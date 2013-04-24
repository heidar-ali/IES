Imports System.Windows.Forms

Public Class frmFundGroups

    Dim Fund As tFundGroups
    Dim State As FormState

    Dim sFundID As String

   
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmFundGroups_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
    Public Sub ShowForm()
        State = FormState.addFormState
        FillListView("SELECT GroupCode,GroupName,GroupShort,GroupID FROM tblAccountGroups", lvFund, False)

        Me.ShowDialog()
    End Sub

    Private Sub RefreshToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles RefreshToolStripButton.Click
        FillListView("SELECT GroupCode,GroupName,GroupShort,GroupID FROM tblAccountGroups", lvFund, False)
    End Sub

    Private Sub DeleteToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles DeleteToolStripButton.Click
        If lvFund.Items.Count > 0 Then
            State = FormState.deleteFormState
            If ExecuteDeleteAccountFund(lvFund.FocusedItem.SubItems(3).Text) = TranDBResult.Success Then
                RefreshToolStripButton_Click(sender, e)
                NewToolStripButton_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub lvFund_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lvFund.SelectedIndexChanged
        On Error Resume Next

        If lvFund.Items.Count > 0 Then
            State = FormState.updateFormState

            txtCode.Text = lvFund.FocusedItem.Text
            txtDescription.Text = lvFund.FocusedItem.SubItems(1).Text
            txtShortName.Text = lvFund.FocusedItem.SubItems(2).Text
            sFundID = lvFund.FocusedItem.SubItems(3).Text
        End If
    End Sub

    Private Sub NewToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles NewToolStripButton.Click
        txtCode.Text = ""
        txtDescription.Text = ""
        txtShortName.Text = ""

        sFundID = ""

        State = FormState.addFormState
    End Sub

    Private Sub SaveData()
        If Not CheckTextBox(txtCode, "Please enter Account Fund/Group Code") Then Exit Sub
        If Not CheckTextBox(txtDescription, "Please enter Account Fund/Group Description") Then Exit Sub

        Fund.GroupCode = txtCode.Text
        Fund.GroupName = txtDescription.Text
        Fund.ShortName = txtShortName.Text

        Select Case SaveAccountFund(Fund)
            Case TranDBResult.Success
                RefreshToolStripButton_Click(Me, New System.EventArgs())
                NewToolStripButton_Click(Me, New System.EventArgs)

            Case TranDBResult.DuplicateCode
                MsgBox("There is an error occur while saving Account Funds..." & vbNewLine & "FUND CODE already exists in the record", vbExclamation)
                Exit Sub

            Case TranDBResult.Failed
                CatchError("ModAccounting", "SaveAccountFund", "There is an error while saving Account Funds..." & vbNewLine & "")
        End Select
    End Sub

    Private Sub UpdateData()
        If Not CheckTextBox(txtCode, "Please enter Account Fund/Group Code") Then Exit Sub
        If Not CheckTextBox(txtDescription, "Please enter Account Fund/Group Description") Then Exit Sub

        Fund.GroupCode = txtCode.Text
        Fund.GroupName = txtDescription.Text
        Fund.ShortName = txtShortName.Text
        Fund.ShortName = sFundID

        Select Case UpdateAccountFund(Fund)
            Case TranDBResult.Success
                RefreshToolStripButton_Click(Me, New System.EventArgs())
                NewToolStripButton_Click(Me, New System.EventArgs)
            Case TranDBResult.DuplicateCode
                MsgBox("There is an error occur while saving Account Funds..." & vbNewLine & "FUND CODE already exists in the record", vbExclamation)
                Exit Sub

            Case TranDBResult.Failed
                CatchError("ModAccounting", "UpdateAccountFund", "There is an unknown error occur while saving Account Funds..." & vbNewLine & "")
        End Select
    End Sub

    Private Sub SaveToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles SaveToolStripButton.Click
        Select Case State
            Case FormState.addFormState
                SaveData()
            Case FormState.updateFormState
                UpdateData()
        End Select
    End Sub
End Class
