Option Explicit On
Imports MySql.Data.MySqlClient
Imports System.Data

Module modDBSubject
    Public Const KeySubject As String = "subj"

    Public Structure tSubject
        Dim SubjectCode As String
        Dim SubjectTitle As String
        Dim SubjectID As String
        Dim Description As String
        Dim Alias1 As String
        Dim Alias2 As String
        Dim Units As Integer
        Dim LecHrs As Integer
        Dim LabUnits As Integer
        Dim LabHrs As Integer
        Dim CreditUnits As Integer


        Dim SubjectParentID As String
        Dim CourseLevelID As String

        Dim MinSlots As Integer
        Dim MaxSlots As Integer

        Dim SubjectWithInternet As Short
        Dim InclGWA As Short
        Dim InActive As Short
        Dim IsComputerSubject As Short
        Dim IsSubjectGE As Short
        Dim IsSubjectElective As Short
        Dim IsNonAcademic As Short
        Dim IsSubjectELearning As Short
        Dim IsSubjectMajor As Short
        Dim IsOtherSchool As Short
        Dim IsClubOrganization As Short

        Dim UseTransmutedGrade As Short

        Dim IsLocked As Short

        Dim IncludeTFCompute As Short
        Dim InlcludeLFComputer As Short

        Dim ChargeAirConLecUnit As Short
        Dim ChargeAirConLabUnit As Short

        Dim DateLocked As Date

        Dim SubjectAreaID As String
        Dim SubjectMode As String

        Dim CreationDate As Date
        Dim CreatedBy As String

        Dim ModifiedDate As Date
        Dim Modified As String

    End Structure

    Public Structure tSubjectAreas
        Dim SubjectAreaID As String
        Dim SubjectAreaName As String
        Dim ShortName As String
    End Structure
    Public Structure tSubjectMode
        Dim SubjectMode As String
        Dim Description As String
        Dim ShortName As String
    End Structure






    Public Function CreateRSSubjectBySectionID(ByVal sSectionID As String) As TranDBResult

        Dim sSQL As String

        'default
        CreateRSSubjectBySectionID = TranDBResult.Failed

        sSQL = "SELECT tblSubject.SubjectID, tblSubject.SubjectTitle, tblDepartment.DepartmentTitle, tblTeacher.TeacherTitle, tblSubject.Description" & _
                " FROM tblTeacher INNER JOIN (tblDepartment INNER JOIN ((tblYearLevel INNER JOIN tblSection ON tblYearLevel.YearLevelID = tblSection.YearLevelID) INNER JOIN tblSubject ON tblYearLevel.YearLevelID = tblSubject.YearLevelID) ON (tblDepartment.DepartmentID = tblSubject.DepartmentID) AND (tblDepartment.DepartmentID = tblSection.DepartmentID)) ON tblTeacher.TeacherID = tblSection.TeacherID" & _
                " Where (((tblSection.SectionID) = '" & sSectionID & "'))" & _
                " GROUP BY tblSubject.SubjectID, tblSubject.SubjectTitle, tblDepartment.DepartmentTitle, tblYearLevel.YearLevelTitle, tblTeacher.TeacherTitle, tblSubject.Description;"


        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            CreateRSSubjectBySectionID = TranDBResult.Success
        End If
        vRS.Close()
    End Function

    Public Function AddSubjectAreas(ByVal newSubArea As tSubjectAreas) As TranDBResult

        If SubjectAreaExistByID(newSubArea.SubjectAreaID) = TranDBResult.Success Then
            AddSubjectAreas = TranDBResult.DuplicateID
            GoTo ReleaseAndExit
        End If

        If Len(Trim(newSubArea.SubjectAreaID)) < 1 Then
            AddSubjectAreas = TranDBResult.InvalidSubjectAreaID
            GoTo ReleaseAndExit
        End If

        Dim com As New MySqlCommand("INSERT INTO tblSubjectAreas(SubjectAreaID,SubjectAreaName,ShortName) VALUES " & _
                                    "('" & newSubArea.SubjectAreaID & "','" & newSubArea.SubjectAreaName & "','" & newSubArea.ShortName & "')", clsCon.con)
        com.ExecuteNonQuery()

        AddSubjectAreas = TranDBResult.Success

ReleaseAndExit:
        Exit Function
    End Function

    Public Function AddSubjectMode(ByVal newSubMode As tSubjectMode) As TranDBResult

        If SubjectModeExistByID(newSubMode.SubjectMode) = TranDBResult.Success Then
            AddSubjectMode = TranDBResult.DuplicateID
            GoTo ReleaseAndExit
        End If

        If Len(Trim(newSubMode.SubjectMode)) < 1 Then
            AddSubjectMode = TranDBResult.InvalidSubjectModeID
            GoTo ReleaseAndExit
        End If

        Dim com As New MySqlCommand("INSERT INTO tblSubjectMode(SubjectMode,Description,ShortName) VALUES " & _
                                    "('" & newSubMode.SubjectMode & "','" & newSubMode.Description & "','" & newSubMode.ShortName & "')", clsCon.con)
        'Dim com As New MySqlCommand("CALL AddSubjectMode(@Mode,@Desc,@Name)", clsCon.con)
        'com.Parameters.Add("@Mode", MySqlDbType.VarChar, 45).Value = newSubMode.SubjectMode
        'com.Parameters.Add("@Desc", MySqlDbType.VarChar, 150).Value = newSubMode.Description
        'com.Parameters.Add("@Name", MySqlDbType.VarChar, 45).Value = newSubMode.ShortName
        com.ExecuteNonQuery()

        AddSubjectMode = TranDBResult.Success

