Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class frmConflict

    Dim tmpIsOverRide As Boolean

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        tmpIsOverRide = False
        Close()
    End Sub

    Public Function ShowForm(ByVal ConflictOccur As String, ByVal OfferingID As String, ByVal sValue As String, ByVal sValueID As String, _
                        ByVal Day As String, TimeStart As String, TimeEnd As String, ByVal TeacherID As String, ByVal TermID As Integer)

        tmpIsOverRide = False

        Select Case ConflictOccur
            Case "Room"
                lblSubject.Text = "Room Schedule"
                GetRoomScheduleConflicts(TermID, sValueID, Day, TimeStart, TimeEnd)
            Case "Subject"

            Case "Faculty"
                lblSubject.Text = "Faculty Schedule"
                GetFacultyScheduleConflicts(TermID, TeacherID, Day, TimeStart, TimeEnd)
        End Select

        Me.ShowDialog()

        ShowForm = tmpIsOverRide

    End Function


    Private Sub GetRoomScheduleConflicts(ByVal TermID As Integer, ByVal RoomID As String, ByVal sDay As String, _
                                              ByVal TimeStart As String, ByVal TimeEnd As String)
        Dim sSQL = "SELECT  SubjectOfferingID, CS.TermID, CS.SubjectID, S.SubjectCode, S.SubjectTitle, S.CreditUnits, CSec.SectionTitle," & _
                    "CS.Sched1, fnRoomName2(CS.RoomID) AS Room_1,CS.Sched2, fnRoomName2(CS.RoomID2) AS Room_2,CS.Sched3, fnRoomName2(CS.RoomID3) AS Room_3,CS.Sched4, fnRoomName2(CS.RoomID4) AS Room_4, " & _
                    "CS.Sched5, fnRoomName2(CS.RoomID5) As Room_5,fnProgramCode(CSec.ProgramID) As ProgramCode " & _
                    "FROM tblClassSchedule AS CS LEFT JOIN tblSubject AS S ON S.SubjectID = CS.SubjectID LEFT JOIN " & _
                    "tblSection AS CSec ON CSec.SectionID = CS.SectionID " & _
                    "WHERE   (CS.TermID ='" & TermID & "') AND (CS.RoomID = '" & RoomID & "') AND (CS.Days LIKE '%" & sDay & "%') AND " & _
                   "((SchedTimeStart BETWEEN '" & TimeStart & "' AND '" & TimeEnd & "') OR (SchedTimeEnd BETWEEN '" & TimeStart & "' AND '" & TimeEnd & "') " & _
                   "OR ((SchedTimeEnd > '" & TimeStart & "' AND SchedTimeEnd <= '" & TimeEnd & "') OR ('" & TimeStart & "' BETWEEN SchedTimeStart+1 AND SchedTimeEnd-9941) OR ('" & TimeEnd & "' BETWEEN SchedTimeStart+1 AND SchedTimeEnd-9941))) " & _
                   "AND ((SchedTimeEnd > '" & TimeStart & "' AND SchedTimeEnd <= '" & TimeEnd & "') OR ('" & TimeStart & "' BETWEEN SchedTimeStart+1 AND SchedTimeEnd-9941) OR ('" & TimeEnd & "' BETWEEN SchedTimeStart+1 AND SchedTimeEnd-9941)) " & _
                    "UNION " & _
                    "SELECT  SubjectOfferingID, CS.TermID, CS.SubjectID, S.SubjectCode, S.SubjectTitle, S.CreditUnits, CSec.SectionTitle, " & _
                    "CS.Sched1, fnRoomName2(CS.RoomID) AS Room_1,CS.Sched2, fnRoomName2(CS.RoomID2) AS Room_2, " & _
                    "CS.Sched3, fnRoomName2(CS.RoomID3) AS Room_3,CS.Sched4, fnRoomName2(CS.RoomID4) AS Room_4," & _
                    "CS.Sched5, fnRoomName2(CS.RoomID5) AS Room_5, fnProgramCode(CSec.ProgramID) AS ProgramCode " & _
                    "FROM tblClassSchedule AS CS LEFT JOIN tblSubject AS S ON S.SubjectID = CS.SubjectID LEFT JOIN " & _
                    "tblSection AS CSec ON CSec.SectionID = CS.SectionID " & _
                   "WHERE   (CS.TermID ='" & TermID & "') AND (CS.RoomID2 = '" & RoomID & "') AND (CS.Days2 LIKE '%" & sDay & "%') AND " & _
                   "((SchedTimeStart2 BETWEEN '" & TimeStart & "' AND '" & TimeEnd & "') OR (SchedTimeEnd2 BETWEEN '" & TimeStart & "' AND '" & TimeEnd & "') " & _
                   "OR ((SchedTimeEnd2 > '" & TimeStart & "' AND SchedTimeEnd2 <= '" & TimeEnd & "') OR ('" & TimeStart & "' BETWEEN SchedTimeStart2+1 AND SchedTimeEnd2-9941) OR ('" & TimeEnd & "' BETWEEN SchedTimeStart2+1 AND SchedTimeEnd2-9941))) " & _
                   "AND ((SchedTimeEnd2 > '" & TimeStart & "' AND SchedTimeEnd2 <= '" & TimeEnd & "') OR ('" & TimeStart & "' BETWEEN SchedTimeStart2+1 AND SchedTimeEnd2-9941) OR ('" & TimeEnd & "' BETWEEN SchedTimeStart2+1 AND SchedTimeEnd2-9941)) " & _
                    "UNION " & _
                    "SELECT  SubjectOfferingID, CS.TermID, CS.SubjectID, S.SubjectCode, S.SubjectTitle, S.CreditUnits, CSec.SectionTitle," & _
                   "CS.Sched1, fnRoomName2(CS.RoomID) AS Room_1,CS.Sched2, fnRoomName2(CS.RoomID2) AS Room_2,CS.Sched3, fnRoomName2(CS.RoomID3) AS Room_3, " & _
                   "CS.Sched4, fnRoomName2(CS.RoomID4) AS Room_4,CS.Sched5, fnRoomName2(CS.RoomID5) AS Room_5, fnProgramCode(CSec.ProgramID) AS ProgramCode " & _
                 "FROM tblClassSchedule AS CS LEFT JOIN tblSubject AS S ON S.SubjectID = CS.SubjectID LEFT JOIN tblSection AS CSec ON CSec.SectionID = CS.SectionID " & _
                "WHERE   (CS.TermID ='" & TermID & "') AND (CS.RoomID3 = '" & RoomID & "') AND (CS.Days3 LIKE '%" & sDay & "%') AND " & _
                   "((SchedTimeStart3 BETWEEN '" & TimeStart & "' AND '" & TimeEnd & "') OR (SchedTimeEnd3 BETWEEN '" & TimeStart & "' AND '" & TimeEnd & "') " & _
                   "OR ((SchedTimeEnd3 > '" & TimeStart & "' AND SchedTimeEnd3 <= '" & TimeEnd & "') OR ('" & TimeStart & "' BETWEEN SchedTimeStart3+1 AND SchedTimeEnd3-9941) OR ('" & TimeEnd & "' BETWEEN SchedTimeStart3+1 AND SchedTimeEnd3-9941))) " & _
                   "AND ((SchedTimeEnd3 > '" & TimeStart & "' AND SchedTimeEnd3 <= '" & TimeEnd & "') OR ('" & TimeStart & "' BETWEEN SchedTimeStart3+1 AND SchedTimeEnd3-9941) OR ('" & TimeEnd & "' BETWEEN SchedTimeStart3+1 AND SchedTimeEnd3-9941)) " & _
                    "UNION " & _
                  "SELECT  SubjectOfferingID, CS.TermID, CS.SubjectID, S.SubjectCode, S.SubjectTitle, S.CreditUnits, CSec.SectionTitle, " & _
                   "CS.Sched1, fnRoomName2(CS.RoomID) AS Room_1,CS.Sched2, fnRoomName2(CS.RoomID2) AS Room_2, " & _
                   "CS.Sched3, fnRoomName2(CS.RoomID3) AS Room_3,CS.Sched4, fnRoomName2(CS.RoomID4) AS Room_4, " & _
                   "CS.Sched5, fnRoomName2(CS.RoomID5) AS Room_5, fnProgramCode(CSec.ProgramID) AS ProgramCode " & _
                   "FROM  tblClassSchedule AS CS LEFT JOIN tblSubject AS S ON S.SubjectID = CS.SubjectID LEFT JOIN tblSection AS CSec ON CSec.SectionID = CS.SectionID " & _
                    "WHERE   (CS.TermID ='" & TermID & "') AND (CS.RoomID4 = '" & RoomID & "') AND (CS.Days4 LIKE '%" & sDay & "%') AND " & _
                     "((SchedTimeStart4 BETWEEN '" & TimeStart & "' AND '" & TimeEnd & "') OR (SchedTimeEnd4 BETWEEN '" & TimeStart & "' AND '" & TimeEnd & "') " & _
                    "OR ((SchedTimeEnd4 > '" & TimeStart & "' AND SchedTimeEnd4 <= '" & TimeEnd & "') OR ('" & TimeStart & "' BETWEEN SchedTimeStart4+1 AND SchedTimeEnd4-9941) OR ('" & TimeEnd & "' BETWEEN SchedTimeStart4+1 AND SchedTimeEnd4-9941))) " & _
                    "AND ((SchedTimeEnd4 > '" & TimeStart & "' AND SchedTimeEnd4 <= '" & TimeEnd & "') OR ('" & TimeStart & "' BETWEEN SchedTimeStart4+1 AND SchedTimeEnd4-9941) OR ('" & TimeEnd & "' BETWEEN SchedTimeStart4+1 AND SchedTimeEnd4-9941)) " & _
                      "UNION " & _
                      "SELECT  SubjectOfferingID, CS.TermID, CS.SubjectID, S.SubjectCode, S.SubjectTitle, S.CreditUnits, CSec.SectionTitle, " & _
                     "CS.Sched1, fnRoomName2(CS.RoomID) AS Room_1,CS.Sched2, fnRoomName2(CS.RoomID2) AS Room_2, " & _
                     "CS.Sched3, fnRoomName2(CS.RoomID3) AS Room_3, CS.Sched4, fnRoomName2(CS.RoomID4) AS Room_4, " & _
                     "CS.Sched5, fnRoomName2(CS.RoomID5) AS Room_5,fnProgramCode(CSec.ProgramID) AS ProgramCode " & _
                    "FROM tblClassSchedule AS CS LEFT JOIN tblSubject AS S ON S.SubjectID = CS.SubjectID LEFT JOIN tblSection AS CSec ON CSec.SectionID = CS.SectionID " & _
                     "WHERE   (CS.TermID ='" & TermID & "') AND (CS.RoomID5 = '" & RoomID & "') AND (CS.Days5 LIKE '%" & sDay & "%') AND " & _
                     "((SchedTimeStart5 BETWEEN '" & TimeStart & "' AND '" & TimeEnd & "') OR (SchedTimeEnd5 BETWEEN '" & TimeStart & "' AND '" & TimeEnd & "') " & _
                    "OR ((SchedTimeEnd5 > '" & TimeStart & "' AND SchedTimeEnd5 <= '" & TimeEnd & "') OR ('" & TimeStart & "' BETWEEN SchedTimeStart5+1 AND SchedTimeEnd5-9941) OR ('" & TimeEnd & "' BETWEEN SchedTimeStart5+1 AND SchedTimeEnd5-9941))) " & _
                    "AND ((SchedTimeEnd5 > '" & TimeStart & "' AND SchedTimeEnd5 <= '" & TimeEnd & "') OR ('" & TimeStart & "' BETWEEN SchedTimeStart5+1 AND SchedTimeEnd5-9941) OR ('" & TimeEnd & "' BETWEEN SchedTimeStart5+1 AND SchedTimeEnd5-9941)) "


        Dim com As New MySqlCommand(sSQL, con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        lvConflict.Items.Clear()
        While vRS.Read
            Dim lv As New ListViewItem(vRS("ProgramCode").ToString())
            lv.SubItems.Add(vRS("SectionTitle").ToString())
            lv.SubItems.Add(vRS("SubjectCode").ToString())
            lv.SubItems.Add(vRS("SubjectTitle").ToString())
            lv.SubItems.Add(vRS("CreditUnits").ToString())

            Dim Caption As String = IIf(vRS("Sched1").ToString() <> "", vRS("Sched1").ToString() & " @ " & vRS("Room_1").ToString() & vbNewLine, "") & _
                                    IIf(vRS("Sched2").ToString() <> "", vRS("Sched2").ToString() & " @ " & vRS("Room_2").ToString() & vbNewLine, "") & _
                                    IIf(vRS("Sched3").ToString() <> "", vRS("Sched3").ToString() & " @ " & vRS("Room_3").ToString() & vbNewLine, "") & _
                                    IIf(vRS("Sched4").ToString() <> "", vRS("Sched4").ToString() & " @ " & vRS("Room_4").ToString() & vbNewLine, "") & _
                                    IIf(vRS("Sched4").ToString() <> "", vRS("Sched4").ToString() & " @ " & vRS("Room_5").ToString(), "")
            lv.SubItems.Add(Caption)
            lvConflict.Items.AddRange(New ListViewItem() {lv})
        End While
        vRS.Close()
    End Sub


    Public Function GetFacultyScheduleConflicts(ByVal TermID As Integer, ByVal FacultyID As String, _
                                                ByVal sDAy As String, ByVal TimeStart As String, ByVal TimeEnd As String)

        Dim com As New MySqlCommand("CALL GetFacultyScheduleConflicts('" & TermID & "','" & FacultyID & "','" & sDAy & "','" & TimeStart & "','" & TimeEnd & "')", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        While vRS.Read()
            Dim lv As New ListViewItem(vRS("ProgramCode").ToString())
            lv.SubItems.Add(vRS("SectionTitle").ToString())
            lv.SubItems.Add(vRS("SubjectCode").ToString())
            lv.SubItems.Add(vRS("SubjectTitle").ToString())
            lv.SubItems.Add(vRS("CreditUnits").ToString())

            Dim Caption As String = IIf(vRS("Sched1").ToString() <> "", vRS("Sched1").ToString() & " @ " & vRS("Room_1").ToString() & vbNewLine, "") & _
                                    IIf(vRS("Sched2").ToString() <> "", vRS("Sched2").ToString() & " @ " & vRS("Room_2").ToString() & vbNewLine, "") & _
                                    IIf(vRS("Sched3").ToString() <> "", vRS("Sched3").ToString() & " @ " & vRS("Room_3").ToString() & vbNewLine, "") & _
                                    IIf(vRS("Sched4").ToString() <> "", vRS("Sched4").ToString() & " @ " & vRS("Room_4").ToString() & vbNewLine, "") & _
                                    IIf(vRS("Sched4").ToString() <> "", vRS("Sched4").ToString() & " @ " & vRS("Room_5").ToString(), "")
            lv.SubItems.Add(Caption)
            lvConflict.Items.AddRange(New ListViewItem() {lv})
        End While
        vRS.Close()
    End Function


    Private Sub cmdOverRide_Click(sender As System.Object, e As System.EventArgs) Handles cmdOverRide.Click
        tmpIsOverRide = True
        Close()
    End Sub
End Class