Option Explicit On

Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class frmAddSubjectAreas

    Dim SubjectAreaID As String

    Public Sub ShowForm()

        GetNewSubjectAreasID(SubjectAreaID)

        'LoadAreas()

        FillListView("SELECT SubjectAreaName,SubjectAreaID,ShortName FROM tblSubjectAreas", ListView1)
        lblRecordCount.Text = ListView1.Items.Count

        cmdSave.Text = "Save"

        Me.ShowDialog()
    End Sub

    Private Sub LoadAreas()
        Dim com As New MySqlCommand("SELECT * FROM tblSubjectAreas", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        ListView1.Items.Clear()
        While vRS.Read()
            Dim lv As New ListViewItem(vRS("SubjectAreaName").ToString())
            lv.SubItems.Add(vRS("SubjectAreaID").ToString())
            lv.SubItems.Add(vRS("ShortName").ToString())
            ListView1.Items.AddRange(New ListViewItem() {lv})
        End While
        vRS.Close()
        lblRecordCount.Text = ListView1.Items.Count
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        FillListView("SELECT SubjectAreaName,SubjectAreaID,ShortName FROM tblSubjectAreas", ListView1)
        lblRecordCount.Text = ListView1.Items.Count
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If ListView1.Items.Count < 0 Then Exit Sub

        Dim com As New MySqlCommand("DELETE FROM tblSubjectAreas WHERE SubjectAreaID='" & ListView1.FocusedItem.SubItems(1).Text & "'", clsCon.con)
        com.ExecuteNonQuery()

        MsgBox("Record successfully removed", vbInformation)
        FillListView("SELECT SubjectAreaName,SubjectAreaID,ShortName FROM tblSubjectAreas", ListView1)
        lblRecordCount.Text = ListView1.Items.Count

    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.Items.Count < 0 Then Exit Sub

        SubjectAreaID = ListView1.FocusedItem.SubItems(1).Text
        txtSubjectArea.Text = ListView1.FocusedItem.Text
        txtShortName.Text = ListView1.FocusedItem.SubItems(2).Text

        cmdSave.Text = "Update"

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Select Case cmdSave.Text
            Case "Update"
                UpdateData()
            Case Else
                SaveData()
        End Select
    End Sub

    Private Sub SaveData()
        Dim vSubjectArea As tSubjectAreas
        'default
        If Not CheckTextBox(txtSubjectArea, "Please Enter Subject Area") Then
            HLTxt(txtSubjectArea)
            Exit Sub
        End If

        vSubjectArea.SubjectAreaID = SubjectAreaID
        vSubjectArea.SubjectAreaName = txtSubjectArea.Text
        vSubjectArea.ShortName = txtShortName.Text

        Select Case AddSubjectAreas(vSubjectArea)
            Case TranDBResult.Success
                'Success
                MsgBox("Record Successfully Saved", vbInformation)
                FillListView("SELECT SubjectAreaName,SubjectAreaID,ShortName FROM tblSubjectAreas", ListView1)
                lblRecordCount.Text = ListView1.Items.Count

            Case TranDBResult.DuplicateID
                MsgBox("Subject Area ID already exist in the record", vbInformation)
                Exit Sub

            Case TranDBResult.DuplicateTitle
                MsgBox("Invalid Subject Area Name", vbInformation)
                Exit Sub

            Case Else
                MsgBox("Unknown Error", vbExclamation)
                CatchError("frmAddSubjectAreas", "SaveDate()", "Unknown result in Adding New Subject Area")
        End Select

    End Sub

    Private Sub UpdateData()
        Dim vSubjectArea As tSubjectAreas
        'default
        If Not CheckTextBox(txtSubjectArea, "Please Enter Subject Area") Then
            HLTxt(txtSubjectArea)
            Exit Sub
        End If

        vSubjectArea.SubjectAreaID = SubjectAreaID
        vSubjectArea.SubjectAreaName = txtSubjectArea.Text
        vSubjectArea.ShortName = txtShortName.Text

        Select Case EditSubjectAreas(vSubjectArea)
            Case TranDBResult.Success
                'Success
                MsgBox("Record Successfully Updated", vbInformation)
                FillListView("SELECT SubjectAreaName,SubjectAreaID,ShortName FROM tblSubjectAreas", ListView1)
                lblRecordCount.Text = ListView1.Items.Count

            Case Else
                MsgBox("Unknown Error", vbExclamation)
                CatchError("frmAddSubjectAreas", "SaveDate()", "Unknown result in Adding New Subject Area")
        End Select

    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        txtSubjectArea.Text = ""
        txtShortName.Text = ""
        SubjectAreaID = ""
    End Sub

    Private Sub frmAddSubjectAreas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class