'
' * Created by SharpDevelop.
' * User: Janphil Garay
' * Date: 11/17/2011
' * Time: 11:51 PM
' * 
' * To change this template use Tools | Options | Coding | Edit Standard Headers.
' 

Imports System.Drawing
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Drawing.Printing
Imports System.Collections.Generic

Public Class frmSplitMerge
    Inherits Form


    Public Sub New()

        InitializeComponent()


    End Sub
    Private Sub DisplayAddSchedule()


    End Sub

    Private Sub FrmTimeTablingLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        fillMultiColumnCombo2(cboCampus, "SELECT ShortName,CampusID FROM tblCampus")
        'fillCombo(cboCampusID, "SELECT CampusID FROM tblCampus")

        fillToolStripCombo(cboSource, "SELECT ShortName FROM tblCampus")
        'fillCombo(cboSourceCampusID, "SELECT CampusID FROM tblCampus")

        fillToolStripCombo(cboDestination, "SELECT ShortName FROM tblCampus")
        'fillCombo(cboDestinationCampusID, "SELECT CampusID FROM tblCampus")

    End Sub

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PrintToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub OpenToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'DisplayAddSchedule()
    End Sub

    Private Sub cmdBrowseAY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim sSchoolYearTitle As String
        Dim frm As New PickSchoolYear()

        'sSchoolYearTitle = frm.GetItem(txtSY)

        If sSchoolYearTitle <> "" Then
            'txtSY.Text = sSchoolYearTitle
        End If
    End Sub
End Class