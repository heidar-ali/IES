<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBillingSummary
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
    	Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBillingSummary))
    	Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
    	Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
    	Me.txtSY = New System.Windows.Forms.ToolStripTextBox()
    	Me.cmdBrowseSchoolYear = New System.Windows.Forms.ToolStripButton()
    	Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
    	Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton()
    	Me.TabControl1 = New System.Windows.Forms.TabControl()
    	Me.TabPage1 = New System.Windows.Forms.TabPage()
    	Me.lvBillable = New System.Windows.Forms.ListView()
    	Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
    	Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
    	Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader()
    	Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader()
    	Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader()
    	Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
    	Me.AssessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.LockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
    	Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.StatusStrip3 = New System.Windows.Forms.StatusStrip()
    	Me.TabPage2 = New System.Windows.Forms.TabPage()
    	Me.lvCollectibles = New System.Windows.Forms.ListView()
    	Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader()
    	Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader()
    	Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader()
    	Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader()
    	Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader()
    	Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader()
    	Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader()
    	Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
    	Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
    	Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
    	Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
    	Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
    	Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
    	Me.TabPage3 = New System.Windows.Forms.TabPage()
    	Me.lvBalance = New System.Windows.Forms.ListView()
    	Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader()
    	Me.ColumnHeader14 = New System.Windows.Forms.ColumnHeader()
    	Me.ColumnHeader15 = New System.Windows.Forms.ColumnHeader()
    	Me.ColumnHeader16 = New System.Windows.Forms.ColumnHeader()
    	Me.ColumnHeader17 = New System.Windows.Forms.ColumnHeader()
    	Me.ColumnHeader18 = New System.Windows.Forms.ColumnHeader()
    	Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
    	Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
    	Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
    	Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
    	Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
    	Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
    	Me.ToolStrip1.SuspendLayout
    	Me.TabControl1.SuspendLayout
    	Me.TabPage1.SuspendLayout
    	Me.ContextMenuStrip1.SuspendLayout
    	Me.TabPage2.SuspendLayout
    	Me.ContextMenuStrip2.SuspendLayout
    	Me.TabPage3.SuspendLayout
    	Me.ContextMenuStrip3.SuspendLayout
    	Me.SuspendLayout
    	'
    	'ToolStrip1
    	'
    	Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.txtSY, Me.cmdBrowseSchoolYear, Me.ToolStripSeparator1, Me.PrintToolStripButton})
    	Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
    	Me.ToolStrip1.Name = "ToolStrip1"
    	Me.ToolStrip1.Size = New System.Drawing.Size(888, 39)
    	Me.ToolStrip1.TabIndex = 0
    	Me.ToolStrip1.Text = "ToolStrip1"
    	'
    	'ToolStripLabel1
    	'
    	Me.ToolStripLabel1.Name = "ToolStripLabel1"
    	Me.ToolStripLabel1.Size = New System.Drawing.Size(69, 36)
    	Me.ToolStripLabel1.Text = "School Year"
    	'
    	'txtSY
    	'
    	Me.txtSY.BackColor = System.Drawing.SystemColors.Info
    	Me.txtSY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    	Me.txtSY.Name = "txtSY"
    	Me.txtSY.ReadOnly = true
    	Me.txtSY.Size = New System.Drawing.Size(100, 39)
    	'
    	'cmdBrowseSchoolYear
    	'
    	Me.cmdBrowseSchoolYear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    	Me.cmdBrowseSchoolYear.Image = CType(resources.GetObject("cmdBrowseSchoolYear.Image"),System.Drawing.Image)
    	Me.cmdBrowseSchoolYear.ImageTransparentColor = System.Drawing.Color.Magenta
    	Me.cmdBrowseSchoolYear.Name = "cmdBrowseSchoolYear"
    	Me.cmdBrowseSchoolYear.Size = New System.Drawing.Size(23, 36)
    	Me.cmdBrowseSchoolYear.Text = "Pick School Year"
    	'
    	'ToolStripSeparator1
    	'
    	Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    	Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
    	'
    	'PrintToolStripButton
    	'
    	Me.PrintToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    	Me.PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"),System.Drawing.Image)
    	Me.PrintToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
    	Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
    	Me.PrintToolStripButton.Name = "PrintToolStripButton"
    	Me.PrintToolStripButton.Size = New System.Drawing.Size(36, 36)
    	Me.PrintToolStripButton.Text = "&Print"
    	'
    	'TabControl1
    	'
    	Me.TabControl1.Controls.Add(Me.TabPage1)
    	Me.TabControl1.Controls.Add(Me.TabPage2)
    	Me.TabControl1.Controls.Add(Me.TabPage3)
    	Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
    	Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.TabControl1.Location = New System.Drawing.Point(0, 39)
    	Me.TabControl1.Name = "TabControl1"
    	Me.TabControl1.SelectedIndex = 0
    	Me.TabControl1.Size = New System.Drawing.Size(888, 437)
    	Me.TabControl1.TabIndex = 1
    	'
    	'TabPage1
    	'
    	Me.TabPage1.Controls.Add(Me.lvBillable)
    	Me.TabPage1.Controls.Add(Me.StatusStrip3)
    	Me.TabPage1.Location = New System.Drawing.Point(4, 23)
    	Me.TabPage1.Name = "TabPage1"
    	Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
    	Me.TabPage1.Size = New System.Drawing.Size(880, 410)
    	Me.TabPage1.TabIndex = 0
    	Me.TabPage1.Text = "Billable Accounts"
    	Me.TabPage1.UseVisualStyleBackColor = true
    	'
    	'lvBillable
    	'
    	Me.lvBillable.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
    	Me.lvBillable.ContextMenuStrip = Me.ContextMenuStrip1
    	Me.lvBillable.Dock = System.Windows.Forms.DockStyle.Fill
    	Me.lvBillable.FullRowSelect = true
    	Me.lvBillable.Location = New System.Drawing.Point(3, 3)
    	Me.lvBillable.Name = "lvBillable"
    	Me.lvBillable.Size = New System.Drawing.Size(874, 382)
    	Me.lvBillable.TabIndex = 2
    	Me.lvBillable.UseCompatibleStateImageBehavior = false
    	Me.lvBillable.View = System.Windows.Forms.View.Details
    	'
    	'ColumnHeader1
    	'
    	Me.ColumnHeader1.Text = "Student Name"
    	Me.ColumnHeader1.Width = 281
    	'
    	'ColumnHeader2
    	'
    	Me.ColumnHeader2.Text = "ID Number"
    	Me.ColumnHeader2.Width = 128
    	'
    	'ColumnHeader3
    	'
    	Me.ColumnHeader3.Text = "Gender"
    	Me.ColumnHeader3.Width = 96
    	'
    	'ColumnHeader4
    	'
    	Me.ColumnHeader4.Text = "Year Level"
    	Me.ColumnHeader4.Width = 108
    	'
    	'ColumnHeader5
    	'
    	Me.ColumnHeader5.Text = "Date Registered"
    	Me.ColumnHeader5.Width = 172
    	'
    	'ContextMenuStrip1
    	'
    	Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AssessToolStripMenuItem, Me.LockToolStripMenuItem, Me.ToolStripSeparator2, Me.RefreshToolStripMenuItem})
    	Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
    	Me.ContextMenuStrip1.Size = New System.Drawing.Size(124, 76)
    	'
    	'AssessToolStripMenuItem
    	'
    	Me.AssessToolStripMenuItem.Name = "AssessToolStripMenuItem"
    	Me.AssessToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
    	Me.AssessToolStripMenuItem.Text = "Assess"
    	'
    	'LockToolStripMenuItem
    	'
    	Me.LockToolStripMenuItem.Name = "LockToolStripMenuItem"
    	Me.LockToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
    	Me.LockToolStripMenuItem.Text = "Lock"
    	'
    	'ToolStripSeparator2
    	'
    	Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
    	Me.ToolStripSeparator2.Size = New System.Drawing.Size(120, 6)
    	'
    	'RefreshToolStripMenuItem
    	'
    	Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
    	Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
    	Me.RefreshToolStripMenuItem.Text = "Refresh"
    	'
    	'StatusStrip3
    	'
    	Me.StatusStrip3.Location = New System.Drawing.Point(3, 385)
    	Me.StatusStrip3.Name = "StatusStrip3"
    	Me.StatusStrip3.Size = New System.Drawing.Size(874, 22)
    	Me.StatusStrip3.TabIndex = 1
    	Me.StatusStrip3.Text = "StatusStrip3"
    	'
    	'TabPage2
    	'
    	Me.TabPage2.Controls.Add(Me.lvCollectibles)
    	Me.TabPage2.Controls.Add(Me.StatusStrip2)
    	Me.TabPage2.Location = New System.Drawing.Point(4, 23)
    	Me.TabPage2.Name = "TabPage2"
    	Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
    	Me.TabPage2.Size = New System.Drawing.Size(880, 410)
    	Me.TabPage2.TabIndex = 1
    	Me.TabPage2.Text = "Collectible Accounts"
    	Me.TabPage2.UseVisualStyleBackColor = true
    	'
    	'lvCollectibles
    	'
    	Me.lvCollectibles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12})
    	Me.lvCollectibles.ContextMenuStrip = Me.ContextMenuStrip2
    	Me.lvCollectibles.Dock = System.Windows.Forms.DockStyle.Fill
    	Me.lvCollectibles.FullRowSelect = true
    	Me.lvCollectibles.Location = New System.Drawing.Point(3, 3)
    	Me.lvCollectibles.Name = "lvCollectibles"
    	Me.lvCollectibles.Size = New System.Drawing.Size(874, 382)
    	Me.lvCollectibles.TabIndex = 3
    	Me.lvCollectibles.UseCompatibleStateImageBehavior = false
    	Me.lvCollectibles.View = System.Windows.Forms.View.Details
    	'
    	'ColumnHeader6
    	'
    	Me.ColumnHeader6.Text = "Student Name"
    	Me.ColumnHeader6.Width = 297
    	'
    	'ColumnHeader7
    	'
    	Me.ColumnHeader7.Text = "ID Number"
    	Me.ColumnHeader7.Width = 143
    	'
    	'ColumnHeader8
    	'
    	Me.ColumnHeader8.Text = "Year Level"
    	Me.ColumnHeader8.Width = 97
    	'
    	'ColumnHeader9
    	'
    	Me.ColumnHeader9.Text = "Scholarship"
    	Me.ColumnHeader9.Width = 215
    	'
    	'ColumnHeader10
    	'
    	Me.ColumnHeader10.Text = "Billed"
    	Me.ColumnHeader10.Width = 120
    	'
    	'ColumnHeader11
    	'
    	Me.ColumnHeader11.Text = "Paid"
    	Me.ColumnHeader11.Width = 119
    	'
    	'ColumnHeader12
    	'
    	Me.ColumnHeader12.Text = "Balance"
    	Me.ColumnHeader12.Width = 109
    	'
    	'ContextMenuStrip2
    	'
    	Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripSeparator3, Me.ToolStripMenuItem3})
    	Me.ContextMenuStrip2.Name = "ContextMenuStrip1"
    	Me.ContextMenuStrip2.Size = New System.Drawing.Size(124, 76)
    	'
    	'ToolStripMenuItem1
    	'
    	Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
    	Me.ToolStripMenuItem1.Size = New System.Drawing.Size(123, 22)
    	Me.ToolStripMenuItem1.Text = "Assess"
    	'
    	'ToolStripMenuItem2
    	'
    	Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
    	Me.ToolStripMenuItem2.Size = New System.Drawing.Size(123, 22)
    	Me.ToolStripMenuItem2.Text = "Lock"
    	'
    	'ToolStripSeparator3
    	'
    	Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
    	Me.ToolStripSeparator3.Size = New System.Drawing.Size(120, 6)
    	'
    	'ToolStripMenuItem3
    	'
    	Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
    	Me.ToolStripMenuItem3.Size = New System.Drawing.Size(123, 22)
    	Me.ToolStripMenuItem3.Text = "Refresh"
    	'
    	'StatusStrip2
    	'
    	Me.StatusStrip2.Location = New System.Drawing.Point(3, 385)
    	Me.StatusStrip2.Name = "StatusStrip2"
    	Me.StatusStrip2.Size = New System.Drawing.Size(874, 22)
    	Me.StatusStrip2.TabIndex = 1
    	Me.StatusStrip2.Text = "StatusStrip2"
    	'
    	'TabPage3
    	'
    	Me.TabPage3.Controls.Add(Me.lvBalance)
    	Me.TabPage3.Controls.Add(Me.StatusStrip1)
    	Me.TabPage3.Location = New System.Drawing.Point(4, 23)
    	Me.TabPage3.Name = "TabPage3"
    	Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
    	Me.TabPage3.Size = New System.Drawing.Size(880, 410)
    	Me.TabPage3.TabIndex = 2
    	Me.TabPage3.Text = "Acount Balances"
    	Me.TabPage3.UseVisualStyleBackColor = true
    	'
    	'lvBalance
    	'
    	Me.lvBalance.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18})
    	Me.lvBalance.ContextMenuStrip = Me.ContextMenuStrip3
    	Me.lvBalance.Dock = System.Windows.Forms.DockStyle.Fill
    	Me.lvBalance.FullRowSelect = true
    	Me.lvBalance.Location = New System.Drawing.Point(3, 3)
    	Me.lvBalance.Name = "lvBalance"
    	Me.lvBalance.Size = New System.Drawing.Size(874, 382)
    	Me.lvBalance.TabIndex = 3
    	Me.lvBalance.UseCompatibleStateImageBehavior = false
    	Me.lvBalance.View = System.Windows.Forms.View.Details
    	'
    	'ColumnHeader13
    	'
    	Me.ColumnHeader13.Text = "Billing Description"
    	Me.ColumnHeader13.Width = 237
    	'
    	'ColumnHeader14
    	'
    	Me.ColumnHeader14.Text = "Account Code"
    	Me.ColumnHeader14.Width = 117
    	'
    	'ColumnHeader15
    	'
    	Me.ColumnHeader15.Text = "Acount Description"
    	Me.ColumnHeader15.Width = 318
    	'
    	'ColumnHeader16
    	'
    	Me.ColumnHeader16.Text = "Billed"
    	Me.ColumnHeader16.Width = 87
    	'
    	'ColumnHeader17
    	'
    	Me.ColumnHeader17.Text = "Collected"
    	Me.ColumnHeader17.Width = 106
    	'
    	'ColumnHeader18
    	'
    	Me.ColumnHeader18.Text = "Balance"
    	Me.ColumnHeader18.Width = 94
    	'
    	'ContextMenuStrip3
    	'
    	Me.ContextMenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4, Me.ToolStripMenuItem5, Me.ToolStripSeparator4, Me.ToolStripMenuItem6})
    	Me.ContextMenuStrip3.Name = "ContextMenuStrip1"
    	Me.ContextMenuStrip3.Size = New System.Drawing.Size(124, 76)
    	'
    	'ToolStripMenuItem4
    	'
    	Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
    	Me.ToolStripMenuItem4.Size = New System.Drawing.Size(123, 22)
    	Me.ToolStripMenuItem4.Text = "Assess"
    	'
    	'ToolStripMenuItem5
    	'
    	Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
    	Me.ToolStripMenuItem5.Size = New System.Drawing.Size(123, 22)
    	Me.ToolStripMenuItem5.Text = "Lock"
    	'
    	'ToolStripSeparator4
    	'
    	Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
    	Me.ToolStripSeparator4.Size = New System.Drawing.Size(120, 6)
    	'
    	'ToolStripMenuItem6
    	'
    	Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
    	Me.ToolStripMenuItem6.Size = New System.Drawing.Size(123, 22)
    	Me.ToolStripMenuItem6.Text = "Refresh"
    	'
    	'StatusStrip1
    	'
    	Me.StatusStrip1.Location = New System.Drawing.Point(3, 385)
    	Me.StatusStrip1.Name = "StatusStrip1"
    	Me.StatusStrip1.Size = New System.Drawing.Size(874, 22)
    	Me.StatusStrip1.TabIndex = 0
    	Me.StatusStrip1.Text = "StatusStrip1"
    	'
    	'frmBillingSummary
    	'
    	Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    	Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    	Me.ClientSize = New System.Drawing.Size(888, 476)
    	Me.Controls.Add(Me.TabControl1)
    	Me.Controls.Add(Me.ToolStrip1)
    	Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
    	Me.Name = "frmBillingSummary"
    	Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    	Me.Text = "Billing Summary"
    	Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    	Me.ToolStrip1.ResumeLayout(false)
    	Me.ToolStrip1.PerformLayout
    	Me.TabControl1.ResumeLayout(false)
    	Me.TabPage1.ResumeLayout(false)
    	Me.TabPage1.PerformLayout
    	Me.ContextMenuStrip1.ResumeLayout(false)
    	Me.TabPage2.ResumeLayout(false)
    	Me.TabPage2.PerformLayout
    	Me.ContextMenuStrip2.ResumeLayout(false)
    	Me.TabPage3.ResumeLayout(false)
    	Me.TabPage3.PerformLayout
    	Me.ContextMenuStrip3.ResumeLayout(false)
    	Me.ResumeLayout(false)
    	Me.PerformLayout
    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtSY As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents cmdBrowseSchoolYear As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents lvBillable As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents StatusStrip3 As System.Windows.Forms.StatusStrip
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lvCollectibles As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents StatusStrip2 As System.Windows.Forms.StatusStrip
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents lvBalance As System.Windows.Forms.ListView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AssessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip3 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
End Class
