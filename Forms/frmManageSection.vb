Imports System.Diagnostics
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class frmManageSection

    Dim xCampusID As Integer
    Dim xCollegeID As String
    Dim xProgramID As String
    Dim xSectionID As String


    Dim SecState As SectionState

    Private Sub f_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        fillToolStripCombo(cboAY, "SELECT fnAcademicYearTerm(TermID) AS AYTerm FROM tblAYTerm")
        fillToolStripCombo(cboAYID, "SELECT TermID FROM tblAYTerm")

        fillMultiColumnCombo2(cboCampus, "SELECT CampusName,CampusID FROM tblCampus")

    End Sub

    Private Sub LoadTree(ByVal TermID As String, ByVal sCollegeID As String)
        Dim tvPrograms As TreeNode
        Dim tvSection As TreeNode

        Dim daPrograms As New MySqlDataAdapter
        Dim daSection As New MySqlDataAdapter

        Dim dsPrograms As New DataSet
        Dim dsSection As New DataSet

        Dim iii, iv As Integer

        Dim ProgramID$, Programs$
        Dim ProgramCollegeID$, ProgramCampusID$
        Dim SectionCampusID$, SectionCollegeID$, SectionProgramID$, SectionID$, Section$


        Dim comm As New MySqlCommand("SELECT ProgName,CollegeID,CampusID,ProgID FROM tblPrograms WHERE CollegeID='" & sCollegeID & "'", con)
        daPrograms.SelectCommand = comm
        daPrograms.Fill(dsPrograms, "tblPrograms")

        Dim cmdd As New MySqlCommand("SELECT CampusID,ProgramID,CollegeID,SectionID,SectionTitle FROM tblSection WHERE TermID='" & TermID & "'", con)
        daSection.SelectCommand = cmdd
        daSection.Fill(dsSection, "tblSection")

        TreeView.Nodes.Clear()

        For iii = 0 To dsPrograms.Tables("tblPrograms").Rows.Count - 1
            Programs = dsPrograms.Tables("tblPrograms").Rows(iii).Item("ProgName").ToString()
            ProgramID = dsPrograms.Tables("tblPrograms").Rows(iii).Item("ProgID").ToString()
            ProgramCollegeID = dsPrograms.Tables("tblPrograms").Rows(iii).Item("CollegeID").ToString()
            ProgramCampusID = dsPrograms.Tables("tblPrograms").Rows(iii).Item("CampusID").ToString()

            tvPrograms = TreeView.Nodes.Add(keyPrograms & ";" & ProgramID, Programs)
            tvPrograms.SelectedImageIndex = 3
            tvPrograms.StateImageIndex = 3

            For iv = 0 To dsSection.Tables("tblSection").Rows.Count - 1
                Section = dsSection.Tables("tblSection").Rows(iv).Item("SectionTitle").ToString()
                SectionID = dsSection.Tables("tblSection").Rows(iv).Item("SectionID").ToString()
                SectionCampusID = dsSection.Tables("tblSection").Rows(iv).Item("CampusID").ToString()
                SectionProgramID = dsSection.Tables("tblSection").Rows(iv).Item("ProgramID").ToString()
                SectionCollegeID = dsSection.Tables("tblSection").Rows(iv).Item("CollegeID").ToString()

                If ProgramCampusID = SectionCampusID Then
                    If ProgramID = SectionProgramID Then
                        If ProgramCollegeID = SectionCollegeID Then
                            tvSection = tvPrograms.Nodes.Add(keySection & ";" & keyPrograms & ";" & SectionID, Section)
                            tvSection.SelectedImageIndex = 3
                            tvSection.StateImageIndex = 3
                        End If
                    End If
                End If

            Next
        Next
    End Sub

    Private Sub LoadListView(ByVal sKey As String, Optional ByVal sValue As String = "", Optional ByVal sTermID As Integer = 0, Optional ByVal sCampusID As Integer = 0)
        Select Case sKey
            Case keyCampus
                FillListView("SELECT CollegeCode,CollegeID,CollegeName,fnCollegeProgramCount(CollegeID),CollegeDean FROM tblColleges WHERE CampusID='" & sValue & "'", ListView, True, 3)
            Case keyCollege
                FillListView("SELECT ProgCode,ProgID,ProgName,fnMajorName(ProgDiscipline),ProgYears,ProgSems,MaxResidency,fnProgramClassName(ProgStatus) FROM tblPrograms WHERE CollegeID='" & sValue & "'", ListView, True, 3)
            Case keyPrograms
                FillListView("SELECT SectionTitle,SectionID,fnYearLevelByLevelTerm(YearLevelID),fnCurriculumDesc(CurriculumID), fnEmployeeName(AdviserID),IsBlock,0,0,IsDissolved,CreationDate,CreatedBy FROM tblSection WHERE ProgramID='" & sValue & "'", ListView, True, 3)
            Case keySection
                ShowSubjectOffering(sValue, sTermID, sCampusID)
        End Select

    End Sub

    Private Sub ShowSubjectOffering(ByVal SectionID As String, ByVal TermID As Integer, ByVal CampusID As Integer)
        FillListView("SELECT CD.SubjectOfferingID,SUB.SubjectCode,SUB.SubjectID,SUB.Description,SUB.Units,SUB.LecHrs,SUB.LabUnits,SUB.LabHrs,SUB.MinSize,CD.`Limit`,fnEmployeeName(S.AdviserID), " & _
                    "CD.Sched2,fnRoomName2(CD.RoomID2),CD.Sched3,fnRoomName2(CD.RoomID3),CD.Sched4,fnRoomName2(CD.RoomID4),CD.Sched5,fnRoomName2(CD.RoomID5) FROM tblSection AS S " & _
                    "INNER JOIN tblClassSchedule AS CD ON S.SectionID = CD.SectionID INNER JOIN tblsubject AS SUB ON SUB.SubjectID = CD.SubjectID WHERE S.SectionID='" & SectionID & "' AND S.TermID='" & TermID & "' AND S.CampusID='" & CampusID & "'", ListView, True, 4)
    End Sub

    Private Sub SetUpListViewColumns(ByVal Key As String)

        Dim lvColumnHeader As ColumnHeader
        ListView.Columns.Clear()

        'SetView(View.SmallIcon)
        SetView(View.Details)


        Select Case Key
            Case keyCampus

                lvColumnHeader = ListView.Columns.Add("Column0")
                lvColumnHeader.Text = "College Code"
                lvColumnHeader.Width = 100

                lvColumnHeader = ListView.Columns.Add("Column1")
                lvColumnHeader.Text = "College ID"
                lvColumnHeader.Width = 0

                lvColumnHeader = ListView.Columns.Add("Column2")
                lvColumnHeader.Text = "College Name"
                lvColumnHeader.Width = 300

                lvColumnHeader = ListView.Columns.Add("Column3")
                lvColumnHeader.Text = "No. of Programs"
                lvColumnHeader.Width = 100

                lvColumnHeader = ListView.Columns.Add("Column3")
                lvColumnHeader.Text = "College Dean"
                lvColumnHeader.Width = 300

            Case keyCollege

                lvColumnHeader = ListView.Columns.Add("Column0")
                lvColumnHeader.Text = "Program Code"
                lvColumnHeader.Width = 100

                lvColumnHeader = ListView.Columns.Add("Column1")
                lvColumnHeader.Text = "Program ID"
                lvColumnHeader.Width = 0

                lvColumnHeader = ListView.Columns.Add("Column2")
                lvColumnHeader.Text = "Program Name"
                lvColumnHeader.Width = 300

                lvColumnHeader = ListView.Columns.Add("Column3")
                lvColumnHeader.Text = "Major Study"
                lvColumnHeader.Width = 300

                lvColumnHeader = ListView.Columns.Add("Column4")
                lvColumnHeader.Text = "Years"
                lvColumnHeader.Width = 70

                lvColumnHeader = ListView.Columns.Add("Column5")
                lvColumnHeader.Text = "Semester"
                lvColumnHeader.Width = 70

                lvColumnHeader = ListView.Columns.Add("Column6")
                lvColumnHeader.Text = "Max. Residency"
                lvColumnHeader.Width = 100

                lvColumnHeader = ListView.Columns.Add("Column7")
                lvColumnHeader.Text = "Program Classification"
                lvColumnHeader.Width = 300

            Case keyPrograms

                lvColumnHeader = ListView.Columns.Add("Column0")
                lvColumnHeader.Text = "Class Section"
                lvColumnHeader.Width = 100

                lvColumnHeader = ListView.Columns.Add("Column1")
                lvColumnHeader.Text = "Section ID"
                lvColumnHeader.Width = 0

                lvColumnHeader = ListView.Columns.Add("Column2")
                lvColumnHeader.Text = "Year Level"
                lvColumnHeader.Width = 100

                lvColumnHeader = ListView.Columns.Add("Column3")
                lvColumnHeader.Text = "Curriculum Code"
                lvColumnHeader.Width = 200

                lvColumnHeader = ListView.Columns.Add("Column4")
                lvColumnHeader.Text = "Class Adviser"
                lvColumnHeader.Width = 300

                lvColumnHeader = ListView.Columns.Add("Column5")
                lvColumnHeader.Text = "Block"
                lvColumnHeader.Width = 0

                lvColumnHeader = ListView.Columns.Add("Column6")
                lvColumnHeader.Text = "Registered"
                lvColumnHeader.Width = 70

                lvColumnHeader = ListView.Columns.Add("Column7")
                lvColumnHeader.Text = "Validated"
                lvColumnHeader.Width = 70

                lvColumnHeader = ListView.Columns.Add("Column8")
                lvColumnHeader.Text = "Dissolved"
                lvColumnHeader.Width = 70

                lvColumnHeader = ListView.Columns.Add("Column9")
                lvColumnHeader.Text = "Date Created"
                lvColumnHeader.Width = 100

                lvColumnHeader = ListView.Columns.Add("Column10")
                lvColumnHeader.Text = "Created By"
                lvColumnHeader.Width = 100

                lvColumnHeader = ListView.Columns.Add("Column11")
                lvColumnHeader.Text = "ProgID"
                lvColumnHeader.Width = 0


            Case keySection

                lvColumnHeader = ListView.Columns.Add("Column0")
                lvColumnHeader.Text = "Offering ID"
                lvColumnHeader.Width = 200

                lvColumnHeader = ListView.Columns.Add("Column1")
                lvColumnHeader.Text = "Subject Code"
                lvColumnHeader.Width = 150


                lvColumnHeader = ListView.Columns.Add("Column1s")
                lvColumnHeader.Text = "Subject ID"
                lvColumnHeader.Width = 0

                lvColumnHeader = ListView.Columns.Add("Column2")
                lvColumnHeader.Text = "Descriptive Title"
                lvColumnHeader.Width = 400

                lvColumnHeader = ListView.Columns.Add("Column3")
                lvColumnHeader.Text = "Units"
                lvColumnHeader.Width = 100

                lvColumnHeader = ListView.Columns.Add("Column4")
                lvColumnHeader.Text = "Lect. Hrs"
                lvColumnHeader.Width = 100

                lvColumnHeader = ListView.Columns.Add("Column5")
                lvColumnHeader.Text = "Lab. Units"
                lvColumnHeader.Width = 100

                lvColumnHeader = ListView.Columns.Add("Column6")
                lvColumnHeader.Text = "Lab. Hrs"
                lvColumnHeader.Width = 100

                lvColumnHeader = ListView.Columns.Add("Column7")
                lvColumnHeader.Text = "Min. Size"
                lvColumnHeader.Width = 100

                lvColumnHeader = ListView.Columns.Add("Column8")
                lvColumnHeader.Text = "Limit"
                lvColumnHeader.Width = 100

                lvColumnHeader = ListView.Columns.Add("Column9")
                lvColumnHeader.Text = "Faculty"
                lvColumnHeader.Width = 400

                lvColumnHeader = ListView.Columns.Add("Column10")
                lvColumnHeader.Text = "Registered"
                lvColumnHeader.Width = 150

                lvColumnHeader = ListView.Columns.Add("Column11")
                lvColumnHeader.Text = "Validated"
                lvColumnHeader.Width = 100

                lvColumnHeader = ListView.Columns.Add("Column12")
                lvColumnHeader.Text = "Dropped"
                lvColumnHeader.Width = 100

                lvColumnHeader = ListView.Columns.Add("Column13")
                lvColumnHeader.Text = "Dissolved"
                lvColumnHeader.Width = 100

        End Select

    End Sub

    Private Sub SetView(ByVal View As System.Windows.Forms.View)
        'Figure out which menu item should be checked
        Dim MenuItemToCheck As ToolStripMenuItem = Nothing
        Select Case View
            Case View.Details
                MenuItemToCheck = DetailsToolStripMenuItem
            Case View.LargeIcon
                MenuItemToCheck = LargeIconsToolStripMenuItem
            Case View.List
                MenuItemToCheck = ListToolStripMenuItem
            Case View.SmallIcon
                MenuItemToCheck = SmallIconsToolStripMenuItem
            Case View.Tile
                MenuItemToCheck = TileToolStripMenuItem
            Case Else
                Debug.Fail("Unexpected View")
                View = View.Details
                MenuItemToCheck = DetailsToolStripMenuItem
        End Select

        'Check the appropriate menu item and deselect all others under the Views menu
        For Each MenuItem As ToolStripMenuItem In ListViewToolStripButton.DropDownItems
            If MenuItem Is MenuItemToCheck Then
                MenuItem.Checked = True
            Else
                MenuItem.Checked = False
            End If
        Next

        'Finally, set the view requested
        ListView.View = View
    End Sub

    Private Sub ListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListToolStripMenuItem.Click
        SetView(View.List)
    End Sub

    Private Sub DetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetailsToolStripMenuItem.Click
        SetView(View.Details)
    End Sub

    Private Sub LargeIconsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LargeIconsToolStripMenuItem.Click
        SetView(View.LargeIcon)
    End Sub

    Private Sub SmallIconsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SmallIconsToolStripMenuItem.Click
        SetView(View.SmallIcon)
    End Sub

    Private Sub TileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TileToolStripMenuItem.Click
        SetView(View.Tile)
    End Sub

    Private Sub TreeView_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView.AfterSelect
        Dim splitKey() As String = Split(e.Node.Name, ";")

        Select Case splitKey(0)
            Case keyPrograms
                SetUpListViewColumns(keyPrograms)
                LoadListView(keyPrograms, splitKey(1))
                ListView.ContextMenuStrip = popClassSection
                cmdPrintSection.Visible = True
                cmdPrintOffering.Visible = False
                xProgramID = splitKey(1)
                SecState = SectionState.Program
            Case keySection
                xSectionID = splitKey(2)
                SetUpListViewColumns(keySection)
                LoadListView(keySection, splitKey(2), cboAYID.Text, cboCampus.SelectedItem.Col2)
                ListView.ContextMenuStrip = popOffering
                cmdPrintSection.Visible = False
                cmdPrintOffering.Visible = True
                SecState = SectionState.Section
        End Select

    End Sub

    Private Sub AddNewBlockSectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewBlockSectionToolStripMenuItem.Click
        Dim frm As New frmAddSection()
        frm.ShowForm()
    End Sub

    Private Sub AddNewFreeSectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewFreeSectionToolStripMenuItem.Click
        Dim frm As New frmAddFreeSections()
        frm.ShowForm(xCampusID, xCollegeID, cboAYID.Text, xProgramID)
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        Select Case SecState
            Case SectionState.Program
                SetUpListViewColumns(keyPrograms)
                LoadListView(keyPrograms, xProgramID)
                ListView.ContextMenuStrip = popClassSection
                cmdPrintSection.Visible = True
                cmdPrintOffering.Visible = False
                SecState = SectionState.Program
        End Select
    End Sub

    Private Sub DeleteClassSectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteClassSectionToolStripMenuItem.Click
        If ListView.Items.Count > 0 Then
            ExecuteDeleteSection(ListView.FocusedItem.SubItems(1).Text)
        End If

    End Sub

    Private Sub cboAY_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAY.SelectedIndexChanged
        cboAYID.SelectedIndex = cboAY.SelectedIndex
    End Sub

    Private Sub ListView_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView.SelectedIndexChanged

    End Sub

    Private Sub cboAYID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAYID.SelectedIndexChanged
        On Error Resume Next
        LoadTree(cboAYID.Text, cboCollege.SelectedItem.Col3)
    End Sub

    Private Sub RefreshToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem1.Click
        LoadTree(cboAYID.Text, cboCollege.SelectedItem.Col3)
    End Sub

    Private Sub cboCampus_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboCampus.SelectedIndexChanged
        fillMultiColumnCombo3(cboCollege, "SELECT CollegeCode,CollegeName, CollegeID FROM tblColleges WHERE CampusID= '" & cboCampus.SelectedItem.Col2 & "'")
    End Sub

    Private Sub cboCollege_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboCollege.SelectedIndexChanged
        LoadTree(cboAYID.Text, cboCollege.SelectedItem.Col3)
    End Sub


    Private Sub ListView_DoubleClick(sender As System.Object, e As System.EventArgs) Handles ListView.DoubleClick
        Select Case SecState
            Case SectionState.Program
                SetUpListViewColumns(keySection)
                LoadListView(keySection, ListView.FocusedItem.SubItems(1).Text, cboAYID.Text, cboCampus.SelectedItem.Col2)
                ListView.ContextMenuStrip = popOffering
                cmdPrintSection.Visible = False
                cmdPrintOffering.Visible = True
            Case SectionState.Section
               
        End Select
    End Sub

    Private Sub RenameClassSectionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RenameClassSectionToolStripMenuItem.Click
        If ListView.Items.Count > 0 Then
            Dim frm As New frmRenameSection
            frm.ShowForm(ListView.FocusedItem.Text, ListView.FocusedItem.SubItems(1).Text)
        End If
    End Sub

    Private Sub ClassSectionScheduleToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClassSectionScheduleToolStripMenuItem.Click
        If ListView.Items.Count > 0 Then
            Dim frm As New frmViewClassSched
            frm.ShowForm(ListView.FocusedItem.Text, ListView.FocusedItem.SubItems(1).Text, cboCampus.SelectedItem.Col2, cboAYID.Text)
        End If
    End Sub

    Private Sub DissolveClassSectionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DissolveClassSectionToolStripMenuItem.Click
        If ListView.Items.Count > 0 Then

            If CheckEnrolledStudentBySection(ListView.FocusedItem.SubItems(1).Text, cboAYID.Text, cboCampus.SelectedItem.Col2) = True Then
                MsgBox("Unable to Dissolve this Class Section. There are still have regular student/s taken the Course under this Class Section.", vbExclamation)
                Exit Sub
            End If

            If MsgBox("Are you sure you want to dissolved this section...?" & vbNewLine & vbNewLine & _
                       "SECTION: " & ListView.FocusedItem.Text, vbExclamation + vbYesNo) = vbYes Then
                If DissolvedSection(ListView.FocusedItem.SubItems(1).Text) = TranDBResult.Success Then
                    Select Case SecState
                        Case SectionState.Program
                            SetUpListViewColumns(keySection)
                            LoadListView(keySection, ListView.FocusedItem.SubItems(1).Text, cboAYID.Text, cboCampus.SelectedItem.Col2)
                            ListView.ContextMenuStrip = popOffering
                            cmdPrintSection.Visible = False
                            cmdPrintOffering.Visible = True
                    End Select
                End If
            End If
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles RefreshToolStripMenuItem2.Click
        Select Case SecState
            Case SectionState.Section
                SetUpListViewColumns(keySection)
                LoadListView(keySection, ListView.FocusedItem.SubItems(1).Text, cboAYID.Text, cboCampus.SelectedItem.Col2)
                ListView.ContextMenuStrip = popOffering
                cmdPrintSection.Visible = False
                cmdPrintOffering.Visible = True
        End Select
    End Sub

    Private Sub TreeView_NodeMouseClick(sender As System.Object, e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles TreeView.NodeMouseClick
        Dim splitKey() As String = Split(e.Node.Name, ";")

        Select Case splitKey(0)
            Case keyPrograms
                SetUpListViewColumns(keyPrograms)
                LoadListView(keyPrograms, splitKey(1))
                ListView.ContextMenuStrip = popClassSection
                cmdPrintSection.Visible = True
                cmdPrintOffering.Visible = False
                xProgramID = splitKey(1)
                SecState = SectionState.Program
            Case keySection
                xSectionID = splitKey(2)
                SetUpListViewColumns(keySection)
                LoadListView(keySection, splitKey(2), cboAYID.Text, cboCampus.SelectedItem.Col2)
                ListView.ContextMenuStrip = popOffering
                cmdPrintSection.Visible = False
                cmdPrintOffering.Visible = True
                SecState = SectionState.Section
        End Select
    End Sub

    Private Sub ModifyClassLimitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ModifyClassLimitToolStripMenuItem.Click
        Dim frm As New frmModClassLimit
        frm.ShowForm(xSectionID, ListView.FocusedItem.Text, ListView.FocusedItem.SubItems(9).Text)
    End Sub

    Private Sub AddNewSubjectOfferingToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AddNewSubjectOfferingToolStripMenuItem.Click
        Dim frm As New frmAddSubjectSection()
        frm.ShowForm(xSectionID, cboAYID.Text)
    End Sub

    Private Sub DeleteSubjectToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DeleteSubjectToolStripMenuItem.Click
        If ListView.Items.Count > 0 Then

            If CheckEnrolledSubjectOffering(ListView.FocusedItem.Text) > 0 Then
                MsgBox("Sorry, you are no longer allowed to delete [" & ListView.FocusedItem.SubItems(3).Text & "] in this Section.", vbExclamation)
                Exit Sub
            End If

            If MsgBox("Are you sure want to delete " & ListView.FocusedItem.SubItems(3).Text & "?", vbExclamation + vbYesNo) = vbYes Then
                Dim com As New MySqlCommand("DELETE FROM tblClassSchedule WHERE SubjectOfferingID='" & ListView.FocusedItem.Text & "'", con)
                com.ExecuteNonQuery()

                SetUpListViewColumns(keySection)
                LoadListView(keySection, xSectionID, cboAYID.Text, cboCampus.SelectedItem.Col2)
                ListView.ContextMenuStrip = popOffering
                cmdPrintSection.Visible = False
                cmdPrintOffering.Visible = True
                SecState = SectionState.Section

            End If
        End If
    End Sub

    Private Sub ReplaceSubjectOfferingToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ReplaceSubjectOfferingToolStripMenuItem.Click
        Dim frm As New frmReplaceSubject
        frm.ShowForm()
    End Sub
End Class
