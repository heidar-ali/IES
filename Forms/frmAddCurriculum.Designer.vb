<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddCurriculum
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddCurriculum))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.txtCurriculumCode = New System.Windows.Forms.TextBox()
        Me.cmdGetProgram = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkLocked = New System.Windows.Forms.CheckBox()
        Me.txtProgram = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTerm = New System.Windows.Forms.Label()
        Me.lblYears = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblTotalYears = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboCampus = New MTGCComboBox()
        Me.cboMajor = New System.Windows.Forms.ComboBox()
        Me.cboMajorID = New System.Windows.Forms.ComboBox()
        Me.cboCampus1 = New System.Windows.Forms.ComboBox()
        Me.cboCampusID = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.cmdSave, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(275, 323)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(170, 31)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdSave.Location = New System.Drawing.Point(3, 3)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(78, 25)
        Me.cmdSave.TabIndex = 0
        Me.cmdSave.Text = "&Save"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(88, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(78, 25)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'txtCurriculumCode
        '
        Me.txtCurriculumCode.BackColor = System.Drawing.SystemColors.Info
        Me.txtCurriculumCode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurriculumCode.Location = New System.Drawing.Point(129, 156)
        Me.txtCurriculumCode.Name = "txtCurriculumCode"
        Me.txtCurriculumCode.Size = New System.Drawing.Size(317, 22)
        Me.txtCurriculumCode.TabIndex = 15
        '
        'cmdGetProgram
        '
        Me.cmdGetProgram.Image = CType(resources.GetObject("cmdGetProgram.Image"), System.Drawing.Image)
        Me.cmdGetProgram.Location = New System.Drawing.Point(417, 39)
        Me.cmdGetProgram.Name = "cmdGetProgram"
        Me.cmdGetProgram.Size = New System.Drawing.Size(26, 23)
        Me.cmdGetProgram.TabIndex = 16
        Me.cmdGetProgram.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 14)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Curriculum Code" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.SystemColors.Info
        Me.txtDescription.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(129, 184)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(317, 22)
        Me.txtDescription.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 14)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Description"
        '
        'txtNote
        '
        Me.txtNote.BackColor = System.Drawing.Color.White
        Me.txtNote.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNote.Location = New System.Drawing.Point(128, 212)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(318, 53)
        Me.txtNote.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 14)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Note"
        '
        'chkLocked
        '
        Me.chkLocked.AutoSize = True
        Me.chkLocked.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLocked.Location = New System.Drawing.Point(129, 271)
        Me.chkLocked.Name = "chkLocked"
        Me.chkLocked.Size = New System.Drawing.Size(138, 18)
        Me.chkLocked.TabIndex = 21
        Me.chkLocked.Text = "Locked Curriculum"
        Me.chkLocked.UseVisualStyleBackColor = True
        '
        'txtProgram
        '
        Me.txtProgram.BackColor = System.Drawing.SystemColors.Info
        Me.txtProgram.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProgram.Location = New System.Drawing.Point(129, 40)
        Me.txtProgram.Name = "txtProgram"
        Me.txtProgram.Size = New System.Drawing.Size(288, 22)
        Me.txtProgram.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 14)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Academic Program"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 14)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Campus"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 14)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Major Study"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(268, 273)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(169, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "- No more modification are allowed"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(459, 367)
        Me.ShapeContainer1.TabIndex = 31
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.DarkGray
        Me.LineShape2.BorderWidth = 2
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 19
        Me.LineShape2.X2 = 442
        Me.LineShape2.Y1 = 139
        Me.LineShape2.Y2 = 139
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.DarkGray
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 20
        Me.LineShape1.X2 = 443
        Me.LineShape1.Y1 = 104
        Me.LineShape1.Y2 = 104
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(17, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "TERM:"
        '
        'lblTerm
        '
        Me.lblTerm.AutoSize = True
        Me.lblTerm.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTerm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTerm.Location = New System.Drawing.Point(55, 114)
        Me.lblTerm.Name = "lblTerm"
        Me.lblTerm.Size = New System.Drawing.Size(42, 14)
        Me.lblTerm.TabIndex = 33
        Me.lblTerm.Text = "TERM:"
        '
        'lblYears
        '
        Me.lblYears.AutoSize = True
        Me.lblYears.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYears.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblYears.Location = New System.Drawing.Point(237, 114)
        Me.lblYears.Name = "lblYears"
        Me.lblYears.Size = New System.Drawing.Size(14, 14)
        Me.lblYears.TabIndex = 35
        Me.lblYears.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(153, 114)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 13)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "NO OF YEARS:"
        '
        'lblTotalYears
        '
        Me.lblTotalYears.AutoSize = True
        Me.lblTotalYears.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalYears.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotalYears.Location = New System.Drawing.Point(423, 116)
        Me.lblTotalYears.Name = "lblTotalYears"
        Me.lblTotalYears.Size = New System.Drawing.Size(14, 14)
        Me.lblTotalYears.TabIndex = 37
        Me.lblTotalYears.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(299, 116)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(118, 13)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "TOTAL NO. OF TERMS:"
        '
        'cboCampus
        '
        Me.cboCampus.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cboCampus.ArrowColor = System.Drawing.Color.Black
        Me.cboCampus.BackColor = System.Drawing.SystemColors.Info
        Me.cboCampus.BindedControl = CType(resources.GetObject("cboCampus.BindedControl"), MTGCComboBox.ControlloAssociato)
        Me.cboCampus.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D
        Me.cboCampus.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboCampus.ColumnNum = 2
        Me.cboCampus.ColumnWidth = "60;0"
        Me.cboCampus.DisabledArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cboCampus.DisabledArrowColor = System.Drawing.Color.LightGray
        Me.cboCampus.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.cboCampus.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder
        Me.cboCampus.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.cboCampus.DisplayMember = "Text"
        Me.cboCampus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboCampus.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cboCampus.DropDownForeColor = System.Drawing.Color.Black
        Me.cboCampus.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList
        Me.cboCampus.GridLineColor = System.Drawing.Color.LightGray
        Me.cboCampus.GridLineHorizontal = True
        Me.cboCampus.GridLineVertical = True
        Me.cboCampus.ItemHeight = 17
        Me.cboCampus.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.cboCampus.Location = New System.Drawing.Point(128, 6)
        Me.cboCampus.ManagingFastMouseMoving = True
        Me.cboCampus.ManagingFastMouseMovingInterval = 30
        Me.cboCampus.Name = "cboCampus"
        Me.cboCampus.SelectedItem = Nothing
        Me.cboCampus.SelectedValue = Nothing
        Me.cboCampus.Size = New System.Drawing.Size(315, 23)
        Me.cboCampus.TabIndex = 68
        '
        'cboMajor
        '
        Me.cboMajor.FormattingEnabled = True
        Me.cboMajor.Location = New System.Drawing.Point(129, 71)
        Me.cboMajor.Name = "cboMajor"
        Me.cboMajor.Size = New System.Drawing.Size(314, 22)
        Me.cboMajor.TabIndex = 69
        '
        'cboMajorID
        '
        Me.cboMajorID.FormattingEnabled = True
        Me.cboMajorID.Location = New System.Drawing.Point(28, 306)
        Me.cboMajorID.Name = "cboMajorID"
        Me.cboMajorID.Size = New System.Drawing.Size(69, 22)
        Me.cboMajorID.TabIndex = 70
        Me.cboMajorID.Visible = False
        '
        'cboCampus1
        '
        Me.cboCampus1.FormattingEnabled = True
        Me.cboCampus1.Location = New System.Drawing.Point(127, 6)
        Me.cboCampus1.Name = "cboCampus1"
        Me.cboCampus1.Size = New System.Drawing.Size(315, 22)
        Me.cboCampus1.TabIndex = 71
        '
        'cboCampusID
        '
        Me.cboCampusID.FormattingEnabled = True
        Me.cboCampusID.Location = New System.Drawing.Point(103, 306)
        Me.cboCampusID.Name = "cboCampusID"
        Me.cboCampusID.Size = New System.Drawing.Size(69, 22)
        Me.cboCampusID.TabIndex = 72
        Me.cboCampusID.Visible = False
        '
        'frmAddCurriculum
        '
        Me.AcceptButton = Me.cmdSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(459, 367)
        Me.Controls.Add(Me.cboCampusID)
        Me.Controls.Add(Me.cboCampus1)
        Me.Controls.Add(Me.cboMajorID)
        Me.Controls.Add(Me.cboMajor)
        Me.Controls.Add(Me.cboCampus)
        Me.Controls.Add(Me.lblTotalYears)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblYears)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblTerm)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtProgram)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chkLocked)
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdGetProgram)
        Me.Controls.Add(Me.txtCurriculumCode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddCurriculum"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Curriculum"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents txtCurriculumCode As System.Windows.Forms.TextBox
    Friend WithEvents cmdGetProgram As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkLocked As System.Windows.Forms.CheckBox
    Friend WithEvents txtProgram As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblTerm As System.Windows.Forms.Label
    Friend WithEvents lblYears As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblTotalYears As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboCampus As MTGCComboBox
    Friend WithEvents cboMajor As System.Windows.Forms.ComboBox
    Friend WithEvents cboMajorID As System.Windows.Forms.ComboBox
    Friend WithEvents cboCampus1 As System.Windows.Forms.ComboBox
    Friend WithEvents cboCampusID As System.Windows.Forms.ComboBox

End Class
