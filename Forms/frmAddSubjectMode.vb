Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frmAddSubjectMode

    Dim SubjectMode As String

    Public Sub ShowForm()

        GetNewSubjectModeID(SubjectMode)

        'LoadAreas()
        FillListView("SELECT Description,SubjectMode,ShortName FROM tblSubjectMode", ListView1)

        lblRecordCount.Text = ListView1.Items.Count

        cmdSave.Text = "Save"

        Me.ShowDialog()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
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
        Dim vSubjectArea As tSubjectMode
        'default
        If Not CheckTextBox(txtSubjectMode, "Please Enter Subject Mode") Then
            HLTxt(txtSubjectMode)
            Exit Sub
        End If

        vSubjectArea.SubjectMode = SubjectMode
        vSubjectArea.Description = txtSubjectMode.Text
        vSubjectArea.ShortName = txtShortName.Text

        Select Case AddSubjectMode(vSubjectArea)
            Case TranDBResult.Success
                'Success
                MsgBox("Record Successfully Saved", vbInformation)
                FillListView("SELECT SubjectMode,SubjectAreasID,ShortName FROM tblSubjectMode", ListView1)
                lblRecordCount.Text = ListView1.Items.Count

            Case TranDBResult.DuplicateID
                MsgBox("Subject Mode already exist in the record", vbInformation)
                Exit Sub

            Case TranDBResult.DuplicateTitle
                MsgBox("Invalid Subject Mode Name", vbInformation)
                Exit Sub

            Case Else
                MsgBox("Unknown Error", vbExclamation)
                CatchError("frmAddSubjectMode", "SaveData()", "Unknown result in Adding New Subject Mode")
        End Select

    End Sub

    Private Sub UpdateData()
        Dim vSubjectArea As tSubjectMode
        'default
        If Not CheckTextBox(txtSubjectMode, "Please Enter Subject Mode") Then
            HLTxt(txtSubjectMode)
            Exit Sub
        End If

        vSubjectArea.SubjectMode = SubjectMode
        vSubjectArea.Description = txtSubjectMode.Text
        vSubjectArea.ShortName = txtShortName.Text

        Select Case EditSubjectMode(vSubjectArea)
            Case TranDBResult.Success
                'Success
                MsgBox("Record Successfully Updated", vbInformation)
                FillListView("SELECT Description,SubjectMode,ShortName FROM tblSubjectMode", ListView1)
                lblRecordCount.Text = ListView1.Items.Count

            Case Else
                MsgBox("Unknown Error", vbExclamation)
                CatchError("frmAddSubjectMode", "UpdateData()", "Unknown result in Updating New Subject Mode")
        End Select

    End Sub
    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If ListView1.Items.Count < 0 Then Exit Sub

        Dim com As New MySqlCommand("DELETE FROM tblSubjectMode WHERE SubjectMode='" & ListView1.FocusedItem.SubItems(1).Text & "'", clsCon.con)
        com.ExecuteNonQuery()

        MsgBox("Record successfully removed", vbInformation)
        FillListView("SELECT Description,SubjectMode,ShortName FROM tblSubjectMode", ListView1)
        lblRecordCount.Text = ListView1.Items.Count

    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        FillListView("SELECT Description,SubjectMode,ShortName FROM tblSubjectMode", ListView1)
        lblRecordCount.Text = ListView1.Items.Count
    End Sub
End Class
