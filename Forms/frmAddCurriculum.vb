Imports System.Windows.Forms
Imports MySql.Data.MySqlClient


Public Class frmAddCurriculum

    Dim CurID As String
    Public ProgramID As String

    Dim RecordAdded As Boolean
    Dim RecordEdited As Boolean

    Dim newCur As tCurriculum

    Dim State As FormState


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Select Case cmdSave.Text
            Case "Update"
                If UpdateData() Then 'Edited
                    RecordEdited = True
                    Close()
                End If
            Case Else
                If SaveData() Then 'added
                    RecordAdded = True
                    Close()
                End If
        End Select
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub

#Region "ShowForm"
    Public Sub ShowForm(Optional ByVal Campus As String = "", Optional ByVal CampusID As String = "", _
                        Optional ByVal Program As String = "", Optional ByVal sProgramID As String = "")

        Dim camp As tSchool

        GetNewCurriculumID(CurID)

        cboCampus1.Visible = False

        'cboCampus.SelectedValue.Contains(ReadINI("Campus", "Campus", CONFIG_INI_FILE))
        If Not cboCampus.ItemSelect(2, ReadINI("Campus", "Campus", CONFIG_INI_FILE), False, True) Then
            cboCampus.SelectedIndex = -1
        End If

        If GetCampusByCampusID(CampusID, camp) = TranDBResult.Success Then
            cboCampus1.Text = camp.CampusName
            cboCampusID.Text = camp.CampusID
        End If

        txtProgram.Text = Program
        ProgramID = sProgramID

        State = FormState.addFormState

        Me.ShowDialog()
    End Sub
#End Region

#Region "ShowEdit"
    Public Sub ShowEdit(ByVal sID As String, ByVal Campus As String, ByVal CampusID As String, _
                        Optional ByVal Program As String = "", Optional ByVal sProgramID As String = "")


        Dim vCur As tCurriculum
        Dim camp As tSchool
        Dim vMajor As tMajors

        cboCampus.Visible = True

        fillComboAcademicMajors(cboMajor, "SELECT tbldisciplinemajors.MajorDescription " & _
                                     "FROM tblprograms INNER JOIN   tblprogrammajors ON tblprograms.ProgID = tblprogrammajors.ProgID INNER JOIN tbldisciplinemajors ON tblprogrammajors.MajorDiscID = tbldisciplinemajors.ID " & _
                                     "WHERE tblPrograms.ProgID='" & sProgramID & "'")

        fillComboAcademicMajors(cboMajorID, "SELECT tbldisciplinemajors.ID " & _
                                "FROM tblprograms INNER JOIN   tblprogrammajors ON tblprograms.ProgID = tblprogrammajors.ProgID INNER JOIN tbldisciplinemajors ON tblprogrammajors.MajorDiscID = tbldisciplinemajors.ID " & _
                                "WHERE tblPrograms.ProgID='" & sProgramID & "'")


        If GetCurriculumByID(sID, vCur) = TranDBResult.Success Then
            CurID = vCur.CurriculumID
            txtCurriculumCode.Text = vCur.CurriculumCode
            txtDescription.Text = vCur.Description
            txtNote.Text = vCur.Notes
            chkLocked.CheckState = IntToBoolean(vCur.IsLocked)

        End If

        If GetCampusByCampusID(CampusID, camp) = TranDBResult.Success Then
            cboCampus1.Text = camp.CampusName
            cboCampusID.Text = camp.CampusID
        End If

        txtProgram.Text = Program
        ProgramID = sProgramID

      
        If GetProgramMajorsByCurriculumProgramID(sProgramID, vCur.MajorID, vMajor) = TranDBResult.Success Then
            cboMajor.Text = vMajor.MajorDescription
            cboMajorID.Text = vMajor.MajorID
        End If

        State = FormState.updateFormState

        Me.ShowDialog()

    End Sub
#End Region

#Region "UpdateData"
    Private Function UpdateData() As Boolean
        Dim vDepartment As tDepartment
        Dim newCur As tCurriculum

        UpdateData = False

        If Not ValidateData() Then Exit Function

        If GetDepartmentByTitle(txtProgram.Text, vDepartment) <> TranDBResult.Success Then
            MsgBox("Invalid Department Title", vbExclamation)
            HLTxt(txtProgram)
            Exit Function
        End If

        newCur.CurriculumID = CurID
        newCur.CurriculumCode = txtCurriculumCode.Text
        newCur.MajorID = cboMajorID.Text
        newCur.Description = txtDescription.Text
        newCur.Notes = txtNote.Text
        newCur.IsLocked = BooleanToInt(chkLocked.Text)

        If chkLocked.Checked = True Then
            newCur.DateLocked = Now()
        Else
            newCur.DateLocked = ""
        End If

        newCur.CreatedBy = CurrentUser.FullName
        newCur.CreationDate = Now()

        Select Case EditCurriculum(newCur)
            Case TranDBResult.Success
                'success
                '-------------------------------------
                MsgBox("Curriculum Entry successfully Edited.", vbInformation)
                UpdateData = True

            Case Else
                'fatal
                'temp
                MsgBox("Unknown Error.", vbExclamation)
                UpdateData = False
        End Select

    End Function
#End Region

