Option Explicit On

Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports System.Diagnostics

Imports C1.Win.C1FlexGrid



Public Class frmProgramsMajors
    Inherits Form

    Dim curTeacher As tTeacher
    Dim ReadyToRefresh As Boolean
    Dim curDepartment As tDepartment

    Public Sub New()
        InitializeComponent()
    End Sub


    Private Sub frmManageSubject_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsTables.tblsubject' table. You can move, or remove it, as needed.

        fillToolStripCombo(cboCampus, "SELECT ShortName FROM tblCampus")
        fillToolStripCombo(cboCampusID, "SELECT CampusID FROM tblCampus")

        FillListView("SELECT MajorGroupCode,Description,ID FROM tblDisciplineMajorGroups ORDER BY ID", lvMajorGroups, True, 0)

        FillVSFlexGrid()

        FillMajorDiscipline()

    End Sub

#Region "FillVSFlexGrid"
    Private Sub FillVSFlexGrid()
        With fgMajor
            .AllowMerging = AllowMergingEnum.Free
            .Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter

            fgMajor(0, 0) = "Major Group"
            fgMajor(0, 1) = "Major Code"
            fgMajor(0, 2) = "Major Discipline"

            fgMajor.Cols(0).Width = 350
            fgMajor.Cols(1).Width = 150
            fgMajor.Cols(2).Width = 1000
        End With
    End Sub
#End Region

#Region "FillMajorDiscipline"
    Public Sub FillMajorDiscipline()
        Dim a As Integer
        Dim row As Integer = 1

        Dim com As New MySqlCommand("SELECT tbldisciplinemajorgroups.Description AS `MAJOR GROUP`, tbldisciplinemajors.MajorDiscCode AS `MAJOR CODE`, tbldisciplinemajors.MajorDescription AS `MAJOR DISCIPLINE`, tbldisciplinemajors.ID " & _
                                    "FROM tbldisciplinemajorgroups INNER JOIN tbldisciplinemajors ON tbldisciplinemajorgroups.ID = tbldisciplinemajors.MajorGroup ORDER BY tblDisciplineMajors.MajorGroup", clsCon.con)
        'Dim vRS As MySqlDataReader = com.ExecuteReader()
        Dim ds As New DataSet()
        Dim dA As New MySqlDataAdapter()
        Dim BS As New BindingSource
        dA.SelectCommand = com
        dA.Fill(ds)
        BS.DataSource = ds.Tables(0).DefaultView
        'FillVSFlexGrid()

        fgMajor.DataSource = BS

        fgMajor.AllowMerging = AllowMergingEnum.Free
        fgMajor.Cols(0).AllowMerging = True
        fgMajor.Cols(0).AllowDragging = False
        fgMajor.Cols(0).AllowEditing = False
        fgMajor.Cols(0).AllowResizing = False
        fgMajor.Cols(0).TextAlign = TextAlignEnum.CenterCenter
        fgMajor.Cols(0).Width = 350

        fgMajor.Cols(1).Width = 150
        fgMajor.Cols(1).AllowDragging = False
        fgMajor.Cols(1).AllowEditing = False
        fgMajor.Cols(1).AllowResizing = False

        fgMajor.Cols(2).Width = 700
        fgMajor.Cols(2).AllowDragging = False
        fgMajor.Cols(2).AllowEditing = False
        fgMajor.Cols(2).AllowResizing = False

        fgMajor.Cols(3).Width = 0
        fgMajor.Cols(3).AllowDragging = False
        fgMajor.Cols(3).AllowEditing = False
        fgMajor.Cols(3).AllowResizing = False


        'While vRS.Read()
        '    With fgMajor
        '        .Rows.Add()
        '        .AllowMerging = AllowMergingEnum.Free

        '        .Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter

        '        .Cols(0).AllowMerging = True
        '        .Styles.Fixed.WordWrap = True

        '        fgMajor(.Row - 1, 0) = vRS("Description").ToString()
        '        fgMajor(.Row - 1, 1) = vRS("MajorDiscCode").ToString()
        '        fgMajor(.Row - 1, 2) = vRS("MajorDescription").ToString()

        '        .Row = .Row + 1
        '    End With
        'End While
        
        'vRS.Close()

    End Sub
