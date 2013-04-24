Partial Class frmAllSections
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAllSections))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.popClassSection = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddNewBlockSectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewFreeSectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditSectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadSectionWithSubjectsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.PropertiesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cboAY = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.cboCampus = New System.Windows.Forms.ToolStripComboBox()
        Me.cboCampusID = New System.Windows.Forms.ToolStripComboBox()
        Me.cboAYID = New System.Windows.Forms.ToolStripComboBox()
        Me.TabControl5 = New System.Windows.Forms.TabControl()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.lvSection = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader22 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TreeView = New System.Windows.Forms.TreeView()
        Me.popClassSection.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl5.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Procedure.ico")
        Me.ImageList1.Images.SetKeyName(1, "Folder.ico")
        Me.ImageList1.Images.SetKeyName(2, "322.ICO")
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 546)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1018, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'popClassSection
        '
        Me.popClassSection.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewBlockSectionToolStripMenuItem, Me.AddNewFreeSectionToolStripMenuItem, Me.ToolStripSeparator2, Me.EditSectionToolStripMenuItem, Me.LoadSectionWithSubjectsToolStripMenuItem, Me.ToolStripSeparator9, Me.PropertiesToolStripMenuItem1, Me.ToolStripSeparator5, Me.ToolStripMenuItem3, Me.ToolStripSeparator8, Me.ToolStripMenuItem4})
        Me.popClassSection.Name = "ContextMenuStrip4"
        Me.popClassSection.Size = New System.Drawing.Size(198, 182)
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
        Me.AddNewFreeSectionToolStripMenuItem.Name = "AddNewFreeSectionToolStripMenuItem"
        Me.AddNewFreeSectionToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.AddNewFreeSectionToolStripMenuItem.Text = "Add New Free Section"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(194, 6)
        '
        'EditSectionToolStripMenuItem
        '
        Me.EditSectionToolStripMenuItem.Image = CType(resources.GetObject("EditSectionToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EditSectionToolStripMenuItem.Name = "EditSectionToolStripMenuItem"
        Me.EditSectionToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.EditSectionToolStripMenuItem.Text = "Edit block section"
        '
        'LoadSectionWithSubjectsToolStripMenuItem
        '
        Me.LoadSectionWithSubjectsToolStripMenuItem.Image = CType(resources.GetObject("LoadSectionWithSubjectsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LoadSectionWithSubjectsToolStripMenuItem.Name = "LoadSectionWithSubjectsToolStripMenuItem"
        Me.LoadSectionWithSubjectsToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.LoadSectionWithSubjectsToolStripMenuItem.Text = "Delete "
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(194, 6)
        '
        'PropertiesToolStripMenuItem1
        '
        Me.PropertiesToolStripMenuItem1.Image = CType(resources.GetObject("PropertiesToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.PropertiesToolStripMenuItem1.Name = "PropertiesToolStripMenuItem1"
        Me.PropertiesToolStripMenuItem1.Size = New System.Drawing.Size(197, 22)
        Me.PropertiesToolStripMenuItem1.Text = "Properties..."
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(194, 6)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Image = CType(resources.GetObject("ToolStripMenuItem3.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(197, 22)
        Me.ToolStripMenuItem3.Text = "Print classlist"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(194, 6)
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Image = CType(resources.GetObject("ToolStripMenuItem4.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(197, 22)
        Me.ToolStripMenuItem4.Text = "Refresh"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboAY, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.cboCampus, Me.cboCampusID, Me.cboAYID})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1018, 25)
        Me.ToolStrip1.TabIndex = 32
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(145, 22)
        Me.ToolStripLabel1.Text = "Academic Year && Term:"
        '
        'cboAY
        '
        Me.cboAY.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboAY.Name = "cboAY"
        Me.cboAY.Size = New System.Drawing.Size(200, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(59, 22)
        Me.ToolStripLabel2.Text = "Campus:"
        '
        'cboCampus
        '
        Me.cboCampus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboCampus.Name = "cboCampus"
        Me.cboCampus.Size = New System.Drawing.Size(300, 25)
        '
        'cboCampusID
        '
        Me.cboCampusID.Name = "cboCampusID"
        Me.cboCampusID.Size = New System.Drawing.Size(75, 25)
        Me.cboCampusID.Visible = False
        '
        'cboAYID
        '
        Me.cboAYID.Name = "cboAYID"
        Me.cboAYID.Size = New System.Drawing.Size(75, 25)
        Me.cboAYID.Visible = False
        '
        'TabControl5
        '
        Me.TabControl5.Controls.Add(Me.TabPage7)
        Me.TabControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl5.Location = New System.Drawing.Point(261, 25)
        Me.TabControl5.Name = "TabControl5"
        Me.TabControl5.SelectedIndex = 0
        Me.TabControl5.Size = New System.Drawing.Size(757, 521)
        Me.TabControl5.TabIndex = 34
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.lvSection)
        Me.TabPage7.Location = New System.Drawing.Point(4, 23)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(749, 494)
        Me.TabPage7.TabIndex = 1
        Me.TabPage7.Text = "Block Sections"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'lvSection
        '
        Me.lvSection.AllowDrop = True
        Me.lvSection.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader2, Me.ColumnHeader15, Me.ColumnHeader20, Me.ColumnHeader21, Me.ColumnHeader19, Me.ColumnHeader22, Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lvSection.ContextMenuStrip = Me.popClassSection
        Me.lvSection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvSection.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvSection.FullRowSelect = True
        Me.lvSection.Location = New System.Drawing.Point(3, 3)
        Me.lvSection.MultiSelect = False
        Me.lvSection.Name = "lvSection"
        Me.lvSection.Size = New System.Drawing.Size(743, 488)
        Me.lvSection.TabIndex = 30
        Me.lvSection.UseCompatibleStateImageBehavior = False
        Me.lvSection.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Section"
        Me.ColumnHeader4.Width = 165
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Section ID"
        Me.ColumnHeader2.Width = 0
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Year Level"
        Me.ColumnHeader15.Width = 76
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "Slots"
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "Registered"
        Me.ColumnHeader21.Width = 97
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Validated"
        Me.ColumnHeader19.Width = 64
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "Class Adviser"
        Me.ColumnHeader22.Width = 229
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Rooms"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Block"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Dissolved"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Created By"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Created On"
        '
        'TreeView
        '
        Me.TreeView.Dock = System.Windows.Forms.DockStyle.Left
        Me.TreeView.ImageIndex = 1
        Me.TreeView.ImageList = Me.ImageList1
        Me.TreeView.Location = New System.Drawing.Point(0, 25)
        Me.TreeView.Name = "TreeView"
        Me.TreeView.SelectedImageIndex = 2
        Me.TreeView.Size = New System.Drawing.Size(261, 521)
        Me.TreeView.TabIndex = 33
        '
        'frmAllSections
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 568)
        Me.Controls.Add(Me.TabControl5)
        Me.Controls.Add(Me.TreeView)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "frmAllSections"
        Me.Text = "Class Sections Management"
        Me.popClassSection.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl5.ResumeLayout(False)
        Me.TabPage7.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents popClassSection As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditSectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadSectionWithSubjectsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PropertiesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents AddNewBlockSectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents TabControl5 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Private WithEvents lvSection As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TreeView As System.Windows.Forms.TreeView
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboAY As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboCampus As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents cboCampusID As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents cboAYID As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents AddNewFreeSectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator

#End Region

End Class
