Option Explicit On

Imports System.Windows.Forms
Imports System.Diagnostics

Public Class frmMajorDisciplineAE

    Dim MajorID As String
    Dim State As FormState

    Public Sub ShowForm()

        GetNewMajorID(MajorID)

        OK_Button.Text = "Save"

        State = FormState.addFormState

        Me.ShowDialog()
    End Sub

    Public Sub ShowEdit(ByVal ID As String)
        Dim Maj As tMajors
        Dim MajGrp As tMajorGroups

        If GetMajorByMajorID(ID, Maj) = TranDBResult.Success Then
            txtCode.Text = Maj.MajorDiscCode
            txtMajor.Text = Maj.MajorDescription
            cboGroupID.Text = Maj.MajorGroup
            MajorID = Maj.MajorID

            GetMajorGroupByID(Maj.MajorGroup, MajGrp)

            cboMajorGroup.Text = MajGrp.Description

            Debug.Print("cboGroupID: " & Maj.MajorGroup)

            State = FormState.updateFormState
        End If

        Me.ShowDialog()
    End Sub


    Private Function SaveData() As Boolean
        Dim vMajor As tMajors

        SaveData = False

        If Not CheckTextBox(txtMajor, "Please enter Major Discipline") Then Exit Function

        If Not CheckTextBox(txtCode, "Please enter Major Discipline Code") Then Exit Function

        vMajor.MajorID = MajorID
        vMajor.MajorDiscCode = txtCode.Text
        vMajor.MajorDescription = txtMajor.Text
        vMajor.MajorGroup = CInt(cboGroupID.Text)

        Select Case AddMajorDiscipline(vMajor)
            Case TranDBResult.Success
                SaveData = True
                MsgBox("Record Successfully Saved", vbInformation)
                Close()

            Case TranDBResult.DuplicateCode
                MsgBox("Unable to saved. Duplicate Major Discipline Code found", vbExclamation)
                HLTxt(txtCode)

            Case TranDBResult.DuplicateID
                CatchError("modAcademicPrograms", "GetNewMajorID", "Unable to saved. Duplicate Major ID found")

            Case TranDBResult.Failed
                CatchError("modAcademicPrograms", "AddMajorDiscipline()", "Unable to saved. Duplicate Major ID found")

        End Select

    End Function

    Private Function UpdateData() As Boolean
        Dim vMajor As tMajors

        UpdateData = False

        If Not CheckTextBox(txtMajor, "Please enter Major Discipline") Then Exit Function

        If Not CheckTextBox(txtCode, "Please enter Major Discipline Code") Then Exit Function

        vMajor.MajorID = MajorID
        vMajor.MajorDiscCode = txtCode.Text
        vMajor.MajorDescription = txtMajor.Text
        vMajor.MajorGroup = CInt(cboGroupID.Text)

        Select Case EditMajorDiscipline(vMajor)
            Case TranDBResult.Success
                UpdateData = True
                MsgBox("Record Successfully Updated", vbInformation)
                Close()

            Case TranDBResult.DuplicateCode
                MsgBox("Unable to saved. Duplicate Major Discipline Code found", vbExclamation)
                HLTxt(txtCode)

            Case TranDBResult.DuplicateID
                CatchError("modAcademicPrograms", "GetNewMajorID", "Unable to saved. Duplicate Major ID found")

            Case TranDBResult.Failed
                CatchError("modAcademicPrograms", "AddMajorDiscipline()", "Unable to saved. Duplicate Major ID found")

        End Select

    End Function

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Select Case State
            Case FormState.updateFormState
                UpdateData()
            Case FormState.addFormState
                SaveData()
        End Select
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmMajorDisciplineAE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillCombo(cboGroupID, "SELECT ID FROM tblDisciplineMajorGroups")
        fillCombo(cboMajorGroup, "SELECT Description FROM tblDisciplineMajorGroups")
    End Sub

    Private Sub cboMajorGroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMajorGroup.SelectedIndexChanged
        cboGroupID.SelectedIndex = cboMajorGroup.SelectedIndex
    End Sub
End Class
