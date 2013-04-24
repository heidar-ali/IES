'==========================================================================================
'Filename:      modDBAcademicProgramMajors.vb
'Type:          MODULE
'Date:          03.JUNE.2012
'Notice:        ©2012 i4Link Systems, Inc. All rights reserved.
'
'Purpose:       Academic Programs,Major Disciplines, Major Discipline Group

'Programmer:        Philip Cesar B. Garay
'===========================================================================================

Option Explicit On

Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Module modDBAcademicProgramsMajors

    Public Const keyPrograms = "prog"

    '===================== DECLARATION ============================

    Public Structure tProgramSemester
        Dim SemestralCode As Integer
        Dim SemestralDesc As String
        Dim NoOfTerm As Integer
        Dim InActive As Short
    End Structure


    Public Structure tAcademicPrograms
        Dim ProgID As Integer
        Dim CampusID As String
        Dim CollegeID As String
        Dim ProgramCode As String
        Dim ProgramName As String
        Dim ShortName As String
        Dim ProgramYears As Integer
        Dim ProgramSemester As Integer
        Dim MaxResidency As Integer
        Dim TotalAcadSubject As Integer
        Dim TotalCreditUnits As Integer
        Dim TotalNormalLoad As Integer
        Dim TotalGenEdUnits As Integer
        Dim TotalMajorUnits As Integer
        Dim TotalElectiveUnits As Integer
        Dim TotalLectureUnits As Integer
        Dim TotalNonLecUnits As Integer
        Dim Classification As Integer
        Dim ProgDiscipline As Integer
        Dim ProgRecognize As Date
        Dim ProgRevise As Date
        Dim ProgStatus As Short
        Dim IsProgLadder As Integer
        Dim ProgParent As String
        Dim BoardExam As String
        Dim ThesisReqID As Integer
        Dim Semestral As Short
        Dim ProgChairID As Integer
        Dim MajorDiscGroupCode As Integer
        Dim Accreditation As String
        Dim NumberCode As String
        Dim Weight As String
        Dim Alias1 As String
        Dim SortOrder As Integer
        Dim Remarks As String
    End Structure

    Public Structure tProgramMajors
        Dim ID As Integer
        Dim ProgID As String
        Dim MajorDiscID As String
        Dim InActive As Short
    End Structure

    Public Structure tMajors
        Dim MajorID As Integer
        Dim MajorDiscCode As String
        Dim MajorDescription As String
        Dim MajorGroup As Integer
    End Structure

    Public Structure tMajorGroups
        Dim GroupID As Integer
        Dim GroupCode As String
        Dim Description As String
    End Structure

    Public Structure tProgramClass
        Dim ClassCode As Integer
        Dim ClassDesc As String
        Dim ShortName As String
    End Structure

    Public Structure tProgramLadder
        Dim LadderCode As Integer
        Dim LadderDesc As String
    End Structure

    Public Structure tProgramBoardExam
        Dim BoardExamCode As Integer
        Dim BoardExamDesc As String
    End Structure

    Public Structure tProgramStatus
        Dim StatusCode As Integer
        Dim StatusName As String
    End Structure
    Public Structure tProgramThesis
        Dim ThesisReqID As Integer
        Dim ThesisReqDesc As String
    End Structure


    '======================================================= ACADEMIC PROGRAMS STORED FUNCTIONS AND PROCEDURE ======================================

    Public Function ExecuteDeleteAcademicProgram(ByVal sProgramID As String) As TranDBResult

        'check if record exist and if it is edited by other user
        If MsgBox("WARNING:" & vbNewLine & _
            "Deleting this ACADEMIC PROGRAM entry will affect all other record" & vbNewLine & vbNewLine & _
            "Delete this record anyway?", vbQuestion + vbYesNo, Application.ProductName) = vbYes Then


            'TODO --> Check if there are students currently enrolled in this program base on current Academic Year and Sem.


            If DeleteAcademicProgram(sProgramID) = TranDBResult.Success Then
                MsgBox("ACADEMIC PROGRAM entry and other related record succesfully deleted.", vbInformation)
                ExecuteDeleteAcademicProgram = TranDBResult.Success
            Else
                MsgBox("Deleting ACADEMIC PROGRAM entry went failed.", vbExclamation)
                ExecuteDeleteAcademicProgram = TranDBResult.Failed
            End If
        Else
            ExecuteDeleteAcademicProgram = TranDBResult.Failed
        End If
    End Function

    Public Function DeleteAcademicProgram(ByVal sProgramID As String) As TranDBResult
        DeleteAcademicProgram = TranDBResult.Failed

        Dim com As New MySqlCommand("Delete From tblPrograms WHERE (((tblPrograms.ProgID)='" & sProgramID & "'));", clsCon.con)
        com.ExecuteNonQuery()
        DeleteAcademicProgram = TranDBResult.Success

    End Function

    Public Function AddAcademicProgram(ByVal newProg As tAcademicPrograms) As TranDBResult
        'find duplicate ID

        If ProgramExistByID(newProg.ProgID) = TranDBResult.Success Then
            AddAcademicProgram = TranDBResult.DuplicateID
            GoTo ReleaseAndExit
        End If

        'find duplicate CODE base on Campus
        If ProgramExistByCode(newProg.ProgramCode, newProg.CampusID) = TranDBResult.Success Then
            AddAcademicProgram = TranDBResult.DuplicateCode
            GoTo ReleaseAndExit
        End If

        Dim com As New MySqlCommand("INSERT INTO tblPrograms(ProgID,CampusID,CollegeID,ProgCode,ProgName,ProgShortName,ProgYears,ProgSems,ProgDiscipline,MaxResidency,TotalAcadSubject,TotalAcadCreditUnits,TotalGenEdUnits," & _
                                    "TotalMajorUnits,TotalElectiveUnits,TotalLectureUnits,TotalNonLectUnits,ProgRecognize,ProgRevise,ProgClass,ProgStatus,ProgLadder,ProgParent,BoardExam,ThesisReqID,MajorDiscGroupCode,Weight,Alias,Semestral,ProgChairID,SortOrder) VALUES " & _
                                    "('" & newProg.ProgID & "','" & _
                                    newProg.CampusID & "','" & _
                                    newProg.CollegeID & "','" & _
                                    newProg.ProgramCode & "','" & _
                                    newProg.ProgramName & "','" & _
                                    newProg.ShortName & "','" & _
                                    newProg.ProgramYears & "','" & _
                                    newProg.ProgramSemester & "','" & _
                                    newProg.ProgDiscipline & "','" & _
                                    newProg.MaxResidency & "','" & _
                                    newProg.TotalAcadSubject & "','" & _
                                    newProg.TotalCreditUnits & "','" & _
                                    newProg.TotalGenEdUnits & "','" & _
                                    newProg.TotalMajorUnits & "','" & _
                                    newProg.TotalElectiveUnits & "','" & _
                                    newProg.TotalLectureUnits & "','" & _
                                    newProg.TotalNonLecUnits & "',@Recognize, @Revise,'" & _
                                    newProg.Classification & "','" & _
                                    newProg.ProgStatus & "','" & _
                                    newProg.IsProgLadder & "','" & _
                                    newProg.ProgParent & "','" & _
                                    newProg.BoardExam & "','" & _
                                    newProg.ThesisReqID & "','" & _
                                    newProg.MajorDiscGroupCode & "','" & _
                                    newProg.Weight & "','" & _
                                    newProg.Alias1 & "','" & _
                                    newProg.Semestral & "','1','0')", clsCon.con)

        com.Parameters.Add("@Recognize", MySqlDbType.Date).Value = newProg.ProgRecognize
        com.Parameters.Add("@Revise", MySqlDbType.Date).Value = newProg.ProgRevise

        com.ExecuteNonQuery()
        com.Parameters.Clear()

        AddAcademicProgram = TranDBResult.Success


