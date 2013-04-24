Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1FlexGrid.Util
Imports C1.Win.C1FlexGrid.PrintDocumentGridRenderer

Public Class frmScheduler
    Inherits Form

    Dim State As ScheduleState
    Dim SchedPrint As SchedulePrint
    Dim sFormState As FormState

    Dim i As Integer

    Dim Colors As Color() = New Color(16) {Color.LightGreen, Color.LightPink, Color.LightSkyBlue, Color.Orange, Color.Tan, Color.OrangeRed, Color.LimeGreen, Color.Violet, Color.LightSteelBlue, Color.FromArgb(&H66, &HFF, &HFF), Color.MediumAquamarine, Color.FromArgb(&HFF, &HCC, &H33), Color.Coral, Color.Silver, Color.SandyBrown, Color.ForestGreen, Color.FromArgb(&H99, &H0, &HFF)}


    Dim newSubjectOffering As tSubjectOffering

    Dim OfferingID As String

    Dim RecordSaved As Boolean


    Public Sub New()
        InitializeComponent()
    End Sub

    Public Function ShowForm(Optional ByVal sSectionID As String = "", Optional ByVal sSubjectID As String = "", Optional ByVal sSubjectTitle As String = "", Optional ByRef sSubjectOfferingID As String = "", _
        Optional ByRef sSchedTimeStart As String = "", _
        Optional ByRef sSchedTimeEnd As String = "", _
        Optional ByRef sTeacherID As String = "", _
        Optional ByRef sDays As String = "", _
        Optional ByRef sTeacherName As String = "", _
        Optional ByRef sRoomID As String = "", _
        Optional ByRef RoomNo As String = "") As Boolean


        Dim i As Integer

        'set default
        RecordSaved = False
        sTeacherID = ""

        'set parameter

        txtSectionID.Text = sSectionID
        txtSubjectID.Text = sSubjectID
        'show form
        Me.ShowDialog()


        ShowForm = RecordSaved
    End Function

    

    Private Sub FacultyGrid()

        facGrid.Clear()

        facGrid.set_ColWidth(0, 60)


        For i As Integer = 1 To 7
            facGrid.set_ColWidth(i, 80)
        Next

        facGrid(0, 1) = "Monday"
        facGrid(0, 2) = "Tuesday"
        facGrid(0, 3) = "Wednesday"
        facGrid(0, 4) = "Thursday"
        facGrid(0, 5) = "Friday"
        facGrid(0, 6) = "Saturday"
        facGrid(0, 7) = "Sunday"

        facGrid(1, 0) = "06:00 AM"
        facGrid(2, 0) = "06:30 AM"
        facGrid(3, 0) = "07:00 AM"
        facGrid(4, 0) = "07:30 AM"
        facGrid(5, 0) = "08:00 AM"
        facGrid(6, 0) = "08:30 AM"
        facGrid(7, 0) = "09:00 AM"
        facGrid(8, 0) = "09:30 AM"
        facGrid(9, 0) = "10:00 AM"
        facGrid(10, 0) = "10:30 AM"
        facGrid(11, 0) = "11:00 AM"
        facGrid(12, 0) = "11:30 AM"
        facGrid(13, 0) = "12:00 PM"
        facGrid(14, 0) = "12:30 PM"
        facGrid(15, 0) = "01:00 PM"
        facGrid(16, 0) = "01:30 PM"
        facGrid(17, 0) = "02:00 PM"
        facGrid(18, 0) = "02:30 PM"
        facGrid(19, 0) = "03:00 PM"
        facGrid(20, 0) = "03:30 PM"
        facGrid(21, 0) = "04:00 PM"
        facGrid(22, 0) = "04:30 PM"
        facGrid(23, 0) = "05:00 PM"
        facGrid(24, 0) = "05:30 PM"
        facGrid(25, 0) = "06:00 PM"
        facGrid(26, 0) = "06:30 PM"
        facGrid(27, 0) = "07:00 PM"
        facGrid(28, 0) = "07:30 PM"
        facGrid(29, 0) = "08:00 PM"
        facGrid(30, 0) = "08:30 PM"

        For i As Integer = 1 To facGrid.Rows - 1
            facGrid.set_RowHeight(i, 26)
            facGrid.set_Cell(Classic.CellPropertySettings.flexcpFont, i, 1, New System.Drawing.Font("Arial", 7, FontStyle.Bold))
            facGrid.set_Cell(Classic.CellPropertySettings.flexcpFont, i, 2, New System.Drawing.Font("Arial", 7, FontStyle.Bold))
            facGrid.set_Cell(Classic.CellPropertySettings.flexcpFont, i, 3, New System.Drawing.Font("Arial", 7, FontStyle.Bold))
            facGrid.set_Cell(Classic.CellPropertySettings.flexcpFont, i, 4, New System.Drawing.Font("Arial", 7, FontStyle.Bold))
            facGrid.set_Cell(Classic.CellPropertySettings.flexcpFont, i, 5, New System.Drawing.Font("Arial", 7, FontStyle.Bold))
            facGrid.set_Cell(Classic.CellPropertySettings.flexcpFont, i, 6, New System.Drawing.Font("Arial", 7, FontStyle.Bold))
            facGrid.set_Cell(Classic.CellPropertySettings.flexcpFont, i, 7, New System.Drawing.Font("Arial", 7, FontStyle.Bold))
        Next

        'dgView1.Font.Size = 7
        facGrid.Styles.Fixed.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter

    End Sub
    Private Sub ClassSectionGrid()

        clsGrid.Clear()

        clsGrid.set_ColWidth(0, 60)

        For i As Integer = 1 To 7
            clsGrid.set_ColWidth(i, 80)
        Next

        clsGrid(0, 1) = "Monday"
        clsGrid(0, 2) = "Tuesday"
        clsGrid(0, 3) = "Wednesday"
        clsGrid(0, 4) = "Thursday"
        clsGrid(0, 5) = "Friday"
        clsGrid(0, 6) = "Saturday"
        clsGrid(0, 7) = "Sunday"

        clsGrid(1, 0) = "06:00 AM"
        clsGrid(2, 0) = "06:30 AM"
        clsGrid(3, 0) = "07:00 AM"
        clsGrid(4, 0) = "07:30 AM"
        clsGrid(5, 0) = "08:00 AM"
        clsGrid(6, 0) = "08:30 AM"
        clsGrid(7, 0) = "09:00 AM"
        clsGrid(8, 0) = "09:30 AM"
        clsGrid(9, 0) = "10:00 AM"
        clsGrid(10, 0) = "10:30 AM"
        clsGrid(11, 0) = "11:00 AM"
        clsGrid(12, 0) = "11:30 AM"
        clsGrid(13, 0) = "12:00 PM"
        clsGrid(14, 0) = "12:30 PM"
        clsGrid(15, 0) = "01:00 PM"
        clsGrid(16, 0) = "01:30 PM"
        clsGrid(17, 0) = "02:00 PM"
        clsGrid(18, 0) = "02:30 PM"
        clsGrid(19, 0) = "03:00 PM"
        clsGrid(20, 0) = "03:30 PM"
        clsGrid(21, 0) = "04:00 PM"
        clsGrid(22, 0) = "04:30 PM"
        clsGrid(23, 0) = "05:00 PM"
        clsGrid(24, 0) = "05:30 PM"
        clsGrid(25, 0) = "06:00 PM"
        clsGrid(26, 0) = "06:30 PM"
        clsGrid(27, 0) = "07:00 PM"
        clsGrid(28, 0) = "07:30 PM"
        clsGrid(29, 0) = "08:00 PM"
        clsGrid(30, 0) = "08:30 PM"

        For i As Integer = 1 To clsGrid.Rows - 1
            clsGrid.set_RowHeight(i, 26)
            clsGrid.set_Cell(Classic.CellPropertySettings.flexcpFont, i, 1, New System.Drawing.Font("Arial", 7, FontStyle.Bold))
            clsGrid.set_Cell(Classic.CellPropertySettings.flexcpFont, i, 2, New System.Drawing.Font("Arial", 7, FontStyle.Bold))
            clsGrid.set_Cell(Classic.CellPropertySettings.flexcpFont, i, 3, New System.Drawing.Font("Arial", 7, FontStyle.Bold))
            clsGrid.set_Cell(Classic.CellPropertySettings.flexcpFont, i, 4, New System.Drawing.Font("Arial", 7, FontStyle.Bold))
            clsGrid.set_Cell(Classic.CellPropertySettings.flexcpFont, i, 5, New System.Drawing.Font("Arial", 7, FontStyle.Bold))
            clsGrid.set_Cell(Classic.CellPropertySettings.flexcpFont, i, 6, New System.Drawing.Font("Arial", 7, FontStyle.Bold))
            clsGrid.set_Cell(Classic.CellPropertySettings.flexcpFont, i, 7, New System.Drawing.Font("Arial", 7, FontStyle.Bold))
        Next
        'dgView.Font.Size = 7
        clsGrid.Styles.Fixed.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter
    End Sub
    Private Sub ClassRoomGrid()

        RoomGrid.Clear()
        RoomGrid.set_ColWidth(0, 60)

        For i As Integer = 1 To 7
            RoomGrid.set_ColWidth(i, 80)
        Next

        RoomGrid(0, 1) = "Monday"
        RoomGrid(0, 2) = "Tuesday"
        RoomGrid(0, 3) = "Wednesday"
        RoomGrid(0, 4) = "Thursday"
        RoomGrid(0, 5) = "Friday"
        RoomGrid(0, 6) = "Saturday"
        RoomGrid(0, 7) = "Sunday"

        RoomGrid(1, 0) = "06:00 AM"
        RoomGrid(2, 0) = "06:30 AM"
        RoomGrid(3, 0) = "07:00 AM"
        RoomGrid(4, 0) = "07:30 AM"
        RoomGrid(5, 0) = "08:00 AM"
        RoomGrid(6, 0) = "08:30 AM"
        RoomGrid(7, 0) = "09:00 AM"
        RoomGrid(8, 0) = "09:30 AM"
        RoomGrid(9, 0) = "10:00 AM"
        RoomGrid(10, 0) = "10:30 AM"
        RoomGrid(11, 0) = "11:00 AM"
        RoomGrid(12, 0) = "11:30 AM"
        RoomGrid(13, 0) = "12:00 PM"
        RoomGrid(14, 0) = "12:30 PM"
        RoomGrid(15, 0) = "01:00 PM"
        RoomGrid(16, 0) = "01:30 PM"
        RoomGrid(17, 0) = "02:00 PM"
        RoomGrid(18, 0) = "02:30 PM"
        RoomGrid(19, 0) = "03:00 PM"
        RoomGrid(20, 0) = "03:30 PM"
        RoomGrid(21, 0) = "04:00 PM"
        RoomGrid(22, 0) = "04:30 PM"
        RoomGrid(23, 0) = "05:00 PM"
        RoomGrid(24, 0) = "05:30 PM"
        RoomGrid(25, 0) = "06:00 PM"
        RoomGrid(26, 0) = "06:30 PM"
        RoomGrid(27, 0) = "07:00 PM"
        RoomGrid(28, 0) = "07:30 PM"
        RoomGrid(29, 0) = "08:00 PM"
        RoomGrid(30, 0) = "08:30 PM"

        For i As Integer = 1 To RoomGrid.Rows - 1
            RoomGrid.set_RowHeight(i, 26)
            RoomGrid.set_Cell(Classic.CellPropertySettings.flexcpFont, i, 1, New System.Drawing.Font("Arial", 7, FontStyle.Bold))
            RoomGrid.set_Cell(Classic.CellPropertySettings.flexcpFont, i, 2, New System.Drawing.Font("Arial", 7, FontStyle.Bold))
            RoomGrid.set_Cell(Classic.CellPropertySettings.flexcpFont, i, 3, New System.Drawing.Font("Arial", 7, FontStyle.Bold))
            RoomGrid.set_Cell(Classic.CellPropertySettings.flexcpFont, i, 4, New System.Drawing.Font("Arial", 7, FontStyle.Bold))
            RoomGrid.set_Cell(Classic.CellPropertySettings.flexcpFont, i, 5, New System.Drawing.Font("Arial", 7, FontStyle.Bold))
            RoomGrid.set_Cell(Classic.CellPropertySettings.flexcpFont, i, 6, New System.Drawing.Font("Arial", 7, FontStyle.Bold))
            RoomGrid.set_Cell(Classic.CellPropertySettings.flexcpFont, i, 7, New System.Drawing.Font("Arial", 7, FontStyle.Bold))
        Next

        '.CellFontSize = 7
        RoomGrid.Styles.Fixed.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter
    End Sub

    
    

    Private Sub DisplayFacultySchedule(ByVal sFacultyID As String, ByVal sTermID As String)
        Dim num1 As Integer, num2 As Integer
        Dim sDay As String
        Dim randonGen As New Random()
        Dim Caption As String


        Dim com As New MySqlCommand("CALL GetFacultyScheduleByTerm('" & sFacultyID & "','" & sTermID & "')", clsCon.con)
        Dim dr As MySqlDataReader = com.ExecuteReader()
        lvFacSchedule.Items.Clear()

        facGrid.Clear()

        FacultyGrid()

        While dr.Read()
            Dim lv As New ListViewItem(dr("SubjectTitle").ToString())
            lv.SubItems.Add(dr("Room").ToString())
            lv.SubItems.Add(dr("FacultyName").ToString())
            lv.SubItems.Add(dr("Schedule").ToString())
            lv.ForeColor = Colors(randonGen.Next(16))
            lvFacSchedule.Items.AddRange(New ListViewItem() {lv})


            If dr("Schedule").ToString() <> "" Then
                Caption = dr("FacultyName").ToString() & vbNewLine & dr("Section").ToString() & vbNewLine & dr("SubjectTitle").ToString()
            Else
                Caption = ""
            End If

            num1 = TimeToInt(dr("Time_Start").ToString())
            num2 = TimeToInt(dr("Time_End").ToString())

            sDay = dr("Days").ToString()

            For time As Integer = num1 To num2
                With facGrid
                    .AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
                    .set_ColAlignment(0, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignLeftCenter)

                    For i = 1 To Len(dr("DAYS").ToString())
                        If dr("Days").ToString() Like "*" & Microsoft.VisualBasic.Mid(sDay, i, 1) & "*" Then
                            Dim n As Integer = Microsoft.VisualBasic.Mid(sDay, i, 1)

                            .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpBackColor, time, n, lv.ForeColor)

                            .set_TextMatrix(time, n, Caption)
                            .set_MergeCol(n, True)
                            .set_ColAlignment(n, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignCenterCenter)
                            .CellFontSize = 7
                            .CellFontBold = True
                        End If
                    Next
                    .WordWrap = True
                    '.Styles.Fixed.WordWrap = True
                End With
            Next
        End While
        dr.Close()
    End Sub

    Private Sub DisplayRoomSchedule(ByVal sRoomID As String, ByVal sTermID As Integer)
        'On Error Resume Next
        Dim num1 As Integer, num2 As Integer
        Dim sDay As String
        Dim randonGen As New Random()
        Dim Caption As String

        Dim com As New MySqlCommand("CALL GetRoomScheduleByTerm('" & sRoomID & "','" & sTermID & "')", clsCon.con)
        Dim dr As MySqlDataReader = com.ExecuteReader()
        lvRoomSchedule.Items.Clear()

        RoomGrid.Clear()

        ClassRoomGrid()

        While dr.Read()
            Dim lv As New ListViewItem(dr("SubjectTitle").ToString())
            lv.SubItems.Add(dr("Room").ToString())
            lv.SubItems.Add(dr("FacultyName").ToString())
            lv.SubItems.Add(dr("Schedule").ToString())
            lv.ForeColor = Colors(randonGen.Next(16))
            lvRoomSchedule.Items.AddRange(New ListViewItem() {lv})


            If dr("Schedule").ToString() <> "" Then
                Caption = dr("FacultyName").ToString() & vbNewLine & dr("Section").ToString() & vbNewLine & dr("SubjectTitle").ToString()
            Else
                Caption = ""
            End If

            num1 = TimeToInt(dr("Time_Start").ToString())
            num2 = TimeToInt(dr("Time_End").ToString())

            sDay = dr("Days").ToString()

            For time As Integer = num1 To num2
                With RoomGrid
                    .AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
                    .set_ColAlignment(0, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignLeftCenter)

                    For i = 1 To Len(dr("DAYS").ToString())
                        If dr("Days").ToString() Like "*" & Microsoft.VisualBasic.Mid(sDay, i, 1) & "*" Then
                            Dim n As Integer = Microsoft.VisualBasic.Mid(sDay, i, 1)

                            .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpBackColor, time, n, lv.ForeColor)

                            .set_TextMatrix(time, n, Caption)
                            .set_MergeCol(n, True)
                            .set_ColAlignment(n, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignCenterCenter)
                            .CellFontSize = 7
                            .CellFontBold = True
                        End If
                    Next
                    .WordWrap = True
                    '.Styles.Fixed.WordWrap = True
                End With
            Next
        End While
        dr.Close()
    End Sub

    Private Sub DisplaySectionSchedule(ByVal sSectionOfferingID As String)
        Dim num1, num2 As Integer ' SchedTimeEnd -SchedTimeStart
        Dim num21, num22 As Integer 'SchetTimeEnd2 - SchedTimeStart2
        Dim num31, num32 As Integer
        Dim num41, num42 As Integer
        Dim num51, num52 As Integer

        Dim randonGen As New Random()
        Dim sDay, sDay2, sDay3, sDay4, sDay5 As String

        Dim Caption1 As String = ""
        Dim Caption2 As String = ""
        Dim Caption3 As String = ""
        Dim Caption4 As String = ""
        Dim Caption5 As String = ""

        Dim sSQL As String = "CALL GetClassSchedule('" & sSectionOfferingID & "')"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim dr As MySqlDataReader = com.ExecuteReader()
        lvSchedule.Items.Clear()

        clsGrid.Clear()

        ClassSectionGrid()

        While dr.Read()
            Dim lv As New ListViewItem(dr("SubjectTitle").ToString())
            lv.SubItems.Add(dr("SubjectTitle").ToString())
            lvSchedule.Items.AddRange(New ListViewItem() {lv})

            For i As Integer = 0 To lvSchedule.Items.Count - 1
                lvSchedule.Items(i).ForeColor = Colors(i)
            Next

            If dr("Sched1").ToString() <> "" Then
                If dr("Room1").ToString() <> "" Then
                    Caption1 = "- Sched 1 -" & vbNewLine & dr("SubjectCode").ToString() & vbNewLine & dr("Faculty")
                    num1 = TimeToInt(dr("Time_Start1").ToString())
                    num2 = TimeToInt(dr("Time_End1").ToString())
                End If
            End If

            If dr("Sched2").ToString() <> "" Then
                If dr("Room2").ToString() <> "" Then
                    Caption2 = "- Sched 2 -" & vbNewLine & dr("SubjectCode").ToString() & vbNewLine & dr("Faculty")

                    num21 = TimeToInt(dr("Time_Start2").ToString())
                    num22 = TimeToInt(dr("Time_End2").ToString())
                End If
            End If

            If dr("Sched3").ToString() <> "" Then
                If dr("Room3").ToString() <> "" Then
                    Caption3 = "- Sched 3 -" & dr("SubjectCode").ToString() & vbNewLine & dr("Faculty")

                    num31 = TimeToInt(dr("Time_Start3").ToString())
                    num32 = TimeToInt(dr("Time_End3").ToString())
                End If
            End If

            If dr("Sched4").ToString() <> "" Then
                If dr("Room4").ToString() <> "" Then
                    Caption4 = "- Sched 4 -" & dr("SubjectCode").ToString() & vbNewLine & dr("Faculty")

                    num41 = TimeToInt(dr("Time_Start4").ToString())
                    num42 = TimeToInt(dr("Time_End4").ToString())
                End If
            End If

            If dr("Sched5").ToString() <> "" Then
                If dr("Room5").ToString() <> "" Then
                    Caption5 = "- Sched 5 -" & dr("SubjectCode").ToString() & vbNewLine & dr("Faculty")

                    num51 = TimeToInt(dr("Time_Start5").ToString())
                    num52 = TimeToInt(dr("Time_End5").ToString())
                End If
            End If



            With clsGrid
                .AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
                .set_ColAlignment(0, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignCenterCenter)


                If dr("Days1").ToString <> "" And dr("Days2").ToString() <> "" And dr("Days3").ToString() <> "" And dr("Days4").ToString() <> "" And dr("Days5").ToString() <> "" Then
                    sDay = dr("Days1").ToString()
                    sDay2 = dr("Days2").ToString()
                    sDay3 = dr("Days3").ToString()
                    sDay4 = dr("Days4").ToString()
                    sDay5 = dr("Days5").ToString()

                    For time As Integer = num51 To num52
                        For i = 1 To Len(dr("Days5").ToString())
                            If dr("Days5").ToString() Like "*" & Microsoft.VisualBasic.Mid(sDay5, i, 1) & "*" Then
                                Dim n As Integer = Microsoft.VisualBasic.Mid(sDay5, i, 1)

                                .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpBackColor, time, n, lv.ForeColor)
                                .set_TextMatrix(time, n, Caption5)
                                .set_MergeCol(n, True)
                                .set_ColAlignment(n, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignCenterCenter)
                                .CellFontSize = 7
                                .CellFontBold = True
                            End If
                        Next
                        .WordWrap = True
                    Next

                    For time As Integer = num41 To num42
                        For i = 1 To Len(dr("Days4").ToString())
                            If dr("Days4").ToString() Like "*" & Microsoft.VisualBasic.Mid(sDay4, i, 1) & "*" Then
                                Dim n As Integer = Microsoft.VisualBasic.Mid(sDay4, i, 1)

                                .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpBackColor, time, n, lv.ForeColor)
                                .set_TextMatrix(time, n, Caption4)
                                .set_MergeCol(n, True)
                                .set_ColAlignment(n, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignCenterCenter)
                                .CellFontSize = 7
                                .CellFontBold = True
                            End If
                        Next
                        .WordWrap = True
                    Next

                    For time As Integer = num31 To num32
                        For i = 1 To Len(dr("Days3").ToString())
                            If dr("Days3").ToString() Like "*" & Microsoft.VisualBasic.Mid(sDay3, i, 1) & "*" Then
                                Dim n As Integer = Microsoft.VisualBasic.Mid(sDay3, i, 1)

                                .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpBackColor, time, n, lv.ForeColor)
                                .set_TextMatrix(time, n, Caption3)
                                .set_MergeCol(n, True)
                                .set_ColAlignment(n, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignCenterCenter)
                                .CellFontSize = 7
                                .CellFontBold = True
                            End If
                        Next
                        .WordWrap = True
                    Next

                    For time As Integer = num21 To num22
                        For i = 1 To Len(dr("Days2").ToString())
                            If dr("Days2").ToString() Like "*" & Microsoft.VisualBasic.Mid(sDay2, i, 1) & "*" Then
                                Dim n As Integer = Microsoft.VisualBasic.Mid(sDay2, i, 1)

                                .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpBackColor, time, n, lv.ForeColor)
                                .set_TextMatrix(time, n, Caption2)
                                .set_MergeCol(n, True)
                                .set_ColAlignment(n, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignCenterCenter)
                                .CellFontSize = 7
                                .CellFontBold = True
                            End If
                        Next
                        .WordWrap = True
                    Next

                    For time As Integer = num1 To num2
                        For i = 1 To Len(dr("Days1").ToString())
                            If dr("Days1").ToString() Like "*" & Microsoft.VisualBasic.Mid(sDay, i, 1) & "*" Then
                                Dim n As Integer = Microsoft.VisualBasic.Mid(sDay, i, 1)

                                .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpBackColor, time, n, lv.ForeColor)
                                .set_TextMatrix(time, n, Caption1)
                                .set_MergeCol(n, True)
                                .set_ColAlignment(n, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignCenterCenter)
                                .CellFontSize = 7
                                .CellFontBold = True
                            End If
                        Next
                        .WordWrap = True
                    Next

                End If

                If dr("Days1").ToString <> "" And dr("Days2").ToString() <> "" And dr("Days3").ToString() <> "" And dr("Days4").ToString() <> "" Then

                    sDay = dr("Days1").ToString()
                    sDay2 = dr("Days2").ToString()
                    sDay3 = dr("Days3").ToString()
                    sDay4 = dr("Days4").ToString()

                    For time As Integer = num41 To num42
                        For i = 1 To Len(dr("Days4").ToString())
                            If dr("Days4").ToString() Like "*" & Microsoft.VisualBasic.Mid(sDay4, i, 1) & "*" Then
                                Dim n As Integer = Microsoft.VisualBasic.Mid(sDay4, i, 1)

                                .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpBackColor, time, n, lv.ForeColor)
                                .set_TextMatrix(time, n, Caption4)
                                .set_MergeCol(n, True)
                                .set_ColAlignment(n, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignCenterCenter)
                                .CellFontSize = 7
                                .CellFontBold = True
                            End If
                        Next
                        .WordWrap = True
                    Next

                    For time As Integer = num31 To num32
                        For i = 1 To Len(dr("Days3").ToString())
                            If dr("Days3").ToString() Like "*" & Microsoft.VisualBasic.Mid(sDay3, i, 1) & "*" Then
                                Dim n As Integer = Microsoft.VisualBasic.Mid(sDay3, i, 1)

                                .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpBackColor, time, n, lv.ForeColor)
                                .set_TextMatrix(time, n, Caption3)
                                .set_MergeCol(n, True)
                                .set_ColAlignment(n, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignCenterCenter)
                                .CellFontSize = 7
                                .CellFontBold = True
                            End If
                        Next
                        .WordWrap = True
                    Next

                    For time As Integer = num21 To num22
                        For i = 1 To Len(dr("Days2").ToString())
                            If dr("Days2").ToString() Like "*" & Microsoft.VisualBasic.Mid(sDay2, i, 1) & "*" Then
                                Dim n As Integer = Microsoft.VisualBasic.Mid(sDay2, i, 1)

                                .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpBackColor, time, n, lv.ForeColor)
                                .set_TextMatrix(time, n, Caption2)
                                .set_MergeCol(n, True)
                                .set_ColAlignment(n, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignCenterCenter)
                                .CellFontSize = 7
                                .CellFontBold = True
                            End If
                        Next
                        .WordWrap = True
                    Next

                    For time As Integer = num1 To num2
                        For i = 1 To Len(dr("Days1").ToString())
                            If dr("Days1").ToString() Like "*" & Microsoft.VisualBasic.Mid(sDay, i, 1) & "*" Then
                                Dim n As Integer = Microsoft.VisualBasic.Mid(sDay, i, 1)

                                .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpBackColor, time, n, lv.ForeColor)
                                .set_TextMatrix(time, n, Caption1)
                                .set_MergeCol(n, True)
                                .set_ColAlignment(n, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignCenterCenter)
                                .CellFontSize = 7
                                .CellFontBold = True
                            End If
                        Next
                        .WordWrap = True
                    Next

                End If

                If dr("Days1").ToString <> "" And dr("Days2").ToString() <> "" And dr("Days3").ToString() <> "" Then

                    sDay = dr("Days1").ToString()
                    sDay2 = dr("Days2").ToString()
                    sDay3 = dr("Days3").ToString()

                    For time As Integer = num31 To num32
                        For i = 1 To Len(dr("Days3").ToString())
                            If dr("Days3").ToString() Like "*" & Microsoft.VisualBasic.Mid(sDay3, i, 1) & "*" Then
                                Dim n As Integer = Microsoft.VisualBasic.Mid(sDay3, i, 1)

                                .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpBackColor, time, n, lv.ForeColor)
                                .set_TextMatrix(time, n, Caption2)
                                .set_MergeCol(n, True)
                                .set_ColAlignment(n, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignCenterCenter)
                                .CellFontSize = 7
                                .CellFontBold = True
                            End If
                        Next
                        .WordWrap = True
                    Next

                    For time As Integer = num21 To num22
                        For i = 1 To Len(dr("Days2").ToString())
                            If dr("Days2").ToString() Like "*" & Microsoft.VisualBasic.Mid(sDay2, i, 1) & "*" Then
                                Dim n As Integer = Microsoft.VisualBasic.Mid(sDay2, i, 1)

                                .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpBackColor, time, n, lv.ForeColor)
                                .set_TextMatrix(time, n, Caption2)
                                .set_MergeCol(n, True)
                                .set_ColAlignment(n, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignCenterCenter)
                                .CellFontSize = 7
                                .CellFontBold = True
                            End If
                        Next
                        .WordWrap = True
                    Next

                    For time As Integer = num1 To num2
                        For i = 1 To Len(dr("Days1").ToString())
                            If dr("Days1").ToString() Like "*" & Microsoft.VisualBasic.Mid(sDay, i, 1) & "*" Then
                                Dim n As Integer = Microsoft.VisualBasic.Mid(sDay, i, 1)

                                .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpBackColor, time, n, lv.ForeColor)
                                .set_TextMatrix(time, n, Caption1)
                                .set_MergeCol(n, True)
                                .set_ColAlignment(n, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignCenterCenter)
                                .CellFontSize = 7
                                .CellFontBold = True
                            End If
                        Next
                        .WordWrap = True
                    Next
                End If


                If dr("Days1").ToString <> "" And dr("Days2").ToString() <> "" Then

                    sDay = dr("Days1").ToString()
                    sDay2 = dr("Days2").ToString()

                    For time As Integer = num21 To num22
                        For i = 1 To Len(dr("Days2").ToString())
                            If dr("Days2").ToString() Like "*" & Microsoft.VisualBasic.Mid(sDay2, i, 1) & "*" Then
                                Dim n As Integer = Microsoft.VisualBasic.Mid(sDay2, i, 1)

                                .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpBackColor, time, n, lv.ForeColor)
                                .set_TextMatrix(time, n, Caption2)
                                .set_MergeCol(n, True)
                                .set_ColAlignment(n, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignCenterCenter)
                                .CellFontSize = 7
                                .CellFontBold = True
                            End If
                        Next
                        .WordWrap = True
                    Next

                    For time As Integer = num1 To num2
                        For i = 1 To Len(dr("Days1").ToString())
                            If dr("Days1").ToString() Like "*" & Microsoft.VisualBasic.Mid(sDay, i, 1) & "*" Then
                                Dim n As Integer = Microsoft.VisualBasic.Mid(sDay, i, 1)

                                .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpBackColor, time, n, lv.ForeColor)
                                .set_TextMatrix(time, n, Caption1)
                                .set_MergeCol(n, True)
                                .set_ColAlignment(n, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignCenterCenter)
                                .CellFontSize = 7
                                .CellFontBold = True
                            End If
                        Next
                        .WordWrap = True
                    Next

                End If




                If dr("Days1").ToString <> "" Then
                    sDay = dr("Days1").ToString()

                    For time As Integer = num1 To num2
                        For i = 1 To Len(dr("Days1").ToString())
                            If dr("Days1").ToString() Like "*" & Microsoft.VisualBasic.Mid(sDay, i, 1) & "*" Then
                                Dim n As Integer = Microsoft.VisualBasic.Mid(sDay, i, 1)

                                .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpBackColor, time, n, lv.ForeColor)
                                .set_TextMatrix(time, n, Caption1)
                                .set_MergeCol(n, True)
                                .set_ColAlignment(n, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignCenterCenter)
                                .CellFontSize = 7
                                .CellFontBold = True
                            End If
                        Next
                        .WordWrap = True
                    Next
                End If


            End With

        End While
        dr.Close()
    End Sub


    Private Sub frmScheduler_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        fillMultiColumnCombo2(cboCampus, "SELECT CampusName,CampusID FROM tblCampus")
        fillMultiColumnCombo2(cboSY, "SELECT fnAcademicYearTerm(TermID), TermID FROM tblAYTerm")

        ClassRoomGrid()
        ClassSectionGrid()
        FacultyGrid()

        State = ScheduleState.OneScheduleState
        SchedPrint = SchedulePrint.ClassSchedule

        dtpFrom.Text = "00:00:00 AM"
        dtpTo.Text = "00:00:00 AM"

        dtpFrom2.Text = "00:00:00 AM"
        dtpTo2.Text = "00:00:00 AM"

        dtpFrom2.Text = "00:00:00 AM"
        dtpTo2.Text = "00:00:00 AM"

        dtpFrom2.Text = "00:00:00 AM"
        dtpTo2.Text = "00:00:00 AM"

        dtpFrom2.Text = "00:00:00 AM"
        dtpTo2.Text = "00:00:00 AM"

    End Sub


    Public Sub Form_Save()

        newSubjectOffering.SectionID = txtSectionID.Text
        newSubjectOffering.SubjectID = txtSubjectID.Text

        If GetSubjectOfferingBySectionIDSubjectID(txtSubjectID.Text, txtSectionID.Text, newSubjectOffering.SubjectOfferingID) <> TranDBResult.Success Then
            MsgBox("Invalid Subject Offering...Either not found in the record", vbExclamation)
            Exit Sub
        End If


        For Each lv As ListViewItem In clbDay.Items
            If lv.Checked = True Then State = ScheduleState.OneScheduleState
        Next

        For Each lv As ListViewItem In clbDay2.Items
            If lv.Checked = True Then State = ScheduleState.TwoScheduleState
        Next

        For Each lv As ListViewItem In clbDay3.Items
            If lv.Checked = True Then State = ScheduleState.ThreeScheduleState
        Next

        For Each lv As ListViewItem In clbDay4.Items
            If lv.Checked = True Then State = ScheduleState.FourScheduleState
        Next

        For Each lv As ListViewItem In clbDay5.Items
            If lv.Checked = True Then State = ScheduleState.FiveScheduleState
        Next



        Select Case State
            Case ScheduleState.OneScheduleState
                xSched1()
            Case ScheduleState.TwoScheduleState
                xSched1()
                xSched2()
            Case ScheduleState.ThreeScheduleState
                xSched1()
                xSched2()
                xSched3()
            Case ScheduleState.FourScheduleState
                xSched1()
                xSched2()
                xSched3()
                xSched4()
            Case ScheduleState.FiveScheduleState
                xSched1()
                xSched2()
                xSched3()
                xSched4()
                xSched5()
        End Select

        'ClearItems()

    End Sub

    Private Sub xSched1()

        Dim curSchedTimeEnd As Integer
        Dim curSchedTimeStart As Integer
        Dim days As Boolean() = New Boolean(6) {}


        For i As Integer = 0 To clbDay.Items.Count - 1
            days(i) = clbDay.Items(i).Checked
        Next

        Dim daysOfWeek As New Days(days)

        curSchedTimeStart = toMilitaryTime(dtpFrom.Value.ToString("HH:mm:ss"))
        curSchedTimeEnd = toMilitaryTime(dtpTo.Value.ToString("HH:mm:ss"))

        If curSchedTimeStart < 1 Then
            MsgBox("Please enter the Start Time for " & lblCaption1.Text & vbNewLine & vbNewLine & "Click [OK] to continue.....", vbExclamation)
            Exit Sub
        End If

        If curSchedTimeEnd < 1 Then
            MsgBox("Please enter the End Time for " & lblCaption1.Text & vbNewLine & vbNewLine & "Click [OK] to continue.....", vbExclamation)
            Exit Sub
        End If


        If clbDay.CheckedItems.Count < 1 Then
            MsgBox("SCHEDULE [1]: " & vbNewLine & "Choose at least one day of the week.", vbInformation, "ERROR")
            Exit Sub
        End If

        If chkOverride1.Checked <> True Then
            If cboRoom1.Text = "" Then
                newSubjectOffering.RoomID = ""
            Else
                newSubjectOffering.RoomID = cboRoom1.SelectedItem.Col2
            End If

            GoTo CheckRoom1

