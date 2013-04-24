
Option Explicit On

Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Partial Public Class frmAddFreeSections
    Inherits Form

    Dim State As FormState

    Dim RecordAdded As Boolean
    Dim RecordEdited As Boolean

    Dim curTeacherID As String
    Dim curRoomID As String

    Dim Sec As tFreeSection


    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmSectionDetails_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

    End Sub
    Public Function ShowForm(Optional ByVal sCampusID As Integer = 0, _
                             Optional ByVal sCollegeID As String = "", _
                             Optional ByVal sTermID As Integer = 0, _
                             Optional ByVal sProgramID As String = "") As Boolean


        Text = "Please select the Subject(s) you wish to add to this Free Section"


        'check user access
        If UserAllowedTo(CurrentUser.UserName, "Can Add Section") = False Then
            MsgBox("Unable to show Add Free Section window." & vbNewLine & _
                    "You are not permitted to aceess it. Please contact your Administrator.", vbExclamation)

            Close()
            Exit Function
        End If

        State = FormState.addFormState

        GetNewFreeSectionID(txtSectionID.Text)
        Sec.SectionID = txtSectionID.Text
        Sec.CollegeID = sCollegeID
        Sec.CampusID = sCampusID
        Sec.TermID = sTermID
        Sec.ProgramID = sProgramID

        txtSlot.Text = 40

        Sec.Limit = 40
        Sec.IsBlock = 0
        Sec.IsDissolved = 0
        Sec.IsEvening = 0

        FillListView("SELECT S.SubjectCode, s.SubjectID, s.Description, s.Units, s.CreditUnits, s.LabUnits, s.LabHrs, S.LecHrs,S.MaxSize " & _
                       "FROM tblcurriculumdetails AS CD, tblsubject AS S, `tblcurriculum` AS C " & _
                       "WHERE S.`SubjectID` = CD.SubjectID AND C.`CurriculumID` = CD.`CurriculumID` " & _
                       "AND C.`ProgramID` = '" & sProgramID & "' ORDER BY  CD.`SubjectID`", listSubjects, False)


        'show form
        Me.ShowDialog()

        'return
        ShowForm = RecordAdded
    End Function
    Public Function ShowEdit(Optional ByVal sSectionOfferingID As String = "") As Boolean

        '-------------------------------------------------------
        'check user access
        '-------------------------------------------------------
        If UserAllowedTo(CurrentUser.UserName, sCanEditSectionOffering) = False Then
            MsgBox("Unable to continue Editing Section Offering entry." & vbNewLine & vbNewLine & _
                    "You are not permitted to do this. Please contact your administrator for more information.", vbExclamation)
            Exit Function
        End If
        '-------------------------------------------------------


        txtSectionID.Text = sSectionOfferingID

        TabControl1.Enabled = False

        State = FormState.updateFormState

        cmdSave.Text = "Update"

        'show form
        Me.ShowDialog()

        'return
        ShowEdit = RecordEdited
    End Function

    Private Function ValidateData() As Boolean

        'default
        ValidateData = False

        'check id
        If Not CheckTextBox(txtSectionID, "Please Enter Section ID") Then
            Exit Function
        End If

        'check title
        If Not CheckTextBox(txtSectionFullTitle, "Please Enter Section Title") Then
            Exit Function
        End If

        'If SectionExistByFullTitle(txtSectionFullTitle.Text) <> TranDBResult.Success Then
        '    MsgBox("Please enter valid Section Title. Section Title already offer...", vbExclamation)
        '    HLTxt(txtSectionFullTitle)
        '    Exit Function
        'End If

        ValidateData = True
    End Function
    Private Sub UpdateData()

    End Sub
    Private Function SaveData() As Boolean

        Dim Offer As tSubjectOffering

        Sec.SectionTitle = txtSectionFullTitle.Text
        Sec.CreatedBy = CurrentUser.FullName
        Sec.CreationDate = DateTime.Now.Date()

        If Not ValidateData() Then
            Exit Function
        End If

        Select Case AddFreeSection(Sec)
            Case TranDBResult.Success

                For Each lv As ListViewItem In listSubjects.Items
                    If lv.Checked = True Then
                        Offer.SubjectOfferingID = DateTime.Now.Year & "-" & txtSectionID.Text & "-" & lv.SubItems(1).Text
                        Offer.SubjectID = lv.SubItems(1).Text
                        Offer.SectionID = txtSectionID.Text
                        Offer.TermID = Sec.TermID
                        Offer.CreatedBy = CurrentUser.FullName
                        Offer.CreationDate = DateTime.Now.Date
                        Offer.Limit = 60

                        Select Case AddSubjectOffering(Offer)
                            Case TranDBResult.Success

                            Case TranDBResult.Failed
                                GoTo Failed
                        End Select
                    End If
                Next
                MsgBox("Free section successfully saved", vbInformation)
                Close()
                SaveData = True

            Case TranDBResult.DuplicateTitle
                MsgBox("Adding Free section went failed" & vbNewLine & vbNewLine & "Duplicate Title Found!!!", vbExclamation)
                SaveData = False

            Case TranDBResult.DuplicateID
                MsgBox("Adding Free section went failed" & vbNewLine & vbNewLine & "Duplicate SectionID Found!!!", vbExclamation)
                SaveData = False

            Case TranDBResult.InvalidSectionSectionTitle
                MsgBox("Adding Free section went failed" & vbNewLine & vbNewLine & "Invalid Section Title Input!!!", vbExclamation)
                SaveData = False

            Case TranDBResult.InvalidSectionSectionID
                MsgBox("Adding Free section went failed" & vbNewLine & vbNewLine & "Invalid Section ID Generated!!!", vbExclamation)
                SaveData = False

            Case TranDBResult.InvalidSectionProgramID
                MsgBox("Adding Free section went failed" & vbNewLine & vbNewLine & "Invalid Academic Program for Section!!!", vbExclamation)
                SaveData = False

