Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class Assessment
    Public EnrollmentID As String

    Dim curStudentSchoolYearTitle As String
    Dim curStudentYearLevelID As Integer

    Dim EnrolIDType As IDType
    Dim EnrolmentTermID As Integer

    Private dvMain As DataView

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DisableControls()

        fillCombo(cboTrans, "SELECT TransName FROM tblFinancialTransactions WHERE `InAccounting` <> 0")
        fillCombo(cboTransID, "SELECT TransID FROM TblFinancialTransactions WHERE `InAccounting` <> 0")
        cmdApply.Enabled = False
        cmdReset.Enabled = False
    End Sub
    Private Sub EnableControls()
        cmdReset.Enabled = True
        cmdReload.Enabled = True
        cmdCloseStudent.Enabled = True
        cmdLedger.Enabled = True
        cmdBillingSummary.Enabled = True
        cmdSettings.Enabled = True
    End Sub
    Private Sub DisableControls()
        cmdReset.Enabled = False
        cmdReload.Enabled = False
        cmdCloseStudent.Enabled = False
        cmdLedger.Enabled = False
        cmdBillingSummary.Enabled = False
        cmdSettings.Enabled = False
    End Sub
    Private Sub ShowStudentRegistrationTransaction(ByVal StudentNo As String)
        Dim com As New MySqlCommand("SELECT EnrolmentID AS `Reg.ID.`,fnAcademicYearTerm(TermID) AS `A.Y. Term`,DateEnroled AS `Reg. Date`,ValidationDate AS `Validation Date`,fnCampusName(CampusID) AS `Campus Name` FROM tblEnrolment WHERE StudentID='" & StudentNo & "'", con)
        Dim daAccount As New MySqlDataAdapter()
        Dim dtAccount As New DataTable
        Dim dsAccount As New DataSet
        Dim BS As New BindingSource


        daAccount.SelectCommand = com
        daAccount.Fill(dtAccount)
        cboRef.SelectedIndex = -1
        cboRef.Items.Clear()

        cboRef.DataSource = dtAccount
        cboRef.DisplayColumnNames = Nothing
        cboRef.DataBind()
        daAccount.Dispose()

    End Sub

    Private Sub ShowStudentAssessment(ByVal pTransType As Integer, ByVal pRefNo As String, _
                                      ByVal pIDType As Integer)
        Dim com As New MySqlCommand("CALL GetAssessment(" & pTransType & ",'" & pRefNo & "','" & pIDType & "')", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        lvDetails.Items.Clear()
        While vRS.Read
            Dim lv As New ListViewItem(vRS("AcctCode").ToString())
            lv.SubItems.Add(vRS("AcctName").ToString())
            lv.SubItems.Add(vRS("Assess_Fee").ToString())
            lv.SubItems.Add(vRS("FinancialAid").ToString())
            lv.SubItems.Add(vRS("Debit").ToString())
            lv.SubItems.Add(vRS("1st Payment").ToString())
            lv.SubItems.Add(vRS("2nd Payment").ToString())
            lv.SubItems.Add(vRS("3rd Payment").ToString())
            lv.SubItems.Add(vRS("PaymentDiscount").ToString())
            lv.SubItems.Add(vRS("Credit").ToString())
            lv.SubItems.Add(vRS("Balance").ToString())
            lv.SubItems.Add(vRS("Remarks").ToString())
            lv.SubItems.Add(vRS("EntryID").ToString())
            lv.SubItems.Add(vRS("AcctID").ToString())

            lvDetails.Items.AddRange(New ListViewItem() {lv})
        End While
        vRS.Close()

        lblItemCount.Text = lvDetails.Items.Count & " item(s)"
        lbl1st.Text = GetTotalFirstPayment(pTransType, pRefNo, pIDType, txtStudentID.Text)
        lbl2nd.Text = GetTotalSecondPayment(pTransType, pRefNo, pIDType, txtStudentID.Text)
        lbl3rd.Text = GetTotalThirdPayment(pTransType, pRefNo, pIDType, txtStudentID.Text)
        lblNetAssesed.Text = GetTotalNetAssessment(pTransType, pRefNo, pIDType, txtStudentID.Text)
        lblFinancialAid.Text = GetTotalFinancialAid(pTransType, pRefNo, pIDType, txtStudentID.Text)
        lblAssessed.Text = fnGetStudentAssessedFees(pTransType, pRefNo, pIDType, txtStudentID.Text)



        lblOutstandingBal.Text = StudentOutStandingBalance(txtStudentID.Text, EnrolmentTermID)


    End Sub

    Private Sub ShowStudentRegistration(ByVal EnrolmentID As String)

        Dim Enl As tEnrolment
        Dim Term As tSchoolYear

        Dim com As New MySqlCommand("CALL GetStudentEnrolledSubject('" & EnrolmentID & "')", con)
        Dim dr As MySqlDataReader = com.ExecuteReader()

        lvRegistration.Items.Clear()
        While dr.Read()
            Dim lv As New ListViewItem(dr("SubjectCode").ToString())
            lv.SubItems.Add(dr("SubjectTitle").ToString())
            lv.SubItems.Add(dr("LabUnits").ToString())
            lv.SubItems.Add(dr("Units").ToString())
            lv.SubItems.Add(dr("CreditUnits").ToString())
            lv.SubItems.Add(dr("Section").ToString())
            lv.SubItems.Add(dr("Sched1").ToString())
            lv.SubItems.Add("")
            lv.SubItems.Add(dr("SID").ToString())
            lvRegistration.Items.AddRange(New ListViewItem() {lv})
        End While
        dr.Close()
        lblSubjectEnrolled.Text = getTotalSubjectEnrolled(EnrolmentID) & " Subjects Enrolled"
        lblSubCredit.Text = GetTotalEnrolledCreditUnits(EnrolmentID)
        lblRegLab.Text = GetTotalEnrolledLabUnits(EnrolmentID)
        lblRegLec.Text = GetTotalEnrolledLecUnits(EnrolmentID)


        If GetEnrolmentByID(EnrolmentID, Enl) = TranDBResult.Success Then
            lblAYTerm.Text = CurrentSchoolYear.SchoolYearTitle & " - " & CurrentSchoolYear.SchoolTerm
            EnrolmentTermID = Enl.TermID
            lblRegDate.Text = Enl.DateEnroled
            lblValidation.Text = Enl.ValidationDate
            lblRemarks.Text = "REGISTRATION"
        End If
    End Sub

    Private Sub ShowStudentDetails(ByVal StudentNo As String)
        Dim stud As tStudent
        If GetStudentByID(StudentNo, stud) = TranDBResult.Success Then
            txtStudent.Text = UCase(stud.LastName) & ", " & stud.FirstName & " " & stud.MiddleName
            lblStudent.Text = stud.StudentNo
            lblYL.Text = GetStudentYearLevel(stud.StudentNo)
            lblProgram.Text = GetStudentAcadProgram(stud.StudentNo)

            EnrolIDType = IDType.Student
        End If
    End Sub

    Private Sub ShowEnrolmentAssessment(ByVal pTransType As Integer, ByVal EnrolmentID As String, ByVal pIDType As Integer)
        Dim com As New MySqlCommand("CALL GetAssessment('")
    End Sub

    Private Sub BillingSummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBillingSummary.Click
        Dim frm As New frmBillingSummary()
        frm.Show()
    End Sub
    Private Sub cmdApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBillingToolStripMenuItem.Click, cmdApply.Click
        Dim Sum As Decimal
        Dim Debit As Decimal
        Dim First As Decimal

        If optAmount.Checked = True Then
            For Each lv As ListViewItem In lvDetails.Items
                For Each ls As ListViewItem In lvGrantDetails.Items
                    If lv.SubItems(13).Text = ls.SubItems(1).Text Then
                        Sum = Val(lv.SubItems(2).Text) - Val(ls.SubItems(2).Text)
                        Debit = Val(lv.SubItems(2).Text) - Val(Sum)
                        First = Val(lv.SubItems(2).Text) - Val(Sum)

                        Dim com As New MySqlCommand("UPDATE tblJournals SET Discount=@Disc, Debit=@Debit,`1st Payment`=@first WHERE ReferenceNo='" & cboRef.Text & "' AND AccountID='" & lv.SubItems(13).Text & "'", con)
                        com.Parameters.Add("@Disc", MySqlDbType.Decimal).Value = Sum.ToString("#,##0.00")
                        com.Parameters.Add("@Debit", MySqlDbType.Decimal).Value = Debit.ToString("#,##0.00")
                        com.Parameters.Add("@first", MySqlDbType.Decimal).Value = First.ToString("#,##0.00")
                        com.ExecuteNonQuery()
                    End If
                Next
            Next
        End If

        If optRate.Checked = True Then
            For Each lv As ListViewItem In lvDetails.Items
                For Each ls As ListViewItem In lvGrantDetails.Items
                    If lv.SubItems(13).Text = ls.SubItems(1).Text Then
                        Sum = Val(lv.SubItems(2).Text) * (Val(ls.SubItems(3).Text) / 100)
                        Debit = Val(lv.SubItems(2).Text) - Val(Sum)
                        First = Val(lv.SubItems(2).Text) - Val(Sum)

                        Dim com As New MySqlCommand("UPDATE tblJournals SET Discount=@Disc, Debit=@Debit,`1st Payment`=@first WHERE ReferenceNo='" & cboRef.Text & "' AND AccountID='" & lv.SubItems(13).Text & "'", con)
                        com.Parameters.Add("@Disc", MySqlDbType.Decimal).Value = Sum.ToString("#,##0.00")
                        com.Parameters.Add("@Debit", MySqlDbType.Decimal).Value = Debit.ToString("#,##0.00")
                        com.Parameters.Add("@first", MySqlDbType.Decimal).Value = First.ToString("#,##0.00")
                        com.ExecuteNonQuery()
                    End If
                Next
            Next
        End If

        ShowStudentAssessment(cboTransID.Text, cboRef.Text, EnrolIDType)

    End Sub


    Private Sub cmdStudentInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStudentInfo.Click
        If txtStudentID.Text = "" Then Exit Sub

        'frmStudentRecord.ShowForm(txtStudentID.Text)
    End Sub



    Private Sub cmdReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MsgBox("Warning: Resetting student assessment may loss all the billing, payables and paid accounts of the student" & vbNewLine & _
                  "Are you sure to proceed?", vbExclamation + vbYesNo) = vbYes Then
            MsgBox("Sorry no function yet", vbExclamation)
        End If
    End Sub


    Private Sub txtStudent_ButtonClick(sender As System.Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtStudent.ButtonClick
        Dim frm As New frmBrowse()
        txtStudentID.Text = frm.ShowForm()

        If txtStudentID.Text = "" Then Exit Sub
        ShowStudentDetails(txtStudentID.Text)
    End Sub

    Private Sub cboGrantTemplate_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboGrantTemplate.SelectedIndexChanged
        cboGrantTemplateID.SelectedIndex = cboGrantTemplate.SelectedIndex

        FillListView("SELECT fnAccountName(AcctID),AcctID,Amount,Percentage FROM tblSchoGrantTemplate_Details WHERE GrantTemplateID='" & cboGrantTemplateID.Text & "'", lvGrantDetails, False)
    End Sub

    Private Sub cboTrans_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboTrans.SelectedIndexChanged
        cboTransID.SelectedIndex = cboTrans.SelectedIndex

        Select Case cboTransID.Text
            Case TransactionType.Enrollment
                ShowStudentRegistrationTransaction(txtStudentID.Text)
            Case TransactionType.Beginning_Balance
            Case TransactionType.Add_Drop_Change_Subject
            Case TransactionType.Graduation
            Case TransactionType.Transcript_of_Record
            Case TransactionType.Admission_Testing
            Case TransactionType.Other_Assessment
            Case Else
                cboRef.Items.Clear()
        End Select
    End Sub

    Private Sub cboRef_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboRef.SelectedIndexChanged
        'On Error GoTo err

        ShowStudentRegistration(cboRef.Text)

        Select Case XtraTabControl2.SelectedTabPageIndex
            Case 0
                EnrolIDType = IDType.Student
            Case 1
                EnrolIDType = IDType.Scholar_Prov
            Case 2
                EnrolIDType = IDType.Employee
            Case 3
                EnrolIDType = IDType.Others
        End Select

        ShowStudentAssessment(cboTransID.Text, cboRef.Text, EnrolIDType)
        Exit Sub

err:
        DisplayErrorMsg("MainForm", "cboRef_SelectedIndexChanged", Err.Number, Err.Description)
        Exit Sub
    End Sub

    Private Sub lvRegistration_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lvRegistration.SelectedIndexChanged
        If lvRegistration.Items.Count > 0 Then
            lblStatSubject.Text = lvRegistration.FocusedItem.Text & " - " & lvRegistration.FocusedItem.SubItems(1).Text
        End If
    End Sub

    Private Sub XtraTabControl2_SelectedPageChanged(sender As System.Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl2.SelectedPageChanged

    End Sub

    Private Sub XtraTabControl2_SelectedPageChanging(sender As System.Object, e As DevExpress.XtraTab.TabPageChangingEventArgs) Handles XtraTabControl2.SelectedPageChanging
        Select Case XtraTabControl2.SelectedTabPageIndex
            Case 0
                EnrolIDType = IDType.Student
            Case 1
                EnrolIDType = IDType.Scholar_Prov
            Case 2
                EnrolIDType = IDType.Employee
            Case 3
                EnrolIDType = IDType.Others
        End Select
    End Sub

    Private Sub GroupControl3_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles GroupControl3.Paint

    End Sub

    Private Sub txtAid_ButtonClick(sender As System.Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtAid.ButtonClick
        Dim frm As New PickScholarship()
        Dim frm1 As New PickGuarantor()

        If optScho.Checked = True Then
            frm.ShowForm(EnrolmentTermID, lblGrantID.Text, txtAid.Text)

            If txtAid.Text <> "" Then XtraTabControl3.Enabled = True : cmdApply.Enabled = True : fillCombo(cboGrantTemplate, "SELECT CONCAT(TemplateCode,' - ', Description) FROM tblSchoGrantTemplates WHERE SchoProviderID='" & lblGrantID.Text & "'") : fillCombo(cboGrantTemplateID, "SELECT GrantTemplateID FROM tblSchoGrantTemplates WHERE SchoProviderID='" & lblGrantID.Text & "'")
        ElseIf optGuarantor.Checked = True Then

            If txtAid.Text <> "" Then XtraTabControl3.Enabled = True : cmdApply.Enabled = True
        Else
            cmdApply.Enabled = False
            XtraTabControl3.Enabled = False
            Exit Sub
        End If


    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optHalfFullTuition.CheckedChanged
        If optHalfFullTuition.Checked = True Then
            txtPercentTuition.Visible = True
        Else
            optHalfFullAllAccounts.Checked = False
            txtPercentAllAccounts.Visible = False
        End If
    End Sub

    Private Sub optHalfFullAllAccounts_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optHalfFullAllAccounts.CheckedChanged
        If optHalfFullAllAccounts.Checked = True Then
            txtPercentAllAccounts.Visible = True
        Else
            optHalfFullTuition.Checked = False
            txtPercentTuition.Visible = False
        End If
    End Sub

    Private Sub cmdDetails_Click(sender As System.Object, e As System.EventArgs) Handles cmdDetails.Click
        If cboGrantTemplate.Text <> "" Then
            Dim frm As New GrantTemplateDetails()
            frm.ShowForm(cboGrantTemplateID.Text)
        End If
    End Sub

    Private Sub optAmount_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optAmount.CheckedChanged
        If optAmount.Checked = True Then
            optRate.Checked = False
        Else
            optRate.Checked = True
        End If
    End Sub

    Private Sub optRate_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optRate.CheckedChanged
        If optRate.Checked = True Then
            optAmount.Checked = False
        Else
            optRate.Checked = False
        End If
    End Sub

    Private Sub optScho_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optScho.CheckedChanged
        If optScho.Checked = True Then
            XtraTabControl3.Enabled = True : cmdApply.Enabled = True
        Else
            XtraTabControl3.Enabled = False : cmdApply.Enabled = False
            txtAid.Text = ""
            lblGrantID.Text = ""
        End If
    End Sub

    Private Sub optGuarantor_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optGuarantor.CheckedChanged
        If optGuarantor.Checked = True Then
            XtraTabPage9.PageEnabled = False
            cmdApply.Enabled = True
            XtraTabControl3.Enabled = True
        Else
            XtraTabControl3.Enabled = False : cmdApply.Enabled = False
            txtAid.Text = ""
            lblGrantID.Text = ""
        End If
    End Sub


End Class
