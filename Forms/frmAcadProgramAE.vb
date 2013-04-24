Option Explicit On

Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data
Imports System.Diagnostics

Public Class frmAcadProgramAE

    Public ProgramAlias As String

    Dim ProgramID As String
    Dim State As FormState


#Region "ShowForm"
    Public Sub ShowForm()

        cboCampus.SelectedIndex = (ReadINI("Campus", "Campus", CONFIG_INI_FILE) - 1)

        GetNewProgramID(ProgramID)

        cmdSave.Text = "Save"

        cboCampus1.Visible = False
        cboCollege1.Visible = False
        cboStatus1.Visible = False
        cboTerm1.Visible = False
        cboClassification1.Visible = False


        State = FormState.addFormState

        Me.ShowDialog()
    End Sub
#End Region

#Region "ShowEdit"
    Public Sub ShowEdit(ByVal ProgID As String)

        Dim vProg As tAcademicPrograms
        Dim Board As tProgramBoardExam
        Dim Ladder As tProgramLadder
        Dim vClass As tProgramClass
        Dim Thes As tProgramThesis
        Dim Sem As tProgramSemester
        Dim Stat As tProgramStatus
        Dim Camp As tSchool
        Dim Col As tCollege
        Dim Maj As tMajorGroups

        cboCampus.Visible = False
        cboCollege.Visible = False
        cboClassification.Visible = False
        cboTerm.Visible = False
        cboStatus.Visible = False


        If GetProgramByProgramID(ProgID, vProg) = TranDBResult.Success Then

            txtAcadUnits.Text = vProg.TotalAcadSubject
            txtCreditUnits.Text = vProg.TotalCreditUnits
            txtElectiveUnits.Text = vProg.TotalElectiveUnits
            txtGenEdUnits.Text = vProg.TotalGenEdUnits
            txtLectureUnits.Text = vProg.TotalLectureUnits
            txtMajorUnits.Text = vProg.TotalMajorUnits
            txtMaxResidency.Text = vProg.MaxResidency
            txtNonLecUnits.Text = vProg.TotalNonLecUnits
            txtNoYears.Text = vProg.ProgramYears
            txtProgramCode.Text = vProg.ProgramCode
            txtProgramName.Text = vProg.ProgramName
            txtShortName.Text = vProg.ShortName
            txtWeight.Text = vProg.Weight

            ProgramID = vProg.ProgID
            ProgramAlias = vProg.Alias1

            If GetCampusByCampusID(vProg.CampusID, Camp) = TranDBResult.Success Then
                cboCampus1.Text = Camp.ShortName
                cboCampusID.Text = Camp.CampusID
            End If

            If GetCollegeByID(vProg.CollegeID, Col) = TranDBResult.Success Then
                cboCollege1.Text = Col.CollegeName
                cboCollegeID.Text = Col.CollegeID
            End If

            If GetProgramStatus(vProg.ProgStatus, Stat) = TranDBResult.Success Then
                cboStatus1.Text = Stat.StatusName
                cboStatusID.Text = Stat.StatusCode
            End If


            Select Case (vProg.ProgramSemester / vProg.ProgramYears)
                Case 2
                    cboTerm1.Text = "Semestral"
                    cboTermID.Text = YearTerm.Semestral
                Case 3
                    cboTerm1.Text = "Trimestral"
                    cboTermID.Text = YearTerm.Trimestral
                Case 1
                    cboTerm1.Text = "Yearly - High School"
                    cboTermID.Text = YearTerm.YearlyHS
            End Select

            '=========================== PROGRAM CLASS ====================================
            If GetProgramClass(vProg.Classification, vClass) = TranDBResult.Success Then
                cboClassification1.Text = vClass.ClassDesc
                cboClassificationID.Text = vClass.ClassCode
            End If

            '=========================== PROGRAM THESIS ===================================
            If GetProgramThesis(vProg.ThesisReqID, Thes) = TranDBResult.Success Then
                cboThesisOption.Text = Thes.ThesisReqDesc
                cboThesisID.Text = Thes.ThesisReqID
            End If

            '========================== PROGRAM BOARD EXAM ================================
            If GetProgramBoardExam(vProg.BoardExam, Board) = TranDBResult.Success Then
                cboBoardExam.Text = Board.BoardExamDesc
                cboBoardID.Text = vProg.BoardExam
            End If

            '========================== PROGRAM LADDER =====================================
            If GetProgramLadder(vProg.IsProgLadder, Ladder) Then
                cboLadder.Text = Ladder.LadderDesc
                cboLadderID.Text = Ladder.LadderCode
            End If

            '========================= PROGRAM PARENT ======================================
            If GetProgramByProgramID(vProg.ProgParent, vProg) = TranDBResult.Success Then
                cboParent.Text = vProg.ProgramCode
                cboParentID.Text = vProg.ProgID
            End If


            dtpRecognize.Text = vProg.ProgRecognize
            dtpRevise.Text = vProg.ProgRevise


            '========================= MAJOR DISCIPLINE CATEGORY =============================
            If GetMajorGroupByID(vProg.MajorDiscGroupCode, Maj) = TranDBResult.Success Then
                cboDiscipline.Text = Maj.Description
                cboDisciplineID.Text = Maj.GroupID
            End If

            FillMajorByGroup(cboDisciplineID.Text)

            Dim com As New MySqlCommand("SELECT MajorDiscID FROM tblProgramMajors WHERE ProgID ='" & vProg.ProgID & "'", clsCon.con)
            Dim DS As New DataSet
            Dim dA As New MySqlDataAdapter
            Dim i As Integer

            dA.SelectCommand = com
            dA.Fill(DS)

            For i = 0 To DS.Tables(0).Rows.Count - 1
                For a As Integer = 0 To dgMajor.RowCount - 1
                    If dgMajor.Item(4, a).Value.ToString() = DS.Tables(0).Rows(i).Item("MajorDiscID").ToString() Then
                        dgMajor.Item(2, a).Value = True
                    End If
                Next
            Next

        Else
            Exit Sub
        End If

        State = FormState.updateFormState

        Me.ShowDialog()

    End Sub
