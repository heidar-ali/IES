Imports System.Windows.Forms

Public Class frmRegSettings

    Dim sSet As EnrolSettings

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmSettings_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub ShowForm()
        fillCombo(cboCampus, "SELECT CampusName FROM tblCampus ORDER BY CampusID")
        fillCombo(cboCampusID, "SELECT CampusID FROM tblCampus ORDER BY CampusID")

        fillCombo(cboTerm, "SELECT fnAcademicYearTerm(TermID) FROM tblAYTerm ORDER BY TermID")
        fillCombo(cboTermID, "SELECT TermID FROM tblAYTerm ORDER BY TermID")




        Me.ShowDialog()
    End Sub

    Private Sub chkPrerequisite_MouseEnter(sender As System.Object, e As System.EventArgs) Handles chkPrerequisite.MouseEnter
        lblDescription.Text = CheckPreRequisite
    End Sub

    Private Sub chkPrerequisite_MouseLeave(sender As System.Object, e As System.EventArgs) Handles chkPrerequisite.MouseLeave
        lblDescription.Text = ""
    End Sub

    Private Sub SaveSettings()
        sSet.TermID = cboTermID.Text
        sSet.CampusID = cboCampusID.Text



    End Sub

    Private Sub CheckBox3_MouseEnter(sender As System.Object, e As System.EventArgs) Handles chkAllowIncompleteGrades.MouseEnter
        lblDescription.Text = AllowIncomplateGrades
    End Sub

    Private Sub CheckBox3_MouseLeave(sender As System.Object, e As System.EventArgs) Handles chkAllowIncompleteGrades.MouseLeave
        lblDescription.Text = ""
    End Sub

    Private Sub cboTerm_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboTerm.SelectedIndexChanged
        cboTermID.SelectedIndex = cboTerm.SelectedIndex
    End Sub

    Private Sub cboCampus_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboCampus.SelectedIndexChanged
        cboCampusID.SelectedIndex = cboCampus.SelectedIndex
    End Sub
End Class
