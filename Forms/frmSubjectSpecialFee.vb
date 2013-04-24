Option Explicit On

Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Drawing

Public Class frmSubjectSpecialFee

    Dim State As FormState
    Private dvMain As DataView
    Dim AcctID As String = ""
    Dim SwfID As String

    Public Sub ShowForm()

        State = FormState.addFormState

        'GetNewSWFID(SwfID)

        chkTF_CheckedChanged(Me, New System.EventArgs())

        Me.ShowDialog()

    End Sub

    Public Sub ShowEdit(ByVal SWFID As String, ByVal CampusID As Integer)
        Dim SWF As SubjectWithFee
        Dim Camp As tSchool
        Dim Term As tSchoolYear

        State = FormState.updateFormState

        'If GetSubjectWithFeeByID(SWFID, CampusID, SWF) = TranDBResult.Success Then

        '    If GetCampusByCampusID(CampusID, Camp) = TranDBResult.Success Then
        '        cboCampus.Text = Camp.CampusName
        '        cboCampusID.Text = CampusID

        '        cboCampus_SelectedIndexChanged(Me, New System.EventArgs())

        '    End If

        '    If GetAcademicYearTerm(SWF.TermID, Term) = TranDBResult.Success Then
        '        cboTerm.Text = Term.SchoolYearTitle & " - " & Term.SchoolTerm
        '        cboTermID.Text = SWF.TermID
        '    End If

        '    Dim com As New MySqlCommand("SELECT Description,SubjectCode,LecHrs,LabHrs,LabUnits,Units,CreditUnits,SubjectID FROM tblSubject " & _
        '                           "WHERE SubjectID='" & SWF.SubjectID & "'", con)

        '    Dim vRS As MySqlDataReader = com.ExecuteReader
        '    vRS.Read()
        '    If vRS.HasRows Then
        '        txtSubject.Text = vRS("Description").ToString()
        '        lblCreditUnit.Text = vRS("CreditUnits").ToString()
        '        lblLabHrs.Text = vRS("LabHrs").ToString()
        '        lblLabUnit.Text = vRS("LabUnits").ToString()
        '        lblLectHrs.Text = vRS("LecHrs").ToString()
        '        lblLectUnit.Text = vRS("Units").ToString()
        '        lblSubjectCode.Text = vRS("SubjectCode").ToString()
        '    End If
        ' vRS.Close()

        'chkLF.Checked = IntToBoolean(SWF.IsLFRate)
        'chkTF.Checked = IntToBoolean(SWF.IsTFRate)

        'txtTuitionFee.Text = SWF.TFUnits
        'txtLabFee.Text = SWF.LFUnits

        ''txtAmount.text = SWF.Amount

        'txtRemarks.Text = SWF.Remarks

        'End If

        ShowSubjectWithFeeDistribution(SWFID)

        Me.ShowDialog()

    End Sub

    Private Sub ShowSubjectWithFeeDistribution(ByVal SWFID As String)
        Dim com As New MySqlCommand("SELECT * FROM tblSubjectWithFee_Distribution WHERE SWFID='" & SWFID & "'", con)
        Dim vrS As MySqlDataReader = com.ExecuteReader
        While vrS.Read()
            For Each lv As ListViewItem In lvPrograms.Items
                If lv.SubItems(1).Text = vrS("ProgramID").ToString() Then
                    lv.Checked = True
                    lv.BackColor = Color.Orange
                ElseIf vrS("ProgramID").ToString = 0 Then
                    lv.Checked = True
                    lv.BackColor = Color.Orange
                Else
                    lv.Checked = False
                    lv.BackColor = Color.White
                End If
            Next
        End While
        vrS.Close()
    End Sub


    Private Sub frmSubjectSpecialFee_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        fillCombo(cboCampus, "SELECT CampusName FROM tblCampus")
        fillCombo(cboCampusID, "SELECT CampusID FROM tblCampus")

        fillCombo(cboTerm, "SELECT fnAcademicYearTerm(TermID) FROM tblAYTerm")
        fillCombo(cboTermID, "SELECT TermID FROM tblAYTerm")

        fillCombo(cboYearLevel, "SELECT YearLevelTitle FROM tblYearLevel")
        cboYearLevel.Items.Add("[All Year Level]")

        fillCombo(cboYLID, "SELECT YearLEvelID FROM tblYearLevel")
        cboYLID.Items.Add("0")

        fillCombo(cboAccount, "SELECT CONCAT(AcctCode,'-',AcctName) FROM tblAccounts")
        fillCombo(cboAcctID, "SELECT AcctID FROM tblAccounts")


        LoadSubjectWithFee()

    End Sub



    Private Sub cboCampus_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboCampus.SelectedIndexChanged
        cboCampusID.SelectedIndex = cboCampus.SelectedIndex

        FillListView("SELECT ProgCode,ProgID,ProgName FROM tblPrograms WHERE CampusID='" & cboCampusID.Text & "'", lvPrograms, False)
    End Sub

    Private Sub cboTerm_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboTerm.SelectedIndexChanged
        cboTermID.SelectedIndex = cboTerm.SelectedIndex
    End Sub

    Private Sub cboAccount_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboAccount.SelectedIndexChanged
        cboAcctID.SelectedIndex = cboAccount.SelectedIndex
    End Sub

    Private Sub cboYearLevel_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboYearLevel.SelectedIndexChanged
        cboYLID.SelectedIndex = cboYearLevel.SelectedIndex
    End Sub

    Private Sub SaveData()

        Dim SWF As SubjectWithFee


        If Not CheckTextBox(txtAmount, "Please enter an Amount") Then HLTxt(txtAmount) : Exit Sub

        If cboAccount.Text = "" Then Exit Sub
        If cboCampus.Text = "" Then Exit Sub
        If cboTerm.Text = "" Then Exit Sub


        SWF.AccountID = cboAcctID.Text
        SWF.Amount = txtAmount.Text
        SWF.CampusID = cboCampusID.Text
        SWF.CreatedBy = CurrentUser.UserID
        SWF.CreatedDate = DateTime.Now.Date
        SWF.CurrencyID = 1
        SWF.IsLFRate = BooleanToInt(chkLF.Checked)
        SWF.IsTFRate = BooleanToInt(chkTF.Checked)
        SWF.LFUnits = txtLabFee.Text
        SWF.Remarks = txtRemarks.Text
        SWF.TermID = cboTermID.Text
        SWF.TFUnits = txtTuitionFee.Text
        SWF.YearLevelID = cboYLID.Text
        SWF.IndexID = CInt(SwfID)
        SWF.SubjectID = txtSubject.SelectedValue.ToString()
        SWF.Amount = CDec(txtAmount.Text)

        'Select Case SaveSubjectWithFee(SWF)
        '    Case TranDBResult.Success

        '        If lvPrograms.CheckedItems.Count = lvPrograms.Items.Count Then
        '            Dim com As New MySqlCommand("INSERT INTO tblSubjectWithFee_Distribution(SWFID,ProgramID,CreatedBy,CreatedDate) VALUES ('" & SwfID & "','0','" & CurrentUser.UserID & "','" & DateTime.Now.Date & "')", con)
        '            com.ExecuteNonQuery()
        '        Else
        '            For Each lv As ListViewItem In lvPrograms.Items
        '                If lv.Checked = True Then
        '                    Dim com As New MySqlCommand("INSERT INTO tblSubjectWithFee_Distribution(SWFID,ProgramID,CreatedBy,CreatedDate) VALUES " & _
        '                                                "('" & SwfID & "','" & lv.SubItems(1).Text & "','" & CurrentUser.UserID & "',NOW())", con)
        '                    com.ExecuteNonQuery()
        '                End If
        '            Next
        '        End If

        '        MsgBox("Record successfuly saved...", vbInformation)
        '        Close()
        '    Case TranDBResult.Failed

        'End Select

    End Sub

    Private Sub UpdateData()
        Dim SWF As SubjectWithFee


        If Not CheckTextBox(txtAmount, "Please enter an Amount") Then HLTxt(txtAmount) : Exit Sub

        If cboAccount.Text = "" Then Exit Sub
        If cboCampus.Text = "" Then Exit Sub
        If cboTerm.Text = "" Then Exit Sub


        SWF.AccountID = cboAcctID.Text
        SWF.Amount = txtAmount.Text
        SWF.CampusID = cboCampusID.Text
        SWF.CreatedBy = CurrentUser.UserID
        SWF.CreatedDate = DateTime.Now.Date
        SWF.CurrencyID = 1
        SWF.IsLFRate = BooleanToInt(chkLF.Checked)
        SWF.IsTFRate = BooleanToInt(chkTF.Checked)
        SWF.LFUnits = txtLabFee.Text
        SWF.Remarks = txtRemarks.Text
        SWF.TermID = cboTermID.Text
        SWF.TFUnits = txtTuitionFee.Text
        SWF.YearLevelID = cboYLID.Text
        SWF.IndexID = SwfID
        SWF.SubjectID = txtSubject.SelectedValue
        SWF.Amount = txtAmount.Text


        'Select Case UpdateSubjectWithFee(SWF)
        '    Case TranDBResult.Success

        '        Dim cm As New MySqlCommand("DELETE FROM tblSubjectWithFee_Distribution WHERE SWFID='" & SWF.IndexID & "'", con)
        '        cm.ExecuteNonQuery()

        '        If lvPrograms.CheckedItems.Count = lvPrograms.Items.Count Then
        '            Dim com As New MySqlCommand("INSERT INTO tblSubjectWithFee_Distribution(SWFID,ProgramID,CreatedBy,CreatedDate) VALUES ('" & SwfID & "','0','" & CurrentUser.UserID & "','" & DateTime.Now.Date & "')", con)
        '            com.ExecuteNonQuery()
        '        Else
        '            For Each lv As ListViewItem In lvPrograms.Items
        '                If lv.Checked = True Then
        '                    Dim com As New MySqlCommand("INSERT INTO tblSubjectWithFee_Distribution(SWFID,ProgramID,CreatedBy,CreatedDate) VALUES " & _
        '                                                "('" & SwfID & "','" & lv.SubItems(1).Text & "','" & CurrentUser.UserID & "',NOW())", con)
        '                    com.ExecuteNonQuery()
        '                End If
        '            Next
        '        End If

        '        MsgBox("Record successfuly updated...", vbInformation)
        '        Close()
        '    Case TranDBResult.Failed
        'End Select
    End Sub

    Private Sub cmdSave_Click(sender As System.Object, e As System.EventArgs) Handles cmdSave.Click
        Select Case State
            Case FormState.addFormState
                SaveData()
            Case FormState.updateFormState
                UpdateData()
        End Select
    End Sub

    Private Sub chkLF_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkLF.CheckedChanged
        If chkLF.Checked = True Then
            txtAmount.Enabled = False
            txtAmount.Text = "0.00"
            chkTF.Checked = False
        Else
            txtLabFee.Text = "0.00"
        End If
    End Sub

    Private Sub chkTF_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTF.CheckedChanged
        If chkTF.Checked = True Then
            txtAmount.Enabled = False
            txtAmount.Text = "0.00"
            chkLF.Checked = False
        Else
            txtTuitionFee.Text = "0.00"
        End If
    End Sub

    Private Sub cmdCancel_Click(sender As System.Object, e As System.EventArgs) Handles cmdCancel.Click
        Close()

    End Sub

    Private Sub LoadSubjectWithFee()
        Dim com As New MySqlCommand("SELECT SubjectCode AS `SUBJECT CODE`,Description AS `DESCRIPTIVE TITLE`,LecHrs AS `LECT. HRS.` ,LabHrs AS `LAB. HRS.`,LabUnits AS `LAB. UNITS`,Units AS `LECT. UNITS`,CreditUnits AS `CREDIT UNITS`,SubjectID AS `SUBJECT ID` FROM tblSubject", con)
        Dim daAccount As New MySqlDataAdapter()
        Dim dsAccount As New DataSet
        Dim BS As New BindingSource

        daAccount.SelectCommand = com
        daAccount.Fill(dsAccount)
        BS.DataSource = dsAccount.Tables(0).DefaultView
        Dim dvm As DataViewManager = New DataViewManager(dsAccount)
        dvMain = dvm.CreateDataView(dsAccount.Tables(0))

        txtSubject.DataSource = dvMain
        txtSubject.DisplayMember = "DESCRIPTIVE TITLE"
        txtSubject.ValueMember = "SUBJECT ID"
        txtSubject.ColumnWidth = "200"
        txtSubject.ColumnCaptionHeight = "30"

        txtSubject.HeadingStyle.Font = New System.Drawing.Font("Tahoma", 9)
        txtSubject.HeadingStyle.HorizontalAlignment = C1.Win.C1List.AlignVertEnum.Center
        txtSubject.HighLightRowStyle.Font = New System.Drawing.Font("Tahoma", 9, FontStyle.Bold)
        txtSubject.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Silver
    End Sub

    Private Sub txtSubject_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles txtSubject.SelectedValueChanged
        Dim com As New MySqlCommand("SELECT Description,SubjectCode,LecHrs,LabHrs,LabUnits,Units,CreditUnits,SubjectID FROM tblSubject " & _
                            "WHERE SubjectID='" & txtSubject.SelectedValue & "'", con)

        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            lblCreditUnit.Text = vRS("CreditUnits").ToString()
            lblLabHrs.Text = vRS("LabHrs").ToString()
            lblLabUnit.Text = vRS("LabUnits").ToString()
            lblLectHrs.Text = vRS("LecHrs").ToString()
            lblLectUnit.Text = vRS("Units").ToString()
            lblSubjectCode.Text = vRS("SubjectCode").ToString()
        Else
            lblCreditUnit.Text = ""
            lblLabHrs.Text = ""
            lblLabUnit.Text = ""
            lblLectHrs.Text = ""
            lblLectUnit.Text = ""
            lblSubjectCode.Text = ""
        End If
        vRS.Close()

        Select Case State
            Case FormState.updateFormState
                ShowSubjectWithFeeDistribution(txtSubject.SelectedValue)
        End Select

    End Sub
    Private Sub txtTuitionFee_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTuitionFee.TextChanged
        On Error Resume Next
        If chkTF.Checked = True Then
            Dim TF As Decimal = Val(txtTuitionFee.Text) * Val(lblLectUnit.Text)
            txtAmount.Text = TF.ToString("#,##0.00")
        End If
    End Sub

    Private Sub txtLabFee_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtLabFee.TextChanged
        On Error Resume Next
        If chkLF.Checked = True Then
            Dim LF As Decimal = Val(txtLabFee.Text) * Val(lblLabUnit.Text)
            txtAmount.Text = LF.ToString("#,##0.00")
        End If

    End Sub
End Class
