Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Diagnostics

Public Class frmCourseOutline
    Dim CurriculumCode As String

    Public Sub ShowForm(ByVal Program As String, Optional ByVal sCurriculumCode As String = "")

        CurriculumCode = sCurriculumCode
        Debug.Print("CurriculumCode: " & CurriculumCode)

        lblProgram.Text = Program

        Me.ShowDialog()
    End Sub

    Private Sub frmCourseOutline_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        fillCombo(cboYearTerm, "SELECT YearTermDesc FROM tblYearLevelTerm")
        fillCombo(cboTermID, "SELECT ID FROM tblYearLevelTerm")
        fillCombo(cboYearLevel, "SELECT YearLevelID FROM tblYearLevelTerm")

        FillSubject()

    End Sub


    Private Sub FillSubject()
        Dim com As New MySqlCommand("SELECT * FROM tblSubject", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        listView.Items.Clear()
        While vRS.Read()
            Dim lv As New ListViewItem(vRS("SubjectCode").ToString())
            lv.SubItems.Add(vRS("Description").ToString())
            lv.SubItems.Add(vRS("Units").ToString())
            lv.SubItems.Add(vRS("LabUnits").ToString())
            lv.SubItems.Add(vRS("CreditUnits").ToString())
            lv.SubItems.Add(vRS("SubjectID").ToString())
            listView.Items.AddRange(New ListViewItem() {lv})
        End While
        vRS.Close()
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
        'Dim frm As New PickSubject()
        'frm.GetSubjectTitle(txtSubjectCode.Text, txtDescriptive.Text, txtSubjectID.Text)

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
        Dim com As New MySqlCommand("SELECT tblcurriculumdetails.CurriculumID,tblsubject.SubjectID, tblsubject.SubjectCode, tblsubject.Description, tblsubject.Units, tblsubject.CreditUnits, tblsubject.LabUnits, tblyearlevelterm.YearTermDesc,tblYearLevelTerm.ID " & _
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
            dgOutLine.Rows(n).Cells(5).Value = dr("SubjectID").ToString()
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
                Me.cmdAssign.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
                Me.cmdReplace.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
            End If

        End If
    End Sub

    Private Sub dgOutLine_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgOutLine.KeyDown
        If e.KeyCode = Keys.Delete Then
            cmdDelete_Click(sender, e)

            cmdRefresh_Click(sender, e)
        End If
    End Sub


    Private Sub txtSubjectCode_Enter(sender As System.Object, e As System.EventArgs) Handles txtSubjectCode.Enter

    End Sub
    Private Sub txtSubjectCode_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSubjectCode.TextChanged
        'On Error Resume Next

        'PanelList.Height = 289
        'PanelList.Width = 393
       
    End Sub

    Private Sub listView_DoubleClick(sender As System.Object, e As System.EventArgs) Handles listView.DoubleClick
        Dim vSubj As tSubject

        If listView.Items.Count > 0 Then
            If GetSubjectByID(txtSubjectID.Text, vSubj) <> TranDBResult.Success Then
                Exit Sub
            End If

            txtSubjectCode.Text = vSubj.SubjectCode
            txtDescriptive.Text = vSubj.Description

            lblLabUnit.Text = vSubj.LabUnits
            lblLecUnit.Text = vSubj.Units
            lblCreditUnit.Text = vSubj.CreditUnits
        End If

        txtSearch.Text = ""

        PanelList.Height = 0
        PanelList.Width = 0

    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles panelSubject.Click

        If PanelList.Height = 0 And PanelList.Width = 0 Then

            If listView.Items.Count < 2 Then
                PanelList.Height = 108
                PanelList.Width = 393
            ElseIf listView.Items.Count > 2 And listView.Items.Count < 20 Then
                PanelList.Height = 182
                PanelList.Width = 393
            ElseIf listView.Items.Count > 20 And listView.Items.Count < 100 Then
                PanelList.Height = 246
                PanelList.Width = 393
            Else
                PanelList.Height = 289
                PanelList.Width = 393
            End If

            txtSubjectCode.Text = ""
            txtDescriptive.Text = ""

            PanelList.Focus()
        Else
            txtSubjectCode.Text = ""
            txtDescriptive.Text = ""

            PanelList.Height = 0
            PanelList.Width = 0
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Dim vSubj As tSubject

        If listView.Items.Count > 0 Then
            If GetSubjectByID(txtSubjectID.Text, vSubj) <> TranDBResult.Success Then
                Exit Sub
            End If

            txtSubjectCode.Text = vSubj.SubjectCode
            txtDescriptive.Text = vSubj.Description

            lblLabUnit.Text = vSubj.LabUnits
            lblLecUnit.Text = vSubj.Units
            lblCreditUnit.Text = vSubj.CreditUnits
        End If

        txtSearch.Text = ""

        PanelList.Height = 0
        PanelList.Width = 0

    End Sub

    Private Sub PanelList_Leave(sender As System.Object, e As System.EventArgs) Handles PanelList.Leave
        PanelList.Height = 0
        PanelList.Width = 0
    End Sub

    Private Sub listView_Click(sender As System.Object, e As System.EventArgs) Handles listView.Click
        If listView.Items.Count > 0 Then
            txtSubjectCode.Text = listView.FocusedItem.Text
            txtSubjectID.Text = listView.FocusedItem.SubItems(5).Text
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        txtSubjectCode.Text = ""
        txtDescriptive.Text = ""

        PanelList.Height = 0
        PanelList.Width = 0
    End Sub

    Private Sub txtSearch_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSearch.TextChanged
        On Error Resume Next
        Dim com As New MySqlCommand("SELECT * FROM tblSubject WHERE SubjectCode LIKE '%" & txtSearch.Text & "%' OR Description LIKE '%" & _
                                    txtSearch.Text & "%' OR SubjectTitle LIKE '%" & txtSearch.Text & "%'", con)

        Dim vRS As MySqlDataReader = com.ExecuteReader()
        listView.Items.Clear()
        While vRS.Read()
            Dim lv As New ListViewItem(vRS("SubjectCode").ToString())
            lv.SubItems.Add(vRS("Description").ToString())
            lv.SubItems.Add(vRS("Units").ToString())
            lv.SubItems.Add(vRS("LabUnits").ToString())
            lv.SubItems.Add(vRS("CreditUnits").ToString())
            lv.SubItems.Add(vRS("SubjectID").ToString())
            listView.Items.AddRange(New ListViewItem() {lv})
        End While
        vRS.Close()
    End Sub

    Private Sub dgOutLine_Leave(sender As System.Object, e As System.EventArgs) Handles dgOutLine.Leave
        Me.cmdAssign.BackColor = System.Drawing.SystemColors.Control
        Me.cmdReplace.BackColor = System.Drawing.SystemColors.Control
    End Sub

    Private Sub cmdAssign_Click(sender As System.Object, e As System.EventArgs) Handles cmdAssign.Click
        If dgOutLine.RowCount > 0 Then
            If Len(dgOutLine.Rows(dgOutLine.CurrentRow.Index).Cells(5).Value.ToString()) > 0 Then
                Dim frm As New frmSubjectEquivalentByCurriculum()
                frm.ShowForm(dgOutLine.Rows(dgOutLine.CurrentRow.Index).Cells(5).Value.ToString(), CurriculumCode)
            End If
        End If
    End Sub
End Class