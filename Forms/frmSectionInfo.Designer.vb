Partial Class frmSectionInfo
    Inherits System.Windows.Forms.Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSectionInfo))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lvRoomSchedule = New System.Windows.Forms.ListView()
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.popRoomSchedule = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuAddRoomschedule = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditRoomSchedule = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDeleteRoomSchedule = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuRefreshRoomSchedule = New System.Windows.Forms.ToolStripMenuItem()
        Me.lvInstructor = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Grid = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lvEnrollees = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.popEnrollees = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ViewStudentInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lvDeletedEnrollees = New System.Windows.Forms.ListView()
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.popRoomSchedule.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.popEnrollees.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(707, 550)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lvRoomSchedule)
        Me.TabPage1.Controls.Add(Me.lvInstructor)
        Me.TabPage1.Controls.Add(Me.Grid)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(699, 523)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "General Info"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lvRoomSchedule
        '
        Me.lvRoomSchedule.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader12, Me.ColumnHeader15, Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvRoomSchedule.ContextMenuStrip = Me.popRoomSchedule
        Me.lvRoomSchedule.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvRoomSchedule.FullRowSelect = True
        Me.lvRoomSchedule.Location = New System.Drawing.Point(3, 150)
        Me.lvRoomSchedule.Name = "lvRoomSchedule"
        Me.lvRoomSchedule.Size = New System.Drawing.Size(693, 218)
        Me.lvRoomSchedule.TabIndex = 4
        Me.lvRoomSchedule.UseCompatibleStateImageBehavior = False
        Me.lvRoomSchedule.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Subjects"
        Me.ColumnHeader12.Width = 188
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "ID"
        Me.ColumnHeader15.Width = 0
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Assigned Room"
        Me.ColumnHeader1.Width = 166
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Schedule"
        Me.ColumnHeader2.Width = 322
        '
        'popRoomSchedule
        '
        Me.popRoomSchedule.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAddRoomschedule, Me.mnuEditRoomSchedule, Me.mnuDeleteRoomSchedule, Me.ToolStripSeparator1, Me.mnuRefreshRoomSchedule})
        Me.popRoomSchedule.Name = "popRoomSchedule"
        Me.popRoomSchedule.Size = New System.Drawing.Size(184, 120)
        '
        'mnuAddRoomschedule
        '
        Me.mnuAddRoomschedule.Name = "mnuAddRoomschedule"
        Me.mnuAddRoomschedule.Size = New System.Drawing.Size(183, 22)
        Me.mnuAddRoomschedule.Text = "Add subject offering"
        '
        'mnuEditRoomSchedule
        '
        Me.mnuEditRoomSchedule.Name = "mnuEditRoomSchedule"
        Me.mnuEditRoomSchedule.Size = New System.Drawing.Size(183, 22)
        Me.mnuEditRoomSchedule.Text = "Edit schedule"
        '
        'mnuDeleteRoomSchedule
        '
        Me.mnuDeleteRoomSchedule.Name = "mnuDeleteRoomSchedule"
        Me.mnuDeleteRoomSchedule.Size = New System.Drawing.Size(183, 22)
        Me.mnuDeleteRoomSchedule.Text = "Delete"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(180, 6)
        '
        'mnuRefreshRoomSchedule
        '
        Me.mnuRefreshRoomSchedule.Name = "mnuRefreshRoomSchedule"
        Me.mnuRefreshRoomSchedule.Size = New System.Drawing.Size(183, 22)
        Me.mnuRefreshRoomSchedule.Text = "Refresh"
        '
        'lvInstructor
        '
        Me.lvInstructor.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvInstructor.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lvInstructor.FullRowSelect = True
        Me.lvInstructor.Location = New System.Drawing.Point(3, 368)
        Me.lvInstructor.Name = "lvInstructor"
        Me.lvInstructor.Size = New System.Drawing.Size(693, 107)
        Me.lvInstructor.TabIndex = 3
        Me.lvInstructor.UseCompatibleStateImageBehavior = False
        Me.lvInstructor.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Teacher"
        Me.ColumnHeader3.Width = 571
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "ID"
        Me.ColumnHeader4.Width = 0
        '
        'Grid
        '
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Top
        Me.Grid.Location = New System.Drawing.Point(3, 3)
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(693, 147)
        Me.Grid.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdSave)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(3, 475)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(693, 45)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(284, 10)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(117, 33)
        Me.cmdSave.TabIndex = 0
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lvEnrollees)
        Me.TabPage2.Controls.Add(Me.StatusStrip1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(699, 523)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Enrollees"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lvEnrollees
        '
        Me.lvEnrollees.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.lvEnrollees.ContextMenuStrip = Me.popEnrollees
        Me.lvEnrollees.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvEnrollees.FullRowSelect = True
        Me.lvEnrollees.Location = New System.Drawing.Point(3, 3)
        Me.lvEnrollees.Name = "lvEnrollees"
        Me.lvEnrollees.Size = New System.Drawing.Size(693, 495)
        Me.lvEnrollees.TabIndex = 1
        Me.lvEnrollees.UseCompatibleStateImageBehavior = False
        Me.lvEnrollees.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Student Name"
        Me.ColumnHeader5.Width = 246
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "ID Number"
        Me.ColumnHeader6.Width = 152
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Year Level"
        Me.ColumnHeader7.Width = 86
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Date Enrolled"
        Me.ColumnHeader8.Width = 149
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Enrolled By"
        Me.ColumnHeader9.Width = 208
        '
        'popEnrollees
        '
        Me.popEnrollees.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewStudentInfoToolStripMenuItem, Me.ToolStripSeparator2, Me.RefreshToolStripMenuItem})
        Me.popEnrollees.Name = "popEnrollees"
        Me.popEnrollees.Size = New System.Drawing.Size(169, 76)
        '
        'ViewStudentInfoToolStripMenuItem
        '
        Me.ViewStudentInfoToolStripMenuItem.Name = "ViewStudentInfoToolStripMenuItem"
        Me.ViewStudentInfoToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ViewStudentInfoToolStripMenuItem.Text = "View student info"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(165, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(3, 498)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(693, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.lvDeletedEnrollees)
        Me.TabPage3.Controls.Add(Me.StatusStrip2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(699, 523)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Deleted Enrollees"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'lvDeletedEnrollees
        '
        Me.lvDeletedEnrollees.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader13, Me.ColumnHeader14})
        Me.lvDeletedEnrollees.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvDeletedEnrollees.FullRowSelect = True
        Me.lvDeletedEnrollees.Location = New System.Drawing.Point(3, 3)
        Me.lvDeletedEnrollees.Name = "lvDeletedEnrollees"
        Me.lvDeletedEnrollees.Size = New System.Drawing.Size(693, 495)
        Me.lvDeletedEnrollees.TabIndex = 2
        Me.lvDeletedEnrollees.UseCompatibleStateImageBehavior = False
        Me.lvDeletedEnrollees.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Student Name"
        Me.ColumnHeader10.Width = 246
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "ID Number"
        Me.ColumnHeader11.Width = 152
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Date of Deletion"
        Me.ColumnHeader13.Width = 149
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Deleted By"
        Me.ColumnHeader14.Width = 208
        '
        'StatusStrip2
        '
        Me.StatusStrip2.Location = New System.Drawing.Point(3, 498)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.Size = New System.Drawing.Size(693, 22)
        Me.StatusStrip2.TabIndex = 0
        Me.StatusStrip2.Text = "StatusStrip2"
        '
        'frmManageSections
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 550)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmManageSections"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Section Properties"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.popRoomSchedule.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.popEnrollees.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents lvRoomSchedule As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvInstructor As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Grid As C1.Win.C1FlexGrid.Classic.C1FlexGridClassic
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents StatusStrip2 As System.Windows.Forms.StatusStrip
    Friend WithEvents lvEnrollees As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvDeletedEnrollees As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents popRoomSchedule As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuAddRoomschedule As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEditRoomSchedule As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDeleteRoomSchedule As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuRefreshRoomSchedule As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents popEnrollees As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ViewStudentInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader

#End Region

End Class
