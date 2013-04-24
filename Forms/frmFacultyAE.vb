Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frmFacultyAE
    Inherits Form
    Public mFormState As String
    Dim RecordAdded As Boolean
    Dim sNewID As Integer

    Dim CurrentTeacher As tTeacher

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmFacultyAE_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        If clsCon.con.State = ConnectionState.Open Then
            clsCon.con.Close()
        End If
        clsCon.con.Open()

        LoadSY()

        cboSY.SelectedIndex = cboSY.Items.IndexOf(CurrentSchoolYear.SchoolYearTitle)
    End Sub
    Public Sub LoadSY()
        Dim com As New MySqlCommand("SELECT SchoolYear FROM tblSchoolYear", clsCon.con)
        Dim dr As MySqlDataReader = com.ExecuteReader()
        cboSY.Items.Clear()
        cboSY.Items.Add("All")
        While dr.Read()
            cboSY.Items.Add(dr("SchoolYear").ToString())
        End While
        dr.Close()
    End Sub
    Public Sub ShowEdit(ByVal sTeacherID As String)

        If GetTeacherByID(sTeacherID, CurrentTeacher) <> TranDBResult.Success Then
            MsgBox("Unable to continue proccess." & vbNewLine & "The selected TEACHER entry was not found in record.", vbExclamation)
            Close()
            Exit Sub
        End If

        LoadAdvisory(sTeacherID)
        RefreshSubjects(sTeacherID)

        Call SetTextField()
        cmdSave.Text = "Update"

        Me.ShowDialog()

    End Sub
    Private Sub SetTextField()
        txtFacultyID.Text = CurrentTeacher.TeacherID
        txtTeacherTitle.Text = CurrentTeacher.TeacherTitle
        txtPassword.Text = CurrentTeacher.Password
        txtFName.Text = CurrentTeacher.FirstName
        txtMName.Text = CurrentTeacher.MiddleName
        txtLName.Text = CurrentTeacher.LastName
        txtAddress.Text = CurrentTeacher.Address
        txtContactNumber.Text = CurrentTeacher.ContactNumber
        chkActive.Checked = CurrentTeacher.Active
    End Sub

    Public Function ShowForm() As Boolean

        '-------------------------------------------------------
        'check user access
        '-------------------------------------------------------
        If UserAllowedTo(CurrentUser.UserName, sCanAddTeacher) = False Then
            MsgBox("Unable to continue Adding Teacher entry." & vbNewLine & vbNewLine & _
                    "You are not permitted to do this. Please contact your administrator for more information.", vbExclamation)
            Exit Function
        End If
        '-------------------------------------------------------
        GenerateID()

        Me.ShowDialog()


    End Function
    Public Function ShowProperties(ByVal sTeacherID As String) As Boolean

        If GetTeacherByID(sTeacherID, CurrentTeacher) <> TranDBResult.Success Then
            MsgBox("Unable to continue proccess." & vbNewLine & "The selected TEACHER entry was not found in record.", vbExclamation)
            Close()
            Exit Function
        End If

        Call SetTextField()

        LoadAdvisory(sTeacherID)
        RefreshSubjects(sTeacherID)

        txtAddress.ReadOnly = True
        txtContactNumber.ReadOnly = True
        txtFName.ReadOnly = True
        txtLName.ReadOnly = True
        txtMName.ReadOnly = True
        txtPassword.ReadOnly = True
        txtTeacherTitle.ReadOnly = True

        cmdSave.Visible = False
        cmdBrowse.Visible = False
        cmdDelete.Visible = False

        chkActive.Enabled = False

        Me.ShowDialog()


    End Function
    Private Sub GenerateID()
        Dim cmddr As New MySqlCommand("select NextNo from tblGenerator Where TableName='Teacher'", clsCon.con)
        Dim dr As MySqlDataReader = cmddr.ExecuteReader()

        While dr.Read()
            Dim strid As String = dr("NextNo").ToString()
            If strid = "" Then
                txtFacultyID.Text = "TN-" & "1"
                sNewID = 1
            Else
                sNewID = Convert.ToInt32(dr("NextNo")) + 1
                txtFacultyID.Text = "TN-" & sNewID.ToString()
            End If
        End While
        dr.Close()
        cmddr.Dispose()
    End Sub
    Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
        Me.Close()
    End Sub

    Private Function SaveData() As Boolean

        Dim newTeacher As tTeacher


        'set failed
        SaveData = False

        If Not ValidateData Then Exit Function


        'set data
        newTeacher.TeacherID = Trim(txtFacultyID.Text)
        newTeacher.TeacherTitle = Trim(txtTeacherTitle.Text)
        newTeacher.Password = Trim(txtPassword.Text)
        newTeacher.FirstName = Trim(txtFName.Text)
        newTeacher.MiddleName = Trim(txtMName.Text)
        newTeacher.LastName = Trim(txtLName.Text)
        newTeacher.Address = Trim(txtAddress.Text)
        newTeacher.ContactNumber = Trim(txtContactNumber.Text)
        newTeacher.Active = chkActive.Checked
        newTeacher.CreationDate = Now


        Select Case AddTeacher(newTeacher)

            Case TranDBResult.Success
                'success
                '----------------------------
                MsgBox("TEACHER entry successfull Added.", vbInformation)
                Close()
                '----------------------------
            Case TranDBResult.DuplicateID
                MsgBox("The TEACHER ID you have entered is already existed." & vbNewLine & "Please enter a different value.", vbExclamation)
                txtFacultyID.Focus()

            Case TranDBResult.DuplicateTitle
                MsgBox("The TEACHER TITLE you have entered is already existed." & vbNewLine & "Please enter a different value.", vbExclamation)
                txtTeacherTitle.Focus()


            Case TranDBResult.InvalidTeacherTitle
                MsgBox("Invalid TEACHER TITLE.", vbExclamation)
                txtTeacherTitle.Focus()


            Case TranDBResult.InvalidTeacherPassword
                MsgBox("Invalid PASSWORD.", vbExclamation)
                txtPassword.Focus()


            Case TranDBResult.InvalidTeacherFirstName
                MsgBox("Invalid FIRST NAME.", vbExclamation)
                txtFName.Focus()


            Case TranDBResult.InvalidTeacherMiddleName
                MsgBox("Invalid MIDDLE NAME.", vbExclamation)
                txtMName.Focus()


            Case TranDBResult.InvalidTeacherLastName
                MsgBox("Invalid LAST NAME.", vbExclamation)
                txtLName.Focus()


            Case TranDBResult.InvalidTeacherContactNumber
                MsgBox("Invalid CONTACT NUMBER.", vbExclamation)
                txtContactNumber.Focus()


            Case TranDBResult.InvalidTeacherAddress
                MsgBox("Invalid ADDRESS.", vbExclamation)
                txtAddress.Focus()
            Case Else
                MsgBox("Unknown result: Adding Teacher entry", vbCritical)
        End Select
    End Function


    Private Function ValidateData() As Boolean

        'set default failed
        ValidateData = False

        If Not CheckTextBox(txtFacultyID, "Teacher ID") Then Exit Function
        If Not CheckTextBox(txtTeacherTitle, "Teacher Name") Then Exit Function
        If Not CheckTextBox(txtPassword, "Password") Then Exit Function
        If Not CheckTextBox(txtFName, "First Name") Then Exit Function
        If Not CheckTextBox(txtMName, "MiddleName") Then Exit Function
        If Not CheckTextBox(txtLName, "LastName") Then Exit Function
        If Not CheckTextBox(txtAddress, "Address") Then Exit Function
        If Not CheckTextBox(txtContactNumber, "ContactNumber") Then Exit Function

        ValidateData = True
    End Function


    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Select Case cmdSave.Text
            Case "Update"
                If UpdateData() Then
                    'added
                    Close()
                End If
            Case Else
                If SaveData() Then
                    'added
                    RecordAdded = True
                    Close()
                End If
        End Select
        
    End Sub
    Private Function UpdateData() As Boolean

        'default
        UpdateData = False

        If Not SetRSField() Then
            UpdateData = False
            Exit Function
        End If


        'save


        Select Case EditTeacher(CurrentTeacher)

            Case TranDBResult.Success
                'success
                '----------------------------
                MsgBox("TEACHER entry successfull edited.", vbInformation)
                Close()
                '----------------------------

            Case TranDBResult.DuplicateID
                MsgBox("The TEACHER ID you have entered is already existed." & vbNewLine & "Please enter a different value.", vbExclamation)
                txtFacultyID.Focus()

            Case TranDBResult.DuplicateTitle
                MsgBox("The TEACHER TITLE you have entered is already existed." & vbNewLine & "Please enter a different value.", vbExclamation)
                txtTeacherTitle.Focus()


            Case TranDBResult.InvalidTeacherTitle
                MsgBox("Invalid TEACHER TITLE.", vbExclamation)
                txtTeacherTitle.Focus()


            Case TranDBResult.InvalidTeacherPassword
                MsgBox("Invalid PASSWORD.", vbExclamation)
                txtPassword.Focus()


            Case TranDBResult.InvalidTeacherFirstName
                MsgBox("Invalid FIRST NAME.", vbExclamation)
                txtFName.Focus()


            Case TranDBResult.InvalidTeacherMiddleName
                MsgBox("Invalid MIDDLE NAME.", vbExclamation)
                txtMName.Focus()


            Case TranDBResult.InvalidTeacherLastName
                MsgBox("Invalid LAST NAME.", vbExclamation)
                txtLName.Focus()


            Case TranDBResult.InvalidTeacherContactNumber
                MsgBox("Invalid CONTACT NUMBER.", vbExclamation)
                txtContactNumber.Focus()


            Case TranDBResult.InvalidTeacherAddress
                MsgBox("Invalid ADDRESS.", vbExclamation)
                txtAddress.Focus()

        End Select



    End Function 'SaveData---------------------------

    Private Function SetRSField() As Boolean

        SetRSField = False

        If Not ValidateData Then Exit Function

        'set data
        CurrentTeacher.TeacherID = Trim(txtFacultyID.Text)
        CurrentTeacher.TeacherTitle = Trim(txtTeacherTitle.Text)
        CurrentTeacher.Password = Trim(txtPassword.Text)
        CurrentTeacher.FirstName = Trim(txtFName.Text)
        CurrentTeacher.MiddleName = Trim(txtMName.Text)
        CurrentTeacher.LastName = Trim(txtLName.Text)
        CurrentTeacher.Address = Trim(txtAddress.Text)
        CurrentTeacher.ContactNumber = Trim(txtContactNumber.Text)
        CurrentTeacher.Active = chkActive.Checked

        SetRSField = True
    End Function
    Public Sub LoadAdvisory(ByVal FacultyID As String)
        Dim com As New MySqlCommand(" SELECT tblEnrolment.SchoolYear, CONCAT(tblYearLevel.YearLevelTitle , ' - ' , tblSection.SectionTitle) AS SectionFullTitle, tblStudent.StudentID, CONCAT(tblStudent.LastName , ', ' , tblStudent.FirstName , ' ' , tblStudent.MiddleName) AS StudentFullName" & _
                                    " FROM (tblYearLevel INNER JOIN (tblSection INNER JOIN tblSectionOffering ON tblSection.SectionID = tblSectionOffering.SectionID) ON tblYearLevel.YearLevelID = tblSection.YearLevelID) INNER JOIN (tblStudent INNER JOIN tblEnrolment ON tblStudent.StudentID = tblEnrolment.StudentID) ON tblSectionOffering.SectionOfferingID = tblEnrolment.SectionOfferingID" & _
                                    " WHERE tblSectionOffering.TeacherID='" & FacultyID & "'", clsCon.con)

        Dim dr As MySqlDataReader = com.ExecuteReader()
        lvAdvisory.Items.Clear()
        While dr.Read()
            Dim list As New ListViewItem(dr("StudentFullName").ToString())
            list.SubItems.Add(dr("StudentID").ToString())
            list.SubItems.Add(dr("SectionFullTitle").ToString())
            lvAdvisory.Items.AddRange(New ListViewItem() {list})
        End While
        dr.Close()
    End Sub
    Private Sub RefreshSubjects(ByVal FacultyID As String)
        Dim sSQL As String

        'clear subject list
        lsvLoad.Items.Clear()

        'On Error GoTo ReleaseAndExit

        If cboSY.Text = "All" Then

            sSQL = "SELECT tblTeacher.TeacherID, tblSubjectOffering.SubjectOfferingID, tblSectionOffering.SchoolYear, tblSubject.SubjectTitle, CONCAT(tblYearLevel.YearLevelTitle , '-' , tblSection.SectionTitle) AS YRSection, tblSubject.Units, tblroom.Room, CONCAT(tblSubjectOffering.Days , ' ' , tblSubjectOffering.SchedTimeStart , '-' , tblSubjectOffering.SchedTimeEnd) AS Schedule" & _
                    " FROM (((tblYearLevel INNER JOIN tblSection ON tblYearLevel.YearLevelID = tblSection.YearLevelID) INNER JOIN tblSectionOffering ON tblSection.SectionID = tblSectionOffering.SectionID) INNER JOIN (tblSubject INNER JOIN (tblTeacher INNER JOIN tblSubjectOffering ON tblTeacher.TeacherID = tblSubjectOffering.TeacherID) ON tblSubject.SubjectID = tblSubjectOffering.SubjectID) ON tblSectionOffering.SectionOfferingID = tblSubjectOffering.SectionOfferingID) INNER JOIN tblroom ON tblSubjectOffering.RoomID = tblroom.RoomID" & _
                    " WHERE (((tblTeacher.TeacherID)='" & FacultyID & "') AND tblSectionOffering.SchoolYear='" & cboSY.Text & "')" & _
                    " ORDER BY tblSectionOffering.SchoolYear DESC , tblSubject.SubjectTitle DESC;"
        Else
            sSQL = "SELECT tblTeacher.TeacherID, tblSubjectOffering.SubjectOfferingID, tblSectionOffering.SchoolYear, tblSubject.SubjectTitle, CONCAT(tblYearLevel.YearLevelTitle , '-' , tblSection.SectionTitle) AS YRSection, tblSubject.Units, tblroom.Room, CONCAT(tblSubjectOffering.Days , ' ' , tblSubjectOffering.SchedTimeStart , '-' , tblSubjectOffering.SchedTimeEnd) AS Schedule" & _
                    " FROM (((tblYearLevel INNER JOIN tblSection ON tblYearLevel.YearLevelID = tblSection.YearLevelID) INNER JOIN tblSectionOffering ON tblSection.SectionID = tblSectionOffering.SectionID) INNER JOIN (tblSubject INNER JOIN (tblTeacher INNER JOIN tblSubjectOffering ON tblTeacher.TeacherID = tblSubjectOffering.TeacherID) ON tblSubject.SubjectID = tblSubjectOffering.SubjectID) ON tblSectionOffering.SectionOfferingID = tblSubjectOffering.SectionOfferingID) INNER JOIN tblroom ON tblSubjectOffering.RoomID = tblroom.RoomID" & _
                    " WHERE (((tblTeacher.TeacherID)='" & FacultyID & "'))" & _
                    " ORDER BY tblSectionOffering.SchoolYear DESC , tblSubject.SubjectTitle DESC;"

        End If


        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        While vRS.Read()
            Dim lv As New ListViewItem(vRS("SubjectTitle").ToString())
            lv.SubItems.Add(vRS("SubjectOfferingID").ToString())
            lv.SubItems.Add(vRS("YRSection").ToString())
            lv.SubItems.Add(vRS("Units").ToString())
            lv.SubItems.Add(vRS("Room").ToString())
            lv.SubItems.Add(vRS("Schedule").ToString())
            lsvLoad.Items.AddRange(New ListViewItem() {lv})
        End While
        vRS.Close()

