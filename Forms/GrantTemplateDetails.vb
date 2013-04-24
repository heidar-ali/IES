Imports System.Windows.Forms

Public Class GrantTemplateDetails

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub GrantTemplateDetails_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub ShowForm(ByVal GrantTemplateID As String)
        Dim sum As Decimal

        FillListView("SELECT fnAccountName(AcctID),AcctID,Amount,Percentage FROM tblSchoGrantTemplate_Details WHERE GrantTemplateID='" & GrantTemplateID & "'", lvGrantDetails, False)
        For Each lv As ListViewItem In lvGrantDetails.Items
            sum += (lv.SubItems(2).Text)
        Next
        Label2.Text = "PHP " & sum.ToString("#,##0.00")
        Me.ShowDialog()
    End Sub

End Class
