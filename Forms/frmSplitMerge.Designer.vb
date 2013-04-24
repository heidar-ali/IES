'
' * Created by SharpDevelop.
' * User: Janphil Garay
' * Date: 11/17/2011
' * Time: 11:51 PM
' * 
' * To change this template use Tools | Options | Coding | Edit Standard Headers.
' 

Partial Class frmSplitMerge
    ''' <summary>
    ''' Designer variable used to keep track of non-visual components.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Disposes resources used by the form.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If components IsNot Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    ''' <summary>
    ''' This method is required for Windows Forms designer support.
    ''' Do not change the method contents inside the source code editor. The Forms designer might
    ''' not be able to load this method if it was changed manually.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSplitMerge))
        Me.imgList32X32 = New System.Windows.Forms.ImageList(Me.components)
        Me.tpSchedule = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip7 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip12 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel17 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripComboBox7 = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripComboBox8 = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStrip11 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel16 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel18 = New System.Windows.Forms.ToolStripLabel()
        Me.cboSource = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel13 = New System.Windows.Forms.ToolStripLabel()
        Me.cboClass = New System.Windows.Forms.ToolStripComboBox()
        Me.cboSubject = New System.Windows.Forms.ToolStripComboBox()
        Me.ListView3 = New System.Windows.Forms.ListView()
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip8 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton10 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton11 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip9 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel14 = New System.Windows.Forms.ToolStripLabel()
        Me.cboDestinationSection = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripComboBox3 = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStrip10 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel15 = New System.Windows.Forms.ToolStripLabel()
        Me.cboDestination = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStrip14 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel19 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripComboBox5 = New System.Windows.Forms.ToolStripTextBox()
        Me.cmdBrowseAY = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip4 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel9 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel10 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel11 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel12 = New System.Windows.Forms.ToolStripLabel()
        Me.tpSection = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.lsvSource = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel7 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtSection = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.img16X16 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip6 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel8 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.lblCount = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.lblSelected = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel6 = New System.Windows.Forms.ToolStripLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cboCampus = New MTGCComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboCampusID = New System.Windows.Forms.ComboBox()
        Me.cmdGetSchoolYear = New System.Windows.Forms.Button()
        Me.txtSchoolYear = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.tpSchedule.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.ToolStrip7.SuspendLayout()
        Me.ToolStrip12.SuspendLayout()
        Me.ToolStrip11.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        Me.ToolStrip8.SuspendLayout()
        Me.ToolStrip9.SuspendLayout()
        Me.ToolStrip10.SuspendLayout()
        Me.ToolStrip14.SuspendLayout()
        Me.ToolStrip4.SuspendLayout()
        Me.tpSection.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.ToolStrip6.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.imgList32X32.Images.SetKeyName(33, "constraints_32.png")
        Me.imgList32X32.Images.SetKeyName(34, "compare_32.png")
        '
        'tpSchedule
        '
        Me.tpSchedule.Controls.Add(Me.SplitContainer2)
        Me.tpSchedule.Controls.Add(Me.ToolStrip14)
        Me.tpSchedule.Controls.Add(Me.ToolStrip4)
        Me.tpSchedule.ImageIndex = 79
        Me.tpSchedule.Location = New System.Drawing.Point(4, 23)
        Me.tpSchedule.Name = "tpSchedule"
        Me.tpSchedule.Padding = New System.Windows.Forms.Padding(3)
        Me.tpSchedule.Size = New System.Drawing.Size(1134, 390)
        Me.tpSchedule.TabIndex = 1
        Me.tpSchedule.Text = "Class Schedules (Split/Merge)"
        Me.tpSchedule.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 28)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.ListView2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ToolStrip7)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ToolStrip12)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ToolStrip11)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ToolStrip3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.ListView3)
        Me.SplitContainer2.Panel2.Controls.Add(Me.ToolStrip8)
        Me.SplitContainer2.Panel2.Controls.Add(Me.ToolStrip9)
        Me.SplitContainer2.Panel2.Controls.Add(Me.ToolStrip10)
        Me.SplitContainer2.Size = New System.Drawing.Size(1128, 334)
        Me.SplitContainer2.SplitterDistance = 571
        Me.SplitContainer2.TabIndex = 17
        '
        'ListView2
        '
        Me.ListView2.CheckBoxes = True
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12})
        Me.ListView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.HoverSelection = True
        Me.ListView2.Location = New System.Drawing.Point(0, 75)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(571, 259)
        Me.ListView2.TabIndex = 19
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "STUDENT NO."
        Me.ColumnHeader9.Width = 103
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "FULL NAME"
        Me.ColumnHeader10.Width = 287
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "PROGRAM"
        Me.ColumnHeader11.Width = 115
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "YEAR LEVEL"
        Me.ColumnHeader12.Width = 87
        '
        'ToolStrip7
        '
        Me.ToolStrip7.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ToolStripButton6, Me.ToolStripSeparator4, Me.ToolStripButton7, Me.ToolStripSeparator1})
        Me.ToolStrip7.Location = New System.Drawing.Point(0, 50)
        Me.ToolStrip7.Name = "ToolStrip7"
        Me.ToolStrip7.Size = New System.Drawing.Size(571, 25)
        Me.ToolStrip7.TabIndex = 18
        Me.ToolStrip7.Text = "ToolStrip7"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(75, 22)
        Me.ToolStripButton2.Text = "Select All"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(89, 22)
        Me.ToolStripButton6.Text = "Unselect All"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(143, 22)
        Me.ToolStripButton7.Text = "TRANSFER SELECTED "
        Me.ToolStripButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStrip12
        '
        Me.ToolStrip12.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel17, Me.ToolStripComboBox7, Me.ToolStripComboBox8})
        Me.ToolStrip12.Location = New System.Drawing.Point(0, 25)
        Me.ToolStrip12.Name = "ToolStrip12"
        Me.ToolStrip12.Size = New System.Drawing.Size(571, 25)
        Me.ToolStrip12.TabIndex = 17
        Me.ToolStrip12.Text = "ToolStrip12"
        '
        'ToolStripLabel17
        '
        Me.ToolStripLabel17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel17.Name = "ToolStripLabel17"
        Me.ToolStripLabel17.Size = New System.Drawing.Size(114, 22)
        Me.ToolStripLabel17.Text = "Source Class Schedule"
        '
        'ToolStripComboBox7
        '
        Me.ToolStripComboBox7.Name = "ToolStripComboBox7"
        Me.ToolStripComboBox7.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripComboBox8
        '
        Me.ToolStripComboBox8.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.ToolStripComboBox8.Name = "ToolStripComboBox8"
        Me.ToolStripComboBox8.Size = New System.Drawing.Size(200, 25)
        '
        'ToolStrip11
        '
        Me.ToolStrip11.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel16, Me.ToolStripLabel18, Me.cboSource})
        Me.ToolStrip11.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip11.Name = "ToolStrip11"
        Me.ToolStrip11.Size = New System.Drawing.Size(571, 25)
        Me.ToolStrip11.TabIndex = 16
        Me.ToolStrip11.Text = "ToolStrip11"
        '
        'ToolStripLabel16
        '
        Me.ToolStripLabel16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel16.Name = "ToolStripLabel16"
        Me.ToolStripLabel16.Size = New System.Drawing.Size(85, 22)
        Me.ToolStripLabel16.Text = "Source Campus:"
        '
        'ToolStripLabel18
        '
        Me.ToolStripLabel18.Name = "ToolStripLabel18"
        Me.ToolStripLabel18.Size = New System.Drawing.Size(28, 22)
        Me.ToolStripLabel18.Text = "       "
        '
        'cboSource
        '
        Me.cboSource.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.cboSource.Name = "cboSource"
        Me.cboSource.Size = New System.Drawing.Size(250, 25)
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel13, Me.cboClass, Me.cboSubject})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(508, 25)
        Me.ToolStrip3.TabIndex = 0
        Me.ToolStrip3.Text = "ToolStrip3"
        Me.ToolStrip3.Visible = False
        '
        'ToolStripLabel13
        '
        Me.ToolStripLabel13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel13.Name = "ToolStripLabel13"
        Me.ToolStripLabel13.Size = New System.Drawing.Size(114, 22)
        Me.ToolStripLabel13.Text = "Source Class Schedule"
        '
        'cboClass
        '
        Me.cboClass.Name = "cboClass"
        Me.cboClass.Size = New System.Drawing.Size(121, 25)
        '
        'cboSubject
        '
        Me.cboSubject.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.cboSubject.Name = "cboSubject"
        Me.cboSubject.Size = New System.Drawing.Size(200, 25)
        '
        'ListView3
        '
        Me.ListView3.CheckBoxes = True
        Me.ListView3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16})
        Me.ListView3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView3.FullRowSelect = True
        Me.ListView3.GridLines = True
        Me.ListView3.HoverSelection = True
        Me.ListView3.Location = New System.Drawing.Point(0, 75)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(553, 259)
        Me.ListView3.TabIndex = 13
        Me.ListView3.UseCompatibleStateImageBehavior = False
        Me.ListView3.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "STUDENT NO."
        Me.ColumnHeader13.Width = 103
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "FULL NAME"
        Me.ColumnHeader14.Width = 287
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "PROGRAM"
        Me.ColumnHeader15.Width = 115
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "YEAR LEVEL"
        Me.ColumnHeader16.Width = 87
        '
        'ToolStrip8
        '
        Me.ToolStrip8.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton9, Me.ToolStripButton10, Me.ToolStripSeparator6, Me.ToolStripButton11, Me.ToolStripSeparator7})
        Me.ToolStrip8.Location = New System.Drawing.Point(0, 50)
        Me.ToolStrip8.Name = "ToolStrip8"
        Me.ToolStrip8.Size = New System.Drawing.Size(553, 25)
        Me.ToolStrip8.TabIndex = 12
        Me.ToolStrip8.Text = "ToolStrip8"
        '
        'ToolStripButton9
        '
        Me.ToolStripButton9.Image = CType(resources.GetObject("ToolStripButton9.Image"), System.Drawing.Image)
        Me.ToolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton9.Name = "ToolStripButton9"
        Me.ToolStripButton9.Size = New System.Drawing.Size(75, 22)
        Me.ToolStripButton9.Text = "Select All"
        '
        'ToolStripButton10
        '
        Me.ToolStripButton10.Image = CType(resources.GetObject("ToolStripButton10.Image"), System.Drawing.Image)
        Me.ToolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton10.Name = "ToolStripButton10"
        Me.ToolStripButton10.Size = New System.Drawing.Size(89, 22)
        Me.ToolStripButton10.Text = "Unselect All"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton11
        '
        Me.ToolStripButton11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton11.Image = CType(resources.GetObject("ToolStripButton11.Image"), System.Drawing.Image)
        Me.ToolStripButton11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton11.Name = "ToolStripButton11"
        Me.ToolStripButton11.Size = New System.Drawing.Size(143, 22)
        Me.ToolStripButton11.Text = "TRANSFER SELECTED "
        Me.ToolStripButton11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripButton11.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStrip9
        '
        Me.ToolStrip9.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel14, Me.cboDestinationSection, Me.ToolStripComboBox3})
        Me.ToolStrip9.Location = New System.Drawing.Point(0, 25)
        Me.ToolStrip9.Name = "ToolStrip9"
        Me.ToolStrip9.Size = New System.Drawing.Size(553, 25)
        Me.ToolStrip9.TabIndex = 11
        Me.ToolStrip9.Text = "ToolStrip9"
        '
        'ToolStripLabel14
        '
        Me.ToolStripLabel14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel14.Name = "ToolStripLabel14"
        Me.ToolStripLabel14.Size = New System.Drawing.Size(135, 22)
        Me.ToolStripLabel14.Text = "Destination Class Schedule"
        '
        'cboDestinationSection
        '
        Me.cboDestinationSection.Name = "cboDestinationSection"
        Me.cboDestinationSection.Size = New System.Drawing.Size(121, 23)
        '
        'ToolStripComboBox3
        '
        Me.ToolStripComboBox3.Name = "ToolStripComboBox3"
        Me.ToolStripComboBox3.Size = New System.Drawing.Size(200, 23)
        '
        'ToolStrip10
        '
        Me.ToolStrip10.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel15, Me.cboDestination})
        Me.ToolStrip10.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip10.Name = "ToolStrip10"
        Me.ToolStrip10.Size = New System.Drawing.Size(553, 25)
        Me.ToolStrip10.TabIndex = 10
        Me.ToolStrip10.Text = "ToolStrip10"
        '
        'ToolStripLabel15
        '
        Me.ToolStripLabel15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel15.Name = "ToolStripLabel15"
        Me.ToolStripLabel15.Size = New System.Drawing.Size(133, 22)
        Me.ToolStripLabel15.Text = "Destination Campus:         "
        '
        'cboDestination
        '
        Me.cboDestination.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.cboDestination.Name = "cboDestination"
        Me.cboDestination.Size = New System.Drawing.Size(250, 23)
        '
        'ToolStrip14
        '
        Me.ToolStrip14.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel19, Me.ToolStripComboBox5, Me.cmdBrowseAY})
        Me.ToolStrip14.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip14.Name = "ToolStrip14"
        Me.ToolStrip14.Size = New System.Drawing.Size(1128, 25)
        Me.ToolStrip14.TabIndex = 16
        Me.ToolStrip14.Text = "ToolStrip14"
        '
        'ToolStripLabel19
        '
        Me.ToolStripLabel19.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel19.Name = "ToolStripLabel19"
        Me.ToolStripLabel19.Size = New System.Drawing.Size(186, 22)
        Me.ToolStripLabel19.Text = "Academic Year and Semester:"
        '
        'ToolStripComboBox5
        '
        Me.ToolStripComboBox5.Name = "ToolStripComboBox5"
        Me.ToolStripComboBox5.Size = New System.Drawing.Size(200, 25)
        '
        'cmdBrowseAY
        '
        Me.cmdBrowseAY.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdBrowseAY.Image = CType(resources.GetObject("cmdBrowseAY.Image"), System.Drawing.Image)
        Me.cmdBrowseAY.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdBrowseAY.Name = "cmdBrowseAY"
        Me.cmdBrowseAY.Size = New System.Drawing.Size(23, 22)
        Me.cmdBrowseAY.Text = "Pick School Year"
        '
        'ToolStrip4
        '
        Me.ToolStrip4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripLabel2, Me.ToolStripLabel9, Me.ToolStripLabel10, Me.ToolStripLabel11, Me.ToolStripLabel12})
        Me.ToolStrip4.Location = New System.Drawing.Point(3, 362)
        Me.ToolStrip4.Name = "ToolStrip4"
        Me.ToolStrip4.Size = New System.Drawing.Size(1128, 25)
        Me.ToolStrip4.TabIndex = 5
        Me.ToolStrip4.Text = "ToolStrip4"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(86, 22)
        Me.ToolStripLabel1.Text = "Total Students:"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(15, 22)
        Me.ToolStripLabel2.Text = "0"
        '
        'ToolStripLabel9
        '
        Me.ToolStripLabel9.Name = "ToolStripLabel9"
        Me.ToolStripLabel9.Size = New System.Drawing.Size(28, 22)
        Me.ToolStripLabel9.Text = "       "
        '
        'ToolStripLabel10
        '
        Me.ToolStripLabel10.Name = "ToolStripLabel10"
        Me.ToolStripLabel10.Size = New System.Drawing.Size(54, 22)
        Me.ToolStripLabel10.Text = "Selected:"
        '
        'ToolStripLabel11
        '
        Me.ToolStripLabel11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel11.Name = "ToolStripLabel11"
        Me.ToolStripLabel11.Size = New System.Drawing.Size(15, 22)
        Me.ToolStripLabel11.Text = "0"
        '
        'ToolStripLabel12
        '
        Me.ToolStripLabel12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel12.Name = "ToolStripLabel12"
        Me.ToolStripLabel12.Size = New System.Drawing.Size(47, 22)
        Me.ToolStripLabel12.Text = "          "
        '
        'tpSection
        '
        Me.tpSection.Controls.Add(Me.SplitContainer1)
        Me.tpSection.Controls.Add(Me.ToolStrip1)
        Me.tpSection.Controls.Add(Me.Panel1)
        Me.tpSection.ImageIndex = 78
        Me.tpSection.Location = New System.Drawing.Point(4, 23)
        Me.tpSection.Name = "tpSection"
        Me.tpSection.Padding = New System.Windows.Forms.Padding(3)
        Me.tpSection.Size = New System.Drawing.Size(1134, 390)
        Me.tpSection.TabIndex = 0
        Me.tpSection.Text = "Class Sections (Split/Merge)"
        Me.tpSection.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 38)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TabControl2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1128, 324)
        Me.SplitContainer1.SplitterDistance = 589
        Me.SplitContainer1.TabIndex = 5
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.ImageList = Me.img16X16
        Me.TabControl2.Location = New System.Drawing.Point(0, 0)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(589, 324)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.lsvSource)
        Me.TabPage4.Controls.Add(Me.ToolStrip2)
        Me.TabPage4.ImageIndex = 39
        Me.TabPage4.Location = New System.Drawing.Point(4, 23)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(581, 297)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Source Class Section"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'lsvSource
        '
        Me.lsvSource.CheckBoxes = True
        Me.lsvSource.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lsvSource.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsvSource.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvSource.FullRowSelect = True
        Me.lsvSource.GridLines = True
        Me.lsvSource.HoverSelection = True
        Me.lsvSource.Location = New System.Drawing.Point(3, 28)
        Me.lsvSource.Name = "lsvSource"
        Me.lsvSource.Size = New System.Drawing.Size(575, 266)
        Me.lsvSource.TabIndex = 4
        Me.lsvSource.UseCompatibleStateImageBehavior = False
        Me.lsvSource.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "STUDENT NO."
        Me.ColumnHeader1.Width = 118
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "FULL NAME"
        Me.ColumnHeader2.Width = 256
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "PROGRAM"
        Me.ColumnHeader3.Width = 181
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "YEAR LEVEL"
        Me.ColumnHeader4.Width = 87
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel7, Me.ToolStripSeparator3, Me.txtSection, Me.ToolStripButton1})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(575, 25)
        Me.ToolStrip2.TabIndex = 1
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel7
        '
        Me.ToolStripLabel7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel7.Name = "ToolStripLabel7"
        Me.ToolStripLabel7.Size = New System.Drawing.Size(123, 22)
        Me.ToolStripLabel7.Text = "Source Class Section"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'txtSection
        '
        Me.txtSection.BackColor = System.Drawing.SystemColors.Info
        Me.txtSection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSection.Name = "txtSection"
        Me.txtSection.Size = New System.Drawing.Size(200, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
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
        Me.img16X16.Images.SetKeyName(78, "constraints_32.png")
        Me.img16X16.Images.SetKeyName(79, "compare_32.png")
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabPage3)
        Me.TabControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl3.ImageList = Me.img16X16
        Me.TabControl3.Location = New System.Drawing.Point(0, 0)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(535, 324)
        Me.TabControl3.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ListView1)
        Me.TabPage3.Controls.Add(Me.ToolStrip6)
        Me.TabPage3.ImageIndex = 40
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(527, 297)
        Me.TabPage3.TabIndex = 1
        Me.TabPage3.Text = "Destination Class Section"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.CheckBoxes = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HoverSelection = True
        Me.ListView1.Location = New System.Drawing.Point(3, 28)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(521, 266)
        Me.ListView1.TabIndex = 9
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "STUDENT NO."
        Me.ColumnHeader5.Width = 118
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "FULL NAME"
        Me.ColumnHeader6.Width = 256
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "PROGRAM"
        Me.ColumnHeader7.Width = 181
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "YEAR LEVEL"
        Me.ColumnHeader8.Width = 87
        '
        'ToolStrip6
        '
        Me.ToolStrip6.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel8, Me.ToolStripSeparator5, Me.ToolStripTextBox1, Me.ToolStripButton8})
        Me.ToolStrip6.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip6.Name = "ToolStrip6"
        Me.ToolStrip6.Size = New System.Drawing.Size(521, 25)
        Me.ToolStrip6.TabIndex = 5
        Me.ToolStrip6.Text = "ToolStrip6"
        '
        'ToolStripLabel8
        '
        Me.ToolStripLabel8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel8.Name = "ToolStripLabel8"
        Me.ToolStripLabel8.Size = New System.Drawing.Size(149, 22)
        Me.ToolStripLabel8.Text = "Destination Class Section"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.BackColor = System.Drawing.SystemColors.Info
        Me.ToolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(200, 25)
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.Image = CType(resources.GetObject("ToolStripButton8.Image"), System.Drawing.Image)
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton8.Text = "ToolStripButton1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel3, Me.lblCount, Me.ToolStripLabel4, Me.ToolStripLabel5, Me.lblSelected, Me.ToolStripLabel6, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripButton5})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 362)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1128, 25)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(86, 22)
        Me.ToolStripLabel3.Text = "Total Students:"
        '
        'lblCount
        '
        Me.lblCount.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(15, 22)
        Me.lblCount.Text = "0"
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(22, 22)
        Me.ToolStripLabel4.Text = "     "
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(54, 22)
        Me.ToolStripLabel5.Text = "Selected:"
        '
        'lblSelected
        '
        Me.lblSelected.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(15, 22)
        Me.lblSelected.Text = "0"
        '
        'ToolStripLabel6
        '
        Me.ToolStripLabel6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel6.Name = "ToolStripLabel6"
        Me.ToolStripLabel6.Size = New System.Drawing.Size(39, 22)
        Me.ToolStripLabel6.Text = "        "
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cboCampus)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cboCampusID)
        Me.Panel1.Controls.Add(Me.cmdGetSchoolYear)
        Me.Panel1.Controls.Add(Me.txtSchoolYear)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1128, 35)
        Me.Panel1.TabIndex = 2
        '
        'cboCampus
        '
        Me.cboCampus.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cboCampus.ArrowColor = System.Drawing.Color.Black
        Me.cboCampus.BindedControl = CType(resources.GetObject("cboCampus.BindedControl"), MTGCComboBox.ControlloAssociato)
        Me.cboCampus.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D
        Me.cboCampus.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboCampus.ColumnNum = 2
        Me.cboCampus.ColumnWidth = "300;0"
        Me.cboCampus.DisabledArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cboCampus.DisabledArrowColor = System.Drawing.Color.LightGray
        Me.cboCampus.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.cboCampus.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder
        Me.cboCampus.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.cboCampus.DisplayMember = "Text"
        Me.cboCampus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboCampus.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cboCampus.DropDownForeColor = System.Drawing.Color.Black
        Me.cboCampus.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.cboCampus.DropDownWidth = 320
        Me.cboCampus.GridLineColor = System.Drawing.Color.LightGray
        Me.cboCampus.GridLineHorizontal = True
        Me.cboCampus.GridLineVertical = True
        Me.cboCampus.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.cboCampus.Location = New System.Drawing.Point(571, 7)
        Me.cboCampus.ManagingFastMouseMoving = True
        Me.cboCampus.ManagingFastMouseMovingInterval = 30
        Me.cboCampus.Name = "cboCampus"
        Me.cboCampus.SelectedItem = Nothing
        Me.cboCampus.SelectedValue = Nothing
        Me.cboCampus.Size = New System.Drawing.Size(306, 23)
        Me.cboCampus.TabIndex = 75
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(440, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 14)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Select the Campus:"
        '
        'cboCampusID
        '
        Me.cboCampusID.FormattingEnabled = True
        Me.cboCampusID.Location = New System.Drawing.Point(883, 7)
        Me.cboCampusID.Name = "cboCampusID"
        Me.cboCampusID.Size = New System.Drawing.Size(25, 22)
        Me.cboCampusID.TabIndex = 73
        Me.cboCampusID.Visible = False
        '
        'cmdGetSchoolYear
        '
        Me.cmdGetSchoolYear.Image = CType(resources.GetObject("cmdGetSchoolYear.Image"), System.Drawing.Image)
        Me.cmdGetSchoolYear.Location = New System.Drawing.Point(403, 7)
        Me.cmdGetSchoolYear.Name = "cmdGetSchoolYear"
        Me.cmdGetSchoolYear.Size = New System.Drawing.Size(25, 23)
        Me.cmdGetSchoolYear.TabIndex = 71
        Me.cmdGetSchoolYear.UseVisualStyleBackColor = True
        '
        'txtSchoolYear
        '
        Me.txtSchoolYear.BackColor = System.Drawing.SystemColors.Info
        Me.txtSchoolYear.Location = New System.Drawing.Point(196, 8)
        Me.txtSchoolYear.Name = "txtSchoolYear"
        Me.txtSchoolYear.Size = New System.Drawing.Size(207, 22)
        Me.txtSchoolYear.TabIndex = 70
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(186, 14)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Academic Year and Semester:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpSection)
        Me.TabControl1.Controls.Add(Me.tpSchedule)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.ImageList = Me.img16X16
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1142, 417)
        Me.TabControl1.TabIndex = 3
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(75, 22)
        Me.ToolStripButton3.Text = "Select All"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(89, 22)
        Me.ToolStripButton4.Text = "Unselect All"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripButton5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(143, 22)
        Me.ToolStripButton5.Text = "TRANSFER SELECTED "
        Me.ToolStripButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'frmSplitMerge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1142, 417)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmSplitMerge"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SPLIT / MERGE MANAGEMENT"
        Me.tpSchedule.ResumeLayout(False)
        Me.tpSchedule.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ToolStrip7.ResumeLayout(False)
        Me.ToolStrip7.PerformLayout()
        Me.ToolStrip12.ResumeLayout(False)
        Me.ToolStrip12.PerformLayout()
        Me.ToolStrip11.ResumeLayout(False)
        Me.ToolStrip11.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ToolStrip8.ResumeLayout(False)
        Me.ToolStrip8.PerformLayout()
        Me.ToolStrip9.ResumeLayout(False)
        Me.ToolStrip9.PerformLayout()
        Me.ToolStrip10.ResumeLayout(False)
        Me.ToolStrip10.PerformLayout()
        Me.ToolStrip14.ResumeLayout(False)
        Me.ToolStrip14.PerformLayout()
        Me.ToolStrip4.ResumeLayout(False)
        Me.ToolStrip4.PerformLayout()
        Me.tpSection.ResumeLayout(False)
        Me.tpSection.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ToolStrip6.ResumeLayout(False)
        Me.ToolStrip6.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents imgList32X32 As System.Windows.Forms.ImageList
    Public WithEvents tpSchedule As System.Windows.Forms.TabPage
    Public WithEvents tpSection As System.Windows.Forms.TabPage
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Private WithEvents img16X16 As System.Windows.Forms.ImageList
    Friend WithEvents cboCampusID As System.Windows.Forms.ComboBox
    Friend WithEvents cmdGetSchoolYear As System.Windows.Forms.Button
    Public WithEvents txtSchoolYear As System.Windows.Forms.TextBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip4 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel9 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel10 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel11 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel12 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents lsvSource As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel7 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtSection As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabControl3 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStrip6 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel8 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lblCount As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel5 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lblSelected As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel6 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboCampus As MTGCComboBox
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStrip7 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStrip12 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel17 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripComboBox7 As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripComboBox8 As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStrip11 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel16 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel18 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboSource As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel13 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboClass As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents cboSubject As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ListView3 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStrip8 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton9 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton10 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton11 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStrip9 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel14 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboDestinationSection As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripComboBox3 As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStrip10 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel15 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboDestination As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStrip14 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel19 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripComboBox5 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents cmdBrowseAY As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
End Class
