Imports MySql.Data.MySqlClient

Module modRSSectionOffering

    Public Const KeySectionOffering As String = "seof"

    Public Structure tSectionOffering
        Dim SectionOfferingID As String
        Dim SectionID As String
        Dim TeacherID As String
        Dim SchoolYear As String
        Dim MaxStudentCount As Integer
        Dim MaxGrade As Double
        Dim MinGrade As Double
        Dim Note As String
        Dim RoomID As String

        Dim CreationDate As Date
        Dim CreatedBy As String
        Dim ModifiedDate As Date
        Dim ModifiedBy As String
    End Structure


    Public Function AddSectionOffering(ByVal vSectionID As String, ByVal vSectionOffering As tSectionOffering) As TranDBResult
        Dim sSQL As String

        If SectionOfferingExistByID(vSectionOffering.SectionOfferingID) = TranDBResult.Success Then
            AddSectionOffering = TranDBResult.DuplicateID
            GoTo ReleaseAndExit
        End If

        sSQL = "INSERT INTO tblSectionOffering(SectionOfferingID,SectionID,SchoolYear,TeacherID,MaxStudentCount,MaxGrade,MinGrade,Note,RoomID,CreationDate,CreatedBy) VALUES ('" & _
                vSectionOffering.SectionOfferingID & _
                "','" & vSectionOffering.SectionID & _
                "','" & vSectionOffering.SchoolYear & _
                "','" & vSectionOffering.TeacherID & _
                "','" & vSectionOffering.MaxStudentCount & _
                "','" & vSectionOffering.MaxGrade & _
                "','" & vSectionOffering.MinGrade & _
                "','" & vSectionOffering.Note & _
                "','" & vSectionOffering.RoomID & _
                "','" & vSectionOffering.CreationDate & _
                "','" & vSectionOffering.CreatedBy & "')"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        com.ExecuteNonQuery()

        AddSectionOffering = TranDBResult.Success
        
ReleaseAndExit:
        Exit Function
    End Function


    Public Function EditSectionOffering(ByVal vSectionOffering As tSectionOffering) As TranDBResult

        Dim sSQL As String

        If SectionOfferingExistByID(vSectionOffering.SectionID) <> TranDBResult.Success Then
            EditSectionOffering = TranDBResult.InvalidID
            GoTo ReleaseAndExit
        End If

        sSQL = "UPDATE tblSectionOffering SET SectionOfferingID='" & vSectionOffering.SectionOfferingID & "', SectionID='" & vSectionOffering.SectionID & "', SchoolYear='" & vSectionOffering.SchoolYear & "', TeacherID='" & vSectionOffering.TeacherID & _
                "', MaxStudentCount='" & vSectionOffering.MaxStudentCount & "', MaxGrade='" & vSectionOffering.MaxGrade & "', MinGrade='" & vSectionOffering.MinGrade & _
                "', Note='" & vSectionOffering.Note & "', RoomID='" & vSectionOffering.RoomID & "', ModifiedDate='" & vSectionOffering.ModifiedDate & "',ModifiedBy ='" & vSectionOffering.ModifiedBy & "' WHERE SectionOfferingID='" & vSectionOffering.SectionOfferingID & "'"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        com.ExecuteNonQuery()

        EditSectionOffering = TranDBResult.Success
ReleaseAndExit:
        Exit Function
    End Function



    Public Function DeleteSectionOffering(ByVal sSectionOfferingID As String) As TranDBResult

        Dim com As New MySqlCommand("Delete From tblSectionOffering WHERE (((tblSectionOffering.SectionOfferingID)='" & sSectionOfferingID & "'));", clsCon.con)
        com.ExecuteNonQuery()
        DeleteSectionOffering = TranDBResult.Success
        
    End Function



    Public Function GetSectionOfferingByID(ByVal sSectionOfferingID As String, ByRef vSectionOffering As tSectionOffering) As TranDBResult
        On Error Resume Next
        Dim sSQL As String

        GetSectionOfferingByID = TranDBResult.Failed


        If Len(sSectionOfferingID) < 1 Then
            GetSectionOfferingByID = TranDBResult.Failed
            GoTo ReleaseAndExit
        End If

        sSQL = "SELECT * FROM tblSectionOffering WHERE SectionOfferingID='" & sSectionOfferingID & "'"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            vSectionOffering.SectionOfferingID = vRS("SectionOfferingID").ToString()
            vSectionOffering.SectionID = (vRS("SectionID").ToString())
            vSectionOffering.SchoolYear = (vRS("SchoolYear").ToString())

            vSectionOffering.TeacherID = (vRS("TeacherID").ToString())
            vSectionOffering.MaxStudentCount = Convert.ToInt32(vRS("MaxStudentCount").ToString())
            vSectionOffering.MaxGrade = Convert.ToInt32(vRS("MaxGrade").ToString())
            vSectionOffering.MinGrade = Convert.ToInt32(vRS("MinGrade").ToString())
            vSectionOffering.Note = (vRS("Note").ToString())

            vSectionOffering.CreationDate = Convert.ToDateTime(vRS("CreationDate").ToString())
            vSectionOffering.CreatedBy = (vRS("CreatedBy").ToString())

            GetSectionOfferingByID = TranDBResult.Success

        Else
            GetSectionOfferingByID = TranDBResult.Failed
        End If
        vRS.Close()
