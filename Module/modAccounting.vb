'==========================================================================================
'Filename:      modAccounting.vb
'Type:          MODULE
'Date:          4.AUGUST.2012
'Notice:        ©2012 i4Link Systems, Inc. All rights reserved.
'
'Purpose:       Use for Accounting on enrollment

'Programmer:        Philip Cesar B. Garay
'===========================================================================================

Option Explicit On

Imports MySql.Data.MySqlClient
Imports System.Windows.Forms


Module modAccounting

    Public Structure tAccounting
        Dim AcctID As Integer
        Dim AccountCode As String
        Dim AccountName As String
        Dim ShortName As String
        Dim FundID As String
        Dim SubFundID As String
        Dim SubUnit As String
        Dim DepartmentID As String
        Dim ClassificationID As String
        Dim CategoryID As String
        Dim GLID As String

        Dim AccountOptionID As String
        Dim PaymentOptionID As String

        Dim RecDebitAccount As String
        Dim RecCreditAccount As String

        Dim ColCreditAccount As String

        Dim InActive As Short
    End Structure

    Public Structure tFundGroups
        Dim IndexID As Integer
        Dim GroupCode As String
        Dim GroupName As String
        Dim ShortName As String
    End Structure

    Public Structure tSubFund
        Dim IndexID As Integer
        Dim SubFundCode As String
        Dim SubFundName As String
        Dim SubFundShortName As String
    End Structure

    Public Structure tSubUnits
        Dim IndexID As Integer
        Dim UnitCode As String
        Dim UnitName As String
        Dim ShortName As String
    End Structure

    Public Structure tAccountDepartment
        Dim IndexID As Integer
        Dim DeptCode As String
        Dim DeptName As String
        Dim ShortName As String
    End Structure

    Public Structure tAccountClassification
        Dim IndexID As Integer
        Dim ClassCode As String
        Dim ClassName As String
        Dim ShortName As String
    End Structure

    Public Structure tAccountCategory
        Dim IndexID As Integer
        Dim TypeCode As String
        Dim TypeName As String
        Dim ShortName As String
    End Structure

    Public Structure tAccountGLCode
        Dim IndexID As Integer
        Dim GLCode As String
        Dim GLName As String
        Dim ShortName As String
    End Structure

    Public Structure tSubsidiaryCode
        Dim IndexID As Integer
        Dim SubCode As String
        Dim SubName As String
        Dim ShortName As String
    End Structure

    Public Structure tAccountOptions
        Dim AcctOptionID As String
        Dim AcctOptionName As String
        Dim AcctOptionDesc As String
        Dim Seqno As Integer
        Dim InActive As Short
    End Structure


    ' ================================== CHARTS OF ACCOUNTS ============================================================

    Public Function AccountsRecordExists() As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblAccounts", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            AccountsRecordExists = TranDBResult.Success
        Else
            AccountsRecordExists = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function AccountsExistsByCode(ByVal AcctCode As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblAccounts WHERE AcctCode = '" & AcctCode & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            AccountsExistsByCode = TranDBResult.Success
        Else
            AccountsExistsByCode = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function AccountsExistsByID(ByVal AcctID As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblAccounts WHERE AcctID = '" & AcctID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            AccountsExistsByID = TranDBResult.Success
        Else
            AccountsExistsByID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function GetAccountsByCode(ByVal AcctCode As String, ByRef Acct As tAccounting) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblAccounts WHERE AcctCode = '" & AcctCode & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            Acct.AccountCode = vRS("AcctCode").ToString()
            Acct.AccountName = vRS("AcctName").ToString()
            Acct.ShortName = vRS("ShortName").ToString()
            Acct.AccountOptionID = vRS("AcctOption").ToString()
            Acct.ClassificationID = vRS("ClassID").ToString()
            Acct.ColCreditAccount = vRS("GLID_Collection_Credit").ToString()
            Acct.DepartmentID = vRS("DeptID").ToString()
            Acct.AcctID = vRS("AcctID").ToString()
            Acct.CategoryID = vRS("CategoryID").ToString()
            Acct.FundID = vRS("GroupID").ToString()
            Acct.GLID = vRS("GLID").ToString()
            Acct.SubFundID = vRS("SubFundID").ToString()
            Acct.SubUnit = vRS("SubUnitID").ToString()
            Acct.RecDebitAccount = vRS("GLID_Setup_Debit").ToString()
            Acct.AccountOptionID = vRS("AcctOption").ToString()
            Acct.PaymentOptionID = vRS("PaymentOption").ToString()
            Acct.InActive = vRS("InActive").ToString()
            GetAccountsByCode = TranDBResult.Success
        Else
            GetAccountsByCode = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function GetAccountsByID(ByVal AcctID As String, ByRef Acct As tAccounting) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblAccounts WHERE AcctID = '" & AcctID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            Acct.AccountCode = vRS("AcctCode").ToString()
            Acct.AccountName = vRS("AcctName").ToString()
            Acct.ShortName = vRS("ShortName").ToString()
            Acct.AccountOptionID = vRS("AcctOption").ToString()
            Acct.ClassificationID = vRS("ClassID").ToString()
            Acct.ColCreditAccount = vRS("GLID_Collection_Credit").ToString()
            Acct.DepartmentID = vRS("DeptID").ToString()
            Acct.AcctID = vRS("AcctID").ToString()
            Acct.CategoryID = vRS("CategoryID").ToString()
            Acct.FundID = vRS("GroupID").ToString()
            Acct.GLID = vRS("GLID").ToString()
            Acct.SubFundID = vRS("SubFundID").ToString()
            Acct.SubUnit = vRS("SubUnitID").ToString()
            Acct.RecDebitAccount = vRS("GLID_Setup_Debit").ToString()
            Acct.AccountOptionID = vRS("AcctOption").ToString()
            Acct.PaymentOptionID = vRS("PaymentOption").ToString()
            Acct.InActive = vRS("InActive").ToString()
            GetAccountsByID = TranDBResult.Success
        Else
            GetAccountsByID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function SaveAccounts(ByVal Acct As tAccounting) As TranDBResult
        On Error GoTo err
        Dim com As New MySqlCommand("INSERT INTO tblAccounts(AcctCode,AcctName,ShortName,CategoryID,GroupID,ClassID,InActive,AcctOption,PaymentOption,GLID,SubFundID,SubUnitID,DeptID,GLID_Setup_Debit,GLID_Collection_Credit,CreatedBy,CreatedDate) VALUES " & _
                                    "('" & Acct.AccountCode & "','" & Acct.AccountName & "','" & Acct.ShortName & _
                                    "','" & Acct.CategoryID & "','" & Acct.FundID & "','" & Acct.ClassificationID & _
                                    "','" & Acct.InActive & "','" & Acct.AccountOptionID & "','" & Acct.PaymentOptionID & _
                                    "','" & Acct.RecCreditAccount & "','" & Acct.SubFundID & "','" & Acct.SubUnit & _
                                    "','" & Acct.DepartmentID & "','" & Acct.RecDebitAccount & "','" & Acct.ColCreditAccount & _
                                    "','" & CurrentUser.UserID & "',@Date)", con)
        com.Parameters.Add("@Date", MySqlDbType.Date).Value = DateTime.Now.Date
        com.ExecuteNonQuery()

        SaveAccounts = TranDBResult.Success

        Exit Function

err:
        DisplayErrorMsg("modAccounting", "SaveAccounts", Err.Number, Err.Description)
        SaveAccounts = TranDBResult.Failed
    End Function


    Public Function UpdateAccount(ByVal Acct As tAccounting) As TranDBResult
        On Error GoTo err
        If AccountsExistsByCode(Acct.AccountCode) = TranDBResult.Success Then

            Dim com As New MySqlCommand("UPDATE tblAccounts SET AcctCode='" & Acct.AccountCode & _
                                        "',AcctName='" & Acct.AccountName & "',ShortName='" & Acct.ShortName & _
                                        "',CategoryID='" & Acct.CategoryID & "',GroupID='" & Acct.FundID & _
                                        "',ClassID='" & Acct.ClassificationID & "', InActive='" & Acct.InActive & _
                                        "',AcctOption='" & Acct.AccountOptionID & "',PaymentOption='" & Acct.PaymentOptionID & _
                                        "',GLID='" & Acct.GLID & "',SubFundID='" & Acct.SubFundID & "',SubUnitID='" & Acct.SubUnit & _
                                        "',DeptID='" & Acct.DepartmentID & "',GLID_Setup_Debit = '" & Acct.RecDebitAccount & _
                                        "',GLID_Collection_Credit='" & Acct.ColCreditAccount & "',ModifiedBy='" & CurrentUser.UserID & _
                                        "',ModifiedDate=@Date WHERE AcctID='" & Acct.AcctID & "'", con)
            com.Parameters.Add("@Date", MySqlDbType.Date).Value = DateTime.Now.Date
            com.ExecuteNonQuery()
            UpdateAccount = TranDBResult.Success
        End If
        Exit Function
err:
        DisplayErrorMsg("modAccounting", "UpdateAccount", Err.Number, Err.Description)
        UpdateAccount = TranDBResult.Failed

    End Function

    Public Function ExecuteDeleteAccounts(ByVal GLCode As String) As TranDBResult

        'check if record exist and if it is edited by other user
        If MsgBox("WARNING:" & vbNewLine & _
            "Deleting this ACCOUNT entry will affect all other record" & vbNewLine & vbNewLine & _
            "Delete this record anyway?", vbQuestion + vbYesNo, Application.ProductName) = vbYes Then

            If DeleteAccounts(GLCode) = TranDBResult.Success Then
                MsgBox("ACCOUNT entry and other related record succesfully deleted.", vbInformation)
                ExecuteDeleteAccounts = TranDBResult.Success
            Else
                MsgBox("Deleting ACCOUNT entry went failed.", vbExclamation)
                ExecuteDeleteAccounts = TranDBResult.Failed
            End If
        Else
            ExecuteDeleteAccounts = TranDBResult.Failed
        End If
    End Function

    Public Function DeleteAccounts(ByVal AcctCode As String) As TranDBResult

        Try
            Dim com As New MySqlCommand("Delete From tblAccounts WHERE AcctCode='" & AcctCode & "'", clsCon.con)
            com.ExecuteNonQuery()
            DeleteAccounts = TranDBResult.Success

        Catch ex As Exception
            DeleteAccounts = TranDBResult.Failed
        End Try

    End Function


    '# ========================================= ACCOUNT OPTIONS ========================================================= #

    Public Function GetAccountOptionsByID(ByVal AcctOptionID As String, ByRef Act As tAccountOptions) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblAccountOptions WHERE AcctOptionID='" & AcctOptionID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            Act.AcctOptionDesc = vRS("AcctOptionDesc").ToString()
            Act.AcctOptionID = vRS("AcctOptionID").ToString()
            Act.AcctOptionName = vRS("AcctOptionName").ToString()
            Act.InActive = vRS("InActive").ToString()
            Act.Seqno = vRS("SeqNo").ToString()
            GetAccountOptionsByID = TranDBResult.Success
        Else
            GetAccountOptionsByID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    '=====================================SUBSIDIARY CODES========================================================
    Public Function SubsidiaryCodeRecordExists() As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblSubsidiaryCode", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            SubsidiaryCodeRecordExists = TranDBResult.Success
        Else
            SubsidiaryCodeRecordExists = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function SubsidiaryCodeExistByCode(ByVal SubsidiaryCode As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblSubsidiaryCode WHERE SubCode='" & SubsidiaryCode & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            SubsidiaryCodeExistByCode = TranDBResult.Success
        Else
            SubsidiaryCodeExistByCode = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function GetSubsidiaryCodeByCode(ByVal SubsidiaryCode As String, ByRef tSubsi As tSubsidiaryCode) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblSubsidiaryCode WHERE SubCode='" & SubsidiaryCode & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            tSubsi.SubCode = vRS("SubCode").ToString()
            tSubsi.IndexID = vRS("IndexID").ToString()
            tSubsi.ShortName = vRS("ShortName").ToString()
            tSubsi.SubName = vRS("SubDescription").ToString()
            GetSubsidiaryCodeByCode = TranDBResult.Success
        Else
            GetSubsidiaryCodeByCode = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function GetSubsidiaryCodeByID(ByVal SubsidiaryID As String, ByRef tSubsi As tSubsidiaryCode) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblSubsidiaryCode WHERE IndexID='" & SubsidiaryID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            tSubsi.SubCode = vRS("SubCode").ToString()
            tSubsi.IndexID = vRS("IndexID").ToString()
            tSubsi.ShortName = vRS("ShortName").ToString()
            tSubsi.SubName = vRS("SubDescription").ToString()
            GetSubsidiaryCodeByID = TranDBResult.Success
        Else
            GetSubsidiaryCodeByID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function SaveSubsidiaryCode(ByVal tSub As tSubsidiaryCode) As TranDBResult

        If SubsidiaryCodeExistByCode(tSub.SubCode) = TranDBResult.Success Then
            SaveSubsidiaryCode = TranDBResult.DuplicateCode
            Exit Function
        End If

        Dim com As New MySqlCommand("INSERT INTO tblSubsidiaryCode (SubCode,ShortName,SubDescription) VALUES ('" & tSub.SubCode & "','" & tSub.ShortName & "','" & tSub.ShortName & "')", con)
        com.ExecuteNonQuery()
        SaveSubsidiaryCode = TranDBResult.Success

    End Function

    Public Function UpdateSubsidiaryCode(ByVal SubCode As String, ByVal tSub As tSubsidiaryCode) As TranDBResult

        If SubsidiaryCodeExistByCode(tSub.SubCode) = TranDBResult.Success Then

            Dim com As New MySqlCommand("UPDATE FROM tblSubsidiaryCode SET SubCode='" & tSub.SubCode & _
                                        "', ShortName='" & tSub.ShortName & "', SubDescription='" & tSub.SubName & "' WHERE SubCode='" & SubCode & "'", con)

            com.ExecuteNonQuery()

            UpdateSubsidiaryCode = TranDBResult.Success
        End If

    End Function

    Public Function ExecuteDeleteSubsidiaryCode(ByVal SubCode As String) As TranDBResult

        'check if record exist and if it is edited by other user
        If MsgBox("WARNING:" & vbNewLine & _
            "Deleting this SUBSIDIARY CODE entry will affect all other record" & vbNewLine & vbNewLine & _
            "Delete this record anyway?", vbQuestion + vbYesNo, Application.ProductName) = vbYes Then

            If DeleteSubsidiaryCode(SubCode) = TranDBResult.Success Then
                MsgBox("SUBSIDIARY CODE entry and other related record succesfully deleted.", vbInformation)
                ExecuteDeleteSubsidiaryCode = TranDBResult.Success
            Else
                MsgBox("Deleting SUBSIDIARY CODE entry went failed.", vbExclamation)
                ExecuteDeleteSubsidiaryCode = TranDBResult.Failed
            End If
        Else
            ExecuteDeleteSubsidiaryCode = TranDBResult.Failed
        End If
    End Function

    Public Function DeleteSubsidiaryCode(ByVal SubCode As String) As TranDBResult
        DeleteSubsidiaryCode = TranDBResult.Failed

        Dim com As New MySqlCommand("Delete From tblSubsidiaryCode WHERE SubCode='" & SubCode & "'", clsCon.con)
        com.ExecuteNonQuery()
        DeleteSubsidiaryCode = TranDBResult.Success

    End Function


    '============================================== ACCOUNT FUNDS/GROUPS =======================================================
    Public Function AccountFundRecordExists() As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblAccountGroups", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            AccountFundRecordExists = TranDBResult.Success
        Else
            AccountFundRecordExists = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function AccountFundExistByCode(ByVal GroupCode As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblAccountGroups WHERE GroupCode='" & GroupCode & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            AccountFundExistByCode = TranDBResult.Success
        Else
            AccountFundExistByCode = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function AccountFundExistByID(ByVal GroupCode As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblAccountGroups WHERE GroupID='" & GroupCode & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            AccountFundExistByID = TranDBResult.Success
        Else
            AccountFundExistByID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function GetAccountFundByCode(ByVal GroupCode As String, ByRef tFund As tFundGroups) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblAccountGroups WHERE GroupCode='" & GroupCode & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            tFund.GroupCode = vRS("GroupCode").ToString()
            tFund.GroupName = vRS("GroupName").ToString()
            tFund.IndexID = vRS("GroupID").ToString()
            tFund.ShortName = vRS("GroupShort").ToString()
            GetAccountFundByCode = TranDBResult.Success
        Else
            GetAccountFundByCode = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function GetAccountFundByID(ByVal GroupID As String, ByRef tFund As tFundGroups) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblAccountGroups WHERE GroupID='" & GroupID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            tFund.GroupCode = vRS("GroupCode").ToString()
            tFund.GroupName = vRS("GroupName").ToString()
            tFund.IndexID = vRS("GroupID").ToString()
            tFund.ShortName = vRS("GroupShort").ToString()
            GetAccountFundByID = TranDBResult.Success
        Else
            GetAccountFundByID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function GetAccountFundByAccountID(ByVal AccountID As String, ByRef tFund As tFundGroups) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblAccountGroups WHERE GroupID IN ( SELECT GroupID FROM tblAccounts WHERE AccountID = '" & AccountID & "')", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            tFund.GroupCode = vRS("GroupCode").ToString()
            tFund.GroupName = vRS("GroupName").ToString()
            tFund.IndexID = vRS("GroupID").ToString()
            tFund.ShortName = vRS("GroupShort").ToString()
            GetAccountFundByAccountID = TranDBResult.Success
        Else
            GetAccountFundByAccountID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function SaveAccountFund(ByVal tFund As tFundGroups) As TranDBResult

        If AccountFundExistByCode(tFund.GroupCode) = TranDBResult.Success Then
            SaveAccountFund = TranDBResult.DuplicateCode
            Exit Function
        End If

        Dim com As New MySqlCommand("INSERT INTO tblAccountGroups(GroupCode,GroupName,GroupShort) VALUES ('" & tFund.GroupCode & "','" & tFund.GroupName & "','" & tFund.ShortName & "')", con)
        com.ExecuteNonQuery()

        SaveAccountFund = TranDBResult.Success
    End Function

    Public Function UpdateAccountFund(ByVal tFund As tFundGroups) As TranDBResult
        If AccountFundExistByID(tFund.IndexID) = TranDBResult.Success Then

            Dim com As New MySqlCommand("UPDATE tblAccountGroups SET GroupCode='" & tFund.GroupCode & "', GroupName='" & tFund.GroupName & _
                                        "', ShortName='" & tFund.ShortName & "' WHERE GroupID='" & tFund.IndexID & "'", con)
            com.ExecuteNonQuery()

            UpdateAccountFund = TranDBResult.Success
        End If
    End Function

    Public Function ExecuteDeleteAccountFund(ByVal GLCode As String) As TranDBResult

        'check if record exist and if it is edited by other user
        If MsgBox("WARNING:" & vbNewLine & _
            "Deleting this ACCOUNT FUND/GROUPS entry will affect all other record" & vbNewLine & vbNewLine & _
            "Delete this record anyway?", vbQuestion + vbYesNo, Application.ProductName) = vbYes Then

            If DeleteAccountFund(GLCode) = TranDBResult.Success Then
                MsgBox("ACCOUNT FUND/GROUPS entry and other related record succesfully deleted.", vbInformation)
                ExecuteDeleteAccountFund = TranDBResult.Success
            Else
                MsgBox("Deleting ACCOUNT FUND/GROUPS entry went failed.", vbExclamation)
                ExecuteDeleteAccountFund = TranDBResult.Failed
            End If
        Else
            ExecuteDeleteAccountFund = TranDBResult.Failed
        End If
    End Function

    Public Function DeleteAccountFund(ByVal GLCode As String) As TranDBResult
        DeleteAccountFund = TranDBResult.Failed

        Dim com As New MySqlCommand("Delete From tblAccountGroups WHERE GroupID='" & GLCode & "'", clsCon.con)
        com.ExecuteNonQuery()
        DeleteAccountFund = TranDBResult.Success

    End Function


    '============================================= ACcOUNT SUB FUND/GROUPS ======================================================
    Public Function SubFundRecordExists() As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblAccountSubGroups", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            SubFundRecordExists = TranDBResult.Success
        Else
            SubFundRecordExists = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function SubFundExistByCode(ByVal SubFundCode As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblAccountSubGroups WHERE GroupCode='" & SubFundCode & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            SubFundExistByCode = TranDBResult.Success
        Else
            SubFundExistByCode = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function SubFundExistByID(ByVal SubFundCode As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblAccountSubGroups WHERE SubGroupID='" & SubFundCode & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            SubFundExistByID = TranDBResult.Success
        Else
            SubFundExistByID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function GetSubFundExistByCode(ByVal SubFundCode As String, ByRef tFund As tSubFund) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblAccountSubGroups WHERE GroupCode='" & SubFundCode & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            tFund.IndexID = vRS("SubGroupID").ToString()
            tFund.SubFundCode = vRS("GroupCode").ToString()
            tFund.SubFundShortName = vRS("ShortName").ToString()
            GetSubFundExistByCode = TranDBResult.Success
        Else
            GetSubFundExistByCode = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function GetSubFundExistByID(ByVal SubFundID As String, ByRef tFund As tSubFund) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblAccountSubGroups WHERE SubGroupID='" & SubFundID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            tFund.IndexID = vRS("SubGroupID").ToString()
            tFund.SubFundCode = vRS("GroupCode").ToString()
            tFund.SubFundShortName = vRS("ShortName").ToString()
            GetSubFundExistByID = TranDBResult.Success
        Else
            GetSubFundExistByID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function SaveSubFund(ByVal tFund As tSubFund) As TranDBResult
        If SubFundExistByCode(tFund.SubFundCode) = TranDBResult.Success Then
            SaveSubFund = TranDBResult.DuplicateCode
            Exit Function
        End If

        Dim com As New MySqlCommand("INSERT INTO tblAccountSubGroups(GroupCode,ShortName,SubGroupName) VALUES('" & tFund.SubFundCode & "','" & tFund.SubFundShortName & "','" & tFund.SubFundName & "')", con)
        com.ExecuteNonQuery()

        SaveSubFund = TranDBResult.Success

    End Function

    Public Function UpdateSubFund(ByVal tFund As tSubFund) As TranDBResult
        If SubFundExistByID(tFund.SubFundCode) = TranDBResult.Success Then
            Dim com As New MySqlCommand("UPDATE tblAccountSubGroups SET GroupCode = '" & tFund.SubFundCode & _
                                     "',ShortName='" & tFund.SubFundShortName & "', SubGroupName='" & tFund.SubFundName & _
                                     "' WHERE SubGroupID='" & tFund.IndexID & "'", con)
            com.ExecuteNonQuery()
            UpdateSubFund = TranDBResult.Success
        End If
    End Function


    Public Function ExecuteDeleteAccountSubFund(ByVal GLCode As String) As TranDBResult

        'check if record exist and if it is edited by other user
        If MsgBox("WARNING:" & vbNewLine & _
            "Deleting this ACCOUNT SUB FUND/GROUPS entry will affect all other record" & vbNewLine & vbNewLine & _
            "Delete this record anyway?", vbQuestion + vbYesNo, Application.ProductName) = vbYes Then

            If DeleteAccountSubFund(GLCode) = TranDBResult.Success Then
                MsgBox("ACCOUNT SUB FUND/GROUPS entry and other related record succesfully deleted.", vbInformation)
                ExecuteDeleteAccountSubFund = TranDBResult.Success
            Else
                MsgBox("Deleting ACCOUNT SUB  FUND/GROUPS entry went failed.", vbExclamation)
                ExecuteDeleteAccountSubFund = TranDBResult.Failed
            End If
        Else
            ExecuteDeleteAccountSubFund = TranDBResult.Failed
        End If
    End Function

    Public Function DeleteAccountSubFund(ByVal GLCode As String) As TranDBResult
        DeleteAccountSubFund = TranDBResult.Failed

        Dim com As New MySqlCommand("Delete From tblAccountSubGroups WHERE SubGroupID='" & GLCode & "'", clsCon.con)
        com.ExecuteNonQuery()
        DeleteAccountSubFund = TranDBResult.Success

    End Function

    '============================================== ACCOUNT SUB UNITS =============================================================
    Public Function SubUnitsRecordExists() As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblAccountSubUnits", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            SubUnitsRecordExists = TranDBResult.Success
        Else
            SubUnitsRecordExists = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function SubUnitsExistByCode(ByVal UnitCode As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblAccountSubUnits WHERE UnitCode='" & UnitCode & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            SubUnitsExistByCode = TranDBResult.Success
        Else
            SubUnitsExistByCode = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function SubUnitsExistByID(ByVal SubUnitID As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblAccountSubUnits WHERE SubUnitID='" & SubUnitID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            SubUnitsExistByID = TranDBResult.Success
        Else
            SubUnitsExistByID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function
    Public Function GetSubUnitsByCode(ByVal UnitCode As String, ByRef tUnits As tSubUnits) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblAccountSubUnits WHERE UnitCode='" & UnitCode & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            tUnits.IndexID = vRS("SubUnitID").ToString()
            tUnits.UnitCode = vRS("UnitCode").ToString()
            tUnits.UnitName = vRS("UnitName").ToString()
            tUnits.ShortName = vRS("ShortName").ToString()
            GetSubUnitsByCode = TranDBResult.Success
        Else
            GetSubUnitsByCode = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function GetSubUnitsByID(ByVal UnitID As String, ByRef tUnits As tSubUnits) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblAccountSubUnits WHERE SubUnitID='" & UnitID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            tUnits.IndexID = vRS("SubUnitID").ToString()
            tUnits.UnitCode = vRS("UnitCode").ToString()
            tUnits.UnitName = vRS("UnitName").ToString()
            tUnits.ShortName = vRS("ShortName").ToString()
            GetSubUnitsByID = TranDBResult.Success
        Else
            GetSubUnitsByID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function
    Public Function SaveSubUnits(ByVal tUnits As tSubUnits) As TranDBResult
        If SubUnitsExistByCode(tUnits.UnitCode) = TranDBResult.Success Then
            SaveSubUnits = TranDBResult.DuplicateCode
            Exit Function
        End If

        Dim com As New MySqlCommand("INSERT INTO tblAccountSubUnits(UnitCode,UnitName,ShortName) VALUES ('" & tUnits.UnitCode & _
                                    "','" & tUnits.UnitName & "','" & tUnits.ShortName & "')", con)
        com.ExecuteNonQuery()
        SaveSubUnits = TranDBResult.Success
    End Function

    Public Function UpdateSubUnits(ByVal tUnits As tSubUnits) As TranDBResult
        If SubUnitsExistByID(tUnits.IndexID) = TranDBResult.Success Then
            Dim com As New MySqlCommand("UPDATE tblAccountSubUnits SET UnitCode ='" & tUnits.UnitCode & "',UnitName='" & tUnits.UnitName & "',ShortName='" & tUnits.ShortName & "' WHERE SubUnitID='" & tUnits.IndexID & "'", con)
            com.ExecuteNonQuery()
            UpdateSubUnits = TranDBResult.Success
        End If
    End Function


    Public Function ExecuteDeleteAccountSubUnits(ByVal GLCode As String) As TranDBResult

        'check if record exist and if it is edited by other user
        If MsgBox("WARNING:" & vbNewLine & _
            "Deleting this ACCOUNT SUB FUND/GROUPS entry will affect all other record" & vbNewLine & vbNewLine & _
            "Delete this record anyway?", vbQuestion + vbYesNo, Application.ProductName) = vbYes Then

            If DeleteAccountSubUnits(GLCode) = TranDBResult.Success Then
                MsgBox("ACCOUNT SUB FUND/GROUPS entry and other related record succesfully deleted.", vbInformation)
                ExecuteDeleteAccountSubUnits = TranDBResult.Success
            Else
                MsgBox("Deleting ACCOUNT SUB  FUND/GROUPS entry went failed.", vbExclamation)
                ExecuteDeleteAccountSubUnits = TranDBResult.Failed
            End If
        Else
            ExecuteDeleteAccountSubUnits = TranDBResult.Failed
        End If
    End Function

    Public Function DeleteAccountSubUnits(ByVal GLCode As String) As TranDBResult
        DeleteAccountSubUnits = TranDBResult.Failed

        Dim com As New MySqlCommand("Delete From tblAccountSubUnits WHERE SubUnitID='" & GLCode & "'", clsCon.con)
        com.ExecuteNonQuery()
        DeleteAccountSubUnits = TranDBResult.Success

    End Function


    '=============================================ACCOUNT DEPARTMENT ========================================================
    Public Function AccountDepartmentExistsByCode(ByVal DeptCode As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblAccountDepartment WHERE DeptCode='" & DeptCode & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            AccountDepartmentExistsByCode = TranDBResult.Success
        Else
            AccountDepartmentExistsByCode = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function AccountDepartmentExistsByID(ByVal DeptID As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblAccountDepartment WHERE DeptID='" & DeptID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            AccountDepartmentExistsByID = TranDBResult.Success
        Else
            AccountDepartmentExistsByID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function AccountDepartmentRecordExists() As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblAccountDepartment", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            AccountDepartmentRecordExists = TranDBResult.Success
        Else
            AccountDepartmentRecordExists = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function GetAccountDepartmentByCode(ByVal DeptCode As String, ByRef Dept As tAccountDepartment) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblAccountDepartment WHERE DeptCode='" & DeptCode & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            Dept.IndexID = vRS("DeptID").ToString()
            Dept.DeptCode = vRS("DeptCode").ToString()
            Dept.DeptName = vRS("DeptName").ToString()
            Dept.ShortName = vRS("DeptShort").ToString()
            GetAccountDepartmentByCode = TranDBResult.Success
        Else
            GetAccountDepartmentByCode = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function GetAccountDepartmentByID(ByVal DeptID As String, ByRef Dept As tAccountDepartment) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblAccountDepartment WHERE DeptID='" & DeptID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            Dept.IndexID = vRS("DeptID").ToString()
            Dept.DeptCode = vRS("DeptCode").ToString()
            Dept.DeptName = vRS("DeptName").ToString()
            Dept.ShortName = vRS("DeptShort").ToString()

            GetAccountDepartmentByID = TranDBResult.Success
        Else
            GetAccountDepartmentByID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function SaveAccountDepartment(ByVal Dept As tAccountDepartment) As TranDBResult
        If AccountDepartmentExistsByCode(Dept.DeptCode) = TranDBResult.Success Then
            SaveAccountDepartment = TranDBResult.DuplicateCode
            Exit Function
        End If

        Dim com As New MySqlCommand("INSERT INTO tblAccountDepartment (DeptCode,DeptName,DeptShort) VALUES ('" & Dept.DeptCode & _
                                    "','" & Dept.DeptName & "','" & Dept.ShortName & "')", con)
        com.ExecuteNonQuery()

        SaveAccountDepartment = TranDBResult.Success

    End Function

    Public Function UpdateAccountDepartment(ByVal Dept As tAccountDepartment) As TranDBResult
        If AccountDepartmentExistsByID(Dept.IndexID) = TranDBResult.Success Then
            Dim com As New MySqlCommand("UPDATE tblAccountDepartment SET DeptCode='" & Dept.DeptCode & "',DeptName='" & Dept.DeptName & "',DeptShort='" & Dept.ShortName & _
                                        "' WHERE DeptID='" & Dept.IndexID & "'", con)
            com.ExecuteNonQuery()

            UpdateAccountDepartment = TranDBResult.Success
        End If
    End Function

    Public Function ExecuteDeleteAccountDepartment(ByVal GLCode As String) As TranDBResult

        'check if record exist and if it is edited by other user
        If MsgBox("WARNING:" & vbNewLine & _
            "Deleting this ACCOUNT DEPARTMENT entry will affect all other record" & vbNewLine & vbNewLine & _
            "Delete this record anyway?", vbQuestion + vbYesNo, Application.ProductName) = vbYes Then

            If DeleteAccountDepartment(GLCode) = TranDBResult.Success Then
                MsgBox("ACCOUNT DEPARTMENT entry and other related record succesfully deleted.", vbInformation)
                ExecuteDeleteAccountDepartment = TranDBResult.Success
            Else
                MsgBox("Deleting ACCOUNT DEPARTMENT entry went failed.", vbExclamation)
                ExecuteDeleteAccountDepartment = TranDBResult.Failed
            End If
        Else
            ExecuteDeleteAccountDepartment = TranDBResult.Failed
        End If
    End Function

    Public Function DeleteAccountDepartment(ByVal GLCode As String) As TranDBResult
        DeleteAccountDepartment = TranDBResult.Failed

        Dim com As New MySqlCommand("Delete From tblAccountDepartment WHERE DeptID='" & GLCode & "'", clsCon.con)
        com.ExecuteNonQuery()
        DeleteAccountDepartment = TranDBResult.Success

    End Function



    '================================================ ACCOUNT CLASSIFICATION =============================================
    Public Function AccountClassificationRecordExists() As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblAccountClass", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            AccountClassificationRecordExists = TranDBResult.Success
        Else
            AccountClassificationRecordExists = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function AccountClassificationExistByCode(ByVal ClassCode As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblAccountClass WHERE ClassCode='" & ClassCode & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            AccountClassificationExistByCode = TranDBResult.Success
        Else
            AccountClassificationExistByCode = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function GetAccountClassificationByCode(ByVal ClassCode As String, ByRef Clas As tAccountClassification) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblAccountClass WHERE ClassCode='" & ClassCode & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            Clas.ClassCode = vRS("ClassCode").ToString()
            Clas.ClassName = vRS("ClassName").ToString()
            Clas.IndexID = vRS("ClassID").ToString()
            Clas.ShortName = vRS("ShortName").ToString()
            GetAccountClassificationByCode = TranDBResult.Success
        Else
            GetAccountClassificationByCode = TranDBResult.Failed
        End If
        vRS.Close()
    End Function


    Public Function GetAccountClassificationByID(ByVal ClassID As String, ByRef Clas As tAccountClassification) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblAccountClass WHERE ClassID='" & ClassID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            Clas.ClassCode = vRS("ClassCode").ToString()
            Clas.ClassName = vRS("ClassName").ToString()
            Clas.IndexID = vRS("ClassID").ToString()
            Clas.ShortName = vRS("ShortName").ToString()
            GetAccountClassificationByID = TranDBResult.Success
        Else
            GetAccountClassificationByID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function GetAccountClassificationByAccountID(ByVal AccountID As String, ByRef Clas As tAccountClassification) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblAccountClass WHERE ClassID IN (SELECT ClassID FROM tblAccounts WHERE AccountID='" & AccountID & "')", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            Clas.ClassCode = vRS("ClassCode").ToString()
            Clas.ClassName = vRS("ClassName").ToString()
            Clas.IndexID = vRS("ClassID").ToString()
            Clas.ShortName = vRS("ShortName").ToString()
            GetAccountClassificationByAccountID = TranDBResult.Success
        Else
            GetAccountClassificationByAccountID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function SaveAccountClassification(ByVal Clas As tAccountClassification) As TranDBResult
        If AccountClassificationExistByCode(Clas.ClassCode) = TranDBResult.Success Then
            SaveAccountClassification = TranDBResult.DuplicateCode
            Exit Function
        End If

        Dim com As New MySqlCommand("INSERT INTO tblAccountClass(ClassCode,ClassName,ShortName) VALUES ('" & Clas.ClassCode & _
                                    "','" & Clas.ClassName & "','" & Clas.ShortName & "')", con)
        com.ExecuteNonQuery()

        SaveAccountClassification = TranDBResult.Success
    End Function

    Public Function ExecuteDeleteAccountClassification(ByVal GLCode As String) As TranDBResult

        'check if record exist and if it is edited by other user
        If MsgBox("WARNING:" & vbNewLine & _
            "Deleting this ACCOUNT CLASSIFICATION entry will affect all other record" & vbNewLine & vbNewLine & _
            "Delete this record anyway?", vbQuestion + vbYesNo, Application.ProductName) = vbYes Then

            If DeleteAccountClassification(GLCode) = TranDBResult.Success Then
                MsgBox("ACCOUNT CLASSIFICATION entry and other related record succesfully deleted.", vbInformation)
                ExecuteDeleteAccountClassification = TranDBResult.Success
            Else
                MsgBox("Deleting ACCOUNT CLASSIFICATION entry went failed.", vbExclamation)
                ExecuteDeleteAccountClassification = TranDBResult.Failed
            End If
        Else
            ExecuteDeleteAccountClassification = TranDBResult.Failed
        End If
    End Function

    Public Function DeleteAccountClassification(ByVal GLCode As String) As TranDBResult
        DeleteAccountClassification = TranDBResult.Failed

        Dim com As New MySqlCommand("Delete From tblAccountClass WHERE ClassCode='" & GLCode & "'", clsCon.con)
        com.ExecuteNonQuery()
        DeleteAccountClassification = TranDBResult.Success

    End Function


    '================================================== ACCOUNT CATEGORY ==================================================
    Public Function AccountCategoryRecordExists() As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblAccountsCategory", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            AccountCategoryRecordExists = TranDBResult.Success
        Else
            AccountCategoryRecordExists = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function AccountCategoryRecordExistByCode(ByVal CategoryCode As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblAccountsCategory WHERE CategoryCode='" & CategoryCode & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            AccountCategoryRecordExistByCode = TranDBResult.Success
        Else
            AccountCategoryRecordExistByCode = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function GetAccountCategoryRecordByCode(ByVal CategoryCode As String, ByRef Cat As tAccountCategory) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblAccountsCategory WHERE CategoryCode='" & CategoryCode & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            Cat.IndexID = vRS("CategoryID").ToString()
            Cat.TypeCode = vRS("CategoryCode").ToString()
            Cat.TypeName = vRS("CategoryName").ToString()
            Cat.ShortName = vRS("CategoryShort").ToString()
            GetAccountCategoryRecordByCode = TranDBResult.Success
        Else
            GetAccountCategoryRecordByCode = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function GetAccountCategoryRecordByID(ByVal CategoryID As String, ByRef Cat As tAccountCategory) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblAccountsCategory WHERE CategoryID='" & CategoryID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            Cat.IndexID = vRS("CategoryID").ToString()
            Cat.TypeCode = vRS("CategoryCode").ToString()
            Cat.TypeName = vRS("CategoryName").ToString()
            Cat.ShortName = vRS("CategoryShort").ToString()
            GetAccountCategoryRecordByID = TranDBResult.Success
        Else
            GetAccountCategoryRecordByID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function SaveAccountCategory(ByVal Cat As tAccountCategory) As TranDBResult
        If AccountCategoryRecordExistByCode(Cat.TypeCode) = TranDBResult.Success Then
            SaveAccountCategory = TranDBResult.DuplicateCode
            Exit Function
        End If

        Dim com As New MySqlCommand("INSERT INTO tblAccountsCategory(CategoryCode,CategoryName,CategoryShort) VALUES ('" & Cat.TypeCode & _
                                    "','" & Cat.TypeName & "','" & Cat.ShortName & "')", con)
        com.ExecuteNonQuery()

        SaveAccountCategory = TranDBResult.Success
    End Function

    Public Function UpdateAccountCategory(ByVal tYpeCode As String, ByVal Cat As tAccountCategory) As TranDBResult

        If AccountCategoryRecordExistByCode(Cat.TypeCode) = TranDBResult.Success Then

            Dim com As New MySqlCommand("UPDATE tblAccountsCategory SET CategoryCode='" & Cat.TypeCode & "', CategoryName ='" & Cat.TypeName & _
                                        "', CategoryShortName='" & Cat.ShortName & "' WHERE CategoryID = '" & tYpeCode & "'", con)
            com.ExecuteNonQuery()

            UpdateAccountCategory = TranDBResult.Success
        End If

    End Function


    Public Function ExecuteDeleteAccountCategory(ByVal GLCode As String) As TranDBResult

        'check if record exist and if it is edited by other user
        If MsgBox("WARNING:" & vbNewLine & _
            "Deleting this ACCOUNT CATEGORY entry will affect all other record" & vbNewLine & vbNewLine & _
            "Delete this record anyway?", vbQuestion + vbYesNo, Application.ProductName) = vbYes Then

            If DeleteAccountCategory(GLCode) = TranDBResult.Success Then
                MsgBox("ACCOUNT CATEGORY entry and other related record succesfully deleted.", vbInformation)
                ExecuteDeleteAccountCategory = TranDBResult.Success
            Else
                MsgBox("Deleting ACCOUNT CATEGORY entry went failed.", vbExclamation)
                ExecuteDeleteAccountCategory = TranDBResult.Failed
            End If
        Else
            ExecuteDeleteAccountCategory = TranDBResult.Failed
        End If
    End Function

    Public Function DeleteAccountCategory(ByVal GLCode As String) As TranDBResult
        DeleteAccountCategory = TranDBResult.Failed

        Dim com As New MySqlCommand("Delete From tblAccountsCategory WHERE CategoryCode='" & GLCode & "'", clsCon.con)
        com.ExecuteNonQuery()
        DeleteAccountCategory = TranDBResult.Success

    End Function


    '=========================================================== ACCOUNT GL CODE ===============================================
    Public Function AccountGLCodeRecordExists() As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblAccountGLCodes", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            AccountGLCodeRecordExists = TranDBResult.Success
        Else
            AccountGLCodeRecordExists = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function AccountGLCodeExistbyCode(ByVal GLCode As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblAccountGLCodes WHERE GLCode='" & GLCode & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            AccountGLCodeExistbyCode = TranDBResult.Success
        Else
            AccountGLCodeExistbyCode = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function AccountGLCodeExistByID(ByVal GLCode As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblAccountGLCodes WHERE GLID='" & GLCode & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            AccountGLCodeExistByID = TranDBResult.Success
        Else
            AccountGLCodeExistByID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function GetAccountGLCodeRecordByCode(ByVal GLCode As String, ByRef GL As tAccountGLCode) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblAccountGLCodes WHERE GLCode='" & GLCode & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            GL.GLCode = vRS("GLCode").ToString()
            GL.GLName = vRS("GLName").ToString()
            GL.ShortName = vRS("GLShort").ToString()
            GL.IndexID = vRS("GLID").ToString()
            GetAccountGLCodeRecordByCode = TranDBResult.Success
        Else
            GetAccountGLCodeRecordByCode = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function GetAccountGLCodeRecordByID(ByVal GLID As String, ByRef GL As tAccountGLCode) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblAccountGLCodes WHERE GLID='" & GLID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            GL.GLCode = vRS("GLCode").ToString()
            GL.GLName = vRS("GLName").ToString()
            GL.ShortName = vRS("GLShort").ToString()
            GL.IndexID = vRS("GLID").ToString()
            GetAccountGLCodeRecordByID = TranDBResult.Success
        Else
            GetAccountGLCodeRecordByID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function SaveAccountGLCode(ByVal GL As tAccountGLCode) As TranDBResult
        If AccountGLCodeExistbyCode(GL.GLCode) = TranDBResult.Success Then
            SaveAccountGLCode = TranDBResult.DuplicateCode
            Exit Function
        End If

        Dim com As New MySqlCommand("INSERT INTO tblAccountGLCodes(GLCode,GLName,GLShort) VALUES ('" & GL.GLCode & _
                                    "','" & GL.GLName & "','" & GL.ShortName & "')", con)
        com.ExecuteNonQuery()

        SaveAccountGLCode = TranDBResult.Success
    End Function

    Public Function UpdateAccountGLCode(ByVal GL As tAccountGLCode) As TranDBResult
        If AccountGLCodeExistByID(GL.IndexID) = TranDBResult.Success Then
            Dim com As New MySqlCommand("UPDATE tblAccountGLCodes SET GLCode='" & GL.GLCode & _
                                     "',GLName='" & GL.GLName & "',GLShort='" & GL.ShortName & "' WHERE GLID='" & GL.IndexID & "'", con)
            com.ExecuteNonQuery()
            UpdateAccountGLCode = TranDBResult.Success
        Else
            CatchError("modAccounting", "UpdateAccountGLCode", "Error")
            Exit Function
        End If
    End Function


    Public Function ExecuteDeleteAccountGLCode(ByVal GLCode As String) As TranDBResult

        'check if record exist and if it is edited by other user
        If MsgBox("WARNING:" & vbNewLine & _
            "Deleting this ACCOUNT GL entry will affect all other record" & vbNewLine & vbNewLine & _
            "Delete this record anyway?", vbQuestion + vbYesNo, Application.ProductName) = vbYes Then

            If DeleteAccountGL(GLCode) = TranDBResult.Success Then
                MsgBox("ACCOUNT GL entry and other related record succesfully deleted.", vbInformation)
                ExecuteDeleteAccountGLCode = TranDBResult.Success
            Else
                MsgBox("Deleting ACCOUNT GL entry went failed.", vbExclamation)
                ExecuteDeleteAccountGLCode = TranDBResult.Failed
            End If
        Else
            ExecuteDeleteAccountGLCode = TranDBResult.Failed
        End If
    End Function

    Public Function DeleteAccountGL(ByVal GLCode As String) As TranDBResult
        DeleteAccountGL = TranDBResult.Failed

        Dim com As New MySqlCommand("Delete From tblAccountGLCodes WHERE GLID='" & GLCode & "'", clsCon.con)
        com.ExecuteNonQuery()
        DeleteAccountGL = TranDBResult.Success

    End Function
End Module