ReleaseAndExit:
        Exit Function
    End Function

    Public Function EditSubjectMode(ByVal newSubMode As tSubjectMode) As TranDBResult

        If SubjectModeExistByID(newSubMode.SubjectMode) = TranDBResult.Success Then

            Dim com As New MySqlCommand("UPDATE tblSubjectMode SET SubjectMode='" & newSubMode.SubjectMode & "',Description='" & newSubMode.Description & "',ShortName='" & newSubMode.ShortName & "' WHERE SubjectMode='" & newSubMode.SubjectMode & "'", clsCon.con)
            com.ExecuteNonQuery()

            EditSubjectMode = TranDBResult.Success
        End If

ReleaseAndExit:
        Exit Function
    End Function

    Public Function EditSubjectAreas(ByVal newSubArea As tSubjectAreas) As TranDBResult

        If SubjectAreaExistByID(newSubArea.SubjectAreaID) = TranDBResult.Success Then

            Dim com As New MySqlCommand("UPDATE tblSubjectAreas SET SubjectAreaID='" & newSubArea.SubjectAreaID & "',SubjectAreaName='" & newSubArea.SubjectAreaName & "',ShortName='" & newSubArea.ShortName & "' WHERE SubjectAreaID='" & newSubArea.SubjectAreaID & "'", clsCon.con)
            com.ExecuteNonQuery()

            EditSubjectAreas = TranDBResult.Success
        End If