ReleaseAndExit:
        'release
        Exit Function
    End Function

    Public Function EditAcademicProgram(ByVal newProg As tAcademicPrograms) As TranDBResult
        'find duplicate ID
        On Error GoTo ReleaseAndExit

        If ProgramExistByID(newProg.ProgID) = TranDBResult.Success Then

            Dim com As New MySqlCommand("UPDATE tblPrograms SET CampusID ='" & newProg.CampusID & _
                                        "',CollegeID ='" & newProg.CollegeID & _
                                        "',ProgCode ='" & newProg.ProgramCode & _
                                        "',ProgName='" & newProg.ProgramName & _
                                        "',ProgShortName='" & newProg.ShortName & _
                                        "',ProgYears ='" & newProg.ProgramYears & _
                                        "',ProgSems = '" & newProg.ProgramSemester & _
                                        "',ProgDiscipline ='" & newProg.ProgDiscipline & _
                                        "',Semestral= '" & newProg.Semestral & _
                                        "',MaxResidency ='" & newProg.MaxResidency & _
                                        "',TotalAcadSubject='" & newProg.TotalAcadSubject & _
                                        "',TotalAcadCreditUnits = '" & newProg.TotalCreditUnits & _
                                        "',TotalMajorUnits='" & newProg.TotalMajorUnits & _
                                        "',TotalElectiveUnits ='" & newProg.TotalElectiveUnits & _
                                        "',TotalLectureUnits = '" & newProg.TotalLectureUnits & _
                                        "',TotalNonLectUnits ='" & newProg.TotalNonLecUnits & _
                                        "',ProgRecognize=@Recognize,ProgRevise=@Revise,ProgClass='" & newProg.Classification & _
                                        "',ProgStatus='" & newProg.ProgStatus & _
                                        "',ProgLadder ='" & newProg.IsProgLadder & _
                                        "',ProgParent = '" & newProg.ProgParent & _
                                        "',BoardExam ='" & newProg.BoardExam & _
                                        "',ThesisReqID ='" & newProg.ThesisReqID & _
                                        "',MajorDiscGroupCode='" & newProg.MajorDiscGroupCode & _
                                        "',Weight='" & newProg.Weight & _
                                        "',Alias='" & newProg.Alias1 & _
                                        "',ProgChairID='1'" & _
                                        " WHERE ProgID='" & newProg.ProgID & "'", clsCon.con)

            com.Parameters.Add("@Recognize", MySqlDbType.Date).Value = newProg.ProgRecognize
            com.Parameters.Add("@Revise", MySqlDbType.Date).Value = newProg.ProgRevise

            com.ExecuteNonQuery()
            com.Parameters.Clear()

            EditAcademicProgram = TranDBResult.Success

        End If
        Exit Function

