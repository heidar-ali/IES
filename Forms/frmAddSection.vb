Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class frmAddSection

    Dim RecordAdded As Boolean
    Public myID As Integer
    Dim RecordEdited As Boolean

    Dim curSection As tSection
    Dim vCol As tCollege

    Dim FacultyID As String
    Dim CollegeID As String

    Dim IsBlock As Boolean

    Dim IsDissolved As Boolean
    Dim IsEvening As Boolean
    Dim ProgramID As String


    Public Function ShowForm(Optional ByVal CollegeID As String = "") As Boolean

        Dim sNewSectionID As String


        '-------------------------------------------------------
        'check user access

        '-------------------------------------------------------

        Text = "Add New Block Section"

        If UserAllowedTo(CurrentUser.UserName, sCanAddSection) = False Then
            MsgBox("Unable to continue Editing Section entry." & vbNewLine & vbNewLine & _
                    "You are not permitted to do this. Please contact your administrator for more information.", vbExclamation)
            Exit Function
        End If



        'set defaults
        ShowForm = False

        If CollegeRecordExist() <> TranDBResult.Success Then
            MsgBox("Unable to continue Adding Section." & vbNewLine & "Academic Programs/Course entries not exist", vbExclamation)
            Close()
            Exit Function
        End If


        'check if other related recordset rentry exist
        'If ProgramRecordExist() <> TranDBResult.Success Then
        '    MsgBox("Unable to continue Adding Section." & vbNewLine & "Academic Programs/Course entries not exist", vbExclamation)
        '    Close()
        '    Exit Function
        'End If



        'generate new id
        GetNewSectionID(txtSectionID.Text)

        'FillListView("SELECT YearTermDesc,ID FROM tlbYearLevelTerm", lvYearTerm)

        OK_Button.Text = "Save"

        'show form
        ShowDialog()

        'return
        ShowForm = RecordAdded
    End Function
    Public Function ShowEdit(ByVal sSectionID As String) As Boolean

        Dim vCur As tCurriculum
        Dim vProg As tAcademicPrograms



        '-------------------------------------------------------
        'check user access
        '-------------------------------------------------------
        If UserAllowedTo(CurrentUser.UserName, sCanEditSection) = False Then
            MsgBox("Unable to continue Editing Section entry." & vbNewLine & vbNewLine & _
                    "You are not permitted to do this. Please contact your administrator for more information.", vbExclamation)
            Exit Function
        End If
        '-------------------------------------------------------



        If GetSectionByID(sSectionID, curSection) <> TranDBResult.Success Then

            MsgBox("Unable to continue Editing Section entry." & vbNewLine & "Selected Sectiohn cannot be found in record.", vbCritical)
            Close()
            Exit Function
        End If

        'set form's text fields
        txtSectionID.Text = curSection.SectionID
        txtSectionFullTitle.Text = curSection.SectionTitle

        If GetCurriculumByID(curSection.CurriculumID, vCur) <> True Then
            'hide msg to user
            'record error
            CatchError("frmEditSection", "ShowForm", "Error: Acadmic Program By ID not found. " & vProg.ProgramCode)
            Exit Function
        End If
        txtAcademicProgram.Text = vCur.CurriculumCode


        'show form
        OK_Button.Text = "Update"

        Me.ShowDialog()

        'return
        ShowEdit = RecordEdited
    End Function
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Select Case OK_Button.Text
            Case "Save"
                If SaveData() = True Then 'added
                    MsgBox("CLASS SECTION Entry successfully added.", vbInformation)
                    RecordAdded = True

                    Close()
                End If
            Case Else
                UpdateData()
        End Select

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Function SaveData() As Boolean

        Dim newSection As tSection
        Dim vProg As tAcademicPrograms
        Dim vYearlevel As tYearLevel
        Dim vTeacher As tTeacher
        Dim Offer As tSubjectOffering

        'set default
        SaveData = False

        'validate date
        If Not ValidateData Then Exit Function


        'set rs field
        newSection.SectionID = txtSectionID.Text
        newSection.CampusID = cboCampus.SelectedItem.Col2
        newSection.TermID = cboTerm.SelectedItem.Col2
        newSection.SectionTitle = txtSectionFullTitle.Text
        newSection.ProgramID = ProgramID
        newSection.YearLevelID = vYearlevel.YearLevelID
        newSection.CurriculumID = txtCurriculumCode.Text
        newSection.CreationDate = DateTime.Now
        newSection.CreatedBy = CurrentUser.FullName
        newSection.Limit = 60
        newSection.YearLevelID = txtYearTermID.Text
        newSection.IsBlock = 1
        newSection.IsDissolved = 0
        newSection.IsEvening = 0

        If GetCollegeByProgramID(ProgramID, vCol) = TranDBResult.Success Then
            CollegeID = vCol.CollegeID
            newSection.CollegeID = CollegeID
        End If


        If cboRoom.Text = "" Then
            newSection.RoomID = ""
        Else
            newSection.RoomID = cboRoom.SelectedItem.Col2
        End If

        newSection.AdviserID = FacultyID

        'try

        Select Case AddSection(newSection)
            Case TranDBResult.Success
                'success
                '-------------------------------------

                For Each lv As ListViewItem In listAvailableSubjects.Items
                    Offer.SubjectOfferingID = DateTime.Now.Year & "-" & txtSectionID.Text & "-" & lv.SubItems(1).Text
                    Offer.SubjectID = lv.SubItems(1).Text
                    Offer.SectionID = txtSectionID.Text
                    Offer.TermID = cboTerm.SelectedItem.Col2
                    Offer.CreatedBy = CurrentUser.FullName
                    Offer.CreationDate = DateTime.Now.Date
                    Offer.Limit = 60

                    Select Case AddSubjectOffering(Offer)
                        Case TranDBResult.Success

                        Case TranDBResult.Failed
                            GoTo Failed
                    End Select

                Next
                SaveData = True
