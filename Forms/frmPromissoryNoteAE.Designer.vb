<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPromissoryNoteAE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPromissoryNoteAE))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboTerm = New MTGCComboBox()
        Me.MtgcComboBox1 = New MTGCComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdPickAccount = New System.Windows.Forms.Button()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(271, 423)
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
        Me.OK_Button.Text = "OK"
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
        Me.Label1.Location = New System.Drawing.Point(15, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Student:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(77, 67)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(341, 22)
        Me.TextBox1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Academic Year && Term:"
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
        Me.cboTerm.GridLineColor = System.Drawing.Color.LightGray
        Me.cboTerm.GridLineHorizontal = False
        Me.cboTerm.GridLineVertical = False
        Me.cboTerm.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.cboTerm.Location = New System.Drawing.Point(159, 11)
        Me.cboTerm.ManagingFastMouseMoving = True
        Me.cboTerm.ManagingFastMouseMovingInterval = 30
        Me.cboTerm.Name = "cboTerm"
        Me.cboTerm.SelectedItem = Nothing
        Me.cboTerm.SelectedValue = Nothing
        Me.cboTerm.Size = New System.Drawing.Size(285, 23)
        Me.cboTerm.TabIndex = 4
        '
        'MtgcComboBox1
        '
        Me.MtgcComboBox1.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.MtgcComboBox1.ArrowColor = System.Drawing.Color.Black
        Me.MtgcComboBox1.BindedControl = CType(resources.GetObject("MtgcComboBox1.BindedControl"), MTGCComboBox.ControlloAssociato)
        Me.MtgcComboBox1.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D
        Me.MtgcComboBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MtgcComboBox1.ColumnNum = 2
        Me.MtgcComboBox1.ColumnWidth = "121;0"
        Me.MtgcComboBox1.DisabledArrowBoxColor = System.Drawing.SystemColors.Control
        Me.MtgcComboBox1.DisabledArrowColor = System.Drawing.Color.LightGray
        Me.MtgcComboBox1.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.MtgcComboBox1.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder
        Me.MtgcComboBox1.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.MtgcComboBox1.DisplayMember = "Text"
        Me.MtgcComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.MtgcComboBox1.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.MtgcComboBox1.DropDownForeColor = System.Drawing.Color.Black
        Me.MtgcComboBox1.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.MtgcComboBox1.DropDownWidth = 141
        Me.MtgcComboBox1.GridLineColor = System.Drawing.Color.LightGray
        Me.MtgcComboBox1.GridLineHorizontal = False
        Me.MtgcComboBox1.GridLineVertical = False
        Me.MtgcComboBox1.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.MtgcComboBox1.Location = New System.Drawing.Point(159, 38)
        Me.MtgcComboBox1.ManagingFastMouseMoving = True
        Me.MtgcComboBox1.ManagingFastMouseMovingInterval = 30
        Me.MtgcComboBox1.Name = "MtgcComboBox1"
        Me.MtgcComboBox1.SelectedItem = Nothing
        Me.MtgcComboBox1.SelectedValue = Nothing
        Me.MtgcComboBox1.Size = New System.Drawing.Size(285, 23)
        Me.MtgcComboBox1.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 14)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Campus:"
        '
        'cmdPickAccount
        '
        Me.cmdPickAccount.Image = CType(resources.GetObject("cmdPickAccount.Image"), System.Drawing.Image)
        Me.cmdPickAccount.Location = New System.Drawing.Point(420, 65)
        Me.cmdPickAccount.Name = "cmdPickAccount"
        Me.cmdPickAccount.Size = New System.Drawing.Size(25, 25)
        Me.cmdPickAccount.TabIndex = 9
        Me.cmdPickAccount.UseVisualStyleBackColor = True
        '
        'frmPromissoryNoteAE
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(456, 468)
        Me.Controls.Add(Me.cmdPickAccount)
        Me.Controls.Add(Me.MtgcComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboTerm)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPromissoryNoteAE"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Create Promissiory Note"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboTerm As MTGCComboBox
    Friend WithEvents MtgcComboBox1 As MTGCComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdPickAccount As System.Windows.Forms.Button

End Class