ReleaseAndExit:
        'release
        EditAcademicProgram = TranDBResult.Failed
        DisplayErrorMsg("modDBAcademicProgramMajors", "EditAcademicProgram", Err.Number, Err.Description)
    End Function

    Public Function AddProgramMajors(ByVal newMajor As tProgramMajors) As TranDBResult

        Try
            Dim com As New MySqlCommand("INSERT INTO tblProgramMajors VALUES('" & newMajor.ProgID & "','" & _
                                   newMajor.MajorDiscID & "','" & _
                                   newMajor.InActive & "')", clsCon.con)
            com.ExecuteNonQuery()
            AddProgramMajors = TranDBResult.Success
        Catch ex As Exception
            AddProgramMajors = TranDBResult.Failed
        End Try

    End Function

    Public Function AddMajorDiscipline(ByVal newMajor As tMajors) As TranDBResult
        'find duplicate ID
        If MajorExistByID(newMajor.MajorID) = TranDBResult.Success Then
            AddMajorDiscipline = TranDBResult.DuplicateID
            GoTo ReleaseAndExit
        End If

        'find duplicate CODE
        If MajorExistByCode(newMajor.MajorDiscCode) = TranDBResult.Success Then
            AddMajorDiscipline = TranDBResult.DuplicateCode
            GoTo ReleaseAndExit
        End If

        Dim com As New MySqlCommand("INSERT INTO tblDisciplineMajors(ID,MajorDiscCode,MajorDescription,MajorGroup) VALUES ('" & _
                                    newMajor.MajorID & "','" & _
                                    newMajor.MajorDiscCode & "','" & _
                                    newMajor.MajorDescription & "','" & _
                                    newMajor.MajorGroup & "')", clsCon.con)
        com.ExecuteNonQuery()
        AddMajorDiscipline = TranDBResult.Success


