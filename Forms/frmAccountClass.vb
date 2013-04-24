Public Class frmAccountClass

    Dim State As FormState
    Dim Clas As tAccountClassification

    Private Sub frmAccountClass_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        FillListView("SELECT ClassCode,ClassName,ShortName FROM tblAccountClass", lvClass, False)
    End Sub

    Private Sub RefreshToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles RefreshToolStripButton.Click
        FillListView("SELECT ClassCode,ClassName,ShortName FROM tblAccountClass", lvClass, False)
    End Sub

    Private Sub NewToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles NewToolStripButton.Click
        txtCode.Text = ""
        txtDescription.Text = ""
        txtShortName.Text = ""
    End Sub

    Private Sub DeleteToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles DeleteToolStripButton.Click
        If lvClass.Items.Count > 0 Then
            If ExecuteDeleteAccountClassification(lvClass.FocusedItem.Text) = TranDBResult.Success Then
                RefreshToolStripButton_Click(sender, e)
            End If
        End If
    End Sub

    Public Sub ShowForm()
        State = FormState.addFormState

        Me.ShowDialog()
    End Sub

    Private Sub SaveData()
        If Not CheckTextBox(txtCode, "Please enter Account Classification Code") Then Exit Sub
        If Not CheckTextBox(txtDescription, "Please enter Account Classification Name/Description") Then Exit Sub

        Clas.ClassCode = txtCode.Text
        Clas.ClassName = txtDescription.Text
        Clas.ShortName = txtShortName.Text

        Select Case SaveAccountClassification(Clas)
            Case TranDBResult.Success
                RefreshToolStripButton_Click(Me, New System.EventArgs)

            Case TranDBResult.DuplicateCode
                MsgBox("Saving Account Classification went failed..." & vbNewLine & vbNewLine & "Account Classification already exist in the record...", vbInformation)
            Case TranDBResult.Failed
                MsgBox("Saving Account Classification went failed..." & vbNewLine & vbNewLine & "Unknown Error occur", vbInformation)
                Exit Sub
        End Select

    End Sub

    Private Sub UpdateData()
        If Not CheckTextBox(txtCode, "Please enter Account Classification Code") Then Exit Sub
        If Not CheckTextBox(txtDescription, "Please enter Account Classification Name/Description") Then Exit Sub

        Clas.ClassCode = txtCode.Text
        Clas.ClassName = txtDescription.Text
        Clas.ShortName = txtShortName.Text

        Select Case SaveAccountClassification(Clas)
            Case TranDBResult.Success
                RefreshToolStripButton_Click(Me, New System.EventArgs)

            Case TranDBResult.DuplicateCode
                MsgBox("Saving Account Classification went failed..." & vbNewLine & vbNewLine & "Account Classification already exist in the record...", vbInformation)
            Case TranDBResult.Failed
                MsgBox("Saving Account Classification went failed..." & vbNewLine & vbNewLine & "Unknown Error occur", vbInformation)
                Exit Sub
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

    Private Sub lvClass_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lvClass.SelectedIndexChanged
        On Error Resume Next
        State = FormState.updateFormState

        txtCode.Text = lvClass.FocusedItem.Text
        txtDescription.Text = lvClass.FocusedItem.SubItems(1).Text
        txtShortName.Text = lvClass.FocusedItem.SubItems(2).Text
    End Sub
End Class