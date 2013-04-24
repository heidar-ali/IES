<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccountsAE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccountsAE))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.txtAccountName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtShortName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboFundGroup = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboSubFund = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboSubUnit = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboDepartment = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboClassification = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboAccountOption = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboPaymentOption = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.cmdGL2 = New System.Windows.Forms.Button()
        Me.cmdRefreshRecCredit = New System.Windows.Forms.Button()
        Me.cmdGL1 = New System.Windows.Forms.Button()
        Me.cboRecCredit = New System.Windows.Forms.ComboBox()
        Me.cmdRefreshRecDebit = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cboRecDebit = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.cmdGL3 = New System.Windows.Forms.Button()
        Me.cmdColRefreshGL = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cboColCredit = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmdNewFund = New System.Windows.Forms.Button()
        Me.cmdSubFund = New System.Windows.Forms.Button()
        Me.cmdSubUnit = New System.Windows.Forms.Button()
        Me.cmdDepartment = New System.Windows.Forms.Button()
        Me.cmdClassification = New System.Windows.Forms.Button()
        Me.cmdType = New System.Windows.Forms.Button()
        Me.cboFundID = New System.Windows.Forms.ComboBox()
        Me.cboSubFundID = New System.Windows.Forms.ComboBox()
        Me.cboSubUnitID = New System.Windows.Forms.ComboBox()
        Me.cboAccountDepartmentID = New System.Windows.Forms.ComboBox()
        Me.cboTypeID = New System.Windows.Forms.ComboBox()
        Me.cboClassID = New System.Windows.Forms.ComboBox()
        Me.cboAccountOptionID = New System.Windows.Forms.ComboBox()
        Me.cboPayOptionID = New System.Windows.Forms.ComboBox()
        Me.cboRecDebitID = New System.Windows.Forms.ComboBox()
        Me.cboRecCreditID = New System.Windows.Forms.ComboBox()
        Me.cboColCreditID = New System.Windows.Forms.ComboBox()
        Me.cmdRefreshFund = New System.Windows.Forms.Button()
        Me.cmdRefreshSubFund = New System.Windows.Forms.Button()
        Me.cmdRefreshSubUnit = New System.Windows.Forms.Button()
        Me.cmdRefreshDepartment = New System.Windows.Forms.Button()
        Me.cmdRefreshClassification = New System.Windows.Forms.Button()
        Me.cmdRefreshTpype = New System.Windows.Forms.Button()
        Me.chkActive = New System.Windows.Forms.CheckBox()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(626, 342)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(177, 32)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Image = CType(resources.GetObject("OK_Button.Image"), System.Drawing.Image)
        Me.OK_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(82, 26)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "&Save"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Image = CType(resources.GetObject("Cancel_Button.Image"), System.Drawing.Image)
        Me.Cancel_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cancel_Button.Location = New System.Drawing.Point(91, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(83, 26)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(5, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "&Account Code:"
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(119, 12)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(114, 20)
        Me.txtCode.TabIndex = 2
        '
        'txtAccountName
        '
        Me.txtAccountName.Location = New System.Drawing.Point(119, 53)
        Me.txtAccountName.Name = "txtAccountName"
        Me.txtAccountName.Size = New System.Drawing.Size(259, 20)
        Me.txtAccountName.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(5, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Account Name:"
        '
        'txtShortName
        '
        Me.txtShortName.Location = New System.Drawing.Point(119, 79)
        Me.txtShortName.Name = "txtShortName"
        Me.txtShortName.Size = New System.Drawing.Size(259, 20)
        Me.txtShortName.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(5, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Short Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(12, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Fund/Group:"
        '
        'cboFundGroup
        '
        Me.cboFundGroup.FormattingEnabled = True
        Me.cboFundGroup.Location = New System.Drawing.Point(119, 131)
        Me.cboFundGroup.Name = "cboFundGroup"
        Me.cboFundGroup.Size = New System.Drawing.Size(234, 21)
        Me.cboFundGroup.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(5, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(376, 2)
        Me.Label5.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(5, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(377, 2)
        Me.Label6.TabIndex = 10
        '
        'cboSubFund
        '
        Me.cboSubFund.FormattingEnabled = True
        Me.cboSubFund.Location = New System.Drawing.Point(119, 158)
        Me.cboSubFund.Name = "cboSubFund"
        Me.cboSubFund.Size = New System.Drawing.Size(234, 21)
        Me.cboSubFund.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Sub Fund:"
        '
        'cboSubUnit
        '
        Me.cboSubUnit.FormattingEnabled = True
        Me.cboSubUnit.Location = New System.Drawing.Point(119, 185)
        Me.cboSubUnit.Name = "cboSubUnit"
        Me.cboSubUnit.Size = New System.Drawing.Size(234, 21)
        Me.cboSubUnit.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Sub Unit:"
        '
        'cboDepartment
        '
        Me.cboDepartment.FormattingEnabled = True
        Me.cboDepartment.Location = New System.Drawing.Point(119, 212)
        Me.cboDepartment.Name = "cboDepartment"
        Me.cboDepartment.Size = New System.Drawing.Size(234, 21)
        Me.cboDepartment.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 215)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Department:"
        '
        'cboClassification
        '
        Me.cboClassification.FormattingEnabled = True
        Me.cboClassification.Location = New System.Drawing.Point(119, 239)
        Me.cboClassification.Name = "cboClassification"
        Me.cboClassification.Size = New System.Drawing.Size(234, 21)
        Me.cboClassification.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(12, 242)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Classification:"
        '
        'cboType
        '
        Me.cboType.FormattingEnabled = True
        Me.cboType.Location = New System.Drawing.Point(119, 266)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(234, 21)
        Me.cboType.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 269)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Type"
        '
        'cboAccountOption
        '
        Me.cboAccountOption.FormattingEnabled = True
        Me.cboAccountOption.Location = New System.Drawing.Point(119, 319)
        Me.cboAccountOption.Name = "cboAccountOption"
        Me.cboAccountOption.Size = New System.Drawing.Size(234, 21)
        Me.cboAccountOption.TabIndex = 22
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(12, 322)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Account Options:"
        '
        'cboPaymentOption
        '
        Me.cboPaymentOption.FormattingEnabled = True
        Me.cboPaymentOption.Location = New System.Drawing.Point(119, 346)
        Me.cboPaymentOption.Name = "cboPaymentOption"
        Me.cboPaymentOption.Size = New System.Drawing.Size(234, 21)
        Me.cboPaymentOption.TabIndex = 24
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(12, 349)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 13)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Payment Options:"
        '
        'Label14
        '
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Location = New System.Drawing.Point(5, 302)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(377, 2)
        Me.Label14.TabIndex = 25
        '
        'Label15
        '
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Location = New System.Drawing.Point(406, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(2, 361)
        Me.Label15.TabIndex = 26
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupControl1.Appearance.Options.UseBackColor = True
        Me.GroupControl1.Controls.Add(Me.cmdGL2)
        Me.GroupControl1.Controls.Add(Me.cmdRefreshRecCredit)
        Me.GroupControl1.Controls.Add(Me.cmdGL1)
        Me.GroupControl1.Controls.Add(Me.cboRecCredit)
        Me.GroupControl1.Controls.Add(Me.cmdRefreshRecDebit)
        Me.GroupControl1.Controls.Add(Me.Label17)
        Me.GroupControl1.Controls.Add(Me.cboRecDebit)
        Me.GroupControl1.Controls.Add(Me.Label16)
        Me.GroupControl1.Location = New System.Drawing.Point(415, 9)
        Me.GroupControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(394, 90)
        Me.GroupControl1.TabIndex = 27
        Me.GroupControl1.Text = "FEES RECEIVABLE (GL Entry)"
        '
        'cmdGL2
        '
        Me.cmdGL2.Image = CType(resources.GetObject("cmdGL2.Image"), System.Drawing.Image)
        Me.cmdGL2.Location = New System.Drawing.Point(341, 52)
        Me.cmdGL2.Name = "cmdGL2"
        Me.cmdGL2.Size = New System.Drawing.Size(23, 23)
        Me.cmdGL2.TabIndex = 56
        Me.cmdGL2.UseVisualStyleBackColor = True
        '
        'cmdRefreshRecCredit
        '
        Me.cmdRefreshRecCredit.Image = CType(resources.GetObject("cmdRefreshRecCredit.Image"), System.Drawing.Image)
        Me.cmdRefreshRecCredit.Location = New System.Drawing.Point(363, 52)
        Me.cmdRefreshRecCredit.Name = "cmdRefreshRecCredit"
        Me.cmdRefreshRecCredit.Size = New System.Drawing.Size(23, 23)
        Me.cmdRefreshRecCredit.TabIndex = 55
        Me.cmdRefreshRecCredit.UseVisualStyleBackColor = True
        '
        'cmdGL1
        '
        Me.cmdGL1.Image = CType(resources.GetObject("cmdGL1.Image"), System.Drawing.Image)
        Me.cmdGL1.Location = New System.Drawing.Point(341, 26)
        Me.cmdGL1.Name = "cmdGL1"
        Me.cmdGL1.Size = New System.Drawing.Size(23, 23)
        Me.cmdGL1.TabIndex = 54
        Me.cmdGL1.UseVisualStyleBackColor = True
        '
        'cboRecCredit
        '
        Me.cboRecCredit.FormattingEnabled = True
        Me.cboRecCredit.Location = New System.Drawing.Point(90, 54)
        Me.cboRecCredit.Name = "cboRecCredit"
        Me.cboRecCredit.Size = New System.Drawing.Size(249, 21)
        Me.cboRecCredit.TabIndex = 32
        '
        'cmdRefreshRecDebit
        '
        Me.cmdRefreshRecDebit.Image = CType(resources.GetObject("cmdRefreshRecDebit.Image"), System.Drawing.Image)
        Me.cmdRefreshRecDebit.Location = New System.Drawing.Point(363, 26)
        Me.cmdRefreshRecDebit.Name = "cmdRefreshRecDebit"
        Me.cmdRefreshRecDebit.Size = New System.Drawing.Size(23, 23)
        Me.cmdRefreshRecDebit.TabIndex = 53
        Me.cmdRefreshRecDebit.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(8, 57)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 13)
        Me.Label17.TabIndex = 31
        Me.Label17.Text = "Credit Account:"
        '
        'cboRecDebit
        '
        Me.cboRecDebit.FormattingEnabled = True
        Me.cboRecDebit.Location = New System.Drawing.Point(90, 27)
        Me.cboRecDebit.Name = "cboRecDebit"
        Me.cboRecDebit.Size = New System.Drawing.Size(249, 21)
        Me.cboRecDebit.TabIndex = 30
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(6, 30)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(78, 13)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "Debit Account:"
        '
        'GroupControl2
        '
        Me.GroupControl2.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupControl2.Appearance.Options.UseBackColor = True
        Me.GroupControl2.Controls.Add(Me.cmdGL3)
        Me.GroupControl2.Controls.Add(Me.cmdColRefreshGL)
        Me.GroupControl2.Controls.Add(Me.Label20)
        Me.GroupControl2.Controls.Add(Me.cboColCredit)
        Me.GroupControl2.Controls.Add(Me.Label18)
        Me.GroupControl2.Controls.Add(Me.Label19)
        Me.GroupControl2.Location = New System.Drawing.Point(415, 105)
        Me.GroupControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.GroupControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(394, 96)
        Me.GroupControl2.TabIndex = 28
        Me.GroupControl2.Text = "COLLECTION (GL Entry)"
        '
        'cmdGL3
        '
        Me.cmdGL3.Image = CType(resources.GetObject("cmdGL3.Image"), System.Drawing.Image)
        Me.cmdGL3.Location = New System.Drawing.Point(341, 60)
        Me.cmdGL3.Name = "cmdGL3"
        Me.cmdGL3.Size = New System.Drawing.Size(23, 23)
        Me.cmdGL3.TabIndex = 56
        Me.cmdGL3.UseVisualStyleBackColor = True
        '
        'cmdColRefreshGL
        '
        Me.cmdColRefreshGL.Image = CType(resources.GetObject("cmdColRefreshGL.Image"), System.Drawing.Image)
        Me.cmdColRefreshGL.Location = New System.Drawing.Point(363, 59)
        Me.cmdColRefreshGL.Name = "cmdColRefreshGL"
        Me.cmdColRefreshGL.Size = New System.Drawing.Size(23, 23)
        Me.cmdColRefreshGL.TabIndex = 55
        Me.cmdColRefreshGL.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(90, 38)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(187, 13)
        Me.Label20.TabIndex = 36
        Me.Label20.Text = "Entry is base on Payment Setup" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cboColCredit
        '
        Me.cboColCredit.FormattingEnabled = True
        Me.cboColCredit.Location = New System.Drawing.Point(90, 62)
        Me.cboColCredit.Name = "cboColCredit"
        Me.cboColCredit.Size = New System.Drawing.Size(249, 21)
        Me.cboColCredit.TabIndex = 35
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(8, 65)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 13)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "Credit Account:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 38)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(78, 13)
        Me.Label19.TabIndex = 33
        Me.Label19.Text = "Debit Account:"
        '
        'cmdNewFund
        '
        Me.cmdNewFund.Image = CType(resources.GetObject("cmdNewFund.Image"), System.Drawing.Image)
        Me.cmdNewFund.Location = New System.Drawing.Point(353, 130)
        Me.cmdNewFund.Name = "cmdNewFund"
        Me.cmdNewFund.Size = New System.Drawing.Size(23, 23)
        Me.cmdNewFund.TabIndex = 29
        Me.cmdNewFund.UseVisualStyleBackColor = True
        '
        'cmdSubFund
        '
        Me.cmdSubFund.Image = CType(resources.GetObject("cmdSubFund.Image"), System.Drawing.Image)
        Me.cmdSubFund.Location = New System.Drawing.Point(353, 157)
        Me.cmdSubFund.Name = "cmdSubFund"
        Me.cmdSubFund.Size = New System.Drawing.Size(23, 24)
        Me.cmdSubFund.TabIndex = 30
        Me.cmdSubFund.UseVisualStyleBackColor = True
        '
        'cmdSubUnit
        '
        Me.cmdSubUnit.Image = CType(resources.GetObject("cmdSubUnit.Image"), System.Drawing.Image)
        Me.cmdSubUnit.Location = New System.Drawing.Point(353, 183)
        Me.cmdSubUnit.Name = "cmdSubUnit"
        Me.cmdSubUnit.Size = New System.Drawing.Size(23, 23)
        Me.cmdSubUnit.TabIndex = 31
        Me.cmdSubUnit.UseVisualStyleBackColor = True
        '
        'cmdDepartment
        '
        Me.cmdDepartment.Image = CType(resources.GetObject("cmdDepartment.Image"), System.Drawing.Image)
        Me.cmdDepartment.Location = New System.Drawing.Point(353, 211)
        Me.cmdDepartment.Name = "cmdDepartment"
        Me.cmdDepartment.Size = New System.Drawing.Size(23, 23)
        Me.cmdDepartment.TabIndex = 32
        Me.cmdDepartment.UseVisualStyleBackColor = True
        '
        'cmdClassification
        '
        Me.cmdClassification.Image = CType(resources.GetObject("cmdClassification.Image"), System.Drawing.Image)
        Me.cmdClassification.Location = New System.Drawing.Point(353, 238)
        Me.cmdClassification.Name = "cmdClassification"
        Me.cmdClassification.Size = New System.Drawing.Size(23, 23)
        Me.cmdClassification.TabIndex = 33
        Me.cmdClassification.UseVisualStyleBackColor = True
        '
        'cmdType
        '
        Me.cmdType.Image = CType(resources.GetObject("cmdType.Image"), System.Drawing.Image)
        Me.cmdType.Location = New System.Drawing.Point(353, 265)
        Me.cmdType.Name = "cmdType"
        Me.cmdType.Size = New System.Drawing.Size(23, 23)
        Me.cmdType.TabIndex = 34
        Me.cmdType.UseVisualStyleBackColor = True
        '
        'cboFundID
        '
        Me.cboFundID.FormattingEnabled = True
        Me.cboFundID.Location = New System.Drawing.Point(540, 273)
        Me.cboFundID.Name = "cboFundID"
        Me.cboFundID.Size = New System.Drawing.Size(53, 21)
        Me.cboFundID.TabIndex = 36
        Me.cboFundID.Visible = False
        '
        'cboSubFundID
        '
        Me.cboSubFundID.FormattingEnabled = True
        Me.cboSubFundID.Location = New System.Drawing.Point(414, 273)
        Me.cboSubFundID.Name = "cboSubFundID"
        Me.cboSubFundID.Size = New System.Drawing.Size(53, 21)
        Me.cboSubFundID.TabIndex = 37
        Me.cboSubFundID.Visible = False
        '
        'cboSubUnitID
        '
        Me.cboSubUnitID.FormattingEnabled = True
        Me.cboSubUnitID.Location = New System.Drawing.Point(414, 300)
        Me.cboSubUnitID.Name = "cboSubUnitID"
        Me.cboSubUnitID.Size = New System.Drawing.Size(53, 21)
        Me.cboSubUnitID.TabIndex = 38
        Me.cboSubUnitID.Visible = False
        '
        'cboAccountDepartmentID
        '
        Me.cboAccountDepartmentID.FormattingEnabled = True
        Me.cboAccountDepartmentID.Location = New System.Drawing.Point(414, 327)
        Me.cboAccountDepartmentID.Name = "cboAccountDepartmentID"
        Me.cboAccountDepartmentID.Size = New System.Drawing.Size(53, 21)
        Me.cboAccountDepartmentID.TabIndex = 39
        Me.cboAccountDepartmentID.Visible = False
        '
        'cboTypeID
        '
        Me.cboTypeID.FormattingEnabled = True
        Me.cboTypeID.Location = New System.Drawing.Point(415, 353)
        Me.cboTypeID.Name = "cboTypeID"
        Me.cboTypeID.Size = New System.Drawing.Size(53, 21)
        Me.cboTypeID.TabIndex = 40
        Me.cboTypeID.Visible = False
        '
        'cboClassID
        '
        Me.cboClassID.FormattingEnabled = True
        Me.cboClassID.Location = New System.Drawing.Point(599, 273)
        Me.cboClassID.Name = "cboClassID"
        Me.cboClassID.Size = New System.Drawing.Size(53, 21)
        Me.cboClassID.TabIndex = 41
        Me.cboClassID.Visible = False
        '
        'cboAccountOptionID
        '
        Me.cboAccountOptionID.FormattingEnabled = True
        Me.cboAccountOptionID.Location = New System.Drawing.Point(473, 273)
        Me.cboAccountOptionID.Name = "cboAccountOptionID"
        Me.cboAccountOptionID.Size = New System.Drawing.Size(53, 21)
        Me.cboAccountOptionID.TabIndex = 42
        Me.cboAccountOptionID.Visible = False
        '
        'cboPayOptionID
        '
        Me.cboPayOptionID.FormattingEnabled = True
        Me.cboPayOptionID.Location = New System.Drawing.Point(473, 300)
        Me.cboPayOptionID.Name = "cboPayOptionID"
        Me.cboPayOptionID.Size = New System.Drawing.Size(53, 21)
        Me.cboPayOptionID.TabIndex = 43
        Me.cboPayOptionID.Visible = False
        '
        'cboRecDebitID
        '
        Me.cboRecDebitID.FormattingEnabled = True
        Me.cboRecDebitID.Location = New System.Drawing.Point(473, 327)
        Me.cboRecDebitID.Name = "cboRecDebitID"
        Me.cboRecDebitID.Size = New System.Drawing.Size(53, 21)
        Me.cboRecDebitID.TabIndex = 44
        Me.cboRecDebitID.Visible = False
        '
        'cboRecCreditID
        '
        Me.cboRecCreditID.FormattingEnabled = True
        Me.cboRecCreditID.Location = New System.Drawing.Point(473, 353)
        Me.cboRecCreditID.Name = "cboRecCreditID"
        Me.cboRecCreditID.Size = New System.Drawing.Size(53, 21)
        Me.cboRecCreditID.TabIndex = 45
        Me.cboRecCreditID.Visible = False
        '
        'cboColCreditID
        '
        Me.cboColCreditID.FormattingEnabled = True
        Me.cboColCreditID.Location = New System.Drawing.Point(658, 273)
        Me.cboColCreditID.Name = "cboColCreditID"
        Me.cboColCreditID.Size = New System.Drawing.Size(53, 21)
        Me.cboColCreditID.TabIndex = 46
        Me.cboColCreditID.Visible = False
        '
        'cmdRefreshFund
        '
        Me.cmdRefreshFund.Image = CType(resources.GetObject("cmdRefreshFund.Image"), System.Drawing.Image)
        Me.cmdRefreshFund.Location = New System.Drawing.Point(375, 130)
        Me.cmdRefreshFund.Name = "cmdRefreshFund"
        Me.cmdRefreshFund.Size = New System.Drawing.Size(23, 23)
        Me.cmdRefreshFund.TabIndex = 47
        Me.cmdRefreshFund.UseVisualStyleBackColor = True
        '
        'cmdRefreshSubFund
        '
        Me.cmdRefreshSubFund.Image = CType(resources.GetObject("cmdRefreshSubFund.Image"), System.Drawing.Image)
        Me.cmdRefreshSubFund.Location = New System.Drawing.Point(375, 157)
        Me.cmdRefreshSubFund.Name = "cmdRefreshSubFund"
        Me.cmdRefreshSubFund.Size = New System.Drawing.Size(23, 23)
        Me.cmdRefreshSubFund.TabIndex = 48
        Me.cmdRefreshSubFund.UseVisualStyleBackColor = True
        '
        'cmdRefreshSubUnit
        '
        Me.cmdRefreshSubUnit.Image = CType(resources.GetObject("cmdRefreshSubUnit.Image"), System.Drawing.Image)
        Me.cmdRefreshSubUnit.Location = New System.Drawing.Point(375, 183)
        Me.cmdRefreshSubUnit.Name = "cmdRefreshSubUnit"
        Me.cmdRefreshSubUnit.Size = New System.Drawing.Size(23, 23)
        Me.cmdRefreshSubUnit.TabIndex = 49
        Me.cmdRefreshSubUnit.UseVisualStyleBackColor = True
        '
        'cmdRefreshDepartment
        '
        Me.cmdRefreshDepartment.Image = CType(resources.GetObject("cmdRefreshDepartment.Image"), System.Drawing.Image)
        Me.cmdRefreshDepartment.Location = New System.Drawing.Point(375, 211)
        Me.cmdRefreshDepartment.Name = "cmdRefreshDepartment"
        Me.cmdRefreshDepartment.Size = New System.Drawing.Size(23, 23)
        Me.cmdRefreshDepartment.TabIndex = 50
        Me.cmdRefreshDepartment.UseVisualStyleBackColor = True
        '
        'cmdRefreshClassification
        '
        Me.cmdRefreshClassification.Image = CType(resources.GetObject("cmdRefreshClassification.Image"), System.Drawing.Image)
        Me.cmdRefreshClassification.Location = New System.Drawing.Point(375, 238)
        Me.cmdRefreshClassification.Name = "cmdRefreshClassification"
        Me.cmdRefreshClassification.Size = New System.Drawing.Size(23, 23)
        Me.cmdRefreshClassification.TabIndex = 51
        Me.cmdRefreshClassification.UseVisualStyleBackColor = True
        '
        'cmdRefreshTpype
        '
        Me.cmdRefreshTpype.Image = CType(resources.GetObject("cmdRefreshTpype.Image"), System.Drawing.Image)
        Me.cmdRefreshTpype.Location = New System.Drawing.Point(375, 264)
        Me.cmdRefreshTpype.Name = "cmdRefreshTpype"
        Me.cmdRefreshTpype.Size = New System.Drawing.Size(23, 23)
        Me.cmdRefreshTpype.TabIndex = 52
        Me.cmdRefreshTpype.UseVisualStyleBackColor = True
        '
        'chkActive
        '
        Me.chkActive.AutoSize = True
        Me.chkActive.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActive.Location = New System.Drawing.Point(415, 216)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(75, 18)
        Me.chkActive.TabIndex = 53
        Me.chkActive.Text = "Inactive"
        Me.chkActive.UseVisualStyleBackColor = True
        '
        'frmAccountsAE
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(815, 383)
        Me.Controls.Add(Me.chkActive)
        Me.Controls.Add(Me.cmdRefreshTpype)
        Me.Controls.Add(Me.cmdRefreshClassification)
        Me.Controls.Add(Me.cmdRefreshDepartment)
        Me.Controls.Add(Me.cmdRefreshSubUnit)
        Me.Controls.Add(Me.cmdRefreshSubFund)
        Me.Controls.Add(Me.cmdRefreshFund)
        Me.Controls.Add(Me.cboColCreditID)
        Me.Controls.Add(Me.cboRecCreditID)
        Me.Controls.Add(Me.cboRecDebitID)
        Me.Controls.Add(Me.cboPayOptionID)
        Me.Controls.Add(Me.cboAccountOptionID)
        Me.Controls.Add(Me.cboClassID)
        Me.Controls.Add(Me.cboTypeID)
        Me.Controls.Add(Me.cboAccountDepartmentID)
        Me.Controls.Add(Me.cboSubUnitID)
        Me.Controls.Add(Me.cboSubFundID)
        Me.Controls.Add(Me.cboFundID)
        Me.Controls.Add(Me.cmdType)
        Me.Controls.Add(Me.cmdClassification)
        Me.Controls.Add(Me.cmdDepartment)
        Me.Controls.Add(Me.cmdSubUnit)
        Me.Controls.Add(Me.cmdSubFund)
        Me.Controls.Add(Me.cmdNewFund)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cboPaymentOption)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cboAccountOption)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cboClassification)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cboDepartment)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cboSubUnit)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cboSubFund)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboFundGroup)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtShortName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAccountName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAccountsAE"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Account Information"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents txtAccountName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtShortName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboFundGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboSubFund As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboSubUnit As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboClassification As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboType As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboAccountOption As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboPaymentOption As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cboRecCredit As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cboRecDebit As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cboColCredit As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cmdNewFund As System.Windows.Forms.Button
    Friend WithEvents cmdSubFund As System.Windows.Forms.Button
    Friend WithEvents cmdSubUnit As System.Windows.Forms.Button
    Friend WithEvents cmdDepartment As System.Windows.Forms.Button
    Friend WithEvents cmdClassification As System.Windows.Forms.Button
    Friend WithEvents cmdType As System.Windows.Forms.Button
    Friend WithEvents cboFundID As System.Windows.Forms.ComboBox
    Friend WithEvents cboSubFundID As System.Windows.Forms.ComboBox
    Friend WithEvents cboSubUnitID As System.Windows.Forms.ComboBox
    Friend WithEvents cboAccountDepartmentID As System.Windows.Forms.ComboBox
    Friend WithEvents cboTypeID As System.Windows.Forms.ComboBox
    Friend WithEvents cboClassID As System.Windows.Forms.ComboBox
    Friend WithEvents cboAccountOptionID As System.Windows.Forms.ComboBox
    Friend WithEvents cboPayOptionID As System.Windows.Forms.ComboBox
    Friend WithEvents cboRecDebitID As System.Windows.Forms.ComboBox
    Friend WithEvents cboRecCreditID As System.Windows.Forms.ComboBox
    Friend WithEvents cboColCreditID As System.Windows.Forms.ComboBox
    Friend WithEvents cmdRefreshFund As System.Windows.Forms.Button
    Friend WithEvents cmdRefreshSubFund As System.Windows.Forms.Button
    Friend WithEvents cmdRefreshSubUnit As System.Windows.Forms.Button
    Friend WithEvents cmdRefreshDepartment As System.Windows.Forms.Button
    Friend WithEvents cmdRefreshClassification As System.Windows.Forms.Button
    Friend WithEvents cmdRefreshTpype As System.Windows.Forms.Button
    Friend WithEvents cmdRefreshRecDebit As System.Windows.Forms.Button
    Friend WithEvents cmdGL1 As System.Windows.Forms.Button
    Friend WithEvents cmdGL2 As System.Windows.Forms.Button
    Friend WithEvents cmdRefreshRecCredit As System.Windows.Forms.Button
    Friend WithEvents cmdGL3 As System.Windows.Forms.Button
    Friend WithEvents cmdColRefreshGL As System.Windows.Forms.Button
    Friend WithEvents chkActive As System.Windows.Forms.CheckBox

End Class
