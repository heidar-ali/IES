Imports MySql.Data.MySqlClient
Module modRSSection
    Public Const keySection As String = "sect"

    Public Enum SectionState
        Program = 0
        Section = 1
        Offering = 2
    End Enum

    Public Structure tSection

        Dim SectionID As String
        Dim SectionTitle As String

        Dim CurriculumID As String
        Dim YearLevelID As Integer
        Dim TermID As Integer
        Dim CampusID As String
        Dim CollegeID As String
        Dim ProgramID As String
        Dim AdviserID As String

        Dim IsBlock As Short
        Dim RoomID As String
        Dim IsEvening As Short
        Dim Limit As Integer
        Dim IsDissolved As Short

        Dim CreationDate As Date
        Dim CreatedBy As String
        Dim ModifiedDate As Date
        Dim ModifiedBy As String
    End Structure

    Public Structure tFreeSection
        Dim SectionID As String
        Dim SectionTitle As String

        Dim TermID As Integer

        Dim CampusID As Integer
        Dim CollegeID As String
        Dim AdviserID As String
        Dim ProgramID As String
        Dim RoomID As String
        Dim IsBlock As Short
        Dim Limit As Integer

        Dim CreatedBy As String
        Dim CreationDate As Date
        Dim IsEvening As Short
        Dim IsDissolved As Short

    End Structure

    Public Function GetNewSectionID(ByRef sNewSectionID As String) As TranDBResult
        Dim sSQL As String
        Dim NewDNumber As Long


        'default
        GetNewSectionID = TranDBResult.Failed

        sSQL = "SELECT CONCAT('SEC-','',LEFT('0000000',6-Length(Count(*)+1)),'',Count(*)+1) AS NewID FROM tblSection;"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = False Then
            GetNewSectionID = TranDBResult.Failed
            Exit Function
        Else
            sNewSectionID = vRS("NewID").ToString()
        End If
        vRS.Close()

        While SectionExistByID(sNewSectionID) = TranDBResult.Success
            NewDNumber = Val(Right(sNewSectionID, 6)) + 1
            sNewSectionID = "SEC-" & StrDup(6 - Len(NewDNumber), "0") & NewDNumber
        End While

        GetNewSectionID = TranDBResult.Success
    End Function

    Public Function GetNewFreeSectionID(ByRef sNewSectionID As String) As TranDBResult
        Dim sSQL As String
        Dim NewDNumber As Long


        'default
        GetNewFreeSectionID = TranDBResult.Failed

        sSQL = "SELECT CONCAT('FSEC-','',LEFT('0000000',6-Length(Count(*)+1)),'',Count(*)+1) AS NewID FROM tblSection;"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = False Then
            GetNewFreeSectionID = TranDBResult.Failed
            Exit Function
        Else
            sNewSectionID = vRS("NewID").ToString()
        End If
        vRS.Close()

        While SectionExistByID(sNewSectionID) = TranDBResult.Success
            NewDNumber = Val(Right(sNewSectionID, 6)) + 1
            sNewSectionID = "FSEC-" & StrDup(6 - Len(NewDNumber), "0") & NewDNumber
        End While

        GetNewFreeSectionID = TranDBResult.Success
    End Function

    Public Function AddSection(ByVal newSection As tSection) As TranDBResult


        'check each fields
        If Len(Trim(newSection.SectionID)) < 1 Then
            AddSection = TranDBResult.InvalidSectionSectionID
            GoTo ReleaseAndExit
        End If

        If Len(Trim(newSection.SectionTitle)) < 1 Then
            AddSection = TranDBResult.InvalidSectionSectionTitle
            GoTo ReleaseAndExit
        End If

        If CurriculumExistByID(newSection.CurriculumID) <> TranDBResult.Success Then
            AddSection = TranDBResult.InvalidSectionCurriculumID
            GoTo ReleaseAndExit
        End If

        If ProgramExistByID(newSection.ProgramID) <> TranDBResult.Success Then
            AddSection = TranDBResult.InvalidSectionProgramID
            GoTo ReleaseAndExit
        End If


        If YearLevelExistByID(newSection.YearLevelID) <> TranDBResult.Success Then
            AddSection = TranDBResult.InvalidSectionYearLevelID
            GoTo ReleaseAndExit
        End If

        'find duplicate TITLE
        If SectionExistByID(newSection.SectionID) = TranDBResult.Success Then
            AddSection = TranDBResult.DuplicateID
            GoTo ReleaseAndExit
        End If

        'find duplicate TITLE
        If SectionExistByTitle(newSection.SectionTitle) = TranDBResult.Success Then
            AddSection = TranDBResult.DuplicateTitle
            GoTo ReleaseAndExit
        End If

        Dim com As New MySqlCommand("INSERT INTO tblSection(SectionID,SectionTitle,CurriculumID,YearLevelID,TermID,CampusID,CollegeID,ProgramID,AdviserID,RoomID,IsBlock,`Limit`,IsDissolved,CreationDate,CreatedBy) VALUES ('" & _
                                    Trim(newSection.SectionID) & "','" & Trim(newSection.SectionTitle) & "','" & _
                                    Trim(newSection.CurriculumID) & "','" & newSection.YearLevelID & "','" & _
                                    newSection.TermID & "','" & newSection.CampusID & "','" & _
                                    newSection.CollegeID & "','" & newSection.ProgramID & "','" & newSection.AdviserID & "','" & newSection.RoomID & "','" & _
                                    newSection.IsBlock & "','" & newSection.Limit & "','" & _
                                    newSection.IsDissolved & "',@Date,@User)", clsCon.con)
        com.Parameters.Add("@Date", MySqlDbType.DateTime).Value = newSection.CreationDate
        com.Parameters.Add("@User", MySqlDbType.VarChar, 45).Value = newSection.CreatedBy
        com.ExecuteNonQuery()
        com.Parameters.Clear()

        AddSection = TranDBResult.Success

