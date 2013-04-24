Option Explicit On

Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class frmStudentRecord

    Dim curStudent As tStudent
    Dim curStudentSchoolYearTitle As String
    Dim curStudentYearLevelID As Integer

    Dim sStudentNo As String
    Dim sEnrolmentID As String
    Dim sSectionFullTitle As String

    Dim sSEctionTitle(3) As String
    Dim curEnrolmentID(3) As String
    Private Sub frmStudentRecord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadGrids()
    End Sub
    Public Sub ShowBilledAccount(ByVal StudentNo As String)
        Dim sSQL As String

        Dim PaidAmount As String
        Dim Balance As String

        sSQL = "SELECT * " & _
                "FROM qryAssessment " & _
                "WHERE StudentNo ='" & StudentNo & "'"


        lvBilling.Items.Clear()

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        While vRS.Read
            Dim lv As New ListViewItem(vRS("SchoolYear").ToString())
            lv.SubItems.Add(vRS("EnrolmentID").ToString())
            lv.SubItems.Add(vRS("CreationDate").ToString())
            lv.SubItems.Add(FormatNumber(vRS("ChargeAmount").ToString(), 2))

            PaidAmount = vRS("PaidAmount").ToString()
            If PaidAmount <> "" Then
                lv.SubItems.Add(vRS("PaidAmount").ToString())
            Else
                lv.SubItems.Add("0.00")
            End If

            Balance = vRS("Balance").ToString()
            If Balance <> "" Then
                lv.SubItems.Add(vRS("Balance").ToString())
            Else
                lv.SubItems.Add("0.00")
            End If

            lvBilling.Items.AddRange(New ListViewItem() {lv})
        End While
        vRS.Close()
    End Sub
    Public Sub ShowSubjectDetail(ByVal EnrolmentID As String)
        Dim sSQL As String
        Dim cur As Decimal

        Me.Cursor = Cursors.WaitCursor

        sSQL = "SELECT tblEnrolment.EnrolmentID, tblSubject.SubjectID, tblSubject.SubjectTitle, tblSubject.Description, tblSubject.Units, tblSubject.SubjectFee,tblEnrolment.SchoolYear, (tblSubject.Units*tblSubject.SubjectFee) AS SubjectPayment" & _
                " FROM tblSubject INNER JOIN (tblSubjectOffering INNER JOIN (tblEnrolment INNER JOIN tblGrade ON tblEnrolment.EnrolmentID = tblGrade.EnrolmentID) ON (tblSubjectOffering.SubjectOfferingID = tblGrade.SubjectOfferingID) AND (tblSubjectOffering.SubjectOfferingID = tblGrade.SubjectOfferingID)) ON tblSubject.SubjectID = tblSubjectOffering.SubjectID" & _
                " WHERE tblEnrolment.EnrolmentID ='" & EnrolmentID & "'"

        lvSubjectFee.Items.Clear()

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        While vRS.Read()
            Dim lv As New ListViewItem(vRS("SubjectTitle").ToString())
            lv.SubItems.Add(FormatNumber(vRS("SubjectPayment").ToString(), 2))
            lv.SubItems.Add("0.00")
            lv.SubItems.Add("0.00")
            lvSubjectFee.Items.AddRange(New ListViewItem() {lv})

            cur = cur + Val(vRS("SubjectPayment").ToString())
        End While
        vRS.Close()

        txtTuitionAmount.Text = FormatNumber(cur, 2)

        Dim lvs As New ListViewItem("Subject Fee")
        lvs.SubItems.Add(txtTuitionAmount.Text)
        lvs.SubItems.Add("0.00")
        lvs.SubItems.Add("0.00")
        lvBillingItem.Items.AddRange(New ListViewItem() {lvs})


        Me.Cursor = Cursors.Default
    End Sub
    Public Sub ShowSubjectLAbDetail(ByVal EnrolmentID As String)
        Dim sSQL As String
        Dim cur As Decimal

        Me.Cursor = Cursors.WaitCursor

        sSQL = "SELECT tblEnrolment.EnrolmentID, tblSubject.SubjectID, tblSubject.SubjectTitle, tblSubject.Description, tblSubject.Units, tblSubject.LaboratoryFee,tblEnrolment.SchoolYear, (tblSubject.Units*tblSubject.LaboratoryFee) AS Laboratory" & _
                " FROM tblSubject INNER JOIN (tblSubjectOffering INNER JOIN (tblEnrolment INNER JOIN tblGrade ON tblEnrolment.EnrolmentID = tblGrade.EnrolmentID) ON (tblSubjectOffering.SubjectOfferingID = tblGrade.SubjectOfferingID) AND (tblSubjectOffering.SubjectOfferingID = tblGrade.SubjectOfferingID)) ON tblSubject.SubjectID = tblSubjectOffering.SubjectID" & _
                " WHERE ((tblSubject.Units*tblSubject.LaboratoryFee) > 0) AND tblEnrolment.EnrolmentID ='" & EnrolmentID & "'"


        lvLabFee.Items.Clear()

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        While vRS.Read()
            Dim lv As New ListViewItem(vRS("SubjectTitle").ToString())
            lv.SubItems.Add(FormatNumber(vRS("Laboratory").ToString(), 2))
            lv.SubItems.Add("0.00")
            lv.SubItems.Add("0.00")
            lvLabFee.Items.AddRange(New ListViewItem() {lv})

            cur = cur + Val(vRS("Laboratory").ToString())
        End While
        vRS.Close()

        txtLabAmount.Text = FormatNumber(cur, 2)

        Dim lvs As New ListViewItem("Laboratory Fee")
        lvs.SubItems.Add(txtLabAmount.Text)
        lvs.SubItems.Add("0.00")
        lvs.SubItems.Add("0.00")
        lvBillingItem.Items.AddRange(New ListViewItem() {lvs})

        Me.Cursor = Cursors.Default
    End Sub
    Public Function ShowForm(Optional ByVal sStudentNo As String = "", Optional ByVal FormName As String = "")
        'show form
        Me.Show()
        Me.Focus()

        Application.DoEvents()

        If sStudentNo <> "" Then

            lblLevel.Text = ""
            chkGraduated.Text = "Graduated"
            chkGraduated.Checked = CheckState.Unchecked


            If GetStudentByID(sStudentNo, curStudent) <> TranDBResult.Success Then
                Exit Function
            End If

            Application.DoEvents()
            tabMAin.Enabled = True

            RefreshStudentPersonalInfo()
            RefreshRecord()

        End If

        Exit Function
    End Function

    Private Sub RefreshRecord()

        Dim i As Integer
        Dim sSYGraduated As String

        'set name
        curStudent.StudentNo = curStudent.StudentNo

        'checck if graduate
        If IsStudentGraduated(curStudent.StudentNo, sSYGraduated) = True Then
            chkGraduated.Text = "Graduated (" & sSYGraduated & ")"
            chkGraduated.Checked = CheckState.Checked
        Else
            chkGraduated.Text = "Graduated"
            chkGraduated.Checked = CheckState.Unchecked
        End If

        'check if dropped
        If IsStudentDropped(curStudent.StudentNo) = TranDBResult.Success Then
            chkDropped.Checked = CheckState.Checked
        Else
            chkDropped.Checked = CheckState.Unchecked
        End If




        ShowBilledAccount(curStudent.StudentNo)

        If curStudentYearLevelID < 1 Then
            tabMAin.SelectedIndex = 0
            lblNE.Visible = True
            GoTo ReleaseAndExit
        End If

        For i = 1 To curStudentYearLevelID

            Application.DoEvents()

            ShowStudentYLRecord(i)
        Next

        lblLevel.Text = YLIDtoTitle(curStudentYearLevelID) & "  (" & curStudentSchoolYearTitle & ")"


