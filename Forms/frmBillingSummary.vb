Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class frmBillingSummary

    Private Sub cmdBrowseSchoolYear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBrowseSchoolYear.Click
        Dim sSchoolYearTitle As String

        'sSchoolYearTitle = PickSchoolYear.GetItem(txtSY)

        If sSchoolYearTitle <> "" Then
            txtSY.Text = sSchoolYearTitle
        End If
    End Sub

    Private Sub frmBillingSummary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtSY.Text = CurrentSchoolYear.SchoolYearTitle


    End Sub
    Public Sub ShowCollictibleAccount()
        Dim sSQL As String
        Dim PaidAmount As String
        Dim Balance As String

        sSQL = "SELECT tblenrolment.EnrolmentID, tblstudent.StudentID, CONCAT(tblstudent.LastName, ', ', tblstudent.FirstName, ' ' , Left(tblstudent.MiddleName,1),'.') AS StudentName, tblyearlevel.YearLevelTitle, tblscholarship.Scholarship, Sum(tblcharge.Amount) AS Billed, tblpayment.AmountPay AS Paid, (Sum(tblcharge.Amount)-tblpayment.AmountPay) AS Balance,tblEnrolment.SchoolYear" & _
                " FROM (tblsection INNER JOIN ((((((tblscholarship RIGHT JOIN tblscholar ON tblscholarship.ScholarshipID = tblscholar.ScholarshipID) RIGHT JOIN tblstudent ON tblscholar.StudentID = tblstudent.StudentID) INNER JOIN tblenrolment ON tblstudent.StudentID = tblenrolment.StudentID) INNER JOIN tblcharge ON tblenrolment.EnrolmentID = tblcharge.EnrolmentID) LEFT JOIN tblpayment ON tblenrolment.EnrolmentID = tblpayment.EnrolmentID) INNER JOIN tblsectionoffering ON tblenrolment.SectionOfferingID = tblsectionoffering.SectionOfferingID) ON tblsection.SectionID = tblsectionoffering.SectionID) INNER JOIN tblyearlevel ON tblsection.YearLevelID = tblyearlevel.YearLevelID" & _
                " WHERE tblEnrolment.SchoolYear = '" & txtSY.Text & "'" & _
                " GROUP BY tblenrolment.EnrolmentID, tblstudent.StudentID, tblstudent.LastName, tblstudent.FirstName, tblstudent.MiddleName, tblyearlevel.YearLevelTitle, tblscholarship.Scholarship, tblpayment.AmountPay;"

        lvCollectibles.Items.Clear()

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        While vRS.Read
            Dim lv As New ListViewItem(vRS("StudentName").ToString())
            lv.SubItems.Add(vRS("StudentID").ToString())
            lv.SubItems.Add(vRS("YearLevelTitle").ToString())
            lv.SubItems.Add(vRS("Scholarship").ToString())
            lv.SubItems.Add(FormatNumber(vRS("Billed").ToString(), 2))

            PaidAmount = vRS("Paid").ToString()
            If PaidAmount <> "" Then
                lv.SubItems.Add(vRS("Paid").ToString())
            Else
                lv.SubItems.Add("0.00")
            End If

            Balance = vRS("Balance").ToString()
            If Balance <> "" Then
                lv.SubItems.Add(vRS("Balance").ToString())
            Else
                lv.SubItems.Add("0.00")
            End If
            lvCollectibles.Items.AddRange(New ListViewItem() {lv})
        End While
        vRS.Close()
    End Sub
    Public Sub ShowBillableAccount()
        Dim sSQL As String

        sSQL = "SELECT tblstudent.StudentID, CONCAT(tblstudent.LastName,', ',tblstudent.FirstName,' ',tblstudent.MiddleName) AS StudentName, tblstudent.Gender, tblyearlevel.YearLevelTitle, tblenrolment.SchoolYear, tblenrolment.DateEnroled" & _
                " FROM (tblsection INNER JOIN (tblsectionoffering INNER JOIN ((tblcharge RIGHT JOIN tblenrolment ON tblcharge.EnrolmentID = tblenrolment.EnrolmentID) INNER JOIN tblstudent ON tblenrolment.StudentID = tblstudent.StudentID) ON tblsectionoffering.SectionOfferingID = tblenrolment.SectionOfferingID) ON tblsection.SectionID = tblsectionoffering.SectionID) INNER JOIN tblyearlevel ON tblsection.YearLevelID = tblyearlevel.YearLevelID" & _
                " WHERE tblEnrolment.SchoolYear='" & txtSY.Text & "'" & _
                " GROUP BY tblstudent.StudentID, tblstudent.LastName, tblstudent.FirstName, tblstudent.MiddleName, tblstudent.Gender, tblyearlevel.YearLevelTitle, tblenrolment.SchoolYear, tblenrolment.DateEnroled;"

        lvBillable.Items.Clear()

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        While vRS.Read
            Dim lv As New ListViewItem(vRS("StudentName").ToString())
            lv.SubItems.Add(vRS("StudentID").ToString())
            lv.SubItems.Add(vRS("Gender").ToString())
            lv.SubItems.Add(vRS("YearLevelTitle").ToString())
            lv.SubItems.Add(vRS("DateEnroled").ToString())
            lvBillable.Items.AddRange(New ListViewItem() {lv})
        End While
        vRS.Close()
    End Sub

    Private Sub txtSY_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSY.TextChanged
        ShowCollictibleAccount()
        ShowBillableAccount()
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        ShowCollictibleAccount()
        ShowBillableAccount()
    End Sub
End Class