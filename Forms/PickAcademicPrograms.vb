Imports System.Windows.Forms

Public Class PickAcademicPrograms

    Dim tmpProgramID As String
    Dim tmpProgramName As String
    Dim tmpProgramCode As String

    Public Function GetAcademicProgram(Optional ByVal CampusID As Integer = 1, Optional ByRef TextObject As String = "0000", Optional ByRef sProgramID As String = "", Optional ByRef ProgramCode As String = "") As String

        Dim sSQL As String


        'set fail to default
        'GetAcademicProgram = ""
        tmpProgramID = ""
        tmpProgramName = ""
        tmpProgramCode = ""

        FillListView("SELECT tblPrograms.ProgCode,tblPrograms.ProgID,tblPrograms.ProgName,tblColleges.CollegeCode " & _
                    "FROM tblPrograms INNER JOIN tblColleges ON tblPrograms.CollegeID = tblColleges.CollegeID WHERE tblPrograms.CampusID='" & CampusID & "'", listRecord)

ConShowForm:

        'show form
        Me.ShowDialog()

        'this next line will not execute unload this for will be unloaded
        TextObject = tmpProgramCode
        sProgramID = tmpProgramID
        ProgramCode = tmpProgramCode

    End Function
    Private Sub ReturnGetProgramID()
        If listRecord.Items.Count > 0 Then
            tmpProgramID = listRecord.FocusedItem.SubItems(1).Text
            tmpProgramName = listRecord.FocusedItem.SubItems(2).Text
            tmpProgramCode = listRecord.FocusedItem.Text
            Close()
        End If
    End Sub
    Private Sub CancelGetProgramID()
        tmpProgramID = ""
        tmpProgramName = ""
        tmpProgramCode = ""
        Close()
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listRecord.DoubleClick, cmdSelect.Click
        ReturnGetProgramID()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        CancelGetProgramID()
    End Sub

End Class
