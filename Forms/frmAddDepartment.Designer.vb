<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddDepartment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddDepartment))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDepartmentID = New System.Windows.Forms.TextBox()
        Me.txtDepartmentTitle = New System.Windows.Forms.TextBox()
        Me.txtShortName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboCampus = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboCampusID = New System.Windows.Forms.ComboBox()
        Me.cboCollege = New MTGCComboBox()
        Me.cboCollege1 = New System.Windows.Forms.ComboBox()
        Me.cboCollegeID = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1.SuspendLayout()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(148, 274)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(170, 31)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(78, 25)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Save"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Department:"
        '
        'txtDepartmentID
        '
        Me.txtDepartmentID.Location = New System.Drawing.Point(400, 26)
        Me.txtDepartmentID.Name = "txtDepartmentID"
        Me.txtDepartmentID.ReadOnly = True
        Me.txtDepartmentID.Size = New System.Drawing.Size(100, 22)
        Me.txtDepartmentID.TabIndex = 2
        '
        'txtDepartmentTitle
        '
        Me.txtDepartmentTitle.Location = New System.Drawing.Point(15, 161)
        Me.txtDepartmentTitle.Name = "txtDepartmentTitle"
        Me.txtDepartmentTitle.Size = New System.Drawing.Size(302, 22)
        Me.txtDepartmentTitle.TabIndex = 4
        '
        'txtShortName
        '
        Me.txtShortName.Location = New System.Drawing.Point(15, 211)
        Me.txtShortName.Name = "txtShortName"
        Me.txtShortName.Size = New System.Drawing.Size(302, 22)
        Me.txtShortName.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 14)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Short Name/Acronym:"
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(15, 115)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(302, 22)
        Me.txtCode.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 14)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Department Code:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 14)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Campus"
        '
        'cboCampus
        '
        Me.cboCampus.BackColor = System.Drawing.SystemColors.Info
        Me.cboCampus.FormattingEnabled = True
        Me.cboCampus.Location = New System.Drawing.Point(15, 30)
        Me.cboCampus.Name = "cboCampus"
        Me.cboCampus.Size = New System.Drawing.Size(303, 22)
        Me.cboCampus.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 14)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "College"
        '
        'cboCampusID
        '
        Me.cboCampusID.BackColor = System.Drawing.SystemColors.Info
        Me.cboCampusID.FormattingEnabled = True
        Me.cboCampusID.Location = New System.Drawing.Point(15, 267)
        Me.cboCampusID.Name = "cboCampusID"
        Me.cboCampusID.Size = New System.Drawing.Size(46, 22)
        Me.cboCampusID.TabIndex = 13
        Me.cboCampusID.Visible = False
        '
        'cboCollege
        '
        Me.cboCollege.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cboCollege.ArrowColor = System.Drawing.Color.Black
        Me.cboCollege.BindedControl = CType(resources.GetObject("cboCollege.BindedControl"), MTGCComboBox.ControlloAssociato)
        Me.cboCollege.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D
        Me.cboCollege.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboCollege.ColumnNum = 2
        Me.cboCollege.ColumnWidth = "60;0"
        Me.cboCollege.DisabledArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cboCollege.DisabledArrowColor = System.Drawing.Color.LightGray
        Me.cboCollege.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.cboCollege.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder
        Me.cboCollege.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.cboCollege.DisplayMember = "Text"
        Me.cboCollege.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboCollege.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cboCollege.DropDownForeColor = System.Drawing.Color.Black
        Me.cboCollege.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList
        Me.cboCollege.GridLineColor = System.Drawing.Color.LightGray
        Me.cboCollege.GridLineHorizontal = True
        Me.cboCollege.GridLineVertical = True
        Me.cboCollege.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.cboCollege.Location = New System.Drawing.Point(15, 72)
        Me.cboCollege.ManagingFastMouseMoving = True
        Me.cboCollege.ManagingFastMouseMovingInterval = 30
        Me.cboCollege.Name = "cboCollege"
        Me.cboCollege.SelectedItem = Nothing
        Me.cboCollege.SelectedValue = Nothing
        Me.cboCollege.Size = New System.Drawing.Size(303, 23)
        Me.cboCollege.TabIndex = 15
        '
        'cboCollege1
        '
        Me.cboCollege1.BackColor = System.Drawing.SystemColors.Info
        Me.cboCollege1.FormattingEnabled = True
        Me.cboCollege1.Location = New System.Drawing.Point(15, 72)
        Me.cboCollege1.Name = "cboCollege1"
        Me.cboCollege1.Size = New System.Drawing.Size(303, 22)
        Me.cboCollege1.TabIndex = 16
        '
        'cboCollegeID
        '
        Me.cboCollegeID.BackColor = System.Drawing.SystemColors.Info
        Me.cboCollegeID.FormattingEnabled = True
        Me.cboCollegeID.Location = New System.Drawing.Point(67, 267)
        Me.cboCollegeID.Name = "cboCollegeID"
        Me.cboCollegeID.Size = New System.Drawing.Size(46, 22)
        Me.cboCollegeID.TabIndex = 17
        Me.cboCollegeID.Visible = False
        '
        'frmAddDepartment
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(332, 319)
        Me.Controls.Add(Me.cboCollegeID)
        Me.Controls.Add(Me.cboCollege1)
        Me.Controls.Add(Me.cboCollege)
        Me.Controls.Add(Me.cboCampusID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboCampus)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtShortName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDepartmentTitle)
        Me.Controls.Add(Me.txtDepartmentID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddDepartment"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Department"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDepartmentID As System.Windows.Forms.TextBox
    Friend WithEvents txtDepartmentTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtShortName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboCampus As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboCampusID As System.Windows.Forms.ComboBox
    Friend WithEvents cboCollege As MTGCComboBox
    Friend WithEvents cboCollege1 As System.Windows.Forms.ComboBox
    Friend WithEvents cboCollegeID As System.Windows.Forms.ComboBox

End Class
