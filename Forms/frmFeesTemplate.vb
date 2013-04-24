Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors.Controls
Imports System.Windows.Forms
Imports System.Data
Imports System.Drawing

Public Class frmFeesTemplate

    Dim TransType As FeesTemplateTransType

    Dim EnrolState As FormState
    Dim GradState As FormState
    Dim ThesisState As FormState

    Dim EnrolTemplateID As String
    Dim GradTemplateID As String
    Dim ThesisTemplateID As String

    Private Enum PanelState
        OnDrop = 1
        OnClose = 0
    End Enum

    Dim sPanelState As PanelState

    Private Sub frmFeesTemplate_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        tabControl.TabPages.Remove(tabAirCondition)
        tabControl.TabPages.Remove(tabGraduation)
        tabControl.TabPages.Remove(tabAirCondition)
        tabControl.TabPages.Remove(tabSpecialFee)
        tabControl.TabPages.Remove(tabThesis)

        TransType = FeesTemplateTransType.Enrollment

        EnrolState = FormState.addFormState
        GradState = FormState.addFormState
        ThesisState = FormState.addFormState

        fillMultiColumnCombo2(cboEnrolCampus, "SELECT ShortName,CampusID FROM tblCampus")
        fillMultiColumnCombo2(cboEnrolTerm, "SELECT CONCAT(tblAYTerm.SchoolYear,' ',tblAYTerm.SchoolTerm) AS lvKey, tblAYTerm.TermID From tblAYTerm")

        fillMultiColumnCombo2(cboGradCampus, "SELECT ShortName,CampusID FROM tblCampus")
        fillMultiColumnCombo2(cboGradTerm, "SELECT CONCAT(tblAYTerm.SchoolYear,' ',tblAYTerm.SchoolTerm) AS lvKey, tblAYTerm.TermID From tblAYTerm")

        fillMultiColumnCombo2(cboThesisCampus, "SELECT ShortName,CampusID FROM tblCampus")
        fillMultiColumnCombo2(cboThesisTerm, "SELECT CONCAT(tblAYTerm.SchoolYear,' ',tblAYTerm.SchoolTerm) AS lvKey, tblAYTerm.TermID From tblAYTerm")

        fillCombo(cboPaymentOption, "SELECT PaymentOptionName FROM tblPaymentOptions")
        fillCombo(cboPaymentOptionID, "SELECT PaymentOptionID FROM tblPaymentOptions")

        fillToolStripCombo(cboSubCampus, "SELECT ShortName FROM tblCampus")
        fillToolStripCombo(cboSubCampusID, "SELECT CampusID FROM tblCampus")

        fillToolStripCombo(cboSubTerm, "SELECT fnAcademicYearTerm(TermID) FROM tblAYTerm")
        fillToolStripCombo(cboSubTermID, "SELECT TermID FROM tblAYTerm")

        FillListView("SELECT fnYearLevel(YearLevelID),YearLevelID FROM tblYearLevel", lvYearLevel, False)


        PanelYearLevel.Width = 0
        PanelYearLevel.Height = 0
        PanelProgram.Width = 0
        PanelProgram.Height = 0

        'Charge Subjects with Air Condition
        FillSubjectAirCon()
    End Sub

    Private Sub cmdGraduation_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdGraduation.LinkClicked
        tabControl.TabPages.Remove(tabAirCondition)
        tabControl.TabPages.Remove(tabEnrollment)
        tabControl.TabPages.Remove(tabAirCondition)
        tabControl.TabPages.Remove(tabSpecialFee)
        tabControl.TabPages.Remove(tabThesis)

        tabControl.TabPages.Add(tabGraduation)

        GradState = FormState.addFormState
        TransType = FeesTemplateTransType.Graduation

    End Sub

    Private Sub cmdEnrollment_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdEnrollment.LinkClicked
        tabControl.TabPages.Remove(tabAirCondition)
        tabControl.TabPages.Remove(tabGraduation)
        tabControl.TabPages.Remove(tabAirCondition)
        tabControl.TabPages.Remove(tabSpecialFee)
        tabControl.TabPages.Remove(tabThesis)

        tabControl.TabPages.Add(tabEnrollment)

        EnrolState = FormState.addFormState
        TransType = FeesTemplateTransType.Enrollment

    End Sub

    Private Sub cmdThesis_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdThesis.LinkClicked
        tabControl.TabPages.Remove(tabAirCondition)
        tabControl.TabPages.Remove(tabGraduation)
        tabControl.TabPages.Remove(tabAirCondition)
        tabControl.TabPages.Remove(tabSpecialFee)
        tabControl.TabPages.Remove(tabEnrollment)

        tabControl.TabPages.Add(tabThesis)

        ThesisState = FormState.addFormState
        TransType = FeesTemplateTransType.Thesis
    End Sub

    Private Sub cmdSpecial_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdSpecial.LinkClicked
        tabControl.TabPages.Remove(tabAirCondition)
        tabControl.TabPages.Remove(tabGraduation)
        tabControl.TabPages.Remove(tabAirCondition)
        tabControl.TabPages.Remove(tabThesis)
        tabControl.TabPages.Remove(tabEnrollment)

        tabControl.TabPages.Add(tabSpecialFee)
    End Sub

    Private Sub cmdAirCon_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdAirCon.LinkClicked
        tabControl.TabPages.Remove(tabSpecialFee)
        tabControl.TabPages.Remove(tabGraduation)
        tabControl.TabPages.Remove(tabAirCondition)
        tabControl.TabPages.Remove(tabThesis)
        tabControl.TabPages.Remove(tabEnrollment)

        tabControl.TabPages.Add(tabAirCondition)
    End Sub


    Private Sub dgEnroll_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgEnroll.CellClick
        Dim sFee As tTableofFees
        Dim Camp As tSchool
        Dim Opt As PaymentOptions

        If dgEnroll.RowCount > 0 Then
            Dim n As Integer = dgEnroll.CurrentRow.Index

            If GetFeeTemplateByTemplateID(dgEnroll.Rows(n).Cells(1).Value.ToString(), sFee) = TranDBResult.Success Then
                txtEnrolCode.Text = sFee.TemplateCode
                txtEnrolDesc.Text = sFee.TemplateDisc
                txtEnrolCurrency.Text = sFee.Currency
                txtEnrolRemarks.Text = sFee.TemplateRemarks
                chkEnrolStat.Checked = IntToBoolean(sFee.InActive)

                EnrolTemplateID = dgEnroll.Rows(n).Cells(1).Value.ToString()

                sFee.TemplateID = EnrolTemplateID

                Select Case sFee.StudentStatus
                    Case 0
                        optBothStudent.Checked = True
                    Case 1
                        optNewStudent.Checked = True
                    Case 2
                        optOldStudent.Checked = True
                End Select

                Select Case sFee.StudentGender
                    Case 0
                        optBothGender.Checked = True
                    Case 1
                        optMaleGender.Checked = True
                    Case 2
                        optFemaleGender.Checked = True
                End Select

                Select Case sFee.PaymentScheme
                    Case 0
                        optCash.Checked = True
                    Case 1
                        optSemestral.Checked = True
                    Case 2
                        optQuarterly.Checked = True
                    Case 3
                        optMonthly.Checked = True
                End Select

                If GetPaymenyOptionByOptionID(sFee.PaymentOption, Opt) = TranDBResult.Success Then
                    cboPaymentOption.Text = Opt.PaymentOptionName
                    cboPaymentOptionID.Text = Opt.PaymentOptionID
                End If

            End If

            Dim cm As New MySqlCommand("SELECT DISTINCT ProgID FROM tblTableOfFee_DistributionList WHERE TemplateID='" & dgEnroll.Rows(n).Cells(1).Value.ToString() & "'", con)
            Dim vRS As MySqlDataReader = cm.ExecuteReader()
            Dim str As [String] = ""
            txtProgram.Text = ""
            While vRS.Read
                For Each lv As ListViewItem In lvProgram.Items
                    If lv.SubItems(2).Text = vRS(0).ToString() Then
                        lv.Checked = True
                        str = lv.Text & ";" & str & " Only"
                    End If
                Next
            End While
            txtProgram.Text = str.ToString()
            vRS.Close()

            Dim com As New MySqlCommand("SELECT DISTINCT YearLevelID FROM tblTableOfFee_DistributionList WHERE TemplateID='" & dgEnroll.Rows(n).Cells(1).Value.ToString() & "'", con)
            Dim rs As MySqlDataReader = com.ExecuteReader()
            Dim strs As [String] = ""
            While rs.Read
                For Each ls As ListViewItem In lvYearLevel.Items
                    If ls.SubItems(1).Text = rs("YearLevelID").ToString() Then
                        ls.Checked = True
                        strs = ls.Text & ";" & strs & " Only"
                    End If
                Next
            End While
            txtYearLevel.Text = strs.ToString()
            rs.Close()
        End If
    End Sub

    Private Sub CreateTemplateToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CreateTemplateToolStripMenuItem.Click, cmdOutline.Click
        If dgEnroll.RowCount > 0 Then
            Dim n As Integer = dgEnroll.CurrentRow.Index

            Dim frm As New frmFeeTemplateOutline
            frm.ShowForm(dgEnroll.Rows(n).Cells(1).Value.ToString(), cboEnrolCampus.SelectedItem.Col2, cboEnrolTerm.SelectedItem.Col2)
        End If
    End Sub

    Private Sub cmdEnrolNew_Click(sender As System.Object, e As System.EventArgs) Handles cmdEnrolNew.Click
        EnrolState = FormState.addFormState

        txtEnrolCode.Text = ""
        txtEnrolCurrency.Text = ""
        txtEnrolDesc.Text = ""
        txtEnrolRemarks.Text = ""

        optBothGender.Checked = False
        optBothStudent.Checked = False
        optCash.Checked = False
        optFemaleGender.Checked = False
        optMaleGender.Checked = False
        optMonthly.Checked = False
        optNewStudent.Checked = False
        optOldStudent.Checked = False
        optQuarterly.Checked = False
        optSemestral.Checked = False

        cmdEnrolRefresh_Click(sender, e)

    End Sub

    Private Sub FillTemplate(ByVal TermID As Integer, ByVal CampusID As Integer, ByVal sTransType As Integer, ByRef dgView As DataGridView)
        Dim com As New MySqlCommand("SELECT TemplateCode,TemplateID,TemplateDesc,InActive FROM tblTableOfFees WHERE SchoolYear='" & TermID & "' AND CampusID='" & CampusID & "' AND TransType='" & sTransType & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        dgView.Rows.Clear()
        While vRS.Read()
            Dim n As Integer = dgView.Rows.Add()
            With dgView
                .Rows(n).Cells(0).Value = vRS("TemplateCode").ToString()
                .Rows(n).Cells(1).Value = vRS("TemplateID").ToString()
                .Rows(n).Cells(3).Value = vRS("TemplateDesc").ToString()
                .Rows(n).Cells(4).Value = IntToBoolean(vRS("InActive").ToString())

                .FirstDisplayedScrollingRowIndex = n
                .CurrentCell = .Rows(n).Cells(0)
                .Rows(n).Selected = True

            End With
        End While
        vRS.Close()
    End Sub

    Private Sub cboEnrolTerm_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboEnrolTerm.SelectedIndexChanged, cboEnrolCampus.SelectedIndexChanged
        If cboEnrolCampus.Text = "" Then Exit Sub

        FillListView("SELECT ProgCode,ProgName,ProgID FROM tblPrograms WHERE CampusID='" & cboEnrolCampus.SelectedItem.Col2 & "'", lvProgram, False)

        If cboEnrolTerm.Text = "" Then Exit Sub
        FillTemplate(cboEnrolTerm.SelectedItem.Col2, cboEnrolCampus.SelectedItem.Col2, FeesTemplateTransType.Enrollment, dgEnroll)

    End Sub

    Private Sub cmdEnrolRefresh_Click(sender As System.Object, e As System.EventArgs) Handles cmdEnrolRefresh.Click
        'If cboEnrolCampus.Text = "" Then Exit Sub
        'If cboEnrolTerm.Text = "" Then Exit Sub

        'FillTemplate(cboEnrolTerm.SelectedItem.Col2, cboEnrolCampus.SelectedItem.Col2, FeesTemplateTransType.Enrollment, dgEnroll)

        'For Each lv As CheckedListBoxItem In chkcboEnrolYL.Properties.GetItems
        '    If lv.CheckState = CheckState.Checked Then
        '        MsgBox(lv.Description)
        '    End If
        'Next


    End Sub

    Private Sub cmdEnrolSave_Click(sender As System.Object, e As System.EventArgs) Handles cmdEnrolSave.Click
        Select Case EnrolState
            Case FormState.addFormState
                SaveEnrollmentTemplate()
            Case FormState.updateFormState
                UpdateEnrollmentTemplate()
        End Select

    End Sub

    Private Sub cmdEnrolDelete_Click(sender As System.Object, e As System.EventArgs) Handles cmdEnrolDelete.Click
        If dgEnroll.RowCount > 0 Then
            If ExecuteDeleteFeeTemplate(dgEnroll.Rows(dgEnroll.CurrentRow.Index).Cells(1).Value.ToString()) = TranDBResult.Success Then
                cmdEnrolRefresh_Click(sender, e)
                cmdEnrolNew_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub SaveEnrollmentTemplate()

        Dim Prog() As String
        Dim Fee As tTableofFees
        Dim sFee As tTableOfFeeDistribution

        If cboEnrolCampus.Text = "" Then Exit Sub
        If cboEnrolTerm.Text = "" Then Exit Sub

        If Not CheckTextBox(txtEnrolCode, "Please enter Template Code for ENROLLMENT BILLING PROFILE") Then Exit Sub
        If Not CheckTextBox(txtEnrolDesc, "Please enter Template Description for ENROLLMENT BILLING PROFILE") Then Exit Sub
        If Not CheckTextBox(txtEnrolCurrency, "Please enter Currency (ex. PHP,USD) for ENROLLMENT BILLING PROFILE") Then Exit Sub

        Fee.TemplateCode = txtEnrolCode.Text
        Fee.TemplateDisc = txtEnrolDesc.Text
        Fee.TemplateRemarks = txtEnrolRemarks.Text
        Fee.Currency = txtEnrolCurrency.Text
        Fee.InActive = BooleanToInt(chkEnrolStat.Checked)

        Fee.CampusID = cboEnrolCampus.SelectedItem.Col2
        Fee.SchoolYear = cboEnrolTerm.SelectedItem.Col2

        Fee.TransType = FeesTemplateTransType.Enrollment

        If optBothStudent.Checked Then
            Fee.StudentStatus = StudentStatus.Both
        ElseIf optNewStudent.Checked Then
            Fee.StudentStatus = StudentStatus.sNew
        ElseIf optOldStudent.Checked Then
            Fee.StudentStatus = StudentStatus.Old
        End If

        If optBothGender.Checked Then
            Fee.StudentGender = StudentGender.Both
        ElseIf optFemaleGender.Checked Then
            Fee.StudentGender = StudentGender.Female
        ElseIf optMaleGender.Checked Then
            Fee.StudentGender = StudentGender.Male
        End If

        If optCash.Checked Then
            Fee.PaymentScheme = PaymentScheme.Cash
        ElseIf optSemestral.Checked Then
            Fee.PaymentScheme = PaymentScheme.Monthly
        ElseIf optQuarterly.Checked Then
            Fee.PaymentScheme = PaymentScheme.Quarterly
        ElseIf optSemestral.Checked Then
            Fee.PaymentScheme = PaymentScheme.Semestral
        End If

        Fee.PaymentOption = cboPaymentOptionID.Text

        For Each lv As ListViewItem In lvProgram.Items
            If lv.Checked = True Then

            End If
        Next

        For Each ls As ListViewItem In lvYearLevel.Items
            If ls.Checked = True Then

            End If
        Next

        Select Case SaveTableOfFees(Fee)

            Case TranDBResult.Success
                cmdEnrolRefresh_Click(Me, New System.EventArgs)

            Case TranDBResult.DuplicateCode
                CatchError("modFees", "SaveTableOfFees", "Error while saving Table of fees.. Duplicate Template Code found")
                Exit Sub
            Case TranDBResult.DuplicateID
                CatchError("modFees", "SaveTableOfFees", "Error while saving Table of fees.. Duplicate Template ID found")
                Exit Sub
        End Select

    End Sub

    Private Sub UpdateEnrollmentTemplate()
        Dim Prog() As String
        Dim Fee As tTableofFees

        If cboEnrolCampus.Text = "" Then Exit Sub
        If cboEnrolTerm.Text = "" Then Exit Sub

        If Not CheckTextBox(txtEnrolCode, "Please enter Template Code for ENROLLMENT BILLING PROFILE") Then Exit Sub
        If Not CheckTextBox(txtEnrolDesc, "Please enter Template Description for ENROLLMENT BILLING PROFILE") Then Exit Sub
        If Not CheckTextBox(txtEnrolCurrency, "Please enter Currency (ex. PHP,USD) for ENROLLMENT BILLING PROFILE") Then Exit Sub

        Fee.TemplateCode = txtEnrolCode.Text
        Fee.TemplateDisc = txtEnrolDesc.Text
        Fee.TemplateRemarks = txtEnrolRemarks.Text
        Fee.Currency = txtEnrolCurrency.Text
        Fee.InActive = BooleanToInt(chkEnrolStat.Checked)

        Fee.CampusID = cboEnrolCampus.SelectedItem.Col2
        Fee.SchoolYear = cboEnrolTerm.SelectedItem.Col2

        Fee.TransType = FeesTemplateTransType.Enrollment

        Fee.TemplateID = EnrolTemplateID

        If optBothStudent.Checked Then
            Fee.StudentStatus = StudentStatus.Both
        ElseIf optNewStudent.Checked Then
            Fee.StudentStatus = StudentStatus.sNew
        ElseIf optOldStudent.Checked Then
            Fee.StudentStatus = StudentStatus.Old
        End If

        If optBothGender.Checked Then
            Fee.StudentGender = StudentGender.Both
        ElseIf optFemaleGender.Checked Then
            Fee.StudentGender = StudentGender.Female
        ElseIf optMaleGender.Checked Then
            Fee.StudentGender = StudentGender.Male
        End If

        If optCash.Checked Then
            Fee.PaymentScheme = PaymentScheme.Cash
        ElseIf optSemestral.Checked Then
            Fee.PaymentScheme = PaymentScheme.Monthly
        ElseIf optQuarterly.Checked Then
            Fee.PaymentScheme = PaymentScheme.Quarterly
        ElseIf optSemestral.Checked Then
            Fee.PaymentScheme = PaymentScheme.Semestral
        End If

        Fee.PaymentOption = cboPaymentOptionID.Text


        'For i As Integer = 0 To chkcboEnrolYL.Properties.Items.Count - 1
        '    If chkcboEnrolYL.Properties.Items.GetCheckedValues(i) Then
        '        Dim SplitKey() As String
        '        SplitKey = Split(chkcboEnrolYL.SelectedText, "-")
        '    End If
        'Next

        Select Case UpdateTableOfFees(Fee)

            Case TranDBResult.Success
                cmdEnrolRefresh_Click(Me, New System.EventArgs)

            Case TranDBResult.DuplicateCode
                CatchError("modFees", "UpdateTableOfFees", "Error while updating Table of fees.. Duplicate Template Code found")
                Exit Sub
            Case TranDBResult.DuplicateID
                CatchError("modFees", "UpdateTableOfFees", "Error while updating Table of fees.. Duplicate Template ID found")
                Exit Sub
        End Select
    End Sub


    Private Sub SaveGraduationTemplate()

        Dim Prog() As String
        Dim Fee As tTableofFees

        If cboGradCampus.Text = "" Then Exit Sub
        If cboGradTerm.Text = "" Then Exit Sub

        If Not CheckTextBox(txtGradCode, "Please enter Template Code for ENROLLMENT BILLING PROFILE") Then Exit Sub
        If Not CheckTextBox(txtGradDesc, "Please enter Template Description for ENROLLMENT BILLING PROFILE") Then Exit Sub
        If Not CheckTextBox(txtGradCurrency, "Please enter Currency (ex. PHP,USD) for ENROLLMENT BILLING PROFILE") Then Exit Sub

        Fee.TemplateCode = txtGradCode.Text
        Fee.TemplateDisc = txtGradDesc.Text
        Fee.TemplateRemarks = txtGradRemarks.Text
        Fee.Currency = txtGradCurrency.Text
        Fee.InActive = BooleanToInt(chkGradStat.Checked)

        Fee.TransType = FeesTemplateTransType.Graduation

        Fee.CampusID = cboGradCampus.SelectedItem.Col2
        Fee.SchoolYear = cboGradTerm.SelectedItem.Col2

        If optBothStudent.Checked Then
            Fee.StudentStatus = StudentStatus.Both
        ElseIf optNewStudent.Checked Then
            Fee.StudentStatus = StudentStatus.sNew
        ElseIf optOldStudent.Checked Then
            Fee.StudentStatus = StudentStatus.Old
        End If

        If optBothGender.Checked Then
            Fee.StudentGender = StudentGender.Both
        ElseIf optFemaleGender.Checked Then
            Fee.StudentGender = StudentGender.Female
        ElseIf optMaleGender.Checked Then
            Fee.StudentGender = StudentGender.Male
        End If

        If optCash.Checked Then
            Fee.PaymentScheme = PaymentScheme.Cash
        ElseIf optSemestral.Checked Then
            Fee.PaymentScheme = PaymentScheme.Monthly
        ElseIf optQuarterly.Checked Then
            Fee.PaymentScheme = PaymentScheme.Quarterly
        ElseIf optSemestral.Checked Then
            Fee.PaymentScheme = PaymentScheme.Semestral
        End If

        Fee.PaymentOption = cboPaymentOptionID.Text


        'For i As Integer = 0 To chkcboGradYL.Properties.Items.Count - 1
        '    If chkcboGradYL.Properties.Items.GetCheckedValues(i) Then
        '        Dim SplitKey() As String
        '        SplitKey = Split(chkcboGradYL.SelectedText, "-")
        '    End If
        'Next

        Select Case SaveTableOfFeesThesisGrad(Fee)

            Case TranDBResult.Success
                cmdGradRefresh_Click(Me, New System.EventArgs)

            Case TranDBResult.DuplicateCode
                CatchError("modFees", "SaveTableOfFees", "Error while saving Table of fees.. Duplicate Template Code found")
                Exit Sub
            Case TranDBResult.DuplicateID
                CatchError("modFees", "SaveTableOfFees", "Error while saving Table of fees.. Duplicate Template ID found")
                Exit Sub
        End Select

    End Sub

    Private Sub UpdateGraduationTemplate()
        Dim Prog() As String
        Dim Fee As tTableofFees

        If cboGradCampus.Text = "" Then Exit Sub
        If cboGradTerm.Text = "" Then Exit Sub

        If Not CheckTextBox(txtGradCode, "Please enter Template Code for GradLMENT BILLING PROFILE") Then Exit Sub
        If Not CheckTextBox(txtGradDesc, "Please enter Template Description for GradLMENT BILLING PROFILE") Then Exit Sub
        If Not CheckTextBox(txtGradCurrency, "Please enter Currency (ex. PHP,USD) for GradLMENT BILLING PROFILE") Then Exit Sub

        Fee.TemplateCode = txtGradCode.Text
        Fee.TemplateDisc = txtGradDesc.Text
        Fee.TemplateRemarks = txtGradRemarks.Text
        Fee.Currency = txtGradCurrency.Text
        Fee.InActive = BooleanToInt(chkGradStat.Checked)

        Fee.CampusID = cboGradCampus.SelectedItem.Col2
        Fee.SchoolYear = cboGradTerm.SelectedItem.Col2

        Fee.TransType = FeesTemplateTransType.Graduation

        Fee.TemplateID = GradTemplateID

        If optBothStudent.Checked Then
            Fee.StudentStatus = StudentStatus.Both
        ElseIf optNewStudent.Checked Then
            Fee.StudentStatus = StudentStatus.sNew
        ElseIf optOldStudent.Checked Then
            Fee.StudentStatus = StudentStatus.Old
        End If

        If optBothGender.Checked Then
            Fee.StudentGender = StudentGender.Both
        ElseIf optFemaleGender.Checked Then
            Fee.StudentGender = StudentGender.Female
        ElseIf optMaleGender.Checked Then
            Fee.StudentGender = StudentGender.Male
        End If

        If optCash.Checked Then
            Fee.PaymentScheme = PaymentScheme.Cash
        ElseIf optSemestral.Checked Then
            Fee.PaymentScheme = PaymentScheme.Monthly
        ElseIf optQuarterly.Checked Then
            Fee.PaymentScheme = PaymentScheme.Quarterly
        ElseIf optSemestral.Checked Then
            Fee.PaymentScheme = PaymentScheme.Semestral
        End If

        Fee.PaymentOption = cboPaymentOptionID.Text


        'For i As Integer = 0 To chkcboGradYL.Properties.Items.Count - 1
        '    If chkcboGradYL.Properties.Items.GetCheckedValues(i) Then
        '        Dim SplitKey() As String
        '        SplitKey = Split(chkcboGradYL.SelectedText, "-")
        '    End If
        'Next

        Select Case UpdateTableOfFeesThesisGrad(Fee)

            Case TranDBResult.Success
                cmdGradRefresh_Click(Me, New System.EventArgs)

            Case TranDBResult.DuplicateCode
                CatchError("modFees", "UpdateTableOfFees", "Error while updating Table of fees.. Duplicate Template Code found")
                Exit Sub
            Case TranDBResult.DuplicateID
                CatchError("modFees", "UpdateTableOfFees", "Error while updating Table of fees.. Duplicate Template ID found")
                Exit Sub
        End Select
    End Sub

    Private Sub SaveThesisTemplate()

        Dim Prog() As String
        Dim Fee As tTableofFees

        If cboThesisCampus.Text = "" Then Exit Sub
        If cboThesisTerm.Text = "" Then Exit Sub

        If Not CheckTextBox(txtThesisCode, "Please enter Template Code for ENROLLMENT BILLING PROFILE") Then Exit Sub
        If Not CheckTextBox(txtThesisDescription, "Please enter Template Description for ENROLLMENT BILLING PROFILE") Then Exit Sub
        If Not CheckTextBox(txtThesisCurrency, "Please enter Currency (ex. PHP,USD) for ENROLLMENT BILLING PROFILE") Then Exit Sub

        Fee.TemplateCode = txtThesisCode.Text
        Fee.TemplateDisc = txtThesisDescription.Text
        Fee.TemplateRemarks = txtThesisRemarks.Text
        Fee.Currency = txtGradCurrency.Text
        Fee.InActive = BooleanToInt(chkGradStat.Checked)

        Fee.TransType = FeesTemplateTransType.Thesis

        Fee.CampusID = cboThesisCampus.SelectedItem.Col2
        Fee.SchoolYear = cboThesisTerm.SelectedItem.Col2

        If optBothStudent.Checked Then
            Fee.StudentStatus = StudentStatus.Both
        ElseIf optNewStudent.Checked Then
            Fee.StudentStatus = StudentStatus.sNew
        ElseIf optOldStudent.Checked Then
            Fee.StudentStatus = StudentStatus.Old
        End If

        If optBothGender.Checked Then
            Fee.StudentGender = StudentGender.Both
        ElseIf optFemaleGender.Checked Then
            Fee.StudentGender = StudentGender.Female
        ElseIf optMaleGender.Checked Then
            Fee.StudentGender = StudentGender.Male
        End If

        If optCash.Checked Then
            Fee.PaymentScheme = PaymentScheme.Cash
        ElseIf optSemestral.Checked Then
            Fee.PaymentScheme = PaymentScheme.Monthly
        ElseIf optQuarterly.Checked Then
            Fee.PaymentScheme = PaymentScheme.Quarterly
        ElseIf optSemestral.Checked Then
            Fee.PaymentScheme = PaymentScheme.Semestral
        End If

        Fee.PaymentOption = cboPaymentOptionID.Text


        'For i As Integer = 0 To chkcboThesisYL.Properties.Items.Count - 1
        '    If chkcboThesisYL.Properties.Items.GetCheckedValues(i) Then
        '        Dim SplitKey() As String
        '        SplitKey = Split(chkcboThesisYL.SelectedText, "-")
        '    End If
        'Next

        Select Case SaveTableOfFeesThesisGrad(Fee)

            Case TranDBResult.Success
                cmdThesisRefresh_Click(Me, New System.EventArgs)

            Case TranDBResult.DuplicateCode
                CatchError("modFees", "SaveTableOfFees", "Error while saving Table of fees.. Duplicate Template Code found")
                Exit Sub
            Case TranDBResult.DuplicateID
                CatchError("modFees", "SaveTableOfFees", "Error while saving Table of fees.. Duplicate Template ID found")
                Exit Sub
        End Select

    End Sub

    Private Sub UpdateThesisTemplate()
        Dim Prog() As String
        Dim Fee As tTableofFees

        If cboGradCampus.Text = "" Then Exit Sub
        If cboGradTerm.Text = "" Then Exit Sub

        If Not CheckTextBox(txtGradCode, "Please enter Template Code for GradLMENT BILLING PROFILE") Then Exit Sub
        If Not CheckTextBox(txtGradDesc, "Please enter Template Description for GradLMENT BILLING PROFILE") Then Exit Sub
        If Not CheckTextBox(txtGradCurrency, "Please enter Currency (ex. PHP,USD) for GradLMENT BILLING PROFILE") Then Exit Sub

        Fee.TemplateCode = txtGradCode.Text
        Fee.TemplateDisc = txtGradDesc.Text
        Fee.TemplateRemarks = txtGradRemarks.Text
        Fee.Currency = txtGradCurrency.Text
        Fee.InActive = BooleanToInt(chkGradStat.Checked)

        Fee.CampusID = cboGradCampus.SelectedItem.Col2
        Fee.SchoolYear = cboGradTerm.SelectedItem.Col2

        Fee.TransType = FeesTemplateTransType.Graduation

        Fee.TemplateID = GradTemplateID

        If optBothStudent.Checked Then
            Fee.StudentStatus = StudentStatus.Both
        ElseIf optNewStudent.Checked Then
            Fee.StudentStatus = StudentStatus.sNew
        ElseIf optOldStudent.Checked Then
            Fee.StudentStatus = StudentStatus.Old
        End If

        If optBothGender.Checked Then
            Fee.StudentGender = StudentGender.Both
        ElseIf optFemaleGender.Checked Then
            Fee.StudentGender = StudentGender.Female
        ElseIf optMaleGender.Checked Then
            Fee.StudentGender = StudentGender.Male
        End If

        If optCash.Checked Then
            Fee.PaymentScheme = PaymentScheme.Cash
        ElseIf optSemestral.Checked Then
            Fee.PaymentScheme = PaymentScheme.Monthly
        ElseIf optQuarterly.Checked Then
            Fee.PaymentScheme = PaymentScheme.Quarterly
        ElseIf optSemestral.Checked Then
            Fee.PaymentScheme = PaymentScheme.Semestral
        End If

        Fee.PaymentOption = cboPaymentOptionID.Text


        'For i As Integer = 0 To chkcboGradYL.Properties.Items.Count - 1
        '    If chkcboGradYL.Properties.Items.GetCheckedValues(i) Then
        '        Dim SplitKey() As String
        '        SplitKey = Split(chkcboGradYL.SelectedText, "-")
        '    End If
        'Next

        Select Case UpdateTableOfFeesThesisGrad(Fee)

            Case TranDBResult.Success
                cmdGradRefresh_Click(Me, New System.EventArgs)

            Case TranDBResult.DuplicateCode
                CatchError("modFees", "UpdateTableOfFees", "Error while updating Table of fees.. Duplicate Template Code found")
                Exit Sub
            Case TranDBResult.DuplicateID
                CatchError("modFees", "UpdateTableOfFees", "Error while updating Table of fees.. Duplicate Template ID found")
                Exit Sub
        End Select
    End Sub
    Private Sub cboPaymentOption_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboPaymentOption.SelectedIndexChanged
        cboPaymentOptionID.SelectedIndex = cboPaymentOption.SelectedIndex
    End Sub

    Private Sub dgEnroll_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgEnroll.CellDoubleClick
        CreateTemplateToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub cmdGradSave_Click(sender As System.Object, e As System.EventArgs) Handles cmdGradSave.Click
        Select Case GradState
            Case FormState.addFormState
                SaveGraduationTemplate()
            Case FormState.updateFormState
                UpdateGraduationTemplate()
        End Select
    End Sub

    Private Sub AddNewSubjectWithSpecialFeeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AddNewSubjectWithSpecialFeeToolStripMenuItem.Click
        Dim frm As New frmSubjectSpecialFee
        frm.ShowForm()
    End Sub

    Private Sub FillSubjectAirCon()
        Dim com As New MySqlCommand("SELECT SubjectCode,Description,Units,LabUnits,CreditUnits,InclTFCompute,InclLFCompute,ChargeAirConLecUnit, ChargeAirConLabUnit FROM tblSubject", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        dgSubjects.Rows.Clear()
        While vRS.Read
            Dim n As Integer = dgSubjects.Rows.Add()
            With dgSubjects
                .Rows(n).Cells(0).Value = vRS(0).ToString()
                .Rows(n).Cells(1).Value = vRS(1).ToString()
                .Rows(n).Cells(2).Value = vRS(2).ToString()
                .Rows(n).Cells(3).Value = vRS(3).ToString()
                .Rows(n).Cells(4).Value = vRS(4).ToString()
                .Rows(n).Cells(5).Value = IntToBoolean(vRS(5).ToString())
                .Rows(n).Cells(6).Value = IntToBoolean(vRS(6).ToString())
                .Rows(n).Cells(7).Value = IntToBoolean(vRS(7).ToString())
                .Rows(n).Cells(8).Value = IntToBoolean(vRS(8).ToString())
                .FirstDisplayedScrollingRowIndex = n
                .CurrentCell = .Rows(n).Cells(0)
                .Rows(n).Selected = True
            End With
        End While
        vRS.Close()
    End Sub

    Private Sub FillSubjectWithSpecialFee(ByVal TermID As Integer, ByVal CampusID As Integer)
        Dim com As New MySqlCommand("SELECT S.SubjectCode,S.Description,fnCurrencyCode(SWF.CurrencyID),SWF.Amount,S.InclTFCompute,S.InclLFCompute, " & _
                                    "fnAccountName(SWF.AccountID),'',fnYearLevelDesc(SWF.YearLevelID),SWF.Remarks,IndexID " & _
                                    "FROM tblSubject AS S INNER JOIN tblSubjectWithFee AS SWF ON S.SubjectID = SWF.SubjectID " & _
                                    "WHERE SWF.TermID='" & TermID & "' AND SWF.CampusID='" & CampusID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        dgSubject.Rows.Clear()
        While vRS.Read
            Dim n As Integer = dgSubject.Rows.Add()
            With dgSubject
                .Rows(n).Cells(0).Value = vRS(0).ToString()
                .Rows(n).Cells(1).Value = vRS(1).ToString()
                .Rows(n).Cells(2).Value = vRS(2).ToString()
                .Rows(n).Cells(3).Value = vRS(3).ToString()
                .Rows(n).Cells(4).Value = IntToBoolean(vRS(4).ToString())
                .Rows(n).Cells(5).Value = IntToBoolean(vRS(5).ToString())
                .Rows(n).Cells(6).Value = (vRS(6).ToString())
                .Rows(n).Cells(7).Value = (vRS(7).ToString())
                .Rows(n).Cells(8).Value = (vRS(8).ToString())
                .Rows(n).Cells(9).Value = (vRS(9).ToString())
                .Rows(n).Cells(10).Value = (vRS(10).ToString())
                .FirstDisplayedScrollingRowIndex = n
                .CurrentCell = .Rows(n).Cells(0)
                .Rows(n).Selected = True
            End With
        End While
        vRS.Close()

        Dim da As New MySqlDataAdapter
        da.SelectCommand = com
        Dim ds As New DataSet
        da.Fill(ds)
        Dim BS As New BindingSource
        BS.DataSource = ds.Tables(0)

        bNavigator.BindingSource = BS

    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        If cboSubCampus.Text = "" Or cboSubTerm.Text = "" Then
            Exit Sub
        End If

        FillSubjectWithSpecialFee(cboSubTermID.Text, cboSubCampusID.Text)
    End Sub

    Private Sub cboSubCampus_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboSubCampus.SelectedIndexChanged
        cboSubCampusID.SelectedIndex = cboSubCampus.SelectedIndex

    End Sub

    Private Sub cboSubTerm_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboSubTerm.SelectedIndexChanged
        cboSubTermID.SelectedIndex = cboSubTerm.SelectedIndex
    End Sub

    Private Sub cmdList_Click(sender As System.Object, e As System.EventArgs) Handles cmdList.Click
        If cboSubCampus.Text = "" Or cboSubTerm.Text = "" Then
            Exit Sub
        End If

        FillSubjectWithSpecialFee(cboSubTermID.Text, cboSubCampusID.Text)
    End Sub

    Private Sub cmdGradNew_Click(sender As System.Object, e As System.EventArgs) Handles cmdGradNew.Click
        GradState = FormState.addFormState

        txtGradCode.Text = ""
        txtGradCurrency.Text = ""
        txtGradDesc.Text = ""
        txtGradRemarks.Text = ""

    End Sub

    Private Sub cboGradCampus_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboGradCampus.SelectedIndexChanged
        If cboGradCampus.Text = "" Or cboGradTerm.Text = "" Then Exit Sub

        'FillCheckedComboBox(chkCboGrad, "SELECT CONCAT(fnProgramCode(ProgID),' - ',ProgName) FROM tblPrograms WHERE CampusID='" & cboGradCampus.SelectedItem.Col2 & "'")

        FillTemplate(cboGradTerm.SelectedItem.Col2, cboGradCampus.SelectedItem.Col2, FeesTemplateTransType.Graduation, dgGrad)
    End Sub

    Private Sub cboGradTerm_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboGradTerm.SelectedIndexChanged
        If cboGradCampus.Text = "" Or cboGradTerm.Text = "" Then Exit Sub

        FillTemplate(cboGradTerm.SelectedItem.Col2, cboGradCampus.SelectedItem.Col2, FeesTemplateTransType.Graduation, dgGrad)
    End Sub

    Private Sub cboThesisCampus_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboThesisCampus.SelectedIndexChanged
        If cboThesisCampus.Text = "" Or cboThesisTerm.Text = "" Then Exit Sub

        'FillCheckedComboBox(chkcboThesis, "SELECT CONCAT(fnProgramCode(ProgID),' - ',ProgName) FROM tblPrograms WHERE CampusID='" & cboThesisCampus.SelectedItem.Col2 & "'")


        FillTemplate(cboThesisTerm.SelectedItem.Col2, cboThesisCampus.SelectedItem.Col2, FeesTemplateTransType.Thesis, dgThesis)
    End Sub

    Private Sub cboThesisTerm_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboThesisTerm.SelectedIndexChanged
        If cboThesisCampus.Text = "" Or cboThesisTerm.Text = "" Then Exit Sub

        FillTemplate(cboThesisTerm.SelectedItem.Col2, cboThesisCampus.SelectedItem.Col2, FeesTemplateTransType.Thesis, dgThesis)
    End Sub

    Private Sub cmdGradRefresh_Click(sender As System.Object, e As System.EventArgs) Handles cmdGradRefresh.Click
        If cboGradCampus.Text = "" Then Exit Sub
        If cboGradTerm.Text = "" Then Exit Sub

        FillTemplate(cboGradTerm.SelectedItem.Col2, cboGradCampus.SelectedItem.Col2, FeesTemplateTransType.Enrollment, dgGrad)
    End Sub

    Private Sub cmdGradOutline_Click(sender As System.Object, e As System.EventArgs) Handles cmdGradOutline.Click
        If dgGrad.RowCount > 0 Then
            Dim n As Integer = dgGrad.CurrentRow.Index

            Dim frm As New frmFeeTemplateOutline
            frm.ShowForm(dgGrad.Rows(n).Cells(1).Value.ToString(), cboGradCampus.SelectedItem.Col2, cboGradTerm.SelectedItem.Col2)
        End If
    End Sub

    Private Sub cmdThesisRefresh_Click(sender As System.Object, e As System.EventArgs) Handles cmdThesisRefresh.Click
        If cboThesisCampus.Text = "" Then Exit Sub
        If cboThesisTerm.Text = "" Then Exit Sub

        FillTemplate(cboThesisTerm.SelectedItem.Col2, cboThesisCampus.SelectedItem.Col2, FeesTemplateTransType.Enrollment, dgThesis)
    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        If dgThesis.RowCount > 0 Then
            Dim n As Integer = dgThesis.CurrentRow.Index

            Dim frm As New frmFeeTemplateOutline
            frm.ShowForm(dgThesis.Rows(n).Cells(1).Value.ToString(), cboThesisCampus.SelectedItem.Col2, cboThesisCampus.SelectedItem.Col2)
        End If
    End Sub

    Private Sub ModifySubjectWithSpecialFeeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ModifySubjectWithSpecialFeeToolStripMenuItem.Click
        If dgSubject.RowCount > 0 Then
            Dim frm As New frmSubjectSpecialFee()
            frm.ShowEdit(dgSubject.Rows(dgSubject.CurrentRow.Index).Cells(10).Value.ToString(), cboSubCampusID.Text)
        End If
    End Sub

    Private Sub dgSubject_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgSubject.CellDoubleClick
        If dgSubject.RowCount > 0 Then
            Dim frm As New frmSubjectSpecialFee()
            frm.ShowEdit(dgSubject.Rows(dgSubject.CurrentRow.Index).Cells(10).Value.ToString(), cboSubCampusID.Text)
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        PanelProgram.Width = 0
        PanelProgram.Height = 0
        PanelProgram.Visible = False

        Dim str As [String] = ""

        For Each lv As ListViewItem In lvProgram.Items
            If lv.Checked = True Then
                str = lv.Text & ";" & str & " Only"
            End If
        Next
        txtProgram.Text = ""
        txtProgram.Text = str.ToString()
    End Sub

    Private Sub picPostalCode_Click(sender As System.Object, e As System.EventArgs) Handles picProgram.Click

        If PanelProgram.Height = 0 And PanelProgram.Width = 0 Then

            PanelProgram.Width = 271
            PanelProgram.Height = 210

            PanelYearLevel.Width = 0
            PanelYearLevel.Height = 0
            PanelYearLevel.Visible = False

            'PanelProgram.Left = txtProgram.Left
            'PanelProgram.Top = txtProgram.Top + txtProgram.Height

            PanelProgram.Location = txtProgram.Location

            PanelProgram.Visible = True
            PanelProgram.Focus()
        End If
    End Sub

    Private Sub picYearLevel_Click(sender As System.Object, e As System.EventArgs) Handles picYearLevel.Click

        If PanelYearLevel.Height = 0 And PanelYearLevel.Width = 0 Then

            PanelYearLevel.Width = 272
            PanelYearLevel.Height = 210

            PanelProgram.Width = 0
            PanelProgram.Height = 0
            PanelProgram.Visible = False

            PanelYearLevel.Left = txtYearLevel.Left
            PanelYearLevel.Top = txtYearLevel.Top - txtYearLevel.Height

            PanelYearLevel.Location = New Point(txtYearLevel.Left, txtYearLevel.Top - txtYearLevel.Height)


            PanelYearLevel.Visible = True
            PanelYearLevel.Focus()
        End If

    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click


        PanelYearLevel.Width = 0
        PanelYearLevel.Height = 0
        PanelYearLevel.Visible = False
        Dim str As [String] = ""

        For Each lv As ListViewItem In lvYearLevel.Items
            If lv.Checked = True Then
                str = lv.Text & ";" & str & " Only"
            End If
        Next
        txtYearLevel.Text = ""
        txtYearLevel.Text = str.ToString()
    End Sub

    Private Sub frmFeesTemplate_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize

        PanelProgram.Left = txtProgram.Left
        PanelProgram.Top = txtProgram.Top + txtProgram.Height

        PanelYearLevel.Left = txtYearLevel.Left
        PanelYearLevel.Top = txtYearLevel.Top - txtYearLevel.Height

    End Sub

    Private Sub PanelProgram_Leave(sender As System.Object, e As System.EventArgs) Handles PanelProgram.Leave
        PanelProgram.Width = 0
        PanelProgram.Height = 0
        PanelProgram.Visible = False
        For Each lv As ListViewItem In lvProgram.Items
            lv.Checked = False
        Next
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        PanelYearLevel.Width = 0
        PanelYearLevel.Height = 0
        PanelYearLevel.Visible = False
        For Each lv As ListViewItem In lvYearLevel.Items
            lv.Checked = False
        Next
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        PanelProgram.Width = 0
        PanelProgram.Height = 0
        PanelProgram.Visible = False

        For Each lv As ListViewItem In lvProgram.Items
            lv.Checked = False
        Next
    End Sub

    Private Sub PanelYearLevel_Leave(sender As System.Object, e As System.EventArgs) Handles PanelYearLevel.Leave
        PanelYearLevel.Width = 0
        PanelYearLevel.Height = 0
        PanelYearLevel.Visible = False
        For Each lv As ListViewItem In lvYearLevel.Items
            lv.Checked = False
        Next
    End Sub


    Private Sub DeleteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        If dgSubject.RowCount > 0 Then
            If MsgBox("Are you sure you want to delete the selected item?" & vbNewLine & vbNewLine & _
                      dgSubject.Rows(dgSubject.CurrentRow.Index).Cells(0).Value & " - " & dgSubject.Rows(dgSubject.CurrentRow.Index).Cells(1).Value, vbQuestion) = vbYes Then
                Try
                    Dim com As New MySqlCommand("DELETE FROM tblSubjectWithFee WHERE IndexID='" & dgSubject.Rows(dgSubject.CurrentRow.Index).Cells(10).Value & "'", con)
                    com.ExecuteNonQuery()

                    Dim com1 As New MySqlCommand("DELETE FROM tblSubjectWithFee_Distributions WHERE SWFID='" & dgSubject.Rows(dgSubject.CurrentRow.Index).Cells(10).Value & "'", con)
                    com1.ExecuteNonQuery()


                    If cboSubCampus.Text = "" Or cboSubTerm.Text = "" Then
                        Exit Sub
                    End If

                    FillSubjectWithSpecialFee(cboSubTermID.Text, cboSubCampusID.Text)

                Catch ex As MySqlException
                    DisplayErrorMsg("frmFeesTemplate", "DeleteToolStripMenuItem_Click", ex.Number, ex.Message)
                    Exit Sub
                End Try
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub cboSubCampusID_Click(sender As System.Object, e As System.EventArgs) Handles cboSubCampusID.Click

    End Sub

End Class