Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class PickSectionOffering
    Dim tmpStudentID As String

    Dim MaxEntryCount As Long
    Dim CurRecPos As Long
    Dim CurStudentCount As Long

    Dim curSchoolYear As String
    Dim curYearLevelID As Integer
    Public Function GetSectionOfferingID(Optional ByRef TextObject As Object = Nothing, Optional ByVal lMaxEntryCount As Long = 15, Optional ByVal sSchoolYear As String = "", Optional ByVal iYearLevelID As Integer = 0) As String

        Dim sSQL As String


        'set fail to default
        GetSectionOfferingID = ""
        tmpStudentID = ""
        'set defaults

        MaxEntryCount = lMaxEntryCount
        CurRecPos = 0

        curSchoolYear = sSchoolYear
        curYearLevelID = iYearLevelID

        If curSchoolYear = "" Then
            sSQL = "SELECT tblSectionOffering.SectionOfferingID AS lvKey, CONCAT(tblYearLevel.YearLevelTitle , ' - ' , tblSection.SectionTitle) AS FullTitle, tblSchoolYear.SchoolYear, tblDepartment.DepartmentTitle" & _
                " FROM tblYearLevel INNER JOIN ((tblDepartment INNER JOIN tblSection ON tblDepartment.DepartmentID = tblSection.DepartmentID) INNER JOIN (tblSchoolYear INNER JOIN tblSectionOffering ON tblSchoolYear.SchoolYear = tblSectionOffering.SchoolYear) ON tblSection.SectionID = tblSectionOffering.SectionID) ON tblYearLevel.YearLevelID = tblSection.YearLevelID"

            If curYearLevelID <> 0 Then
                sSQL = sSQL & " WHERE((tblYearLevel.YearLevelID)=" & curYearLevelID & ")"
            End If

            sSQL = sSQL & " ORDER BY  CONCAT(tblYearLevel.YearLevelTitle , ' - ' , tblSection.SectionTitle);"


        Else

            sSQL = "SELECT tblSectionOffering.SectionOfferingID AS lvKey, CONCAT(tblYearLevel.YearLevelTitle , ' - ' , tblSection.SectionTitle) AS FullTitle, tblSchoolYear.SchoolYear, tblDepartment.DepartmentTitle" & _
                    " FROM tblYearLevel INNER JOIN ((tblDepartment INNER JOIN tblSection ON tblDepartment.DepartmentID = tblSection.DepartmentID) INNER JOIN (tblSchoolYear INNER JOIN tblSectionOffering ON tblSchoolYear.SchoolYear = tblSectionOffering.SchoolYear) ON tblSection.SectionID = tblSectionOffering.SectionID) ON tblYearLevel.YearLevelID = tblSection.YearLevelID" & _
                    " Where (((tblSchoolYear.SchoolYear) = '" & curSchoolYear & "')"

            If curYearLevelID <> 0 Then
                sSQL = sSQL & " AND ((tblYearLevel.YearLevelID)=" & curYearLevelID & "))"
            Else
                sSQL = sSQL & ")"
            End If

            sSQL = sSQL & " ORDER BY CONCAT(tblYearLevel.YearLevelTitle , ' - ' , tblSection.SectionTitle);"


        End If

        listRecord.Items.Clear()

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        While vRS.Read()
            Dim lv As New ListViewItem(vRS("FullTitle").ToString())
            lv.SubItems.Add(vRS("lvKey").ToString())
            listRecord.Items.AddRange(New ListViewItem() {lv})
        End While
        vRS.Close()
        'show form
        Me.ShowDialog()

        'this next line will not execute unload this for will be unloaded
        GetSectionOfferingID = tmpStudentID
    End Function

    Private Sub ReturnGetStudentID()
        If listRecord.Items.Count > 0 Then
            tmpStudentID = listRecord.FocusedItem.SubItems(1).Text
            Close()
        End If
    End Sub
    Private Sub CancelGetStudentID()
        tmpStudentID = ""
        Close()
    End Sub


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        ReturnGetStudentID()
    End Sub

    Private Sub listRecord_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listRecord.DoubleClick
        ReturnGetStudentID()
    End Sub

    Private Sub txtFind_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFind.TextChanged
        Dim sSQL As String

        sSQL = "SELECT tblSectionOffering.SectionOfferingID AS lvKey, CONCAT(tblYearLevel.YearLevelTitle , ' - ' , tblSection.SectionTitle) AS FullTitle, tblSchoolYear.SchoolYearTitle, tblDepartment.DepartmentTitle" & _
                " FROM tblYearLevel INNER JOIN ((tblDepartment INNER JOIN tblSection ON tblDepartment.DepartmentID = tblSection.DepartmentID) INNER JOIN (tblSchoolYear INNER JOIN tblSectionOffering ON tblSchoolYear.SchoolYearTitle = tblSectionOffering.SchoolYear) ON tblSection.SectionID = tblSectionOffering.SectionID) ON tblYearLevel.YearLevelID = tblSection.YearLevelID" & _
                " WHERE ((CONCAT(tblYearLevel.YearLevelTitle , ' - ' , tblSection.SectionTitle) like '%" & txtFind.Text & "%')" & _
                " OR tblDepartment.DepartmentTitle like '%" & txtFind.Text & "%'" & _
                " OR tblSchoolYear.SchoolYearTitle like '%" & txtFind.Text & "%')"
        'add values on parameters
        '-------------------------------------------------------------------

        If curSchoolYear = "" Then
            If curYearLevelID <> 0 Then
                sSQL = sSQL & " AND ((tblYearLevel.YearLevelID)=" & curYearLevelID & ")"
            End If
        Else
            sSQL = sSQL & " AND (((tblSchoolYear.SchoolYearTitle) = '" & curSchoolYear & "')"

            If curYearLevelID <> 0 Then
                sSQL = sSQL & " AND ((tblYearLevel.YearLevelID)=" & curYearLevelID & ") )"
            Else
                sSQL = sSQL & ")"
            End If


        End If
        '-------------------------------------------------------------------

        sSQL = sSQL & " ORDER BY  CONCAT(tblYearLevel.YearLevelTitle , ' - ' , tblSection.SectionTitle);"

        listRecord.Items.Clear()

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        While vRS.Read()
            Dim lv As New ListViewItem(vRS("FullTitle").ToString())
            lv.SubItems.Add(vRS("lvKey").ToString())
            listRecord.Items.AddRange(New ListViewItem() {lv})
        End While
        vRS.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        CancelGetStudentID()
    End Sub
End Class