#End Region


    Private Sub cmdRefreshMajor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefreshMajor.Click
        FillListView("SELECT MajorGroupCode,Description,ID FROM tblDisciplineMajorGroups ORDER BY ID", lvMajorGroups, True, 0)
    End Sub

    Private Sub cmdNewMajorGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNewMajorGroup.Click
        Dim frm As New frmMajorGroupAE()
        frm.ShowForm()
    End Sub



    Private Sub cmdRefreshMajorDisc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefreshMajorDisc.Click
        FillMajorDiscipline()
    End Sub

    Private Sub cmdNewProgram_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNewProgram.Click
        Dim frm As New frmAcadProgramAE()
        frm.ShowForm()
    End Sub

    Private Sub cmdNewMajor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNewMajor.Click, NewToolStripButton.Click
        Dim frm As New frmMajorDisciplineAE()
        frm.ShowForm()
    End Sub

    Private Sub cboCollege_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCollege.SelectedIndexChanged
        cboCollegeID.SelectedIndex = cboCollege.SelectedIndex
    End Sub

    Private Sub cboCampus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCampus.SelectedIndexChanged
        cboCampusID.SelectedIndex = cboCampus.SelectedIndex
    End Sub
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        FillMajorDiscipline()
    End Sub

    Private Sub cmdNewCollege_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New frmCollegeAE()
        frm.ShowForm()
    End Sub

    Private Sub NewDepartmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewDepartmentToolStripMenuItem.Click
        Dim frm As New frmAddDepartment()
        frm.ShowForm()
    End Sub

    Private Sub cmdRefreshCollege_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cboCampusID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCampusID.SelectedIndexChanged
        fillToolStripCombo(cboCollegeID, "SELECT tblColleges.CollegeID " & _
                           "FROM tblColleges INNER JOIN tblCampus ON tblColleges.CampusID=tblCampus.CampusID WHERE tblCampus.CampusID='" & cboCampusID.Text & "'")

        fillToolStripCombo(cboCollege, "SELECT tblColleges.CollegeName " & _
                           "FROM tblColleges INNER JOIN tblCampus ON tblColleges.CampusID=tblCampus.CampusID WHERE tblCampus.CampusID='" & cboCampusID.Text & "'")
    End Sub

    Private Sub cboCollegeID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCollegeID.SelectedIndexChanged
        FillListView("SELECT ProgCode,ProgID,ProgName FROM tblPrograms WHERE CollegeID='" & cboCollegeID.Text & "' AND CampusID='" & cboCampusID.Text & "'", lvPrograms, True, 5)
    End Sub

    Private Sub frmProgramsMajors_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        'ControlBox = False
    End Sub

    Private Sub cmdRefreshProgram_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefreshProgram.Click
        FillListView("SELECT ProgCode,ProgID,ProgName FROM tblPrograms WHERE CollegeID='" & cboCollegeID.Text & "' AND CampusID='" & cboCampusID.Text & "'", lvPrograms, True, 5)
    End Sub

    Private Sub lvPrograms_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvPrograms.SelectedIndexChanged
        If lvPrograms.Items.Count > 0 Then
            TabMajorGroup.Text = "MAJOR DISCIPLINE CATEGORY: " & GetMajorDisciplinceGroup(lvPrograms.FocusedItem.SubItems(1).Text)
            GetProgramMajors(lvPrograms.FocusedItem.SubItems(1).Text)
        End If
    End Sub

