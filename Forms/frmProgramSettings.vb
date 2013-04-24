Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Windows.Forms

Public Class frmProgramSettings
    Inherits Form

    Dim tvRoot As TreeNode
    Dim tvNode As TreeNode
    Dim tvNode1 As TreeNode
    Dim tvNode2 As TreeNode

    Dim daSchoolYear As New MySqlDataAdapter
    Dim daYearLevel As New MySqlDataAdapter
    Dim daDepartment As New MySqlDataAdapter
    Dim daSection As New MySqlDataAdapter

    Dim dsgeneral As New DataSet()
    Dim dsgeneral1 As New DataSet()
    Dim dsgeneral2 As New DataSet()
    Dim dsgeneral3 As New DataSet()

    Dim slSchoolYearTitle$, slCollegeTitle$, slProgramTitle$, slYearLevelTitle$, slSectionTitle$

    Dim sSQL As String = "SELECT CONCAT('[','',SchoolYear,']',' ', SchoolTerm) As SchoolYear" & _
                " FROM tblSchoolYear;"

    Dim sSQL1 As String = "SELECT CONCAT(CollegeName,' ',CollegeCode) As CollegeName" & _
                " FROM tblColleges"

    Dim sSQL2 As String = "SELECT CONCAT(ProgName,' ', ProgCode) AS AcadProg FROM tblPrograms"

    Dim sSQL3 As String = "SELECT YearLevelTitle" & _
                " FROM tblYearLevel"

    Dim sSQL4 As String = "SELECT tblSection.SectionTitle, tblSectionOffering.SchoolYear, tblDepartment.DepartmentTitle, tblYearLevel.YearLevelTitle,tblSectionOffering.SectionOfferingID" & _
           " FROM tblYearLevel INNER JOIN ((tblDepartment INNER JOIN tblSection ON tblDepartment.DepartmentID = tblSection.DepartmentID) INNER JOIN tblSectionOffering ON tblSection.SectionID = tblSectionOffering.SectionID) ON tblYearLevel.YearLevelID = tblSection.YearLevelID" & _
           " GROUP BY tblSectionOffering.SectionOfferingID, tblSectionOffering.SchoolYear, tblDepartment.DepartmentTitle, tblYearLevel.YearLevelTitle, tblSection.SectionTitle;"

    Dim IsStarted As Boolean


    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Refresh_SchoolYear()

        'Dim i As Integer
        'Dim ii As Integer
        'Dim iii As Integer
        'Dim iv As Integer


        'Dim slYearLevelTitleID$, slDepartmentTitleID$, slSchoolYearTitleID$, sSectionTitleID$

        'tvDirectory.Nodes.Clear()

        'Dim com As New MySqlCommand(sSQL, clsCon.con)
        'daSchoolYear.SelectCommand = com
        'daSchoolYear.Fill(dsgeneral, "tblAyTerm")


        'Dim com1 As New MySqlCommand(sSQL1, clsCon.con)
        'daDepartment.SelectCommand = com1
        'daDepartment.Fill(dsgeneral1, "tblColleges")


        'Dim com2 As New MySqlCommand(sSQL2, clsCon.con)
        'daYearLevel.SelectCommand = com2
        'daYearLevel.Fill(dsgeneral2, "tblYearLevel")


        'Dim com3 As New MySqlCommand(sSQL3, clsCon.con)
        'daSection.SelectCommand = com3
        'daSection.Fill(dsgeneral3, "tblSection")


        'For i = 0 To dsgeneral.Tables("tblAYTerm").Rows.Count - 1
        '    slSchoolYearTitle = dsgeneral.Tables("tblAYTerm").Rows(i).Item("SchoolYear").ToString()

        '    tvRoot = tvDirectory.Nodes.Add(keySchoolYear & ";" & slSchoolYearTitle, slSchoolYearTitle)


        '    For ii = 0 To dsgeneral1.Tables("tblColleges").Rows.Count - 1
        '        slCollegeTitle = dsgeneral1.Tables("tblDColleges").Rows(ii).Item("CollegeName").ToString()

        '        tvNode = tvRoot.Nodes.Add(keyDepartment & ";" & slSchoolYearTitle & ";" & slCollegeTitle, slProgramTitle)


        '        For iii = 0 To dsgeneral2.Tables("tblYearLevel").Rows.Count - 1
        '            slYearLevelTitle = dsgeneral2.Tables("tblYearLevel").Rows(iii).Item("YearLevelTitle").ToString()

        '            tvNode1 = tvNode.Nodes.Add(KeyYearLevel & ";" & slSchoolYearTitle & ";" & slCollegeTitle & ";" & slYearLevelTitle, slYearLevelTitle)


        '            For iv = 0 To dsgeneral3.Tables("tblSection").Rows.Count - 1
        '                slYearLevelTitleID = dsgeneral3.Tables("tblSection").Rows(iv).Item("YearLevelTitle").ToString()
        '                slDepartmentTitleID = dsgeneral3.Tables("tblSection").Rows(iv).Item("DepartmentTitle").ToString()
        '                slSchoolYearTitleID = dsgeneral3.Tables("tblSection").Rows(iv).Item("SchoolYear").ToString()

        '                If slSchoolYearTitle = slSchoolYearTitleID Then
        '                    If slCollegeTitle = slDepartmentTitleID Then
        '                        If slYearLevelTitle = slYearLevelTitleID Then
        '                            slSectionTitle = dsgeneral3.Tables("tblSection").Rows(iv).Item("SectionTitle").ToString()
        '                            sSectionTitleID = dsgeneral3.Tables("tblSection").Rows(iv).Item("SectionOfferingID").ToString()

        '                            tvNode2 = tvNode1.Nodes.Add(KeySectionOffering & ";" & slSchoolYearTitle & ";" & slCollegeTitle & ";" & slYearLevelTitle & ";" & sSectionTitleID, slSectionTitle)
        '                        End If
        '                    End If
        '                End If

        '            Next

        '        Next

        '    Next
        'Next

    End Sub

    Private Sub LoadListView()
        Dim com As New MySqlCommand("SELECT CONCAT(SchoolYear,' ',SchoolTerm) AS SchoolYear FROM tblAYTerm", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        ListView.Items.Clear()
        While vRS.Read()
            Dim lv As New ListViewItem(vRS("SchoolYear").ToString())
            lv.ImageIndex = 0
            ListView.Items.AddRange(New ListViewItem() {lv})
        End While
        vRS.Close()
    End Sub



    Private Sub frmSettings_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        If clsCon.con.State = ConnectionState.Open Then
            clsCon.con.Close()
        End If
        clsCon.con.Open()
        LoadListView()
        Refresh_SchoolYear()
    End Sub
    Public Sub Faculty_Delete()
        Dim i As Integer
        Dim iSelectedCount As Integer
        Dim sMSG As String
        Dim sLVItemKey As String
        Dim EntryDeletedCount As Integer
        EntryDeletedCount = 0


        sMSG = "WARNING:" & vbNewLine & "You are about to delete 1 Teacher Entry and you cannot Undo this operation." & vbNewLine & _
        " Are you sure to delete it?"

        If MsgBox(sMSG, vbQuestion + vbYesNo) = vbYes Then


            sLVItemKey = lsvFaculty.FocusedItem.SubItems(1).Text

            If DeleteTeacher(sLVItemKey) = TranDBResult.Success Then
                EntryDeletedCount = EntryDeletedCount + 1
            Else
                'temp
                'fatal
                MsgBox("Unable to delete Teacher Entry with ID: " & sLVItemKey)
            End If



            If EntryDeletedCount > 0 Then
                'show info
                MsgBox(EntryDeletedCount & " Entry/s deleted.", vbInformation)
                'refresh list
            End If

        End If 'user is sure to delete entry
    End Sub
    Public Sub Room_Delete()
        Dim i As Integer
        Dim iSelectedCount As Integer
        Dim sMSG As String
        Dim sLVItemKey As String
        Dim EntryDeletedCount As Integer

        Dim lEnrolmentCount As Long 'Enrolment count by the selected Room

        'defaults
        EntryDeletedCount = 0


        sMSG = "WARNING:" & vbNewLine & "You are about to delete 1 Room Entry and you cannot Undo this operation." & vbNewLine & _
        " Are you sure to delete it?"

        If MsgBox(sMSG, vbQuestion + vbYesNo) = vbYes Then

            sLVItemKey = lsvClassroom.FocusedItem.SubItems(1).Text

            If DeleteRoom(sLVItemKey) = TranDBResult.Success Then
                EntryDeletedCount = EntryDeletedCount + 1
            Else
                'temp
                'fatal
                MsgBox("Unable to delete Room Entry with ID: " & sLVItemKey)
            End If




            If EntryDeletedCount > 0 Then
                'show info
                MsgBox(EntryDeletedCount & " Entry/s deleted.", vbInformation)
                'refresh list
            End If

        End If 'user is sure to delete entry
    End Sub
    Public Sub Subject_Delete()
        Dim i As Integer
        Dim iSelectedCount As Integer
        Dim sMSG As String
        Dim sLVItemKey As String
        Dim EntryDeletedCount As Integer

        Dim lEnrolmentCount As Long 'Enrolment count by the selected Subject

        'defaults
        EntryDeletedCount = 0



        If iSelectedCount = 1 Then
            sMSG = "WARNING:" & vbNewLine & "You are about to delete 1 Subject Entry and you cannot Undo this operation." & vbNewLine & _
            " Are you sure to delete it?"
        Else
            sMSG = "WARNING:" & vbNewLine & "You are about to delete " & iSelectedCount & " Subject Entries and you cannot Undo this operation." & vbNewLine & _
            " Are you sure to delete it?"
        End If

        If MsgBox(sMSG, vbQuestion + vbYesNo) = vbYes Then


            sLVItemKey = (lsvSubject.FocusedItem.SubItems(1).Text)

            If DeleteSubject(sLVItemKey) = TranDBResult.Success Then
                EntryDeletedCount = EntryDeletedCount + 1
            Else
                'temp
                'fatal
                MsgBox("Unable to delete Subject Entry with ID: " & sLVItemKey)
            End If




            If EntryDeletedCount > 0 Then
                'show info
                MsgBox(EntryDeletedCount & " Entry/s deleted.", vbInformation)
                'refresh list
            End If

        End If 'user is sure to delete entry
    End Sub

    Private Sub tvDirectory_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvDirectory.AfterSelect
        Dim splitKey() As String
        splitKey = Split(e.Node.Name, ";")

        Select Case splitKey(0)
            Case keySchoolYear
                Text = "S.Y.: " & e.Node.Text
                ShowForm(sSQL1)
            Case keyDepartment
                Text = "S.Y.: " & e.Node.Text & " - " & splitKey(1)
                ShowForm(sSQL2)
            Case KeyYearLevel
                Text = "S.Y.: " & e.Node.Text & " - " & splitKey(1) & " - " & splitKey(2) & " - " & splitKey(3)
                ShowForm(sSQL3)
            Case KeySectionOffering
                GenerateStudentList(splitKey(4))
        End Select
    End Sub
    Public Sub ShowForm(ByVal sSQL As String)
        Dim c As Integer

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()

        ListView.Items.Clear()
        Do While vRS.Read()
            Dim lv As New ListViewItem(vRS(0).ToString())

            For c = 1 To vRS.FieldCount - 1
                lv.SubItems.Add(vRS.Item(c).ToString)
            Next

            lv.ImageIndex = 0
            ListView.Items.AddRange(New ListViewItem() {lv})
        Loop
        vRS.Close()
    End Sub
    Private Sub GenerateStudentList(ByVal ID As String)

        Dim sSQL As String


        sSQL = "SELECT CONCAT(tblStudent.LastName , ', ' , tblStudent.FirstName , ' ' ,tblStudent.MiddleName) AS FullName,tblStudent.StudentID, Avg(tblGrade.GradeValue) AS AvgOfGradeValue, If(Avg(tblGrade.GradeValue)<75 Or Min(tblGrade.GradeValue)<75,'Failed','Passed') AS Remark, tblEnrolment.DateEnroled" & _
                " FROM tblStudent INNER JOIN ((tblSection INNER JOIN tblSectionOffering ON tblSection.SectionID = tblSectionOffering.SectionID) INNER JOIN (tblEnrolment INNER JOIN tblGrade ON tblEnrolment.EnrolmentID = tblGrade.EnrolmentID) ON tblSectionOffering.SectionOfferingID = tblEnrolment.SectionOfferingID) ON tblStudent.StudentID = tblEnrolment.StudentID" & _
                " WHERE (((tblSectionOffering.SectionOfferingID)='" & ID & "'))" & _
                " GROUP BY CONCAT(tblStudent.LastName , ', ' , tblStudent.FirstName , ' ' , tblStudent.MiddleName),tblStudent.StudentID, tblEnrolment.DateEnroled" & _
                " ORDER BY CONCAT(tblStudent.LastName , ', ' , tblStudent.FirstName , ' ' , tblStudent.MiddleName)"

        Dim c As Integer

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()

        ListView.Clear()
        ListView.Items.Clear()

        Dim lvColumnHeader As ColumnHeader

        lvColumnHeader = ListView.Columns.Add("Student Name")
        lvColumnHeader.Width = 600

        lvColumnHeader = ListView.Columns.Add("Student ID")
        lvColumnHeader.Width = 300

        lvColumnHeader = ListView.Columns.Add("Grade")
        lvColumnHeader.Width = 200

        lvColumnHeader = ListView.Columns.Add("Remarks")
        lvColumnHeader.Width = 200

        lvColumnHeader = ListView.Columns.Add("Date Enroled")
        lvColumnHeader.Width = 300


        Do While vRS.Read()
            Dim lv As New ListViewItem(vRS("FullName").ToString())
            lv.SubItems.Add(vRS("StudentID").ToString)
            lv.SubItems.Add(vRS("AvgOfGradeValue").ToString)
            lv.SubItems.Add(vRS("Remark").ToString)
            lv.SubItems.Add(vRS("DateEnroled").ToString)

            lv.ToolTipText = vRS("FullName").ToString() & " " & vRS("StudentID").ToString & vbNewLine & " Date Enrolled:" & vRS("DateEnroled").ToString
            lv.ImageIndex = 3

            ListView.View = View.Details
            ListView.Items.AddRange(New ListViewItem() {lv})
        Loop
        vRS.Close()
    End Sub

    Private Sub PropertiesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PropertiesToolStripMenuItem.Click
        Select Case ListView.Tag
            Case keySchoolYear

            Case keyDepartment

            Case KeyYearLevel

            Case KeySectionOffering
                Dim frm As New frmStudentRecord()
                frm.ShowForm(ListView.FocusedItem.SubItems(1).Text)
        End Select
    End Sub

End Class
