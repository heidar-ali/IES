Imports System.Windows.Forms

Public Class frmAssessment

    Private Sub frmAssessment_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub ShowForm(ByVal pTransType As Integer, ByVal pReferenceNo As String, _
                                                          ByVal pAsOfDate As DateTime, ByVal pIDType As Integer, Optional ByVal StudentNo As String = "")

        Dim AssessFee As Decimal

        If EnrolmentTempExistByID(pReferenceNo) = TranDBResult.Success Then
            If GetStudentAssessedFees_Temp(TransactionType.Enrollment, pReferenceNo, DateTime.Now) = True Then
                GetTempRegistrationAssessmentByEnrollmentID(pTransType, pReferenceNo, pAsOfDate, pIDType)

                lblLabUnits.Text = GetTotalTempEnrolledLabUnits(pReferenceNo)
                lblLectUnits.Text = GetTotalTempEnrolledLecUnits(pReferenceNo)
                AssessFee = fnGetStudentTempAssessedFees(pTransType, pReferenceNo, pIDType, StudentNo)
                lblAssess.Text = AssessFee.ToString("#,##0.00")
                lblSubjectCount.Text = getTotalTempSubjectEnrolled(pReferenceNo)
                lblLabHrs.Text = GetTotalTempEnrolledLabHrs(pReferenceNo)
            End If
        End If

        If EnrolmentExistByID(pReferenceNo) = TranDBResult.Success Then
            If GetStudentAssessedFees(TransactionType.Enrollment, pReferenceNo, DateTime.Now) = True Then
                GetRegistrationAssessmentByEnrollmentID(pTransType, pReferenceNo, pAsOfDate, pIDType)

                lblLabUnits.Text = GetTotalEnrolledLabUnits(pReferenceNo)
                lblLectUnits.Text = GetTotalEnrolledLecUnits(pReferenceNo)
                AssessFee = fnGetStudentAssessedFees(pTransType, pReferenceNo, pIDType, StudentNo)
                lblAssess.Text = AssessFee.ToString("#,##0.00")
                lblSubjectCount.Text = getTotalSubjectEnrolled(pReferenceNo)
                lblLabHrs.Text = GetTotalEnrolledLabHrs(pReferenceNo)
            End If
        End If

       

        Me.ShowDialog()
    End Sub

    Public Sub GetRegistrationAssessmentByEnrollmentID(ByVal pTransType As Integer, ByVal pReferenceNo As String, _
                                                          ByVal pAsOfDate As Date, ByVal pIDType As Integer)
        Dim sSQL As String = "SELECT  A.AcctCode, A.AcctName, J.Remarks AS Remarks, J.Debit, J.`1st Payment`, J.`2nd Payment`, `3rd Payment`, J.`4th Payment`, J.`5th Payment`, " & _
            "(J.Debit - J.ActualPayment) as Balance, J.ActualPayment as Credit, J.Discount AS FinancialAid, J.`Assess_Fee`, J.PaymentDiscount, J.CreditMemo, A.AcctOption, AG.GroupID, AG.GroupCode, AG.GroupName, AG.GroupShort, AC.ClassCode, AC.ClassName, AC.ShortName, J.EntryID, J.AccountID, J.DMCMRefNo " & _
         "FROM	tblAccountClass AC RIGHT OUTER JOIN tblAccounts A ON AC.ClassID = A.ClassID RIGHT OUTER JOIN tblJournals J ON A.AcctID = J.AccountID LEFT OUTER JOIN " & _
         "tblAccountGroups AG ON A.GroupID = AG.GroupID WHERE (J.TransID ='" & pTransType & "') AND (J.ReferenceNo = '" & pReferenceNo & "') AND (J.TransDate <= '" & pAsOfDate & "') AND " & _
         "(J.IDType ='" & pIDType & "') And (J.Debit > 0) ORDER BY J.SeqNo, J.EntryID;"

        FillListView(sSQL, lvAssessment, False)
    End Sub

    Public Sub GetTempRegistrationAssessmentByEnrollmentID(ByVal pTransType As Integer, ByVal pReferenceNo As String, _
                                                          ByVal pAsOfDate As Date, ByVal pIDType As Integer)
        Dim sSQL As String = "SELECT  A.AcctCode, A.AcctName, J.Remarks AS Remarks, J.Debit, J.`1st Payment`, J.`2nd Payment`, `3rd Payment`, J.`4th Payment`, J.`5th Payment`, " & _
            "(J.Debit - J.ActualPayment) as Balance, J.ActualPayment as Credit, J.Discount AS FinancialAid, J.`Assess_Fee`, J.PaymentDiscount, J.CreditMemo, A.AcctOption, AG.GroupID, AG.GroupCode, AG.GroupName, AG.GroupShort, AC.ClassCode, AC.ClassName, AC.ShortName, J.EntryID, J.AccountID, J.DMCMRefNo " & _
         "FROM	tblAccountClass AC RIGHT OUTER JOIN tblAccounts A ON AC.ClassID = A.ClassID RIGHT OUTER JOIN tblJournals_Temp J ON A.AcctID = J.AccountID LEFT OUTER JOIN " & _
         "tblAccountGroups AG ON A.GroupID = AG.GroupID WHERE (J.TransID ='" & pTransType & "') AND (J.ReferenceNo = '" & pReferenceNo & "') AND (J.TransDate <= '" & pAsOfDate & "') AND " & _
         "(J.IDType ='" & pIDType & "') And (J.Debit > 0) ORDER BY J.SeqNo, J.EntryID;"

        FillListView(sSQL, lvAssessment, False)
    End Sub




End Class
