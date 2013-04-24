'
' * Created by SharpDevelop.
' * User: Janphil Garay
' * Date: 11/17/2011
' * Time: 11:51 PM
' * 
' * To change this template use Tools | Options | Coding | Edit Standard Headers.
' 

Imports System.Drawing
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Drawing.Printing
Imports System.Collections.Generic

Public Class frmViewClassSched
    Inherits Form
    Public Sub New()
        InitializeComponent()
    End Sub


    Public Sub ShowForm(ByVal SectionName As String, ByVal SectionID As String, ByVal CampusID As String, ByVal TermID As Integer)

        FillListView("SELECT SUB.SubjectCode,SUB.SubjectID,SUB.Description,fnClassSectionName(S.SectionID),SUB.Units,SUB.LabUnits,fnEmployeeName(CD.TeacherID),CD.Sched1,fnRoomName2(CD.RoomID), " & _
                   "CD.Sched2,fnRoomName2(CD.RoomID2),CD.Sched3,fnRoomName2(CD.RoomID3),CD.Sched4,fnRoomName2(CD.RoomID4),CD.Sched5,fnRoomName2(CD.RoomID5) FROM tblSection AS S " & _
                   "INNER JOIN tblClassSchedule AS CD ON S.SectionID = CD.SectionID INNER JOIN tblsubject AS SUB ON SUB.SubjectID = CD.SubjectID WHERE S.SectionID='" & SectionID & "' AND S.TermID='" & TermID & "' AND S.CampusID='" & CampusID & "'", lvSubjects, True, 3)

        lblSubjectCount.Text = lvSubjects.Items.Count
        lblCaption.Text = "Class Schedule of " & UCase(SectionName)

        Me.ShowDialog()
    End Sub

    Private Sub frmViewClassSched_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lvSubjects_Click(sender As System.Object, e As System.EventArgs) Handles lvSubjects.Click
        If lvSubjects.Items.Count > 0 Then
            lblSubjectCode.Text = lvSubjects.FocusedItem.Text

            lblSubjectTitle.Text = lvSubjects.FocusedItem.SubItems(2).Text
        End If
    End Sub
End Class