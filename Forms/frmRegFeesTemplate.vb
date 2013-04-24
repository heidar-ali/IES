Imports System.Windows.Forms

Public Class frmRegFeesTemplate

    Dim tmpTemplateID As String
    Dim tmpTemplate As String

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        'ReturnValues()
        Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        CancelValues()
    End Sub

    Private Sub frmFeesTemplate_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        fillToolStripCombo(cboAY, "SELECT fnAcademicYearTerm(TermID) FROM tblAYTerm")
        fillToolStripCombo(cboAYID, "SELECT TermID FROM tblAYTerm")

        cboAY.SelectedIndex = Conf.TermID
    End Sub

    Public Sub ShowForm()

        Me.ShowDialog()
    End Sub

    Private Sub cboAY_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboAY.SelectedIndexChanged
        cboAYID.SelectedIndex = cboAY.SelectedIndex

        FillListView("SELECT TemplateCode,TemplateID FROM tblTableOfFees WHERE SchoolYear='" & cboAYID.Text & "'", lvFeesTemplate, False)
        lblNoOfTemplates.Text = lvFeesTemplate.Items.Count
    End Sub

    Private Sub lvFeesTemplate_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lvFeesTemplate.SelectedIndexChanged
        If lvFeesTemplate.Items.Count > 0 Then

            lblTemplate.Text = "FEES TEMPLATE - " & lvFeesTemplate.FocusedItem.Text

            FillListView("SELECT A.AcctCode,A.AcctName,A.ShortName, TD.Amount FROM tblAccounts A INNER JOIN tblTableOfFee_Details TD ON A.AcctID = TD.AccountID WHERE TD.TemplateID='" & lvFeesTemplate.FocusedItem.SubItems(1).Text & "'", lvDetails, False)

            lblNoAccount.Text = lvDetails.Items.Count

            Dim sum As Decimal

            For Each lv As ListViewItem In lvDetails.Items
                sum += lv.SubItems(3).Text
            Next
            lblAmount.Text = sum.ToString("#,##0.00")
        End If
    End Sub

    Private Sub ReturnValues()
        If lvFeesTemplate.Items.Count > 0 Then
            tmpTemplateID = lvFeesTemplate.FocusedItem.SubItems(1).Text
            tmpTemplate = lvFeesTemplate.FocusedItem.Text

            Close()
        End If
    End Sub

    Private Sub CancelValues()
        tmpTemplate = ""
        tmpTemplateID = ""

        Close()
    End Sub

    Private Sub cboAY_Click(sender As System.Object, e As System.EventArgs) Handles cboAY.Click

    End Sub
End Class
