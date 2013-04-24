Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frmStudBadAccounts

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmStudBadAccounts_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SaveStudent(ByVal StudentNo As String)

    End Sub

End Class