#Region "GetProgramMajors"
    Private Sub GetProgramMajors(ByVal ProgID As String)
        Dim com As New MySqlCommand("SELECT fnMajorCode(MajorDiscID),MajorDiscID,fnMajorName(MajorDiscID) FROM tblProgramMajors WHERE ProgID='" & ProgID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        lvMajors.Items.Clear()
        While vRS.Read
            Dim lv As New ListViewItem(vRS(0).ToString)
            lv.SubItems.Add(vRS(1).ToString())
            lv.SubItems.Add(vRS(2).ToString())
            lvMajors.Items.AddRange(New ListViewItem() {lv})
        End While
        vRS.Close()
    End Sub
#End Region

#Region "GetMajorDisciplinceGroup"
    Private Function GetMajorDisciplinceGroup(ByVal ProgID As String) As String
        Dim com As New MySqlCommand("SELECT Description FROM tblDisciplineMajorGroups WHERE ID IN (SELECT MajorDiscGroupCode FROM tblPrograms WHERE ProgID='" & ProgID & "')", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows = True Then
            GetMajorDisciplinceGroup = vRS(0).ToString()
        Else
            GetMajorDisciplinceGroup = ""
        End If
        vRS.Close()
    End Function
#End Region

    Private Sub cmdEditMajorGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditMajorGroup.Click
        If lvMajorGroups.Items.Count > 0 Then
            Dim frm As New frmMajorGroupAE()
            frm.ShowEdit(lvMajorGroups.FocusedItem.Text)
        End If
    End Sub


    Private Sub cmdShowAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdShowAll.Click
        If cboCampus.Text = "" Then MsgBox("Unable to load record..." & vbNewLine & "Please select campus", vbExclamation) : Exit Sub

        FillListView("SELECT ProgCode,ProgID,ProgName FROM tblPrograms WHERE CampusID='" & cboCampusID.Text & "'", lvPrograms, True, 5)
    End Sub

    Private Sub cmdEditProgram_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditProgram.Click
        If lvPrograms.Items.Count > 0 Then
            Dim frm As New frmAcadProgramAE()
            frm.ShowEdit(lvPrograms.FocusedItem.SubItems(1).Text)
        End If
    End Sub

    Private Sub cmdDeleteProgram_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDeleteProgram.Click

    End Sub

    Private Sub PrintAllAcademicProgramsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintAllAcademicProgramsToolStripMenuItem.Click
        Dim frm As New frmPrintPreview()
        'frm.rptAcademiProgramByCampus(cboCampusID.Text, CurrentUser.UserID)
    End Sub

    Private Sub cmdEditMajor_Click(sender As System.Object, e As System.EventArgs) Handles cmdEditMajor.Click
        Dim frm As New frmMajorDisciplineAE
        frm.ShowEdit(fgMajor.GetDataDisplay(fgMajor.RowSel, 3))
    End Sub


    Private Sub fgMajor_Click(sender As System.Object, e As System.EventArgs) Handles fgMajor.Click
        If fgMajor.Rows.Count > 0 Then
            Debug.Print("Major Code: " & fgMajor.GetDataDisplay(fgMajor.RowSel, 1) & "ID: " & fgMajor.GetDataDisplay(fgMajor.RowSel, 3))
        End If
    End Sub

    Private Sub cmdDeleteMajor_Click(sender As System.Object, e As System.EventArgs) Handles cmdDeleteMajor.Click, ToolStripButton2.Click
        On Error GoTo err
        If lvMajorGroups.Items.Count > 0 Then
            If Len(lvMajorGroups.FocusedItem.SubItems(2).Text) > 0 Then

                Dim com As New MySqlCommand("DELETE FROM tbldisciplinemajorsgroups WHERE ID='" & lvMajorGroups.FocusedItem.SubItems(2).Text & "'", con)
                com.ExecuteNonQuery()

                FillListView("SELECT MajorGroupCode,Description,ID FROM tblDisciplineMajorGroups ORDER BY ID", lvMajorGroups, True, 0)

            End If
        End If

        Exit Sub
err:
        DisplayErrorMsg("frmProgramMajors", "cmdDeleteMajor_Click", Err.Number, Err.Description)
    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub cmdDeleteMajorDisc_Click(sender As System.Object, e As System.EventArgs) Handles cmdDeleteMajorDisc.Click
        On Error GoTo err

        If fgMajor.Rows.Count > 0 Then
            If Len(fgMajor.GetDataDisplay(fgMajor.RowSel, 3)) > 0 Then

                Dim com As New MySqlCommand("DELETE FROM tbldisciplinemajors WHERE ID='" & fgMajor.GetDataDisplay(fgMajor.RowSel, 3) & "'", con)
                com.ExecuteNonQuery()

                FillMajorDiscipline()

            End If
        End If


        Exit Sub
err:
        DisplayErrorMsg("frmProgramMajors", "cmdDeleteMajorDesc_Click", Err.Number, Err.Description)
    End Sub

    Private Sub fgMajor_DoubleClick(sender As System.Object, e As System.EventArgs) Handles fgMajor.DoubleClick
        On Error GoTo err
        If Len(fgMajor.GetDataDisplay(fgMajor.RowSel, 3) > 0) Then
            Dim frm As New frmMajorDisciplineAE
            frm.ShowEdit(fgMajor.GetDataDisplay(fgMajor.RowSel, 3))
        End If
        Exit Sub
err:
        DisplayErrorMsg("frmProgramsMajors", "fgMajor_DoubleClick", Err.Number, Err.Description)
    End Sub

    Private Sub lvMajorGroups_DoubleClick(sender As System.Object, e As System.EventArgs) Handles lvMajorGroups.DoubleClick
        cmdEditMajorGroup_Click(sender, e)
    End Sub

    Private Sub cmdBrowse_Click(sender As System.Object, e As System.EventArgs) Handles cmdBrowse.Click

    End Sub

    Public Sub FillMajorDiscipline()
        Dim a As Integer
        Dim row As Integer = 1

        Dim com As New MySqlCommand("SELECT tbldisciplinemajorgroups.Description AS `MAJOR GROUP`, tbldisciplinemajors.MajorDiscCode AS `MAJOR CODE`, tbldisciplinemajors.MajorDescription AS `MAJOR DISCIPLINE`, tbldisciplinemajors.ID " & _
                                    "FROM tbldisciplinemajorgroups INNER JOIN tbldisciplinemajors ON tbldisciplinemajorgroups.ID = tbldisciplinemajors.MajorGroup ORDER BY tblDisciplineMajors.MajorGroup", clsCon.con)
        'Dim vRS As MySqlDataReader = com.ExecuteReader()
        Dim ds As New DataSet()
        Dim dA As New MySqlDataAdapter()
        Dim BS As New BindingSource
        dA.SelectCommand = com
        dA.Fill(ds)
        BS.DataSource = ds.Tables(0).DefaultView
        'FillVSFlexGrid()

        fgMajor.DataSource = BS

        fgMajor.AllowMerging = AllowMergingEnum.Free
        fgMajor.Cols(0).AllowMerging = True
        fgMajor.Cols(0).AllowDragging = False
        fgMajor.Cols(0).AllowEditing = False
        fgMajor.Cols(0).AllowResizing = False
        fgMajor.Cols(0).TextAlign = TextAlignEnum.CenterCenter
        fgMajor.Cols(0).Width = 350

        fgMajor.Cols(1).Width = 150
        fgMajor.Cols(1).AllowDragging = False
        fgMajor.Cols(1).AllowEditing = False
        fgMajor.Cols(1).AllowResizing = False

        fgMajor.Cols(2).Width = 700
        fgMajor.Cols(2).AllowDragging = False
        fgMajor.Cols(2).AllowEditing = False
        fgMajor.Cols(2).AllowResizing = False

        fgMajor.Cols(3).Width = 0
        fgMajor.Cols(3).AllowDragging = False
        fgMajor.Cols(3).AllowEditing = False
        fgMajor.Cols(3).AllowResizing = False

    End Sub
End Class
