
Option Explicit On

Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Module modRSCurriculum

    Public Structure tCurriculum
        Dim CurriculumID As String
        Dim CurriculumCode As String
        Dim Description As String
        Dim Notes As String
        Dim IsLocked As Short
        Dim DateLocked As Date
        Dim CreatedBy As String
        Dim CreationDate As Date
        Dim ModifiedBy As String
        Dim ModifiedOn As Date

        Dim ProgramID As String
        Dim MajorID As String

    End Structure

    Public Structure tCurriculumDetails
        Dim ID As Integer
        Dim CurriculumID As String
        Dim YearTermID As Integer
        Dim SubjectID As String
        Dim YearStandingID As Integer
        Dim EquivalentSubjectID As String
    End Structure

    Public Function CurriculumExistByProgramID(ByVal sProgID As String) As TranDBResult

        Dim com As New MySqlCommand("SELECT * From tblCurriculum WHERE tblCurriculum.ProgramID='" & sProgID & "'", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            CurriculumExistByProgramID = TranDBResult.Success
        Else
            CurriculumExistByProgramID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function AddCurriculum(ByVal tCur As tCurriculum) As TranDBResult

        If CurriculumExistByID(tCur.CurriculumID) = TranDBResult.Success Then
            AddCurriculum = TranDBResult.DuplicateID
            Exit Function
        End If

        If CurriculumExistByCode(tCur.CurriculumCode) = TranDBResult.Success Then
            AddCurriculum = TranDBResult.DuplicateCode
            Exit Function
        End If

        Dim com As New MySqlCommand("INSERT INTO tblCurriculum(CurriculumID,CurriculumCode,Description,Notes,IsLocked,DateLocked,ProgramID,MajorID,CreationDate,CreatedBy) VALUES (@ID,@Code,@Desc,@Note,@IsLocked,@DateLocked,@ProgramID,@MajorID,@Date,@User)", clsCon.con)

        com.Parameters.Add("@ID", MySqlDbType.VarChar, 45).Value = tCur.CurriculumID
        com.Parameters.Add("@Code", MySqlDbType.VarChar, 45).Value = tCur.CurriculumCode
        com.Parameters.Add("@Desc", MySqlDbType.VarChar, 100).Value = tCur.Description
        com.Parameters.Add("@Note", MySqlDbType.VarChar, 200).Value = tCur.Notes
        com.Parameters.Add("@IsLocked", MySqlDbType.Int16).Value = tCur.IsLocked
        com.Parameters.Add("@DateLocked", MySqlDbType.Date).Value = tCur.DateLocked
        com.Parameters.Add("@ProgramID", MySqlDbType.VarChar, 45).Value = tCur.ProgramID
        com.Parameters.Add("@MajorID", MySqlDbType.VarChar, 45).Value = tCur.MajorID
        com.Parameters.Add("@Date", MySqlDbType.Date).Value = tCur.CreationDate
        com.Parameters.Add("@User", MySqlDbType.VarChar, 45).Value = tCur.CreatedBy

        com.ExecuteNonQuery()
        com.Parameters.Clear()

        AddCurriculum = TranDBResult.Success

    End Function

    Public Function AddCurriculumDetails(ByVal tCur As tCurriculumDetails) As TranDBResult

        If CurriculumSubjectExistByID(tCur.SubjectID, tCur.CurriculumID) = TranDBResult.Success Then
            AddCurriculumDetails = TranDBResult.DuplicateID
            Exit Function
        End If
        Dim com As New MySqlCommand("INSERT INTO tblCurriculumDetails(CurriculumID,YearTermID,SubjectID,YearStandingID,EquivalentSubjectID) VALUES (@CurriculumID,@TermID,@SubjectID,@StandingID,@Equal)", clsCon.con)

        com.Parameters.Add("@CurriculumID", MySqlDbType.VarChar, 45).Value = tCur.CurriculumID
        com.Parameters.Add("@TermID", MySqlDbType.Int32, 11).Value = tCur.YearTermID
        com.Parameters.Add("@SubjectID", MySqlDbType.VarChar, 45).Value = tCur.SubjectID
        com.Parameters.Add("@StandingID", MySqlDbType.Int32, 11).Value = tCur.YearStandingID
        com.Parameters.Add("@Equal", MySqlDbType.VarChar, 45).Value = tCur.EquivalentSubjectID

        com.ExecuteNonQuery()
        com.Parameters.Clear()

        AddCurriculumDetails = TranDBResult.Success

    End Function


    Public Function EditCurriculum(ByVal tCur As tCurriculum) As TranDBResult

        Dim com As New MySqlCommand("UPDATE tblCurriculum SET CurriculumID=@ID,CurriculumCode=@Code,Description=@Desc,Notes=@Note,IsLocked=@IsLocked,DateLocked=@DateLocked,DepartmentID=@DepartmentID,CreationDate=@Date,CreatedBy=@User WHERE CurriculumID='" & tCur.CurriculumID & "'", clsCon.con)

        com.Parameters.Add("@ID", MySqlDbType.VarChar, 45).Value = tCur.CurriculumID
        com.Parameters.Add("@Code", MySqlDbType.VarChar, 45).Value = tCur.CurriculumCode
        com.Parameters.Add("@Desc", MySqlDbType.VarChar, 100).Value = tCur.Description
        com.Parameters.Add("@Note", MySqlDbType.VarChar, 200).Value = tCur.Notes
        com.Parameters.Add("@IsLocked", MySqlDbType.Int16).Value = tCur.IsLocked
        com.Parameters.Add("@DateLocked", MySqlDbType.Date).Value = tCur.DateLocked
        com.Parameters.Add("@DepartmentID", MySqlDbType.VarChar, 45).Value = tCur.ProgramID
        com.Parameters.Add("@Date", MySqlDbType.Date).Value = tCur.CreationDate
        com.Parameters.Add("@User", MySqlDbType.VarChar, 45).Value = tCur.CreatedBy

        com.ExecuteNonQuery()
        com.Parameters.Clear()

        EditCurriculum = TranDBResult.Success

    End Function

    Public Function CurriculumRecordExist() As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblCurriculum", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            CurriculumRecordExist = TranDBResult.Success
        Else
            CurriculumRecordExist = TranDBResult.Failed
        End If
        vRS.Close()
    End Function
    Public Function CurriculumExistByCode(ByVal sCode As String) As TranDBResult

        Dim com As New MySqlCommand("SELECT * From tblCurriculum WHERE tblCurriculum.CurriculumCode='" & sCode & "'", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            CurriculumExistByCode = TranDBResult.Success
        Else
            CurriculumExistByCode = TranDBResult.Failed
        End If
        vRS.Close()
    End Function


    Public Function CurriculumExistByID(ByVal sID As String) As TranDBResult

        Dim com As New MySqlCommand("SELECT * From tblCurriculum WHERE (((tblCurriculum.CurriculumID)='" & sID & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            CurriculumExistByID = TranDBResult.Success
        Else
            CurriculumExistByID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function CurriculumSubjectExistByID(ByVal sSubjectID As String, ByVal sCurriculumID As String) As TranDBResult

        Dim com As New MySqlCommand("SELECT * From tblCurriculumDetails WHERE tblCurriculumDetails.SubjectID='" & sSubjectID & "' AND tblCurriculumDetails.CurriculumID='" & sCurriculumID & "'", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            CurriculumSubjectExistByID = TranDBResult.Success
        Else
            CurriculumSubjectExistByID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function


    Public Function GetCurriculumByID(ByVal sID As String, ByRef vCur As tCurriculum) As TranDBResult

        Dim com As New MySqlCommand("SELECT *  FROM tblCurriculum WHERE (((tblCurriculum.CurriculumID)='" & sID & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            vCur.CurriculumID = (vRS("CurriculumID").ToString())
            vCur.Description = (vRS("Description").ToString())
            vCur.CurriculumCode = (vRS("CurriculumCode").ToString())
            vCur.Notes = vRS("Notes").ToString()
            vCur.DateLocked = vRS("DateLocked").ToString()
            vCur.CreatedBy = vRS("CreatedBy").ToString()
            vCur.CreationDate = vRS("CreationDate").ToString()

            vCur.ProgramID = vRS("ProgramID").ToString()
            vCur.MajorID = vRS("MajorID").ToString()

            GetCurriculumByID = TranDBResult.Success
        Else
            GetCurriculumByID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function GetCurriculumByCode(ByVal sCode As String, ByRef vCur As tCurriculum) As TranDBResult

        Dim com As New MySqlCommand("SELECT *  FROM tblCurriculum WHERE (((tblCurriculum.CurriculumCode)='" & sCode & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            vCur.CurriculumID = (vRS("CurriculumID").ToString())
            vCur.Description = (vRS("Desc").ToString())
            vCur.CurriculumCode = (vRS("CurriculumCode").ToString())
            vCur.Notes = vRS("Notes").ToString()
            vCur.DateLocked = vRS("DateLocked").ToString()
            vCur.CreatedBy = vRS("CreatedBy").ToString()
            vCur.CreationDate = vRS("CreationDate").ToString()

            vCur.ProgramID = vRS("ProgramID").ToString()
            vCur.MajorID = vRS("MajorID").ToString()

            GetCurriculumByCode = TranDBResult.Success
        Else
            GetCurriculumByCode = TranDBResult.Failed
        End If
        vRS.Close()
    End Function


    Public Function ExecuteDeleteCurriculumSubject(ByVal sSubjectID As String, ByVal CurriculumID As String, ByVal sSubjectTitle As String) As TranDBResult

        'check if record exist and if it is edited by other user
        If MsgBox("Are you sure you want to delete the selected subject?" & vbNewLine & vbNewLine & _
            sSubjectTitle, vbQuestion + vbYesNo, Application.ProductName) = vbYes Then

            If DeleteCurriculumSubject(sSubjectID, CurriculumID) = TranDBResult.Success Then
                MsgBox("SUBJECT ON CURRICULUM entry and other related record succesfully deleted.", vbInformation)
                ExecuteDeleteCurriculumSubject = TranDBResult.Success
            Else
                MsgBox("Deleting SUBJECT ON CURRICULUM entry went failed.", vbExclamation)
                ExecuteDeleteCurriculumSubject = TranDBResult.Failed
            End If
        End If
    End Function

    Public Function DeleteCurriculumSubject(ByVal sSubjectID As String, ByVal CurriculumID As String) As TranDBResult
        Dim lEnrolmentCount As Long

        'default
        DeleteCurriculumSubject = TranDBResult.Failed

        ''check
        'If GetEnrolmentCountBySubject(sSubjectID, lEnrolmentCount) = TranDBResult.Success Then
        '    If lEnrolmentCount > 0 Then
        '        If ShowMessage = True Then
        '            'temp
        '            MsgBox("temp: show is already used", vbExclamation)
        '        End If

        '        DeleteSubject = TranDBResult.Failed
        '        Exit Function
        '    End If
        'Else
        '    'subject entry not exist
        '    CatchError("frmAllSubject", "listRecord_DblClick", "GetEnrolmentCountBySubject(lvKey, lEnrolmentCount) = success")
        '    Exit Function
        'End If


        '----------------------------------------------------
        'delete
        '----------------------------------------------------
        Dim com As New MySqlCommand("Delete From tblCurriculumDetails WHERE SubjectID='" & sSubjectID & "' AND CurriculumID='" & CurriculumID & "'", clsCon.con)
        com.ExecuteNonQuery()
        DeleteCurriculumSubject = TranDBResult.Success

    End Function

    Public Function ExecuteDeleteCurriculum(ByVal sCurriculumCode As String) As TranDBResult

        'check if record exist and if it is edited by other user
        If MsgBox("WARNING:" & vbNewLine & _
            "Deleting this CURRICULUM entry will affect all other record" & vbNewLine & vbNewLine & _
            "Delete this record anyway?", vbQuestion + vbYesNo, Application.ProductName) = vbYes Then

            'If DeleteDepartment(sDepartmentID) = TranDBResult.Success Then
            'MsgBox("DEPARTMENT entry and other related record succesfully deleted.", vbInformation)
            'ExecuteDeleteCurriculumSubject = TranDBResult.Success
            'Else
            'MsgBox("Deleting DEPARTMENT entry went failed.", vbExclamation)
            'ExecuteDeleteCurriculumSubject = TranDBResult.Failed

            'Else
            'ExecuteDeleteCurriculumSubject = TranDBResult.Failed
            'End If
        End If
    End Function

    Public Function GetNewCurriculumID(ByRef sNewID As String) As TranDBResult
        Dim sSQL As String
        Dim NewDNumber As Long

        sSQL = "SELECT CONCAT('C-' ,'',LEFT('000000',6-Length(Count(*)+1)),'',Count(*)+1) AS NewID FROM tblCurriculum;"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = False Then
            GetNewCurriculumID = TranDBResult.Failed
            Exit Function
        Else
            sNewID = vRS("NewID").ToString()
        End If
        vRS.Close()

        While SubjectExistByID(sNewID) = TranDBResult.Success
            NewDNumber = Val(Right(sNewID, 6)) + 1
            sNewID = "C-" & StrDup(6 - Len(NewDNumber), "0") & NewDNumber
        End While

        GetNewCurriculumID = TranDBResult.Success

    End Function

    Public Function GetNewCurriculumDetailsID(ByRef sNewID As String) As TranDBResult
        Dim sSQL As String
        Dim NewDNumber As Long

        sSQL = "SELECT CONCAT(LEFT('0000000000',10-Length(Count(*)+1)),'',Count(*)+1) AS NewID FROM tblCurriculumDetails;"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = False Then
            GetNewCurriculumDetailsID = TranDBResult.Failed
            Exit Function
        Else
            sNewID = vRS("NewID").ToString()
        End If
        vRS.Close()

        While CurriculumExistByID(sNewID) = TranDBResult.Success
            NewDNumber = Val(Right(sNewID, 10)) + 1
            sNewID = StrDup(10 - Len(NewDNumber), "0") & NewDNumber
        End While

        GetNewCurriculumDetailsID = TranDBResult.Success

    End Function
End Module
