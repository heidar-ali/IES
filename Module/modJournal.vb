Option Explicit On

Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Module modJournal

    Public Structure tJournals
        Dim EntryID As Integer
        Dim ServerDate As Date
        Dim TransDate As Date
        Dim TermID As Integer
        Dim CampusID As Integer
        Dim TransID As Integer
        Dim ReferenceNo As String
        Dim Description As String
        Dim Particulars As String
        Dim Payor As String
        Dim AccountID As String
        Dim IDType As String
        Dim IDNo As String
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
        Dim CreditMemo As String
        Dim SeqNo As Integer
        Dim NonLedger As Short
        Dim Deferred As Short
        Dim SubCodeID As String
    End Structure


End Module