#Region "SaveData"
    Private Function SaveData() As Boolean
        Dim vDepartment As tDepartment

        If Not ValidateData() Then Exit Function

        SaveData = False

        newCur.CurriculumID = CurID
        newCur.CurriculumCode = txtCurriculumCode.Text
        newCur.ProgramID = ProgramID
        newCur.MajorID = cboMajorID.Text
        newCur.Description = txtDescription.Text
        newCur.Notes = txtNote.Text
        newCur.IsLocked = BooleanToInt(chkLocked.CheckState)

        If chkLocked.Checked = True Then
            newCur.DateLocked = Now()
        End If

        newCur.CreatedBy = CurrentUser.FullName
        newCur.CreationDate = Now()

        Select Case AddCurriculum(newCur)
            Case TranDBResult.Success
                'success
                '-------------------------------------
                MsgBox("Curriculum Entry successfully added.", vbInformation)
                SaveData = True

            Case TranDBResult.DuplicateCode
                MsgBox("Curriculum Code already existed", vbExclamation)
                SaveData = False

            Case TranDBResult.DuplicateID
                MsgBox("ID already existed.", vbExclamation)
                SaveData = False

            Case TranDBResult.InvalidSubjectDepartmentID
                MsgBox("Invalid Department.", vbExclamation)
                HLTxt(txtProgram)
                SaveData = False

            Case Else
                'fatal
                'temp
                MsgBox("Unknown Error.", vbExclamation)
                SaveData = False
        End Select
    End Function
#End Region

#Region "ValidateData"
    Public Function ValidateData() As Boolean
        ValidateData = False

        If Not CheckTextBox(txtCurriculumCode, "Please enter Curriculum Code") Then
            Exit Function
        End If

        If Not CheckTextBox(txtDescription, "Please enter Curriculum Description") Then
            Exit Function
        End If

        If Not CheckTextBox(txtProgram, "Please enter Academic Program Name") Then
            Exit Function
        End If

        If ProgramExistByID(ProgramID) <> TranDBResult.Success Then
            MsgBox("Invalid Academic Program Or " & vbNewLine & " Academic Program does not exists", vbExclamation)
            HLTxt(txtProgram)
            Exit Function
        End If

        ValidateData = True
    End Function
#End Region

    Private Sub cmdGetDepartmentTitle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetProgram.Click
        Dim Prog As tAcademicPrograms
        Dim AcademicProgram, AcadProgramID, TextObject, sProgramCode As String


        Dim frm As New PickAcademicPrograms()

        Select Case State
            Case FormState.addFormState
                If ProgramRecordExist(cboCampus.SelectedItem.Col2) <> TranDBResult.Success Then
                    MsgBox("Unable to continue. There are no record yet in Academic Program Entries", vbExclamation)
                    Exit Sub
                End If

                frm.GetAcademicProgram(cboCampus.SelectedItem.Col2, TextObject, AcadProgramID)

            Case FormState.updateFormState
                If ProgramRecordExist(cboCampusID.Text) <> TranDBResult.Success Then
                    MsgBox("Unable to continue. There are no record yet in Academic Program Entries", vbExclamation)
                    Exit Sub
                End If

                frm.GetAcademicProgram(cboCampusID.Text, TextObject, AcadProgramID)
        End Select

        If Len(TextObject) > 0 Then
            txtProgram.Text = TextObject
        End If

        If Len(AcadProgramID) > 0 Then
            ProgramID = AcadProgramID
        End If


        If ProgramID <> "" Then

            GetProgramTerms(ProgramID)

            fillComboAcademicMajors(cboMajor, "SELECT tbldisciplinemajors.MajorDescription " & _
                                        "FROM tblprograms INNER JOIN   tblprogrammajors ON tblprograms.ProgID = tblprogrammajors.ProgID INNER JOIN tbldisciplinemajors ON tblprogrammajors.MajorDiscID = tbldisciplinemajors.ID " & _
                                        "WHERE tblPrograms.ProgID='" & ProgramID & "'")

            fillComboAcademicMajors(cboMajorID, "SELECT tbldisciplinemajors.ID " & _
                                    "FROM tblprograms INNER JOIN   tblprogrammajors ON tblprograms.ProgID = tblprogrammajors.ProgID INNER JOIN tbldisciplinemajors ON tblprogrammajors.MajorDiscID = tbldisciplinemajors.ID " & _
                                    "WHERE tblPrograms.ProgID='" & ProgramID & "'")
        End If
    End Sub

    Private Sub frmAddCurriculum_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillMultiColumnCombo2(cboCampus, "SELECT ShortName,CampusID FROM tblCampus")
        fillCombo(cboCampus1, "SELECT CampusName FROM tblCampus")
        fillCombo(cboCampusID, "SELECT CampusID FROM tblCampus")
    End Sub

    Private Sub cboMajor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMajor.SelectedIndexChanged
        If cboMajor.SelectedIndex > 0 Then
            cboMajorID.SelectedIndex = cboMajor.SelectedIndex
        Else
            cboMajorID.Text = 0
        End If
    End Sub

    Private Sub cboCampus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cboCampusID.SelectedIndex = cboCampus1.SelectedIndex
    End Sub


    Private Sub GetProgramTerms(ByVal ProgramID As String)
        Dim com As New MySqlCommand("SELECT tblprogram_semestral.SemestralDesc, tblprograms.ProgYears, tblprograms.ProgSems " & _
                                    "FROM tblprogram_semestral INNER JOIN tblprograms ON tblprogram_semestral.SemestralCode = tblprograms.Semestral " & _
                                    "WHERE tblPrograms.ProgID='" & ProgramID & "'", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            lblTerm.Text = vRS("SemestralDesc").ToString()
            lblTotalYears.Text = vRS("ProgSems").ToString()
            lblYears.Text = vRS("ProgYears").ToString()
        End If
        vRS.Close()
    End Sub
End Class
