Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class PickSection
    Dim curSectionCOunt As Integer

    Dim MaxEntryCount As Long
    Dim CurRecPos As Long

    Dim curYearLevelID As Integer
    Dim curDepartmentID As String

    Dim tmpSectionID As String
    Dim tmpSectionTitle As String
    Dim tmpYearLevelID As Integer

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click, listRecord.DoubleClick
       ReturnGetSectionID()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        CancelGetSection()
    End Sub

    Private Sub PickSection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub CancelGetSection()
        tmpSectionID = ""
        Close()
    End Sub
    Private Sub ReturnGetSectionID()

        Dim sp() As String

        If listRecord.Items.Count > 0 Then

            tmpSectionID = listRecord.FocusedItem.SubItems(1).Text
            sp = Split(listRecord.FocusedItem.Text, "-")
            tmpSectionTitle = Trim(sp(1))
            tmpYearLevelID = YLTitleToID(Trim(sp(0)))

            Close()
        End If
    End Sub
    Public Function GetSectionID(Optional ByRef TextObject As Object = Nothing, Optional ByVal lMaxEntryCount As Long = 15, Optional ByVal sDepartmentID As String = "", Optional ByVal iYearLevelID As Integer = 0, Optional ByRef sRetrunSectionTitle As String = "", Optional ByRef iRetrunYearLevelID As Integer = 0) As String

        Dim sSQL As String


        'set fail to default
        GetSectionID = ""
        tmpSectionID = ""
        'set defaults

        MaxEntryCount = lMaxEntryCount
        CurRecPos = 0

        curYearLevelID = iYearLevelID
        curDepartmentID = sDepartmentID

        If curYearLevelID = 0 And curDepartmentID = "" Then

            sSQL = " SELECT tblSection.SectionID, CONCAT(tblYearLevel.YearLevelTitle , ' - ' , tblSection.SectionTitle) AS sSectionFullTitle, tblDepartment.DepartmentTitle" & _
                " FROM tblDepartment RIGHT JOIN (tblYearLevel RIGHT JOIN tblSection ON tblYearLevel.YearLevelID = tblSection.YearLevelID) ON tblDepartment.DepartmentID = tblSection.DepartmentID" & _
                " ORDER BY CONCAT(tblYearLevel.YearLevelTitle , ' - ' , tblSection.SectionTitle);"

        ElseIf curYearLevelID = 0 And curDepartmentID <> "" Then

            sSQL = " SELECT tblSection.SectionID, CONCAT(tblYearLevel.YearLevelTitle , ' - ' , tblSection.SectionTitle) AS sSectionFullTitle, tblDepartment.DepartmentTitle" & _
                " FROM tblDepartment RIGHT JOIN (tblYearLevel RIGHT JOIN tblSection ON tblYearLevel.YearLevelID = tblSection.YearLevelID) ON tblDepartment.DepartmentID = tblSection.DepartmentID" & _
                " Where ((tblSection.DepartmentID) = '" & curDepartmentID & "')" & _
                " ORDER BY CONCAT(tblYearLevel.YearLevelTitle , ' - ' , tblSection.SectionTitle);"

        ElseIf curYearLevelID <> 0 And curDepartmentID = "" Then

            sSQL = " SELECT tblSection.SectionID, CONCAT(tblYearLevel.YearLevelTitle , ' - ' , tblSection.SectionTitle) AS sSectionFullTitle, tblDepartment.DepartmentTitle" & _
                " FROM tblDepartment RIGHT JOIN (tblYearLevel RIGHT JOIN tblSection ON tblYearLevel.YearLevelID = tblSection.YearLevelID) ON tblDepartment.DepartmentID = tblSection.DepartmentID" & _
                " Where ((tblSection.YearLevelID) = '" & curYearLevelID & "')" & _
                " ORDER BY CONCAT(tblYearLevel.YearLevelTitle , ' - ' , tblSection.SectionTitle);"

        Else
            sSQL = " SELECT tblSection.SectionID,CONCAT(tblYearLevel.YearLevelTitle , ' - ' , tblSection.SectionTitle) AS sSectionFullTitle, tblDepartment.DepartmentTitle" & _
                " FROM tblDepartment RIGHT JOIN (tblYearLevel RIGHT JOIN tblSection ON tblYearLevel.YearLevelID = tblSection.YearLevelID) ON tblDepartment.DepartmentID = tblSection.DepartmentID" & _
                " Where (((tblSection.DepartmentID) = '" & curDepartmentID & "') And ((tblSection.YearLevelID) = '" & curYearLevelID & "'))" & _
                " ORDER BY CONCAT(tblYearLevel.YearLevelTitle , ' - ' , tblSection.SectionTitle);"

        End If


        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        listRecord.Items.Clear()
        While vRS.Read
            Dim lv As New ListViewItem(vRS("sSectionFullTitle").ToString())
            lv.SubItems.Add(vRS("SectionID").ToString())
            listRecord.Items.AddRange(New ListViewItem() {lv})
        End While
        vRS.Close()


        'show form
        Me.ShowDialog()

        'this next line will not execute unload this for will be unloaded
        On Error Resume Next
        sRetrunSectionTitle = tmpSectionTitle
        iRetrunYearLevelID = tmpYearLevelID
        GetSectionID = tmpSectionID
    End Function
End Class
