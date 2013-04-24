Partial Class frmProgramSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProgramSettings))
        Me.pgcSettings = New System.Windows.Forms.TabControl()
        Me.tabDirectory = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.tvDirectory = New System.Windows.Forms.TreeView()
        Me.TreeNodeImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.ListView = New System.Windows.Forms.ListView()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ViewToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThumbnailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetailsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.ArrangeIconsByToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifiedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.ShowsInGroupsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutoArrangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlignToGridToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.PropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListViewLargeImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.ListViewSmallImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.treDirectory = New System.Windows.Forms.TreeView()
        Me.sbrDirectory = New System.Windows.Forms.StatusBar()
        Me._panel_117 = New System.Windows.Forms.StatusBarPanel()
        Me._panel_118 = New System.Windows.Forms.StatusBarPanel()
        Me._panel_119 = New System.Windows.Forms.StatusBarPanel()
        Me.tabFaculty = New System.Windows.Forms.TabPage()
        Me.lsvFaculty = New System.Windows.Forms.ListView()
        Me._column_120 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me._column_121 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me._column_122 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.popFaculty = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.newFacultyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.editFacultyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.deleteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.activateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.refreshToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.sbrFaculty = New System.Windows.Forms.StatusBar()
        Me._panel_123 = New System.Windows.Forms.StatusBarPanel()
        Me.tabSubject = New System.Windows.Forms.TabPage()
        Me.lsvSubject = New System.Windows.Forms.ListView()
        Me.columnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lsvDepartment = New System.Windows.Forms.ListView()
        Me._column_128 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.popDepartment = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewDepartmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifyDepartmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.printSubjectsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.refreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.sbrSubject = New System.Windows.Forms.StatusBar()
        Me._panel_129 = New System.Windows.Forms.StatusBarPanel()
        Me._panel_130 = New System.Windows.Forms.StatusBarPanel()
        Me.tabClassroom = New System.Windows.Forms.TabPage()
        Me.lsvClassroom = New System.Windows.Forms.ListView()
        Me.columnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.popClassroom = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.newClassroomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.editClassroomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.deleteToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.refreshToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.sbrClassroom = New System.Windows.Forms.StatusBar()
        Me._panel_137 = New System.Windows.Forms.StatusBarPanel()
        Me.popSection = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.newSectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.editSectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.deleteToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.refreshToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.pgcSettings.SuspendLayout()
        Me.tabDirectory.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        CType(Me._panel_117, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._panel_118, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._panel_119, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabFaculty.SuspendLayout()
        Me.popFaculty.SuspendLayout()
        CType(Me._panel_123, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSubject.SuspendLayout()
        Me.popDepartment.SuspendLayout()
        CType(Me._panel_129, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._panel_130, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabClassroom.SuspendLayout()
        Me.popClassroom.SuspendLayout()
        CType(Me._panel_137, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popSection.SuspendLayout()
        Me.SuspendLayout()
        '
        'pgcSettings
        '
        Me.pgcSettings.Controls.Add(Me.tabDirectory)
        Me.pgcSettings.Controls.Add(Me.tabFaculty)
        Me.pgcSettings.Controls.Add(Me.tabSubject)
        Me.pgcSettings.Controls.Add(Me.tabClassroom)
        Me.pgcSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pgcSettings.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pgcSettings.Location = New System.Drawing.Point(0, 0)
        Me.pgcSettings.Name = "pgcSettings"
        Me.pgcSettings.SelectedIndex = 0
        Me.pgcSettings.Size = New System.Drawing.Size(924, 518)
        Me.pgcSettings.TabIndex = 1
        '
        'tabDirectory
        '
        Me.tabDirectory.Controls.Add(Me.SplitContainer1)
        Me.tabDirectory.Controls.Add(Me.treDirectory)
        Me.tabDirectory.Controls.Add(Me.sbrDirectory)
        Me.tabDirectory.ImageIndex = 6
        Me.tabDirectory.Location = New System.Drawing.Point(4, 23)
        Me.tabDirectory.Name = "tabDirectory"
        Me.tabDirectory.Size = New System.Drawing.Size(916, 491)
        Me.tabDirectory.TabIndex = 0
        Me.tabDirectory.Text = "Record Directory"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.tvDirectory)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ListView)
        Me.SplitContainer1.Size = New System.Drawing.Size(916, 472)
        Me.SplitContainer1.SplitterDistance = 229
        Me.SplitContainer1.TabIndex = 2
        '
        'tvDirectory
        '
        Me.tvDirectory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvDirectory.ImageIndex = 0
        Me.tvDirectory.ImageList = Me.TreeNodeImageList
        Me.tvDirectory.Location = New System.Drawing.Point(0, 0)
        Me.tvDirectory.Name = "tvDirectory"
        Me.tvDirectory.SelectedImageIndex = 0
        Me.tvDirectory.Size = New System.Drawing.Size(229, 472)
        Me.tvDirectory.TabIndex = 3
        '
        'TreeNodeImageList
        '
        Me.TreeNodeImageList.ImageStream = CType(resources.GetObject("TreeNodeImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.TreeNodeImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.TreeNodeImageList.Images.SetKeyName(0, "ClosedFolder")
        Me.TreeNodeImageList.Images.SetKeyName(1, "OpenFolder")
        '
        'ListView
        '
        Me.ListView.ContextMenuStrip = Me.ContextMenuStrip2
        Me.ListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView.LargeImageList = Me.ListViewLargeImageList
        Me.ListView.Location = New System.Drawing.Point(0, 0)
        Me.ListView.Name = "ListView"
        Me.ListView.ShowItemToolTips = True
        Me.ListView.Size = New System.Drawing.Size(683, 472)
        Me.ListView.SmallImageList = Me.ListViewSmallImageList
        Me.ListView.TabIndex = 0
        Me.ListView.UseCompatibleStateImageBehavior = False
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.ToolStripSeparator8, Me.ViewToolStripMenuItem1, Me.ToolStripSeparator10, Me.ArrangeIconsByToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripSeparator12, Me.PropertiesToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(169, 132)
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(165, 6)
        '
        'ViewToolStripMenuItem1
        '
        Me.ViewToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThumbnailsToolStripMenuItem, Me.TilesToolStripMenuItem, Me.IconsToolStripMenuItem, Me.ListToolStripMenuItem1, Me.DetailsToolStripMenuItem1})
        Me.ViewToolStripMenuItem1.Name = "ViewToolStripMenuItem1"
        Me.ViewToolStripMenuItem1.Size = New System.Drawing.Size(168, 22)
        Me.ViewToolStripMenuItem1.Text = "View"
        '
        'ThumbnailsToolStripMenuItem
        '
        Me.ThumbnailsToolStripMenuItem.Checked = True
        Me.ThumbnailsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ThumbnailsToolStripMenuItem.Name = "ThumbnailsToolStripMenuItem"
        Me.ThumbnailsToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.ThumbnailsToolStripMenuItem.Text = "Thumbnails"
        '
        'TilesToolStripMenuItem
        '
        Me.TilesToolStripMenuItem.Name = "TilesToolStripMenuItem"
        Me.TilesToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.TilesToolStripMenuItem.Text = "Tiles"
        '
        'IconsToolStripMenuItem
        '
        Me.IconsToolStripMenuItem.Name = "IconsToolStripMenuItem"
        Me.IconsToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.IconsToolStripMenuItem.Text = "Icons"
        '
        'ListToolStripMenuItem1
        '
        Me.ListToolStripMenuItem1.Name = "ListToolStripMenuItem1"
        Me.ListToolStripMenuItem1.Size = New System.Drawing.Size(138, 22)
        Me.ListToolStripMenuItem1.Text = "List"
        '
        'DetailsToolStripMenuItem1
        '
        Me.DetailsToolStripMenuItem1.Name = "DetailsToolStripMenuItem1"
        Me.DetailsToolStripMenuItem1.Size = New System.Drawing.Size(138, 22)
        Me.DetailsToolStripMenuItem1.Text = "Details"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(165, 6)
        '
        'ArrangeIconsByToolStripMenuItem
        '
        Me.ArrangeIconsByToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NameToolStripMenuItem, Me.SizeToolStripMenuItem, Me.TypeToolStripMenuItem, Me.ModifiedToolStripMenuItem, Me.ToolStripSeparator11, Me.ShowsInGroupsToolStripMenuItem, Me.AutoArrangeToolStripMenuItem, Me.AlignToGridToolStripMenuItem})
        Me.ArrangeIconsByToolStripMenuItem.Name = "ArrangeIconsByToolStripMenuItem"
        Me.ArrangeIconsByToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ArrangeIconsByToolStripMenuItem.Text = "Arrange Icons by"
        '
        'NameToolStripMenuItem
        '
        Me.NameToolStripMenuItem.Name = "NameToolStripMenuItem"
        Me.NameToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.NameToolStripMenuItem.Text = "Name"
        '
        'SizeToolStripMenuItem
        '
        Me.SizeToolStripMenuItem.Name = "SizeToolStripMenuItem"
        Me.SizeToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.SizeToolStripMenuItem.Text = "Size"
        '
        'TypeToolStripMenuItem
        '
        Me.TypeToolStripMenuItem.Name = "TypeToolStripMenuItem"
        Me.TypeToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.TypeToolStripMenuItem.Text = "Type"
        '
        'ModifiedToolStripMenuItem
        '
        Me.ModifiedToolStripMenuItem.Name = "ModifiedToolStripMenuItem"
        Me.ModifiedToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ModifiedToolStripMenuItem.Text = "Modified"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(161, 6)
        '
        'ShowsInGroupsToolStripMenuItem
        '
        Me.ShowsInGroupsToolStripMenuItem.Name = "ShowsInGroupsToolStripMenuItem"
        Me.ShowsInGroupsToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ShowsInGroupsToolStripMenuItem.Text = "Shows in Groups"
        '
        'AutoArrangeToolStripMenuItem
        '
        Me.AutoArrangeToolStripMenuItem.Name = "AutoArrangeToolStripMenuItem"
        Me.AutoArrangeToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.AutoArrangeToolStripMenuItem.Text = "Auto Arrange"
        '
        'AlignToGridToolStripMenuItem
        '
        Me.AlignToGridToolStripMenuItem.Name = "AlignToGridToolStripMenuItem"
        Me.AlignToGridToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.AlignToGridToolStripMenuItem.Text = "Align to Grid"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(168, 22)
        Me.ToolStripMenuItem1.Text = "Refresh"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(165, 6)
        '
        'PropertiesToolStripMenuItem
        '
        Me.PropertiesToolStripMenuItem.Name = "PropertiesToolStripMenuItem"
        Me.PropertiesToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.PropertiesToolStripMenuItem.Text = "Properties"
        '
        'ListViewLargeImageList
        '
        Me.ListViewLargeImageList.ImageStream = CType(resources.GetObject("ListViewLargeImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ListViewLargeImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ListViewLargeImageList.Images.SetKeyName(0, "Windows 7 (206).png")
        Me.ListViewLargeImageList.Images.SetKeyName(1, "0000 - Open Folder.ico")
        Me.ListViewLargeImageList.Images.SetKeyName(2, "0001 - Closed Folder.ico")
        Me.ListViewLargeImageList.Images.SetKeyName(3, "Windows 7 (78).png")
        '
        'ListViewSmallImageList
        '
        Me.ListViewSmallImageList.ImageStream = CType(resources.GetObject("ListViewSmallImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ListViewSmallImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ListViewSmallImageList.Images.SetKeyName(0, "Windows 7 (206).png")
        Me.ListViewSmallImageList.Images.SetKeyName(1, "0000 - Open Folder.ico")
        Me.ListViewSmallImageList.Images.SetKeyName(2, "0001 - Closed Folder.ico")
        Me.ListViewSmallImageList.Images.SetKeyName(3, "Windows 7 (87).png")
        '
        'treDirectory
        '
        Me.treDirectory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treDirectory.HideSelection = False
        Me.treDirectory.Indent = 19
        Me.treDirectory.Location = New System.Drawing.Point(0, 0)
        Me.treDirectory.Name = "treDirectory"
        Me.treDirectory.Size = New System.Drawing.Size(916, 472)
        Me.treDirectory.TabIndex = 0
        '
        'sbrDirectory
        '
        Me.sbrDirectory.Location = New System.Drawing.Point(0, 472)
        Me.sbrDirectory.Name = "sbrDirectory"
        Me.sbrDirectory.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me._panel_117, Me._panel_118, Me._panel_119})
        Me.sbrDirectory.ShowPanels = True
        Me.sbrDirectory.Size = New System.Drawing.Size(916, 19)
        Me.sbrDirectory.TabIndex = 1
        '
        '_panel_117
        '
        Me._panel_117.Name = "_panel_117"
        '
        '_panel_118
        '
        Me._panel_118.Name = "_panel_118"
        '
        '_panel_119
        '
        Me._panel_119.Name = "_panel_119"
        '
        'tabFaculty
        '
        Me.tabFaculty.Controls.Add(Me.lsvFaculty)
        Me.tabFaculty.Controls.Add(Me.sbrFaculty)
        Me.tabFaculty.ImageIndex = 2
        Me.tabFaculty.Location = New System.Drawing.Point(4, 23)
        Me.tabFaculty.Name = "tabFaculty"
        Me.tabFaculty.Size = New System.Drawing.Size(916, 491)
        Me.tabFaculty.TabIndex = 1
        Me.tabFaculty.Text = "Employee and Faculty"
        '
        'lsvFaculty
        '
        Me.lsvFaculty.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me._column_120, Me._column_121, Me._column_122})
        Me.lsvFaculty.ContextMenuStrip = Me.popFaculty
        Me.lsvFaculty.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsvFaculty.FullRowSelect = True
        Me.lsvFaculty.HideSelection = False
        Me.lsvFaculty.Location = New System.Drawing.Point(0, 0)
        Me.lsvFaculty.Name = "lsvFaculty"
        Me.lsvFaculty.Size = New System.Drawing.Size(916, 472)
        Me.lsvFaculty.TabIndex = 0
        Me.lsvFaculty.UseCompatibleStateImageBehavior = False
        Me.lsvFaculty.View = System.Windows.Forms.View.Details
        '
        '_column_120
        '
        Me._column_120.Name = "_column_120"
        Me._column_120.Text = "Full Name"
        Me._column_120.Width = 294
        '
        '_column_121
        '
        Me._column_121.Name = "_column_121"
        Me._column_121.Tag = 100
        Me._column_121.Text = "ID Number"
        Me._column_121.Width = 113
        '
        '_column_122
        '
        Me._column_122.Name = "_column_122"
        Me._column_122.Text = "Active"
        '
        'popFaculty
        '
        Me.popFaculty.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newFacultyToolStripMenuItem, Me.editFacultyToolStripMenuItem, Me.deleteToolStripMenuItem1, Me.toolStripSeparator4, Me.activateToolStripMenuItem, Me.toolStripSeparator5, Me.refreshToolStripMenuItem2})
        Me.popFaculty.Name = "popFaculty"
        Me.popFaculty.Size = New System.Drawing.Size(155, 126)
        '
        'newFacultyToolStripMenuItem
        '
        Me.newFacultyToolStripMenuItem.Name = "newFacultyToolStripMenuItem"
        Me.newFacultyToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.newFacultyToolStripMenuItem.Text = "New faculty..."
        '
        'editFacultyToolStripMenuItem
        '
        Me.editFacultyToolStripMenuItem.Name = "editFacultyToolStripMenuItem"
        Me.editFacultyToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.editFacultyToolStripMenuItem.Text = "Edit faculty..."
        '
        'deleteToolStripMenuItem1
        '
        Me.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1"
        Me.deleteToolStripMenuItem1.Size = New System.Drawing.Size(154, 22)
        Me.deleteToolStripMenuItem1.Text = "Delete"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(151, 6)
        '
        'activateToolStripMenuItem
        '
        Me.activateToolStripMenuItem.Name = "activateToolStripMenuItem"
        Me.activateToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.activateToolStripMenuItem.Text = "Activate"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(151, 6)
        '
        'refreshToolStripMenuItem2
        '
        Me.refreshToolStripMenuItem2.Name = "refreshToolStripMenuItem2"
        Me.refreshToolStripMenuItem2.Size = New System.Drawing.Size(154, 22)
        Me.refreshToolStripMenuItem2.Text = "Refresh"
        '
        'sbrFaculty
        '
        Me.sbrFaculty.Location = New System.Drawing.Point(0, 472)
        Me.sbrFaculty.Name = "sbrFaculty"
        Me.sbrFaculty.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me._panel_123})
        Me.sbrFaculty.ShowPanels = True
        Me.sbrFaculty.Size = New System.Drawing.Size(916, 19)
        Me.sbrFaculty.TabIndex = 1
        '
        '_panel_123
        '
        Me._panel_123.Name = "_panel_123"
        '
        'tabSubject
        '
        Me.tabSubject.Controls.Add(Me.lsvSubject)
        Me.tabSubject.Controls.Add(Me.lsvDepartment)
        Me.tabSubject.Controls.Add(Me.sbrSubject)
        Me.tabSubject.ImageIndex = 3
        Me.tabSubject.Location = New System.Drawing.Point(4, 23)
        Me.tabSubject.Name = "tabSubject"
        Me.tabSubject.Size = New System.Drawing.Size(916, 491)
        Me.tabSubject.TabIndex = 2
        Me.tabSubject.Text = "Subject Master List"
        '
        'lsvSubject
        '
        Me.lsvSubject.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader14, Me.columnHeader13, Me.columnHeader15, Me.columnHeader16})
        Me.lsvSubject.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsvSubject.FullRowSelect = True
        Me.lsvSubject.HideSelection = False
        Me.lsvSubject.Location = New System.Drawing.Point(292, 0)
        Me.lsvSubject.Name = "lsvSubject"
        Me.lsvSubject.Size = New System.Drawing.Size(624, 472)
        Me.lsvSubject.TabIndex = 1
        Me.lsvSubject.UseCompatibleStateImageBehavior = False
        Me.lsvSubject.View = System.Windows.Forms.View.Details
        '
        'columnHeader14
        '
        Me.columnHeader14.Text = "Subject"
        Me.columnHeader14.Width = 123
        '
        'columnHeader13
        '
        Me.columnHeader13.Text = "SubjectID"
        Me.columnHeader13.Width = 0
        '
        'columnHeader15
        '
        Me.columnHeader15.Text = "Descriptive Title"
        Me.columnHeader15.Width = 219
        '
        'columnHeader16
        '
        Me.columnHeader16.Text = "Units"
        '
        'lsvDepartment
        '
        Me.lsvDepartment.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me._column_128, Me.ColumnHeader1})
        Me.lsvDepartment.ContextMenuStrip = Me.popDepartment
        Me.lsvDepartment.Dock = System.Windows.Forms.DockStyle.Left
        Me.lsvDepartment.FullRowSelect = True
        Me.lsvDepartment.HideSelection = False
        Me.lsvDepartment.Location = New System.Drawing.Point(0, 0)
        Me.lsvDepartment.Name = "lsvDepartment"
        Me.lsvDepartment.Size = New System.Drawing.Size(292, 472)
        Me.lsvDepartment.TabIndex = 0
        Me.lsvDepartment.UseCompatibleStateImageBehavior = False
        Me.lsvDepartment.View = System.Windows.Forms.View.Details
        '
        '_column_128
        '
        Me._column_128.Name = "_column_128"
        Me._column_128.Text = "Department"
        Me._column_128.Width = 238
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 0
        '
        'popDepartment
        '
        Me.popDepartment.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewDepartmentToolStripMenuItem, Me.ModifyDepartmentToolStripMenuItem, Me.printSubjectsToolStripMenuItem, Me.toolStripSeparator1, Me.DeleteToolStripMenuItem4, Me.ToolStripSeparator7, Me.refreshToolStripMenuItem})
        Me.popDepartment.Name = "popDepartment"
        Me.popDepartment.Size = New System.Drawing.Size(190, 126)
        '
        'NewDepartmentToolStripMenuItem
        '
        Me.NewDepartmentToolStripMenuItem.Name = "NewDepartmentToolStripMenuItem"
        Me.NewDepartmentToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.NewDepartmentToolStripMenuItem.Text = "New Department..."
        '
        'ModifyDepartmentToolStripMenuItem
        '
        Me.ModifyDepartmentToolStripMenuItem.Name = "ModifyDepartmentToolStripMenuItem"
        Me.ModifyDepartmentToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.ModifyDepartmentToolStripMenuItem.Text = "Modify Department..."
        '
        'printSubjectsToolStripMenuItem
        '
        Me.printSubjectsToolStripMenuItem.Name = "printSubjectsToolStripMenuItem"
        Me.printSubjectsToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.printSubjectsToolStripMenuItem.Text = "Print subjects..."
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(186, 6)
        '
        'DeleteToolStripMenuItem4
        '
        Me.DeleteToolStripMenuItem4.Name = "DeleteToolStripMenuItem4"
        Me.DeleteToolStripMenuItem4.Size = New System.Drawing.Size(189, 22)
        Me.DeleteToolStripMenuItem4.Text = "Delete"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(186, 6)
        '
        'refreshToolStripMenuItem
        '
        Me.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem"
        Me.refreshToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.refreshToolStripMenuItem.Text = "Refresh"
        '
        'sbrSubject
        '
        Me.sbrSubject.Location = New System.Drawing.Point(0, 472)
        Me.sbrSubject.Name = "sbrSubject"
        Me.sbrSubject.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me._panel_129, Me._panel_130})
        Me.sbrSubject.ShowPanels = True
        Me.sbrSubject.Size = New System.Drawing.Size(916, 19)
        Me.sbrSubject.TabIndex = 2
        '
        '_panel_129
        '
        Me._panel_129.Name = "_panel_129"
        '
        '_panel_130
        '
        Me._panel_130.Name = "_panel_130"
        '
        'tabClassroom
        '
        Me.tabClassroom.Controls.Add(Me.lsvClassroom)
        Me.tabClassroom.Controls.Add(Me.sbrClassroom)
        Me.tabClassroom.ImageIndex = 5
        Me.tabClassroom.Location = New System.Drawing.Point(4, 23)
        Me.tabClassroom.Name = "tabClassroom"
        Me.tabClassroom.Size = New System.Drawing.Size(916, 491)
        Me.tabClassroom.TabIndex = 4
        Me.tabClassroom.Text = "Buildings and Rooms"
        '
        'lsvClassroom
        '
        Me.lsvClassroom.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader10, Me.columnHeader11, Me.columnHeader12})
        Me.lsvClassroom.ContextMenuStrip = Me.popClassroom
        Me.lsvClassroom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsvClassroom.FullRowSelect = True
        Me.lsvClassroom.HideSelection = False
        Me.lsvClassroom.Location = New System.Drawing.Point(0, 0)
        Me.lsvClassroom.Name = "lsvClassroom"
        Me.lsvClassroom.Size = New System.Drawing.Size(916, 472)
        Me.lsvClassroom.TabIndex = 0
        Me.lsvClassroom.UseCompatibleStateImageBehavior = False
        Me.lsvClassroom.View = System.Windows.Forms.View.Details
        '
        'columnHeader10
        '
        Me.columnHeader10.Text = "Building"
        Me.columnHeader10.Width = 286
        '
        'columnHeader11
        '
        Me.columnHeader11.Text = "Room No."
        Me.columnHeader11.Width = 120
        '
        'columnHeader12
        '
        Me.columnHeader12.Text = "Capacity"
        Me.columnHeader12.Width = 74
        '
        'popClassroom
        '
        Me.popClassroom.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newClassroomToolStripMenuItem, Me.editClassroomToolStripMenuItem, Me.deleteToolStripMenuItem2, Me.toolStripSeparator6, Me.refreshToolStripMenuItem3})
        Me.popClassroom.Name = "popClassroom"
        Me.popClassroom.Size = New System.Drawing.Size(169, 98)
        '
        'newClassroomToolStripMenuItem
        '
        Me.newClassroomToolStripMenuItem.Name = "newClassroomToolStripMenuItem"
        Me.newClassroomToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.newClassroomToolStripMenuItem.Text = "New classroom..."
        '
        'editClassroomToolStripMenuItem
        '
        Me.editClassroomToolStripMenuItem.Name = "editClassroomToolStripMenuItem"
        Me.editClassroomToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.editClassroomToolStripMenuItem.Text = "Edit classroom..."
        '
        'deleteToolStripMenuItem2
        '
        Me.deleteToolStripMenuItem2.Name = "deleteToolStripMenuItem2"
        Me.deleteToolStripMenuItem2.Size = New System.Drawing.Size(168, 22)
        Me.deleteToolStripMenuItem2.Text = "Delete"
        '
        'toolStripSeparator6
        '
        Me.toolStripSeparator6.Name = "toolStripSeparator6"
        Me.toolStripSeparator6.Size = New System.Drawing.Size(165, 6)
        '
        'refreshToolStripMenuItem3
        '
        Me.refreshToolStripMenuItem3.Name = "refreshToolStripMenuItem3"
        Me.refreshToolStripMenuItem3.Size = New System.Drawing.Size(168, 22)
        Me.refreshToolStripMenuItem3.Text = "Refresh"
        '
        'sbrClassroom
        '
        Me.sbrClassroom.Location = New System.Drawing.Point(0, 472)
        Me.sbrClassroom.Name = "sbrClassroom"
        Me.sbrClassroom.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me._panel_137})
        Me.sbrClassroom.ShowPanels = True
        Me.sbrClassroom.Size = New System.Drawing.Size(916, 19)
        Me.sbrClassroom.TabIndex = 1
        '
        '_panel_137
        '
        Me._panel_137.Name = "_panel_137"
        '
        'popSection
        '
        Me.popSection.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newSectionToolStripMenuItem, Me.editSectionToolStripMenuItem, Me.deleteToolStripMenuItem3, Me.toolStripSeparator9, Me.refreshToolStripMenuItem4})
        Me.popSection.Name = "popSection"
        Me.popSection.Size = New System.Drawing.Size(156, 98)
        '
        'newSectionToolStripMenuItem
        '
        Me.newSectionToolStripMenuItem.Name = "newSectionToolStripMenuItem"
        Me.newSectionToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.newSectionToolStripMenuItem.Text = "New section..."
        '
        'editSectionToolStripMenuItem
        '
        Me.editSectionToolStripMenuItem.Name = "editSectionToolStripMenuItem"
        Me.editSectionToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.editSectionToolStripMenuItem.Text = "Edit section..."
        '
        'deleteToolStripMenuItem3
        '
        Me.deleteToolStripMenuItem3.Name = "deleteToolStripMenuItem3"
        Me.deleteToolStripMenuItem3.Size = New System.Drawing.Size(155, 22)
        Me.deleteToolStripMenuItem3.Text = "Delete"
        '
        'toolStripSeparator9
        '
        Me.toolStripSeparator9.Name = "toolStripSeparator9"
        Me.toolStripSeparator9.Size = New System.Drawing.Size(152, 6)
        '
        'refreshToolStripMenuItem4
        '
        Me.refreshToolStripMenuItem4.Name = "refreshToolStripMenuItem4"
        Me.refreshToolStripMenuItem4.Size = New System.Drawing.Size(155, 22)
        Me.refreshToolStripMenuItem4.Text = "Refresh"
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 518)
        Me.Controls.Add(Me.pgcSettings)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Academic Manager"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pgcSettings.ResumeLayout(False)
        Me.tabDirectory.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        CType(Me._panel_117, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._panel_118, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._panel_119, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabFaculty.ResumeLayout(False)
        Me.popFaculty.ResumeLayout(False)
        CType(Me._panel_123, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSubject.ResumeLayout(False)
        Me.popDepartment.ResumeLayout(False)
        CType(Me._panel_129, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._panel_130, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabClassroom.ResumeLayout(False)
        Me.popClassroom.ResumeLayout(False)
        CType(Me._panel_137, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popSection.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public pgcSettings As System.Windows.Forms.TabControl
    Public tabDirectory As System.Windows.Forms.TabPage
    Public treDirectory As System.Windows.Forms.TreeView
    Public sbrDirectory As System.Windows.Forms.StatusBar
    Public _panel_117 As System.Windows.Forms.StatusBarPanel
    Public _panel_118 As System.Windows.Forms.StatusBarPanel
    Public _panel_119 As System.Windows.Forms.StatusBarPanel
    Public tabFaculty As System.Windows.Forms.TabPage
    Public lsvFaculty As System.Windows.Forms.ListView
    Public _column_120 As System.Windows.Forms.ColumnHeader
    Public _column_121 As System.Windows.Forms.ColumnHeader
    Public _column_122 As System.Windows.Forms.ColumnHeader
    Public sbrFaculty As System.Windows.Forms.StatusBar
    Public _panel_123 As System.Windows.Forms.StatusBarPanel
    Public tabSubject As System.Windows.Forms.TabPage
    Public lsvSubject As System.Windows.Forms.ListView
    Friend WithEvents lsvDepartment As System.Windows.Forms.ListView
    Public _column_128 As System.Windows.Forms.ColumnHeader
    Public sbrSubject As System.Windows.Forms.StatusBar
    Public _panel_129 As System.Windows.Forms.StatusBarPanel
    Public _panel_130 As System.Windows.Forms.StatusBarPanel
    Public tabClassroom As System.Windows.Forms.TabPage
    Public lsvClassroom As System.Windows.Forms.ListView
    Public sbrClassroom As System.Windows.Forms.StatusBar
    Public _panel_137 As System.Windows.Forms.StatusBarPanel
    Private popFaculty As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents newFacultyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents editFacultyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents deleteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Private toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents activateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents refreshToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Private popDepartment As System.Windows.Forms.ContextMenuStrip
    Private printSubjectsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents refreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private popClassroom As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents newClassroomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents editClassroomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents deleteToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Private toolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents refreshToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Private popSection As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents newSectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents editSectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents deleteToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Private toolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents refreshToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Private columnHeader10 As System.Windows.Forms.ColumnHeader
    Private columnHeader11 As System.Windows.Forms.ColumnHeader
    Private columnHeader12 As System.Windows.Forms.ColumnHeader
    Private columnHeader13 As System.Windows.Forms.ColumnHeader
    Private columnHeader14 As System.Windows.Forms.ColumnHeader
    Private columnHeader15 As System.Windows.Forms.ColumnHeader
    Private columnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents tvDirectory As System.Windows.Forms.TreeView
    Friend WithEvents ListView As System.Windows.Forms.ListView
    Friend WithEvents TreeNodeImageList As System.Windows.Forms.ImageList
    Friend WithEvents NewDepartmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifyDepartmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ViewToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThumbnailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IconsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DetailsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ArrangeIconsByToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifiedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ShowsInGroupsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AutoArrangeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlignToGridToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PropertiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListViewLargeImageList As System.Windows.Forms.ImageList
    Friend WithEvents ListViewSmallImageList As System.Windows.Forms.ImageList
End Class
