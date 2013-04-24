Imports System.Windows.Forms

Public Class frmAccountDepartment

    Dim Dept As tAccountDepartment
    Dim State As FormState

    Dim DeptID As String


    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Public Sub ShowForm()
        State = FormState.addFormState

        FillListView("SELECT DeptCode,DeptName,DeptShort,DeptID FROM tblAccountDepartment", lvDepartment, False)

        Me.ShowDialog()
    End Sub

    Private Sub SaveToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles SaveToolStripButton.Click
        Select Case State
            Case FormState.addFormState
                SaveData()
            Case FormState.updateFormState
                UpdateData()
        End Select
    End Sub

    Private Sub NewToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles NewToolStripButton.Click
        State = FormState.addFormState
        txtCode.Text = ""
        txtDescription.Text = ""
        txtShortName.Text = ""

        RefreshToolStripButton_Click(sender, e)
    End Sub

    Private Sub lvDepartment_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lvDepartment.SelectedIndexChanged
        On Error Resume Next
        If lvDepartment.Items.Count > 0 Then
            txtCode.Text = lvDepartment.FocusedItem.Text
            txtDescription.Text = lvDepartment.FocusedItem.SubItems(1).Text
            txtShortName.Text = lvDepartment.FocusedItem.SubItems(2).Text
            DeptID = lvDepartment.FocusedItem.SubItems(3).Text
        End If
    End Sub

    Private Sub RefreshToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles RefreshToolStripButton.Click
        FillListView("SELECT DeptCode,DeptName,DeptShort,DeptID FROM tblAccountDepartment", lvDepartment, False)
    End Sub

    Private Sub DeleteToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles DeleteToolStripButton.Click
        If lvDepartment.Items.Count > 0 Then
            If ExecuteDeleteAccountDepartment(DeptID) = TranDBResult.Success Then
                RefreshToolStripButton_Click(sender, e)
                NewToolStripButton_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub SaveData()
        If Not CheckTextBox(txtCode, "Please enter Account Department Code") Then HLTxt(txtCode) : Exit Sub
        If Not CheckTextBox(txtDescription, "Please enter Account Department Name/Description") Then HLTxt(txtDescription) : Exit Sub

        Dept.DeptCode = txtCode.Text
        Dept.DeptName = txtDescription.Text
        Dept.ShortName = txtShortName.Text

        Select Case SaveAccountDepartment(Dept)
            Case TranDBResult.Success
                RefreshToolStripButton_Click(Me, New System.EventArgs)
                NewToolStripButton_Click(Me, New System.EventArgs)

            Case TranDBResult.DuplicateCode
                CatchError("modAccounting", "SaveAccountDepartment", "Unable to Save Account Department - Account Department already exist in the record")
                Exit Sub
            Case TranDBResult.Failed
                CatchError("modAccounting", "SaveAccountDepartment", "Unable to Save Account Department - Unknown error occur")
                Exit Sub
        End Select
    End Sub

    Private Sub UpdateData()
        If Not CheckTextBox(txtCode, "Please enter Account Department Code") Then HLTxt(txtCode) : Exit Sub
        If Not CheckTextBox(txtDescription, "Please enter Account Department Name/Description") Then HLTxt(txtDescription) : Exit Sub

        Dept.DeptCode = txtCode.Text
        Dept.DeptName = txtDescription.Text
        Dept.ShortName = txtShortName.Text
        Dept.IndexID = DeptID

        Select Case UpdateAccountDepartment(Dept)
            Case TranDBResult.Success
                RefreshToolStripButton_Click(Me, New System.EventArgs)
                NewToolStripButton_Click(Me, New System.EventArgs)

            Case TranDBResult.DuplicateCode
                CatchError("modAccounting", "UpdateAccountDepartment", "Unable to updated Account Department - Account Department already exist in the record")
                Exit Sub
            Case TranDBResult.Failed
                CatchError("modAccounting", "UpdateAccountDepartment", "Unable to update Account Department - Unknown error occur")
                Exit Sub
        End Select
    End Sub

End Class
