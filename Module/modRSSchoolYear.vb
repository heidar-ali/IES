Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Module modRSSchoolYear

    Public Const keySchoolYear As String = "scho"

    Public Enum SchoolTerm
        Semestral = 2
        Trimistral = 3
        Yearly = 1
    End Enum


    Public Structure tSchoolYear
        Dim SchoolYearTitle As String
        Dim SchoolTerm As String
        Dim TermID As String

        Dim Locked As Boolean
    End Structure

    Public Function AddSchoolYear(ByVal newSchoolYear As tSchoolYear) As TranDBResult


        'default
        AddSchoolYear = TranDBResult.Failed



        If SchoolYearExistByTitle(newSchoolYear.SchoolYearTitle) = TranDBResult.Success Then
            AddSchoolYear = TranDBResult.DuplicateTitle
            GoTo ReleaseAndExit
        End If

        Dim com As New MySqlCommand("INSERT INTO tblSchoolYear(SchoolYear,Locked) VALUES ('" & newSchoolYear.SchoolYearTitle & "','" & newSchoolYear.Locked & "')", clsCon.con)
        com.ExecuteNonQuery()

        AddSchoolYear = TranDBResult.Success



ReleaseAndExit:
        Exit Function
    End Function
    Public Function SchoolYearRecordExisted() As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblAYTerm", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            SchoolYearRecordExisted = TranDBResult.Success
        Else
            SchoolYearRecordExisted = TranDBResult.Failed
        End If
        vRS.Close()
    End Function
    Public Function EditSchoolYear(ByVal OldSchoolYearTitle As String, ByVal newSchoolYear As tSchoolYear) As TranDBResult
        If OldSchoolYearTitle = newSchoolYear.SchoolYearTitle Then
            'nothing to process, hust return success
            EditSchoolYear = TranDBResult.Success
        Else
            'find duplicate
            If SchoolYearExistByTitle(newSchoolYear.SchoolYearTitle) = TranDBResult.Success Then
                EditSchoolYear = TranDBResult.DuplicateTitle
            Else

                Dim com As New MySqlCommand("UPDATE tblSchoolYear SET SchoolYear='" & newSchoolYear.SchoolYearTitle & "', Locked='" & newSchoolYear.Locked & "' WHERE (((tblSchoolYear.SchoolYear)='" & OldSchoolYearTitle & "'));", clsCon.con)

                com.ExecuteNonQuery()

                EditSchoolYear = TranDBResult.Success
            End If
        End If
    End Function






    Public Function ExecuteDeleteSchoolYear(ByVal sSchoolYearTitle As String) As TranDBResult

        Dim vSchoolYear As tSchoolYear
        Dim DeleteResult As Integer
        'default
        ExecuteDeleteSchoolYear = TranDBResult.Failed

        'check if record exist and if it is edited by other user
        If MsgBox("WARNING:" & vbNewLine & _
        "Deleting School Year Record will affect all other record" & vbNewLine & vbNewLine & _
        "Delete this record anyway?", vbQuestion + vbYesNo) = vbYes Then

            If Len(sSchoolYearTitle) < 1 Then Exit Function


            'delete file
            DeleteResult = DeleteSchoolYear(sSchoolYearTitle)

            Select Case DeleteResult

                Case 1 'deleted
                    MsgBox("School Year deleted.", vbInformation)

                Case Else 'failed
                    MsgBox("Deleting School Year went failed.", vbExclamation)

            End Select


        End If

        ExecuteDeleteSchoolYear = TranDBResult.Success
    End Function

    Public Function SchoolYearExistByTitle(ByVal sSchoolYearTitle As String) As TranDBResult

        SchoolYearExistByTitle = TranDBResult.Failed

        Dim sSQL As String = "SELECT * FROM tblSchoolYear WHERE tblSchoolYear.SchoolYear='" & sSchoolYearTitle & "'"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = False Then
            SchoolYearExistByTitle = TranDBResult.Failed
        Else
            SchoolYearExistByTitle = TranDBResult.Success
        End If
        vRS.Close()

