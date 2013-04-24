Partial Class frmRoomAE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRoomAE))
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboRoomType = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboFloorLocation = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboBuilding = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRoomNo = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.txtCapacity = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txtRoom = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.chkAirConditioned = New System.Windows.Forms.CheckBox()
        Me.chkActive = New System.Windows.Forms.CheckBox()
        Me.chkNight = New System.Windows.Forms.CheckBox()
        Me.chkLAN = New System.Windows.Forms.CheckBox()
        Me.chkShared = New System.Windows.Forms.CheckBox()
        Me.cboRoomTypeID = New System.Windows.Forms.ComboBox()
        Me.txtRoomID = New System.Windows.Forms.TextBox()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.cboRoomType)
        Me.groupBox1.Controls.Add(Me.Label6)
        Me.groupBox1.Controls.Add(Me.cboFloorLocation)
        Me.groupBox1.Controls.Add(Me.Label5)
        Me.groupBox1.Controls.Add(Me.cboBuilding)
        Me.groupBox1.Controls.Add(Me.Label1)
        Me.groupBox1.Controls.Add(Me.txtRoomNo)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.txtCapacity)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.txtRoom)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Location = New System.Drawing.Point(8, 3)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(339, 195)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = False
        '
        'cboRoomType
        '
        Me.cboRoomType.BackColor = System.Drawing.SystemColors.Info
        Me.cboRoomType.FormattingEnabled = True
        Me.cboRoomType.Location = New System.Drawing.Point(102, 158)
        Me.cboRoomType.Name = "cboRoomType"
        Me.cboRoomType.Size = New System.Drawing.Size(231, 22)
        Me.cboRoomType.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 14)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Room Type:"
        '
        'cboFloorLocation
        '
        Me.cboFloorLocation.BackColor = System.Drawing.SystemColors.Info
        Me.cboFloorLocation.FormattingEnabled = True
        Me.cboFloorLocation.Location = New System.Drawing.Point(102, 46)
        Me.cboFloorLocation.Name = "cboFloorLocation"
        Me.cboFloorLocation.Size = New System.Drawing.Size(147, 22)
        Me.cboFloorLocation.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 14)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Floor Location:"
        '
        'cboBuilding
        '
        Me.cboBuilding.BackColor = System.Drawing.SystemColors.Info
        Me.cboBuilding.FormattingEnabled = True
        Me.cboBuilding.Location = New System.Drawing.Point(102, 18)
        Me.cboBuilding.Name = "cboBuilding"
        Me.cboBuilding.Size = New System.Drawing.Size(231, 22)
        Me.cboBuilding.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 14)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Building:"
        '
        'txtRoomNo
        '
        Me.txtRoomNo.BackColor = System.Drawing.SystemColors.Info
        Me.txtRoomNo.Location = New System.Drawing.Point(102, 74)
        Me.txtRoomNo.Name = "txtRoomNo"
        Me.txtRoomNo.Size = New System.Drawing.Size(231, 22)
        Me.txtRoomNo.TabIndex = 7
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(9, 77)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(61, 14)
        Me.label4.TabIndex = 6
        Me.label4.Text = "Room No:"
        '
        'txtCapacity
        '
        Me.txtCapacity.Location = New System.Drawing.Point(102, 130)
        Me.txtCapacity.Name = "txtCapacity"
        Me.txtCapacity.Size = New System.Drawing.Size(147, 22)
        Me.txtCapacity.TabIndex = 5
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(9, 133)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(52, 14)
        Me.label3.TabIndex = 4
        Me.label3.Text = "Capacity"
        '
        'txtRoom
        '
        Me.txtRoom.BackColor = System.Drawing.SystemColors.Info
        Me.txtRoom.Location = New System.Drawing.Point(102, 102)
        Me.txtRoom.Name = "txtRoom"
        Me.txtRoom.Size = New System.Drawing.Size(231, 22)
        Me.txtRoom.TabIndex = 3
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(9, 105)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(77, 14)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Room Name:"
        '
        'cmdSave
        '
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSave.Location = New System.Drawing.Point(310, 216)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(87, 26)
        Me.cmdSave.TabIndex = 1
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'button3
        '
        Me.button3.Image = CType(resources.GetObject("button3.Image"), System.Drawing.Image)
        Me.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button3.Location = New System.Drawing.Point(403, 216)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(87, 26)
        Me.button3.TabIndex = 3
        Me.button3.Text = "&Cancel"
        Me.button3.UseVisualStyleBackColor = True
        '
        'chkAirConditioned
        '
        Me.chkAirConditioned.AutoSize = True
        Me.chkAirConditioned.Location = New System.Drawing.Point(353, 12)
        Me.chkAirConditioned.Name = "chkAirConditioned"
        Me.chkAirConditioned.Size = New System.Drawing.Size(109, 18)
        Me.chkAirConditioned.TabIndex = 4
        Me.chkAirConditioned.Text = "Air Conditioned"
        Me.chkAirConditioned.UseVisualStyleBackColor = True
        '
        'chkActive
        '
        Me.chkActive.AutoSize = True
        Me.chkActive.Location = New System.Drawing.Point(353, 36)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(138, 18)
        Me.chkActive.TabIndex = 5
        Me.chkActive.Text = "Ready to Use/Active"
        Me.chkActive.UseVisualStyleBackColor = True
        '
        'chkNight
        '
        Me.chkNight.AutoSize = True
        Me.chkNight.Location = New System.Drawing.Point(353, 60)
        Me.chkNight.Name = "chkNight"
        Me.chkNight.Size = New System.Drawing.Size(117, 18)
        Me.chkNight.TabIndex = 6
        Me.chkNight.Text = "Allow Night Class"
        Me.chkNight.UseVisualStyleBackColor = True
        '
        'chkLAN
        '
        Me.chkLAN.AutoSize = True
        Me.chkLAN.Location = New System.Drawing.Point(353, 84)
        Me.chkLAN.Name = "chkLAN"
        Me.chkLAN.Size = New System.Drawing.Size(85, 18)
        Me.chkLAN.TabIndex = 7
        Me.chkLAN.Text = "LAN Ready"
        Me.chkLAN.UseVisualStyleBackColor = True
        '
        'chkShared
        '
        Me.chkShared.AutoSize = True
        Me.chkShared.Location = New System.Drawing.Point(353, 106)
        Me.chkShared.Name = "chkShared"
        Me.chkShared.Size = New System.Drawing.Size(64, 18)
        Me.chkShared.TabIndex = 8
        Me.chkShared.Text = "Shared"
        Me.chkShared.UseVisualStyleBackColor = True
        '
        'cboRoomTypeID
        '
        Me.cboRoomTypeID.FormattingEnabled = True
        Me.cboRoomTypeID.Location = New System.Drawing.Point(8, 204)
        Me.cboRoomTypeID.Name = "cboRoomTypeID"
        Me.cboRoomTypeID.Size = New System.Drawing.Size(121, 22)
        Me.cboRoomTypeID.TabIndex = 9
        '
        'txtRoomID
        '
        Me.txtRoomID.Location = New System.Drawing.Point(135, 204)
        Me.txtRoomID.Name = "txtRoomID"
        Me.txtRoomID.Size = New System.Drawing.Size(147, 22)
        Me.txtRoomID.TabIndex = 14
        '
        'frmRoomAE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 254)
        Me.Controls.Add(Me.txtRoomID)
        Me.Controls.Add(Me.cboRoomTypeID)
        Me.Controls.Add(Me.chkShared)
        Me.Controls.Add(Me.chkLAN)
        Me.Controls.Add(Me.chkNight)
        Me.Controls.Add(Me.chkActive)
        Me.Controls.Add(Me.chkAirConditioned)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.groupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRoomAE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Room"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private groupBox1 As System.Windows.Forms.GroupBox
    Private txtCapacity As System.Windows.Forms.TextBox
    Private label3 As System.Windows.Forms.Label
    Private txtRoom As System.Windows.Forms.TextBox
    Private label2 As System.Windows.Forms.Label
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents button3 As System.Windows.Forms.Button
    Private txtRoomNo As System.Windows.Forms.TextBox
    Private label4 As System.Windows.Forms.Label
    Friend WithEvents cboRoomType As System.Windows.Forms.ComboBox
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboFloorLocation As System.Windows.Forms.ComboBox
    Private WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboBuilding As System.Windows.Forms.ComboBox
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkAirConditioned As System.Windows.Forms.CheckBox
    Friend WithEvents chkActive As System.Windows.Forms.CheckBox
    Friend WithEvents chkNight As System.Windows.Forms.CheckBox
    Friend WithEvents chkLAN As System.Windows.Forms.CheckBox
    Friend WithEvents chkShared As System.Windows.Forms.CheckBox
    Friend WithEvents cboRoomTypeID As System.Windows.Forms.ComboBox
    Private WithEvents txtRoomID As System.Windows.Forms.TextBox
End Class
