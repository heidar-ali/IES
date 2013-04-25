Option Explicit On

Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Windows.Forms

Public Class frmSubjectProperties
    Inherits Form

    Dim sPreqID As String
    Dim SubjectID As String

    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub frmSectionAE_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        With Grid
            .set_ColWidth(0, 130)
            .set_ColWidth(1, 480)

            .set_TextMatrix(0, 0, "Subject Code")
            .set_TextMatrix(1, 0, "Subject Title")
            .set_TextMatrix(2, 0, "Descriptive Title")
            .set_TextMatrix(3, 0, "Lecture Units")
            .set_TextMatrix(4, 0, "Lecture Hours")
            .set_TextMatrix(5, 0, "Laboratory Units")
            .set_TextMatrix(6, 0, "Laboratory Hours")
            .set_TextMatrix(7, 0, "Min. Class Slots")
            .set_TextMatrix(8, 0, "Max. Class Slots")

        End With
    End Sub
    Public Sub ShowForm(ByVal sSubjectId As String)
        Dim com As New MySqlCommand("SELECT t.SubjectCode,t.SubjectTitle,t.Description,t.Units,t.LecHrs,t.LabUnits,t.LabHrs,t.MinSize,t.MaxSize " & _
                                    "FROM tblsubject t WHERE t.SubjectID='" & sSubjectId & "'", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            SubjectID = sSubjectId
            With Grid
                .set_TextMatrix(0, 1, vRS("SubjectCode").ToString())
                .set_TextMatrix(1, 1, vRS("SubjectTitle").ToString())
                .set_TextMatrix(2, 1, vRS("Description").ToString())
                .set_TextMatrix(3, 1, vRS("Units").ToString())
                .set_TextMatrix(4, 1, vRS("LecHrs").ToString())
                .set_TextMatrix(5, 1, vRS("LabUnits").ToString())
                .set_TextMatrix(6, 1, vRS("LabHrs").ToString())
                .set_TextMatrix(7, 1, vRS("MinSize").ToString())
                .set_TextMatrix(8, 1, vRS("MaxSize").ToString())

                .set_ColAlignment(1, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignLeftCenter)

            End With
        End If
        vRS.Close()

        ShowPrerequisite(sSubjectId)
        ShowEquivalence(sSubjectId)
        ShowLinkInformation(sSubjectId)

        Me.ShowDialog()
    End Sub

    Private Sub ShowPrerequisite(ByVal CurSubjectID As String)
        FillListView("SELECT fnSubjectCode(SubjectID),SubjectID,fnSubjectLectUnits(SubjectID),fnSubjectDesc(SubjectID),Remarks FROM tblPrerequisite WHERE Remarks <> 'Equivalence' AND Curriculum_SubjectID='" & CurSubjectID & "'", lvPrerequisite, False)
    End Sub

    Private Sub ShowEquivalence(ByVal CurSubjectID As String)
        FillListView("SELECT fnSubjectCode(SubjectID),SubjectID,fnSubjectLectUnits(SubjectID),fnSubjectDesc(SubjectID),Remarks FROM tblPrerequisite WHERE Remarks = 'Equivalence' AND Curriculum_SubjectID='" & CurSubjectID & "'", lvEquivalence, False)
    End Sub

    Private Sub ShowLinkInformation(ByVal curSubjectID As String)
        FillListView("SELECT C.CurriculumCode,`fnProgramCollegeCode`(PM.`ProgID`), fnProgramCode(PM.`ProgID`),`fnDisciplineMajors`(PM.`MajorDiscID`),`fnYearTerm`(CD.`YearTermID`) " & _
                     "FROM `tblcurriculum` AS C INNER JOIN `tblcurriculumdetails` AS CD ON C.CurriculumID = CD.`CurriculumID`LEFT JOIN `tblprogrammajors` AS PM ON C.`ProgramID` = PM.ProgID " & _
                     "WHERE CD.SubjectID='" & curSubjectID & "'", lvOfferingHistory, False)
    End Sub

End Class