ReleaseAndExit:
        Exit Function
    End Function




    Public Function DeleteSchoolYear(ByVal sSchoolYearTitle As String) As TranDBResult
        Dim com As New MySqlCommand("DELETE From tblSchoolYear WHERE (((tblSchoolYear.SchoolYear)='" & sSchoolYearTitle & "'));", clsCon.con)
        com.ExecuteNonQuery()
        DeleteSchoolYear = TranDBResult.Success
    End Function



    Public Function GetNextSchoolYear(ByVal sOldSchoolYear As String, ByRef newSchoolYear As String) As TranDBResult
        Dim sSQL As String

        sSQL = "SELECT tblSchoolYear.SchoolYear" & _
            " From tblSchoolYear" & _
            " Where Left(tblSchoolYear.SchoolYear, 4) > " & Left(sOldSchoolYear, 4) & " " & _
            " ORDER BY tblSchoolYear.SchoolYear;"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = False Then
            newSchoolYear = (vRS("SchoolYear").ToString())
            GetNextSchoolYear = TranDBResult.Success
        Else
            GetNextSchoolYear = TranDBResult.Failed
        End If


        vRS.Close()
    End Function



    Public Function GetSchoolYearByTitle(ByVal sSchoolYearTitle As String, ByRef vSchoolYear As tSchoolYear) As TranDBResult
        Dim sSQL As String
        GetSchoolYearByTitle = TranDBResult.Failed

        sSQL = "SELECT * FROM tblSchoolYear WHERE tblSchoolYear.SchoolYear='" & sSchoolYearTitle & "'"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = False Then
            GetSchoolYearByTitle = TranDBResult.Failed
            GoTo ReleaseAndExit
        End If
        If vRS.HasRows = True Then

            vSchoolYear.SchoolYearTitle = vRS("SchoolYear").ToString()
            vSchoolYear.SchoolTerm = vRS("SchoolTerm").ToString()
            vSchoolYear.Locked = Convert.ToBoolean(vRS("Locked").ToString())

            GetSchoolYearByTitle = TranDBResult.Success
        Else
            GetSchoolYearByTitle = TranDBResult.Failed
        End If
        vRS.Close()

ReleaseAndExit:
        vRS.Close()
        Exit Function
    End Function

    Public Function GetSchoolYearByID(ByVal sID As String, ByRef vSchoolYear As tSchoolYear) As TranDBResult
        Dim sSQL As String
        GetSchoolYearByID = TranDBResult.Failed

        sSQL = "SELECT * FROM tblAYTerm WHERE TermID='" & sID & "'"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = False Then
            GetSchoolYearByID = TranDBResult.Failed
            GoTo ReleaseAndExit
        End If
        If vRS.HasRows = True Then

            vSchoolYear.SchoolYearTitle = vRS("SchoolYear").ToString()
            vSchoolYear.SchoolTerm = vRS("SchoolTerm").ToString()
            vSchoolYear.Locked = Convert.ToBoolean(vRS("Locked").ToString())

            GetSchoolYearByID = TranDBResult.Success
        Else
            GetSchoolYearByID = TranDBResult.Failed
        End If
        vRS.Close()

ReleaseAndExit:
        vRS.Close()
        Exit Function
    End Function

    Public Function GetAcademicYearTerm(ByVal TermID As Integer, ByRef Term As tSchoolYear) As TranDBResult

        Dim com As New MySqlCommand("SELECT * FROM tblAYTerm WHERE TermID='" & TermID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            Term.SchoolTerm = vRS("SchoolTerm").ToString()
            Term.SchoolYearTitle = vRS("SchoolYear").ToString()

            GetAcademicYearTerm = TranDBResult.Success
        Else
            GetAcademicYearTerm = TranDBResult.Failed
        End If
        vRS.Close()
    End Function


    Public Sub SaveActiveSchoolYear(ByVal sSYTitle As String)
        SaveINI("AYTerm", "DefaultAcademicTerm", sSYTitle, CONFIG_INI_FILE)
    End Sub

    Public Sub GetActiveSchoolYear()
        GetSchoolYearByID(ReadINI("AYTerm", "DefaultAcademicTerm", CONFIG_INI_FILE), CurrentSchoolYear)
    End Sub

End Module
