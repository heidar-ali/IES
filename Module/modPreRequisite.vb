
Option Explicit On

Imports MySql.Data.MySqlClient

Module modPreRequisite

    Public Structure tPrerequisite
        Dim PrerequisiteID As Integer
        Dim CurriculumID_SubjectID As String
        Dim SubjectID As String
        Dim CurriculumID As String
        Dim Remarks As String
    End Structure

    Public Function CheckExistingPreRequisite(ByVal CurriculumSubjectID As String, ByVal YearTermID As Integer) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblCurriculumDetails WHERE SubjectID='" & CurriculumSubjectID & "' AND YearTermID='" & YearTermID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            CheckExistingPreRequisite = TranDBResult.Success
        Else
            CheckExistingPreRequisite = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function CheckSubjectPreRequisite(ByVal CurriculumSubjectID As String, CurriculumID As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblPrerequisite WHERE CurriculumSubjectID='" & CurriculumSubjectID & "' AND CurriculumID='" & CurriculumID & "' AND Remarks ='Pre'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            CheckSubjectPreRequisite = TranDBResult.Success
        Else
            CheckSubjectPreRequisite = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function CheckSubjectCoRequisite(ByVal CurriculumSubjectID As String, CurriculumID As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblPrerequisite WHERE CurriculumSubjectID='" & CurriculumSubjectID & "' AND CurriculumID='" & CurriculumID & "' AND Remarks ='Co'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            CheckSubjectCoRequisite = TranDBResult.Success
        Else
            CheckSubjectCoRequisite = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function CheckSubjectPreRequisiteBySubject(ByVal CurriculumSubjectID As String, CurriculumID As String, ByVal SubjectID As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblPrerequisite WHERE Curriculum_SubjectID='" & CurriculumSubjectID & "' AND CurriculumID='" & CurriculumID & "' AND SubjectID='" & SubjectID & "' AND Remarks ='Pre'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            CheckSubjectPreRequisiteBySubject = TranDBResult.Success
        Else
            CheckSubjectPreRequisiteBySubject = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function CheckSubjectCoRequisiteBySubject(ByVal CurriculumSubjectID As String, CurriculumID As String, ByVal SubjectID As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblPrerequisite WHERE Curriculum_SubjectID='" & CurriculumSubjectID & "' AND CurriculumID='" & CurriculumID & "' AND SubjectID='" & SubjectID & "' AND Remarks ='Co-Requisite'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            CheckSubjectCoRequisiteBySubject = TranDBResult.Success
        Else
            CheckSubjectCoRequisiteBySubject = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function CheckSubjectEquivalenceBySubject(ByVal CurriculumSubjectID As String, CurriculumID As String, ByVal SubjectID As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblPrerequisite WHERE Curriculum_SubjectID='" & CurriculumSubjectID & "' AND CurriculumID='" & CurriculumID & "' AND SubjectID='" & SubjectID & "' AND Remarks ='Equivalence'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            CheckSubjectEquivalenceBySubject = TranDBResult.Success
        Else
            CheckSubjectEquivalenceBySubject = TranDBResult.Failed
        End If
        vRS.Close()
    End Function



    '====================================== SUBJECT PRE-REQUISITE / CO-REQUISITE ==============================================

    Public Function SavePreRequisite(ByVal Pre As tPrerequisite) As TranDBResult

        If CheckSubjectPreRequisiteBySubject(Pre.CurriculumID_SubjectID, Pre.SubjectID, Pre.CurriculumID) = TranDBResult.Success Then
            SavePreRequisite = TranDBResult.DuplicateID
            Exit Function
        End If

        If CheckSubjectCoRequisiteBySubject(Pre.CurriculumID_SubjectID, Pre.SubjectID, Pre.CurriculumID) = TranDBResult.Success Then
            SavePreRequisite = TranDBResult.DuplicateCode
            Exit Function
        End If

        Dim com As New MySqlCommand("INSERT INTO tblPrerequisite(Curriculum_SubjectID,SubjectID,CurriculumID,Remarks) VALUES('" & Pre.CurriculumID_SubjectID & "','" & Pre.SubjectID & "','" & Pre.CurriculumID & "','" & Pre.Remarks & "')", con)
        com.ExecuteNonQuery()

        SavePreRequisite = TranDBResult.Success

    End Function

    Public Function DeletePreRequisite(ByVal Pre As tPrerequisite) As TranDBResult

        Dim com As New MySqlCommand("DELETE FROM tblPrerequisite wHERE Curriculum_SubjectID ='" & Pre.CurriculumID_SubjectID & "' AND SubjectID='" & Pre.SubjectID & "' AND CurriculumID='" & Pre.CurriculumID & _
                                    "' AND Remarks = '" & Pre.Remarks & "'", con)
        com.ExecuteNonQuery()

        DeletePreRequisite = TranDBResult.Success
    End Function


    '============================================ SUBJECT EQUIVALENCE =================================================
    Public Function SaveSubjectEquivalence(ByVal Pre As tPrerequisite) As TranDBResult

        If CheckSubjectEquivalenceBySubject(Pre.CurriculumID_SubjectID, Pre.CurriculumID, Pre.SubjectID) = TranDBResult.Success Then
            SaveSubjectEquivalence = TranDBResult.DuplicateID
            Exit Function
        End If

        Dim com As New MySqlCommand("INSERT INTO tblPrerequisite(Curriculum_SubjectID,SubjectID,CurriculumID,Remarks) VALUES('" & Pre.CurriculumID_SubjectID & "','" & Pre.SubjectID & "','" & Pre.CurriculumID & "','" & Pre.Remarks & "')", con)
        com.ExecuteNonQuery()

        SaveSubjectEquivalence = TranDBResult.Success
    End Function

    Public Function DeleteSubjectEquivalence(ByVal Pre As tPrerequisite) As TranDBResult

        Dim com As New MySqlCommand("DELETE FROM tblPrerequisite wHERE Curriculum_SubjectID ='" & Pre.CurriculumID_SubjectID & "' AND SubjectID='" & Pre.SubjectID & _
                                    "' AND Remarks = '" & Pre.Remarks & "'", con)
        com.ExecuteNonQuery()

        DeleteSubjectEquivalence = TranDBResult.Success
    End Function

End Module

