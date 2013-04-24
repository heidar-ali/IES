Imports System.Windows.Forms

Public Class frmAccountType

    Dim State As FormState
    Dim Types As tAccountCategory

    Dim TypeID As String

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmAccountType_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub ShowForm()
        State = FormState.addFormState
        FillListView("SELECT CategoryCode,CategoryName,CategoryShort,CategoryID FROM tblAccountsCategory", ListView1, False)

        NewToolStripButton_Click(Me, New System.EventArgs)
        Me.ShowDialog()
    End Sub


    Private Sub RefreshToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles RefreshToolStripButton.Click
        FillListView("SELECT CategoryCode,CategoryName,CategoryShort,CategoryID FROM tblAccountsCategory", ListView1, False)
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        On Error Resume Next
        If ListView1.Items.Count > 0 Then
            State = FormState.updateFormState

            txtCode.Text = ListView1.FocusedItem.Text
            txtDescription.Text = ListView1.FocusedItem.SubItems(1).Text
            txtShortName.Text = ListView1.FocusedItem.SubItems(2).Text

            TypeID = ListView1.FocusedItem.SubItems(3).Text

        End If
    End Sub

    Private Sub DeleteToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles DeleteToolStripButton.Click
        If ListView1.Items.Count > 0 Then
            If ExecuteDeleteAccountCategory(ListView1.FocusedItem.Text) = TranDBResult.Success Then
                RefreshToolStripButton_Click(sender, e)
            End If
        End If
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
        If Not CheckTextBox(txtCode, "Please enter Account Category Code") Then HLTxt(txtCode) : Exit Sub
        If Not CheckTextBox(txtDescription, "Please enter Account Category Description") Then HLTxt(txtDescription) : Exit Sub

        Types.ShortName = txtShortName.Text
        Types.TypeName = txtDescription.Text
        Types.TypeCode = txtCode.Text

        Select Case SaveAccountCategory(Types)
            Case TranDBResult.Success
                RefreshToolStripButton_Click(Me, New System.EventArgs)
                NewToolStripButton_Click(Me, New System.EventArgs)

            Case TranDBResult.DuplicateCode
                CatchError("modAccounting", "SaveAccountCategory", "There is an error occur when saving Account Category..." & vbNewLine & "Account Category already exist in the record")
                Exit Sub

            Case TranDBResult.Failed
                CatchError("modAccounting", "SaveAccountCategory", "Unknown Error Occur")
                Exit Sub
        End Select
    End Sub

    Private Sub UpdateData()
        If Not CheckTextBox(txtCode, "Please enter Account Category Code") Then HLTxt(txtCode) : Exit Sub
        If Not CheckTextBox(txtDescription, "Please enter Account Category Description") Then HLTxt(txtDescription) : Exit Sub

        Types.ShortName = txtShortName.Text
        Types.TypeName = txtDescription.Text
        Types.TypeCode = txtCode.Text
        Types.IndexID = TypeID

        Select Case UpdateAccountCategory(TypeID, Types)
            Case TranDBResult.Success
                RefreshToolStripButton_Click(Me, New System.EventArgs)
                NewToolStripButton_Click(Me, New System.EventArgs)

            Case TranDBResult.DuplicateCode
                CatchError("modAccounting", "UpdateAccountCategory", "There is an error occur when saving Account Category..." & vbNewLine & "Account Category already exist in the record")
                Exit Sub

            Case TranDBResult.Failed
                CatchError("modAccounting", "UpdateAccountCategory", "Unknown Error Occur")
                Exit Sub
        End Select
    End Sub


    Private Sub NewToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles NewToolStripButton.Click
        txtCode.Text = ""
        txtDescription.Text = ""
        txtShortName.Text = ""
        TypeID = ""

        State = FormState.addFormState
    End Sub
End Class