ReleaseAndExit:
        Exit Function
    End Function

    Public Function SectionOfferingExistByID(ByVal sSectionOfferingID As String) As TranDBResult
        Dim sSQL As String

        'default
        SectionOfferingExistByID = TranDBResult.Failed

        If Len(sSectionOfferingID) < 1 Then Exit Function

        sSQL = " SELECT tblSectionOffering.SectionOfferingID" & _
                " From tblSectionOffering " & _
                " WHERE (((tblSectionOffering.SectionOfferingID)='" & sSectionOfferingID & "'));"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            SectionOfferingExistByID = TranDBResult.Success
        Else
            SectionOfferingExistByID = TranDBResult.Failed
        End If
        
        vRS.Close()
    End Function

    Public Function SectionOfferingExistBySectionID(ByVal sSectionID As String) As TranDBResult
        Dim sSQL As String

        'default
        SectionOfferingExistBySectionID = TranDBResult.Failed

        If Len(sSectionID) < 1 Then Exit Function

        sSQL = " SELECT tblSectionOffering.SectionID" & _
                " From tblSectionOffering " & _
                " WHERE (((tblSectionOffering.SectionID)='" & sSectionID & "'));"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            SectionOfferingExistBySectionID = TranDBResult.Success
        Else
            SectionOfferingExistBySectionID = TranDBResult.Failed
        End If

        vRS.Close()
    End Function

    Public Function TeacherAssignedBySchoolYear(ByVal sTeacherID As String, ByVal sSchoolYearTitle As String) As TranDBResult
        Dim sSQL As String

        'default
        TeacherAssignedBySchoolYear = TranDBResult.Failed

        If Len(sSchoolYearTitle) < 1 Or Len(sTeacherID) < 1 Then Exit Function

        sSQL = "SELECT  tblSectionOffering.TeacherID,  tblSectionOffering.SchoolYear" & _
                " From  tblSectionOffering" & _
                " WHERE (((tblSectionOffering.TeacherID)='" & sTeacherID & "') AND ((tblSectionOffering.SchoolYear)='" & sSchoolYearTitle & "'));"


        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            TeacherAssignedBySchoolYear = TranDBResult.Success
        Else
            TeacherAssignedBySchoolYear = TranDBResult.Failed
        End If

        vRS.Close()
    End Function


    Public Function GetAutoSectionOffering(ByVal sSchoolYear As String, ByVal sDepartmentID As String, ByVal iYearLevelID As Integer, ByVal dStudentPrevAveGrade As Double, ByRef sReturnSectionOfferingID As String) As TranDBResult
        Dim sSQL As String

        sSQL = "SELECT tblSectionOffering.SectionOfferingID, Count(tblEnrolment.EnrolmentID) AS CountOfEnrolmentID, tblSectionOffering.MinGrade, tblSectionOffering.MaxGrade, tblSectionOffering.MaxStudentCount, CONCAT(tblSectionOffering.MaxGrade+tblSectionOffering.MinGrade) AS GradeRank, tblSectionOffering.MaxGrade, tblSectionOffering.CreationDate, tblSectionOffering.SchoolYear, tblSection.DepartmentID, tblSection.YearLevelID " & _
                "FROM tblSection INNER JOIN (tblSectionOffering LEFT JOIN tblEnrolment ON tblSectionOffering.SectionOfferingID = tblEnrolment.SectionOfferingID) ON tblSection.SectionID = tblSectionOffering.SectionID " & _
                "GROUP BY tblSectionOffering.SectionOfferingID, tblSectionOffering.MinGrade, tblSectionOffering.MaxGrade, tblSectionOffering.MaxStudentCount, (tblSectionOffering.MaxGrade+tblSectionOffering.MinGrade), tblSectionOffering.MaxGrade, tblSectionOffering.CreationDate, tblSectionOffering.SchoolYear, tblSection.DepartmentID, tblSection.YearLevelID " & _
                "Having (((Count(tblEnrolment.EnrolmentID)) < tblSectionOffering.MaxStudentCount) And ((tblSectionOffering.MinGrade) <= " & dStudentPrevAveGrade & ") And ((tblSectionOffering.MaxGrade) >= " & dStudentPrevAveGrade & ") And ((tblSectionOffering.SchoolYear) = '" & sSchoolYear & "') And ((tblSection.DepartmentID) = '" & sDepartmentID & "') And ((tblSection.YearLevelID) = " & iYearLevelID & ")) " & _
                "ORDER BY (tblSectionOffering.MaxGrade+tblSectionOffering.MinGrade) DESC , tblSectionOffering.MaxGrade DESC , tblSectionOffering.CreationDate;"

        sReturnSectionOfferingID = ""
        GetAutoSectionOffering = TranDBResult.Failed

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = False Then
            GetAutoSectionOffering = TranDBResult.Failed
            GoTo ReleaseAndExit
        End If

        'success
        sReturnSectionOfferingID = (vRS("SectionID").ToString())
        GetAutoSectionOffering = TranDBResult.Success


ReleaseAndExit:
        vRS.Close()
        Exit Function
    End Function

End Module
