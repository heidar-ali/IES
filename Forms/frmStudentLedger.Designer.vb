<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentLedger
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStudentLedger))
        Me.GridInfo = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.C1FlexGridClassic1 = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        CType(Me.GridInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1FlexGridClassic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridInfo
        '
        Me.GridInfo.CellButtonPicture = CType(resources.GetObject("GridInfo.CellButtonPicture"), System.Drawing.Image)
        Me.GridInfo.Cols = 2
        Me.GridInfo.ColumnInfo = "2,1,0,0,0,105,Columns:0{Width:147;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:331;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.GridInfo.Dock = System.Windows.Forms.DockStyle.Left
        Me.GridInfo.FixedRows = 0
        Me.GridInfo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridInfo.GridColorFixed = System.Drawing.SystemColors.ControlDark
        Me.GridInfo.Location = New System.Drawing.Point(2, 2)
        Me.GridInfo.MergeCells = C1.Win.C1FlexGrid.Classic.MergeSettings.flexMergeFree
        Me.GridInfo.Name = "GridInfo"
        Me.GridInfo.NodeClosedPicture = Nothing
        Me.GridInfo.NodeOpenPicture = Nothing
        Me.GridInfo.OutlineCol = -1
        Me.GridInfo.Rows = 5
        Me.GridInfo.Size = New System.Drawing.Size(486, 112)
        Me.GridInfo.StyleInfo = resources.GetString("GridInfo.StyleInfo")
        Me.GridInfo.TabIndex = 0
        Me.GridInfo.TreeColor = System.Drawing.Color.DarkGray
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Controls.Add(Me.GridInfo)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "VS2010"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1008, 116)
        Me.PanelControl1.TabIndex = 1
        '
        'GroupControl1
        '
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupControl1.Location = New System.Drawing.Point(488, 2)
        Me.GroupControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(358, 112)
        Me.GroupControl1.TabIndex = 1
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 708)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1008, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'C1FlexGridClassic1
        '
        Me.C1FlexGridClassic1.ColumnInfo = "10,1,0,0,0,95,Columns:"
        Me.C1FlexGridClassic1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1FlexGridClassic1.GridColorFixed = System.Drawing.SystemColors.ControlDark
        Me.C1FlexGridClassic1.Location = New System.Drawing.Point(0, 116)
        Me.C1FlexGridClassic1.Name = "C1FlexGridClassic1"
        Me.C1FlexGridClassic1.NodeClosedPicture = Nothing
        Me.C1FlexGridClassic1.NodeOpenPicture = Nothing
        Me.C1FlexGridClassic1.OutlineCol = -1
        Me.C1FlexGridClassic1.Size = New System.Drawing.Size(1008, 592)
        Me.C1FlexGridClassic1.TabIndex = 3
        Me.C1FlexGridClassic1.TreeColor = System.Drawing.Color.DarkGray
        '
        'frmStudentLedger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.C1FlexGridClassic1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmStudentLedger"
        Me.Text = "Student Ledger"
        CType(Me.GridInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1FlexGridClassic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridInfo As C1.Win.C1FlexGrid.Classic.C1FlexGridClassic
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents C1FlexGridClassic1 As C1.Win.C1FlexGrid.Classic.C1FlexGridClassic
End Class
