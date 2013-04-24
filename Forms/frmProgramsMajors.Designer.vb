Partial Class frmProgramsMajors
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProgramsMajors))
        Me.popPrograms = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdNewProgram = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdEditProgram = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdDeleteProgram = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdRefreshProgram = New System.Windows.Forms.ToolStripMenuItem()
        Me.img16X16 = New System.Windows.Forms.ImageList(Me.components)
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPage1 = New System.Windows.Forms.TabPage()
        Me.lvPrograms = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabMajorGroup = New System.Windows.Forms.TabPage()
        Me.lvMajors = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.cboCampus = New System.Windows.Forms.ToolStripComboBox()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cboCollege = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdPrintAcademicPrograms = New System.Windows.Forms.ToolStripDropDownButton()
        Me.PrintAllAcademicProgramsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdShowAll = New System.Windows.Forms.ToolStripButton()
        Me.cboCampusID = New System.Windows.Forms.ToolStripComboBox()
        Me.cboCollegeID = New System.Windows.Forms.ToolStripComboBox()
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.fgMajor = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.popMajor = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdNewMajor = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdEditMajor = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdDeleteMajorDisc = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdRefreshMajorDisc = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdBrowse = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip3 = New System.Windows.Forms.StatusStrip()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lvMajorGroups = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.popMajorGroups = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdNewMajorGroup = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdEditMajorGroup = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdDeleteMajor = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdRefreshMajor = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        Me.imgList32X32 = New System.Windows.Forms.ImageList(Me.components)
        Me.popDepartment = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewDepartmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifyDepartmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.refreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.columnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.miniToolStrip = New System.Windows.Forms.ToolStrip()
        Me.txtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.popPrograms.SuspendLayout()
        Me.tabControl1.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabMajorGroup.SuspendLayout()
        Me.toolStrip1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.fgMajor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popMajor.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.popMajorGroups.SuspendLayout()
        Me.popDepartment.SuspendLayout()
        Me.SuspendLayout()
        '
        'popPrograms
        '
        Me.popPrograms.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdNewProgram, Me.cmdEditProgram, Me.cmdDeleteProgram, Me.toolStripSeparator4, Me.cmdRefreshProgram})
        Me.popPrograms.Name = "contextMenuStrip1"
        Me.popPrograms.Size = New System.Drawing.Size(181, 98)
        '
        'cmdNewProgram
        '
        Me.cmdNewProgram.Image = CType(resources.GetObject("cmdNewProgram.Image"), System.Drawing.Image)
        Me.cmdNewProgram.Name = "cmdNewProgram"
        Me.cmdNewProgram.Size = New System.Drawing.Size(180, 22)
        Me.cmdNewProgram.Text = "New Acad. Program"
        '
        'cmdEditProgram
        '
        Me.cmdEditProgram.Image = CType(resources.GetObject("cmdEditProgram.Image"), System.Drawing.Image)
        Me.cmdEditProgram.Name = "cmdEditProgram"
        Me.cmdEditProgram.Size = New System.Drawing.Size(180, 22)
        Me.cmdEditProgram.Text = "Edit Acad. Program"
        '
        'cmdDeleteProgram
        '
        Me.cmdDeleteProgram.Image = CType(resources.GetObject("cmdDeleteProgram.Image"), System.Drawing.Image)
        Me.cmdDeleteProgram.Name = "cmdDeleteProgram"
        Me.cmdDeleteProgram.Size = New System.Drawing.Size(180, 22)
        Me.cmdDeleteProgram.Text = "Delete"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(177, 6)
        '
        'cmdRefreshProgram
        '
        Me.cmdRefreshProgram.Image = CType(resources.GetObject("cmdRefreshProgram.Image"), System.Drawing.Image)
        Me.cmdRefreshProgram.Name = "cmdRefreshProgram"
        Me.cmdRefreshProgram.Size = New System.Drawing.Size(180, 22)
        Me.cmdRefreshProgram.Text = "Refresh"
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
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.tabPage1)
        Me.tabControl1.Controls.Add(Me.TabPage2)
        Me.tabControl1.Controls.Add(Me.TabPage3)
        Me.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControl1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabControl1.ImageList = Me.img16X16
        Me.tabControl1.Location = New System.Drawing.Point(0, 0)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(1173, 573)
        Me.tabControl1.TabIndex = 4
        '
        'tabPage1
        '
        Me.tabPage1.Controls.Add(Me.lvPrograms)
        Me.tabPage1.Controls.Add(Me.TabControl3)
        Me.tabPage1.Controls.Add(Me.toolStrip1)
        Me.tabPage1.Controls.Add(Me.statusStrip1)
        Me.tabPage1.ImageIndex = 19
        Me.tabPage1.Location = New System.Drawing.Point(4, 23)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage1.Size = New System.Drawing.Size(1165, 546)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "Academic Programs"
        Me.tabPage1.UseVisualStyleBackColor = True
        '
        'lvPrograms
        '
        Me.lvPrograms.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader6, Me.ColumnHeader4})
        Me.lvPrograms.ContextMenuStrip = Me.popPrograms
        Me.lvPrograms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvPrograms.FullRowSelect = True
        Me.lvPrograms.Location = New System.Drawing.Point(3, 28)
        Me.lvPrograms.Name = "lvPrograms"
        Me.lvPrograms.Size = New System.Drawing.Size(586, 493)
        Me.lvPrograms.SmallImageList = Me.img16X16
        Me.lvPrograms.TabIndex = 15
        Me.lvPrograms.UseCompatibleStateImageBehavior = False
        Me.lvPrograms.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Program Code"
        Me.ColumnHeader3.Width = 155
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "ID"
        Me.ColumnHeader6.Width = 0
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Academic Programs"
        Me.ColumnHeader4.Width = 392
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabMajorGroup)
        Me.TabControl3.Dock = System.Windows.Forms.DockStyle.Right
        Me.TabControl3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl3.Location = New System.Drawing.Point(589, 28)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(573, 493)
        Me.TabControl3.TabIndex = 14
        '
        'TabMajorGroup
        '
        Me.TabMajorGroup.Controls.Add(Me.lvMajors)
        Me.TabMajorGroup.Location = New System.Drawing.Point(4, 23)
        Me.TabMajorGroup.Name = "TabMajorGroup"
        Me.TabMajorGroup.Padding = New System.Windows.Forms.Padding(3)
        Me.TabMajorGroup.Size = New System.Drawing.Size(565, 466)
        Me.TabMajorGroup.TabIndex = 1
        Me.TabMajorGroup.Text = "MAJOR DISCIPLINE CATEGORY"
        Me.TabMajorGroup.UseVisualStyleBackColor = True
        '
        'lvMajors
        '
        Me.lvMajors.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.lvMajors.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvMajors.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvMajors.FullRowSelect = True
        Me.lvMajors.GridLines = True
        Me.lvMajors.Location = New System.Drawing.Point(3, 3)
        Me.lvMajors.Name = "lvMajors"
        Me.lvMajors.Size = New System.Drawing.Size(559, 460)
        Me.lvMajors.TabIndex = 0
        Me.lvMajors.UseCompatibleStateImageBehavior = False
        Me.lvMajors.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "MAJOR CODE"
        Me.ColumnHeader7.Width = 157
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "MAJOR ID"
        Me.ColumnHeader8.Width = 0
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "MAJOR DISCIPLINE"
        Me.ColumnHeader9.Width = 371
        '
        'toolStrip1
        '
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.cboCampus, Me.toolStripSeparator2, Me.ToolStripLabel1, Me.cboCollege, Me.ToolStripSeparator7, Me.cmdPrintAcademicPrograms, Me.ToolStripSeparator10, Me.cmdShowAll, Me.cboCampusID, Me.cboCollegeID})
        Me.toolStrip1.Location = New System.Drawing.Point(3, 3)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New System.Drawing.Size(1159, 25)
        Me.toolStrip1.TabIndex = 13
        Me.toolStrip1.Text = "toolStrip1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripLabel2.Text = "Ca&mpus"
        '
        'cboCampus
        '
        Me.cboCampus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboCampus.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.cboCampus.Name = "cboCampus"
        Me.cboCampus.Size = New System.Drawing.Size(280, 25)
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(48, 22)
        Me.ToolStripLabel1.Text = "&College"
        '
        'cboCollege
        '
        Me.cboCollege.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboCollege.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.cboCollege.Name = "cboCollege"
        Me.cboCollege.Size = New System.Drawing.Size(300, 25)
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'cmdPrintAcademicPrograms
        '
        Me.cmdPrintAcademicPrograms.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintAllAcademicProgramsToolStripMenuItem})
        Me.cmdPrintAcademicPrograms.Image = CType(resources.GetObject("cmdPrintAcademicPrograms.Image"), System.Drawing.Image)
        Me.cmdPrintAcademicPrograms.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrintAcademicPrograms.Name = "cmdPrintAcademicPrograms"
        Me.cmdPrintAcademicPrograms.Size = New System.Drawing.Size(61, 22)
        Me.cmdPrintAcademicPrograms.Text = "Print"
        '
        'PrintAllAcademicProgramsToolStripMenuItem
        '
        Me.PrintAllAcademicProgramsToolStripMenuItem.Name = "PrintAllAcademicProgramsToolStripMenuItem"
        Me.PrintAllAcademicProgramsToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.PrintAllAcademicProgramsToolStripMenuItem.Text = "Print All Academic Programs"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'cmdShowAll
        '
        Me.cmdShowAll.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdShowAll.Image = CType(resources.GetObject("cmdShowAll.Image"), System.Drawing.Image)
        Me.cmdShowAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdShowAll.Name = "cmdShowAll"
        Me.cmdShowAll.Size = New System.Drawing.Size(184, 22)
        Me.cmdShowAll.Text = "Show All Academic Programs"
        '
        'cboCampusID
        '
        Me.cboCampusID.Name = "cboCampusID"
        Me.cboCampusID.Size = New System.Drawing.Size(75, 25)
        Me.cboCampusID.Visible = False
        '
        'cboCollegeID
        '
        Me.cboCollegeID.Name = "cboCollegeID"
        Me.cboCollegeID.Size = New System.Drawing.Size(75, 25)
        Me.cboCollegeID.Visible = False
        '
        'statusStrip1
        '
        Me.statusStrip1.Location = New System.Drawing.Point(3, 521)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 12, 0)
        Me.statusStrip1.Size = New System.Drawing.Size(1159, 22)
        Me.statusStrip1.TabIndex = 4
        Me.statusStrip1.Text = "statusStrip1"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.fgMajor)
        Me.TabPage2.Controls.Add(Me.ToolStrip3)
        Me.TabPage2.Controls.Add(Me.StatusStrip3)
        Me.TabPage2.ImageIndex = 30
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1165, 546)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "CHED Coded- Major Disciplines"
        '
        'fgMajor
        '
        Me.fgMajor.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fgMajor.ColumnInfo = resources.GetString("fgMajor.ColumnInfo")
        Me.fgMajor.ContextMenuStrip = Me.popMajor
        Me.fgMajor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fgMajor.Location = New System.Drawing.Point(3, 28)
        Me.fgMajor.Name = "fgMajor"
        Me.fgMajor.Rows.Count = 1
        Me.fgMajor.Rows.DefaultSize = 21
        Me.fgMajor.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange
        Me.fgMajor.Size = New System.Drawing.Size(1159, 493)
        Me.fgMajor.StyleInfo = resources.GetString("fgMajor.StyleInfo")
        Me.fgMajor.TabIndex = 6
        Me.fgMajor.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue
        '
        'popMajor
        '
        Me.popMajor.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdNewMajor, Me.cmdEditMajor, Me.cmdDeleteMajorDisc, Me.ToolStripSeparator1, Me.cmdRefreshMajorDisc})
        Me.popMajor.Name = "popMajor"
        Me.popMajor.Size = New System.Drawing.Size(187, 98)
        '
        'cmdNewMajor
        '
        Me.cmdNewMajor.Image = CType(resources.GetObject("cmdNewMajor.Image"), System.Drawing.Image)
        Me.cmdNewMajor.Name = "cmdNewMajor"
        Me.cmdNewMajor.Size = New System.Drawing.Size(186, 22)
        Me.cmdNewMajor.Text = "New Major Discipline"
        '
        'cmdEditMajor
        '
        Me.cmdEditMajor.Image = CType(resources.GetObject("cmdEditMajor.Image"), System.Drawing.Image)
        Me.cmdEditMajor.Name = "cmdEditMajor"
        Me.cmdEditMajor.Size = New System.Drawing.Size(186, 22)
        Me.cmdEditMajor.Text = "Edit Major Discipline"
        '
        'cmdDeleteMajorDisc
        '
        Me.cmdDeleteMajorDisc.Image = CType(resources.GetObject("cmdDeleteMajorDisc.Image"), System.Drawing.Image)
        Me.cmdDeleteMajorDisc.Name = "cmdDeleteMajorDisc"
        Me.cmdDeleteMajorDisc.Size = New System.Drawing.Size(186, 22)
        Me.cmdDeleteMajorDisc.Text = "Delete"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(183, 6)
        '
        'cmdRefreshMajorDisc
        '
        Me.cmdRefreshMajorDisc.Image = CType(resources.GetObject("cmdRefreshMajorDisc.Image"), System.Drawing.Image)
        Me.cmdRefreshMajorDisc.Name = "cmdRefreshMajorDisc"
        Me.cmdRefreshMajorDisc.Size = New System.Drawing.Size(186, 22)
        Me.cmdRefreshMajorDisc.Text = "Refresh"
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.ToolStripButton2, Me.ToolStripButton1, Me.toolStripSeparator14, Me.ToolStripLabel3, Me.txtSearch, Me.cmdBrowse})
        Me.ToolStrip3.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(1159, 25)
        Me.ToolStrip3.TabIndex = 5
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(51, 22)
        Me.NewToolStripButton.Text = "&New"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(60, 22)
        Me.ToolStripButton2.Text = "Delete"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(66, 22)
        Me.ToolStripButton1.Text = "Refresh"
        '
        'toolStripSeparator14
        '
        Me.toolStripSeparator14.Name = "toolStripSeparator14"
        Me.toolStripSeparator14.Size = New System.Drawing.Size(6, 25)
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Image = CType(resources.GetObject("cmdBrowse.Image"), System.Drawing.Image)
        Me.cmdBrowse.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(62, 22)
        Me.cmdBrowse.Text = "&Search"
        '
        'StatusStrip3
        '
        Me.StatusStrip3.Location = New System.Drawing.Point(3, 521)
        Me.StatusStrip3.Name = "StatusStrip3"
        Me.StatusStrip3.Size = New System.Drawing.Size(1159, 22)
        Me.StatusStrip3.TabIndex = 0
        Me.StatusStrip3.Text = "StatusStrip3"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.lvMajorGroups)
        Me.TabPage3.Controls.Add(Me.StatusStrip2)
        Me.TabPage3.ImageIndex = 31
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1165, 546)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Major Discipline Groups"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'lvMajorGroups
        '
        Me.lvMajorGroups.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader13})
        Me.lvMajorGroups.ContextMenuStrip = Me.popMajorGroups
        Me.lvMajorGroups.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvMajorGroups.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvMajorGroups.FullRowSelect = True
        Me.lvMajorGroups.Location = New System.Drawing.Point(3, 3)
        Me.lvMajorGroups.MultiSelect = False
        Me.lvMajorGroups.Name = "lvMajorGroups"
        Me.lvMajorGroups.Size = New System.Drawing.Size(1159, 518)
        Me.lvMajorGroups.SmallImageList = Me.img16X16
        Me.lvMajorGroups.TabIndex = 16
        Me.lvMajorGroups.UseCompatibleStateImageBehavior = False
        Me.lvMajorGroups.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "GROUP CODE"
        Me.ColumnHeader1.Width = 226
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "GROUP DESCRIPTION"
        Me.ColumnHeader2.Width = 551
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = ""
        Me.ColumnHeader13.Width = 0
        '
        'popMajorGroups
        '
        Me.popMajorGroups.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdNewMajorGroup, Me.cmdEditMajorGroup, Me.cmdDeleteMajor, Me.ToolStripSeparator3, Me.cmdRefreshMajor})
        Me.popMajorGroups.Name = "ContextMenuStrip4"
        Me.popMajorGroups.Size = New System.Drawing.Size(169, 98)
        '
        'cmdNewMajorGroup
        '
        Me.cmdNewMajorGroup.Image = CType(resources.GetObject("cmdNewMajorGroup.Image"), System.Drawing.Image)
        Me.cmdNewMajorGroup.Name = "cmdNewMajorGroup"
        Me.cmdNewMajorGroup.Size = New System.Drawing.Size(168, 22)
        Me.cmdNewMajorGroup.Text = "New Major Group"
        '
        'cmdEditMajorGroup
        '
        Me.cmdEditMajorGroup.Image = CType(resources.GetObject("cmdEditMajorGroup.Image"), System.Drawing.Image)
        Me.cmdEditMajorGroup.Name = "cmdEditMajorGroup"
        Me.cmdEditMajorGroup.Size = New System.Drawing.Size(168, 22)
        Me.cmdEditMajorGroup.Text = "Edit Major Group"
        '
        'cmdDeleteMajor
        '
        Me.cmdDeleteMajor.Image = CType(resources.GetObject("cmdDeleteMajor.Image"), System.Drawing.Image)
        Me.cmdDeleteMajor.Name = "cmdDeleteMajor"
        Me.cmdDeleteMajor.Size = New System.Drawing.Size(168, 22)
        Me.cmdDeleteMajor.Text = "Delete"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(165, 6)
        '
        'cmdRefreshMajor
        '
        Me.cmdRefreshMajor.Image = CType(resources.GetObject("cmdRefreshMajor.Image"), System.Drawing.Image)
        Me.cmdRefreshMajor.Name = "cmdRefreshMajor"
        Me.cmdRefreshMajor.Size = New System.Drawing.Size(168, 22)
        Me.cmdRefreshMajor.Text = "Refresh"
        '
        'StatusStrip2
        '
        Me.StatusStrip2.Location = New System.Drawing.Point(3, 521)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.Size = New System.Drawing.Size(1159, 22)
        Me.StatusStrip2.TabIndex = 0
        Me.StatusStrip2.Text = "StatusStrip2"
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
        'popDepartment
        '
        Me.popDepartment.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewDepartmentToolStripMenuItem, Me.ModifyDepartmentToolStripMenuItem, Me.ToolStripSeparator6, Me.DeleteToolStripMenuItem4, Me.ToolStripSeparator8, Me.refreshToolStripMenuItem})
        Me.popDepartment.Name = "popDepartment"
        Me.popDepartment.Size = New System.Drawing.Size(188, 104)
        '
        'NewDepartmentToolStripMenuItem
        '
        Me.NewDepartmentToolStripMenuItem.Image = CType(resources.GetObject("NewDepartmentToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewDepartmentToolStripMenuItem.Name = "NewDepartmentToolStripMenuItem"
        Me.NewDepartmentToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.NewDepartmentToolStripMenuItem.Text = "New Department..."
        '
        'ModifyDepartmentToolStripMenuItem
        '
        Me.ModifyDepartmentToolStripMenuItem.Image = CType(resources.GetObject("ModifyDepartmentToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ModifyDepartmentToolStripMenuItem.Name = "ModifyDepartmentToolStripMenuItem"
        Me.ModifyDepartmentToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.ModifyDepartmentToolStripMenuItem.Text = "Modify Department..."
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(184, 6)
        '
        'DeleteToolStripMenuItem4
        '
        Me.DeleteToolStripMenuItem4.Image = CType(resources.GetObject("DeleteToolStripMenuItem4.Image"), System.Drawing.Image)
        Me.DeleteToolStripMenuItem4.Name = "DeleteToolStripMenuItem4"
        Me.DeleteToolStripMenuItem4.Size = New System.Drawing.Size(187, 22)
        Me.DeleteToolStripMenuItem4.Text = "Delete"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(184, 6)
        '
        'refreshToolStripMenuItem
        '
        Me.refreshToolStripMenuItem.Image = CType(resources.GetObject("refreshToolStripMenuItem.Image"), System.Drawing.Image)
        Me.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem"
        Me.refreshToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.refreshToolStripMenuItem.Text = "Refresh"
        '
        'columnHeader11
        '
        Me.columnHeader11.Text = "Subject"
        Me.columnHeader11.Width = 107
        '
        'columnHeader10
        '
        Me.columnHeader10.Text = "SubjectCode"
        Me.columnHeader10.Width = 0
        '
        'columnHeader12
        '
        Me.columnHeader12.Text = "Descriptive Title"
        Me.columnHeader12.Width = 214
        '
        'columnHeader14
        '
        Me.columnHeader14.Text = "Unit"
        Me.columnHeader14.Width = 47
        '
        'columnHeader5
        '
        Me.columnHeader5.Text = "Yr"
        Me.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.columnHeader5.Width = 0
        '
        'miniToolStrip
        '
        Me.miniToolStrip.AutoSize = False
        Me.miniToolStrip.CanOverflow = False
        Me.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.miniToolStrip.Location = New System.Drawing.Point(668, 3)
        Me.miniToolStrip.Name = "miniToolStrip"
        Me.miniToolStrip.Size = New System.Drawing.Size(1145, 25)
        Me.miniToolStrip.TabIndex = 11
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(200, 25)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(42, 22)
        Me.ToolStripLabel3.Text = "Search"
        '
        'frmProgramsMajors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1173, 573)
        Me.Controls.Add(Me.tabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProgramsMajors"
        Me.Text = "ACADEMIC PROGRAMS"
        Me.popPrograms.ResumeLayout(False)
        Me.tabControl1.ResumeLayout(False)
        Me.tabPage1.ResumeLayout(False)
        Me.tabPage1.PerformLayout()
        Me.TabControl3.ResumeLayout(False)
        Me.TabMajorGroup.ResumeLayout(False)
        Me.toolStrip1.ResumeLayout(False)
        Me.toolStrip1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.fgMajor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popMajor.ResumeLayout(False)
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.popMajorGroups.ResumeLayout(False)
        Me.popDepartment.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private popPrograms As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdRefreshProgram As System.Windows.Forms.ToolStripMenuItem
    Private img16X16 As System.Windows.Forms.ImageList
    Private tabControl1 As System.Windows.Forms.TabControl
    Private tabPage1 As System.Windows.Forms.TabPage
    Private statusStrip1 As System.Windows.Forms.StatusStrip
    Private toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdNewProgram As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdEditProgram As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDeleteProgram As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popMajorGroups As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdNewMajorGroup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdEditMajorGroup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdRefreshMajor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDeleteMajor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents toolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboCampus As System.Windows.Forms.ToolStripComboBox
    Private WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Private WithEvents cboCollege As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents columnHeader11 As System.Windows.Forms.ColumnHeader
    Private WithEvents columnHeader10 As System.Windows.Forms.ColumnHeader
    Private WithEvents columnHeader12 As System.Windows.Forms.ColumnHeader
    Private WithEvents columnHeader14 As System.Windows.Forms.ColumnHeader
    Private WithEvents columnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents lvMajorGroups As System.Windows.Forms.ListView
    Private WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Private WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents StatusStrip2 As System.Windows.Forms.StatusStrip
    Friend WithEvents imgList32X32 As System.Windows.Forms.ImageList
    Friend WithEvents StatusStrip3 As System.Windows.Forms.StatusStrip
    Friend WithEvents cboCampusID As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents cboCollegeID As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents popMajor As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdNewMajor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdEditMajor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDeleteMajorDisc As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdRefreshMajorDisc As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator14 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdBrowse As System.Windows.Forms.ToolStripButton
    Private WithEvents popDepartment As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewDepartmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifyDepartmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents refreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fgMajor As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdShowAll As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdPrintAcademicPrograms As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents PrintAllAcademicProgramsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lvPrograms As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TabControl3 As System.Windows.Forms.TabControl
    Friend WithEvents TabMajorGroup As System.Windows.Forms.TabPage
    Friend WithEvents lvMajors As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents DataSet11 As Academic_Manager.DataSet1
    Friend WithEvents miniToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtSearch As System.Windows.Forms.ToolStripTextBox
    'Friend WithEvents DsTables As Academic_Manager.dsTables

End Class
