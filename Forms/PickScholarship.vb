Imports System.Windows.Forms

Public Class PickScholarship
    Dim curGrantID As String
    Dim curGrantCode As String
    Dim curTermID As Integer

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
       SetReturnValues()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
       ClearReturnValues()
    End Sub

    Private Sub cmdSearch_Click(sender As System.Object, e As System.EventArgs) Handles cmdSearch.Click
        FillListView("SELECT TemplateCode,fnScholarProviderName(SchoProviderID),ShortName,GrantTemplateID FROM tblSchoGrantTemplates WHERE TemplateCode LIKE '%" & txtFind.Text & "%' AND TermID='" & curTermID & "'", lvGrants, False)
    End Sub

    Public Sub ShowForm(ByVal TermID As Integer, ByRef GrantID As String, ByRef GrantCode As String)
        FillListView("SELECT TemplateCode,fnScholarProviderName(SchoProviderID),ShortName,GrantTemplateID FROM tblSchoGrantTemplates WHERE TermID='" & TermID & "'", lvGrants, False)

        curTermID = TermID

        Me.ShowDialog()

        GrantID = curGrantID
        GrantCode = curGrantCode

    End Sub

    Private Sub SetReturnValues()
        If lvGrants.Items.Count > 0 Then
            curGrantID = lvGrants.FocusedItem.SubItems(3).Text
            curGrantCode = lvGrants.FocusedItem.Text

            Close()
        End If
    End Sub

    Private Sub ClearReturnValues()
        curGrantID = ""
        curGrantCode = ""

        Close()
    End Sub
End Class
