Option Explicit On
Imports MySql.Data.MySqlClient
Module modDBGrade

    Public Const KeyGrade As String = "grad"

    Public Structure tGrade

        Dim GradeID As String
        Dim EnrolmentID As String
        Dim SubjectOfferingID As String
        Dim FirstGrading As Double
        Dim SecondGrading As Double
        Dim ThirdGrading As Double
        Dim FourthGrading As Double
        Dim GradeValue As Double

    End Structure


    Public Function AddGrade(ByVal newGrade As tGrade) As TranDBResult
 
        'check enrolment ID
        If EnrolmentExistByID(newGrade.EnrolmentID) <> TranDBResult.Success Then
            AddGrade = TranDBResult.InvalidGradeEnrolmentID
            GoTo ReleaseAndExit
        End If

        'check Subject ID
        If SubjectOfferingExistByID(newGrade.SubjectOfferingID) <> TranDBResult.Success Then
            AddGrade = TranDBResult.InvalidGradeSubjectID
            GoTo ReleaseAndExit
        End If

        If newGrade.FirstGrading < 0 Or newGrade.FirstGrading > 100 Then
            AddGrade = TranDBResult.InvalidGradeGradeValue
            GoTo ReleaseAndExit
        End If

        If newGrade.SecondGrading < 0 Or newGrade.SecondGrading > 100 Then
            AddGrade = TranDBResult.InvalidGradeGradeValue
            GoTo ReleaseAndExit
        End If

        If newGrade.ThirdGrading < 0 Or newGrade.ThirdGrading > 100 Then
            AddGrade = TranDBResult.InvalidGradeGradeValue
            GoTo ReleaseAndExit
        End If

        If newGrade.FourthGrading < 0 Or newGrade.FourthGrading > 100 Then
            AddGrade = TranDBResult.InvalidGradeGradeValue
            GoTo ReleaseAndExit
        End If

        If newGrade.GradeValue < 0 Or newGrade.GradeValue > 100 Then
            AddGrade = TranDBResult.InvalidGradeGradeValue
            GoTo ReleaseAndExit
        End If


        Dim com As New MySqlCommand("INSERT INTO tblGrade(GradeID,EnrolmentID,SubjectOfferingID,FirstGrading,SecondGrading,ThirdGrading,FourthGrading,GradeValue) VALUES " & _
                               "('" & Trim(newGrade.EnrolmentID) & "-" & Trim(newGrade.SubjectOfferingID) & _
                               "','" & Trim(newGrade.EnrolmentID) & _
                               "','" & Trim(newGrade.SubjectOfferingID) & _
                               "','" & FormatNumber(newGrade.FirstGrading, 2) & _
                               "','" & FormatNumber(newGrade.SecondGrading, 2) & _
                               "','" & FormatNumber(newGrade.ThirdGrading, 2) & _
                               "','" & FormatNumber(newGrade.FourthGrading, 2) & _
                               "','" & FormatNumber(newGrade.GradeValue, 2) & "')", clsCon.con)
        com.ExecuteNonQuery()

        AddGrade = TranDBResult.Success



