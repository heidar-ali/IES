Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

' Represents the days of the week that are used in the TimeSlot class
Public Class Days
    Private m_daysOfWeek As Boolean() = {False, False, False, False, False, False, _
     False}

    Public Sub New(ByVal daysOfWeek__1 As Boolean())
        DaysOfWeek = daysOfWeek__1
    End Sub

    Public Sub New(ByVal dayLetters As [String])
        For i As Integer = 0 To dayLetters.Length - 1
            If dayLetters(i) = "Mon" Then
                m_daysOfWeek(0) = True
            ElseIf dayLetters(i) = "Tue" Then
                m_daysOfWeek(1) = True
            ElseIf dayLetters(i) = "Wed" Then
                m_daysOfWeek(2) = True
            ElseIf dayLetters(i) = "Thu" Then
                m_daysOfWeek(3) = True
            ElseIf dayLetters(i) = "Fri" Then
                m_daysOfWeek(4) = True
            ElseIf dayLetters(i) = "Sat" Then
                m_daysOfWeek(5) = True
            ElseIf dayLetters(i) = "Sun" Then
                m_daysOfWeek(6) = True
            End If
        Next
    End Sub

    Public Property DaysOfWeek() As Boolean()
        Get
            Return m_daysOfWeek
        End Get
        Set(ByVal value As Boolean())
            m_daysOfWeek = Value
        End Set
    End Property

    Public Function Overlap(ByVal otherDays As Days) As Boolean
        Dim result As Boolean = False

        For i As Integer = 0 To m_daysOfWeek.Length - 1
            If m_daysOfWeek(i) AndAlso otherDays.DaysOfWeek(i) Then
                result = True
            End If
        Next

        Return result
    End Function

    Public Overrides Function Equals(ByVal obj As [Object]) As Boolean
        If Not (TypeOf obj Is Days) Then
            Return False
        End If
        Dim otherDays As Days = DirectCast(obj, Days)

        For i As Integer = 0 To m_daysOfWeek.Length - 1
            If m_daysOfWeek(i) <> otherDays.DaysOfWeek(i) Then
                Return False
            End If
        Next
        Return True
    End Function
    ' We aren't really using this - no HashMaps.
    Public Overrides Function GetHashCode() As Integer
        Return MyBase.GetHashCode()
    End Function

    Public Overrides Function ToString() As [String]
        ' UMTWRFS
        Dim result As [String] = ""

        Dim dayLetters As String() = {"Mon", "Tue", "Wed", "Thu", "Fri", "Sat", _
         "Sun"}
        For i As Integer = 0 To m_daysOfWeek.Length - 1
            If m_daysOfWeek(i) Then
                result += dayLetters(i)
            End If
        Next

        Return result
    End Function
    Public Function ToChar() As [String]
        ' UMTWRFS
        Dim result As [String] = ""

        Dim dayLetters As String() = {"M", "T", "W", "Th", "F", "S", _
         "Su"}
        For i As Integer = 0 To m_daysOfWeek.Length - 1
            If m_daysOfWeek(i) Then
                result += dayLetters(i)
            End If
        Next

        Return result
    End Function
    Public Function ToInteger() As [String]
        ' UMTWRFS
        Dim result As [String] = ""

        Dim dayLetters As String() = {"Mon", "Tue", "Wed", "Thu", "Fri", "Sat", _
         "Sun"}
        For i As Integer = 0 To m_daysOfWeek.Length - 1
            If m_daysOfWeek(i) Then
                Dim sDay As Integer = i + 1
                result += (sDay.ToString())
            End If
        Next

        Return result
    End Function

    Public Function toDaysOfWeek(ByVal Num As Integer) As String
        Select Case Num
            Case 1
                toDaysOfWeek = "Mon"
            Case 2
                toDaysOfWeek = "Tue"
            Case 3
                toDaysOfWeek = "Wed"
            Case 4
                toDaysOfWeek = "Thu"
            Case 5
                toDaysOfWeek = "Fri"
            Case 6
                toDaysOfWeek = "Sat"
            Case 7
                toDaysOfWeek = "Sun"
        End Select
    End Function


End Class

