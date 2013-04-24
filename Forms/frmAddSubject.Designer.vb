<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddSubject
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddSubject))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSubjectTitle = New System.Windows.Forms.TextBox()
        Me.txtLecUnits = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLecHrs = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSubjectID = New System.Windows.Forms.TextBox()
        Me.txtLabHrs = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCreditUnits = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtLabUnits = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtAlias = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.chkInactive = New System.Windows.Forms.CheckBox()
        Me.chkCompSubj = New System.Windows.Forms.CheckBox()
        Me.chkSubjWithInternet = New System.Windows.Forms.CheckBox()
        Me.chkNonAcademic = New System.Windows.Forms.CheckBox()
        Me.chkELearning = New System.Windows.Forms.CheckBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.chkGPAGWA = New System.Windows.Forms.CheckBox()
        Me.chkOther = New System.Windows.Forms.CheckBox()
        Me.txtMinSlots = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMaxSlots = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmdBrowseSubjectArea = New System.Windows.Forms.Button()
        Me.txtSubjectArea = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmdBrowseSubjectMode = New System.Windows.Forms.Button()
        Me.txtSubjectMode = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmdNewSubjectArea = New System.Windows.Forms.Button()
        Me.cmdNewSubjectMode = New System.Windows.Forms.Button()
        Me.txtSubjectCode = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.chkElective = New System.Windows.Forms.CheckBox()
        Me.chkGenEduc = New System.Windows.Forms.CheckBox()
        Me.chkMajor = New System.Windows.Forms.CheckBox()
        Me.cboCourseLevel = New System.Windows.Forms.ComboBox()
        Me.cboCourseLevelID = New System.Windows.Forms.ComboBox()
        Me.chklock = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtParentCode = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmdParent = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtAlias2 = New System.Windows.Forms.TextBox()
        Me.cmdAlias2 = New System.Windows.Forms.Button()
        Me.cmdLinkInfo = New System.Windows.Forms.LinkLabel()
        Me.cmdEquivalent = New System.Windows.Forms.LinkLabel()
        Me.chkClub = New System.Windows.Forms.CheckBox()
        Me.chkTransmutedGrades = New System.Windows.Forms.CheckBox()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(297, 523)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(183, 38)
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
        Me.Cancel_Button.Location = New System.Drawing.Point(97, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(80, 31)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Subject Code"
        '
        'txtSubjectTitle
        '
        Me.txtSubjectTitle.BackColor = System.Drawing.SystemColors.Info
        Me.txtSubjectTitle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubjectTitle.Location = New System.Drawing.Point(121, 40)
        Me.txtSubjectTitle.Name = "txtSubjectTitle"
        Me.txtSubjectTitle.Size = New System.Drawing.Size(328, 22)
        Me.txtSubjectTitle.TabIndex = 2
        '
        'txtLecUnits
        '
        Me.txtLecUnits.BackColor = System.Drawing.SystemColors.Info
        Me.txtLecUnits.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLecUnits.Location = New System.Drawing.Point(120, 167)
        Me.txtLecUnits.Name = "txtLecUnits"
        Me.txtLecUnits.Size = New System.Drawing.Size(59, 22)
        Me.txtLecUnits.TabIndex = 4
        Me.txtLecUnits.Text = "0"
        Me.txtLecUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(11, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 26)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Lecture Units" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Academic Units)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtLecHrs
        '
        Me.txtLecHrs.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLecHrs.Location = New System.Drawing.Point(120, 224)
        Me.txtLecHrs.Name = "txtLecHrs"
        Me.txtLecHrs.Size = New System.Drawing.Size(59, 22)
        Me.txtLecHrs.TabIndex = 6
        Me.txtLecHrs.Text = "0"
        Me.txtLecHrs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Lecture Hours"
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.SystemColors.Info
        Me.txtDescription.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(121, 68)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescription.Size = New System.Drawing.Size(328, 52)
        Me.txtDescription.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 14)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Description"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(42, 402)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Course Level:"
        '
        'txtSubjectID
        '
        Me.txtSubjectID.BackColor = System.Drawing.SystemColors.Info
        Me.txtSubjectID.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubjectID.Location = New System.Drawing.Point(531, 485)
        Me.txtSubjectID.Name = "txtSubjectID"
        Me.txtSubjectID.ReadOnly = True
        Me.txtSubjectID.Size = New System.Drawing.Size(35, 22)
        Me.txtSubjectID.TabIndex = 16
        Me.txtSubjectID.Visible = False
        '
        'txtLabHrs
        '
        Me.txtLabHrs.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLabHrs.Location = New System.Drawing.Point(120, 252)
        Me.txtLabHrs.Name = "txtLabHrs"
        Me.txtLabHrs.Size = New System.Drawing.Size(59, 22)
        Me.txtLabHrs.TabIndex = 18
        Me.txtLabHrs.Text = "0"
        Me.txtLabHrs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 256)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Laboratory Hours"
        '
        'txtCreditUnits
        '
        Me.txtCreditUnits.BackColor = System.Drawing.SystemColors.Info
        Me.txtCreditUnits.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreditUnits.Location = New System.Drawing.Point(120, 195)
        Me.txtCreditUnits.Name = "txtCreditUnits"
        Me.txtCreditUnits.Size = New System.Drawing.Size(59, 22)
        Me.txtCreditUnits.TabIndex = 20
        Me.txtCreditUnits.Text = "0"
        Me.txtCreditUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(15, 199)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Credited Units"
        '
        'txtLabUnits
        '
        Me.txtLabUnits.BackColor = System.Drawing.SystemColors.Info
        Me.txtLabUnits.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLabUnits.Location = New System.Drawing.Point(120, 139)
        Me.txtLabUnits.Name = "txtLabUnits"
        Me.txtLabUnits.Size = New System.Drawing.Size(59, 22)
        Me.txtLabUnits.TabIndex = 22
        Me.txtLabUnits.Text = "0"
        Me.txtLabUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(11, 143)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Laboratory Units"
        '
        'txtAlias
        '
        Me.txtAlias.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlias.Location = New System.Drawing.Point(120, 285)
        Me.txtAlias.Name = "txtAlias"
        Me.txtAlias.Size = New System.Drawing.Size(125, 22)
        Me.txtAlias.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(25, 288)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 14)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Code Alias 1:"
        '
        'chkInactive
        '
        Me.chkInactive.AutoSize = True
        Me.chkInactive.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkInactive.Location = New System.Drawing.Point(288, 132)
        Me.chkInactive.Name = "chkInactive"
        Me.chkInactive.Size = New System.Drawing.Size(115, 18)
        Me.chkInactive.TabIndex = 30
        Me.chkInactive.Text = "Inactive Subject"
        Me.chkInactive.UseVisualStyleBackColor = True
        '
        'chkCompSubj
        '
        Me.chkCompSubj.AutoSize = True
        Me.chkCompSubj.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCompSubj.ForeColor = System.Drawing.Color.Blue
        Me.chkCompSubj.Location = New System.Drawing.Point(288, 151)
        Me.chkCompSubj.Name = "chkCompSubj"
        Me.chkCompSubj.Size = New System.Drawing.Size(149, 18)
        Me.chkCompSubj.TabIndex = 31
        Me.chkCompSubj.Text = "COMPUTER SUBJECT"
        Me.chkCompSubj.UseVisualStyleBackColor = True
        '
        'chkSubjWithInternet
        '
        Me.chkSubjWithInternet.AutoSize = True
        Me.chkSubjWithInternet.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSubjWithInternet.ForeColor = System.Drawing.Color.Blue
        Me.chkSubjWithInternet.Location = New System.Drawing.Point(288, 174)
        Me.chkSubjWithInternet.Name = "chkSubjWithInternet"
        Me.chkSubjWithInternet.Size = New System.Drawing.Size(177, 18)
        Me.chkSubjWithInternet.TabIndex = 32
        Me.chkSubjWithInternet.Text = "SUBJECT WITH INTERNET"
        Me.chkSubjWithInternet.UseVisualStyleBackColor = True
        '
        'chkNonAcademic
        '
        Me.chkNonAcademic.AutoSize = True
        Me.chkNonAcademic.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNonAcademic.Location = New System.Drawing.Point(288, 197)
        Me.chkNonAcademic.Name = "chkNonAcademic"
        Me.chkNonAcademic.Size = New System.Drawing.Size(166, 18)
        Me.chkNonAcademic.TabIndex = 33
        Me.chkNonAcademic.Text = "NON-ACADEMIC SUBJECT"
        Me.chkNonAcademic.UseVisualStyleBackColor = True
        '
        'chkELearning
        '
        Me.chkELearning.AutoSize = True
        Me.chkELearning.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkELearning.ForeColor = System.Drawing.Color.Blue
        Me.chkELearning.Location = New System.Drawing.Point(288, 220)
        Me.chkELearning.Name = "chkELearning"
        Me.chkELearning.Size = New System.Drawing.Size(99, 18)
        Me.chkELearning.TabIndex = 34
        Me.chkELearning.Text = "E-LEARNING"
        Me.chkELearning.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(492, 568)
        Me.ShapeContainer1.TabIndex = 35
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.Color.Silver
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 15
        Me.LineShape4.X2 = 273
        Me.LineShape4.Y1 = 351
        Me.LineShape4.Y2 = 351
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.Color.Silver
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 281
        Me.LineShape3.X2 = 281
        Me.LineShape3.Y1 = 392
        Me.LineShape3.Y2 = 132
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.Silver
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 17
        Me.LineShape2.X2 = 453
        Me.LineShape2.Y1 = 485
        Me.LineShape2.Y2 = 485
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.Silver
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 11
        Me.LineShape1.X2 = 466
        Me.LineShape1.Y1 = 125
        Me.LineShape1.Y2 = 125
        '
        'chkGPAGWA
        '
        Me.chkGPAGWA.AutoSize = True
        Me.chkGPAGWA.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGPAGWA.Location = New System.Drawing.Point(288, 243)
        Me.chkGPAGWA.Name = "chkGPAGWA"
        Me.chkGPAGWA.Size = New System.Drawing.Size(160, 18)
        Me.chkGPAGWA.TabIndex = 36
        Me.chkGPAGWA.Text = "INCLUDE 'GPA' or 'GWA'"
        Me.chkGPAGWA.UseVisualStyleBackColor = True
        '
        'chkOther
        '
        Me.chkOther.AutoSize = True
        Me.chkOther.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOther.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkOther.Location = New System.Drawing.Point(288, 266)
        Me.chkOther.Name = "chkOther"
        Me.chkOther.Size = New System.Drawing.Size(160, 18)
        Me.chkOther.TabIndex = 37
        Me.chkOther.Text = "FROM OTHER SCHOOL"
        Me.chkOther.UseVisualStyleBackColor = True
        '
        'txtMinSlots
        '
        Me.txtMinSlots.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinSlots.Location = New System.Drawing.Point(166, 493)
        Me.txtMinSlots.Name = "txtMinSlots"
        Me.txtMinSlots.Size = New System.Drawing.Size(55, 22)
        Me.txtMinSlots.TabIndex = 39
        Me.txtMinSlots.Text = "15"
        Me.txtMinSlots.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 497)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Default Minimum Class Size:"
        '
        'txtMaxSlots
        '
        Me.txtMaxSlots.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaxSlots.Location = New System.Drawing.Point(166, 521)
        Me.txtMaxSlots.Name = "txtMaxSlots"
        Me.txtMaxSlots.Size = New System.Drawing.Size(55, 22)
        Me.txtMaxSlots.TabIndex = 41
        Me.txtMaxSlots.Text = "40"
        Me.txtMaxSlots.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(16, 525)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(143, 13)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "Default Maximum Class Size:"
        '
        'cmdBrowseSubjectArea
        '
        Me.cmdBrowseSubjectArea.Image = CType(resources.GetObject("cmdBrowseSubjectArea.Image"), System.Drawing.Image)
        Me.cmdBrowseSubjectArea.Location = New System.Drawing.Point(398, 427)
        Me.cmdBrowseSubjectArea.Name = "cmdBrowseSubjectArea"
        Me.cmdBrowseSubjectArea.Size = New System.Drawing.Size(26, 23)
        Me.cmdBrowseSubjectArea.TabIndex = 44
        Me.cmdBrowseSubjectArea.UseVisualStyleBackColor = True
        '
        'txtSubjectArea
        '
        Me.txtSubjectArea.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubjectArea.Location = New System.Drawing.Point(121, 427)
        Me.txtSubjectArea.Name = "txtSubjectArea"
        Me.txtSubjectArea.Size = New System.Drawing.Size(276, 22)
        Me.txtSubjectArea.TabIndex = 43
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(42, 431)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 13)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Subject Area:"
        '
        'cmdBrowseSubjectMode
        '
        Me.cmdBrowseSubjectMode.Image = CType(resources.GetObject("cmdBrowseSubjectMode.Image"), System.Drawing.Image)
        Me.cmdBrowseSubjectMode.Location = New System.Drawing.Point(398, 455)
        Me.cmdBrowseSubjectMode.Name = "cmdBrowseSubjectMode"
        Me.cmdBrowseSubjectMode.Size = New System.Drawing.Size(26, 23)
        Me.cmdBrowseSubjectMode.TabIndex = 47
        Me.cmdBrowseSubjectMode.UseVisualStyleBackColor = True
        '
        'txtSubjectMode
        '
        Me.txtSubjectMode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubjectMode.Location = New System.Drawing.Point(121, 455)
        Me.txtSubjectMode.Name = "txtSubjectMode"
        Me.txtSubjectMode.Size = New System.Drawing.Size(276, 22)
        Me.txtSubjectMode.TabIndex = 46
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(37, 458)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 13)
        Me.Label14.TabIndex = 45
        Me.Label14.Text = "Subject Mode:"
        '
        'cmdNewSubjectArea
        '
        Me.cmdNewSubjectArea.Image = CType(resources.GetObject("cmdNewSubjectArea.Image"), System.Drawing.Image)
        Me.cmdNewSubjectArea.Location = New System.Drawing.Point(423, 427)
        Me.cmdNewSubjectArea.Name = "cmdNewSubjectArea"
        Me.cmdNewSubjectArea.Size = New System.Drawing.Size(26, 23)
        Me.cmdNewSubjectArea.TabIndex = 48
        Me.cmdNewSubjectArea.UseVisualStyleBackColor = True
        '
        'cmdNewSubjectMode
        '
        Me.cmdNewSubjectMode.Image = CType(resources.GetObject("cmdNewSubjectMode.Image"), System.Drawing.Image)
        Me.cmdNewSubjectMode.Location = New System.Drawing.Point(423, 454)
        Me.cmdNewSubjectMode.Name = "cmdNewSubjectMode"
        Me.cmdNewSubjectMode.Size = New System.Drawing.Size(26, 23)
        Me.cmdNewSubjectMode.TabIndex = 49
        Me.cmdNewSubjectMode.UseVisualStyleBackColor = True
        '
        'txtSubjectCode
        '
        Me.txtSubjectCode.BackColor = System.Drawing.SystemColors.Info
        Me.txtSubjectCode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubjectCode.Location = New System.Drawing.Point(121, 12)
        Me.txtSubjectCode.Name = "txtSubjectCode"
        Me.txtSubjectCode.Size = New System.Drawing.Size(125, 22)
        Me.txtSubjectCode.TabIndex = 51
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(6, 43)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 14)
        Me.Label15.TabIndex = 50
        Me.Label15.Text = "Subject Title"
        '
        'chkElective
        '
        Me.chkElective.AutoSize = True
        Me.chkElective.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkElective.Location = New System.Drawing.Point(288, 289)
        Me.chkElective.Name = "chkElective"
        Me.chkElective.Size = New System.Drawing.Size(133, 18)
        Me.chkElective.TabIndex = 52
        Me.chkElective.Text = "ELECTIVE SUBJECT"
        Me.chkElective.UseVisualStyleBackColor = True
        '
        'chkGenEduc
        '
        Me.chkGenEduc.AutoSize = True
        Me.chkGenEduc.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGenEduc.Location = New System.Drawing.Point(288, 311)
        Me.chkGenEduc.Name = "chkGenEduc"
        Me.chkGenEduc.Size = New System.Drawing.Size(148, 18)
        Me.chkGenEduc.TabIndex = 53
        Me.chkGenEduc.Text = "GENERAL EDUCATION"
        Me.chkGenEduc.UseVisualStyleBackColor = True
        '
        'chkMajor
        '
        Me.chkMajor.AutoSize = True
        Me.chkMajor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMajor.Location = New System.Drawing.Point(288, 334)
        Me.chkMajor.Name = "chkMajor"
        Me.chkMajor.Size = New System.Drawing.Size(117, 18)
        Me.chkMajor.TabIndex = 54
        Me.chkMajor.Text = "MAJOR SUBJECT"
        Me.chkMajor.UseVisualStyleBackColor = True
        '
        'cboCourseLevel
        '
        Me.cboCourseLevel.BackColor = System.Drawing.SystemColors.Info
        Me.cboCourseLevel.FormattingEnabled = True
        Me.cboCourseLevel.Location = New System.Drawing.Point(121, 402)
        Me.cboCourseLevel.Name = "cboCourseLevel"
        Me.cboCourseLevel.Size = New System.Drawing.Size(328, 21)
        Me.cboCourseLevel.TabIndex = 55
        '
        'cboCourseLevelID
        '
        Me.cboCourseLevelID.BackColor = System.Drawing.Color.White
        Me.cboCourseLevelID.FormattingEnabled = True
        Me.cboCourseLevelID.Location = New System.Drawing.Point(490, 485)
        Me.cboCourseLevelID.Name = "cboCourseLevelID"
        Me.cboCourseLevelID.Size = New System.Drawing.Size(30, 21)
        Me.cboCourseLevelID.TabIndex = 58
        '
        'chklock
        '
        Me.chklock.AutoSize = True
        Me.chklock.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chklock.Location = New System.Drawing.Point(244, 492)
        Me.chklock.Name = "chklock"
        Me.chklock.Size = New System.Drawing.Size(120, 18)
        Me.chklock.TabIndex = 59
        Me.chklock.Text = "Locked Subject"
        Me.chklock.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(220, 360)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 24)
        Me.Button1.TabIndex = 61
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtParentCode
        '
        Me.txtParentCode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtParentCode.Location = New System.Drawing.Point(120, 361)
        Me.txtParentCode.Name = "txtParentCode"
        Me.txtParentCode.Size = New System.Drawing.Size(100, 22)
        Me.txtParentCode.TabIndex = 60
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(42, 365)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(71, 13)
        Me.Label16.TabIndex = 62
        Me.Label16.Text = "Parent Code:"
        '
        'cmdParent
        '
        Me.cmdParent.Image = CType(resources.GetObject("cmdParent.Image"), System.Drawing.Image)
        Me.cmdParent.Location = New System.Drawing.Point(244, 360)
        Me.cmdParent.Name = "cmdParent"
        Me.cmdParent.Size = New System.Drawing.Size(24, 24)
        Me.cmdParent.TabIndex = 63
        Me.cmdParent.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(21, 316)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(77, 14)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "Code Alias 2:"
        '
        'txtAlias2
        '
        Me.txtAlias2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlias2.Location = New System.Drawing.Point(120, 313)
        Me.txtAlias2.Name = "txtAlias2"
        Me.txtAlias2.Size = New System.Drawing.Size(100, 22)
        Me.txtAlias2.TabIndex = 25
        '
        'cmdAlias2
        '
        Me.cmdAlias2.Image = CType(resources.GetObject("cmdAlias2.Image"), System.Drawing.Image)
        Me.cmdAlias2.Location = New System.Drawing.Point(220, 312)
        Me.cmdAlias2.Name = "cmdAlias2"
        Me.cmdAlias2.Size = New System.Drawing.Size(24, 24)
        Me.cmdAlias2.TabIndex = 64
        Me.cmdAlias2.UseVisualStyleBackColor = True
        '
        'cmdLinkInfo
        '
        Me.cmdLinkInfo.AutoSize = True
        Me.cmdLinkInfo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLinkInfo.Location = New System.Drawing.Point(306, 16)
        Me.cmdLinkInfo.Name = "cmdLinkInfo"
        Me.cmdLinkInfo.Size = New System.Drawing.Size(66, 14)
        Me.cmdLinkInfo.TabIndex = 65
        Me.cmdLinkInfo.TabStop = True
        Me.cmdLinkInfo.Text = "Link Info."
        Me.cmdLinkInfo.Visible = False
        '
        'cmdEquivalent
        '
        Me.cmdEquivalent.AutoSize = True
        Me.cmdEquivalent.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEquivalent.Location = New System.Drawing.Point(391, 16)
        Me.cmdEquivalent.Name = "cmdEquivalent"
        Me.cmdEquivalent.Size = New System.Drawing.Size(71, 14)
        Me.cmdEquivalent.TabIndex = 66
        Me.cmdEquivalent.TabStop = True
        Me.cmdEquivalent.Text = "Equivalent"
        Me.cmdEquivalent.Visible = False
        '
        'chkClub
        '
        Me.chkClub.AutoSize = True
        Me.chkClub.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkClub.Location = New System.Drawing.Point(288, 355)
        Me.chkClub.Name = "chkClub"
        Me.chkClub.Size = New System.Drawing.Size(200, 18)
        Me.chkClub.TabIndex = 67
        Me.chkClub.Text = "CLUB/ORGANIZATION SUBJECT"
        Me.chkClub.UseVisualStyleBackColor = True
        '
        'chkTransmutedGrades
        '
        Me.chkTransmutedGrades.AutoSize = True
        Me.chkTransmutedGrades.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTransmutedGrades.Location = New System.Drawing.Point(288, 375)
        Me.chkTransmutedGrades.Name = "chkTransmutedGrades"
        Me.chkTransmutedGrades.Size = New System.Drawing.Size(179, 18)
        Me.chkTransmutedGrades.TabIndex = 68
        Me.chkTransmutedGrades.Text = "USE TRANSMUTED GRADES"
        Me.chkTransmutedGrades.UseVisualStyleBackColor = True
        '
        'frmAddSubject
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(492, 568)
        Me.Controls.Add(Me.chkTransmutedGrades)
        Me.Controls.Add(Me.chkClub)
        Me.Controls.Add(Me.cmdEquivalent)
        Me.Controls.Add(Me.cmdLinkInfo)
        Me.Controls.Add(Me.cmdAlias2)
        Me.Controls.Add(Me.txtAlias2)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.cmdParent)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtParentCode)
        Me.Controls.Add(Me.chklock)
        Me.Controls.Add(Me.cboCourseLevelID)
        Me.Controls.Add(Me.cboCourseLevel)
        Me.Controls.Add(Me.chkMajor)
        Me.Controls.Add(Me.chkGenEduc)
        Me.Controls.Add(Me.chkElective)
        Me.Controls.Add(Me.txtSubjectCode)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cmdNewSubjectMode)
        Me.Controls.Add(Me.cmdNewSubjectArea)
        Me.Controls.Add(Me.cmdBrowseSubjectMode)
        Me.Controls.Add(Me.txtSubjectMode)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cmdBrowseSubjectArea)
        Me.Controls.Add(Me.txtSubjectArea)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtMaxSlots)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtMinSlots)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.chkOther)
        Me.Controls.Add(Me.chkGPAGWA)
        Me.Controls.Add(Me.chkELearning)
        Me.Controls.Add(Me.chkNonAcademic)
        Me.Controls.Add(Me.chkSubjWithInternet)
        Me.Controls.Add(Me.chkCompSubj)
        Me.Controls.Add(Me.chkInactive)
        Me.Controls.Add(Me.txtAlias)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtLabUnits)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtCreditUnits)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtLabHrs)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtSubjectID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtLecHrs)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLecUnits)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSubjectTitle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddSubject"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "11"
        Me.Text = "Subject Management"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSubjectTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtLecUnits As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLecHrs As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSubjectID As System.Windows.Forms.TextBox
    Friend WithEvents txtLabHrs As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCreditUnits As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtLabUnits As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtAlias As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents chkInactive As System.Windows.Forms.CheckBox
    Friend WithEvents chkCompSubj As System.Windows.Forms.CheckBox
    Friend WithEvents chkSubjWithInternet As System.Windows.Forms.CheckBox
    Friend WithEvents chkNonAcademic As System.Windows.Forms.CheckBox
    Friend WithEvents chkELearning As System.Windows.Forms.CheckBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents chkGPAGWA As System.Windows.Forms.CheckBox
    Friend WithEvents chkOther As System.Windows.Forms.CheckBox
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents txtMinSlots As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMaxSlots As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmdBrowseSubjectArea As System.Windows.Forms.Button
    Friend WithEvents txtSubjectArea As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmdBrowseSubjectMode As System.Windows.Forms.Button
    Friend WithEvents txtSubjectMode As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmdNewSubjectArea As System.Windows.Forms.Button
    Friend WithEvents cmdNewSubjectMode As System.Windows.Forms.Button
    Friend WithEvents txtSubjectCode As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents chkElective As System.Windows.Forms.CheckBox
    Friend WithEvents chkGenEduc As System.Windows.Forms.CheckBox
    Friend WithEvents chkMajor As System.Windows.Forms.CheckBox
    Friend WithEvents cboCourseLevel As System.Windows.Forms.ComboBox
    Friend WithEvents cboCourseLevelID As System.Windows.Forms.ComboBox
    Friend WithEvents chklock As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtParentCode As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cmdParent As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtAlias2 As System.Windows.Forms.TextBox
    Friend WithEvents cmdAlias2 As System.Windows.Forms.Button
    Friend WithEvents cmdLinkInfo As System.Windows.Forms.LinkLabel
    Friend WithEvents cmdEquivalent As System.Windows.Forms.LinkLabel
    Friend WithEvents chkClub As System.Windows.Forms.CheckBox
    Friend WithEvents chkTransmutedGrades As System.Windows.Forms.CheckBox

End Class