ReleaseAndExit:
        Exit Function
    End Function

    Public Function AddSubject(ByVal newSubject As tSubject) As TranDBResult


        Dim daSubject As New MySqlDataAdapter()
        Dim dsSubject As New DataSet()

        'find duplicate ID
        If SubjectExistByID(newSubject.SubjectID) = TranDBResult.Success Then
            AddSubject = TranDBResult.DuplicateID
            GoTo ReleaseAndExit
        End If

        'find duplicate TITLE
        If SubjectExistByTitle(newSubject.SubjectTitle) = TranDBResult.Success Then
            AddSubject = TranDBResult.DuplicateTitle
            GoTo ReleaseAndExit
        End If

        'find duplicate SUBJECT CODE
        If SubjectExistBySubjectCode(newSubject.SubjectCode) = TranDBResult.Success Then
            AddSubject = TranDBResult.DuplicateCode
            GoTo ReleaseAndExit
        End If


        'check each fields
        If Len(Trim(newSubject.SubjectID)) < 1 Then
            AddSubject = TranDBResult.InvalidSubjectSubjectID
            GoTo ReleaseAndExit
        End If

        If Len(Trim(newSubject.SubjectTitle)) < 1 Then
            AddSubject = TranDBResult.InvalidSubjectSubjectTitle
            GoTo ReleaseAndExit
        End If

        If Len(Trim(newSubject.Description)) < 1 Then
            AddSubject = TranDBResult.InvalidSubjectDescription
            GoTo ReleaseAndExit
        End If

        If Len(Trim(newSubject.SubjectCode)) < 1 Then
            AddSubject = TranDBResult.InvalidSubjectCode
            GoTo ReleaseAndExit
        End If


        Dim com As New MySqlCommand("INSERT INTO tblSubject(SubjectID,SubjectTitle,SubjectCode,AliasCode1,AliasCode2,Description, " & _
                                    "Units, LecHrs, LabUnits, LabHrs, CreditUnits, LevelID, MinSize, MaxSize, SubjectWithInternet, " & _
                                    "InclGWA, Inactive, IsCompSubject, IsSubjectGE, IsSubjectElective, IsNonAcademic, IsSubjectELearning, " & _
                                    "CreatedBy, CreationDate, SubjectAreaID, SubjectMode, IsOtherSchool, IsMajorSubject, IsClubOrganization, " & _
                                    "InclTFCompute, InclLFCompute, SubjParentID, IsTransmutedGrade, DateLocked) " & _
                                    "VALUES (@ID,@Title,@Code,@Alias,@Alias2,@Description,@Units,@LecHrs," & _
                                    "@LabUnits,@LabHrs,@Credit,@CourseLevelID,@MinSize,@MaxSize,@SWI,@IGWA," & _
                                    "@InActive,@ICS,@ISGE,@ISE,@INA,@ISEL,@CreatedBy,@Date,@AreaID,@Mode,@Other,@Major,@Club,'1','1',@Parent,@Grade,@DateLocked)", clsCon.con)

        com.Parameters.Add("@ID", MySqlDbType.VarChar, 45).Value = newSubject.SubjectID
        com.Parameters.Add("@Title", MySqlDbType.VarChar, 255).Value = newSubject.SubjectTitle
        com.Parameters.Add("@Code", MySqlDbType.VarChar, 45).Value = newSubject.SubjectCode
        com.Parameters.Add("@Alias", MySqlDbType.VarChar, 45).Value = newSubject.Alias1
        com.Parameters.Add("@Alias2", MySqlDbType.VarChar, 45).Value = newSubject.Alias2
        com.Parameters.Add("@Description", MySqlDbType.Text).Value = newSubject.Description
        com.Parameters.Add("@Units", MySqlDbType.Int32, 2).Value = newSubject.Units
        com.Parameters.Add("@LecHrs", MySqlDbType.Int32, 2).Value = newSubject.LecHrs
        com.Parameters.Add("@LabUnits", MySqlDbType.Int32, 2).Value = newSubject.LabUnits
        com.Parameters.Add("@LabHrs", MySqlDbType.Int32, 2).Value = newSubject.LabHrs
        com.Parameters.Add("@Credit", MySqlDbType.Int32, 2).Value = newSubject.CreditUnits

        com.Parameters.Add("@CourseLevelID", MySqlDbType.VarChar, 45).Value = newSubject.CourseLevelID

        com.Parameters.Add("@MinSize", MySqlDbType.Int32, 3).Value = newSubject.MinSlots
        com.Parameters.Add("@MaxSize", MySqlDbType.Int32, 3).Value = newSubject.MaxSlots

        com.Parameters.Add("@SWI", MySqlDbType.Int16, 1).Value = newSubject.SubjectWithInternet
        com.Parameters.Add("@IGWA", MySqlDbType.Int16, 1).Value = newSubject.InclGWA
        com.Parameters.Add("@InActive", MySqlDbType.Int16, 1).Value = newSubject.InActive
        com.Parameters.Add("@ICS", MySqlDbType.Int16, 1).Value = newSubject.IsComputerSubject
        com.Parameters.Add("@ISGE", MySqlDbType.Int16, 1).Value = newSubject.IsSubjectGE
        com.Parameters.Add("@ISE", MySqlDbType.Int16, 1).Value = newSubject.IsSubjectElective
        com.Parameters.Add("@INA", MySqlDbType.Int16, 1).Value = newSubject.IsNonAcademic
        com.Parameters.Add("@ISEL", MySqlDbType.Int16, 1).Value = newSubject.IsSubjectELearning
        com.Parameters.Add("@Other", MySqlDbType.Int16, 1).Value = newSubject.IsOtherSchool
        com.Parameters.Add("@Major", MySqlDbType.Int16, 1).Value = newSubject.IsSubjectMajor
        com.Parameters.Add("@Club", MySqlDbType.Int16, 1).Value = newSubject.IsClubOrganization

        com.Parameters.Add("@CreatedBy", MySqlDbType.VarChar, 45).Value = newSubject.CreatedBy
        com.Parameters.Add("@Date", MySqlDbType.Date).Value = newSubject.CreationDate

        com.Parameters.Add("@AreaID", MySqlDbType.VarChar, 45).Value = newSubject.SubjectAreaID
        com.Parameters.Add("@Mode", MySqlDbType.VarChar, 45).Value = newSubject.SubjectMode
        com.Parameters.Add("@Parent", MySqlDbType.VarChar, 45).Value = newSubject.SubjectParentID
        com.Parameters.Add("@Grade", MySqlDbType.VarChar, 45).Value = newSubject.UseTransmutedGrade

        com.Parameters.Add("@DateLocked", MySqlDbType.DateTime).Value = newSubject.DateLocked

        com.ExecuteNonQuery()

        com.Parameters.Clear()

        AddSubject = TranDBResult.Success

