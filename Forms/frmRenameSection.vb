Imports System.Windows.Forms

Public Class frmRenameSection

    Dim tmpSectionID As String

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        If Not CheckTextBox(txtNewName, "Please enter then new name for this Section") Then Exit Sub

        If RenameClassSection(txtNewName.Text, tmpSectionID) = TranDBResult.Success Then
            MsgBox("Section successfully renamed..." & vbNewLine & vbNewLine & _
                "Please refresh the List of Class Section", vbInformation)
            Close()

        Else
            MsgBox("Renaming Class Section went failed...", vbInformation)
            Close()
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmRenameSection_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub ShowForm(ByVal OldName As String, ByVal SectionID As String)

        txtOldName.Text = OldName

        tmpSectionID = SectionID

        Me.ShowDialog()
    End Sub

End Class
