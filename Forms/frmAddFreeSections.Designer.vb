Partial Class frmAddFreeSections
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddFreeSections))
        Me.tabFaculty = New System.Windows.Forms.TabControl()
        Me.tabPage1 = New System.Windows.Forms.TabPage()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.listSubjects = New System.Windows.Forms.ListView()
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblSubjectCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lvSubjects = New System.Windows.Forms.ListView()
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSectionFullTitle = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.cmdBrowseRoom = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtRoom = New System.Windows.Forms.TextBox()
        Me.txtSlot = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTeacherFullName = New System.Windows.Forms.TextBox()
        Me.cmdGetTeacher = New System.Windows.Forms.Button()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.txtSectionID = New System.Windows.Forms.TextBox()
        Me._panel_111 = New System.Windows.Forms.StatusBarPanel()
        Me._column_106 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me._column_107 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me._column_108 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me._column_109 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me._column_110 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tabFaculty.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        CType(Me._panel_111, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabFaculty
        '
        Me.tabFaculty.Controls.Add(Me.tabPage1)
        Me.tabFaculty.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabFaculty.Location = New System.Drawing.Point(0, 0)
        Me.tabFaculty.Name = "tabFaculty"
        Me.tabFaculty.SelectedIndex = 0
        Me.tabFaculty.Size = New System.Drawing.Size(928, 529)
        Me.tabFaculty.TabIndex = 0
        '
        'tabPage1
        '
        Me.tabPage1.Controls.Add(Me.groupBox1)
        Me.tabPage1.Controls.Add(Me.groupBox2)
        Me.tabPage1.Location = New System.Drawing.Point(4, 24)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage1.Size = New System.Drawing.Size(920, 501)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "Free Section Details"
        Me.tabPage1.UseVisualStyleBackColor = True
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.TabControl1)
        Me.groupBox1.Controls.Add(Me.TabControl2)
        Me.groupBox1.Controls.Add(Me.Label5)
        Me.groupBox1.Controls.Add(Me.txtSectionFullTitle)
        Me.groupBox1.Controls.Add(Me.label8)
        Me.groupBox1.Controls.Add(Me.label10)
        Me.groupBox1.Controls.Add(Me.cmdBrowseRoom)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.txtRoom)
        Me.groupBox1.Controls.Add(Me.txtSlot)
        Me.groupBox1.Controls.Add(Me.Label6)
        Me.groupBox1.Controls.Add(Me.txtTeacherFullName)
        Me.groupBox1.Controls.Add(Me.cmdGetTeacher)
        Me.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupBox1.Location = New System.Drawing.Point(3, 3)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(914, 450)
        Me.groupBox1.TabIndex = 6
        Me.groupBox1.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(3, 130)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(579, 317)
        Me.TabControl1.TabIndex = 102
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.listSubjects)
        Me.TabPage3.Controls.Add(Me.StatusStrip1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(571, 290)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "List of Subjects for this curriculum"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'listSubjects
        '
        Me.listSubjects.AllowDrop = True
        Me.listSubjects.CheckBoxes = True
        Me.listSubjects.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader16, Me.ColumnHeader4, Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.listSubjects.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listSubjects.FullRowSelect = True
        Me.listSubjects.Location = New System.Drawing.Point(3, 3)
        Me.listSubjects.MultiSelect = False
        Me.listSubjects.Name = "listSubjects"
        Me.listSubjects.Size = New System.Drawing.Size(565, 262)
        Me.listSubjects.TabIndex = 8
        Me.listSubjects.UseCompatibleStateImageBehavior = False
        Me.listSubjects.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Subject Code"
        Me.ColumnHeader16.Width = 112
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Subject ID"
        Me.ColumnHeader4.Width = 0
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Subject Title"
        Me.ColumnHeader1.Width = 294
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Lec. Units"
        Me.ColumnHeader3.Width = 73
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Lec.Hrs."
        Me.ColumnHeader5.Width = 61
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Lab Units"
        Me.ColumnHeader6.Width = 65
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Lab Hrs."
        Me.ColumnHeader7.Width = 62
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Slots"
        Me.ColumnHeader8.Width = 52
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblSubjectCount})
        Me.StatusStrip1.Location = New System.Drawing.Point(3, 265)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(565, 22)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel1.Text = "Total Subject Count:"
        '
        'lblSubjectCount
        '
        Me.lblSubjectCount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubjectCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSubjectCount.Name = "lblSubjectCount"
        Me.lblSubjectCount.Size = New System.Drawing.Size(14, 17)
        Me.lblSubjectCount.Text = "0"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Right
        Me.TabControl2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl2.Location = New System.Drawing.Point(582, 16)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(329, 431)
        Me.TabControl2.TabIndex = 101
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lvSubjects)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.txtFind)
        Me.TabPage2.Controls.Add(Me.cmdSearch)
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(321, 404)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "List of Subjects"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lvSubjects
        '
        Me.lvSubjects.AllowDrop = True
        Me.lvSubjects.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12})
        Me.lvSubjects.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lvSubjects.FullRowSelect = True
        Me.lvSubjects.Location = New System.Drawing.Point(3, 61)
        Me.lvSubjects.MultiSelect = False
        Me.lvSubjects.Name = "lvSubjects"
        Me.lvSubjects.Size = New System.Drawing.Size(315, 340)
        Me.lvSubjects.TabIndex = 98
        Me.lvSubjects.UseCompatibleStateImageBehavior = False
        Me.lvSubjects.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Subject Code"
        Me.ColumnHeader9.Width = 91
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Subject ID"
        Me.ColumnHeader10.Width = 0
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Subject Title"
        Me.ColumnHeader11.Width = 160
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Units"
        Me.ColumnHeader12.Width = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(6, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 14)
        Me.Label3.TabIndex = 96
        Me.Label3.Text = "Search Subject Code:"
        '
        'txtFind
        '
        Me.txtFind.BackColor = System.Drawing.SystemColors.Info
        Me.txtFind.Location = New System.Drawing.Point(6, 26)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(281, 22)
        Me.txtFind.TabIndex = 97
        '
        'cmdSearch
        '
        Me.cmdSearch.Image = CType(resources.GetObject("cmdSearch.Image"), System.Drawing.Image)
        Me.cmdSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSearch.Location = New System.Drawing.Point(288, 24)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(25, 24)
        Me.cmdSearch.TabIndex = 98
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(596, 1)
        Me.Label5.TabIndex = 99
        '
        'txtSectionFullTitle
        '
        Me.txtSectionFullTitle.BackColor = System.Drawing.SystemColors.Info
        Me.txtSectionFullTitle.Location = New System.Drawing.Point(105, 20)
        Me.txtSectionFullTitle.Name = "txtSectionFullTitle"
        Me.txtSectionFullTitle.Size = New System.Drawing.Size(234, 21)
        Me.txtSectionFullTitle.TabIndex = 19
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(44, 47)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(49, 15)
        Me.label8.TabIndex = 15
        Me.label8.Text = "Adviser:"
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(14, 23)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(77, 15)
        Me.label10.TabIndex = 18
        Me.label10.Text = "Section Title:"
        '
        'cmdBrowseRoom
        '
        Me.cmdBrowseRoom.Image = CType(resources.GetObject("cmdBrowseRoom.Image"), System.Drawing.Image)
        Me.cmdBrowseRoom.Location = New System.Drawing.Point(339, 71)
        Me.cmdBrowseRoom.Name = "cmdBrowseRoom"
        Me.cmdBrowseRoom.Size = New System.Drawing.Size(25, 23)
        Me.cmdBrowseRoom.TabIndex = 80
        Me.cmdBrowseRoom.UseVisualStyleBackColor = True
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(368, 23)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(37, 15)
        Me.label2.TabIndex = 3
        Me.label2.Text = "Slots:"
        '
        'txtRoom
        '
        Me.txtRoom.BackColor = System.Drawing.SystemColors.Info
        Me.txtRoom.Location = New System.Drawing.Point(105, 73)
        Me.txtRoom.Name = "txtRoom"
        Me.txtRoom.Size = New System.Drawing.Size(234, 21)
        Me.txtRoom.TabIndex = 79
        '
        'txtSlot
        '
        Me.txtSlot.Location = New System.Drawing.Point(411, 20)
        Me.txtSlot.Name = "txtSlot"
        Me.txtSlot.Size = New System.Drawing.Size(155, 21)
        Me.txtSlot.TabIndex = 2
        Me.txtSlot.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(52, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 14)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "Room:"
        '
        'txtTeacherFullName
        '
        Me.txtTeacherFullName.BackColor = System.Drawing.SystemColors.Info
        Me.txtTeacherFullName.Location = New System.Drawing.Point(105, 45)
        Me.txtTeacherFullName.Name = "txtTeacherFullName"
        Me.txtTeacherFullName.Size = New System.Drawing.Size(234, 21)
        Me.txtTeacherFullName.TabIndex = 60
        '
        'cmdGetTeacher
        '
        Me.cmdGetTeacher.Image = CType(resources.GetObject("cmdGetTeacher.Image"), System.Drawing.Image)
        Me.cmdGetTeacher.Location = New System.Drawing.Point(338, 44)
        Me.cmdGetTeacher.Name = "cmdGetTeacher"
        Me.cmdGetTeacher.Size = New System.Drawing.Size(25, 23)
        Me.cmdGetTeacher.TabIndex = 61
        Me.cmdGetTeacher.UseVisualStyleBackColor = True
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.cmdCancel)
        Me.groupBox2.Controls.Add(Me.cmdSave)
        Me.groupBox2.Controls.Add(Me.txtSectionID)
        Me.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.groupBox2.Location = New System.Drawing.Point(3, 453)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(914, 45)
        Me.groupBox2.TabIndex = 5
        Me.groupBox2.TabStop = False
        '
        'cmdCancel
        '
        Me.cmdCancel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Image = CType(resources.GetObject("cmdCancel.Image"), System.Drawing.Image)
        Me.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancel.Location = New System.Drawing.Point(798, 10)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(106, 30)
        Me.cmdCancel.TabIndex = 18
        Me.cmdCancel.Text = "&Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSave.Location = New System.Drawing.Point(686, 10)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(106, 31)
        Me.cmdSave.TabIndex = 0
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'txtSectionID
        '
        Me.txtSectionID.BackColor = System.Drawing.SystemColors.Info
        Me.txtSectionID.Location = New System.Drawing.Point(10, 14)
        Me.txtSectionID.Name = "txtSectionID"
        Me.txtSectionID.ReadOnly = True
        Me.txtSectionID.Size = New System.Drawing.Size(184, 21)
        Me.txtSectionID.TabIndex = 17
        '
        '_panel_111
        '
        Me._panel_111.Name = "_panel_111"
        '
        '_column_106
        '
        Me._column_106.DisplayIndex = 0
        Me._column_106.Name = "_column_106"
        Me._column_106.Text = "Student Name"
        Me._column_106.Width = 208
        '
        '_column_107
        '
        Me._column_107.DisplayIndex = 1
        Me._column_107.Name = "_column_107"
        Me._column_107.Text = "ID Number"
        Me._column_107.Width = 120
        '
        '_column_108
        '
        Me._column_108.DisplayIndex = 2
        Me._column_108.Name = "_column_108"
        Me._column_108.Text = "Year Level"
        Me._column_108.Width = 97
        '
        '_column_109
        '
        Me._column_109.DisplayIndex = 3
        Me._column_109.Name = "_column_109"
        Me._column_109.Text = "Date Enrolled"
        Me._column_109.Width = 117
        '
        '_column_110
        '
        Me._column_110.DisplayIndex = 4
        Me._column_110.Name = "_column_110"
        Me._column_110.Text = "Enrolled by"
        Me._column_110.Width = 102
        '
        'frmAddFreeSections
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 529)
        Me.Controls.Add(Me.tabFaculty)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddFreeSections"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Free Section Entry"
        Me.tabFaculty.ResumeLayout(False)
        Me.tabPage1.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        CType(Me._panel_111, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private tabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Private groupBox1 As System.Windows.Forms.GroupBox
    Private groupBox2 As System.Windows.Forms.GroupBox
    Public tabFaculty As System.Windows.Forms.TabControl
    Public WithEvents _column_96 As System.Windows.Forms.ColumnHeader
    Private WithEvents columnHeader2 As System.Windows.Forms.ColumnHeader
    Public WithEvents txtSectionID As System.Windows.Forms.TextBox
    Public WithEvents _panel_111 As System.Windows.Forms.StatusBarPanel
    Public WithEvents _column_106 As System.Windows.Forms.ColumnHeader
    Public WithEvents _column_107 As System.Windows.Forms.ColumnHeader
    Public WithEvents _column_108 As System.Windows.Forms.ColumnHeader
    Public WithEvents _column_109 As System.Windows.Forms.ColumnHeader
    Public WithEvents _column_110 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Private WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents txtFind As System.Windows.Forms.TextBox
    Private WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents txtSectionFullTitle As System.Windows.Forms.TextBox
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents label10 As System.Windows.Forms.Label
    Friend WithEvents cmdBrowseRoom As System.Windows.Forms.Button
    Private WithEvents label2 As System.Windows.Forms.Label
    Public WithEvents txtRoom As System.Windows.Forms.TextBox
    Friend WithEvents txtSlot As System.Windows.Forms.TextBox
    Private WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents txtTeacherFullName As System.Windows.Forms.TextBox
    Friend WithEvents cmdGetTeacher As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Public WithEvents listSubjects As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblSubjectCount As System.Windows.Forms.ToolStripStatusLabel
    Public WithEvents lvSubjects As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader

End Class
