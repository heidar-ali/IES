Partial Class frmSubjectProperties
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSubjectProperties))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lvPrerequisite = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lvEquivalence = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lvOfferingHistory = New System.Windows.Forms.ListView()
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Grid = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 205)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(573, 331)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lvPrerequisite)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(565, 304)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Pre-Requisite/Co-Requisite"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lvPrerequisite
        '
        Me.lvPrerequisite.AllowDrop = True
        Me.lvPrerequisite.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader13})
        Me.lvPrerequisite.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvPrerequisite.FullRowSelect = True
        Me.lvPrerequisite.Location = New System.Drawing.Point(3, 3)
        Me.lvPrerequisite.Name = "lvPrerequisite"
        Me.lvPrerequisite.Size = New System.Drawing.Size(559, 298)
        Me.lvPrerequisite.TabIndex = 3
        Me.lvPrerequisite.UseCompatibleStateImageBehavior = False
        Me.lvPrerequisite.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Subject Code"
        Me.ColumnHeader5.Width = 168
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "ID"
        Me.ColumnHeader6.Width = 0
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Units"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Description"
        Me.ColumnHeader8.Width = 243
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Status"
        Me.ColumnHeader13.Width = 111
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.lvEquivalence)
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(565, 304)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Equivalence"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'lvEquivalence
        '
        Me.lvEquivalence.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvEquivalence.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvEquivalence.FullRowSelect = True
        Me.lvEquivalence.Location = New System.Drawing.Point(0, 0)
        Me.lvEquivalence.Name = "lvEquivalence"
        Me.lvEquivalence.Size = New System.Drawing.Size(565, 304)
        Me.lvEquivalence.TabIndex = 5
        Me.lvEquivalence.UseCompatibleStateImageBehavior = False
        Me.lvEquivalence.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Section "
        Me.ColumnHeader1.Width = 213
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "ID"
        Me.ColumnHeader2.Width = 0
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "School Year"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Department"
        Me.ColumnHeader4.Width = 211
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lvOfferingHistory)
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(565, 304)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Link Information"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lvOfferingHistory
        '
        Me.lvOfferingHistory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader19})
        Me.lvOfferingHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvOfferingHistory.FullRowSelect = True
        Me.lvOfferingHistory.Location = New System.Drawing.Point(3, 3)
        Me.lvOfferingHistory.Name = "lvOfferingHistory"
        Me.lvOfferingHistory.Size = New System.Drawing.Size(559, 298)
        Me.lvOfferingHistory.TabIndex = 4
        Me.lvOfferingHistory.UseCompatibleStateImageBehavior = False
        Me.lvOfferingHistory.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Curriculum Code"
        Me.ColumnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader15.Width = 129
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "College Code"
        Me.ColumnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader16.Width = 119
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "Program Code"
        Me.ColumnHeader17.Width = 104
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Major Studies"
        Me.ColumnHeader18.Width = 182
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Year & Term"
        Me.ColumnHeader19.Width = 145
        '
        'Grid
        '
        Me.Grid.Cols = 2
        Me.Grid.ColumnInfo = "2,1,0,0,0,100,Columns:0{Width:126;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:442;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Top
        Me.Grid.FixedRows = 0
        Me.Grid.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.GridColorFixed = System.Drawing.SystemColors.ControlDark
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.Name = "Grid"
        Me.Grid.NodeClosedPicture = Nothing
        Me.Grid.NodeOpenPicture = Nothing
        Me.Grid.OutlineCol = -1
        Me.Grid.Rows = 9
        Me.Grid.Size = New System.Drawing.Size(573, 205)
        Me.Grid.StyleInfo = resources.GetString("Grid.StyleInfo")
        Me.Grid.TabIndex = 3
        Me.Grid.TreeColor = System.Drawing.Color.DarkGray
        '
        'frmSubjectProperties
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 536)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Grid)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSubjectProperties"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SUBJECT PROPERTIES"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Grid As C1.Win.C1FlexGrid.Classic.C1FlexGridClassic
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents lvPrerequisite As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvOfferingHistory As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvEquivalence As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader

#End Region

End Class