ReleaseAndExit:
        Exit Function
    End Function



    Public Function EditSubject(ByVal newSubject As tSubject) As TranDBResult

        Dim oldSubject As tSubject
        Dim daSubject As New MySqlDataAdapter()
        Dim dsSubject As New DataSet()

        'get old Subject
        If GetSubjectByID(newSubject.SubjectID, oldSubject) <> TranDBResult.Success Then
            EditSubject = TranDBResult.InvalidID
            GoTo ReleaseAndExit
        End If

        Dim com As New MySqlCommand("CALL UpdateSubjects(@ID,@Title,@Code,@Alias,@Alias2,@Description," & _
                                   "@Units,@LecHrs,@LabUnits,@LabHrs,@Credit,@CourseLevelID,@MinSize,@MaxSize,@SWI,@IGWA, " & _
                                   "@InActive,@ICS,@ISGE,@ISE,@INA,@ISEL,@CreatedBy,@Date,@AreaID,@Mode,@Other,@Major,@Club,'1','1',@Parent,@Grade,@DateLock)", clsCon.con)

        com.Parameters.Add("@ID", MySqlDbType.VarChar, 45).Value = newSubject.SubjectID
        com.Parameters.Add("@Title", MySqlDbType.VarChar, 255).Value = newSubject.SubjectTitle
        com.Parameters.Add("@Code", MySqlDbType.VarChar, 45).Value = newSubject.SubjectCode
        com.Parameters.Add("@Alias", MySqlDbType.VarChar, 45).Value = newSubject.Alias1
        com.Parameters.Add("@Alias2", MySqlDbType.VarChar, 45).Value = newSubject.Alias2
        com.Parameters.Add("@Description", MySqlDbType.Text).Value = newSubject.Description
        com.Parameters.Add("@Units", MySqlDbType.Int32, 2).Value = newSubject.Units
        com.Parameters.Add("@LecHrs", MySqlDbType.Int32, 2).Value = newSubject.LecHrs
        com.Parameters.Add("@LabUnits", MySqlDbType.Int32, 2).Value = newSubject.LabUnits
        com.Parameters.Add("@LabHrs", MySqlDbType.Int32, 2).Value = newSubject.LabHrs
        com.Parameters.Add("@Credit", MySqlDbType.Int32, 2).Value = newSubject.CreditUnits

        com.Parameters.Add("@CourseLevelID", MySqlDbType.VarChar, 45).Value = newSubject.CourseLevelID

        com.Parameters.Add("@MinSize", MySqlDbType.Int32, 3).Value = newSubject.MinSlots
        com.Parameters.Add("@MaxSize", MySqlDbType.Int32, 3).Value = newSubject.MaxSlots

        com.Parameters.Add("@SWI", MySqlDbType.Int16, 1).Value = newSubject.SubjectWithInternet
        com.Parameters.Add("@IGWA", MySqlDbType.Int16, 1).Value = newSubject.InclGWA
        com.Parameters.Add("@InActive", MySqlDbType.Int16, 1).Value = newSubject.InActive
        com.Parameters.Add("@ICS", MySqlDbType.Int16, 1).Value = newSubject.IsComputerSubject
        com.Parameters.Add("@ISGE", MySqlDbType.Int16, 1).Value = newSubject.IsSubjectGE
        com.Parameters.Add("@ISE", MySqlDbType.Int16, 1).Value = newSubject.IsSubjectElective
        com.Parameters.Add("@INA", MySqlDbType.Int16, 1).Value = newSubject.IsNonAcademic
        com.Parameters.Add("@ISEL", MySqlDbType.Int16, 1).Value = newSubject.IsSubjectELearning
        com.Parameters.Add("@Other", MySqlDbType.Int16, 1).Value = newSubject.IsOtherSchool
        com.Parameters.Add("@Major", MySqlDbType.Int16, 1).Value = newSubject.IsSubjectMajor
        com.Parameters.Add("@Club", MySqlDbType.Int16, 1).Value = newSubject.IsClubOrganization

        com.Parameters.Add("@CreatedBy", MySqlDbType.VarChar, 45).Value = newSubject.CreatedBy
        com.Parameters.Add("@Date", MySqlDbType.Date).Value = newSubject.CreationDate

        com.Parameters.Add("@AreaID", MySqlDbType.VarChar, 45).Value = newSubject.SubjectAreaID
        com.Parameters.Add("@Mode", MySqlDbType.VarChar, 45).Value = newSubject.SubjectMode
        com.Parameters.Add("@Parent", MySqlDbType.VarChar, 45).Value = newSubject.SubjectParentID
        com.Parameters.Add("@Grade", MySqlDbType.VarChar, 45).Value = newSubject.UseTransmutedGrade

        com.Parameters.Add("@DateLock", MySqlDbType.Date).Value = newSubject.DateLocked

        com.ExecuteNonQuery()

        com.Parameters.Clear()
        EditSubject = TranDBResult.Success

        'find record to edit

    