ReleaseAndExit:
        'release
        Exit Function
    End Function

    Public Function EditMajorDiscipline(ByVal newMajor As tMajors) As TranDBResult
        'find duplicate ID
        If MajorExistByID(newMajor.MajorID) = TranDBResult.Success Then
            If MajorExistByCode(newMajor.MajorDiscCode) = TranDBResult.Success Then
                Dim com As New MySqlCommand("UPDATE tblDisciplineMajors SET ID='" & newMajor.MajorID & "',MajorDiscCode='" & newMajor.MajorDiscCode & _
                                            "', MajorDescription='" & newMajor.MajorDescription & "',MajorGroup='" & newMajor.MajorGroup & "' WHERE ID = '" & newMajor.MajorID & "'", clsCon.con)
                com.ExecuteNonQuery()
                EditMajorDiscipline = TranDBResult.Success
            End If
        End If

ReleaseAndExit:
        'release
        Exit Function
    End Function

    Public Function AddMajorGroup(ByVal newMajor As tMajorGroups) As TranDBResult
        'find duplicate ID
        If MajorGroupExistByID(newMajor.GroupID) = TranDBResult.Success Then
            AddMajorGroup = TranDBResult.DuplicateID
            GoTo ReleaseAndExit
        End If

        'find duplicate CODE
        If MajorGroupExistByCode(newMajor.GroupCode) = TranDBResult.Success Then
            AddMajorGroup = TranDBResult.DuplicateCode
            GoTo ReleaseAndExit
        End If

        Dim com As New MySqlCommand("INSERT INTO tblDisciplineMajorGroups(ID,MajorGroupCode,Description) VALUES ('" & _
                                    newMajor.GroupID & "','" & _
                                    newMajor.GroupCode & "','" & _
                                    newMajor.Description & "')", clsCon.con)
        com.ExecuteNonQuery()
        AddMajorGroup = TranDBResult.Success

ReleaseAndExit:
        'release
        Exit Function
    End Function

    Public Function EditMajorGroup(ByVal newMajor As tMajorGroups) As TranDBResult

        'find duplicate ID
        If MajorGroupExistByID(newMajor.GroupID) = TranDBResult.Success Then
            If MajorGroupExistByCode(newMajor.GroupCode) = TranDBResult.Success Then
                Dim com As New MySqlCommand("UPDATE tblDisciplineMajorGroups SET ID='" & newMajor.GroupID & "',MajorGroupCode='" & newMajor.GroupCode & "',Description='" & newMajor.Description & "' WHERE ID ='" & newMajor.GroupID & "'", clsCon.con)
                com.ExecuteNonQuery()
                EditMajorGroup = TranDBResult.Success
            End If
        End If