ReleaseAndExit:
        Exit Function
    End Function


    Public Function AddFreeSection(ByVal newSection As tFreeSection) As TranDBResult


        'check each fields
        If Len(Trim(newSection.SectionID)) < 1 Then
            AddFreeSection = TranDBResult.InvalidSectionSectionID
            GoTo ReleaseAndExit
        End If

        If Len(Trim(newSection.SectionTitle)) < 1 Then
            AddFreeSection = TranDBResult.InvalidSectionSectionTitle
            GoTo ReleaseAndExit
        End If

        If ProgramExistByID(newSection.ProgramID) <> TranDBResult.Success Then
            AddFreeSection = TranDBResult.InvalidSectionProgramID
            GoTo ReleaseAndExit
        End If

        'find duplicate TITLE
        If SectionExistByID(newSection.SectionID) = TranDBResult.Success Then
            AddFreeSection = TranDBResult.DuplicateID
            GoTo ReleaseAndExit
        End If

        'find duplicate TITLE
        If SectionExistByTitle(newSection.SectionTitle) = TranDBResult.Success Then
            AddFreeSection = TranDBResult.DuplicateTitle
            GoTo ReleaseAndExit
        End If

        Dim com As New MySqlCommand("INSERT INTO tblSection(SectionID,SectionTitle,TermID,CampusID,CollegeID,ProgramID,AdviserID,RoomID,IsBlock,`Limit`,IsDissolved,CreationDate,CreatedBy) VALUES ('" & _
                                    Trim(newSection.SectionID) & "','" & Trim(newSection.SectionTitle) & "','" & _
                                    newSection.TermID & "','" & newSection.CampusID & "','" & _
                                    newSection.CollegeID & "','" & newSection.ProgramID & "','" & newSection.AdviserID & "','" & newSection.RoomID & "','" & _
                                    newSection.IsBlock & "','" & newSection.Limit & "','" & _
                                    newSection.IsDissolved & "',@Date,@User)", clsCon.con)
        com.Parameters.Add("@Date", MySqlDbType.DateTime).Value = newSection.CreationDate
        com.Parameters.Add("@User", MySqlDbType.VarChar, 45).Value = newSection.CreatedBy
        com.ExecuteNonQuery()
        com.Parameters.Clear()

        AddFreeSection = TranDBResult.Success

