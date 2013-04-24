<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddSection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddSection))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.txtSectionID = New System.Windows.Forms.TextBox()
        Me.cmdGetItem = New System.Windows.Forms.Button()
        Me.txtAcademicProgram = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.txtSectionFullTitle = New System.Windows.Forms.TextBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdGetTeacher = New System.Windows.Forms.Button()
        Me.txtTeacherFullName = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cboRoom = New MTGCComboBox()
        Me.cboBuilding = New MTGCComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboCampus = New MTGCComboBox()
        Me.cboTerm = New MTGCComboBox()
        Me.txtCurriculumCode = New System.Windows.Forms.TextBox()
        Me.txtYearTermID = New System.Windows.Forms.TextBox()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lvCurriculum = New System.Windows.Forms.ListView()
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lvYearTerm = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.listAvailableSubjects = New System.Windows.Forms.ListView()
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblSubjectCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.miniToolStrip = New System.Windows.Forms.StatusStrip()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(751, 6)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(180, 38)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(84, 32)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Save"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel_Button.Location = New System.Drawing.Point(95, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(79, 31)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'txtSectionID
        '
        Me.txtSectionID.BackColor = System.Drawing.SystemColors.Info
        Me.txtSectionID.Location = New System.Drawing.Point(901, 64)
        Me.txtSectionID.Name = "txtSectionID"
        Me.txtSectionID.ReadOnly = True
        Me.txtSectionID.Size = New System.Drawing.Size(12, 20)
        Me.txtSectionID.TabIndex = 18
        '
        'cmdGetItem
        '
        Me.cmdGetItem.Image = CType(resources.GetObject("cmdGetItem.Image"), System.Drawing.Image)
        Me.cmdGetItem.Location = New System.Drawing.Point(427, 59)
        Me.cmdGetItem.Name = "cmdGetItem"
        Me.cmdGetItem.Size = New System.Drawing.Size(25, 23)
        Me.cmdGetItem.TabIndex = 67
        Me.cmdGetItem.UseVisualStyleBackColor = True
        '
        'txtAcademicProgram
        '
        Me.txtAcademicProgram.BackColor = System.Drawing.SystemColors.Info
        Me.txtAcademicProgram.Location = New System.Drawing.Point(167, 61)
        Me.txtAcademicProgram.Name = "txtAcademicProgram"
        Me.txtAcademicProgram.Size = New System.Drawing.Size(260, 20)
        Me.txtAcademicProgram.TabIndex = 66
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(49, 63)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(112, 14)
        Me.label6.TabIndex = 69
        Me.label6.Text = "Academic Program:"
        '
        'txtSectionFullTitle
        '
        Me.txtSectionFullTitle.Location = New System.Drawing.Point(167, 87)
        Me.txtSectionFullTitle.Name = "txtSectionFullTitle"
        Me.txtSectionFullTitle.Size = New System.Drawing.Size(152, 20)
        Me.txtSectionFullTitle.TabIndex = 71
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.Location = New System.Drawing.Point(81, 89)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(80, 14)
        Me.label10.TabIndex = 70
        Me.label10.Text = "Section Title:"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(325, 89)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(112, 14)
        Me.LinkLabel1.TabIndex = 72
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Modification History"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 14)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Academic Year and Term:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 607)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(943, 50)
        Me.GroupBox1.TabIndex = 76
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(471, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 14)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Room:"
        '
        'cmdGetTeacher
        '
        Me.cmdGetTeacher.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGetTeacher.Image = CType(resources.GetObject("cmdGetTeacher.Image"), System.Drawing.Image)
        Me.cmdGetTeacher.Location = New System.Drawing.Point(781, 7)
        Me.cmdGetTeacher.Name = "cmdGetTeacher"
        Me.cmdGetTeacher.Size = New System.Drawing.Size(25, 23)
        Me.cmdGetTeacher.TabIndex = 83
        Me.cmdGetTeacher.UseVisualStyleBackColor = True
        '
        'txtTeacherFullName
        '
        Me.txtTeacherFullName.BackColor = System.Drawing.SystemColors.Info
        Me.txtTeacherFullName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTeacherFullName.Location = New System.Drawing.Point(519, 8)
        Me.txtTeacherFullName.Name = "txtTeacherFullName"
        Me.txtTeacherFullName.Size = New System.Drawing.Size(260, 22)
        Me.txtTeacherFullName.TabIndex = 82
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.Location = New System.Drawing.Point(463, 11)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(50, 14)
        Me.label8.TabIndex = 81
        Me.label8.Text = "Adviser:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cboRoom)
        Me.Panel1.Controls.Add(Me.cboBuilding)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cboCampus)
        Me.Panel1.Controls.Add(Me.cboTerm)
        Me.Panel1.Controls.Add(Me.txtCurriculumCode)
        Me.Panel1.Controls.Add(Me.txtYearTermID)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.txtSectionID)
        Me.Panel1.Controls.Add(Me.txtAcademicProgram)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cmdGetItem)
        Me.Panel1.Controls.Add(Me.cmdGetTeacher)
        Me.Panel1.Controls.Add(Me.label6)
        Me.Panel1.Controls.Add(Me.txtTeacherFullName)
        Me.Panel1.Controls.Add(Me.label10)
        Me.Panel1.Controls.Add(Me.label8)
        Me.Panel1.Controls.Add(Me.txtSectionFullTitle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(943, 118)
        Me.Panel1.TabIndex = 87
        '
        'cboRoom
        '
        Me.cboRoom.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cboRoom.ArrowColor = System.Drawing.Color.Black
        Me.cboRoom.BindedControl = CType(resources.GetObject("cboRoom.BindedControl"), MTGCComboBox.ControlloAssociato)
        Me.cboRoom.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D
        Me.cboRoom.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboRoom.ColumnNum = 2
        Me.cboRoom.ColumnWidth = "260;0"
        Me.cboRoom.DisabledArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cboRoom.DisabledArrowColor = System.Drawing.Color.LightGray
        Me.cboRoom.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.cboRoom.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder
        Me.cboRoom.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.cboRoom.DisplayMember = "Text"
        Me.cboRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboRoom.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cboRoom.DropDownForeColor = System.Drawing.Color.Black
        Me.cboRoom.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.cboRoom.DropDownWidth = 280
        Me.cboRoom.GridLineColor = System.Drawing.Color.LightGray
        Me.cboRoom.GridLineHorizontal = False
        Me.cboRoom.GridLineVertical = False
        Me.cboRoom.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.cboRoom.Location = New System.Drawing.Point(519, 59)
        Me.cboRoom.ManagingFastMouseMoving = True
        Me.cboRoom.ManagingFastMouseMovingInterval = 30
        Me.cboRoom.Name = "cboRoom"
        Me.cboRoom.SelectedItem = Nothing
        Me.cboRoom.SelectedValue = Nothing
        Me.cboRoom.Size = New System.Drawing.Size(260, 21)
        Me.cboRoom.TabIndex = 94
        '
        'cboBuilding
        '
        Me.cboBuilding.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cboBuilding.ArrowColor = System.Drawing.Color.Black
        Me.cboBuilding.BindedControl = CType(resources.GetObject("cboBuilding.BindedControl"), MTGCComboBox.ControlloAssociato)
        Me.cboBuilding.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D
        Me.cboBuilding.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboBuilding.ColumnNum = 2
        Me.cboBuilding.ColumnWidth = "260;0"
        Me.cboBuilding.DisabledArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cboBuilding.DisabledArrowColor = System.Drawing.Color.LightGray
        Me.cboBuilding.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.cboBuilding.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder
        Me.cboBuilding.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.cboBuilding.DisplayMember = "Text"
        Me.cboBuilding.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboBuilding.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cboBuilding.DropDownForeColor = System.Drawing.Color.Black
        Me.cboBuilding.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.cboBuilding.DropDownWidth = 280
        Me.cboBuilding.GridLineColor = System.Drawing.Color.LightGray
        Me.cboBuilding.GridLineHorizontal = False
        Me.cboBuilding.GridLineVertical = False
        Me.cboBuilding.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.cboBuilding.Location = New System.Drawing.Point(519, 33)
        Me.cboBuilding.ManagingFastMouseMoving = True
        Me.cboBuilding.ManagingFastMouseMovingInterval = 30
        Me.cboBuilding.Name = "cboBuilding"
        Me.cboBuilding.SelectedItem = Nothing
        Me.cboBuilding.SelectedValue = Nothing
        Me.cboBuilding.Size = New System.Drawing.Size(260, 21)
        Me.cboBuilding.TabIndex = 93
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(461, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 14)
        Me.Label5.TabIndex = 92
        Me.Label5.Text = "Building:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(108, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 14)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "Campus:"
        '
        'cboCampus
        '
        Me.cboCampus.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cboCampus.ArrowColor = System.Drawing.Color.Black
        Me.cboCampus.BindedControl = CType(resources.GetObject("cboCampus.BindedControl"), MTGCComboBox.ControlloAssociato)
        Me.cboCampus.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D
        Me.cboCampus.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboCampus.ColumnNum = 2
        Me.cboCampus.ColumnWidth = "260;0"
        Me.cboCampus.DisabledArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cboCampus.DisabledArrowColor = System.Drawing.Color.LightGray
        Me.cboCampus.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.cboCampus.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder
        Me.cboCampus.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.cboCampus.DisplayMember = "Text"
        Me.cboCampus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboCampus.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cboCampus.DropDownForeColor = System.Drawing.Color.Black
        Me.cboCampus.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.cboCampus.DropDownWidth = 280
        Me.cboCampus.GridLineColor = System.Drawing.Color.LightGray
        Me.cboCampus.GridLineHorizontal = False
        Me.cboCampus.GridLineVertical = False
        Me.cboCampus.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.cboCampus.Location = New System.Drawing.Point(167, 34)
        Me.cboCampus.ManagingFastMouseMoving = True
        Me.cboCampus.ManagingFastMouseMovingInterval = 30
        Me.cboCampus.Name = "cboCampus"
        Me.cboCampus.SelectedItem = Nothing
        Me.cboCampus.SelectedValue = Nothing
        Me.cboCampus.Size = New System.Drawing.Size(260, 21)
        Me.cboCampus.TabIndex = 90
        '
        'cboTerm
        '
        Me.cboTerm.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cboTerm.ArrowColor = System.Drawing.Color.Black
        Me.cboTerm.BindedControl = CType(resources.GetObject("cboTerm.BindedControl"), MTGCComboBox.ControlloAssociato)
        Me.cboTerm.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D
        Me.cboTerm.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboTerm.ColumnNum = 2
        Me.cboTerm.ColumnWidth = "200;0"
        Me.cboTerm.DisabledArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cboTerm.DisabledArrowColor = System.Drawing.Color.LightGray
        Me.cboTerm.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.cboTerm.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder
        Me.cboTerm.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.cboTerm.DisplayMember = "Text"
        Me.cboTerm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboTerm.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cboTerm.DropDownForeColor = System.Drawing.Color.Black
        Me.cboTerm.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.cboTerm.DropDownWidth = 220
        Me.cboTerm.GridLineColor = System.Drawing.Color.LightGray
        Me.cboTerm.GridLineHorizontal = False
        Me.cboTerm.GridLineVertical = False
        Me.cboTerm.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.cboTerm.Location = New System.Drawing.Point(167, 8)
        Me.cboTerm.ManagingFastMouseMoving = True
        Me.cboTerm.ManagingFastMouseMovingInterval = 30
        Me.cboTerm.Name = "cboTerm"
        Me.cboTerm.SelectedItem = Nothing
        Me.cboTerm.SelectedValue = Nothing
        Me.cboTerm.Size = New System.Drawing.Size(260, 21)
        Me.cboTerm.TabIndex = 89
        '
        'txtCurriculumCode
        '
        Me.txtCurriculumCode.BackColor = System.Drawing.SystemColors.Info
        Me.txtCurriculumCode.Location = New System.Drawing.Point(883, 89)
        Me.txtCurriculumCode.Name = "txtCurriculumCode"
        Me.txtCurriculumCode.ReadOnly = True
        Me.txtCurriculumCode.Size = New System.Drawing.Size(12, 20)
        Me.txtCurriculumCode.TabIndex = 88
        '
        'txtYearTermID
        '
        Me.txtYearTermID.BackColor = System.Drawing.SystemColors.Info
        Me.txtYearTermID.Location = New System.Drawing.Point(883, 62)
        Me.txtYearTermID.Name = "txtYearTermID"
        Me.txtYearTermID.ReadOnly = True
        Me.txtYearTermID.Size = New System.Drawing.Size(12, 20)
        Me.txtYearTermID.TabIndex = 87
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage1)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.TabControl2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl2.Location = New System.Drawing.Point(0, 118)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(642, 245)
        Me.TabControl2.TabIndex = 88
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lvCurriculum)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(634, 218)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "List of Curriculums Under this Course"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lvCurriculum
        '
        Me.lvCurriculum.AllowDrop = True
        Me.lvCurriculum.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader14, Me.ColumnHeader11, Me.ColumnHeader15, Me.ColumnHeader17})
        Me.lvCurriculum.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvCurriculum.FullRowSelect = True
        Me.lvCurriculum.Location = New System.Drawing.Point(3, 3)
        Me.lvCurriculum.MultiSelect = False
        Me.lvCurriculum.Name = "lvCurriculum"
        Me.lvCurriculum.Size = New System.Drawing.Size(628, 212)
        Me.lvCurriculum.TabIndex = 8
        Me.lvCurriculum.UseCompatibleStateImageBehavior = False
        Me.lvCurriculum.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "CURRICULUM CODE"
        Me.ColumnHeader14.Width = 145
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "ID"
        Me.ColumnHeader11.Width = 0
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "ACADEMIC PROGRAM"
        Me.ColumnHeader15.Width = 302
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "MAJOR STUDY"
        Me.ColumnHeader17.Width = 173
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabPage2)
        Me.TabControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl3.Location = New System.Drawing.Point(642, 118)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(301, 245)
        Me.TabControl3.TabIndex = 90
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lvYearTerm)
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(293, 218)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Year Term Description"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lvYearTerm
        '
        Me.lvYearTerm.AllowDrop = True
        Me.lvYearTerm.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader8})
        Me.lvYearTerm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvYearTerm.FullRowSelect = True
        Me.lvYearTerm.Location = New System.Drawing.Point(3, 3)
        Me.lvYearTerm.MultiSelect = False
        Me.lvYearTerm.Name = "lvYearTerm"
        Me.lvYearTerm.Size = New System.Drawing.Size(287, 212)
        Me.lvYearTerm.TabIndex = 8
        Me.lvYearTerm.UseCompatibleStateImageBehavior = False
        Me.lvYearTerm.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Year Term"
        Me.ColumnHeader2.Width = 277
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "ID"
        Me.ColumnHeader8.Width = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.listAvailableSubjects)
        Me.TabPage3.Controls.Add(Me.StatusStrip1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(935, 217)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "List of Subjects for this curriculum"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'listAvailableSubjects
        '
        Me.listAvailableSubjects.AllowDrop = True
        Me.listAvailableSubjects.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader16, Me.ColumnHeader4, Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.listAvailableSubjects.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listAvailableSubjects.FullRowSelect = True
        Me.listAvailableSubjects.Location = New System.Drawing.Point(3, 3)
        Me.listAvailableSubjects.MultiSelect = False
        Me.listAvailableSubjects.Name = "listAvailableSubjects"
        Me.listAvailableSubjects.Size = New System.Drawing.Size(929, 189)
        Me.listAvailableSubjects.TabIndex = 8
        Me.listAvailableSubjects.UseCompatibleStateImageBehavior = False
        Me.listAvailableSubjects.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Subject Code"
        Me.ColumnHeader16.Width = 135
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Subject ID"
        Me.ColumnHeader4.Width = 0
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Descriptive Title"
        Me.ColumnHeader1.Width = 342
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Credit Units"
        Me.ColumnHeader3.Width = 81
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Lecture Hrs."
        Me.ColumnHeader5.Width = 89
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Lab Units"
        Me.ColumnHeader6.Width = 74
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Lab Hrs."
        Me.ColumnHeader7.Width = 62
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Min. Size"
        Me.ColumnHeader9.Width = 63
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Max. Size"
        Me.ColumnHeader10.Width = 67
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblSubjectCount})
        Me.StatusStrip1.Location = New System.Drawing.Point(3, 192)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(929, 22)
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
        'miniToolStrip
        '
        Me.miniToolStrip.AutoSize = False
        Me.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.miniToolStrip.Location = New System.Drawing.Point(136, 1)
        Me.miniToolStrip.Name = "miniToolStrip"
        Me.miniToolStrip.Size = New System.Drawing.Size(834, 22)
        Me.miniToolStrip.TabIndex = 7
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 363)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(943, 244)
        Me.TabControl1.TabIndex = 77
        '
        'frmAddSection
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(943, 657)
        Me.Controls.Add(Me.TabControl3)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddSection"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "New Block Section Entry"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Private WithEvents txtSectionID As System.Windows.Forms.TextBox
    Friend WithEvents cmdGetItem As System.Windows.Forms.Button
    Public WithEvents txtAcademicProgram As System.Windows.Forms.TextBox
    Private WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents txtSectionFullTitle As System.Windows.Forms.TextBox
    Private WithEvents label10 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdGetTeacher As System.Windows.Forms.Button
    Public WithEvents txtTeacherFullName As System.Windows.Forms.TextBox
    Private WithEvents label8 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents lvCurriculum As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Private WithEvents txtCurriculumCode As System.Windows.Forms.TextBox
    Private WithEvents txtYearTermID As System.Windows.Forms.TextBox
    Friend WithEvents TabControl3 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Public WithEvents lvYearTerm As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cboTerm As MTGCComboBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboCampus As MTGCComboBox
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cboRoom As MTGCComboBox
    Friend WithEvents cboBuilding As MTGCComboBox
    Private WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Public WithEvents listAvailableSubjects As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblSubjectCount As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents miniToolStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl

End Class