ReleaseAndExit:
        'release
        Exit Function
    End Function
    Public Function SubjectRecordExist() As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblSubject", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            SubjectRecordExist = TranDBResult.Success
        Else
            SubjectRecordExist = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function SubjectModeExist() As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblSubjectMode", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            SubjectModeExist = TranDBResult.Success
        Else
            SubjectModeExist = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function SubjectAreasExist() As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblSubjectAreas", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            SubjectAreasExist = TranDBResult.Success
        Else
            SubjectAreasExist = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function GetEnrolmentCountBySubject(ByVal sSubjectID As String, ByRef lEnrolmentCount As Long) As TranDBResult
        Dim sSQL As String

        GetEnrolmentCountBySubject = TranDBResult.Failed

        sSQL = " SELECT Count(tblEnrolment.EnrolmentID) AS EnrolmentCount, tblSubject.SubjectID " & _
                " FROM (tblYearLevel INNER JOIN tblSection ON tblYearLevel.YearLevelID = tblSection.YearLevelID) INNER JOIN (tblEnrolment INNER JOIN (tblSubject INNER JOIN tblGrade ON tblSubject.SubjectID = tblGrade.SubjectOfferingID) ON tblEnrolment.EnrolmentID = tblGrade.EnrolmentID) ON tblYearLevel.YearLevelID = tblSubject.YearLevelID" & _
                " GROUP BY tblSubject.SubjectID" & _
                " HAVING (((tblSubject.SubjectID)='" & sSubjectID & "'));"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            lEnrolmentCount = Convert.ToInt32(vRS("EnrolmentCount").ToString())
            GetEnrolmentCountBySubject = TranDBResult.Success
        Else
            lEnrolmentCount = -1
            GetEnrolmentCountBySubject = TranDBResult.Failed
        End If

        vRS.Close()

    End Function
    Public Function DeleteSubject(ByVal sSubjectID As String, Optional ByVal ShowMessage As Boolean = True) As TranDBResult
        Dim lEnrolmentCount As Long

        'default
        DeleteSubject = TranDBResult.Failed

        'check
        If GetEnrolmentCountBySubject(sSubjectID, lEnrolmentCount) = TranDBResult.Success Then
            If lEnrolmentCount > 0 Then
                If ShowMessage = True Then
                    'temp
                    MsgBox("temp: show is already used", vbExclamation)
                End If

                DeleteSubject = TranDBResult.Failed
                Exit Function
            End If
        Else
            'subject entry not exist
            CatchError("frmAllSubject", "listRecord_DblClick", "GetEnrolmentCountBySubject(lvKey, lEnrolmentCount) = success")
            Exit Function
        End If


        '----------------------------------------------------
        'delete
        '----------------------------------------------------
        Dim com As New MySqlCommand("Delete From tblSubject WHERE (((tblSubject.SubjectID)='" & sSubjectID & "'));", clsCon.con)
        com.ExecuteNonQuery()
        DeleteSubject = TranDBResult.Success

    End Function


    Public Function SubjectExistByTitle(ByVal sSubjectTitle As String) As TranDBResult

        Dim com As New MySqlCommand("SELECT * From tblSubject WHERE (((tblSubject.SubjectTitle)='" & sSubjectTitle & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            SubjectExistByTitle = TranDBResult.Success
        Else
            SubjectExistByTitle = TranDBResult.Failed
        End If

        vRS.Close()
    End Function


    Public Function SubjectExistByID(ByVal sSubjectID As String) As TranDBResult

        Dim com As New MySqlCommand("SELECT * From tblSubject WHERE (((tblSubject.SubjectID)='" & sSubjectID & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            SubjectExistByID = TranDBResult.Success
        Else
            SubjectExistByID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function SubjectExistBySubjectCode(ByVal sSubjectCode As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * From tblSubject WHERE (((tblSubject.SubjectCode)='" & sSubjectCode & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            SubjectExistBySubjectCode = TranDBResult.Success
        Else
            SubjectExistBySubjectCode = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function SubjectAreaExistByID(ByVal sSubjectAreaID As String) As TranDBResult

        Dim com As New MySqlCommand("SELECT * From tblSubjectAreas WHERE (((tblSubjectAreas.SubjectAreaID)='" & sSubjectAreaID & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            SubjectAreaExistByID = TranDBResult.Success
        Else
            SubjectAreaExistByID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function SubjectAreaExistByShortName(ByVal sSubjectAreaName As String) As TranDBResult

        Dim com As New MySqlCommand("SELECT * From tblSubjectAreas WHERE (((tblSubjectAreas.ShortName)='" & sSubjectAreaName & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            SubjectAreaExistByShortName = TranDBResult.Success
        Else
            SubjectAreaExistByShortName = TranDBResult.Failed
        End If
        vRS.Close()
    End Function
    Public Function SubjectModeExistByID(ByVal sSubjectMode As String) As TranDBResult

        Dim com As New MySqlCommand("SELECT * From tblSubjectMode WHERE (((tblSubjectMode.SubjectMode)='" & sSubjectMode & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            SubjectModeExistByID = TranDBResult.Success
        Else
            SubjectModeExistByID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function SubjectModeExistByShortName(ByVal sSubjectModeName As String) As TranDBResult

        Dim com As New MySqlCommand("SELECT * From tblSubjectMode WHERE (((tblSubjectMode.ShortName)='" & sSubjectModeName & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            SubjectModeExistByShortName = TranDBResult.Success
        Else
            SubjectModeExistByShortName = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function GetSubjectByID(ByVal sSubjectID As String, ByRef vSubject As tSubject) As TranDBResult
        'On Error Resume Next

        Dim com As New MySqlCommand("SELECT * From tblSubject WHERE (((tblSubject.SubjectID)='" & sSubjectID & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            vSubject.SubjectID = (vRS("Subjectid").ToString())
            vSubject.SubjectTitle = (vRS("Subjecttitle").ToString())
            vSubject.SubjectCode = vRS("SubjectCode").ToString()
            vSubject.Description = (vRS("Description").ToString())
            vSubject.Alias1 = vRS("AliasCode1").ToString() '
            vSubject.Alias2 = vRS("AliasCode2").ToString()
            vSubject.CreditUnits = vRS("CreditUnits").ToString()
            vSubject.Units = (vRS("Units").ToString())
            vSubject.LecHrs = vRS("LecHrs").ToString()
            vSubject.LabHrs = vRS("LabHrs").ToString()
            vSubject.MaxSlots = vRS("MaxSize").ToString()
            vSubject.MinSlots = vRS("MinSize").ToString()
            vSubject.LabUnits = vRS("LabUnits").ToString()

            vSubject.InActive = (vRS("InActive").ToString())
            vSubject.InclGWA = vRS("InclGWA").ToString()
            vSubject.SubjectWithInternet = vRS("SubjectWithInternet").ToString()
            vSubject.IsComputerSubject = vRS("IsCompSubject").ToString()
            vSubject.IsSubjectGE = vRS("IsSubjectGE").ToString()
            vSubject.IsSubjectElective = vRS("IsSubjectElective").ToString()
            vSubject.IsNonAcademic = vRS("IsNonAcademic").ToString()
            vSubject.IsSubjectMajor = vRS("IsMajorSubject").ToString()
            vSubject.IsOtherSchool = vRS("IsOtherSchool").ToString()
            vSubject.SubjectParentID = vRS("SubjParentID").ToString()
            vSubject.UseTransmutedGrade = vRS("IsTransmutedGrade").ToString()
            vSubject.IsClubOrganization = vRS("IsClubOrganization").ToString()
            vSubject.IsSubjectELearning = vRS("IsSubjectELearning").ToString()
            vSubject.IsSubjectMajor = vRS("IsMajorSubject").ToString()

            vSubject.SubjectAreaID = vRS("SubjectAreaID").ToString()
            vSubject.SubjectMode = vRS("SubjectMode").ToString()

            vSubject.CourseLevelID = (vRS("LevelID").ToString())

            GetSubjectByID = TranDBResult.Success

        Else
            GetSubjectByID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function GetSubjectBySubjectCode(ByVal sSubjectCode As String, ByRef vSubject As tSubject) As TranDBResult
        'On Error Resume Next

        Dim com As New MySqlCommand("SELECT * From tblSubject WHERE (((tblSubject.SubjectCode)='" & sSubjectCode & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            vSubject.SubjectID = (vRS("Subjectid").ToString())
            vSubject.SubjectTitle = (vRS("Subjecttitle").ToString())
            vSubject.SubjectCode = vRS("SubjectCode").ToString()
            vSubject.Description = (vRS("Description").ToString())
            vSubject.Alias1 = vRS("AliasCode1").ToString()
            vSubject.Alias2 = vRS("AliasCode2").ToString()
            vSubject.CreditUnits = vRS("CreditUnits").ToString()
            vSubject.Units = (vRS("Units").ToString())
            vSubject.LabUnits = vRS("LabUnits").ToString()
            vSubject.LecHrs = vRS("LecHrs").ToString()
            vSubject.LabHrs = vRS("LabHrs").ToString()
            vSubject.MaxSlots = vRS("MaxSize").ToString()
            vSubject.MinSlots = vRS("MinSize").ToString()
            vSubject.IsSubjectMajor = vRS("IsMajorSubject").ToString()

            vSubject.InActive = (vRS("InActive").ToString())
            vSubject.InclGWA = vRS("InclGWA").ToString()
            vSubject.SubjectWithInternet = vRS("SubjectWithInternet").ToString()
            vSubject.IsComputerSubject = vRS("IsCompSubject").ToString()
            vSubject.IsSubjectGE = vRS("IsSubjectGE").ToString()
            vSubject.IsSubjectElective = vRS("IsSubjectElective").ToString()
            vSubject.IsNonAcademic = vRS("IsNonAcademic").ToString()
            vSubject.IsSubjectMajor = vRS("IsMajorSubject").ToString()
            vSubject.IsOtherSchool = vRS("IsOtherSchool").ToString()
            vSubject.SubjectParentID = vRS("SubjParentID").ToString()
            vSubject.UseTransmutedGrade = vRS("IsTransmutedGrade").ToString()
            vSubject.IsClubOrganization = vRS("IsClubOrganization").ToString()
            vSubject.IsSubjectELearning = vRS("IsSubjectELearning").ToString()

            vSubject.SubjectAreaID = vRS("SubjectAreaID").ToString()
            vSubject.SubjectMode = vRS("SubjectMode").ToString()

            vSubject.CourseLevelID = (vRS("LevelID").ToString())

            GetSubjectBySubjectCode = TranDBResult.Success

        Else
            GetSubjectBySubjectCode = TranDBResult.Failed
        End If
        vRS.Close()
    End Function
    Public Function GetSubjectByTitle(ByVal sSubjectTitle As String, ByRef vSubject As tSubject) As TranDBResult

        Dim com As New MySqlCommand("SELECT *  FROM tblSubject WHERE (((tblSubject.SubjectTitle)='" & sSubjectTitle & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            vSubject.SubjectID = (vRS("Subjectid").ToString())
            vSubject.SubjectTitle = (vRS("Subjecttitle").ToString())
            vSubject.SubjectCode = vRS("SubjectCode").ToString()
            vSubject.Description = (vRS("Description").ToString())
            vSubject.Alias1 = vRS("AliasCode1").ToString()
            vSubject.Alias2 = vRS("AliasCode2").ToString()
            vSubject.CreditUnits = vRS("CreditUnits").ToString()
            vSubject.Units = (vRS("Units").ToString())
            vSubject.LecHrs = vRS("LecHrs").ToString()
            vSubject.LabHrs = vRS("LabHrs").ToString()
            vSubject.MaxSlots = vRS("MaxSize").ToString()
            vSubject.MinSlots = vRS("MinSize").ToString()
            vSubject.LabUnits = vRS("LabUnits").ToString()
            vSubject.IsSubjectMajor = vRS("IsMajorSubject").ToString()

            vSubject.InActive = (vRS("InActive").ToString())
            vSubject.InclGWA = vRS("InclGWA").ToString()
            vSubject.SubjectWithInternet = vRS("SubjectWithInternet").ToString()
            vSubject.IsComputerSubject = vRS("IsCompSubject").ToString()
            vSubject.IsSubjectGE = vRS("IsSubjectGE").ToString()
            vSubject.IsSubjectElective = vRS("IsSubjectElective").ToString()
            vSubject.IsNonAcademic = vRS("IsNonAcademic").ToString()
            vSubject.IsSubjectMajor = vRS("IsMajorSubject").ToString()
            vSubject.IsOtherSchool = vRS("IsOtherSchool").ToString()
            vSubject.SubjectParentID = vRS("SubjParentID").ToString()
            vSubject.UseTransmutedGrade = vRS("IsTransmutedGrade").ToString()
            vSubject.IsClubOrganization = vRS("IsClubOrganization").ToString()

            vSubject.SubjectAreaID = vRS("SubjectAreaID").ToString()
            vSubject.SubjectMode = vRS("SubjectMode").ToString()

            vSubject.CourseLevelID = (vRS("LevelID").ToString())

            GetSubjectByTitle = TranDBResult.Success
        Else
            GetSubjectByTitle = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function GetSubjectModeByID(ByVal sSubjectModeID As String, ByRef vSubjectMode As tSubjectMode) As TranDBResult

        Dim com As New MySqlCommand("SELECT *  FROM tblSubjectMode WHERE (((tblSubjectMode.SubjectMode)='" & sSubjectModeID & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            vSubjectMode.SubjectMode = (vRS("SubjectMode").ToString())
            vSubjectMode.Description = (vRS("Description").ToString())
            vSubjectMode.ShortName = (vRS("ShortName").ToString())
            
            GetSubjectModeByID = TranDBResult.Success
        Else
            GetSubjectModeByID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function
    Public Function GetSubjectModeByShortName(ByVal sShortName As String, ByRef vSubjectMode As tSubjectMode) As TranDBResult

        Dim com As New MySqlCommand("SELECT *  FROM tblSubjectMode WHERE (((tblSubjectMode.ShortName)='" & sShortName & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            vSubjectMode.SubjectMode = (vRS("SubjectMode").ToString())
            vSubjectMode.Description = (vRS("Description").ToString())
            vSubjectMode.ShortName = (vRS("ShortName").ToString())

            GetSubjectModeByShortName = TranDBResult.Success
        Else
            GetSubjectModeByShortName = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function GetSubjectAreasByID(ByVal sSubjectAreasID As String, ByRef vSubjectArea As tSubjectAreas) As TranDBResult

        Dim com As New MySqlCommand("SELECT *  FROM tblSubjectAreas WHERE (((tblSubjectAreas.SubjectAreaID)='" & sSubjectAreasID & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            vSubjectArea.SubjectAreaID = (vRS("SubjectAreaID").ToString())
            vSubjectArea.SubjectAreaName = (vRS("SubjectAreaName").ToString())
            vSubjectArea.ShortName = (vRS("ShortName").ToString())

            GetSubjectAreasByID = TranDBResult.Success
        Else
            GetSubjectAreasByID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function GetSubjectAreasByShortName(ByVal sShortName As String, ByRef vSubjectArea As tSubjectAreas) As TranDBResult

        Dim com As New MySqlCommand("SELECT *  FROM tblSubjectAreas WHERE (((tblSubjectAreas.ShortName)='" & sShortName & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            vSubjectArea.SubjectAreaID = (vRS("SubjectAreaID").ToString())
            vSubjectArea.SubjectAreaName = (vRS("SubjectAreaName").ToString())
            vSubjectArea.ShortName = (vRS("ShortName").ToString())

            GetSubjectAreasByShortName = TranDBResult.Success
        Else
            GetSubjectAreasByShortName = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function ExecuteDeleteSubject(ByVal sSubjectID As String) As TranDBResult

        'check if record exist and if it is edited by other user
        If MsgBox("Are you sure to delete the selected subject?", vbQuestion + vbYesNo) = vbYes Then

            If DeleteSubject(sSubjectID) = TranDBResult.Success Then
                MsgBox("Subject entry and other related record succesfully deleted.", vbInformation)
                ExecuteDeleteSubject = TranDBResult.Success
            Else
                MsgBox("Deleting Subject entry went failed.", vbExclamation)
                ExecuteDeleteSubject = TranDBResult.Failed
            End If
        Else
            ExecuteDeleteSubject = TranDBResult.Failed
        End If
    End Function


    Public Function GetSubjectByDeptByYLCount(ByVal sDepartmentID As String, ByVal lYearLevelID As Integer, ByVal lSubjectCount As Long) As TranDBResult
        Dim sSQL As String

        'default
        GetSubjectByDeptByYLCount = TranDBResult.Failed
        sSQL = "SELECT Count(*) AS SubjectCount, tblSubject.DepartmentID, tblSubject.YearLevelID" & _
                " From tblSubject" & _
                " GROUP BY tblSubject.DepartmentID, tblSubject.YearLevelID" & _
                " HAVING (((tblSubject.DepartmentID)='" & sDepartmentID & "') AND ((tblSubject.YearLevelID)=" & lYearLevelID & "));"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            lSubjectCount = Convert.ToInt32(vRS("SubjectCount").ToString())
            GetSubjectByDeptByYLCount = TranDBResult.Success
        Else
            lSubjectCount = 0
            GetSubjectByDeptByYLCount = TranDBResult.Failed
        End If

        vRS.Close()
    End Function


    Public Function CreatetRSSubjectByDeptByYL(ByVal sDepartmentID As String, ByVal lYearLevelID As Integer) As TranDBResult

        'default
        CreatetRSSubjectByDeptByYL = TranDBResult.Failed

        Dim sSQL As String = "SELECT tblSubject.SubjectID" & _
                " From tblSubject" & _
                " Where (((tblSubject.DepartmentID) = '" & sDepartmentID & "') And ((tblSubject.YearLevelID) = " & lYearLevelID & "))" & _
                " GROUP BY tblSubject.SubjectID;"


        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            CreatetRSSubjectByDeptByYL = TranDBResult.Success
        Else
            CreatetRSSubjectByDeptByYL = TranDBResult.Failed
        End If
        vRS.Close()

    End Function

    Public Function GetNewSubjectID(ByRef sNewID As String) As TranDBResult
        Dim sSQL As String
        Dim NewDNumber As Long

        sSQL = "SELECT CONCAT(LEFT('0000000000',10-Length(Count(*)+1)),'',Count(*)+1) AS NewID FROM tblSubject;"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = False Then
            GetNewSubjectID = TranDBResult.Failed
            Exit Function
        Else
            sNewID = vRS("NewID").ToString()
        End If
        vRS.Close()

        While SubjectExistByID(sNewID) = TranDBResult.Success
            NewDNumber = Val(Right(sNewID, 10)) + 1
            sNewID = Left("0", 10) & NewDNumber
        End While

        GetNewSubjectID = TranDBResult.Success

    End Function

    Public Function GetNewSubjectAreasID(ByRef sNewID As String) As TranDBResult
        Dim sSQL As String
        Dim NewDNumber As Long

        sSQL = "SELECT CONCAT(LEFT('000000',6-Length(Count(*)+1)),'',Count(*)+1) AS NewID FROM tblSubjectAreas;"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = False Then
            GetNewSubjectAreasID = TranDBResult.Failed
            Exit Function
        Else
            sNewID = vRS("NewID").ToString()
        End If
        vRS.Close()

        While SubjectAreaExistByID(sNewID) = TranDBResult.Success
            NewDNumber = Val(Right(sNewID, 6)) + 1
            sNewID = "SA-" & StrDup(6 - Len(NewDNumber), "0") & NewDNumber
        End While

        GetNewSubjectAreasID = TranDBResult.Success

    End Function

    Public Function GetNewSubjectModeID(ByRef sNewID As String) As TranDBResult
        Dim sSQL As String
        Dim NewDNumber As Long

        sSQL = "SELECT CONCAT(LEFT('000000',6-Length(Count(*)+1)),'',Count(*)+1) AS NewID FROM tblSubjectMode;"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = False Then
            GetNewSubjectModeID = TranDBResult.Failed
            Exit Function
        Else
            sNewID = vRS("NewID").ToString()
        End If
        vRS.Close()

        While SubjectModeExistByID(sNewID) = TranDBResult.Success
            NewDNumber = Val(Right(sNewID, 6)) + 1
            sNewID = "SM-" & StrDup(6 - Len(NewDNumber), "0") & NewDNumber
        End While

        GetNewSubjectModeID = TranDBResult.Success

    End Function
End Module
