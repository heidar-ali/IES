Imports System.Diagnostics
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports System.Data
Public Class frmRecordExplorer

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

    Dim slSchoolYearTitle$, slDepartmentTitle$, slYearLevelTitle$, slSectionOfferingTitle$

    Dim sSQL As String = "SELECT fnAcademicYearTerm(TermID) as SchoolYear,TermID" & _
                  " FROM tblAYTerm;"

    Dim sSQL1 As String = "SELECT CollegeName,CollegeID" & _
                " FROM tblColleges"

    Dim sSQL2 As String = "SELECT ProgName" & _
                " FROM tblPrograms"

    Dim sSQL3 As String = "SELECT tblSection.SectionTitle, tblSectionOffering.SchoolYear, tblDepartment.DepartmentTitle, tblYearLevel.YearLevelTitle,tblSectionOffering.SectionOfferingID" & _
           " FROM tblYearLevel INNER JOIN ((tblDepartment INNER JOIN tblSection ON tblDepartment.DepartmentID = tblSection.DepartmentID) INNER JOIN tblSectionOffering ON tblSection.SectionID = tblSectionOffering.SectionID) ON tblYearLevel.YearLevelID = tblSection.YearLevelID" & _
           " GROUP BY tblSectionOffering.SectionOfferingID, tblSectionOffering.SchoolYear, tblDepartment.DepartmentTitle, tblYearLevel.YearLevelTitle, tblSection.SectionTitle;"

    Dim IsStarted As Boolean
   

    Private Sub frmRecordExplorer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Set up the UI
        SetUpListViewColumns()
        Refresh_SchoolYear()
        FillListView(sSQL, ListView)
    End Sub

    Private Sub Refresh_SchoolYear()

        Dim i As Integer
        Dim ii As Integer
        Dim iii As Integer
        Dim iv As Integer


        Dim slYearLevelTitleID$, slDepartmentTitleID$, slSchoolYearTitleID$, sSectionTitleID$

        TreeView.Nodes.Clear()

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        daSchoolYear.SelectCommand = com
        daSchoolYear.Fill(dsgeneral, "tblSchoolYear")


        Dim com1 As New MySqlCommand(sSQL1, clsCon.con)
        daDepartment.SelectCommand = com1
        daDepartment.Fill(dsgeneral1, "tblDepartment")


        Dim com2 As New MySqlCommand(sSQL2, clsCon.con)
        daYearLevel.SelectCommand = com2
        daYearLevel.Fill(dsgeneral2, "tblYearLevel")


        Dim com3 As New MySqlCommand(sSQL3, clsCon.con)
        daSection.SelectCommand = com3
        daSection.Fill(dsgeneral3, "tblSection")


        For i = 0 To dsgeneral.Tables("tblSchoolYear").Rows.Count - 1
            slSchoolYearTitle = dsgeneral.Tables("tblSchoolYear").Rows(i).Item("SchoolYear").ToString()

            tvRoot = TreeView.Nodes.Add(keySchoolYear & ";" & slSchoolYearTitle, slSchoolYearTitle)


            For ii = 0 To dsgeneral1.Tables("tblDepartment").Rows.Count - 1
                slDepartmentTitle = dsgeneral1.Tables("tblDepartment").Rows(ii).Item("DepartmentTitle").ToString()

                tvNode = tvRoot.Nodes.Add(keyDepartment & ";" & slSchoolYearTitle & ";" & slDepartmentTitle, slDepartmentTitle)


                For iii = 0 To dsgeneral2.Tables("tblYearLevel").Rows.Count - 1
                    slYearLevelTitle = dsgeneral2.Tables("tblYearLevel").Rows(iii).Item("YearLevelTitle").ToString()

                    tvNode1 = tvNode.Nodes.Add(KeyYearLevel & ";" & slSchoolYearTitle & ";" & slDepartmentTitle & ";" & slYearLevelTitle, slYearLevelTitle)


                    For iv = 0 To dsgeneral3.Tables("tblSection").Rows.Count - 1
                        slYearLevelTitleID = dsgeneral3.Tables("tblSection").Rows(iv).Item("YearLevelTitle").ToString()
                        slDepartmentTitleID = dsgeneral3.Tables("tblSection").Rows(iv).Item("DepartmentTitle").ToString()
                        slSchoolYearTitleID = dsgeneral3.Tables("tblSection").Rows(iv).Item("SchoolYear").ToString()

                        If slSchoolYearTitle = slSchoolYearTitleID Then
                            If slDepartmentTitle = slDepartmentTitleID Then
                                If slYearLevelTitle = slYearLevelTitleID Then
                                    slSectionOfferingTitle = dsgeneral3.Tables("tblSection").Rows(iv).Item("SectionTitle").ToString()
                                    sSectionTitleID = dsgeneral3.Tables("tblSection").Rows(iv).Item("SectionOfferingID").ToString()

                                    tvNode2 = tvNode1.Nodes.Add(KeySectionOffering & ";" & slSchoolYearTitle & ";" & slDepartmentTitle & ";" & slYearLevelTitle & ";" & sSectionTitleID, slSectionOfferingTitle)
                                End If
                            End If
                        End If

                    Next

                Next

            Next
        Next

    End Sub
    Public Function SelectNode(ByVal sKey As String) As Object

        Dim tNode As TreeNode

        If IsStarted = False Then
            Start()
        End If

        For Each tNode In TreeView.Nodes
            If tNode.Name = sKey Then

                TreeView.SelectedNode = tNode
                tNode.Expand()
            End If
        Next

    End Function
    Public Sub Start(Optional ByVal sSectionOfferingTitle As String = "", Optional ByVal sSchoolYearTitle As String = "")


        'refresh SectionOffering tree
        Refresh_SchoolYear()

        'set parameter
        If sSectionOfferingTitle <> "" Then
            SetSelectedSectionOffering(sSectionOfferingTitle, sSchoolYearTitle)
        End If
        IsStarted = True
    End Sub
    Private Sub SetSelectedSectionOffering(ByVal sSectionOfferingTitle As String, Optional ByVal sSchoolYearTitle As String = "")
        Dim tNode As TreeNode
        Dim splitKey() As String


        For Each tNode In TreeView.Nodes

            If tNode.Text = sSectionOfferingTitle And Microsoft.VisualBasic.Left(tNode.Name, 4) = KeySectionOffering Then

                splitKey = Split(tNode.Name, ";")

                If sSchoolYearTitle = "" Then
                    TreeView.SelectedNode = tNode
                    tNode.EnsureVisible()
                    Exit For
                Else

                    If splitKey(1) = sSchoolYearTitle Then
                        TreeView.SelectedNode = tNode
                        tNode.EnsureVisible()
                        Exit For
                    End If
                End If

            End If

        Next
    End Sub
    Private Sub SetUpListViewColumns()

        Dim lvColumnHeader As ColumnHeader

        SetView(View.LargeIcon)

        lvColumnHeader = ListView.Columns.Add("Name")
        lvColumnHeader.Width = 300

        lvColumnHeader = ListView.Columns.Add("ID")
        lvColumnHeader.Width = 0

        lvColumnHeader = ListView.Columns.Add("School Year")
        lvColumnHeader.Width = 100

        lvColumnHeader = ListView.Columns.Add("Department")
        lvColumnHeader.Width = 100

        lvColumnHeader = ListView.Columns.Add("Year Level")
        lvColumnHeader.Width = 100
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Close this form
        Me.Close()
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolBarToolStripMenuItem.Click
        'Toggle the visibility of the toolstrip and also the checked state of the associated menu item
        ToolBarToolStripMenuItem.Checked = Not ToolBarToolStripMenuItem.Checked
        ToolStrip.Visible = ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatusBarToolStripMenuItem.Click
        'Toggle the visibility of the statusstrip and also the checked state of the associated menu item
        StatusBarToolStripMenuItem.Checked = Not StatusBarToolStripMenuItem.Checked
        StatusStrip.Visible = StatusBarToolStripMenuItem.Checked
    End Sub

    'Change whether or not the folders pane is visible
    Private Sub ToggleFoldersVisible()
        'First toggle the checked state of the associated menu item
        FoldersToolStripMenuItem.Checked = Not FoldersToolStripMenuItem.Checked

        'Change the Folders toolbar button to be in sync
        FoldersToolStripButton.Checked = FoldersToolStripMenuItem.Checked

        ' Collapse the Panel containing the TreeView.
        Me.SplitContainer.Panel1Collapsed = Not FoldersToolStripMenuItem.Checked
    End Sub

    Private Sub FoldersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FoldersToolStripMenuItem.Click
        ToggleFoldersVisible()
    End Sub

    Private Sub FoldersToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FoldersToolStripButton.Click
        ToggleFoldersVisible()
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

    Private Sub ListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListToolStripMenuItem.Click, ListToolStripMenuItem1.Click
        SetView(View.List)
    End Sub

    Private Sub DetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetailsToolStripMenuItem.Click, DetailsToolStripMenuItem1.Click
        SetView(View.Details)
    End Sub

    Private Sub LargeIconsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LargeIconsToolStripMenuItem.Click, ThumbnailsToolStripMenuItem.Click
        SetView(View.LargeIcon)
    End Sub

    Private Sub SmallIconsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SmallIconsToolStripMenuItem.Click, IconsToolStripMenuItem.Click
        SetView(View.SmallIcon)
    End Sub

    Private Sub TileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TileToolStripMenuItem.Click, TilesToolStripMenuItem.Click
        SetView(View.Tile)
    End Sub


    Private Sub TreeView_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView.AfterSelect

        Dim splitKey() As String
        splitKey = Split(e.Node.Name, ";")

        Select Case splitKey(0)
            Case keySchoolYear
                Text = "S.Y.: " & e.Node.Text
                FillListView(sSQL1, ListView)
                ListView.Tag = keySchoolYear
            Case keyDepartment
                Text = "S.Y.: " & e.Node.Text & " - " & splitKey(1)
                FillListView(sSQL2, ListView)
                ListView.Tag = keyDepartment
            Case KeyYearLevel
                Text = "S.Y.: " & e.Node.Text & " - " & splitKey(1) & " - " & splitKey(2) & " - " & splitKey(3)
                FillListView(sSQL3, ListView)
                ListView.Tag = KeyYearLevel
            Case KeySectionOffering
                GenerateStudentList(splitKey(4))
                ListView.Tag = KeySectionOffering
        End Select
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Close()
    End Sub

    Private Sub frmRecordExplorer_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        ControlBox = False
    End Sub

    
    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click

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

        SetView(View.Details)

        lvColumnHeader = ListView.Columns.Add("Student Name")
        lvColumnHeader.Width = 400

        lvColumnHeader = ListView.Columns.Add("Student ID")
        lvColumnHeader.Width = 200

        lvColumnHeader = ListView.Columns.Add("Grade")
        lvColumnHeader.Width = 100

        lvColumnHeader = ListView.Columns.Add("Remarks")
        lvColumnHeader.Width = 100

        lvColumnHeader = ListView.Columns.Add("Date Enroled")
        lvColumnHeader.Width = 100


        Do While vRS.Read()
            Dim lv As New ListViewItem(vRS("FullName").ToString())
            lv.SubItems.Add(vRS("StudentID").ToString)
            lv.SubItems.Add(vRS("AvgOfGradeValue").ToString)
            lv.SubItems.Add(vRS("Remark").ToString)
            lv.SubItems.Add(vRS("DateEnroled").ToString)

            lv.ToolTipText = vRS("FullName").ToString() & " " & vRS("StudentID").ToString & vbNewLine & " Date Enrolled:" & vRS("DateEnroled").ToString
            lv.ImageIndex = 3
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

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        
    End Sub
End Class
