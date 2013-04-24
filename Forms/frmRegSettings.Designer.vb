<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegSettings))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.CheckBox11 = New System.Windows.Forms.CheckBox()
        Me.CheckBox10 = New System.Windows.Forms.CheckBox()
        Me.CheckBox9 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.chkDisplayBlockSection = New System.Windows.Forms.CheckBox()
        Me.chkOverRideExpireReg = New System.Windows.Forms.CheckBox()
        Me.chkAllowOverload = New System.Windows.Forms.CheckBox()
        Me.chkAllowIncompleteGrades = New System.Windows.Forms.CheckBox()
        Me.chkCheckConflict = New System.Windows.Forms.CheckBox()
        Me.chkPrerequisite = New System.Windows.Forms.CheckBox()
        Me.cboCampusID = New System.Windows.Forms.ComboBox()
        Me.cboTermID = New System.Windows.Forms.ComboBox()
        Me.cboCampus = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboTerm = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.CheckBox14 = New System.Windows.Forms.CheckBox()
        Me.CheckBox13 = New System.Windows.Forms.CheckBox()
        Me.CheckBox12 = New System.Windows.Forms.CheckBox()
        Me.cmdPrintSetup = New System.Windows.Forms.Button()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.txtNumOfPayment = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtp5th = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtp4th = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtp3rd = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtp2nd = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtp1st = New System.Windows.Forms.DateTimePicker()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(298, 419)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(3, 5)
        Me.XtraTabControl1.LookAndFeel.SkinName = "VS2010"
        Me.XtraTabControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(452, 410)
        Me.XtraTabControl1.TabIndex = 1
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage4})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.CheckBox11)
        Me.XtraTabPage1.Controls.Add(Me.CheckBox10)
        Me.XtraTabPage1.Controls.Add(Me.CheckBox9)
        Me.XtraTabPage1.Controls.Add(Me.GroupBox1)
        Me.XtraTabPage1.Controls.Add(Me.CheckBox8)
        Me.XtraTabPage1.Controls.Add(Me.CheckBox7)
        Me.XtraTabPage1.Controls.Add(Me.chkDisplayBlockSection)
        Me.XtraTabPage1.Controls.Add(Me.chkOverRideExpireReg)
        Me.XtraTabPage1.Controls.Add(Me.chkAllowOverload)
        Me.XtraTabPage1.Controls.Add(Me.chkAllowIncompleteGrades)
        Me.XtraTabPage1.Controls.Add(Me.chkCheckConflict)
        Me.XtraTabPage1.Controls.Add(Me.chkPrerequisite)
        Me.XtraTabPage1.Controls.Add(Me.cboCampusID)
        Me.XtraTabPage1.Controls.Add(Me.cboTermID)
        Me.XtraTabPage1.Controls.Add(Me.cboCampus)
        Me.XtraTabPage1.Controls.Add(Me.Label2)
        Me.XtraTabPage1.Controls.Add(Me.cboTerm)
        Me.XtraTabPage1.Controls.Add(Me.Label1)
        Me.XtraTabPage1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(450, 377)
        Me.XtraTabPage1.Text = "Registration"
        '
        'CheckBox11
        '
        Me.CheckBox11.AutoSize = True
        Me.CheckBox11.Location = New System.Drawing.Point(215, 144)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(159, 17)
        Me.CheckBox11.TabIndex = 17
        Me.CheckBox11.Text = "Show Posted Schedule Only"
        Me.CheckBox11.UseVisualStyleBackColor = True
        '
        'CheckBox10
        '
        Me.CheckBox10.AutoSize = True
        Me.CheckBox10.Location = New System.Drawing.Point(215, 121)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(183, 17)
        Me.CheckBox10.TabIndex = 16
        Me.CheckBox10.Text = "Check for Scholastic Delinquency"
        Me.CheckBox10.UseVisualStyleBackColor = True
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.Location = New System.Drawing.Point(215, 98)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(99, 17)
        Me.CheckBox9.TabIndex = 15
        Me.CheckBox9.Text = "Auto Max Units"
        Me.CheckBox9.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblDescription)
        Me.GroupBox1.Location = New System.Drawing.Point(37, 291)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 78)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Description"
        '
        'lblDescription
        '
        Me.lblDescription.Location = New System.Drawing.Point(11, 22)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(373, 49)
        Me.lblDescription.TabIndex = 3
        Me.lblDescription.Text = "..."
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Location = New System.Drawing.Point(12, 261)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(110, 17)
        Me.CheckBox8.TabIndex = 13
        Me.CheckBox8.Text = "Allow Cross Enroll"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Location = New System.Drawing.Point(11, 238)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(130, 17)
        Me.CheckBox7.TabIndex = 12
        Me.CheckBox7.Text = "Show Student Grades"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'chkDisplayBlockSection
        '
        Me.chkDisplayBlockSection.AutoSize = True
        Me.chkDisplayBlockSection.Location = New System.Drawing.Point(11, 215)
        Me.chkDisplayBlockSection.Name = "chkDisplayBlockSection"
        Me.chkDisplayBlockSection.Size = New System.Drawing.Size(144, 17)
        Me.chkDisplayBlockSection.TabIndex = 11
        Me.chkDisplayBlockSection.Text = "Display All Block Sections"
        Me.chkDisplayBlockSection.UseVisualStyleBackColor = True
        '
        'chkOverRideExpireReg
        '
        Me.chkOverRideExpireReg.AutoSize = True
        Me.chkOverRideExpireReg.Location = New System.Drawing.Point(11, 192)
        Me.chkOverRideExpireReg.Name = "chkOverRideExpireReg"
        Me.chkOverRideExpireReg.Size = New System.Drawing.Size(203, 17)
        Me.chkOverRideExpireReg.TabIndex = 10
        Me.chkOverRideExpireReg.Text = "Over- Ride Expiration of Registration"
        Me.chkOverRideExpireReg.UseVisualStyleBackColor = True
        '
        'chkAllowOverload
        '
        Me.chkAllowOverload.AutoSize = True
        Me.chkAllowOverload.Location = New System.Drawing.Point(11, 169)
        Me.chkAllowOverload.Name = "chkAllowOverload"
        Me.chkAllowOverload.Size = New System.Drawing.Size(125, 17)
        Me.chkAllowOverload.TabIndex = 9
        Me.chkAllowOverload.Text = "Allow Overload Units"
        Me.chkAllowOverload.UseVisualStyleBackColor = True
        '
        'chkAllowIncompleteGrades
        '
        Me.chkAllowIncompleteGrades.AutoSize = True
        Me.chkAllowIncompleteGrades.Location = New System.Drawing.Point(11, 121)
        Me.chkAllowIncompleteGrades.Name = "chkAllowIncompleteGrades"
        Me.chkAllowIncompleteGrades.Size = New System.Drawing.Size(144, 17)
        Me.chkAllowIncompleteGrades.TabIndex = 8
        Me.chkAllowIncompleteGrades.Text = "Allow Incomplete Grades"
        Me.chkAllowIncompleteGrades.UseVisualStyleBackColor = True
        '
        'chkCheckConflict
        '
        Me.chkCheckConflict.AutoSize = True
        Me.chkCheckConflict.Location = New System.Drawing.Point(11, 144)
        Me.chkCheckConflict.Name = "chkCheckConflict"
        Me.chkCheckConflict.Size = New System.Drawing.Size(170, 17)
        Me.chkCheckConflict.TabIndex = 7
        Me.chkCheckConflict.Text = "Check for Conflict of Schedule"
        Me.chkCheckConflict.UseVisualStyleBackColor = True
        '
        'chkPrerequisite
        '
        Me.chkPrerequisite.AutoSize = True
        Me.chkPrerequisite.Location = New System.Drawing.Point(11, 98)
        Me.chkPrerequisite.Name = "chkPrerequisite"
        Me.chkPrerequisite.Size = New System.Drawing.Size(119, 17)
        Me.chkPrerequisite.TabIndex = 6
        Me.chkPrerequisite.Text = "Check Pre-requisite"
        Me.chkPrerequisite.UseVisualStyleBackColor = True
        '
        'cboCampusID
        '
        Me.cboCampusID.FormattingEnabled = True
        Me.cboCampusID.Location = New System.Drawing.Point(370, 71)
        Me.cboCampusID.Name = "cboCampusID"
        Me.cboCampusID.Size = New System.Drawing.Size(51, 21)
        Me.cboCampusID.TabIndex = 5
        Me.cboCampusID.Visible = False
        '
        'cboTermID
        '
        Me.cboTermID.FormattingEnabled = True
        Me.cboTermID.Location = New System.Drawing.Point(389, 71)
        Me.cboTermID.Name = "cboTermID"
        Me.cboTermID.Size = New System.Drawing.Size(51, 21)
        Me.cboTermID.TabIndex = 4
        Me.cboTermID.Visible = False
        '
        'cboCampus
        '
        Me.cboCampus.FormattingEnabled = True
        Me.cboCampus.Location = New System.Drawing.Point(145, 44)
        Me.cboCampus.Name = "cboCampus"
        Me.cboCampus.Size = New System.Drawing.Size(295, 21)
        Me.cboCampus.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Default Campus"
        '
        'cboTerm
        '
        Me.cboTerm.FormattingEnabled = True
        Me.cboTerm.Location = New System.Drawing.Point(145, 17)
        Me.cboTerm.Name = "cboTerm"
        Me.cboTerm.Size = New System.Drawing.Size(295, 21)
        Me.cboTerm.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Default Academic Year"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(450, 377)
        Me.XtraTabPage2.Text = "C.O.R. Printing"
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.CheckBox14)
        Me.XtraTabPage3.Controls.Add(Me.CheckBox13)
        Me.XtraTabPage3.Controls.Add(Me.CheckBox12)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(450, 377)
        Me.XtraTabPage3.Text = "Assessment Printing"
        '
        'CheckBox14
        '
        Me.CheckBox14.AutoSize = True
        Me.CheckBox14.Location = New System.Drawing.Point(19, 216)
        Me.CheckBox14.Name = "CheckBox14"
        Me.CheckBox14.Size = New System.Drawing.Size(195, 17)
        Me.CheckBox14.TabIndex = 14
        Me.CheckBox14.Text = "View Previous Outstanding Balance"
        Me.CheckBox14.UseVisualStyleBackColor = True
        '
        'CheckBox13
        '
        Me.CheckBox13.AutoSize = True
        Me.CheckBox13.Location = New System.Drawing.Point(19, 193)
        Me.CheckBox13.Name = "CheckBox13"
        Me.CheckBox13.Size = New System.Drawing.Size(163, 17)
        Me.CheckBox13.TabIndex = 13
        Me.CheckBox13.Text = "Print Registration Upon Save"
        Me.CheckBox13.UseVisualStyleBackColor = True
        '
        'CheckBox12
        '
        Me.CheckBox12.AutoSize = True
        Me.CheckBox12.Location = New System.Drawing.Point(19, 170)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Size = New System.Drawing.Size(163, 17)
        Me.CheckBox12.TabIndex = 12
        Me.CheckBox12.Text = "Print Assessment Upon Save"
        Me.CheckBox12.UseVisualStyleBackColor = True
        '
        'cmdPrintSetup
        '
        Me.cmdPrintSetup.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdPrintSetup.Image = CType(resources.GetObject("cmdPrintSetup.Image"), System.Drawing.Image)
        Me.cmdPrintSetup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPrintSetup.Location = New System.Drawing.Point(5, 421)
        Me.cmdPrintSetup.Name = "cmdPrintSetup"
        Me.cmdPrintSetup.Size = New System.Drawing.Size(117, 26)
        Me.cmdPrintSetup.TabIndex = 2
        Me.cmdPrintSetup.Text = "Printer Set-up"
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.txtNumOfPayment)
        Me.XtraTabPage4.Controls.Add(Me.Label8)
        Me.XtraTabPage4.Controls.Add(Me.CheckBox5)
        Me.XtraTabPage4.Controls.Add(Me.GroupControl1)
        Me.XtraTabPage4.Controls.Add(Me.CheckBox4)
        Me.XtraTabPage4.Controls.Add(Me.CheckBox3)
        Me.XtraTabPage4.Controls.Add(Me.CheckBox2)
        Me.XtraTabPage4.Controls.Add(Me.CheckBox1)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(450, 377)
        Me.XtraTabPage4.Text = "Assessment Config."
        '
        'txtNumOfPayment
        '
        Me.txtNumOfPayment.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumOfPayment.Location = New System.Drawing.Point(154, 137)
        Me.txtNumOfPayment.Name = "txtNumOfPayment"
        Me.txtNumOfPayment.Size = New System.Drawing.Size(100, 22)
        Me.txtNumOfPayment.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(22, 140)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 14)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Number of Payments:"
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox5.Location = New System.Drawing.Point(25, 106)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(267, 18)
        Me.CheckBox5.TabIndex = 19
        Me.CheckBox5.Text = "Print C.O.R. of not yet validated registration"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.Label7)
        Me.GroupControl1.Controls.Add(Me.dtp5th)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.dtp4th)
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Controls.Add(Me.dtp3rd)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.dtp2nd)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.dtp1st)
        Me.GroupControl1.Location = New System.Drawing.Point(2, 171)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(445, 183)
        Me.GroupControl1.TabIndex = 18
        Me.GroupControl1.Text = "SCHEDULE OF PAYMENTS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 14)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "5th Payment:"
        '
        'dtp5th
        '
        Me.dtp5th.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp5th.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp5th.Location = New System.Drawing.Point(135, 149)
        Me.dtp5th.Name = "dtp5th"
        Me.dtp5th.Size = New System.Drawing.Size(136, 22)
        Me.dtp5th.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 14)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "4th Payment:"
        '
        'dtp4th
        '
        Me.dtp4th.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp4th.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp4th.Location = New System.Drawing.Point(135, 121)
        Me.dtp4th.Name = "dtp4th"
        Me.dtp4th.Size = New System.Drawing.Size(136, 22)
        Me.dtp4th.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 14)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "3rd Payment:"
        '
        'dtp3rd
        '
        Me.dtp3rd.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp3rd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp3rd.Location = New System.Drawing.Point(135, 93)
        Me.dtp3rd.Name = "dtp3rd"
        Me.dtp3rd.Size = New System.Drawing.Size(136, 22)
        Me.dtp3rd.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 14)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "2nd Payment:"
        '
        'dtp2nd
        '
        Me.dtp2nd.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp2nd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp2nd.Location = New System.Drawing.Point(135, 65)
        Me.dtp2nd.Name = "dtp2nd"
        Me.dtp2nd.Size = New System.Drawing.Size(136, 22)
        Me.dtp2nd.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 14)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "1st Payment:"
        '
        'dtp1st
        '
        Me.dtp1st.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp1st.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp1st.Location = New System.Drawing.Point(135, 37)
        Me.dtp1st.Name = "dtp1st"
        Me.dtp1st.Size = New System.Drawing.Size(136, 22)
        Me.dtp1st.TabIndex = 0
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox4.Location = New System.Drawing.Point(25, 83)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(262, 18)
        Me.CheckBox4.TabIndex = 17
        Me.CheckBox4.Text = "Charge Lab Fee on Subjects with Lab Units"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.Location = New System.Drawing.Point(25, 60)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(178, 18)
        Me.CheckBox3.TabIndex = 16
        Me.CheckBox3.Text = "Charge Late Enrollment Fee"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(25, 37)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(155, 18)
        Me.CheckBox2.TabIndex = 15
        Me.CheckBox2.Text = "Charge Reservation Fee"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(25, 14)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(248, 18)
        Me.CheckBox1.TabIndex = 14
        Me.CheckBox1.Text = "Allow Students With Balance to Register"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'frmSettings
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(456, 459)
        Me.Controls.Add(Me.cmdPrintSetup)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettings"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Registration Settings"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage3.PerformLayout()
        Me.XtraTabPage4.ResumeLayout(False)
        Me.XtraTabPage4.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents cboCampusID As System.Windows.Forms.ComboBox
    Friend WithEvents cboTermID As System.Windows.Forms.ComboBox
    Friend WithEvents cboCampus As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboTerm As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox8 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox
    Friend WithEvents chkDisplayBlockSection As System.Windows.Forms.CheckBox
    Friend WithEvents chkOverRideExpireReg As System.Windows.Forms.CheckBox
    Friend WithEvents chkAllowOverload As System.Windows.Forms.CheckBox
    Friend WithEvents chkAllowIncompleteGrades As System.Windows.Forms.CheckBox
    Friend WithEvents chkCheckConflict As System.Windows.Forms.CheckBox
    Friend WithEvents chkPrerequisite As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox10 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox9 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox11 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox14 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox13 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox12 As System.Windows.Forms.CheckBox
    Friend WithEvents cmdPrintSetup As System.Windows.Forms.Button
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtNumOfPayment As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtp5th As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtp4th As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtp3rd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtp2nd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtp1st As System.Windows.Forms.DateTimePicker
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox

End Class