Failed:
            Case TranDBResult.Failed
                MsgBox("Adding Free section went failed", vbExclamation)
                SaveData = False
                Exit Function
        End Select

    End Function

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdSave.Click
        Select Case State
            Case FormState.updateFormState
                UpdateData()
            Case FormState.addFormState
                SaveData()
        End Select
    End Sub


    Private Sub cmdGetTeacher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetTeacher.Click
        Dim sTeacherID As String
        Dim sTeacherFullName As String
        Dim frm As New PickTeacher()

        sTeacherID = frm.GetTeacherID(sTeacherFullName)

        If sTeacherID <> "" Then
            curTeacherID = sTeacherID
            txtTeacherFullName.Text = sTeacherFullName
        End If
    End Sub

    Private Sub txtTeacherFullName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTeacherFullName.TextChanged
        If Len(txtTeacherFullName.Text) < 1 Then Exit Sub

        If TeacherAssignedBySchoolYear(curTeacherID, Sec.TermID) = TranDBResult.Success Then
            MsgBox("The seleted Teacher entry is already assigned in the selected School Year." & vbNewLine & "Please select other Teacher entry", vbExclamation)
            cmdGetTeacher.Focus()
        End If
    End Sub


    Private Sub cmdBrowseRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBrowseRoom.Click
        Dim frm As New PickRoom()
        frm.ShowDialog()
        If frm.isValid = True Then
            txtRoom.Text = frm.getRoom
            curRoomID = frm.getID
        End If
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Close()
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        FillListView("SELECT SubjectID,SubjectCode,SubjectTitle,CreditUnits FROM tblSubject WHERE SubjectCode LIKE '%" & txtFind.Text & "%'", lvSubjects, False)
    End Sub

    Private Sub txtFind_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFind.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdSearch_Click(sender, e)
        End If
    End Sub
End Class
