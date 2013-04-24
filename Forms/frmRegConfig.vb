Public Class frmRegConfig

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub frmRegConfig_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        fillCombo(cboAYTerm, "SELECT fnAcademicYearTerm(TermID) FROM tblAYTerm")
        fillCombo(cboAYTermID, "SELECT TermID FROM tblAYTerm")
    End Sub

    Private Sub cboAYTerm_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboAYTerm.SelectedIndexChanged
        cboAYTermID.SelectedIndex = cboAYTerm.SelectedIndex
    End Sub
End Class