ReleaseAndExit:
        'release
        Exit Function
    End Function

    Public Function ProgramRecordExist(ByVal sCAmpusID) As TranDBResult
        'Dim com As New MySqlCommand("SELECT * FROM tblPrograms", clsCon.con)

        Dim PrimaryKey As String
        Dim com As New MySqlCommand("SELECT * FROM tblPrograms WHERE CampusID='" & sCAmpusID & "'", clsCon.con)

        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            ProgramRecordExist = TranDBResult.Success
        Else
            ProgramRecordExist = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function GetProgramByProgramID(ByVal ProgramID As String, ByRef Prog As tAcademicPrograms) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblPrograms WHERE ProgID='" & ProgramID & "'", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then

            Prog.ProgID = vRS("ProgID").ToString()
            Prog.CampusID = vRS("CampusID").ToString()
            Prog.CollegeID = vRS("CollegeID").ToString()
            Prog.ProgramCode = vRS("ProgCode").ToString()
            Prog.ProgramName = vRS("ProgName").ToString()
            Prog.ShortName = vRS("ProgShortName").ToString()
            Prog.ProgramYears = vRS("ProgYears").ToString()
            Prog.ProgramSemester = vRS("ProgSems").ToString()
            Prog.MaxResidency = vRS("MaxResidency").ToString()
            Prog.TotalAcadSubject = vRS("TotalAcadSubject").ToString()
            Prog.TotalCreditUnits = vRS("TotalAcadCreditUnits").ToString()
            Prog.TotalNormalLoad = vRS("TotalNormalLoad").ToString()
            Prog.TotalGenEdUnits = vRS("TotalGenEdUnits").ToString()
            Prog.TotalMajorUnits = vRS("TotalMajorUnits").ToString()
            Prog.TotalElectiveUnits = vRS("TotalElectiveUnits").ToString()
            Prog.TotalLectureUnits = vRS("TotalLectureUnits").ToString()
            Prog.TotalNonLecUnits = vRS("TotalNonLectUnits").ToString()
            Prog.ProgDiscipline = vRS("ProgDiscipline").ToString()
            Prog.Classification = vRS("ProgClass").ToString()
            Prog.ProgStatus = vRS("ProgStatus").ToString()
            Prog.IsProgLadder = vRS("ProgLadder").ToString()
            Prog.ProgParent = vRS("ProgParent").ToString()
            Prog.BoardExam = vRS("BoardExam").ToString()
            Prog.ThesisReqID = vRS("ThesisReqID").ToString()
            Prog.Semestral = vRS("Semestral").ToString()
            Prog.ProgChairID = vRS("ProgChairID").ToString()
            Prog.MajorDiscGroupCode = vRS("MajorDiscGroupCode").ToString()
            Prog.Accreditation = vRS("Accreditation").ToString()
            Prog.NumberCode = vRS("NumberCode").ToString()
            Prog.Weight = vRS("Weight").ToString()
            Prog.Alias1 = vRS("Alias").ToString()
            'Prog.SortOrder = vRS("SortOrder").ToString()
            Prog.Remarks = vRS("Remarks").ToString()

            GetProgramByProgramID = TranDBResult.Success
        Else
            GetProgramByProgramID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function GetProgramByProgramCode(ByVal ProgramCode As String, ByRef Prog As tAcademicPrograms) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblPrograms WHERE ProgCode='" & ProgramCode & "'", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            Prog.ProgID = vRS("ProgID").ToString()
            Prog.CampusID = vRS("CampusID").ToString()
            Prog.CollegeID = vRS("CollegeID").ToString()
            Prog.ProgramCode = vRS("ProgCode").ToString()
            Prog.ProgramName = vRS("ProgName").ToString()
            Prog.ShortName = vRS("ProgShortName").ToString()
            Prog.ProgramYears = vRS("ProgYears").ToString()
            Prog.ProgramSemester = vRS("ProgSems").ToString()
            Prog.MaxResidency = vRS("MaxResidency").ToString()
            Prog.TotalAcadSubject = vRS("TotalAcadSubject").ToString()
            Prog.TotalCreditUnits = vRS("TotalCreditUnits").ToString()
            Prog.TotalNormalLoad = vRS("TotalNormalLoad").ToString()
            Prog.TotalGenEdUnits = vRS("TotalGenEdUnits").ToString()
            Prog.TotalMajorUnits = vRS("TotalMajorUnits").ToString()
            Prog.TotalElectiveUnits = vRS("TotalElectiveUnits").ToString()
            Prog.TotalLectureUnits = vRS("TotalLectureUnits").ToString()
            Prog.TotalNonLecUnits = vRS("TotalNonLecUnits").ToString()
            Prog.ProgDiscipline = vRS("ProgDiscipline").ToString()
            Prog.Classification = vRS("ProgClass").ToString()
            Prog.ProgStatus = vRS("ProgStatus").ToString()
            Prog.IsProgLadder = vRS("ProgLadder").ToString()
            Prog.ProgParent = vRS("ProgParent").ToString()
            Prog.BoardExam = vRS("BoardExam").ToString()
            Prog.ThesisReqID = vRS("ThesisReqID").ToString()
            Prog.Semestral = vRS("Semestral").ToString()
            Prog.ProgChairID = vRS("ProgChair").ToString()
            Prog.MajorDiscGroupCode = vRS("MajorDiscGroupCode").ToString()
            Prog.Accreditation = vRS("Accreditation").ToString()
            Prog.NumberCode = vRS("NumberCode").ToString()
            Prog.Weight = vRS("Weight").ToString()
            Prog.Alias1 = vRS("Alias").ToString()
            Prog.SortOrder = vRS("SortOrder").ToString()
            Prog.Remarks = vRS("Remarks").ToString()

            GetProgramByProgramCode = TranDBResult.Success
        Else
            GetProgramByProgramCode = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function MajorRecordExist() As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblDisciplineMajors", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            MajorRecordExist = TranDBResult.Success
        Else
            MajorRecordExist = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function MajorGroupRecordExist() As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblDisciplineMajorGroups", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            MajorGroupRecordExist = TranDBResult.Success
        Else
            MajorGroupRecordExist = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function ProgramExistByID(ByVal sProgramID As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * From tblPrograms WHERE (((tblPrograms.ProgID)='" & sProgramID & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            ProgramExistByID = TranDBResult.Success
        Else
            ProgramExistByID = TranDBResult.Failed
        End If
        'release
        vRS.Close()
    End Function

    Public Function ProgramExistByCode(ByVal sProgramCode As String, ByVal sCampusID As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * From tblPrograms WHERE tblPrograms.ProgCode='" & sProgramCode & "' AND tblPrograms.CampusID ='" & sCampusID & "'", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            ProgramExistByCode = TranDBResult.Success
        Else
            ProgramExistByCode = TranDBResult.Failed
        End If
        'release
        vRS.Close()
    End Function

    Public Function GetProgramMajorsByProgramID(ByVal sProgID As String, ByRef vMajor As tMajors) As TranDBResult
        Dim com As New MySqlCommand("SELECT tblprograms.ProgID, tblprograms.ProgCode, tblprograms.ProgName, tblprograms.ProgShortName, tblprograms.ProgSems, tblprograms.ProgYears, tbldisciplinemajors.MajorDescription " & _
                                    "FROM tblprograms INNER JOIN   tblprogrammajors ON tblprograms.ProgID = tblprogrammajors.ProgID INNER JOIN tbldisciplinemajors ON tblprogrammajors.MajorDiscID = tbldisciplinemajors.ID " & _
                                    "WHERE tblPrograms.ProgID='" & sProgID & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then

            GetProgramMajorsByProgramID = TranDBResult.Success
        Else
            GetProgramMajorsByProgramID = TranDBResult.Failed
        End If
        'release
        vRS.Close()
    End Function

    Public Function GetProgramClass(ByVal ClassCode As String, ByRef vProgClass As tProgramClass) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblProgram_Class WHERE ClassCode='" & ClassCode & "'", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            vProgClass.ClassCode = vRS("ClassCode").ToString()
            vProgClass.ClassDesc = vRS("ClassDesc").ToString()
            vProgClass.ShortName = vRS("ShortName").ToString()
            GetProgramClass = TranDBResult.Success
        Else
            GetProgramClass = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function GetProgramLadder(ByVal LadderCode As String, ByRef vLadder As tProgramLadder) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblProgram_Ladder WHERE LadderCode='" & LadderCode & "'", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            vLadder.LadderCode = vRS("LadderCode").ToString()
            vLadder.LadderDesc = vRS("LadderDesc").ToString()
            GetProgramLadder = TranDBResult.Success
        Else
            GetProgramLadder = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function GetProgramSemestral(ByVal SemestralCode As String, ByRef vSem As tProgramSemester) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblProgram_Semestral WHERE SemestralCode ='" & SemestralCode & "'", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            vSem.InActive = vRS("InActive").ToString()
            vSem.NoOfTerm = vRS("NoOfTerm").ToString()
            vSem.SemestralCode = vRS("SemestralCode").ToString()
            vSem.SemestralDesc = vRS("SemestralDesc").ToString()

            GetProgramSemestral = TranDBResult.Success
        Else
            GetProgramSemestral = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function GetProgramBoardExam(ByVal BoardExamCode As String, ByRef vBoard As tProgramBoardExam) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblProgram_BoardExam WHERE BoardExamCode='" & BoardExamCode & "'", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            vBoard.BoardExamCode = vRS("BoardExamCode").ToString()
            vBoard.BoardExamDesc = vRS("BoardExamDesc").ToString()
            GetProgramBoardExam = TranDBResult.Success
        Else
            GetProgramBoardExam = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function GetProgramThesis(ByVal ThesisReqID As String, ByRef vThesis As tProgramThesis) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblProgram_ThesisReq WHERE ThesisReqID = '" & ThesisReqID & "'", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            vThesis.ThesisReqID = vRS("ThesisReqID").ToString()
            vThesis.ThesisReqDesc = vRS("ThesisReqDesc").ToString()
            GetProgramThesis = TranDBResult.Success
        Else
            GetProgramThesis = TranDBResult.Failed
        End If
        vRS.Close()
    End Function
    Public Function GetProgramStatus(ByVal StatusCode As String, ByRef vStat As tProgramStatus) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblProgram_Status WHERE StatusCode='" & StatusCode & "'", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            vStat.StatusCode = vRS("StatusCode").ToString()
            vStat.StatusName = vRS("StatusName").ToString()
            GetProgramStatus = TranDBResult.Success
        Else
            GetProgramStatus = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function MajorExistByID(ByVal sMajorID As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * From tblDisciplineMajors WHERE (((tblDisciplineMajors.ID)='" & sMajorID & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            MajorExistByID = TranDBResult.Success
        Else
            MajorExistByID = TranDBResult.Failed
        End If
        'release
        vRS.Close()
    End Function
    Public Function MajorExistByCode(ByVal sMajorCode As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * From tblDisciplineMajors WHERE (((tblDisciplineMajors.MajorDiscCode)='" & sMajorCode & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            MajorExistByCode = TranDBResult.Success
        Else
            MajorExistByCode = TranDBResult.Failed
        End If
        'release
        vRS.Close()
    End Function

    Public Function GetMajorByMajorID(ByVal sMajorID As String, ByRef vMajor As tMajors) As TranDBResult
        Dim com As New MySqlCommand("SELECT * From tblDisciplineMajors WHERE (((tblDisciplineMajors.ID)='" & sMajorID & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            vMajor.MajorID = vRS("ID").ToString()
            vMajor.MajorDiscCode = vRS("MajorDiscCode").ToString()
            vMajor.MajorDescription = vRS("MajorDescription").ToString()
            vMajor.MajorGroup = vRS("MajorGroup").ToString()

            GetMajorByMajorID = TranDBResult.Success
        Else
            GetMajorByMajorID = TranDBResult.Failed
        End If
        'release
        vRS.Close()
    End Function

    Public Function GetMajorByProgramID(ByVal sProgID As String, ByRef vMajor As tMajors) As TranDBResult
        Dim com As New MySqlCommand("SELECT * From tblDisciplineMajors WHERE (((tblDisciplineMajors.ProgID)='" & sProgID & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            vMajor.MajorID = vRS("ID").ToString()
            vMajor.MajorDiscCode = vRS("MajorDiscCode").ToString()
            vMajor.MajorDescription = vRS("MajorDescription").ToString()
            vMajor.MajorGroup = vRS("MajorGroup").ToString()

            GetMajorByProgramID = TranDBResult.Success
        Else
            GetMajorByProgramID = TranDBResult.Failed
        End If
        'release
        vRS.Close()
    End Function

    Public Function MajorGroupExistByCode(ByVal sMajorCode As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * From tblDisciplineMajorGroups WHERE (((tblDisciplineMajorGroups.MajorGroupCode)='" & sMajorCode & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            MajorGroupExistByCode = TranDBResult.Success
        Else
            MajorGroupExistByCode = TranDBResult.Failed
        End If
        'release
        vRS.Close()
    End Function

    Public Function MajorGroupExistByID(ByVal sMajorID As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * From tblDisciplineMajorGroups WHERE (((tblDisciplineMajorGroups.ID)='" & sMajorID & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            MajorGroupExistByID = TranDBResult.Success
        Else
            MajorGroupExistByID = TranDBResult.Failed
        End If
        'release
        vRS.Close()
    End Function

    Public Function MajorProgramExistByID(ByVal sProgramID As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * From tblProgramMajors WHERE (((tblProgramMajors.ID)='" & sProgramID & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            MajorProgramExistByID = TranDBResult.Success
        Else
            MajorProgramExistByID = TranDBResult.Failed
        End If
        'release
        vRS.Close()
    End Function

    Public Function GetMajorGroupByCode(ByVal MajorGroupCode As String, ByRef vGroup As tMajorGroups) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblDisciplineMajorGroups WHERE MajorGroupCode='" & MajorGroupCode & "'", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            vGroup.GroupID = vRS("ID").ToString()
            vGroup.GroupCode = vRS("MajorGroupCode").ToString()
            vGroup.Description = vRS("Description").ToString()

            GetMajorGroupByCode = TranDBResult.Success
        Else
            GetMajorGroupByCode = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function GetMajorGroupByID(ByVal MajorGroupID As String, ByRef vGroup As tMajorGroups) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblDisciplineMajorGroups WHERE ID='" & MajorGroupID & "'", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            vGroup.GroupID = vRS("ID").ToString()
            vGroup.GroupCode = vRS("MajorGroupCode").ToString()
            vGroup.Description = vRS("Description").ToString()

            GetMajorGroupByID = TranDBResult.Success
        Else
            GetMajorGroupByID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function GetNewProgramID(ByRef sNewProgramID As String) As TranDBResult
        Dim sSQL As String
        Dim NewDNumber As String

        GetNewProgramID = TranDBResult.Failed

        sSQL = "SELECT Count(*)+1 AS NewID FROM tblPrograms;"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = False Then
            GetNewProgramID = TranDBResult.Failed
            Exit Function
        Else
            sNewProgramID = vRS("NewID").ToString()
            GetNewProgramID = TranDBResult.Success
        End If
        vRS.Close()
        While ProgramExistByID(sNewProgramID) = TranDBResult.Success
            NewDNumber = Val(Right(sNewProgramID, 5)) + 1
            sNewProgramID = NewDNumber
        End While

    End Function

    Public Function GetNewMajorID(ByRef sNewProgramID As String) As TranDBResult
        Dim sSQL As String
        Dim NewDNumber As Integer

        GetNewMajorID = TranDBResult.Failed

        sSQL = "SELECT CONCAT(LEFT('0000',4-Length(Count(*)+1)),'',Count(*)+1) AS NewID FROM tblDisciplineMajors;"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = False Then
            GetNewMajorID = TranDBResult.Failed
            Exit Function
        Else
            sNewProgramID = vRS("NewID").ToString()
            GetNewMajorID = TranDBResult.Success
        End If
        vRS.Close()
        While MajorExistByID(sNewProgramID) = TranDBResult.Success
            NewDNumber = CInt(Right(sNewProgramID, 4)) + 1
            sNewProgramID = StrDup(4 - Len(NewDNumber), "0") & NewDNumber
        End While


    End Function

    Public Function GetNewMajorGroupID(ByRef sNewProgramID As String) As TranDBResult
        Dim sSQL As String
        Dim NewDNumber As Integer

        GetNewMajorGroupID = TranDBResult.Failed

        sSQL = "SELECT CONCAT(LEFT('0000',4-Length(Count(*)+1)),'',Count(*)+1) AS NewID FROM tblDisciplineMajorGroups;"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = False Then
            GetNewMajorGroupID = TranDBResult.Failed
            Exit Function
        Else
            sNewProgramID = vRS("NewID").ToString()
            GetNewMajorGroupID = TranDBResult.Success
        End If
        vRS.Close()
        While MajorGroupExistByID(sNewProgramID) = TranDBResult.Success
            NewDNumber = CInt(Right(sNewProgramID, 4)) + 1
            sNewProgramID = StrDup(4 - Len(NewDNumber), "0") & NewDNumber
        End While
    End Function

    Public Function GetNewProgramMajorID(ByRef sNewProgramID As String) As TranDBResult
        Dim sSQL As String
        Dim NewDNumber As Integer

        GetNewProgramMajorID = TranDBResult.Failed

        sSQL = "SELECT CONCAT(LEFT('0000000',7-Length(Count(*)+1)),'',Count(*)+1) AS NewID FROM tblProgramMajors;"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = False Then
            GetNewProgramMajorID = TranDBResult.Failed
            Exit Function
        Else
            sNewProgramID = vRS("NewID").ToString()
            GetNewProgramMajorID = TranDBResult.Success
        End If
        vRS.Close()

        While MajorGroupExistByID(sNewProgramID) = TranDBResult.Success
            NewDNumber = CInt(Right(sNewProgramID, 7)) + 1
            sNewProgramID = Left("0", 7) & NewDNumber
        End While
    End Function

    Public Function AcademicProgramMajorsExistByID(ByVal ProgID As String, ByVal MajorDiscID As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblprogrammajors WHERE ProgID='" & ProgID & "' AND MajorDiscID='" & MajorDiscID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            AcademicProgramMajorsExistByID = TranDBResult.Success
        Else
            AcademicProgramMajorsExistByID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

End Module
