<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSchedReports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSchedReports))
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("List of Class Schedule by College")
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("List of Class Schedule")
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("List of Offered Course")
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("List of Faculty Loading")
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Inventory of Academic Program Curriculum")
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Inventory of Curriculums By Student")
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Inventory of Faculty Academic Load")
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Inventory of Faculty Academic Schedule")
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.cboFaculty = New MTGCComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboSubject = New MTGCComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdPickPrograms = New System.Windows.Forms.Button()
        Me.cmdPickCollege = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboCampus = New MTGCComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboTerm = New MTGCComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(558, 394)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(184, 31)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Image = CType(resources.GetObject("OK_Button.Image"), System.Drawing.Image)
        Me.OK_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(86, 25)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Preview"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Image = CType(resources.GetObject("Cancel_Button.Image"), System.Drawing.Image)
        Me.Cancel_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cancel_Button.Location = New System.Drawing.Point(95, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(86, 25)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.ListView1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(277, 432)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "List of Reports"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8})
        Me.ListView1.Location = New System.Drawing.Point(2, 18)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(273, 412)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Report Title"
        Me.ColumnHeader1.Width = 265
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "ID"
        Me.ColumnHeader2.Width = 0
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.cboFaculty)
        Me.GroupControl2.Controls.Add(Me.Label6)
        Me.GroupControl2.Controls.Add(Me.cboSubject)
        Me.GroupControl2.Controls.Add(Me.Label7)
        Me.GroupControl2.Controls.Add(Me.Label5)
        Me.GroupControl2.Controls.Add(Me.cmdPickPrograms)
        Me.GroupControl2.Controls.Add(Me.cmdPickCollege)
        Me.GroupControl2.Controls.Add(Me.Label4)
        Me.GroupControl2.Controls.Add(Me.TextBox2)
        Me.GroupControl2.Controls.Add(Me.TextBox1)
        Me.GroupControl2.Controls.Add(Me.CheckBox3)
        Me.GroupControl2.Controls.Add(Me.CheckBox2)
        Me.GroupControl2.Controls.Add(Me.CheckBox1)
        Me.GroupControl2.Controls.Add(Me.Label3)
        Me.GroupControl2.Controls.Add(Me.cboCampus)
        Me.GroupControl2.Controls.Add(Me.Label2)
        Me.GroupControl2.Controls.Add(Me.cboTerm)
        Me.GroupControl2.Controls.Add(Me.Label1)
        Me.GroupControl2.Location = New System.Drawing.Point(280, 1)
        Me.GroupControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.GroupControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(471, 383)
        Me.GroupControl2.TabIndex = 2
        Me.GroupControl2.Text = "Report Parameters"
        '
        'cboFaculty
        '
        Me.cboFaculty.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cboFaculty.ArrowColor = System.Drawing.Color.Black
        Me.cboFaculty.BindedControl = CType(resources.GetObject("cboFaculty.BindedControl"), MTGCComboBox.ControlloAssociato)
        Me.cboFaculty.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D
        Me.cboFaculty.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboFaculty.ColumnNum = 2
        Me.cboFaculty.ColumnWidth = "121;0"
        Me.cboFaculty.DisabledArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cboFaculty.DisabledArrowColor = System.Drawing.Color.LightGray
        Me.cboFaculty.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.cboFaculty.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder
        Me.cboFaculty.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.cboFaculty.DisplayMember = "Text"
        Me.cboFaculty.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboFaculty.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cboFaculty.DropDownForeColor = System.Drawing.Color.Black
        Me.cboFaculty.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.cboFaculty.DropDownWidth = 141
        Me.cboFaculty.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFaculty.GridLineColor = System.Drawing.Color.LightGray
        Me.cboFaculty.GridLineHorizontal = True
        Me.cboFaculty.GridLineVertical = True
        Me.cboFaculty.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.cboFaculty.Location = New System.Drawing.Point(157, 240)
        Me.cboFaculty.ManagingFastMouseMoving = True
        Me.cboFaculty.ManagingFastMouseMovingInterval = 30
        Me.cboFaculty.Name = "cboFaculty"
        Me.cboFaculty.SelectedItem = Nothing
        Me.cboFaculty.SelectedValue = Nothing
        Me.cboFaculty.Size = New System.Drawing.Size(293, 23)
        Me.cboFaculty.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 243)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 14)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Faculty Name:"
        '
        'cboSubject
        '
        Me.cboSubject.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cboSubject.ArrowColor = System.Drawing.Color.Black
        Me.cboSubject.BindedControl = CType(resources.GetObject("cboSubject.BindedControl"), MTGCComboBox.ControlloAssociato)
        Me.cboSubject.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D
        Me.cboSubject.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboSubject.ColumnNum = 2
        Me.cboSubject.ColumnWidth = "121;0"
        Me.cboSubject.DisabledArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cboSubject.DisabledArrowColor = System.Drawing.Color.LightGray
        Me.cboSubject.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.cboSubject.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder
        Me.cboSubject.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.cboSubject.DisplayMember = "Text"
        Me.cboSubject.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboSubject.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cboSubject.DropDownForeColor = System.Drawing.Color.Black
        Me.cboSubject.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.cboSubject.DropDownWidth = 141
        Me.cboSubject.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSubject.GridLineColor = System.Drawing.Color.LightGray
        Me.cboSubject.GridLineHorizontal = True
        Me.cboSubject.GridLineVertical = True
        Me.cboSubject.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.cboSubject.Location = New System.Drawing.Point(157, 209)
        Me.cboSubject.ManagingFastMouseMoving = True
        Me.cboSubject.ManagingFastMouseMovingInterval = 30
        Me.cboSubject.Name = "cboSubject"
        Me.cboSubject.SelectedItem = Nothing
        Me.cboSubject.SelectedValue = Nothing
        Me.cboSubject.Size = New System.Drawing.Size(293, 23)
        Me.cboSubject.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 14)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Subject"
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(461, 2)
        Me.Label5.TabIndex = 13
        '
        'cmdPickPrograms
        '
        Me.cmdPickPrograms.Image = CType(resources.GetObject("cmdPickPrograms.Image"), System.Drawing.Image)
        Me.cmdPickPrograms.Location = New System.Drawing.Point(431, 154)
        Me.cmdPickPrograms.Name = "cmdPickPrograms"
        Me.cmdPickPrograms.Size = New System.Drawing.Size(25, 24)
        Me.cmdPickPrograms.TabIndex = 12
        Me.cmdPickPrograms.UseVisualStyleBackColor = True
        '
        'cmdPickCollege
        '
        Me.cmdPickCollege.Image = CType(resources.GetObject("cmdPickCollege.Image"), System.Drawing.Image)
        Me.cmdPickCollege.Location = New System.Drawing.Point(431, 127)
        Me.cmdPickCollege.Name = "cmdPickCollege"
        Me.cmdPickCollege.Size = New System.Drawing.Size(25, 24)
        Me.cmdPickCollege.TabIndex = 11
        Me.cmdPickCollege.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(154, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(203, 14)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "All Colleges and Academic Programs"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(157, 156)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(273, 22)
        Me.TextBox2.TabIndex = 9
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(157, 128)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(273, 22)
        Me.TextBox1.TabIndex = 8
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.Location = New System.Drawing.Point(21, 158)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(97, 18)
        Me.CheckBox3.TabIndex = 7
        Me.CheckBox3.Text = "By Programs:"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(21, 130)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(86, 18)
        Me.CheckBox2.TabIndex = 6
        Me.CheckBox2.Text = "By College:"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CheckBox1.Location = New System.Drawing.Point(21, 108)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(82, 18)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "All Groups"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(461, 2)
        Me.Label3.TabIndex = 4
        '
        'cboCampus
        '
        Me.cboCampus.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cboCampus.ArrowColor = System.Drawing.Color.Black
        Me.cboCampus.BindedControl = CType(resources.GetObject("cboCampus.BindedControl"), MTGCComboBox.ControlloAssociato)
        Me.cboCampus.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D
        Me.cboCampus.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboCampus.ColumnNum = 2
        Me.cboCampus.ColumnWidth = "121;0"
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
        Me.cboCampus.DropDownWidth = 141
        Me.cboCampus.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCampus.GridLineColor = System.Drawing.Color.LightGray
        Me.cboCampus.GridLineHorizontal = True
        Me.cboCampus.GridLineVertical = True
        Me.cboCampus.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.cboCampus.Location = New System.Drawing.Point(157, 61)
        Me.cboCampus.ManagingFastMouseMoving = True
        Me.cboCampus.ManagingFastMouseMovingInterval = 30
        Me.cboCampus.Name = "cboCampus"
        Me.cboCampus.SelectedItem = Nothing
        Me.cboCampus.SelectedValue = Nothing
        Me.cboCampus.Size = New System.Drawing.Size(293, 23)
        Me.cboCampus.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Campus"
        '
        'cboTerm
        '
        Me.cboTerm.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cboTerm.ArrowColor = System.Drawing.Color.Black
        Me.cboTerm.BindedControl = CType(resources.GetObject("cboTerm.BindedControl"), MTGCComboBox.ControlloAssociato)
        Me.cboTerm.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D
        Me.cboTerm.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboTerm.ColumnNum = 2
        Me.cboTerm.ColumnWidth = "121;0"
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
        Me.cboTerm.DropDownWidth = 141
        Me.cboTerm.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTerm.GridLineColor = System.Drawing.Color.LightGray
        Me.cboTerm.GridLineHorizontal = True
        Me.cboTerm.GridLineVertical = True
        Me.cboTerm.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.cboTerm.Location = New System.Drawing.Point(157, 30)
        Me.cboTerm.ManagingFastMouseMoving = True
        Me.cboTerm.ManagingFastMouseMovingInterval = 30
        Me.cboTerm.Name = "cboTerm"
        Me.cboTerm.SelectedItem = Nothing
        Me.cboTerm.SelectedValue = Nothing
        Me.cboTerm.Size = New System.Drawing.Size(293, 23)
        Me.cboTerm.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Academic Year && Term"
        '
        'frmListOfReports
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(754, 432)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmListOfReports"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "List Of Reports"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboCampus As MTGCComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboTerm As MTGCComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdPickPrograms As System.Windows.Forms.Button
    Friend WithEvents cmdPickCollege As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents cboFaculty As MTGCComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboSubject As MTGCComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
