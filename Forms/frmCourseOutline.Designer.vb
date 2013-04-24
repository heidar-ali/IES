<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCourseOutline
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCourseOutline))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboYearTerm = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSubjectCode = New System.Windows.Forms.TextBox()
        Me.cmdGetProgram = New System.Windows.Forms.Button()
        Me.txtDescriptive = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblLabUnit = New System.Windows.Forms.Label()
        Me.lblLecUnit = New System.Windows.Forms.Label()
        Me.lblCreditUnit = New System.Windows.Forms.Label()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgOutLine = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cmdNew = New System.Windows.Forms.ToolStripButton()
        Me.cmdSave = New System.Windows.Forms.ToolStripButton()
        Me.cmdDelete = New System.Windows.Forms.ToolStripButton()
        Me.cmdRefresh = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdClose = New System.Windows.Forms.ToolStripButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblSubjectCount = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblTotalCreditUnit = New System.Windows.Forms.Label()
        Me.lblTotalLecUnit = New System.Windows.Forms.Label()
        Me.lblTotalLabUnits = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblProgram = New System.Windows.Forms.Label()
        Me.cboTermID = New System.Windows.Forms.ComboBox()
        Me.txtSubjectID = New System.Windows.Forms.TextBox()
        Me.cboYearLevel = New System.Windows.Forms.ComboBox()
        CType(Me.dgOutLine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "COURSE OUTLINE:"
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.Silver
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 10
        Me.LineShape1.X2 = 450
        Me.LineShape1.Y1 = 66
        Me.LineShape1.Y2 = 66
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Year/ Term"
        '
        'cboYearTerm
        '
        Me.cboYearTerm.BackColor = System.Drawing.SystemColors.Info
        Me.cboYearTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYearTerm.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYearTerm.FormattingEnabled = True
        Me.cboYearTerm.Location = New System.Drawing.Point(100, 77)
        Me.cboYearTerm.Name = "cboYearTerm"
        Me.cboYearTerm.Size = New System.Drawing.Size(350, 22)
        Me.cboYearTerm.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 14)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Subject Code"
        '
        'txtSubjectCode
        '
        Me.txtSubjectCode.BackColor = System.Drawing.SystemColors.Info
        Me.txtSubjectCode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubjectCode.Location = New System.Drawing.Point(100, 108)
        Me.txtSubjectCode.Name = "txtSubjectCode"
        Me.txtSubjectCode.Size = New System.Drawing.Size(155, 22)
        Me.txtSubjectCode.TabIndex = 25
        '
        'cmdGetProgram
        '
        Me.cmdGetProgram.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGetProgram.Image = CType(resources.GetObject("cmdGetProgram.Image"), System.Drawing.Image)
        Me.cmdGetProgram.Location = New System.Drawing.Point(255, 107)
        Me.cmdGetProgram.Name = "cmdGetProgram"
        Me.cmdGetProgram.Size = New System.Drawing.Size(26, 24)
        Me.cmdGetProgram.TabIndex = 24
        Me.cmdGetProgram.UseVisualStyleBackColor = True
        '
        'txtDescriptive
        '
        Me.txtDescriptive.BackColor = System.Drawing.SystemColors.Info
        Me.txtDescriptive.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescriptive.Location = New System.Drawing.Point(100, 136)
        Me.txtDescriptive.Name = "txtDescriptive"
        Me.txtDescriptive.Size = New System.Drawing.Size(350, 22)
        Me.txtDescriptive.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(97, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Lab. Unit:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(199, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Lec. Unit:"
        '
        'lblLabUnit
        '
        Me.lblLabUnit.AutoSize = True
        Me.lblLabUnit.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabUnit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLabUnit.Location = New System.Drawing.Point(157, 171)
        Me.lblLabUnit.Name = "lblLabUnit"
        Me.lblLabUnit.Size = New System.Drawing.Size(15, 14)
        Me.lblLabUnit.TabIndex = 32
        Me.lblLabUnit.Text = "0"
        '
        'lblLecUnit
        '
        Me.lblLecUnit.AutoSize = True
        Me.lblLecUnit.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLecUnit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLecUnit.Location = New System.Drawing.Point(258, 171)
        Me.lblLecUnit.Name = "lblLecUnit"
        Me.lblLecUnit.Size = New System.Drawing.Size(15, 14)
        Me.lblLecUnit.TabIndex = 33
        Me.lblLecUnit.Text = "0"
        '
        'lblCreditUnit
        '
        Me.lblCreditUnit.AutoSize = True
        Me.lblCreditUnit.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreditUnit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCreditUnit.Location = New System.Drawing.Point(368, 171)
        Me.lblCreditUnit.Name = "lblCreditUnit"
        Me.lblCreditUnit.Size = New System.Drawing.Size(15, 14)
        Me.lblCreditUnit.TabIndex = 34
        Me.lblCreditUnit.Text = "0"
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer2.Size = New System.Drawing.Size(475, 527)
        Me.ShapeContainer2.TabIndex = 1
        Me.ShapeContainer2.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.Silver
        Me.LineShape2.BorderWidth = 2
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 11
        Me.LineShape2.X2 = 463
        Me.LineShape2.Y1 = 505
        Me.LineShape2.Y2 = 505
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(300, 171)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Credit Unit:"
        '
        'dgOutLine
        '
        Me.dgOutLine.AllowUserToAddRows = False
        Me.dgOutLine.AllowUserToDeleteRows = False
        Me.dgOutLine.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgOutLine.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgOutLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgOutLine.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgOutLine.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgOutLine.Location = New System.Drawing.Point(5, 188)
        Me.dgOutLine.Name = "dgOutLine"
        Me.dgOutLine.ReadOnly = True
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.dgOutLine.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgOutLine.Size = New System.Drawing.Size(467, 231)
        Me.dgOutLine.TabIndex = 36
        '
        'Column1
        '
        Me.Column1.HeaderText = "SUBJECT CODE"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 70
        '
        'Column2
        '
        Me.Column2.HeaderText = "DESCRIPTIVE TITLE"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 210
        '
        'Column3
        '
        Me.Column3.HeaderText = "LAB UNIT"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 47
        '
        'Column4
        '
        Me.Column4.HeaderText = "LEC UNIT"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 47
        '
        'Column5
        '
        Me.Column5.HeaderText = "CREDIT UNIT"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 47
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdNew, Me.cmdSave, Me.cmdDelete, Me.cmdRefresh, Me.toolStripSeparator, Me.cmdClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(475, 25)
        Me.ToolStrip1.TabIndex = 37
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cmdNew
        '
        Me.cmdNew.Image = CType(resources.GetObject("cmdNew.Image"), System.Drawing.Image)
        Me.cmdNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(51, 22)
        Me.cmdNew.Text = "&New"
        '
        'cmdSave
        '
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(51, 22)
        Me.cmdSave.Text = "&Save"
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = CType(resources.GetObject("cmdDelete.Image"), System.Drawing.Image)
        Me.cmdDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(60, 22)
        Me.cmdDelete.Text = "Delete"
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
        'cmdClose
        '
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(56, 22)
        Me.cmdClose.Text = "Close"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(8, 425)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(208, 26)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Assigning Pre-Requisite and Co-Requisite," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click ASSIGN"
        '
        'lblSubjectCount
        '
        Me.lblSubjectCount.AutoSize = True
        Me.lblSubjectCount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubjectCount.ForeColor = System.Drawing.Color.Black
        Me.lblSubjectCount.Location = New System.Drawing.Point(17, 478)
        Me.lblSubjectCount.Name = "lblSubjectCount"
        Me.lblSubjectCount.Size = New System.Drawing.Size(76, 13)
        Me.lblSubjectCount.TabIndex = 42
        Me.lblSubjectCount.Text = "0 Subject(s)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(376, 478)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Credit Unit:"
        '
        'lblTotalCreditUnit
        '
        Me.lblTotalCreditUnit.AutoSize = True
        Me.lblTotalCreditUnit.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCreditUnit.ForeColor = System.Drawing.Color.Black
        Me.lblTotalCreditUnit.Location = New System.Drawing.Point(440, 477)
        Me.lblTotalCreditUnit.Name = "lblTotalCreditUnit"
        Me.lblTotalCreditUnit.Size = New System.Drawing.Size(15, 14)
        Me.lblTotalCreditUnit.TabIndex = 47
        Me.lblTotalCreditUnit.Text = "0"
        '
        'lblTotalLecUnit
        '
        Me.lblTotalLecUnit.AutoSize = True
        Me.lblTotalLecUnit.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalLecUnit.ForeColor = System.Drawing.Color.Black
        Me.lblTotalLecUnit.Location = New System.Drawing.Point(350, 477)
        Me.lblTotalLecUnit.Name = "lblTotalLecUnit"
        Me.lblTotalLecUnit.Size = New System.Drawing.Size(15, 14)
        Me.lblTotalLecUnit.TabIndex = 46
        Me.lblTotalLecUnit.Text = "0"
        '
        'lblTotalLabUnits
        '
        Me.lblTotalLabUnits.AutoSize = True
        Me.lblTotalLabUnits.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalLabUnits.ForeColor = System.Drawing.Color.Black
        Me.lblTotalLabUnits.Location = New System.Drawing.Point(266, 478)
        Me.lblTotalLabUnits.Name = "lblTotalLabUnits"
        Me.lblTotalLabUnits.Size = New System.Drawing.Size(15, 14)
        Me.lblTotalLabUnits.TabIndex = 45
        Me.lblTotalLabUnits.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(291, 478)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 13)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "Lec. Unit:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(181, 478)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 13)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "Total Lab. Unit:"
        '
        'lblProgram
        '
        Me.lblProgram.AutoSize = True
        Me.lblProgram.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgram.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblProgram.Location = New System.Drawing.Point(137, 39)
        Me.lblProgram.Name = "lblProgram"
        Me.lblProgram.Size = New System.Drawing.Size(117, 16)
        Me.lblProgram.TabIndex = 49
        Me.lblProgram.Text = "COURSE OUTLINE:"
        '
        'cboTermID
        '
        Me.cboTermID.BackColor = System.Drawing.SystemColors.Info
        Me.cboTermID.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTermID.FormattingEnabled = True
        Me.cboTermID.Location = New System.Drawing.Point(353, 105)
        Me.cboTermID.Name = "cboTermID"
        Me.cboTermID.Size = New System.Drawing.Size(30, 22)
        Me.cboTermID.TabIndex = 50
        Me.cboTermID.Visible = False
        '
        'txtSubjectID
        '
        Me.txtSubjectID.BackColor = System.Drawing.SystemColors.Info
        Me.txtSubjectID.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubjectID.Location = New System.Drawing.Point(287, 105)
        Me.txtSubjectID.Name = "txtSubjectID"
        Me.txtSubjectID.Size = New System.Drawing.Size(39, 22)
        Me.txtSubjectID.TabIndex = 51
        Me.txtSubjectID.Visible = False
        '
        'cboYearLevel
        '
        Me.cboYearLevel.BackColor = System.Drawing.SystemColors.Info
        Me.cboYearLevel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYearLevel.FormattingEnabled = True
        Me.cboYearLevel.Location = New System.Drawing.Point(389, 105)
        Me.cboYearLevel.Name = "cboYearLevel"
        Me.cboYearLevel.Size = New System.Drawing.Size(29, 22)
        Me.cboYearLevel.TabIndex = 52
        Me.cboYearLevel.Visible = False
        '
        'frmCourseOutline
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 527)
        Me.Controls.Add(Me.cboYearLevel)
        Me.Controls.Add(Me.txtSubjectID)
        Me.Controls.Add(Me.cboTermID)
        Me.Controls.Add(Me.lblProgram)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblTotalCreditUnit)
        Me.Controls.Add(Me.lblTotalLecUnit)
        Me.Controls.Add(Me.lblTotalLabUnits)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblSubjectCount)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgOutLine)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblCreditUnit)
        Me.Controls.Add(Me.cboYearTerm)
        Me.Controls.Add(Me.lblLecUnit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblLabUnit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdGetProgram)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSubjectCode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDescriptive)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCourseOutline"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Course Outline | Prospectus"
        CType(Me.dgOutLine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboYearTerm As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents txtSubjectCode As System.Windows.Forms.TextBox
    Friend WithEvents cmdGetProgram As System.Windows.Forms.Button
    Friend WithEvents txtDescriptive As System.Windows.Forms.TextBox
    Friend WithEvents lblCreditUnit As System.Windows.Forms.Label
    Friend WithEvents lblLecUnit As System.Windows.Forms.Label
    Friend WithEvents lblLabUnit As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dgOutLine As System.Windows.Forms.DataGridView
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblSubjectCount As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblTotalCreditUnit As System.Windows.Forms.Label
    Friend WithEvents lblTotalLecUnit As System.Windows.Forms.Label
    Friend WithEvents lblTotalLabUnits As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblProgram As System.Windows.Forms.Label
    Friend WithEvents cboTermID As System.Windows.Forms.ComboBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtSubjectID As System.Windows.Forms.TextBox
    Friend WithEvents cboYearLevel As System.Windows.Forms.ComboBox
End Class
