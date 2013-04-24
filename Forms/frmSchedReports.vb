Imports System.Windows.Forms

Public Class frmSchedReports

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmListOfReports_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        fillMultiColumnCombo2(cboTerm, "SELECT CONCAT(SchoolYear,'-',SchoolTerm), TermID FROM tblAYTerm")
        fillMultiColumnCombo2(cboTerm, "SELECT CampusName,CampusID FROM tblCampus")
    End Sub
End Class
