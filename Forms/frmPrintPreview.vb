Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data
Imports CrystalDecisions.CrystalReports

Public Class frmPrintPreview

    Public Sub rptAcademiProgramByCampus(ByVal CampusID As Integer, ByVal PrintedBy As String)
        Dim com As New MySqlCommand("CALL rptAcademicProgramsByCampus('" & CampusID & "','" & PrintedBy & "')", con)
        Dim daAcademic As New MySqlDataAdapter()
        Dim dsAcademic As New DataSet()
        daAcademic.SelectCommand = com
        daAcademic.Fill(dsAcademic)

        'Dim rpt As New rptAcademicPrograms()
        'CRViewer.ReportSource = rpt

        Me.Show()
    End Sub

    Private Sub frmPrintPreview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class