<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentRecord
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStudentRecord))
        Me.tabMAin = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GridParents = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.GridGuardians = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.GridInfo = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkDropped = New System.Windows.Forms.CheckBox()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.chkGraduated = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picImage = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TabControl5 = New System.Windows.Forms.TabControl()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.lblNE = New System.Windows.Forms.Label()
        Me.lvTranscript = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        Me.TabControl6 = New System.Windows.Forms.TabControl()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.lvCredentials = New System.Windows.Forms.ListView()
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuNewCredential = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDeleteCredential = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuRefreshCredentials = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.lvBilling = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StatusStrip6 = New System.Windows.Forms.StatusStrip()
        Me.StatusStrip3 = New System.Windows.Forms.StatusStrip()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.lvBillingItem = New System.Windows.Forms.ListView()
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StatusStrip4 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtBillAmount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabControl7 = New System.Windows.Forms.TabControl()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.lvSubjectFee = New System.Windows.Forms.ListView()
        Me.ColumnHeader28 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader29 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader30 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader31 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StatusStrip5 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtTuitionAmount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabPage10 = New System.Windows.Forms.TabPage()
        Me.lvLabFee = New System.Windows.Forms.ListView()
        Me.ColumnHeader32 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader33 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader34 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader35 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StatusStrip7 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtLabAmount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabControl4 = New System.Windows.Forms.TabControl()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.lvPayment = New System.Windows.Forms.ListView()
        Me.ColumnHeader22 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader23 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader24 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader25 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvPaymentItem = New System.Windows.Forms.ListView()
        Me.ColumnHeader26 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader27 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tabMAin.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.GridParents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridGuardians, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl5.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.TabControl6.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.StatusStrip4.SuspendLayout()
        Me.TabControl7.SuspendLayout()
        Me.TabPage9.SuspendLayout()
        Me.StatusStrip5.SuspendLayout()
        Me.TabPage10.SuspendLayout()
        Me.StatusStrip7.SuspendLayout()
        Me.TabControl4.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabMAin
        '
        Me.tabMAin.Controls.Add(Me.TabPage3)
        Me.tabMAin.Controls.Add(Me.TabPage2)
        Me.tabMAin.Controls.Add(Me.TabPage1)
        Me.tabMAin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMAin.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabMAin.Location = New System.Drawing.Point(0, 0)
        Me.tabMAin.Name = "tabMAin"
        Me.tabMAin.SelectedIndex = 0
        Me.tabMAin.Size = New System.Drawing.Size(1018, 610)
        Me.tabMAin.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GridParents)
        Me.TabPage3.Controls.Add(Me.GridGuardians)
        Me.TabPage3.Controls.Add(Me.GridInfo)
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1010, 583)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Personal Info"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GridParents
        '
        Me.GridParents.Cols = 2
        Me.GridParents.ColumnInfo = "2,1,0,0,0,105,Columns:0{Width:116;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:680;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.GridParents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridParents.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridParents.GridColorFixed = System.Drawing.SystemColors.ControlDark
        Me.GridParents.Location = New System.Drawing.Point(3, 302)
        Me.GridParents.Name = "GridParents"
        Me.GridParents.NodeClosedPicture = Nothing
        Me.GridParents.NodeOpenPicture = Nothing
        Me.GridParents.OutlineCol = -1
        Me.GridParents.Rows = 7
        Me.GridParents.Size = New System.Drawing.Size(803, 154)
        Me.GridParents.StyleInfo = resources.GetString("GridParents.StyleInfo")
        Me.GridParents.TabIndex = 3
        Me.GridParents.TreeColor = System.Drawing.Color.DarkGray
        '
        'GridGuardians
        '
        Me.GridGuardians.Cols = 2
        Me.GridGuardians.ColumnInfo = "2,1,0,0,0,105,Columns:0{Width:116;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:680;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.GridGuardians.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GridGuardians.GridColorFixed = System.Drawing.SystemColors.ControlDark
        Me.GridGuardians.Location = New System.Drawing.Point(3, 456)
        Me.GridGuardians.Name = "GridGuardians"
        Me.GridGuardians.NodeClosedPicture = Nothing
        Me.GridGuardians.NodeOpenPicture = Nothing
        Me.GridGuardians.OutlineCol = -1
        Me.GridGuardians.Rows = 5
        Me.GridGuardians.Size = New System.Drawing.Size(803, 124)
        Me.GridGuardians.StyleInfo = resources.GetString("GridGuardians.StyleInfo")
        Me.GridGuardians.TabIndex = 2
        Me.GridGuardians.TreeColor = System.Drawing.Color.DarkGray
        '
        'GridInfo
        '
        Me.GridInfo.Cols = 2
        Me.GridInfo.ColumnInfo = "2,1,0,0,0,105,Columns:0{Width:116;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:681;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.GridInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.GridInfo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridInfo.GridColorFixed = System.Drawing.SystemColors.ControlDark
        Me.GridInfo.Location = New System.Drawing.Point(3, 3)
        Me.GridInfo.Name = "GridInfo"
        Me.GridInfo.NodeClosedPicture = Nothing
        Me.GridInfo.NodeOpenPicture = Nothing
        Me.GridInfo.OutlineCol = -1
        Me.GridInfo.Rows = 14
        Me.GridInfo.Size = New System.Drawing.Size(803, 299)
        Me.GridInfo.StyleInfo = resources.GetString("GridInfo.StyleInfo")
        Me.GridInfo.TabIndex = 1
        Me.GridInfo.TreeColor = System.Drawing.Color.DarkGray
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkDropped)
        Me.GroupBox1.Controls.Add(Me.lblLevel)
        Me.GroupBox1.Controls.Add(Me.chkGraduated)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.picImage)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox1.Location = New System.Drawing.Point(806, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(201, 577)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'chkDropped
        '
        Me.chkDropped.AutoSize = True
        Me.chkDropped.Enabled = False
        Me.chkDropped.Location = New System.Drawing.Point(17, 246)
        Me.chkDropped.Name = "chkDropped"
        Me.chkDropped.Size = New System.Drawing.Size(73, 18)
        Me.chkDropped.TabIndex = 4
        Me.chkDropped.Text = "Dropped"
        Me.chkDropped.UseVisualStyleBackColor = True
        '
        'lblLevel
        '
        Me.lblLevel.AutoSize = True
        Me.lblLevel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevel.ForeColor = System.Drawing.Color.Blue
        Me.lblLevel.Location = New System.Drawing.Point(96, 183)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(23, 16)
        Me.lblLevel.TabIndex = 3
        Me.lblLevel.Text = "---"
        '
        'chkGraduated
        '
        Me.chkGraduated.AutoSize = True
        Me.chkGraduated.Enabled = False
        Me.chkGraduated.Location = New System.Drawing.Point(17, 222)
        Me.chkGraduated.Name = "chkGraduated"
        Me.chkGraduated.Size = New System.Drawing.Size(83, 18)
        Me.chkGraduated.TabIndex = 2
        Me.chkGraduated.Text = "Graduated"
        Me.chkGraduated.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 183)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Level (Latest):"
        '
        'picImage
        '
        Me.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picImage.Image = CType(resources.GetObject("picImage.Image"), System.Drawing.Image)
        Me.picImage.Location = New System.Drawing.Point(17, 21)
        Me.picImage.Name = "picImage"
        Me.picImage.Size = New System.Drawing.Size(169, 147)
        Me.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picImage.TabIndex = 0
        Me.picImage.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SplitContainer1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1010, 583)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Transcript and Credentials"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TabControl5)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl6)
        Me.SplitContainer1.Size = New System.Drawing.Size(1004, 577)
        Me.SplitContainer1.SplitterDistance = 718
        Me.SplitContainer1.TabIndex = 0
        '
        'TabControl5
        '
        Me.TabControl5.Controls.Add(Me.TabPage7)
        Me.TabControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl5.Location = New System.Drawing.Point(0, 0)
        Me.TabControl5.Name = "TabControl5"
        Me.TabControl5.SelectedIndex = 0
        Me.TabControl5.Size = New System.Drawing.Size(718, 577)
        Me.TabControl5.TabIndex = 0
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.lblNE)
        Me.TabPage7.Controls.Add(Me.lvTranscript)
        Me.TabPage7.Controls.Add(Me.StatusStrip2)
        Me.TabPage7.Location = New System.Drawing.Point(4, 23)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(710, 550)
        Me.TabPage7.TabIndex = 0
        Me.TabPage7.Text = "Transcript"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'lblNE
        '
        Me.lblNE.AutoSize = True
        Me.lblNE.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNE.Location = New System.Drawing.Point(215, 167)
        Me.lblNE.Name = "lblNE"
        Me.lblNE.Size = New System.Drawing.Size(264, 25)
        Me.lblNE.TabIndex = 2
        Me.lblNE.Text = "Student not yet enrolled"
        Me.lblNE.Visible = False
        '
        'lvTranscript
        '
        Me.lvTranscript.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader19})
        Me.lvTranscript.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvTranscript.FullRowSelect = True
        Me.lvTranscript.Location = New System.Drawing.Point(3, 3)
        Me.lvTranscript.Name = "lvTranscript"
        Me.lvTranscript.Size = New System.Drawing.Size(704, 522)
        Me.lvTranscript.TabIndex = 1
        Me.lvTranscript.UseCompatibleStateImageBehavior = False
        Me.lvTranscript.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Subject"
        Me.ColumnHeader7.Width = 142
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "ID"
        Me.ColumnHeader8.Width = 0
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Descriptive Title"
        Me.ColumnHeader9.Width = 262
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Units"
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "1st Grading"
        Me.ColumnHeader11.Width = 100
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "2nd Grading"
        Me.ColumnHeader12.Width = 88
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "3rd Grading"
        Me.ColumnHeader17.Width = 82
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "4th Grading"
        Me.ColumnHeader18.Width = 86
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Final Rating"
        Me.ColumnHeader19.Width = 81
        '
        'StatusStrip2
        '
        Me.StatusStrip2.Location = New System.Drawing.Point(3, 525)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.Size = New System.Drawing.Size(704, 22)
        Me.StatusStrip2.TabIndex = 0
        Me.StatusStrip2.Text = "StatusStrip2"
        '
        'TabControl6
        '
        Me.TabControl6.Controls.Add(Me.TabPage8)
        Me.TabControl6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl6.Location = New System.Drawing.Point(0, 0)
        Me.TabControl6.Name = "TabControl6"
        Me.TabControl6.SelectedIndex = 0
        Me.TabControl6.Size = New System.Drawing.Size(282, 577)
        Me.TabControl6.TabIndex = 1
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.lvCredentials)
        Me.TabPage8.Location = New System.Drawing.Point(4, 23)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(274, 550)
        Me.TabPage8.TabIndex = 0
        Me.TabPage8.Text = "Credentials"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'lvCredentials
        '
        Me.lvCredentials.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader20, Me.ColumnHeader21})
        Me.lvCredentials.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lvCredentials.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvCredentials.FullRowSelect = True
        Me.lvCredentials.Location = New System.Drawing.Point(3, 3)
        Me.lvCredentials.Name = "lvCredentials"
        Me.lvCredentials.Size = New System.Drawing.Size(268, 544)
        Me.lvCredentials.TabIndex = 0
        Me.lvCredentials.UseCompatibleStateImageBehavior = False
        Me.lvCredentials.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "Credentials"
        Me.ColumnHeader20.Width = 283
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "ID"
        Me.ColumnHeader21.Width = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNewCredential, Me.mnuDeleteCredential, Me.ToolStripSeparator1, Me.mnuRefreshCredentials})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(164, 76)
        '
        'mnuNewCredential
        '
        Me.mnuNewCredential.Name = "mnuNewCredential"
        Me.mnuNewCredential.Size = New System.Drawing.Size(163, 22)
        Me.mnuNewCredential.Text = "New Credential"
        '
        'mnuDeleteCredential
        '
        Me.mnuDeleteCredential.Name = "mnuDeleteCredential"
        Me.mnuDeleteCredential.Size = New System.Drawing.Size(163, 22)
        Me.mnuDeleteCredential.Text = "Delete"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(160, 6)
        '
        'mnuRefreshCredentials
        '
        Me.mnuRefreshCredentials.Name = "mnuRefreshCredentials"
        Me.mnuRefreshCredentials.Size = New System.Drawing.Size(163, 22)
        Me.mnuRefreshCredentials.Text = "Refresh"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SplitContainer2)
        Me.TabPage1.Controls.Add(Me.TabControl4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1010, 583)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Billing and Payments"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.TabControl2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.TabControl3)
        Me.SplitContainer2.Panel2.Controls.Add(Me.TabControl7)
        Me.SplitContainer2.Size = New System.Drawing.Size(1004, 386)
        Me.SplitContainer2.SplitterDistance = 513
        Me.SplitContainer2.TabIndex = 6
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Location = New System.Drawing.Point(0, 0)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(513, 386)
        Me.TabControl2.TabIndex = 2
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.lvBilling)
        Me.TabPage4.Controls.Add(Me.StatusStrip6)
        Me.TabPage4.Controls.Add(Me.StatusStrip3)
        Me.TabPage4.Location = New System.Drawing.Point(4, 23)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(505, 359)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "Billing Accounts"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'lvBilling
        '
        Me.lvBilling.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvBilling.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvBilling.FullRowSelect = True
        Me.lvBilling.Location = New System.Drawing.Point(3, 3)
        Me.lvBilling.Name = "lvBilling"
        Me.lvBilling.Size = New System.Drawing.Size(499, 331)
        Me.lvBilling.TabIndex = 4
        Me.lvBilling.UseCompatibleStateImageBehavior = False
        Me.lvBilling.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Year"
        Me.ColumnHeader1.Width = 78
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "ID"
        Me.ColumnHeader2.Width = 0
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Date Assessed"
        Me.ColumnHeader3.Width = 126
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Total Amt."
        Me.ColumnHeader4.Width = 86
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Paid Amt."
        Me.ColumnHeader5.Width = 98
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Balance"
        Me.ColumnHeader6.Width = 85
        '
        'StatusStrip6
        '
        Me.StatusStrip6.Location = New System.Drawing.Point(3, 334)
        Me.StatusStrip6.Name = "StatusStrip6"
        Me.StatusStrip6.Size = New System.Drawing.Size(499, 22)
        Me.StatusStrip6.TabIndex = 3
        Me.StatusStrip6.Text = "StatusStrip6"
        '
        'StatusStrip3
        '
        Me.StatusStrip3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StatusStrip3.Location = New System.Drawing.Point(3, 3)
        Me.StatusStrip3.Name = "StatusStrip3"
        Me.StatusStrip3.Size = New System.Drawing.Size(499, 353)
        Me.StatusStrip3.TabIndex = 0
        Me.StatusStrip3.Text = "StatusStrip3"
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabPage5)
        Me.TabControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl3.Location = New System.Drawing.Point(0, 0)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(487, 223)
        Me.TabControl3.TabIndex = 5
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.lvBillingItem)
        Me.TabPage5.Controls.Add(Me.StatusStrip4)
        Me.TabPage5.Location = New System.Drawing.Point(4, 23)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(479, 196)
        Me.TabPage5.TabIndex = 0
        Me.TabPage5.Text = "Miscellaneous Fee"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'lvBillingItem
        '
        Me.lvBillingItem.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16})
        Me.lvBillingItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvBillingItem.ForeColor = System.Drawing.Color.Black
        Me.lvBillingItem.FullRowSelect = True
        Me.lvBillingItem.Location = New System.Drawing.Point(3, 3)
        Me.lvBillingItem.Name = "lvBillingItem"
        Me.lvBillingItem.Size = New System.Drawing.Size(473, 165)
        Me.lvBillingItem.TabIndex = 2
        Me.lvBillingItem.UseCompatibleStateImageBehavior = False
        Me.lvBillingItem.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Description"
        Me.ColumnHeader13.Width = 218
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Amount"
        Me.ColumnHeader14.Width = 83
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Paid Amt."
        Me.ColumnHeader15.Width = 83
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Balance"
        Me.ColumnHeader16.Width = 80
        '
        'StatusStrip4
        '
        Me.StatusStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel3, Me.txtBillAmount})
        Me.StatusStrip4.Location = New System.Drawing.Point(3, 168)
        Me.StatusStrip4.Name = "StatusStrip4"
        Me.StatusStrip4.Size = New System.Drawing.Size(473, 25)
        Me.StatusStrip4.TabIndex = 1
        Me.StatusStrip4.Text = "StatusStrip4"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.ToolStripStatusLabel3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(225, 20)
        Me.ToolStripStatusLabel3.Text = "                Total Billed Amount:"
        '
        'txtBillAmount
        '
        Me.txtBillAmount.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBillAmount.ForeColor = System.Drawing.Color.Blue
        Me.txtBillAmount.Name = "txtBillAmount"
        Me.txtBillAmount.Size = New System.Drawing.Size(38, 20)
        Me.txtBillAmount.Text = "0.00"
        '
        'TabControl7
        '
        Me.TabControl7.Controls.Add(Me.TabPage9)
        Me.TabControl7.Controls.Add(Me.TabPage10)
        Me.TabControl7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabControl7.Location = New System.Drawing.Point(0, 223)
        Me.TabControl7.Name = "TabControl7"
        Me.TabControl7.SelectedIndex = 0
        Me.TabControl7.Size = New System.Drawing.Size(487, 163)
        Me.TabControl7.TabIndex = 4
        '
        'TabPage9
        '
        Me.TabPage9.Controls.Add(Me.lvSubjectFee)
        Me.TabPage9.Controls.Add(Me.StatusStrip5)
        Me.TabPage9.Location = New System.Drawing.Point(4, 23)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage9.Size = New System.Drawing.Size(479, 136)
        Me.TabPage9.TabIndex = 0
        Me.TabPage9.Text = "Subject Fee"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'lvSubjectFee
        '
        Me.lvSubjectFee.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader28, Me.ColumnHeader29, Me.ColumnHeader30, Me.ColumnHeader31})
        Me.lvSubjectFee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvSubjectFee.ForeColor = System.Drawing.Color.Black
        Me.lvSubjectFee.FullRowSelect = True
        Me.lvSubjectFee.Location = New System.Drawing.Point(3, 3)
        Me.lvSubjectFee.Name = "lvSubjectFee"
        Me.lvSubjectFee.Size = New System.Drawing.Size(473, 105)
        Me.lvSubjectFee.TabIndex = 2
        Me.lvSubjectFee.UseCompatibleStateImageBehavior = False
        Me.lvSubjectFee.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader28
        '
        Me.ColumnHeader28.Text = "Description"
        Me.ColumnHeader28.Width = 218
        '
        'ColumnHeader29
        '
        Me.ColumnHeader29.Text = "Amount"
        Me.ColumnHeader29.Width = 83
        '
        'ColumnHeader30
        '
        Me.ColumnHeader30.Text = "Paid Amt."
        Me.ColumnHeader30.Width = 83
        '
        'ColumnHeader31
        '
        Me.ColumnHeader31.Text = "Balance"
        Me.ColumnHeader31.Width = 80
        '
        'StatusStrip5
        '
        Me.StatusStrip5.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.txtTuitionAmount})
        Me.StatusStrip5.Location = New System.Drawing.Point(3, 108)
        Me.StatusStrip5.Name = "StatusStrip5"
        Me.StatusStrip5.Size = New System.Drawing.Size(473, 25)
        Me.StatusStrip5.TabIndex = 1
        Me.StatusStrip5.Text = "StatusStrip5"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(217, 20)
        Me.ToolStripStatusLabel1.Text = "                Total Subject Fee:"
        '
        'txtTuitionAmount
        '
        Me.txtTuitionAmount.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTuitionAmount.Name = "txtTuitionAmount"
        Me.txtTuitionAmount.Size = New System.Drawing.Size(38, 20)
        Me.txtTuitionAmount.Text = "0.00"
        '
        'TabPage10
        '
        Me.TabPage10.Controls.Add(Me.lvLabFee)
        Me.TabPage10.Controls.Add(Me.StatusStrip7)
        Me.TabPage10.Location = New System.Drawing.Point(4, 23)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage10.Size = New System.Drawing.Size(479, 136)
        Me.TabPage10.TabIndex = 1
        Me.TabPage10.Text = "Laboratory Fee"
        Me.TabPage10.UseVisualStyleBackColor = True
        '
        'lvLabFee
        '
        Me.lvLabFee.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader32, Me.ColumnHeader33, Me.ColumnHeader34, Me.ColumnHeader35})
        Me.lvLabFee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvLabFee.ForeColor = System.Drawing.Color.Black
        Me.lvLabFee.FullRowSelect = True
        Me.lvLabFee.Location = New System.Drawing.Point(3, 3)
        Me.lvLabFee.Name = "lvLabFee"
        Me.lvLabFee.Size = New System.Drawing.Size(473, 105)
        Me.lvLabFee.TabIndex = 4
        Me.lvLabFee.UseCompatibleStateImageBehavior = False
        Me.lvLabFee.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader32
        '
        Me.ColumnHeader32.Text = "Description"
        Me.ColumnHeader32.Width = 218
        '
        'ColumnHeader33
        '
        Me.ColumnHeader33.Text = "Amount"
        Me.ColumnHeader33.Width = 83
        '
        'ColumnHeader34
        '
        Me.ColumnHeader34.Text = "Paid Amt."
        Me.ColumnHeader34.Width = 83
        '
        'ColumnHeader35
        '
        Me.ColumnHeader35.Text = "Balance"
        Me.ColumnHeader35.Width = 80
        '
        'StatusStrip7
        '
        Me.StatusStrip7.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel2, Me.txtLabAmount})
        Me.StatusStrip7.Location = New System.Drawing.Point(3, 108)
        Me.StatusStrip7.Name = "StatusStrip7"
        Me.StatusStrip7.Size = New System.Drawing.Size(473, 25)
        Me.StatusStrip7.TabIndex = 3
        Me.StatusStrip7.Text = "StatusStrip7"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(217, 20)
        Me.ToolStripStatusLabel2.Text = "            Total Laboratory Fee:"
        '
        'txtLabAmount
        '
        Me.txtLabAmount.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLabAmount.Name = "txtLabAmount"
        Me.txtLabAmount.Size = New System.Drawing.Size(38, 20)
        Me.txtLabAmount.Text = "0.00"
        '
        'TabControl4
        '
        Me.TabControl4.Controls.Add(Me.TabPage6)
        Me.TabControl4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabControl4.Location = New System.Drawing.Point(3, 389)
        Me.TabControl4.Name = "TabControl4"
        Me.TabControl4.SelectedIndex = 0
        Me.TabControl4.Size = New System.Drawing.Size(1004, 191)
        Me.TabControl4.TabIndex = 5
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.SplitContainer3)
        Me.TabPage6.Controls.Add(Me.StatusStrip1)
        Me.TabPage6.Location = New System.Drawing.Point(4, 23)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(996, 164)
        Me.TabPage6.TabIndex = 0
        Me.TabPage6.Text = "Payment Accounts"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.lvPayment)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.lvPaymentItem)
        Me.SplitContainer3.Size = New System.Drawing.Size(990, 136)
        Me.SplitContainer3.SplitterDistance = 564
        Me.SplitContainer3.TabIndex = 1
        '
        'lvPayment
        '
        Me.lvPayment.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader22, Me.ColumnHeader23, Me.ColumnHeader24, Me.ColumnHeader25})
        Me.lvPayment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvPayment.FullRowSelect = True
        Me.lvPayment.Location = New System.Drawing.Point(0, 0)
        Me.lvPayment.Name = "lvPayment"
        Me.lvPayment.Size = New System.Drawing.Size(564, 136)
        Me.lvPayment.TabIndex = 1
        Me.lvPayment.UseCompatibleStateImageBehavior = False
        Me.lvPayment.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "Payment Date"
        Me.ColumnHeader22.Width = 103
        '
        'ColumnHeader23
        '
        Me.ColumnHeader23.Text = "O.R. Number"
        Me.ColumnHeader23.Width = 139
        '
        'ColumnHeader24
        '
        Me.ColumnHeader24.Text = "Received By"
        Me.ColumnHeader24.Width = 222
        '
        'ColumnHeader25
        '
        Me.ColumnHeader25.Text = "Total Amt."
        Me.ColumnHeader25.Width = 95
        '
        'lvPaymentItem
        '
        Me.lvPaymentItem.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader26, Me.ColumnHeader27})
        Me.lvPaymentItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvPaymentItem.FullRowSelect = True
        Me.lvPaymentItem.Location = New System.Drawing.Point(0, 0)
        Me.lvPaymentItem.Name = "lvPaymentItem"
        Me.lvPaymentItem.Size = New System.Drawing.Size(422, 136)
        Me.lvPaymentItem.TabIndex = 1
        Me.lvPaymentItem.UseCompatibleStateImageBehavior = False
        Me.lvPaymentItem.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader26
        '
        Me.ColumnHeader26.Text = "Description"
        Me.ColumnHeader26.Width = 297
        '
        'ColumnHeader27
        '
        Me.ColumnHeader27.Text = "Amount"
        Me.ColumnHeader27.Width = 110
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(3, 139)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(990, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'frmStudentRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 610)
        Me.Controls.Add(Me.tabMAin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStudentRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Information"
        Me.tabMAin.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.GridParents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridGuardians, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl5.ResumeLayout(False)
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        Me.TabControl6.ResumeLayout(False)
        Me.TabPage8.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.StatusStrip4.ResumeLayout(False)
        Me.StatusStrip4.PerformLayout()
        Me.TabControl7.ResumeLayout(False)
        Me.TabPage9.ResumeLayout(False)
        Me.TabPage9.PerformLayout()
        Me.StatusStrip5.ResumeLayout(False)
        Me.StatusStrip5.PerformLayout()
        Me.TabPage10.ResumeLayout(False)
        Me.TabPage10.PerformLayout()
        Me.StatusStrip7.ResumeLayout(False)
        Me.StatusStrip7.PerformLayout()
        Me.TabControl4.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabMAin As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents StatusStrip3 As System.Windows.Forms.StatusStrip
    Friend WithEvents TabControl4 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TabControl5 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents TabControl6 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents lvTranscript As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents StatusStrip2 As System.Windows.Forms.StatusStrip
    Friend WithEvents lvCredentials As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents lvPayment As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader23 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader24 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader25 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvPaymentItem As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader26 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader27 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents picImage As System.Windows.Forms.PictureBox
    Friend WithEvents GridParents As C1.Win.C1FlexGrid.Classic.C1FlexGridClassic
    Friend WithEvents GridGuardians As C1.Win.C1FlexGrid.Classic.C1FlexGridClassic
    Friend WithEvents GridInfo As C1.Win.C1FlexGrid.Classic.C1FlexGridClassic
    Friend WithEvents lvBilling As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents StatusStrip6 As System.Windows.Forms.StatusStrip
    Friend WithEvents TabControl3 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents lvBillingItem As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents StatusStrip4 As System.Windows.Forms.StatusStrip
    Friend WithEvents TabControl7 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage9 As System.Windows.Forms.TabPage
    Friend WithEvents lvSubjectFee As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader28 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader29 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader30 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader31 As System.Windows.Forms.ColumnHeader
    Friend WithEvents StatusStrip5 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblLevel As System.Windows.Forms.Label
    Friend WithEvents chkGraduated As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkDropped As System.Windows.Forms.CheckBox
    Friend WithEvents lblNE As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuNewCredential As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDeleteCredential As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuRefreshCredentials As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtTuitionAmount As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TabPage10 As System.Windows.Forms.TabPage
    Friend WithEvents lvLabFee As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader32 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader33 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader34 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader35 As System.Windows.Forms.ColumnHeader
    Friend WithEvents StatusStrip7 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtLabAmount As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtBillAmount As System.Windows.Forms.ToolStripStatusLabel
End Class
