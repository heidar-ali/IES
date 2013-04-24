Option Explicit On

Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Windows.Forms


Public Class Registration

    Dim Colors As Color() = New Color(16) {Color.DarkOrange, Color.Fuchsia, Color.RoyalBlue, Color.FromArgb(&HFF, &HCC, &H33), Color.DimGray, Color.Yellow, Color.LimeGreen, Color.Red, Color.Maroon, Color.FromArgb(&H66, &HFF, &HFF), Color.MediumAquamarine, Color.FromArgb(&HFF, &HCC, &H33), Color.Coral, Color.Silver, Color.SandyBrown, Color.ForestGreen, Color.FromArgb(&H99, &H0, &HFF)}
    Dim i As Integer

    Dim RecordAdded As Boolean

    Dim Reason As String

    Dim State As FormState

    Dim selIsEnrolled As Boolean
    Dim curEnrolmentID As String
    Dim curFeeTemplateID As String

    Dim curStudent As tStudent


    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If UserAllowedTo(CurrentUser.UserName, sCanAddEnrolment) = False Then
            MsgBox("Unable to continue adding Enrolment entry." & vbNewLine & vbNewLine & _
                    "You are not permitted to do this. Please contact your administrator for more information.", vbExclamation)

            DisableButtons()

            Exit Sub
        End If

        Call EnableButtons()

        If CheckRegistrationSettings() <> True Then
            MsgBox("The Enrolment Configuration has not yet been properly set-up." & vbNewLine & "Please contact the IT Personnel or System Administrator", vbExclamation)
            Exit Sub
        Else
            Call GetEnrollmentConfig("1", Conf)
        End If

        txtSY.Text = GetEnrollmentAcademicYearTerm(Conf.TermID)

        TimeTable()
        StudentInfo()
        ShowSectionDetail(Conf.TermID)
    End Sub

    Private Function CheckRegistrationSettings() As Boolean
        If CheckEnrolmentSettings() = TranDBResult.Success Then
            CheckRegistrationSettings = True
        Else
            CheckRegistrationSettings = False
        End If
    End Function


    Private Sub TimeTable()
        With dgView
            .Clear()
            .set_TextMatrix(0, 0, "")
            .set_TextMatrix(1, 0, "M")
            .set_TextMatrix(2, 0, "T")
            .set_TextMatrix(3, 0, "W")
            .set_TextMatrix(4, 0, "Th")
            .set_TextMatrix(5, 0, "F")
            .set_TextMatrix(6, 0, "S")
            .set_TextMatrix(7, 0, "Su")

            .set_TextMatrix(0, 1, "06")
            .set_TextMatrix(0, 2, "06")
            .set_TextMatrix(0, 3, "07")
            .set_TextMatrix(0, 4, "07")
            .set_TextMatrix(0, 5, "08")
            .set_TextMatrix(0, 6, "08")
            .set_TextMatrix(0, 7, "09")
            .set_TextMatrix(0, 8, "09")
            .set_TextMatrix(0, 9, "10")
            .set_TextMatrix(0, 10, "10")
            .set_TextMatrix(0, 11, "11")
            .set_TextMatrix(0, 12, "11")
            .set_TextMatrix(0, 13, "12")
            .set_TextMatrix(0, 14, "12")
            .set_TextMatrix(0, 15, "01")
            .set_TextMatrix(0, 16, "01")
            .set_TextMatrix(0, 17, "02")
            .set_TextMatrix(0, 18, "02")
            .set_TextMatrix(0, 19, "03")
            .set_TextMatrix(0, 20, "03")
            .set_TextMatrix(0, 21, "04")
            .set_TextMatrix(0, 22, "04")
            .set_TextMatrix(0, 23, "05")
            .set_TextMatrix(0, 24, "05")
            .set_TextMatrix(0, 25, "06")
            .set_TextMatrix(0, 26, "06")
            .set_TextMatrix(0, 27, "07")
            .set_TextMatrix(0, 28, "07")
            .set_TextMatrix(0, 29, "08")
            .set_TextMatrix(0, 30, "08")
            .set_TextMatrix(0, 31, "09")
        End With

        For i As Integer = 0 To dgView.Cols - 1
            dgView.set_ColSort(i, C1.Win.C1FlexGrid.Classic.SortSettings.flexSortNone)
            dgView.set_ColWidth(i, 15)
            dgView.set_ColAlignment(i, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignLeftCenter)
        Next

    End Sub

    Private Sub StudentInfo()
        With Grid
            .set_TextMatrix(0, 0, "REGISTRATION #:")
            .set_TextMatrix(1, 0, "ID Number")
            .set_TextMatrix(2, 0, "Fullname")
            .set_TextMatrix(3, 0, "Gender")
            .set_TextMatrix(4, 0, "Year Level")
            .set_TextMatrix(5, 0, "Academic Program")
            .set_TextMatrix(6, 0, "Major Study")
            .set_TextMatrix(7, 0, "Curriculum")
            .set_TextMatrix(8, 0, "Scholarship")

            .set_ColAlignment(0, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignLeftCenter)
            .set_ColAlignment(1, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignLeftCenter)
        End With

        With GridInfo2
            .set_TextMatrix(0, 0, "College")
            .set_TextMatrix(1, 0, "Acad. Status")
            .set_TextMatrix(2, 0, "Total Units")
            .set_TextMatrix(3, 0, "Max Units")
            .set_TextMatrix(4, 0, "Required Units")
            .set_TextMatrix(5, 0, "Earned Units")
            .set_TextMatrix(6, 0, "Remaining Units")
            .set_TextMatrix(7, 0, "Fee Template")
            .set_TextMatrix(8, 0, "Expiry Date")

            .set_ColAlignment(0, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignLeftCenter)
            .set_ColAlignment(1, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignLeftCenter)
        End With
    End Sub


    Private Sub EnableButtons()
        cmdClone.Enabled = True
        cmdStudentInfo.Enabled = True
        cmdPrint.Enabled = True
        cmdSave.Enabled = True
        cmdBrowse.Enabled = True

        Me.PanelMain.Visible = True
        ToolStrip1.Enabled = True
    End Sub
    Private Sub DisableButtons()
        cmdClone.Enabled = False
        cmdStudentInfo.Enabled = False
        cmdPrint.Enabled = False
        cmdSave.Enabled = False
        cmdBrowse.Enabled = False

        Me.PanelMain.Visible = False
        ToolStrip1.Enabled = False
    End Sub
    Private Sub BrowseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBrowse.Click
        Dim frm As New frmBrowse()
        txtStudentID.Text = frm.ShowForm

        If txtStudentID.Text = "" Then Exit Sub

        State = FormState.addFormState

        ShowStudentDetail()
    End Sub
    Private Sub CloneSubjectsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClone.Click
        Dim frm As New frmClone()
        frm.txtSY.Text = txtSY.Text
        frm.Show()
    End Sub

    Private Sub PrintPreRegistrationFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Dim frm As New frmPrintPreview()
        'frm.PK = txtEnrolmentID.Text
        'frm.Show()
    End Sub

    Private Sub ShowStudentDetail()

        If Len(txtStudentID.Text) < 1 Then
            cmdRegister.Enabled = False
        Else
            cmdRegister.Enabled = True
        End If


        If GetStudentByID(txtStudentID.Text, curStudent) = TranDBResult.Success Then

            If GetStudentYearLevel(txtStudentID.Text) = "1st Year" Then

                With Grid
                    .set_TextMatrix(1, 1, txtStudentID.Text) ' Student ID #

                    .set_TextMatrix(2, 1, curStudent.LastName & ", " & curStudent.FirstName & " " & curStudent.MiddleName) ' Student FullName

                    .set_TextMatrix(3, 1, CompleteGender(curStudent.Gender)) ' Student Gender

                    .set_TextMatrix(4, 1, UCase(GetStudentYearLevel(txtStudentID.Text))) ' Student Year Level - > 1st Year

                    .set_TextMatrix(5, 1, GetStudentAcadProgram(txtStudentID.Text)) ' Student Academic Program/ Course Taken- > 1st Year

                    .set_TextMatrix(6, 1, GetStudentAcadProgramMajor(txtStudentID.Text)) ' Student Academic Program / Course

                    .set_TextMatrix(7, 1, GetStudentCurriculum(txtStudentID.Text)) ' Student Curriculum

                    .set_TextMatrix(8, 1, GetStudentScholarhipProvider(txtStudentID.Text)) ' Student Scholarship


                    .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpFont, 4, 1, New System.Drawing.Font("Arial", 9, FontStyle.Underline))
                    .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpForeColor, 4, 1, Color.FromArgb(&H0, &H0, &HCC))

                    .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpFont, 5, 1, New System.Drawing.Font("Arial", 8, FontStyle.Underline))
                End With

                With GridInfo2
                    .set_TextMatrix(0, 1, GetStudentCollege(txtStudentID.Text)) ' Student College

                    .set_TextMatrix(1, 1, GetStudentAcadStatus(txtStudentID.Text)) ' Student Academic Status

                    .set_TextMatrix(2, 1, GetTotalUnitsByCurriculum(curStudent.CurriculumID)) ' Total Academic Units

                    .set_TextMatrix(7, 1, GetStudentFeeTemplate(txtStudentID.Text, curFeeTemplateID)) 'Student Fee Template

                    .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpFont, 7, 1, New System.Drawing.Font("Arial", 9, FontStyle.Underline))
                    .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpForeColor, 7, 1, Color.FromArgb(&H0, &H0, &HCC))
                End With

            Else
                With Grid
                    .set_TextMatrix(1, 1, txtStudentID.Text) ' Student ID #

                    .set_TextMatrix(2, 1, curStudent.LastName & ", " & curStudent.FirstName & " " & curStudent.MiddleName) ' Student FullName

                    .set_TextMatrix(3, 1, CompleteGender(curStudent.Gender)) ' Student Gender

                    .set_TextMatrix(4, 1, GetStudentYearLevel(txtStudentID.Text))

                    .set_TextMatrix(5, 1, GetStudentAcadProgramByTerm(txtStudentID.Text, Conf.TermID - 1)) ' Student Academic Program/ Course Taken
                End With
                With GridInfo2
                    .set_TextMatrix(0, 1, GetStudentCollege(txtStudentID.Text)) ' Student College

                    .set_TextMatrix(1, 1, GetStudentAcadStatus(txtStudentID.Text)) ' Student Academic Status
                End With
            End If

        End If



        If StudentEnroledBySchoolYear(curStudent.StudentNo, Conf.TermID, selIsEnrolled) = TranDBResult.Success Then ' Check if student is currently Enrolled on the current academic year
            If selIsEnrolled = True Then
                txtStatus.Text = "Student is currently enroled on this AY..."


                MsgBox("STUDENT: " & curStudent.LastName & ", " & curStudent.FirstName & " " & curStudent.MiddleName & _
                       vbNewLine & "STUDENT No.: " & curStudent.StudentNo & vbNewLine & vbNewLine & _
                       "Is already enroled on the current academic year...")
                Exit Sub
            End If
        End If

        If StudentOutStandingBalance(curStudent.StudentNo, Conf.TermID) > 0 Then
            txtStatus.Text = "Student have currently OUTSTANDING BALANCE"


            MsgBox("Unable to enroll the student: '" & UCase(curStudent.LastName & ", " & curStudent.FirstName & " " & curStudent.MiddleName & " (" & curStudent.StudentNo & ")' ") & "this Semester. " & _
                    vbNewLine & vbNewLine & "Please advise the student to clear all unpaid balance before he/she enroll." & vbNewLine & vbNewLine & "Please proceed to the Cashier Office/Accounting Office for further information...", vbExclamation)
            Exit Sub
        End If

        If CheckStudentAccountabilities(txtStudentID.Text, Conf.TermID) = TranDBResult.Success Then
            If getStudentAccountabilities(txtStudentID.Text, Conf.TermID, Reason) = TranDBResult.Success Then
                txtStatus.Text = "Student have currently ACCOUNTABILITIES..."
                MsgBox("Unable to proceed Registration. Please clear all student's Accountabilities!" & vbNewLine & vbNewLine & _
                       "REASON: " & vbNewLine & Reason)
                Exit Sub
            End If
        End If


        GenerateEnrolmentID()

        If EnrolmentTempExistByID(txtEnrolmentID.Text) = TranDBResult.Success Then
            DisplayStudentTemporaryRegistrationSubject(txtEnrolmentID.Text)

            If GetStudentAssessedFees_Temp(TransactionType.Enrollment, txtEnrolmentID.Text, DateTime.Now.Date) = True Then
                FillListView("SELECT AccountID,Debit,Remarks FROM tblJournals_Temp WHERE ReferenceNo='" & txtEnrolmentID.Text & "'", lvAssessment, False)
            Else
                FillListView("SELECT AccountID,Amount,Remarks FROM tblTableOfFee_Details WHERE TemplateID='" & curFeeTemplateID & "'", lvAssessment, False)
            End If

            State = FormState.addFormState
        End If

        If EnrolmentExistByID(txtEnrolmentID.Text) = TranDBResult.Success Then

            If IsStudentRegistrationValidated(curStudent.StudentNo, Conf.TermID) = False Then

                txtStatus.Text = "Student is REGISTERED"

                State = FormState.updateFormState

                DisplayStudentRegistrationSubject(txtEnrolmentID.Text)

                'Fill up Fee Templates / Table of Fees / Registration Assessment
                FillListView("SELECT AccountID,Amount,Remarks FROM tblTableOfFee_Details WHERE TemplateID='" & curFeeTemplateID & "'", lvAssessment, False)

                ' show Section Offering base on Academic Year and Student College
                ShowSectionDetailsByCollegeByTerm(GetStudentCollegeID(curStudent.StudentNo), Conf.TermID)

            Else
                txtStatus.Text = "Student is VALIDATED"
                cmdRegister.Enabled = False
            End If

        Else
            State = FormState.addFormState

            txtStatus.Text = "---"

            'Fill up Fee Templates / Table of Fees / Registration Assessment
            FillListView("SELECT AccountID,Amount,Remarks FROM tblTableOfFee_Details WHERE TemplateID='" & curFeeTemplateID & "'", lvAssessment, False)


            ' show Section Offering base on Academic Year and Student College
            ShowSectionDetailsByCollegeByTerm(GetStudentCollegeID(curStudent.StudentNo), Conf.TermID)
        End If

        Exit Sub

    End Sub

    Private Sub ShowSectionDetail(ByVal TermID As Integer)
        'Block Section
        FillListView("SELECT SectionTitle,SectionID,fnCollegeCode(CollegeID) FROM tblSection WHERE TermID='" & TermID & "' AND IsBlock= 1", lvBlock, False)

        'Free Section
        FillListView("SELECT SectionTitle,SectionID,fnCollegeCode(CollegeID) FROM tblSection WHERE TermID='" & TermID & "' AND IsBlock= 0", lvFree, False)

        lvSubjects.Items.Clear()

    End Sub

    Private Sub ShowSectionDetailsByCollegeByTerm(ByVal CollegeID As String, ByVal TermID As Integer)

        'Block Section
        FillListView("SELECT SectionTitle,SectionID,`Limit` FROM tblSection WHERE TermID='" & TermID & "' AND CollegeID='" & CollegeID & _
                     "' AND IsBlock= 1", lvBlock, False)

        'Free Section
        FillListView("SELECT SectionTitle,SectionID,`Limit` FROM tblSection WHERE TermID='" & TermID & "' AND ProgramID='" & CollegeID & _
                     "' AND IsBlock= 0", lvFree, False)

    End Sub

    Private Sub ShowSubjectOffering(ByVal SectionID As String, ByVal TermID As Integer, ByVal CampusID As Integer)
        FillListView("SELECT SUB.SubjectCode,SUB.SubjectID,SUB.Description,fnClassSectionName(S.SectionID),SUB.Units,SUB.LabUnits,fnFacultyName(CD.TeacherID),CD.Sched1,fnRoomName2(CD.RoomID), " & _
                    "CD.Sched2,fnRoomName2(CD.RoomID2),CD.Sched3,fnRoomName2(CD.RoomID3),CD.Sched4,fnRoomName2(CD.RoomID4),CD.Sched5,fnRoomName2(CD.RoomID5),SubjectOfferingID FROM tblSection AS S " & _
                    "INNER JOIN tblClassSchedule AS CD ON S.SectionID = CD.SectionID INNER JOIN tblsubject AS SUB ON SUB.SubjectID = CD.SubjectID WHERE S.SectionID='" & SectionID & "' AND S.TermID='" & TermID & "' AND S.CampusID='" & CampusID & "'", lvSubjects, False)

        Dim Unit As Double = 0
        Dim LabUnits As Double = 0

        For Each lv As ListViewItem In lvSubjects.Items
            Unit = Unit + lv.SubItems(4).Text
            LabUnits = LabUnits + lv.SubItems(5).Text
        Next
        lblSecSubUnit.Text = Unit.ToString()
        lblSecSubLab.Text = LabUnits.ToString
        lblSecSub.Text = lvSubjects.Items.Count
    End Sub


    Private Function GenerateEnrolmentID() As Boolean

        Dim IsEnroled As Boolean

        'default
        GenerateEnrolmentID = False

        txtEnrolmentID.Text = ""


        'Check if Student is existed in the record
        If StudentExistByID(txtStudentID.Text) = TranDBResult.Failed Then
            CatchError("modRSStudent", "StudentExistByID", "Unknown Error Occur")
            Exit Function
        End If

        'check if student is already enroled
        If StudentEnroledBySchoolYear(txtStudentID.Text, Conf.TermID, IsEnroled) = TranDBResult.Success Then
            If IsEnroled = True Then
                MsgBox("Student Already enrolled", vbExclamation)
                Exit Function
            End If
        End If

        'generate id
        'txtEnrolmentID.Text = Microsoft.VisualBasic.Left(GetAcademicYearTermByTermID(Conf.TermID), 4) & "-" & txtStudentID.Text

        Grid.set_TextMatrix(0, 1, txtEnrolmentID.Text)

        GenerateEnrolmentID = True

        'return success

    End Function
    Private Sub txtStudentID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStudentID.TextChanged

    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        Select Case State
            Case FormState.addFormState
                SaveData()
            Case FormState.updateFormState

        End Select

    End Sub

    Private Function SaveData() As Boolean

        Dim NewEnrolment As tEnrolment
        Dim vStudent As tStudent

        Dim Led As ES_Ledger
        Dim AR As DetailedAccountsReceivable
        Dim Ass As RegistrationAssessment
        Dim Trans As FinancialTransaction
        Dim Acct As tAccounting
        Dim tFund As tFundGroups
        Dim AcctClass As tAccountClassification
        Dim Enrol As tEnrolmentDetails


        Dim AcctID As String = ""
        Dim Remarks As String = ""
        Dim Amount As Decimal = "0.00"


        'default
        SaveData = False

        '-------------------------------------------------------------------
        If GetStudentByID(txtStudentID.Text, vStudent) <> TranDBResult.Success Then

            MsgBox("Invalid Student Entry!" & vbNewLine & vbNewLine & _
                    "Unable to save Enrolment Entry. The selected Student ID does not exist in record. Please enter correct Student ID.", vbExclamation)

            Exit Function
        End If

        If Not CheckTextBox(txtSectionID, "Please Select Class Section to enroll...") Then Exit Function


        'set enrolment
        '-----------------------------------------------------------------------
        NewEnrolment.EnrolmentID = txtEnrolmentID.Text
        NewEnrolment.StudentID = txtStudentID.Text
        NewEnrolment.TermID = Conf.TermID
        NewEnrolment.SectionOfferingID = txtSectionID.Text
        NewEnrolment.ProgramID = curStudent.ProgID
        NewEnrolment.MajorID = curStudent.MajorDiscID
        NewEnrolment.DateEnroled = DateTime.Now.Date
        NewEnrolment.FeeTemplateID = curStudent.TblFeeID
        NewEnrolment.CampusID = Conf.CampusID
        NewEnrolment.CollegeID = GetStudentCollegeID(curStudent.StudentNo)
        NewEnrolment.SubjectsEnrolled = lblRegSub.Text
        NewEnrolment.TotalLabUnits = lblRegLab.Text
        NewEnrolment.TotalLectUnits = lblRegUnit.Text
        NewEnrolment.AssessedFees = fnGetStudentTempAssessedFees(TransactionType.Enrollment, txtEnrolmentID.Text, 1, curStudent.StudentNo)
        NewEnrolment.TotalNetAssessed = GetTotalTempNetAssessment(TransactionType.Enrollment, txtEnrolmentID.Text, 1, txtStudentID.Text)
        NewEnrolment.TotalAssessment = fnGetStudentTempAssessedFees(TransactionType.Enrollment, txtEnrolmentID.Text, 1, curStudent.StudentNo)
        NewEnrolment.YearLevelID = curStudent.YearLevelID
        NewEnrolment.IsWithDraw = 0
        NewEnrolment.AdvisingOfficerID = CurrentUser.UserID
        NewEnrolment.Discount = 0

        NewEnrolment.CreationDate = DateTime.Now.Date
        NewEnrolment.CreatedBy = CurrentUser.UserID
        NewEnrolment.FirstPaymentDueDate = Conf.FirstPaymentDueDate
        NewEnrolment.SecondPaymentDueDate = Conf.SecondPaymentDueDate
        NewEnrolment.ThirdPaymentDueDate = Conf.ThirdPaymentDueDate
        NewEnrolment.FourthPaymentDueDate = Conf.FourthPaymentDueDate
        NewEnrolment.FifthPaymentDueDate = Conf.FifthPaymentDueDate

        'set LEdger
        '-----------------------------------------------------------------------
        Led.StudentNo = curStudent.StudentNo
        Led.ReferenceNo = txtEnrolmentID.Text
        Led.TermID = Conf.TermID
        Led.Debit = fnGetStudentTempAssessedFees(TransactionType.Enrollment, txtEnrolmentID.Text, 1, curStudent.StudentNo)
        Led.Credit = "0.00"
        Led.Balance = StudentOutStandingBalance(curStudent.StudentNo, Conf.TermID)
        Led.TransDate = DateTime.Now.Date

        If GetFinancialTransactionByID(TransactionType.Enrollment, Trans) = TranDBResult.Success Then
            Led.TransCode = Trans.TransCode
        End If
        Led.Posted = 0
        Led.PostedDate = DateTime.Now.Date
        Led.Remarks = "Enrollment"




        Select Case AddEnrolment(NewEnrolment)
            Case TranDBResult.Success 'SUCCESS

                'Save Enrolment Details
                For Each lv As ListViewItem In lvRegister.Items
                    Enrol.EnrollmentID = txtEnrolmentID.Text
                    Enrol.ScheduleID = lv.SubItems(17).Text
                    Enrol.SeqNo = lv.Index
                    Enrol.RegTagID = 0

                    Select Case AddEnrollmentDetails(Enrol)
                        Case TranDBResult.Success

                    End Select
                Next

                'Save Journal Cache

                For Each lvs As ListViewItem In lvAssessment.Items
                    Ass.CampusID = Conf.CampusID
                    Ass.TermID = Conf.TermID
                    Ass.TransID = TransactionType.Enrollment
                    Ass.ReferenceNo = txtEnrolmentID.Text
                    Ass.Payor = curStudent.LastName & ", " & curStudent.FirstName & " " & curStudent.MiddleName
                    Ass.IDType = 1
                    Ass.IDNo = curStudent.StudentNo
                    Ass.AccountID = lvs.Text
                    Ass.Debit = lvs.SubItems(1).Text
                    Ass.Credit = "0.00"
                    Ass.Remarks = lvs.SubItems(2).Text
                    Ass.UserID = CurrentUser.UserID
                    Ass.Assess_Fee = lvs.SubItems(1).Text
                    Ass.Discount = "0.00"
                    Ass.FirstPayment = lvs.SubItems(1).Text
                    Ass.SecondPayment = "0.00"
                    Ass.ThirdPayment = "0.00"
                    Ass.FourthPayment = "0.00"
                    Ass.FifthPayment = "0.00"
                    Ass.PaymentDiscount = "0.00"
                    Ass.ActualPayment = "0.00"
                    Ass.Refund = "0.00"
                    Ass.TransType = "0"
                    Ass.TransRefNo = ""
                    Ass.CreditMemo = "0.00"
                    Ass.SeqNo = lvs.Index
                    Ass.NonLedger = 0
                    Ass.Deferred = 0
                    Ass.SubCodeID = 0
                    Ass.DMCMRefNo = ""


                    'Save Journal

                    Select Case SaveRegistrationAssessment(Ass, txtEnrolmentID.Text, curStudent.StudentNo)
                        Case TranDBResult.Success

                        Case TranDBResult.Failed
                            MsgBox("Error while saving Student Assessment", vbExclamation)

                            Dim comsq As New MySqlCommand("DELETE FROM tblEnrolment WHERE EnrolmentID='" & txtEnrolmentID.Text & "'", con)
                            comsq.ExecuteNonQuery()

                            Exit Function
                    End Select

                Next


                'Save Ledger
                Select Case SaveStudentLedger(Led)
                    Case TranDBResult.Success

                    Case TranDBResult.Failed
                        MsgBox("Error while saving Student Ledger", vbExclamation)

                        Dim coms2 As New MySqlCommand("DELETE FROM tblEnrolment WHERE EnrolmentID='" & txtEnrolmentID.Text & "'", con)
                        coms2.ExecuteNonQuery()

                        Exit Function
                End Select


                'set Detailed Accounts Receivable and Save Detailed Accounts Receivable
                '-----------------------------------------------------------------------------------------
                For Each lv As ListViewItem In lvAssessment.Items

                    AR.AccountID = lv.Text

                    If GetAccountsByID(lv.Text, Acct) = TranDBResult.Success Then
                        AR.AccountCode = Acct.AccountCode
                        AR.AccountName = Acct.AccountName
                        AR.ShortName = Acct.ShortName
                    End If

                    AR.RefNo = txtEnrolmentID.Text
                    AR.IDNo = curStudent.StudentNo
                    AR.StudentName = UCase(curStudent.LastName) & ", " & curStudent.FirstName & " " & curStudent.MiddleName
                    AR.Assessment = fnGetStudentTempAssessedFees(TransactionType.Enrollment, txtEnrolmentID.Text, 1, curStudent.StudentNo)
                    AR.CampusID = Conf.CampusID

                    If GetAccountFundByAccountID(lv.Text, tFund) = TranDBResult.Success Then
                        AR.GroupID = tFund.IndexID
                        AR.GroupCode = tFund.GroupCode
                        AR.GroupName = tFund.GroupName
                        AR.GroupShort = tFund.ShortName
                    End If

                    If GetAccountClassificationByAccountID(lv.Text, AcctClass) = TranDBResult.Success Then
                        AR.ClassCode = AcctClass.ClassCode
                        AR.ClassName = AcctClass.ClassName
                        AR.ClassID = AcctClass.IndexID
                        AR.ClassShort = AcctClass.ShortName
                    End If

                    Select Case SaveDetailedAccountsReceivable(AR)
                        Case TranDBResult.Success

                        Case TranDBResult.Failed
                            MsgBox("Error while saving Detailed Accounts Receivable", vbExclamation)

                            Dim coms As New MySqlCommand("DELETE FROM tblEnrolment WHERE EnrolmentID='" & txtEnrolmentID.Text & "'", con)
                            coms.ExecuteNonQuery()

                            Exit Function
                    End Select

                Next

                MsgBox("New Enrolment successfully added.", vbInformation)

                SaveData = True
                CloseStudent()

            Case TranDBResult.EnrolmentStudentIDNotFound
                MsgBox("Enrolment Not added - Selected student is not found on the database", vbExclamation)
                SaveData = False

            Case TranDBResult.EnrolmentSectionIDNotFound
                MsgBox("Enrolment Not added - No Section is selected or invalid Class Section", vbExclamation)
                SaveData = False

            Case Else 'unknown result, consider as failed
                'temp
                MsgBox("Enrolment Not added - Unknown Error occured", vbExclamation)
                SaveData = False
        End Select

    End Function
    Private Sub CloseStudent()

        lvSubjects.Items.Clear()

        txtStudentID.Text = Nothing
        txtEnrolmentID.Text = Nothing

        TimeTable()

        With Grid
            .set_TextMatrix(0, 0, "REGISTRATION #:")
            .set_TextMatrix(1, 0, "ID Number")
            .set_TextMatrix(2, 0, "Fullname")
            .set_TextMatrix(3, 0, "Gender")
            .set_TextMatrix(4, 0, "Year Level")
            .set_TextMatrix(5, 0, "Academic Program")
            .set_TextMatrix(6, 0, "Major Study")
            .set_TextMatrix(7, 0, "Curriculum")
            .set_TextMatrix(8, 0, "Scholarship")

            .set_TextMatrix(0, 1, "")
            .set_TextMatrix(1, 1, "")
            .set_TextMatrix(2, 1, "")
            .set_TextMatrix(3, 1, "")
            .set_TextMatrix(4, 1, "")
            .set_TextMatrix(5, 1, "")
            .set_TextMatrix(6, 1, "")
            .set_TextMatrix(7, 1, "")
            .set_TextMatrix(8, 1, "")


            .set_ColAlignment(0, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignLeftCenter)
            .set_ColAlignment(1, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignLeftCenter)
        End With

        With GridInfo2
            .set_TextMatrix(0, 0, "College")
            .set_TextMatrix(1, 0, "Acad. Status")
            .set_TextMatrix(2, 0, "Total Units")
            .set_TextMatrix(3, 0, "Max Units")
            .set_TextMatrix(4, 0, "Required Units")
            .set_TextMatrix(5, 0, "Earned Units")
            .set_TextMatrix(6, 0, "Remaining Units")
            .set_TextMatrix(7, 0, "Fee Template")
            .set_TextMatrix(8, 0, "Expiry Date")

            .set_TextMatrix(0, 1, "")
            .set_TextMatrix(1, 1, "")
            .set_TextMatrix(2, 1, "")
            .set_TextMatrix(3, 1, "")
            .set_TextMatrix(4, 1, "")
            .set_TextMatrix(5, 1, "")
            .set_TextMatrix(6, 1, "")
            .set_TextMatrix(7, 1, "")
            .set_TextMatrix(8, 1, "")

            .set_ColAlignment(0, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignLeftCenter)
            .set_ColAlignment(1, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignLeftCenter)
        End With

        lvRegister.Items.Clear()
        lvBlock.Items.Clear()
        lvFree.Items.Clear()
        lvAssessment.Items.Clear()

        txtStudentID.Text = ""
        txtEnrolmentID.Text = ""
        txtSection.Text = ""
        txtSectionID.Text = ""
        txtStatus.Text = "---"

        TimeTable()
    End Sub

    Private Sub mnuCloseStudent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCloseStudent.Click
        CloseStudent()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub cmdStudentInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStudentInfo.Click
        'frmStudentRecord.ShowForm(txtStudentID.Text)
    End Sub



    Private Sub ListOfCertificateOfRegistrationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New frmREgListOfReports()
        frm.Show()
    End Sub

    Private Sub mnuSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New frmProgramSettings
        'frm.ShowForm()
    End Sub

    Private Sub lvFree_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lvFree.SelectedIndexChanged
        If lvFree.Items.Count > 0 Then
            ShowSubjectOffering(lvFree.FocusedItem.SubItems(1).Text, Conf.TermID, Conf.CampusID)
            txtSectionID.Text = lvFree.FocusedItem.SubItems(1).Text
            txtSection.Text = lvFree.FocusedItem.Text
        End If
    End Sub

    Private Sub lvBlock_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lvBlock.SelectedIndexChanged
        If lvBlock.Items.Count > 0 Then
            ShowSubjectOffering(lvBlock.FocusedItem.SubItems(1).Text, Conf.TermID, Conf.CampusID)
            txtSectionID.Text = lvBlock.FocusedItem.SubItems(1).Text
            txtSection.Text = lvBlock.FocusedItem.Text
        End If
    End Sub

    Private Sub cmdSelectAll_Click(sender As System.Object, e As System.EventArgs) Handles cmdSelectAll.Click
        If lvSubjects.Items.Count > 0 Then
            For Each lv As ListViewItem In lvSubjects.Items
                lv.Checked = True
            Next
        End If
    End Sub

    Private Sub cmdUnselect_Click(sender As System.Object, e As System.EventArgs) Handles cmdUnselect.Click
        If lvSubjects.Items.Count > 0 Then
            For Each lv As ListViewItem In lvSubjects.Items
                lv.Checked = False
            Next
        End If
    End Sub

    Private Sub cmdRegister_Click(sender As System.Object, e As System.EventArgs) Handles cmdRegister.Click

        Dim sSectionTitle As String = ""
        Dim sSubjectCode As String = ""
        Dim sSubjectTitle As String = ""
        Dim sSchedule As String = ""

        Dim ScheduleInfo As String = ""
        Dim SubjectInfo As String = ""
        Dim SectionInfo As String = ""
        Dim DayInfo As String = ""
        Dim xTimeStart As String = ""
        Dim xTimeEnd As String = ""

        Dim AcctID As String = ""
        Dim Remarks As String = ""
        Dim Amount As Decimal

        Dim Remarks1 As String = ""
        Dim Unit As Double = 0
        Dim LabUnits As Double = 0

        Dim Enrol As tEnrolmentDetails
        Dim Ass As RegistrationAssessment
        Dim NewEnrolment As tEnrolment


        If lvSubjects.Items.Count > 0 Then

            For Each lv As ListViewItem In lvSubjects.Items
                If lv.Checked Then

                    'Check if SubjectOffering has Pre-requisite/co-requisite/equivalent
                    ' Check if subject Pre-requisite/co-requisite/equivalent is passed/failed/incomplete


                    If CheckSubjectOfferingSchedule(lv.SubItems(17).Text) <> TranDBResult.Success Then ' Check Subject Offering Schedule Exist
                        MsgBox("The selected subject has no schedule " & vbNewLine & vbNewLine & lv.Text & " - " & lv.SubItems(2).Text)
                        Exit Sub
                    End If

                    If CheckSubjectOfferingOnList(lv.SubItems(1).Text) = True Then ' Check if Subject is already exist in the list
                        MsgBox("Subject: " & lv.Text & " - " & lv.SubItems(2).Text & vbNewLine & vbNewLine & _
                                "was already in the list...", vbExclamation)
                        Exit Sub
                    End If

                    If CheckSubjectOfferingByCurriculum(lv.SubItems(1).Text, curStudent.CurriculumID) <> True Then ' Check Subject on Curriculum
                        If MsgBox("Subject: " & lv.Text & " - " & lv.SubItems(2).Text & vbNewLine & _
                                  "is not found in the Curriculum Program " & UCase(EnrollmentCurriculumProgram(curStudent.CurriculumID)) & _
                                  vbNewLine & vbNewLine & _
                                  "Do you still wish to register to this Subject?", vbExclamation + vbYesNo) = vbNo Then
                            Exit Sub
                        End If
                    End If

                    If getTotalSubjectEnrolled(lv.SubItems(17).Text) = GetSubjectMaxLimit(lv.SubItems(17).Text) Then ' Check subject Limit on the list
                        MsgBox("Subject: " & lv.Text & " - " & lv.SubItems(2).Text & vbNewLine & _
                               "Section: " & txtSection.Text & vbNewLine & vbNewLine & _
                               "has already reached its maximum class size." & vbNewLine & _
                               "Please use the Class Section Management [SCHEDULER MODULE / ACADEMIC MANAGER MODULE] " & _
                               "to modify or adjust the Class Size Limit.", vbExclamation)
                        Exit Sub
                    End If

                    'get Number of temporary enrolled subjects
                    For a As Integer = 1 To GetNoOfTempEnrolledSubjects(txtEnrolmentID.Text)
                        'Get Number of Schedule on a Specific Subject 
                        For i As Integer = 1 To GetNoOfCurrentSchedule(lv.SubItems(17).Text, Conf.TermID)

                            GetSubjectOfferingSchedule(lv.SubItems(17).Text, i, ScheduleInfo, SectionInfo, SubjectInfo)

                            GetSubjectOfferingInfo(lv.SubItems(17).Text, Conf.TermID, i, DayInfo, xTimeStart, xTimeEnd)

                            'Check for Conflict Schedule
                            If CheckSubjectOfferingIfConflict(txtEnrolmentID.Text, Conf.TermID, DayInfo, xTimeStart, xTimeEnd, a, sSubjectCode, sSubjectTitle, sSectionTitle, sSchedule) = True Then

                                MsgBox("The class schedule of the subject " & vbNewLine & vbNewLine & _
                                        SubjectInfo & " - " & SectionInfo & _
                                        vbNewLine & ScheduleInfo & _
                                        vbNewLine & vbNewLine & _
                                        "has Day/Time conflict with current subject: " & vbNewLine & _
                                        "(" & sSubjectCode & ") " & sSubjectTitle & " - " & sSectionTitle & _
                                        vbNewLine & sSchedule, vbExclamation)
                                Exit Sub
                            End If

                        Next
                    Next

                    NewEnrolment.EnrolmentID = txtEnrolmentID.Text
                    NewEnrolment.StudentID = txtStudentID.Text
                    NewEnrolment.TermID = Conf.TermID
                    NewEnrolment.SectionOfferingID = txtSectionID.Text
                    NewEnrolment.ProgramID = curStudent.ProgID
                    NewEnrolment.MajorID = curStudent.MajorDiscID
                    NewEnrolment.DateEnroled = DateTime.Now.Date
                    NewEnrolment.FeeTemplateID = curStudent.TblFeeID
                    NewEnrolment.CampusID = Conf.CampusID
                    NewEnrolment.CollegeID = GetStudentCollegeID(curStudent.StudentNo)
                    NewEnrolment.SubjectsEnrolled = lblRegSub.Text
                    NewEnrolment.TotalLabUnits = lblRegLab.Text
                    NewEnrolment.TotalLectUnits = lblRegUnit.Text
                    NewEnrolment.YearLevelID = curStudent.YearLevelID
                    NewEnrolment.IsWithDraw = 0
                    NewEnrolment.AdvisingOfficerID = CurrentUser.UserID
                    NewEnrolment.Discount = "0.00"

                    NewEnrolment.CreationDate = DateTime.Now.Date
                    NewEnrolment.CreatedBy = CurrentUser.UserID

                    If TempEnrolmentExistByID(txtEnrolmentID.Text) <> TranDBResult.Success Then
                        Select Case AddTempEnrolment(NewEnrolment)
                            Case TranDBResult.Success 'SUCCESS
                        End Select
                    Else
                        Select Case AddTempEnrolment(NewEnrolment)
                            Case TranDBResult.Success 'SUCCESS
                        End Select
                    End If

                    Enrol.EnrollmentID = txtEnrolmentID.Text
                    Enrol.ScheduleID = lv.SubItems(17).Text
                    Enrol.SeqNo = lv.Index
                    Enrol.RegTagID = 0
                    Enrol.FeeTemplateID = curStudent.TblFeeID

                    Select Case State
                        Case FormState.addFormState
                            Select Case AddTempEnrolmentDetails(Enrol)
                                Case TranDBResult.Success
                                    If EnrolmentTempExistByID(txtEnrolmentID.Text) = TranDBResult.Success Then
                                        DisplayStudentTemporaryRegistrationSubject(txtEnrolmentID.Text)
                                        'FillListView("SELECT AccountID,Debit,Remarks FROM tblJournals_Temp WHERE ReferenceNo='" & txtEnrolmentID.Text & "'", lvAssessment, False)
                                    End If

                                    If EnrolmentExistByID(txtEnrolmentID.Text) = TranDBResult.Success Then
                                        DisplayStudentRegistrationSubject(txtEnrolmentID.Text)
                                        'FillListView("SELECT AccountID,Debit,Remarks FROM tblJournals_Temp WHERE ReferenceNo='" & txtEnrolmentID.Text & "'", lvAssessment, False)
                                    End If
                                Case TranDBResult.DuplicateTitle
                                    MsgBox("Subject: " & lv.Text & " - " & lv.SubItems(2).Text & vbNewLine & vbNewLine & _
                                       "was already in the list...", vbExclamation)
                                    Exit Sub
                            End Select
                        Case FormState.updateFormState

                            Select Case AddEnrollmentDetails(Enrol)
                                Case TranDBResult.Success
                                    If EnrolmentTempExistByID(txtEnrolmentID.Text) = TranDBResult.Success Then
                                        DisplayStudentTemporaryRegistrationSubject(txtEnrolmentID.Text)
                                        'FillListView("SELECT AccountID,Debit,Remarks FROM tblJournals_Temp WHERE ReferenceNo='" & txtEnrolmentID.Text & "'", lvAssessment, False)
                                    End If

                                    If EnrolmentExistByID(txtEnrolmentID.Text) = TranDBResult.Success Then
                                        DisplayStudentRegistrationSubject(txtEnrolmentID.Text)
                                        'FillListView("SELECT AccountID,Debit,Remarks FROM tblJournals WHERE ReferenceNo='" & txtEnrolmentID.Text & "'", lvAssessment, False)
                                    End If
                                Case TranDBResult.DuplicateTitle
                                    MsgBox("Subject: " & lv.Text & " - " & lv.SubItems(2).Text & vbNewLine & vbNewLine & _
                                       "was already in the list...", vbExclamation)
                                    Exit Sub
                            End Select

                    End Select
                End If
            Next

            If GetStudentAssessedFees_Temp(TransactionType.Enrollment, txtEnrolmentID.Text, DateTime.Now.Date) = True Then

                For Each lv As ListViewItem In lvRegister.Items
                    If (IsSubjectWithFee(lv.SubItems(1).Text, Conf.TermID) = True) And (TempEnrolledSubjectExist(txtEnrolmentID.Text, lv.SubItems(1).Text) = lv.SubItems(1).Text) Then

                        GetAccountSubjectWithFee(lv.SubItems(1).Text, AcctID, Amount, Remarks)

                        'If SWFAccountExistInJournal_Temp(AcctID, txtEnrolmentID.Text, TransactionType.Enrollment, IDType.Student) = True Then Exit For

                        Ass.CampusID = Conf.CampusID
                        Ass.TermID = Conf.TermID
                        Ass.TransID = TransactionType.Enrollment
                        Ass.ReferenceNo = txtEnrolmentID.Text
                        Ass.Payor = curStudent.LastName & ", " & curStudent.FirstName & " " & curStudent.MiddleName
                        Ass.IDType = 1
                        Ass.IDNo = curStudent.StudentNo
                        Ass.AccountID = AcctID
                        Ass.Debit = Amount
                        Ass.Credit = "0.00"
                        Ass.Remarks = Remarks
                        Ass.UserID = CurrentUser.UserID
                        Ass.Assess_Fee = Amount
                        Ass.Discount = "0.00"
                        Ass.FirstPayment = Amount
                        Ass.SecondPayment = "0.00"
                        Ass.ThirdPayment = "0.00"
                        Ass.FourthPayment = "0.00"
                        Ass.FifthPayment = "0.00"
                        Ass.PaymentDiscount = "0.00"
                        Ass.ActualPayment = "0.00"
                        Ass.Refund = "0.00"
                        Ass.TransType = "0"
                        Ass.TransRefNo = ""
                        Ass.CreditMemo = "0.00"
                        'Ass.SeqNo = lvs.Index
                        Ass.NonLedger = 0
                        Ass.Deferred = 0
                        Ass.SubCodeID = 0
                        Ass.DMCMRefNo = ""

                        Select Case SaveTempRegistrationAssessment(Ass, txtEnrolmentID.Text, curStudent.StudentNo)
                            Case TranDBResult.Success

                            Case TranDBResult.Failed
                                MsgBox("Error on Assessment", vbExclamation)

                                Dim coms As New MySqlCommand("DELETE FROM tblEnrolment_Temp WHERE EnrolmentID='" & txtEnrolmentID.Text & "'", con)
                                coms.ExecuteNonQuery()

                                Dim coms1 As New MySqlCommand("DELETE FROM tblEnrolmentDetails_Temp WHERE EnrolmentID='" & txtEnrolmentID.Text & "'", con)
                                coms1.ExecuteNonQuery()

                                Dim coms2 As New MySqlCommand("DELETE FROM tblJournals_Temp WHERE EnrolmentID='" & txtEnrolmentID.Text & "'", con)
                                coms2.ExecuteNonQuery()

                                Exit Sub
                        End Select
                    End If
                Next

                For Each lvs As ListViewItem In lvAssessment.Items
                    If GetfnGetAccountTempTuitionFeeID(txtEnrolmentID.Text, Conf.TermID) = lvs.Text Then
                        GetAccountDetailsOnFeeTemplate(lvs.Text, curFeeTemplateID, GetTotalTempEnrolledLecUnits(txtEnrolmentID.Text), Remarks1)
                        Amount = GetTotalTuitionFeeAmount_Temp(txtEnrolmentID.Text, GetTotalTempEnrolledLecUnits(txtEnrolmentID.Text))

                        Dim com As New MySqlCommand("UPDATE tblJournals_Temp SET Debit=@Amount,Assess_Fee=@AssFee,`1st Payment`=@1st,Remarks='" & Remarks1 & "' WHERE ReferenceNo='" & txtEnrolmentID.Text & "' AND AccountID='" & lvs.Text & "'", con)
                        com.Parameters.Add("@Amount", MySqlDbType.Decimal).Value = Amount
                        com.Parameters.Add("@AssFee", MySqlDbType.Decimal).Value = Amount
                        com.Parameters.Add("@1st", MySqlDbType.Decimal).Value = Amount
                        com.ExecuteNonQuery()
                        com.Parameters.Clear()

                    End If
                Next

            Else

                For Each lv As ListViewItem In lvRegister.Items
                    If IsSubjectWithFee(lv.SubItems(1).Text, Conf.TermID) = True And TempEnrolledSubjectExist(txtEnrolmentID.Text, lv.SubItems(1).Text) = lv.SubItems(1).Text Then
                        GetAccountSubjectWithFee(lv.SubItems(1).Text, AcctID, Amount, Remarks)

                        Ass.CampusID = Conf.CampusID
                        Ass.TermID = Conf.TermID
                        Ass.TransID = TransactionType.Enrollment
                        Ass.ReferenceNo = txtEnrolmentID.Text
                        Ass.Payor = curStudent.LastName & ", " & curStudent.FirstName & " " & curStudent.MiddleName
                        Ass.IDType = 1
                        Ass.IDNo = curStudent.StudentNo
                        Ass.AccountID = AcctID
                        Ass.Debit = Amount
                        Ass.Credit = "0.00"
                        Ass.Remarks = Remarks
                        Ass.UserID = CurrentUser.UserID
                        Ass.Assess_Fee = Amount
                        Ass.Discount = "0.00"
                        Ass.FirstPayment = Amount
                        Ass.SecondPayment = "0.00"
                        Ass.ThirdPayment = "0.00"
                        Ass.FourthPayment = "0.00"
                        Ass.FifthPayment = "0.00"
                        Ass.PaymentDiscount = "0.00"
                        Ass.ActualPayment = "0.00"
                        Ass.Refund = "0.00"
                        Ass.TransType = "0"
                        Ass.TransRefNo = ""
                        Ass.CreditMemo = "0.00"
                        'Ass.SeqNo = lvs.Index
                        Ass.NonLedger = 0
                        Ass.Deferred = 0
                        Ass.SubCodeID = 0
                        Ass.DMCMRefNo = ""

                        Select Case SaveTempRegistrationAssessment(Ass, txtEnrolmentID.Text, curStudent.StudentNo)
                            Case TranDBResult.Success

                            Case TranDBResult.Failed
                                MsgBox("Error on Assessment", vbExclamation)

                                Dim coms As New MySqlCommand("DELETE FROM tblEnrolment_Temp WHERE EnrolmentID='" & txtEnrolmentID.Text & "'", con)
                                coms.ExecuteNonQuery()

                                Dim coms1 As New MySqlCommand("DELETE FROM tblEnrolmentDetails_Temp WHERE EnrolmentID='" & txtEnrolmentID.Text & "'", con)
                                coms1.ExecuteNonQuery()

                                Dim coms2 As New MySqlCommand("DELETE FROM tblJournals_Temp WHERE EnrolmentID='" & txtEnrolmentID.Text & "'", con)
                                coms2.ExecuteNonQuery()

                                Exit Sub
                        End Select
                    End If
                Next

                For Each lvs As ListViewItem In lvAssessment.Items
                    Ass.CampusID = Conf.CampusID
                    Ass.TermID = Conf.TermID
                    Ass.TransID = TransactionType.Enrollment
                    Ass.ReferenceNo = txtEnrolmentID.Text
                    Ass.Payor = curStudent.LastName & ", " & curStudent.FirstName & " " & curStudent.MiddleName
                    Ass.IDType = 1
                    Ass.IDNo = curStudent.StudentNo
                    Ass.AccountID = lvs.Text
                    Ass.Debit = lvs.SubItems(1).Text
                    Ass.Credit = "0.00"
                    Ass.Remarks = lvs.SubItems(2).Text
                    Ass.UserID = CurrentUser.UserID
                    Ass.Assess_Fee = lvs.SubItems(1).Text
                    Ass.Discount = "0.00"
                    Ass.FirstPayment = lvs.SubItems(1).Text
                    Ass.SecondPayment = "0.00"
                    Ass.ThirdPayment = "0.00"
                    Ass.FourthPayment = "0.00"
                    Ass.FifthPayment = "0.00"
                    Ass.PaymentDiscount = "0.00"
                    Ass.ActualPayment = "0.00"
                    Ass.Refund = "0.00"
                    Ass.TransType = "0"
                    Ass.TransRefNo = ""
                    Ass.CreditMemo = "0.00"
                    Ass.SeqNo = lvs.Index
                    Ass.NonLedger = 0
                    Ass.Deferred = 0
                    Ass.SubCodeID = 0
                    Ass.DMCMRefNo = ""

                    Select Case SaveTempRegistrationAssessment(Ass, txtEnrolmentID.Text, curStudent.StudentNo)
                        Case TranDBResult.Success

                            If GetfnGetAccountTempTuitionFeeID(txtEnrolmentID.Text, Conf.TermID) = lvs.Text Then
                                GetAccountDetailsOnFeeTemplate(lvs.Text, curFeeTemplateID, GetTotalTempEnrolledLecUnits(txtEnrolmentID.Text), Remarks1)
                                Amount = GetTotalTuitionFeeAmount_Temp(txtEnrolmentID.Text, GetTotalTempEnrolledLecUnits(txtEnrolmentID.Text))

                                Dim com As New MySqlCommand("UPDATE tblJournals_Temp SET Debit=@Amount,Assess_Fee=@AssFee,`1st Payment`=@1st,Remarks='" & Remarks1 & "' WHERE ReferenceNo='" & txtEnrolmentID.Text & "' AND AccountID='" & lvs.Text & "'", con)
                                com.Parameters.Add("@Amount", MySqlDbType.Decimal).Value = Amount
                                com.Parameters.Add("@AssFee", MySqlDbType.Decimal).Value = Amount
                                com.Parameters.Add("@1st", MySqlDbType.Decimal).Value = Amount
                                com.ExecuteNonQuery()
                                com.Parameters.Clear()
                            End If

                        Case TranDBResult.Failed
                            MsgBox("Error on Assessment", vbExclamation)

                            Dim coms As New MySqlCommand("DELETE FROM tblEnrolment_Temp WHERE EnrolmentID='" & txtEnrolmentID.Text & "'", con)
                            coms.ExecuteNonQuery()

                            Dim coms1 As New MySqlCommand("DELETE FROM tblEnrolmentDetails_Temp WHERE EnrolmentID='" & txtEnrolmentID.Text & "'", con)
                            coms1.ExecuteNonQuery()

                            Dim coms2 As New MySqlCommand("DELETE FROM tblJournals_Temp WHERE EnrolmentID='" & txtEnrolmentID.Text & "'", con)
                            coms2.ExecuteNonQuery()

                            Exit Sub
                    End Select
                Next

            End If

            If EnrolmentTempExistByID(txtEnrolmentID.Text) = TranDBResult.Success Then
                FillListView("SELECT AccountID,Debit,Remarks FROM tblJournals_Temp WHERE ReferenceNo='" & txtEnrolmentID.Text & "'", lvAssessment, False)
            End If

            If EnrolmentExistByID(txtEnrolmentID.Text) = TranDBResult.Success Then
                FillListView("SELECT AccountID,Debit,Remarks FROM tblJournals WHERE ReferenceNo='" & txtEnrolmentID.Text & "'", lvAssessment, False)
            End If

        End If
    End Sub

    Private Function CheckSubjectOfferingOnList(ByVal SubjectID As String) As Boolean
        For Each lv As ListViewItem In lvRegister.Items
            If lv.SubItems(1).Text = SubjectID Then
                CheckSubjectOfferingOnList = True
                Exit For
            Else
                CheckSubjectOfferingOnList = False
            End If
        Next
    End Function

    Private Sub cmdRemoveAll_Click(sender As System.Object, e As System.EventArgs) Handles cmdRemoveAll.Click
        If lvRegister.Items.Count > 0 Then
            Try
                Dim AcctID As String
                Dim Remarks As String
                Dim Amount As Decimal

                For Each lv As ListViewItem In lvRegister.Items
                    Dim com As New MySqlCommand("DELETE FROM tblEnrolmentDetails_Temp WHERE ScheduleID='" & lv.SubItems(17).Text & "'", con)
                    com.ExecuteNonQuery()
                Next

                If GetStudentAssessedFees_Temp(TransactionType.Enrollment, txtEnrolmentID.Text, DateTime.Now.Date) = True Then
                    Dim com As New MySqlCommand("DELETE FROM tblJournals_Temp WHERE ReferenceNo='" & txtEnrolmentID.Text & "'", con)
                    com.ExecuteNonQuery()
                End If

                If EnrolmentTempExistByID(txtEnrolmentID.Text) = TranDBResult.Success Then
                    DisplayStudentTemporaryRegistrationSubject(txtEnrolmentID.Text)
                    FillListView("SELECT AccountID,Debit,Remarks FROM tblJournals_Temp WHERE ReferenceNo='" & txtEnrolmentID.Text & "'", lvAssessment, False)
                Else
                    lvRegister.Items.Clear()
                    TimeTable()

                    FillListView("SELECT AccountID,Amount,Remarks FROM tblTableOfFee_Details WHERE TemplateID='" & curFeeTemplateID & "'", lvAssessment, False)

                End If

                If EnrolmentExistByID(txtEnrolmentID.Text) = TranDBResult.Success Then
                    DisplayStudentRegistrationSubject(txtEnrolmentID.Text)
                    FillListView("SELECT AccountID,Debit,Remarks FROM tblJournals WHERE ReferenceNo='" & txtEnrolmentID.Text & "'", lvAssessment, False)
                Else
                    lvRegister.Items.Clear()
                    TimeTable()

                    FillListView("SELECT AccountID,Amount,Remarks FROM tblTableOfFee_Details WHERE TemplateID='" & curFeeTemplateID & "'", lvAssessment, False)

                End If

            Catch ex As MySqlException
                DisplayErrorMsg("frmMain", "cmdRemoveAll_Click", ex.Number, ex.Message)
            End Try
        End If
    End Sub

    Private Sub lvSubjects_ItemCheck(sender As System.Object, e As System.Windows.Forms.ItemCheckEventArgs) Handles lvSubjects.ItemCheck

    End Sub

    Private Sub lvSubjects_ItemChecked(sender As System.Object, e As System.Windows.Forms.ItemCheckedEventArgs) Handles lvSubjects.ItemChecked
        For Each lv As ListViewItem In lvSubjects.Items
            If lv.Checked = True Then
                If getTotalSubjectEnrolled(lv.SubItems(17).Text) = GetSubjectMaxLimit(lv.SubItems(17).Text) Then
                    MsgBox("Subject: " & lv.Text & " - " & lv.SubItems(2).Text & vbNewLine & _
                           "Section: " & txtSection.Text & vbNewLine & vbNewLine & _
                           "has already reached its maximum class size." & vbNewLine & _
                           "Please use the Class Section Management [SCHEDULER MODULE / ACADEMIC MANAGER MODULE] " & _
                           "to modify or adjust the Class Size Limit.", vbExclamation)
                    Exit Sub
                End If
            End If
        Next
    End Sub

    Private Sub cmdReload_Click(sender As System.Object, e As System.EventArgs)
        ShowStudentDetail()
    End Sub

    Private Sub cmdRemove_Click(sender As System.Object, e As System.EventArgs) Handles cmdRemove.Click

        Dim Remarks1 As String = ""
        Dim Amount As Decimal

        If lvRegister.Items.Count > 0 Then
            Try
                Dim com As New MySqlCommand("DELETE FROM tblEnrolmentDetails_Temp WHERE ScheduleID='" & lvRegister.FocusedItem.SubItems(17).Text & "'", con)
                com.ExecuteNonQuery()

                For Each lvs As ListViewItem In lvAssessment.Items
                    If GetfnGetAccountTempTuitionFeeID(txtEnrolmentID.Text, Conf.TermID) = lvs.Text Then
                        GetAccountDetailsOnFeeTemplate(lvs.Text, curFeeTemplateID, GetTotalTempEnrolledLecUnits(txtEnrolmentID.Text), Remarks1)
                        Amount = GetTotalTuitionFeeAmount_Temp(txtEnrolmentID.Text, GetTotalTempEnrolledLecUnits(txtEnrolmentID.Text))

                        Dim com1 As New MySqlCommand("UPDATE tblJournals_Temp SET Debit=@Amount,Assess_Fee=@AssFee,`1st Payment`=@1st,Remarks='" & Remarks1 & "' WHERE ReferenceNo='" & txtEnrolmentID.Text & "' AND AccountID='" & lvs.Text & "'", con)
                        com1.Parameters.Add("@Amount", MySqlDbType.Decimal).Value = Amount
                        com1.Parameters.Add("@AssFee", MySqlDbType.Decimal).Value = Amount
                        com1.Parameters.Add("@1st", MySqlDbType.Decimal).Value = Amount
                        com1.ExecuteNonQuery()
                        com1.Parameters.Clear()

                    End If
                Next

                If EnrolmentTempExistByID(txtEnrolmentID.Text) = TranDBResult.Success Then
                    DisplayStudentTemporaryRegistrationSubject(txtEnrolmentID.Text)
                    FillListView("SELECT AccountID,Debit,Remarks FROM tblJournals_Temp WHERE ReferenceNo='" & txtEnrolmentID.Text & "'", lvAssessment, False)
                End If

                If EnrolmentExistByID(txtEnrolmentID.Text) = TranDBResult.Success Then
                    DisplayStudentRegistrationSubject(txtEnrolmentID.Text)
                    FillListView("SELECT AccountID,Debit,Remarks FROM tblJournals WHERE ReferenceNo='" & txtEnrolmentID.Text & "'", lvAssessment, False)
                End If

            Catch ex As MySqlException
                DisplayErrorMsg("frmMain", "cmdRemove_Click", ex.Number, ex.Message)
            End Try

        End If
    End Sub
    Private Sub Grid_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Grid.MouseDoubleClick
        Select Case Grid.RowSel
            Case 4
                If Grid.ColSel = 1 Then
                    If Grid.get_TextMatrix(4, 1) <> "" Then
                        Dim frm As New frmSelectYL()
                        frm.ShowDialog()
                    End If
                End If

        End Select
    End Sub

    Private Sub GridInfo2_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles GridInfo2.MouseDoubleClick
        Select Case GridInfo2.RowSel
            Case 7
                If GridInfo2.ColSel = 1 Then
                    If GridInfo2.get_TextMatrix(7, 1) <> "" Then
                        Dim frm As New frmRegFeesTemplate()
                        frm.ShowForm()
                    End If
                End If

            Case 3
                If GridInfo2.ColSel = 1 Then
                    If GridInfo2.get_TextMatrix(3, 1) <> "" Then
                        Dim frm As New frmAdjustMaxUnits()
                        frm.ShowForm()
                    End If
                End If
        End Select
    End Sub

    Private Sub cmdFeeTemplate_Click(sender As System.Object, e As System.EventArgs) Handles cmdFeeTemplate.Click
        If txtStudentID.Text = "" Then Exit Sub
        Dim frm As New frmRegFeesTemplate()
        frm.ShowForm()
    End Sub

    Private Sub cmdAssessment_Click(sender As System.Object, e As System.EventArgs) Handles cmdAssessment.Click


        If lvRegister.Items.Count < 0 Then Exit Sub

        Dim frm As New frmAssessment()
        frm.ShowForm(TransactionType.Enrollment, txtEnrolmentID.Text, DateTime.Now.Date, 1, curStudent.StudentNo)
    End Sub

    Public Sub DisplayStudentTemporaryRegistrationSubject(ByVal EnrolmentID As String)

        Dim num1, num2 As Integer ' SchedTimeEnd -SchedTimeStart
        Dim num21, num22 As Integer 'SchedTimeEnd2 - SchedTimeStart2
        Dim num31, num32 As Integer 'SchedTimeEnd3 - SchedTimeStart3
        Dim num41, num42 As Integer 'SchedTimeEnd4 - SchedTimeStart4
        Dim num51, num52 As Integer 'SchedTimeEnd5 - SchedTimeStart5

        Dim sDay, sDay2, sDay3, sDay4, sDay5 As String

        Dim Caption1 As String = ""
        Dim Caption2 As String = ""
        Dim Caption3 As String = ""
        Dim Caption4 As String = ""
        Dim Caption5 As String = ""

        Dim com As New MySqlCommand("CALL GetStudentTempEnrolledSubject('" & EnrolmentID & "')", con)
        Dim dr As MySqlDataReader = com.ExecuteReader()

        lvRegister.Items.Clear()
        dgView.Clear()
        TimeTable()

        While dr.Read()
            Dim lv As New ListViewItem(dr("SubjectCode").ToString())
            lv.SubItems.Add(dr("SubjectID").ToString())
            lv.SubItems.Add(dr("SubjectTitle").ToString())
            lv.SubItems.Add(dr("Section").ToString())
            lv.SubItems.Add(dr("Units").ToString())
            lv.SubItems.Add(dr("LabUnits").ToString())
            lv.SubItems.Add(dr("Faculty").ToString())
            lv.SubItems.Add(dr("Sched1").ToString())
            lv.SubItems.Add(dr("Room1").ToString())
            lv.SubItems.Add(dr("Sched2").ToString())
            lv.SubItems.Add(dr("Room2").ToString())
            lv.SubItems.Add(dr("Sched3").ToString())
            lv.SubItems.Add(dr("Room3").ToString())
            lv.SubItems.Add(dr("Sched4").ToString())
            lv.SubItems.Add(dr("Room4").ToString())
            lv.SubItems.Add(dr("Sched5").ToString())
            lv.SubItems.Add(dr("Room5").ToString())
            lv.SubItems.Add(dr("SID").ToString())
            lvRegister.Items.AddRange(New ListViewItem() {lv})

            For a As Integer = 0 To lvRegister.Items.Count - 1
                lv.ForeColor = Colors(a)
            Next

            If dr("Sched1").ToString() <> "" Then
                If dr("Room1").ToString() <> "" Then
                    Caption1 = dr("SubjectCode").ToString()
                    num1 = TimeToInt(dr("Time_Start1").ToString())
                    num2 = TimeToInt(dr("Time_End1").ToString())
                End If
            End If

            If dr("Sched2").ToString() <> "" Then
                If dr("Room2").ToString() <> "" Then
                    Caption2 = dr("SubjectCode").ToString()
                    num21 = TimeToInt(dr("Time_Start2").ToString())
                    num22 = TimeToInt(dr("Time_End2").ToString())
                End If
            End If

            If dr("Sched3").ToString() <> "" Then
                If dr("Room3").ToString() <> "" Then
                    Caption3 = dr("SubjectCode").ToString()
                    num31 = TimeToInt(dr("Time_Start3").ToString())
                    num32 = TimeToInt(dr("Time_End3").ToString())
                End If
            End If

            If dr("Sched4").ToString() <> "" Then
                If dr("Room4").ToString() <> "" Then
                    Caption4 = dr("SubjectCode").ToString()
                    num41 = TimeToInt(dr("Time_Start4").ToString())
                    num42 = TimeToInt(dr("Time_End4").ToString())
                End If
            End If

            If dr("Sched5").ToString() <> "" Then
                If dr("Room5").ToString() <> "" Then
                    Caption5 = dr("SubjectCode").ToString()
                    num51 = TimeToInt(dr("Time_Start5").ToString())
                    num52 = TimeToInt(dr("Time_End5").ToString())
                End If
            End If

            With dgView
                .AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
                .set_ColAlignment(0, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignCenterCenter)


                If dr("Days1").ToString <> "" And dr("Days2").ToString() <> "" And dr("Days3").ToString() <> "" And dr("Days4").ToString() <> "" And dr("Days5").ToString() <> "" Then
                    sDay = dr("Days1").ToString()
                    sDay2 = dr("Days2").ToString()
                    sDay3 = dr("Days3").ToString()
                    sDay4 = dr("Days4").ToString()
                    sDay5 = dr("Days5").ToString()

                    For time As Integer = num51 To num52
                        For i = 1 To Len(dr("Days5").ToString())
                            If dr("Days5").ToString() Like "*" & Microsoft.VisualBasic.Mid(sDay5, i, 1) & "*" Then
                                Dim n As Integer = Microsoft.VisualBasic.Mid(sDay5, i, 1)

                                .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpBackColor, n, time, lv.ForeColor)
                                '.set_TextMatrix(n, time, Caption5)
                                .set_MergeRow(n, True)
                            End If
                        Next
                    Next

                    For time As Integer = num41 To num42
                        For i = 1 To Len(dr("Days4").ToString())
                            If dr("Days4").ToString() Like "*" & Microsoft.VisualBasic.Mid(sDay4, i, 1) & "*" Then
                                Dim n As Integer = Microsoft.VisualBasic.Mid(sDay4, i, 1)
                                '.set_TextMatrix(n, time, Caption4)
                                .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpBackColor, n, time, lv.ForeColor)
                                .set_MergeRow(n, True)
                            End If
                        Next
                    Next

                    For time As Integer = num31 To num32
                        For i = 1 To Len(dr("Days3").ToString())
                            If dr("Days3").ToString() Like "*" & Microsoft.VisualBasic.Mid(sDay3, i, 1) & "*" Then
                                Dim n As Integer = Microsoft.VisualBasic.Mid(sDay3, i, 1)

                                .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpBackColor, n, time, lv.ForeColor)
                                '.set_TextMatrix(n, time, Caption3)
                                .set_MergeRow(n, True)
                            End If
                        Next
                    Next

                    For time As Integer = num21 To num22
                        For i = 1 To Len(dr("Days2").ToString())
                            If dr("Days2").ToString() Like "*" & Microsoft.VisualBasic.Mid(sDay2, i, 1) & "*" Then
                                Dim n As Integer = Microsoft.VisualBasic.Mid(sDay2, i, 1)

                                .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpBackColor, n, time, lv.ForeColor)
                                '.set_TextMatrix(n, time, Caption2)
                                .set_MergeRow(n, True)
                            End If
                        Next
                    Next

                    For time As Integer = num1 To num2
                        For i = 1 To Len(dr("Days1").ToString())
                            If dr("Days1").ToString() Like "*" & Microsoft.VisualBasic.Mid(sDay, i, 1) & "*" Then
                                Dim n As Integer = Microsoft.VisualBasic.Mid(sDay, i, 1)

                                .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpBackColor, n, time, lv.ForeColor)
                                '.set_TextMatrix(n, time, Caption1)
                                .set_MergeRow(n, True)
                            End If
                        Next
                    Next

                End If

                If dr("Days1").ToString <> "" And dr("Days2").ToString() <> "" And dr("Days3").ToString() <> "" And dr("Days4").ToString() <> "" Then

                    sDay = dr("Days1").ToString()
                    sDay2 = dr("Days2").ToString()
                    sDay3 = dr("Days3").ToString()
                    sDay4 = dr("Days4").ToString()

                    For time As Integer = num41 To num42
                        For i = 1 To Len(dr("Days4").ToString())
                            If dr("Days4").ToString() Like "*" & Microsoft.VisualBasic.Mid(sDay4, i, 1) & "*" Then
                                Dim n As Integer = Microsoft.VisualBasic.Mid(sDay4, i, 1)

                                .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpBackColor, n, time, lv.ForeColor)
                                '.set_TextMatrix(n, time, Caption4)
                                .set_MergeRow(n, True)
                            End If
                        Next
                    Next

                    For time As Integer = num31 To num32
                        For i = 1 To Len(dr("Days3").ToString())
                            If dr("Days3").ToString() Like "*" & Microsoft.VisualBasic.Mid(sDay3, i, 1) & "*" Then
                                Dim n As Integer = Microsoft.VisualBasic.Mid(sDay3, i, 1)

                                .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpBackColor, n, time, lv.ForeColor)
                                '.set_TextMatrix(n, time, Caption3)
                                .set_MergeRow(n, True)
                            End If
                        Next
                    Next

                    For time As Integer = num21 To num22
                        For i = 1 To Len(dr("Days2").ToString())
                            If dr("Days2").ToString() Like "*" & Microsoft.VisualBasic.Mid(sDay2, i, 1) & "*" Then
                                Dim n As Integer = Microsoft.VisualBasic.Mid(sDay2, i, 1)

                                .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpBackColor, n, time, lv.ForeColor)
                                '.set_TextMatrix(n, time, Caption2)
                                .set_MergeRow(n, True)
                            End If
                        Next
                    Next

                    For time As Integer = num1 To num2
                        For i = 1 To Len(dr("Days1").ToString())
                            If dr("Days1").ToString() Like "*" & Microsoft.VisualBasic.Mid(sDay, i, 1) & "*" Then
                                Dim n As Integer = Microsoft.VisualBasic.Mid(sDay, i, 1)

                                .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpBackColor, n, time, lv.ForeColor)
                                '.set_TextMatrix(n, time, Caption1)
                                .set_MergeRow(n, True)
                            End If
                        Next
                    Next

                End If

                If dr("Days1").ToString <> "" And dr("Days2").ToString() <> "" And dr("Days3").ToString() <> "" Then

                    sDay = dr("Days1").ToString()
                    sDay2 = dr("Days2").ToString()
                    sDay3 = dr("Days3").ToString()

                    For time As Integer = num31 To num32
                        For i = 1 To Len(dr("Days3").ToString())
                            If dr("Days3").ToString() Like "*" & Microsoft.VisualBasic.Mid(sDay3, i, 1) & "*" Then
                                Dim n As Integer = Microsoft.VisualBasic.Mid(sDay3, i, 1)

                                .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpBackColor, n, time, lv.ForeColor)
                                '.set_TextMatrix(n, time, Caption3)
                                .set_MergeRow(n, True)
                            End If
                        Next
                    Next

                    For time As Integer = num21 To num22
                        For i = 1 To Len(dr("Days2").ToString())
                            If dr("Days2").ToString() Like "*" & Microsoft.VisualBasic.Mid(sDay2, i, 1) & "*" Then
                                Dim n As Integer = Microsoft.VisualBasic.Mid(sDay2, i, 1)

                                .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpBackColor, n, time, lv.ForeColor)
                                '.set_TextMatrix(n, time, Caption2)
                                .set_MergeRow(n, True)
                            End If
                        Next
                    Next

                    For time As Integer = num1 To num2
                        For i = 1 To Len(dr("Days1").ToString())
                            If dr("Days1").ToString() Like "*" & Microsoft.VisualBasic.Mid(sDay, i, 1) & "*" Then
                                Dim n As Integer = Microsoft.VisualBasic.Mid(sDay, i, 1)

                                .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpBackColor, n, time, lv.ForeColor)
                                '.set_TextMatrix(n, time, Caption1)
                                .set_MergeRow(n, True)
                            End If
                        Next
                    Next
                End If


                If dr("Days1").ToString <> "" And dr("Days2").ToString() <> "" Then

                    sDay = dr("Days1").ToString()
                    sDay2 = dr("Days2").ToString()

                    For time As Integer = num21 To num22
                        For i = 1 To Len(dr("Days2").ToString())
                            If dr("Days2").ToString() Like "*" & Microsoft.VisualBasic.Mid(sDay2, i, 1) & "*" Then
                                Dim n As Integer = Microsoft.VisualBasic.Mid(sDay2, i, 1)

                                .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpBackColor, n, time, lv.ForeColor)
                                '.set_TextMatrix(n, time, Caption2)
                                .set_MergeRow(n, True)
                            End If
                        Next
                    Next

                    For time As Integer = num1 To num2
                        For i = 1 To Len(dr("Days1").ToString())
                            If dr("Days1").ToString() Like "*" & Microsoft.VisualBasic.Mid(sDay, i, 1) & "*" Then
                                Dim n As Integer = Microsoft.VisualBasic.Mid(sDay, i, 1)

                                .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpBackColor, n, time, lv.ForeColor)
                                '.set_TextMatrix(n, time, Caption1)
                                .set_MergeRow(n, True)
                            End If
                        Next
                    Next

                End If

                If dr("Days1").ToString <> "" Then
                    sDay = dr("Days1").ToString()

                    For time As Integer = num1 To num2
                        For i = 1 To Len(dr("Days1").ToString())
                            If dr("Days1").ToString() Like "*" & Microsoft.VisualBasic.Mid(sDay, i, 1) & "*" Then
                                Dim n As Integer = Microsoft.VisualBasic.Mid(sDay, i, 1)

                                .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpBackColor, n, time, lv.ForeColor)
                                '.set_TextMatrix(n, time, Caption1)
                                .set_MergeRow(n, True)
                            End If
                        Next
                    Next
                End If
            End With
        End While
        dr.Close()

        lblRegUnit.Text = GetTotalTempEnrolledLecUnits(EnrolmentID)
        lblRegLab.Text = GetTotalTempEnrolledLabUnits(EnrolmentID)
        lblRegSub.Text = lvRegister.Items.Count
    End Sub


    Public Sub DisplayStudentRegistrationSubject(ByVal EnrolmentID As String)

        Dim num1, num2 As Integer ' SchedTimeEnd -SchedTimeStart
        Dim num21, num22 As Integer 'SchedTimeEnd2 - SchedTimeStart2
        Dim num31, num32 As Integer 'SchedTimeEnd3 - SchedTimeStart3
        Dim num41, num42 As Integer 'SchedTimeEnd4 - SchedTimeStart4
        Dim num51, num52 As Integer 'SchedTimeEnd5 - SchedTimeStart5

        Dim sDay, sDay2, sDay3, sDay4, sDay5 As String

        Dim Caption1 As String = ""
        Dim Caption2 As String = ""
        Dim Caption3 As String = ""
        Dim Caption4 As String = ""
        Dim Caption5 As String = ""

        Dim com As New MySqlCommand("CALL GetStudentEnrolledSubject('" & EnrolmentID & "')", con)
        Dim dr As MySqlDataReader = com.ExecuteReader()

        lvRegister.Items.Clear()

        dgView.Clear()

        TimeTable()

        While dr.Read()
            Dim lv As New ListViewItem(dr("SubjectCode").ToString())
            lv.SubItems.Add(dr("SubjectID").ToString())
            lv.SubItems.Add(dr("SubjectTitle").ToString())
            lv.SubItems.Add(dr("Section").ToString())
            lv.SubItems.Add(dr("Units").ToString())
            lv.SubItems.Add(dr("LabUnits").ToString())
            lv.SubItems.Add(dr("Faculty").ToString())
            lv.SubItems.Add(dr("Sched1").ToString())
            lv.SubItems.Add(dr("Room1").ToString())
            lv.SubItems.Add(dr("Sched2").ToString())
            lv.SubItems.Add(dr("Room2").ToString())
            lv.SubItems.Add(dr("Sched3").ToString())
            lv.SubItems.Add(dr("Room3").ToString())
            lv.SubItems.Add(dr("Sched4").ToString())
            lv.SubItems.Add(dr("Room4").ToString())
            lv.SubItems.Add(dr("Sched5").ToString())
            lv.SubItems.Add(dr("Room5").ToString())
            lv.SubItems.Add(dr("SID").ToString())
            lvRegister.Items.AddRange(New ListViewItem() {lv})

            For a As Integer = 0 To lvRegister.Items.Count - 1
                lv.ForeColor = Colors(a)
            Next

            If dr("Sched1").ToString() <> "" Then
                If dr("Room1").ToString() <> "" Then
                    Caption1 = dr("SubjectCode").ToString()
                    num1 = TimeToInt(dr("Time_Start1").ToString())
                    num2 = TimeToInt(dr("Time_End1").ToString())
                End If
            End If

            If dr("Sched2").ToString() <> "" Then
                If dr("Room2").ToString() <> "" Then
                    Caption2 = dr("SubjectCode").ToString()
                    num21 = TimeToInt(dr("Time_Start2").ToString())
                    num22 = TimeToInt(dr("Time_End2").ToString())
                End If
            End If

            If dr("Sched3").ToString() <> "" Then
                If dr("Room3").ToString() <> "" Then
                    Caption3 = dr("SubjectCode").ToString()
                    num31 = TimeToInt(dr("Time_Start3").ToString())
                    num32 = TimeToInt(dr("Time_End3").ToString())
                End If
            End If

            If dr("Sched4").ToString() <> "" Then
                If dr("Room4").ToString() <> "" Then
                    Caption4 = dr("SubjectCode").ToString()
                    num41 = TimeToInt(dr("Time_Start4").ToString())
                    num42 = TimeToInt(dr("Time_End4").ToString())
                End If
            End If

            If dr("Sched5").ToString() <> "" Then
                If dr("Room5").ToString() <> "" Then
                    Caption5 = dr("SubjectCode").ToString()
                    num51 = TimeToInt(dr("Time_Start5").ToString())
                    num52 = TimeToInt(dr("Time_End5").ToString())
                End If
            End If

            With dgView
                .AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
                .set_ColAlignment(0, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignCenterCenter)


                If dr("Days1").ToString <> "" And dr("Days2").ToString() <> "" And dr("Days3").ToString() <> "" And dr("Days4").ToString() <> "" And dr("Days5").ToString() <> "" Then
                    sDay = dr("Days1").ToString()
                    sDay2 = dr("Days2").ToString()
                    sDay3 = dr("Days3").ToString()
                    sDay4 = dr("Days4").ToString()
                    sDay5 = dr("Days5").ToString()

                    For time As Integer = num51 To num52
                        For i = 1 To Len(dr("Days5").ToString())
                            If dr("Days5").ToString() Like "*" & Microsoft.VisualBasic.Mid(sDay5, i, 1) & "*" Then
                                Dim n As Integer = Microsoft.VisualBasic.Mid(sDay5, i, 1)

                                .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpBackColor, n, time, lv.ForeColor)
                                '.set_TextMatrix(n, time, Caption5)
                                .set_MergeRow(n, True)
                            End If
                        Next
                    Next

                    For time As Integer = num41 To num42
                        For i = 1 To Len(dr("Days4").ToString())
                            If dr("Days4").ToString() Like "*" & Microsoft.VisualBasic.Mid(sDay4, i, 1) & "*" Then
                                Dim n As Integer = Microsoft.VisualBasic.Mid(sDay4, i, 1)
                                '.set_TextMatrix(n, time, Caption4)
                                .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpBackColor, n, time, lv.ForeColor)
                                .set_MergeRow(n, True)
                            End If
                        Next
                    Next

                    For time As Integer = num31 To num32
                        For i = 1 To Len(dr("Days3").ToString())
                            If dr("Days3").ToString() Like "*" & Microsoft.VisualBasic.Mid(sDay3, i, 1) & "*" Then
                                Dim n As Integer = Microsoft.VisualBasic.Mid(sDay3, i, 1)

                                .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpBackColor, n, time, lv.ForeColor)
                                '.set_TextMatrix(n, time, Caption3)
                                .set_MergeRow(n, True)
                            End If
                        Next
                    Next

                    For time As Integer = num21 To num22
                        For i = 1 To Len(dr("Days2").ToString())
                            If dr("Days2").ToString() Like "*" & Microsoft.VisualBasic.Mid(sDay2, i, 1) & "*" Then
                                Dim n As Integer = Microsoft.VisualBasic.Mid(sDay2, i, 1)

                                .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpBackColor, n, time, lv.ForeColor)
                                '.set_TextMatrix(n, time, Caption2)
                                .set_MergeRow(n, True)
                            End If
                        Next
                    Next

                    For time As Integer = num1 To num2
                        For i = 1 To Len(dr("Days1").ToString())
                            If dr("Days1").ToString() Like "*" & Microsoft.VisualBasic.Mid(sDay, i, 1) & "*" Then
                                Dim n As Integer = Microsoft.VisualBasic.Mid(sDay, i, 1)

                                .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpBackColor, n, time, lv.ForeColor)
                                '.set_TextMatrix(n, time, Caption1)
                                .set_MergeRow(n, True)
                            End If
                        Next
                    Next

                End If

                If dr("Days1").ToString <> "" And dr("Days2").ToString() <> "" And dr("Days3").ToString() <> "" And dr("Days4").ToString() <> "" Then

                    sDay = dr("Days1").ToString()
                    sDay2 = dr("Days2").ToString()
                    sDay3 = dr("Days3").ToString()
                    sDay4 = dr("Days4").ToString()

                    For time As Integer = num41 To num42
                        For i = 1 To Len(dr("Days4").ToString())
                            If dr("Days4").ToString() Like "*" & Microsoft.VisualBasic.Mid(sDay4, i, 1) & "*" Then
                                Dim n As Integer = Microsoft.VisualBasic.Mid(sDay4, i, 1)

                                .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpBackColor, n, time, lv.ForeColor)
                                '.set_TextMatrix(n, time, Caption4)
                                .set_MergeRow(n, True)
                            End If
                        Next
                    Next

                    For time As Integer = num31 To num32
                        For i = 1 To Len(dr("Days3").ToString())
                            If dr("Days3").ToString() Like "*" & Microsoft.VisualBasic.Mid(sDay3, i, 1) & "*" Then
                                Dim n As Integer = Microsoft.VisualBasic.Mid(sDay3, i, 1)

                                .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpBackColor, n, time, lv.ForeColor)
                                '.set_TextMatrix(n, time, Caption3)
                                .set_MergeRow(n, True)
                            End If
                        Next
                    Next

                    For time As Integer = num21 To num22
                        For i = 1 To Len(dr("Days2").ToString())
                            If dr("Days2").ToString() Like "*" & Microsoft.VisualBasic.Mid(sDay2, i, 1) & "*" Then
                                Dim n As Integer = Microsoft.VisualBasic.Mid(sDay2, i, 1)

                                .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpBackColor, n, time, lv.ForeColor)
                                '.set_TextMatrix(n, time, Caption2)
                                .set_MergeRow(n, True)
                            End If
                        Next
                    Next

                    For time As Integer = num1 To num2
                        For i = 1 To Len(dr("Days1").ToString())
                            If dr("Days1").ToString() Like "*" & Microsoft.VisualBasic.Mid(sDay, i, 1) & "*" Then
                                Dim n As Integer = Microsoft.VisualBasic.Mid(sDay, i, 1)

                                .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpBackColor, n, time, lv.ForeColor)
                                '.set_TextMatrix(n, time, Caption1)
                                .set_MergeRow(n, True)
                            End If
                        Next
                    Next

                End If

                If dr("Days1").ToString <> "" And dr("Days2").ToString() <> "" And dr("Days3").ToString() <> "" Then

                    sDay = dr("Days1").ToString()
                    sDay2 = dr("Days2").ToString()
                    sDay3 = dr("Days3").ToString()

                    For time As Integer = num31 To num32
                        For i = 1 To Len(dr("Days3").ToString())
                            If dr("Days3").ToString() Like "*" & Microsoft.VisualBasic.Mid(sDay3, i, 1) & "*" Then
                                Dim n As Integer = Microsoft.VisualBasic.Mid(sDay3, i, 1)

                                .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpBackColor, n, time, lv.ForeColor)
                                '.set_TextMatrix(n, time, Caption3)
                                .set_MergeRow(n, True)
                            End If
                        Next
                    Next

                    For time As Integer = num21 To num22
                        For i = 1 To Len(dr("Days2").ToString())
                            If dr("Days2").ToString() Like "*" & Microsoft.VisualBasic.Mid(sDay2, i, 1) & "*" Then
                                Dim n As Integer = Microsoft.VisualBasic.Mid(sDay2, i, 1)

                                .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpBackColor, n, time, lv.ForeColor)
                                '.set_TextMatrix(n, time, Caption2)
                                .set_MergeRow(n, True)
                            End If
                        Next
                    Next

                    For time As Integer = num1 To num2
                        For i = 1 To Len(dr("Days1").ToString())
                            If dr("Days1").ToString() Like "*" & Microsoft.VisualBasic.Mid(sDay, i, 1) & "*" Then
                                Dim n As Integer = Microsoft.VisualBasic.Mid(sDay, i, 1)

                                .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpBackColor, n, time, lv.ForeColor)
                                '.set_TextMatrix(n, time, Caption1)
                                .set_MergeRow(n, True)
                            End If
                        Next
                    Next
                End If


                If dr("Days1").ToString <> "" And dr("Days2").ToString() <> "" Then

                    sDay = dr("Days1").ToString()
                    sDay2 = dr("Days2").ToString()

                    For time As Integer = num21 To num22
                        For i = 1 To Len(dr("Days2").ToString())
                            If dr("Days2").ToString() Like "*" & Microsoft.VisualBasic.Mid(sDay2, i, 1) & "*" Then
                                Dim n As Integer = Microsoft.VisualBasic.Mid(sDay2, i, 1)

                                .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpBackColor, n, time, lv.ForeColor)
                                '.set_TextMatrix(n, time, Caption2)
                                .set_MergeRow(n, True)
                            End If
                        Next
                    Next

                    For time As Integer = num1 To num2
                        For i = 1 To Len(dr("Days1").ToString())
                            If dr("Days1").ToString() Like "*" & Microsoft.VisualBasic.Mid(sDay, i, 1) & "*" Then
                                Dim n As Integer = Microsoft.VisualBasic.Mid(sDay, i, 1)

                                .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpBackColor, n, time, lv.ForeColor)
                                '.set_TextMatrix(n, time, Caption1)
                                .set_MergeRow(n, True)
                            End If
                        Next
                    Next

                End If

                If dr("Days1").ToString <> "" Then
                    sDay = dr("Days1").ToString()

                    For time As Integer = num1 To num2
                        For i = 1 To Len(dr("Days1").ToString())
                            If dr("Days1").ToString() Like "*" & Microsoft.VisualBasic.Mid(sDay, i, 1) & "*" Then
                                Dim n As Integer = Microsoft.VisualBasic.Mid(sDay, i, 1)

                                .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpBackColor, n, time, lv.ForeColor)
                                '.set_TextMatrix(n, time, Caption1)
                                .set_MergeRow(n, True)
                            End If
                        Next
                    Next
                End If
            End With
        End While
        dr.Close()

        lblRegUnit.Text = GetTotalTempEnrolledLecUnits(EnrolmentID)
        lblRegLab.Text = GetTotalTempEnrolledLabUnits(EnrolmentID)
        lblRegSub.Text = lvRegister.Items.Count

    End Sub

End Class
