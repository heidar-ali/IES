Imports System.Windows.Forms

Public Class frmPromisoryNote

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub NewToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles NewToolStripButton.Click
        Dim frm As New frmPromissoryNoteAE
        frm.ShowDialog()
    End Sub
End Class
