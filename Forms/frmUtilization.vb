Option Explicit On

Imports MySql.Data.MySqlClient
Imports C1.Win.C1FlexGrid
Imports System.Drawing
Imports System.Windows.Forms

Public Class frmUtilization

    Dim i As Integer

    Dim Colors As Color() = New Color(15) {Color.LightGreen, Color.LightPink, Color.LightSkyBlue, Color.FromArgb(&H66, &HFF, &HFF), Color.MediumAquamarine, Color.Orange, Color.OrangeRed, Color.Yellow, Color.LimeGreen, Color.Violet, Color.Coral, Color.Tan, Color.Silver, Color.SandyBrown, Color.ForestGreen, Color.FromArgb(&H99, &H0, &HFF)}

    Private Sub frmRoomSchedule_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        TimeTableGrid()

        fillMultiColumnCombo2(cboTeachCampus, "SELECT CampusName,CampusID FROM tblCampus")
        fillMultiColumnCombo2(cbomCampus, "SELECT CampusName,CampusID FROM tblCampus")
        fillMultiColumnCombo2(cboAYTerm, "SELECT fnAcademicYearTerm(TermID), TermID FROM tblAYTerm")
        fillMultiColumnCombo2(cboAYTermRoom, "SELECT fnAcademicYearTerm(TermID),TermID FROM tblAYTerm")
    End Sub

    Private Sub cbosBuilding_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbosBuilding.SelectedIndexChanged
        Dim sBuilding As vBuilding
        Dim com As New MySqlCommand("SELECT  tblroom.Room,tblRoom.RoomNo,tblRoom.BldgID,tblroom.RoomID FROM tblRoom " & _
                            "WHERE tblRoom.BldgID='" & cbosBuilding.SelectedItem.Col2 & "' AND IsUsable ='1'", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        lsvRooms.Items.Clear()
        While vRS.Read
            Dim lv As New ListViewItem(vRS("RoomNo").ToString())
            lv.SubItems.Add(vRS("RoomID").ToString())
            lv.SubItems.Add(vRS("Room").ToString())
            lv.ImageIndex = 13
            lsvRooms.Items.AddRange(New ListViewItem() {lv})
        End While
        vRS.Close()
    End Sub

    Private Sub cboTeachCampus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTeachCampus.SelectedIndexChanged
        fillMultiColumnCombo2(cboColleges, "SELECT CollegeName,CollegeID FROM tblColleges WHERE CampusID='" & cboTeachCampus.SelectedItem.Col2 & "'")
    End Sub
    Private Sub cbomCampus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbomCampus.SelectedIndexChanged
        fillMultiColumnCombo2(cbosBuilding, "SELECT BldgName,BldgID FROM tblBuilding WHERE CampusID='" & cbomCampus.SelectedItem.Col2 & "' ORDER BY BldgID")
    End Sub
    Private Sub lsvFaculty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsvFaculty.Click
        DisplayFacultyTimeTable(lsvFaculty.FocusedItem.SubItems(1).Text, cboAYTerm.SelectedItem.Col2)
    End Sub
    Private Sub PrintToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripButton.Click
        Grid.PrintGrid("Time Schedule", PrintGridFlags.ShowPreviewDialog)
    End Sub

    Private Sub lsvRooms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsvRooms.Click
        DisplayRoomTimeTable(lsvRooms.FocusedItem.SubItems(1).Text, cboAYTermRoom.SelectedItem.Col2)
    End Sub

    Private Sub cboColleges_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboColleges.SelectedIndexChanged
        FillListView("SELECT fnEmployeeName(EmployeeID),TeacherID,fnCollegeName(CollegeID) FROM tblTeacher WHERE CollegeID='" & cboColleges.SelectedItem.Col2 & "'", lsvFaculty)
    End Sub

    Private Sub TimeTableGrid()
        With Grid
            .Clear()
            .set_ColWidth(0, 80)

            For i As Integer = 1 To 7
                .set_ColWidth(i, 80)
            Next

            Grid(0, 1) = "Monday"
            Grid(0, 2) = "Tuesday"
            Grid(0, 3) = "Wednesday"
            Grid(0, 4) = "Thursday"
            Grid(0, 5) = "Friday"
            Grid(0, 6) = "Saturday"
            Grid(0, 7) = "Sunday"

            Grid(1, 0) = "06:00 AM"
            Grid(2, 0) = "06:30 AM"
            Grid(3, 0) = "07:00 AM"
            Grid(4, 0) = "07:30 AM"
            Grid(5, 0) = "08:00 AM"
            Grid(6, 0) = "08:30 AM"
            Grid(7, 0) = "09:00 AM"
            Grid(8, 0) = "09:30 AM"
            Grid(9, 0) = "10:00 AM"
            Grid(10, 0) = "10:30 AM"
            Grid(11, 0) = "11:00 AM"
            Grid(12, 0) = "11:30 AM"
            Grid(13, 0) = "12:00 PM"
            Grid(14, 0) = "12:30 PM"
            Grid(15, 0) = "01:00 PM"
            Grid(16, 0) = "01:30 PM"
            Grid(17, 0) = "02:00 PM"
            Grid(18, 0) = "02:30 PM"
            Grid(19, 0) = "03:00 PM"
            Grid(20, 0) = "03:30 PM"
            Grid(21, 0) = "04:00 PM"
            Grid(22, 0) = "04:30 PM"
            Grid(23, 0) = "05:00 PM"
            Grid(24, 0) = "05:30 PM"
            Grid(25, 0) = "06:00 PM"
            Grid(26, 0) = "06:30 PM"
            Grid(27, 0) = "07:00 PM"
            Grid(28, 0) = "07:30 PM"
            Grid(29, 0) = "08:00 PM"
            Grid(30, 0) = "08:30 PM"

            'dgView1.Font.Size = 7'

            For i As Integer = 1 To Grid.Rows - 1
                Grid.set_RowHeight(i, 26)
                Grid.set_Cell(Classic.CellPropertySettings.flexcpFont, i, 1, New System.Drawing.Font("Arial", 7, FontStyle.Bold))
                Grid.set_Cell(Classic.CellPropertySettings.flexcpFont, i, 2, New System.Drawing.Font("Arial", 7, FontStyle.Bold))
                Grid.set_Cell(Classic.CellPropertySettings.flexcpFont, i, 3, New System.Drawing.Font("Arial", 7, FontStyle.Bold))
                Grid.set_Cell(Classic.CellPropertySettings.flexcpFont, i, 4, New System.Drawing.Font("Arial", 7, FontStyle.Bold))
                Grid.set_Cell(Classic.CellPropertySettings.flexcpFont, i, 5, New System.Drawing.Font("Arial", 7, FontStyle.Bold))
                Grid.set_Cell(Classic.CellPropertySettings.flexcpFont, i, 6, New System.Drawing.Font("Arial", 7, FontStyle.Bold))
                Grid.set_Cell(Classic.CellPropertySettings.flexcpFont, i, 7, New System.Drawing.Font("Arial", 7, FontStyle.Bold))
            Next
            Grid.Styles.Fixed.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter
        End With

    End Sub

    Private Sub DisplayRoomTimeTable(ByVal sRoomID As String, ByVal sTermID As String)
        Dim num1 As Integer, num2 As Integer
        Dim sDay As String
        Dim sRow As String

        Dim randonGen As New Random()

        Dim Caption As String

        Dim com As New MySqlCommand("CALL GetRoomScheduleByTerm('" & sRoomID & "','" & sTermID & "')", clsCon.con)
        Dim dr As MySqlDataReader = com.ExecuteReader()
        lvUtilization.Items.Clear()

        Grid.Clear()

        TimeTableGrid()

        While dr.Read()
            Dim lv As New ListViewItem(dr("SubjectTitle").ToString())
            lv.SubItems.Add(dr("Room").ToString())
            lv.SubItems.Add(dr("FacultyName").ToString())
            lv.SubItems.Add(dr("Schedule").ToString())
            lv.ForeColor = Colors(randonGen.Next(10))
            lvUtilization.Items.AddRange(New ListViewItem() {lv})


            If dr("Schedule").ToString() <> "" Then
                Caption = dr("FacultyName").ToString() & vbNewLine & dr("Section").ToString() & vbNewLine & dr("SubjectTitle").ToString()
            Else
                Caption = ""
            End If

            num1 = TimeToInt(dr("Time_Start").ToString())
            num2 = TimeToInt(dr("Time_End").ToString())

            sDay = dr("Days").ToString()

            For time As Integer = num1 To num2
                With Grid
                    .AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
                    .set_ColAlignment(0, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignCenterCenter)

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

    Private Sub DisplayFacultyTimeTable(ByVal sFacultyID As String, ByVal sTermID As String)
        Dim num1 As Integer, num2 As Integer
        Dim sDay As String
        Dim sRow As String

        Dim randonGen As New Random()

        Dim Caption As String

        Dim com As New MySqlCommand("CALL GetFacultyScheduleByTerm('" & sFacultyID & "','" & sTermID & "')", clsCon.con)
        Dim dr As MySqlDataReader = com.ExecuteReader()
        lvUtilization.Items.Clear()

        Grid.Clear()

        TimeTableGrid()

        While dr.Read()
            Dim lv As New ListViewItem(dr("SubjectTitle").ToString())
            lv.SubItems.Add(dr("Room").ToString())
            lv.SubItems.Add(dr("FacultyName").ToString())
            lv.SubItems.Add(dr("Schedule").ToString())
            lv.ForeColor = Colors(randonGen.Next(10))
            lvUtilization.Items.AddRange(New ListViewItem() {lv})


            If dr("Schedule").ToString() <> "" Then
                Caption = dr("FacultyName").ToString() & vbNewLine & dr("Section").ToString() & vbNewLine & dr("SubjectTitle").ToString()
            Else
                Caption = ""
            End If

            num1 = TimeToInt(dr("Time_Start").ToString())
            num2 = TimeToInt(dr("Time_End").ToString())

            sDay = dr("Days").ToString()

            For time As Integer = num1 To num2
                With Grid
                    .AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
                    .set_ColAlignment(0, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignCenterCenter)

                    For i = 1 To Len(dr("DAYS").ToString())
                        If dr("Days").ToString() Like "*" & Microsoft.VisualBasic.Mid(sDay, i, 1) & "*" Then
                            Dim n As Integer = Microsoft.VisualBasic.Mid(sDay, i, 1)

                            .set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpBackColor, time, n, lv.ForeColor)
                            '.set_Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpFontSize, time, n, )


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
End Class