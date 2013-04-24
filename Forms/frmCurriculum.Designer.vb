Partial Class frmCurriculum
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCurriculum))
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPage1 = New System.Windows.Forms.TabPage()
        Me.dgView = New System.Windows.Forms.DataGridView()
        Me.SubjectCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptiveTitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.popSubjects = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdNewSubject = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditSubject = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDeleteSubject = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuRefreshSubject = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.SubjectEquivalentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.NavBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
        Me.NavBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.cmdAddNewSubject = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarGroupControlContainer1 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.txtWhat = New System.Windows.Forms.TextBox()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboLookFor = New System.Windows.Forms.ComboBox()
        Me.NavBarGroupControlContainer2 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.lvCurriculum = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cboSubProgram = New MTGCComboBox()
        Me.cboSubCampus = New MTGCComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboProgramAccess = New System.Windows.Forms.ComboBox()
        Me.opt2 = New System.Windows.Forms.RadioButton()
        Me.opt1 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NavBarGroup2 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarGroup3 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.tabPage2 = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.lvDetails = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.popDetails = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SetPreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubjectEquivalentToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdRefreshDetails = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdPrintDetails = New System.Windows.Forms.ToolStripMenuItem()
        Me.img16X16 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl4 = New System.Windows.Forms.TabControl()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.listRecord = New System.Windows.Forms.ListView()
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.lsvCurriculum = New System.Windows.Forms.ListView()
        Me._column_11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me._column_12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.popCurriculum = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdNewCur = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdEditCur = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdDeleteCur = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.CourseOutlineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdPrintCurriculumDetails = New System.Windows.Forms.ToolStripMenuItem()
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cboCampus = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cboCampusID = New System.Windows.Forms.ToolStripComboBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.lvFaculty = New System.Windows.Forms.ListView()
        Me.ColumnHeader22 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader37 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader23 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader24 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader25 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader26 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader27 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader28 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader29 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader30 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.XtraTabControl2 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.lvLoadHistory = New System.Windows.Forms.ListView()
        Me.ColumnHeader38 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader39 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader40 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader41 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader42 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader43 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader44 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader45 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader46 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader47 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader48 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader49 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader50 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader51 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader52 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.cboAY = New System.Windows.Forms.ToolStripComboBox()
        Me.cboAYID = New System.Windows.Forms.ToolStripComboBox()
        Me.StatusStrip4 = New System.Windows.Forms.StatusStrip()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.lvSubjectTaught = New System.Windows.Forms.ListView()
        Me.ColumnHeader53 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader54 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader55 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader56 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader57 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader58 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader59 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StatusStrip5 = New System.Windows.Forms.StatusStrip()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.lvOffering = New System.Windows.Forms.ListView()
        Me.ColumnHeader34 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader35 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader36 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clsGrid = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        Me.lblNoOffering = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.lvSection = New System.Windows.Forms.ListView()
        Me.ColumnHeader31 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader32 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader33 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StatusStrip3 = New System.Windows.Forms.StatusStrip()
        Me.lblOfferingSec = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cboSectionType = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboOfferingTerm = New MTGCComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboOfferingCampus = New MTGCComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboProgram = New MTGCComboBox()
        Me.cboCollege = New MTGCComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.imgList32X32 = New System.Windows.Forms.ImageList(Me.components)
        Me.tabControl1.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popSubjects.SuspendLayout()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavBarControl1.SuspendLayout()
        Me.NavBarGroupControlContainer1.SuspendLayout()
        Me.NavBarGroupControlContainer2.SuspendLayout()
        Me.tabPage2.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.popDetails.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabControl4.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.popCurriculum.SuspendLayout()
        Me.toolStrip1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl2.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.XtraTabPage4.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        CType(Me.clsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip2.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.StatusStrip3.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'timer1
        '
        Me.timer1.Enabled = True
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.tabPage1)
        Me.tabControl1.Controls.Add(Me.tabPage2)
        Me.tabControl1.Controls.Add(Me.TabPage3)
        Me.tabControl1.Controls.Add(Me.TabPage7)
        Me.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControl1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabControl1.ImageList = Me.img16X16
        Me.tabControl1.Location = New System.Drawing.Point(0, 0)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(1018, 740)
        Me.tabControl1.TabIndex = 20
        '
        'tabPage1
        '
        Me.tabPage1.Controls.Add(Me.dgView)
        Me.tabPage1.Controls.Add(Me.NavBarControl1)
        Me.tabPage1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabPage1.ImageIndex = 13
        Me.tabPage1.Location = New System.Drawing.Point(4, 23)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage1.Size = New System.Drawing.Size(1010, 713)
        Me.tabPage1.TabIndex = 2
        Me.tabPage1.Text = "Subject Master List"
        Me.tabPage1.UseVisualStyleBackColor = True
        '
        'dgView
        '
        Me.dgView.AllowUserToAddRows = False
        Me.dgView.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SubjectCode, Me.Column21, Me.Column22, Me.DescriptiveTitle, Me.Column9, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column10, Me.Column11, Me.Column12, Me.Column23, Me.Column13, Me.Column14, Me.Column15, Me.Column16, Me.Column17, Me.Column18, Me.Column19, Me.Column20})
        Me.dgView.ContextMenuStrip = Me.popSubjects
        Me.dgView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgView.EnableHeadersVisualStyles = False
        Me.dgView.GridColor = System.Drawing.Color.DeepSkyBlue
        Me.dgView.Location = New System.Drawing.Point(218, 3)
        Me.dgView.MultiSelect = False
        Me.dgView.Name = "dgView"
        Me.dgView.ReadOnly = True
        Me.dgView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgView.Size = New System.Drawing.Size(789, 707)
        Me.dgView.TabIndex = 24
        '
        'SubjectCode
        '
        Me.SubjectCode.HeaderText = "Subject Code"
        Me.SubjectCode.Name = "SubjectCode"
        Me.SubjectCode.ReadOnly = True
        '
        'Column21
        '
        Me.Column21.HeaderText = "Subject ID"
        Me.Column21.Name = "Column21"
        Me.Column21.ReadOnly = True
        Me.Column21.Width = 5
        '
        'Column22
        '
        Me.Column22.HeaderText = "Subject Title"
        Me.Column22.Name = "Column22"
        Me.Column22.ReadOnly = True
        Me.Column22.Width = 200
        '
        'DescriptiveTitle
        '
        Me.DescriptiveTitle.HeaderText = "Descriptive Title"
        Me.DescriptiveTitle.Name = "DescriptiveTitle"
        Me.DescriptiveTitle.ReadOnly = True
        Me.DescriptiveTitle.Width = 300
        '
        'Column9
        '
        Me.Column9.HeaderText = "Alias"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "LAB UNIT"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = "LEC UNIT"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 50
        '
        'Column3
        '
        Me.Column3.HeaderText = "CREDIT UNIT"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 50
        '
        'Column4
        '
        Me.Column4.HeaderText = "LEC HOUR"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 50
        '
        'Column5
        '
        Me.Column5.HeaderText = "LAB HOUR"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 50
        '
        'Column6
        '
        Me.Column6.HeaderText = "General Education"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column6.Width = 70
        '
        'Column7
        '
        Me.Column7.HeaderText = "Elective Subject"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column7.Width = 60
        '
        'Column8
        '
        Me.Column8.HeaderText = "Major Subject"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column8.Width = 60
        '
        'Column10
        '
        Me.Column10.HeaderText = "Computer Subject"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column10.Width = 60
        '
        'Column11
        '
        Me.Column11.HeaderText = "Include in GPA/GWA"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column11.Width = 60
        '
        'Column12
        '
        Me.Column12.HeaderText = "Non-Acad. Subject"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column12.Width = 60
        '
        'Column23
        '
        Me.Column23.HeaderText = "LEVEL"
        Me.Column23.Name = "Column23"
        Me.Column23.ReadOnly = True
        Me.Column23.Width = 170
        '
        'Column13
        '
        Me.Column13.HeaderText = "Min. Slots"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        '
        'Column14
        '
        Me.Column14.HeaderText = "Max. Slots"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        '
        'Column15
        '
        Me.Column15.HeaderText = "Other School"
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        Me.Column15.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column15.Width = 60
        '
        'Column16
        '
        Me.Column16.HeaderText = "In-Active"
        Me.Column16.Name = "Column16"
        Me.Column16.ReadOnly = True
        Me.Column16.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column16.Width = 60
        '
        'Column17
        '
        Me.Column17.HeaderText = "Created By"
        Me.Column17.Name = "Column17"
        Me.Column17.ReadOnly = True
        Me.Column17.Width = 150
        '
        'Column18
        '
        Me.Column18.HeaderText = "Date Created"
        Me.Column18.Name = "Column18"
        Me.Column18.ReadOnly = True
        Me.Column18.Width = 150
        '
        'Column19
        '
        Me.Column19.HeaderText = "Modified By"
        Me.Column19.Name = "Column19"
        Me.Column19.ReadOnly = True
        Me.Column19.Width = 150
        '
        'Column20
        '
        Me.Column20.HeaderText = "Modified Date"
        Me.Column20.Name = "Column20"
        Me.Column20.ReadOnly = True
        Me.Column20.Width = 150
        '
        'popSubjects
        '
        Me.popSubjects.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdNewSubject, Me.mnuEditSubject, Me.mnuDeleteSubject, Me.ToolStripSeparator4, Me.mnuRefreshSubject, Me.ToolStripSeparator7, Me.SubjectEquivalentToolStripMenuItem, Me.PropertiesToolStripMenuItem, Me.ToolStripSeparator8})
        Me.popSubjects.Name = "popSubjects"
        Me.popSubjects.Size = New System.Drawing.Size(189, 154)
        '
        'cmdNewSubject
        '
        Me.cmdNewSubject.Image = CType(resources.GetObject("cmdNewSubject.Image"), System.Drawing.Image)
        Me.cmdNewSubject.Name = "cmdNewSubject"
        Me.cmdNewSubject.Size = New System.Drawing.Size(188, 22)
        Me.cmdNewSubject.Text = "New subject..."
        '
        'mnuEditSubject
        '
        Me.mnuEditSubject.Image = CType(resources.GetObject("mnuEditSubject.Image"), System.Drawing.Image)
        Me.mnuEditSubject.Name = "mnuEditSubject"
        Me.mnuEditSubject.Size = New System.Drawing.Size(188, 22)
        Me.mnuEditSubject.Text = "Edit subject..."
        '
        'mnuDeleteSubject
        '
        Me.mnuDeleteSubject.Image = CType(resources.GetObject("mnuDeleteSubject.Image"), System.Drawing.Image)
        Me.mnuDeleteSubject.Name = "mnuDeleteSubject"
        Me.mnuDeleteSubject.Size = New System.Drawing.Size(188, 22)
        Me.mnuDeleteSubject.Text = "Delete"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(185, 6)
        '
        'mnuRefreshSubject
        '
        Me.mnuRefreshSubject.Image = CType(resources.GetObject("mnuRefreshSubject.Image"), System.Drawing.Image)
        Me.mnuRefreshSubject.Name = "mnuRefreshSubject"
        Me.mnuRefreshSubject.Size = New System.Drawing.Size(188, 22)
        Me.mnuRefreshSubject.Text = "Refresh"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(185, 6)
        '
        'SubjectEquivalentToolStripMenuItem
        '
        Me.SubjectEquivalentToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubjectEquivalentToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SubjectEquivalentToolStripMenuItem.Image = CType(resources.GetObject("SubjectEquivalentToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SubjectEquivalentToolStripMenuItem.Name = "SubjectEquivalentToolStripMenuItem"
        Me.SubjectEquivalentToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.SubjectEquivalentToolStripMenuItem.Text = "Subject Equivalent..."
        '
        'PropertiesToolStripMenuItem
        '
        Me.PropertiesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PropertiesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PropertiesToolStripMenuItem.Name = "PropertiesToolStripMenuItem"
        Me.PropertiesToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.PropertiesToolStripMenuItem.Text = "Subject Properties..."
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(185, 6)
        '
        'NavBarControl1
        '
        Me.NavBarControl1.ActiveGroup = Me.NavBarGroup1
        Me.NavBarControl1.Controls.Add(Me.NavBarGroupControlContainer1)
        Me.NavBarControl1.Controls.Add(Me.NavBarGroupControlContainer2)
        Me.NavBarControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.NavBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.NavBarGroup1, Me.NavBarGroup2, Me.NavBarGroup3})
        Me.NavBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.cmdAddNewSubject})
        Me.NavBarControl1.Location = New System.Drawing.Point(3, 3)
        Me.NavBarControl1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.NavBarControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.NavBarControl1.Name = "NavBarControl1"
        Me.NavBarControl1.OptionsNavPane.ExpandedWidth = 215
        Me.NavBarControl1.Size = New System.Drawing.Size(215, 707)
        Me.NavBarControl1.TabIndex = 23
        Me.NavBarControl1.Text = "NavBarControl1"
        '
        'NavBarGroup1
        '
        Me.NavBarGroup1.Caption = "Subject Management"
        Me.NavBarGroup1.Expanded = True
        Me.NavBarGroup1.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.cmdAddNewSubject)})
        Me.NavBarGroup1.Name = "NavBarGroup1"
        '
        'cmdAddNewSubject
        '
        Me.cmdAddNewSubject.Caption = "New Subject"
        Me.cmdAddNewSubject.Name = "cmdAddNewSubject"
        Me.cmdAddNewSubject.SmallImage = CType(resources.GetObject("cmdAddNewSubject.SmallImage"), System.Drawing.Image)
        '
        'NavBarGroupControlContainer1
        '
        Me.NavBarGroupControlContainer1.Controls.Add(Me.txtWhat)
        Me.NavBarGroupControlContainer1.Controls.Add(Me.cmdSearch)
        Me.NavBarGroupControlContainer1.Controls.Add(Me.Label2)
        Me.NavBarGroupControlContainer1.Controls.Add(Me.Label1)
        Me.NavBarGroupControlContainer1.Controls.Add(Me.cboLookFor)
        Me.NavBarGroupControlContainer1.Name = "NavBarGroupControlContainer1"
        Me.NavBarGroupControlContainer1.Size = New System.Drawing.Size(207, 105)
        Me.NavBarGroupControlContainer1.TabIndex = 0
        '
        'txtWhat
        '
        Me.txtWhat.Location = New System.Drawing.Point(7, 15)
        Me.txtWhat.Name = "txtWhat"
        Me.txtWhat.Size = New System.Drawing.Size(197, 21)
        Me.txtWhat.TabIndex = 5
        '
        'cmdSearch
        '
        Me.cmdSearch.Location = New System.Drawing.Point(127, 75)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(75, 23)
        Me.cmdSearch.TabIndex = 4
        Me.cmdSearch.Text = "Search"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(3, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Look In:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Search What:"
        '
        'cboLookFor
        '
        Me.cboLookFor.FormattingEnabled = True
        Me.cboLookFor.Items.AddRange(New Object() {"Subject Code", "Subject Title", "Alias"})
        Me.cboLookFor.Location = New System.Drawing.Point(7, 51)
        Me.cboLookFor.Name = "cboLookFor"
        Me.cboLookFor.Size = New System.Drawing.Size(198, 21)
        Me.cboLookFor.TabIndex = 2
        '
        'NavBarGroupControlContainer2
        '
        Me.NavBarGroupControlContainer2.Controls.Add(Me.lvCurriculum)
        Me.NavBarGroupControlContainer2.Controls.Add(Me.cboSubProgram)
        Me.NavBarGroupControlContainer2.Controls.Add(Me.cboSubCampus)
        Me.NavBarGroupControlContainer2.Controls.Add(Me.Label4)
        Me.NavBarGroupControlContainer2.Controls.Add(Me.cboProgramAccess)
        Me.NavBarGroupControlContainer2.Controls.Add(Me.opt2)
        Me.NavBarGroupControlContainer2.Controls.Add(Me.opt1)
        Me.NavBarGroupControlContainer2.Controls.Add(Me.Label3)
        Me.NavBarGroupControlContainer2.Name = "NavBarGroupControlContainer2"
        Me.NavBarGroupControlContainer2.Size = New System.Drawing.Size(207, 337)
        Me.NavBarGroupControlContainer2.TabIndex = 1
        '
        'lvCurriculum
        '
        Me.lvCurriculum.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader14, Me.ColumnHeader13})
        Me.lvCurriculum.Enabled = False
        Me.lvCurriculum.FullRowSelect = True
        Me.lvCurriculum.Location = New System.Drawing.Point(-1, 161)
        Me.lvCurriculum.Name = "lvCurriculum"
        Me.lvCurriculum.Size = New System.Drawing.Size(203, 167)
        Me.lvCurriculum.TabIndex = 10
        Me.lvCurriculum.UseCompatibleStateImageBehavior = False
        Me.lvCurriculum.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Curriculum"
        Me.ColumnHeader2.Width = 87
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "ID"
        Me.ColumnHeader14.Width = 0
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Description"
        Me.ColumnHeader13.Width = 104
        '
        'cboSubProgram
        '
        Me.cboSubProgram.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cboSubProgram.ArrowColor = System.Drawing.Color.Black
        Me.cboSubProgram.BindedControl = CType(resources.GetObject("cboSubProgram.BindedControl"), MTGCComboBox.ControlloAssociato)
        Me.cboSubProgram.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D
        Me.cboSubProgram.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboSubProgram.ColumnNum = 4
        Me.cboSubProgram.ColumnWidth = "200;0;121;121"
        Me.cboSubProgram.DisabledArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cboSubProgram.DisabledArrowColor = System.Drawing.Color.LightGray
        Me.cboSubProgram.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.cboSubProgram.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder
        Me.cboSubProgram.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.cboSubProgram.DisplayMember = "Text"
        Me.cboSubProgram.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboSubProgram.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cboSubProgram.DropDownForeColor = System.Drawing.Color.Black
        Me.cboSubProgram.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.cboSubProgram.DropDownWidth = 480
        Me.cboSubProgram.Enabled = False
        Me.cboSubProgram.GridLineColor = System.Drawing.Color.LightGray
        Me.cboSubProgram.GridLineHorizontal = True
        Me.cboSubProgram.GridLineVertical = True
        Me.cboSubProgram.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.cboSubProgram.Location = New System.Drawing.Point(7, 133)
        Me.cboSubProgram.ManagingFastMouseMoving = True
        Me.cboSubProgram.ManagingFastMouseMovingInterval = 30
        Me.cboSubProgram.Name = "cboSubProgram"
        Me.cboSubProgram.SelectedItem = Nothing
        Me.cboSubProgram.SelectedValue = Nothing
        Me.cboSubProgram.Size = New System.Drawing.Size(195, 22)
        Me.cboSubProgram.TabIndex = 9
        '
        'cboSubCampus
        '
        Me.cboSubCampus.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cboSubCampus.ArrowColor = System.Drawing.Color.Black
        Me.cboSubCampus.BindedControl = CType(resources.GetObject("cboSubCampus.BindedControl"), MTGCComboBox.ControlloAssociato)
        Me.cboSubCampus.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D
        Me.cboSubCampus.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboSubCampus.ColumnNum = 2
        Me.cboSubCampus.ColumnWidth = "150;0"
        Me.cboSubCampus.DisabledArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cboSubCampus.DisabledArrowColor = System.Drawing.Color.LightGray
        Me.cboSubCampus.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.cboSubCampus.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder
        Me.cboSubCampus.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.cboSubCampus.DisplayMember = "Text"
        Me.cboSubCampus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboSubCampus.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cboSubCampus.DropDownForeColor = System.Drawing.Color.Black
        Me.cboSubCampus.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.cboSubCampus.DropDownWidth = 200
        Me.cboSubCampus.Enabled = False
        Me.cboSubCampus.GridLineColor = System.Drawing.Color.LightGray
        Me.cboSubCampus.GridLineHorizontal = True
        Me.cboSubCampus.GridLineVertical = True
        Me.cboSubCampus.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.cboSubCampus.Location = New System.Drawing.Point(7, 95)
        Me.cboSubCampus.ManagingFastMouseMoving = True
        Me.cboSubCampus.ManagingFastMouseMovingInterval = 30
        Me.cboSubCampus.Name = "cboSubCampus"
        Me.cboSubCampus.SelectedItem = Nothing
        Me.cboSubCampus.SelectedValue = Nothing
        Me.cboSubCampus.Size = New System.Drawing.Size(195, 22)
        Me.cboSubCampus.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(3, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Academic Program:"
        '
        'cboProgramAccess
        '
        Me.cboProgramAccess.Enabled = False
        Me.cboProgramAccess.FormattingEnabled = True
        Me.cboProgramAccess.Items.AddRange(New Object() {"[View All]", "College Only", "Masteral Only"})
        Me.cboProgramAccess.Location = New System.Drawing.Point(7, 27)
        Me.cboProgramAccess.Name = "cboProgramAccess"
        Me.cboProgramAccess.Size = New System.Drawing.Size(198, 21)
        Me.cboProgramAccess.TabIndex = 6
        '
        'opt2
        '
        Me.opt2.AutoSize = True
        Me.opt2.BackColor = System.Drawing.Color.Transparent
        Me.opt2.Location = New System.Drawing.Point(3, 55)
        Me.opt2.Name = "opt2"
        Me.opt2.Size = New System.Drawing.Size(79, 17)
        Me.opt2.TabIndex = 5
        Me.opt2.TabStop = True
        Me.opt2.Text = "Curriculum:"
        Me.opt2.UseVisualStyleBackColor = False
        '
        'opt1
        '
        Me.opt1.AutoSize = True
        Me.opt1.BackColor = System.Drawing.Color.Transparent
        Me.opt1.Location = New System.Drawing.Point(6, 4)
        Me.opt1.Name = "opt1"
        Me.opt1.Size = New System.Drawing.Size(105, 17)
        Me.opt1.TabIndex = 4
        Me.opt1.TabStop = True
        Me.opt1.Text = "Program Access:"
        Me.opt1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(4, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Campus:"
        '
        'NavBarGroup2
        '
        Me.NavBarGroup2.Caption = "Search Subject"
        Me.NavBarGroup2.ControlContainer = Me.NavBarGroupControlContainer1
        Me.NavBarGroup2.Expanded = True
        Me.NavBarGroup2.GroupClientHeight = 109
        Me.NavBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.NavBarGroup2.Name = "NavBarGroup2"
        '
        'NavBarGroup3
        '
        Me.NavBarGroup3.Caption = "Filter By"
        Me.NavBarGroup3.ControlContainer = Me.NavBarGroupControlContainer2
        Me.NavBarGroup3.Expanded = True
        Me.NavBarGroup3.GroupClientHeight = 341
        Me.NavBarGroup3.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.NavBarGroup3.Name = "NavBarGroup3"
        '
        'tabPage2
        '
        Me.tabPage2.Controls.Add(Me.TabControl2)
        Me.tabPage2.Controls.Add(Me.Panel1)
        Me.tabPage2.Controls.Add(Me.statusStrip1)
        Me.tabPage2.Controls.Add(Me.toolStrip1)
        Me.tabPage2.ImageIndex = 30
        Me.tabPage2.Location = New System.Drawing.Point(4, 23)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage2.Size = New System.Drawing.Size(1010, 713)
        Me.tabPage2.TabIndex = 1
        Me.tabPage2.Text = "Program Curriculums"
        Me.tabPage2.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.ImageList = Me.img16X16
        Me.TabControl2.Location = New System.Drawing.Point(428, 28)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(579, 660)
        Me.TabControl2.TabIndex = 39
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.White
        Me.TabPage4.Controls.Add(Me.lvDetails)
        Me.TabPage4.ImageIndex = 77
        Me.TabPage4.Location = New System.Drawing.Point(4, 23)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(571, 633)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "Curriculum Details"
        '
        'lvDetails
        '
        Me.lvDetails.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17})
        Me.lvDetails.ContextMenuStrip = Me.popDetails
        Me.lvDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvDetails.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvDetails.FullRowSelect = True
        Me.lvDetails.HideSelection = False
        Me.lvDetails.Location = New System.Drawing.Point(3, 3)
        Me.lvDetails.Name = "lvDetails"
        Me.lvDetails.Size = New System.Drawing.Size(565, 627)
        Me.lvDetails.SmallImageList = Me.img16X16
        Me.lvDetails.TabIndex = 38
        Me.lvDetails.UseCompatibleStateImageBehavior = False
        Me.lvDetails.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Subject Code"
        Me.ColumnHeader3.Width = 146
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Descriptive Title"
        Me.ColumnHeader4.Width = 245
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "LAB UNIT"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 77
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "LEC UNIT"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 100
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "CREDIT UNIT"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 89
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Lec. Hour"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 77
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Lab. Hour"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader9.Width = 81
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Pre-requisite"
        Me.ColumnHeader10.Width = 306
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Co-requisite"
        Me.ColumnHeader11.Width = 300
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Equivalent"
        Me.ColumnHeader12.Width = 240
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "SubjectID"
        Me.ColumnHeader15.Width = 0
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "YearTermID"
        Me.ColumnHeader16.Width = 0
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "CurriculumID"
        Me.ColumnHeader17.Width = 0
        '
        'popDetails
        '
        Me.popDetails.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetPreToolStripMenuItem, Me.SubjectEquivalentToolStripMenuItem1, Me.ToolStripSeparator9, Me.cmdRefreshDetails, Me.ToolStripSeparator3, Me.cmdPrintDetails})
        Me.popDetails.Name = "popDetails"
        Me.popDetails.Size = New System.Drawing.Size(231, 104)
        '
        'SetPreToolStripMenuItem
        '
        Me.SetPreToolStripMenuItem.Image = CType(resources.GetObject("SetPreToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SetPreToolStripMenuItem.Name = "SetPreToolStripMenuItem"
        Me.SetPreToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.SetPreToolStripMenuItem.Text = "Set Pre-requisite/Co-requisite"
        '
        'SubjectEquivalentToolStripMenuItem1
        '
        Me.SubjectEquivalentToolStripMenuItem1.Image = CType(resources.GetObject("SubjectEquivalentToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.SubjectEquivalentToolStripMenuItem1.Name = "SubjectEquivalentToolStripMenuItem1"
        Me.SubjectEquivalentToolStripMenuItem1.Size = New System.Drawing.Size(230, 22)
        Me.SubjectEquivalentToolStripMenuItem1.Text = "Set Subject Equivalent"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(227, 6)
        '
        'cmdRefreshDetails
        '
        Me.cmdRefreshDetails.Image = CType(resources.GetObject("cmdRefreshDetails.Image"), System.Drawing.Image)
        Me.cmdRefreshDetails.Name = "cmdRefreshDetails"
        Me.cmdRefreshDetails.Size = New System.Drawing.Size(230, 22)
        Me.cmdRefreshDetails.Text = "Refresh"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(227, 6)
        '
        'cmdPrintDetails
        '
        Me.cmdPrintDetails.Image = CType(resources.GetObject("cmdPrintDetails.Image"), System.Drawing.Image)
        Me.cmdPrintDetails.Name = "cmdPrintDetails"
        Me.cmdPrintDetails.Size = New System.Drawing.Size(230, 22)
        Me.cmdPrintDetails.Text = "Print Prospectus"
        '
        'img16X16
        '
        Me.img16X16.ImageStream = CType(resources.GetObject("img16X16.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.img16X16.TransparentColor = System.Drawing.Color.Transparent
        Me.img16X16.Images.SetKeyName(0, "folder.png")
        Me.img16X16.Images.SetKeyName(1, "folder_yel.png")
        Me.img16X16.Images.SetKeyName(2, "folder_yel_open.png")
        Me.img16X16.Images.SetKeyName(3, "idea.png")
        Me.img16X16.Images.SetKeyName(4, "zoom_in.ico")
        Me.img16X16.Images.SetKeyName(5, "doc_history.ico")
        Me.img16X16.Images.SetKeyName(6, "Windows 7 (198).png")
        Me.img16X16.Images.SetKeyName(7, "app.ico")
        Me.img16X16.Images.SetKeyName(8, "calculator.ico")
        Me.img16X16.Images.SetKeyName(9, "camera.ico")
        Me.img16X16.Images.SetKeyName(10, "comp.ico")
        Me.img16X16.Images.SetKeyName(11, "comp_search.ico")
        Me.img16X16.Images.SetKeyName(12, "convert_to_audio.ico")
        Me.img16X16.Images.SetKeyName(13, "doc_edit.ico")
        Me.img16X16.Images.SetKeyName(14, "doc_favor.ico")
        Me.img16X16.Images.SetKeyName(15, "doc_history.ico")
        Me.img16X16.Images.SetKeyName(16, "doc_new.ico")
        Me.img16X16.Images.SetKeyName(17, "doc_refresh.ico")
        Me.img16X16.Images.SetKeyName(18, "doc_remove.ico")
        Me.img16X16.Images.SetKeyName(19, "doc_remove2.ico")
        Me.img16X16.Images.SetKeyName(20, "doc_star.ico")
        Me.img16X16.Images.SetKeyName(21, "doc_stats.ico")
        Me.img16X16.Images.SetKeyName(22, "doc_user.ico")
        Me.img16X16.Images.SetKeyName(23, "down2.ico")
        Me.img16X16.Images.SetKeyName(24, "exit.ico")
        Me.img16X16.Images.SetKeyName(25, "folder.ico")
        Me.img16X16.Images.SetKeyName(26, "folder_add.ico")
        Me.img16X16.Images.SetKeyName(27, "folder_app.ico")
        Me.img16X16.Images.SetKeyName(28, "folder_doc.ico")
        Me.img16X16.Images.SetKeyName(29, "folder_edit.ico")
        Me.img16X16.Images.SetKeyName(30, "folder_font.ico")
        Me.img16X16.Images.SetKeyName(31, "folder_in.ico")
        Me.img16X16.Images.SetKeyName(32, "folder_out.ico")
        Me.img16X16.Images.SetKeyName(33, "folder_stats.ico")
        Me.img16X16.Images.SetKeyName(34, "font.ico")
        Me.img16X16.Images.SetKeyName(35, "help.ico")
        Me.img16X16.Images.SetKeyName(36, "home.ico")
        Me.img16X16.Images.SetKeyName(37, "info.ico")
        Me.img16X16.Images.SetKeyName(38, "key.ico")
        Me.img16X16.Images.SetKeyName(39, "ok.ico")
        Me.img16X16.Images.SetKeyName(40, "ok2.ico")
        Me.img16X16.Images.SetKeyName(41, "paste.ico")
        Me.img16X16.Images.SetKeyName(42, "pen_yellow.ico")
        Me.img16X16.Images.SetKeyName(43, "picture.ico")
        Me.img16X16.Images.SetKeyName(44, "point_blue.ico")
        Me.img16X16.Images.SetKeyName(45, "point_cyan.ico")
        Me.img16X16.Images.SetKeyName(46, "point_green.ico")
        Me.img16X16.Images.SetKeyName(47, "point_red.ico")
        Me.img16X16.Images.SetKeyName(48, "point_yellow.ico")
        Me.img16X16.Images.SetKeyName(49, "print_preview.ico")
        Me.img16X16.Images.SetKeyName(50, "printer.ico")
        Me.img16X16.Images.SetKeyName(51, "rect_blue.ico")
        Me.img16X16.Images.SetKeyName(52, "rect_cyan.ico")
        Me.img16X16.Images.SetKeyName(53, "rect_green.ico")
        Me.img16X16.Images.SetKeyName(54, "rect_red.ico")
        Me.img16X16.Images.SetKeyName(55, "rect_yellow.ico")
        Me.img16X16.Images.SetKeyName(56, "save.ico")
        Me.img16X16.Images.SetKeyName(57, "search.ico")
        Me.img16X16.Images.SetKeyName(58, "triang_cyan.ico")
        Me.img16X16.Images.SetKeyName(59, "triang_green.ico")
        Me.img16X16.Images.SetKeyName(60, "triang_red.ico")
        Me.img16X16.Images.SetKeyName(61, "triang_yellow.ico")
        Me.img16X16.Images.SetKeyName(62, "user.ico")
        Me.img16X16.Images.SetKeyName(63, "user2.ico")
        Me.img16X16.Images.SetKeyName(64, "user3.ico")
        Me.img16X16.Images.SetKeyName(65, "user_add.ico")
        Me.img16X16.Images.SetKeyName(66, "user_edit.ico")
        Me.img16X16.Images.SetKeyName(67, "user_remove.ico")
        Me.img16X16.Images.SetKeyName(68, "user_search.ico")
        Me.img16X16.Images.SetKeyName(69, "users.ico")
        Me.img16X16.Images.SetKeyName(70, "Windows 7 (78).png")
        Me.img16X16.Images.SetKeyName(71, "Windows 7 (87).png")
        Me.img16X16.Images.SetKeyName(72, "Windows 7 (88).png")
        Me.img16X16.Images.SetKeyName(73, "Windows 7 (110).png")
        Me.img16X16.Images.SetKeyName(74, "Windows 7 (171).png")
        Me.img16X16.Images.SetKeyName(75, "Windows 7 (172).png")
        Me.img16X16.Images.SetKeyName(76, "Windows 7 (196).png")
        Me.img16X16.Images.SetKeyName(77, "Windows 7 (206).png")
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TabControl4)
        Me.Panel1.Controls.Add(Me.TabControl3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(3, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(425, 660)
        Me.Panel1.TabIndex = 38
        '
        'TabControl4
        '
        Me.TabControl4.Controls.Add(Me.TabPage6)
        Me.TabControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl4.Location = New System.Drawing.Point(0, 0)
        Me.TabControl4.Name = "TabControl4"
        Me.TabControl4.SelectedIndex = 0
        Me.TabControl4.Size = New System.Drawing.Size(425, 357)
        Me.TabControl4.TabIndex = 4
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.listRecord)
        Me.TabPage6.Location = New System.Drawing.Point(4, 23)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(417, 330)
        Me.TabPage6.TabIndex = 0
        Me.TabPage6.Text = "Academic Program"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'listRecord
        '
        Me.listRecord.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader21})
        Me.listRecord.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listRecord.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listRecord.FullRowSelect = True
        Me.listRecord.Location = New System.Drawing.Point(3, 3)
        Me.listRecord.Name = "listRecord"
        Me.listRecord.Size = New System.Drawing.Size(411, 324)
        Me.listRecord.TabIndex = 6
        Me.listRecord.UseCompatibleStateImageBehavior = False
        Me.listRecord.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "PROGRAM CODE"
        Me.ColumnHeader18.Width = 115
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "PROGRAM ID"
        Me.ColumnHeader19.Width = 0
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "ACADEMIC PROGRAM"
        Me.ColumnHeader20.Width = 248
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "COLLEGE CODE"
        Me.ColumnHeader21.Width = 104
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabPage5)
        Me.TabControl3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabControl3.Location = New System.Drawing.Point(0, 357)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(425, 303)
        Me.TabControl3.TabIndex = 3
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.lsvCurriculum)
        Me.TabPage5.Location = New System.Drawing.Point(4, 23)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(417, 276)
        Me.TabPage5.TabIndex = 1
        Me.TabPage5.Text = "Program Curriculum"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'lsvCurriculum
        '
        Me.lsvCurriculum.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me._column_11, Me.ColumnHeader1, Me._column_12})
        Me.lsvCurriculum.ContextMenuStrip = Me.popCurriculum
        Me.lsvCurriculum.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsvCurriculum.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvCurriculum.FullRowSelect = True
        Me.lsvCurriculum.HideSelection = False
        Me.lsvCurriculum.Location = New System.Drawing.Point(3, 3)
        Me.lsvCurriculum.Name = "lsvCurriculum"
        Me.lsvCurriculum.Size = New System.Drawing.Size(411, 270)
        Me.lsvCurriculum.SmallImageList = Me.img16X16
        Me.lsvCurriculum.TabIndex = 38
        Me.lsvCurriculum.UseCompatibleStateImageBehavior = False
        Me.lsvCurriculum.View = System.Windows.Forms.View.Details
        '
        '_column_11
        '
        Me._column_11.Name = "_column_11"
        Me._column_11.Text = "Curriculum Code"
        Me._column_11.Width = 119
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 0
        '
        '_column_12
        '
        Me._column_12.Name = "_column_12"
        Me._column_12.Text = "Description"
        Me._column_12.Width = 231
        '
        'popCurriculum
        '
        Me.popCurriculum.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdNewCur, Me.cmdEditCur, Me.cmdDeleteCur, Me.ToolStripSeparator5, Me.cmdRefresh, Me.ToolStripSeparator6, Me.CourseOutlineToolStripMenuItem, Me.ToolStripSeparator1, Me.cmdPrintCurriculumDetails})
        Me.popCurriculum.Name = "popCurriculum"
        Me.popCurriculum.Size = New System.Drawing.Size(201, 154)
        '
        'cmdNewCur
        '
        Me.cmdNewCur.Image = CType(resources.GetObject("cmdNewCur.Image"), System.Drawing.Image)
        Me.cmdNewCur.Name = "cmdNewCur"
        Me.cmdNewCur.Size = New System.Drawing.Size(200, 22)
        Me.cmdNewCur.Text = "New Curriculum"
        '
        'cmdEditCur
        '
        Me.cmdEditCur.Image = CType(resources.GetObject("cmdEditCur.Image"), System.Drawing.Image)
        Me.cmdEditCur.Name = "cmdEditCur"
        Me.cmdEditCur.Size = New System.Drawing.Size(200, 22)
        Me.cmdEditCur.Text = "Edit Curriculum"
        '
        'cmdDeleteCur
        '
        Me.cmdDeleteCur.Image = CType(resources.GetObject("cmdDeleteCur.Image"), System.Drawing.Image)
        Me.cmdDeleteCur.Name = "cmdDeleteCur"
        Me.cmdDeleteCur.Size = New System.Drawing.Size(200, 22)
        Me.cmdDeleteCur.Text = "Delete"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(197, 6)
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Image = CType(resources.GetObject("cmdRefresh.Image"), System.Drawing.Image)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(200, 22)
        Me.cmdRefresh.Text = "Refresh"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(197, 6)
        '
        'CourseOutlineToolStripMenuItem
        '
        Me.CourseOutlineToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CourseOutlineToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CourseOutlineToolStripMenuItem.Image = CType(resources.GetObject("CourseOutlineToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CourseOutlineToolStripMenuItem.Name = "CourseOutlineToolStripMenuItem"
        Me.CourseOutlineToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.CourseOutlineToolStripMenuItem.Text = "Course Outline"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(197, 6)
        '
        'cmdPrintCurriculumDetails
        '
        Me.cmdPrintCurriculumDetails.Image = CType(resources.GetObject("cmdPrintCurriculumDetails.Image"), System.Drawing.Image)
        Me.cmdPrintCurriculumDetails.Name = "cmdPrintCurriculumDetails"
        Me.cmdPrintCurriculumDetails.Size = New System.Drawing.Size(200, 22)
        Me.cmdPrintCurriculumDetails.Text = "Print Curriculum Details"
        '
        'statusStrip1
        '
        Me.statusStrip1.Location = New System.Drawing.Point(3, 688)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.Size = New System.Drawing.Size(1004, 22)
        Me.statusStrip1.TabIndex = 35
        Me.statusStrip1.Text = "statusStrip1"
        '
        'toolStrip1
        '
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboCampus, Me.ToolStripSeparator2, Me.cboCampusID})
        Me.toolStrip1.Location = New System.Drawing.Point(3, 3)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New System.Drawing.Size(1004, 25)
        Me.toolStrip1.TabIndex = 29
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(93, 22)
        Me.ToolStripLabel1.Text = "Select Campus:"
        '
        'cboCampus
        '
        Me.cboCampus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboCampus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCampus.Name = "cboCampus"
        Me.cboCampus.Size = New System.Drawing.Size(250, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'cboCampusID
        '
        Me.cboCampusID.Name = "cboCampusID"
        Me.cboCampusID.Size = New System.Drawing.Size(75, 25)
        Me.cboCampusID.Visible = False
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.XtraTabControl1)
        Me.TabPage3.ImageIndex = 75
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1010, 713)
        Me.TabPage3.TabIndex = 3
        Me.TabPage3.Text = "Faculty / Teaching Staff"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(3, 3)
        Me.XtraTabControl1.LookAndFeel.SkinName = "VS2010"
        Me.XtraTabControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage2
        Me.XtraTabControl1.Size = New System.Drawing.Size(1004, 707)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage2})
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.lvFaculty)
        Me.XtraTabPage2.Controls.Add(Me.XtraTabControl2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1002, 674)
        Me.XtraTabPage2.Text = "Faculty Masterlist"
        '
        'lvFaculty
        '
        Me.lvFaculty.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader22, Me.ColumnHeader37, Me.ColumnHeader23, Me.ColumnHeader24, Me.ColumnHeader25, Me.ColumnHeader26, Me.ColumnHeader27, Me.ColumnHeader28, Me.ColumnHeader29, Me.ColumnHeader30})
        Me.lvFaculty.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvFaculty.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvFaculty.FullRowSelect = True
        Me.lvFaculty.GridLines = True
        Me.lvFaculty.Location = New System.Drawing.Point(0, 0)
        Me.lvFaculty.Name = "lvFaculty"
        Me.lvFaculty.Size = New System.Drawing.Size(1002, 353)
        Me.lvFaculty.TabIndex = 3
        Me.lvFaculty.UseCompatibleStateImageBehavior = False
        Me.lvFaculty.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "EMPLOYEE NO."
        Me.ColumnHeader22.Width = 127
        '
        'ColumnHeader37
        '
        Me.ColumnHeader37.Text = "FACULTY ID"
        Me.ColumnHeader37.Width = 0
        '
        'ColumnHeader23
        '
        Me.ColumnHeader23.Text = "FULL NAME"
        Me.ColumnHeader23.Width = 233
        '
        'ColumnHeader24
        '
        Me.ColumnHeader24.Text = "BIRTH DATE"
        Me.ColumnHeader24.Width = 146
        '
        'ColumnHeader25
        '
        Me.ColumnHeader25.Text = "EMP. STATUS"
        Me.ColumnHeader25.Width = 95
        '
        'ColumnHeader26
        '
        Me.ColumnHeader26.Text = "POSITION"
        Me.ColumnHeader26.Width = 221
        '
        'ColumnHeader27
        '
        Me.ColumnHeader27.Text = "DEPARTMENT"
        Me.ColumnHeader27.Width = 209
        '
        'ColumnHeader28
        '
        Me.ColumnHeader28.Text = "RANK"
        Me.ColumnHeader28.Width = 171
        '
        'ColumnHeader29
        '
        Me.ColumnHeader29.Text = "FAC. COLLEGE"
        Me.ColumnHeader29.Width = 195
        '
        'ColumnHeader30
        '
        Me.ColumnHeader30.Text = "FAC. CAMPUS"
        Me.ColumnHeader30.Width = 173
        '
        'XtraTabControl2
        '
        Me.XtraTabControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.XtraTabControl2.Location = New System.Drawing.Point(0, 353)
        Me.XtraTabControl2.LookAndFeel.SkinName = "VS2010"
        Me.XtraTabControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.XtraTabControl2.Name = "XtraTabControl2"
        Me.XtraTabControl2.SelectedTabPage = Me.XtraTabPage3
        Me.XtraTabControl2.Size = New System.Drawing.Size(1002, 321)
        Me.XtraTabControl2.TabIndex = 0
        Me.XtraTabControl2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage3, Me.XtraTabPage4})
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.lvLoadHistory)
        Me.XtraTabPage3.Controls.Add(Me.ToolStrip2)
        Me.XtraTabPage3.Controls.Add(Me.StatusStrip4)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(1000, 288)
        Me.XtraTabPage3.Text = "Teaching Load History"
        '
        'lvLoadHistory
        '
        Me.lvLoadHistory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader38, Me.ColumnHeader39, Me.ColumnHeader40, Me.ColumnHeader41, Me.ColumnHeader42, Me.ColumnHeader43, Me.ColumnHeader44, Me.ColumnHeader45, Me.ColumnHeader46, Me.ColumnHeader47, Me.ColumnHeader48, Me.ColumnHeader49, Me.ColumnHeader50, Me.ColumnHeader51, Me.ColumnHeader52})
        Me.lvLoadHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvLoadHistory.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvLoadHistory.Location = New System.Drawing.Point(0, 25)
        Me.lvLoadHistory.Name = "lvLoadHistory"
        Me.lvLoadHistory.Size = New System.Drawing.Size(1000, 241)
        Me.lvLoadHistory.TabIndex = 2
        Me.lvLoadHistory.UseCompatibleStateImageBehavior = False
        Me.lvLoadHistory.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader38
        '
        Me.ColumnHeader38.Text = "ACAD. YR."
        Me.ColumnHeader38.Width = 122
        '
        'ColumnHeader39
        '
        Me.ColumnHeader39.Text = "TERM"
        Me.ColumnHeader39.Width = 117
        '
        'ColumnHeader40
        '
        Me.ColumnHeader40.Text = "SUBJECT CODE"
        Me.ColumnHeader40.Width = 125
        '
        'ColumnHeader41
        '
        Me.ColumnHeader41.Text = "SUBJ. TITLE"
        Me.ColumnHeader41.Width = 222
        '
        'ColumnHeader42
        '
        Me.ColumnHeader42.Text = "SECTION"
        Me.ColumnHeader42.Width = 120
        '
        'ColumnHeader43
        '
        Me.ColumnHeader43.Text = "SCHEDULE 1"
        Me.ColumnHeader43.Width = 249
        '
        'ColumnHeader44
        '
        Me.ColumnHeader44.Text = "ROOM 1"
        Me.ColumnHeader44.Width = 109
        '
        'ColumnHeader45
        '
        Me.ColumnHeader45.Text = "SCHEDULE 2"
        Me.ColumnHeader45.Width = 215
        '
        'ColumnHeader46
        '
        Me.ColumnHeader46.Text = "ROOM 2"
        Me.ColumnHeader46.Width = 116
        '
        'ColumnHeader47
        '
        Me.ColumnHeader47.Text = "SCHEDULE 3"
        Me.ColumnHeader47.Width = 261
        '
        'ColumnHeader48
        '
        Me.ColumnHeader48.Text = "ROOM 3"
        Me.ColumnHeader48.Width = 113
        '
        'ColumnHeader49
        '
        Me.ColumnHeader49.Text = "SCHEDULE 4"
        Me.ColumnHeader49.Width = 251
        '
        'ColumnHeader50
        '
        Me.ColumnHeader50.Text = "ROOM 4"
        Me.ColumnHeader50.Width = 96
        '
        'ColumnHeader51
        '
        Me.ColumnHeader51.Text = "SCHEDULE 5"
        Me.ColumnHeader51.Width = 220
        '
        'ColumnHeader52
        '
        Me.ColumnHeader52.Text = "ROOM 5"
        Me.ColumnHeader52.Width = 104
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.ToolStripSeparator10, Me.cboAY, Me.cboAYID})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1000, 25)
        Me.ToolStrip2.TabIndex = 1
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(123, 22)
        Me.ToolStripLabel2.Text = "Select Academic Year:"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'cboAY
        '
        Me.cboAY.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboAY.Name = "cboAY"
        Me.cboAY.Size = New System.Drawing.Size(200, 25)
        '
        'cboAYID
        '
        Me.cboAYID.Name = "cboAYID"
        Me.cboAYID.Size = New System.Drawing.Size(75, 25)
        Me.cboAYID.Visible = False
        '
        'StatusStrip4
        '
        Me.StatusStrip4.Location = New System.Drawing.Point(0, 266)
        Me.StatusStrip4.Name = "StatusStrip4"
        Me.StatusStrip4.Size = New System.Drawing.Size(1000, 22)
        Me.StatusStrip4.TabIndex = 0
        Me.StatusStrip4.Text = "StatusStrip4"
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.lvSubjectTaught)
        Me.XtraTabPage4.Controls.Add(Me.StatusStrip5)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(1000, 288)
        Me.XtraTabPage4.Text = "Subject Taught"
        '
        'lvSubjectTaught
        '
        Me.lvSubjectTaught.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader53, Me.ColumnHeader54, Me.ColumnHeader55, Me.ColumnHeader56, Me.ColumnHeader57, Me.ColumnHeader58, Me.ColumnHeader59})
        Me.lvSubjectTaught.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvSubjectTaught.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvSubjectTaught.FullRowSelect = True
        Me.lvSubjectTaught.GridLines = True
        Me.lvSubjectTaught.Location = New System.Drawing.Point(0, 0)
        Me.lvSubjectTaught.Name = "lvSubjectTaught"
        Me.lvSubjectTaught.Size = New System.Drawing.Size(1000, 266)
        Me.lvSubjectTaught.TabIndex = 2
        Me.lvSubjectTaught.UseCompatibleStateImageBehavior = False
        Me.lvSubjectTaught.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader53
        '
        Me.ColumnHeader53.Text = "SUBJECT CODE"
        Me.ColumnHeader53.Width = 141
        '
        'ColumnHeader54
        '
        Me.ColumnHeader54.Text = "SUBJECT ID"
        Me.ColumnHeader54.Width = 0
        '
        'ColumnHeader55
        '
        Me.ColumnHeader55.Text = "DESCRIPTIVE TITLE"
        Me.ColumnHeader55.Width = 374
        '
        'ColumnHeader56
        '
        Me.ColumnHeader56.Text = "LEC. UNITS"
        Me.ColumnHeader56.Width = 78
        '
        'ColumnHeader57
        '
        Me.ColumnHeader57.Text = "LAB. UNITS"
        Me.ColumnHeader57.Width = 80
        '
        'ColumnHeader58
        '
        Me.ColumnHeader58.Text = "LEC. HRS"
        Me.ColumnHeader58.Width = 72
        '
        'ColumnHeader59
        '
        Me.ColumnHeader59.Text = "LAB. HRS"
        Me.ColumnHeader59.Width = 75
        '
        'StatusStrip5
        '
        Me.StatusStrip5.Location = New System.Drawing.Point(0, 266)
        Me.StatusStrip5.Name = "StatusStrip5"
        Me.StatusStrip5.Size = New System.Drawing.Size(1000, 22)
        Me.StatusStrip5.TabIndex = 1
        Me.StatusStrip5.Text = "StatusStrip5"
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.TabControl)
        Me.TabPage7.Controls.Add(Me.clsGrid)
        Me.TabPage7.Controls.Add(Me.StatusStrip2)
        Me.TabPage7.Controls.Add(Me.GroupControl2)
        Me.TabPage7.ImageIndex = 41
        Me.TabPage7.Location = New System.Drawing.Point(4, 23)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(1010, 713)
        Me.TabPage7.TabIndex = 4
        Me.TabPage7.Text = "Subject Offering"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPage8)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Location = New System.Drawing.Point(389, 178)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(618, 508)
        Me.TabControl.TabIndex = 17
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.lvOffering)
        Me.TabPage8.Location = New System.Drawing.Point(4, 23)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(610, 481)
        Me.TabPage8.TabIndex = 0
        Me.TabPage8.Text = "Subject Offering List"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'lvOffering
        '
        Me.lvOffering.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader34, Me.ColumnHeader35, Me.ColumnHeader36})
        Me.lvOffering.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvOffering.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvOffering.FullRowSelect = True
        Me.lvOffering.GridLines = True
        Me.lvOffering.Location = New System.Drawing.Point(3, 3)
        Me.lvOffering.Name = "lvOffering"
        Me.lvOffering.Size = New System.Drawing.Size(604, 475)
        Me.lvOffering.TabIndex = 5
        Me.lvOffering.UseCompatibleStateImageBehavior = False
        Me.lvOffering.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader34
        '
        Me.ColumnHeader34.Text = "SECTION NAME"
        Me.ColumnHeader34.Width = 135
        '
        'ColumnHeader35
        '
        Me.ColumnHeader35.Text = "SECTION ID"
        Me.ColumnHeader35.Width = 0
        '
        'ColumnHeader36
        '
        Me.ColumnHeader36.Text = "PROGRAM"
        Me.ColumnHeader36.Width = 199
        '
        'clsGrid
        '
        Me.clsGrid.Cols = 32
        Me.clsGrid.ColumnInfo = resources.GetString("clsGrid.ColumnInfo")
        Me.clsGrid.Dock = System.Windows.Forms.DockStyle.Top
        Me.clsGrid.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clsGrid.GridColorFixed = System.Drawing.SystemColors.ControlDark
        Me.clsGrid.Location = New System.Drawing.Point(389, 3)
        Me.clsGrid.Name = "clsGrid"
        Me.clsGrid.NodeClosedPicture = Nothing
        Me.clsGrid.NodeOpenPicture = Nothing
        Me.clsGrid.OutlineCol = -1
        Me.clsGrid.RowHeightMax = 18
        Me.clsGrid.RowHeightMin = 20
        Me.clsGrid.Rows = 8
        Me.clsGrid.Size = New System.Drawing.Size(618, 175)
        Me.clsGrid.StyleInfo = resources.GetString("clsGrid.StyleInfo")
        Me.clsGrid.TabIndex = 16
        Me.clsGrid.TreeColor = System.Drawing.Color.DarkGray
        '
        'StatusStrip2
        '
        Me.StatusStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblNoOffering})
        Me.StatusStrip2.Location = New System.Drawing.Point(389, 686)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.Size = New System.Drawing.Size(618, 24)
        Me.StatusStrip2.TabIndex = 1
        Me.StatusStrip2.Text = "StatusStrip2"
        '
        'lblNoOffering
        '
        Me.lblNoOffering.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.lblNoOffering.Name = "lblNoOffering"
        Me.lblNoOffering.Size = New System.Drawing.Size(112, 19)
        Me.lblNoOffering.Text = "0 Regular Offerings"
        '
        'GroupControl2
        '
        Me.GroupControl2.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.GroupControl2.Appearance.Options.UseBackColor = True
        Me.GroupControl2.Controls.Add(Me.lvSection)
        Me.GroupControl2.Controls.Add(Me.StatusStrip3)
        Me.GroupControl2.Controls.Add(Me.PanelControl1)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupControl2.Location = New System.Drawing.Point(3, 3)
        Me.GroupControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.GroupControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(386, 707)
        Me.GroupControl2.TabIndex = 0
        Me.GroupControl2.Text = "SUBJECT OFFERING PARAMETERS"
        '
        'lvSection
        '
        Me.lvSection.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader31, Me.ColumnHeader32, Me.ColumnHeader33})
        Me.lvSection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvSection.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvSection.FullRowSelect = True
        Me.lvSection.GridLines = True
        Me.lvSection.Location = New System.Drawing.Point(2, 241)
        Me.lvSection.Name = "lvSection"
        Me.lvSection.Size = New System.Drawing.Size(382, 440)
        Me.lvSection.TabIndex = 17
        Me.lvSection.UseCompatibleStateImageBehavior = False
        Me.lvSection.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader31
        '
        Me.ColumnHeader31.Text = "SECTION NAME"
        Me.ColumnHeader31.Width = 135
        '
        'ColumnHeader32
        '
        Me.ColumnHeader32.Text = "SECTION ID"
        Me.ColumnHeader32.Width = 0
        '
        'ColumnHeader33
        '
        Me.ColumnHeader33.Text = "PROGRAM"
        Me.ColumnHeader33.Width = 229
        '
        'StatusStrip3
        '
        Me.StatusStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblOfferingSec})
        Me.StatusStrip3.Location = New System.Drawing.Point(2, 681)
        Me.StatusStrip3.Name = "StatusStrip3"
        Me.StatusStrip3.Size = New System.Drawing.Size(382, 24)
        Me.StatusStrip3.TabIndex = 16
        Me.StatusStrip3.Text = "StatusStrip3"
        '
        'lblOfferingSec
        '
        Me.lblOfferingSec.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.lblOfferingSec.Name = "lblOfferingSec"
        Me.lblOfferingSec.Size = New System.Drawing.Size(128, 19)
        Me.lblOfferingSec.Text = "Total No. of Section: 0"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cboSectionType)
        Me.PanelControl1.Controls.Add(Me.Label6)
        Me.PanelControl1.Controls.Add(Me.Label12)
        Me.PanelControl1.Controls.Add(Me.cboOfferingTerm)
        Me.PanelControl1.Controls.Add(Me.Label11)
        Me.PanelControl1.Controls.Add(Me.Label7)
        Me.PanelControl1.Controls.Add(Me.cboOfferingCampus)
        Me.PanelControl1.Controls.Add(Me.Label10)
        Me.PanelControl1.Controls.Add(Me.Label8)
        Me.PanelControl1.Controls.Add(Me.cboProgram)
        Me.PanelControl1.Controls.Add(Me.cboCollege)
        Me.PanelControl1.Controls.Add(Me.Label9)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(2, 18)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(382, 223)
        Me.PanelControl1.TabIndex = 15
        '
        'cboSectionType
        '
        Me.cboSectionType.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSectionType.FormattingEnabled = True
        Me.cboSectionType.Items.AddRange(New Object() {"Both Block and Free Section(s)", "Block Section(s) Only", "Free Section(s) Only"})
        Me.cboSectionType.Location = New System.Drawing.Point(123, 178)
        Me.cboSectionType.Name = "cboSectionType"
        Me.cboSectionType.Size = New System.Drawing.Size(249, 22)
        Me.cboSectionType.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(5, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Academic Year And Term:"
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 161)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(367, 2)
        Me.Label12.TabIndex = 14
        '
        'cboOfferingTerm
        '
        Me.cboOfferingTerm.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cboOfferingTerm.ArrowColor = System.Drawing.Color.Black
        Me.cboOfferingTerm.BindedControl = CType(resources.GetObject("cboOfferingTerm.BindedControl"), MTGCComboBox.ControlloAssociato)
        Me.cboOfferingTerm.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D
        Me.cboOfferingTerm.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboOfferingTerm.ColumnNum = 2
        Me.cboOfferingTerm.ColumnWidth = "200;0"
        Me.cboOfferingTerm.DisabledArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cboOfferingTerm.DisabledArrowColor = System.Drawing.Color.LightGray
        Me.cboOfferingTerm.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.cboOfferingTerm.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder
        Me.cboOfferingTerm.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.cboOfferingTerm.DisplayMember = "Text"
        Me.cboOfferingTerm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboOfferingTerm.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cboOfferingTerm.DropDownForeColor = System.Drawing.Color.Black
        Me.cboOfferingTerm.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.cboOfferingTerm.DropDownWidth = 220
        Me.cboOfferingTerm.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOfferingTerm.GridLineColor = System.Drawing.Color.LightGray
        Me.cboOfferingTerm.GridLineHorizontal = False
        Me.cboOfferingTerm.GridLineVertical = False
        Me.cboOfferingTerm.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.cboOfferingTerm.Location = New System.Drawing.Point(163, 15)
        Me.cboOfferingTerm.ManagingFastMouseMoving = True
        Me.cboOfferingTerm.ManagingFastMouseMovingInterval = 30
        Me.cboOfferingTerm.Name = "cboOfferingTerm"
        Me.cboOfferingTerm.SelectedItem = Nothing
        Me.cboOfferingTerm.SelectedValue = Nothing
        Me.cboOfferingTerm.Size = New System.Drawing.Size(209, 23)
        Me.cboOfferingTerm.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 51)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(367, 2)
        Me.Label11.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(5, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 14)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Campus Name:"
        '
        'cboOfferingCampus
        '
        Me.cboOfferingCampus.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cboOfferingCampus.ArrowColor = System.Drawing.Color.Black
        Me.cboOfferingCampus.BindedControl = CType(resources.GetObject("cboOfferingCampus.BindedControl"), MTGCComboBox.ControlloAssociato)
        Me.cboOfferingCampus.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D
        Me.cboOfferingCampus.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboOfferingCampus.ColumnNum = 2
        Me.cboOfferingCampus.ColumnWidth = "200;0"
        Me.cboOfferingCampus.DisabledArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cboOfferingCampus.DisabledArrowColor = System.Drawing.Color.LightGray
        Me.cboOfferingCampus.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.cboOfferingCampus.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder
        Me.cboOfferingCampus.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.cboOfferingCampus.DisplayMember = "Text"
        Me.cboOfferingCampus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboOfferingCampus.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cboOfferingCampus.DropDownForeColor = System.Drawing.Color.Black
        Me.cboOfferingCampus.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.cboOfferingCampus.DropDownWidth = 220
        Me.cboOfferingCampus.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOfferingCampus.GridLineColor = System.Drawing.Color.LightGray
        Me.cboOfferingCampus.GridLineHorizontal = False
        Me.cboOfferingCampus.GridLineVertical = False
        Me.cboOfferingCampus.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.cboOfferingCampus.Location = New System.Drawing.Point(123, 64)
        Me.cboOfferingCampus.ManagingFastMouseMoving = True
        Me.cboOfferingCampus.ManagingFastMouseMovingInterval = 30
        Me.cboOfferingCampus.Name = "cboOfferingCampus"
        Me.cboOfferingCampus.SelectedItem = Nothing
        Me.cboOfferingCampus.SelectedValue = Nothing
        Me.cboOfferingCampus.Size = New System.Drawing.Size(249, 23)
        Me.cboOfferingCampus.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(5, 178)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 14)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Section Type:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(5, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 14)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "College Name:"
        '
        'cboProgram
        '
        Me.cboProgram.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cboProgram.ArrowColor = System.Drawing.Color.Black
        Me.cboProgram.BindedControl = CType(resources.GetObject("cboProgram.BindedControl"), MTGCComboBox.ControlloAssociato)
        Me.cboProgram.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D
        Me.cboProgram.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboProgram.ColumnNum = 4
        Me.cboProgram.ColumnWidth = "120;300;100;0"
        Me.cboProgram.DisabledArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cboProgram.DisabledArrowColor = System.Drawing.Color.LightGray
        Me.cboProgram.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.cboProgram.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder
        Me.cboProgram.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.cboProgram.DisplayMember = "Text"
        Me.cboProgram.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboProgram.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cboProgram.DropDownForeColor = System.Drawing.Color.Black
        Me.cboProgram.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.cboProgram.DropDownWidth = 540
        Me.cboProgram.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProgram.GridLineColor = System.Drawing.Color.LightGray
        Me.cboProgram.GridLineHorizontal = False
        Me.cboProgram.GridLineVertical = False
        Me.cboProgram.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.cboProgram.Location = New System.Drawing.Point(123, 122)
        Me.cboProgram.ManagingFastMouseMoving = True
        Me.cboProgram.ManagingFastMouseMovingInterval = 30
        Me.cboProgram.Name = "cboProgram"
        Me.cboProgram.SelectedItem = Nothing
        Me.cboProgram.SelectedValue = Nothing
        Me.cboProgram.Size = New System.Drawing.Size(249, 23)
        Me.cboProgram.TabIndex = 10
        '
        'cboCollege
        '
        Me.cboCollege.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cboCollege.ArrowColor = System.Drawing.Color.Black
        Me.cboCollege.BindedControl = CType(resources.GetObject("cboCollege.BindedControl"), MTGCComboBox.ControlloAssociato)
        Me.cboCollege.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D
        Me.cboCollege.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboCollege.ColumnNum = 4
        Me.cboCollege.ColumnWidth = "120;300;100;0"
        Me.cboCollege.DisabledArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cboCollege.DisabledArrowColor = System.Drawing.Color.LightGray
        Me.cboCollege.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.cboCollege.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder
        Me.cboCollege.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.cboCollege.DisplayMember = "Text"
        Me.cboCollege.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboCollege.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cboCollege.DropDownForeColor = System.Drawing.Color.Black
        Me.cboCollege.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.cboCollege.DropDownWidth = 540
        Me.cboCollege.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCollege.GridLineColor = System.Drawing.Color.LightGray
        Me.cboCollege.GridLineHorizontal = False
        Me.cboCollege.GridLineVertical = False
        Me.cboCollege.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.cboCollege.Location = New System.Drawing.Point(123, 93)
        Me.cboCollege.ManagingFastMouseMoving = True
        Me.cboCollege.ManagingFastMouseMovingInterval = 30
        Me.cboCollege.Name = "cboCollege"
        Me.cboCollege.SelectedItem = Nothing
        Me.cboCollege.SelectedValue = Nothing
        Me.cboCollege.Size = New System.Drawing.Size(249, 23)
        Me.cboCollege.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(4, 126)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 14)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Program Name:"
        '
        'imgList32X32
        '
        Me.imgList32X32.ImageStream = CType(resources.GetObject("imgList32X32.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgList32X32.TransparentColor = System.Drawing.Color.Transparent
        Me.imgList32X32.Images.SetKeyName(0, "MAIN_itb32x3210.ico")
        Me.imgList32X32.Images.SetKeyName(1, "frmAccounts_Icon.ico")
        Me.imgList32X32.Images.SetKeyName(2, "frmAddEnrolment_Icon.ico")
        Me.imgList32X32.Images.SetKeyName(3, "frmDateChecker_Image1.ico")
        Me.imgList32X32.Images.SetKeyName(4, "frmFind_imgICO.ico")
        Me.imgList32X32.Images.SetKeyName(5, "frmShortcuts_ImageList14.ico")
        Me.imgList32X32.Images.SetKeyName(6, "frmShortcuts_ImageList117.ico")
        Me.imgList32X32.Images.SetKeyName(7, "frmShortcuts_ImageList120.ico")
        Me.imgList32X32.Images.SetKeyName(8, "frmShortcuts_ImageList121.ico")
        Me.imgList32X32.Images.SetKeyName(9, "frmStudentRecord_Icon.ico")
        Me.imgList32X32.Images.SetKeyName(10, "MAIN_itb32x320.ico")
        Me.imgList32X32.Images.SetKeyName(11, "MAIN_itb32x321.ico")
        Me.imgList32X32.Images.SetKeyName(12, "MAIN_itb32x323.ico")
        Me.imgList32X32.Images.SetKeyName(13, "MAIN_itb32x324.ico")
        Me.imgList32X32.Images.SetKeyName(14, "MAIN_itb32x326.ico")
        Me.imgList32X32.Images.SetKeyName(15, "MAIN_itb32x327.ico")
        Me.imgList32X32.Images.SetKeyName(16, "MAIN_itb32x328.ico")
        Me.imgList32X32.Images.SetKeyName(17, "frmmain_imglst_Toolbar20.jpg")
        Me.imgList32X32.Images.SetKeyName(18, "frmmain_imglst_Toolbar0.ico")
        Me.imgList32X32.Images.SetKeyName(19, "frmmain_imglst_Toolbar2.ico")
        Me.imgList32X32.Images.SetKeyName(20, "frmmain_imglst_Toolbar4.ico")
        Me.imgList32X32.Images.SetKeyName(21, "frmmain_imglst_Toolbar5.ico")
        Me.imgList32X32.Images.SetKeyName(22, "frmmain_imglst_Toolbar6.ico")
        Me.imgList32X32.Images.SetKeyName(23, "frmmain_imglst_Toolbar7.ico")
        Me.imgList32X32.Images.SetKeyName(24, "frmmain_imglst_Toolbar8.ico")
        Me.imgList32X32.Images.SetKeyName(25, "frmmain_imglst_Toolbar9.ico")
        Me.imgList32X32.Images.SetKeyName(26, "frmmain_imglst_Toolbar10.ico")
        Me.imgList32X32.Images.SetKeyName(27, "frmmain_imglst_Toolbar11.ico")
        Me.imgList32X32.Images.SetKeyName(28, "frmmain_imglst_Toolbar12.ico")
        Me.imgList32X32.Images.SetKeyName(29, "frmmain_imglst_Toolbar13.ico")
        Me.imgList32X32.Images.SetKeyName(30, "frmmain_imglst_Toolbar14.ico")
        Me.imgList32X32.Images.SetKeyName(31, "frmmain_imglst_Toolbar15.ico")
        Me.imgList32X32.Images.SetKeyName(32, "frmmain_imglst_Toolbar16.ico")
        '
        'frmCurriculum
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 740)
        Me.Controls.Add(Me.tabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCurriculum"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Curriculums"
        Me.tabControl1.ResumeLayout(False)
        Me.tabPage1.ResumeLayout(False)
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popSubjects.ResumeLayout(False)
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavBarControl1.ResumeLayout(False)
        Me.NavBarGroupControlContainer1.ResumeLayout(False)
        Me.NavBarGroupControlContainer1.PerformLayout()
        Me.NavBarGroupControlContainer2.ResumeLayout(False)
        Me.NavBarGroupControlContainer2.PerformLayout()
        Me.tabPage2.ResumeLayout(False)
        Me.tabPage2.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.popDetails.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TabControl4.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.popCurriculum.ResumeLayout(False)
        Me.toolStrip1.ResumeLayout(False)
        Me.toolStrip1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl2.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage3.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.XtraTabPage4.ResumeLayout(False)
        Me.XtraTabPage4.PerformLayout()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        Me.TabControl.ResumeLayout(False)
        Me.TabPage8.ResumeLayout(False)
        CType(Me.clsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip2.ResumeLayout(False)
        Me.StatusStrip2.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        Me.StatusStrip3.ResumeLayout(False)
        Me.StatusStrip3.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private tabPage1 As System.Windows.Forms.TabPage
    Private toolStrip1 As System.Windows.Forms.ToolStrip

#End Region

    Private timer1 As System.Windows.Forms.Timer
    Private tabControl1 As System.Windows.Forms.TabControl
    Private tabPage2 As System.Windows.Forms.TabPage
    Private statusStrip1 As System.Windows.Forms.StatusStrip
    Private WithEvents popSubjects As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdNewSubject As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEditSubject As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDeleteSubject As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuRefreshSubject As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents imgList32X32 As System.Windows.Forms.ImageList
    Friend WithEvents popCurriculum As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdNewCur As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdEditCur As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDeleteCur As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CourseOutlineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents img16X16 As System.Windows.Forms.ImageList
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboCampus As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cboCampusID As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdPrintCurriculumDetails As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popDetails As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdRefreshDetails As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdPrintDetails As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SubjectEquivalentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PropertiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents NavBarControl1 As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents NavBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents dgView As System.Windows.Forms.DataGridView
    Friend WithEvents NavBarGroup2 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents cmdAddNewSubject As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarGroup3 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarGroupControlContainer1 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents txtWhat As System.Windows.Forms.TextBox
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboLookFor As System.Windows.Forms.ComboBox
    Friend WithEvents NavBarGroupControlContainer2 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents opt2 As System.Windows.Forms.RadioButton
    Friend WithEvents opt1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lvCurriculum As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cboSubProgram As MTGCComboBox
    Friend WithEvents cboSubCampus As MTGCComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboProgramAccess As System.Windows.Forms.ComboBox
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SubjectCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptiveTitle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column15 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column16 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SetPreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubjectEquivalentToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XtraTabControl2 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Public WithEvents lvDetails As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TabControl3 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Public WithEvents lsvCurriculum As System.Windows.Forms.ListView
    Public WithEvents _column_11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Public WithEvents _column_12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TabControl4 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents listRecord As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StatusStrip2 As System.Windows.Forms.StatusStrip
    Friend WithEvents cboOfferingTerm As MTGCComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboProgram As MTGCComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboCollege As MTGCComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboOfferingCampus As MTGCComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cboSectionType As System.Windows.Forms.ComboBox
    Friend WithEvents lvFaculty As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader23 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader24 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader25 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader26 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader27 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader28 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader29 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader30 As System.Windows.Forms.ColumnHeader
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lblNoOffering As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents clsGrid As C1.Win.C1FlexGrid.Classic.C1FlexGridClassic
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents lvOffering As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader34 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader35 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader36 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvSection As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader31 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader32 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader33 As System.Windows.Forms.ColumnHeader
    Friend WithEvents StatusStrip3 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblOfferingSec As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ColumnHeader37 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvLoadHistory As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader38 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader39 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader40 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader41 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader42 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader43 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader44 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader45 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader46 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader47 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader48 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader49 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader50 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader51 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader52 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cboAY As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents cboAYID As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents StatusStrip4 As System.Windows.Forms.StatusStrip
    Friend WithEvents lvSubjectTaught As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader53 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader54 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader55 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader56 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader57 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader58 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader59 As System.Windows.Forms.ColumnHeader
    Friend WithEvents StatusStrip5 As System.Windows.Forms.StatusStrip

End Class
