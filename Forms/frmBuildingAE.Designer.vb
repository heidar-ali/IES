<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuildingAE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuildingAE))
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkLan = New System.Windows.Forms.CheckBox()
        Me.txtFloor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboCampus = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBuildingName = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.txtAcronym = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txtOtherName = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.button3 = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.chkLan)
        Me.groupBox1.Controls.Add(Me.txtFloor)
        Me.groupBox1.Controls.Add(Me.Label6)
        Me.groupBox1.Controls.Add(Me.cboCampus)
        Me.groupBox1.Controls.Add(Me.Label1)
        Me.groupBox1.Controls.Add(Me.txtBuildingName)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.txtAcronym)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.txtOtherName)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(12, 12)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(453, 195)
        Me.groupBox1.TabIndex = 1
        Me.groupBox1.TabStop = False
        '
        'chkLan
        '
        Me.chkLan.AutoSize = True
        Me.chkLan.Location = New System.Drawing.Point(146, 164)
        Me.chkLan.Name = "chkLan"
        Me.chkLan.Size = New System.Drawing.Size(170, 18)
        Me.chkLan.TabIndex = 14
        Me.chkLan.Text = "Local Area Network Ready"
        Me.chkLan.UseVisualStyleBackColor = True
        '
        'txtFloor
        '
        Me.txtFloor.Location = New System.Drawing.Point(146, 136)
        Me.txtFloor.Name = "txtFloor"
        Me.txtFloor.Size = New System.Drawing.Size(103, 22)
        Me.txtFloor.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 14)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "No. of Floors/Storeys:"
        '
        'cboCampus
        '
        Me.cboCampus.BackColor = System.Drawing.SystemColors.Info
        Me.cboCampus.FormattingEnabled = True
        Me.cboCampus.Location = New System.Drawing.Point(102, 18)
        Me.cboCampus.Name = "cboCampus"
        Me.cboCampus.Size = New System.Drawing.Size(337, 22)
        Me.cboCampus.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 14)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Campus:"
        '
        'txtBuildingName
        '
        Me.txtBuildingName.BackColor = System.Drawing.SystemColors.Info
        Me.txtBuildingName.Location = New System.Drawing.Point(146, 46)
        Me.txtBuildingName.Name = "txtBuildingName"
        Me.txtBuildingName.Size = New System.Drawing.Size(293, 22)
        Me.txtBuildingName.TabIndex = 7
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(9, 49)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(87, 14)
        Me.label4.TabIndex = 6
        Me.label4.Text = "Building Name:"
        '
        'txtAcronym
        '
        Me.txtAcronym.BackColor = System.Drawing.SystemColors.Info
        Me.txtAcronym.Location = New System.Drawing.Point(146, 105)
        Me.txtAcronym.Name = "txtAcronym"
        Me.txtAcronym.Size = New System.Drawing.Size(147, 22)
        Me.txtAcronym.TabIndex = 5
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(9, 108)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(59, 14)
        Me.label3.TabIndex = 4
        Me.label3.Text = "Acronym:"
        '
        'txtOtherName
        '
        Me.txtOtherName.BackColor = System.Drawing.Color.White
        Me.txtOtherName.Location = New System.Drawing.Point(146, 77)
        Me.txtOtherName.Name = "txtOtherName"
        Me.txtOtherName.Size = New System.Drawing.Size(293, 22)
        Me.txtOtherName.TabIndex = 3
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(9, 80)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(78, 14)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Other Name:"
        '
        'button3
        '
        Me.button3.Image = CType(resources.GetObject("button3.Image"), System.Drawing.Image)
        Me.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button3.Location = New System.Drawing.Point(364, 213)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(87, 26)
        Me.button3.TabIndex = 5
        Me.button3.Text = "&Cancel"
        Me.button3.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSave.Location = New System.Drawing.Point(271, 213)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(87, 26)
        Me.cmdSave.TabIndex = 4
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(535, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(103, 20)
        Me.TextBox1.TabIndex = 15
        '
        'frmBuildingAE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 247)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.groupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBuildingAE"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkLan As System.Windows.Forms.CheckBox
    Private WithEvents txtFloor As System.Windows.Forms.TextBox
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboCampus As System.Windows.Forms.ComboBox
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents txtBuildingName As System.Windows.Forms.TextBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents txtAcronym As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents txtOtherName As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents button3 As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Private WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
