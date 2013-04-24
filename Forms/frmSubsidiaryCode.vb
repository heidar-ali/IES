Imports System.Windows.Forms

Public Class frmSubsidiaryCode

    Dim Subs As tSubsidiaryCode
    Dim State As FormState

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub RefreshToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles RefreshToolStripButton.Click
        FillListView("SELECT SubCode,SubDescription,ShortName FROM tblSubsidiaryCode", ListView1, False)
    End Sub

    Private Sub frmSubsidiaryCode_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        FillListView("SELECT SubCode,SubDescription,ShortName FROM tblSubsidiaryCode", ListView1, False)
    End Sub

    Private Sub NewToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles NewToolStripButton.Click
        txtCode.Text = ""
        txtDescription.Text = ""
        txtShortName.Text = ""

        State = FormState.addFormState
    End Sub

    Private Sub DeleteToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles DeleteToolStripButton.Click
        If ListView1.Items.Count > 0 Then
            ExecuteDeleteSubsidiaryCode(ListView1.FocusedItem.Text)
        End If
    End Sub

    Private Sub SaveToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles SaveToolStripButton.Click
        Select Case State
            Case FormState.addFormState

            Case FormState.updateFormState

        End Select
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        On Error Resume Next

        State = FormState.updateFormState

        txtCode.Text = ListView1.FocusedItem.Text
        txtDescription.Text = ListView1.FocusedItem.SubItems(1).Text
        txtShortName.Text = ListView1.FocusedItem.SubItems(2).Text

    End Sub
End Class
