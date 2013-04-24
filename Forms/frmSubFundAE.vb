Imports System.Windows.Forms

Public Class frmSubFundAE

    Dim State As FormState
    Dim SFund As tSubFund


    Dim SFundID As String

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub SaveToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles SaveToolStripButton.Click
        Select Case State
            Case FormState.addFormState
                SaveData()
            Case FormState.updateFormState
                UpdateData()
        End Select
    End Sub

    Private Sub SaveData()

        If Not CheckTextBox(txtCode, "Please enter Account Sub Fund/Group Code") Then Exit Sub
        If Not CheckTextBox(txtDescription, "Please enter Account Sub Fund Description") Then Exit Sub

        SFund.SubFundCode = txtCode.Text
        SFund.SubFundName = txtDescription.Text
        SFund.SubFundShortName = txtShortName.Text

        Select Case SaveSubFund(SFund)

            Case TranDBResult.Success
                RefreshToolStripButton_Click(Me, New System.EventArgs)
                NewToolStripButton_Click(Me, New System.EventArgs)

            Case TranDBResult.DuplicateCode
                CatchError("modAccounting", "SaveSubFund", "Sub Fund/Group has already existed in the record..")
                Exit Sub
            Case TranDBResult.Failed
                CatchError("modAccounting", "SaveSubFund", "Unknown Error")
                Exit Sub

        End Select

    End Sub
    Private Sub UpdateData()

        If Not CheckTextBox(txtCode, "Please enter Account Sub Fund/Group Code") Then Exit Sub
        If Not CheckTextBox(txtDescription, "Please enter Account Sub Fund Description") Then Exit Sub

        SFund.SubFundCode = txtCode.Text
        SFund.SubFundName = txtDescription.Text
        SFund.SubFundShortName = txtShortName.Text
        SFund.IndexID = SFundID

        Select Case UpdateSubFund(SFund)

            Case TranDBResult.Success
                RefreshToolStripButton_Click(Me, New System.EventArgs)
                NewToolStripButton_Click(Me, New System.EventArgs)
            Case TranDBResult.DuplicateCode
                CatchError("modAccounting", "UpdateSubFund", "Sub Fund/Group has already existed in the record..")
                Exit Sub
            Case TranDBResult.Failed
                CatchError("modAccounting", "UpdateSubFund", "Unknown Error")
                Exit Sub

        End Select
    End Sub


    Public Sub ShowForm()
        State = FormState.addFormState

        FillListView("SELECT GroupCode,SubGroupName,ShortName,SubGroupID FrOM tblAccountSubGroups", lvSubFund, False)

        Me.ShowDialog()
    End Sub

    Private Sub RefreshToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles RefreshToolStripButton.Click
        FillListView("SELECT GroupCode,SubGroupName,ShortName,SubGroupID FrOM tblAccountSubGroups", lvSubFund, False)
    End Sub

    Private Sub lvSubFund_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lvSubFund.SelectedIndexChanged
        On Error Resume Next

        If lvSubFund.Items.Count > 0 Then
            State = FormState.updateFormState

            txtCode.Text = lvSubFund.FocusedItem.Text
            txtDescription.Text = lvSubFund.FocusedItem.SubItems(1).Text
            txtShortName.Text = lvSubFund.FocusedItem.SubItems(2).Text

            SFundID = lvSubFund.FocusedItem.SubItems(3).Text
        End If
    End Sub

    Private Sub DeleteToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles DeleteToolStripButton.Click
        If lvSubFund.Items.Count > 0 Then
            State = FormState.deleteFormState
            If ExecuteDeleteAccountSubFund(lvSubFund.FocusedItem.SubItems(1).Text) = TranDBResult.Success Then
                RefreshToolStripButton_Click(sender, e)
                NewToolStripButton_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub NewToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles NewToolStripButton.Click
        State = FormState.addFormState

        txtCode.Text = ""
        txtDescription.Text = ""
        txtShortName.Text = ""
        SFundID = ""

        RefreshToolStripButton_Click(sender, e)
    End Sub

    Private Sub frmSubFundAE_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
