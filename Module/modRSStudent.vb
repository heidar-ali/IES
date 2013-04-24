Option Explicit On
Imports MySql.Data.MySqlClient

Module modRSStudent
    Public Structure tStudent
        Dim StudentNo As String
        Dim CodeCHED As String
        Dim CampusID As Integer
        Dim ProgID As Integer
        Dim MajorDiscID As Integer
        Dim YearLevelID As Integer
        Dim TermID As Integer
        Dim CurriculumID As String
        Dim MaxLoadUnits As Integer
        Dim TblFeeID As Integer

        Dim DateAdmitted As Date

        Dim FirstName As String
        Dim MiddleName As String
        Dim MiddleInitial As String
        Dim LastName As String
        Dim ExtName As String

        Dim IsIllegitemate As Short
        Dim InActive As Short
        Dim StatusID As Short

        Dim BirthDate As String
        Dim PlaceOfBirth As String
        Dim Gender As String
        Dim CivilStatusID As String
        Dim ReligionID As Integer
        Dim NationalityID As Integer
        Dim TelNo As String
        Dim MobileNo As String
        Dim FaxNo As String
        Dim Email As String
        Dim Height As Double
        Dim Weight As String
        Dim BloodType As String

        'parents
        Dim MotherName As String
        Dim MotherOccupation As String
        Dim MotherCompany As String
        Dim MotherCompanyAddress As String
        Dim MotherTelNo As String
        Dim MotherEmail As String
        Dim MotherBirthDate As Date

        Dim FatherName As String
        Dim FatherOccupation As String
        Dim FatherCompany As String
        Dim FatherCompanyAddress As String
        Dim FatherTelNo As String
        Dim FatherEmail As String
        Dim FatherBirthDate As Date

        Dim ResAddress As String
        Dim ResStreet As String
        Dim ResBarangay As String
        Dim ResTown As String
        Dim ResZipCode As String
        Dim ResProvince As String

        Dim PermAddress As String
        Dim PermStreet As String
        Dim PermBarangay As String
        Dim PermTown As String
        Dim PermZipCode As String
        Dim PermProvince As String

        Dim Guardian As String
        Dim GuardianAddress As String
        Dim GuardianRelationship As String
        Dim GuardianStreet As String
        Dim GuardianBarangay As String
        Dim GuardianTown As String
        Dim GuardianProvince As String
        Dim GuardianZipCode As String
        Dim GuardianOccupation As String
        Dim GuardianCompany As String
        Dim GuardianTelNo As String
        Dim GuardianEmail As String

        Dim EmergencyContact As String
        Dim EmergencyAddress As String
        Dim EmergencyTelNo As String
        Dim EmergencyMobileNo As String

        Dim ElemSchool As String
        Dim ElemAddress As String
        Dim ElemInclDate As Date

        Dim HSSchool As String
        Dim HSAddress As String
        Dim HSInclDate As Date

        Dim Vocational As String
        Dim VocaitonalAddress As String
        Dim VocationalDegree As String
        Dim VocationInclDate As Date

        Dim CollegeSchool As String
        Dim CollegeAddress As String
        Dim CollegeDegree As String
        Dim CollegeInclDate As Date

        Dim GSSchool As String
        Dim GSAddress As String
        Dim GSDegree As String
        Dim GSInclDate As Date

        'Dim StudentPic As Image

        Dim CreationDate As Date
        Dim CreatedBy As String
        Dim ModifiedDate As Date
        Dim ModifiedBy As String

        Dim Password As String



    End Structure


    Public Function GetNewStudentNo() As String
        Dim sYear As String
        Dim sStudentNumber As String
        Dim sLastStudentNumber As String
        Dim sStudentNo As String

        Dim sUserName As String

        Dim com As New MySqlCommand("SELECT CONCAT(Year(Now()),'-', (CONCAT(Left('00000000',7-Length(Max(Right(tblStudent.StudentNo,7))+1)),'',(Max(Right(tblStudent.StudentNo,7))+1)))) AS maxId FROM tblStudent;", clsCon.con)
        Dim QRYStudentNewID As MySqlDataReader = com.ExecuteReader()
        QRYStudentNewID.Read()
        If QRYStudentNewID.HasRows = True Then
            sStudentNo = QRYStudentNewID(0).ToString()
            If Len(sStudentNo) < 1 Then
                sYear = CStr(Year(Now))
                sStudentNo = Left(sYear, 4) & "-0000001"
            End If
        Else
            'set year
            sYear = CStr(Year(Now))

            sStudentNo = Left(sYear, 4) & "-0000001"
        End If
        QRYStudentNewID.Close()


        GetNewStudentNo = sStudentNo
    End Function

    Public Function DeleteUserStudentNo(ByVal sUserName As String) As Boolean
        Dim sSQL As String

        'default
        DeleteUserStudentNo = False
        '
        sSQL = "DELETE" & _
                " From tftStudentNo" & _
                " WHERE tftStudentNo.UserName='" & sUserName & "'"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = False Then
            CatchError("modRSStudent", "DeleteUserStudentNo", "Unable to connect Recordset with SQL Expression '" & sSQL & "'")
            GoTo ReleaseAndExit
        End If

        DeleteUserStudentNo = True
        vRS.Close()

