Option Explicit On

Public Class frmAccountGL
    Dim GL As tAccountGLCode
    Dim State As FormState

    Dim GLID As String

    Private Sub frmAccountGL_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RefreshToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles RefreshToolStripButton.Click
        FillListView("SELECT GLCode,GLName,GLShort,GLID FROM tblAccountGLCodes ORDER BY GLID", lvGLCode, False)
    End Sub

    Private Sub SaveData()

        If Not CheckTextBox(txtCode, "Please enter Account GL Code") Then Exit Sub
        If Not CheckTextBox(txtDescription, "Please enter Account GL Code Name/Description") Then Exit Sub

        GL.GLCode = txtCode.Text
        GL.GLName = txtDescription.Text
        GL.ShortName = txtShortName.Text

        Select Case SaveAccountGLCode(GL)
            Case TranDBResult.Success
                MsgBox("Record successfully saved", vbInformation)
                RefreshToolStripButton_Click(Me, New System.EventArgs)
                NewToolStripButton_Click(Me, New System.EventArgs)

            Case TranDBResult.DuplicateCode
                MsgBox("Saving Account GL went failed..." & vbNewLine & vbNewLine & "Account GL Code already exist in the record...", vbInformation)
                Exit Sub
            Case TranDBResult.Failed
                MsgBox("Saving Account GL went failed..." & vbNewLine & vbNewLine & "Unknown Error occur", vbInformation)
                Exit Sub
        End Select
    End Sub

    Private Sub UpdateData()

        If Not CheckTextBox(txtCode, "Please enter Account GL Code") Then Exit Sub
        If Not CheckTextBox(txtDescription, "Please enter Account GL Code Name/Description") Then Exit Sub

        GL.GLCode = txtCode.Text
        GL.GLName = txtDescription.Text
        GL.ShortName = txtShortName.Text
        GL.IndexID = GLID

        Select Case UpdateAccountGLCode(GL)
            Case TranDBResult.Success
                MsgBox("Record successfully updated", vbInformation)
                RefreshToolStripButton_Click(Me, New System.EventArgs)
                NewToolStripButton_Click(Me, New System.EventArgs)

            Case TranDBResult.DuplicateCode
                MsgBox("Updating Account GL went failed..." & vbNewLine & vbNewLine & "Account GL Code already exist in the record...", vbInformation)
                Exit Sub
            Case TranDBResult.Failed
                MsgBox("Updating Account GL went failed..." & vbNewLine & vbNewLine & "Unknown Error occur", vbInformation)
                Exit Sub
        End Select

    End Sub


    Public Sub ShowForm()
        Me.State = FormState.addFormState
        FillListView("SELECT GLCode,GLName,GLShort,GLID FROM tblAccountGLCodes ORDER BY GLID", lvGLCode, False)
        Me.ShowDialog()
    End Sub


    Private Sub NewToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles NewToolStripButton.Click
        txtCode.Text = ""
        txtDescription.Text = ""
        txtShortName.Text = ""
        GLID = ""

        State = FormState.addFormState

        RefreshToolStripButton_Click(sender, e)
    End Sub

    Private Sub SaveToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles SaveToolStripButton.Click
        Select Case State
            Case FormState.addFormState
                SaveData()
            Case FormState.updateFormState
                UpdateData()
        End Select
    End Sub

    Private Sub DeleteToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles DeleteToolStripButton.Click
        If lvGLCode.Items.Count > 0 Then
            If ExecuteDeleteAccountGLCode(lvGLCode.FocusedItem.SubItems(3).Text) = TranDBResult.Success Then
                RefreshToolStripButton_Click(sender, e)
                NewToolStripButton_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub lvGLCode_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lvGLCode.SelectedIndexChanged
        'On Error Resume Next

        If lvGLCode.Items.Count > 0 Then

            State = FormState.updateFormState

            txtCode.Text = lvGLCode.FocusedItem.Text
            txtDescription.Text = lvGLCode.FocusedItem.SubItems(1).Text
            txtShortName.Text = lvGLCode.FocusedItem.SubItems(2).Text

            GLID = lvGLCode.FocusedItem.SubItems(3).Text

        End If
    End Sub
End Class