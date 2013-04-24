Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class PickSchoolYear

    Dim tmpSchoolYear As String
    Dim MaxEntryCount As Long
    Dim CurRecPos As Long
    Dim CurRecordCount As Long

    Dim sOldSchoolYear As String
    Dim sWC As String

    Public ReadOnly Property getSY As String
        Get
            Return tmpSchoolYear
        End Get
    End Property

    Public Function GetItem(Optional ByVal TextObject As Object = Nothing, Optional ByVal lMaxEntryCount As Long = 15, Optional ByVal OldSchoolYear As String = "0000", Optional ByVal ExcludeClosed As Boolean = False) As String

        Dim sSQL As String


        'set fail to default
        GetItem = ""
        tmpSchoolYear = ""


        MaxEntryCount = lMaxEntryCount
        CurRecPos = 0
        sOldSchoolYear = OldSchoolYear

        If ExcludeClosed = True Then
            sWC = " AND ((tblSchoolYear.Locked)='0')"
        Else
            sWC = ""
        End If

        sSQL = "SELECT CONCAT(tblAYTerm.SchoolYear,' ',tblAYTerm.SchoolTerm) AS lvKey, tblAYTerm.SchoolYear" & _
                " From tblAYTerm WHERE Left(SchoolYear,4) > " & Microsoft.VisualBasic.Left(sOldSchoolYear, 4) & sWC

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        lvList.Items.Clear()
        While vRS.Read()
            Dim lv As New ListViewItem(vRS("lvKey").ToString())
            lvList.Items.AddRange(New ListViewItem() {lv})
        End While
        vRS.Close()

        ShowDialog()

        'this next line will not execute unload this for will be unloaded
        GetItem = tmpSchoolYear
    End Function

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click, lvList.DoubleClick
        If lvList.Items.Count > 0 Then
            tmpSchoolYear = lvList.FocusedItem.Text
            Close()
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub PickSchoolYear_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtFind_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFind.TextChanged
        Try
            Dim sSQL As String

            sSQL = "SELECT CONCAT(tblAYTerm.SchoolYear,' ',tblAYTerm.SchoolTerm) as AS lvKey, tblAYTerm.SchoolYear" & _
                    " From tblAYTerm WHERE Left(SchoolYear,4) > " & Microsoft.VisualBasic.Left(sOldSchoolYear, 4) & " AND ((SchoolYearTitle) like '%" & txtFind.Text & "%')) " & sWC


            Dim com As New MySqlCommand(sSQL, clsCon.con)
            Dim vRS As MySqlDataReader = com.ExecuteReader()
            lvList.Items.Clear()
            While vRS.Read()
                Dim lv As New ListViewItem(vRS("lvKey").ToString())
                lvList.Items.AddRange(New ListViewItem() {lv})
            End While
            vRS.Close()
        Catch ex As Exception

        End Try
    End Sub

End Class
