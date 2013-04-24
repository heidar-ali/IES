Imports System.Windows.Forms

Public Class frmAssignedTeacher

    Dim tmpSection As String
    Dim tmpCampusID As String

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If AssignClassAddviserOnSection(cboFAc.SelectedItem.Col2, tmpSection, tmpCampusID) = TranDBResult.Success Then
            MsgBox("Faculty successfully assign as Class Adviser", vbInformation)
            Close()
        Else
            MsgBox("Assigning faculty went failed. " & vbNewLine & "Unknown Error occur...", vbExclamation)
            Exit Sub
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmAssignedTeacher_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub


    Public Sub ShowForm(ByVal CampusID As String, ByVal SectionID As String)

        fillMultiColumnCombo2(cboFAc, "SELECT fnEmployeeName(EmployeeID),EmployeeID FROM tblEmployees WHERE CampusID='" & CampusID & "'")

        tmpSection = SectionID
        tmpCampusID = CampusID

        Me.ShowDialog()
    End Sub
End Class
