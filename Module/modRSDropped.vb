Option Explicit On

Imports MySql.Data.MySqlClient

Module modRSDropped
    Public Const KeyDropped As String = "grad"

    Public Structure tDropped
        Dim StudentID As String
        Dim SchoolYear As String
        Dim DateDropped As Date
        Dim Note As String
        Dim CreationDate As String
        Dim CreatedBy As String
    End Structure


    Public Function AddDropped(ByVal vDropped As tDropped) As TranDBResult
        Dim sSQL As String
        'default
        AddDropped = TranDBResult.Failed

        'check
        If Len(vDropped.StudentID) < 1 Then
            AddDropped = TranDBResult.InvalidID

            GoTo ReleaseAndExit
        End If


        sSQL = "SELECT * FROM tblDropped WHERE tblDropped.StudentID='" & vDropped.StudentID & "'"

        'conect
        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            AddDropped = TranDBResult.DuplicateID
            GoTo ReleaseAndExit
        End If
        vRS.Close()

        Dim cmd As New MySqlCommand("INSER INTO tblDropped(StudentID,SchoolYear,DateDropped,Note,CreationDate,CreatedBy) VALUES " & _
                                    "('" & vDropped.StudentID & _
                                    "','" & vDropped.SchoolYear & _
                                    "','" & vDropped.DateDropped & _
                                    "','" & vDropped.Note & _
                                    "','" & vDropped.CreationDate & _
                                    "','" & vDropped.CreatedBy & "')", clsCon.con)

        com.ExecuteNonQuery()

        'return success
        AddDropped = TranDBResult.Success

ReleaseAndExit:
        Exit Function
    End Function


    Public Function IsStudentDropped(ByVal sStudentID As String) As TranDBResult
        Dim sSQL As String

        'set default
        IsStudentDropped = TranDBResult.Failed

        sSQL = "SELECT tblDropped.StudentID" & _
                " FROM tblDropped INNER JOIN tblStudent ON tblDropped.StudentID = tblStudent.StudentID" & _
                " Where (((tblStudent.StudentID) = '" & sStudentID & "'))" & _
                " GROUP BY tblDropped.StudentID;"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            IsStudentDropped = TranDBResult.Success
        Else
            IsStudentDropped = TranDBResult.Failed
        End If
        vRS.Close()
    End Function



    Public Function DeleteDropped(ByVal sStudentID As String) As TranDBResult
        Dim sSQL As String
        sSQL = "Delete From tblDropped" & _
            " WHERE (((tblDropped.StudentID)='" & sStudentID & "'));"

        'default
        DeleteDropped = TranDBResult.Failed
        Try
            Dim com As New MySqlCommand(sSQL, clsCon.con)
            com.ExecuteNonQuery()
            DeleteDropped = TranDBResult.Success
        Catch ex As Exception
            DeleteDropped = TranDBResult.Failed
        End Try
    End Function

End Module
