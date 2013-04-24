Option Explicit On

Imports System.Windows.Forms

Public Class frmScholarshipGrantTemplates

    Dim AcctID As String

    Dim State As FormState

    Dim Scho As ScholarshipGrantTemplates
    Dim Temp As ScholarshipGrantTemplate_Details

    Dim GrantTemplateID As Integer
    Dim DetailID As Integer

    Private Sub NewToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles NewToolStripButton.Click
        txtCode.Text = ""
        AcctID = ""
        txtAmount.Text = "0.00"
        txtDetail.Text = ""
        txtRate.Text = "0"
        txtRemarks.Text = ""

        State = FormState.addFormState

    End Sub

    Private Sub cmdPickAccount_Click(sender As System.Object, e As System.EventArgs) Handles cmdPickAccount.Click
        Dim frm As New pickAccount
        frm.ShowForm(txtDetail.Text, txtCode.Text, AcctID)
        Label5.Text = AcctID
    End Sub

    Private Sub lvTemplate_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lvTemplate.SelectedIndexChanged
        If lvTemplate.Items.Count > 0 Then
            If GetSchoGrantTemplateByID(lvTemplate.FocusedItem.SubItems(3).Text, Scho) = TranDBResult.Success Then
                cmdPrintTemplate.Text = "Scholarship Grant Template [ " & Scho.TemplateCode & " ]"
                TabControl.Enabled = True

                FillListView("SELECT fnAccountCode(AcctID),fnAccountName(AcctID),Amount,Percentage,Remarks,fnAccountGroup(AcctID),DetailID,AcctID " & _
                             "FROM tblschogranttemplate_details WHERE GrantTemplateID='" & lvTemplate.FocusedItem.SubItems(3).Text & "'", lvTemplateDetails, False)

                GrantTemplateID = lvTemplate.FocusedItem.SubItems(3).Text

            Else
                cmdPrintTemplate.Text = "Scholarship Grant Template"
                TabControl.Enabled = False
            End If
        End If
    End Sub

    Private Sub frmScholarshipGrantTemplates_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        State = FormState.addFormState

        fillMultiColumnCombo2(cboTerm, "SELECT CONCAT(tblAYTerm.SchoolYear,' ',tblAYTerm.SchoolTerm) AS lvKey, tblAYTerm.TermID From tblAYTerm")
    End Sub

    Private Sub cmdAddTemplate_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdAddTemplate.LinkClicked
        Dim frm As New frmSchoGrantAE
        frm.ShowForm()
    End Sub

    Private Sub cmdProvider_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdProvider.LinkClicked
        Dim frm As New frmSchoProvider
        frm.ShowForm()
    End Sub

    Private Sub SaveToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles SaveToolStripButton.Click
        Select Case State
            Case FormState.addFormState
                SaveTemplateDetails()
            Case FormState.updateFormState
                UpdateTemplateDetails()
        End Select
    End Sub

    Private Sub SaveTemplateDetails()

        For Each lv As ListViewItem In lvTemplateDetails.Items
            If lv.SubItems(7).Text = AcctID Then
                MsgBox("The Account Code :[" & txtCode.Text & "] - " & txtDetail.Text & " is already in the list.", vbExclamation)
                Exit Sub
            End If
        Next

        If chkAmount.Checked = True Then
            If Not CheckTextBox(txtAmount, "Please enter the Amount or Rate(%)") Then HLTxt(txtAmount) : Exit Sub
        ElseIf chkRate.Checked = True Then
            If Not CheckTextBox(txtRate, "Please enter the Amount or Rate(%)") Then HLTxt(txtRate) : Exit Sub
        End If


        If Not CheckTextBox(txtCode, "Please enter an Account") Then Exit Sub : txtCode.Focus()

        Temp.AcctID = AcctID
        Temp.Amount = txtAmount.Text
        Temp.GrantTemplateID = GrantTemplateID
        Temp.Percentage = txtRate.Text
        Temp.Remarks = txtRemarks.Text


        Select Case SaveGrantTemplateDetails(Temp, cboTerm.SelectedItem.Col2)
            Case TranDBResult.Success
                cmdRefresh_Click(Me, New System.EventArgs)
                NewToolStripButton_Click(Me, New System.EventArgs)

            Case TranDBResult.Failed
                CatchError("modScholarship", "SaveGrantTemplateDetails", "An Unknown Error occur...")
                Exit Sub
        End Select

    End Sub

    Private Sub UpdateTemplateDetails()

        For Each lv As ListViewItem In lvTemplateDetails.Items
            If lv.SubItems(7).Text = AcctID Then
                MsgBox("The Account Code :[" & txtCode.Text & "] - " & txtDetail.Text & " is already in the list.", vbExclamation)
                Exit Sub
            End If
        Next

        If chkAmount.Checked = True Then
            If Not CheckTextBox(txtAmount, "Please enter the Amount or Rate(%)") Then HLTxt(txtAmount) : Exit Sub
        ElseIf chkRate.Checked = True Then
            If Not CheckTextBox(txtRate, "Please enter the Amount or Rate(%)") Then HLTxt(txtRate) : Exit Sub
        Else

        End If

        Temp.AcctID = AcctID
        Temp.Amount = txtAmount.Text
        Temp.GrantTemplateID = GrantTemplateID
        Temp.Percentage = txtRate.Text
        Temp.Remarks = txtRemarks.Text


        Select Case UpdateGrantTemplateDetails(Temp, cboTerm.SelectedItem.Col2)
            Case TranDBResult.Success
                cmdRefresh_Click(Me, New System.EventArgs)
                NewToolStripButton_Click(Me, New System.EventArgs)

            Case TranDBResult.Failed
                CatchError("modScholarship", "UpdateGrantTemplateDetails", "An Unknown Error occur...")
                Exit Sub
        End Select
    End Sub

    Private Sub cboTerm_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboTerm.SelectedIndexChanged
        FillListView("SELECT TemplateCode,fnScholarProviderName(SchoProviderID),Description,GrantTemplateID FROM tblschogranttemplates WHERE TermID ='" & cboTerm.SelectedItem.Col2 & "'", lvTemplate, False)
    End Sub

    Private Sub cmdPrintSchoProvider_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdPrintSchoProvider.LinkClicked
        Dim frm As New frmPrintPreview
        'frm.ShowPrint("Scholarship_Provider")
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        FillListView("SELECT TemplateCode,fnScholarProviderName(SchoProviderID),Description,GrantTemplateID FROM tblschogranttemplates WHERE TermID ='" & cboTerm.SelectedItem.Col2 & "'", lvTemplate, False)
    End Sub

    Private Sub ModiftTemplateToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ModiftTemplateToolStripMenuItem.Click
        If lvTemplate.Items.Count > 0 Then
            Dim frm As New frmSchoGrantAE
            frm.ShowEdit(lvTemplate.FocusedItem.SubItems(3).Text)
        End If
    End Sub

    Private Sub chkAmount_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkAmount.CheckedChanged
        If chkAmount.Checked = True Then
            txtAmount.Enabled = True
            chkRate.Checked = False
        Else
            txtAmount.Enabled = False
            txtAmount.Text = "0.00"
            chkRate.Checked = True
        End If
    End Sub

    Private Sub chkRate_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkRate.CheckedChanged
        If chkRate.Checked = True Then
            txtRate.Enabled = True
            chkAmount.Checked = False
        Else
            txtRate.Enabled = False
            txtRate.Text = "0"
            chkAmount.Checked = True
        End If
    End Sub

    Private Sub txtAmount_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtAmount.TextChanged
        If Len(txtAmount.Text) > 0 Then
            chkRate.Checked = False
        End If
    End Sub

    Private Sub cmdRefresh_Click(sender As System.Object, e As System.EventArgs) Handles cmdRefresh.Click
        FillListView("SELECT fnAccountCode(AcctID),fnAccountName(AcctID),Amount,Percentage,Remarks,fnAccountGroup(AcctID),DetailID,AcctID " & _
                             "FROM tblschogranttemplate_details WHERE GrantTemplateID='" & GrantTemplateID & "'", lvTemplateDetails, False)
    End Sub

    Private Sub DeleteToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles DeleteToolStripButton.Click
        If lvTemplateDetails.Items.Count > 0 Then
            If ExecuteDeleteSchoGrantTemplateDetails(lvTemplateDetails.FocusedItem.SubItems(6).Text) = TranDBResult.Success Then
                cmdRefresh_Click(sender, e)
                NewToolStripButton_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub lvTemplateDetails_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lvTemplateDetails.SelectedIndexChanged
        If lvTemplateDetails.Items.Count > 0 Then

            State = FormState.updateFormState

            txtCode.Text = lvTemplateDetails.FocusedItem.Text
            txtDetail.Text = lvTemplateDetails.FocusedItem.SubItems(1).Text
            txtRemarks.Text = lvTemplateDetails.FocusedItem.SubItems(4).Text
            txtAmount.Text = lvTemplateDetails.FocusedItem.SubItems(2).Text
            txtRate.Text = lvTemplateDetails.FocusedItem.SubItems(3).Text
            GrantTemplateID = lvTemplateDetails.FocusedItem.SubItems(6).Text
            AcctID = lvTemplateDetails.FocusedItem.SubItems(7).Text
        End If
    End Sub
End Class