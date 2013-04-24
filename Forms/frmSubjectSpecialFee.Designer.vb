<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSubjectSpecialFee
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSubjectSpecialFee))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.cboTerm = New System.Windows.Forms.ComboBox()
        Me.cboCampus = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboYearLevel = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.cboSubjectID = New System.Windows.Forms.ComboBox()
        Me.lblCreditUnit = New System.Windows.Forms.Label()
        Me.lblLectUnit = New System.Windows.Forms.Label()
        Me.cboYLID = New System.Windows.Forms.ComboBox()
        Me.lblLabUnit = New System.Windows.Forms.Label()
        Me.cboAcctID = New System.Windows.Forms.ComboBox()
        Me.lblLabHrs = New System.Windows.Forms.Label()
        Me.cboTermID = New System.Windows.Forms.ComboBox()
        Me.lblLectHrs = New System.Windows.Forms.Label()
        Me.cboCampusID = New System.Windows.Forms.ComboBox()
        Me.lblSubjectCode = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboAccount = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtLabFee = New System.Windows.Forms.TextBox()
        Me.txtTuitionFee = New System.Windows.Forms.TextBox()
        Me.chkLF = New System.Windows.Forms.CheckBox()
        Me.chkTF = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.StyleController1 = New DevExpress.XtraEditors.StyleController(Me.components)
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.lvPrograms = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.txtSubject = New C1.Win.C1List.C1Combo()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.StyleController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.txtSubject, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.cboTerm)
        Me.GroupControl1.Controls.Add(Me.cboCampus)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Location = New System.Drawing.Point(3, 3)
        Me.GroupControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(364, 85)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "GENERAL INFORMATION"
        '
        'cboTerm
        '
        Me.cboTerm.FormattingEnabled = True
        Me.cboTerm.Location = New System.Drawing.Point(111, 56)
        Me.cboTerm.Name = "cboTerm"
        Me.cboTerm.Size = New System.Drawing.Size(248, 21)
        Me.cboTerm.TabIndex = 3
        '
        'cboCampus
        '
        Me.cboCampus.FormattingEnabled = True
        Me.cboCampus.Location = New System.Drawing.Point(111, 29)
        Me.cboCampus.Name = "cboCampus"
        Me.cboCampus.Size = New System.Drawing.Size(248, 21)
        Me.cboCampus.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Academic Term:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Campus:"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.Label12)
        Me.GroupControl2.Controls.Add(Me.cboYearLevel)
        Me.GroupControl2.Controls.Add(Me.Label10)
        Me.GroupControl2.Controls.Add(Me.GroupControl4)
        Me.GroupControl2.Controls.Add(Me.cboAccount)
        Me.GroupControl2.Location = New System.Drawing.Point(3, 133)
        Me.GroupControl2.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(364, 269)
        Me.GroupControl2.TabIndex = 2
        Me.GroupControl2.Text = "SUBJECT ENTRY"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(5, 224)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Year Level:"
        '
        'cboYearLevel
        '
        Me.cboYearLevel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYearLevel.FormattingEnabled = True
        Me.cboYearLevel.Location = New System.Drawing.Point(10, 240)
        Me.cboYearLevel.Name = "cboYearLevel"
        Me.cboYearLevel.Size = New System.Drawing.Size(347, 22)
        Me.cboYearLevel.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(7, 184)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Account:"
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.cboSubjectID)
        Me.GroupControl4.Controls.Add(Me.lblCreditUnit)
        Me.GroupControl4.Controls.Add(Me.lblLectUnit)
        Me.GroupControl4.Controls.Add(Me.cboYLID)
        Me.GroupControl4.Controls.Add(Me.lblLabUnit)
        Me.GroupControl4.Controls.Add(Me.cboAcctID)
        Me.GroupControl4.Controls.Add(Me.lblLabHrs)
        Me.GroupControl4.Controls.Add(Me.cboTermID)
        Me.GroupControl4.Controls.Add(Me.lblLectHrs)
        Me.GroupControl4.Controls.Add(Me.cboCampusID)
        Me.GroupControl4.Controls.Add(Me.lblSubjectCode)
        Me.GroupControl4.Controls.Add(Me.Label9)
        Me.GroupControl4.Controls.Add(Me.Label8)
        Me.GroupControl4.Controls.Add(Me.Label7)
        Me.GroupControl4.Controls.Add(Me.Label6)
        Me.GroupControl4.Controls.Add(Me.Label5)
        Me.GroupControl4.Controls.Add(Me.Label4)
        Me.GroupControl4.Location = New System.Drawing.Point(1, 20)
        Me.GroupControl4.LookAndFeel.SkinName = "Seven Classic"
        Me.GroupControl4.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(362, 159)
        Me.GroupControl4.TabIndex = 4
        Me.GroupControl4.Text = "SUBJECT INFORMATION"
        '
        'cboSubjectID
        '
        Me.cboSubjectID.FormattingEnabled = True
        Me.cboSubjectID.Location = New System.Drawing.Point(271, 21)
        Me.cboSubjectID.Name = "cboSubjectID"
        Me.cboSubjectID.Size = New System.Drawing.Size(71, 21)
        Me.cboSubjectID.TabIndex = 25
        Me.cboSubjectID.Visible = False
        '
        'lblCreditUnit
        '
        Me.lblCreditUnit.AutoSize = True
        Me.lblCreditUnit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreditUnit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCreditUnit.Location = New System.Drawing.Point(149, 142)
        Me.lblCreditUnit.Name = "lblCreditUnit"
        Me.lblCreditUnit.Size = New System.Drawing.Size(22, 13)
        Me.lblCreditUnit.TabIndex = 23
        Me.lblCreditUnit.Text = "---"
        '
        'lblLectUnit
        '
        Me.lblLectUnit.AutoSize = True
        Me.lblLectUnit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLectUnit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLectUnit.Location = New System.Drawing.Point(149, 120)
        Me.lblLectUnit.Name = "lblLectUnit"
        Me.lblLectUnit.Size = New System.Drawing.Size(22, 13)
        Me.lblLectUnit.TabIndex = 22
        Me.lblLectUnit.Text = "---"
        '
        'cboYLID
        '
        Me.cboYLID.FormattingEnabled = True
        Me.cboYLID.Location = New System.Drawing.Point(271, 124)
        Me.cboYLID.Name = "cboYLID"
        Me.cboYLID.Size = New System.Drawing.Size(55, 21)
        Me.cboYLID.TabIndex = 15
        Me.cboYLID.Visible = False
        '
        'lblLabUnit
        '
        Me.lblLabUnit.AutoSize = True
        Me.lblLabUnit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabUnit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLabUnit.Location = New System.Drawing.Point(149, 97)
        Me.lblLabUnit.Name = "lblLabUnit"
        Me.lblLabUnit.Size = New System.Drawing.Size(22, 13)
        Me.lblLabUnit.TabIndex = 21
        Me.lblLabUnit.Text = "---"
        '
        'cboAcctID
        '
        Me.cboAcctID.FormattingEnabled = True
        Me.cboAcctID.Location = New System.Drawing.Point(271, 99)
        Me.cboAcctID.Name = "cboAcctID"
        Me.cboAcctID.Size = New System.Drawing.Size(55, 21)
        Me.cboAcctID.TabIndex = 21
        Me.cboAcctID.Visible = False
        '
        'lblLabHrs
        '
        Me.lblLabHrs.AutoSize = True
        Me.lblLabHrs.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabHrs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLabHrs.Location = New System.Drawing.Point(149, 74)
        Me.lblLabHrs.Name = "lblLabHrs"
        Me.lblLabHrs.Size = New System.Drawing.Size(22, 13)
        Me.lblLabHrs.TabIndex = 20
        Me.lblLabHrs.Text = "---"
        '
        'cboTermID
        '
        Me.cboTermID.FormattingEnabled = True
        Me.cboTermID.Location = New System.Drawing.Point(271, 74)
        Me.cboTermID.Name = "cboTermID"
        Me.cboTermID.Size = New System.Drawing.Size(55, 21)
        Me.cboTermID.TabIndex = 20
        Me.cboTermID.Visible = False
        '
        'lblLectHrs
        '
        Me.lblLectHrs.AutoSize = True
        Me.lblLectHrs.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLectHrs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLectHrs.Location = New System.Drawing.Point(149, 51)
        Me.lblLectHrs.Name = "lblLectHrs"
        Me.lblLectHrs.Size = New System.Drawing.Size(22, 13)
        Me.lblLectHrs.TabIndex = 19
        Me.lblLectHrs.Text = "---"
        '
        'cboCampusID
        '
        Me.cboCampusID.FormattingEnabled = True
        Me.cboCampusID.Location = New System.Drawing.Point(271, 51)
        Me.cboCampusID.Name = "cboCampusID"
        Me.cboCampusID.Size = New System.Drawing.Size(55, 21)
        Me.cboCampusID.TabIndex = 4
        Me.cboCampusID.Visible = False
        '
        'lblSubjectCode
        '
        Me.lblSubjectCode.AutoSize = True
        Me.lblSubjectCode.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubjectCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSubjectCode.Location = New System.Drawing.Point(149, 29)
        Me.lblSubjectCode.Name = "lblSubjectCode"
        Me.lblSubjectCode.Size = New System.Drawing.Size(22, 13)
        Me.lblSubjectCode.TabIndex = 18
        Me.lblSubjectCode.Text = "---"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gray
        Me.Label9.Location = New System.Drawing.Point(6, 142)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "CREDITED UNIT:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gray
        Me.Label8.Location = New System.Drawing.Point(8, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "LABORATORY UNIT:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(8, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "LECTURE UNIT:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(8, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "LABORATORY HOUR:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(10, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "LECTURE HOUR:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(10, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "SUBJECT CODE:"
        '
        'cboAccount
        '
        Me.cboAccount.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAccount.FormattingEnabled = True
        Me.cboAccount.Location = New System.Drawing.Point(10, 200)
        Me.cboAccount.Name = "cboAccount"
        Me.cboAccount.Size = New System.Drawing.Size(347, 22)
        Me.cboAccount.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Subject Title:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(3, 410)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 13)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "REMARKS:"
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Location = New System.Drawing.Point(3, 426)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRemarks.Size = New System.Drawing.Size(364, 49)
        Me.txtRemarks.TabIndex = 16
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdSave.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSave.Location = New System.Drawing.Point(553, 553)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(93, 30)
        Me.cmdSave.TabIndex = 18
        Me.cmdSave.Text = "&Save"
        '
        'cmdCancel
        '
        Me.cmdCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdCancel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Image = CType(resources.GetObject("cmdCancel.Image"), System.Drawing.Image)
        Me.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancel.Location = New System.Drawing.Point(652, 553)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(93, 30)
        Me.cmdCancel.TabIndex = 19
        Me.cmdCancel.Text = "&Cancel"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.Label16)
        Me.GroupControl3.Controls.Add(Me.Label15)
        Me.GroupControl3.Controls.Add(Me.txtLabFee)
        Me.GroupControl3.Controls.Add(Me.txtTuitionFee)
        Me.GroupControl3.Controls.Add(Me.chkLF)
        Me.GroupControl3.Controls.Add(Me.chkTF)
        Me.GroupControl3.Controls.Add(Me.Label14)
        Me.GroupControl3.Controls.Add(Me.txtAmount)
        Me.GroupControl3.Location = New System.Drawing.Point(6, 481)
        Me.GroupControl3.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(362, 116)
        Me.GroupControl3.TabIndex = 22
        Me.GroupControl3.Text = "AMOUNT SETUP"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(309, 88)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(42, 13)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "Unit/s"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(309, 62)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(42, 13)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Unit/s"
        '
        'txtLabFee
        '
        Me.txtLabFee.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLabFee.Location = New System.Drawing.Point(176, 83)
        Me.txtLabFee.Name = "txtLabFee"
        Me.txtLabFee.Size = New System.Drawing.Size(132, 26)
        Me.txtLabFee.TabIndex = 16
        Me.txtLabFee.Text = "0.00"
        '
        'txtTuitionFee
        '
        Me.txtTuitionFee.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTuitionFee.Location = New System.Drawing.Point(176, 55)
        Me.txtTuitionFee.Name = "txtTuitionFee"
        Me.txtTuitionFee.Size = New System.Drawing.Size(132, 26)
        Me.txtTuitionFee.TabIndex = 15
        Me.txtTuitionFee.Text = "0.00"
        '
        'chkLF
        '
        Me.chkLF.AutoSize = True
        Me.chkLF.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkLF.Location = New System.Drawing.Point(14, 88)
        Me.chkLF.Name = "chkLF"
        Me.chkLF.Size = New System.Drawing.Size(137, 18)
        Me.chkLF.TabIndex = 14
        Me.chkLF.Text = "Use Lab Fee Rate @"
        Me.chkLF.UseVisualStyleBackColor = True
        '
        'chkTF
        '
        Me.chkTF.AutoSize = True
        Me.chkTF.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkTF.Location = New System.Drawing.Point(14, 60)
        Me.chkTF.Name = "chkTF"
        Me.chkTF.Size = New System.Drawing.Size(156, 18)
        Me.chkTF.TabIndex = 13
        Me.chkTF.Text = "Use Tuition Fee Rate @"
        Me.chkTF.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(11, 31)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 13)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "AMOUNT:"
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(134, 24)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(217, 26)
        Me.txtAmount.TabIndex = 12
        Me.txtAmount.Text = "0.00"
        '
        'StyleController1
        '
        Me.StyleController1.LookAndFeel.SkinName = "VS2010"
        Me.StyleController1.LookAndFeel.UseDefaultLookAndFeel = False
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(373, 3)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(378, 544)
        Me.XtraTabControl1.TabIndex = 24
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.lvPrograms)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(372, 516)
        Me.XtraTabPage1.Text = "Academic Programs"
        '
        'lvPrograms
        '
        Me.lvPrograms.CheckBoxes = True
        Me.lvPrograms.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvPrograms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvPrograms.FullRowSelect = True
        Me.lvPrograms.GridLines = True
        Me.lvPrograms.Location = New System.Drawing.Point(0, 0)
        Me.lvPrograms.Name = "lvPrograms"
        Me.lvPrograms.Size = New System.Drawing.Size(372, 516)
        Me.lvPrograms.TabIndex = 0
        Me.lvPrograms.UseCompatibleStateImageBehavior = False
        Me.lvPrograms.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "CODE"
        Me.ColumnHeader1.Width = 94
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "ID"
        Me.ColumnHeader2.Width = 0
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ACAD. PROGRAMS"
        Me.ColumnHeader3.Width = 244
        '
        'txtSubject
        '
        Me.txtSubject.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.txtSubject.Caption = ""
        Me.txtSubject.CaptionHeight = 17
        Me.txtSubject.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtSubject.ColumnCaptionHeight = 17
        Me.txtSubject.ColumnFooterHeight = 17
        Me.txtSubject.ContentHeight = 15
        Me.txtSubject.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.txtSubject.EditorBackColor = System.Drawing.SystemColors.Window
        Me.txtSubject.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubject.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSubject.EditorHeight = 15
        Me.txtSubject.Images.Add(CType(resources.GetObject("txtSubject.Images"), System.Drawing.Image))
        Me.txtSubject.ItemHeight = 15
        Me.txtSubject.Location = New System.Drawing.Point(3, 107)
        Me.txtSubject.MatchEntryTimeout = CType(2000, Long)
        Me.txtSubject.MaxDropDownItems = CType(20, Short)
        Me.txtSubject.MaxLength = 32767
        Me.txtSubject.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.txtSubject.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.txtSubject.Size = New System.Drawing.Size(365, 21)
        Me.txtSubject.TabIndex = 25
        Me.txtSubject.PropBag = resources.GetString("txtSubject.PropBag")
        '
        'frmSubjectSpecialFee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 602)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSubjectSpecialFee"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Enrollment - Subject With Special Fee"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.StyleController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.txtSubject, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cboTerm As System.Windows.Forms.ComboBox
    Friend WithEvents cboCampus As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboAccount As System.Windows.Forms.ComboBox
    Friend WithEvents cboYearLevel As System.Windows.Forms.ComboBox
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cboCampusID As System.Windows.Forms.ComboBox
    Friend WithEvents cboTermID As System.Windows.Forms.ComboBox
    Friend WithEvents cboAcctID As System.Windows.Forms.ComboBox
    Friend WithEvents cboYLID As System.Windows.Forms.ComboBox
    Friend WithEvents lblCreditUnit As System.Windows.Forms.Label
    Friend WithEvents lblLectUnit As System.Windows.Forms.Label
    Friend WithEvents lblLabUnit As System.Windows.Forms.Label
    Friend WithEvents lblLabHrs As System.Windows.Forms.Label
    Friend WithEvents lblLectHrs As System.Windows.Forms.Label
    Friend WithEvents lblSubjectCode As System.Windows.Forms.Label
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtLabFee As System.Windows.Forms.TextBox
    Friend WithEvents txtTuitionFee As System.Windows.Forms.TextBox
    Friend WithEvents chkLF As System.Windows.Forms.CheckBox
    Friend WithEvents chkTF As System.Windows.Forms.CheckBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents StyleController1 As DevExpress.XtraEditors.StyleController
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lvPrograms As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cboSubjectID As System.Windows.Forms.ComboBox
    Friend WithEvents txtSubject As C1.Win.C1List.C1Combo

End Class
