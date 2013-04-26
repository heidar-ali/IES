Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class PickSubject

    Dim sGetSubjectTitle As String
    Dim tmpSubjectCode As String
    Dim tmpSubjectID As String

    Public Sub BrowseBook(ByVal sSubjectId As String)
        Dim com As New MySqlCommand("SELECT * FROM tblSubject WHERE SubjectCode LIKE '%" & sSubjectId & "%'", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        lvResult.Items.Clear()
        While vRS.Read()
            Dim lv As New ListViewItem(vRS("SubjectCode").ToString())
            lv.SubItems.Add(vRS("SubjectID").ToString())
            lv.SubItems.Add(vRS("Units").ToString())
            lv.SubItems.Add(vRS("Description").ToString())
            lvResult.Items.AddRange(New ListViewItem() {lv})
        End While
        vRS.Close()
    End Sub
    Public Sub FillList()
        Dim com As New MySqlCommand("SELECT * FROM tblSubject", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        lvResult.Items.Clear()
        While vRS.Read()
            Dim lv As New ListViewItem(vRS("SubjectCode").ToString())
            lv.SubItems.Add(vRS("SubjectID").ToString())
            lv.SubItems.Add(vRS("Units").ToString())
            lv.SubItems.Add(vRS("Description").ToString())
            lvResult.Items.AddRange(New ListViewItem() {lv})
        End While
        vRS.Close()
    End Sub

    Public Sub ShowSubjectPerYL(ByVal sCurriculumCode As String, ByVal YLID As Integer)
        Dim com As New MySqlCommand("SELECT * FROM tblSubject", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        lvResult.Items.Clear()
        While vRS.Read()
            Dim lv As New ListViewItem(vRS("SubjectCode").ToString())
            lv.SubItems.Add(vRS("SubjectID").ToString())
            lv.SubItems.Add(vRS("Units").ToString())
            lv.SubItems.Add(vRS("Description").ToString())
            lvResult.Items.AddRange(New ListViewItem() {lv})
        End While
        vRS.Close()
    End Sub
    Public Function GetSubjectTitle(Optional ByRef sSubjectCode As String = "", Optional ByRef sSubjectDescription As String = "0000", Optional ByRef sSubjectID As String = "0000", Optional ByVal PickSubjectID As String = "0000") As String

        If SubjectRecordExist() <> TranDBResult.Success Then
            MsgBox("There are no record yet in Subject Entries", vbExclamation)
            CancelGetSubjectTitle()
            Exit Function
        End If


        If PickSubjectID <> "0000" Then
            BrowseBook(PickSubjectID)
        Else
            FillList()
        End If

        'show
        Me.ShowDialog()

        'return
        sSubjectCode = tmpSubjectCode
        sSubjectDescription = sGetSubjectTitle
        sSubjectID = tmpSubjectID

    End Function

    Private Sub CancelGetSubjectTitle()
        sGetSubjectTitle = ""
        tmpSubjectCode = ""
        tmpSubjectID = ""
        Close()
    End Sub
    Private Sub ReturnGetSubjectTitle()
        sGetSubjectTitle = lvResult.FocusedItem.SubItems(3).Text
        tmpSubjectCode = lvResult.FocusedItem.Text
        tmpSubjectID = lvResult.FocusedItem.SubItems(1).Text
        Close()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        CancelGetSubjectTitle()
    End Sub

    Private Sub cmdSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSelect.Click
        ReturnGetSubjectTitle()
    End Sub

    Private Sub lvResult_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvResult.DoubleClick
        ReturnGetSubjectTitle()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        BrowseBook(TextBox1.Text)
    End Sub

    Private Sub PickSubject_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        FillList()
    End Sub
End Class