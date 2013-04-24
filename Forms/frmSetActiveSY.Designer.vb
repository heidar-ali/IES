Partial Class frmSetActiveSY
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary>
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetActiveSY))
        Me.label1 = New System.Windows.Forms.Label()
        Me.cmdSet = New System.Windows.Forms.Button()
        Me.cmdGetSchoolYear = New System.Windows.Forms.Button()
        Me.txtSchoolYear = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(12, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(76, 14)
        Me.label1.TabIndex = 1
        Me.label1.Text = "School Year:"
        '
        'cmdSet
        '
        Me.cmdSet.Location = New System.Drawing.Point(56, 61)
        Me.cmdSet.Name = "cmdSet"
        Me.cmdSet.Size = New System.Drawing.Size(94, 22)
        Me.cmdSet.TabIndex = 2
        Me.cmdSet.Text = "Set"
        Me.cmdSet.UseVisualStyleBackColor = True
        '
        'cmdGetSchoolYear
        '
        Me.cmdGetSchoolYear.Image = CType(resources.GetObject("cmdGetSchoolYear.Image"), System.Drawing.Image)
        Me.cmdGetSchoolYear.Location = New System.Drawing.Point(219, 25)
        Me.cmdGetSchoolYear.Name = "cmdGetSchoolYear"
        Me.cmdGetSchoolYear.Size = New System.Drawing.Size(25, 23)
        Me.cmdGetSchoolYear.TabIndex = 68
        Me.cmdGetSchoolYear.UseVisualStyleBackColor = True
        '
        'txtSchoolYear
        '
        Me.txtSchoolYear.BackColor = System.Drawing.SystemColors.Info
        Me.txtSchoolYear.Location = New System.Drawing.Point(12, 26)
        Me.txtSchoolYear.Name = "txtSchoolYear"
        Me.txtSchoolYear.Size = New System.Drawing.Size(207, 20)
        Me.txtSchoolYear.TabIndex = 67
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(156, 61)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 22)
        Me.Button2.TabIndex = 69
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmSetActiveSY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(256, 90)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cmdGetSchoolYear)
        Me.Controls.Add(Me.txtSchoolYear)
        Me.Controls.Add(Me.cmdSet)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSetActiveSY"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Set Active School Year"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private label1 As System.Windows.Forms.Label
    Friend WithEvents cmdSet As System.Windows.Forms.Button
    Friend WithEvents cmdGetSchoolYear As System.Windows.Forms.Button
    Public WithEvents txtSchoolYear As System.Windows.Forms.TextBox
    Private WithEvents Button2 As System.Windows.Forms.Button
End Class