sFaculty1:
            If cboFaculty1.Text = "" Then
                newSubjectOffering.TeacherID = ""
            Else
                newSubjectOffering.TeacherID = cboFaculty1.SelectedItem.Col2
            End If

            GoTo CheckFaculty1

        End If

sOffering1:

        newSubjectOffering.Days = daysOfWeek.ToInteger()
        newSubjectOffering.SchedTimeStart = curSchedTimeStart
        newSubjectOffering.SchedTimeEnd = curSchedTimeEnd
        newSubjectOffering.OverrideConflict = BooleanToInt(chkOverride1.Checked)
        newSubjectOffering.IsSpecialClass = BooleanToInt(chkSpecial1.Checked)

        If cboEvent1.Text = "" Then
            newSubjectOffering.Event1 = ""
        Else
            newSubjectOffering.Event1 = cboEvent1.SelectedIndex + 1
        End If

        newSubjectOffering.Sched1 = daysOfWeek.ToChar() & " " & MilitaryToStandard(curSchedTimeStart) & "-" & MilitaryToStandard(curSchedTimeEnd)
        newSubjectOffering.IsDissolved = 0


        If chkSpecial1.Checked Then
            newSubjectOffering.IsSpecialClass = 1
        End If


        Select Case AddSchedule1(newSubjectOffering)
            Case TranDBResult.Success
                MsgBox("SCHEDULE [1]: " & vbNewLine & "Subject Offering successfully saved", vbInformation)
                RecordSaved = True

                DisplaySectionSchedule(txtSectionID.Text)

            Case TranDBResult.DuplicateID
                MsgBox("SCHEDULE [1]: " & vbNewLine & "This Subject Offering Entry is already exist in record." & vbNewLine & "Please select another subject to offer.", vbExclamation)
        End Select

        Exit Sub