Failed:
                Exit Select

            Case TranDBResult.DuplicateID
                MsgBox("ID already existed.", vbExclamation)
                HLTxt(txtSectionID)
                SaveData = False
                Exit Select

            Case TranDBResult.DuplicateTitle
                MsgBox("Title already existed.", vbExclamation)
                HLTxt(txtSectionFullTitle)
                SaveData = False
                Exit Select

            Case TranDBResult.InvalidSectionCurriculumID
                MsgBox("Invalid Curriculum Code...", MsgBoxStyle.Exclamation)
                SaveData = False
                Exit Select

            Case TranDBResult.InvalidSectionProgramID
                MsgBox("Invalid Academic Program....", vbExclamation)
                SaveData = False
                Exit Select

            Case TranDBResult.InvalidSectionYearLevelID
                MsgBox("Invalid Year Term....", vbExclamation)
                SaveData = False
                Exit Select

            Case Else
                CatchError("frmAddSetion", "SaveData", "Unknown Error on Saving Section")
                SaveData = False
                Exit Select
        End Select
    End Function
    Private Sub UpdateData()
        Dim vProg As tAcademicPrograms
        Dim vYearlevel As tYearLevel
        Dim vTeacher As tTeacher

        If Len(txtSectionFullTitle.Text) < 1 Then
            MsgBox("Section Title must not be empty." & vbNewLine & _
                    "Please enter some value.", vbExclamation)
            Exit Sub
        End If

        If GetProgramByProgramCode(txtAcademicProgram.Text, vProg) <> TranDBResult.Success Then
            MsgBox("Invalid Academic Program Code", vbExclamation)
            HLTxt(txtAcademicProgram)
            Exit Sub
        End If


        'set section's fields
        curSection.SectionTitle = Trim(txtSectionFullTitle.Text)
        curSection.ProgramID = vProg.ProgID
        curSection.YearLevelID = vYearlevel.YearLevelID
        curSection.ModifiedBy = CurrentUser.FullName
        curSection.ModifiedDate = DateTime.Now



        'save
        Select Case EditSection(curSection)
            Case TranDBResult.Success
                MsgBox("Section entry successfully edited.", vbInformation)

                'set flag
                RecordEdited = True
                'close this form
                Close()

            Case TranDBResult.DuplicateTitle
                MsgBox("Section Title already exist. Please try another value.", vbExclamation)

                HLTxt(txtSectionFullTitle)

            Case Else
                MsgBox("Unable to update changes", vbCritical)

                CatchError("frmEditSection", "cmdSave_Click", "EditSection Return unknown error.")
        End Select
    End Sub


    Private Function ValidateData() As Boolean

        'default
        ValidateData = False

        Dim vProg As tAcademicPrograms

        'check id
        If Not CheckTextBox(txtsectionId, "Please Enter Section ID") Then
            Exit Function
        End If

        'check title
        If Not CheckTextBox(txtSectionFullTitle, "Unable to proceed...Please Enter Section Title") Then
            Exit Function
        End If


        'If GetProgramByProgramCode(txtAcademicProgram.Text, vProg) <> TranDBResult.Success Then
        '    MsgBox("Invalid Academic Program Code", vbExclamation)
        '    HLTxt(txtAcademicProgram)
        '    Exit Function
        'End If

        If cboCampus.Text = "" Then
            MsgBox("Please select Campus...", vbExclamation)
            Exit Function
        End If

        If cboTerm.Text = "" Then
            MsgBox("Please select Academic Year and Terms...", vbExclamation)
            Exit Function
        End If


        'return success
        ValidateData = True
    End Function
    Private Sub cmdGetItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetItem.Click
        If cboCampus.Text = "" Then
            MsgBox("Unable to load Academic Program records.. " & vbNewLine & "Please Select campus", vbExclamation)
            Exit Sub
        End If

        Dim frm As New PickAcademicPrograms()
        frm.GetAcademicProgram(cboCampus.SelectedItem.Col2, txtAcademicProgram.Text, ProgramID)

    End Sub

    Private Sub frmAddSection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillMultiColumnCombo2(cboTerm, "SELECT CONCAT(tblAYTerm.SchoolYear,' ',tblAYTerm.SchoolTerm) AS lvKey, tblAYTerm.TermID From tblAYTerm")
        fillMultiColumnCombo2(cboCampus, "SELECT ShortName,CampusID FROM tblCampus")
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        On Error Resume Next
        MsgBox("Created Date: " & curSection.CreationDate & vbNewLine & "Created By: " & curSection.CreatedBy & vbNewLine & "Last Modified Date: " & IIf(curSection.ModifiedDate = CDate("0"), "", curSection.ModifiedDate) & vbNewLine & _
                            "Last Modified By: " & curSection.ModifiedBy)
    End Sub

    Private Sub txtSectionFullTitle_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSectionFullTitle.TextChanged

    End Sub


    Private Sub txtAcademicProgram_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAcademicProgram.TextChanged
        If CurriculumExistByProgramID(ProgramID) = TranDBResult.Success Then
            FillListView("SELECT CurriculumCode,CurriculumID,fnProgramName(ProgramID),fnMajorName(MajorID) FROM tblcurriculum WHERE ProgramID='" & ProgramID & "'", lvCurriculum, False)
        Else
            MsgBox("The system found that the selected Academic Program has no Curriculum..." & vbNewLine & vbNewLine & "Please contact the Administrator for assistance", vbExclamation)
            Exit Sub
        End If

    End Sub

    Private Sub lvCurriculum_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvCurriculum.Click
        txtCurriculumCode.Text = lvCurriculum.FocusedItem.SubItems(1).Text
        FillListView("SELECT YearTermDesc,ID FROM tblYearLevelTerm", lvYearTerm, False)
    End Sub

    Private Sub lvYearTerm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvYearTerm.Click
        txtYearTermID.Text = lvYearTerm.FocusedItem.SubItems(1).Text

        FillListView("SELECT S.SubjectCode,S.SubjectID,S.Description, S.CreditUnits,S.LecHrs,S.LabUnits,S.LabHrs,S.MinSize,S.MaxSize FROM tblcurriculum AS C " & _
                        "INNER JOIN tblcurriculumdetails AS CD ON C.CurriculumID = CD.CurriculumID " & _
                        "INNER JOIN tblsubject AS S ON S.SubjectID = CD.SubjectID " & _
                        "WHERE CD.YearTermID='" & txtYearTermID.Text & "' AND C.ProgramID ='" & ProgramID & "' AND C.CurriculumID='" & txtCurriculumCode.Text & "'", listAvailableSubjects, False)

        lblSubjectCount.Text = listAvailableSubjects.Items.Count
    End Sub

    Private Sub cboCampus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCampus.SelectedIndexChanged
        If cboCampus.Text = "" Then Exit Sub

        fillMultiColumnCombo2(cboBuilding, "SELECT BldgName,BldgID FROM tblBuilding WHERE CampusID='" & cboCampus.SelectedItem.Col2 & "'")
    End Sub

    Private Sub cboBuilding_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBuilding.SelectedIndexChanged
        If cboBuilding.Text = "" Then Exit Sub

        fillMultiColumnCombo2(cboRoom, "SELECT Room,RoomID FROM tblRoom WHERE BldgID='" & cboBuilding.SelectedItem.Col2 & "'")
    End Sub

    Private Sub cmdGetTeacher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetTeacher.Click
        Dim frm As New PickTeacher()
        'frm.ShowDialog()
        frm.GetTeacherID(txtTeacherFullName.Text)
        FacultyID = frm.GetTeacherID
    End Sub
End Class
