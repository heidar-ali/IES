Imports System.Windows.Forms
Imports MySql.Data.MySqlClient


Public Class frmAddCurriculum

    Dim CurID As String
    Public ProgramID As String

    Dim RecordAdded As Boolean
    Dim RecordEdited As Boolean

    Dim newCur As tCurriculum


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

    Public Sub ShowForm(Optional ByVal Campus As String = "", Optional ByVal CampusID As String = "", _
                        Optional ByVal Program As String = "", Optional ByVal sProgramID As String = "")

        Dim camp As tSchool

        GetNewCurriculumID(CurID)

        cboCampus1.Visible = False

        If GetCampusByCampusID(CampusID, camp) = TranDBResult.Success Then
            cboCampus1.Text = camp.CampusName
            cboCampusID.Text = camp.CampusID
        End If

        txtProgram.Text = Program
        ProgramID = sProgramID

        Me.ShowDialog()
    End Sub

    Public Sub ShowEdit(ByVal sID As String)
        Dim vCur As tCurriculum
        Dim camp As tSchool

        cboCampus.Visible = False


        If GetCurriculumByID(sID, vCur) = TranDBResult.Success Then
            CurID = vCur.CurriculumID
            txtCurriculumCode.Text = vCur.CurriculumCode
            txtDescription.Text = vCur.Description
            txtNote.Text = vCur.Notes
            chkLocked.CheckState = IntToBoolean(vCur.IsLocked)

            'If GetCampusByCampusID(vCur., camp) = TranDBResult.Success Then
            '    cboCampus1.Text = camp.CampusName
            '    cboCampusID.Text = camp.CampusID
            'End If
        End If




        Me.ShowDialog()
    End Sub
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

            Case TranDBResult.DuplicateCode
                MsgBox("Curriculum Code already existed", vbExclamation)
                UpdateData = False

            Case TranDBResult.DuplicateID
                MsgBox("ID already existed.", vbExclamation)
                UpdateData = False

            Case TranDBResult.InvalidSubjectDepartmentID
                MsgBox("Invalid Department.", vbExclamation)
                HLTxt(txtProgram)
                UpdateData = False

            Case Else
                'fatal
                'temp
                MsgBox("Unknown Error.", vbExclamation)
                UpdateData = False
        End Select

    End Function

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

    Private Sub cmdGetDepartmentTitle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetProgram.Click
        Dim Prog As tAcademicPrograms

        If ProgramRecordExist(cboCampus.SelectedItem.Col2) <> TranDBResult.Success Then
            MsgBox("Unable to continue. There are no record yet in Academic Program Entries", vbExclamation)
            Exit Sub
        End If

        Dim frm As New PickAcademicPrograms()
        frm.GetAcademicProgram(cboCampus.SelectedItem.Col2, txtProgram.Text, ProgramID)

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
