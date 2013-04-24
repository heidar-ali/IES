Imports System.Windows.Forms

Public Class frmMajorGroupAE
    Dim GroupID As String

    Public Sub ShowForm()

        GetNewMajorGroupID(GroupID)

        OK_Button.Text = "Save"

        Me.ShowDialog()
    End Sub

    Public Sub ShowEdit(ByVal MajorGroupCode As String)
        Dim vMajor As tMajorGroups

        If GetMajorGroupByCode(MajorGroupCode, vMajor) <> TranDBResult.Success Then
            MsgBox("Unable to continue editing.." & vbNewLine & " Specified Major Discipline Group does not exist in records.", vbExclamation)
            Exit Sub
        End If

        txtDescription.Text = vMajor.Description
        txtGroupCode.Text = vMajor.GroupCode
        GroupID = vMajor.GroupID

        OK_Button.Text = "Update"

        Me.ShowDialog()
    End Sub
    Private Function SaveData() As Boolean
        Dim vGroup As tMajorGroups

        SaveData = False

        If Not CheckTextBox(txtGroupCode, "Please Enter Group Code") Then Exit Function

        If Not CheckTextBox(txtDescription, "Please Group Description") Then Exit Function

        vGroup.GroupID = GroupID
        vGroup.GroupCode = txtGroupCode.Text
        vGroup.Description = txtDescription.Text

        Select Case AddMajorGroup(vGroup)
            Case TranDBResult.Success
                MsgBox("Record Successfully Saved", vbInformation)
                SaveData = True
                Close()

            Case TranDBResult.DuplicateID
                MsgBox("Unable to save entry. Duplicate Group ID found", vbExclamation)
                SaveData = False
                Exit Function

            Case TranDBResult.DuplicateCode
                MsgBox("Unable to save entry. Duplicate Group Code found", vbExclamation)
                SaveData = False
                Exit Function

            Case TranDBResult.Failed
                CatchError("frmMajorGroup", "SaveData()", "Unknown Error")
                Exit Function
        End Select
    End Function

    Private Function UpdateData() As Boolean
        Dim vGroup As tMajorGroups

        UpdateData = False

        If Not CheckTextBox(txtGroupCode, "Please Enter Group Code") Then
            CatchError("frmMajorGroupAE", "UpdateDate", "txtGroupCode Check Textbox Error")
            Exit Function
        End If


        If Not CheckTextBox(txtDescription, "Please Group Description") Then
            CatchError("frmMajorGroupAE", "UpdateData", "txtDescription Check Textbox Error")
            Exit Function
        End If

        vGroup.GroupID = GroupID
        vGroup.GroupCode = txtGroupCode.Text
        vGroup.Description = txtDescription.Text

        Select Case EditMajorGroup(vGroup)

            Case TranDBResult.Success
                MsgBox("Record Successfully Updated", vbInformation)
                UpdateData = True
                Close()

            Case TranDBResult.Failed
                CatchError("frmMajorGroup", "SaveData()", "Unknown Error")
                Exit Function

        End Select

    End Function


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Select Case OK_Button.Text
            Case "Update"
                UpdateData()
            Case Else
                SaveData()
        End Select
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
