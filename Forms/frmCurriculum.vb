Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frmCurriculum
    Inherits Form

    Dim vDepartment As tDepartment
    Dim ProgramID As String
    Dim xCurriculumID As String

    Dim AcademicProgram, ProgramCurriculum As String


    Public Sub Form_Refresh()
        LoadSubjects()
    End Sub

    Public Sub Form_New()
        Dim frm As New frmAddSubject()
        frm.ShowForm()
    End Sub

    Public Sub Form_Delete()

    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmScheduling_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        fillToolStripCombo(cboCampus, "SELECT ShortName FROM tblCampus")
        fillToolStripCombo(cboCampusID, "SELECT CampusID FROM tblCampus")

        fillMultiColumnCombo2(cboSubCampus, "SELECT ShortName,CampusID FROM tblCampus")
        fillMultiColumnCombo4(cboSubProgram, "SELECT ProgName,ProgID,ProgCode,fnCollegeCode(CollegeID) FROM tblPrograms")

        fillMultiColumnCombo2(cboOfferingTerm, "SELECT fnAcademicYearTerm(TermID),TermID FROM tblAYTerm")
        fillMultiColumnCombo2(cboOfferingCampus, "SELECT CampusName,CampusID FROM tblCampus")

        LoadSubjects() ' Course Masterlist

        ClassSectionGrid() ' Timetable for Subject Offering

        FillListView("SELECT T.EmployeeID,T.TeacherID,fnEmployeeName2(E.EmployeeID),E.DateOfBirth,E.Gender,fnEmployeePosition(E.PosnTitleID),fnDepartmentName(T.DeptID),fnCollegeName(T.CollegeID),fnCampusShortName(T.CampusID) " & _
             "FROM tblTeacher AS T " & _
             "INNER JOIN tblEmployees AS E ON T.EmployeeID = E.EmployeeID;", lvFaculty, True, 3)

        cboCampus.SelectedIndex = (ReadINI("Campus", "Campus", CONFIG_INI_FILE) - 1)
    End Sub

    Private Sub ClassSectionGrid()
        With clsGrid
            .set_TextMatrix(0, 0, "")
            .set_TextMatrix(1, 0, "M")
            .set_TextMatrix(2, 0, "T")
            .set_TextMatrix(3, 0, "W")
            .set_TextMatrix(4, 0, "Th")
            .set_TextMatrix(5, 0, "F")
            .set_TextMatrix(6, 0, "S")
            .set_TextMatrix(7, 0, "Su")
        End With

        For i As Integer = 0 To clsGrid.Cols - 1
            clsGrid.set_ColSort(i, C1.Win.C1FlexGrid.Classic.SortSettings.flexSortNone)
        Next

    End Sub


    Private Sub LoadSubjects()
        'On Error Resume Next
        Dim daSubject As New MySqlDataAdapter()
        Dim dsSubject As New DataSet()
        Dim bs As New BindingSource

        'Dim com As New MySqlCommand("SELECT * FROM tblSubject", clsCon.con)


        Dim com As New MySqlCommand("SELECT SubjectCode,SubjectID,SubjectTitle,Description,AliasCode1,LabUnits,Units,CreditUnits,LecHrs,LabHrs,IsSubjectGE,IsSubjectElective,IsMajorSubject,IsCompSubject,InclGWA,IsNonAcademic, " & _
                                    "fnProgramClassName(LevelID) AS Level,MinSize,MaxSize,IsOtherSchool,InActive,CreatedBy,CreationDate,ModifiedBy,ModifiedDate FROM tblSubject", con)
        Dim dr As MySqlDataReader = com.ExecuteReader()
        'daSubject.SelectCommand = com
        'daSubject.Fill(dsSubject)
        dgView.Rows.Clear()
        While dr.Read()
            Dim n As Integer = dgView.Rows.Add()
            dgView.Rows(n).Cells(0).Value = dr("SubjectCode").ToString()
            dgView.Rows(n).Cells(1).Value = dr("SubjectID").ToString()
            dgView.Rows(n).Cells(2).Value = dr("SubjectTitle").ToString()
            dgView.Rows(n).Cells(3).Value = dr("Description").ToString()
            dgView.Rows(n).Cells(4).Value = dr("AliasCode1").ToString()
            dgView.Rows(n).Cells(5).Value = dr("LabUnits").ToString()
            dgView.Rows(n).Cells(6).Value = dr("Units").ToString()
            dgView.Rows(n).Cells(7).Value = dr("CreditUnits").ToString()
            dgView.Rows(n).Cells(8).Value = dr("LecHrs").ToString()
            dgView.Rows(n).Cells(9).Value = dr("LabHrs").ToString()
            dgView.Rows(n).Cells(10).Value = IntToBoolean(dr("IsSubjectGE").ToString())
            dgView.Rows(n).Cells(11).Value = IntToBoolean(dr("IsSubjectElective").ToString())
            dgView.Rows(n).Cells(12).Value = IntToBoolean(dr("IsMajorSubject").ToString())
            dgView.Rows(n).Cells(13).Value = IntToBoolean(dr("IsCompSubject").ToString())
            dgView.Rows(n).Cells(14).Value = IntToBoolean(dr("InclGWA").ToString())
            dgView.Rows(n).Cells(15).Value = IntToBoolean(dr("IsNonAcademic").ToString())
            dgView.Rows(n).Cells(16).Value = dr("Level").ToString()
            dgView.Rows(n).Cells(17).Value = dr("MinSize").ToString()
            dgView.Rows(n).Cells(18).Value = dr("MaxSize").ToString()
            dgView.Rows(n).Cells(19).Value = IntToBoolean(dr("IsOtherSchool").ToString())
            dgView.Rows(n).Cells(20).Value = IntToBoolean(dr("InActive").ToString())
            dgView.Rows(n).Cells(21).Value = dr("CreatedBy").ToString()
            dgView.Rows(n).Cells(22).Value = dr("CreationDate").ToString()
            dgView.Rows(n).Cells(23).Value = dr("ModifiedBy").ToString()
            dgView.Rows(n).Cells(24).Value = dr("ModifiedDate").ToString()
            dgView.FirstDisplayedScrollingRowIndex = n
            dgView.CurrentCell = dgView.Rows(n).Cells(0)
            dgView.Rows(n).Selected = True
        End While
        dr.Close()
    End Sub

    Private Sub LoadCurriculumsByDepartment()
        Dim com As New MySqlCommand("SELECT * FROM tblCurriculum", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        lsvCurriculum.Items.Clear()
        While vRS.Read()
            Dim lv As New ListViewItem(vRS("CurriculumCode").ToString())
            lv.SubItems.Add(vRS("CurriculumID").ToString())
            lv.SubItems.Add(vRS("Desc").ToString())
            lv.ImageIndex = 0
            lsvCurriculum.Items.AddRange(New ListViewItem() {lv})
        End While
        vRS.Close()
    End Sub

    Private Sub cmdNewSubject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNewSubject.Click
        Dim frm As New frmAddSubject()
        frm.ShowForm()
    End Sub

    Private Sub mnuEditSubject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditSubject.Click
        Dim n As Integer = dgView.CurrentRow.Index

        Dim frm As New frmAddSubject()
        frm.ShowEdit(dgView.Rows(n).Cells(1).Value.ToString())
    End Sub


    Private Sub cmdNewCur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNewCur.Click, ToolStripNew.Click
        On Error GoTo err
        Dim frm As New frmAddCurriculum()
        frm.ShowForm(cboCampus.Text, cboCampusID.Text, listRecord.FocusedItem.SubItems(2).Text, listRecord.FocusedItem.SubItems(1).Text)
        Exit Sub
err:
        DisplayErrorMsg("frmCurriculum", "cmdNewCur_Click", Err.Number, Err.Description)
    End Sub

    Private Sub cmdEditCur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditCur.Click
        On Error Resume Next
        If lsvCurriculum.Items.Count > 0 Then
            If Len(lsvCurriculum.FocusedItem.SubItems(1).Text) > 0 Then
                Dim frm As New frmAddCurriculum()
                frm.ShowEdit(lsvCurriculum.FocusedItem.SubItems(1).Text, cboCampusID.Text)
            End If
        End If
    End Sub

    Private Sub cmdCoursOutLine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CourseOutlineToolStripMenuItem.Click, cmdCourse_Outline.Click
        On Error GoTo err
        If lsvCurriculum.Items.Count > 0 Then
            If Len(lsvCurriculum.FocusedItem.SubItems(1).Text) > 0 Then
                Dim frm As New frmCourseOutline()
                frm.ShowForm(lsvCurriculum.FocusedItem.SubItems(2).Text, lsvCurriculum.FocusedItem.SubItems(1).Text)
            End If
        End If
        Exit Sub
err:
        DisplayErrorMsg("frmCurriculum", "cmdNewCur_Click", Err.Number, Err.Description)
    End Sub

    Private Sub mnuRefreshSubject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRefreshSubject.Click
        LoadSubjects()
    End Sub

    Private Sub cboCampus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCampus.SelectedIndexChanged
        cboCampusID.SelectedIndex = cboCampus.SelectedIndex

        FillListView("SELECT tblPrograms.ProgCode,tblPrograms.ProgID,tblPrograms.ProgName,tblColleges.CollegeCode " & _
                   "FROM tblPrograms INNER JOIN tblColleges ON tblPrograms.CollegeID = tblColleges.CollegeID WHERE tblPrograms.CampusID='" & cboCampusID.Text & "'", listRecord)
    End Sub

    Private Sub FillList(ByVal CurriculumID As String) ' Fill up Listview with data from tables

        ' # ====================== SHOW CURRICULUM DETAILS =================== #

        Dim sSQL As String = "SELECT CD.IndexID,CD.CurriculumID, s.SubjectCode, S.SubjectID,s.Description, s.Units, s.CreditUnits, s.LabUnits, s.LabHrs, S.LecHrs, fnYearTerm(CD.YearTermID) AS YearTerm ,CD.YearTermID " & _
                             " FROM tblcurriculumdetails AS CD, `tblyearlevelterm` AS YLT, tblsubject AS S " & _
                             " WHERE CD.`YearTermID` = YLT.`ID` " & _
                             " AND S.`SubjectID` = CD.SubjectID " & _
                             " AND CD.CurriculumID ='" & CurriculumID & "'" & _
                             " ORDER BY  CD.`CurriculumID` "

        Dim ds As New DataSet

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As New MySqlDataAdapter
        vRS.SelectCommand = com
        vRS.Fill(ds)

        lvDetails.Items.Clear()

        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            With ds.Tables(0)
                Dim lvGroup As New ListViewGroup(.Rows(i).Item(11).ToString, .Rows(i).Item(10).ToString)
                lvDetails.Groups.AddRange(New ListViewGroup() {lvGroup})


                Dim lv As New ListViewItem(.Rows(i).Item("SubjectCode").ToString)

                lv.SubItems.Add(.Rows(i).Item("Description").ToString)
                lv.SubItems.Add(.Rows(i).Item("LabUnits").ToString)
                lv.SubItems.Add(.Rows(i).Item("Units").ToString)
                lv.SubItems.Add(.Rows(i).Item("CreditUnits").ToString)
                lv.SubItems.Add(.Rows(i).Item("LabHrs").ToString)
                lv.SubItems.Add(.Rows(i).Item("LecHrs").ToString)
                lv.SubItems.Add(SetPreRequisite(.Rows(i).Item("CurriculumID").ToString, .Rows(i).Item("SubjectID").ToString))
                lv.SubItems.Add(SetCoRequisite(.Rows(i).Item("CurriculumID").ToString, .Rows(i).Item("SubjectID").ToString))
                lv.SubItems.Add(SetSubEquivalent(.Rows(i).Item("CurriculumID").ToString, .Rows(i).Item("SubjectID").ToString))
                lv.SubItems.Add(.Rows(i).Item("SubjectID").ToString)
                lv.SubItems.Add(.Rows(i).Item("YearTermID").ToString)
                lv.SubItems.Add(.Rows(i).Item("CurriculumID").ToString)
                lv.ImageIndex = 48

                If lvGroup.Name = .Rows(i).Item(11).ToString Then
                    lv.Group = lvDetails.Groups(.Rows(i).Item(11).ToString)
                    lvDetails.Items.AddRange(New ListViewItem() {lv})
                End If
            End With
        Next
       
    End Sub

    Private Function SetPreRequisite(Optional ByVal CurriculumID As String = "", _
                                     Optional ByVal CurSubjectID As String = "") As [String]

        Dim result As [String] = ""
        Dim dt As New DataSet

        Dim com As New MySqlCommand("SELECT fnSubjectCode(SubjectID) AS Pre FROM tblPrerequisite WHERE CurriculumID='" & CurriculumID & _
                                    "' AND Curriculum_SubjectID='" & CurSubjectID & _
                                    "' AND Remarks='Pre-Requisite'", con)
        Dim vRS As New MySqlDataAdapter
        vRS.SelectCommand = com
        vRS.Fill(dt)
        For i As Integer = 0 To dt.Tables(0).Rows.Count - 1
            result = dt.Tables(0).Rows(i).Item("Pre").ToString() & "," & result
        Next
        Return result
    End Function

    Private Function SetCoRequisite(Optional ByVal CurriculumID As String = "", _
                                    Optional ByVal CurSubjectID As String = "") As [String]

        Dim result As [String] = ""
        Dim dt As New DataSet

        Dim com As New MySqlCommand("SELECT fnSubjectCode(SubjectID) AS Co FROM tblPrerequisite WHERE CurriculumID='" & CurriculumID & _
                                    "' AND Curriculum_SubjectID='" & CurSubjectID & _
                                    "' AND Remarks='Co-Requisite'", con)
        Dim vRS As New MySqlDataAdapter
        vRS.SelectCommand = com
        vRS.Fill(dt)
        For i As Integer = 0 To dt.Tables(0).Rows.Count - 1
            result = dt.Tables(0).Rows(i).Item("Co").ToString() & "," & result
        Next
        Return result
    End Function

    Private Function SetSubEquivalent(Optional ByVal CurriculumID As String = "", _
                                   Optional ByVal CurSubjectID As String = "") As [String]

        Dim result As [String] = ""
        Dim dt As New DataSet

        Dim com As New MySqlCommand("SELECT fnSubjectCode(SubjectID) AS Equi FROM tblPrerequisite WHERE CurriculumID='" & CurriculumID & _
                                    "' AND Curriculum_SubjectID='" & CurSubjectID & _
                                    "' AND Remarks='Equivalence'", con)
        Dim vRS As New MySqlDataAdapter
        vRS.SelectCommand = com
        vRS.Fill(dt)
        For i As Integer = 0 To dt.Tables(0).Rows.Count - 1
            result = dt.Tables(0).Rows(i).Item("Equi").ToString() & "," & result
        Next
        Return result
    End Function


    Private Sub lsvCurriculum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsvCurriculum.Click
        If lsvCurriculum.Items.Count > 0 Then
            If Len(lsvCurriculum.FocusedItem.SubItems(1).Text) > 0 Then
                FillList(lsvCurriculum.FocusedItem.SubItems(1).Text)

                ProgramCurriculum = lsvCurriculum.FocusedItem.Text
                TabPage4.Text = AcademicProgram & " - " & ProgramCurriculum

                xCurriculumID = lsvCurriculum.FocusedItem.SubItems(1).Text
            End If
        End If
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click, ToolStripRefresh.Click
        FillListView("SELECT tblCurriculum.CurriculumCode,tblCurriculum.CurriculumID,tblCurriculum.Description " & _
            "FROM tblCurriculum  INNER JOIN tblPrograms ON tblPrograms.ProgID=tblCurriculum.ProgramID WHERE tblPrograms.ProgID='" & ProgramID & "'", lsvCurriculum, True, 15)
    End Sub

    Private Sub cmdPrintDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrintDetails.Click

    End Sub

    Private Sub cmdRefreshDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefreshDetails.Click
        If lsvCurriculum.Items.Count > 0 Then
            FillList(lsvCurriculum.FocusedItem.SubItems(1).Text)
        End If
    End Sub

    Private Sub PropertiesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PropertiesToolStripMenuItem.Click
        If dgView.RowCount > 0 Then
            Dim n As Integer = dgView.CurrentRow.Index

            Dim frm As New frmSubjectProperties()
            frm.ShowForm(dgView.Rows(n).Cells(1).Value.ToString())
        End If
    End Sub

    Private Sub SubjectEquivalentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectEquivalentToolStripMenuItem.Click
        If dgView.RowCount > 0 Then
            Dim n As Integer = dgView.CurrentRow.Index

            Dim frm As New frmSubjectEquivalent()
            frm.ShowForm(dgView.Rows(n).Cells(1).Value.ToString())
        End If
    End Sub

    Private Sub cmdDeleteCur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDeleteCur.Click
        If lvDetails.Items.Count > 0 Then
            ExecuteDeleteCurriculum(lvDetails.FocusedItem.SubItems(1).Text)
        End If
    End Sub

    Private Sub mnuDeleteSubject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDeleteSubject.Click
        If dgView.RowCount > 0 Then
            Dim n As Integer = dgView.CurrentRow.Index
            ExecuteDeleteSubject(dgView.Rows(n).Cells(1).Value.ToString())
        End If
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        If cboLookFor.Text = "" Then Exit Sub

        Select Case cboLookFor.SelectedIndex
            Case 0
                If Not CheckTextBox(txtWhat, "Please enter SUBJECT CODE to Search") Then Exit Sub
                SearchSubjectsBySubjectCode(txtWhat.Text)
            Case 1
                If Not CheckTextBox(txtWhat, "Please enter SUBJECT TITLE to Search") Then Exit Sub
                SearchSubjectsBySubjectTitle(txtWhat.Text)
            Case 2
                If Not CheckTextBox(txtWhat, "Please enter SUBJECT ALIAS to Search") Then Exit Sub
                SearchSubjectsBySubjectAlias(txtWhat.Text)
        End Select
    End Sub

    Private Sub SearchSubjectsBySubjectCode(ByVal sSubjectCode As String)
        On Error Resume Next
        Dim com As New MySqlCommand("SELECT * FROM tblSubject WHERE tblSubject.SubjectCode LIKE '" & sSubjectCode & "%'", clsCon.con)
        Dim dr As MySqlDataReader = com.ExecuteReader()
        dgView.Rows.Clear()
        While dr.Read()
            Dim n As Integer = dgView.Rows.Add()
            dgView.Rows(n).Cells(0).Value = dr("SubjectCode").ToString()
            dgView.Rows(n).Cells(1).Value = dr("SubjectID").ToString()
            dgView.Rows(n).Cells(2).Value = dr("SubjectTitle").ToString()
            dgView.Rows(n).Cells(3).Value = dr("Description").ToString()
            dgView.Rows(n).Cells(4).Value = dr("AliasCode1").ToString()
            dgView.Rows(n).Cells(5).Value = dr("LabUnits").ToString()
            dgView.Rows(n).Cells(6).Value = dr("Units").ToString()
            dgView.Rows(n).Cells(7).Value = dr("CreditUnits").ToString()
            dgView.Rows(n).Cells(8).Value = dr("LecHrs").ToString()
            dgView.Rows(n).Cells(9).Value = dr("LabHrs").ToString()
            dgView.Rows(n).Cells(10).Value = IntToBoolean(dr("IsSubjectGE").ToString())
            dgView.Rows(n).Cells(11).Value = IntToBoolean(dr("IsSubjectElective").ToString())
            dgView.Rows(n).Cells(12).Value = IntToBoolean(dr("IsMajorSubject").ToString())
            dgView.Rows(n).Cells(13).Value = IntToBoolean(dr("IsCompSubject").ToString())
            dgView.Rows(n).Cells(14).Value = IntToBoolean(dr("InclGWA").ToString())
            dgView.Rows(n).Cells(15).Value = IntToBoolean(dr("IsNonAcademic").ToString())
            dgView.Rows(n).Cells(16).Value = dr("Level").ToString()
            dgView.Rows(n).Cells(17).Value = dr("MinSize").ToString()
            dgView.Rows(n).Cells(18).Value = dr("MaxSize").ToString()
            dgView.Rows(n).Cells(19).Value = IntToBoolean(dr("IsOtherSchool").ToString())
            dgView.Rows(n).Cells(20).Value = IntToBoolean(dr("InActive").ToString())
            dgView.Rows(n).Cells(21).Value = dr("CreatedBy").ToString()
            dgView.Rows(n).Cells(22).Value = dr("CreationDate").ToString()
            dgView.Rows(n).Cells(23).Value = dr("ModifiedBy").ToString()
            dgView.Rows(n).Cells(24).Value = dr("ModifiedDate").ToString()
            dgView.FirstDisplayedScrollingRowIndex = n
            dgView.CurrentCell = dgView.Rows(n).Cells(0)
            dgView.Rows(n).Selected = True
        End While
        dr.Close()
    End Sub

    Private Sub SearchSubjectsBySubjectTitle(ByVal sSubjectTitle As String)
        On Error Resume Next
        Dim com As New MySqlCommand("SELECT * FROM tblSubject WHERE tblSubject.SubjectTitle LIKE '" & sSubjectTitle & "%'", clsCon.con)
        Dim dr As MySqlDataReader = com.ExecuteReader()
        dgView.Rows.Clear()
        While dr.Read()
            Dim n As Integer = dgView.Rows.Add()
            dgView.Rows(n).Cells(0).Value = dr("SubjectCode").ToString()
            dgView.Rows(n).Cells(1).Value = dr("SubjectID").ToString()
            dgView.Rows(n).Cells(2).Value = dr("SubjectTitle").ToString()
            dgView.Rows(n).Cells(3).Value = dr("Description").ToString()
            dgView.Rows(n).Cells(4).Value = dr("AliasCode1").ToString()
            dgView.Rows(n).Cells(5).Value = dr("LabUnits").ToString()
            dgView.Rows(n).Cells(6).Value = dr("Units").ToString()
            dgView.Rows(n).Cells(7).Value = dr("CreditUnits").ToString()
            dgView.Rows(n).Cells(8).Value = dr("LecHrs").ToString()
            dgView.Rows(n).Cells(9).Value = dr("LabHrs").ToString()
            dgView.Rows(n).Cells(10).Value = IntToBoolean(dr("IsSubjectGE").ToString())
            dgView.Rows(n).Cells(11).Value = IntToBoolean(dr("IsSubjectElective").ToString())
            dgView.Rows(n).Cells(12).Value = IntToBoolean(dr("IsMajorSubject").ToString())
            dgView.Rows(n).Cells(13).Value = IntToBoolean(dr("IsCompSubject").ToString())
            dgView.Rows(n).Cells(14).Value = IntToBoolean(dr("InclGWA").ToString())
            dgView.Rows(n).Cells(15).Value = IntToBoolean(dr("IsNonAcademic").ToString())
            dgView.Rows(n).Cells(16).Value = dr("Level").ToString()
            dgView.Rows(n).Cells(17).Value = dr("MinSize").ToString()
            dgView.Rows(n).Cells(18).Value = dr("MaxSize").ToString()
            dgView.Rows(n).Cells(19).Value = IntToBoolean(dr("IsOtherSchool").ToString())
            dgView.Rows(n).Cells(20).Value = IntToBoolean(dr("InActive").ToString())
            dgView.Rows(n).Cells(21).Value = dr("CreatedBy").ToString()
            dgView.Rows(n).Cells(22).Value = dr("CreationDate").ToString()
            dgView.Rows(n).Cells(23).Value = dr("ModifiedBy").ToString()
            dgView.Rows(n).Cells(24).Value = dr("ModifiedDate").ToString()
            dgView.FirstDisplayedScrollingRowIndex = n
            dgView.CurrentCell = dgView.Rows(n).Cells(0)
            dgView.Rows(n).Selected = True
        End While
        dr.Close()
    End Sub


    Private Sub SearchSubjectsBySubjectAlias(ByVal sSubjectCode As String)
        On Error Resume Next
        Dim com As New MySqlCommand("SELECT * FROM tblSubject WHERE tblSubject.AliasCode1= '" & sSubjectCode & "'", clsCon.con)
        Dim dr As MySqlDataReader = com.ExecuteReader()
        dgView.Rows.Clear()
        While dr.Read()
            Dim n As Integer = dgView.Rows.Add()
            dgView.Rows(n).Cells(0).Value = dr("SubjectCode").ToString()
            dgView.Rows(n).Cells(1).Value = dr("SubjectID").ToString()
            dgView.Rows(n).Cells(2).Value = dr("SubjectTitle").ToString()
            dgView.Rows(n).Cells(3).Value = dr("Description").ToString()
            dgView.Rows(n).Cells(4).Value = dr("AliasCode1").ToString()
            dgView.Rows(n).Cells(5).Value = dr("LabUnits").ToString()
            dgView.Rows(n).Cells(6).Value = dr("Units").ToString()
            dgView.Rows(n).Cells(7).Value = dr("CreditUnits").ToString()
            dgView.Rows(n).Cells(8).Value = dr("LecHrs").ToString()
            dgView.Rows(n).Cells(9).Value = dr("LabHrs").ToString()
            dgView.Rows(n).Cells(10).Value = IntToBoolean(dr("IsSubjectGE").ToString())
            dgView.Rows(n).Cells(11).Value = IntToBoolean(dr("IsSubjectElective").ToString())
            dgView.Rows(n).Cells(12).Value = IntToBoolean(dr("IsMajorSubject").ToString())
            dgView.Rows(n).Cells(13).Value = IntToBoolean(dr("IsCompSubject").ToString())
            dgView.Rows(n).Cells(14).Value = IntToBoolean(dr("InclGWA").ToString())
            dgView.Rows(n).Cells(15).Value = IntToBoolean(dr("IsNonAcademic").ToString())
            dgView.Rows(n).Cells(16).Value = dr("Level").ToString()
            dgView.Rows(n).Cells(17).Value = dr("MinSize").ToString()
            dgView.Rows(n).Cells(18).Value = dr("MaxSize").ToString()
            dgView.Rows(n).Cells(19).Value = IntToBoolean(dr("IsOtherSchool").ToString())
            dgView.Rows(n).Cells(20).Value = IntToBoolean(dr("InActive").ToString())
            dgView.Rows(n).Cells(21).Value = dr("CreatedBy").ToString()
            dgView.Rows(n).Cells(22).Value = dr("CreationDate").ToString()
            dgView.Rows(n).Cells(23).Value = dr("ModifiedBy").ToString()
            dgView.Rows(n).Cells(24).Value = dr("ModifiedDate").ToString()
            dgView.FirstDisplayedScrollingRowIndex = n
            dgView.CurrentCell = dgView.Rows(n).Cells(0)
            dgView.Rows(n).Selected = True
        End While
        dr.Close()
    End Sub

    Private Sub FilterSubjectsByCurriculum(ByVal CurriculumID As String)
        On Error Resume Next
        Dim com As New MySqlCommand("SELECT S.`SubjectCode`,S.`SubjectID`,S.`SubjectTitle`,S.`Description`,S.`AliasCode1`,S.`LabUnits`,S.`Units`, " & _
                                    "S.`CreditUnits`,S.`LecHrs`,S.`LabHrs`,S.`IsSubjectGE`,S.`IsSubjectElective`,S.`IsMajorSubject`,S.`IsCompSubject`, " & _
                                    "S.`InclGWA`,S.`IsNonAcademic`,S.`LevelID`,S.`MinSize`,S.`MaxSize`,S.`IsOtherSchool`,S.`InActive`,S.`CreatedBy`, " & _
                                    "S.`CreationDate`,S.`ModifiedBy`,S.`ModifiedDate` " & _
                                    "FROM `tblsubject` AS S INNER JOIN tblCurriculumDetails AS CD " & _
                                    "ON S.SubjectID = CD.SubjectID " & _
                                    "WHERE CD.CurriculumID = '" & CurriculumID & "'", clsCon.con)
        Dim dr As MySqlDataReader = com.ExecuteReader()
        dgView.Rows.Clear()
        While dr.Read()
            Dim n As Integer = dgView.Rows.Add()
            dgView.Rows(n).Cells(0).Value = dr("SubjectCode").ToString()
            dgView.Rows(n).Cells(1).Value = dr("SubjectID").ToString()
            dgView.Rows(n).Cells(2).Value = dr("SubjectTitle").ToString()
            dgView.Rows(n).Cells(3).Value = dr("Description").ToString()
            dgView.Rows(n).Cells(4).Value = dr("AliasCode1").ToString()
            dgView.Rows(n).Cells(5).Value = dr("LabUnits").ToString()
            dgView.Rows(n).Cells(6).Value = dr("Units").ToString()
            dgView.Rows(n).Cells(7).Value = dr("CreditUnits").ToString()
            dgView.Rows(n).Cells(8).Value = dr("LecHrs").ToString()
            dgView.Rows(n).Cells(9).Value = dr("LabHrs").ToString()
            dgView.Rows(n).Cells(10).Value = IntToBoolean(dr("IsSubjectGE").ToString())
            dgView.Rows(n).Cells(11).Value = IntToBoolean(dr("IsSubjectElective").ToString())
            dgView.Rows(n).Cells(12).Value = IntToBoolean(dr("IsMajorSubject").ToString())
            dgView.Rows(n).Cells(13).Value = IntToBoolean(dr("IsCompSubject").ToString())
            dgView.Rows(n).Cells(14).Value = IntToBoolean(dr("InclGWA").ToString())
            dgView.Rows(n).Cells(15).Value = IntToBoolean(dr("IsNonAcademic").ToString())
            dgView.Rows(n).Cells(16).Value = dr("Level").ToString()
            dgView.Rows(n).Cells(17).Value = dr("MinSize").ToString()
            dgView.Rows(n).Cells(18).Value = dr("MaxSize").ToString()
            dgView.Rows(n).Cells(19).Value = IntToBoolean(dr("IsOtherSchool").ToString())
            dgView.Rows(n).Cells(20).Value = IntToBoolean(dr("InActive").ToString())
            dgView.Rows(n).Cells(21).Value = dr("CreatedBy").ToString()
            dgView.Rows(n).Cells(22).Value = dr("CreationDate").ToString()
            dgView.Rows(n).Cells(23).Value = dr("ModifiedBy").ToString()
            dgView.Rows(n).Cells(24).Value = dr("ModifiedDate").ToString()
            dgView.FirstDisplayedScrollingRowIndex = n
            dgView.CurrentCell = dgView.Rows(n).Cells(0)
            dgView.Rows(n).Selected = True
        End While
        dr.Close()
    End Sub

    Private Sub cmdAddNewSubject_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdAddNewSubject.LinkClicked
        cmdNewSubject_Click(sender, e)
    End Sub

    Private Sub cmdEditSubject_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
        SubjectEquivalentToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub cmdSubInfo_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
        PropertiesToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub opt1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opt1.CheckedChanged
        If opt1.Checked = True Then
            cboProgramAccess.Enabled = True
        Else
            cboProgramAccess.Enabled = False
        End If
    End Sub

    Private Sub opt2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opt2.CheckedChanged
        If opt2.Checked = True Then
            cboSubCampus.Enabled = True
            cboSubProgram.Enabled = True
            lvCurriculum.Enabled = True
        Else
            cboSubCampus.Enabled = False
            cboSubProgram.Enabled = False
            lvCurriculum.Enabled = False
        End If
    End Sub

    Private Sub cboSubProgram_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSubProgram.SelectedIndexChanged
        FillListView("SELECT CurriculumCode,CurriculumID,Description FROM tblCurriculum WHERE ProgramID='" & cboSubProgram.SelectedItem.Col2 & "'", lvCurriculum, False)
    End Sub


    Private Sub SetPreToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SetPreToolStripMenuItem.Click
        Dim frm As New frmPrerequisite
        frm.ShowForm(lvDetails.FocusedItem.SubItems(10).Text, lvDetails.FocusedItem.SubItems(12).Text, lvDetails.FocusedItem.SubItems(10).Text)
    End Sub

    Private Sub listRecord_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles listRecord.SelectedIndexChanged
        If cboCampus.Text = "" Or cboCampusID.Text = "" Then
            MsgBox("Unable to load record.. " & vbNewLine & "Please Select campus", vbExclamation)
            Exit Sub
        End If

        lvDetails.Items.Clear()

        FillListView("SELECT tblCurriculum.CurriculumCode,tblCurriculum.CurriculumID,tblCurriculum.Description " & _
                    "FROM tblCurriculum  INNER JOIN tblPrograms ON tblPrograms.ProgID=tblCurriculum.ProgramID WHERE tblPrograms.ProgID='" & listRecord.FocusedItem.SubItems(1).Text & "'", lsvCurriculum, True, 15)

        ProgramID = listRecord.FocusedItem.SubItems(1).Text

    End Sub

    Private Sub SubjectEquivalentToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles SubjectEquivalentToolStripMenuItem1.Click
        If lvDetails.Items.Count > 0 Then
            Dim frm As New frmSubjectEquivalentByCurriculum
            frm.ShowForm(lvDetails.FocusedItem.SubItems(10).Text, xCurriculumID)
        End If
    End Sub

    Private Sub lvCurriculum_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lvCurriculum.SelectedIndexChanged, lsvCurriculum.SelectedIndexChanged
        If lvCurriculum.Items.Count > 0 Then
            FilterSubjectsByCurriculum(lvCurriculum.FocusedItem.SubItems(1).Text)
        End If
    End Sub

    Private Sub cboOfferingCampus_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboOfferingCampus.SelectedIndexChanged
        fillMultiColumnCombo4(cboCollege, "SELECT CollegeCode,CollegeName,fnCampusShortName(CampusID),CollegeID FROM tblColleges WHERE CampusID='" & cboOfferingCampus.SelectedItem.Col2 & "'")
    End Sub

    Private Sub cboCollege_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboCollege.SelectedIndexChanged
        fillMultiColumnCombo4(cboProgram, "SELECT ProgCode,ProgName,fnCollegeCode(CollegeID),ProgID FROM tblPrograms WHERE CollegeID='" & cboCollege.SelectedItem.Col4 & "'")
    End Sub

    Private Sub cboSectionType_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboSectionType.SelectedIndexChanged
        Select Case cboSectionType.SelectedIndex
            Case 0
                FillListView("SELECT SectionTitle,SectionID, fnProgramName(ProgramID) FROM tblSection WHERE TermID='" & cboOfferingTerm.SelectedItem.Col2 & _
                             "' AND CampusID='" & cboOfferingCampus.SelectedItem.Col2 & "' AND ProgramID='" & cboProgram.SelectedItem.Col4 & "'", lvSection, False)
            Case 1
                FillListView("SELECT SectionTitle,SectionID, fnProgramName(ProgramID) FROM tblSection WHERE TermID='" & cboOfferingTerm.SelectedItem.Col2 & _
                            "' AND CampusID='" & cboOfferingCampus.SelectedItem.Col2 & "' AND ProgramID='" & cboProgram.SelectedItem.Col4 & "' AND IsBlock = '1'", lvSection, False)
            Case 2
                FillListView("SELECT SectionTitle,SectionID, fnProgramName(ProgramID) FROM tblSection WHERE TermID='" & cboOfferingTerm.SelectedItem.Col2 & _
                            "' AND CampusID='" & cboOfferingCampus.SelectedItem.Col2 & "' AND ProgramID='" & cboProgram.SelectedItem.Col4 & "' AND IsBlock = '0'", lvSection, False)
        End Select
    End Sub

    Private Sub lvSection_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lvSection.SelectedIndexChanged
        If lvSection.Items.Count > 0 Then
            ShowSubjectOffering(lvSection.FocusedItem.SubItems(1).Text, cboOfferingTerm.SelectedItem.Col2, cboOfferingCampus.SelectedItem.Col2)
        End If
    End Sub

    Private Sub ShowSubjectOffering(ByVal SectionID As String, ByVal TermID As Integer, ByVal CampusID As Integer)
        FillListView("SELECT SUB.SubjectCode,SUB.SubjectID,SUB.Description,fnClassSectionName(S.SectionID),SUB.Units,SUB.LabUnits,fnEmployeeName(CD.TeacherID),CD.Sched1,fnRoomName2(CD.RoomID), " & _
                    "CD.Sched2,fnRoomName2(CD.RoomID2),CD.Sched3,fnRoomName2(CD.RoomID3),CD.Sched4,fnRoomName2(CD.RoomID4),CD.Sched5,fnRoomName2(CD.RoomID5),SubjectOfferingID FROM tblSection AS S " & _
                    "INNER JOIN tblClassSchedule AS CD ON S.SectionID = CD.SectionID INNER JOIN tblsubject AS SUB ON SUB.SubjectID = CD.SubjectID WHERE S.SectionID='" & SectionID & "' AND S.TermID='" & TermID & "' AND S.CampusID='" & CampusID & "'", lvOffering, False)
    End Sub

    Private Sub dgView_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgView.CellContentClick

    End Sub

    Private Sub listRecord_Click(sender As System.Object, e As System.EventArgs) Handles listRecord.Click
        AcademicProgram = listRecord.FocusedItem.SubItems(2).Text
        TabPage4.Text = AcademicProgram & " - " & ProgramCurriculum
        ProgramID = listRecord.FocusedItem.SubItems(1).Text
    End Sub
End Class
