Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Data.OleDb
Imports System.Data
Imports System.Windows.Forms
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Module clsSchedule

    Public Const keyOffering = "Sched"

    Public Enum ScheduleState
        OneScheduleState = 1
        TwoScheduleState = 2
        ThreeScheduleState = 3
        FourScheduleState = 4
        FiveScheduleState = 5
    End Enum

    Public SchedState As ScheduleState

    Public Function DaysToInteger(ByVal cDays As String) As String
        Dim n As Integer
        For n = 0 To Len(cDays)

        Next
    End Function
    Public Function TimeToInt(ByVal cTimeIn As String) As Integer
        Select Case cTimeIn
            Case 60000 'To 63000 '62900     6:00:00 AM
                Return 1
            Case 63000 'To 70000 '65900     6:30:00 AM
                Return 2
            Case 70000 'To 73000 '72900     7:00:00
                Return 3
            Case 73000 'To 80000 '75900     7:30:00
                Return 4
            Case 80000 'To 83000 '82900     8:00:00
                Return 5
            Case 83000 'To 90000 '85900     8:30:00
                Return 6
            Case 90000 'To 93000 '92900     9:00:00
                Return 7
            Case 93000 'To 100000 '95900    9:30:00
                Return 8
            Case 100000 'To 103000 '102900  10:00:00
                Return 9
            Case 103000 'To 110000 '105900  10:30:00
                Return 10
            Case 110000 'To 113000 '112900  11:00:00
                Return 11
            Case 113000 'To 120000 '115900  11:30:00
                Return 12
            Case 120000 'To 123000 '122900  12:00:00
                Return 13
            Case 123000 'To 130000 '122900  12:30:00
                Return 14
            Case 130000 'To 133000 '132900  13:00:00
                Return 15
            Case 133000 'To 140000 '135900  13:30:00
                Return 16
            Case 140000 'To 143000 '142900  14:00:00
                Return 17
            Case 143000 'To 150000 '145900  14:30:00
                Return 18
            Case 150000 'To 153000 '152900  15:00:00
                Return 19
            Case 153000 'To 160000 '155900  15:30:00
                Return 20
            Case 160000 'To 163000 '162900  16:00:00
                Return 21
            Case 163000 'To 170000 '165900  16:30:00
                Return 22
            Case 170000 'To 173000 '172900  17:00:00
                Return 23
            Case 173000 'To 180000 '175900  17:30:00
                Return 24
            Case 180000 'To 183000 '182900  18:00:00
                Return 25
            Case 183000 'To 190000 '185900  18:30:00
                Return 26
            Case 190000 'To 193000 '192900  19:00:00
                Return 27
            Case 193000 'To 200000 '195900  19:30:00
                Return 28
            Case 200000 'To 203000 '202900  20:00:00
                Return 29
            Case 203000 'To 210000          20:30:00
                Return 30
        End Select

    End Function


    Public Function MilitaryToStandard(ByVal pTimeValue As Long) As String

        MilitaryToStandard = CDate(Format(pTimeValue, "00:00:00"))

    End Function

    Public Function toMilitaryTime(ByVal pTime As String) As String

        toMilitaryTime = Format(CDate(pTime), "HHmmss")

    End Function

    Public Function FacultyInUse1(ByVal From As Integer, ByVal sTo As Integer, ByVal Faculty As String, ByVal Day As String, ByVal sTermID As Integer) As Boolean
        Dim i As Integer

        Dim com As New MySqlCommand("CALL GetFacultyScheduleConflicts(" & sTermID & ",'" & Faculty & "','%" & Day & "%'," & From & "," & sTo & ")", con)

        Dim dr As MySqlDataReader = com.ExecuteReader()
        dr.Read()
        If dr.HasRows = True Then
                FacultyInUse1 = True
            Else
                FacultyInUse1 = False
            End If
            dr.Close()
    End Function

    Public Function RoomInUse1(ByVal From As Integer, ByVal sTo As Integer, ByVal Room As String, ByVal Day As String, ByVal sTermID As Integer) As Boolean
        Dim i As Integer
        Dim com As New MySqlCommand("CALL GetRoomScheduleConflicts(" & sTermID & ",'" & Room & "','%" & Day & "%'," & From & "," & sTo & ")", con)

        Dim dr As MySqlDataReader = com.ExecuteReader()
        dr.Read()
        If dr.HasRows = True Then
            RoomInUse1 = True
        Else
            RoomInUse1 = False
        End If

        dr.Close()
    End Function

    Public Function FacultyInUse2(ByVal From As Integer, ByVal sTo As Integer, ByVal Faculty As String, ByVal Day As Integer, ByVal sTermID As Integer) As Boolean
        Dim i As Integer


        Dim com As New MySqlCommand("CALL GetFacultyScheduleConflicts(" & sTermID & ",'" & Faculty & "','%" & Day & "%'," & From & "," & sTo & ")", con)

        Dim dr As MySqlDataReader = com.ExecuteReader()
        dr.Read()
        If dr.HasRows = True Then
            FacultyInUse2 = True
        Else
            FacultyInUse2 = False
        End If

            dr.Close()
    End Function

    Public Function RoomInUse2(ByVal From As Integer, ByVal sTo As Integer, ByVal Room As String, ByVal Day As Integer, ByVal sTermID As Integer) As Boolean
        Dim i As Integer

        Dim com As New MySqlCommand("CALL GetRoomScheduleConflicts(" & sTermID & ",'" & Room & "','%" & Day & "%'," & From & "," & sTo & ")", con)


        Dim dr As MySqlDataReader = com.ExecuteReader()
        dr.Read()
        If dr.HasRows = True Then
            RoomInUse2 = True
        Else
            RoomInUse2 = False
        End If
        dr.Close()
    End Function

    Public Function FacultyInUse3(ByVal From As Integer, ByVal sTo As Integer, ByVal Faculty As String, ByVal Day As Integer, ByVal sTermID As Integer) As Boolean
        Dim i As Integer

        Dim com As New MySqlCommand("CALL GetFacultyScheduleConflicts(" & sTermID & ",'" & Faculty & "','%" & Day & "%'," & From & "," & sTo & ")", con)

        Dim dr As MySqlDataReader = com.ExecuteReader()
        dr.Read()
        If dr.HasRows = True Then
            FacultyInUse3 = True
        Else
            FacultyInUse3 = False
        End If
        dr.Close()
    End Function

    Public Function RoomInUse3(ByVal From As Integer, ByVal sTo As Integer, ByVal Room As String, ByVal Day As Integer, ByVal sTermID As Integer) As Boolean
        Dim i As Integer
        Dim com As New MySqlCommand("CALL GetRoomScheduleConflicts(" & sTermID & ",'" & Room & "','%" & Day & "%'," & From & "," & sTo & ")", con)

        Dim dr As MySqlDataReader = com.ExecuteReader()
        dr.Read()
        If dr.HasRows = True Then
                RoomInUse3 = True
            Else
                RoomInUse3 = False
            End If
            dr.Close()
    End Function

    Public Function FacultyInUse4(ByVal From As Integer, ByVal sTo As Integer, ByVal Faculty As String, ByVal Day As Integer, ByVal sTermID As Integer) As Boolean
        Dim i As Integer
        Dim com As New MySqlCommand("CALL GetFacultyScheduleConflicts(" & sTermID & ",'" & Faculty & "','%" & Day & "%'," & From & "," & sTo & ")", con)

        Dim dr As MySqlDataReader = com.ExecuteReader()
        dr.Read()
        If dr.HasRows = True Then
                FacultyInUse4 = True
            Else
                FacultyInUse4 = False
            End If
            dr.Close()
    End Function

    Public Function RoomInUse4(ByVal From As Integer, ByVal sTo As Integer, ByVal Room As String, ByVal Day As Integer, ByVal sTermID As Integer) As Boolean
        Dim i As Integer
        Dim com As New MySqlCommand("CALL GetRoomScheduleConflicts(" & sTermID & ",'" & Room & "','%" & Day & "%'," & From & "," & sTo & ")", con)


        Dim dr As MySqlDataReader = com.ExecuteReader()
        dr.Read()
        If dr.HasRows = True Then
                RoomInUse4 = True
            Else
                RoomInUse4 = False
            End If
            dr.Close()
    End Function

    Public Function FacultyInUse5(ByVal From As Integer, ByVal sTo As Integer, ByVal Faculty As String, ByVal Day As Integer, ByVal sTermID As Integer) As Boolean
        Dim i As Integer

        Dim com As New MySqlCommand("CALL GetFacultyScheduleConflicts(" & sTermID & ",'" & Faculty & "','%" & Day & "%'," & From & "," & sTo & ")", con)

        Dim dr As MySqlDataReader = com.ExecuteReader()
        dr.Read()
        If dr.HasRows = True Then
                FacultyInUse5 = True
            Else
                FacultyInUse5 = False
            End If
            dr.Close()
    End Function

    Public Function RoomInUse5(ByVal From As Integer, ByVal sTo As Integer, ByVal Room As String, ByVal Day As Integer, ByVal sTermID As Integer) As Boolean
        Dim i As Integer
        Dim com As New MySqlCommand("CALL GetRoomScheduleConflicts(" & sTermID & ",'" & Room & "','%" & Day & "%'," & From & "," & sTo & ")", con)

        Dim dr As MySqlDataReader = com.ExecuteReader()
        dr.Read()
        If dr.HasRows = True Then
            RoomInUse5 = True
        Else
            RoomInUse5 = False
        End If
        dr.Close()
    End Function

    Public Function SectionInUse(ByVal From As Integer, ByVal sTo As Integer, ByVal sSectionID As String, ByVal Day As String, ByVal sTermID As Integer) As Boolean
        Dim i As Integer

        Dim com As New MySqlCommand("CALL GetClassScheduleConflicts()", clsCon.con)
        Dim dr As MySqlDataReader = com.ExecuteReader()
        While dr.Read()
            For i = 1 To Len(dr("Days").ToString())
                If dr("Days").ToString() Like "*" & Microsoft.VisualBasic.Mid(Day, i, 1) & "*" Then
                    SectionInUse = True
                    Exit For
                Else
                    SectionInUse = False
                End If
            Next
        End While
        dr.Close()
    End Function

    Public Function CheckScheduleNum(ByVal OfferingID As String) As ScheduleState
        Dim com As New MySqlCommand("SELECT Sched1,Sched2,Sched3,Sched4,Sched5 FROM tblClassSchedule WHERE SubjectOfferingID='" & OfferingID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            If IsDBNull(vRS("Sched1").ToString) Then
                CheckScheduleNum = ScheduleState.OneScheduleState
            ElseIf IsDBNull(vRS("Sched1").ToString()) And IsDBNull(vRS("Sched2").ToString()) Then
                CheckScheduleNum = ScheduleState.TwoScheduleState
            ElseIf IsDBNull(vRS("Sched1").ToString()) And IsDBNull(vRS("Sched2").ToString()) And _
                IsDBNull(vRS("Sched3").ToString()) Then
                CheckScheduleNum = ScheduleState.ThreeScheduleState
            ElseIf IsDBNull("") Then
            End If

        End If

    End Function


End Module
