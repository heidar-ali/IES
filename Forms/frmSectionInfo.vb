Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports C1.Win.C1FlexGrid

Public Class frmSectionInfo
    Inherits Form

    Dim curSchoolYearTitle As String
    Dim curSectionOfferingID As String
    Dim sSEctionID As String

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub ShowForm(Optional ByVal sSectionOfferingID As String = "", Optional ByVal iTab As Integer = 0)

        'show form


        curSectionOfferingID = sSectionOfferingID

        txtSectionOfferingID_Change(sSectionOfferingID)

        ShowSectionOfferingDetail(sSectionOfferingID)

        LoadSubjectOffering(sSectionOfferingID)

        GenerateStudentList(sSectionOfferingID)

        Me.ShowDialog()
    End Sub

    Private Sub txtSectionOfferingID_Change(ByVal sSectionOfferingID As String)

        Dim vSectionOffering As tSectionOffering

        If GetSectionOfferingByID(sSectionOfferingID, vSectionOffering) = TranDBResult.Success Then
            'found
            lvRoomSchedule.Enabled = True
            lvInstructor.Enabled = True
            lvEnrollees.Enabled = True
            lvDeletedEnrollees.Enabled = True

            sSEctionID = vSectionOffering.SectionID


        Else
            lvRoomSchedule.Items.Clear()
            lvInstructor.Items.Clear()
            lvEnrollees.Items.Clear()
            lvDeletedEnrollees.Items.Clear()

            lvRoomSchedule.Enabled = False
            lvInstructor.Enabled = False
            lvEnrollees.Enabled = False
            lvDeletedEnrollees.Enabled = False

        End If
    End Sub

    Private Sub ShowSectionOfferingDetail(ByVal sSectionOfferingID As String)

        Dim sSQL As String



        sSQL = "SELECT * FROM qryAllSectionOffering WHERE lvKey='" & sSectionOfferingID & "'"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            With Grid
                .set_ColWidth(0, 2100)
                .set_ColWidth(1, 10215 - 2100)

                .set_TextMatrix(0, 1, vRS("Title").ToString())
                .set_TextMatrix(1, 1, vRS("AdviserFullName").ToString())
                .set_TextMatrix(2, 1, vRS("Max Count").ToString())
                .set_TextMatrix(3, 1, vRS("CountOfEnrolmentID").ToString())
                .set_TextMatrix(4, 1, vRS("Min Grade").ToString())
                .set_TextMatrix(5, 1, vRS("Max Grade").ToString())
                .set_TextMatrix(6, 1, vRS("School Year").ToString())
                .set_TextMatrix(7, 1, vRS("Department").ToString())

            End With
        End If
        vRS.Close()

    End Sub
    Private Sub GenerateStudentList(ByVal sSectionOfferingID As String)

        Dim sSQL As String


        sSQL = "SELECT tblEnrolment.EnrolmentID, CONCAT(tblStudent.LastName , ', ' , tblStudent.FirstName , ' ' , tblStudent.MiddleName) AS FullName,tblStudent.StudentID, tblYearLevel.YearLevelTitle, tblEnrolment.DateEnroled, tblEnrolment.CreatedBy" & _
                " FROM tblYearLevel INNER JOIN ((tblSection INNER JOIN tblSectionOffering ON tblSection.SectionID = tblSectionOffering.SectionID) INNER JOIN (tblStudent INNER JOIN tblEnrolment ON tblStudent.StudentID = tblEnrolment.StudentID) ON tblSectionOffering.SectionOfferingID = tblEnrolment.SectionOfferingID) ON tblYearLevel.YearLevelID = tblSection.YearLevelID" & _
                 " WHERE (((tblSectionOffering.SectionOfferingID)='" & sSectionOfferingID & "'))" & _
                " GROUP BY tblEnrolment.EnrolmentID, tblStudent.LastName , ', ' , tblStudent.FirstName , ' ' , tblStudent.MiddleName,tblStudent.StudentID, tblYearLevel.YearLevelTitle, tblEnrolment.DateEnroled, tblEnrolment.CreatedBy" & _
                " ORDER BY tblStudent.LastName , ', ' , tblStudent.FirstName , ' ' , tblStudent.MiddleName;"

        lvEnrollees.Items.Clear()

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        While vRS.Read()
            Dim lv As New ListViewItem(vRS("FullName").ToString())
            lv.SubItems.Add(vRS("StudentID").ToString())
            lv.SubItems.Add(vRS("YearLevelTitle").ToString())
            lv.SubItems.Add(vRS("DateEnroled").ToString())
            lv.SubItems.Add(vRS("CreatedBy").ToString())
            lvEnrollees.Items.AddRange(New ListViewItem() {lv})
        End While
        vRS.Close()
    End Sub
    Public Sub LoadSubjectOffering(ByVal sSectionOfferingID As String)
        Dim sSQL As String
        sSQL = "SELECT tblSubjectOffering.SubjectOfferingID,tblSectionOffering.SectionOfferingID, tblSubjectOffering.SubjectID, tblSubject.SubjectTitle, tblRoom.Room, CONCAT(tblSubjectOffering.Days , ' ' , tblSubjectOffering.SchedTimeStart , ' - ' , tblSubjectOffering.SchedTimeEnd) as Schedule, CONCAT(LastName , ', ' , FirstName , ' ' , MiddleName) AS TeacherFullName" & _
               " FROM tblSection INNER JOIN (tblRoom INNER JOIN (tblSubject INNER JOIN (tblSectionOffering INNER JOIN (tblTeacher INNER JOIN tblSubjectOffering ON tblTeacher.TeacherID = tblSubjectOffering.TeacherID) ON tblSectionOffering.SectionOfferingID = tblSubjectOffering.SectionOfferingID) ON tblSubject.SubjectID = tblSubjectOffering.SubjectID) ON tblRoom.RoomID = tblSectionOffering.RoomID) ON tblSection.SectionID = tblSectionOffering.SectionID" & _
               " WHERE tblSectionOffering.SectionOfferingID='" & sSectionOfferingID & "'" & _
               " ORDER BY tblSubjectOffering.SchedTimeStart;"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim dr As MySqlDataReader = com.ExecuteReader()

        lvRoomSchedule.Items.Clear()

        While dr.Read()
            Dim lv As New ListViewItem(dr("SubjectTitle").ToString())
            lv.SubItems.Add(dr("SubjectID").ToString())
            lv.SubItems.Add(dr("Room").ToString())
            lv.SubItems.Add(dr("Schedule").ToString())
            lvRoomSchedule.Items.AddRange(New ListViewItem() {lv})
        End While
        dr.Close()
    End Sub
    Private Sub frmManageSections_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            If clsCon.con.State = ConnectionState.Open Then
                clsCon.con.Close()
            End If

            clsCon.con.Open()
        Catch exp As Exception
            MessageBox.Show(exp.ToString())
        End Try

        With Grid
            .set_ColWidth(0, 2100)
            .set_ColWidth(1, 10215 - 2100)

            .set_TextMatrix(0, 0, "Section")
            .set_TextMatrix(1, 0, "Adviser")
            .set_TextMatrix(2, 0, "Slots")
            .set_TextMatrix(3, 0, "Enrolled")
            .set_TextMatrix(4, 0, "Min. Grade")
            .set_TextMatrix(5, 0, "Max. Grade")
            .set_TextMatrix(6, 0, "School Year")
            .set_TextMatrix(7, 0, "Department")

        End With

    End Sub


    Private Sub mnuAddRoomschedule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAddRoomschedule.Click
        'Dim frm As New frmScheduler()
        'frm.ShowForm(sSectionID:=sSEctionID)
    End Sub

    Private Sub ViewStudentInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewStudentInfoToolStripMenuItem.Click
        If lvEnrollees.Items.Count > 0 Then
            Dim frm As New frmStudentRecord()
            frm.ShowForm(lvEnrollees.FocusedItem.SubItems(1).Text)
        End If
    End Sub

    Private Sub mnuEditRoomSchedule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditRoomSchedule.Click
    End Sub
End Class