ReleaseAndExit:
        Exit Function
    End Function


    Public Function EditSection(ByVal newSection As tSection) As TranDBResult

        Dim oldSection As tSection

        'get old section
        If GetSectionByID(newSection.SectionID, oldSection) = TranDBResult.Success Then

            If oldSection.SectionTitle <> newSection.SectionTitle Then
                'find duplicate title
                If SectionExistByTitle(newSection.SectionTitle) = TranDBResult.Success Then
                    EditSection = TranDBResult.DuplicateTitle
                    'exit function
                    GoTo ReleaseAndExit
                End If

            End If
        Else
            'department not found
            'exit function
            EditSection = TranDBResult.InvalidID
            GoTo ReleaseAndExit
        End If


        'find record to edit


        Dim com As New MySqlCommand("UPDATE tblSection SET SectionTitle='" & Trim(newSection.SectionTitle) & _
                                    "',CurriculumID='" & Trim(newSection.CurriculumID) & _
                                    "',YearLevelID ='" & newSection.YearLevelID & _
                                    "',TermID='" & newSection.TermID & _
                                    "',CampusID,CollegeID ='" & newSection.CampusID & _
                                    "',ProgramID='" & newSection.CollegeID & _
                                    "',AdviserID='" & newSection.AdviserID & _
                                    "',RoomID='" & newSection.RoomID & _
                                    "',IsBlock='" & newSection.IsBlock & _
                                    "',Limit ='" & newSection.Limit & _
                                    "',IsEvening='" & newSection.IsEvening & _
                                    "',IsDissolved='" & newSection.IsDissolved & _
                                    "',ModifiedDate=@Date,ModifiedBy=@CurrentUser WHERE tblSection.SectionID='" & newSection.SectionID & "'", clsCon.con)

        com.ExecuteNonQuery()
        com.Parameters.Clear()

        EditSection = TranDBResult.Success


