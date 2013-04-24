Option Explicit On

Imports MySql.Data.MySqlClient
Imports System.Data

Module modDBYearLevel
    Public Const KeyYearLevel As String = "year"

    Public Structure tYearLevel
        Dim YearLevelID As Integer
        Dim YearLevelTitle As String
    End Structure

    Public Function YearLevelRecordExist() As Boolean
        Dim com As New MySqlCommand("SELECT * FROM tblYearLevel", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        While vRS.Read()
            If vRS.HasRows = True Then
                YearLevelRecordExist = True
            Else
                YearLevelRecordExist = False
            End If
        End While
        vRS.Close()
    End Function

    Public Function AddYearLevel(ByVal newYearLevel As tYearLevel) As TranDBResult
        Dim daYearLevel As New MySqlDataAdapter()
        Dim dsYearLevel As New DataSet()

        If YearLevelExistByID(newYearLevel.YearLevelID) = TranDBResult.Success Then
            AddYearLevel = TranDBResult.DuplicateID
            GoTo ReleaseAndExit
        End If

        If YearLevelExistByTitle(newYearLevel.YearLevelTitle) = TranDBResult.Success Then
            AddYearLevel = TranDBResult.DuplicateTitle
            GoTo ReleaseAndExit
        End If


        daYearLevel.SelectCommand = New MySqlCommand("SELECT * FROM tblYearLevel", clsCon.con)
        daYearLevel.Fill(dsYearLevel, "tblYearLevel")
        Dim dt As DataTable = dsYearLevel.Tables("tblYearLevel")
        Dim vRS As DataRow

        vRS = dt.NewRow()

        vRS("yearlevelid") = newYearLevel.YearLevelID
        vRS("yearleveltitle") = newYearLevel.YearLevelTitle

        dt.Rows.Add(vRS)
        daYearLevel.Update(dsYearLevel, "tblYearLevel")

        AddYearLevel = TranDBResult.Success

ReleaseAndExit:
        Exit Function
    End Function

    Public Function EditYearLevel(ByVal newYearLevel As tYearLevel) As TranDBResult
        Dim oldYearLevel As tYearLevel

        If GetYearLevelByID(newYearLevel.YearLevelID, oldYearLevel) Then
            If oldYearLevel.YearLevelTitle = newYearLevel.YearLevelTitle Then
                'nothing to proccess here just return success
                EditYearLevel = TranDBResult.Success
            Else
                'find title duplicate
                If YearLevelExistByTitle(newYearLevel.YearLevelTitle) = TranDBResult.Success Then
                    EditYearLevel = TranDBResult.DuplicateTitle
                    GoTo ReleaseAndExit
                End If
            End If
        End If

        Dim com As New MySqlCommand("UPDATE tblYearLevel SET YearLevelID='" & newYearLevel.YearLevelID & "', YearLevelTitle='" & newYearLevel.YearLevelTitle & "' WHERE (((tblYearLevel.YearLevelID)=" & newYearLevel.YearLevelID & "));", clsCon.con)
        com.ExecuteNonQuery()

        EditYearLevel = TranDBResult.Success
ReleaseAndExit:
        EditYearLevel = TranDBResult.Failed
        Exit Function
    End Function




    Public Function ExecuteDeleteYearLevel(ByVal lYearLevelID As Integer) As Boolean

        'check if record exist and if it is edited by other user
        If MsgBox("WARNING:" & vbNewLine & _
            "Deleting this YEAR LEVEL entry will affect all other record" & vbNewLine & vbNewLine & _
            "Delete this record anyway?", vbQuestion + vbYesNo) = vbYes Then

            If DeleteYearLevel(lYearLevelID) Then
                MsgBox("YEAR LEVEL entry and other related record succesfully deleted.", vbInformation)
                ExecuteDeleteYearLevel = True
            Else

                MsgBox("Deleting YEAR LEVEL entry went failed.", vbExclamation)
                ExecuteDeleteYearLevel = False
            End If
        Else
            ExecuteDeleteYearLevel = False
        End If
    End Function

    Public Function DeleteYearLevel(ByVal lYearLevelID As Integer) As Boolean
        Dim com As New MySqlCommand("DELETE * From tblYearLevel WHERE (((tblYearLevel.YearLevelID)=" & lYearLevelID & "));", clsCon.con)
        com.ExecuteNonQuery()
        DeleteYearLevel = True
    End Function


    Public Function YearLevelExistByID(ByVal lYearLevelID As Integer) As TranDBResult

        Dim com As New MySqlCommand("SELECT * From tblYearLevel WHERE (((tblYearLevel.YearLevelID)=" & lYearLevelID & "));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then

            YearLevelExistByID = TranDBResult.Success

        Else
            YearLevelExistByID = TranDBResult.Failed
        End If

        vRS.Close()

    End Function

    Public Function YearLevelExistByTitle(ByVal lYearLevelTitle As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * From tblYearLevel WHERE (((tblYearLevel.YearLevelTitle)='" & lYearLevelTitle & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            YearLevelExistByTitle = TranDBResult.Success
        Else
            YearLevelExistByTitle = TranDBResult.Failed
        End If


        vRS.Close()

    End Function
    Public Function GetYearLevelByID(ByVal lYearLevelID As Integer, ByRef vYearlevel As tYearLevel) As Boolean
        Dim com As New MySqlCommand("SELECT * From tblYearLevel WHERE (((tblYearLevel.YearLevelID)=" & lYearLevelID & "));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            vYearlevel.YearLevelID = Convert.ToInt32(vRS("yearlevelid").ToString())
            vYearlevel.YearLevelTitle = vRS("yearleveltitle").ToString()

            GetYearLevelByID = True

        Else
            GetYearLevelByID = False
        End If

        vRS.Close()
    End Function

    Public Function GetYearLevelbyTitle(ByVal sYearLevelTitle As String, ByRef vYearlevel As tYearLevel) As TranDBResult

        Dim com As New MySqlCommand("SELECT * From tblYearLevel WHERE (((tblYearLevel.YearLevelTitle)='" & sYearLevelTitle & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            vYearlevel.YearLevelID = Convert.ToInt32(vRS("yearlevelid").ToString())
            vYearlevel.YearLevelTitle = vRS("yearleveltitle").ToString()

            GetYearLevelbyTitle = TranDBResult.Success

        Else
            GetYearLevelbyTitle = TranDBResult.Failed
        End If

        vRS.Close()
    End Function


    Public Function YLTitleToID(ByVal sTitle As String) As Integer
        Select Case UCase(sTitle)
            Case "I"
                YLTitleToID = 1
            Case "II"
                YLTitleToID = 2
            Case "III"
                YLTitleToID = 3
            Case "IV"
                YLTitleToID = 4
            Case Else
                YLTitleToID = 0
        End Select
    End Function

    Public Function YLIDtoTitle(ByVal iLYID As Integer) As String
        Select Case iLYID
            Case 1
                YLIDtoTitle = "I"
            Case 2
                YLIDtoTitle = "II"
            Case 3
                YLIDtoTitle = "III"
            Case 4
                YLIDtoTitle = "IV"
            Case Else
                YLIDtoTitle = "0"
        End Select
    End Function

End Module
