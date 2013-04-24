Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class PickSubjectAreas

    Dim tmpSubjectAreaID As String
    Dim curSubjectArea As String

    Public Function GetSubjectAreas(Optional ByRef TextObject As String = "0000", Optional ByRef sSubjectAreaID As String = "") As String

        Dim sSQL As String

        tmpSubjectAreaID = ""
        curSubjectArea = ""

        FillListView("SELECT SubjectAreaName,SubjectAreaID,ShortName FROM tblSubjectAreas", listRecord)

        Me.ShowDialog()

        TextObject = curSubjectArea
        sSubjectAreaID = tmpSubjectAreaID
    End Function


    Private Sub ReturnGetStudentID()
        If listRecord.Items.Count > 0 Then
            tmpSubjectAreaID = listRecord.FocusedItem.SubItems(1).Text
            curSubjectArea = listRecord.FocusedItem.Text
            Close()
        End If
    End Sub
    Private Sub CancelGetStudentID()
        tmpSubjectAreaID = ""
        Close()
    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listRecord.DoubleClick, cmdSelect.Click
        ReturnGetStudentID()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        CancelGetStudentID()
    End Sub

    Private Sub PickSubjectAreas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtFind_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFind.TextChanged
        FillListView("SELECT SubjectAreaName,SubjectAreaID,ShortName FROM tblSubjectAreas WHERE SubjectAreaName Like '*" & txtFind.Text & "*'", listRecord)
    End Sub
End Class