CheckRoom1:
        If cboRoom1.Text = "" Then
            If RoomInUse1(curSchedTimeStart, curSchedTimeEnd, "", daysOfWeek.ToInteger(), cboSY.SelectedItem.Col2) = True Then
                Dim frm As New frmConflict()
                frm.ShowForm("Room", txtOfferingID.Text, lblCaption1.Text, "", daysOfWeek.ToInteger(), curSchedTimeStart, curSchedTimeEnd, cboFaculty1.SelectedItem.Col2, cboSY.SelectedItem.Col2)
                Exit Sub
            End If
        Else
            If RoomInUse1(curSchedTimeStart, curSchedTimeEnd, cboRoom1.SelectedItem.Col2, daysOfWeek.ToInteger(), cboSY.SelectedItem.Col2) = True Then
                'MsgBox("SCHEDULE [1] " & vbNewLine & "WARNING: Conflict found on selected room!!! " & vbNewLine & "[" & cboBuilding.Text & "-" & cboRoom1.Text & "]", vbExclamation)

                Dim frm As New frmConflict()
                chkOverride1.Checked = frm.ShowForm("Room", txtOfferingID.Text, lblCaption1.Text, cboRoom1.SelectedItem.Col2, daysOfWeek.ToInteger(), curSchedTimeStart, curSchedTimeEnd, cboFaculty1.SelectedItem.Col2, cboSY.SelectedItem.Col2)
                Exit Sub
            End If
        End If
        GoTo sFaculty1

