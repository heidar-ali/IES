Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frmModClassLimit

    Dim tmpSectionID As String
    Dim tmpOfferingID As String

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        If txtLimit.Text = "" Then
            MsgBox("Please enter the New Class Limit", vbExclamation)
            Exit Sub
        End If

        Select Case chkApply.Checked
            Case True
                Dim com As New MySqlCommand("UPDATE tblClassSchedule SET `Limit`='" & txtLimit.Text & "' WHERE SectionID='" & tmpSectionID & "'", con)
                com.ExecuteNonQuery()

                MsgBox("Subject Offering Class Limit under this Class Section Successfully change.." & vbNewLine & vbNewLine & "Refresh Class section to reload records...", vbInformation)
                Close()

            Case False

                Dim com As New MySqlCommand("UPDATE tblClassSchedule SET `Limit`='" & txtLimit.Text & "' WHERE SubjectOfferingID='" & tmpOfferingID & "'", con)
                com.ExecuteNonQuery()

                MsgBox("Subject Offering Class Limit Successfully change.." & vbNewLine & vbNewLine & "Refresh Class section to reload records...", vbInformation)
                Close()

        End Select
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmModClassLimit_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub ShowForm(ByVal SectionID As String, ByVal SubjectOfferingID As String, ByVal Limit As Integer)

        tmpSectionID = SectionID
        tmpOfferingID = SubjectOfferingID

        txtLimit.Text = Limit

        Me.ShowDialog()
    End Sub



End Class
