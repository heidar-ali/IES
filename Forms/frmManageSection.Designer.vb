<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManageSection
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

    Friend WithEvents ToolStripContainer As System.Windows.Forms.ToolStripContainer
    Friend WithEvents TreeNodeImageList As System.Windows.Forms.ImageList
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ListViewToolStripButton As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LargeIconsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SmallIconsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents ListView As System.Windows.Forms.ListView
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ListViewLargeImageList As System.Windows.Forms.ImageList
    Friend WithEvents ListViewSmallImageList As System.Windows.Forms.ImageList

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManageSection))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TreeNodeImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cboAY = New System.Windows.Forms.ToolStripComboBox()
        Me.cboAYID = New System.Windows.Forms.ToolStripComboBox()
        Me.ListViewToolStripButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LargeIconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SmallIconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdPrintSection = New System.Windows.Forms.ToolStripDropDownButton()
        Me.PrintListOfClassScheduleAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintListOfClassScheduleProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintListOfCourseOfferedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdPrintOffering = New System.Windows.Forms.ToolStripDropDownButton()
        Me.PrintListOfRegisteredStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintOfficialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStripContainer = New System.Windows.Forms.ToolStripContainer()
        Me.SplitContainer = New System.Windows.Forms.SplitContainer()
        Me.TreeView = New System.Windows.Forms.TreeView()
        Me.popTree = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.cboCollege = New MTGCComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboCampus = New MTGCComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListView = New System.Windows.Forms.ListView()
        Me.ListViewLargeImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.ListViewSmallImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.popClassSection = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddNewBlockSectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewFreeSectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RenameClassSectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteClassSectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClassSectionScheduleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.DissolveClassSectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.PropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.popOffering = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddNewSubjectOfferingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReplaceSubjectOfferingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteSubjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ModifyClassLimitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.ToolStripContainer.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer.ContentPanel.SuspendLayout()
        Me.ToolStripContainer.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer.SuspendLayout()
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer.Panel1.SuspendLayout()
        Me.SplitContainer.Panel2.SuspendLayout()
        Me.SplitContainer.SuspendLayout()
        Me.popTree.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.popClassSection.SuspendLayout()
        Me.popOffering.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1008, 22)
        Me.StatusStrip.TabIndex = 6
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'TreeNodeImageList
        '
        Me.TreeNodeImageList.ImageStream = CType(resources.GetObject("TreeNodeImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.TreeNodeImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.TreeNodeImageList.Images.SetKeyName(0, "gohome.ico")
        Me.TreeNodeImageList.Images.SetKeyName(1, "OpenFolder")
        Me.TreeNodeImageList.Images.SetKeyName(2, "favorite.ico")
        Me.TreeNodeImageList.Images.SetKeyName(3, "forward.ico")
        '
        'ToolStrip
        '
        Me.ToolStrip.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboAY, Me.cboAYID, Me.ListViewToolStripButton, Me.cmdPrintSection, Me.cmdPrintOffering})
        Me.ToolStrip.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(427, 25)
        Me.ToolStrip.TabIndex = 0
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(184, 22)
        Me.ToolStripLabel1.Text = "Select Academic Year and Term:"
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
        'ListViewToolStripButton
        '
        Me.ListViewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ListViewToolStripButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListToolStripMenuItem, Me.DetailsToolStripMenuItem, Me.LargeIconsToolStripMenuItem, Me.SmallIconsToolStripMenuItem, Me.TileToolStripMenuItem})
        Me.ListViewToolStripButton.Image = CType(resources.GetObject("ListViewToolStripButton.Image"), System.Drawing.Image)
        Me.ListViewToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.ListViewToolStripButton.Name = "ListViewToolStripButton"
        Me.ListViewToolStripButton.Size = New System.Drawing.Size(29, 22)
        Me.ListViewToolStripButton.Text = "Views"
        '
        'ListToolStripMenuItem
        '
        Me.ListToolStripMenuItem.Name = "ListToolStripMenuItem"
        Me.ListToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ListToolStripMenuItem.Text = "List"
        '
        'DetailsToolStripMenuItem
        '
        Me.DetailsToolStripMenuItem.Checked = True
        Me.DetailsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.DetailsToolStripMenuItem.Name = "DetailsToolStripMenuItem"
        Me.DetailsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DetailsToolStripMenuItem.Text = "Details"
        '
        'LargeIconsToolStripMenuItem
        '
        Me.LargeIconsToolStripMenuItem.Name = "LargeIconsToolStripMenuItem"
        Me.LargeIconsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LargeIconsToolStripMenuItem.Text = "Large Icons"
        '
        'SmallIconsToolStripMenuItem
        '
        Me.SmallIconsToolStripMenuItem.Name = "SmallIconsToolStripMenuItem"
        Me.SmallIconsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SmallIconsToolStripMenuItem.Text = "Small Icons"
        '
        'TileToolStripMenuItem
        '
        Me.TileToolStripMenuItem.Name = "TileToolStripMenuItem"
        Me.TileToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TileToolStripMenuItem.Text = "Tile"
        '
        'cmdPrintSection
        '
        Me.cmdPrintSection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdPrintSection.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintListOfClassScheduleAllToolStripMenuItem, Me.PrintListOfClassScheduleProgramToolStripMenuItem, Me.PrintListOfCourseOfferedToolStripMenuItem})
        Me.cmdPrintSection.Image = CType(resources.GetObject("cmdPrintSection.Image"), System.Drawing.Image)
        Me.cmdPrintSection.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrintSection.Name = "cmdPrintSection"
        Me.cmdPrintSection.Size = New System.Drawing.Size(29, 22)
        Me.cmdPrintSection.Text = "ToolStripButton1"
        Me.cmdPrintSection.Visible = False
        '
        'PrintListOfClassScheduleAllToolStripMenuItem
        '
        Me.PrintListOfClassScheduleAllToolStripMenuItem.Image = CType(resources.GetObject("PrintListOfClassScheduleAllToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintListOfClassScheduleAllToolStripMenuItem.Name = "PrintListOfClassScheduleAllToolStripMenuItem"
        Me.PrintListOfClassScheduleAllToolStripMenuItem.Size = New System.Drawing.Size(272, 22)
        Me.PrintListOfClassScheduleAllToolStripMenuItem.Text = "Print List of Class Schedule (All)"
        '
        'PrintListOfClassScheduleProgramToolStripMenuItem
        '
        Me.PrintListOfClassScheduleProgramToolStripMenuItem.Image = CType(resources.GetObject("PrintListOfClassScheduleProgramToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintListOfClassScheduleProgramToolStripMenuItem.Name = "PrintListOfClassScheduleProgramToolStripMenuItem"
        Me.PrintListOfClassScheduleProgramToolStripMenuItem.Size = New System.Drawing.Size(272, 22)
        Me.PrintListOfClassScheduleProgramToolStripMenuItem.Text = "Print List of Class Schedule (Program)"
        '
        'PrintListOfCourseOfferedToolStripMenuItem
        '
        Me.PrintListOfCourseOfferedToolStripMenuItem.Image = CType(resources.GetObject("PrintListOfCourseOfferedToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintListOfCourseOfferedToolStripMenuItem.Name = "PrintListOfCourseOfferedToolStripMenuItem"
        Me.PrintListOfCourseOfferedToolStripMenuItem.Size = New System.Drawing.Size(272, 22)
        Me.PrintListOfCourseOfferedToolStripMenuItem.Text = "Print List of Course Offered"
        '
        'cmdPrintOffering
        '
        Me.cmdPrintOffering.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdPrintOffering.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintListOfRegisteredStudentToolStripMenuItem, Me.PrintOfficialToolStripMenuItem})
        Me.cmdPrintOffering.Image = CType(resources.GetObject("cmdPrintOffering.Image"), System.Drawing.Image)
        Me.cmdPrintOffering.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrintOffering.Name = "cmdPrintOffering"
        Me.cmdPrintOffering.Size = New System.Drawing.Size(29, 22)
        Me.cmdPrintOffering.Text = "ToolStripButton2"
        Me.cmdPrintOffering.Visible = False
        '
        'PrintListOfRegisteredStudentToolStripMenuItem
        '
        Me.PrintListOfRegisteredStudentToolStripMenuItem.Image = CType(resources.GetObject("PrintListOfRegisteredStudentToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintListOfRegisteredStudentToolStripMenuItem.Name = "PrintListOfRegisteredStudentToolStripMenuItem"
        Me.PrintListOfRegisteredStudentToolStripMenuItem.Size = New System.Drawing.Size(270, 22)
        Me.PrintListOfRegisteredStudentToolStripMenuItem.Text = "Print List of Registered Students"
        '
        'PrintOfficialToolStripMenuItem
        '
        Me.PrintOfficialToolStripMenuItem.Image = CType(resources.GetObject("PrintOfficialToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintOfficialToolStripMenuItem.Name = "PrintOfficialToolStripMenuItem"
        Me.PrintOfficialToolStripMenuItem.Size = New System.Drawing.Size(270, 22)
        Me.PrintOfficialToolStripMenuItem.Text = "Print Official List of Enrolled Students"
        '
        'ToolStripContainer
        '
        '
        'ToolStripContainer.BottomToolStripPanel
        '
        Me.ToolStripContainer.BottomToolStripPanel.Controls.Add(Me.StatusStrip)
        '
        'ToolStripContainer.ContentPanel
        '
        Me.ToolStripContainer.ContentPanel.Controls.Add(Me.SplitContainer)
        Me.ToolStripContainer.ContentPanel.Size = New System.Drawing.Size(1008, 683)
        Me.ToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer.Name = "ToolStripContainer"
        Me.ToolStripContainer.Size = New System.Drawing.Size(1008, 730)
        Me.ToolStripContainer.TabIndex = 7
        Me.ToolStripContainer.Text = "ToolStripContainer1"
        '
        'ToolStripContainer.TopToolStripPanel
        '
        Me.ToolStripContainer.TopToolStripPanel.Controls.Add(Me.ToolStrip)
        '
        'SplitContainer
        '
        Me.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer.IsSplitterFixed = True
        Me.SplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer.Name = "SplitContainer"
        '
        'SplitContainer.Panel1
        '
        Me.SplitContainer.Panel1.Controls.Add(Me.TreeView)
        Me.SplitContainer.Panel1.Controls.Add(Me.GroupControl1)
        '
        'SplitContainer.Panel2
        '
        Me.SplitContainer.Panel2.Controls.Add(Me.ListView)
        Me.SplitContainer.Size = New System.Drawing.Size(1008, 683)
        Me.SplitContainer.SplitterDistance = 336
        Me.SplitContainer.TabIndex = 0
        Me.SplitContainer.Text = "SplitContainer1"
        '
        'TreeView
        '
        Me.TreeView.ContextMenuStrip = Me.popTree
        Me.TreeView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView.ImageIndex = 0
        Me.TreeView.ImageList = Me.TreeNodeImageList
        Me.TreeView.Location = New System.Drawing.Point(0, 96)
        Me.TreeView.Name = "TreeView"
        Me.TreeView.SelectedImageIndex = 0
        Me.TreeView.Size = New System.Drawing.Size(336, 587)
        Me.TreeView.TabIndex = 1
        '
        'popTree
        '
        Me.popTree.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem1})
        Me.popTree.Name = "ContextMenuStrip1"
        Me.popTree.Size = New System.Drawing.Size(114, 26)
        '
        'RefreshToolStripMenuItem1
        '
        Me.RefreshToolStripMenuItem1.Name = "RefreshToolStripMenuItem1"
        Me.RefreshToolStripMenuItem1.Size = New System.Drawing.Size(113, 22)
        Me.RefreshToolStripMenuItem1.Text = "Refresh"
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.GroupControl1.Appearance.Options.UseBackColor = True
        Me.GroupControl1.Controls.Add(Me.cboCollege)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.cboCampus)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(336, 96)
        Me.GroupControl1.TabIndex = 0
        '
        'cboCollege
        '
        Me.cboCollege.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cboCollege.ArrowColor = System.Drawing.Color.Black
        Me.cboCollege.BindedControl = CType(resources.GetObject("cboCollege.BindedControl"), MTGCComboBox.ControlloAssociato)
        Me.cboCollege.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D
        Me.cboCollege.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboCollege.ColumnNum = 3
        Me.cboCollege.ColumnWidth = "130;200;0"
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
        Me.cboCollege.DropDownWidth = 500
        Me.cboCollege.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCollege.GridLineColor = System.Drawing.Color.LightGray
        Me.cboCollege.GridLineHorizontal = True
        Me.cboCollege.GridLineVertical = True
        Me.cboCollege.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.cboCollege.Location = New System.Drawing.Point(71, 58)
        Me.cboCollege.ManagingFastMouseMoving = True
        Me.cboCollege.ManagingFastMouseMovingInterval = 30
        Me.cboCollege.Name = "cboCollege"
        Me.cboCollege.SelectedItem = Nothing
        Me.cboCollege.SelectedValue = Nothing
        Me.cboCollege.Size = New System.Drawing.Size(260, 23)
        Me.cboCollege.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "College:"
        '
        'cboCampus
        '
        Me.cboCampus.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cboCampus.ArrowColor = System.Drawing.Color.Black
        Me.cboCampus.BindedControl = CType(resources.GetObject("cboCampus.BindedControl"), MTGCComboBox.ControlloAssociato)
        Me.cboCampus.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D
        Me.cboCampus.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboCampus.ColumnNum = 2
        Me.cboCampus.ColumnWidth = "200;0"
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
        Me.cboCampus.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCampus.GridLineColor = System.Drawing.Color.LightGray
        Me.cboCampus.GridLineHorizontal = True
        Me.cboCampus.GridLineVertical = True
        Me.cboCampus.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.cboCampus.Location = New System.Drawing.Point(71, 29)
        Me.cboCampus.ManagingFastMouseMoving = True
        Me.cboCampus.ManagingFastMouseMovingInterval = 30
        Me.cboCampus.Name = "cboCampus"
        Me.cboCampus.SelectedItem = Nothing
        Me.cboCampus.SelectedValue = Nothing
        Me.cboCampus.Size = New System.Drawing.Size(260, 23)
        Me.cboCampus.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Campus:"
        '
        'ListView
        '
        Me.ListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView.FullRowSelect = True
        Me.ListView.LargeImageList = Me.ListViewLargeImageList
        Me.ListView.Location = New System.Drawing.Point(0, 0)
        Me.ListView.Name = "ListView"
        Me.ListView.Size = New System.Drawing.Size(668, 683)
        Me.ListView.SmallImageList = Me.ListViewSmallImageList
        Me.ListView.TabIndex = 0
        Me.ListView.UseCompatibleStateImageBehavior = False
        '
        'ListViewLargeImageList
        '
        Me.ListViewLargeImageList.ImageStream = CType(resources.GetObject("ListViewLargeImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ListViewLargeImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ListViewLargeImageList.Images.SetKeyName(0, "Windows 7 (2).png")
        Me.ListViewLargeImageList.Images.SetKeyName(1, "Windows 7 (7).png")
        Me.ListViewLargeImageList.Images.SetKeyName(2, "Windows 7 (9).png")
        Me.ListViewLargeImageList.Images.SetKeyName(3, "Windows 7 (206).png")
        Me.ListViewLargeImageList.Images.SetKeyName(4, "Windows 7 (211).png")
        Me.ListViewLargeImageList.Images.SetKeyName(5, "Windows 7 (212).png")
        Me.ListViewLargeImageList.Images.SetKeyName(6, "Windows 7.png")
        '
        'ListViewSmallImageList
        '
        Me.ListViewSmallImageList.ImageStream = CType(resources.GetObject("ListViewSmallImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ListViewSmallImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ListViewSmallImageList.Images.SetKeyName(0, "Windows 7 (2).png")
        Me.ListViewSmallImageList.Images.SetKeyName(1, "Windows 7 (7).png")
        Me.ListViewSmallImageList.Images.SetKeyName(2, "Windows 7 (9).png")
        Me.ListViewSmallImageList.Images.SetKeyName(3, "Windows 7 (206).png")
        Me.ListViewSmallImageList.Images.SetKeyName(4, "Windows 7 (211).png")
        Me.ListViewSmallImageList.Images.SetKeyName(5, "Windows 7 (212).png")
        Me.ListViewSmallImageList.Images.SetKeyName(6, "Windows 7.png")
        '
        'popClassSection
        '
        Me.popClassSection.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewBlockSectionToolStripMenuItem, Me.AddNewFreeSectionToolStripMenuItem, Me.ToolStripSeparator1, Me.RenameClassSectionToolStripMenuItem, Me.DeleteClassSectionToolStripMenuItem, Me.RefreshToolStripMenuItem, Me.ToolStripSeparator2, Me.ClassSectionScheduleToolStripMenuItem, Me.ToolStripSeparator3, Me.DissolveClassSectionToolStripMenuItem, Me.ToolStripSeparator4, Me.PropertiesToolStripMenuItem})
        Me.popClassSection.Name = "popClassSection"
        Me.popClassSection.Size = New System.Drawing.Size(198, 204)
        '
        'AddNewBlockSectionToolStripMenuItem
        '
        Me.AddNewBlockSectionToolStripMenuItem.Image = CType(resources.GetObject("AddNewBlockSectionToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddNewBlockSectionToolStripMenuItem.Name = "AddNewBlockSectionToolStripMenuItem"
        Me.AddNewBlockSectionToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.AddNewBlockSectionToolStripMenuItem.Text = "Add New Block Section"
        '
        'AddNewFreeSectionToolStripMenuItem
        '
        Me.AddNewFreeSectionToolStripMenuItem.Image = CType(resources.GetObject("AddNewFreeSectionToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddNewFreeSectionToolStripMenuItem.Name = "AddNewFreeSectionToolStripMenuItem"
        Me.AddNewFreeSectionToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.AddNewFreeSectionToolStripMenuItem.Text = "Add New Free Section"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(194, 6)
        '
        'RenameClassSectionToolStripMenuItem
        '
        Me.RenameClassSectionToolStripMenuItem.Image = CType(resources.GetObject("RenameClassSectionToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RenameClassSectionToolStripMenuItem.Name = "RenameClassSectionToolStripMenuItem"
        Me.RenameClassSectionToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.RenameClassSectionToolStripMenuItem.Text = "Rename Class Section"
        '
        'DeleteClassSectionToolStripMenuItem
        '
        Me.DeleteClassSectionToolStripMenuItem.Image = CType(resources.GetObject("DeleteClassSectionToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeleteClassSectionToolStripMenuItem.Name = "DeleteClassSectionToolStripMenuItem"
        Me.DeleteClassSectionToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.DeleteClassSectionToolStripMenuItem.Text = "Delete Class Section"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = CType(resources.GetObject("RefreshToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(194, 6)
        '
        'ClassSectionScheduleToolStripMenuItem
        '
        Me.ClassSectionScheduleToolStripMenuItem.Image = CType(resources.GetObject("ClassSectionScheduleToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ClassSectionScheduleToolStripMenuItem.Name = "ClassSectionScheduleToolStripMenuItem"
        Me.ClassSectionScheduleToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.ClassSectionScheduleToolStripMenuItem.Text = "View Class Schedule"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(194, 6)
        '
        'DissolveClassSectionToolStripMenuItem
        '
        Me.DissolveClassSectionToolStripMenuItem.Image = CType(resources.GetObject("DissolveClassSectionToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DissolveClassSectionToolStripMenuItem.Name = "DissolveClassSectionToolStripMenuItem"
        Me.DissolveClassSectionToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.DissolveClassSectionToolStripMenuItem.Text = "Dissolve Class Section"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(194, 6)
        '
        'PropertiesToolStripMenuItem
        '
        Me.PropertiesToolStripMenuItem.Image = CType(resources.GetObject("PropertiesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PropertiesToolStripMenuItem.Name = "PropertiesToolStripMenuItem"
        Me.PropertiesToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.PropertiesToolStripMenuItem.Text = "Properties"
        '
        'popOffering
        '
        Me.popOffering.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewSubjectOfferingToolStripMenuItem, Me.ReplaceSubjectOfferingToolStripMenuItem, Me.DeleteSubjectToolStripMenuItem, Me.ToolStripSeparator5, Me.ModifyClassLimitToolStripMenuItem, Me.ToolStripSeparator6, Me.RefreshToolStripMenuItem2})
        Me.popOffering.Name = "popOffering"
        Me.popOffering.Size = New System.Drawing.Size(213, 126)
        '
        'AddNewSubjectOfferingToolStripMenuItem
        '
        Me.AddNewSubjectOfferingToolStripMenuItem.Image = CType(resources.GetObject("AddNewSubjectOfferingToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddNewSubjectOfferingToolStripMenuItem.Name = "AddNewSubjectOfferingToolStripMenuItem"
        Me.AddNewSubjectOfferingToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.AddNewSubjectOfferingToolStripMenuItem.Text = "Add New Subject Offering"
        '
        'ReplaceSubjectOfferingToolStripMenuItem
        '
        Me.ReplaceSubjectOfferingToolStripMenuItem.Image = CType(resources.GetObject("ReplaceSubjectOfferingToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReplaceSubjectOfferingToolStripMenuItem.Name = "ReplaceSubjectOfferingToolStripMenuItem"
        Me.ReplaceSubjectOfferingToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.ReplaceSubjectOfferingToolStripMenuItem.Text = "Replace Subject Offering"
        '
        'DeleteSubjectToolStripMenuItem
        '
        Me.DeleteSubjectToolStripMenuItem.Image = CType(resources.GetObject("DeleteSubjectToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeleteSubjectToolStripMenuItem.Name = "DeleteSubjectToolStripMenuItem"
        Me.DeleteSubjectToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.DeleteSubjectToolStripMenuItem.Text = "Delete Subject"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(209, 6)
        '
        'ModifyClassLimitToolStripMenuItem
        '
        Me.ModifyClassLimitToolStripMenuItem.Image = CType(resources.GetObject("ModifyClassLimitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ModifyClassLimitToolStripMenuItem.Name = "ModifyClassLimitToolStripMenuItem"
        Me.ModifyClassLimitToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.ModifyClassLimitToolStripMenuItem.Text = "Modify Class Limit"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(209, 6)
        '
        'RefreshToolStripMenuItem2
        '
        Me.RefreshToolStripMenuItem2.Image = CType(resources.GetObject("RefreshToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.RefreshToolStripMenuItem2.Name = "RefreshToolStripMenuItem2"
        Me.RefreshToolStripMenuItem2.Size = New System.Drawing.Size(212, 22)
        Me.RefreshToolStripMenuItem2.Text = "Refresh"
        '
        'frmManageSection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.ToolStripContainer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmManageSection"
        Me.Text = "Class Section Management"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.ToolStripContainer.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer.ResumeLayout(False)
        Me.ToolStripContainer.PerformLayout()
        Me.SplitContainer.Panel1.ResumeLayout(False)
        Me.SplitContainer.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer.ResumeLayout(False)
        Me.popTree.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.popClassSection.ResumeLayout(False)
        Me.popOffering.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents popClassSection As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddNewBlockSectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewFreeSectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteClassSectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ClassSectionScheduleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DissolveClassSectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PropertiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboAY As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents cboAYID As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents popTree As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RefreshToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cboCollege As MTGCComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboCampus As MTGCComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TreeView As System.Windows.Forms.TreeView
    Friend WithEvents cmdPrintSection As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents PrintListOfClassScheduleAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintListOfClassScheduleProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintListOfCourseOfferedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdPrintOffering As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents PrintListOfRegisteredStudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintOfficialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popOffering As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddNewSubjectOfferingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReplaceSubjectOfferingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteSubjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ModifyClassLimitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RenameClassSectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
