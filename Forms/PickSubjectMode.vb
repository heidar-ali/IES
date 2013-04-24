Imports System.Windows.Forms

Public Class PickSubjectMode

    Dim tmpSubjectModeID As String
    Dim curSubjectMode As String


    Public Function GetSubjectMode(Optional ByRef TextObject As String = "N/A", Optional ByRef sSubjectModeID As String = "") As String

        Dim sSQL As String

        tmpSubjectModeID = ""
        curSubjectMode = ""

        FillListView("SELECT Description,SubjectMode,ShortName FROM tblSubjectMode", listRecords, False)
        Me.ShowDialog()

        TextObject = curSubjectMode
        sSubjectModeID = tmpSubjectModeID
    End Function
    Private Sub ReturnGetStudentID()
        If listRecords.Items.Count > 0 Then
            tmpSubjectModeID = listRecords.FocusedItem.SubItems(1).Text
            curSubjectMode = listRecords.FocusedItem.Text
            Close()
        End If
    End Sub
    Private Sub CancelGetStudentID()
        tmpSubjectModeID = ""
        curSubjectMode = ""
        Close()
    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSelect.Click
        ReturnGetStudentID()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        CancelGetStudentID()
    End Sub

    Private Sub PickSubjectMode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtFind_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFind.TextChanged
        FillListView("SELECT  Description,SubjectMode,ShortName FROM tblSubjectMode WHERE Description LIKE '%" & txtFind.Text & "%'", listRecords)
    End Sub
End Class
