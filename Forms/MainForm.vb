Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Data.OleDb
Imports System.Text
Imports System.Windows.Forms
Imports System.Runtime.InteropServices

Public Class MainForm1
    Inherits Form

    Public Sub New()
        InitializeComponent()

        'Me.WindowManagerPanel1.CustomTabsProviderType = GetType(MDIWindowManager.SystemTabsProvider)

    End Sub
    Function FindMDIClient() As MdiClient
        Dim i As Integer = 0
        While i < Me.Controls.Count
            If TypeOf Me.Controls(i) Is MdiClient Then
                Return CType(Me.Controls(i), MdiClient)
            End If
            i = i + 1
        End While
        Return Nothing
    End Function
    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles exitApplicationToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub optionsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim schedule As New frmCurriculum()
        schedule.Show()
    End Sub

    Private Sub aboutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles aboutToolStripMenuItem.Click
        Dim about As New frmAbout()
        about.ShowDialog()
    End Sub

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        txtSchoolYear.Text = CurrentSchoolYear.SchoolYearTitle & " - " & CurrentSchoolYear.SchoolTerm

        If txtSchoolYear.Text = "0000" Or txtSchoolYear.Text = "" Then
            MsgBox("Please set a current school year")
            Dim frm As New frmSetActiveSY()
            frm.setSchoolYear()
            Exit Sub
        End If
    End Sub
    Private Sub settingsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles settingsToolStripMenuItem.Click
        Dim frm As New frmProgramSettings()
        frm.ShowDialog()

    End Sub
    Private Sub MainForm_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Resize

    End Sub

    Private Sub loginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loginToolStripMenuItem.Click
        Dim frm As New frmLogin()
        frm.ShowDialog()
        If frm.isValid = True Then
            txtCurrentUser.Text = frm.getUser
        End If

    End Sub

    Private Sub RecordExplorerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim frm As New frmRecordExplorer()
        'frm.MdiParent = Me
        'frm.WindowState = FormWindowState.Maximized
        'frm.Show()
    End Sub
    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New frmBrowse()
        frm.Show()
    End Sub
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        Me.ActiveMdiChild.Close()
    End Sub

    Private Sub cmdCurriculum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProspectusToolStripMenuItem.Click
        Dim frm As New frmCurriculum()
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        'frm.ControlBox = False
        frm.Show()
    End Sub
    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        Select Case ActiveMdiChild.Name
            Case "frmScheduler"

        End Select


    End Sub

    Private Sub cmdColleges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New frmPrintPreview()
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        'frm.ControlBox = False
        frm.Show()
    End Sub
    Private Sub cmdSectionSplitMerge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassSectionSplitMergeToolStripMenuItem.Click
        Dim frm As New frmSplitMerge()
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        'frm.ControlBox = False
        frm.TabControl1.SelectedIndex = 0
        frm.Show()
    End Sub

    Private Sub cmdScheduleSplitMerge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New frmSplitMerge()
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        'frm.ControlBox = False
        frm.TabControl1.SelectedIndex = 1
        frm.Show()
    End Sub

    Private Sub cmdAcadPrograms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcademicProgramsToolStripMenuItem.Click
        Dim frm As New frmProgramsMajors()
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        'frm.ControlBox = True
        frm.Show()
    End Sub

    Private Sub ClassSectionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassSectionsToolStripMenuItem.Click
        Dim frm As New frmManageSection()
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub ReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportsToolStripMenuItem.Click
        Dim frm As New frmPrintForm()
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub


    Private Sub ContactUsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContactUsToolStripMenuItem.Click
        Dim frm As New frmAllRooms()
        frm.Show()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Select Case con.Ping
            Case True
                cmdReconnect.Visible = False
                PictureBox1.Image = Academic_Manager.Resources.Connect1.ToBitmap
                lblConnection.Text = MySQL_SERVER & "\" & DEFAULT_DATABASE & " connected"
            Case False
                cmdReconnect.Visible = True
                PictureBox1.Image = Academic_Manager.Resources.Disconnect1.ToBitmap
                lblConnection.Text = MySQL_SERVER & "\" & DEFAULT_DATABASE & " disconnected"
        End Select
    End Sub

    Private Sub EnrollmentToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EnrollmentToolStripMenuItem.Click
        Dim frm As New Registration()
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub ListOfAccountsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ChartsOfAccountsToolStripMenuItem.Click
        Dim frm As New frmListOfAccounts
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub FeesTemplateToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FeesTemplateToolStripMenuItem.Click
        Dim frm As New frmFeesTemplate
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub ScholarshipGrantTemplateToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ScholarshipTemplatesToolStripMenuItem.Click
        Dim frm As New frmScholarshipGrantTemplates
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub PromissoryNotesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PromissoryNotesToolStripMenuItem.Click
        Dim frm As New frmPromisoryNote()
        frm.ShowDialog()
    End Sub

    Private Sub StudentLedgerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StudentLedgerToolStripMenuItem.Click
        Dim frm As New frmStudentLedger
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub ListOfReportsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ListOfReportsToolStripMenuItem.Click

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Dim frm As New frmScheduler
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub AllSectionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClassSectionToolStripMenuItem.Click
        Dim frm As New frmManageSection()
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        'frm.ControlBox = False
        frm.Show()
    End Sub

    Private Sub RoomsAndFacultyUtilizationToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RoomsAndFacultyUtilizationToolStripMenuItem.Click
        Dim frm As New frmUtilization()
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub FacultyLoadingToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Dim frm As New frmSchedReports
        frm.ShowDialog()
    End Sub

    Private Sub CloneRegistrationToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CloneRegistrationToolStripMenuItem.Click
        Dim frm As New frmClone
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub ConfigurationToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ConfigurationToolStripMenuItem1.Click
        Dim frm As New frmRegSettings
        frm.ShowForm()
    End Sub

    Private Sub RegistrationAssessmentConfiguraitonToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RegistrationAssessmentConfiguraitonToolStripMenuItem.Click
        Dim frm As New frmRegConfig
        frm.ShowDialog()
    End Sub

    Private Sub BillingAndAssessmentToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BillingAndAssessmentToolStripMenuItem.Click
        Dim frm As New ASsessment
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub mnuBillingSummary_Click(sender As System.Object, e As System.EventArgs) Handles mnuBillingSummary.Click
        Dim frm As New frmBillingSummary
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub CollegeDepartmentsInstitutesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CollegeDepartmentsInstitutesToolStripMenuItem.Click
        Dim frm As New frmCollegeAE
        frm.ShowForm()
    End Sub
End Class
