Option Explicit On

Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Module modAssessment

    Public Enum TransactionType
        Beginning_Balance = 0
        Enrollment = 1
        Add_Drop_Change_Subject = 2
        Transcript_of_Record = 3
        Thesis = 4
        Admission_Testing = 5
        Graduation = 6
        Other_Assessment = 15
        Cash_Receipt_Book = 20
        Debit_Credit_Memo = 60
        Credit_Refund = 70
        Non_Ledger = 98
        General_Journal_Book = 99
    End Enum
    Public Enum IDType
        Student = 1
        Scholar_Prov = 2
        Employee = 3
        Others = 4
    End Enum


    Public Structure RegistrationAssessment

        Dim EntryID As Integer
        Dim ServerDate As Date
        Dim TransDate As Date
        Dim TermID As Integer
        Dim CampusID As Integer
        Dim TransID As Integer
        Dim ReferenceNo As String ' EnrolmentID
        Dim Description As String
        Dim Particulars As String
        Dim Payor As String
        Dim AccountID As String
        Dim IDType As Integer
        Dim IDNo As String ' Student No.
        Dim CheckNo As String

        Dim Debit As Decimal
        Dim Credit As Decimal
        Dim Remarks As String

        Dim UserID As String
        Dim DateModified As Date
        Dim ModifiedBy As String
        Dim Assess_Fee As Decimal
        Dim Discount As Decimal

        Dim FirstPayment As Decimal
        Dim SecondPayment As Decimal
        Dim ThirdPayment As Decimal
        Dim FourthPayment As Decimal
        Dim FifthPayment As Decimal
        Dim PaymentDiscount As Decimal
        Dim ActualPayment As Decimal
        Dim Refund As Decimal

        Dim DMCMRefNo As String
        Dim TransType As Integer
        Dim TransRefNo As String
        Dim CreditMemo As Decimal

        Dim SeqNo As Integer

        Dim NonLedger As Short
        Dim Deferred As Short
        Dim SubCodeID As Integer

    End Structure

    Public Structure ES_Ledger
        Dim IndexID As Integer
        Dim TermID As Integer
        Dim StudentNo As String
        Dim TransDate As Date
        Dim TransCode As String
        Dim ReferenceNo As String
        Dim Debit As Decimal
        Dim Credit As Decimal
        Dim Balance As Decimal
        Dim Remarks As String
        Dim Posted As Short
        Dim PostedDate As Date

    End Structure

    Public Structure DetailedAccountsReceivable
        Dim IndexID As Integer
        Dim RefNo As String
        Dim IDNo As String
        Dim StudentName As String
        Dim AccountID As String
        Dim AccountCode As String
        Dim AccountName As String
        Dim ShortName As String
        Dim Assessment As Decimal
        Dim Payment As Decimal
        Dim PaymentDiscount As Decimal
        Dim Refund As Decimal
        Dim GroupID As Integer
        Dim GroupCode As String
        Dim GroupName As String
        Dim GroupShort As String
        Dim GroupSort As Integer
        Dim ClassID As Integer
        Dim ClassCode As String
        Dim ClassName As String
        Dim ClassShort As String
        Dim ClassSort As Integer
        Dim TermID As Integer
        Dim CampusID As Integer
        Dim ValidationDate As Date
    End Structure

    Public Structure FinancialTransaction
        Dim TransID As Integer
        Dim TransName As String
        Dim TransCode As String
        Dim Remarks As String
        Dim View_In_Accounting As Short
        Dim View_In_Cashier As Short
        Dim PayorStudent As Short
        Dim PayorEmployee As Short
        Dim PayroSchoProvider As Short
        Dim PayorOther As Short
        Dim OtherTransaction As Short
    End Structure


    Public Function IsSubjectWithFee(ByVal SubjectID As String, ByVal TermID As Integer) As Boolean
        Dim com As New MySqlCommand()
        com.CommandText = "SELECT * FROM tblSubjectWithFee SWF " & _
                            "WHERE SWF.TermID='" & TermID & "' AND SWF.SubjectID='" & SubjectID & "';"
        com.Connection = con
        Dim vrS As MySqlDataReader = com.ExecuteReader
        If vrS.HasRows Then
            IsSubjectWithFee = True
        Else
            IsSubjectWithFee = False
        End If
        vrS.Close()
    End Function

    Public Function GetAccountTuitionFeeID(ByVal StudentNo As String, ByVal TermID As Integer) As String
        Dim com As New MySqlCommand("SELECT fnGetAccountTuitionFeeID('" & StudentNo & "','" & TermID & "')", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            GetAccountTuitionFeeID = vRS(0).ToString()
        Else
            GetAccountTuitionFeeID = ""
        End If
        vRS.Close()
    End Function

    Public Function GetfnGetAccountTempTuitionFeeID(ByVal RefNo As String, ByVal TermID As Integer) As String
        Dim com As New MySqlCommand("SELECT fnGetAccountTempTuitionFeeID('" & RefNo & "','" & TermID & "')", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            GetfnGetAccountTempTuitionFeeID = vRS(0).ToString()
        Else
            GetfnGetAccountTempTuitionFeeID = ""
        End If
        vRS.Close()
    End Function

    Public Function GetTotalTuitionFeeAmount(ByVal sEnrolmentID As String, ByVal sUnits As Integer) As Decimal
        ' #--PURPOSED: get the total amount of TFAmount (RATE * total # of Units Enrolled)
        Dim com As New MySqlCommand("SELECT fnGetTuitionFeeAmount('" & sEnrolmentID & "','" & sUnits & "')", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            GetTotalTuitionFeeAmount = vRS(0).ToString()
        Else
            GetTotalTuitionFeeAmount = 0
        End If
        vRS.Close()
    End Function

    Public Function GetTotalTuitionFeeAmount_Temp(ByVal sEnrolmentID As String, ByVal sUnits As Integer) As Decimal
        ' #--PURPOSED: get the total amount of TFAmount (RATE * total # of Units Enrolled)
        Dim com As New MySqlCommand("SELECT fnGetTuitionFeeAmount_Temp('" & sEnrolmentID & "','" & sUnits & "')", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            GetTotalTuitionFeeAmount_Temp = vRS(0).ToString()
        Else
            GetTotalTuitionFeeAmount_Temp = 0
        End If
        vRS.Close()
    End Function



    Public Function GetTotalNetAssessment(ByVal TransType As Integer, ByVal ReferenceNo As String, ByVal IDType As Integer, ByVal IDNo As String) As Decimal
        Dim com As New MySqlCommand("SELECT fnTotalNetAssessment('" & TransType & "','" & ReferenceNo & "','" & IDType & "','" & IDNo & "')", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            GetTotalNetAssessment = vRS(0).ToString()
        Else
            GetTotalNetAssessment = 0
        End If
        vRS.Close()
    End Function

    Public Function GetTotalTempNetAssessment(ByVal TransType As Integer, ByVal ReferenceNo As String, ByVal IDType As Integer, ByVal IDNo As String) As Decimal
        Dim com As New MySqlCommand("SELECT fnTotalTempNetAssessment('" & TransType & "','" & ReferenceNo & "','" & IDType & "','" & IDNo & "')", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            GetTotalTempNetAssessment = vRS(0).ToString()
        Else
            GetTotalTempNetAssessment = 0
        End If
        vRS.Close()
    End Function

    Public Function fnGetStudentAssessedFees(ByVal TransType As Integer, ByVal ReferenceNo As String, ByVal IDType As Integer, ByVal IDNo As String) As Decimal
        Dim com As New MySqlCommand("SELECT fnStudentAssessedFees('" & TransType & "','" & ReferenceNo & "','" & IDType & "','" & IDNo & "')", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            fnGetStudentAssessedFees = vRS(0).ToString()
        Else
            fnGetStudentAssessedFees = 0
        End If
        vRS.Close()
    End Function

    Public Function fnGetStudentTempAssessedFees(ByVal TransType As Integer, ByVal ReferenceNo As String, ByVal IDType As Integer, ByVal IDNo As String) As Decimal
        Dim com As New MySqlCommand("SELECT fnStudentTempAssessedFees('" & TransType & "','" & ReferenceNo & "','" & IDType & "','" & IDNo & "')", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            fnGetStudentTempAssessedFees = vRS(0).ToString()
        Else
            fnGetStudentTempAssessedFees = 0
        End If
        vRS.Close()
    End Function


    Public Function GetAccountSubjectWithFee(SubjectID As String, ByRef AcctID As String, ByRef Amount As Decimal, ByRef Remarks As String) As Boolean
        Dim com As New MySqlCommand("SELECT AccountID,Amount, CONCAT(fnSubjectCode(SubjectID),' (',Amount,')') AS Remarks FROM tblSubjectWithFee WHERE SubjectID='" & SubjectID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            AcctID = vRS("AccountID").ToString()
            Amount = vRS("Amount").ToString()
            Remarks = vRS("Remarks").ToString()
            GetAccountSubjectWithFee = True
        Else
            GetAccountSubjectWithFee = False
        End If
        vRS.Close()
    End Function

    Public Function GetAccountDetailsOnFeeTemplate(ByVal AcctID As String, ByVal TemplateID As String, ByVal Units As Integer, ByRef Remarks As String) As Boolean
        Dim com As New MySqlCommand("SELECT AccountID,Amount,Remarks FROM tblTableOfFee_Details WHERE TemplateID='" & TemplateID & "' AND AccountID ='" & AcctID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            Remarks = vRS("Amount").ToString() & " @ " & Units & " Units"
        Else
            Remarks = ""
        End If
        vRS.Close()
    End Function

    Public Function GetStudentAssessedFees(ByVal TransID As Integer, ByVal EnrolmentID As String, ByVal AsOfDate As Date) As Boolean
        Dim com As New MySqlCommand("CALL GetStudentAssessedFees('" & TransID & "','" & EnrolmentID & "','" & AsOfDate & "')", con)
        Dim vrs As MySqlDataReader = com.ExecuteReader()
        vrs.Read()
        If vrs.HasRows Then
            GetStudentAssessedFees = True
        Else
            GetStudentAssessedFees = False
        End If
        vrs.Close()
    End Function

    Public Function GetStudentAssessedFees_Temp(ByVal TransID As Integer, ByVal EnrolmentID As String, ByVal AsOfDate As Date) As Boolean
        Dim com As New MySqlCommand("CALL GetStudentAssessedFees_Temp('" & TransID & "','" & EnrolmentID & "','" & AsOfDate & "')", con)
        Dim vrs As MySqlDataReader = com.ExecuteReader()
        vrs.Read()
        If vrs.HasRows Then
            GetStudentAssessedFees_Temp = True
        Else
            GetStudentAssessedFees_Temp = False
        End If
        vrs.Close()
    End Function

    Public Function SWFAccountExistInJournal_Temp(ByVal AccountID As String, ByVal EnrolmentID As String, ByVal TransType As Integer, _
                                             ByVal IDType As Integer) As Boolean
        Dim com As New MySqlCommand("SELECT AccountID FROM tblJournals_Temp WHERE AccountID='" & AccountID & "' AND ReferenceNo='" & EnrolmentID & _
                                    "' AND TransID='" & TransType & "' AND IDType='" & IDType & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            SWFAccountExistInJournal_Temp = True
        Else
            SWFAccountExistInJournal_Temp = False
        End If
        vRS.Close()
    End Function

    Public Function SWFAccountExistInJournal(ByVal AccountID As String, ByVal EnrolmentID As String, ByVal TransType As Integer, _
                                         ByVal IDType As Integer) As Boolean
        Dim com As New MySqlCommand("SELECT AccountID FROM tblJournals WHERE AccountID='" & AccountID & "' AND ReferenceNo='" & EnrolmentID & _
                                    "' AND TransID='" & TransType & "' AND IDType='" & IDType & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            SWFAccountExistInJournal = True
        Else
            SWFAccountExistInJournal = False
        End If
        vRS.Close()
    End Function

    Public Function SaveRegistrationAssessment(ByVal Reg As RegistrationAssessment, ByVal EnrollmentID As String, ByVal StudentID As String) As TranDBResult
        Try
            Dim com As New MySqlCommand("INSERT INTO tblJournals (TransDate, CampusID,TermID, TransID, ReferenceNo, AccountID, IDType,Payor,IDNo, Debit,Remarks,UserID,Assess_Fee,Discount,`1st Payment`, `2nd Payment`, `3rd Payment`,`4th Payment`,`5th Payment`,ActualPayment,TransType,TransRefNo,CreditMemo,SeqNo,NonLedger,Deferred,SubCodeID,DMCMRefNo) VALUES (CURDATE(),'" & _
                                            Reg.CampusID & "','" & Reg.TermID & "','" & Reg.TransID & "','" & Reg.ReferenceNo & "','" & Reg.AccountID & "','" & Reg.IDType & "','" & Reg.Payor & "','" & Reg.IDNo & "','" & Reg.Debit & "','" & Reg.Remarks & "','" & Reg.UserID & "','" & _
                                            Reg.Assess_Fee & "','" & Reg.Discount & "','" & Reg.FirstPayment & "','" & Reg.SecondPayment & "','" & Reg.ThirdPayment & "','" & Reg.FourthPayment & "','" & Reg.FifthPayment & "','" & Reg.ActualPayment & "','" & _
                                            Reg.TransType & "','" & Reg.TransRefNo & "','" & Reg.CreditMemo & "','" & Reg.SeqNo & "','" & Reg.NonLedger & "','" & Reg.Deferred & "','" & Reg.SubCodeID & "','" & Reg.DMCMRefNo & "')", con)
            com.ExecuteNonQuery()

            SaveRegistrationAssessment = TranDBResult.Success
        Catch ex As Exception
            SaveRegistrationAssessment = TranDBResult.Failed
        End Try
    End Function





    Public Function SaveFinancialAid(ByVal Reg As RegistrationAssessment, ByVal EnrolmentID As String, ByVal StudentNo As String) As TranDBResult
        Dim com As New MySqlCommand("UPDATE ")
    End Function


    Public Function SaveTempRegistrationAssessment(ByVal Reg As RegistrationAssessment, ByVal EnrollmentID As String, ByVal StudentID As String) As TranDBResult
        Try
            Dim com As New MySqlCommand("INSERT INTO tblJournals_Temp (TransDate, CampusID,TermID,TransID, ReferenceNo, AccountID, IDType, Payor, IDNo, Debit,Remarks,UserID,Assess_Fee,Discount,`1st Payment`, `2nd Payment`, `3rd Payment`,`4th Payment`,`5th Payment`,ActualPayment,TransType,TransRefNo,CreditMemo,SeqNo,NonLedger,Deferred,SubCodeID,DMCMRefNo) VALUES (CURDATE(),'" & _
                                             Reg.CampusID & "','" & Reg.TermID & "','" & Reg.TransID & "','" & Reg.ReferenceNo & "','" & Reg.AccountID & "','" & Reg.IDType & "','" & Reg.Payor & "','" & Reg.IDNo & "','" & Reg.Debit & "','" & Reg.Remarks & "','" & Reg.UserID & "','" & _
                                             Reg.Assess_Fee & "','" & Reg.Discount & "','" & Reg.FirstPayment & "','" & Reg.SecondPayment & "','" & Reg.ThirdPayment & "','" & Reg.FourthPayment & "','" & Reg.FifthPayment & "','" & Reg.ActualPayment & "','" & _
                                             Reg.TransType & "','" & Reg.TransRefNo & "','" & Reg.CreditMemo & "','" & Reg.SeqNo & "','" & Reg.NonLedger & "','" & Reg.Deferred & "','" & Reg.SubCodeID & "','" & Reg.DMCMRefNo & "')", con)
            com.ExecuteNonQuery()
            SaveTempRegistrationAssessment = TranDBResult.Success
        Catch ex As Exception
            SaveTempRegistrationAssessment = TranDBResult.Failed
        End Try
    End Function

    Public Function StudentOutStandingBalance(ByVal StudentNo As String, ByVal TermID As Integer) As Decimal
        Dim com As New MySqlCommand("SELECT fnOutStandingBalance('" & StudentNo & "','" & TermID & "')", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            StudentOutStandingBalance = vRS(0).ToString()
        Else
            StudentOutStandingBalance = 0
        End If
        vRS.Close()
    End Function

    Public Function GetTotalFirstPayment(ByVal TransID As Integer, ByVal ReferenceNo As String, ByVal IDType As Integer, ByVal IDNo As String) As Decimal
        Dim com As New MySqlCommand("SELECT fnGetTotalFirstPayment('" & TransID & "','" & ReferenceNo & "','" & IDType & "','" & IDNo & "')", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            GetTotalFirstPayment = vRS(0).ToString()
        Else
            GetTotalFirstPayment = 0
        End If
        vRS.Close()
    End Function

    Public Function GetTotalSecondPayment(ByVal TransID As Integer, ByVal ReferenceNo As String, ByVal IDType As Integer, ByVal IDNo As String) As Decimal
        Dim com As New MySqlCommand("SELECT fnGetTotalSecondPayment('" & TransID & "','" & ReferenceNo & "','" & IDType & "','" & IDNo & "')", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            GetTotalSecondPayment = vRS(0).ToString()
        Else
            GetTotalSecondPayment = 0
        End If
        vRS.Close()
    End Function

    Public Function GetTotalThirdPayment(ByVal TransID As Integer, ByVal ReferenceNo As String, ByVal IDType As Integer, ByVal IDNo As String) As Decimal
        Dim com As New MySqlCommand("SELECT fnGetTotalThirdPayment('" & TransID & "','" & ReferenceNo & "','" & IDType & "','" & IDNo & "')", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            GetTotalThirdPayment = vRS(0).ToString()
        Else
            GetTotalThirdPayment = 0
        End If
        vRS.Close()
    End Function

    Public Function GetTotalFourthPayment(ByVal TransID As Integer, ByVal ReferenceNo As String, ByVal IDType As Integer, ByVal IDNo As String) As Decimal
        Dim com As New MySqlCommand("SELECT fnGetTotalFourthPayment('" & TransID & "','" & ReferenceNo & "','" & IDType & "','" & IDNo & "')", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            GetTotalFourthPayment = vRS(0).ToString()
        Else
            GetTotalFourthPayment = 0
        End If
        vRS.Close()
    End Function

    Public Function GetTotalFifthPayment(ByVal TransID As Integer, ByVal ReferenceNo As String, ByVal IDType As Integer, ByVal IDNo As String) As Decimal
        Dim com As New MySqlCommand("SELECT fnGetTotalFifthPayment('" & TransID & "','" & ReferenceNo & "','" & IDType & "','" & IDNo & "')", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            GetTotalFifthPayment = vRS(0).ToString()
        Else
            GetTotalFifthPayment = 0
        End If
        vRS.Close()
    End Function

    Public Function GetTotalFinancialAid(ByVal TransType As Integer, ByVal RefNo As String, ByVal IDType As Integer, ByVal IDNo As String) As Decimal
        Dim com As New MySqlCommand("SELECT fnTotalFinancialAid('" & TransType & "','" & RefNo & "','" & IDType & "','" & IDNo & "')", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            GetTotalFinancialAid = vRS(0).ToString()
        Else
            GetTotalFinancialAid = 0
        End If
        vRS.Close()
    End Function

    Public Function GetTotalPaymentDiscount(ByVal TransType As Integer, ByVal RefNo As String, ByVal IDType As Integer, ByVal IDNo As String) As Decimal
        Dim com As New MySqlCommand("SELECT fnTotalPaymentDiscount('" & TransType & "','" & RefNo & "','" & IDType & "','" & IDNo & "')", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            GetTotalPaymentDiscount = vRS(0).ToString()
        Else
            GetTotalPaymentDiscount = 0
        End If
        vRS.Close()
    End Function


    '#========================================================= END OF ASSESSMENT ==================================================== 


    '# ============================================= FINANCIAL TRANSACTION =================================================

    Public Function FinancialTransactionRecordExists() As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblFinancialTransactions", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            FinancialTransactionRecordExists = TranDBResult.Success
        Else
            FinancialTransactionRecordExists = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function GetFinancialTransactionByID(ByVal TransID As String, ByRef Trans As FinancialTransaction) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblFinancialTransactions WHERE TransID='" & TransID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            Trans.OtherTransaction = vRS("OtherTransaction").ToString()
            Trans.PayorEmployee = vRS("PayorEmployee").ToString()
            Trans.PayorOther = vRS("PayorOther").ToString()
            Trans.PayorStudent = vRS("PayorStudent").ToString()
            Trans.PayroSchoProvider = vRS("PayorSchoProvider").ToString()
            Trans.Remarks = vRS("Remarks").ToString()
            Trans.TransCode = vRS("TransCode").ToString()
            Trans.TransID = vRS("TransID").ToString()
            Trans.TransName = vRS("TransName").ToString()
            Trans.View_In_Accounting = vRS("View In Accounting").ToString()
            Trans.View_In_Cashier = vRS("View In Cashier").ToString()

            GetFinancialTransactionByID = TranDBResult.Success
        Else
            GetFinancialTransactionByID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function IsStudentRegistrationValidated(ByVal StudentNo As String, ByVal TermID As Integer) As Boolean
        Dim com As New MySqlCommand("SELECT fnStudent_IsValidated('" & StudentNo & "','" & TermID & "')", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            Select Case vRS(0).ToString()
                Case 1
                    IsStudentRegistrationValidated = True
                Case 0
                    IsStudentRegistrationValidated = False
            End Select
        End If
        vRS.Close()
    End Function





    '#=========================================================== STUDENT LEDGER =====================================================

    Public Function StudentLedgerRecordExist(ByVal StudentNo As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblLedger WHERE StudentNo='" & StudentNo & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            StudentLedgerRecordExist = TranDBResult.Success
        Else
            StudentLedgerRecordExist = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function SaveStudentLedger(ByVal led As ES_Ledger) As TranDBResult
        If StudentLedgerRecordExist(led.StudentNo) = TranDBResult.Failed Then

            Try
                Dim com As New MySqlCommand("INSERT INTO tblLedger(TermID,StudentNo,TransDate,TransCode,ReferenceNo,Debit,Credit,Balance,Remarks,Posted,PostedDate) VALUES ('" & _
                                            led.TermID & "','" & led.StudentNo & "',@TranDate,'" & led.TransCode & "','" & led.ReferenceNo & "',@Debit,@Credit,@Balance,'" & led.Remarks & _
                                            "','" & led.Posted & "',@PostedDate)", con)
                com.Parameters.Add("@TranDate", MySqlDbType.Date).Value = led.TransDate
                com.Parameters.Add("@Debit", MySqlDbType.Decimal).Value = led.Debit
                com.Parameters.Add("@Credit", MySqlDbType.Decimal).Value = led.Credit
                com.Parameters.Add("@Balance", MySqlDbType.Decimal).Value = led.Balance
                com.Parameters.Add("@PostedDate", MySqlDbType.Date).Value = led.PostedDate
                com.ExecuteNonQuery()
                com.Parameters.Clear()

                SaveStudentLedger = TranDBResult.Success
            Catch ex As MySqlException
                SaveStudentLedger = TranDBResult.Failed
                DisplayErrorMsg("modAssessment", "SaveStudentLedger", ex.Number, ex.Message)
                Exit Function
            End Try
        Else
            SaveStudentLedger = TranDBResult.Failed
        End If
    End Function


    '# ========================================================= END OF STUDENT LEDGER ========================================================

    '# ========================================================= DETAILED ACCOUNTS RECEIVABLE =================================================

    Public Function StudentAccountReceivable(ByVal StudentNo As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblDetailedAccountReceivable WHERE IDNo='" & StudentNo & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            StudentAccountReceivable = TranDBResult.Success
        Else
            StudentAccountReceivable = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function SaveDetailedAccountsReceivable(ByVal AR As DetailedAccountsReceivable) As TranDBResult

        Try
            Dim com As New MySqlCommand("INSERT INTO tblDetailedAccountReceivable(RefNo,IDNo,StudentName,AccountID,AccountCode,AccountName,ShortName,Assessment,Payment,PaymentDiscount,Refund,GroupID,GroupCode,GroupName,GroupShort,ClassID,ClassCode,ClassName,ClassShort,TermID,CampusID,ValidationDate) VALUES('" & _
                                        AR.RefNo & "','" & AR.IDNo & "','" & AR.StudentName & "','" & AR.AccountID & "','" & AR.AccountCode & "','" & AR.AccountName & "','" & AR.ShortName & _
                                        "',@Assessment,@Payment,@PaymentDiscount,@Refund,'" & AR.GroupID & "','" & AR.GroupCode & "','" & AR.GroupName & "','" & AR.GroupShort & _
                                        "','" & AR.ClassID & "','" & AR.ClassCode & "','" & AR.ClassName & "','" & AR.ClassShort & "','" & AR.TermID & "','" & AR.CampusID & "',@ValidationDate)", con)
            com.Parameters.Add("@Assessment", MySqlDbType.Decimal).Value = AR.Assessment
            com.Parameters.Add("@Payment", MySqlDbType.Decimal).Value = AR.Payment
            com.Parameters.Add("@PaymentDiscount", MySqlDbType.Decimal).Value = AR.PaymentDiscount
            com.Parameters.Add("@Refund", MySqlDbType.Decimal).Value = AR.Refund
            com.Parameters.Add("@ValidationDate", MySqlDbType.Date).Value = AR.ValidationDate

            com.ExecuteNonQuery()
            com.Parameters.Clear()

            SaveDetailedAccountsReceivable = TranDBResult.Success
        Catch ex As Exception
            SaveDetailedAccountsReceivable = TranDBResult.Failed
        End Try
    End Function



End Module