ReleaseAndExit:
        'release
        Exit Function
    End Function


    Public Function DissolvedSection(ByVal sSectionID As String) As TranDBResult
        Try
            Dim com As New MySqlCommand("UPDATE tblSection SET IsDissolved = 1 WHERE (((tblSection.SectionID)='" & sSectionID & "'));", clsCon.con)
            com.ExecuteNonQuery()
            DissolvedSection = TranDBResult.Success
        Catch ex As Exception
            DissolvedSection = TranDBResult.Failed
        End Try
    End Function

    Public Function DeleteSection(ByVal sSectionID As String) As TranDBResult
        Try
            Dim com As New MySqlCommand("DELETE FROM tblSection WHERE SectionID ='" & sSectionID & "'", con)
            com.ExecuteNonQuery()
            DeleteSection = TranDBResult.Success
        Catch ex As Exception
            DeleteSection = TranDBResult.Failed
        End Try
    End Function


    Public Function GetSectionByID(ByVal sSectionID As String, ByRef vSection As tSection) As TranDBResult
        'On Error Resume Next
        Dim com As New MySqlCommand("SELECT * From tblSection WHERE (((tblSection.SectionID)='" & sSectionID & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            vSection.SectionID = (vRS("sectionid").ToString())
            vSection.SectionTitle = (vRS("Sectiontitle").ToString())
            vSection.ProgramID = (vRS("ProgramID").ToString())
            vSection.YearLevelID = CInt(vRS("yearlevelid").ToString())
            vSection.CampusID = vRS("CampusID").ToString()
            vSection.CollegeID = vRS("CollegeID").ToString()
            vSection.CurriculumID = vRS("CurriculumID").ToString()
            vSection.IsBlock = vRS("IsBlock").ToString()
            vSection.Limit = vRS("Limit").ToString()
            vSection.IsDissolved = vRS("IsEvening").ToString()
            vSection.AdviserID = vRS("AdviserID").ToString()
            vSection.RoomID = vRS("RoomID").ToString()
            vSection.TermID = vRS("TermID").ToString()
            vSection.CreationDate = CDate(vRS("CreationDate").ToString())
            vSection.CreatedBy = (vRS("CreatedBy").ToString())
            vSection.ModifiedDate = CDate(vRS("ModifiedDate").ToString())
            vSection.ModifiedBy = (vRS("ModifiedBy").ToString())

            GetSectionByID = TranDBResult.Success
        Else

            'FAILED: record does not exist
            GetSectionByID = TranDBResult.Failed
        End If

        vRS.Close()
    End Function
    Public Function GetSectionByTitle(ByVal sSectionTitle As String, ByRef vSection As tSection) As TranDBResult

        Dim com As New MySqlCommand("SELECT *  FROM tblSection WHERE (((tblSection.SectionTitle)='" & sSectionTitle & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then

            vSection.SectionID = (vRS("sectionid").ToString())
            vSection.SectionTitle = (vRS("Sectiontitle").ToString())
            vSection.ProgramID = (vRS("ProgramID").ToString())
            vSection.YearLevelID = CInt(vRS("yearlevelid").ToString())
            vSection.TermID = vRS("TermID").ToString()
            vSection.CollegeID = vRS("CollegeID").ToString()
            vSection.CreationDate = CDate(vRS("CreationDate").ToString())
            vSection.CreatedBy = (vRS("CreatedBy").ToString())
            vSection.CampusID = vRS("CampusID").ToString()


            'return success
            GetSectionByTitle = TranDBResult.Success

        Else
            'return failed
            GetSectionByTitle = TranDBResult.Failed
        End If

        vRS.Close()
    End Function

    Public Function GetSectionByFullTitle(ByVal sSectionFullTitle As String, ByRef vSection As tSection) As TranDBResult
        Dim splitsSectionFullTitle() As String
        Dim sSectionTitle As String


        On Error GoTo ErrFound


        splitsSectionFullTitle = Split(sSectionFullTitle, " - ")
        sSectionTitle = Trim(splitsSectionFullTitle(1))

        Dim com As New MySqlCommand("SELECT *  FROM tblSection WHERE (((tblSection.SectionTitle)='" & sSectionTitle & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then

            vSection.SectionID = (vRS("sectionid").ToString())
            vSection.SectionTitle = (vRS("Sectiontitle").ToString())
            vSection.ProgramID = (vRS("ProgramID").ToString())
            vSection.YearLevelID = CInt(vRS("yearlevelid").ToString())
            vSection.TermID = vRS("TermID").ToString()
            vSection.CreationDate = CDate(vRS("CreationDate").ToString())
            vSection.CreatedBy = (vRS("CreatedBy").ToString())

            GetSectionByFullTitle = TranDBResult.Success

        Else
            'return failed
            GetSectionByFullTitle = TranDBResult.Failed
        End If

        vRS.close()
        Exit Function

ErrFound:
        Exit Function
        vRS.Close()
        GetSectionByFullTitle = TranDBResult.Failed
    End Function


    Public Function SectionExistByID(ByVal sSectionID As String) As TranDBResult

        Dim com As New MySqlCommand("SELECT * From tblSection WHERE (((tblSection.SectionID)='" & sSectionID & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            SectionExistByID = TranDBResult.Success
        Else
            SectionExistByID = TranDBResult.Failed
        End If

        vRS.Close()
    End Function

    Public Function SectionExistByTitle(ByVal sSectionTitle As String) As TranDBResult

        Dim com As New MySqlCommand("SELECT * From tblSection WHERE (((tblSection.SectionTitle)='" & sSectionTitle & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            SectionExistByTitle = TranDBResult.Success
        Else
            SectionExistByTitle = TranDBResult.Failed
        End If

        vRS.Close()
    End Function
    Public Function SectionExistByFullTitle(ByVal sSectionFullTitle As String) As TranDBResult
        Dim splitsSectionFullTitle() As String
        Dim sSectionTitle As String


        On Error GoTo ErrFound

        splitsSectionFullTitle = Split(sSectionFullTitle, " - ")
        sSectionTitle = splitsSectionFullTitle(1)

        Dim com As New MySqlCommand("SELECT * From tblSection WHERE (((tblSection.SectionTitle)='" & sSectionTitle & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        If vRS.HasRows Then
            SectionExistByFullTitle = TranDBResult.Success
        Else
            SectionExistByFullTitle = TranDBResult.Failed
        End If

        vRS.Close()
        Exit Function

ErrFound:
        Exit Function
        SectionExistByFullTitle = TranDBResult.Failed
    End Function


    Public Function SectionRecordExist() As TranDBResult

        Dim com As New MySqlCommand("SELECT * FROM tblSection", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            SectionRecordExist = TranDBResult.Success
        Else
            SectionRecordExist = TranDBResult.Failed
        End If
        vRS.Close()
    End Function


    Public Function ExecuteDeleteSection(ByVal sSectionID As String) As TranDBResult

        'check if record exist and if it is edited by other user
        If MsgBox("WARNING:" & vbNewLine & _
            "Dissolving this SECTION entry will affect all other record" & vbNewLine & vbNewLine & _
            "Delete this record anyway?", vbQuestion + vbYesNo) = vbYes Then

            If DeleteSection(sSectionID) = TranDBResult.Success Then
                MsgBox("SECTION entry and other related record succesfully deleted.", vbInformation)
                ExecuteDeleteSection = TranDBResult.Success
            Else
                MsgBox("Deleting SECTION entry went failed.", vbExclamation)
                ExecuteDeleteSection = TranDBResult.Failed
            End If
        Else
            ExecuteDeleteSection = TranDBResult.Failed
        End If
    End Function



    Public Function GetSectionFullTitle(ByVal sSectionID As String, ByRef sFullTitle As String) As TranDBResult
        Dim sSQL As String

        sSQL = "SELECT CONCAT(`tblYearLevel`.`YearLevelTitle` , ' - ' , `tblSection`.`SectionTitle`) AS Title" & _
                " FROM tblYearLevel INNER JOIN tblSection ON tblYearLevel.YearLevelID = tblSection.YearLevelID" & _
                " Where(((tblSection.SectionID) = '" & sSectionID & "'))"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            sFullTitle = vRS("Title").ToString()
            GetSectionFullTitle = TranDBResult.Success
        Else
            GetSectionFullTitle = TranDBResult.Failed
        End If

        vRS.Close()
    End Function

    Public Function RenameClassSection(ByVal NewName As String, SectionID As String) As TranDBResult

        If SectionExistByID(SectionID) <> TranDBResult.Success Then
            RenameClassSection = TranDBResult.NoRecordExist
            Exit Function
        End If

        Dim com As New MySqlCommand("UPDATE tblSection SET SectionTitle='" & NewName & "' WHERE SectionID='" & SectionID & "'", con)
        com.ExecuteNonQuery()

        RenameClassSection = TranDBResult.Success
    End Function

    Public Function CheckEnrolledStudentBySection(ByVal sSectionID As String, ByVal TermID As String, ByVal CampusID As String) As Boolean
        Dim com As New MySqlCommand("SELECT COUNT(*) FROM tblEnrolment WHERE SectionOfferingID IN (SELECT SectionID FROM tblSection WHERE SectionID='" & sSectionID & "') AND TermID ='" & TermID & "' AND CampusID='" & CampusID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            If CInt(vRS(0).ToString()) > 0 Then
                CheckEnrolledStudentBySection = True
            Else
                CheckEnrolledStudentBySection = False
            End If
        Else
            CheckEnrolledStudentBySection = False
        End If
        vRS.Close()
    End Function

    Public Function AssignClassAddviserOnSection(ByVal EmpID As String, ByVal SectionID As String, ByVal CampusID As String) As TranDBResult
        Try
            Dim com As New MySqlCommand("UPDATE tblSection SET AdviserID='" & EmpID & "' WHERE SectionID='" & SectionID & "' AND CampusID='" & CampusID & "'", con)
            com.ExecuteNonQuery()
            AssignClassAddviserOnSection = TranDBResult.Success
        Catch ex As Exception
            AssignClassAddviserOnSection = TranDBResult.Failed
        End Try

    End Function

End Module
