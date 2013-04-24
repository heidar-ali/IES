Partial Class MainForm1
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm1))
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.toolsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.loginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemLockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.exitApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdmissionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.studentProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentMasterListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator22 = New System.Windows.Forms.ToolStripSeparator()
        Me.SubjectMasterListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator23 = New System.Windows.Forms.ToolStripSeparator()
        Me.gradingSystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator24 = New System.Windows.Forms.ToolStripSeparator()
        Me.addDropChangeOfCourseWithdrawalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator25 = New System.Windows.Forms.ToolStripSeparator()
        Me.gradeEncodingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.correctionOfGradesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.academicProgramEvaluationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.transcriptOfRecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.reportOfGradesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator26 = New System.Windows.Forms.ToolStripSeparator()
        Me.tagGraduatingStudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.graduatesCandidateForGraduationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator27 = New System.Windows.Forms.ToolStripSeparator()
        Me.cHEDReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.listOfReportsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.viewMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcademicProgramsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CollegeDepartmentsInstitutesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProspectusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClassSectionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClassSectionSplitMergeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.FacultyLoadingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SchedulerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClassSectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomsAndFacultyUtilizationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator19 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnrollmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CertificateOfRegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloneRegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator()
        Me.RegistrationCorrectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrationValidationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator17 = New System.Windows.Forms.ToolStripSeparator()
        Me.PurgeInvalidatedRegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurgeExpireRegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator18 = New System.Windows.Forms.ToolStripSeparator()
        Me.ConfigurationToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrationAssessmentConfiguraitonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChartsOfAccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeesTemplateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScholarshipTemplatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.PromissoryNotesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JournalEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentLedgerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.StudentAccountReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentWithBadAccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ListOfReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AssessmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BillingAndAssessmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator21 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuBillingSummary = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatementOfAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PermitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator20 = New System.Windows.Forms.ToolStripSeparator()
        Me.ConfigurationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcademicInstitutionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcademicYearsAndTermsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.settingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.UserAccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileHorizontallyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileVerticallyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.helpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VersionHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.aboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblConnection = New System.Windows.Forms.Label()
        Me.cmdReconnect = New System.Windows.Forms.Button()
        Me.statusStrip = New System.Windows.Forms.StatusStrip()
        Me.toolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtCurrentUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtSchoolYear = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DocumentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
        Me.TabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.menuStrip.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.statusStrip.SuspendLayout()
        CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menuStrip
        '
        Me.menuStrip.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolsMenu, Me.AdmissionToolStripMenuItem, Me.RegistrarToolStripMenuItem, Me.viewMenu, Me.SchedulerToolStripMenuItem, Me.RegistrationToolStripMenuItem, Me.AccountingToolStripMenuItem, Me.AssessmentToolStripMenuItem, Me.toolsToolStripMenuItem, Me.WindowToolStripMenuItem, Me.helpMenu})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(1008, 24)
        Me.menuStrip.TabIndex = 0
        Me.menuStrip.Text = "MenuStrip"
        '
        'toolsMenu
        '
        Me.toolsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.loginToolStripMenuItem, Me.TransactionLogToolStripMenuItem, Me.SystemLockToolStripMenuItem, Me.ToolStripSeparator4, Me.ChangePasswordToolStripMenuItem, Me.toolStripSeparator3, Me.exitApplicationToolStripMenuItem})
        Me.toolsMenu.Name = "toolsMenu"
        Me.toolsMenu.Size = New System.Drawing.Size(54, 20)
        Me.toolsMenu.Text = "&Action"
        '
        'loginToolStripMenuItem
        '
        Me.loginToolStripMenuItem.Image = CType(resources.GetObject("loginToolStripMenuItem.Image"), System.Drawing.Image)
        Me.loginToolStripMenuItem.Name = "loginToolStripMenuItem"
        Me.loginToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.loginToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.loginToolStripMenuItem.Text = "Login..."
        '
        'TransactionLogToolStripMenuItem
        '
        Me.TransactionLogToolStripMenuItem.Image = CType(resources.GetObject("TransactionLogToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TransactionLogToolStripMenuItem.Name = "TransactionLogToolStripMenuItem"
        Me.TransactionLogToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.TransactionLogToolStripMenuItem.Text = "Transaction Log"
        '
        'SystemLockToolStripMenuItem
        '
        Me.SystemLockToolStripMenuItem.Image = CType(resources.GetObject("SystemLockToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SystemLockToolStripMenuItem.Name = "SystemLockToolStripMenuItem"
        Me.SystemLockToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.SystemLockToolStripMenuItem.Text = "System Lock"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(179, 6)
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Image = CType(resources.GetObject("ChangePasswordToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password..."
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(179, 6)
        '
        'exitApplicationToolStripMenuItem
        '
        Me.exitApplicationToolStripMenuItem.Image = CType(resources.GetObject("exitApplicationToolStripMenuItem.Image"), System.Drawing.Image)
        Me.exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem"
        Me.exitApplicationToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.exitApplicationToolStripMenuItem.Text = "Exit Application"
        '
        'AdmissionToolStripMenuItem
        '
        Me.AdmissionToolStripMenuItem.Name = "AdmissionToolStripMenuItem"
        Me.AdmissionToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.AdmissionToolStripMenuItem.Text = "A&dmission"
        '
        'RegistrarToolStripMenuItem
        '
        Me.RegistrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.studentProfileToolStripMenuItem, Me.StudentMasterListToolStripMenuItem, Me.toolStripSeparator22, Me.SubjectMasterListToolStripMenuItem, Me.toolStripSeparator23, Me.gradingSystemToolStripMenuItem, Me.toolStripSeparator24, Me.addDropChangeOfCourseWithdrawalToolStripMenuItem, Me.toolStripSeparator25, Me.gradeEncodingToolStripMenuItem, Me.correctionOfGradesToolStripMenuItem, Me.academicProgramEvaluationToolStripMenuItem, Me.transcriptOfRecordsToolStripMenuItem, Me.reportOfGradesToolStripMenuItem, Me.toolStripSeparator26, Me.tagGraduatingStudentsToolStripMenuItem, Me.graduatesCandidateForGraduationToolStripMenuItem, Me.toolStripSeparator27, Me.cHEDReportsToolStripMenuItem, Me.listOfReportsToolStripMenuItem1})
        Me.RegistrarToolStripMenuItem.Name = "RegistrarToolStripMenuItem"
        Me.RegistrarToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.RegistrarToolStripMenuItem.Text = "&Registrar"
        '
        'studentProfileToolStripMenuItem
        '
        Me.studentProfileToolStripMenuItem.Name = "studentProfileToolStripMenuItem"
        Me.studentProfileToolStripMenuItem.Size = New System.Drawing.Size(295, 22)
        Me.studentProfileToolStripMenuItem.Text = "Student Profile"
        '
        'StudentMasterListToolStripMenuItem
        '
        Me.StudentMasterListToolStripMenuItem.Name = "StudentMasterListToolStripMenuItem"
        Me.StudentMasterListToolStripMenuItem.Size = New System.Drawing.Size(295, 22)
        Me.StudentMasterListToolStripMenuItem.Text = "Student Master List"
        '
        'toolStripSeparator22
        '
        Me.toolStripSeparator22.Name = "toolStripSeparator22"
        Me.toolStripSeparator22.Size = New System.Drawing.Size(292, 6)
        '
        'SubjectMasterListToolStripMenuItem
        '
        Me.SubjectMasterListToolStripMenuItem.Name = "SubjectMasterListToolStripMenuItem"
        Me.SubjectMasterListToolStripMenuItem.Size = New System.Drawing.Size(295, 22)
        Me.SubjectMasterListToolStripMenuItem.Text = "Subject Master List"
        '
        'toolStripSeparator23
        '
        Me.toolStripSeparator23.Name = "toolStripSeparator23"
        Me.toolStripSeparator23.Size = New System.Drawing.Size(292, 6)
        '
        'gradingSystemToolStripMenuItem
        '
        Me.gradingSystemToolStripMenuItem.Name = "gradingSystemToolStripMenuItem"
        Me.gradingSystemToolStripMenuItem.Size = New System.Drawing.Size(295, 22)
        Me.gradingSystemToolStripMenuItem.Text = "Grading System"
        '
        'toolStripSeparator24
        '
        Me.toolStripSeparator24.Name = "toolStripSeparator24"
        Me.toolStripSeparator24.Size = New System.Drawing.Size(292, 6)
        '
        'addDropChangeOfCourseWithdrawalToolStripMenuItem
        '
        Me.addDropChangeOfCourseWithdrawalToolStripMenuItem.Name = "addDropChangeOfCourseWithdrawalToolStripMenuItem"
        Me.addDropChangeOfCourseWithdrawalToolStripMenuItem.Size = New System.Drawing.Size(295, 22)
        Me.addDropChangeOfCourseWithdrawalToolStripMenuItem.Text = "Add/Drop/Change of Course/Withdrawal"
        '
        'toolStripSeparator25
        '
        Me.toolStripSeparator25.Name = "toolStripSeparator25"
        Me.toolStripSeparator25.Size = New System.Drawing.Size(292, 6)
        '
        'gradeEncodingToolStripMenuItem
        '
        Me.gradeEncodingToolStripMenuItem.Name = "gradeEncodingToolStripMenuItem"
        Me.gradeEncodingToolStripMenuItem.Size = New System.Drawing.Size(295, 22)
        Me.gradeEncodingToolStripMenuItem.Text = "Grade Encoding"
        '
        'correctionOfGradesToolStripMenuItem
        '
        Me.correctionOfGradesToolStripMenuItem.Name = "correctionOfGradesToolStripMenuItem"
        Me.correctionOfGradesToolStripMenuItem.Size = New System.Drawing.Size(295, 22)
        Me.correctionOfGradesToolStripMenuItem.Text = "Correction of Grades"
        '
        'academicProgramEvaluationToolStripMenuItem
        '
        Me.academicProgramEvaluationToolStripMenuItem.Name = "academicProgramEvaluationToolStripMenuItem"
        Me.academicProgramEvaluationToolStripMenuItem.Size = New System.Drawing.Size(295, 22)
        Me.academicProgramEvaluationToolStripMenuItem.Text = "Academic Program Evaluation"
        '
        'transcriptOfRecordsToolStripMenuItem
        '
        Me.transcriptOfRecordsToolStripMenuItem.Name = "transcriptOfRecordsToolStripMenuItem"
        Me.transcriptOfRecordsToolStripMenuItem.Size = New System.Drawing.Size(295, 22)
        Me.transcriptOfRecordsToolStripMenuItem.Text = "Transcript Of Records"
        '
        'reportOfGradesToolStripMenuItem
        '
        Me.reportOfGradesToolStripMenuItem.Name = "reportOfGradesToolStripMenuItem"
        Me.reportOfGradesToolStripMenuItem.Size = New System.Drawing.Size(295, 22)
        Me.reportOfGradesToolStripMenuItem.Text = "Report of Grades"
        '
        'toolStripSeparator26
        '
        Me.toolStripSeparator26.Name = "toolStripSeparator26"
        Me.toolStripSeparator26.Size = New System.Drawing.Size(292, 6)
        '
        'tagGraduatingStudentsToolStripMenuItem
        '
        Me.tagGraduatingStudentsToolStripMenuItem.Name = "tagGraduatingStudentsToolStripMenuItem"
        Me.tagGraduatingStudentsToolStripMenuItem.Size = New System.Drawing.Size(295, 22)
        Me.tagGraduatingStudentsToolStripMenuItem.Text = "Tag Graduating Students"
        '
        'graduatesCandidateForGraduationToolStripMenuItem
        '
        Me.graduatesCandidateForGraduationToolStripMenuItem.Name = "graduatesCandidateForGraduationToolStripMenuItem"
        Me.graduatesCandidateForGraduationToolStripMenuItem.Size = New System.Drawing.Size(295, 22)
        Me.graduatesCandidateForGraduationToolStripMenuItem.Text = "Graduates/Candidate for Graduation"
        '
        'toolStripSeparator27
        '
        Me.toolStripSeparator27.Name = "toolStripSeparator27"
        Me.toolStripSeparator27.Size = New System.Drawing.Size(292, 6)
        '
        'cHEDReportsToolStripMenuItem
        '
        Me.cHEDReportsToolStripMenuItem.Name = "cHEDReportsToolStripMenuItem"
        Me.cHEDReportsToolStripMenuItem.Size = New System.Drawing.Size(295, 22)
        Me.cHEDReportsToolStripMenuItem.Text = "CHED Reports"
        '
        'listOfReportsToolStripMenuItem1
        '
        Me.listOfReportsToolStripMenuItem1.Name = "listOfReportsToolStripMenuItem1"
        Me.listOfReportsToolStripMenuItem1.Size = New System.Drawing.Size(295, 22)
        Me.listOfReportsToolStripMenuItem1.Text = "List of Reports"
        '
        'viewMenu
        '
        Me.viewMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcademicProgramsToolStripMenuItem, Me.CollegeDepartmentsInstitutesToolStripMenuItem, Me.ToolStripSeparator11, Me.ProspectusToolStripMenuItem, Me.ToolStripSeparator9, Me.ClassSectionsToolStripMenuItem, Me.ClassSectionSplitMergeToolStripMenuItem, Me.ToolStripSeparator10, Me.FacultyLoadingToolStripMenuItem, Me.ToolStripSeparator7, Me.ReportsToolStripMenuItem})
        Me.viewMenu.Name = "viewMenu"
        Me.viewMenu.Size = New System.Drawing.Size(71, 20)
        Me.viewMenu.Text = "A&cademic"
        '
        'AcademicProgramsToolStripMenuItem
        '
        Me.AcademicProgramsToolStripMenuItem.Image = CType(resources.GetObject("AcademicProgramsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AcademicProgramsToolStripMenuItem.Name = "AcademicProgramsToolStripMenuItem"
        Me.AcademicProgramsToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.AcademicProgramsToolStripMenuItem.Text = "Academic Programs"
        '
        'CollegeDepartmentsInstitutesToolStripMenuItem
        '
        Me.CollegeDepartmentsInstitutesToolStripMenuItem.Name = "CollegeDepartmentsInstitutesToolStripMenuItem"
        Me.CollegeDepartmentsInstitutesToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.CollegeDepartmentsInstitutesToolStripMenuItem.Text = "College/Departments/Institutes"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(243, 6)
        '
        'ProspectusToolStripMenuItem
        '
        Me.ProspectusToolStripMenuItem.Image = CType(resources.GetObject("ProspectusToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProspectusToolStripMenuItem.Name = "ProspectusToolStripMenuItem"
        Me.ProspectusToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.ProspectusToolStripMenuItem.Text = "Program Curriculums"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(243, 6)
        '
        'ClassSectionsToolStripMenuItem
        '
        Me.ClassSectionsToolStripMenuItem.Image = CType(resources.GetObject("ClassSectionsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ClassSectionsToolStripMenuItem.Name = "ClassSectionsToolStripMenuItem"
        Me.ClassSectionsToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.ClassSectionsToolStripMenuItem.Text = "Class Section Management"
        '
        'ClassSectionSplitMergeToolStripMenuItem
        '
        Me.ClassSectionSplitMergeToolStripMenuItem.Image = CType(resources.GetObject("ClassSectionSplitMergeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ClassSectionSplitMergeToolStripMenuItem.Name = "ClassSectionSplitMergeToolStripMenuItem"
        Me.ClassSectionSplitMergeToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.ClassSectionSplitMergeToolStripMenuItem.Text = "Class Section Split/Merge"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(243, 6)
        '
        'FacultyLoadingToolStripMenuItem
        '
        Me.FacultyLoadingToolStripMenuItem.Image = CType(resources.GetObject("FacultyLoadingToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FacultyLoadingToolStripMenuItem.Name = "FacultyLoadingToolStripMenuItem"
        Me.FacultyLoadingToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.FacultyLoadingToolStripMenuItem.Text = "Faculty Loading"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(243, 6)
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.Image = CType(resources.GetObject("ReportsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.ReportsToolStripMenuItem.Text = "List of Reports..."
        '
        'SchedulerToolStripMenuItem
        '
        Me.SchedulerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripSeparator15, Me.ClassSectionToolStripMenuItem, Me.RoomsAndFacultyUtilizationToolStripMenuItem, Me.ToolStripSeparator19, Me.ToolStripMenuItem2})
        Me.SchedulerToolStripMenuItem.Name = "SchedulerToolStripMenuItem"
        Me.SchedulerToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.SchedulerToolStripMenuItem.Text = "&Scheduler"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(219, 22)
        Me.ToolStripMenuItem1.Text = "Class Scheduling"
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(216, 6)
        '
        'ClassSectionToolStripMenuItem
        '
        Me.ClassSectionToolStripMenuItem.Image = CType(resources.GetObject("ClassSectionToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ClassSectionToolStripMenuItem.Name = "ClassSectionToolStripMenuItem"
        Me.ClassSectionToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.ClassSectionToolStripMenuItem.Text = "Class Section Management"
        '
        'RoomsAndFacultyUtilizationToolStripMenuItem
        '
        Me.RoomsAndFacultyUtilizationToolStripMenuItem.Image = CType(resources.GetObject("RoomsAndFacultyUtilizationToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RoomsAndFacultyUtilizationToolStripMenuItem.Name = "RoomsAndFacultyUtilizationToolStripMenuItem"
        Me.RoomsAndFacultyUtilizationToolStripMenuItem.ShortcutKeyDisplayString = "F5"
        Me.RoomsAndFacultyUtilizationToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.RoomsAndFacultyUtilizationToolStripMenuItem.Text = "Utilization"
        '
        'ToolStripSeparator19
        '
        Me.ToolStripSeparator19.Name = "ToolStripSeparator19"
        Me.ToolStripSeparator19.Size = New System.Drawing.Size(216, 6)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = CType(resources.GetObject("ToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(219, 22)
        Me.ToolStripMenuItem2.Text = "List of Reports..."
        '
        'RegistrationToolStripMenuItem
        '
        Me.RegistrationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnrollmentToolStripMenuItem, Me.CertificateOfRegistrationToolStripMenuItem, Me.ToolStripSeparator14, Me.CloneRegistrationToolStripMenuItem, Me.ToolStripSeparator16, Me.RegistrationCorrectionToolStripMenuItem, Me.RegistrationValidationToolStripMenuItem, Me.ToolStripSeparator17, Me.PurgeInvalidatedRegistrationToolStripMenuItem, Me.PurgeExpireRegistrationToolStripMenuItem, Me.ToolStripSeparator18, Me.ConfigurationToolStripMenuItem1, Me.RegistrationAssessmentConfiguraitonToolStripMenuItem})
        Me.RegistrationToolStripMenuItem.Name = "RegistrationToolStripMenuItem"
        Me.RegistrationToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.RegistrationToolStripMenuItem.Text = "Re&gistration"
        '
        'EnrollmentToolStripMenuItem
        '
        Me.EnrollmentToolStripMenuItem.Name = "EnrollmentToolStripMenuItem"
        Me.EnrollmentToolStripMenuItem.Size = New System.Drawing.Size(282, 22)
        Me.EnrollmentToolStripMenuItem.Text = "Enrollment..."
        '
        'CertificateOfRegistrationToolStripMenuItem
        '
        Me.CertificateOfRegistrationToolStripMenuItem.Name = "CertificateOfRegistrationToolStripMenuItem"
        Me.CertificateOfRegistrationToolStripMenuItem.Size = New System.Drawing.Size(282, 22)
        Me.CertificateOfRegistrationToolStripMenuItem.Text = "Certificate of Registration (COR)"
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(279, 6)
        '
        'CloneRegistrationToolStripMenuItem
        '
        Me.CloneRegistrationToolStripMenuItem.Name = "CloneRegistrationToolStripMenuItem"
        Me.CloneRegistrationToolStripMenuItem.Size = New System.Drawing.Size(282, 22)
        Me.CloneRegistrationToolStripMenuItem.Text = "Clone Registration"
        '
        'ToolStripSeparator16
        '
        Me.ToolStripSeparator16.Name = "ToolStripSeparator16"
        Me.ToolStripSeparator16.Size = New System.Drawing.Size(279, 6)
        '
        'RegistrationCorrectionToolStripMenuItem
        '
        Me.RegistrationCorrectionToolStripMenuItem.Name = "RegistrationCorrectionToolStripMenuItem"
        Me.RegistrationCorrectionToolStripMenuItem.Size = New System.Drawing.Size(282, 22)
        Me.RegistrationCorrectionToolStripMenuItem.Text = "Registration Correction"
        '
        'RegistrationValidationToolStripMenuItem
        '
        Me.RegistrationValidationToolStripMenuItem.Name = "RegistrationValidationToolStripMenuItem"
        Me.RegistrationValidationToolStripMenuItem.Size = New System.Drawing.Size(282, 22)
        Me.RegistrationValidationToolStripMenuItem.Text = "Registration Validation"
        '
        'ToolStripSeparator17
        '
        Me.ToolStripSeparator17.Name = "ToolStripSeparator17"
        Me.ToolStripSeparator17.Size = New System.Drawing.Size(279, 6)
        '
        'PurgeInvalidatedRegistrationToolStripMenuItem
        '
        Me.PurgeInvalidatedRegistrationToolStripMenuItem.Name = "PurgeInvalidatedRegistrationToolStripMenuItem"
        Me.PurgeInvalidatedRegistrationToolStripMenuItem.Size = New System.Drawing.Size(282, 22)
        Me.PurgeInvalidatedRegistrationToolStripMenuItem.Text = "Purge Invalidated Registration"
        '
        'PurgeExpireRegistrationToolStripMenuItem
        '
        Me.PurgeExpireRegistrationToolStripMenuItem.Name = "PurgeExpireRegistrationToolStripMenuItem"
        Me.PurgeExpireRegistrationToolStripMenuItem.Size = New System.Drawing.Size(282, 22)
        Me.PurgeExpireRegistrationToolStripMenuItem.Text = "Purge Expire Registration"
        '
        'ToolStripSeparator18
        '
        Me.ToolStripSeparator18.Name = "ToolStripSeparator18"
        Me.ToolStripSeparator18.Size = New System.Drawing.Size(279, 6)
        '
        'ConfigurationToolStripMenuItem1
        '
        Me.ConfigurationToolStripMenuItem1.Name = "ConfigurationToolStripMenuItem1"
        Me.ConfigurationToolStripMenuItem1.Size = New System.Drawing.Size(282, 22)
        Me.ConfigurationToolStripMenuItem1.Text = "Registration Settings"
        '
        'RegistrationAssessmentConfiguraitonToolStripMenuItem
        '
        Me.RegistrationAssessmentConfiguraitonToolStripMenuItem.Name = "RegistrationAssessmentConfiguraitonToolStripMenuItem"
        Me.RegistrationAssessmentConfiguraitonToolStripMenuItem.Size = New System.Drawing.Size(282, 22)
        Me.RegistrationAssessmentConfiguraitonToolStripMenuItem.Text = "Registration Assessment Configuration"
        '
        'AccountingToolStripMenuItem
        '
        Me.AccountingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChartsOfAccountsToolStripMenuItem, Me.FeesTemplateToolStripMenuItem, Me.ScholarshipTemplatesToolStripMenuItem, Me.ToolStripSeparator12, Me.PromissoryNotesToolStripMenuItem, Me.JournalEntryToolStripMenuItem, Me.StudentLedgerToolStripMenuItem, Me.ToolStripSeparator1, Me.StudentAccountReportsToolStripMenuItem, Me.StudentWithBadAccountsToolStripMenuItem, Me.ToolStripSeparator6, Me.ListOfReportsToolStripMenuItem})
        Me.AccountingToolStripMenuItem.Name = "AccountingToolStripMenuItem"
        Me.AccountingToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.AccountingToolStripMenuItem.Text = "Acc&ounting"
        '
        'ChartsOfAccountsToolStripMenuItem
        '
        Me.ChartsOfAccountsToolStripMenuItem.Image = CType(resources.GetObject("ChartsOfAccountsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ChartsOfAccountsToolStripMenuItem.Name = "ChartsOfAccountsToolStripMenuItem"
        Me.ChartsOfAccountsToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.ChartsOfAccountsToolStripMenuItem.Text = "List of Accounts"
        '
        'FeesTemplateToolStripMenuItem
        '
        Me.FeesTemplateToolStripMenuItem.Image = CType(resources.GetObject("FeesTemplateToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FeesTemplateToolStripMenuItem.Name = "FeesTemplateToolStripMenuItem"
        Me.FeesTemplateToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.FeesTemplateToolStripMenuItem.Text = "Fees Template"
        '
        'ScholarshipTemplatesToolStripMenuItem
        '
        Me.ScholarshipTemplatesToolStripMenuItem.Image = CType(resources.GetObject("ScholarshipTemplatesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ScholarshipTemplatesToolStripMenuItem.Name = "ScholarshipTemplatesToolStripMenuItem"
        Me.ScholarshipTemplatesToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.ScholarshipTemplatesToolStripMenuItem.Text = "Scholarship Provider && Template"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(247, 6)
        '
        'PromissoryNotesToolStripMenuItem
        '
        Me.PromissoryNotesToolStripMenuItem.Image = CType(resources.GetObject("PromissoryNotesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PromissoryNotesToolStripMenuItem.Name = "PromissoryNotesToolStripMenuItem"
        Me.PromissoryNotesToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.PromissoryNotesToolStripMenuItem.Text = "Promissory Notes"
        '
        'JournalEntryToolStripMenuItem
        '
        Me.JournalEntryToolStripMenuItem.Image = CType(resources.GetObject("JournalEntryToolStripMenuItem.Image"), System.Drawing.Image)
        Me.JournalEntryToolStripMenuItem.Name = "JournalEntryToolStripMenuItem"
        Me.JournalEntryToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.JournalEntryToolStripMenuItem.Text = "Journal Entry"
        '
        'StudentLedgerToolStripMenuItem
        '
        Me.StudentLedgerToolStripMenuItem.Image = CType(resources.GetObject("StudentLedgerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.StudentLedgerToolStripMenuItem.Name = "StudentLedgerToolStripMenuItem"
        Me.StudentLedgerToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.StudentLedgerToolStripMenuItem.Text = "Student Ledger"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(247, 6)
        '
        'StudentAccountReportsToolStripMenuItem
        '
        Me.StudentAccountReportsToolStripMenuItem.Image = CType(resources.GetObject("StudentAccountReportsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.StudentAccountReportsToolStripMenuItem.Name = "StudentAccountReportsToolStripMenuItem"
        Me.StudentAccountReportsToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.StudentAccountReportsToolStripMenuItem.Text = "Student Account Reports"
        '
        'StudentWithBadAccountsToolStripMenuItem
        '
        Me.StudentWithBadAccountsToolStripMenuItem.Image = CType(resources.GetObject("StudentWithBadAccountsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.StudentWithBadAccountsToolStripMenuItem.Name = "StudentWithBadAccountsToolStripMenuItem"
        Me.StudentWithBadAccountsToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.StudentWithBadAccountsToolStripMenuItem.Text = "Student with Bad Accounts"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(247, 6)
        '
        'ListOfReportsToolStripMenuItem
        '
        Me.ListOfReportsToolStripMenuItem.Image = CType(resources.GetObject("ListOfReportsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ListOfReportsToolStripMenuItem.Name = "ListOfReportsToolStripMenuItem"
        Me.ListOfReportsToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.ListOfReportsToolStripMenuItem.Text = "List of Reports"
        '
        'AssessmentToolStripMenuItem
        '
        Me.AssessmentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BillingAndAssessmentToolStripMenuItem, Me.ToolStripSeparator21, Me.mnuBillingSummary, Me.StatementOfAccountToolStripMenuItem, Me.ClearanceToolStripMenuItem, Me.PermitToolStripMenuItem, Me.ToolStripSeparator20, Me.ConfigurationToolStripMenuItem})
        Me.AssessmentToolStripMenuItem.Name = "AssessmentToolStripMenuItem"
        Me.AssessmentToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.AssessmentToolStripMenuItem.Text = "A&ssessment"
        '
        'BillingAndAssessmentToolStripMenuItem
        '
        Me.BillingAndAssessmentToolStripMenuItem.Name = "BillingAndAssessmentToolStripMenuItem"
        Me.BillingAndAssessmentToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.BillingAndAssessmentToolStripMenuItem.Text = "Billing/Assessment"
        '
        'ToolStripSeparator21
        '
        Me.ToolStripSeparator21.Name = "ToolStripSeparator21"
        Me.ToolStripSeparator21.Size = New System.Drawing.Size(197, 6)
        '
        'mnuBillingSummary
        '
        Me.mnuBillingSummary.Name = "mnuBillingSummary"
        Me.mnuBillingSummary.Size = New System.Drawing.Size(200, 22)
        Me.mnuBillingSummary.Text = "Billing Summary..."
        '
        'StatementOfAccountToolStripMenuItem
        '
        Me.StatementOfAccountToolStripMenuItem.Name = "StatementOfAccountToolStripMenuItem"
        Me.StatementOfAccountToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.StatementOfAccountToolStripMenuItem.Text = "Statement Of Account"
        '
        'ClearanceToolStripMenuItem
        '
        Me.ClearanceToolStripMenuItem.Name = "ClearanceToolStripMenuItem"
        Me.ClearanceToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ClearanceToolStripMenuItem.Text = "Clearance"
        '
        'PermitToolStripMenuItem
        '
        Me.PermitToolStripMenuItem.Name = "PermitToolStripMenuItem"
        Me.PermitToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.PermitToolStripMenuItem.Text = "Permit"
        '
        'ToolStripSeparator20
        '
        Me.ToolStripSeparator20.Name = "ToolStripSeparator20"
        Me.ToolStripSeparator20.Size = New System.Drawing.Size(197, 6)
        '
        'ConfigurationToolStripMenuItem
        '
        Me.ConfigurationToolStripMenuItem.Name = "ConfigurationToolStripMenuItem"
        Me.ConfigurationToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ConfigurationToolStripMenuItem.Text = "Configuration"
        '
        'toolsToolStripMenuItem
        '
        Me.toolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcademicInstitutionToolStripMenuItem, Me.AcademicYearsAndTermsToolStripMenuItem, Me.ToolStripSeparator5, Me.settingsToolStripMenuItem, Me.ToolStripSeparator8, Me.UserAccountsToolStripMenuItem})
        Me.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem"
        Me.toolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.toolsToolStripMenuItem.Text = "&Tools"
        '
        'AcademicInstitutionToolStripMenuItem
        '
        Me.AcademicInstitutionToolStripMenuItem.Name = "AcademicInstitutionToolStripMenuItem"
        Me.AcademicInstitutionToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.AcademicInstitutionToolStripMenuItem.Text = "Academic Institution"
        '
        'AcademicYearsAndTermsToolStripMenuItem
        '
        Me.AcademicYearsAndTermsToolStripMenuItem.Name = "AcademicYearsAndTermsToolStripMenuItem"
        Me.AcademicYearsAndTermsToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.AcademicYearsAndTermsToolStripMenuItem.Text = "Academic Years and Terms"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(219, 6)
        '
        'settingsToolStripMenuItem
        '
        Me.settingsToolStripMenuItem.Image = CType(resources.GetObject("settingsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem"
        Me.settingsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10
        Me.settingsToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.settingsToolStripMenuItem.Text = "Settings"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(219, 6)
        '
        'UserAccountsToolStripMenuItem
        '
        Me.UserAccountsToolStripMenuItem.Name = "UserAccountsToolStripMenuItem"
        Me.UserAccountsToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.UserAccountsToolStripMenuItem.Text = "User Accounts"
        '
        'WindowToolStripMenuItem
        '
        Me.WindowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TileHorizontallyToolStripMenuItem, Me.TileVerticallyToolStripMenuItem, Me.CascadeToolStripMenuItem, Me.ToolStripSeparator2})
        Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
        Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.WindowToolStripMenuItem.Text = "Window"
        '
        'TileHorizontallyToolStripMenuItem
        '
        Me.TileHorizontallyToolStripMenuItem.Name = "TileHorizontallyToolStripMenuItem"
        Me.TileHorizontallyToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.TileHorizontallyToolStripMenuItem.Text = "Tile Horizontally"
        '
        'TileVerticallyToolStripMenuItem
        '
        Me.TileVerticallyToolStripMenuItem.Name = "TileVerticallyToolStripMenuItem"
        Me.TileVerticallyToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.TileVerticallyToolStripMenuItem.Text = "Tile Vertically"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.CascadeToolStripMenuItem.Text = "Cascade"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(155, 6)
        '
        'helpMenu
        '
        Me.helpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContactUsToolStripMenuItem, Me.VersionHistoryToolStripMenuItem, Me.ToolStripSeparator13, Me.aboutToolStripMenuItem})
        Me.helpMenu.Name = "helpMenu"
        Me.helpMenu.Size = New System.Drawing.Size(43, 20)
        Me.helpMenu.Text = "&Help"
        '
        'ContactUsToolStripMenuItem
        '
        Me.ContactUsToolStripMenuItem.Name = "ContactUsToolStripMenuItem"
        Me.ContactUsToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ContactUsToolStripMenuItem.Text = "Contact Us..."
        '
        'VersionHistoryToolStripMenuItem
        '
        Me.VersionHistoryToolStripMenuItem.Name = "VersionHistoryToolStripMenuItem"
        Me.VersionHistoryToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.VersionHistoryToolStripMenuItem.Text = "Version History"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(159, 6)
        '
        'aboutToolStripMenuItem
        '
        Me.aboutToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aboutToolStripMenuItem.Image = CType(resources.GetObject("aboutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem"
        Me.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.aboutToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.aboutToolStripMenuItem.Text = "&About ICE..."
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.lblConnection)
        Me.Panel1.Controls.Add(Me.cmdReconnect)
        Me.Panel1.Controls.Add(Me.statusStrip)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 703)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1008, 26)
        Me.Panel1.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(741, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'lblConnection
        '
        Me.lblConnection.AutoSize = True
        Me.lblConnection.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConnection.Location = New System.Drawing.Point(771, 5)
        Me.lblConnection.Name = "lblConnection"
        Me.lblConnection.Size = New System.Drawing.Size(19, 15)
        Me.lblConnection.TabIndex = 5
        Me.lblConnection.Text = "---"
        '
        'cmdReconnect
        '
        Me.cmdReconnect.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdReconnect.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReconnect.Location = New System.Drawing.Point(548, 2)
        Me.cmdReconnect.Name = "cmdReconnect"
        Me.cmdReconnect.Size = New System.Drawing.Size(188, 23)
        Me.cmdReconnect.TabIndex = 4
        Me.cmdReconnect.Text = "RECONNECT TO SERVER"
        Me.cmdReconnect.UseVisualStyleBackColor = False
        '
        'statusStrip
        '
        Me.statusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripStatusLabel, Me.txtCurrentUser, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel1, Me.txtSchoolYear})
        Me.statusStrip.Location = New System.Drawing.Point(0, 2)
        Me.statusStrip.Name = "statusStrip"
        Me.statusStrip.Size = New System.Drawing.Size(1008, 24)
        Me.statusStrip.TabIndex = 3
        Me.statusStrip.Text = "StatusStrip"
        '
        'toolStripStatusLabel
        '
        Me.toolStripStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.toolStripStatusLabel.Name = "toolStripStatusLabel"
        Me.toolStripStatusLabel.Size = New System.Drawing.Size(80, 19)
        Me.toolStripStatusLabel.Text = "Current User:"
        '
        'txtCurrentUser
        '
        Me.txtCurrentUser.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentUser.Name = "txtCurrentUser"
        Me.txtCurrentUser.Size = New System.Drawing.Size(79, 19)
        Me.txtCurrentUser.Text = "Logged out"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(94, 19)
        Me.ToolStripStatusLabel2.Text = "                             "
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(72, 19)
        Me.ToolStripStatusLabel1.Text = "School Year:"
        '
        'txtSchoolYear
        '
        Me.txtSchoolYear.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.txtSchoolYear.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.txtSchoolYear.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSchoolYear.Name = "txtSchoolYear"
        Me.txtSchoolYear.Size = New System.Drawing.Size(39, 19)
        Me.txtSchoolYear.Text = "0000"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'DocumentManager1
        '
        Me.DocumentManager1.MdiParent = Me
        Me.DocumentManager1.View = Me.TabbedView1
        Me.DocumentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.TabbedView1})
        '
        'MainForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.menuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.menuStrip
        Me.Name = "MainForm1"
        Me.Text = "I N T E G R A T E D   C O L L E G E  E N R O L L M E N T  S Y S T E M"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.statusStrip.ResumeLayout(False)
        Me.statusStrip.PerformLayout()
        CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private listOfReportsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Private cHEDReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private toolStripSeparator27 As System.Windows.Forms.ToolStripSeparator
    Private graduatesCandidateForGraduationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private tagGraduatingStudentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private toolStripSeparator26 As System.Windows.Forms.ToolStripSeparator
    Private reportOfGradesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private transcriptOfRecordsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private academicProgramEvaluationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private correctionOfGradesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private gradeEncodingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private toolStripSeparator25 As System.Windows.Forms.ToolStripSeparator
    Private addDropChangeOfCourseWithdrawalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private toolStripSeparator24 As System.Windows.Forms.ToolStripSeparator
    Private gradingSystemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private toolStripSeparator23 As System.Windows.Forms.ToolStripSeparator
    Private toolStripSeparator22 As System.Windows.Forms.ToolStripSeparator
    Private studentProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents settingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private toolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
#End Region


    Private menuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents aboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private viewMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents helpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProspectusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ContactUsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents VersionHistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents loginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents exitApplicationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcademicProgramsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ClassSectionSplitMergeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ClassSectionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileHorizontallyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileVerticallyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdReconnect As System.Windows.Forms.Button
    Private WithEvents statusStrip As System.Windows.Forms.StatusStrip
    Private WithEvents toolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtCurrentUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Public WithEvents txtSchoolYear As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblConnection As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TransactionLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SystemLockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AcademicInstitutionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcademicYearsAndTermsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UserAccountsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdmissionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AccountingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AssessmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BillingAndAssessmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfigurationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DocumentManager1 As DevExpress.XtraBars.Docking2010.DocumentManager
    Friend WithEvents TabbedView1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents EnrollmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CertificateOfRegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator14 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CloneRegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator16 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RegistrationCorrectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrationValidationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator17 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PurgeInvalidatedRegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurgeExpireRegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator18 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ConfigurationToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentMasterListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubjectMasterListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChartsOfAccountsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FeesTemplateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScholarshipTemplatesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PromissoryNotesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JournalEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentLedgerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StudentAccountReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentWithBadAccountsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ListOfReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SchedulerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator15 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ClassSectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoomsAndFacultyUtilizationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator19 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FacultyLoadingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrationAssessmentConfiguraitonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator21 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuBillingSummary As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatementOfAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PermitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator20 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CollegeDepartmentsInstitutesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class