ReleaseAndExit:
        Exit Sub
    End Sub

    Public Sub LoadStudentList(ByVal SubjectOfferingID As String)
        Dim com As New MySqlCommand(" SELECT tblstudent.StudentID, tblenrolment.EnrolmentID, tblgrade.SubjectOfferingID, tblstudent.LastName, tblstudent.FirstName, tblstudent.MiddleName, tblgrade.FirstGrading, tblgrade.SecondGrading, tblgrade.ThirdGrading, tblgrade.FourthGrading, tblgrade.GradeValue,if((tblgrade.GradeValue < 75),'Failed','Passed') AS Remark" & _
                                    " FROM tblenrolment INNER JOIN tblgrade ON tblenrolment.EnrolmentID = tblgrade.EnrolmentID INNER JOIN tblstudent ON tblenrolment.StudentID = tblstudent.StudentID" & _
                                    " WHERE tblgrade.SubjectOfferingID='" & SubjectOfferingID & "'", clsCon.con)

        Dim dr As MySqlDataReader = com.ExecuteReader()
        lsvClasslist.Items.Clear()
        While dr.Read()
            Dim list As New ListViewItem(dr("StudentName").ToString())
            list.SubItems.Add(dr("StudentID").ToString())
            list.SubItems.Add(dr("FirstGrading").ToString())
            list.SubItems.Add(dr("SecondGrading").ToString())
            list.SubItems.Add(dr("ThirdGrading").ToString())
            list.SubItems.Add(dr("FourthGrading").ToString())
            list.SubItems.Add(dr("GradeValue").ToString())
            list.SubItems.Add(dr("Remark").ToString())
            lsvClasslist.Items.AddRange(New ListViewItem() {list})
        End While
        dr.Close()
    End Sub

    Private Sub lsvLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsvLoad.Click
        If lsvLoad.Items.Count > 0 Then
            LoadStudentList(lsvLoad.FocusedItem.SubItems(1).Text)
        End If
    End Sub
End Class
