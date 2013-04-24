Option Explicit On
Imports MySql.Data.MySqlClient
Module modDBEnrolment

    Public Conf As EnrolSettings

    Public Const KeyEnrolment = "enro"

    Public Const CheckPreRequisite = "Allows to check subject pre-requisite/co-requisite before registering subject..."
    Public Const AllowIncomplateGrades = "Overrides the Registration process were it allows student with Incomplete Grades to enroll..."


    Public Structure tEnrolment
        Dim EnrolmentID As String
        Dim TermID As Integer
        Dim IsWithDraw As Short
        Dim DateWithDrawn As String
        Dim CampusID As Integer
        Dim CollegeID As String
        Dim ProgramID As Integer
        Dim MajorID As Integer
        Dim StudentID As String
        Dim SectionOfferingID As String
        Dim YearLevelID As Integer
        Dim DateEnroled As String
        Dim ExpireDate As String
        Dim SubjectsEnrolled As Integer
        Dim TotalLectUnits As Integer
        Dim TotalLabUnits As Integer
        Dim AdvisingOfficerID As String
        Dim ValidatingOfficerID As String
        Dim ValidationDate As String
        Dim ORNumber As String
        Dim AssessedFees As Decimal
        Dim Discount As Decimal

        Dim FeeTemplateID As Integer

        Dim SchoProviderType As Integer
        Dim SchoProviderID As Integer
        Dim GrantTemplateID As Integer

        Dim AssessedBy As String
        Dim AssessedDate As String

        Dim FirstPaymentDueDate As String
        Dim SecondPaymentDueDate As String
        Dim ThirdPaymentDueDate As String
        Dim FourthPaymentDueDate As String
        Dim FifthPaymentDueDate As String

        Dim TotalAssessment As Decimal
        Dim TotalFinancialAid As Decimal
        Dim TotalNetAssessed As Decimal
        Dim TotalNonLedger As Decimal
        Dim TotalRefund As Decimal
        Dim TotalBalance As Decimal

        Dim CreationDate As String
        Dim CreatedBy As String
        Dim ModifiedDate As String
        Dim ModifiedBy As String
    End Structure


    Public Structure tEnrolmentDetails
        Dim ReferenceID As Integer
        Dim EnrollmentID As String
        Dim ScheduleID As String ' SubjectOfferingID 
        Dim RegTagID As String
        Dim RefNo As Integer
        Dim CSTargetScheduleID As String
        Dim sDefault As Short
        Dim SeqNo As Integer
        Dim ScheduleID_Old As String
        Dim WithDrawnSchedID As String

        'Optional
        Dim FeeTemplateID As String
    End Structure

    Public Structure EnrolSettings
        Dim ConfigID As Integer
        Dim TermID As Integer
        Dim CampusID As Integer
        Dim CheckPreReq As Short
        Dim AllowWithBalance As Short
        Dim AllowIncompleteGrade As Short
        Dim CheckConflictSched As Short
        Dim ShowAllBlockSection As Short
        Dim AllowCrossEnroll As Short
        Dim ShowStudentGrades As Short
        Dim AllowMaxUnits As Short
        Dim PrintAssessmentUponSave As Short
        Dim PrintRegistrationUponSave As Short
        Dim PreviewPreviousBalance As Short
        'Dim ChargeReservationFee As Short
        Dim ChargeLateEnrollmentFee As Short
        Dim ChargeLabFee As Short
        Dim OverRideExpireReg As Short
        Dim TFChargeMode As Short
        Dim AllowOverloading As Short
        Dim FirstPaymentDueDate As Date
        Dim SecondPaymentDueDate As Date
        Dim ThirdPaymentDueDate As Date
        Dim FifthPaymentDueDate As Date
        Dim FourthPaymentDueDate As Date
        Dim NumberOfPayment As Date
        Dim PrintCORNotYetValidated As Short
    End Structure

    Public Function CheckEnrolmentSettings() As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblEnrolmentConfig", con)
        Dim rs As MySqlDataReader = com.ExecuteReader
        rs.Read()
        If rs.HasRows Then
            CheckEnrolmentSettings = TranDBResult.Success
        Else
            CheckEnrolmentSettings = TranDBResult.Failed
        End If
        rs.Close()
    End Function

    Public Function GetEnrollmentConfig(ByVal TermID As Integer, ByRef sSet As EnrolSettings) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblEnrolmentConfig WHERE TermID='" & TermID & "'", con)
        Dim rs As MySqlDataReader = com.ExecuteReader
        rs.Read()
        If rs.HasRows Then
            sSet.TermID = rs("TermID").ToString()
            sSet.CampusID = rs("CampusID").ToString()
            sSet.ConfigID = rs("configID").ToString()
            sSet.CheckPreReq = rs("CheckPreReq").ToString()
            sSet.AllowIncompleteGrade = rs("AllowInc").ToString()
            sSet.CheckConflictSched = rs("CheckConflictSchedule").ToString()
            sSet.ShowAllBlockSection = rs("DisplayAllBSections").ToString()
            sSet.AllowCrossEnroll = rs("AllowCrossEnroll").ToString()
            sSet.ShowStudentGrades = rs("ShowStudentGrades").ToString()
            sSet.AllowMaxUnits = rs("AutoMaxUnitsAllowed").ToString()
            sSet.PrintAssessmentUponSave = rs("PrintAssessmentUponSave").ToString()
            'sSet.PrintRegistrationUponSave = rs("PrintRegistrationUponSave").ToString()
            sSet.AllowWithBalance = rs("AllowWithBalance").ToString()
            sSet.PreviewPreviousBalance = rs("ViewPreviousOutstandingBalance").ToString()
            sSet.ChargeLateEnrollmentFee = rs("ChargeLateEnrollmentFee").ToString()
            sSet.ChargeLabFee = rs("ChargeLabFee").ToString()
            sSet.OverRideExpireReg = rs("OverRideExpireReg").ToString()
            sSet.TFChargeMode = rs("TFChargeMode").ToString()
            sSet.AllowOverloading = rs("AllowOverloading").ToString()
            sSet.PrintCORNotYetValidated = rs("PrintCORNotYetValidated").ToString()

            sSet.FirstPaymentDueDate = rs("FirstPaymentDueDate").ToString()
            sSet.SecondPaymentDueDate = rs("SecondPaymentDueDate").ToString()
            sSet.ThirdPaymentDueDate = rs("ThirdPaymentDueDate").ToString()
            sSet.FourthPaymentDueDate = rs("FourthPaymentDueDate").ToString()
            sSet.FifthPaymentDueDate = rs("FifthPaymentDueDate").ToString()
            'sSet.NumberOfPayment = rs("NumberOfPayment").ToString()



            GetEnrollmentConfig = TranDBResult.Success
        Else
            GetEnrollmentConfig = TranDBResult.Failed
        End If
        rs.Close()
    End Function

    Public Function SetEnrollmentConfig(ByVal sSet As EnrolSettings) As TranDBResult

        If EnrolmentConfigExistByTerm(sSet.TermID) = TranDBResult.Success Then
            If InsertEnrollmentConfig(sSet) = TranDBResult.Success Then
                SetEnrollmentConfig = TranDBResult.Success
            Else
                SetEnrollmentConfig = TranDBResult.Failed
            End If
        Else
            If UpdateEnrollmentConfig(sSet) = TranDBResult.Success Then
                SetEnrollmentConfig = TranDBResult.Success
            Else
                SetEnrollmentConfig = TranDBResult.Failed
            End If
        End If

    End Function

    Public Function EnrolmentConfigExistByTerm(ByVal TermID As Integer) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblAYtem WHERE TermID='" & TermID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            EnrolmentConfigExistByTerm = TranDBResult.Success
        Else
            EnrolmentConfigExistByTerm = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function InsertEnrollmentConfig(ByVal sSet As EnrolSettings) As TranDBResult
        With sSet
            Dim com As New MySqlCommand("INSERT INTO tblEnrolmentConfig(`TermID`,`CampusID`,`CheckPreReq`,`AllowIncompleteGrade`,`CheckConflictSched`," & _
                    "`ShowAllBlockSection`,`AllowCrossEnroll`,`ShowStudentGrades`,`AllowMaxUnits`,`PrintAssessmentUponSave`,`PrintRegistrationUponSave`," & _
                    "`AllowWithBalance`,`ViewPreviousBalance`,`ChargeLateEnrollmentFee`,`ChargeLabFee`,`OverRideExpireReg`," & _
                    "`TFChargeMode`,`AllowOverloading`,`PrintCORNotYetValidated`) VALUES " & _
                    "('" & .TermID & "','" & .CampusID & "','" & .CheckPreReq & "','" & .AllowIncompleteGrade & "','" & .CheckConflictSched & _
                    "','" & .ShowAllBlockSection & "','" & .AllowCrossEnroll & "','" & .ShowStudentGrades & "','" & .AllowMaxUnits & "','" & .PrintAssessmentUponSave & "','" & .PrintRegistrationUponSave & _
                    "','" & .AllowWithBalance & "','" & .PreviewPreviousBalance & "','" & .ChargeLateEnrollmentFee & "','" & .ChargeLabFee & "','" & .OverRideExpireReg & _
                    "','" & .TFChargeMode & "','" & .AllowOverloading & "','" & .PrintCORNotYetValidated & "')", con)

            com.ExecuteNonQuery()
        End With

        InsertEnrollmentConfig = TranDBResult.Success

    End Function

    Public Function UpdateEnrollmentConfig(ByVal sSET As EnrolSettings) As TranDBResult
        With sSET
            Dim com As New MySqlCommand("UPDATE tblEnrolmentConfig SET CampusID ='" & .CampusID & "',CheckPreReq='" & .CheckPreReq & "',AllowIncompleteGrade='" & .AllowIncompleteGrade & "',CheckConflictSched='" & .CheckConflictSched & _
                                        "',ShowAllBlockSection='" & .ShowAllBlockSection & "',AllowCrossEnroll='" & .AllowCrossEnroll & "',ShowStudentGrades='" & .ShowStudentGrades & "',AllowMaxUnits='" & .AllowMaxUnits & "',PrintAssessmentUponSave='" & .PrintAssessmentUponSave & "',PrintRegistrationUponSave = '" & .PrintRegistrationUponSave & _
                                        "',AllowWithBalance='" & .AllowWithBalance & "',ViewPreviousBalance='" & .PreviewPreviousBalance & "',ChargeLateEnrollmentFee='" & .ChargeLateEnrollmentFee & "',ChargeLabFee='" & .ChargeLabFee & "',OverRideExprireReg='" & .OverRideExpireReg & _
                                        "',TFChargeMode='" & .TFChargeMode & "',AllowOverLoading='" & .AllowOverloading & "',PrintCORNotYetValidated='" & .PrintRegistrationUponSave & "' WHERE TermID='" & .TermID & "' AND ConfigID='" & .ConfigID & "'", con)
            com.ExecuteNonQuery()
        End With
        UpdateEnrollmentConfig = TranDBResult.Success
    End Function


    Public Function GetEnrollmentAcademicYearTerm(ByVal TermID As Integer) As String
        Dim com As New MySqlCommand("SELECT fnAcademicYearTerm('" & TermID & "')", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            GetEnrollmentAcademicYearTerm = vRS(0).ToString()
        Else
            GetEnrollmentAcademicYearTerm = "0000"
        End If
        vRS.Close()
    End Function

    Public Function AddEnrolment(ByVal NewEnrolment As tEnrolment) As TranDBResult
        '--------------------------------------------------------------
        'check
        '--------------------------------------------------------------

        'find duplicate ID
        If EnrolmentExistByID(NewEnrolment.EnrolmentID) = TranDBResult.Success Then
            AddEnrolment = TranDBResult.DuplicateID
            Exit Function
        End If


        If StudentExistByID(NewEnrolment.StudentID) <> TranDBResult.Success Then
            AddEnrolment = TranDBResult.EnrolmentStudentIDNotFound
            Exit Function
        End If

        If SectionExistByID(NewEnrolment.SectionOfferingID) <> TranDBResult.Success Then
            AddEnrolment = TranDBResult.EnrolmentSectionIDNotFound
            Exit Function
        End If


        'set creation date
        NewEnrolment.CreationDate = FormatDateTime(Now, vbShortDate)

        Try
            Dim com As New MySqlCommand("INSERT INTO tblEnrolment(EnrolmentID,TermID,IsWithdraw,StudentID,CampusID,CollegeID,ProgramID,MajorID,SectionOfferingID,YearLevelID,DateEnroled, " & _
                                   "CreationDate,CreatedBy,SubjectsEnrolled,TotalLectUnits,TotalLabUnits,AdvisingOfficerID,AssessedFees,Discount,FeeTemplateID,FirstPaymentDueDate,SecondPaymentDueDate, " & _
                                   "ThirdPaymentDueDate,FourthPaymentDueDate,FifthPaymentDueDate,TotalAssessment,TotalNetAssessed) VALUES " & _
                                   "('" & NewEnrolment.EnrolmentID & "','" & NewEnrolment.TermID & "','" & NewEnrolment.IsWithDraw & _
                                   "','" & NewEnrolment.StudentID & "','" & NewEnrolment.CampusID & "','" & NewEnrolment.CollegeID & _
                                   "','" & NewEnrolment.ProgramID & "','" & NewEnrolment.MajorID & "','" & NewEnrolment.SectionOfferingID & _
                                   "','" & NewEnrolment.YearLevelID & "',@DateEnrolled,@Date,'" & NewEnrolment.CreatedBy & "','" & NewEnrolment.SubjectsEnrolled & "','" & NewEnrolment.TotalLectUnits & _
                                   "','" & NewEnrolment.TotalLabUnits & "','" & NewEnrolment.AdvisingOfficerID & "',@Assess,@Discount,'" & NewEnrolment.FeeTemplateID & _
                                   "',@First,@Second,@Third,@Fourth,@Fifth,@Assessment,@NetAssessed)", clsCon.con)

            com.Parameters.Add("@First", MySqlDbType.Date).Value = NewEnrolment.FirstPaymentDueDate
            com.Parameters.Add("@Second", MySqlDbType.Date).Value = NewEnrolment.SecondPaymentDueDate
            com.Parameters.Add("@Third", MySqlDbType.Date).Value = NewEnrolment.ThirdPaymentDueDate
            com.Parameters.Add("@Fourth", MySqlDbType.Date).Value = NewEnrolment.FourthPaymentDueDate
            com.Parameters.Add("@Fifth", MySqlDbType.Date).Value = NewEnrolment.FirstPaymentDueDate

            com.Parameters.Add("@DateEnrolled", MySqlDbType.Date).Value = NewEnrolment.DateEnroled
            com.Parameters.Add("@Date", MySqlDbType.Date).Value = NewEnrolment.CreationDate

            com.Parameters.Add("@Assessment", MySqlDbType.Decimal).Value = NewEnrolment.TotalAssessment
            com.Parameters.Add("@NetAssessed", MySqlDbType.Decimal).Value = NewEnrolment.TotalNetAssessed
            com.Parameters.Add("@Assess", MySqlDbType.Decimal).Value = NewEnrolment.AssessedFees
            com.Parameters.Add("@Discount", MySqlDbType.Decimal).Value = NewEnrolment.Discount

            com.ExecuteNonQuery()
            com.Parameters.Clear()

            AddEnrolment = TranDBResult.Success
        Catch ex As Exception
            AddEnrolment = TranDBResult.Failed
        End Try

    End Function

    Public Function AddEnrollmentDetails(ByVal Enrol As tEnrolmentDetails) As TranDBResult

        If CheckEnrolledSubject(Enrol.ScheduleID, Enrol.EnrollmentID) = TranDBResult.Success Then
            AddEnrollmentDetails = TranDBResult.DuplicateTitle ' Check if Subject Offering is already enrolled
            Exit Function
        End If

        Try
            Dim com As New MySqlCommand("INSERT INTO tblEnrolmentDetails(EnrollmentID,ScheduleID,SeqNo,RegTagID) VALUES ('" & Enrol.EnrollmentID & _
                                        "','" & Enrol.ScheduleID & "','" & Enrol.SeqNo & "','" & Enrol.RegTagID & "')", con)
            com.ExecuteNonQuery()

            AddEnrollmentDetails = TranDBResult.Success
        Catch ex As Exception
            AddEnrollmentDetails = TranDBResult.Failed
        End Try

    End Function

    Public Function AddTempEnrolment(ByVal NewEnrolment As tEnrolment) As TranDBResult
        '--------------------------------------------------------------
        'check
        '--------------------------------------------------------------

        If StudentExistByID(NewEnrolment.StudentID) <> TranDBResult.Success Then
            AddTempEnrolment = TranDBResult.EnrolmentStudentIDNotFound
            Exit Function
        End If

        If SectionExistByID(NewEnrolment.SectionOfferingID) <> TranDBResult.Success Then
            AddTempEnrolment = TranDBResult.EnrolmentSectionIDNotFound
            Exit Function
        End If


        'set creation date
        NewEnrolment.CreationDate = FormatDateTime(Now, vbShortDate)

        Try
            Dim com As New MySqlCommand("INSERT INTO tblEnrolment_Temp(EnrolmentID,TermID,IsWithdraw,StudentID,CampusID,CollegeID,ProgramID,MajorID,SectionOfferingID,YearLevelID,DateEnroled, " & _
                                   "CreationDate,CreatedBy,SubjectsEnrolled,TotalLectUnits,TotalLabUnits,AdvisingOfficerID,FeeTemplateID) VALUES " & _
                                   "('" & NewEnrolment.EnrolmentID & "','" & NewEnrolment.TermID & "','" & NewEnrolment.IsWithDraw & _
                                   "','" & NewEnrolment.StudentID & "','" & NewEnrolment.CampusID & "','" & NewEnrolment.CollegeID & _
                                   "','" & NewEnrolment.ProgramID & "','" & NewEnrolment.MajorID & "','" & NewEnrolment.SectionOfferingID & _
                                   "','" & NewEnrolment.YearLevelID & "',@DateEnrolled,@Date,'" & NewEnrolment.CreatedBy & "','" & NewEnrolment.SubjectsEnrolled & "','" & NewEnrolment.TotalLectUnits & _
                                   "','" & NewEnrolment.TotalLabUnits & "','" & NewEnrolment.AdvisingOfficerID & "','" & NewEnrolment.FeeTemplateID & "')", clsCon.con)

            com.Parameters.Add("@DateEnrolled", MySqlDbType.Date).Value = NewEnrolment.DateEnroled
            com.Parameters.Add("@Date", MySqlDbType.Date).Value = NewEnrolment.CreationDate

            com.ExecuteNonQuery()
            com.Parameters.Clear()

            AddTempEnrolment = TranDBResult.Success
        Catch ex As Exception
            AddTempEnrolment = TranDBResult.Failed
        End Try

    End Function

    Public Function AddTempEnrolmentDetails(ByVal Enrol As tEnrolmentDetails) As TranDBResult

        If EnrolmentTempExistByID(Enrol.EnrollmentID) = TranDBResult.Failed Then

            If CheckTempEnrolledSubject(Enrol.ScheduleID, Enrol.EnrollmentID) = TranDBResult.Success Then
                AddTempEnrolmentDetails = TranDBResult.DuplicateTitle ' Check if Subject Offering is already enrolled
                Exit Function
            End If

            Dim com As New MySqlCommand("INSERT INTO tblEnrolmentDetails_Temp(EnrollmentID,ScheduleID,SeqNo,RegTagID,FeeTemplateID) VALUES ('" & Enrol.EnrollmentID & _
                                        "','" & Enrol.ScheduleID & "','" & Enrol.SeqNo & "','" & Enrol.RegTagID & "','" & Enrol.FeeTemplateID & "')", con)
            com.ExecuteNonQuery()

            AddTempEnrolmentDetails = TranDBResult.Success
        Else

            If CheckTempEnrolledSubject(Enrol.ScheduleID, Enrol.EnrollmentID) = TranDBResult.Success Then
                AddTempEnrolmentDetails = TranDBResult.DuplicateTitle ' Check if Subject Offering is already enrolled
                Exit Function
            End If

            Dim com As New MySqlCommand("INSERT INTO tblEnrolmentDetails_Temp(EnrollmentID,ScheduleID,SeqNo,RegTagID,FeeTemplateID) VALUES ('" & Enrol.EnrollmentID & _
                                        "','" & Enrol.ScheduleID & "','" & Enrol.SeqNo & "','" & Enrol.RegTagID & "','" & Enrol.FeeTemplateID & "')", con)
            com.ExecuteNonQuery()

            AddTempEnrolmentDetails = TranDBResult.Success

        End If
    End Function

    Public Function CheckTempEnrolledSubject(ByVal SubjectOfferingID As String, ByVal EnrollmentID As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblEnrolmentDetails_Temp WHERE ScheduleID = '" & SubjectOfferingID & "' AND EnrollmentID ='" & EnrollmentID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows = True Then
            CheckTempEnrolledSubject = TranDBResult.Success
        Else
            CheckTempEnrolledSubject = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function CheckEnrolledSubject(ByVal SubjectOfferingID As String, ByVal EnrollmentID As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblEnrolmentDetails WHERE ScheduleID = '" & SubjectOfferingID & "' AND EnrollmentID ='" & EnrollmentID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows = True Then
            CheckEnrolledSubject = TranDBResult.Success
        Else
            CheckEnrolledSubject = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function EditEnrolment(ByVal vEnrolment As tEnrolment) As TranDBResult

        Dim com As New MySqlCommand("SELECT * From tblEnrolment WHERE tblEnrolment.EnrolmentID)='" & vEnrolment.EnrolmentID & "'", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        If vRS.HasRows = False Then
            EditEnrolment = TranDBResult.InvalidID
            GoTo ReleaseAndExit
        End If

        Dim dsEnrollment As New Data.DataSet()
        Dim daEnrollment As New MySqlDataAdapter()
        Dim dt As Data.DataTable = dsEnrollment.Tables("tlbEnrolment")
        daEnrollment.SelectCommand = com
        daEnrollment.Fill(dsEnrollment, "tblEnrolment")

        With dt
            .Rows(0)("SchoolYear") = vEnrolment.TermID
            .Rows(0)("StudentID") = vEnrolment.StudentID
            .Rows(0)("SectionOfferingID") = vEnrolment.SectionOfferingID
            .Rows(0)("DateEnroled") = vEnrolment.DateEnroled

            .Rows(0)("ModifiedDate") = vEnrolment.ModifiedDate
            .Rows(0)("ModifiedBy") = vEnrolment.ModifiedBy
        End With
        daEnrollment.Update(dsEnrollment, "tblEnrolment")

        EditEnrolment = TranDBResult.Success

ReleaseAndExit:
        vRS.Close()
    End Function

    Public Function ExecuteDeleteEnrolment(ByVal sEnrolmentID As String) As TranDBResult

        'check if record exist and if it is edited by other user
        If MsgBox("WARNING:" & vbNewLine & _
            "Deleting this Enrolment entry will affect all other record" & vbNewLine & vbNewLine & _
            "Delete this record anyway?", vbQuestion + vbYesNo) = vbYes Then

            If DeleteEnrolment(sEnrolmentID) = TranDBResult.Success Then
                MsgBox("Enrolment entry and other related record succesfully deleted.", vbInformation)
                ExecuteDeleteEnrolment = TranDBResult.Success
            Else
                MsgBox("Deleting Enrolment entry went failed.", vbExclamation)
                ExecuteDeleteEnrolment = TranDBResult.Failed
            End If
        Else
            ExecuteDeleteEnrolment = TranDBResult.Failed
        End If
    End Function



    Public Function DeleteEnrolment(ByVal sEnrolmentID As String) As TranDBResult
        Try
            Dim com As New MySqlCommand("Delete * From tblEnrolment WHERE tblEnrolment.EnrolmentID='" & sEnrolmentID & "'", clsCon.con)
            com.ExecuteNonQuery()
            DeleteEnrolment = TranDBResult.Success
        Catch ex As Exception
            DeleteEnrolment = TranDBResult.Failed
        End Try
    End Function




    Public Function GetEnrolmentByID(ByVal sEnrolmentID As String, ByRef vEnrolment As tEnrolment) As TranDBResult
        Dim com As New MySqlCommand("SELECT * From tblEnrolment WHERE tblEnrolment.EnrolmentID='" & sEnrolmentID & "'", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()

        vRS.Read()
        If vRS.HasRows = True Then
            '----------------------------------------------------------------
            vEnrolment.EnrolmentID = (vRS("EnrolmentID").ToString())
            vEnrolment.TermID = (vRS("TermID").ToString())
            vEnrolment.StudentID = (vRS("StudentID").ToString())
            vEnrolment.SectionOfferingID = (vRS("SectionOfferingID").ToString())
            vEnrolment.DateEnroled = (vRS("DateEnroled").ToString())
            vEnrolment.CollegeID = vRS("CollegeID").ToString()
            vEnrolment.ProgramID = vRS("ProgramID").ToString()
            vEnrolment.MajorID = vRS("MajorID").ToString()
            vEnrolment.YearLevelID = vRS("YearLevelID").ToString()


            vEnrolment.ValidationDate = vRS("ValidationDate").ToString()
            vEnrolment.CreationDate = (vRS("CreationDate").ToString())
            vEnrolment.CreatedBy = (vRS("CreatedBy").ToString())
            vEnrolment.ModifiedDate = (vRS("ModifiedDate").ToString())
            vEnrolment.ModifiedBy = (vRS("ModifiedBy").ToString())


            GetEnrolmentByID = TranDBResult.Success

        Else

            'FAILED: record does not exist
            GetEnrolmentByID = TranDBResult.Failed
        End If

        'release
        vRS.Close()
    End Function



    Public Function GetEnrolmentByStudentIDByYearLevelTitle(ByVal sStudentID As String, ByVal sYearLevelTitle As String, ByRef vEnrolment As tEnrolment) As TranDBResult
        Dim sSQL As String

        'sSQL = "SELECT tblEnrolment.EnrolmentID, tblEnrolment.SchoolYear, tblEnrolment.StudentID, tblEnrolment.SectionOfferingID, tblEnrolment.CreationDate" & _
        '        " FROM tblYearLevel INNER JOIN (tblSection INNER JOIN tblEnrolment ON tblSection.SectionOfferingID = tblEnrolment.SectionOfferingID) ON tblYearLevel.YearLevelID = tblSection.YearLevelID" & _
        '        " Where (((tblEnrolment.StudentID) = '" & sStudentID & "') And ((tblYearLevel.YearLevelTitle) = '" & sYearLevelTitle & "'))" & _
        '       " GROUP BY tblEnrolment.EnrolmentID, tblEnrolment.SchoolYear, tblEnrolment.StudentID, tblEnrolment.SectionOfferingID, tblEnrolment.CreationDate;"

        sSQL = "SELECT tblEnrolment.EnrolmentID, tblEnrolment.SchoolYear, tblEnrolment.StudentID, tblEnrolment.SectionID, tblEnrolment.CreationDate" & _
                " FROM tblEnrolment, tblYearLevel INNER JOIN tblSection ON tblYearLevel.YearLevelID = tblSection.YearLevelID" & _
                " Where (((tblEnrolment.StudentID) = '" & sStudentID & "') And ((tblYearLevel.YearLevelTitle) = '" & sYearLevelTitle & "'))" & _
                "GROUP BY tblEnrolment.EnrolmentID, tblEnrolment.SchoolYear, tblEnrolment.StudentID, tblEnrolment.SectionID, tblEnrolment.CreationDate"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()

        vRS.Read()
        If vRS.HasRows = True Then
            '----------------------------------------------------------------
            vEnrolment.EnrolmentID = (vRS("EnrolmentID"))
            vEnrolment.TermID = (vRS("SchoolYear"))
            vEnrolment.StudentID = (vRS("StudentID"))
            vEnrolment.SectionOfferingID = (vRS("SectionOfferingID"))
            vEnrolment.DateEnroled = (vRS("DateEnroled"))

            vEnrolment.CreationDate = (vRS("CreationDate"))
            vEnrolment.CreatedBy = (vRS("CreatedBy"))
            vEnrolment.ModifiedDate = (vRS("ModifiedDate"))
            vEnrolment.ModifiedBy = (vRS("ModifiedBy"))

            GetEnrolmentByStudentIDByYearLevelTitle = TranDBResult.Success

        Else

            'FAILED: record does not exist
            GetEnrolmentByStudentIDByYearLevelTitle = TranDBResult.Failed
        End If

        'release
        vRS.Close()
    End Function

    Public Function GetEnrolmentCountBySYBySectionTitle(ByVal sSchoolYearTitle As String, ByVal sSectionTitle As String, ByRef EnrolmentCount As Long, ByVal MaxAllowed As Long) As TranDBResult
        Dim sSQL As String

        sSQL = "SELECT Count(*) AS StudentCount, tblEnrolment.SchoolYear, tblSection.MaxStudentCount, tblEnrolment.SchoolYear, tblSection.SectionTitle" & _
                " FROM tblEnrolment, tblYearLevel INNER JOIN tblSection ON tblYearLevel.YearLevelID = tblSection.YearLevelID" & _
                " GROUP BY tblEnrolment.SchoolYear, tblSection.MaxStudentCount, tblEnrolment.SchoolYear, tblSection.SectionTitle" & _
                " Having (((tblEnrolment.SchoolYear) = '" & sSchoolYearTitle & "') And ((tblSection.SectionTitle) = '" & sSectionTitle & "'))" & _
                " ORDER BY tblSection.SectionTitle"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()

        vRS.Read()
        If vRS.HasRows = True Then
            '----------------------------------------------------------------
            EnrolmentCount = vRS("StudentCount").ToString()
            MaxAllowed = vRS("MaxStudentCount").ToString()
            GetEnrolmentCountBySYBySectionTitle = TranDBResult.Success

        Else

            sSQL = "SELECT tblSection.MaxStudentCount" & _
                    " From tblSection" & _
                    " Where (((tblSection.SectionTitle) = '" & sSectionTitle & "'))" & _
                    " GROUP BY tblSection.MaxStudentCount;"
            vRS.Close()
            Dim com1 As New MySqlCommand(sSQL, clsCon.con)
            Dim vRS1 As MySqlDataReader = com.ExecuteReader()
            vRS1.Read()
            If vRS1.HasRows = True Then
                EnrolmentCount = 0
                MaxAllowed = vRS1("MaxStudentCount").ToString()
                GetEnrolmentCountBySYBySectionTitle = TranDBResult.Success
            Else
                GetEnrolmentCountBySYBySectionTitle = TranDBResult.Failed
            End If
            vRS1.Close()
        End If
        vRS.Close()
    End Function
    Private Sub ReadFromRecord(ByRef com As MySqlCommand, ByRef vEnrolment As tEnrolment)
        Dim dsEnrolment As New Data.DataSet()
        Dim daEnrolment As New MySqlDataAdapter()
        daEnrolment.SelectCommand = com
        daEnrolment.Fill(dsEnrolment, "tblEnrolment")
        Dim dt As Data.DataTable = dsEnrolment.Tables("tblEnrolment")

        vEnrolment.EnrolmentID = (dt.Rows(0)("EnrolmentID"))
        vEnrolment.TermID = (dt.Rows(0)("SchoolYear"))
        vEnrolment.StudentID = (dt.Rows(0)("StudentID"))
        vEnrolment.SectionOfferingID = (dt.Rows(0)("SectionOfferingID"))
        vEnrolment.DateEnroled = (dt.Rows(0)("DateEnroled"))

        vEnrolment.CreationDate = (dt.Rows(0)("CreationDate"))
        vEnrolment.CreatedBy = (dt.Rows(0)("CreatedBy"))
        vEnrolment.ModifiedDate = (dt.Rows(0)("ModifiedDate"))
        vEnrolment.ModifiedBy = (dt.Rows(0)("ModifiedBy"))
    End Sub


    Public Function EnrolmentExistByStudentID(ByVal sStudentID As String, ByVal TermID As Integer) As TranDBResult
        Dim com As New MySqlCommand("SELECT * From tblEnrolment WHERE tblEnrolment.StudentID='" & sStudentID & "' AND TermID='" & TermID & "'", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            EnrolmentExistByStudentID = TranDBResult.Success
        Else
            EnrolmentExistByStudentID = TranDBResult.Failed
        End If
        'release
        vRS.Close()
    End Function

    Public Function EnrolmentExistByStudentIDBySchoolYear(ByVal sStudentID As String, ByVal sSchoolYear As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT tblEnrolment.StudentID, tblEnrolment.SchoolYear From tblEnrolment WHERE (((tblEnrolment.StudentID)='" & sStudentID & "') AND ((tblEnrolment.SchoolYear)='" & sSchoolYear & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()

        vRS.Read()
        If vRS.HasRows = True Then
            EnrolmentExistByStudentIDBySchoolYear = TranDBResult.Success
        Else
            EnrolmentExistByStudentIDBySchoolYear = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function EnrolmentExistBySectionID(ByVal sSectionID As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * From tblEnrolment WHERE (((tblEnrolment.SectionOfferingID)='" & sSectionID & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()

        vRS.Read()
        If vRS.HasRows = True Then
            EnrolmentExistBySectionID = TranDBResult.Success
        Else
            EnrolmentExistBySectionID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function EnrolmentExistByID(ByVal sEnrolmentID As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * From tblEnrolment WHERE tblEnrolment.EnrolmentID='" & sEnrolmentID & "'", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            EnrolmentExistByID = TranDBResult.Success
        Else
            EnrolmentExistByID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function TempEnrolledSubjectExist(ByVal EnrolmentID As String, ByVal SubjectID As String) As String
        Dim com As New MySqlCommand("  SELECT CS.SubjectID FROM tblClassSchedule CS WHERE CS.SubjectOfferingID IN " & _
                                    "(SELECT ScheduleID FROM tblEnrolmentDetails_Temp WHERE EnrollmentID='" & EnrolmentID & "') AND CS.SubjectID='" & SubjectID & "';", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            TempEnrolledSubjectExist = vRS(0).ToString()
        Else
            TempEnrolledSubjectExist = ""
        End If
        vRS.Close()
    End Function

    Public Function TempEnrolmentExistByID(ByVal sEnrolmentID As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * From tblEnrolment_Temp WHERE EnrolmentID='" & sEnrolmentID & "'", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            TempEnrolmentExistByID = TranDBResult.Success
        Else
            TempEnrolmentExistByID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function EnrolmentTempExistByID(ByVal EnrolmentID As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblEnrolmentDetails_Temp WHERE EnrollmentID='" & EnrolmentID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows = True Then
            EnrolmentTempExistByID = TranDBResult.Success
        Else
            EnrolmentTempExistByID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function



    Public Function GetNewEnrolmentID(ByVal sSchoolYear As String, ByVal sStudentID As String, ByRef sNewEnrolmentID As String) As TranDBResult
        'set default
        GetNewEnrolmentID = TranDBResult.Failed

        If StudentExistByID(sStudentID) <> TranDBResult.Success Then
            GetNewEnrolmentID = TranDBResult.EnrolmentStudentIDNotFound
            Exit Function
        End If

        If EnrolmentExistByStudentIDBySchoolYear(sStudentID, sSchoolYear) = TranDBResult.Success Then
            GetNewEnrolmentID = TranDBResult.EnrolmentDuplicateEntryWithInYear
            Exit Function
        End If

        sNewEnrolmentID = Left(Trim(sSchoolYear), 4) & "-" & Trim(sStudentID)
        GetNewEnrolmentID = TranDBResult.Success
    End Function


    Public Function StudentEnroledBySchoolYear(ByVal sStudentID As String, ByVal TermID As Integer, ByRef IsEnroled As Boolean) As TranDBResult
        Dim sSQL As String

        IsEnroled = False

        sSQL = "SELECT tblEnrolment.TermID, tblStudent.StudentNo " & _
                "FROM tblStudent INNER JOIN tblEnrolment ON tblStudent.StudentNo = tblEnrolment.StudentID " & _
                "WHERE tblEnrolment.TermID='" & TermID & "' AND tblStudent.StudentNo='" & sStudentID & "' AND  tblEnrolment.ValidationDate IS NOT NULL " & _
                "GROUP BY tblEnrolment.TermID, tblStudent.StudentNo "

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            IsEnroled = True
            StudentEnroledBySchoolYear = TranDBResult.Success
        Else
            IsEnroled = False
            StudentEnroledBySchoolYear = TranDBResult.Failed
        End If

        vRS.Close()
    End Function

    Public Function GetAcademicRecord(ByVal sStudentID As String, ByVal iYearLevelID As Integer, ByRef dAveGrade As Double, ByRef bPassed As Boolean, ByRef sDepartmentID As String) As TranDBResult
        Dim sSQL As String


        'sSQL = "SELECT Avg(tblGrade.GradeValue) AS AvgOfGradeValue, IIf(Min([tblGrade].[GradeValue])<75 Or Avg([tblGrade].[GradeValue])<75,False,True) AS Passed" & _
        '        " FROM tblSection INNER JOIN (tblSectionOffering INNER JOIN (tblEnrolment INNER JOIN tblGrade ON tblEnrolment.EnrolmentID = tblGrade.EnrolmentID) ON tblSectionOffering.SectionOfferingID = tblEnrolment.SectionOfferingID) ON tblSection.SectionID = tblSectionOffering.SectionID" & _
        '        " WHERE (((tblSection.YearLevelID)=" & iYearLevelID & ") AND ((tblEnrolment.StudentID)='" & sStudentID & "'));"
        'WHERE (((tblSection.YearLevelID)=1) AND ((tblEnrolment.StudentID)='2006-0000068'));



        'sSQL = "SELECT (tblSection.DepartmentID) AS FirstOfDepartmentID, Avg(tblGrade.GradeValue) AS AvgOfGradeValue, If(Min(tblGrade.GradeValue)<75 Or Avg(tblGrade.GradeValue)<75,False,True) AS Passed" & _
        '        " FROM tblSection INNER JOIN (tblSectionOffering INNER JOIN (tblEnrolment INNER JOIN tblGrade ON tblEnrolment.EnrolmentID = tblGrade.EnrolmentID) ON tblSectionOffering.SectionOfferingID = tblEnrolment.SectionOfferingID) ON tblSection.SectionID = tblSectionOffering.SectionID" & _
        '        " WHERE (((tblSection.YearLevelID)=" & iYearLevelID & ") AND ((tblEnrolment.StudentID)='" & sStudentID & "'))" & _
        '        "GROUP BY tblSection.DepartmentID LIMIT 1;"

        'Dim com As New MySqlCommand(sSQL, clsCon.con)
        'Dim vRS As MySqlDataReader = com.ExecuteReader()

        'vRS.Read()
        'If vRS.HasRows = True Then
        '    dAveGrade = (vRS("AvgOfGradeValue").ToString())
        '    bPassed = (vRS("Passed").ToString())

        '    sDepartmentID = (vRS("FirstOfDepartmentID").ToString())
        '    GetAcademicRecord = TranDBResult.Success
        'Else
        '    dAveGrade = 0
        '    GetAcademicRecord = TranDBResult.Success
        'End If
        'vRS.Close()

        'sSQL = "SELECT tblGrade.GradeValue" & _
        '      " FROM tblSection INNER JOIN ((tblSectionOffering INNER JOIN tblEnrolment ON tblSectionOffering.SectionOfferingID = tblEnrolment.SectionOfferingID) INNER JOIN tblGrade ON tblEnrolment.EnrolmentID = tblGrade.EnrolmentID) ON tblSection.SectionID = tblSectionOffering.SectionID" & _
        '      " Where (((tblSection.YearLevelID) = " & iYearLevelID & ") And ((tblEnrolment.StudentID) = '" & sStudentID & "'))" & _
        '      " GROUP BY tblGrade.GradeValue;"

        'Dim com1 As New MySqlCommand(sSQL, clsCon.con)
        'Dim dr As MySqlDataReader = com1.ExecuteReader()
        'dr.Read()
        'If dr.HasRows = True Then
        'Else
        'End If
        'dr.Close()
    End Function

    Public Function GetTotalUnitsByCurriculum(ByVal CurriculumID As String) As Integer
        On Error GoTo err
        Dim com As New MySqlCommand("SELECT SUM(fnSubjectLectUnits(SubjectID)) FROM tblCurriculumDetails WHERE CurriculumID ='" & CurriculumID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            GetTotalUnitsByCurriculum = (vRS(0).ToString())
        End If
        vRS.Close()

        Exit Function

err:
        vRS.Close()
        GetTotalUnitsByCurriculum = 0
    End Function

    Public Function GetRequiredUnitsByCurriculum(ByVal CurriculumID As String, ByVal YearTermID As Integer) As Integer
        On Error GoTo err
        Dim com As New MySqlCommand("SELECT SUM(fnSubjectLectUnits(SubjectID)) FROM tblCurriculumDetails WHERE CurriculumID='" & CurriculumID & "' AND YearTermID='" & YearTermID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            GetRequiredUnitsByCurriculum = vRS(0).ToString()
        End If
        vRS.Close()

        Exit Function
err:
        vRS.Close()
        GetRequiredUnitsByCurriculum = 0
    End Function


    Public Function GetTotalEnrolledBySection(ByVal sSectionID As String, sTermID As Integer) As Integer
        Dim com As New MySqlCommand("SELECT fnGetTotalEnrolledBySection('" & sSectionID & "','" & sTermID & "')", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            If Not IsDBNull(vRS(0).ToString()) Then
                GetTotalEnrolledBySection = vRS(0).ToString()
            Else
                GetTotalEnrolledBySection = 0
            End If
        Else
            GetTotalEnrolledBySection = 0
        End If
        vRS.Close()
    End Function

    Public Function EnrollmentCurriculumProgram(ByVal CurriculumID As String) As String
        Dim com As New MySqlCommand("SELECT fnCurriculumDesc('" & CurriculumID & "')", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            EnrollmentCurriculumProgram = vRS(0).ToString()
        Else
            EnrollmentCurriculumProgram = ""
        End If
        vRS.Close()
    End Function

    Public Function GetSubjectMaxLimit(ByVal sSubjectOfferingID As String) As Integer
        Dim com As New MySqlCommand("SELECT MaxSize FROM tblSubject WHERE SubjectID IN (SELECT SubjectID FROM tblClassSchedule WHERE SubjectOfferingID='" & sSubjectOfferingID & "')", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            If (vRS(0).ToString() <> "") Then
                GetSubjectMaxLimit = vRS(0).ToString()
            Else
                GetSubjectMaxLimit = 0
            End If
        Else
            GetSubjectMaxLimit = 0
        End If
        vRS.Close()
    End Function


    Public Function CheckSubjectOfferingByCurriculum(ByVal SubjectID As String, CurriculumID As String) As Boolean
        Dim com As New MySqlCommand("SELECT * FROM tblCurriculumDetails WHERE SubjectID='" & SubjectID & "' AND CurriculumID='" & CurriculumID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows = True Then
            CheckSubjectOfferingByCurriculum = True
        Else
            CheckSubjectOfferingByCurriculum = False
        End If
        vRS.Close()
    End Function

    Public Function GetTotalEnrolledLabUnits(ByVal EnrollmentID As String) As Decimal
        Dim com As New MySqlCommand("SELECT fnGetTotalLabUnits('" & EnrollmentID & "')", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            GetTotalEnrolledLabUnits = vRS(0).ToString()
        Else
            GetTotalEnrolledLabUnits = 0
        End If
        vRS.Close()
    End Function

    Public Function GetTotalEnrolledLabHrs(ByVal EnrollmentID As String) As Decimal
        Dim com As New MySqlCommand("SELECT fnGetTotalLabHrs('" & EnrollmentID & "')", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            GetTotalEnrolledLabHrs = vRS(0).ToString()
        Else
            GetTotalEnrolledLabHrs = 0
        End If
        vRS.Close()
    End Function

    Public Function GetTotalTempEnrolledLabHrs(ByVal EnrollmentID As String) As Decimal
        Dim com As New MySqlCommand("SELECT fnGetTotalTempLabHrs('" & EnrollmentID & "')", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            GetTotalTempEnrolledLabHrs = vRS(0).ToString()
        Else
            GetTotalTempEnrolledLabHrs = 0
        End If
        vRS.Close()
    End Function

    Public Function GetTotalTempEnrolledLabUnits(ByVal EnrollmentID As String) As Decimal
        Dim com As New MySqlCommand("SELECT fnGetTotalTempLabUnits('" & EnrollmentID & "')", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            GetTotalTempEnrolledLabUnits = vRS(0).ToString()
        Else
            GetTotalTempEnrolledLabUnits = 0
        End If
        vRS.Close()
    End Function

    Public Function GetTotalEnrolledLecUnits(ByVal EnrollmentID As String) As Decimal
        Dim com As New MySqlCommand("SELECT fnTotalEnrolledLecUnits('" & EnrollmentID & "')", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            GetTotalEnrolledLecUnits = vRS(0).ToString()
        Else
            GetTotalEnrolledLecUnits = 0
        End If
        vRS.Close()
    End Function

    Public Function GetTotalTempEnrolledLecUnits(ByVal EnrollmentID As String) As Decimal
        Dim com As New MySqlCommand("SELECT fnTotalTempEnrolledLecUnits('" & EnrollmentID & "')", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            GetTotalTempEnrolledLecUnits = vRS(0).ToString()
        Else
            GetTotalTempEnrolledLecUnits = 0
        End If
        vRS.Close()
    End Function

    Public Function GetTotalEnrolledCreditUnits(ByVal EnrollmentID As String) As Decimal
        Dim com As New MySqlCommand("SELECT fnGetTotalCreditUnitsEnrolled('" & EnrollmentID & "')", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            GetTotalEnrolledCreditUnits = vRS(0).ToString()
        Else
            GetTotalEnrolledCreditUnits = 0
        End If
        vRS.Close()
    End Function


    Public Function getTotalSubjectEnrolled(ByVal EnrollmentID As String) As Integer
        Dim com As New MySqlCommand("SELECT fnGetTotalSubjectEnrolled('" & EnrollmentID & "')", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            getTotalSubjectEnrolled = vRS(0).ToString()
        Else
            getTotalSubjectEnrolled = 0
        End If
        vRS.Close()
    End Function

    Public Function getTotalTempSubjectEnrolled(ByVal EnrollmentID As String) As Integer
        Dim com As New MySqlCommand("SELECT fnGetTotalTempSubjectEnrolled('" & EnrollmentID & "')", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            getTotalTempSubjectEnrolled = vRS(0).ToString()
        Else
            getTotalTempSubjectEnrolled = 0
        End If
        vRS.Close()
    End Function


End Module