ReleaseAndExit:
        vRS.Close()
    End Function

    Private Function SaveUserStudentNo(ByVal sUserName As String, ByVal sStudentNo As String) As Boolean
        Dim sSQL As String

        'default
        SaveUserStudentNo = False
        '
        sSQL = "SELECT tftStudentNo.UserName, tftStudentNo.StudentNo" & _
                " From tftStudentNo" & _
                " WHERE tftStudentNo.UserName='" & sUserName & "'"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()

        If vRS.HasRows = False Then
            CatchError("modRSStudent", "SaveUserStudentNo", "Unable to connect Recordset with SQL Expression '" & sSQL & "'")
            GoTo ReleaseAndExit
        End If
        vRS.Close()
        On Error GoTo ReleaseAndExit

        com.CommandText = "INSERT INTO tftStudentNo(UserName,StudentNo) VALUES (@UserName,@StudentNo)"
        com.Connection = clsCon.con
        com.Parameters.Add("@UserName", MySqlDbType.VarChar, 45).Value = sUserName
        com.Parameters.Add("@StudentNo", MySqlDbType.VarChar, 45).Value = sStudentNo
        com.ExecuteNonQuery()
        com.Parameters.Clear()
        'return true
        SaveUserStudentNo = True


ReleaseAndExit:
        vRS.Close()
    End Function

    Public Function StudentNoNotExistFromOther(ByVal sStudentNo As String, Optional ByRef sUserName As String = "") As Boolean
        Dim sSQL As String

        StudentNoNotExistFromOther = False

        sSQL = "SELECT tftStudentNo.UserName" & _
                " From tftStudentNo" & _
                " WHERE (((tftStudentNo.StudentNo)='" & sStudentNo & "'))"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = False Then
            CatchError("modRSStudent", "StudentNoNotExistFromOther", "Unable to connect Recordset with SQL Expression '" & sSQL & "'")
            GoTo ReleaseAndExit
        End If

        'On Error Resume Next
        If vRS.HasRows = True Then
            sUserName = (vRS("UserName").ToString())
            'return true
            StudentNoNotExistFromOther = True
        Else
            'not found
            StudentNoNotExistFromOther = False
        End If
        vRS.Close()

