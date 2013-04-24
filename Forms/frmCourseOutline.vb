Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class frmCourseOutline
    Dim CurriculumCode As String

    Public Sub ShowForm(ByVal Program As String, Optional ByVal sCurriculumCode As String = "")

        CurriculumCode = sCurriculumCode
        lblProgram.Text = Program

        Me.ShowDialog()
    End Sub

    Private Sub frmCourseOutline_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        fillCombo(cboYearTerm, "SELECT YearTermDesc FROM tblYearLevelTerm")
        fillCombo(cboTermID, "SELECT ID FROM tblYearLevelTerm")
        fillCombo(cboYearLevel, "SELECT YearLevelID FROM tblYearLevelTerm")

    End Sub

    Private Sub cboYearTerm_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboYearTerm.SelectedIndexChanged
        cboTermID.SelectedIndex = cboYearTerm.SelectedIndex
        cboYearLevel.SelectedIndex = cboYearTerm.SelectedIndex
        LoadOutlineByProgram(cboTermID.Text, CurriculumCode)
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Close()
    End Sub

    Private Sub cmdGetProgram_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetProgram.Click
        Dim vSubj As tSubject

        Dim frm As New PickSubject()
        frm.GetSubjectTitle(txtSubjectCode.Text, txtDescriptive.Text, txtSubjectID.Text)

        If GetSubjectBySubjectCode(txtSubjectCode.Text, vSubj) <> TranDBResult.Success Then
            Exit Sub
        End If

        lblLabUnit.Text = vSubj.LabUnits
        lblLecUnit.Text = vSubj.Units
        lblCreditUnit.Text = vSubj.CreditUnits

    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        txtSubjectCode.Text = ""
        txtDescriptive.Text = ""
        txtSubjectID.Text = ""
        lblCreditUnit.Text = "0"
        lblLabUnit.Text = "0"
        lblLecUnit.Text = "0"
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim vDetails As tCurriculumDetails
        Dim vSubject As tSubject

        If cboTermID.Text = "" Or cboYearTerm.Text = "" Then
            MsgBox("Unable to continue saving. " & vbNewLine & "Please select Year/Term ", vbExclamation)
            Exit Sub
        End If

        'GetNewCurriculumDetailsID(vDetails.ID)
        vDetails.CurriculumID = CurriculumCode
        vDetails.SubjectID = txtSubjectID.Text
        vDetails.YearTermID = cboTermID.Text
        vDetails.YearStandingID = cboYearLevel.Text
        vDetails.EquivalentSubjectID = "0"

        Select Case AddCurriculumDetails(vDetails)

            Case TranDBResult.Success
                LoadOutlineByProgram(cboTermID.Text, CurriculumCode)
                cmdNew_Click(sender, e)
                Exit Sub

            Case TranDBResult.DuplicateID
                MsgBox("Subject already offered or existed in this course", vbExclamation)
                cmdNew_Click(sender, e)
                Exit Sub

        End Select

    End Sub

    Private Sub LoadOutlineByProgram(ByVal TermID As String, ByVal CurriculumCode As String)
        Dim com As New MySqlCommand("SELECT tblcurriculumdetails.CurriculumID, tblsubject.SubjectCode, tblsubject.Description, tblsubject.Units, tblsubject.CreditUnits, tblsubject.LabUnits, tblyearlevelterm.YearTermDesc,tblYearLevelTerm.ID " & _
                                    "FROM tblcurriculumdetails INNER JOIN tblsubject ON tblcurriculumdetails.SubjectID = tblsubject.SubjectID INNER JOIN tblyearlevelterm ON tblcurriculumdetails.YearTermID = tblyearlevelterm.ID " & _
                                    "WHERE tblYearLevelTerm.ID = '" & TermID & "' AND tblCurriculumDetails.CurriculumID='" & CurriculumCode & "'", clsCon.con)
        Dim dr As MySqlDataReader = com.ExecuteReader()
        dgOutLine.Rows.Clear()
        While dr.Read()
            Dim n As Integer = dgOutLine.Rows.Add()
            dgOutLine.Rows(n).Cells(0).Value = dr("SubjectCode").ToString()
            dgOutLine.Rows(n).Cells(1).Value = dr("Description").ToString()
            dgOutLine.Rows(n).Cells(2).Value = dr("LabUnits").ToString()
            dgOutLine.Rows(n).Cells(3).Value = dr("Units").ToString()
            dgOutLine.Rows(n).Cells(4).Value = dr("CreditUnits").ToString()
            dgOutLine.FirstDisplayedScrollingRowIndex = n
            dgOutLine.CurrentCell = dgOutLine.Rows(n).Cells(0)
            dgOutLine.Rows(n).Selected = True

            lblSubjectCount.Text = dgOutLine.Rows.Count & " Subject(s)"
        End While
        dr.Close()

        Dim com1 As New MySqlCommand("CALL GetTotalCurriculumUnits('" & TermID & "','" & CurriculumCode & "')", clsCon.con)
        Dim vRS As MySqlDataReader = com1.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            lblTotalLecUnit.Text = vRS("LecUnits").ToString()
            lblTotalLabUnits.Text = vRS("LabUnits").ToString()
            lblTotalCreditUnit.Text = vRS("CreditUnits").ToString()
        End If
        vRS.Close()
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim n As Integer = dgOutLine.CurrentRow.Index
        ExecuteDeleteCurriculumSubject(txtSubjectID.Text, CurriculumCode, dgOutLine.Rows(n).Cells(0).Value.ToString() & "-" & dgOutLine.Rows(n).Cells(1).Value.ToString())

        cmdRefresh_Click(sender, e)
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        LoadOutlineByProgram(cboTermID.Text, CurriculumCode)
    End Sub

    Private Sub dgOutLine_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgOutLine.CellClick
        Dim SUV As tSubject
        If dgOutLine.RowCount > 0 Then
            Dim n As Integer = dgOutLine.CurrentRow.Index

            If GetSubjectBySubjectCode(dgOutLine.Rows(n).Cells(0).Value.ToString(), SUV) = TranDBResult.Success Then
                txtSubjectID.Text = SUV.SubjectID
            End If

        End If
    End Sub

    Private Sub dgOutLine_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgOutLine.KeyDown
        If e.KeyCode = Keys.Delete Then
            cmdDelete_Click(sender, e)

            cmdRefresh_Click(sender, e)
        End If
    End Sub
End Class