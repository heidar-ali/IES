Option Explicit On
Imports MySql.Data.MySqlClient

Public Class frmBuildingAE


    Private Sub frmBuildingAE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetNewBuildingID(TextBox1.Text)
        fillCombo(cboCampus, "SELECT Acronym FROM tblSchool LIMIT 1")
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim newBuilding As vBuilding
        Dim Camp As tSchool

        If Not CheckTextBox(txtBuildingName, "Please enter Building Name") Then
            Exit Sub
        End If

        If Not CheckTextBox(txtAcronym, "Please enter Building's Acronym") Then
            Exit Sub
        End If

        If GetCampusByAcronym(cboCampus.Text, Camp) <> TranDBResult.Success Then
            CatchError("frmBuilding", "cmdSave_Click", "Unknown Error")
            Exit Sub
        End If

        newBuilding.CampusID = Camp.CampusID
        newBuilding.BldgName = txtBuildingName.Text
        newBuilding.BldgID = CInt(TextBox1.Text)
        newBuilding.Acronym = txtAcronym.Text
        newBuilding.OtherName = txtOtherName.Text
        newBuilding.IsLAN = BooleanToInt(chkLan.CheckState)
        newBuilding.Floors = CInt(txtFloor.Text)

        Select Case AddBuilding(newBuilding)
            Case TranDBResult.Success  'success
                MsgBox("New Building succesfully added", vbInformation)
                Close()

            Case TranDBResult.DuplicateFullName
                MsgBox("Unable to save entry building name already exist in record", vbExclamation)
                HLTxt(txtBuildingName)

            Case TranDBResult.DuplicateTitle
                MsgBox("The Building Alias Name that you have entered is already existed. Enter another Building Alias Name.", vbExclamation)
                HLTxt(txtOtherName)

            Case TranDBResult.DuplicateLoginName
                MsgBox("Unable to save entry building Acronym already exist in record", vbExclamation)
                HLTxt(txtAcronym)

            Case Else
                MsgBox("Unknown Error", vbExclamation)
                CatchError("frmAddDepartment", "SaveNewDepartment", "Unknown result in Add New Department")
        End Select
    End Sub

    Private Sub button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button3.Click
        Close()
    End Sub
End Class