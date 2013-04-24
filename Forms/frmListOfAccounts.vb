Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms

Public Class frmListOfAccounts
    Private dvMain As DataView

    Private Sub cmdAddAccount_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
        Dim frm As New frmAccountsAE
        frm.ShowForm()
    End Sub

    Private Sub frmListOfAccounts_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        FillFundGroup()
        FillAccountGrid()
    End Sub

    Private Sub FillAccountGrid()
        Dim com As New MySqlCommand("SELECT AcctCode AS `Acct. Code`,AcctID AS `Acct. ID`,AcctName AS `Acct. Name`,ShortName AS `Short Name`,fnAccountGroupName(GroupID) AS `Fund/Group`,fnAccountSubGroupName(SubFundID) AS `Sub Fund/Group`,fnAccountSubUnitName(SubUnitID) AS `Sub Unit`, " & _
                "fnAccountClassName(ClassID) AS `Classification`,fnAccountCategory(CategoryID) AS `Type`,fnAccountOptionName(AcctOption) AS `Account Options`, " & _
                "fnPaymentOptionName(PaymentOption) AS `Payment Option`,fnEmployeeName(CreatedBy) AS `Created By`,CreatedDate AS `Date Created`,fnEmployeeName(ModifiedBy) AS `Modified By`,ModifiedDate AS `Date Modified` FROM tblAccounts", con)


        Dim daAccount As New MySqlDataAdapter()
        Dim dsAccount As New DataSet()
        Dim BS As New BindingSource

        daAccount.SelectCommand = com
        daAccount.Fill(dsAccount)
        BS.DataSource = dsAccount.Tables(0).DefaultView

        dgAccounts.AutoGenerateColumns = True
        dgAccounts.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        dgAccounts.DataSource = BS

    End Sub

    Private Sub FillFundGroup()
        Dim com As New MySqlCommand("SELECT GroupCode AS `FUND CODE`,GroupName AS `FUND`,GroupShort AS `SHORT NAME`,GroupID AS `ID` FROM tblAccountGroups", con)
        Dim daAccount As New MySqlDataAdapter()
        Dim dsAccount As New DataSet



        daAccount.SelectCommand = com
        daAccount.Fill(dsAccount, "tblAccountGroups")
        Dim BS As BindingSource
        BS = New BindingSource(dsAccount, "tblAccountGroups")

        Dim dvm As DataViewManager = New DataViewManager(dsAccount)
        dvMain = dvm.CreateDataView(dsAccount.Tables("tblAccountGroups"))

        LookUpEdit1.DataBindings.Add("EditValue", dvMain, "ID")
        LookUpEdit1.Properties.DataSource = dvMain

        LookUpEdit1.Properties.DisplayMember = "FUND CODE"
        LookUpEdit1.Properties.ValueMember = "ID"
        LookUpEdit1.Properties.PopulateColumns()

        LookUpEdit1.Properties.SearchMode = SearchMode.AutoComplete
    End Sub


    Private Sub RefreshToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RefreshToolStripMenuItem.Click, RefreshToolStripButton.Click
        FillAccountGrid()
    End Sub

    Private Sub NewAccountsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NewAccountsToolStripMenuItem.Click, NewToolStripButton.Click
        Dim frm As New frmAccountsAE
        frm.ShowForm()
    End Sub

    Private Sub cmdSubsidiary_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdSubsidiary.LinkClicked
        Dim frm As New frmSubsidiaryCode
        frm.ShowDialog()
    End Sub

    Private Sub cmdFund_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdFund.LinkClicked
        Dim frm As New frmFundGroups
        frm.ShowForm()
    End Sub

    Private Sub cmdSubFund_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdSubFund.LinkClicked
        Dim frm As New frmSubFundAE
        frm.ShowForm()
    End Sub

    Private Sub cmdSubUnit_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdSubUnit.LinkClicked
        Dim frm As New frmSubUnits
        frm.ShowForm()
    End Sub

    Private Sub cmdAcctDept_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdAcctDept.LinkClicked
        Dim frm As New frmAccountDepartment
        frm.ShowForm()
    End Sub

    Private Sub cmdAcctClass_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdAcctClass.LinkClicked
        Dim frm As New frmAccountClass
        frm.ShowForm()
    End Sub

    Private Sub cmdAcctType_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdAcctType.LinkClicked
        Dim frm As New frmAccountType
        frm.ShowForm()
    End Sub
    Private Sub cmdAcctGL_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles cmdAcctGL.LinkClicked
        Dim frm As New frmAccountGL
        frm.ShowForm()
    End Sub

    Private Sub txtFind_ButtonClick(sender As System.Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtFind.ButtonClick
        Dim com As New MySqlCommand("SELECT AcctCode AS `Acct. Code`,AcctID AS `Acct. ID`,AcctName AS `Acct. Name`,ShortName AS `Short Name`,fnAccountGroupName(GroupID) AS `Fund/Group`,fnAccountSubGroupName(SubFundID) AS `Sub Fund/Group`,fnAccountSubUnitName(SubUnitID) AS `Sub Unit`, " & _
                "fnAccountClassName(ClassID) AS `Classification`,fnAccountCategory(CategoryID) AS `Type`,fnAccountOptionName(AcctOption) AS `Account Options`, " & _
                "fnPaymentOptionName(PaymentOption) AS `Payment Option`,fnEmployeeName(CreatedBy) AS `Created By`,CreatedDate AS `Date Created`,fnEmployeeName(ModifiedBy) AS `Modified By`,ModifiedDate AS `Date Modified` FROM tblAccounts " & _
                "WHERE AcctCode ='" & txtFind.Text & "' OR AcctName LIKE '%" & txtFind.Text & "%'", con)


        Dim daAccount As New MySqlDataAdapter()
        Dim dsAccount As New DataSet()
        Dim BS As New BindingSource

        daAccount.SelectCommand = com
        daAccount.Fill(dsAccount)
        BS.DataSource = dsAccount.Tables(0).DefaultView

        dgAccounts.AutoGenerateColumns = True
        dgAccounts.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        dgAccounts.DataSource = BS

    End Sub

    Private Sub chkAccount_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkAccount.CheckedChanged
        GroupControl1.Enabled = chkAccount.Checked
    End Sub

    Private Sub chkFund_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkFund.CheckedChanged
        GroupControl2.Enabled = chkFund.Checked
    End Sub

    Private Sub txtFind_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtFind.KeyDown
        If e.KeyCode = Keys.Enter Then

            Dim com As New MySqlCommand("SELECT AcctCode AS `Acct. Code`,AcctID AS `Acct. ID`,AcctName AS `Acct. Name`,ShortName AS `Short Name`,fnAccountGroupName(GroupID) AS `Fund/Group`,fnAccountSubGroupName(SubFundID) AS `Sub Fund/Group`,fnAccountSubUnitName(SubUnitID) AS `Sub Unit`, " & _
                "fnAccountClassName(ClassID) AS `Classification`,fnAccountCategory(CategoryID) AS `Type`,fnAccountOptionName(AcctOption) AS `Account Options`, " & _
                "fnPaymentOptionName(PaymentOption) AS `Payment Option`,fnEmployeeName(CreatedBy) AS `Created By`,CreatedDate AS `Date Created`,fnEmployeeName(ModifiedBy) AS `Modified By`,ModifiedDate AS `Date Modified` FROM tblAccounts " & _
                "WHERE AcctCode ='" & txtFind.Text & "' OR AcctName LIKE '%" & txtFind.Text & "%'", con)


            Dim daAccount As New MySqlDataAdapter()
            Dim dsAccount As New DataSet()
            Dim BS As New BindingSource

            daAccount.SelectCommand = com
            daAccount.Fill(dsAccount)
            BS.DataSource = dsAccount.Tables(0).DefaultView

            dgAccounts.AutoGenerateColumns = True
            dgAccounts.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
            dgAccounts.DataSource = BS

        End If
    End Sub

    Private Sub LookUpEdit1_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles LookUpEdit1.EditValueChanged

        Dim row As Object = LookUpEdit1.Properties.GetDataSourceRowByKeyValue(LookUpEdit1.EditValue)

        Dim com As New MySqlCommand("SELECT AcctCode AS `Acct. Code`,AcctID AS `Acct. ID`,AcctName AS `Acct. Name`,ShortName AS `Short Name`,fnAccountGroupName(GroupID) AS `Fund/Group`,fnAccountSubGroupName(SubFundID) AS `Sub Fund/Group`,fnAccountSubUnitName(SubUnitID) AS `Sub Unit`, " & _
                       "fnAccountClassName(ClassID) AS `Classification`,fnAccountCategory(CategoryID) AS `Type`,fnAccountOptionName(AcctOption) AS `Account Options`, " & _
                       "fnPaymentOptionName(PaymentOption) AS `Payment Option`,fnEmployeeName(CreatedBy) AS `Created By`,CreatedDate AS `Date Created`,fnEmployeeName(ModifiedBy) AS `Modified By`,ModifiedDate AS `Date Modified` FROM tblAccounts " & _
                       "WHERE GroupID='" & row("ID").ToString() & "'", con)


        Dim daAccount As New MySqlDataAdapter()
        Dim dsAccount As New DataSet()
        Dim BS As New BindingSource

        daAccount.SelectCommand = com
        daAccount.Fill(dsAccount)
        BS.DataSource = dsAccount.Tables(0).DefaultView

        dgAccounts.AutoGenerateColumns = True
        dgAccounts.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        dgAccounts.DataSource = BS
    End Sub

    Private Sub EditAccountToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EditAccountToolStripMenuItem.Click
        If dgAccounts.RowCount > 0 Then
            Dim frm As New frmAccountsAE
            frm.ShowEdit(dgAccounts.Rows(dgAccounts.CurrentRow.Index).Cells(0).Value.ToString())
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DeleteToolStripMenuItem.Click, DeleteToolStripButton.Click
        If dgAccounts.RowCount > 0 Then
            If ExecuteDeleteAccounts(dgAccounts.Rows(dgAccounts.CurrentRow.Index).Cells(0).Value.ToString()) = TranDBResult.Success Then
                FillAccountGrid()
            End If
        End If
    End Sub

    Private Sub dgAccounts_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgAccounts.CellDoubleClick
        If dgAccounts.RowCount > 0 Then
            Dim frm As New frmAccountsAE
            frm.ShowEdit(dgAccounts.Rows(dgAccounts.CurrentRow.Index).Cells(0).Value.ToString())
        End If
    End Sub

    Private Sub PrintToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles PrintToolStripButton.Click
        Dim frm As New frmPrintPreview
        'frm.ShowPrint("ListOfAccounts")
    End Sub
End Class
