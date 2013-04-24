Imports System.Windows.Forms

Public Class pickAccount

    Dim tmpAcctName As String
    Dim tmpAcctID As String
    Dim tmpAcctCode As String

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click, lvItems.DoubleClick
        ReturnAccount()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        CancelAccount()
    End Sub
    Private Sub ReturnAccount()
        tmpAcctID = lvItems.FocusedItem.SubItems(1).Text
        tmpAcctName = lvItems.FocusedItem.SubItems(2).Text
        tmpAcctCode = lvItems.FocusedItem.Text
        Close()
    End Sub
    Private Sub CancelAccount()
        tmpAcctID = ""
        tmpAcctName = ""
        tmpAcctCode = ""
        Close()
    End Sub

    Public Sub ShowForm(Optional ByRef AcctName As String = "", Optional ByRef AcctCode As String = "", Optional ByRef AcctID As String = "")

        If AccountsRecordExists() = TranDBResult.Failed Then
            MsgBox("Unable to load LIST OF ACCOUNTS..." & vbNewLine & "The system found that there are no records exist in the database.", vbExclamation)
            Exit Sub
        End If

        FillListView("SELECT AcctCode,AcctID,AcctName FROM tblAccounts", lvItems, False)

        Me.ShowDialog()

        AcctName = tmpAcctName
        AcctID = tmpAcctID
        AcctCode = tmpAcctCode

    End Sub

    Private Sub cmdFind_Click(sender As System.Object, e As System.EventArgs) Handles cmdFind.Click
        If IsNumeric(txtFind.Text) Then
            FillListView("SELECT AcctCode,AcctID,AcctName FROM tblAccounts WHERE AcctCode ='" & txtFind.Text & "'", lvItems, False)
        Else
            FillListView("SELECT AcctCode,AcctID,AcctName FROM tblAccounts WHERE AcctName LIKE '%" & txtFind.Text & "%'", lvItems, False)
        End If

    End Sub

    Private Sub txtFind_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtFind.TextChanged
        If IsNumeric(txtFind.Text) Then
            FillListView("SELECT AcctCode,AcctID,AcctName FROM tblAccounts WHERE AcctCode ='" & txtFind.Text & "'", lvItems, False)
        Else
            FillListView("SELECT AcctCode,AcctID,AcctName FROM tblAccounts WHERE AcctName LIKE '%" & txtFind.Text & "%'", lvItems, False)
        End If
    End Sub
End Class