CheckFaculty1:

        If cboFaculty1.Text = "" Then
            If FacultyInUse1(curSchedTimeStart, curSchedTimeEnd, "", daysOfWeek.ToInteger(), cboSY.SelectedItem.Col2) = True Then
                Dim frm As New frmConflict()
                chkOverride1.Checked = frm.ShowForm("Faculty", txtOfferingID.Text, lblCaption1.Text, cboRoom1.SelectedItem.Col2, daysOfWeek.ToInteger(), curSchedTimeStart, curSchedTimeEnd, cboFaculty1.SelectedItem.Col2, cboSY.SelectedItem.Col2)
                Exit Sub
            End If
        Else
            If FacultyInUse1(curSchedTimeStart, curSchedTimeEnd, cboFaculty1.SelectedItem.Col2, daysOfWeek.ToInteger(), cboSY.SelectedItem.Col2) = True Then
                'MsgBox("SCHEDULE [1] " & vbNewLine & "WARNING: Conflict found on assigned teacher!!! " & vbNewLine & "[" & cboFaculty1.Text & "]", vbExclamation)
                Dim frm As New frmConflict()
                chkOverride1.Checked = frm.ShowForm("Faculty", txtOfferingID.Text, lblCaption1.Text, cboFaculty1.SelectedItem.Col2, daysOfWeek.ToInteger(), curSchedTimeStart, curSchedTimeEnd, cboFaculty1.SelectedItem.Col2, cboSY.SelectedItem.Col2)
                Exit Sub
            End If
        End If
        GoTo sOffering1

    End Sub
    Private Sub xSched2()

        Dim curSchedTimeStart2 As Integer
        Dim curSchedTimeEnd2 As Integer

        Dim days2 As Boolean() = New Boolean(6) {}

        For i As Integer = 0 To clbDay2.Items.Count - 1
            days2(i) = clbDay2.Items(i).Checked
        Next

        Dim daysOfWeek2 As New Days(days2)


        curSchedTimeStart2 = toMilitaryTime(dtpFrom2.Value.ToString("HH:mm:ss"))
        curSchedTimeEnd2 = toMilitaryTime(dtpTo2.Value.ToString("HH:mm:ss"))

        If curSchedTimeStart2 < 1 Then
            MsgBox("Please enter the Start Time for " & lblCaption2.Text & vbNewLine & vbNewLine & "Click [OK] to continue.....", vbExclamation)
            Exit Sub
        End If

        If curSchedTimeEnd2 < 1 Then
            MsgBox("Please enter the End Time for " & lblCaption2.Text & vbNewLine & vbNewLine & "Click [OK] to continue.....", vbExclamation)
            Exit Sub
        End If

        If clbDay2.CheckedItems.Count < 1 Then
            MsgBox("SCHEDULE [2]: " & vbNewLine & "Choose at least one day of the week.", vbInformation, "ERROR")
            Exit Sub
        End If

        If chkOverride2.Checked <> True Then
            If cboRoom2.Text = "" Then
                newSubjectOffering.RoomID2 = ""
            Else
                newSubjectOffering.RoomID2 = cboRoom2.SelectedItem.Col2
            End If

            GoTo CheckRoom2

sFaculty2:
            If cboFaculty2.Text = "" Then
                newSubjectOffering.TeacherID2 = ""
            Else
                newSubjectOffering.TeacherID2 = cboFaculty2.SelectedItem.Col2
            End If

            GoTo CheckFaculty2
        End If

sOffering2:
        newSubjectOffering.Days2 = daysOfWeek2.ToInteger()
        newSubjectOffering.SchedTimeStart2 = curSchedTimeStart2
        newSubjectOffering.SchedTimeEnd2 = curSchedTimeEnd2
        newSubjectOffering.OverrideConflict = BooleanToInt(chkOverride2.Checked)
        newSubjectOffering.IsSpecialClass = BooleanToInt(chkSpecial2.Checked)

        If cboEvent2.Text = "" Then
            newSubjectOffering.Event2 = ""
        Else
            newSubjectOffering.Event2 = cboEvent2.SelectedIndex + 1
        End If

        newSubjectOffering.Sched2 = daysOfWeek2.ToChar() & " " & MilitaryToStandard(curSchedTimeStart2) & "-" & MilitaryToStandard(curSchedTimeEnd2)
        newSubjectOffering.IsDissolved = 0

        Select Case AddSchedule2(newSubjectOffering)
            Case TranDBResult.Success
                MsgBox("SCHEDULE [2]: " & vbNewLine & "Subject Offering successfully saved", vbInformation)
                RecordSaved = True
                DisplaySectionSchedule(txtSectionID.Text)

            Case TranDBResult.DuplicateID
                MsgBox("SCHEDULE [2]: " & vbNewLine & "This Subject Offering Entry is already exist in record." & vbNewLine & "Please select another subject to offer.", vbExclamation)
        End Select
        Exit Sub

CheckRoom2:
        If cboRoom2.Text = "" Then
            If RoomInUse2(curSchedTimeStart2, curSchedTimeEnd2, "", daysOfWeek2.ToInteger(), cboSY.SelectedItem.Col2) = True Then
                MsgBox("SCHEDULE [2] " & vbNewLine & "WARNING: Conflict found on selected room!!! " & vbNewLine & "[" & cboBuilding2.Text & "-" & cboRoom2.Text & "]", vbExclamation)
                Exit Sub
            End If
        Else
            If RoomInUse2(curSchedTimeStart2, curSchedTimeEnd2, cboRoom2.SelectedItem.Col2, daysOfWeek2.ToInteger(), cboSY.SelectedItem.Col2) = True Then
                MsgBox("SCHEDULE [2] " & vbNewLine & "WARNING: Conflict found on selected room!!! " & vbNewLine & "[" & cboBuilding2.Text & "-" & cboRoom2.Text & "]", vbExclamation)
                Exit Sub
            End If
        End If

        GoTo sFaculty2

CheckFaculty2:
        If cboFaculty2.Text = "" Then
            If FacultyInUse2(curSchedTimeStart2, curSchedTimeEnd2, "", daysOfWeek2.ToInteger(), cboSY.SelectedItem.Col2) = True Then
                MsgBox("SCHEDULE [2] " & vbNewLine & "WARNING: Conflict found on assigned teacher!!! " & vbNewLine & "[" & cboFaculty2.Text & "]", vbExclamation)
                Exit Sub
            End If
        Else
            If FacultyInUse2(curSchedTimeStart2, curSchedTimeEnd2, cboFaculty2.SelectedItem.Col2, daysOfWeek2.ToInteger(), cboSY.SelectedItem.Col2) = True Then
                MsgBox("SCHEDULE [2] " & vbNewLine & "WARNING: Conflict found on assigned teacher!!! " & vbNewLine & "[" & cboFaculty2.Text & "]", vbExclamation)
                Exit Sub
            End If
        End If


        GoTo sOffering2

    End Sub
    Private Sub xSched3()

        Dim curSchedTimeStart3 As Integer
        Dim curSchedTimeEnd3 As Integer

        Dim days3 As Boolean() = New Boolean(6) {}

        For i As Integer = 0 To clbDay3.Items.Count - 1
            days3(i) = clbDay3.Items(i).Checked
        Next
        Dim daysOfWeek3 As New Days(days3)

        curSchedTimeStart3 = toMilitaryTime(dtpFrom3.Value.ToString("HH:mm:ss"))
        curSchedTimeEnd3 = toMilitaryTime(dtpTo3.Value.ToString("HH:mm:ss"))

        If curSchedTimeStart3 < 1 Then
            MsgBox("Please enter the Start Time for " & lblCaption3.Text & vbNewLine & vbNewLine & "Click [OK] to continue.....", vbExclamation)
            Exit Sub
        End If

        If curSchedTimeEnd3 < 1 Then
            MsgBox("Please enter the End Time for " & lblCaption3.Text & vbNewLine & vbNewLine & "Click [OK] to continue.....", vbExclamation)
            Exit Sub
        End If

        If clbDay3.CheckedItems.Count < 1 Then
            MsgBox("SCHEDULE [3]: " & vbNewLine & "Choose at least one day of the week.", vbInformation, "ERROR")
            Exit Sub
        End If

        If chkOverride3.Checked <> True Then
            If cboRoom3.Text = "" Then
                newSubjectOffering.RoomID3 = ""
            Else
                newSubjectOffering.RoomID3 = cboRoom3.SelectedItem.Col2
            End If

            GoTo CheckRoom3

