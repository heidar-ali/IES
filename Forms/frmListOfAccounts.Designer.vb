<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListOfAccounts
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListOfAccounts))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.dgAccounts = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewAccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.PropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DeleteToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.RefreshToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.CopyToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.HelpToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.NavBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
        Me.NavBarGroup2 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.cmdSubsidiary = New DevExpress.XtraNavBar.NavBarItem()
        Me.cmdAcctGL = New DevExpress.XtraNavBar.NavBarItem()
        Me.cmdFund = New DevExpress.XtraNavBar.NavBarItem()
        Me.cmdSubFund = New DevExpress.XtraNavBar.NavBarItem()
        Me.cmdSubUnit = New DevExpress.XtraNavBar.NavBarItem()
        Me.cmdAcctDept = New DevExpress.XtraNavBar.NavBarItem()
        Me.cmdAcctClass = New DevExpress.XtraNavBar.NavBarItem()
        Me.cmdAcctType = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarGroupControlContainer1 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.chkFund = New System.Windows.Forms.RadioButton()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.LookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkAccount = New System.Windows.Forms.RadioButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtFind = New DevExpress.XtraEditors.ButtonEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NavBarGroup4 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.cmdPaymentOption = New DevExpress.XtraNavBar.NavBarItem()
        Me.DsAccounting1 = New Academic_Manager.dsAccounting()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.dgAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavBarControl1.SuspendLayout()
        Me.NavBarGroupControlContainer1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtFind.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAccounting1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 708)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1362, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabControl1.Appearance.Options.UseFont = True
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.LookAndFeel.SkinName = "VS2010"
        Me.XtraTabControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1362, 708)
        Me.XtraTabControl1.TabIndex = 1
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.dgAccounts)
        Me.XtraTabPage1.Controls.Add(Me.ToolStrip1)
        Me.XtraTabPage1.Controls.Add(Me.NavBarControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1360, 675)
        Me.XtraTabPage1.Text = "List of Accounts"
        '
        'dgAccounts
        '
        Me.dgAccounts.AllowUserToAddRows = False
        Me.dgAccounts.AllowUserToDeleteRows = False
        Me.dgAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgAccounts.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgAccounts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAccounts.ContextMenuStrip = Me.ContextMenuStrip1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgAccounts.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgAccounts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgAccounts.EnableHeadersVisualStyles = False
        Me.dgAccounts.GridColor = System.Drawing.Color.DeepSkyBlue
        Me.dgAccounts.Location = New System.Drawing.Point(291, 25)
        Me.dgAccounts.Name = "dgAccounts"
        Me.dgAccounts.ReadOnly = True
        Me.dgAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgAccounts.Size = New System.Drawing.Size(1069, 650)
        Me.dgAccounts.TabIndex = 2
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewAccountsToolStripMenuItem, Me.EditAccountToolStripMenuItem, Me.ToolStripSeparator1, Me.DeleteToolStripMenuItem, Me.ToolStripSeparator2, Me.RefreshToolStripMenuItem, Me.ToolStripSeparator3, Me.PropertiesToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(147, 132)
        '
        'NewAccountsToolStripMenuItem
        '
        Me.NewAccountsToolStripMenuItem.Image = CType(resources.GetObject("NewAccountsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewAccountsToolStripMenuItem.Name = "NewAccountsToolStripMenuItem"
        Me.NewAccountsToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.NewAccountsToolStripMenuItem.Text = "New Account"
        '
        'EditAccountToolStripMenuItem
        '
        Me.EditAccountToolStripMenuItem.Image = CType(resources.GetObject("EditAccountToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EditAccountToolStripMenuItem.Name = "EditAccountToolStripMenuItem"
        Me.EditAccountToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.EditAccountToolStripMenuItem.Text = "Edit Account"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(143, 6)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Image = CType(resources.GetObject("DeleteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(143, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = CType(resources.GetObject("RefreshToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(143, 6)
        '
        'PropertiesToolStripMenuItem
        '
        Me.PropertiesToolStripMenuItem.Image = CType(resources.GetObject("PropertiesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PropertiesToolStripMenuItem.Name = "PropertiesToolStripMenuItem"
        Me.PropertiesToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.PropertiesToolStripMenuItem.Text = "Properties"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.DeleteToolStripButton, Me.RefreshToolStripButton, Me.PrintToolStripButton, Me.toolStripSeparator, Me.CopyToolStripButton, Me.toolStripSeparator4, Me.HelpToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(291, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1069, 25)
        Me.ToolStrip1.TabIndex = 1
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
        'DeleteToolStripButton
        '
        Me.DeleteToolStripButton.Image = CType(resources.GetObject("DeleteToolStripButton.Image"), System.Drawing.Image)
        Me.DeleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeleteToolStripButton.Name = "DeleteToolStripButton"
        Me.DeleteToolStripButton.Size = New System.Drawing.Size(60, 22)
        Me.DeleteToolStripButton.Text = "&Delete"
        '
        'RefreshToolStripButton
        '
        Me.RefreshToolStripButton.Image = CType(resources.GetObject("RefreshToolStripButton.Image"), System.Drawing.Image)
        Me.RefreshToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RefreshToolStripButton.Name = "RefreshToolStripButton"
        Me.RefreshToolStripButton.Size = New System.Drawing.Size(66, 22)
        Me.RefreshToolStripButton.Text = "&Refresh"
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), System.Drawing.Image)
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(52, 22)
        Me.PrintToolStripButton.Text = "&Print"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'CopyToolStripButton
        '
        Me.CopyToolStripButton.Image = CType(resources.GetObject("CopyToolStripButton.Image"), System.Drawing.Image)
        Me.CopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripButton.Name = "CopyToolStripButton"
        Me.CopyToolStripButton.Size = New System.Drawing.Size(128, 22)
        Me.CopyToolStripButton.Text = "&Account Properties"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'HelpToolStripButton
        '
        Me.HelpToolStripButton.Image = CType(resources.GetObject("HelpToolStripButton.Image"), System.Drawing.Image)
        Me.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HelpToolStripButton.Name = "HelpToolStripButton"
        Me.HelpToolStripButton.Size = New System.Drawing.Size(52, 22)
        Me.HelpToolStripButton.Text = "He&lp"
        '
        'NavBarControl1
        '
        Me.NavBarControl1.ActiveGroup = Me.NavBarGroup2
        Me.NavBarControl1.Controls.Add(Me.NavBarGroupControlContainer1)
        Me.NavBarControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.NavBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.NavBarGroup2, Me.NavBarGroup4})
        Me.NavBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.cmdSubsidiary, Me.cmdFund, Me.cmdSubFund, Me.cmdSubUnit, Me.cmdAcctDept, Me.cmdAcctClass, Me.cmdAcctType, Me.cmdPaymentOption, Me.cmdAcctGL})
        Me.NavBarControl1.Location = New System.Drawing.Point(0, 0)
        Me.NavBarControl1.LookAndFeel.SkinName = "VS2010"
        Me.NavBarControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.NavBarControl1.Name = "NavBarControl1"
        Me.NavBarControl1.OptionsNavPane.ExpandedWidth = 291
        Me.NavBarControl1.Size = New System.Drawing.Size(291, 675)
        Me.NavBarControl1.TabIndex = 0
        Me.NavBarControl1.Text = "NavBarControl1"
        '
        'NavBarGroup2
        '
        Me.NavBarGroup2.Caption = "Miscellaneous"
        Me.NavBarGroup2.Expanded = True
        Me.NavBarGroup2.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.cmdSubsidiary), New DevExpress.XtraNavBar.NavBarItemLink(Me.cmdAcctGL), New DevExpress.XtraNavBar.NavBarItemLink(Me.cmdFund), New DevExpress.XtraNavBar.NavBarItemLink(Me.cmdSubFund), New DevExpress.XtraNavBar.NavBarItemLink(Me.cmdSubUnit), New DevExpress.XtraNavBar.NavBarItemLink(Me.cmdAcctDept), New DevExpress.XtraNavBar.NavBarItemLink(Me.cmdAcctClass), New DevExpress.XtraNavBar.NavBarItemLink(Me.cmdAcctType)})
        Me.NavBarGroup2.Name = "NavBarGroup2"
        '
        'cmdSubsidiary
        '
        Me.cmdSubsidiary.Caption = "Subsidiary  Code"
        Me.cmdSubsidiary.Name = "cmdSubsidiary"
        Me.cmdSubsidiary.SmallImage = CType(resources.GetObject("cmdSubsidiary.SmallImage"), System.Drawing.Image)
        '
        'cmdAcctGL
        '
        Me.cmdAcctGL.Caption = "Account GL Groups"
        Me.cmdAcctGL.Name = "cmdAcctGL"
        Me.cmdAcctGL.SmallImage = CType(resources.GetObject("cmdAcctGL.SmallImage"), System.Drawing.Image)
        '
        'cmdFund
        '
        Me.cmdFund.Caption = "Account Fund/Groups"
        Me.cmdFund.Hint = "Account Fund/Groups"
        Me.cmdFund.Name = "cmdFund"
        Me.cmdFund.SmallImage = CType(resources.GetObject("cmdFund.SmallImage"), System.Drawing.Image)
        '
        'cmdSubFund
        '
        Me.cmdSubFund.Caption = "Account Sub Fund/Groups"
        Me.cmdSubFund.Name = "cmdSubFund"
        Me.cmdSubFund.SmallImage = CType(resources.GetObject("cmdSubFund.SmallImage"), System.Drawing.Image)
        '
        'cmdSubUnit
        '
        Me.cmdSubUnit.Caption = "Account Sub Unit"
        Me.cmdSubUnit.Name = "cmdSubUnit"
        Me.cmdSubUnit.SmallImage = CType(resources.GetObject("cmdSubUnit.SmallImage"), System.Drawing.Image)
        '
        'cmdAcctDept
        '
        Me.cmdAcctDept.Caption = "Account Department"
        Me.cmdAcctDept.Name = "cmdAcctDept"
        Me.cmdAcctDept.SmallImage = CType(resources.GetObject("cmdAcctDept.SmallImage"), System.Drawing.Image)
        '
        'cmdAcctClass
        '
        Me.cmdAcctClass.Caption = "Account Classification"
        Me.cmdAcctClass.Name = "cmdAcctClass"
        Me.cmdAcctClass.SmallImage = CType(resources.GetObject("cmdAcctClass.SmallImage"), System.Drawing.Image)
        '
        'cmdAcctType
        '
        Me.cmdAcctType.Caption = "Account Type"
        Me.cmdAcctType.Name = "cmdAcctType"
        Me.cmdAcctType.SmallImage = CType(resources.GetObject("cmdAcctType.SmallImage"), System.Drawing.Image)
        '
        'NavBarGroupControlContainer1
        '
        Me.NavBarGroupControlContainer1.Controls.Add(Me.chkFund)
        Me.NavBarGroupControlContainer1.Controls.Add(Me.GroupControl2)
        Me.NavBarGroupControlContainer1.Controls.Add(Me.chkAccount)
        Me.NavBarGroupControlContainer1.Controls.Add(Me.GroupControl1)
        Me.NavBarGroupControlContainer1.Name = "NavBarGroupControlContainer1"
        Me.NavBarGroupControlContainer1.Size = New System.Drawing.Size(283, 216)
        Me.NavBarGroupControlContainer1.TabIndex = 0
        '
        'chkFund
        '
        Me.chkFund.AutoSize = True
        Me.chkFund.BackColor = System.Drawing.Color.Transparent
        Me.chkFund.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFund.ForeColor = System.Drawing.Color.White
        Me.chkFund.Location = New System.Drawing.Point(3, 113)
        Me.chkFund.Name = "chkFund"
        Me.chkFund.Size = New System.Drawing.Size(102, 18)
        Me.chkFund.TabIndex = 5
        Me.chkFund.Text = "Filter By FUND"
        Me.chkFund.UseVisualStyleBackColor = False
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.LookUpEdit1)
        Me.GroupControl2.Controls.Add(Me.Label2)
        Me.GroupControl2.Enabled = False
        Me.GroupControl2.Location = New System.Drawing.Point(0, 133)
        Me.GroupControl2.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(283, 81)
        Me.GroupControl2.TabIndex = 4
        Me.GroupControl2.Text = "Filter By Fund"
        '
        'LookUpEdit1
        '
        Me.LookUpEdit1.Location = New System.Drawing.Point(8, 43)
        Me.LookUpEdit1.Name = "LookUpEdit1"
        Me.LookUpEdit1.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.LookUpEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LookUpEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LookUpEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.LookUpEdit1.Properties.Appearance.Options.UseFont = True
        Me.LookUpEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.LookUpEdit1.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.Black
        Me.LookUpEdit1.Properties.AppearanceDropDown.Options.UseForeColor = True
        Me.LookUpEdit1.Properties.AppearanceDropDownHeader.ForeColor = System.Drawing.Color.Black
        Me.LookUpEdit1.Properties.AppearanceDropDownHeader.Options.UseForeColor = True
        Me.LookUpEdit1.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.LookUpEdit1.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.LookUpEdit1.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.LookUpEdit1.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.LookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit1.Properties.DropDownRows = 5
        Me.LookUpEdit1.Properties.LookAndFeel.SkinName = "VS2010"
        Me.LookUpEdit1.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LookUpEdit1.Size = New System.Drawing.Size(269, 20)
        Me.LookUpEdit1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(5, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "&Search:"
        '
        'chkAccount
        '
        Me.chkAccount.AutoSize = True
        Me.chkAccount.BackColor = System.Drawing.Color.Transparent
        Me.chkAccount.Checked = True
        Me.chkAccount.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAccount.ForeColor = System.Drawing.Color.White
        Me.chkAccount.Location = New System.Drawing.Point(3, 6)
        Me.chkAccount.Name = "chkAccount"
        Me.chkAccount.Size = New System.Drawing.Size(127, 18)
        Me.chkAccount.TabIndex = 3
        Me.chkAccount.TabStop = True
        Me.chkAccount.Text = "Filter By ACCOUNT"
        Me.chkAccount.UseVisualStyleBackColor = False
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtFind)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Location = New System.Drawing.Point(0, 25)
        Me.GroupControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(285, 81)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "Filter By Account"
        '
        'txtFind
        '
        Me.txtFind.Location = New System.Drawing.Point(4, 42)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("txtFind.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, False)})
        Me.txtFind.Properties.LookAndFeel.SkinName = "VS2010"
        Me.txtFind.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtFind.Size = New System.Drawing.Size(274, 20)
        Me.txtFind.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(5, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Search:"
        '
        'NavBarGroup4
        '
        Me.NavBarGroup4.Caption = "Filter"
        Me.NavBarGroup4.ControlContainer = Me.NavBarGroupControlContainer1
        Me.NavBarGroup4.Expanded = True
        Me.NavBarGroup4.GroupClientHeight = 223
        Me.NavBarGroup4.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.NavBarGroup4.Name = "NavBarGroup4"
        '
        'cmdPaymentOption
        '
        Me.cmdPaymentOption.Caption = "Payment Options"
        Me.cmdPaymentOption.Name = "cmdPaymentOption"
        Me.cmdPaymentOption.SmallImage = CType(resources.GetObject("cmdPaymentOption.SmallImage"), System.Drawing.Image)
        '
        'DsAccounting1
        '
        Me.DsAccounting1.DataSetName = "dsAccounting"
        Me.DsAccounting1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmListOfAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 730)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmListOfAccounts"
        Me.Text = "List of Account"
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.dgAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavBarControl1.ResumeLayout(False)
        Me.NavBarGroupControlContainer1.ResumeLayout(False)
        Me.NavBarGroupControlContainer1.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtFind.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAccounting1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents NavBarControl1 As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents cmdSubsidiary As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewAccountsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PropertiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NavBarGroup2 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents cmdFund As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents cmdSubFund As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents cmdSubUnit As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents cmdAcctDept As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents cmdAcctClass As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents cmdAcctType As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents cmdPaymentOption As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents cmdAcctGL As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarGroupControlContainer1 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents NavBarGroup4 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents dgAccounts As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PrintToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CopyToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HelpToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtFind As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkFund As System.Windows.Forms.RadioButton
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkAccount As System.Windows.Forms.RadioButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents DsAccounting1 As dsAccounting
    Friend WithEvents LookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents DeleteToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents RefreshToolStripButton As System.Windows.Forms.ToolStripButton

End Class