#End Region

#Region "FillMajorByGroup"
    Private Sub FillMajorByGroup(ByVal GroupID As String)
        Dim com As New MySqlCommand("SELECT tbldisciplinemajorgroups.MajorGroupCode,tbldisciplinemajorgroups.Description,tbldisciplinemajors.ID,tbldisciplinemajors.MajorDiscCode, tbldisciplinemajors.MajorDescription " & _
                                    "FROM tbldisciplinemajorgroups INNER JOIN tbldisciplinemajors ON tbldisciplinemajorgroups.ID = tbldisciplinemajors.MajorGroup WHERE tblDisciplineMajorGroups.ID='" & GroupID & "'", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        dgMajor.Rows.Clear()
        While vRS.Read()
            Dim n As Integer = dgMajor.Rows.Add()
            dgMajor.Rows(n).Cells(0).Value = vRS("MajorDiscCode").ToString()
            dgMajor.Rows(n).Cells(1).Value = vRS("MajorDescription").ToString()
            dgMajor.Rows(n).Cells(2).Value = False
            dgMajor.Rows(n).Cells(3).Value = False
            dgMajor.Rows(n).Cells(4).Value = vRS("ID").ToString()
        End While
        vRS.Close()
    End Sub
#End Region

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Close()
    End Sub

    Private Sub cboDiscipline_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDiscipline.SelectedIndexChanged
        cboDisciplineID.SelectedIndex = cboDiscipline.SelectedIndex
        FillMajorByGroup(cboDisciplineID.Text)
    End Sub

    Private Sub cboDisciplineID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDisciplineID.SelectedIndexChanged

    End Sub

    Private Sub frmAcadProgramAE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        fillMultiColumnCombo2(cboCampus, "SELECT ShortName,CampusID FROM tblCampus")
        fillCombo(cboCampusID, "SELECT CampusID FROM tblCampus")
        fillCombo(cboCampus1, "SELECT ShortName FROM tblCampus")

        fillMultiColumnCombo2(cboClassification, "SELECT ClassDesc,ClassCode FROM tblProgram_Class")
        fillCombo(cboClassificationID, "SELECT ClassCode FROM tblProgram_Class")
        fillCombo(cboClassification1, "SELECT ClassDesc FROM tblProgram_Class")

        fillCombo(cboBoardExam, "SELECT BoardExamDesc FROM tblProgram_BoardExam")
        fillCombo(cboBoardID, "SELECT BoardExamCode FROM tblProgram_BoardExam")

        fillCombo(cboLadder, "SELECT LadderDesc FROM tblProgram_Ladder")
        fillCombo(cboLadderID, "SELECT LadderCode FROM tblProgram_Ladder")

        fillCombo(cboThesisOption, "SELECT ThesisReqDesc FROM tblProgram_ThesisReq")
        fillCombo(cboThesisID, "SELECT ThesisReqID FROM tblProgram_ThesisReq")

        fillMultiColumnCombo3(cboTerm, "SELECT SemestralDesc,SemestralCode,NoOfTerm FROM tblProgram_Semestral WHERE InActive = 0")

        fillCombo(cboTermID, "SELECT SemestralCode FROM tblProgram_Semestral")
        fillCombo(cboTerm1, "SELECT SemestralDesc FROM tblProgram_Semestral")

        fillCombo(cboStatus1, "SELECT StatusName FROM tblProgram_Status")
        fillMultiColumnCombo2(cboStatus, "SELECT StatusName,StatusCode FROM tblProgram_Status")

        fillCombo(cboParent, "SELECT ProgName FROM tblPrograms")
        fillCombo(cboParentID, "SELECT ProgID FROM tblPrograms")

        fillCombo(cboDiscipline, "SELECT Description FROM tblDisciplineMajorGroups")
        fillCombo(cboDisciplineID, "SELECT ID  FROM tblDisciplineMajorGroups")

    End Sub

    Private Sub cboCampus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCampus.SelectedIndexChanged
        'cboCampusID.SelectedIndex = cboCampus.SelectedIndex
        fillMultiColumnCombo2(cboCollege, "SELECT CollegeName,CollegeID FROM tblColleges WHERE CampusID='" & cboCampus.SelectedItem.Col2 & "'")
    End Sub

    Private Sub cboCollege_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCollege1.SelectedValueChanged
        cboCollegeID.SelectedIndex = cboCollege1.SelectedIndex
    End Sub

    Private Sub cboStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'cboStatusID.SelectedIndex = cboStatus1.SelectedIndex
    End Sub

    Private Sub cboTerm_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'cboTermID.SelectedIndex = cboTerm.SelectedIndex
    End Sub

    Private Sub cboClassification_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboClassification1.SelectedIndexChanged
        cboClassificationID.SelectedIndex = cboClassification1.SelectedIndex
    End Sub

    Private Sub cboThesisOption_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboThesisOption.SelectedIndexChanged
        cboThesisID.SelectedIndex = cboThesisOption.SelectedIndex
    End Sub

    Private Sub cboBoardExam_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBoardExam.SelectedIndexChanged
        cboBoardID.SelectedIndex = cboBoardExam.SelectedIndex
    End Sub

    Private Sub cboLadder_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLadder.SelectedIndexChanged
        cboLadderID.SelectedIndex = cboLadder.SelectedIndex
    End Sub

    Private Sub cboParent_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboParent.SelectedIndexChanged
        cboParentID.SelectedIndex = cboParent.SelectedIndex
    End Sub

#Region "SaveData"
    Private Function SaveData() As Boolean
        Dim vProg As tAcademicPrograms

        SaveData = False

        If cboCampus.Text = "" Then Exit Function
        If cboCollege.Text = "" Then Exit Function
        If cboStatus.Text = "" Then Exit Function
        If cboTerm.Text = "" Then Exit Function

        If cboDiscipline.Text = "" Then Exit Function

        If Not CheckTextBox(txtProgramCode, "Please Enter Program Code", True) Then HLTxt(txtProgramCode) : Exit Function

        If Not CheckTextBox(txtProgramName, "Please Enter Program Name", True) Then HLTxt(txtProgramName) : Exit Function

        If Not CheckTextBox(txtShortName, "Please Enter Program Short Name", True) Then HLTxt(txtShortName) : Exit Function

        If Not CheckTextBox(txtNoYears, "Please enter No. of Years", True) Then HLTxt(txtNoYears) : Exit Function

        If Not CheckTextBox(txtMaxResidency, "Please enter Maximum Residency", True) Then HLTxt(txtMaxResidency) : Exit Function

        If Val(txtNoYears.Text) < 1 Then MsgBox("No. of Years must be greater than zero (0)") : Exit Function

        If Val(txtMaxResidency.Text) < 1 Then MsgBox("Please enter Maximum residency") : Exit Function


        vProg.ProgID = ProgramID
        vProg.ProgramCode = txtProgramCode.Text
        vProg.ProgramName = txtProgramName.Text
        vProg.ShortName = txtShortName.Text
        vProg.CampusID = cboCampus.SelectedItem.Col2
        vProg.CollegeID = cboCollege.SelectedItem.Col2
        vProg.Alias1 = ProgramAlias
        vProg.ProgramYears = (txtNoYears.Text)
        vProg.MaxResidency = (txtMaxResidency.Text)
        vProg.BoardExam = (cboBoardID.Text)
        vProg.IsProgLadder = (cboLadderID.Text)
        vProg.TotalAcadSubject = (txtAcadUnits.Text)
        vProg.TotalCreditUnits = (txtCreditUnits.Text)
        vProg.TotalElectiveUnits = (txtElectiveUnits.Text)
        vProg.TotalGenEdUnits = (txtGenEdUnits.Text)
        vProg.TotalLectureUnits = (txtLectureUnits.Text)
        vProg.TotalMajorUnits = (txtMajorUnits.Text)
        vProg.TotalNonLecUnits = (txtNonLecUnits.Text)
        vProg.Weight = (txtWeight.Text)
        vProg.ProgParent = (cboParentID.Text)
        vProg.Classification = (cboClassification.SelectedItem.Col2)
        vProg.ThesisReqID = (cboThesisID.Text)
        vProg.ProgStatus = cboStatus.SelectedItem.Col2
        vProg.MajorDiscGroupCode = cboDisciplineID.Text
        vProg.ProgDiscipline = cboDisciplineID.Text
        vProg.Semestral = "1"

        vProg.ProgRecognize = dtpRecognize.Value.Date
        vProg.ProgRevise = dtpRevise.Value.Date

        vProg.ProgramSemester = cboTerm.SelectedItem.Col3 * Val(txtNoYears.Text)



        Select Case AddAcademicProgram(vProg)

            Case TranDBResult.Success

                For i As Integer = 0 To dgMajor.RowCount - 1
                    If BooleanToInt(dgMajor.Item(2, i).Value.ToString()) = 1 Then
                        Dim com As New MySqlCommand("INSERT INTO tblProgramMajors(ProgID,MajorDiscID,InActive) VALUES('" & vProg.ProgID & "','" & _
                                  dgMajor.Item(4, i).Value.ToString() & "','" & BooleanToInt(dgMajor.Item(3, i).Value.ToString()) & "')", clsCon.con)
                        com.ExecuteNonQuery()
                    End If
                Next

                MsgBox("Record successfully saved", vbInformation)
                SaveData = True
                Close()

            Case TranDBResult.DuplicateID
                MsgBox("Unable to save record..." & vbNewLine & " Duplicate Academic Program ID found", vbExclamation)
                Exit Function
            Case TranDBResult.DuplicateCode
                MsgBox("Unable to save record..." & vbNewLine & " Duplicate Academic Program Code found", vbExclamation)
                HLTxt(txtProgramCode)
                Exit Function
            Case TranDBResult.Failed
                CatchError("modDBAcademicProgramMajors", "AddAcademicProgram()", "Unknown Error")
                Exit Function
        End Select
    End Function
#End Region

#Region "SaveProgramMajors"
    Private Function SaveProgramMajors(ByVal sProgID As String) As Boolean
        Dim vMajor As tProgramMajors

        SaveProgramMajors = True

        For i As Integer = 0 To dgMajor.RowCount - 1
            If CBool(dgMajor.Item(2, i).Value.ToString()) = True Then
                'GetNewProgramMajorID(vMajor.ID)

                vMajor.ProgID = sProgID
                vMajor.MajorDiscID = dgMajor.Item(4, i).Value.ToString()
                vMajor.InActive = "0"

                If AddProgramMajors(vMajor) <> TranDBResult.Success Then
                    SaveProgramMajors = False
                End If
            End If
        Next
    End Function
#End Region

    Private Sub cmdProgAlias_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles cmdProgAlias.LinkClicked
        If Not CheckTextBox(txtProgramCode, "Sorry unable to proceed... " & vbNewLine & "No Academic Program") Then Exit Sub

        Dim frm As New frmAcadProgramAlias()
        'If frm.isValid = False Then Exit Sub
        frm.ShowDialog()
        ProgramAlias = frm.getAlias()

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Select Case State
            Case FormState.updateFormState
                Debug.Print("FormState.updateFormState")
                UpdateData()
            Case FormState.addFormState
                Debug.Print("FormState.addFormState")
                SaveData()
        End Select
    End Sub

#Region "UpdateData"
    Private Function UpdateData() As Boolean
        Dim vProg As tAcademicPrograms

        UpdateData = False

        If cboCampus1.Text = "" Then Exit Function
        If cboCollege1.Text = "" Then Exit Function
        If cboStatus1.Text = "" Then Exit Function
        If cboTerm1.Text = "" Then Exit Function

        If cboDiscipline.Text = "" Then Exit Function

        If Not CheckTextBox(txtProgramCode, "Please Enter Program Code", True) Then HLTxt(txtProgramCode) : Exit Function

        If Not CheckTextBox(txtProgramName, "Please Enter Program Name", True) Then HLTxt(txtProgramName) : Exit Function

        If Not CheckTextBox(txtShortName, "Please Enter Program Short Name", True) Then HLTxt(txtShortName) : Exit Function

        If Not CheckTextBox(txtNoYears, "Please enter No. of Years", True) Then HLTxt(txtNoYears) : Exit Function

        If Not CheckTextBox(txtMaxResidency, "Please enter Maximum Residency", True) Then HLTxt(txtMaxResidency) : Exit Function

        If Val(txtNoYears.Text) < 1 Then MsgBox("No. of Years must be greater than zero (0)") : Exit Function

        If Val(txtMaxResidency.Text) < 1 Then MsgBox("Please enter Maximum residency") : Exit Function

        vProg.ProgID = ProgramID
        vProg.ProgramCode = txtProgramCode.Text
        vProg.ProgramName = txtProgramName.Text
        vProg.ShortName = txtShortName.Text
        vProg.CampusID = cboCampusID.Text
        vProg.CollegeID = cboCollegeID.Text
        vProg.Alias1 = ProgramAlias
        vProg.ProgramYears = (txtNoYears.Text)
        vProg.MaxResidency = (txtMaxResidency.Text)
        vProg.BoardExam = (cboBoardID.Text)
        vProg.IsProgLadder = (cboLadderID.Text)
        vProg.TotalAcadSubject = (txtAcadUnits.Text)
        vProg.TotalCreditUnits = (txtCreditUnits.Text)
        vProg.TotalElectiveUnits = (txtElectiveUnits.Text)
        vProg.TotalGenEdUnits = (txtGenEdUnits.Text)
        vProg.TotalLectureUnits = (txtLectureUnits.Text)
        vProg.TotalMajorUnits = (txtMajorUnits.Text)
        vProg.TotalNonLecUnits = (txtNonLecUnits.Text)
        vProg.Weight = (txtWeight.Text)
        vProg.ProgParent = (cboParentID.Text)
        vProg.Classification = (cboClassificationID.Text)
        vProg.ThesisReqID = (cboThesisID.Text)
        vProg.ProgStatus = cboStatusID.Text
        vProg.MajorDiscGroupCode = cboDisciplineID.Text
        vProg.ProgDiscipline = cboDisciplineID.Text
        vProg.ProgramSemester = cboTermID.Text * Val(txtNoYears.Text)

        Select Case (vProg.ProgramSemester / vProg.ProgramYears)
            Case 2
              vProg.Semestral = "1"
            Case 3
                vProg.Semestral = "0"
            Case 1
                vProg.Semestral = "0"
        End Select

        Select Case EditAcademicProgram(vProg)

            Case TranDBResult.Success
                For i As Integer = 0 To dgMajor.RowCount - 1
                    If CBool(dgMajor.Item(2, i).Value.ToString()) Then
                        If AcademicProgramMajorsExistByID(vProg.ProgID, dgMajor.Item(4, i).Value.ToString()) <> TranDBResult.Success Then
                            Dim com As New MySqlCommand("INSERT INTO tblProgramMajors(ProgID,MajorDiscID,InActive) VALUES('" & vProg.ProgID & "','" & _
                                 dgMajor.Item(4, i).Value.ToString() & "','" & BooleanToInt(dgMajor.Item(3, i).Value.ToString()) & "')", clsCon.con)
                            com.ExecuteNonQuery()

                        Else
                            Dim com1 As New MySqlCommand("UPDATE tblProgramMajors Set InActive ='" & BooleanToInt(dgMajor.Item(3, i).Value.ToString()) & _
                                                         "' WHERE ProgID='" & vProg.ProgID & "' AND MajorDiscID='" & dgMajor.Item(4, i).Value.ToString() & "'", clsCon.con)
                            com1.ExecuteNonQuery()
                        End If
                    Else
                        If AcademicProgramMajorsExistByID(vProg.ProgID, dgMajor.Item(4, i).Value.ToString()) = TranDBResult.Success Then
                            Dim com As New MySqlCommand("DELETE FROM tblProgramMajors WHERE ProgID='" & vProg.ProgID & "' AND MajorDiscID='" & dgMajor.Item(4, i).Value.ToString() & "'", clsCon.con)
                            com.ExecuteNonQuery()
                        End If
                    End If
                Next

                MsgBox("Record successfully saved", vbInformation)
                UpdateData = True
                Close()

            Case TranDBResult.Failed
                CatchError("modDBAcademicProgramMajors", "EditAcademicProgram()", "Unknown Error")
                Exit Function
        End Select
    End Function
#End Region

    Private Sub cboCampus1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCampus1.SelectedIndexChanged
        cboCampusID.SelectedIndex = cboCampus.SelectedIndex
        fillCombo(cboCollege1, "SELECT CollegeName,CollegeID FROM tblColleges WHERE CampusID='" & cboCampusID.Text & "'")
    End Sub

    Private Sub cboStatus1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboStatus1.SelectedIndexChanged
        'cboStatusID.SelectedIndex = cboStatus1.SelectedIndex
    End Sub
End Class