sFaculty3:
            If cboFaculty3.Text = "" Then
                newSubjectOffering.TeacherID3 = ""
            Else
                newSubjectOffering.TeacherID3 = cboFaculty3.SelectedItem.Col2
            End If

            GoTo CheckFaculty3
        End If

sOffering3:
        newSubjectOffering.Days3 = daysOfWeek3.ToInteger()
        newSubjectOffering.SchedTimeStart3 = curSchedTimeStart3
        newSubjectOffering.SchedTimeEnd3 = curSchedTimeEnd3
        newSubjectOffering.OverrideConflict = BooleanToInt(chkOverride3.Checked)
        newSubjectOffering.IsSpecialClass = BooleanToInt(chkSpecial3.Checked)

        If cboEvent3.Text = "" Then
            newSubjectOffering.Event3 = ""
        Else
            newSubjectOffering.Event3 = cboEvent3.SelectedIndex + 1
        End If

        newSubjectOffering.Sched3 = daysOfWeek3.ToChar() & " " & MilitaryToStandard(curSchedTimeStart3) & "-" & MilitaryToStandard(curSchedTimeEnd3)
        newSubjectOffering.IsDissolved = 0

        Select Case AddSchedule3(newSubjectOffering)
            Case TranDBResult.Success
                MsgBox("SCHEDULE [3]: " & vbNewLine & "Subject Offering successfully saved", vbInformation)
                RecordSaved = True
                DisplaySectionSchedule(txtSectionID.Text)

            Case TranDBResult.DuplicateID
                MsgBox("SCHEDULE [3]: " & vbNewLine & "This Subject Offering Entry is already exist in record." & vbNewLine & "Please select another subject to offer.", vbExclamation)
        End Select
        Exit Sub


CheckRoom3:
        If cboRoom3.Text = "" Then
            If RoomInUse3(curSchedTimeStart3, curSchedTimeEnd3, "", daysOfWeek3.ToInteger(), cboSY.SelectedItem.Col2) = True Then
                MsgBox("SCHEDULE [3] " & vbNewLine & "WARNING: Conflict found on selected room!!! " & vbNewLine & "[" & cboBuilding3.Text & "-" & cboRoom3.Text & "]", vbExclamation)
                Exit Sub
            End If
        Else
            If RoomInUse3(curSchedTimeStart3, curSchedTimeEnd3, cboRoom3.SelectedItem.Col2, daysOfWeek3.ToInteger(), cboSY.SelectedItem.Col2) = True Then
                MsgBox("SCHEDULE [3] " & vbNewLine & "WARNING: Conflict found on selected room!!! " & vbNewLine & "[" & cboBuilding3.Text & "-" & cboRoom3.Text & "]", vbExclamation)
                Exit Sub
            End If
        End If

        GoTo sFaculty3

CheckFaculty3:
        If cboFaculty3.Text = "" Then
            If FacultyInUse3(curSchedTimeStart3, curSchedTimeEnd3, "", daysOfWeek3.ToInteger(), cboSY.SelectedItem.Col2) = True Then
                MsgBox("SCHEDULE [3] " & vbNewLine & "WARNING: Conflict found on assigned teacher!!! " & vbNewLine & "[" & cboFaculty3.Text & "]", vbExclamation)
                Exit Sub
            End If
        Else
            If FacultyInUse3(curSchedTimeStart3, curSchedTimeEnd3, cboFaculty3.SelectedItem.Col2, daysOfWeek3.ToInteger(), cboSY.SelectedItem.Col2) = True Then
                MsgBox("SCHEDULE [3] " & vbNewLine & "WARNING: Conflict found on assigned teacher!!! " & vbNewLine & "[" & cboFaculty3.Text & "]", vbExclamation)
                Exit Sub
            End If
        End If

        GoTo sOffering3
    End Sub

    Private Sub xSched4()

        Dim curSchedTimeStart4 As Integer
        Dim curSchedTimeEnd4 As Integer

        Dim days4 As Boolean() = New Boolean(6) {}

        For i As Integer = 0 To clbDay4.Items.Count - 1
            days4(i) = clbDay4.Items(i).Checked
        Next
        Dim daysOfWeek4 As New Days(days4)

        curSchedTimeStart4 = toMilitaryTime(dtpFrom4.Value.ToString("HH:mm:ss"))
        curSchedTimeEnd4 = toMilitaryTime(dtpTo4.Value.ToString("HH:mm:ss"))

        If curSchedTimeStart4 < 1 Then
            MsgBox("Please enter the Start Time for " & lblCaption4.Text & vbNewLine & vbNewLine & "Click [OK] to continue.....", vbExclamation)
            Exit Sub
        End If

        If curSchedTimeEnd4 < 1 Then
            MsgBox("Please enter the End Time for " & lblCaption4.Text & vbNewLine & vbNewLine & "Click [OK] to continue.....", vbExclamation)
            Exit Sub
        End If

        If clbDay4.CheckedItems.Count < 1 Then
            MsgBox("SCHEDULE [4]: " & vbNewLine & "Choose at least one day of the week.", vbInformation, "ERROR")
            Exit Sub
        End If

        If chkOverride4.Checked <> True Then
            If cboRoom4.Text = "" Then
                newSubjectOffering.RoomID4 = ""
            Else
                newSubjectOffering.RoomID4 = cboRoom4.SelectedItem.Col2
            End If

            GoTo CheckRoom4

sFaculty4:
            If cboFaculty4.Text = "" Then
                newSubjectOffering.TeacherID4 = ""
            Else
                newSubjectOffering.TeacherID4 = cboFaculty4.SelectedItem.Col2
            End If

            GoTo CheckFaculty4
        End If

sOffering4:
        newSubjectOffering.Days4 = daysOfWeek4.ToInteger()
        newSubjectOffering.SchedTimeStart4 = curSchedTimeStart4
        newSubjectOffering.SchedTimeEnd4 = curSchedTimeEnd4
        newSubjectOffering.OverrideConflict = BooleanToInt(chkOverride4.Checked)
        newSubjectOffering.IsSpecialClass = BooleanToInt(chkSpecial4.Checked)

        If cboEvent4.Text = "" Then
            newSubjectOffering.Event4 = ""
        Else
            newSubjectOffering.Event4 = cboEvent4.SelectedIndex + 1
        End If

        newSubjectOffering.Sched4 = daysOfWeek4.ToChar() & " " & MilitaryToStandard(curSchedTimeStart4) & "-" & MilitaryToStandard(curSchedTimeEnd4)
        newSubjectOffering.IsDissolved = 0

        Select Case AddSchedule4(newSubjectOffering)
            Case TranDBResult.Success
                MsgBox("SCHEDULE [4]: " & vbNewLine & "Subject Offering successfully saved", vbInformation)
                RecordSaved = True
                DisplaySectionSchedule(txtSectionID.Text)

            Case TranDBResult.DuplicateID
                MsgBox("SCHEDULE [4]: " & vbNewLine & "This Subject Offering Entry is already exist in record." & vbNewLine & "Please select another subject to offer.", vbExclamation)
        End Select
        Exit Sub

CheckRoom4:
        If cboRoom4.Text = "" Then
            If RoomInUse4(curSchedTimeStart4, curSchedTimeEnd4, "", daysOfWeek4.ToInteger(), cboSY.SelectedItem.Col2) = True Then
                MsgBox("SCHEDULE [4] " & vbNewLine & "WARNING: Conflict found on selected room!!! " & vbNewLine & "[" & cboBuilding4.Text & "-" & cboRoom4.Text & "]", vbExclamation)
                Exit Sub
            End If
        Else
            If RoomInUse4(curSchedTimeStart4, curSchedTimeEnd4, cboRoom4.SelectedItem.Col2, daysOfWeek4.ToInteger(), cboSY.SelectedItem.Col2) = True Then
                MsgBox("SCHEDULE [4] " & vbNewLine & "WARNING: Conflict found on selected room!!! " & vbNewLine & "[" & cboBuilding4.Text & "-" & cboRoom4.Text & "]", vbExclamation)
                Exit Sub
            End If
        End If

        GoTo sFaculty4

CheckFaculty4:
        If cboFaculty4.Text = "" Then
            If FacultyInUse4(curSchedTimeStart4, curSchedTimeEnd4, "", daysOfWeek4.ToInteger(), cboSY.SelectedItem.Col2) = True Then
                MsgBox("SCHEDULE [4] " & vbNewLine & "WARNING: Conflict found on assigned teacher!!!" & vbNewLine & "[" & cboFaculty4.Text & "]", vbExclamation)
                Exit Sub
            End If
        Else
            If FacultyInUse4(curSchedTimeStart4, curSchedTimeEnd4, cboFaculty4.SelectedItem.Col2, daysOfWeek4.ToInteger(), cboSY.SelectedItem.Col2) = True Then
                MsgBox("SCHEDULE [4] " & vbNewLine & "WARNING: Conflict found on assigned teacher!!!" & vbNewLine & "[" & cboFaculty4.Text & "]", vbExclamation)
                Exit Sub
            End If
        End If
        GoTo sOffering4
    End Sub

    Private Sub xSched5()

        Dim curSchedTimeStart5 As Integer
        Dim curSchedTimeEnd5 As Integer
        Dim days5 As Boolean() = New Boolean(6) {}

        For i As Integer = 0 To clbDay5.Items.Count - 1
            days5(i) = clbDay5.Items(i).Checked
        Next
        Dim daysOfWeek5 As New Days(days5)

        curSchedTimeStart5 = toMilitaryTime(dtpFrom5.Value.ToString("HH:mm:ss"))
        curSchedTimeEnd5 = toMilitaryTime(dtpTo5.Value.ToString("HH:mm:ss"))

        If curSchedTimeStart5 < 1 Then
            MsgBox("Please enter the Start Time for " & lblCaption5.Text & vbNewLine & vbNewLine & "Click [OK] to continue.....", vbExclamation)
            Exit Sub
        End If

        If curSchedTimeEnd5 < 1 Then
            MsgBox("Please enter the End Time for " & lblCaption5.Text & vbNewLine & vbNewLine & "Click [OK] to continue.....", vbExclamation)
            Exit Sub
        End If

        If clbDay5.CheckedItems.Count < 1 Then
            MsgBox("SCHEDULE [5]: " & vbNewLine & "Choose at least one day of the week.", vbInformation, "ERROR")
            Exit Sub
        End If

        If chkOverride5.Checked <> True Then
            If cboRoom5.Text = "" Then
                newSubjectOffering.RoomID5 = ""
            Else
                newSubjectOffering.RoomID5 = cboRoom5.SelectedItem.Col2
            End If

            GoTo CheckRoom5

sFaculty5:
            If cboFaculty5.Text = "" Then
                newSubjectOffering.TeacherID5 = ""
            Else
                newSubjectOffering.TeacherID5 = cboFaculty5.SelectedItem.Col2
            End If

            GoTo CheckFaculty5
        End If

sOffering5:
        newSubjectOffering.Days5 = daysOfWeek5.ToInteger()
        newSubjectOffering.SchedTimeStart5 = curSchedTimeStart5
        newSubjectOffering.SchedTimeEnd5 = curSchedTimeEnd5
        newSubjectOffering.OverrideConflict = BooleanToInt(chkOverride5.Checked)
        newSubjectOffering.IsSpecialClass = BooleanToInt(chkSpecial5.Checked)

        If cboEvent5.Text = "" Then
            newSubjectOffering.Event5 = ""
        Else
            newSubjectOffering.Event5 = cboEvent5.SelectedIndex + 1
        End If

        newSubjectOffering.Sched5 = daysOfWeek5.ToChar() & " " & MilitaryToStandard(curSchedTimeStart5) & "-" & MilitaryToStandard(curSchedTimeEnd5)
        newSubjectOffering.IsDissolved = 0

        Select Case AddSchedule5(newSubjectOffering)
            Case TranDBResult.Success
                MsgBox("SCHEDULE [5]: " & vbNewLine & "Subject Offering successfully saved", vbInformation)
                RecordSaved = True
                DisplaySectionSchedule(txtSectionID.Text)

            Case TranDBResult.DuplicateID
                MsgBox("SCHEDULE [5]: " & vbNewLine & "This Subject Offering Entry is already exist in record." & vbNewLine & "Please select another subject to offer.", vbExclamation)
        End Select
        Exit Sub