ReleaseAndExit:
        Exit Function
    End Function

    Public Function AddTempGrade(ByVal newGrade As tGrade) As TranDBResult


        'check Subject ID
        If SubjectOfferingExistByID(newGrade.SubjectOfferingID) <> TranDBResult.Success Then
            AddTempGrade = TranDBResult.InvalidGradeSubjectID
            GoTo ReleaseAndExit
        End If

        If TempGradeExistByID(newGrade.EnrolmentID, newGrade.SubjectOfferingID) <> TranDBResult.Success Then
            AddTempGrade = TranDBResult.Failed
            GoTo ReleaseAndExit
        End If


        If newGrade.FirstGrading < 0 Or newGrade.FirstGrading > 100 Then
            AddTempGrade = TranDBResult.InvalidGradeGradeValue
            GoTo ReleaseAndExit
        End If

        If newGrade.SecondGrading < 0 Or newGrade.SecondGrading > 100 Then
            AddTempGrade = TranDBResult.InvalidGradeGradeValue
            GoTo ReleaseAndExit
        End If

        If newGrade.ThirdGrading < 0 Or newGrade.ThirdGrading > 100 Then
            AddTempGrade = TranDBResult.InvalidGradeGradeValue
            GoTo ReleaseAndExit
        End If

        If newGrade.FourthGrading < 0 Or newGrade.FourthGrading > 100 Then
            AddTempGrade = TranDBResult.InvalidGradeGradeValue
            GoTo ReleaseAndExit
        End If

        If newGrade.GradeValue < 0 Or newGrade.GradeValue > 100 Then
            AddTempGrade = TranDBResult.InvalidGradeGradeValue
            GoTo ReleaseAndExit
        End If


        Dim com As New MySqlCommand("INSERT INTO tblTempGrade(GradeID,EnrolmentID,SubjectOfferingID,FirstGrading,SecondGrading,ThirdGrading,FourthGrading,GradeValue) VALUES " & _
                               "('" & Trim(newGrade.EnrolmentID) & "-" & Trim(newGrade.SubjectOfferingID) & _
                               "','" & Trim(newGrade.EnrolmentID) & _
                               "','" & Trim(newGrade.SubjectOfferingID) & _
                               "','" & FormatNumber(newGrade.FirstGrading, 2) & _
                               "','" & FormatNumber(newGrade.SecondGrading, 2) & _
                               "','" & FormatNumber(newGrade.ThirdGrading, 2) & _
                               "','" & FormatNumber(newGrade.FourthGrading, 2) & _
                               "','" & FormatNumber(newGrade.GradeValue, 2) & "')", clsCon.con)
        com.ExecuteNonQuery()

        AddTempGrade = TranDBResult.Success


ReleaseAndExit:
        Exit Function
    End Function

    Public Function UpdateGrade(ByVal newGrade As tGrade) As TranDBResult

        Dim sSQL As String


        'check enrolment ID
        If EnrolmentExistByID(newGrade.EnrolmentID) <> TranDBResult.Success Then
            UpdateGrade = TranDBResult.InvalidGradeEnrolmentID
            GoTo ReleaseAndExit
        End If

        'check Subject ID
        If SubjectExistByID(newGrade.SubjectOfferingID) <> TranDBResult.Success Then
            UpdateGrade = TranDBResult.InvalidGradeSubjectID
            GoTo ReleaseAndExit
        End If

        If newGrade.FirstGrading < 0 Or newGrade.FirstGrading > 100 Then
            UpdateGrade = TranDBResult.InvalidGradeGradeValue
            GoTo ReleaseAndExit
        End If

        If newGrade.SecondGrading < 0 Or newGrade.SecondGrading > 100 Then
            UpdateGrade = TranDBResult.InvalidGradeGradeValue
            GoTo ReleaseAndExit
        End If

        If newGrade.ThirdGrading < 0 Or newGrade.ThirdGrading > 100 Then
            UpdateGrade = TranDBResult.InvalidGradeGradeValue
            GoTo ReleaseAndExit
        End If

        If newGrade.FourthGrading < 0 Or newGrade.FourthGrading > 100 Then
            UpdateGrade = TranDBResult.InvalidGradeGradeValue
            GoTo ReleaseAndExit
        End If

        If newGrade.GradeValue < 0 Or newGrade.GradeValue > 100 Then
            UpdateGrade = TranDBResult.InvalidGradeGradeValue
            GoTo ReleaseAndExit
        End If


        Try
            sSQL = "UPDATE tblGrade SET tblGrade.GradeID='" & Trim(newGrade.EnrolmentID) & "-" & Trim(newGrade.SubjectOfferingID) & _
                "',tblGrade.EnrolmentID='" & Trim(newGrade.EnrolmentID) & _
                "',tblGrade.SubjectOfferingID= '" & Trim(newGrade.SubjectOfferingID) & _
                "',tblGrade.FirstGrading = '" & CDbl(newGrade.FirstGrading) & _
                "',tblGrade.SecondGrading = '" & CDbl(newGrade.SecondGrading) & _
                "',tblGrade.ThirdGrading = '" & CDbl(newGrade.ThirdGrading) & _
                "',tblGrade.FourthGrading = '" & CDbl(newGrade.FourthGrading) & _
                "',tblGrade.GradeValue='" & CDbl(newGrade.GradeValue) & _
                " Where (((tblGrade.EnrolmentID) = '" & newGrade.EnrolmentID & "') And ((tblGrade.SubjectOfferingID) = '" & newGrade.SubjectOfferingID & "'))"

            Dim com As New MySqlCommand(sSQL, clsCon.con)
            com.ExecuteNonQuery()
            UpdateGrade = TranDBResult.Success
        Catch ex As Exception
            UpdateGrade = TranDBResult.Failed
        End Try

