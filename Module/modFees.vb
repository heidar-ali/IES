'==========================================================================================
'Filename:      modFees.vb
'Type:          MODULE
'Date:          6.AUGUST.2012
'Notice:        ©2012 i4Link Systems, Inc. All rights reserved.
'
'Purpose:       Use to create Table of Fees and Billing Profiles

'Programmer:        Philip Cesar B. Garay
'===========================================================================================

Option Explicit On

Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Module modFees

    Public Structure tTableofFees
        Dim TemplateID As Integer
        Dim TemplateCode As String
        Dim TemplateDisc As String
        Dim TemplateRemarks As String
        Dim SchoolYear As String
        Dim CampusID As String

        Dim ForForeign As Short
        Dim TransType As String
        Dim InActive As Short
        Dim Currency As String

        Dim StudentStatus As Short
        Dim StudentGender As Short

        Dim PaymentScheme As String
        Dim PaymentOption As String

        Dim LastModified As Date
        Dim ModifiedBy As String
    End Structure

    Public Structure tTableOfFeeDetails
        Dim ID As Integer
        Dim TemplateID As Integer
        Dim AccountID As Integer
        Dim Amount As Decimal
        Dim Remarks As String
        Dim ChargeMode As Short
        Dim InActive As Short
        Dim Currency As String
        Dim Succeeding As Decimal
        Dim Options As Integer
    End Structure

    Public Structure tTableOfFeeDistribution
        Dim ID As Integer
        Dim TemplateID As Integer
        Dim YearLevelID As Integer
    End Structure

    Public Structure PaymentOptions
        Dim PaymentOptionID As Integer
        Dim PaymentOptionName As String
        Dim PaymentDescription As String
        Dim SeqNo As Integer
        Dim InActive As Short
        Dim FirstPayment As Double
        Dim SecondPayment As Double
        Dim ThirdPayment As Double
        Dim FourthPayment As Double
        Dim FifthPayment As Double
        Dim SixthPayment As Double
        Dim SeventhPayment As Double
        Dim EightPayment As Double
        Dim NinthPayment As Double
        Dim TenthPayment As Double
    End Structure

    Public Structure SubjectWithFee
        Dim IndexID As Integer
        Dim CampusID As Integer
        Dim TermID As Integer
        Dim SubjectID As String
        Dim AccountID As Integer
        Dim Amount As Decimal
        Dim CurrencyID As Integer
        Dim ProgramID As String
        Dim YearLevelID As Integer
        Dim Remarks As String
        Dim CreatedBy As String
        Dim CreatedDate As Date
        Dim SucceedingAmount As Decimal
        Dim IsTFRate As Short
        Dim TFUnits As Double
        Dim IsLFRate As Short
        Dim LFUnits As Double
        Dim InclTF As Short
        Dim InclLF As Short
    End Structure


    Public Enum StudentStatus
        Both = 0
        sNew = 1
        Old = 2
    End Enum

    Public Enum StudentGender
        Both = 0
        Male = 1
        Female = 2
    End Enum

    Public Enum PaymentScheme
        Cash = 0
        Semestral = 1
        Quarterly = 2
        Monthly = 3
    End Enum

    Public Enum FeesTemplateTransType
        Enrollment = 1
        Graduation = 2
        Thesis = 3
    End Enum


    Public Function FeeTemplateRecordExists() As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblTableOfFees", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            FeeTemplateRecordExists = TranDBResult.Success
        Else
            FeeTemplateRecordExists = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function FeeTemplateExistsByCode(ByVal TemplateCode As String, Optional ByVal CampusID As Integer = 0, Optional ByVal TermID As Integer = 0) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblTableOfFees WHERE TemplateCode='" & TemplateCode & "' AND CampusID ='" & CampusID & "' AND SchoolYear ='" & TermID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            FeeTemplateExistsByCode = TranDBResult.Success
        Else
            FeeTemplateExistsByCode = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function FeeTemplateExistsByTemplateID(ByVal TemplateID As String, Optional ByVal CampusID As Integer = 0, Optional ByVal TermID As Integer = 0) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblTableOfFees WHERE TemplateID='" & TemplateID & "' AND CampusID ='" & CampusID & "' AND SchoolYear ='" & TermID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            FeeTemplateExistsByTemplateID = TranDBResult.Success
        Else
            FeeTemplateExistsByTemplateID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function GetFeeTemplateByTemplateCode(ByVal TemplateCode As String, ByRef Fee As tTableofFees) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblTableOfFees WHERE TemplateCode='" & TemplateCode & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            Fee.TemplateID = vRS("TemplateID").ToString()
            Fee.TemplateCode = vRS("TemplateCode").ToString()
            Fee.TemplateDisc = vRS("TemplateDesc").ToString()
            Fee.TemplateRemarks = vRS("TemplateRemarks").ToString()
            Fee.SchoolYear = vRS("SchoolYear").ToString()
            Fee.CampusID = vRS("CampusID").ToString()
            Fee.StudentGender = vRS("StudentGender").ToString()
            Fee.ForForeign = vRS("ForForeign").ToString()
            Fee.TransType = vRS("TransType").ToString()
            Fee.InActive = vRS("InActive").ToString()
            Fee.Currency = vRS("Currency").ToString()
            Fee.StudentStatus = vRS("StudentStatus").ToString()
            Fee.PaymentScheme = vRS("PaymentScheme").ToString()
            Fee.PaymentOption = vRS("PaymentOption").ToString()
            Fee.LastModified = vRS("LastModified").ToString()
            Fee.ModifiedBy = vRS("ModifiedBy").ToString()
            GetFeeTemplateByTemplateCode = TranDBResult.Success
        Else
            GetFeeTemplateByTemplateCode = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function GetFeeTemplateByTemplateID(ByVal TemplateID As String, ByRef Fee As tTableofFees) As TranDBResult
        On Error Resume Next
        Dim com As New MySqlCommand("SELECT * FROM tblTableOfFees WHERE TemplateID='" & TemplateID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            Fee.TemplateID = vRS("TemplateID").ToString()
            Fee.TemplateCode = vRS("TemplateCode").ToString()
            Fee.TemplateDisc = vRS("TemplateDesc").ToString()
            Fee.TemplateRemarks = vRS("TemplateRemarks").ToString()
            Fee.SchoolYear = vRS("SchoolYear").ToString()
            Fee.CampusID = vRS("CampusID").ToString()
            Fee.StudentGender = vRS("StudentGender").ToString()
            Fee.ForForeign = vRS("ForForeign").ToString()
            Fee.TransType = vRS("TransType").ToString()
            Fee.InActive = vRS("InActive").ToString()
            Fee.Currency = vRS("Currency").ToString()
            Fee.StudentStatus = vRS("StudentStatus").ToString()
            Fee.PaymentScheme = vRS("PaymentScheme").ToString()
            Fee.PaymentOption = vRS("PaymentOption").ToString()
            Fee.LastModified = vRS("LastModified").ToString()
            Fee.ModifiedBy = vRS("ModifiedBy").ToString()
            GetFeeTemplateByTemplateID = TranDBResult.Success
        Else
            GetFeeTemplateByTemplateID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function


    Public Function ExecuteDeleteFeeTemplate(ByVal sTemplateID As String) As TranDBResult

        'check if record exist and if it is edited by other user
        If MsgBox("WARNING:" & vbNewLine & _
            "Deleting this FEE TEMPLATE/BILLING PROFILE entry will affect all other record" & vbNewLine & vbNewLine & _
            "Delete this record anyway?", vbQuestion + vbYesNo, Application.ProductName) = vbYes Then

            If DeleteFeeTemplate(sTemplateID) = TranDBResult.Success Then
                MsgBox("FEE TEMPLATE/BILLING PROFILE entry and other related record succesfully deleted.", vbInformation)
                ExecuteDeleteFeeTemplate = TranDBResult.Success
            Else
                MsgBox("Deleting FEE TEMPLATE/BILLING PROFILE entry went failed.", vbExclamation)
                ExecuteDeleteFeeTemplate = TranDBResult.Failed
            End If
        Else
            ExecuteDeleteFeeTemplate = TranDBResult.Failed
        End If
    End Function

    Public Function DeleteFeeTemplate(ByVal sTemplateID As String) As TranDBResult
        DeleteFeeTemplate = TranDBResult.Failed

        Dim com As New MySqlCommand("Delete From tblTableOfFees WHERE TemplateID='" & sTemplateID & "'", clsCon.con)
        com.ExecuteNonQuery()
        DeleteFeeTemplate = TranDBResult.Success

    End Function

    Public Function SaveTableOfFees(ByVal Fee As tTableofFees) As TranDBResult

        If FeeTemplateExistsByCode(Fee.TemplateCode, Fee.CampusID, Fee.SchoolYear) = TranDBResult.Success Then
            SaveTableOfFees = TranDBResult.DuplicateCode
            Exit Function
        End If

        If FeeTemplateExistsByTemplateID(Fee.TemplateID, Fee.CampusID, Fee.SchoolYear) = TranDBResult.Success Then
            SaveTableOfFees = TranDBResult.DuplicateID
            Exit Function
        End If


        Dim com As New MySqlCommand("INSERT INTO tblTableOfFees(TemplateCode,TemplateDesc,TemplateRemarks,SchoolYear,TransType,InActive,Currency,StudentStatus,StudentGender,PaymentScheme,PaymentOption,CampusID) VALUES ('" & Fee.TemplateCode & _
                                    "','" & Fee.TemplateDisc & "','" & Fee.TemplateRemarks & "','" & Fee.SchoolYear & _
                                    "','" & Fee.TransType & "','" & Fee.InActive & "','" & Fee.Currency & "','" & Fee.StudentStatus & _
                                    "','" & Fee.StudentGender & "','" & Fee.PaymentScheme & "','" & Fee.PaymentOption & "','" & Fee.CampusID & "')", con)
        com.ExecuteNonQuery()

        SaveTableOfFees = TranDBResult.Success

    End Function
    Public Function UpdateTableOfFees(ByVal Fee As tTableofFees) As TranDBResult

        If FeeTemplateExistsByTemplateID(Fee.TemplateID) = TranDBResult.Success Then
            Dim com As New MySqlCommand("UPDATE tblTableOfFees SET TemplateCode ='" & Fee.TemplateCode & ",TemplateDesc='" & Fee.TemplateDisc & _
                                        "',TemplateRemarks= '" & Fee.TemplateRemarks & "',SchoolYear='" & Fee.SchoolYear & "',Currency='" & Fee.Currency & _
                                        "',InActive='" & Fee.InActive & "',StudentStatus='" & Fee.StudentStatus & "',StudentGender='" & Fee.StudentGender & _
                                        "',PaymentOption='" & Fee.PaymentOption & "',PaymentScheme ='" & Fee.PaymentScheme & "',CampusID='" & Fee.CampusID & _
                                         "' WHERE TemplateID='" & Fee.TemplateID & "' AND TransType='" & Fee.TransType & "'", con)
            com.ExecuteNonQuery()

            UpdateTableOfFees = TranDBResult.Success
        Else
            UpdateTableOfFees = TranDBResult.Failed
        End If
    End Function


    Public Function SaveTableOfFeesThesisGrad(ByVal Fee As tTableofFees) As TranDBResult

        If FeeTemplateExistsByCode(Fee.TemplateCode, Fee.CampusID, Fee.SchoolYear) = TranDBResult.Success Then
            SaveTableOfFeesThesisGrad = TranDBResult.DuplicateCode
            Exit Function
        End If

        If FeeTemplateExistsByTemplateID(Fee.TemplateID, Fee.CampusID, Fee.SchoolYear) = TranDBResult.Success Then
            SaveTableOfFeesThesisGrad = TranDBResult.DuplicateID
            Exit Function
        End If

        Dim com As New MySqlCommand("INSERT INTO tblTableOfFees(TemplateCode,TemplateDesc,TemplateRemarks,SchoolYear,TransType,InActive,Currency,CampusID) VALUES ('" & Fee.TemplateCode & _
                                   "','" & Fee.TemplateDisc & "','" & Fee.TemplateRemarks & "','" & Fee.SchoolYear & _
                                   "','" & Fee.TransType & "','" & Fee.InActive & "','" & Fee.Currency & "','" & Fee.CampusID & "')", con)
        com.ExecuteNonQuery()

        SaveTableOfFeesThesisGrad = TranDBResult.Success

    End Function

    Public Function UpdateTableOfFeesThesisGrad(ByVal Fee As tTableofFees) As TranDBResult

        If FeeTemplateExistsByTemplateID(Fee.TemplateID, Fee.CampusID, Fee.SchoolYear) = TranDBResult.Success Then
            Dim com As New MySqlCommand("UPDATE tblTableOfFees SET TemplateCode ='" & Fee.TemplateCode & ",TemplateDesc='" & Fee.TemplateDisc & _
                                        "',TemplateRemarks= '" & Fee.TemplateRemarks & "',SchoolYear='" & Fee.SchoolYear & _
                                        "',InActive='" & Fee.InActive & _
                                        "',Currency='" & Fee.Currency & "' WHERE TemplateID='" & Fee.TemplateID & "' AND TransType='" & Fee.TransType & "'", con)
            com.ExecuteNonQuery()

            UpdateTableOfFeesThesisGrad = TranDBResult.Success
        Else
            UpdateTableOfFeesThesisGrad = TranDBResult.Failed
        End If
    End Function

    Public Function SaveTableOfFees_Details(ByVal sFee As tTableOfFeeDetails) As TranDBResult
        If FeeTemplateExistsByTemplateID(sFee.TemplateID) = TranDBResult.Success Then

            Dim com As New MySqlCommand("INSERT INTO tblTableOfFee_Details(TemplateID,AccountID,Amount,ChargeMode,InActive,Currency,`Option`) VALUES ('" & _
                                        sFee.TemplateID & "','" & sFee.AccountID & "','" & sFee.Amount & "','" & sFee.ChargeMode & "','" & sFee.InActive & _
                                        "','" & sFee.Currency & "','" & sFee.Options & "')", con)
            com.ExecuteNonQuery()

            SaveTableOfFees_Details = TranDBResult.Success
        Else
            SaveTableOfFees_Details = TranDBResult.Failed
        End If
    End Function

    Public Function UpdateTableOfFees_Details(ByVal sFee As tTableOfFeeDetails) As TranDBResult
        If FeeTemplateExistsByTemplateID(sFee.TemplateID) = TranDBResult.Success Then

            Dim com As New MySqlCommand("UPDATE tblTableOfFee_Details SET AccountID='" & sFee.AccountID & "',Amount='" & sFee.Amount & _
                                        "',InActive='" & sFee.InActive & "',Currency='" & sFee.Currency & _
                                        "',Option ='" & sFee.Options & "' WHERE ID ='" & sFee.ID & "'", con)
            com.ExecuteNonQuery()

            UpdateTableOfFees_Details = TranDBResult.Success
        Else
            UpdateTableOfFees_Details = TranDBResult.Failed
        End If
    End Function


    Public Function ExecuteDeleteFeeTemplateDetails(ByVal sTemplateID As String, ByVal Account As String) As TranDBResult
        If MsgBox("Are you sure to Delete the selected Account? " & vbNewLine & vbNewLine & Account, vbQuestion + vbYesNo, Application.ProductName) = vbYes Then

            If DeleteFeeTemplateDetails(sTemplateID) = TranDBResult.Success Then
                MsgBox("FEE TEMPLATE Account entry and other related record succesfully deleted.", vbInformation)
                ExecuteDeleteFeeTemplateDetails = TranDBResult.Success
            Else
                MsgBox("Deleting FEE TEMPLATE Account entry went failed.", vbExclamation)
                ExecuteDeleteFeeTemplateDetails = TranDBResult.Failed
            End If
        Else
            ExecuteDeleteFeeTemplateDetails = TranDBResult.Failed
        End If
    End Function

    Public Function DeleteFeeTemplateDetails(ByVal sTemplateID As String) As TranDBResult
        DeleteFeeTemplateDetails = TranDBResult.Failed

        Dim com As New MySqlCommand("Delete From tblTableOfFee_Details WHERE ID='" & sTemplateID & "'", clsCon.con)
        com.ExecuteNonQuery()
        DeleteFeeTemplateDetails = TranDBResult.Success

    End Function

    Public Function GetTableOfFee_DetailsByID(ByVal ID As Integer, ByRef sFee As tTableOfFeeDetails) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblTableOfFee_Details WHERE ID='" & ID & "'", con)
        Dim vRs As MySqlDataReader = com.ExecuteReader
        vRs.Read()
        If vRs.HasRows Then
            sFee.ID = vRs("ID").ToString()
            sFee.TemplateID = vRs("TemplateID").ToString()
            sFee.AccountID = vRs("AccountID").ToString()
            sFee.Amount = vRs("Amount").ToString()
            sFee.Remarks = vRs("Remarks").ToString()
            sFee.ChargeMode = vRs("ChargeMode").ToString()
            sFee.InActive = vRs("InActive").ToString()
            sFee.Currency = vRs("Currency").ToString()
            'sFee.Succeeding = vRs("Succeeding").ToString()
            sFee.Options = vRs("Option").ToString()

            GetTableOfFee_DetailsByID = TranDBResult.Success
        Else
            GetTableOfFee_DetailsByID = TranDBResult.Failed
        End If
        vRs.Close()
    End Function

    Public Function GetPaymenyOptionByOptionID(ByVal PaymentOptionID As Integer, ByRef Opt As PaymentOptions) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblPaymentOptions WHERE PaymentOptionID='" & PaymentOptionID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            Opt.PaymentOptionID = vRS("PaymentOptionID").ToString()
            Opt.PaymentDescription = vRS("PaymentDescription").ToString()
            Opt.PaymentOptionName = vRS("PaymentOptionName").ToString()

            '===== TODO ======

            GetPaymenyOptionByOptionID = TranDBResult.Success
        Else
            GetPaymenyOptionByOptionID = TranDBResult.Failed
        End If
    End Function
End Module