ReleaseAndExit:
        vRS.Close()
    End Function
    Public Function EditStudent(ByVal vStudent As tStudent) As TranDBResult
        Dim OldStudent As tStudent
        Dim NewFullName As String
        Dim OldFullName As String

        'check if user exist
        If GetStudentByID(vStudent.StudentNo, OldStudent) = TranDBResult.Success Then

            'get old full name
            OldFullName = LCase(Trim(OldStudent.FirstName) + Trim(OldStudent.MiddleName) + Trim(OldStudent.LastName))

            'get new full name
            NewFullName = LCase(Trim(vStudent.FirstName) + Trim(vStudent.MiddleName) + Trim(vStudent.LastName))

            'compare
            If OldFullName <> NewFullName Then

                NewFullName = LCase(Trim(vStudent.FirstName) & Trim(vStudent.MiddleName) & Trim(vStudent.LastName))

                If FindDuplicateFullName(NewFullName) = TranDBResult.Success Then
                    'found duplicate
                    EditStudent = TranDBResult.DuplicateFullName
                    GoTo ReleaseAndExit
                End If
            End If
        Else
            'id not found
            EditStudent = TranDBResult.Failed
            GoTo ReleaseAndExit
        End If



        'validated
        'update
        Dim com As New MySqlCommand("SELECT * From tblStudent WHERE (((tblStudent.StudentNo)='" & vStudent.StudentNo & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then

            If UpdateToRecord(vStudent) = TranDBResult.Success Then
                'success
                'added
                EditStudent = TranDBResult.Success

            Else
                'write to record failed
                EditStudent = TranDBResult.Failed
                vRS.Close()
                GoTo ReleaseAndExit
            End If

        Else
            'no record existed
            EditStudent = TranDBResult.Failed
            vRS.Close()
            GoTo ReleaseAndExit
        End If
        vRS.Close()
ReleaseAndExit:
        Exit Function
    End Function
    Public Function AddStudent(ByVal newStudent As tStudent) As TranDBResult
        Dim sFullname As String


        'default
        AddStudent = TranDBResult.Failed

        'check Duplicate ID
        If StudentExistByID(newStudent.StudentNo) = TranDBResult.Success Then
            AddStudent = TranDBResult.DuplicateID
            GoTo ReleaseAndExit
        End If


        If WriteToRecord(newStudent) = TranDBResult.Success Then
            AddStudent = TranDBResult.Success
        Else
            AddStudent = TranDBResult.Failed
        End If

ReleaseAndExit:

    End Function
    Public Function StudentExistByID(ByVal sStudentNo As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblStudent WHERE StudentNo='" & sStudentNo & "'", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            StudentExistByID = TranDBResult.Success
        Else
            StudentExistByID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function GetStudentByID(ByVal sStudentNo As String, ByRef vStudent As tStudent) As TranDBResult

        Dim com As New MySqlCommand("SELECT * From tblStudent WHERE (((tblStudent.StudentNo)='" & sStudentNo & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If Not vRS.HasRows Then
            GetStudentByID = TranDBResult.Failed
        Else
            GetStudentByID = TranDBResult.Success
        End If
        vRS.Close()
        ReadFromRecord(sStudentNo, vStudent)
    End Function

    Public Function GetStudentAcadStatus(ByVal StudentNo As String) As String
        Dim com As New MySqlCommand("SELECT fnStudentStatus(StatusID) AS Status FROM tblStudent WHERE StudentNo='" & StudentNo & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            GetStudentAcadStatus = vRS(0).ToString()
        Else
            GetStudentAcadStatus = ""
        End If
        vRS.Close()
    End Function

    Public Function GetStudentFullNameByID(ByVal sStudentNo As String, ByRef sFullName As String) As TranDBResult

        Dim com As New MySqlCommand("SELECT * From tblStudent WHERE (((tblStudent.StudentNo)='" & sStudentNo & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then

            sFullName = vRS("LastName").ToString() & ", " & vRS("FirstName").ToString() & " " & vRS("MiddleInitial") & "."

            GetStudentFullNameByID = TranDBResult.Success
        Else
            GetStudentFullNameByID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function GetStudentAcadProgram(ByVal StudentID As String) As String
        Dim com As New MySqlCommand("SELECT fnProgramName(S.ProgID) FROM tblStudent AS S WHERE S.StudentNo ='" & StudentID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            GetStudentAcadProgram = vRS(0).ToString()
        Else
            GetStudentAcadProgram = ""
        End If
        vRS.Close()
    End Function

    Public Function GetStudentAcadProgramMajor(ByVal StudentID As String) As String
        Dim com As New MySqlCommand("SELECT fnMajorName(MajorDiscID) FROM tblStudent WHERE StudentNo='" & StudentID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            GetStudentAcadProgramMajor = vRS(0).ToString()
        Else
            GetStudentAcadProgramMajor = ""
        End If
        vRS.Close()
    End Function

    Public Function GetStudentAcadProgramMajorByTerm(ByVal StudentID As String, ByVal TermID As Integer) As String
        Dim com As New MySqlCommand("SELECT fMajorName(MajorID) FROM tblEnrolment WHERE StudentNo='" & StudentID & "' AND TermID='" & TermID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            GetStudentAcadProgramMajorByTerm = vRS(0).ToString()
        Else
            GetStudentAcadProgramMajorByTerm = ""
        End If
        vRS.Close()
    End Function

    Public Function GetStudentAcadProgramByTerm(ByVal StudentID As String, ByVal TermID As Integer) As String
        Dim com As New MySqlCommand("SELECT fnProgramName(S.ProgID) FROM tblEnrolment AS S WHERE S.StudentID='" & StudentID & "' AND S.TermID='" & TermID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            GetStudentAcadProgramByTerm = vRS(0).ToString()
        Else
            GetStudentAcadProgramByTerm = ""
        End If
        vRS.Close()
    End Function

    Public Function GetStudentCurriculum(ByVal StudentID As String) As String
        Dim com As New MySqlCommand("SELECT Description FROM tblCurriculum WHERE CurriculumID IN (SELECT CurriculumID FROM tblStudent WHERE StudentNo='" & StudentID & "')", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            GetStudentCurriculum = vRS(0).ToString()
        Else
            GetStudentCurriculum = ""
        End If
        vRS.Close()
    End Function

    Public Function GetStudentCurriculumByTerm(ByVal StudentID As String, ByVal TermID As Integer) As String
        Dim com As New MySqlCommand("SELECT fnCurriculumDesc(CurriculumID) FROM tblEnrolment WHERE StudentNo='" & StudentID & "' AND TermID='" & TermID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            GetStudentCurriculumByTerm = vRS(0).ToString()
        Else
            GetStudentCurriculumByTerm = ""
        End If
        vRS.Close()
    End Function

    Public Function GetStudentYearLevel(ByVal StudentID As String) As String
        Dim com As New MySqlCommand("SELECT fnYearLevel2(S.YearLevelID, fnProgramClassCode(S.ProgID)) FROM tblStudent AS S WHERE S.StudentNo='" & StudentID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            GetStudentYearLevel = vRS(0).ToString()
        Else
            GetStudentYearLevel = 0
        End If
        vRS.Close()
    End Function

    Public Function GetStudentYearLevelByTerm(ByVal StudentID As String, ByVal TermID As Integer) As Integer
        Dim com As New MySqlCommand("SELECT fnYearLevel2(S.YearLevelID, fnProgramClassCode(S.ProgID)) FROM tblStudents AS S WHERE S.StudentNo='" & StudentID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            GetStudentYearLevelByTerm = vRS(0).ToString()
        Else
            GetStudentYearLevelByTerm = 0
        End If
        vRS.Close()
    End Function
    Public Function GetStudentScholarhipProvider(ByVal StudentID As String) As String
        Dim com As New MySqlCommand("SELECT fnScholarProviderName(SchoProviderID) FROM tblEnrolment WHERE StudentID='" & StudentID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            GetStudentScholarhipProvider = vRS(0).ToString()
        Else
            GetStudentScholarhipProvider = ""
        End If
        vRS.Close()
    End Function

    Public Function CompleteName(ByVal vStudent As tStudent) As String
        CompleteName = cSentenceCase(vStudent.LastName & ", " & vStudent.FirstName & " " & Left(vStudent.MiddleName, 1))
    End Function

    Public Function GetStudentCollege(ByVal StudentID As String) As String
        Dim com As New MySqlCommand("SELECT fnCollegeCode(CollegeID) FROM tblPrograms WHERE ProgID = (SELECT ProgID FROM tblStudent WHERE StudentNo='" & StudentID & "')", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            GetStudentCollege = vRS(0).ToString()
        Else
            GetStudentCollege = ""
        End If
        vRS.Close()
    End Function

    Public Function GetStudentCollegeID(ByVal StudentID As String) As String
        Dim com As New MySqlCommand("SELECT CollegeID FROM tblPrograms WHERE ProgID = (SELECT ProgID FROM tblStudent WHERE StudentNo='" & StudentID & "')", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            GetStudentCollegeID = vRS(0).ToString()
        Else
            GetStudentCollegeID = ""
        End If
        vRS.Close()
    End Function

    Public Function GetStudentCollegeByTerm(ByVal StudentID As String, ByVal TermID As String) As String
        Dim com As New MySqlCommand("SELECT fnCollegeName(CollegeID) FROM tblEnrolment WHERE StudentNo='" & StudentID & "' AND TermID ='" & TermID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            GetStudentCollegeByTerm = vRS(0).ToString()
        Else
            GetStudentCollegeByTerm = ""
        End If
        vRS.Close()
    End Function

    Public Function GetStudentFeeTemplate(ByVal StudentID As String, ByRef TemplateID As String) As String
        Dim com As New MySqlCommand("SELECT fnFeeTemplateCode(TblFeesID),tblFeesID FROM tblStudent WHERE StudentNo='" & StudentID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            GetStudentFeeTemplate = vRS(0).ToString()
            TemplateID = vRS(1).ToString()
        Else
            GetStudentFeeTemplate = ""
            TemplateID = ""
        End If
        vRS.Close()
    End Function

    Public Function GetStudentFeeTemplateByTerm(ByVal StudentID As String, TermID As Integer) As String
        Dim com As New MySqlCommand("SELECT fnStudentFeeTemplateCode(FeeTemplateID) FROM tblEnrolment WHERE StudentID='" & StudentID & "' AND TermID='" & TermID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            GetStudentFeeTemplateByTerm = vRS(0).ToString()
        Else
            GetStudentFeeTemplateByTerm = ""
        End If
        vRS.Close()
    End Function

    Public Function CompleteGender(ByVal sCode As String) As String
        Select Case LCase(sCode)
            Case "m"
                CompleteGender = "Male"
            Case "f"
                CompleteGender = "Female"
        End Select
    End Function

    Public Function CompleteStatus(ByVal sCode As String) As String
        Select Case Left(LCase(sCode), 2)
            Case "si"
                CompleteStatus = "Single"
            Case "ma"
                CompleteStatus = "Maried"
            Case "wi"
                CompleteStatus = "Widowed"
            Case "se"
                CompleteStatus = "separated"
            Case Else
                CompleteStatus = "!Invalid Entry"
        End Select
    End Function
    Public Function GetEnrolmentCountByStudent(ByVal sStudentNo As String, ByRef lEnrolmentCount As Integer) As TranDBResult
        Dim sSQL As String

        '------------------------------------------

        'default
        GetEnrolmentCountByStudent = TranDBResult.Failed

        sSQL = "SELECT Count(tblEnrolment.EnrolmentID) AS EnrolmentCount" & _
                " FROM ((tblYearLevel INNER JOIN tblSection ON tblYearLevel.YearLevelID = tblSection.YearLevelID) INNER JOIN tblSubject ON tblYearLevel.YearLevelID = tblSubject.YearLevelID) INNER JOIN (tblStudent INNER JOIN tblEnrolment ON tblStudent.StudentNo = tblEnrolment.StudentNo) ON tblSection.SectionID = tblEnrolment.SectionID" & _
                " WHERE (((tblStudent.StudentNo)='" & sStudentNo & "'));"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            lEnrolmentCount = vRS("EnrolmentCount").ToString()
            GetEnrolmentCountByStudent = TranDBResult.Success
        Else
            lEnrolmentCount = -1
            GetEnrolmentCountByStudent = TranDBResult.Failed
        End If

        vRS.Close()

    End Function
    Public Function DeleteStudent(ByVal sStudentNo As String, Optional ByVal ShowMessage As Boolean = True) As TranDBResult
        Dim lEnrolmentCount As Long
        DeleteStudent = TranDBResult.Failed

        'check
        If GetEnrolmentCountByStudent(sStudentNo, lEnrolmentCount) = TranDBResult.Success Then
            If lEnrolmentCount > 0 Then
                If ShowMessage = True Then
                    'temp
                    MsgBox("temp: show is already used", vbExclamation)
                End If

                DeleteStudent = TranDBResult.Failed
                Exit Function
            End If
        Else
            'Student entry not exist
            CatchError("frmAllStudent", "listRecord_DblClick", "GetEnrolmentCountByStudent(lvKey, lEnrolmentCount) = success")
        End If


        Dim com As New MySqlCommand("DELETE  From tblStudent WHERE (((tblStudent.StudentNo)='" & sStudentNo & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            DeleteStudent = TranDBResult.Success
        Else
            DeleteStudent = TranDBResult.Failed
        End If

        vRS.Close()
    End Function

    Public Function FindDuplicateFullName(ByVal sFullname As String) As TranDBResult
        Dim sSQL As String

        FindDuplicateFullName = TranDBResult.Failed

        sFullname = LCase(Trim(sFullname))
        sSQL = "SELECT tblStudent.StudentNo  From tblStudent " & _
                " WHERE (LCase(CONCAT(tblStudent.FirstName , tblStudent.MiddleName , tblStudent.LastName ))='" & sFullname & "');"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            FindDuplicateFullName = TranDBResult.Success
        Else
            FindDuplicateFullName = TranDBResult.Failed
        End If

        vRS.Close()
    End Function


    Private Function WriteToRecord(ByVal vStudent As tStudent) As TranDBResult
        On Error GoTo ReleaseAndExit
        'default

        WriteToRecord = TranDBResult.Failed
        Dim sSQL As String = "INSERT INTO `tblstudent`(`StudentNo`, " & _
      "`CampusID`,`ProgID`,`MajorDiscID`,`YearLevelID`,`TermID`,`CurriculumID`,`TblFeesID`,`DateAdmitted`, " & _
      "`LastName`,`Middlename`,`FirstName`,`MiddleInitial`,`ExtName`,`Gender`,`DateOfBirth`,`Inactive`, " & _
      "`StatusID`,`Password`,`IsLegitimateChild`,`MaxUnitsLoad`) VALUES ('" & vStudent.StudentNo & "','" & vStudent.CampusID & "','" & vStudent.ProgID & "','" & vStudent.MajorDiscID & "','" & _
      vStudent.YearLevelID & "','" & vStudent.TermID & "','" & vStudent.CurriculumID & "','" & vStudent.TblFeeID & "',@Admitted,'" & _
      vStudent.LastName & "','" & vStudent.MiddleName & "','" & vStudent.FirstName & "','" & vStudent.MiddleInitial & "','" & vStudent.ExtName & "','" & _
      vStudent.Gender & "','" & vStudent.BirthDate & "','" & vStudent.InActive & "','" & vStudent.CivilStatusID & "','" & vStudent.Password & "','" & vStudent.IsIllegitemate & "','" & vStudent.MaxLoadUnits & "')"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        com.Parameters.Add("@Admitted", MySqlDbType.Date).Value = vStudent.DateAdmitted
        com.ExecuteNonQuery()

        'return success
        WriteToRecord = TranDBResult.Success
        Exit Function

ReleaseAndExit:
        CatchError("modRSStudent", "WriteToRecord", "Unable to continue updating record with Error:" & Err.Description)
    End Function

    Private Function UpdateToRecord(ByVal vStudent As tStudent) As TranDBResult
        On Error GoTo ReleaseAndExit
        'default

        UpdateToRecord = TranDBResult.Failed

        Dim sSQL As String = "UPDATE"

        'Dim com As New MySqlCommand(sSQL, clsCon.con)
        'com.ExecuteNonQuery()

        'return success
        UpdateToRecord = TranDBResult.Success
        Exit Function

ReleaseAndExit:
        CatchError("modRSStudent", "UpdateToRecord", "Unable to continue updating record with Error:" & Err.Description)
    End Function
    Private Function ReadFromRecord(ByVal sStudentNo As String, ByRef vStudent As tStudent) As TranDBResult
        On Error Resume Next
        ReadFromRecord = TranDBResult.Failed
        Dim com As New MySqlCommand("SELECT * From tblStudent WHERE (((tblStudent.StudentNo)='" & sStudentNo & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            With vStudent

                'Student Information
                .StudentNo = (vRS("StudentNo").ToString())
                .FirstName = (vRS("FirstName").ToString())
                .MiddleName = (vRS("MiddleName").ToString())
                .LastName = (vRS("LastName").ToString())
                .Gender = vRS("Gender").ToString()
                .MiddleInitial = vRS("MiddleInitial").ToString()
                .ExtName = vRS("ExtName").ToString()
                .CodeCHED = vRS("CodeCHED").ToString()
                .PlaceOfBirth = vRS("PlaceOfBirth").ToString()
                .TelNo = vRS("TelNo").ToString()
                .MobileNo = vRS("MobileNo").ToString()
                .FaxNo = vRS("FaxNo").ToString()
                .Email = vRS("Email").ToString()
                .BirthDate = vRS("DateOfBirth").ToString()


                .MaxLoadUnits = vRS("MaxUnitsLoad").ToString()
                .CurriculumID = vRS("CurriculumID").ToString()
                .ProgID = vRS("ProgID").ToString()
                .YearLevelID = vRS("YearLevelID").ToString()
                .TblFeeID = vRS("TblFeesID").ToString()

                'Father
                .FatherName = vRS("Father").ToString()
                .FatherOccupation = vRS("Father_Occupation").ToString()
                .FatherCompany = vRS("Father_Company").ToString()
                .FatherCompanyAddress = vRS("Father_CompanyAddress").ToString()
                .FatherTelNo = vRS("Father_TelNo").ToString()
                .FatherEmail = vRS("Father_Email").ToString()
                .FatherBirthDate = vRS("Father_BirthDate").ToString()

                'Mother
                .MotherName = vRS("Mother").ToString()
                .MotherOccupation = vRS("Mother_Occupation").ToString()
                .MotherCompany = vRS("Mother_Company").ToString()
                .MotherCompanyAddress = vRS("Mother_CompanyAddress").ToString()
                .MotherEmail = vRS("Mother_Email").ToString()
                .MotherTelNo = vRS("Mother_TelNo").ToString()
                .MotherBirthDate = vRS("Mother_BirthDate").ToString()

                'Residence
                .ResAddress = vRS("Res_Address").ToString()
                .ResStreet = vRS("Res_Street").ToString()
                .ResBarangay = vRS("Res_Barangay").ToString()
                .ResTown = vRS("Res_TownCity").ToString()
                .ResProvince = vRS("Res_Province").ToString()

                'Permanent Address




                .CreationDate = (vRS("creationdate").ToString())
                .CreatedBy = vRS("CreatedBy").ToString()
            End With


            ReadFromRecord = TranDBResult.Success
        Else
            ReadFromRecord = TranDBResult.Failed
        End If
        vRS.Close()
    End Function


    Public Function CheckStudentAccountabilities(ByVal StudentNo As String, TermID As Integer) As TranDBResult
        Dim com As New MySqlCommand("SELECT fnStudentAccountabilities('" & StudentNo & "','" & TermID & "')", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            If (vRS(0).ToString()) <> "" Then
                CheckStudentAccountabilities = TranDBResult.Success
            Else
                CheckStudentAccountabilities = TranDBResult.Failed
            End If
        Else
            CheckStudentAccountabilities = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function getStudentAccountabilities(ByVal StudentNo As String, TermID As Integer, ByRef Reason As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT fnStudentAccountabilities('" & StudentNo & "','" & TermID & "')", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            Reason = vRS(0).ToString()
            getStudentAccountabilities = TranDBResult.Success
        Else
            Reason = ""
            getStudentAccountabilities = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function IsStudentWithdrawn(ByVal StudentNo As String, ByVal TermID As Integer) As Boolean
        Dim com As New MySqlCommand("SELECT fnStudentIsWithdrawal('" & TermID & "','" & StudentNo & "')", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            Select Case vRS(0).ToString()
                Case 1
                    IsStudentWithdrawn = True
                Case 0
                    IsStudentWithdrawn = False
            End Select
        End If
        vRS.Close()
    End Function

End Module