ReleaseAndExit:
        'release
        Exit Function
    End Function

    Public Function EditGrade(ByVal newGrade As tGrade) As TranDBResult

        Dim oldGrade As tGrade

        'get old Grade
        If GetGradeByID(newGrade.GradeID, oldGrade) <> TranDBResult.Success Then
            'department not found
            'exit function
            EditGrade = TranDBResult.InvalidID
            GoTo ReleaseAndExit
        End If


        'find record to edit
        Dim cmd As New MySqlCommand("SELECT * From tblGrade WHERE (((tblGrade.GradeID)='" & newGrade.GradeID & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = cmd.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = False Then
            EditGrade = TranDBResult.InvalidID
            GoTo ReleaseAndExit
        End If
        vRS.Close()

        Dim sSQL As String = "UPDATE tblGrade SET tblGrade.FirstGrading = '" & CDbl(newGrade.FirstGrading) & _
                 "',tblGrade.SecondGrading = '" & CDbl(newGrade.SecondGrading) & _
                 "',tblGrade.ThirdGrading = '" & CDbl(newGrade.ThirdGrading) & _
                 "',tblGrade.FourthGrading = '" & CDbl(newGrade.FourthGrading) & _
                 "',tblGrade.GradeValue='" & CDbl(newGrade.GradeValue) & _
                 " WHERE (((tblGrade.GradeID)='" & newGrade.GradeID & "'));"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        com.ExecuteNonQuery()

        EditGrade = TranDBResult.Success


ReleaseAndExit:
        Exit Function
    End Function


    Public Function DeleteGrade(ByVal sEnrolmentID As String) As TranDBResult
        Try
            Dim com As New MySqlCommand("Delete From tblGrade WHERE (((tblGrade.EnrolmentID)='" & sEnrolmentID & "'));", clsCon.con)
            com.ExecuteNonQuery()
            DeleteGrade = TranDBResult.Success
        Catch ex As Exception
            DeleteGrade = TranDBResult.Failed
        End Try

    End Function


    Public Function GetGradeByID(ByVal sGradeID As String, ByRef vGrade As tGrade) As TranDBResult


        Dim com As New MySqlCommand("SELECT *  FROM tblGrade WHERE (((tblGrade.GradeID)='" & sGradeID & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            vGrade.GradeID = vRS("GradeID").ToString()
            vGrade.EnrolmentID = vRS("EnrolmentID").ToString()
            vGrade.SubjectOfferingID = vRS("SubjectOfferingID").ToString()
            vGrade.FirstGrading = CDbl(vRS("FirstGrading").ToString())
            vGrade.SecondGrading = CDbl(vRS("SecondGrading").ToString())
            vGrade.ThirdGrading = CDbl(vRS("ThirdGrading").ToString())
            vGrade.FourthGrading = CDbl(vRS("FouthGrading").ToString())
            vGrade.GradeValue = CDbl(vRS("GradeValue").ToString())

            GetGradeByID = TranDBResult.Success
        Else
            GetGradeByID = TranDBResult.Failed
        End If

        'release
        vRS.Close()
    End Function


    Public Function GetGradeInfoByID(ByVal sGradeID As String, ByRef sSubjectTitle As String, ByRef dGradeValue As Double, ByRef sStudentname As String, ByRef sYearLevelTitle As String) As TranDBResult
        Dim sSQL As String

        sSQL = "SELECT tblGrade.GradeID, tblSubject.SubjectTitle, tblGrade.GradeValue, CONCAT(tblStudent.LastName,', ',tblStudent.FirstName,' ',tblStudent.MiddleName) AS StudentName, tblYearLevel.YearLevelTitle" & _
                " FROM tblYearLevel INNER JOIN (tblSubject INNER JOIN (tblStudent INNER JOIN (tblEnrolment INNER JOIN tblGrade ON tblEnrolment.EnrolmentID = tblGrade.EnrolmentID) ON tblStudent.StudentID = tblEnrolment.StudentID) ON tblSubject.SubjectID = tblGrade.SubjectOfferingID) ON tblYearLevel.YearLevelID = tblSubject.YearLevelID" & _
                " WHERE (((tblGrade.GradeID)='" & sGradeID & "'));"


        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then

            sSubjectTitle = vRS("SubjectTitle").ToString()
            dGradeValue = CDbl(vRS("GradeValue").ToString())
            sStudentname = (vRS("StudentName").ToString())
            sYearLevelTitle = (vRS("YearLevelTitle").ToString())

            GetGradeInfoByID = TranDBResult.Success
        Else
            GetGradeInfoByID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function


    Public Function GradeExistByID(ByVal sEnrolmentID As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * From tblGrade WHERE (((tblGrade.EnrolmentID)='" & sEnrolmentID & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            GradeExistByID = TranDBResult.Success
        Else
            GradeExistByID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function
    Public Function TempGradeExistByID(ByVal sEnrolmentID As String, ByVal sSubjectOfferingID As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * From tblTempGrade WHERE tblTempGrade.SubjectOfferingID='" & sSubjectOfferingID & "' AND tblTempGrade.EnrolmentID='" & sEnrolmentID & "'", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            TempGradeExistByID = TranDBResult.Failed
        Else
            TempGradeExistByID = TranDBResult.Success
        End If
        vRS.Close()
    End Function

    Public Function TeacherExistInGradeByID(ByVal sGradeValue As String) As TranDBResult


        Dim com As New MySqlCommand("SELECT tblGrade.GradeValue From tblGrade WHERE (((tblGrade.GradeValue)='" & sGradeValue & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            TeacherExistInGradeByID = TranDBResult.Success
        Else
            TeacherExistInGradeByID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function CreateRSGrade(Optional ByVal sDepartmentTitle As String = "", Optional ByVal sYearLevelTitle As String = "", Optional ByVal sTeacherTitle As String = "") As TranDBResult
        Dim sSQL As String
        Dim WHERE_Clause_Added As Boolean


        'default
        CreateRSGrade = TranDBResult.Failed
        'set starting querry
        sSQL = "SELECT tblGrade.EnrolmentID, tblYearLevel.YearLevelTitle, tblGrade.GradeTitle, tblDepartment.DepartmentTitle, tblTeacher.TeacherTitle, tblGrade.RoomNumber FROM tblTeacher INNER JOIN (tblYearLevel INNER JOIN (tblDepartment INNER JOIN tblGrade ON tblDepartment.SubjectID = tblGrade.SubjectOfferingID) ON tblYearLevel.YearLevelID = tblGrade.YearLevelID) ON tblTeacher.GradeValue = tblGrade.GradeValue"


        'first criteria
        If Len(sDepartmentTitle) > 0 Then
            WHERE_Clause_Added = True
            sSQL = sSQL & " WHERE (((tblDepartment.DepartmentTitle)='" & sDepartmentTitle & "')"

        End If



        If Len(sYearLevelTitle) > 1 Then

            If WHERE_Clause_Added <> True Then
                sSQL = sSQL & " WHERE ("
                WHERE_Clause_Added = True
            Else
                sSQL = sSQL & " AND "
            End If

            sSQL = sSQL & " ((tblYearLevel.YearLevelTitle)='" & sYearLevelTitle & "')"

        End If






        'close querry
        If WHERE_Clause_Added = True Then
            sSQL = sSQL & ");"
        End If

        MsgBox(sSQL)

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            CreateRSGrade = TranDBResult.Success
        End If
        vRS.Close()
    End Function


    'create rs by student
    Public Function CreateRSGradeByStudent(ByVal sStudentID As String) As TranDBResult

        Dim sSQL As String


        sSQL = "SELECT tblGrade.GradeID AS lvKey, tblSubject.SubjectTitle, tblGrade.GradeValue, CONCAT(LastName,', ',FirstName,' ',MiddleName) AS `Full Name`, tblEnrolment.StudentID, tblSchoolYear.SchoolYearTitle, tblYearLevel.YearLevelTitle, tblSection.SectionTitle" & _
                " FROM tblYearLevel INNER JOIN (tblSubject INNER JOIN (tblStudent INNER JOIN (tblSection INNER JOIN (tblSchoolYear INNER JOIN (tblEnrolment INNER JOIN tblGrade ON tblEnrolment.EnrolmentID = tblGrade.EnrolmentID) ON tblSchoolYear.SchoolYearTitle = tblEnrolment.SchoolYear) ON tblSection.SectionID = tblEnrolment.SectionID) ON tblStudent.StudentID = tblEnrolment.StudentID) ON tblSubject.SubjectID = tblGrade.SubjectOfferingID) ON (tblYearLevel.YearLevelID = tblSubject.YearLevelID) AND (tblYearLevel.YearLevelID = tblSection.YearLevelID)" & _
                " Where (((tblEnrolment.StudentID) = '" & sStudentID & "'))" & _
                " ORDER BY CONCAT(LastName,', ',FirstName,' ',MiddleName);"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            CreateRSGradeByStudent = TranDBResult.Success
        Else
            'FAILED: record does not exist
            CreateRSGradeByStudent = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function GetLatesAveGradeByStudentByYearLevel(ByRef AveGrade As Double, ByVal sStudentID As String, ByVal iYearLevelID As Integer) As TranDBResult
        Dim sSQL As String


        sSQL = "SELECT Avg(tblGrade.GradeValue) AS AvgOfGradeValue, tblEnrolment.StudentID, tblYearLevel.YearLevelID" & _
                " FROM tblYearLevel INNER JOIN (tblSection INNER JOIN (tblEnrolment INNER JOIN tblGrade ON tblEnrolment.EnrolmentID = tblGrade.EnrolmentID) ON tblSection.SectionID = tblEnrolment.SectionID) ON tblYearLevel.YearLevelID = tblSection.YearLevelID" & _
                " GROUP BY tblEnrolment.StudentID, tblYearLevel.YearLevelID" & _
                " HAVING (((tblEnrolment.StudentID)='" & sStudentID & "') AND ((tblYearLevel.YearLevelID)=" & iYearLevelID & "));"


        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            AveGrade = CDbl(vRS("AvgOfGradeValue").ToString())
            GetLatesAveGradeByStudentByYearLevel = TranDBResult.Success
        Else
            'FAILED: record does not exist
            GetLatesAveGradeByStudentByYearLevel = TranDBResult.Failed
        End If
        vRS.Close()
    End Function


    Public Function GetAveGradeByStudentIDByYLTitle(ByVal sStudentID As String, ByVal sYearLevelTitle As String, ByRef AveGrade As Double) As TranDBResult
        Dim sSQL As String


        sSQL = "SELECT Avg(tblGrade.GradeValue) AS AvgOfGradeValue" & _
                " FROM tblYearLevel INNER JOIN (tblSubject INNER JOIN (tblEnrolment INNER JOIN tblGrade ON tblEnrolment.EnrolmentID = tblGrade.EnrolmentID) ON tblSubject.SubjectID = tblGrade.SubjectOfferingID) ON tblYearLevel.YearLevelID = tblSubject.YearLevelID" & _
                " WHERE (((tblEnrolment.StudentID)='" & sStudentID & "') AND ((tblYearLevel.YearLevelTitle)='" & sYearLevelTitle & "'));"



        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then

            AveGrade = CDbl(vRS("AvgOfGradeValue").ToString())
            GetAveGradeByStudentIDByYLTitle = TranDBResult.Success
        Else
            'FAILED: record does not exist
            GetAveGradeByStudentIDByYLTitle = TranDBResult.Failed
        End If

        vRS.Close()

    End Function


    Public Function GradeRecordExist() As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblGrade", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            GradeRecordExist = TranDBResult.Success
        Else
            GradeRecordExist = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function IsGradeEditable(ByVal sGradeID As String, ByRef Editable As Boolean) As TranDBResult
        Dim sSQL As String
        Dim sStudentID As String
        Dim curLyearLevelID As Integer
        Dim sSchoolYearTitle As String
        Dim lYearLevelID As Integer

        'default
        Editable = False


        sSQL = "SELECT tblEnrolment.StudentID, tblSection.YearLevelID, tblGrade.GradeID" & _
                " FROM tblSection INNER JOIN (tblEnrolment INNER JOIN tblGrade ON tblEnrolment.EnrolmentID = tblGrade.EnrolmentID) ON tblSection.SectionID = tblEnrolment.SectionID" & _
                " WHERE (((tblGrade.GradeID)='" & sGradeID & "'));"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = False Then
            IsGradeEditable = TranDBResult.InvalidGradeID
        Else
            sStudentID = vRS("StudentID").ToString()
            curLyearLevelID = CInt(vRS("YearLevelID").ToString())
        End If
        vRS.Close()



        'If GetLatestSchoolYearYearLevel(sStudentID, sSchoolYearTitle, lYearLevelID) <> TranDBResult.Success Then
        '    IsGradeEditable = TranDBResult.InvalidGradeID
        '    Exit Function
        'End If

        If curLyearLevelID < lYearLevelID Then
            Editable = False
        Else
            Editable = True
        End If
        IsGradeEditable = TranDBResult.Success
    End Function



    Public Function CreateRSGradeBySectionOfferingID(ByVal sSectionOfferingID As String) As TranDBResult

        Dim sSQL As String

        sSQL = "SELECT tblSubjectOffering.SubjectOfferingID " & _
                " FROM tblSectionOffering INNER JOIN tblSubjectOffering ON tblSectionOffering.SectionOfferingID = tblSubjectOffering.SectionOfferingID" & _
                " Where (((tblSectionOffering.SectionOfferingID) = '" & sSectionOfferingID & "'))"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            CreateRSGradeBySectionOfferingID = TranDBResult.Success
        Else
            CreateRSGradeBySectionOfferingID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function
    Public Function CreateTempRSGradeBySectionOfferingID(ByVal sSectionOfferingID As String) As TranDBResult

        Dim sSQL As String

        sSQL = "SELECT tblSubjectOffering.SubjectOfferingID " & _
                " FROM tblSectionOffering INNER JOIN tblSubjectOffering ON tblSectionOffering.SectionOfferingID = tblSubjectOffering.SectionOfferingID" & _
                " Where (((tblSectionOffering.SectionOfferingID) = '" & sSectionOfferingID & "'))"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            CreateTempRSGradeBySectionOfferingID = TranDBResult.Success
        Else
            CreateTempRSGradeBySectionOfferingID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function
End Module
