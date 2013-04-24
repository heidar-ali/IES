Imports System.Windows.Forms

Public Class frmAccountsAE

    Dim Acct As tAccounting
    Dim State As FormState
    Dim sAcctID As String


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Select Case State
            Case FormState.addFormState
                SaveData()
            Case FormState.updateFormState
                UpdateData()
        End Select


    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmAccountsAE_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '========================= ACCOUNT GL CODES ============================================

        fillCombo(cboColCredit, "SELECT GLName FROM tblAccountGLCodes ORDER BY GLID")
        fillCombo(cboColCreditID, "SELECT GLID FROM tblAccountGLCodes ORDER BY GLID")

        fillCombo(cboRecCredit, "SELECT GLName FROM tblAccountGLCodes ORDER BY GLID")
        fillCombo(cboRecCreditID, "SELECT GLID FROM tblAccountGLCodes ORDER BY GLID")

        fillCombo(cboRecDebit, "SELECT GLName FROM tblAccountGLCodes ORDER BY GLID")
        fillCombo(cboRecDebitID, "SELECT GLID FROM tblAccountGLCodes ORDER BY GLID")

        '======================= ACCOUNT CATEGORY ====================================

        fillCombo(cboType, "SELECT CategoryName FROM tblAccountsCategory ORDER BY CategoryID")
        fillCombo(cboTypeID, "SELECT CategoryID FROM tblAccountsCategory ORDER BY CategoryID")

        '===============================ACCOUNT SUB GROUPS/FUND===============================

        fillCombo(cboSubFund, "SELECT ShortName FROM tblAccountSubGroups ORDER BY SubGroupID")
        fillCombo(cboSubFundID, "SELECT SubGroupID FROM tblAccountSubGroups ORDER BY SubGroupID")

        '============================ACCOUNT GROUPS =====================================
        fillCombo(cboFundGroup, "SELECT GroupName FROM tblAccountGroups ORDER BY GroupID")
        fillCombo(cboFundID, "SELECT GroupID FROM tblAccountGroups ORDER BY GroupID")

        '============================= ACCOUNT CLASS ==========================================
        fillCombo(cboClassification, "SELECT ClassName FROM tblAccountClass ORDER BY ClassID")
        fillCombo(cboClassID, "SELECT ClassID FROM tblAccountClass ORDER BY ClassID")

        '========================== ACCOUNT DEPARTMENT ==============================================
        fillCombo(cboDepartment, "SELECT DeptName FROM tblAccountDepartment ORDER BY DeptID")
        fillCombo(cboAccountDepartmentID, "SELECT DeptID FROM tblAccountDepartment ORDER BY DeptID")

        '============================ ACCOUNT SUB UNIT =========================================
        fillCombo(cboSubUnit, "SELECT UnitName FROM tblAccountSubUnits ORDER BY SubUnitID")
        fillCombo(cboSubUnitID, "SELECT SubUnitID FROM tblAccountSubUnits ORDER BY SubUnitID")


        fillCombo(cboAccountOption, "SELECT AcctOptionName FROM tblAccountOptions ORDER BY AcctOptionID")
        fillCombo(cboAccountOptionID, "SELECT AcctOptionID FROM tblAccountOptions ORDER BY AcctOptionID")

        fillCombo(cboPaymentOption, "SELECT PaymentOptionName FROM tblPaymentOptions ORDER BY PaymentOptionID")
        fillCombo(cboPayOptionID, "SELECT PaymentOptionID FROM tblPaymentOptions ORDER BY PaymentOptionID")

    End Sub

    Public Sub ShowForm()

        State = FormState.addFormState

        Me.ShowDialog()
    End Sub

    Public Sub ShowEdit(ByVal AcctCode As String)

        State = FormState.updateFormState

        Dim Acct As tAccounting
        Dim Dept As tAccountDepartment
        Dim Clas As tAccountClassification
        Dim Cat As tAccountCategory
        Dim GL As tAccountGLCode
        Dim Fund As tFundGroups
        Dim sFund As tSubFund
        Dim uSub As tSubUnits
        Dim sSubd As tSubsidiaryCode
        Dim opt As PaymentOptions
        Dim Act As tAccountOptions

        If GetAccountsByCode(AcctCode, Acct) = TranDBResult.Success Then
            txtAccountName.Text = Acct.AccountName
            txtCode.Text = Acct.AccountCode
            txtShortName.Text = Acct.ShortName
            sAcctID = Acct.AcctID

            chkActive.Checked = IntToBoolean(Acct.InActive)

            If GetAccountDepartmentByID(Acct.DepartmentID, Dept) = TranDBResult.Success Then
                cboDepartment.Text = Dept.DeptName
                cboAccountDepartmentID.Text = Dept.IndexID
            End If

            If GetAccountClassificationByID(Acct.ClassificationID, Clas) = TranDBResult.Success Then
                cboClassification.Text = Clas.ClassName
                cboClassID.Text = Clas.IndexID
            End If

            If GetAccountCategoryRecordByID(Acct.CategoryID, Cat) = TranDBResult.Success Then
                cboType.Text = Cat.TypeName
                cboTypeID.Text = Cat.IndexID
            End If

            If GetAccountFundByID(Acct.FundID, Fund) = TranDBResult.Success Then
                cboFundGroup.Text = Fund.GroupName
                cboFundID.Text = Fund.IndexID
            End If

            If GetSubFundExistByID(Acct.SubFundID, sFund) = TranDBResult.Success Then
                cboSubFund.Text = sFund.SubFundName
                cboSubFundID.Text = sFund.IndexID
            End If

            If GetSubUnitsByID(Acct.SubUnit, uSub) = TranDBResult.Success Then
                cboSubUnit.Text = uSub.UnitName
                cboSubUnitID.Text = uSub.IndexID
            End If

            If GetAccountGLCodeRecordByID(Acct.GLID, GL) = TranDBResult.Success Then
                cboRecCredit.Text = GL.GLName
                cboRecCreditID.Text = GL.IndexID
            End If

            If GetAccountGLCodeRecordByID(Acct.RecDebitAccount, GL) = TranDBResult.Success Then
                cboRecDebit.Text = GL.GLName
                cboRecDebitID.Text = GL.IndexID
            End If

            If GetAccountGLCodeRecordByID(Acct.ColCreditAccount, GL) = TranDBResult.Success Then
                cboColCredit.Text = GL.GLName
                cboColCreditID.Text = GL.IndexID
            End If

            If GetPaymenyOptionByOptionID(Acct.PaymentOptionID, opt) = TranDBResult.Success Then
                cboPaymentOption.Text = opt.PaymentOptionName
                cboPayOptionID.Text = opt.PaymentOptionID
            End If

            If GetAccountOptionsByID(Acct.AccountOptionID, Act) = TranDBResult.Success Then
                cboAccountOption.Text = Act.AcctOptionName
                cboAccountOptionID.Text = Act.AcctOptionID
            End If

        Else
            DisplayErrorMsg("frmAccountsAE", "ShowEdit", Err.Number, Err.Description)
            Exit Sub
        End If

        Me.ShowDialog()
    End Sub

    Private Sub SaveData()
        Dim Acct As tAccounting

        If Not CheckTextBox(txtAccountName, "Please enter Account Name") Then Exit Sub
        If Not CheckTextBox(txtCode, "Please enter Account Code") Then Exit Sub
        If Not CheckTextBox(txtShortName, "Please enter Account Shortname") Then Exit Sub

        If Len(cboFundGroup.Text) < 1 Then
            MsgBox("Please select Account Fund/Groups", vbExclamation) : Exit Sub
        End If

        If Len(cboClassification.Text) < 1 Then
            MsgBox("Please select Account Classification", vbExclamation) : Exit Sub
        End If

        If Len(cboAccountOption.Text) < 1 Then
            MsgBox("Please select Account Options", vbExclamation) : Exit Sub
        End If

        If Len(cboPaymentOption.Text) < 1 Then
            MsgBox("Please select Payment Options for Accounts", vbExclamation) : Exit Sub
        End If

        Acct.AccountName = txtAccountName.Text
        Acct.CategoryID = cboTypeID.Text
        Acct.ClassificationID = cboClassID.Text
        Acct.ColCreditAccount = cboColCreditID.Text
        Acct.DepartmentID = cboAccountDepartmentID.Text
        Acct.FundID = cboFundID.Text
        Acct.InActive = BooleanToInt(chkActive.Checked)
        Acct.PaymentOptionID = cboPayOptionID.Text
        Acct.RecCreditAccount = cboRecCreditID.Text
        Acct.RecDebitAccount = cboRecDebitID.Text
        Acct.ColCreditAccount = cboColCreditID.Text
        Acct.ShortName = txtShortName.Text
        Acct.AccountCode = txtCode.Text
        Acct.SubFundID = cboSubFundID.Text
        Acct.SubUnit = cboSubUnitID.Text

        Select Case SaveAccounts(Acct)
            Case TranDBResult.Success
                MsgBox("Record Successfully Save...", vbInformation)
                Close()
            Case TranDBResult.DuplicateCode
                MsgBox("Unable to save record. Duplicate code entry may occur", vbExclamation)
                Exit Sub
            Case TranDBResult.Failed
        End Select

    End Sub

    Private Sub UpdateData()

        Dim Acct As tAccounting

        If Not CheckTextBox(txtAccountName, "Please enter Account Name") Then Exit Sub
        If Not CheckTextBox(txtCode, "Please enter Account Code") Then Exit Sub
        If Not CheckTextBox(txtShortName, "Please enter Account Shortname") Then Exit Sub

        If Len(cboFundGroup.Text) < 1 Then
            MsgBox("Please select Account Fund/Groups", vbExclamation) : Exit Sub
        End If

        If Len(cboClassification.Text) < 1 Then
            MsgBox("Please select Account Classification", vbExclamation) : Exit Sub
        End If

        If Len(cboAccountOption.Text) < 1 Then
            MsgBox("Please select Account Options", vbExclamation) : Exit Sub
        End If

        If Len(cboPaymentOption.Text) < 1 Then
            MsgBox("Please select Payment Options for Accounts", vbExclamation) : Exit Sub
        End If

        Acct.AccountName = txtAccountName.Text
        Acct.CategoryID = cboTypeID.Text
        Acct.ClassificationID = cboClassID.Text
        Acct.ColCreditAccount = cboColCreditID.Text
        Acct.DepartmentID = cboAccountDepartmentID.Text
        Acct.FundID = cboFundID.Text
        Acct.InActive = BooleanToInt(chkActive.Checked)
        Acct.PaymentOptionID = cboPayOptionID.Text
        Acct.RecCreditAccount = cboRecCreditID.Text
        Acct.RecDebitAccount = cboRecDebitID.Text
        Acct.ColCreditAccount = cboColCreditID.Text
        Acct.ShortName = txtShortName.Text
        Acct.AccountCode = txtCode.Text
        Acct.SubFundID = cboSubFundID.Text
        Acct.SubUnit = cboSubUnitID.Text

        Acct.AcctID = sAcctID

        Select Case UpdateAccount(Acct)
            Case TranDBResult.Success
                MsgBox("Record Successfully updated...", vbInformation)
                Close()
        End Select

    End Sub



    Private Sub cmdNewFund_Click(sender As System.Object, e As System.EventArgs) Handles cmdNewFund.Click
        Dim frm As New frmFundGroups
        frm.ShowForm()
    End Sub

    Private Sub cmdSubFund_Click(sender As System.Object, e As System.EventArgs) Handles cmdSubFund.Click
        Dim frm As New frmSubFundAE
        frm.ShowForm()
    End Sub

    Private Sub cmdSubUnit_Click(sender As System.Object, e As System.EventArgs) Handles cmdSubUnit.Click
        Dim frm As New frmSubUnits
        frm.ShowForm()
    End Sub

    Private Sub cmdDepartment_Click(sender As System.Object, e As System.EventArgs) Handles cmdDepartment.Click
        Dim frm As New frmAccountDepartment()
        frm.ShowForm()
    End Sub

    Private Sub cmdClassification_Click(sender As System.Object, e As System.EventArgs) Handles cmdClassification.Click
        Dim frm As New frmAccountClass
        frm.ShowForm()
    End Sub

    Private Sub cmdType_Click(sender As System.Object, e As System.EventArgs) Handles cmdType.Click
        Dim frm As New frmAccountType
        frm.ShowForm()
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub cmdGL1_Click(sender As System.Object, e As System.EventArgs) Handles cmdGL1.Click, cmdGL3.Click, cmdGL2.Click
        Dim frm As New frmAccountGL
        frm.ShowForm()
    End Sub

    Private Sub cmdRefreshRecCredit_Click(sender As System.Object, e As System.EventArgs) Handles cmdRefreshRecCredit.Click
        fillCombo(cboRecCredit, "SELECT GLName FROM tblAccountGLCodes ORDER BY GLID")
        fillCombo(cboRecCreditID, "SELECT GLID FROM tblAccountGLCodes ORDER BY GLID")
    End Sub

    Private Sub cmdRefreshRecDebit_Click(sender As System.Object, e As System.EventArgs) Handles cmdRefreshRecDebit.Click
        fillCombo(cboRecDebit, "SELECT GLName FROM tblAccountGLCodes ORDER BY GLID")
        fillCombo(cboRecDebitID, "SELECT GLID FROM tblAccountGLCodes ORDER BY GLID")
    End Sub

    Private Sub cmdColRefreshGL_Click(sender As System.Object, e As System.EventArgs) Handles cmdColRefreshGL.Click
        fillCombo(cboColCredit, "SELECT GLName FROM tblAccountGLCodes ORDER BY GLID")
        fillCombo(cboColCreditID, "SELECT GLID FROM tblAccountGLCodes ORDER BY GLID")
    End Sub

    Private Sub cboFundGroup_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboFundGroup.SelectedIndexChanged
        cboFundID.SelectedIndex = cboFundGroup.SelectedIndex
    End Sub

    Private Sub cboSubFund_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboSubFund.SelectedIndexChanged
        cboSubFundID.SelectedIndex = cboSubFund.SelectedIndex
    End Sub

    Private Sub cboDepartment_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboDepartment.SelectedIndexChanged
        cboAccountDepartmentID.SelectedIndex = cboDepartment.SelectedIndex
    End Sub

    Private Sub cboColCredit_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboColCredit.SelectedIndexChanged
        cboColCreditID.SelectedIndex = cboColCredit.SelectedIndex
    End Sub

    Private Sub cboRecCredit_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboRecCredit.SelectedIndexChanged
        cboRecCreditID.SelectedIndex = cboRecCredit.SelectedIndex
    End Sub

    Private Sub cboRecDebit_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboRecDebit.SelectedIndexChanged
        cboRecDebitID.SelectedIndex = cboRecDebit.SelectedIndex
    End Sub

    Private Sub cboPaymentOption_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboPaymentOption.SelectedIndexChanged
        cboPayOptionID.SelectedIndex = cboPaymentOption.SelectedIndex
    End Sub

    Private Sub cboAccountOption_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboAccountOption.SelectedIndexChanged
        cboAccountOptionID.SelectedIndex = cboAccountOption.SelectedIndex
    End Sub

    Private Sub cboType_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboType.SelectedIndexChanged
        cboTypeID.SelectedIndex = cboType.SelectedIndex
    End Sub

    Private Sub cboClassification_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboClassification.SelectedIndexChanged
        cboClassID.SelectedIndex = cboClassification.SelectedIndex
    End Sub

    Private Sub cboSubUnit_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboSubUnit.SelectedIndexChanged
        cboSubUnitID.SelectedIndex = cboSubUnit.SelectedIndex
    End Sub

    Private Sub cmdRefreshFund_Click(sender As System.Object, e As System.EventArgs) Handles cmdRefreshFund.Click
        fillCombo(cboFundGroup, "SELECT GroupName FROM tblAccountGroups ORDER BY GroupID")
        fillCombo(cboFundID, "SELECT GroupID FROM tblAccountGroups ORDER BY GroupID")
    End Sub

    Private Sub cmdRefreshSubFund_Click(sender As System.Object, e As System.EventArgs) Handles cmdRefreshSubFund.Click
        fillCombo(cboSubFund, "SELECT ShortName FROM tblAccountSubGroups ORDER BY SubGroupID")
        fillCombo(cboSubFundID, "SELECT SubGroupID FROM tblAccountSubGroups ORDER BY SubGroupID")
    End Sub

    Private Sub cmdRefreshSubUnit_Click(sender As System.Object, e As System.EventArgs) Handles cmdRefreshSubUnit.Click
        fillCombo(cboSubUnit, "SELECT UnitName FROM tblAccountSubUnits ORDER BY SubUnitID")
        fillCombo(cboSubUnitID, "SELECT SubUnitID FROM tblAccountSubUnits ORDER BY SubUnitID")
    End Sub

    Private Sub cmdRefreshDepartment_Click(sender As System.Object, e As System.EventArgs) Handles cmdRefreshDepartment.Click
        fillCombo(cboDepartment, "SELECT DeptName FROM tblAccountDepartment ORDER BY DeptID")
        fillCombo(cboAccountDepartmentID, "SELECT DeptID FROM tblAccountDepartment ORDER BY DeptID")
    End Sub

    Private Sub cmdRefreshClassification_Click(sender As System.Object, e As System.EventArgs) Handles cmdRefreshClassification.Click
        fillCombo(cboClassification, "SELECT ClassName FROM tblAccountClass ORDER BY ClassID")
        fillCombo(cboClassID, "SELECT ClassID FROM tblAccountClass ORDER BY ClassID")
    End Sub

    Private Sub cmdRefreshTpype_Click(sender As System.Object, e As System.EventArgs) Handles cmdRefreshTpype.Click

        fillCombo(cboType, "SELECT CategoryName FROM tblAccountsCategory ORDER BY CategoryID")
        fillCombo(cboTypeID, "SELECT CategoryID FROM tblAccountsCategory ORDER BY CategoryID")
    End Sub
End Class
