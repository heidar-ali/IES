Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frmFeeTemplateOutline


    Dim CampusID As Integer
    Dim TermID As Integer
    Dim sTemplateID As Integer
    Dim TemplateCode As String

    Dim sID As String

    Dim AcctCode As String
    Dim AcctID As String
    Dim FundID As String
    Dim Fund_Group As String

    Dim State As FormState

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub FeeTemplateOutline_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub ShowForm(ByVal TemplateID As String, ByVal sCampusID As Integer, ByVal sTermID As Integer)
        Dim Fee As tTableofFees
        Dim Camp As tSchool
        Dim Term As tSchoolYear

        Dim Sum As Decimal = 0

        If GetFeeTemplateByTemplateID(TemplateID, Fee) = TranDBResult.Success Then

            State = FormState.addFormState


            TemplateCode = Fee.TemplateCode
            sTemplateID = TemplateID

            lblTemplate.Text = Fee.TemplateDisc

            If GetCampusByCampusID(sCampusID, Camp) = TranDBResult.Success Then
                lblCampus.Text = Camp.CampusName
            End If

            CampusID = sCampusID

            If GetAcademicYearTerm(sTermID, Term) = TranDBResult.Success Then
                lblTerm.Text = Term.SchoolYearTitle & " - " & Term.SchoolTerm
            End If

            TermID = sTermID

            FillListView("SELECT ACCT.AcctCode,ACCT.AcctID,ACCT.AcctName, ACCT.ShortName,CONCAT(TFD.Currency,' ', TFD.Amount), AG.GroupName,TFD.ID " & _
                                    "FROM tblTableofFees AS T RIGHT OUTER JOIN " & _
                              "tblTableofFee_Details AS TFD ON T.TemplateID = TFD.TemplateID LEFT OUTER JOIN " & _
                              "tblAccounts AS ACCT LEFT OUTER JOIN " & _
                              "tblAccountGroups AS AG ON ACCT.GroupID = AG.GroupID ON TFD.AccountID = ACCT.AcctID " & _
                              "WHERE T.TemplateID='" & TemplateID & "'", lvOutline, False)
            lblNo.Text = lvOutline.Items.Count



            For Each lv As ListViewItem In lvOutline.Items
                Dim splitKey As Object = Split(lv.SubItems(4).Text, " ")

                Sum += CDec(splitKey(1))
            Next

            lblTotal.Text = Sum.ToString("#,##0.00")
        End If

        Me.ShowDialog()



    End Sub

    Private Sub NewToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles NewToolStripButton.Click
        State = FormState.addFormState

        txtAccount.Text = ""
        lblDetails.Text = "---"
        txtAmount.Text = ""
        lblCurrency.Text = "PHP"

        FundID = ""
        Fund_Group = ""
        AcctCode = ""
        AcctID = ""

    End Sub

   

    Private Sub cmdPickAccount_Click(sender As System.Object, e As System.EventArgs) Handles cmdPickAccount.Click
        Dim frm As New pickAccount
        frm.ShowForm(lblDetails.Text, txtAccount.Text, AcctID)
    End Sub

    Private Sub RefreshToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles RefreshToolStripButton.Click
        Dim Sum As Decimal = 0

        FillListView("SELECT ACCT.AcctCode,ACCT.AcctID,ACCT.AcctName, ACCT.ShortName,CONCAT(TFD.Currency,' ', TFD.Amount), AG.GroupName,TFD.ID " & _
                                "FROM tblTableofFees AS T RIGHT OUTER JOIN " & _
                          "tblTableofFee_Details AS TFD ON T.TemplateID = TFD.TemplateID LEFT OUTER JOIN " & _
                          "tblAccounts AS ACCT LEFT OUTER JOIN " & _
                          "tblAccountGroups AS AG ON ACCT.GroupID = AG.GroupID ON TFD.AccountID = ACCT.AcctID " & _
                          "WHERE T.TemplateID='" & sTemplateID & "'", lvOutline, False)

        lblNo.Text = lvOutline.Items.Count



        For Each lv As ListViewItem In lvOutline.Items
            Dim splitKey As Object = Split(lv.SubItems(4).Text, " ")

            Sum += CDec(splitKey(1))
        Next

        lblTotal.Text = Sum.ToString("#,##0.00")

    End Sub

    Private Sub PrintToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles PrintToolStripButton.Click

    End Sub

    Private Sub DeleteToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles DeleteToolStripButton.Click
        If lvOutline.Items.Count > 0 Then
            If ExecuteDeleteFeeTemplateDetails(lvOutline.FocusedItem.SubItems(6).Text, txtAccount.Text & "-" & lblDetails.Text) = TranDBResult.Success Then
                RefreshToolStripButton_Click(sender, e)
                NewToolStripButton_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub lvOutline_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lvOutline.SelectedIndexChanged
        Dim sFee As tTableOfFeeDetails
        Dim Acct As tAccounting

        If lvOutline.Items.Count > 0 Then
            If GetTableOfFee_DetailsByID(lvOutline.FocusedItem.SubItems(6).Text, sFee) = TranDBResult.Success Then

                State = FormState.updateFormState

                If GetAccountsByID(lvOutline.FocusedItem.SubItems(1).Text, Acct) = TranDBResult.Success Then
                    txtAccount.Text = Acct.AccountCode
                    lblDetails.Text = Acct.AccountName
                    AcctID = Acct.AcctID
                End If

                sID = lvOutline.FocusedItem.SubItems(6).Text

                txtAmount.Text = sFee.Amount
                lblCurrency.Text = sFee.Currency
                chkActive.Checked = IntToBoolean(sFee.InActive)

                Select Case sFee.Options
                    Case 0
                        optBoth.Checked = True
                    Case 1
                        optAdmitted.Checked = True
                    Case 2
                        optOld.Checked = True
                End Select
            End If
        End If
    End Sub

    Private Sub SaveToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles SaveToolStripButton.Click
        Select Case State
            Case FormState.addFormState
                SaveData()
            Case FormState.updateFormState
                UpdateData()
        End Select
    End Sub

    Private Sub SaveData()
        Dim sFee As tTableOfFeeDetails

        If Not CheckTextBox(txtAccount, "Please enter an Account") Then HLTxt(txtAccount) : Exit Sub
        If Not CheckTextBox(txtAmount, "Please enter an Amount for the Account") Then HLTxt(txtAmount) : Exit Sub

        sFee.TemplateID = sTemplateID
        sFee.AccountID = AcctID
        sFee.Amount = txtAmount.Text
        sFee.Currency = lblCurrency.Text
        sFee.InActive = chkActive.Checked

        If optAdmitted.Checked Then
            sFee.Options = 1
        ElseIf optBoth.Checked Then
            sFee.Options = 0
        ElseIf optOld.Checked Then
            sFee.Options = 2
        End If

        Select Case SaveTableOfFees_Details(sFee)
            Case TranDBResult.Success
                RefreshToolStripButton_Click(Me, New System.EventArgs)
                NewToolStripButton_Click(Me, New System.EventArgs)

            Case TranDBResult.Failed
                CatchError("modFees", "SaveTableOfFees_Details", "Unknown Error Occur")
                Exit Sub
        End Select
    End Sub

    Private Sub UpdateData()
        Dim sFee As tTableOfFeeDetails

        If Not CheckTextBox(txtAccount, "Please enter an Account") Then HLTxt(txtAccount) : Exit Sub
        If Not CheckTextBox(txtAmount, "Please enter an Amount for the Account") Then HLTxt(txtAmount) : Exit Sub

        sFee.TemplateID = sTemplateID
        sFee.AccountID = AcctID
        sFee.Amount = txtAmount.Text
        sFee.Currency = lblCurrency.Text
        sFee.InActive = chkActive.Checked
        sFee.ID = sID


        If optAdmitted.Checked Then
            sFee.Options = 1
        ElseIf optBoth.Checked Then
            sFee.Options = 0
        ElseIf optOld.Checked Then
            sFee.Options = 2
        End If

        Select Case UpdateTableOfFees_Details(sFee)
            Case TranDBResult.Success
                RefreshToolStripButton_Click(Me, New System.EventArgs)
                NewToolStripButton_Click(Me, New System.EventArgs)

            Case TranDBResult.Failed
                CatchError("modFees", "SaveTableOfFees_Details", "Unknown Error Occur")
                Exit Sub
        End Select
    End Sub
End Class