CheckRoom5:
        If cboRoom5.Text = "" Then
            If RoomInUse5(curSchedTimeStart5, curSchedTimeEnd5, "", daysOfWeek5.ToInteger(), cboSY.SelectedItem.Col2) = True Then
                MsgBox("SCHEDULE [5] " & vbNewLine & "WARNING: Conflict found on selected room!!!" & vbNewLine & "[" & cboBuilding5.Text & "-" & cboRoom5.Text & "]", vbExclamation)
                Exit Sub
            End If
        Else
            If RoomInUse5(curSchedTimeStart5, curSchedTimeEnd5, cboRoom5.SelectedItem.Col2, daysOfWeek5.ToInteger(), cboSY.SelectedItem.Col2) = True Then
                MsgBox("SCHEDULE [5] " & vbNewLine & "WARNING: Conflict found on selected room!!!" & vbNewLine & "[" & cboBuilding5.Text & "-" & cboRoom5.Text & "]", vbExclamation)
                Exit Sub
            End If
        End If
        GoTo sFaculty5

CheckFaculty5:
        If cboFaculty5.Text = "" Then
            If FacultyInUse5(curSchedTimeStart5, curSchedTimeEnd5, "", daysOfWeek5.ToInteger(), cboSY.SelectedItem.Col2) = True Then
                MsgBox("SCHEDULE [5] " & vbNewLine & "WARNING: Conflict found on assigned teacher!!! " & vbNewLine & "[" & cboFaculty5.Text & "]", vbExclamation)
                Exit Sub
            End If
        Else
            If FacultyInUse5(curSchedTimeStart5, curSchedTimeEnd5, cboFaculty5.SelectedItem.Col2, daysOfWeek5.ToInteger(), cboSY.SelectedItem.Col2) = True Then
                MsgBox("SCHEDULE [5] " & vbNewLine & "WARNING: Conflict found on assigned teacher!!! " & vbNewLine & "[" & cboFaculty5.Text & "]", vbExclamation)
                Exit Sub
            End If
        End If
        GoTo sOffering5

    End Sub



    Private Sub ClearItems()

        For Each lv As ListViewItem In clbDay.Items
            lv.Checked = False
            lv.BackColor = Color.White
        Next

        For Each lvs As ListViewItem In clbDay2.Items
            lvs.Checked = False
            lvs.BackColor = Color.White
        Next

        For Each lva As ListViewItem In clbDay3.Items
            lva.Checked = False
            lva.BackColor = Color.White
        Next

        For Each lvq As ListViewItem In clbDay4.Items
            lvq.Checked = False
            lvq.BackColor = Color.White
        Next

        For Each lvw As ListViewItem In clbDay5.Items
            lvw.Checked = False
            lvw.BackColor = Color.White
        Next

        cboBuilding.Text = ""
        cboRoom1.Text = ""
        cboEvent1.Text = ""
        cboFaculty1.Text = ""

        cboBuilding2.Text = ""
        cboRoom2.Text = ""
        cboEvent2.Text = ""
        cboFaculty2.Text = ""

        cboBuilding3.Text = ""
        cboRoom3.Text = ""
        cboEvent3.Text = ""
        cboFaculty3.Text = ""

        cboBuilding4.Text = ""
        cboRoom4.Text = ""
        cboEvent4.Text = ""
        cboFaculty4.Text = ""

        cboBuilding5.Text = ""
        cboRoom5.Text = ""
        cboEvent5.Text = ""
        cboFaculty5.Text = ""

        lblCaption1.Text = ""
        lblCaption2.Text = ""
        lblCaption3.Text = ""
        lblCaption4.Text = ""
        lblCaption5.Text = ""

        dtpFrom.Text = "00:00:00 AM"
        dtpTo.Text = "00:00:00 AM"

        dtpFrom2.Text = "00:00:00 AM"
        dtpTo2.Text = "00:00:00 AM"

        dtpFrom2.Text = "00:00:00 AM"
        dtpTo2.Text = "00:00:00 AM"

        dtpFrom2.Text = "00:00:00 AM"
        dtpTo2.Text = "00:00:00 AM"

        dtpFrom2.Text = "00:00:00 AM"
        dtpTo2.Text = "00:00:00 AM"

        chkOverride1.Checked = False : chkOverride2.Checked = False : chkOverride3.Checked = False
        chkOverride4.Checked = False : chkOverride5.Checked = False

        chkSpecial1.Checked = False : chkSpecial2.Checked = False : chkSpecial3.Checked = False
        chkSpecial4.Checked = False : chkSpecial5.Checked = False

    End Sub

    Private Sub cboBuilding_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBuilding.SelectedIndexChanged
        If cboBuilding.Text = "" Then Exit Sub

        fillMultiColumnCombo2(cboRoom1, "SELECT  tblroom.Room,tblroom.RoomID " & _
                                  "FROM tblroom " & _
                     "WHERE tblRoom.BldgID='" & cboBuilding.SelectedItem.Col2 & "' AND IsUsable ='1'")
    End Sub

    Private Sub cboBuilding2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBuilding2.SelectedIndexChanged
        fillMultiColumnCombo2(cboRoom2, "SELECT  tblroom.Room,tblroom.RoomID " & _
                                 "FROM tblroom " & _
                    "WHERE tblRoom.BldgID='" & cboBuilding2.SelectedItem.Col2 & "' AND IsUsable ='1'")
    End Sub

    Private Sub cboBuilding3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBuilding3.SelectedIndexChanged
        fillMultiColumnCombo2(cboRoom3, "SELECT  tblroom.Room,tblroom.RoomID " & _
                                    "FROM tblroom " & _
                       "WHERE tblRoom.BldgID='" & cboBuilding3.SelectedItem.Col2 & "' AND IsUsable ='1'")
    End Sub

    Private Sub cboBuilding4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBuilding4.SelectedIndexChanged
        fillMultiColumnCombo2(cboRoom4, "SELECT  tblroom.Room,tblroom.RoomID " & _
                                  "FROM tblroom " & _
                     "WHERE tblRoom.BldgID='" & cboBuilding4.SelectedItem.Col2 & "' AND IsUsable ='1'")
    End Sub

    Private Sub cboBuilding5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBuilding5.SelectedIndexChanged
        On Error Resume Next
        fillMultiColumnCombo2(cboRoom5, "SELECT  tblroom.Room,tblroom.RoomID " & _
                                 "FROM tblroom " & _
                    "WHERE tblRoom.BldgID='" & cboBuilding5.SelectedItem.Col2 & "' AND IsUsable ='1'")
    End Sub

    Private Sub cmSaved_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        Select Case sFormState
            Case FormState.addFormState
                Form_Save()
            Case FormState.updateFormState

        End Select

    End Sub


    Private Sub cboCampus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCampus.SelectedIndexChanged

        fillMultiColumnCombo4(cboPrograms, "SELECT ProgName,ProgID,ProgCode,fnCollegeCode(CollegeID) FROM tblPrograms WHERE CampusID='" & cboCampus.SelectedItem.Col2 & "'")

        fillMultiColumnCombo2(cboBuilding, "SELECT BldgName,BldgID FROM tblBuilding WHERE CampusID='" & cboCampus.SelectedItem.Col2 & "' ORDER BY BldgID")
        fillMultiColumnCombo2(cboBuilding2, "SELECT BldgName,BldgID FROM tblBuilding WHERE CampusID='" & cboCampus.SelectedItem.Col2 & "' ORDER BY BldgID")
        fillMultiColumnCombo2(cboBuilding3, "SELECT BldgName,BldgID FROM tblBuilding WHERE CampusID='" & cboCampus.SelectedItem.Col2 & "' ORDER BY BldgID")
        fillMultiColumnCombo2(cboBuilding4, "SELECT BldgName,BldgID FROM tblBuilding WHERE CampusID='" & cboCampus.SelectedItem.Col2 & "' ORDER BY BldgID")
        fillMultiColumnCombo2(cboBuilding5, "SELECT BldgName,BldgID FROM tblBuilding WHERE CampusID='" & cboCampus.SelectedItem.Col2 & "' ORDER BY BldgID")

        fillMultiColumnCombo2(cboCampusBuilding, "SELECT BldgName,BldgID FROM tblBuilding WHERE CampusID='" & cboCampus.SelectedItem.Col2 & "' ORDER BY BldgID")

        fillMultiColumnCombo2(cboFaculty1, "SELECT fnEmployeeName(EmployeeID), TeacherID FROM tblTeacher WHERE CampusID='" & cboCampus.SelectedItem.Col2 & "' ORDER BY TeacherID")
        fillMultiColumnCombo2(cboFaculty2, "SELECT fnEmployeeName(EmployeeID), TeacherID FROM tblTeacher WHERE CampusID='" & cboCampus.SelectedItem.Col2 & "' ORDER BY TeacherID")
        fillMultiColumnCombo2(cboFaculty3, "SELECT fnEmployeeName(EmployeeID), TeacherID FROM tblTeacher WHERE CampusID='" & cboCampus.SelectedItem.Col2 & "' ORDER BY TeacherID")
        fillMultiColumnCombo2(cboFaculty4, "SELECT fnEmployeeName(EmployeeID), TeacherID FROM tblTeacher WHERE CampusID='" & cboCampus.SelectedItem.Col2 & "' ORDER BY TeacherID")
        fillMultiColumnCombo2(cboFaculty5, "SELECT fnEmployeeName(EmployeeID), TeacherID FROM tblTeacher WHERE CampusID='" & cboCampus.SelectedItem.Col2 & "' ORDER BY TeacherID")

        FillListView("SELECT fnEmployeeName(EmployeeID),TeacherID,fnCollegeName(CollegeID),IsFullTime FROM tblTeacher WHERE CampusID='" & cboCampus.SelectedItem.Col2 & "' ORDER BY TeacherID", lvFaculty, False)

    End Sub

    Private Sub cboPrograms_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPrograms.SelectedIndexChanged
        If cboPrograms.Text = "" Then Exit Sub

        FillClassSection(cboPrograms.SelectedItem.Col2)
    End Sub
    Private Sub FillClassSection(ByVal sProgramID As String)
        Dim com As New MySqlCommand("SELECT SectionTitle,SectionID,fnYearLevel(YearLevelID) AS YearLevel,YearLevelID FROM tblSection WHERE ProgramID='" & sProgramID & "' AND CampusID='" & cboCampus.SelectedItem.Col2 & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        dgSection.Rows.Clear()
        While vRS.Read()
            Dim n As Integer = dgSection.Rows.Add()
            dgSection.Rows(n).Cells(0).Value = vRS("SectionTitle").ToString()
            dgSection.Rows(n).Cells(1).Value = vRS("SectionID").ToString()
            dgSection.Rows(n).Cells(2).Value = vRS("YearLevel").ToString()
            dgSection.Rows(n).Cells(3).Value = vRS("YearLevelID").ToString()
            dgSection.FirstDisplayedScrollingRowIndex = n
            dgSection.CurrentCell = dgSection.Rows(n).Cells(0)
            dgSection.Rows(n).Selected = True
        End While
        vRS.Close()
    End Sub

    Private Sub FillSubjectOffering(ByVal sSEctionID As String, ByVal sTermID As String, ByVal CampusID As String, ByVal sProgramID As String)
        Dim com As New MySqlCommand("SELECT SUB.SubjectCode,SUB.SubjectID,SUB.Description,SUB.CreditUnits,CD.SubjectOfferingID FROM tblSection AS S " & _
                                    "INNER JOIN tblClassSchedule AS CD ON S.SectionID = CD.SectionID " & _
                                    "INNER JOIN tblsubject AS SUB ON SUB.SubjectID = CD.SubjectID " & _
                                    "WHERE S.SectionID='" & sSEctionID & "' AND S.TermID='" & sTermID & "' AND S.CampusID='" & CampusID & "'" & _
                                    "AND S.ProgramID = '" & sProgramID & "'", con)

        Dim vRS As MySqlDataReader = com.ExecuteReader()
        dgSubjectOffered.Rows.Clear()
        While vRS.Read()
            Dim n As Integer = dgSubjectOffered.Rows.Add()
            dgSubjectOffered.Rows(n).Cells(0).Value = vRS("SubjectCode").ToString()
            dgSubjectOffered.Rows(n).Cells(1).Value = vRS("SubjectID").ToString()
            dgSubjectOffered.Rows(n).Cells(2).Value = vRS("Description").ToString()
            dgSubjectOffered.Rows(n).Cells(3).Value = vRS("CreditUnits").ToString()
            dgSubjectOffered.Rows(n).Cells(4).Value = vRS("SubjectOfferingID").ToString()
            dgSubjectOffered.FirstDisplayedScrollingRowIndex = n
            dgSubjectOffered.CurrentCell = dgSubjectOffered.Rows(n).Cells(0)
            dgSubjectOffered.Rows(n).Selected = True
        End While
        vRS.Close()
    End Sub

    Private Sub dgSection_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgSection.CellClick
        Dim n As Integer = dgSection.CurrentRow.Index
        Dim sum As Integer = 0

        If dgSection.RowCount > 0 Then

            ClearItems()

            txtSectionID.Text = dgSection.Rows(n).Cells(1).Value

            FillSubjectOffering(dgSection.Rows(n).Cells(1).Value, cboSY.SelectedItem.Col2, cboCampus.SelectedItem.Col2, cboPrograms.SelectedItem.Col2)

            TabSched.Text = "Class Schedule of " & UCase(dgSection.Rows(n).Cells(0).Value)
            lblNoOfSubjects.Text = dgSubjectOffered.RowCount

            DisplaySectionSchedule(dgSection.Rows(n).Cells(1).Value)

            For a As Integer = 0 To dgSubjectOffered.RowCount - 1
                sum += dgSubjectOffered.Rows(a).Cells(3).Value.ToString
            Next
            lblTotalUnits.Text = sum.ToString()

        End If
    End Sub

    Private Sub AddScheduleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddScheduleToolStripMenuItem.Click

        If SchedTab.TabCount = 1 Then
            SchedTab.TabPages.Add(Tab2)
            State = ScheduleState.TwoScheduleState

        ElseIf SchedTab.TabCount = 2 Then
            SchedTab.TabPages.Add(Tab3)
            State = ScheduleState.ThreeScheduleState

        ElseIf SchedTab.TabCount = 3 Then
            SchedTab.TabPages.Add(Tab4)
            State = ScheduleState.FourScheduleState

        ElseIf SchedTab.TabCount = 4 Then
            SchedTab.TabPages.Add(Tab5)
            State = ScheduleState.FiveScheduleState

        ElseIf SchedTab.TabCount > 4 Then
            Exit Sub
        End If
    End Sub

    Private Sub dgSubjectOffered_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgSubjectOffered.CellClick
        If dgSubjectOffered.RowCount > 0 Then
            txtOfferingID.Text = dgSubjectOffered.Rows(dgSubjectOffered.CurrentRow.Index).Cells(4).Value.ToString
            txtSubjectID.Text = dgSubjectOffered.Rows(dgSubjectOffered.CurrentRow.Index).Cells(2).Value.ToString
        End If

        SetClassScheduleInfo()
    End Sub


    Private Sub SetClassScheduleInfo()
        Dim sSub As tSubjectOffering
        Dim n As Integer = dgSubjectOffered.CurrentRow.Index

        If dgSubjectOffered.RowCount > 0 Then


            ClearItems()


            txtSubjectID.Text = dgSubjectOffered.Rows(n).Cells(1).Value
            lblCaption1.Text = dgSubjectOffered.Rows(n).Cells(2).Value
            lblCaption2.Text = dgSubjectOffered.Rows(n).Cells(2).Value
            lblCaption3.Text = dgSubjectOffered.Rows(n).Cells(2).Value
            lblCaption4.Text = dgSubjectOffered.Rows(n).Cells(2).Value
            lblCaption5.Text = dgSubjectOffered.Rows(n).Cells(2).Value

            OfferingID = dgSubjectOffered.Rows(n).Cells(4).Value

            If GetClassScheduleInfo(txtOfferingID.Text, sSub) = TranDBResult.Success Then

                On Error GoTo err

                dtpFrom.Text = MilitaryToStandard(sSub.SchedTimeStart)
                dtpTo.Text = MilitaryToStandard(sSub.SchedTimeEnd)

                cboBuilding.Text = GetBuildingByRoomID(sSub.RoomID)
                cboRoom1.Text = GetRoomNameByRoomID(sSub.RoomID)
                cboFaculty1.Text = GetFacultyNameByFacultyID(sSub.TeacherID)
                chkOverride1.Checked = IntToBoolean(sSub.OverrideConflict)
                chkSpecial1.Checked = IntToBoolean(sSub.IsSpecialClass)
                cboEvent1.SelectedIndex = sSub.Event1 - 1

                For Each lv As ListViewItem In clbDay.Items
                    For i = 1 To Len(sSub.Days)
                        If lv.SubItems(1).Text Like "*" & Microsoft.VisualBasic.Mid(sSub.Days, i, 1) & "*" Then
                            lv.Checked = True
                            lv.BackColor = Color.Orange

                            sFormState = FormState.updateFormState

                            Exit For
                        Else
                            lv.Checked = False
                            lv.BackColor = Color.White

                            sFormState = FormState.addFormState
                        End If
                    Next
                Next


                dtpFrom2.Text = MilitaryToStandard(sSub.SchedTimeStart2)
                dtpTo2.Text = MilitaryToStandard(sSub.SchedTimeEnd2)

                cboBuilding2.Text = GetBuildingByRoomID(sSub.RoomID2)
                cboRoom2.Text = GetRoomNameByRoomID(sSub.RoomID2)
                cboFaculty2.Text = GetFacultyNameByFacultyID(sSub.TeacherID2)
                chkOverride2.Checked = IntToBoolean(sSub.OverrideConflict)
                chkSpecial2.Checked = IntToBoolean(sSub.IsSpecialClass)
                cboEvent2.SelectedIndex = sSub.Event2 - 1

                For Each lv As ListViewItem In clbDay2.Items
                    For i = 1 To Len(sSub.Days2)
                        If lv.SubItems(1).Text Like "*" & Microsoft.VisualBasic.Mid(sSub.Days2, i, 1) & "*" Then
                            lv.Checked = True
                            lv.BackColor = Color.Orange
                            sFormState = FormState.updateFormState
                            Exit For
                        Else
                            lv.Checked = False
                            lv.BackColor = Color.White

                            sFormState = FormState.addFormState
                        End If
                    Next
                Next


                dtpFrom3.Text = MilitaryToStandard(sSub.SchedTimeStart3)
                dtpTo3.Text = MilitaryToStandard(sSub.SchedTimeEnd3)

                cboBuilding3.Text = GetBuildingByRoomID(sSub.RoomID3)
                cboRoom3.Text = GetRoomNameByRoomID(sSub.RoomID3)
                cboFaculty3.Text = GetFacultyNameByFacultyID(sSub.TeacherID3)
                chkOverride3.Checked = IntToBoolean(sSub.OverrideConflict)
                chkSpecial3.Checked = IntToBoolean(sSub.IsSpecialClass)
                cboEvent3.SelectedIndex = sSub.Event3 - 1

                For Each lv As ListViewItem In clbDay3.Items
                    For i = 1 To Len(sSub.Days3)
                        If lv.SubItems(1).Text Like "*" & Microsoft.VisualBasic.Mid(sSub.Days3, i, 1) & "*" Then
                            lv.Checked = True
                            lv.BackColor = Color.Orange


                            sFormState = FormState.updateFormState
                            Exit For
                        Else
                            lv.Checked = False
                            lv.BackColor = Color.White

                            sFormState = FormState.addFormState
                        End If
                    Next
                Next


                dtpFrom4.Text = MilitaryToStandard(sSub.SchedTimeStart4)
                dtpTo4.Text = MilitaryToStandard(sSub.SchedTimeEnd4)

                cboBuilding4.Text = GetBuildingByRoomID(sSub.RoomID4)
                cboRoom4.Text = GetRoomNameByRoomID(sSub.RoomID4)
                cboFaculty4.Text = GetFacultyNameByFacultyID(sSub.TeacherID4)
                chkOverride4.Checked = IntToBoolean(sSub.OverrideConflict)
                chkSpecial4.Checked = IntToBoolean(sSub.IsSpecialClass)
                cboEvent4.SelectedIndex = sSub.Event4 - 1

                For Each lv As ListViewItem In clbDay4.Items
                    For i = 1 To Len(sSub.Days4)
                        If lv.SubItems(1).Text Like "*" & Microsoft.VisualBasic.Mid(sSub.Days4, i, 1) & "*" Then
                            lv.Checked = True
                            lv.BackColor = Color.Orange

                            sFormState = FormState.updateFormState
                            Exit For
                        Else
                            lv.Checked = False
                            lv.BackColor = Color.White

                            sFormState = FormState.addFormState
                        End If
                    Next
                Next


                dtpFrom5.Text = MilitaryToStandard(sSub.SchedTimeStart5)
                dtpTo5.Text = MilitaryToStandard(sSub.SchedTimeEnd5)

                cboBuilding5.Text = GetBuildingByRoomID(sSub.RoomID5)
                cboRoom5.Text = GetRoomNameByRoomID(sSub.RoomID5)
                cboFaculty5.Text = GetFacultyNameByFacultyID(sSub.TeacherID5)
                chkOverride5.Checked = IntToBoolean(sSub.OverrideConflict)
                chkSpecial5.Checked = IntToBoolean(sSub.IsSpecialClass)
                cboEvent5.SelectedIndex = sSub.Event5 - 1

                For Each lv As ListViewItem In clbDay5.Items
                    For i = 1 To Len(sSub.Days5)
                        If lv.SubItems(1).Text Like "*" & Microsoft.VisualBasic.Mid(sSub.Days5, i, 1) & "*" Then
                            lv.Checked = True
                            lv.BackColor = Color.Orange
                            sFormState = FormState.updateFormState
                            Exit For
                        Else
                            lv.Checked = False
                            lv.BackColor = Color.White

                            sFormState = FormState.addFormState
                        End If
                    Next
                Next

                Exit Sub
err:
                sFormState = FormState.updateFormState
                DisplayErrorMsg("frmScheduler", "GetClassSchedInfo", Err.Number, Err.Description)
                'ClearItems()
            End If
        End If
    End Sub

    Private Function GetClassScheduleInfo(ByVal OfferingID As String, ByRef sSub As tSubjectOffering) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblClassSchedule WHERE SubjectOfferingID='" & OfferingID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            If (vRS("Sched5").ToString() <> "") And (vRS("Sched4").ToString() <> "") And (vRS("Sched3").ToString() <> "") And (vRS("Sched2").ToString() <> "") And (vRS("Sched1").ToString() <> "") Then
                sSub.SchedTimeEnd5 = vRS("SchedTimeEnd5").ToString()
                sSub.SchedTimeStart5 = vRS("SchedTimeStart5").ToString()
                sSub.RoomID5 = vRS("RoomID5").ToString()
                sSub.Days5 = vRS("Days5").ToString()
                sSub.TeacherID5 = vRS("TeacherID5").ToString()
                sSub.Event5 = vRS("EventID5").ToString()

                sSub.SchedTimeEnd4 = vRS("SchedTimeEnd4").ToString()
                sSub.SchedTimeStart4 = vRS("SchedTimeStart4").ToString()
                sSub.RoomID4 = vRS("RoomID4").ToString()
                sSub.Days4 = vRS("Days4").ToString()
                sSub.TeacherID4 = vRS("TeacherID4").ToString()
                sSub.Event4 = vRS("EventID4").ToString()

                sSub.SchedTimeEnd3 = vRS("SchedTimeEnd3").ToString()
                sSub.SchedTimeStart3 = vRS("SchedTimeStart3").ToString()
                sSub.RoomID3 = vRS("RoomID3").ToString()
                sSub.Days3 = vRS("Days3").ToString()
                sSub.TeacherID3 = vRS("TeacherID3").ToString()
                sSub.Event3 = vRS("EventID3").ToString()

                sSub.SchedTimeEnd2 = vRS("SchedTimeEnd2").ToString()
                sSub.SchedTimeStart2 = vRS("SchedTimeStart2").ToString()
                sSub.RoomID2 = vRS("RoomID2").ToString()
                sSub.Days2 = vRS("Days2").ToString()
                sSub.TeacherID2 = vRS("TeacherID2").ToString()
                sSub.Event2 = vRS("EventID2").ToString()

                sSub.SchedTimeEnd = vRS("SchedTimeEnd").ToString()
                sSub.SchedTimeStart = vRS("SchedTimeStart").ToString()
                sSub.RoomID = vRS("RoomID").ToString()
                sSub.Days = vRS("Days").ToString()
                sSub.TeacherID = vRS("TeacherID").ToString()
                sSub.Event1 = vRS("EventID1").ToString()

                GetClassScheduleInfo = TranDBResult.Success

            ElseIf (vRS("Sched4").ToString() <> "") And (vRS("Sched3").ToString() <> "") And (vRS("Sched2").ToString() <> "") And (vRS("Sched1").ToString() <> "") Then
                sSub.SchedTimeEnd4 = vRS("SchedTimeEnd4").ToString()
                sSub.SchedTimeStart4 = vRS("SchedTimeStart4").ToString()
                sSub.RoomID4 = vRS("RoomID4").ToString()
                sSub.Days4 = vRS("Days4").ToString()
                sSub.TeacherID4 = vRS("TeacherID4").ToString()
                sSub.Event4 = vRS("EventID4").ToString()

                sSub.SchedTimeEnd3 = vRS("SchedTimeEnd3").ToString()
                sSub.SchedTimeStart3 = vRS("SchedTimeStart3").ToString()
                sSub.RoomID3 = vRS("RoomID3").ToString()
                sSub.Days3 = vRS("Days3").ToString()
                sSub.TeacherID3 = vRS("TeacherID3").ToString()
                sSub.Event3 = vRS("EventID3").ToString()

                sSub.SchedTimeEnd2 = vRS("SchedTimeEnd2").ToString()
                sSub.SchedTimeStart2 = vRS("SchedTimeStart2").ToString()
                sSub.RoomID2 = vRS("RoomID2").ToString()
                sSub.Days2 = vRS("Days2").ToString()
                sSub.TeacherID2 = vRS("TeacherID2").ToString()
                sSub.Event2 = vRS("EventID2").ToString()

                sSub.SchedTimeEnd = vRS("SchedTimeEnd").ToString()
                sSub.SchedTimeStart = vRS("SchedTimeStart").ToString()
                sSub.RoomID = vRS("RoomID").ToString()
                sSub.Days = vRS("Days").ToString()
                sSub.TeacherID = vRS("TeacherID").ToString()
                sSub.Event1 = vRS("EventID1").ToString()

                GetClassScheduleInfo = TranDBResult.Success

            ElseIf (vRS("Sched3").ToString() <> "") And (vRS("Sched2").ToString() <> "") And (vRS("Sched1").ToString() <> "") Then
                sSub.SchedTimeEnd3 = vRS("SchedTimeEnd3").ToString()
                sSub.SchedTimeStart3 = vRS("SchedTimeStart3").ToString()
                sSub.RoomID3 = vRS("RoomID3").ToString()
                sSub.Days3 = vRS("Days3").ToString()
                sSub.TeacherID3 = vRS("TeacherID3").ToString()
                sSub.Event3 = vRS("EventID3").ToString()

                sSub.SchedTimeEnd2 = vRS("SchedTimeEnd2").ToString()
                sSub.SchedTimeStart2 = vRS("SchedTimeStart2").ToString()
                sSub.RoomID2 = vRS("RoomID2").ToString()
                sSub.Days2 = vRS("Days2").ToString()
                sSub.TeacherID2 = vRS("TeacherID2").ToString()
                sSub.Event2 = vRS("EventID2").ToString()

                sSub.SchedTimeEnd = vRS("SchedTimeEnd").ToString()
                sSub.SchedTimeStart = vRS("SchedTimeStart").ToString()
                sSub.RoomID = vRS("RoomID").ToString()
                sSub.Days = vRS("Days").ToString()
                sSub.TeacherID = vRS("TeacherID").ToString()
                sSub.Event1 = vRS("EventID1").ToString()

                GetClassScheduleInfo = TranDBResult.Success

            ElseIf (vRS("Sched2").ToString() <> "") And (vRS("Sched1").ToString() <> "") Then
                sSub.SchedTimeEnd2 = vRS("SchedTimeEnd2").ToString()
                sSub.SchedTimeStart2 = vRS("SchedTimeStart2").ToString()
                sSub.RoomID2 = vRS("RoomID2").ToString()
                sSub.Days2 = vRS("Days2").ToString()
                sSub.TeacherID2 = vRS("TeacherID2").ToString()
                sSub.Event2 = vRS("EventID2").ToString()

                sSub.SchedTimeEnd = vRS("SchedTimeEnd").ToString()
                sSub.SchedTimeStart = vRS("SchedTimeStart").ToString()
                sSub.RoomID = vRS("RoomID").ToString()
                sSub.Days = vRS("Days").ToString()
                sSub.TeacherID = vRS("TeacherID").ToString()
                sSub.Event1 = vRS("EventID1").ToString()

                GetClassScheduleInfo = TranDBResult.Success

            ElseIf (vRS("Sched1").ToString() <> "") Then
                sSub.SchedTimeEnd = vRS("SchedTimeEnd").ToString()
                sSub.SchedTimeStart = vRS("SchedTimeStart").ToString()
                sSub.RoomID = vRS("RoomID").ToString()
                sSub.Days = vRS("Days").ToString()
                sSub.TeacherID = vRS("TeacherID").ToString()
                sSub.Event1 = vRS("EventID1").ToString()

                GetClassScheduleInfo = TranDBResult.Success

            Else
                GetClassScheduleInfo = TranDBResult.Failed
            End If

        Else
            GetClassScheduleInfo = TranDBResult.Failed
        End If
        vRS.Close()
    End Function


    Private Sub CloseTabToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseTabToolStripMenuItem.Click
        If SchedTab.TabCount > 1 Then
            Select Case SchedTab.SelectedIndex
                Case 0
                    Exit Sub
                Case 1
                    State = ScheduleState.OneScheduleState
                Case 2
                    State = ScheduleState.TwoScheduleState
                Case 3
                    State = ScheduleState.ThreeScheduleState
                Case 4
                    State = ScheduleState.FourScheduleState
            End Select

            SchedTab.TabPages.RemoveAt(SchedTab.SelectedIndex)

        End If

    End Sub


    Private Sub cboFaculty1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFaculty1.SelectedIndexChanged
        On Error Resume Next
        DisplayFacultySchedule(cboFaculty1.SelectedItem.Col2, cboSY.SelectedItem.Col2)
    End Sub

    Private Sub lvFaculty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvFaculty.Click
        DisplayFacultySchedule(lvFaculty.FocusedItem.SubItems(1).Text, cboSY.SelectedItem.Col2)
    End Sub

    Private Sub lvFaculty_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvFaculty.SelectedIndexChanged

    End Sub

    Private Sub cmdPrintClass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrintClass.Click
        clsGrid.PrintGrid("Class Schedule", PrintGridFlags.ShowPreviewDialog, "Class Schedule", "Printed By:")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New frmPrintForm()
        'frm.ShowPrint("Class Schedule", cboSY.SelectedItem.Col2, cboCampus.SelectedItem.Col2, , , CurrentUser.UserID, txtSectionID.Text, cboPrograms.SelectedItem.Col2, )
    End Sub

    Private Sub cmdTeam1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTeam5.Click, cmdTeam4.Click, cmdTeam3.Click, cmdTeam2.Click, cmdTeam1.Click
        Dim frm As New frmTeamTeaching()
        frm.ShowForm(cboSY.SelectedItem.Col2, OfferingID, cboCampus.SelectedItem.Col2)
    End Sub

    Private Sub cmdPrintRoomGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrintRoomGrid.Click
        RoomGrid.PrintGrid("Room Utilization: ", PrintGridFlags.ShowPreviewDialog + PrintGridFlags.FitToPageWidth, "Room Utilization", "Printed By:")
    End Sub

    Private Sub cboCampusBuilding_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCampusBuilding.SelectedIndexChanged
        FillListView("SELECT RoomNo,RoomID,Room FROM tblRoom WHERE BldgID='" & cboCampusBuilding.SelectedItem.Col2 & "'", lsvRooms, False)
    End Sub

    Private Sub Cancel_Button_Click(sender As System.Object, e As System.EventArgs)
        ClearItems()
    End Sub

    Private Sub chkOverride1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkOverride1.CheckedChanged, chkOverride5.CheckedChanged, chkOverride4.CheckedChanged, chkOverride3.CheckedChanged, chkOverride2.CheckedChanged
        chkOverride2.Checked = chkOverride1.CheckState
        chkOverride3.Checked = chkOverride1.CheckState
        chkOverride4.Checked = chkOverride1.CheckState
        chkOverride5.Checked = chkOverride1.CheckState
    End Sub

    Private Sub chkSpecial1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkSpecial1.CheckedChanged, chkSpecial5.CheckedChanged, chkSpecial4.CheckedChanged, chkSpecial3.CheckedChanged, chkSpecial2.CheckedChanged
        chkSpecial2.Checked = chkSpecial1.CheckState
        chkSpecial3.Checked = chkSpecial1.CheckState
        chkSpecial4.Checked = chkSpecial1.CheckState
        chkSpecial5.Checked = chkSpecial1.CheckState
    End Sub

    Private Sub DeleteToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles DeleteToolStripButton.Click

    End Sub

    Private Sub RefreshToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles RefreshToolStripButton.Click
        SetClassScheduleInfo()

        DisplaySectionSchedule(txtSectionID.Text)
    End Sub

    Private Sub TimeTableTab_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles TimeTableTab.SelectedIndexChanged
        Select Case TimeTableTab.SelectedIndex
            Case 0
                SchedPrint = SchedulePrint.ClassSchedule
            Case 1
                SchedPrint = SchedulePrint.FacultySchedule
            Case 2
                SchedPrint = SchedulePrint.RoomSchedule
        End Select
    End Sub

    Private Sub PrintToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles PrintToolStripButton.Click
        Select Case SchedPrint
            Case SchedulePrint.ClassSchedule
                Button1_Click(sender, e)
            Case SchedulePrint.FacultySchedule

            Case SchedulePrint.RoomSchedule

        End Select
    End Sub

    Private Sub NewToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles NewToolStripButton.Click
        ClearItems()

        State = ScheduleState.OneScheduleState
        sFormState = FormState.addFormState

    End Sub

    Private Sub Button1_Click1(sender As Object, e As System.EventArgs) Handles Button1.Click

    End Sub
End Class
