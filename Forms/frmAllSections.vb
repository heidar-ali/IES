Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Imports MySql.Data.MySqlClient

Public Class frmAllSections
    Inherits Form

    Dim sSQL As String = "SELECT Acronym,CampusID" & _
                   " FROM tblCampus;"

    Dim sSQL1 As String = "SELECT CollegeName,CollegeID" & _
                " FROM tblColleges, tblCampus WHERE tblColleges.CampusID = tblCampus.CampusID;"

    Dim sSQL2 As String = "SELECT ProgName,ProgID" & _
                " FROM tblPrograms, tblColleges WHERE tblColleges.CollegeID = tblPrograms.CollegeID;"

    'Dim sSQL3 As String = "SELECT tblSection.SectionTitle, tblSectionOffering.SchoolYear, tblDepartment.DepartmentTitle, tblYearLevel.YearLevelTitle,tblSectionOffering.SectionOfferingID" & _
    '      " FROM tblYearLevel INNER JOIN ((tblDepartment INNER JOIN tblSection ON tblDepartment.DepartmentID = tblSection.DepartmentID) INNER JOIN tblSectionOffering ON tblSection.SectionID = tblSectionOffering.SectionID) ON tblYearLevel.YearLevelID = tblSection.YearLevelID" & _
    '     " GROUP BY tblSectionOffering.SectionOfferingID, tblSectionOffering.SchoolYear, tblDepartment.DepartmentTitle, tblYearLevel.YearLevelTitle, tblSection.SectionTitle;"


    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmAllSections_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillToolStripCombo(cboAY, "SELECT CONCAT(SchoolYear,' ',SchoolTerm) as SchoolYear FROM tblAYTerm ORDER BY SchoolYear")
        fillToolStripCombo(cboAYID, "SELECT TermID FROM tblAYTerm ORDER BY SchoolYear")
        fillToolStripCombo(cboCampus, "SELECT ShortName FROM tblCampus")
        fillToolStripCombo(cboCampusID, "SELECT CampusID FROM tblCampus")

        'LoadClassSections()
        'ComboBox1.Text = CurrentSchoolYear.SchoolYearTitle
    End Sub

    Private Sub LoadClassSections()
        'Dim tvRoot As TreeNode
        'Dim tvNode As TreeNode
        'Dim tvNode1 As TreeNode
        'Dim tvNode2 As TreeNode

        'Dim daSchoolYear As New MySqlDataAdapter
        'Dim daYearLevel As New MySqlDataAdapter
        'Dim daDepartment As New MySqlDataAdapter
        'Dim daSection As New MySqlDataAdapter

        'Dim dsgeneral As New DataSet()
        'Dim dsgeneral1 As New DataSet()
        'Dim dsgeneral2 As New DataSet()
        'Dim dsgeneral3 As New DataSet()

        'Dim slCampusTitle$, slCollegeTitle$, slProgramTitle$, slSectionTitle$
        'Dim slCampusTitleID$, slCollegeTitleID$, slProgramTitleID$, slSectionTitleID$

        'Dim i As Integer
        'Dim ii As Integer
        'Dim iii As Integer
        'Dim iv As Integer


        'TreeView.Nodes.Clear()

        'Dim com As New MySqlCommand(sSQL, clsCon.con)
        'daSchoolYear.SelectCommand = com
        'daSchoolYear.Fill(dsgeneral, "tblSchoolYear")


        'Dim com1 As New MySqlCommand(sSQL1, clsCon.con)
        'daDepartment.SelectCommand = com1
        'daDepartment.Fill(dsgeneral1, "tblDepartment")


        'Dim com2 As New MySqlCommand(sSQL2, clsCon.con)
        'daYearLevel.SelectCommand = com2
        'daYearLevel.Fill(dsgeneral2, "tblPrograms")


        ''Dim com3 As New MySqlCommand(sSQL3, clsCon.con)
        ''daSection.SelectCommand = com3
        ''daSection.Fill(dsgeneral3, "tblSection")


        'For i = 0 To dsgeneral.Tables("tblSchoolYear").Rows.Count - 1
        '    slSchoolYearTitle = dsgeneral.Tables("tblSchoolYear").Rows(i).Item("SchoolYear").ToString()

        '    tvRoot = TreeView.Nodes.Add(keySchoolYear & ";" & slSchoolYearTitle, slSchoolYearTitle)


        '    For ii = 0 To dsgeneral1.Tables("tblDepartment").Rows.Count - 1
        '        'slDepartmentTitle = dsgeneral1.Tables("tblDepartment").Rows(ii).Item("DepartmentTitle").ToString()

        '        'tvNode = tvRoot.Nodes.Add(keyDepartment & ";" & slSchoolYearTitle & ";" & slDepartmentTitle, slDepartmentTitle)


        '        For iii = 0 To dsgeneral2.Tables("tblYearLevel").Rows.Count - 1
        '            slYearLevelTitle = dsgeneral2.Tables("tblYearLevel").Rows(iii).Item("YearLevelTitle").ToString()

        '            tvNode1 = tvNode.Nodes.Add(KeyYearLevel & ";" & slSchoolYearTitle & ";" & slDepartmentTitle & ";" & slYearLevelTitle, slYearLevelTitle)


        '            For iv = 0 To dsgeneral3.Tables("tblSection").Rows.Count - 1
        '                slYearLevelTitleID = dsgeneral3.Tables("tblSection").Rows(iv).Item("YearLevelTitle").ToString()
        '                slDepartmentTitleID = dsgeneral3.Tables("tblSection").Rows(iv).Item("DepartmentTitle").ToString()
        '                slSchoolYearTitleID = dsgeneral3.Tables("tblSection").Rows(iv).Item("SchoolYear").ToString()

        '                If slSchoolYearTitle = slSchoolYearTitleID Then
        '                    If slDepartmentTitle = slDepartmentTitleID Then
        '                        If slYearLevelTitle = slYearLevelTitleID Then
        '                            slSectionOfferingTitle = dsgeneral3.Tables("tblSection").Rows(iv).Item("SectionTitle").ToString()
        '                            sSectionTitleID = dsgeneral3.Tables("tblSection").Rows(iv).Item("SectionOfferingID").ToString()

        '                            tvNode2 = tvNode1.Nodes.Add(KeySectionOffering & ";" & slSchoolYearTitle & ";" & slDepartmentTitle & ";" & slYearLevelTitle & ";" & sSectionTitleID, slSectionOfferingTitle)
        '                        End If
        '                    End If
        '                End If

        '            Next

        '        Next

        '    Next
        'Next

    End Sub

    Public Sub ShowForm(ByVal sSQL As String)
        Dim c As Integer

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()

        lvSection.Items.Clear()
        Do While vRS.Read()
            Dim lv As New ListViewItem(vRS(0).ToString())

            For c = 1 To vRS.FieldCount - 1
                lv.SubItems.Add(vRS.Item(c).ToString)

                lv.ToolTipText = vRS(0).ToString() & " " & vbNewLine & " " & vRS.Item(c).ToString
            Next
            lv.ImageIndex = 0
            lvSection.Items.AddRange(New ListViewItem() {lv})
        Loop
        vRS.Close()
    End Sub


 
    Private Sub TreeView_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs)
        Dim splitKey() As String
        splitKey = Split(e.Node.Name, ";")

        Select Case splitKey(0)
            Case keySchoolYear

            Case keyDepartment

            Case KeyYearLevel
                'TreeView.ContextMenuStrip = Me.ContextMenuStrip4
            Case (KeySectionOffering)

        End Select
    End Sub
    Private Sub AddNewBlockSectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewBlockSectionToolStripMenuItem.Click
        'Dim frm As New frmAddSection()
        'frm.ShowForm()
    End Sub

    Private Sub EditSectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditSectionToolStripMenuItem.Click
        If lvSection.Items.Count > 0 Then

        End If
    End Sub

    Private Sub LoadSectionWithSubjectsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadSectionWithSubjectsToolStripMenuItem.Click
        If lvSection.Items.Count > 0 Then

        End If
    End Sub

    Private Sub lvSection_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvSection.SelectedIndexChanged

    End Sub

    Private Sub cboAY_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboAY.SelectedIndexChanged
        cboAYID.SelectedIndex = cboAY.SelectedIndex
    End Sub

    Private Sub cboCampus_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboCampus.SelectedIndexChanged
        cboCampusID.SelectedIndex = cboCampus.SelectedIndex
    End Sub

    Private Sub AddNewFreeSectionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AddNewFreeSectionToolStripMenuItem.Click
        Dim frm As New frmAddFreeSections()
        frm.ShowForm()
    End Sub
End Class
