<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScholarshipGrantTemplates
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmScholarshipGrantTemplates))
        Me.NavBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
        Me.NavBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.cmdProvider = New DevExpress.XtraNavBar.NavBarItem()
        Me.cmdPrintSchoProvider = New DevExpress.XtraNavBar.NavBarItem()
        Me.cmdAddTemplate = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem2 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarGroupControlContainer1 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.lvTemplate = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.popTemplate = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ModiftTemplateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboTerm = New MTGCComboBox()
        Me.NavBarGroup2 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.TabControl = New DevExpress.XtraTab.XtraTabControl()
        Me.cmdPrintTemplate = New DevExpress.XtraTab.XtraTabPage()
        Me.lvTemplateDetails = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.chkRate = New System.Windows.Forms.RadioButton()
        Me.chkAmount = New System.Windows.Forms.RadioButton()
        Me.txtTemplateCode = New System.Windows.Forms.TextBox()
        Me.txtDetail = New System.Windows.Forms.TextBox()
        Me.cmdPickAccount = New System.Windows.Forms.Button()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DeleteToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdRefresh = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.HelpToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavBarControl1.SuspendLayout()
        Me.NavBarGroupControlContainer1.SuspendLayout()
        Me.popTemplate.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.TabControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl.SuspendLayout()
        Me.cmdPrintTemplate.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NavBarControl1
        '
        Me.NavBarControl1.ActiveGroup = Me.NavBarGroup1
        Me.NavBarControl1.Controls.Add(Me.NavBarGroupControlContainer1)
        Me.NavBarControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.NavBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.NavBarGroup1, Me.NavBarGroup2})
        Me.NavBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.cmdAddTemplate, Me.NavBarItem2, Me.cmdProvider, Me.cmdPrintSchoProvider})
        Me.NavBarControl1.Location = New System.Drawing.Point(0, 0)
        Me.NavBarControl1.LookAndFeel.SkinName = "VS2010"
        Me.NavBarControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.NavBarControl1.Name = "NavBarControl1"
        Me.NavBarControl1.OptionsNavPane.ExpandedWidth = 328
        Me.NavBarControl1.Size = New System.Drawing.Size(328, 730)
        Me.NavBarControl1.TabIndex = 2
        Me.NavBarControl1.Text = "NavBarControl1"
        '
        'NavBarGroup1
        '
        Me.NavBarGroup1.Caption = "Quick Launch"
        Me.NavBarGroup1.Expanded = True
        Me.NavBarGroup1.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.cmdProvider), New DevExpress.XtraNavBar.NavBarItemLink(Me.cmdPrintSchoProvider), New DevExpress.XtraNavBar.NavBarItemLink(Me.cmdAddTemplate), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem2)})
        Me.NavBarGroup1.Name = "NavBarGroup1"
        '
        'cmdProvider
        '
        Me.cmdProvider.Caption = "New Scholarship Provider"
        Me.cmdProvider.Name = "cmdProvider"
        Me.cmdProvider.SmallImage = CType(resources.GetObject("cmdProvider.SmallImage"), System.Drawing.Image)
        '
        'cmdPrintSchoProvider
        '
        Me.cmdPrintSchoProvider.Caption = "Print Scholarship Provider"
        Me.cmdPrintSchoProvider.Name = "cmdPrintSchoProvider"
        Me.cmdPrintSchoProvider.SmallImage = CType(resources.GetObject("cmdPrintSchoProvider.SmallImage"), System.Drawing.Image)
        '
        'cmdAddTemplate
        '
        Me.cmdAddTemplate.Caption = "New Scholarship Template"
        Me.cmdAddTemplate.Name = "cmdAddTemplate"
        Me.cmdAddTemplate.SmallImage = CType(resources.GetObject("cmdAddTemplate.SmallImage"), System.Drawing.Image)
        '
        'NavBarItem2
        '
        Me.NavBarItem2.Caption = "Print Template"
        Me.NavBarItem2.Name = "NavBarItem2"
        Me.NavBarItem2.SmallImage = CType(resources.GetObject("NavBarItem2.SmallImage"), System.Drawing.Image)
        '
        'NavBarGroupControlContainer1
        '
        Me.NavBarGroupControlContainer1.Controls.Add(Me.lvTemplate)
        Me.NavBarGroupControlContainer1.Controls.Add(Me.GroupControl1)
        Me.NavBarGroupControlContainer1.Name = "NavBarGroupControlContainer1"
        Me.NavBarGroupControlContainer1.Size = New System.Drawing.Size(320, 376)
        Me.NavBarGroupControlContainer1.TabIndex = 0
        '
        'lvTemplate
        '
        Me.lvTemplate.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader10})
        Me.lvTemplate.ContextMenuStrip = Me.popTemplate
        Me.lvTemplate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvTemplate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvTemplate.FullRowSelect = True
        Me.lvTemplate.GridLines = True
        Me.lvTemplate.Location = New System.Drawing.Point(0, 84)
        Me.lvTemplate.Name = "lvTemplate"
        Me.lvTemplate.Size = New System.Drawing.Size(320, 292)
        Me.lvTemplate.TabIndex = 3
        Me.lvTemplate.UseCompatibleStateImageBehavior = False
        Me.lvTemplate.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Template Code"
        Me.ColumnHeader1.Width = 102
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Provider"
        Me.ColumnHeader2.Width = 172
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Description"
        Me.ColumnHeader3.Width = 130
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "ID"
        Me.ColumnHeader10.Width = 0
        '
        'popTemplate
        '
        Me.popTemplate.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModiftTemplateToolStripMenuItem, Me.ToolStripSeparator2, Me.RefreshToolStripMenuItem})
        Me.popTemplate.Name = "popTemplate"
        Me.popTemplate.Size = New System.Drawing.Size(175, 76)
        '
        'ModiftTemplateToolStripMenuItem
        '
        Me.ModiftTemplateToolStripMenuItem.Image = CType(resources.GetObject("ModiftTemplateToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ModiftTemplateToolStripMenuItem.Name = "ModiftTemplateToolStripMenuItem"
        Me.ModiftTemplateToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ModiftTemplateToolStripMenuItem.Text = "Modify Template..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(171, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = CType(resources.GetObject("RefreshToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupControl1.Appearance.Options.UseBackColor = True
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.cboTerm)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(320, 84)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "Enrollment Period"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select Academic Year && Terms..."
        '
        'cboTerm
        '
        Me.cboTerm.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cboTerm.ArrowColor = System.Drawing.Color.Black
        Me.cboTerm.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboTerm.BindedControl = CType(resources.GetObject("cboTerm.BindedControl"), MTGCComboBox.ControlloAssociato)
        Me.cboTerm.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D
        Me.cboTerm.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboTerm.ColumnNum = 2
        Me.cboTerm.ColumnWidth = "280;0"
        Me.cboTerm.DisabledArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cboTerm.DisabledArrowColor = System.Drawing.Color.LightGray
        Me.cboTerm.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.cboTerm.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder
        Me.cboTerm.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.cboTerm.DisplayMember = "Text"
        Me.cboTerm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboTerm.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cboTerm.DropDownForeColor = System.Drawing.Color.Black
        Me.cboTerm.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.cboTerm.DropDownWidth = 300
        Me.cboTerm.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTerm.GridLineColor = System.Drawing.Color.LightGray
        Me.cboTerm.GridLineHorizontal = True
        Me.cboTerm.GridLineVertical = True
        Me.cboTerm.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.cboTerm.Location = New System.Drawing.Point(7, 47)
        Me.cboTerm.ManagingFastMouseMoving = True
        Me.cboTerm.ManagingFastMouseMovingInterval = 30
        Me.cboTerm.Name = "cboTerm"
        Me.cboTerm.SelectedItem = Nothing
        Me.cboTerm.SelectedValue = Nothing
        Me.cboTerm.Size = New System.Drawing.Size(304, 23)
        Me.cboTerm.TabIndex = 0
        '
        'NavBarGroup2
        '
        Me.NavBarGroup2.Caption = "Template List"
        Me.NavBarGroup2.ControlContainer = Me.NavBarGroupControlContainer1
        Me.NavBarGroup2.Expanded = True
        Me.NavBarGroup2.GroupClientHeight = 383
        Me.NavBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.NavBarGroup2.Name = "NavBarGroup2"
        '
        'TabControl
        '
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Enabled = False
        Me.TabControl.Location = New System.Drawing.Point(328, 0)
        Me.TabControl.LookAndFeel.SkinName = "VS2010"
        Me.TabControl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedTabPage = Me.cmdPrintTemplate
        Me.TabControl.Size = New System.Drawing.Size(680, 730)
        Me.TabControl.TabIndex = 3
        Me.TabControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.cmdPrintTemplate})
        '
        'cmdPrintTemplate
        '
        Me.cmdPrintTemplate.Controls.Add(Me.lvTemplateDetails)
        Me.cmdPrintTemplate.Controls.Add(Me.GroupControl2)
        Me.cmdPrintTemplate.Controls.Add(Me.ToolStrip1)
        Me.cmdPrintTemplate.Image = CType(resources.GetObject("cmdPrintTemplate.Image"), System.Drawing.Image)
        Me.cmdPrintTemplate.Name = "cmdPrintTemplate"
        Me.cmdPrintTemplate.Size = New System.Drawing.Size(678, 686)
        Me.cmdPrintTemplate.Text = "Scholarship Grant Templates"
        '
        'lvTemplateDetails
        '
        Me.lvTemplateDetails.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader11, Me.ColumnHeader12})
        Me.lvTemplateDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvTemplateDetails.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvTemplateDetails.FullRowSelect = True
        Me.lvTemplateDetails.GridLines = True
        Me.lvTemplateDetails.Location = New System.Drawing.Point(0, 141)
        Me.lvTemplateDetails.Name = "lvTemplateDetails"
        Me.lvTemplateDetails.Size = New System.Drawing.Size(678, 545)
        Me.lvTemplateDetails.TabIndex = 2
        Me.lvTemplateDetails.UseCompatibleStateImageBehavior = False
        Me.lvTemplateDetails.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Account Code"
        Me.ColumnHeader4.Width = 118
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Account Name"
        Me.ColumnHeader5.Width = 242
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Amount"
        Me.ColumnHeader6.Width = 106
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Percent(%)"
        Me.ColumnHeader7.Width = 85
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Remarks"
        Me.ColumnHeader8.Width = 239
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Fund/Group"
        Me.ColumnHeader9.Width = 161
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "DetailID"
        Me.ColumnHeader11.Width = 0
        '
        'GroupControl2
        '
        Me.GroupControl2.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupControl2.Appearance.Options.UseBackColor = True
        Me.GroupControl2.Controls.Add(Me.chkRate)
        Me.GroupControl2.Controls.Add(Me.chkAmount)
        Me.GroupControl2.Controls.Add(Me.txtTemplateCode)
        Me.GroupControl2.Controls.Add(Me.txtDetail)
        Me.GroupControl2.Controls.Add(Me.cmdPickAccount)
        Me.GroupControl2.Controls.Add(Me.txtRemarks)
        Me.GroupControl2.Controls.Add(Me.Label5)
        Me.GroupControl2.Controls.Add(Me.txtRate)
        Me.GroupControl2.Controls.Add(Me.txtAmount)
        Me.GroupControl2.Controls.Add(Me.txtCode)
        Me.GroupControl2.Controls.Add(Me.Label2)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl2.Location = New System.Drawing.Point(0, 25)
        Me.GroupControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.GroupControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(678, 116)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Template "
        '
        'chkRate
        '
        Me.chkRate.AutoSize = True
        Me.chkRate.Location = New System.Drawing.Point(26, 75)
        Me.chkRate.Name = "chkRate"
        Me.chkRate.Size = New System.Drawing.Size(51, 17)
        Me.chkRate.TabIndex = 14
        Me.chkRate.Text = "Rate:"
        Me.chkRate.UseVisualStyleBackColor = True
        '
        'chkAmount
        '
        Me.chkAmount.AutoSize = True
        Me.chkAmount.Checked = True
        Me.chkAmount.Location = New System.Drawing.Point(26, 49)
        Me.chkAmount.Name = "chkAmount"
        Me.chkAmount.Size = New System.Drawing.Size(64, 17)
        Me.chkAmount.TabIndex = 13
        Me.chkAmount.TabStop = True
        Me.chkAmount.Text = "Amount:"
        Me.chkAmount.UseVisualStyleBackColor = True
        '
        'txtTemplateCode
        '
        Me.txtTemplateCode.Location = New System.Drawing.Point(254, 75)
        Me.txtTemplateCode.Name = "txtTemplateCode"
        Me.txtTemplateCode.Size = New System.Drawing.Size(28, 20)
        Me.txtTemplateCode.TabIndex = 10
        Me.txtTemplateCode.Visible = False
        '
        'txtDetail
        '
        Me.txtDetail.BackColor = System.Drawing.Color.LightGray
        Me.txtDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDetail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDetail.Enabled = False
        Me.txtDetail.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetail.Location = New System.Drawing.Point(265, 23)
        Me.txtDetail.Name = "txtDetail"
        Me.txtDetail.ReadOnly = True
        Me.txtDetail.Size = New System.Drawing.Size(389, 22)
        Me.txtDetail.TabIndex = 9
        '
        'cmdPickAccount
        '
        Me.cmdPickAccount.Image = CType(resources.GetObject("cmdPickAccount.Image"), System.Drawing.Image)
        Me.cmdPickAccount.Location = New System.Drawing.Point(234, 23)
        Me.cmdPickAccount.Name = "cmdPickAccount"
        Me.cmdPickAccount.Size = New System.Drawing.Size(25, 23)
        Me.cmdPickAccount.TabIndex = 8
        Me.cmdPickAccount.UseVisualStyleBackColor = True
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(320, 50)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(334, 59)
        Me.txtRemarks.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(262, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Remarks:"
        '
        'txtRate
        '
        Me.txtRate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRate.Location = New System.Drawing.Point(104, 74)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(131, 20)
        Me.txtRate.TabIndex = 5
        Me.txtRate.Text = "0"
        '
        'txtAmount
        '
        Me.txtAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(104, 48)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(131, 20)
        Me.txtAmount.TabIndex = 3
        Me.txtAmount.Text = "0.00"
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(104, 24)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(131, 20)
        Me.txtCode.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(23, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Account Code:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.SaveToolStripButton, Me.DeleteToolStripButton, Me.ToolStripSeparator1, Me.cmdRefresh, Me.toolStripSeparator, Me.HelpToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(678, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(51, 22)
        Me.NewToolStripButton.Text = "&New"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(51, 22)
        Me.SaveToolStripButton.Text = "&Save"
        '
        'DeleteToolStripButton
        '
        Me.DeleteToolStripButton.Image = CType(resources.GetObject("DeleteToolStripButton.Image"), System.Drawing.Image)
        Me.DeleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeleteToolStripButton.Name = "DeleteToolStripButton"
        Me.DeleteToolStripButton.Size = New System.Drawing.Size(60, 22)
        Me.DeleteToolStripButton.Text = "&Delete"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Image = CType(resources.GetObject("cmdRefresh.Image"), System.Drawing.Image)
        Me.cmdRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(66, 22)
        Me.cmdRefresh.Text = "Refresh"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'HelpToolStripButton
        '
        Me.HelpToolStripButton.Image = CType(resources.GetObject("HelpToolStripButton.Image"), System.Drawing.Image)
        Me.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HelpToolStripButton.Name = "HelpToolStripButton"
        Me.HelpToolStripButton.Size = New System.Drawing.Size(52, 22)
        Me.HelpToolStripButton.Text = "He&lp"
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "AcctID"
        '
        'frmScholarshipGrantTemplates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.NavBarControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmScholarshipGrantTemplates"
        Me.Text = "Scholarship Providers/Grant Templates"
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavBarControl1.ResumeLayout(False)
        Me.NavBarGroupControlContainer1.ResumeLayout(False)
        Me.popTemplate.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.TabControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl.ResumeLayout(False)
        Me.cmdPrintTemplate.ResumeLayout(False)
        Me.cmdPrintTemplate.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NavBarControl1 As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents NavBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarGroupControlContainer1 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents lvTemplate As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboTerm As MTGCComboBox
    Friend WithEvents NavBarGroup2 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents TabControl As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents cmdPrintTemplate As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents cmdAddTemplate As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem2 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents lvTemplateDetails As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents DeleteToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HelpToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtDetail As System.Windows.Forms.TextBox
    Friend WithEvents cmdPickAccount As System.Windows.Forms.Button
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtTemplateCode As System.Windows.Forms.TextBox
    Friend WithEvents cmdProvider As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdPrintSchoProvider As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents popTemplate As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ModiftTemplateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmdRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents chkRate As System.Windows.Forms.RadioButton
    Friend WithEvents chkAmount As System.Windows.Forms.RadioButton
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
End Class
