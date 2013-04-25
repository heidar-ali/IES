Partial Class frmCollegeAE
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCollegeAE))
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPage1 = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.dgCollege = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.popColleges = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdNewCollege = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdEditCollege = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdRefreshCollege = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip4 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonNew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonRefresh = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonPrint = New System.Windows.Forms.ToolStripButton()
        Me.imgList32X32 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.cboCampus = New System.Windows.Forms.ComboBox()
        Me.cboCampusID = New System.Windows.Forms.ComboBox()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cboDeanID = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboDean = New System.Windows.Forms.ComboBox()
        Me.txtCollegeName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkActive = New System.Windows.Forms.CheckBox()
        Me.txtCollegeCode = New System.Windows.Forms.TextBox()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.contextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.refreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.viewFacultyInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.printScheduleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tabControl1.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        CType(Me.dgCollege, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popColleges.SuspendLayout()
        Me.ToolStrip4.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.contextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.tabPage1)
        Me.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControl1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabControl1.Location = New System.Drawing.Point(0, 0)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(1004, 573)
        Me.tabControl1.TabIndex = 2
        '
        'tabPage1
        '
        Me.tabPage1.Controls.Add(Me.TabControl2)
        Me.tabPage1.Controls.Add(Me.GroupControl1)
        Me.tabPage1.Location = New System.Drawing.Point(4, 23)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage1.Size = New System.Drawing.Size(996, 546)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "Colleges/Institute"
        Me.tabPage1.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage6)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.ImageList = Me.imgList32X32
        Me.TabControl2.Location = New System.Drawing.Point(348, 3)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(645, 540)
        Me.TabControl2.TabIndex = 18
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.dgCollege)
        Me.TabPage6.Controls.Add(Me.ToolStrip4)
        Me.TabPage6.ImageIndex = 5
        Me.TabPage6.Location = New System.Drawing.Point(4, 39)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(637, 497)
        Me.TabPage6.TabIndex = 0
        Me.TabPage6.Text = "Campus Colleges"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'dgCollege
        '
        Me.dgCollege.AllowUserToAddRows = False
        Me.dgCollege.AllowUserToDeleteRows = False
        Me.dgCollege.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCollege.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgCollege.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCollege.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.dgCollege.ContextMenuStrip = Me.popColleges
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgCollege.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgCollege.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgCollege.EnableHeadersVisualStyles = False
        Me.dgCollege.Location = New System.Drawing.Point(3, 28)
        Me.dgCollege.Name = "dgCollege"
        Me.dgCollege.ReadOnly = True
        Me.dgCollege.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCollege.Size = New System.Drawing.Size(631, 466)
        Me.dgCollege.TabIndex = 12
        '
        'Column1
        '
        Me.Column1.HeaderText = "COLLEGE CODE"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "COLLEGE NAME"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 250
        '
        'Column3
        '
        Me.Column3.HeaderText = "DEAN ID"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 90
        '
        'Column4
        '
        Me.Column4.HeaderText = "COLLEGE DEAN"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 200
        '
        'Column5
        '
        Me.Column5.HeaderText = "COLLEGE LOGO"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "INACTIVE"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column6.Width = 70
        '
        'Column7
        '
        Me.Column7.HeaderText = "ID"
        Me.Column7.MinimumWidth = 2
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 2
        '
        'popColleges
        '
        Me.popColleges.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdNewCollege, Me.cmdEditCollege, Me.ToolStripMenuItem1, Me.ToolStripSeparator1, Me.cmdRefreshCollege})
        Me.popColleges.Name = "popColleges"
        Me.popColleges.Size = New System.Drawing.Size(151, 98)
        '
        'cmdNewCollege
        '
        Me.cmdNewCollege.Image = CType(resources.GetObject("cmdNewCollege.Image"), System.Drawing.Image)
        Me.cmdNewCollege.Name = "cmdNewCollege"
        Me.cmdNewCollege.Size = New System.Drawing.Size(150, 22)
        Me.cmdNewCollege.Text = "New College..."
        '
        'cmdEditCollege
        '
        Me.cmdEditCollege.Image = CType(resources.GetObject("cmdEditCollege.Image"), System.Drawing.Image)
        Me.cmdEditCollege.Name = "cmdEditCollege"
        Me.cmdEditCollege.Size = New System.Drawing.Size(150, 22)
        Me.cmdEditCollege.Text = "Edit College..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(150, 22)
        Me.ToolStripMenuItem1.Text = "Delete"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(147, 6)
        '
        'cmdRefreshCollege
        '
        Me.cmdRefreshCollege.Image = CType(resources.GetObject("cmdRefreshCollege.Image"), System.Drawing.Image)
        Me.cmdRefreshCollege.Name = "cmdRefreshCollege"
        Me.cmdRefreshCollege.Size = New System.Drawing.Size(150, 22)
        Me.cmdRefreshCollege.Text = "Refresh"
        '
        'ToolStrip4
        '
        Me.ToolStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonNew, Me.ToolStripButtonRefresh, Me.ToolStripSeparator11, Me.ToolStripButtonPrint})
        Me.ToolStrip4.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip4.Name = "ToolStrip4"
        Me.ToolStrip4.Size = New System.Drawing.Size(631, 25)
        Me.ToolStrip4.TabIndex = 11
        Me.ToolStrip4.Text = "ToolStrip4"
        '
        'ToolStripButtonNew
        '
        Me.ToolStripButtonNew.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButtonNew.Image = CType(resources.GetObject("ToolStripButtonNew.Image"), System.Drawing.Image)
        Me.ToolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonNew.Name = "ToolStripButtonNew"
        Me.ToolStripButtonNew.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButtonNew.Text = "&New"
        '
        'ToolStripButtonRefresh
        '
        Me.ToolStripButtonRefresh.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButtonRefresh.Image = CType(resources.GetObject("ToolStripButtonRefresh.Image"), System.Drawing.Image)
        Me.ToolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonRefresh.Name = "ToolStripButtonRefresh"
        Me.ToolStripButtonRefresh.Size = New System.Drawing.Size(68, 22)
        Me.ToolStripButtonRefresh.Text = "&Refresh"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButtonPrint
        '
        Me.ToolStripButtonPrint.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButtonPrint.Image = CType(resources.GetObject("ToolStripButtonPrint.Image"), System.Drawing.Image)
        Me.ToolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonPrint.Name = "ToolStripButtonPrint"
        Me.ToolStripButtonPrint.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButtonPrint.Text = "&Print"
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
        'GroupControl1
        '
        Me.GroupControl1.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupControl1.Appearance.Options.UseBackColor = True
        Me.GroupControl1.Controls.Add(Me.cboCampus)
        Me.GroupControl1.Controls.Add(Me.cboCampusID)
        Me.GroupControl1.Controls.Add(Me.picLogo)
        Me.GroupControl1.Controls.Add(Me.cmdSave)
        Me.GroupControl1.Controls.Add(Me.cmdDelete)
        Me.GroupControl1.Controls.Add(Me.cmdCancel)
        Me.GroupControl1.Controls.Add(Me.cboDeanID)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.cboDean)
        Me.GroupControl1.Controls.Add(Me.txtCollegeName)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.chkActive)
        Me.GroupControl1.Controls.Add(Me.txtCollegeCode)
        Me.GroupControl1.Controls.Add(Me.cmdBrowse)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupControl1.Location = New System.Drawing.Point(3, 3)
        Me.GroupControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(345, 540)
        Me.GroupControl1.TabIndex = 17
        Me.GroupControl1.Text = "COLLEGE/DEPARTMENTS/INSTITUTES INFORMATION"
        '
        'cboCampus
        '
        Me.cboCampus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboCampus.FormattingEnabled = True
        Me.cboCampus.Location = New System.Drawing.Point(11, 49)
        Me.cboCampus.Name = "cboCampus"
        Me.cboCampus.Size = New System.Drawing.Size(327, 22)
        Me.cboCampus.TabIndex = 17
        '
        'cboCampusID
        '
        Me.cboCampusID.FormattingEnabled = True
        Me.cboCampusID.Location = New System.Drawing.Point(10, 49)
        Me.cboCampusID.Name = "cboCampusID"
        Me.cboCampusID.Size = New System.Drawing.Size(327, 22)
        Me.cboCampusID.TabIndex = 16
        '
        'picLogo
        '
        Me.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLogo.Location = New System.Drawing.Point(11, 214)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(175, 176)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 8
        Me.picLogo.TabStop = False
        '
        'cmdSave
        '
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSave.Location = New System.Drawing.Point(149, 502)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(88, 26)
        Me.cmdSave.TabIndex = 1
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = CType(resources.GetObject("cmdDelete.Image"), System.Drawing.Image)
        Me.cmdDelete.Location = New System.Drawing.Point(92, 396)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(29, 26)
        Me.cmdDelete.TabIndex = 15
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Image = CType(resources.GetObject("cmdCancel.Image"), System.Drawing.Image)
        Me.cmdCancel.Location = New System.Drawing.Point(243, 502)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(94, 26)
        Me.cmdCancel.TabIndex = 2
        Me.cmdCancel.Text = "&Cancel"
        Me.cmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cboDeanID
        '
        Me.cboDeanID.FormattingEnabled = True
        Me.cboDeanID.Location = New System.Drawing.Point(294, 214)
        Me.cboDeanID.Name = "cboDeanID"
        Me.cboDeanID.Size = New System.Drawing.Size(43, 22)
        Me.cboDeanID.TabIndex = 13
        Me.cboDeanID.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 14)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Campus"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 14)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "College Name:"
        '
        'cboDean
        '
        Me.cboDean.FormattingEnabled = True
        Me.cboDean.Location = New System.Drawing.Point(11, 179)
        Me.cboDean.Name = "cboDean"
        Me.cboDean.Size = New System.Drawing.Size(327, 22)
        Me.cboDean.TabIndex = 4
        '
        'txtCollegeName
        '
        Me.txtCollegeName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCollegeName.Location = New System.Drawing.Point(10, 135)
        Me.txtCollegeName.Name = "txtCollegeName"
        Me.txtCollegeName.Size = New System.Drawing.Size(327, 22)
        Me.txtCollegeName.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 14)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "College Dean"
        '
        'chkActive
        '
        Me.chkActive.AutoSize = True
        Me.chkActive.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActive.ForeColor = System.Drawing.Color.Red
        Me.chkActive.Location = New System.Drawing.Point(14, 440)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(82, 18)
        Me.chkActive.TabIndex = 10
        Me.chkActive.Text = "In-Active"
        Me.chkActive.UseVisualStyleBackColor = True
        '
        'txtCollegeCode
        '
        Me.txtCollegeCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCollegeCode.Location = New System.Drawing.Point(11, 93)
        Me.txtCollegeCode.Name = "txtCollegeCode"
        Me.txtCollegeCode.Size = New System.Drawing.Size(191, 22)
        Me.txtCollegeCode.TabIndex = 6
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(11, 396)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(75, 26)
        Me.cmdBrowse.TabIndex = 9
        Me.cmdBrowse.Text = "&Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 14)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "College Code:"
        '
        'contextMenuStrip1
        '
        Me.contextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.refreshToolStripMenuItem, Me.toolStripSeparator5, Me.viewFacultyInfoToolStripMenuItem, Me.printScheduleToolStripMenuItem})
        Me.contextMenuStrip1.Name = "contextMenuStrip1"
        Me.contextMenuStrip1.Size = New System.Drawing.Size(165, 76)
        '
        'refreshToolStripMenuItem
        '
        Me.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem"
        Me.refreshToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.refreshToolStripMenuItem.Text = "Refresh"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(161, 6)
        '
        'viewFacultyInfoToolStripMenuItem
        '
        Me.viewFacultyInfoToolStripMenuItem.Name = "viewFacultyInfoToolStripMenuItem"
        Me.viewFacultyInfoToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.viewFacultyInfoToolStripMenuItem.Text = "View Faculty Info"
        '
        'printScheduleToolStripMenuItem
        '
        Me.printScheduleToolStripMenuItem.Name = "printScheduleToolStripMenuItem"
        Me.printScheduleToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.printScheduleToolStripMenuItem.Text = "Print Schedule"
        '
        'timer1
        '
        Me.timer1.Enabled = True
        Me.timer1.Interval = 5000
        '
        'frmCollegeAE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 573)
        Me.Controls.Add(Me.tabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCollegeAE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Colleges/Institute"
        Me.tabControl1.ResumeLayout(False)
        Me.tabPage1.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        CType(Me.dgCollege, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popColleges.ResumeLayout(False)
        Me.ToolStrip4.ResumeLayout(False)
        Me.ToolStrip4.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.contextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private tabControl1 As System.Windows.Forms.TabControl
    Private tabPage1 As System.Windows.Forms.TabPage
    Private timer1 As System.Windows.Forms.Timer
    Friend WithEvents lvFaculty As System.Windows.Forms.ListView
    Private columnHeader10 As System.Windows.Forms.ColumnHeader
    Private columnHeader11 As System.Windows.Forms.ColumnHeader
    Private contextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Private refreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Private viewFacultyInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents printScheduleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCollegeName As System.Windows.Forms.TextBox
    Friend WithEvents chkActive As System.Windows.Forms.CheckBox
    Friend WithEvents cmdBrowse As System.Windows.Forms.Button
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCollegeCode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboDean As System.Windows.Forms.ComboBox
    Friend WithEvents cboDeanID As System.Windows.Forms.ComboBox
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cboCampus As System.Windows.Forms.ComboBox
    Friend WithEvents cboCampusID As System.Windows.Forms.ComboBox
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents dgCollege As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip4 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButtonNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents imgList32X32 As System.Windows.Forms.ImageList
    Friend WithEvents popColleges As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdNewCollege As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdEditCollege As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdRefreshCollege As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
