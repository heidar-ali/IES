Partial Class frmFacultyAE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFacultyAE))
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkActive = New System.Windows.Forms.CheckBox()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.picImage = New System.Windows.Forms.PictureBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTeacherTitle = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.button2 = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.txtMName = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtFacultyID = New System.Windows.Forms.TextBox()
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPage1 = New System.Windows.Forms.TabPage()
        Me.tabPage3 = New System.Windows.Forms.TabPage()
        Me.lsvClasslist = New System.Windows.Forms.ListView()
        Me._column_80 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lsvLoad = New System.Windows.Forms.ListView()
        Me._column_72 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me._column_73 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me._column_74 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.contextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.printClassListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.cboSY = New System.Windows.Forms.ToolStripComboBox()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.sbrLoad = New System.Windows.Forms.StatusBar()
        Me._panel_76 = New System.Windows.Forms.StatusBarPanel()
        Me._panel_77 = New System.Windows.Forms.StatusBarPanel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lvAdvisory = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.groupBox1.SuspendLayout()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabControl1.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        Me.tabPage3.SuspendLayout()
        Me.contextMenuStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me._panel_76, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._panel_77, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.chkActive)
        Me.groupBox1.Controls.Add(Me.cmdDelete)
        Me.groupBox1.Controls.Add(Me.cmdBrowse)
        Me.groupBox1.Controls.Add(Me.picImage)
        Me.groupBox1.Controls.Add(Me.txtPassword)
        Me.groupBox1.Controls.Add(Me.Label8)
        Me.groupBox1.Controls.Add(Me.txtTeacherTitle)
        Me.groupBox1.Controls.Add(Me.Label7)
        Me.groupBox1.Controls.Add(Me.button2)
        Me.groupBox1.Controls.Add(Me.cmdSave)
        Me.groupBox1.Controls.Add(Me.txtContactNumber)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Controls.Add(Me.txtAddress)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.txtMName)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.txtFName)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.txtLName)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.txtFacultyID)
        Me.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(3, 3)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(545, 428)
        Me.groupBox1.TabIndex = 1
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Details"
        '
        'chkActive
        '
        Me.chkActive.AutoSize = True
        Me.chkActive.Location = New System.Drawing.Point(20, 348)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(101, 18)
        Me.chkActive.TabIndex = 28
        Me.chkActive.Text = "Active service"
        Me.chkActive.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(461, 183)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(60, 23)
        Me.cmdDelete.TabIndex = 27
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(354, 183)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(62, 23)
        Me.cmdBrowse.TabIndex = 26
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'picImage
        '
        Me.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picImage.Image = CType(resources.GetObject("picImage.Image"), System.Drawing.Image)
        Me.picImage.Location = New System.Drawing.Point(354, 27)
        Me.picImage.Name = "picImage"
        Me.picImage.Size = New System.Drawing.Size(166, 150)
        Me.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picImage.TabIndex = 25
        Me.picImage.TabStop = False
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(20, 320)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(298, 22)
        Me.txtPassword.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 304)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 14)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Password"
        '
        'txtTeacherTitle
        '
        Me.txtTeacherTitle.Location = New System.Drawing.Point(20, 281)
        Me.txtTeacherTitle.Name = "txtTeacherTitle"
        Me.txtTeacherTitle.Size = New System.Drawing.Size(298, 22)
        Me.txtTeacherTitle.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 265)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 14)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Log-In Name"
        '
        'button2
        '
        Me.button2.Image = CType(resources.GetObject("button2.Image"), System.Drawing.Image)
        Me.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button2.Location = New System.Drawing.Point(433, 397)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(88, 25)
        Me.button2.TabIndex = 20
        Me.button2.Text = "Cancel"
        Me.button2.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSave.Location = New System.Drawing.Point(339, 397)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(88, 25)
        Me.cmdSave.TabIndex = 19
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Location = New System.Drawing.Point(19, 241)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(299, 22)
        Me.txtContactNumber.TabIndex = 11
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(16, 225)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(80, 14)
        Me.label6.TabIndex = 10
        Me.label6.Text = "Contact Info:"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(19, 167)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(299, 55)
        Me.txtAddress.TabIndex = 9
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(16, 151)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(54, 14)
        Me.label5.TabIndex = 8
        Me.label5.Text = "Address:"
        '
        'txtMName
        '
        Me.txtMName.Location = New System.Drawing.Point(19, 126)
        Me.txtMName.Name = "txtMName"
        Me.txtMName.Size = New System.Drawing.Size(299, 22)
        Me.txtMName.TabIndex = 7
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(16, 110)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(75, 14)
        Me.label4.TabIndex = 6
        Me.label4.Text = "Middlename:"
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(19, 85)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(299, 22)
        Me.txtFName.TabIndex = 5
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(16, 72)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(63, 14)
        Me.label3.TabIndex = 4
        Me.label3.Text = "Firstname:"
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(19, 43)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(299, 22)
        Me.txtLName.TabIndex = 3
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(16, 27)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(63, 14)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Lastname:"
        '
        'txtFacultyID
        '
        Me.txtFacultyID.BackColor = System.Drawing.SystemColors.Info
        Me.txtFacultyID.Location = New System.Drawing.Point(415, 257)
        Me.txtFacultyID.Name = "txtFacultyID"
        Me.txtFacultyID.Size = New System.Drawing.Size(78, 22)
        Me.txtFacultyID.TabIndex = 1
        Me.txtFacultyID.Visible = False
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.tabPage1)
        Me.tabControl1.Controls.Add(Me.tabPage3)
        Me.tabControl1.Controls.Add(Me.TabPage2)
        Me.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControl1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabControl1.Location = New System.Drawing.Point(0, 0)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(559, 461)
        Me.tabControl1.TabIndex = 3
        '
        'tabPage1
        '
        Me.tabPage1.Controls.Add(Me.groupBox1)
        Me.tabPage1.Location = New System.Drawing.Point(4, 23)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage1.Size = New System.Drawing.Size(551, 434)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "Personal Info"
        Me.tabPage1.UseVisualStyleBackColor = True
        '
        'tabPage3
        '
        Me.tabPage3.Controls.Add(Me.lsvClasslist)
        Me.tabPage3.Controls.Add(Me.lsvLoad)
        Me.tabPage3.Controls.Add(Me.ToolStrip2)
        Me.tabPage3.Controls.Add(Me.sbrLoad)
        Me.tabPage3.Location = New System.Drawing.Point(4, 23)
        Me.tabPage3.Name = "tabPage3"
        Me.tabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage3.Size = New System.Drawing.Size(551, 434)
        Me.tabPage3.TabIndex = 2
        Me.tabPage3.Text = "Teaching Load"
        Me.tabPage3.UseVisualStyleBackColor = True
        '
        'lsvClasslist
        '
        Me.lsvClasslist.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me._column_80, Me.ColumnHeader6, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader15})
        Me.lsvClasslist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsvClasslist.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvClasslist.FullRowSelect = True
        Me.lsvClasslist.HideSelection = False
        Me.lsvClasslist.Location = New System.Drawing.Point(3, 183)
        Me.lsvClasslist.Name = "lsvClasslist"
        Me.lsvClasslist.Size = New System.Drawing.Size(545, 232)
        Me.lsvClasslist.TabIndex = 13
        Me.lsvClasslist.UseCompatibleStateImageBehavior = False
        Me.lsvClasslist.View = System.Windows.Forms.View.Details
        '
        '_column_80
        '
        Me._column_80.Name = "_column_80"
        Me._column_80.Text = "Student Name"
        Me._column_80.Width = 163
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "ID Number"
        Me.ColumnHeader6.Width = 144
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Final Grade"
        Me.ColumnHeader10.Width = 86
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Comp Grade"
        Me.ColumnHeader11.Width = 90
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Remarks"
        Me.ColumnHeader12.Width = 100
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Date Validated"
        '
        'lsvLoad
        '
        Me.lsvLoad.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me._column_72, Me.ColumnHeader14, Me._column_73, Me._column_74, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lsvLoad.ContextMenuStrip = Me.contextMenuStrip1
        Me.lsvLoad.Dock = System.Windows.Forms.DockStyle.Top
        Me.lsvLoad.FullRowSelect = True
        Me.lsvLoad.HideSelection = False
        Me.lsvLoad.Location = New System.Drawing.Point(3, 28)
        Me.lsvLoad.Name = "lsvLoad"
        Me.lsvLoad.Size = New System.Drawing.Size(545, 155)
        Me.lsvLoad.TabIndex = 12
        Me.lsvLoad.UseCompatibleStateImageBehavior = False
        Me.lsvLoad.View = System.Windows.Forms.View.Details
        '
        '_column_72
        '
        Me._column_72.Name = "_column_72"
        Me._column_72.Text = "Subject"
        Me._column_72.Width = 159
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "ID"
        Me.ColumnHeader14.Width = 0
        '
        '_column_73
        '
        Me._column_73.Name = "_column_73"
        Me._column_73.Text = "Section"
        Me._column_73.Width = 156
        '
        '_column_74
        '
        Me._column_74.Name = "_column_74"
        Me._column_74.Text = "Units"
        Me._column_74.Width = 50
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Room"
        Me.ColumnHeader4.Width = 114
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Class Schedule"
        Me.ColumnHeader5.Width = 225
        '
        'contextMenuStrip1
        '
        Me.contextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.printClassListToolStripMenuItem})
        Me.contextMenuStrip1.Name = "contextMenuStrip1"
        Me.contextMenuStrip1.Size = New System.Drawing.Size(162, 26)
        '
        'printClassListToolStripMenuItem
        '
        Me.printClassListToolStripMenuItem.Name = "printClassListToolStripMenuItem"
        Me.printClassListToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.printClassListToolStripMenuItem.Text = "Print class list..."
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cboSY, Me.toolStripSeparator3, Me.PrintToolStripButton1})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(545, 25)
        Me.ToolStrip2.TabIndex = 11
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'cboSY
        '
        Me.cboSY.Name = "cboSY"
        Me.cboSY.Size = New System.Drawing.Size(200, 25)
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'PrintToolStripButton1
        '
        Me.PrintToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintToolStripButton1.Image = CType(resources.GetObject("PrintToolStripButton1.Image"), System.Drawing.Image)
        Me.PrintToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripButton1.Name = "PrintToolStripButton1"
        Me.PrintToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.PrintToolStripButton1.Text = "&Print"
        '
        'sbrLoad
        '
        Me.sbrLoad.Location = New System.Drawing.Point(3, 415)
        Me.sbrLoad.Name = "sbrLoad"
        Me.sbrLoad.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me._panel_76, Me._panel_77})
        Me.sbrLoad.ShowPanels = True
        Me.sbrLoad.Size = New System.Drawing.Size(545, 16)
        Me.sbrLoad.TabIndex = 7
        '
        '_panel_76
        '
        Me._panel_76.Name = "_panel_76"
        '
        '_panel_77
        '
        Me._panel_77.Name = "_panel_77"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lvAdvisory)
        Me.TabPage2.Controls.Add(Me.StatusStrip1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(551, 434)
        Me.TabPage2.TabIndex = 3
        Me.TabPage2.Text = "Advisee"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lvAdvisory
        '
        Me.lvAdvisory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvAdvisory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvAdvisory.FullRowSelect = True
        Me.lvAdvisory.Location = New System.Drawing.Point(3, 3)
        Me.lvAdvisory.Name = "lvAdvisory"
        Me.lvAdvisory.Size = New System.Drawing.Size(545, 406)
        Me.lvAdvisory.TabIndex = 1
        Me.lvAdvisory.UseCompatibleStateImageBehavior = False
        Me.lvAdvisory.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Student Name"
        Me.ColumnHeader1.Width = 211
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "ID Number"
        Me.ColumnHeader2.Width = 133
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Year Level - Section"
        Me.ColumnHeader3.Width = 174
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(3, 409)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(545, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'openFileDialog1
        '
        Me.openFileDialog1.FileName = "openFileDialog1"
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Validated By"
        '
        'frmFacultyAE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 461)
        Me.Controls.Add(Me.tabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFacultyAE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Faculty"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabControl1.ResumeLayout(False)
        Me.tabPage1.ResumeLayout(False)
        Me.tabPage3.ResumeLayout(False)
        Me.tabPage3.PerformLayout()
        Me.contextMenuStrip1.ResumeLayout(False)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me._panel_76, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._panel_77, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private groupBox1 As System.Windows.Forms.GroupBox
    Private txtContactNumber As System.Windows.Forms.TextBox
    Private label6 As System.Windows.Forms.Label
    Private txtAddress As System.Windows.Forms.TextBox
    Private label5 As System.Windows.Forms.Label
    Private txtMName As System.Windows.Forms.TextBox
    Private label4 As System.Windows.Forms.Label
    Private txtFName As System.Windows.Forms.TextBox
    Private label3 As System.Windows.Forms.Label
    Private txtLName As System.Windows.Forms.TextBox
    Private label2 As System.Windows.Forms.Label
    Private txtFacultyID As System.Windows.Forms.TextBox
    Private tabControl1 As System.Windows.Forms.TabControl
    Private tabPage1 As System.Windows.Forms.TabPage
    Private tabPage3 As System.Windows.Forms.TabPage
    Public sbrLoad As System.Windows.Forms.StatusBar
    Public _panel_76 As System.Windows.Forms.StatusBarPanel
    Public _panel_77 As System.Windows.Forms.StatusBarPanel
    Private contextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Private printClassListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private openFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents button2 As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Private WithEvents txtPassword As System.Windows.Forms.TextBox
    Private WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents txtTeacherTitle As System.Windows.Forms.TextBox
    Private WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdBrowse As System.Windows.Forms.Button
    Friend WithEvents picImage As System.Windows.Forms.PictureBox
    Friend WithEvents lvAdvisory As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents chkActive As System.Windows.Forms.CheckBox
    Public WithEvents lsvClasslist As System.Windows.Forms.ListView
    Public WithEvents _column_80 As System.Windows.Forms.ColumnHeader
    Public WithEvents lsvLoad As System.Windows.Forms.ListView
    Public WithEvents _column_72 As System.Windows.Forms.ColumnHeader
    Public WithEvents _column_73 As System.Windows.Forms.ColumnHeader
    Public WithEvents _column_74 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents cboSY As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
End Class
