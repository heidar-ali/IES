Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frmAddDepartment
    Dim RecordAdded As Boolean
    Dim sNewID As Integer
    Dim currentDepartment As tDepartment

    Dim RecordEdited As Boolean

    Public Function ShowForm() As Boolean

        GetNewDepartmentID(txtDepartmentID.Text)
        '--------------------------------------------------
        'show form
        Me.ShowDialog()
        'return
        ShowForm = RecordAdded

    End Function
    Public Function ShowEdit(ByVal sDepartmentCode As String) As Boolean

        Dim vCollege As tCollege
        Dim vCamp As tSchool
        '-------------------------------------------------------
        'check user access
        '-------------------------------------------------------
        If UserAllowedTo(CurrentUser.UserName, sCanEditDepartment) = False Then
            MsgBox("Unable to continue editing Department entry." & vbNewLine & vbNewLine & _
                    "You are not permitted to do this. Please contact your administrator for more information.", vbExclamation)
            Exit Function
        End If
        '-------------------------------------------------------



        If GetDepartmentByCode(sDepartmentCode, currentDepartment) <> True Then
            MsgBox("Unable to continue editing Department Information: Department not found!", vbCritical)
            Exit Function
        End If


        'ready for edit
        'set data

        txtDepartmentID.Text = currentDepartment.DepartmentID
        txtDepartmentTitle.Text = currentDepartment.DepartmentTitle
        txtCode.Text = currentDepartment.DepartmentCode
        txtShortName.Text = currentDepartment.ShortName




        If GetCollegeByID(currentDepartment.CollegeID, vCollege) = TranDBResult.Success Then
            cboCollege.SelectedIndex = cboCollege.Items.IndexOf(vCollege.CollegeName)
        End If

        OK_Button.Text = "Update"
        'show form
        Me.ShowDialog()



        'return
        ShowEdit = RecordEdited


    End Function
    
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Select Case OK_Button.Text
            Case "Update"
                SaveData()
            Case Else
                SaveNewDepartment()
        End Select

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub SaveNewDepartment()

        If cboCampus.Text = "" Then Exit Sub
        cboCampus.Focus()

        If cboCollege.Text = "" Then Exit Sub
        cboCollege.Focus()

        If Not CheckTextBox(txtDepartmentID, "Please enter Department ID") Then
            Exit Sub
        End If

        If Not CheckTextBox(txtDepartmentTitle, "Please enter Department Title") Then
            Exit Sub
        End If


        'save
        Dim newDepartment As tDepartment

        newDepartment.DepartmentID = txtDepartmentID.Text
        newDepartment.DepartmentTitle = txtDepartmentTitle.Text
        newDepartment.ShortName = txtShortName.Text
        newDepartment.CampusID = cboCampusID.Text
        newDepartment.CollegeID = cboCollege.SelectedItem.Col2
        newDepartment.DepartmentCode = txtCode.Text

        Select Case AddDepartment(newDepartment)
            Case TranDBResult.Success  'success
                MsgBox("New Department succesfully added", vbInformation)
                RecordAdded = True
                Close()

            Case TranDBResult.DuplicateID
                MsgBox("Invalid Department ID!" & vbNewLine & "The Department ID that you have entered is already existed. Enter another Department ID.", vbExclamation)
                HLTxt(txtDepartmentID)

            Case TranDBResult.DuplicateTitle

                MsgBox("Invalid Department Title!" & vbNewLine & "The Department Title that you have entered is already existed. Enter another Department Title.", vbExclamation)
                HLTxt(txtDepartmentTitle)

            Case Else
                MsgBox("Unknown Error", vbExclamation)
                CatchError("frmAddDepartment", "SaveNewDepartment", "Unknown result in Add New Department")
        End Select


    End Sub
    Private Sub SaveData()

        If cboCampus.Text = "" Then Exit Sub
        cboCampus.Focus()

        If cboCollege.Text = "" Then Exit Sub
        cboCollege.Focus()

        If Not CheckTextBox(txtDepartmentID, "Enter Department ID." & vbNewLine & " This field is required") Then
            Exit Sub
        End If

        If Not CheckTextBox(txtDepartmentTitle, "Enter Department Title." & vbNewLine & " This field is required") Then
            Exit Sub
        End If


        'save
        Dim newDepartment As tDepartment

        newDepartment.DepartmentID = txtDepartmentID.Text
        newDepartment.DepartmentTitle = txtDepartmentTitle.Text

        newDepartment.ShortName = txtShortName.Text
        newDepartment.CampusID = cboCampusID.Text
        newDepartment.CollegeID = cboCollege.SelectedItem.Col2

        newDepartment.DepartmentCode = txtCode.Text

        Select Case EditDepartment(newDepartment)
            Case TranDBResult.Success

                MsgBox("Department Information was successfully edited", vbInformation)

                'set flag
                RecordEdited = True

                'close this form
                Close()

            Case TranDBResult.DuplicateTitle
                MsgBox("The Department Title that you have enetered was already existed." & vbNewLine & " Enter another Duplicate Title", vbExclamation)
                HLTxt(txtDepartmentTitle)

            Case Else
                MsgBox("UNKNOWN: Editing Department", vbCritical)
        End Select


    End Sub

    Private Sub cboCampus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCampus.SelectedIndexChanged
        cboCampusID.SelectedIndex = cboCampus.SelectedIndex

        fillMultiColumnCombo2(cboCollege, "SELECT CollegeName,CollegeID FROM tblColleges WHERE CampusID='" & cboCampusID.Text & "'")
        'fillCombo(cboCollegeID, "SELECT CollegeID FROM tblColleges WHERE CampusID='" & cboCampusID.Text & "'")
    End Sub

    Private Sub cboCollege_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'cboCollegeID.SelectedIndex = cboCollege.SelectedIndex
    End Sub

    Private Sub frmAddDepartment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        fillCombo(cboCampus, "SELECT ShortName FROM tblCampus")
        fillCombo(cboCampusID, "SELECT CampusID FROM tblCampus")

    End Sub
End Class