ReleaseAndExit:
        Exit Sub
    End Sub
    Private Sub ShowStudentYLRecord(ByVal iYearLevelID As Integer)
        Dim sSQL As String

        Dim dStudentAveGrade As Double
        Dim bStudentPassed As Boolean
        Dim tmpStudentPrevDepertmentID As String


        GetAcademicRecord(curStudent.StudentNo, iYearLevelID, dStudentAveGrade, bStudentPassed, tmpStudentPrevDepertmentID)


        sSQL = "SELECT tblEnrolment.EnrolmentID, tblEnrolment.SchoolYear AS SY, tblDepartment.DepartmentTitle, CONCAT(tblYearLevel.YearLevelTitle , ' - ' , tblSection.SectionTitle) AS SectionFullTitle, CONCAT(tblTeacher_1.LastName , ', ' , tblTeacher_1.FirstName , ' ' , tblTeacher_1.MiddleName) AS Adviser, tblEnrolment.CreationDate" & _
                " FROM tblYearLevel INNER JOIN ((tblDepartment INNER JOIN tblSection ON tblDepartment.DepartmentID = tblSection.DepartmentID) INNER JOIN ((tblTeacher AS tblTeacher_1 INNER JOIN tblSectionOffering ON tblTeacher_1.TeacherID = tblSectionOffering.TeacherID) INNER JOIN tblEnrolment ON tblSectionOffering.SectionOfferingID = tblEnrolment.SectionOfferingID) ON tblSection.SectionID = tblSectionOffering.SectionID) ON tblYearLevel.YearLevelID = tblSection.YearLevelID" & _
                " WHERE (((tblEnrolment.StudentNo)='" & curStudent.StudentNo & "') AND ((tblSection.YearLevelID)=" & iYearLevelID & "));"


        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            curEnrolmentID(iYearLevelID - 1) = (vRS("EnrolmentID").ToString())
            sSEctionTitle(iYearLevelID - 1) = (vRS("SectionFullTitle").ToString())
            sSectionFullTitle = (vRS("SectionFullTitle").ToString())
            sEnrolmentID = (vRS("EnrolmentID").ToString())
        End If
        vRS.Close()

        ShowSubjectsByEnrolmentID(sEnrolmentID, iYearLevelID, sSectionFullTitle)

        'lblAG(iYearLevelID - 1).Caption = FormatNumber(dStudentAveGrade, 2) & IIf(bStudentPassed = True, " (Passed)", " (Failed)")
        'lblDateEnrolled(iYearLevelID - 1).Caption = (vRS.Fields("CreationDate"))
        'lblSectionFullTitle(iYearLevelID - 1).Caption = (vRS.Fields("SectionFullTitle"))
        'lblSchoolYear(iYearLevelID - 1).Caption = (vRS.Fields("SY"))
        'lblDepartmentTitle(iYearLevelID - 1).Caption = (vRS.Fields("DepartmentTitle"))
        'lblAdviser(iYearLevelID - 1).Caption = (vRS.Fields("Adviser"))

    End Sub
    Private Sub RefreshStudentPersonalInfo()
        With GridInfo
            .set_ColWidth(0, 2100)
            .set_ColWidth(1, 10215 - 2100)

            .set_TextMatrix(0, 0, "ID Number")
            .set_TextMatrix(1, 0, "Full name")
            .set_TextMatrix(2, 0, "Gender")
            .set_TextMatrix(3, 0, "Status")
            .set_TextMatrix(4, 0, "Citizinship")
            .set_TextMatrix(5, 0, "Religion")
            .set_TextMatrix(6, 0, "Blood Type")
            .set_TextMatrix(7, 0, "Birth Date")
            .set_TextMatrix(8, 0, "Place Of Birth")
            .set_TextMatrix(9, 0, "Home Address")
            .set_TextMatrix(10, 0, "Last School Attended")
            .set_TextMatrix(11, 0, "Contact Number")
            .set_TextMatrix(12, 0, "Address")
            .set_TextMatrix(13, 0, "Entrance Ave. Grade:")


            .set_TextMatrix(0, 1, curStudent.StudentNo)
            .set_TextMatrix(1, 1, curStudent.LastName & ", " & curStudent.FirstName & " " & curStudent.MiddleName)
            .set_TextMatrix(2, 1, curStudent.Gender)
            '.set_TextMatrix(3, 1, curStudent.Status)
            '.set_TextMatrix(4, 1, curStudent.Citizenship)
            '.set_TextMatrix(5, 1, curStudent.Religion)
            .set_TextMatrix(6, 1, curStudent.BloodType)
            .set_TextMatrix(7, 1, curStudent.BirthDate)
            .set_TextMatrix(8, 1, curStudent.PlaceOfBirth)
            '.set_TextMatrix(9, 1, curStudent.HomeAddress)
            '.set_TextMatrix(10, 1, curStudent.LastSchoolName)
            '.set_TextMatrix(11, 1, curStudent.LastSchoolContactNumber)
            '.set_TextMatrix(12, 1, curStudent.LastSchoolAddress)
            '.set_TextMatrix(13, 1, curStudent.OldAveGrade)

            .set_ColAlignment(0, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignLeftCenter)
            .set_ColAlignment(1, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignLeftCenter)
        End With


        With GridParents
            .set_ColWidth(0, 2100)
            .set_ColWidth(1, 10215 - 2100)

            .set_TextMatrix(0, 1, "Parents")
            .set_TextMatrix(1, 0, "Mother Name")
            .set_TextMatrix(2, 0, "Occupation")
            .set_TextMatrix(3, 0, "Father Name")
            .set_TextMatrix(4, 0, "Occupation")
            .set_TextMatrix(5, 0, "Contact Number")
            .set_TextMatrix(6, 0, "Address")

            .set_TextMatrix(1, 1, curStudent.MotherName)
            .set_TextMatrix(2, 1, curStudent.MotherOccupation)
            .set_TextMatrix(3, 1, curStudent.FatherName)
            .set_TextMatrix(4, 1, curStudent.FatherOccupation)
            '.set_TextMatrix(5, 1, curStudent.ParentsContactNumber)
            '.set_TextMatrix(6, 1, curStudent.ParentsAddress)

            .set_ColAlignment(0, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignLeftCenter)
            .set_ColAlignment(1, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignLeftCenter)

        End With


        With GridGuardians
            .set_ColWidth(0, 2100)
            .set_ColWidth(1, 10215 - 2100)

            .set_TextMatrix(0, 1, "Guardian")
            .set_TextMatrix(1, 0, "Name")
            .set_TextMatrix(2, 0, "Contact Number")
            .set_TextMatrix(3, 0, "Address")

            '.set_TextMatrix(1, 1, curStudent.GuardianName)
            '.set_TextMatrix(2, 1, curStudent.GuardianContactNumber)
            .set_TextMatrix(3, 1, curStudent.GuardianAddress)

            .set_ColAlignment(0, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignLeftCenter)
            .set_ColAlignment(1, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignLeftCenter)
        End With


    End Sub
    Private Sub LoadGrids()

        With GridInfo
            .set_TextMatrix(0, 0, "ID Number")
            .set_TextMatrix(1, 0, "Full name")
            .set_TextMatrix(2, 0, "Gender")
            .set_TextMatrix(3, 0, "Status")
            .set_TextMatrix(4, 0, "Citizinship")
            .set_TextMatrix(5, 0, "Religion")
            .set_TextMatrix(6, 0, "Blood Type")
            .set_TextMatrix(7, 0, "Birth Date")
            .set_TextMatrix(8, 0, "Place Of Birth")
            .set_TextMatrix(9, 0, "Home Address")
            .set_TextMatrix(10, 0, "Last School Attended")
            .set_TextMatrix(11, 0, "Contact Number")
            .set_TextMatrix(12, 0, "Address")
            .set_TextMatrix(13, 0, "Entrance Ave. Grade:")

            .set_ColAlignment(0, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignLeftCenter)
            .set_ColAlignment(1, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignLeftCenter)
        End With


        With GridParents
            .set_TextMatrix(0, 1, "Parents")
            .set_TextMatrix(1, 0, "Mother Name")
            .set_TextMatrix(2, 0, "Occupation")
            .set_TextMatrix(3, 0, "Father Name")
            .set_TextMatrix(4, 0, "Occupation")
            .set_TextMatrix(5, 0, "Contact Number")
            .set_TextMatrix(6, 0, "Address")

            .set_ColAlignment(0, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignLeftCenter)
            .set_ColAlignment(1, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignLeftCenter)
        End With


        With GridGuardians
            .set_TextMatrix(0, 1, "Guardian")
            .set_TextMatrix(1, 0, "Name")
            .set_TextMatrix(2, 0, "Contact Number")
            .set_TextMatrix(3, 0, "Address")
            .set_ColAlignment(0, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignLeftCenter)
            .set_ColAlignment(1, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignLeftCenter)
        End With


    End Sub
    Private Sub ShowSubjectsByEnrolmentID(ByVal sEnrolmentID As String, ByVal iYearLevelID As Integer, ByVal sSectionTitle As String)

        Dim sSQL As String

        sSQL = "SELECT tblSubject.SubjectID AS lvKey, tblSubject.SubjectTitle,tblSubject.Description,tblSubject.Units,tblGrade.FirstGrading,tblGrade.SecondGrading,tblGrade.ThirdGrading,tblGrade.FourthGrading,tblGrade.GradeValue, CONCAT(tblSubjectOffering.SchedTimeStart , '-' , tblSubjectOffering.SchedTimeEnd) AS TimeSched, tblSubjectOffering.Days,CONCAT(tblTeacher.LastName , ', ' , tblTeacher.FirstName , ' ' , tblTeacher.MiddleName) AS TeacherFullName" & _
                " FROM tblTeacher INNER JOIN (tblSubject INNER JOIN (tblSubjectOffering INNER JOIN (tblEnrolment INNER JOIN tblGrade ON tblEnrolment.EnrolmentID = tblGrade.EnrolmentID) ON tblSubjectOffering.SubjectOfferingID = tblGrade.SubjectOfferingID) ON tblSubject.SubjectID = tblSubjectOffering.SubjectID) ON tblTeacher.TeacherID = tblSubjectOffering.TeacherID" & _
                " Where (((tblEnrolment.EnrolmentID) = '" & sEnrolmentID & "'))" & _
                " ORDER BY tblSubject.SubjectTitle;"



        lvTranscript.Items.Clear()

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        While vRS.Read
            lvTranscript.Groups.Add(New ListViewGroup(sSectionTitle, _
                                                HorizontalAlignment.Left))

            Dim lv As New ListViewItem(vRS("SubjectTitle").ToString())
            lv.SubItems.Add(vRS("lvKey").ToString())
            lv.SubItems.Add(vRS("Description").ToString())
            lv.SubItems.Add(vRS("Units").ToString())
            lv.SubItems.Add(vRS("FirstGrading").ToString())
            lv.SubItems.Add(vRS("SecondGrading").ToString())
            lv.SubItems.Add(vRS("ThirdGrading").ToString())
            lv.SubItems.Add(vRS("FourthGrading").ToString())
            lv.SubItems.Add(vRS("GradeValue").ToString())

            lv.Group = lvTranscript.Groups(0)
            lvTranscript.Items.AddRange(New ListViewItem() {lv})
        End While
        vRS.Close()
    End Sub
    Public Function IsStudentGraduated(ByVal sStudentNo As String, ByRef sSYGraduated As String) As Boolean
        Dim sSQL As String

        sSQL = " SELECT tblGraduate.StudentID,SchoolYear" & _
                " From tblGraduate" & _
                " WHERE (((tblGraduate.StudentID)='" & sStudentNo & "'))"

        'default
        IsStudentGraduated = False

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            IsStudentGraduated = True
            sSYGraduated = (vRS("SchoolYear").ToString())
        Else
            IsStudentGraduated = False
        End If
        vRS.Close()
    End Function

    Private Sub lvBilling_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvBilling.Click
        Dim curTotal As Decimal

        If lvBilling.Items.Count < 0 Then
            Exit Sub
        End If
        ShowFeeDetail(lvBilling.FocusedItem.SubItems(1).Text)
        ShowSubjectDetail(lvBilling.FocusedItem.SubItems(1).Text)
        ShowSubjectLAbDetail(lvBilling.FocusedItem.SubItems(1).Text)

        For Each lvs As ListViewItem In lvBillingItem.Items
            curTotal = curTotal + CDec(lvs.SubItems(1).Text)
        Next
        txtBillAmount.Text = FormatNumber(curTotal, 2)


    End Sub
    Public Sub ShowFeeDetail(ByVal EnrolmentID As String)
        Dim sSQL As String


        Me.Cursor = Cursors.WaitCursor

        sSQL = "SELECT * FROM qryChargesByStudent WHERE EnrolmentID ='" & EnrolmentID & "'"

        lvBillingItem.Items.Clear()
        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        While vRS.Read
            Dim lv As New ListViewItem(vRS("Title").ToString())
            lv.SubItems.Add(FormatNumber(vRS("Amount").ToString(), 2))
            lv.SubItems.Add("0.00")
            lv.SubItems.Add("0.00")
            lvBillingItem.Items.AddRange(New ListViewItem() {lv})
        End While
        vRS.Close()
        Me.Cursor = Cursors.Default

    End Sub
End Class