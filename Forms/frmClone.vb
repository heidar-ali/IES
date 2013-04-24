Option Explicit On

Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class frmClone

    Dim RecordAdded As Boolean


    Dim selStudentPrevYL As Integer
    Dim selStudentPrevSY As String
    Dim selStudentPrevDepertmentID As String

    Dim selStudentAveGrade As Double
    Dim selStudentPassed As Boolean


    Dim selSection As tSection
    Dim selSectionStudentCount As Long

    Dim selStudentPrevYL1 As Integer
    Dim selStudentPrevSY1 As String
    Dim selStudentPrevDepertmentID1 As String

    Dim selStudentAveGrade1 As Double
    Dim selStudentPassed1 As Boolean


    Dim selSection1 As tSection
    Dim selSectionStudentCount1 As Long

    Dim curEnrolmentID As String

    Dim curStudent As tStudent
    Dim curStudent1 As tStudent

    Private Sub frmClone_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With Grid
            .set_TextMatrix(0, 0, "ID Number")
            .set_TextMatrix(1, 0, "Fullname")
            .set_TextMatrix(2, 0, "Gender")
            .set_TextMatrix(3, 0, "Year Level")
            .set_TextMatrix(4, 0, "Attended")
            .set_TextMatrix(5, 0, "Entrance Grade")
            .set_TextMatrix(6, 0, "Scholarship")
            '.set_TextMatrix(7, 0, "")

            .set_ColAlignment(0, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignLeftCenter)
            .set_ColAlignment(1, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignLeftCenter)
        End With

        With Grid1
            .set_TextMatrix(0, 0, "ID Number")
            .set_TextMatrix(1, 0, "Fullname")
            .set_TextMatrix(2, 0, "Gender")
            .set_TextMatrix(3, 0, "Year Level")
            .set_TextMatrix(4, 0, "Attended")
            .set_TextMatrix(5, 0, "Entrance Grade")
            .set_TextMatrix(6, 0, "Scholarship")
            '.set_TextMatrix(7, 0, "")

            .set_ColAlignment(0, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignLeftCenter)
            .set_ColAlignment(1, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignLeftCenter)
        End With
    End Sub

    Private Sub cmdOpen1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOpen1.Click
        Dim frm As New frmBrowse()
        txtStudentID.Text = frm.ShowForm()
    End Sub

    Private Sub cmdOpen2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOpen2.Click
        Dim frm As New frmBrowse()
        frm.ShowDialog()
        txtStudentID1.Text = frm.ShowForm()
    End Sub
    Private Sub ShowStudentDetail()
        Dim IsEnroled As Boolean

        If GetStudentByID(txtStudentID.Text, curStudent) = TranDBResult.Success Then
            With Grid
                .set_TextMatrix(0, 1, txtStudentID.Text)
                .set_TextMatrix(1, 1, curStudent.LastName & ", " & curStudent.FirstName & " " & curStudent.MiddleName)
                .set_TextMatrix(2, 1, curStudent.Gender)
                '.set_TextMatrix(5, 1, curStudent.OldAveGrade)
            End With

            'If GetLatestSchoolYearYearLevel(txtStudentID.Text, selStudentPrevSY, selStudentPrevYL) = TranDBResult.Success Then
            '    Grid.set_TextMatrix(3, 1, YLIDtoTitle(selStudentPrevYL))
            'Else
            '    Grid.set_TextMatrix(3, 1, curStudent.TransfereeYL + 1)
            'End If
        End If

        If StudentEnroledBySchoolYear(txtStudentID.Text, txtSY.Text, IsEnroled) = TranDBResult.Success Then
            If IsEnroled = True Then
                txtEnrolmentID.Text = Microsoft.VisualBasic.Left(txtSY.Text, 4) & "-" & txtStudentID.Text
            Else
                MsgBox("Student not yet enrolled. Please select another student", vbExclamation)
            End If
        End If

        GenerateSectionOffering()

        DisplaySchedule1()

    End Sub
    Private Sub ShowStudentDetail1()
        Dim IsEnroled As Boolean

        If GetStudentByID(txtStudentID1.Text, curStudent1) = TranDBResult.Success Then
            With Grid1
                .set_TextMatrix(0, 1, txtStudentID1.Text)
                .set_TextMatrix(1, 1, curStudent1.LastName & ", " & curStudent1.FirstName & " " & curStudent1.MiddleName)
                .set_TextMatrix(2, 1, curStudent1.Gender)
                '.set_TextMatrix(5, 1, curStudent1.OldAveGrade)
            End With



            'If curStudent1.Transferee = True Then
            '    txtStatus.Text = "Transferee Student, Year Level: " & YLIDtoTitle(curStudent1.TransfereeYL)

            'ElseIf selStudentPrevYL1 < 1 Then
            '    txtStatus.Text = "New Student, Entrance Grade:  " & curStudent1.OldAveGrade
            'Else
            '    'old student
            '    GetAcademicRecord(txtStudentID1.Text, selStudentPrevYL1, selStudentAveGrade1, selStudentPassed1, selStudentPrevDepertmentID1)
            '    If selStudentPassed1 = False Then
            '        'temp
            '        MsgBox("WARNING:" & vbNewLine & vbNewLine & "Student does not passed its previous academic record", vbExclamation)
            '    End If
            'End If

        Else
            txtEnrolmentID1.Text = ""
            Exit Sub
        End If

        If StudentEnroledBySchoolYear(txtStudentID1.Text, txtSY.Text, IsEnroled) = TranDBResult.Success Then
            If IsEnroled = True Then
                MsgBox("Student already enroled", vbExclamation)
                Exit Sub
            End If
        End If

        txtEnrolmentID1.Text = Microsoft.VisualBasic.Left(txtSY.Text, 4) & "-" & txtStudentID1.Text
    End Sub
    Private Sub DisplaySchedule1()
        Dim sSQL As String = "SELECT tblGrade.EnrolmentID,tblSubjectOffering.SubjectOfferingID,CONCAT(tblYearLevel.YearLevelTitle , ' - ' , tblSection.SectionTitle) AS SectionFullTitle, tblSubject.SubjectTitle,tblSubject.Units, tblSubjectOffering.Days, tblSubjectOffering.SchedTimeStart, tblSubjectOffering.SchedTimeEnd, CONCAT(tblteacher.LastName,', ',tblTeacher.FirstName,' ',tblTeacher.MiddleName) AS TeacherFullName" & _
                            " FROM tblYearLevel INNER JOIN ((tblSubject INNER JOIN ((tblSection INNER JOIN tblSectionOffering ON tblSection.SectionID = tblSectionOffering.SectionID) INNER JOIN (tblTeacher INNER JOIN tblSubjectOffering ON tblTeacher.TeacherID = tblSubjectOffering.TeacherID) ON tblSectionOffering.SectionOfferingID = tblSubjectOffering.SectionOfferingID) ON tblSubject.SubjectID = tblSubjectOffering.SubjectID) INNER JOIN tblGrade ON tblSubjectOffering.SubjectOfferingID = tblGrade.SubjectOfferingID) ON tblYearLevel.YearLevelID = tblSection.YearLevelID" & _
                            " WHERE tblGrade.EnrolmentID='" & txtEnrolmentID.Text & "'"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim dr As MySqlDataReader = com.ExecuteReader()
        lvEnroll1.Items.Clear()
        While dr.Read()
            Dim lv As New ListViewItem(dr("SubjectTitle").ToString())
            lv.SubItems.Add(dr("SubjectOfferingID").ToString())
            lv.SubItems.Add(dr("SectionFullTitle").ToString())
            lv.SubItems.Add(dr("Units").ToString())
            lv.SubItems.Add(dr("Days").ToString())
            lv.SubItems.Add(dr("SchedTimeStart").ToString())
            lv.SubItems.Add(dr("SchedTimeEnd").ToString())
            lv.SubItems.Add(dr("TeacherFullName").ToString())
            lvEnroll1.Items.AddRange(New ListViewItem() {lv})
        End While
        dr.Close()
    End Sub
    Private Sub DisplaySchedule2()
        For Each lvItem As ListViewItem In lvEnroll1.Items
            Dim lv As New ListViewItem(lvItem.Text)
            lv.SubItems.Add(lvItem.SubItems(1).Text)
            lv.SubItems.Add(lvItem.SubItems(2).Text)
            lv.SubItems.Add(lvItem.SubItems(3).Text)
            lv.SubItems.Add(lvItem.SubItems(4).Text)
            lv.SubItems.Add(lvItem.SubItems(5).Text)
            lv.SubItems.Add(lvItem.SubItems(6).Text)
            lv.SubItems.Add(lvItem.SubItems(7).Text)
            lvEnroll2.Items.AddRange(New ListViewItem() {lv})
        Next
    End Sub


    Private Sub txtStudentID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStudentID.TextChanged
        ShowStudentDetail()
    End Sub

    Private Sub txtStudentID1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStudentID1.TextChanged
        ShowStudentDetail1()
    End Sub

    Private Sub cmdApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdApply.Click
        If lvEnroll2.Items.Count < 1 Then
            MsgBox("Unable to clone student subjects. Please select student to proceed cloning", vbExclamation)
            Exit Sub
        End If
        If txtStudentID1.Text = "" Then
            MsgBox("Unable to clone student subjects. Please select student to proceed cloning", vbExclamation)
            Exit Sub
        End If

        If txtEnrolmentID1.Text = "" Then
            MsgBox("Unable to clone student subjects. Please select student to proceed cloning", vbExclamation)
            Exit Sub
        End If

        If MsgBox("Are you sure to apply subject and schedule cloning?", vbQuestion + vbYesNo) = vbYes Then
            SaveData()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub chkTransfer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTransfer.CheckedChanged
        If chkTransfer.CheckState = CheckState.Checked Then
            If lvEnroll1.Items.Count > 0 Then
                If txtStudentID1.Text <> "" Then
                    DisplaySchedule2()
                Else
                    chkTransfer.CheckState = CheckState.Unchecked
                    MsgBox("Unable to clone student subjects. Please select student to proceed cloning", vbExclamation)
                    Exit Sub
                End If
            Else
                MsgBox("Unable to clone student subjects. Please select enrolled student to proceed cloning", vbExclamation)
                Exit Sub
            End If
        Else
            lvEnroll2.Items.Clear()
        End If
    End Sub

    Private Function SaveData() As Boolean

        Dim NewEnrolment As tEnrolment

        Dim vSectionOffering As tSectionOffering
        Dim vSection As tSection

        Dim vStudent As tStudent
        'default
        SaveData = False


        'check student
        '-------------------------------------------------------------------
        If GetStudentByID(txtStudentID1.Text, vStudent) <> TranDBResult.Success Then

            MsgBox("Invalid Student Entry!" & vbNewLine & vbNewLine & _
                    "Unable to save Enrolment Entry. The selected Student ID does not exist in record. Please enter correct Student ID.", vbExclamation)

            Exit Function
        End If

        If IsStudentDropped(txtStudentID1.Text) = TranDBResult.Success Then
            MsgBox("Invalid Student Entry!" & vbNewLine & vbNewLine & _
                    "Unable to save Enrolment Entry. The selected Student is already Dropped.", vbExclamation)

            Exit Function
        End If


        'check if student passed previous grades
        If selStudentPrevYL1 > 0 Then
            If selStudentPassed1 = False Then
                MsgBox("Invalid Student Entry!" & vbNewLine & vbNewLine & _
                        "Unable to save Enrolment Entry. The selected Student does not passed its previous academic record. Please enter another Student.", vbExclamation)
                Exit Function
            End If
        End If


        If GetSectionOfferingByID(txtSectionOfferingID.Text, vSectionOffering) = TranDBResult.Failed Then

            MsgBox("Invalid Section Offering Entry!" & vbNewLine & vbNewLine & _
                   "Unable to save Enrolment Entry. The selected Section Offering ID does not exist in record. Please enter correct Section Offering ID.", vbExclamation)

            Exit Function
        End If

        If GetSectionByID(vSectionOffering.SectionID, vSection) = TranDBResult.Failed Then
            MsgBox("Invalid Section Entry!" & vbNewLine & vbNewLine & _
                   "Unable to save Enrolment Entry. The selected Section ID does not exist in record. Please enter correct Section ID.", vbExclamation)

            Exit Function
        End If

        'check if year level match for student's next year level
        'If curStudent1.Transferee = True Then

        '    MsgBox(curStudent1.TransfereeYL)
        '    MsgBox(vSection.YearLevelID)

        '    If vSection.YearLevelID <> curStudent1.TransfereeYL Then
        '        MsgBox("Invalid Section Entry!" & vbNewLine & vbNewLine & _
        '                "Unable to save Enrolment Entry. The selected Section's Year Level is invalid. Please select Section with '" & YLIDtoTitle(selStudentPrevYL + 1) & "' as Year Level Title.", vbExclamation)

        '        Exit Function
        '    End If

        'Else

        If vSection.YearLevelID <> (selStudentPrevYL1 + 1) Then
            MsgBox("Invalid Section Entry!" & vbNewLine & vbNewLine & _
                    "Unable to save Enrolment Entry. The selected Section's Year Level is invalid. Please select Section with '" & YLIDtoTitle(selStudentPrevYL + 1) & "' as Year Level Title.", vbExclamation)

            Exit Function
        End If

        'End If

        'check student count
        If selSectionStudentCount1 >= vSectionOffering.MaxStudentCount Then
            MsgBox("Invalid Section Entry!" & vbNewLine & vbNewLine & _
                    "Unable to save Enrolment Entry. The selected Section is already Full. Please select another Section.", vbExclamation)

            Exit Function
        End If

        'check grade
        If selStudentPrevYL1 < 1 Then
            'new student
            'If vStudent.OldAveGrade < vSectionOffering.MinGrade Or vStudent.OldAveGrade > vSectionOffering.MaxGrade Then
            '    MsgBox(vStudent.OldAveGrade & " to " & vSectionOffering.MinGrade & "-" & vSectionOffering.MaxGrade)

            '    'invalid grade
            '    MsgBox("Invalid Student Entry!" & vbNewLine & vbNewLine & _
            '        "Unable to save Enrolment Entry. The selected Student Entrance Grade does not match the selected Section's Minimum and Maxium Grade. Please enter another Student.", vbExclamation)

            '    Exit Function
            'End If
        Else
            'old student
        End If

        'check subjects
        If lvEnroll1.Items.Count < 1 Then
            MsgBox("Invalid Section Entry!" & vbNewLine & vbNewLine & _
                    "Unable to save Enrolment Entry. The selected Student to clone does not contain any Subjects. Please select another student.", vbExclamation)
            Exit Function
        End If



        'set enrolment
        '-----------------------------------------------------------------------
        NewEnrolment.EnrolmentID = txtEnrolmentID1.Text
        NewEnrolment.StudentID = txtStudentID1.Text
        NewEnrolment.TermID = txtSY.Text
        NewEnrolment.SectionOfferingID = txtSectionOfferingID.Text
        NewEnrolment.DateEnroled = DateTime.Now.Date

        NewEnrolment.CreationDate = Now
        NewEnrolment.CreatedBy = CurrentUser.UserName
        '-----------------------------------------------------------------------

        Select Case AddEnrolment(NewEnrolment)
            Case TranDBResult.Success 'SUCCESS

                'For Each lv As ListViewItem In lvEnroll2.Items
                '    If CreateBlankGrade(NewEnrolment, lv.SubItems(1).Text) <> TranDBResult.Success Then
                '        CatchError("ModRSEnrolment", "AddEnrolment", "'CreateBlankGrade(NewEnrolment)' went failed")
                '    End If
                'Next

                'save charges
                MsgBox("New Enrolment successfully added.", vbInformation)

                SaveData = True

                curEnrolmentID = txtStudentID1.Text

            Case Else 'unknown result, consider as failed
                'temp
                MsgBox("Enrolment Not added", vbExclamation)
                SaveData = False
        End Select

    End Function

    Private Sub GenerateSectionOffering()

        Dim com As New MySqlCommand("SELECT tblEnrolment.EnrolmentID, tblSectionOffering.SectionOfferingID, tblEnrolment.TermID " & _
                                    "FROM tblSectionOffering INNER JOIN tblEnrolment ON tblSectionOffering.SectionOfferingID = tblEnrolment.SectionOfferingID " & _
                                    "WHERE tblEnrolment.EnrolmentID ='" & txtEnrolmentID.Text & "'", clsCon.con)
        Dim dr As MySqlDataReader = com.ExecuteReader()
        dr.Read()
        If dr.HasRows = True Then
            txtSectionOfferingID.Text = dr("SectionOfferingID").ToString()
        End If
        dr.Close()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        With Grid
            .set_ColWidth(0, 2100)
            .set_ColWidth(1, (12000))

            .set_TextMatrix(0, 0, "ID Number")
            .set_TextMatrix(1, 0, "Fullname")
            .set_TextMatrix(2, 0, "Gender")
            .set_TextMatrix(3, 0, "Year Level")
            .set_TextMatrix(4, 0, "Attended")
            .set_TextMatrix(5, 0, "Entrance Grade")
            .set_TextMatrix(6, 0, "Scholarship")

            .set_TextMatrix(0, 1, "")
            .set_TextMatrix(1, 1, "")
            .set_TextMatrix(2, 1, "")
            .set_TextMatrix(3, 1, "")
            .set_TextMatrix(4, 1, "")
            .set_TextMatrix(5, 1, "")
            .set_TextMatrix(6, 1, "")

            .set_ColAlignment(0, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignLeftCenter)
            .set_ColAlignment(1, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignLeftCenter)
        End With

        lvEnroll1.Items.Clear()
        txtSectionOfferingID.Text = ""
        txtStudentID.Text = ""
        txtEnrolmentID.Text = ""

    End Sub

    Private Sub cmdClose1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose1.Click
        With Grid1
            .set_ColWidth(0, 2100)
            .set_ColWidth(1, (12000))

            .set_TextMatrix(0, 0, "ID Number")
            .set_TextMatrix(1, 0, "Fullname")
            .set_TextMatrix(2, 0, "Gender")
            .set_TextMatrix(3, 0, "Year Level")
            .set_TextMatrix(4, 0, "Attended")
            .set_TextMatrix(5, 0, "Entrance Grade")
            .set_TextMatrix(6, 0, "Scholarship")

            .set_TextMatrix(0, 1, "")
            .set_TextMatrix(1, 1, "")
            .set_TextMatrix(2, 1, "")
            .set_TextMatrix(3, 1, "")
            .set_TextMatrix(4, 1, "")
            .set_TextMatrix(5, 1, "")
            .set_TextMatrix(6, 1, "")

            .set_ColAlignment(0, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignLeftCenter)
            .set_ColAlignment(1, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignLeftCenter)
        End With

        lvEnroll2.Items.Clear()

    End Sub

    Private Sub cmdInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInfo.Click
        Dim frm As New frmStudentRecord
        frm.ShowForm(txtStudentID.Text)
    End Sub

    Private Sub cmdInfo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInfo1.Click
        Dim frm As New frmStudentRecord
        frm.ShowForm(txtStudentID1.Text)
    End Sub

    Private Sub cmdPrint1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint1.Click
        Dim frm As New frmPrintPreview()
        'frm.PK = txtEnrolmentID.Text
        frm.Show()
    End Sub

    Private Sub cmdPrint2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint2.Click
        Dim frm As New frmPrintPreview()
        'frm.PK = txtEnrolmentID1.Text
        frm.Show()
    End Sub
End Class