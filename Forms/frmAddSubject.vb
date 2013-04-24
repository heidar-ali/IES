Imports System.Windows.Forms
Imports MySql.Data.MySqlClient


Public Class frmAddSubject

    Dim RecordAdded As Boolean
    Dim RecordEdited As Boolean

    Dim SubjectID As String

    Dim SubjectAreaID As String
    Dim SubjectMode As String
    Dim ParentSubjectID As String

    Dim CurSubject As tSubject

    Public Function ShowForm(Optional ByVal sDepartmentTitle As String = "", Optional ByVal sYearLevelTitle As String = "", Optional ByVal sTeacherTitle As String = "") As Boolean

        Dim sNewSubjectID As String

        'set defaults
        ShowForm = False
        RecordAdded = False

        GetNewSubjectID(txtSubjectID.Text)

        'show form
        Me.ShowDialog()

        'return
        ShowForm = RecordAdded
    End Function
    Public Function ShowEdit(ByVal sSubjectID As String) As Boolean
        Dim vDepartment As tDepartment
        Dim vSubjectArea As tSubjectAreas
        Dim vSubjectMode As tSubjectMode
        Dim vProg As tAcademicPrograms
        Dim Classs As tProgramClass

        'set defaults
        ShowEdit = False

        'get subject
        If GetSubjectByID(sSubjectID, CurSubject) = TranDBResult.Success Then

            'set text fields
            txtSubjectID.Text = CurSubject.SubjectID
            txtSubjectTitle.Text = CurSubject.SubjectTitle
            txtDescription.Text = CurSubject.Description
            txtLecUnits.Text = CurSubject.Units
            txtLecHrs.Text = CurSubject.LecHrs
            txtSubjectCode.Text = CurSubject.SubjectCode
            txtLabHrs.Text = CurSubject.LabHrs
            txtLabUnits.Text = CurSubject.LabUnits
            txtAlias.Text = CurSubject.Alias1
            txtAlias2.Text = CurSubject.Alias2
            txtMaxSlots.Text = CurSubject.MaxSlots
            txtMinSlots.Text = CurSubject.MinSlots
            txtCreditUnits.Text = CurSubject.CreditUnits

            If GetSubjectAreasByID(CurSubject.SubjectAreaID, vSubjectArea) = TranDBResult.Success Then
                txtSubjectArea.Text = vSubjectArea.SubjectAreaName
                SubjectAreaID = CurSubject.SubjectAreaID
            End If

            If GetSubjectModeByID(CurSubject.SubjectMode, vSubjectMode) = TranDBResult.Success Then
                txtSubjectMode.Text = vSubjectMode.Description
                SubjectMode = CurSubject.SubjectMode
            End If

            If GetProgramByProgramID(CurSubject.SubjectParentID, vProg) = TranDBResult.Success Then
                txtParentCode.Text = vProg.ProgramCode
                ParentSubjectID = CurSubject.SubjectParentID
            End If

            If GetProgramClass(CurSubject.CourseLevelID, Classs) = TranDBResult.Success Then
                cboCourseLevel.Text = Classs.ClassDesc
                cboCourseLevelID.Text = Classs.ClassCode
            End If

            chkCompSubj.Checked = IntToBoolean(CurSubject.IsComputerSubject)
            chkELearning.Checked = IntToBoolean(CurSubject.IsSubjectELearning)
            chkGenEduc.Checked = IntToBoolean(CurSubject.IsSubjectGE)
            chkElective.Checked = IntToBoolean(CurSubject.IsSubjectElective)
            chkGPAGWA.Checked = IntToBoolean(CurSubject.InclGWA)
            chkInactive.Checked = IntToBoolean(CurSubject.InActive)
            chkNonAcademic.Checked = IntToBoolean(CurSubject.IsNonAcademic)
            chkSubjWithInternet.Checked = IntToBoolean(CurSubject.SubjectWithInternet)
            chkOther.Checked = IntToBoolean(CurSubject.IsOtherSchool)
            chkTransmutedGrades.Checked = IntToBoolean(CurSubject.UseTransmutedGrade)
            chkClub.Checked = IntToBoolean(CurSubject.IsClubOrganization)
            chkMajor.Checked = IntToBoolean(CurSubject.IsSubjectMajor)

        Else

            Close()
            Exit Function

        End If
        'show form
        OK_Button.Text = "Update"
        Me.ShowDialog()

        'return
        ShowEdit = RecordEdited
    End Function
    Private Function SaveData() As Boolean

        Dim newSubject As tSubject
        Dim vDepartment As tDepartment
        Dim vSubjMode As tSubjectMode
        Dim vSubjArea As tSubjectAreas

        'set default
        SaveData = False

        'validate date
        If Not ValidateData Then Exit Function

        'set rs field
        newSubject.SubjectID = txtSubjectID.Text
        newSubject.SubjectTitle = txtSubjectTitle.Text
        newSubject.Description = txtDescription.Text
        newSubject.SubjectCode = txtSubjectCode.Text
        newSubject.CreditUnits = CInt(txtCreditUnits.Text)
        newSubject.Units = CInt(txtLecUnits.Text)
        newSubject.LecHrs = CInt(txtLecHrs.Text)
        newSubject.LabHrs = CInt(txtLabHrs.Text)
        newSubject.LabUnits = CInt(txtLabUnits.Text)

        newSubject.Alias1 = txtAlias.Text
        newSubject.Alias2 = txtAlias2.Text

        newSubject.MinSlots = txtMinSlots.Text
        newSubject.MaxSlots = txtMaxSlots.Text

        newSubject.IsComputerSubject = BooleanToInt(chkCompSubj.Checked)
        newSubject.IsNonAcademic = BooleanToInt(chkNonAcademic.Checked)
        newSubject.IsSubjectELearning = BooleanToInt(chkELearning.Checked)
        newSubject.IsSubjectElective = BooleanToInt(chkElective.Checked)
        newSubject.IsSubjectGE = BooleanToInt(chkGenEduc.Checked)
        newSubject.SubjectWithInternet = BooleanToInt(chkSubjWithInternet.Checked)
        newSubject.InclGWA = BooleanToInt(chkGPAGWA.Checked)
        newSubject.InActive = BooleanToInt(chkInactive.Checked)
        newSubject.IsOtherSchool = BooleanToInt(chkOther.Checked)
        newSubject.UseTransmutedGrade = BooleanToInt(chkTransmutedGrades.Checked)
        newSubject.SubjectParentID = txtParentCode.Text
        newSubject.IsClubOrganization = BooleanToInt(chkClub.Checked)
        newSubject.IsSubjectMajor = BooleanToInt(chkMajor.Checked)

        newSubject.SubjectAreaID = SubjectAreaID

        newSubject.SubjectMode = SubjectMode

        newSubject.SubjectParentID = ParentSubjectID
        newSubject.CourseLevelID = cboCourseLevelID.Text
        'try

        If chklock.CheckState = CheckState.Checked Then
            newSubject.DateLocked = DateTime.Now()
        Else
            newSubject.DateLocked = ""
        End If

        newSubject.CreatedBy = CurrentUser.UserName
        newSubject.CreationDate = DateTime.Now()

        Select Case AddSubject(newSubject)
            Case TranDBResult.Success
                'success
                '-------------------------------------
                'Subject successfully saved

                SaveData = True


            Case TranDBResult.DuplicateCode
                MsgBox("Subject Code already existed", vbExclamation)
                SaveData = False

            Case TranDBResult.DuplicateID
                MsgBox("ID already existed.", vbExclamation)
                SaveData = False

            Case TranDBResult.InvalidSubjectDescription
                MsgBox("Invalid Description.", vbExclamation)
                HLTxt(txtDescription)
                SaveData = False

            Case TranDBResult.InvalidSubjectCode
                MsgBox("Invalid Subject Code.", vbExclamation)
                HLTxt(txtSubjectCode)
                SaveData = False

            Case TranDBResult.InvalidSubjectUnits
                MsgBox("Invalid Lecture Unit.", vbExclamation)
                HLTxt(txtLecUnits)
                SaveData = False

            Case TranDBResult.InvalidSubjectLabUnits
                MsgBox("Invalid Laboratory Units.", vbExclamation)
                HLTxt(txtLabUnits)
                SaveData = False

            Case Else
                'fatal
                'temp
                MsgBox("Unknown Error.", vbExclamation)
                SaveData = False
        End Select
    End Function

    Private Function UpdateData() As Boolean

        Dim newSubject As tSubject
        Dim vDepartment As tDepartment
        Dim vYearlevel As tYearLevel

        'set default
        UpdateData = False

        'validate date
        If Not ValidateData() Then Exit Function

        'check id, it must be existed
        If SubjectExistByID(LCase(Trim(txtSubjectID.Text))) <> TranDBResult.Success Then
            MsgBox("Subject ID not found.", vbExclamation)
            HLTxt(txtSubjectID)
            Exit Function
        End If


        'set rs field
        newSubject.SubjectID = txtSubjectID.Text
        newSubject.SubjectTitle = txtSubjectTitle.Text
        newSubject.Description = txtDescription.Text
        newSubject.SubjectCode = txtSubjectCode.Text
        newSubject.CreditUnits = CInt(txtCreditUnits.Text)
        newSubject.Units = CInt(txtLecUnits.Text)
        newSubject.LecHrs = CInt(txtLecHrs.Text)
        newSubject.LabHrs = CInt(txtLabHrs.Text)
        newSubject.LabUnits = CInt(txtLabUnits.Text)

        newSubject.Alias1 = txtAlias.Text
        newSubject.Alias2 = txtAlias2.Text

        newSubject.MinSlots = txtMinSlots.Text
        newSubject.MaxSlots = txtMaxSlots.Text

        newSubject.IsComputerSubject = BooleanToInt(chkCompSubj.Checked)
        newSubject.IsNonAcademic = BooleanToInt(chkNonAcademic.Checked)
        newSubject.IsSubjectELearning = BooleanToInt(chkELearning.Checked)
        newSubject.IsSubjectElective = BooleanToInt(chkElective.Checked)
        newSubject.IsSubjectGE = BooleanToInt(chkGenEduc.Checked)
        newSubject.SubjectWithInternet = BooleanToInt(chkSubjWithInternet.Checked)
        newSubject.InclGWA = BooleanToInt(chkGPAGWA.Checked)
        newSubject.InActive = BooleanToInt(chkInactive.Checked)
        newSubject.IsOtherSchool = BooleanToInt(chkOther.Checked)
        newSubject.UseTransmutedGrade = BooleanToInt(chkTransmutedGrades.Checked)
        newSubject.IsOtherSchool = BooleanToInt(chkOther.Checked)
        newSubject.IsSubjectMajor = BooleanToInt(chkMajor.Checked)
        newSubject.IsClubOrganization = BooleanToInt(chkClub.Checked)
        newSubject.IsSubjectMajor = BooleanToInt(chkMajor.Checked)


        newSubject.SubjectAreaID = SubjectAreaID
        newSubject.SubjectMode = SubjectMode

        newSubject.SubjectParentID = ParentSubjectID
        newSubject.CourseLevelID = cboCourseLevelID.Text


        If chklock.CheckState = CheckState.Checked Then
            newSubject.DateLocked = DateTime.Now()
        Else
            'newSubject.DateLocked = ""
        End If

        newSubject.Modified = CurrentUser.UserName
        newSubject.ModifiedDate = DateTime.Now

        Select Case EditSubject(newSubject)
            Case TranDBResult.Success
                'success
                '-------------------------------------
                'Subject successfully saved
                'return success
                UpdateData = True

            Case TranDBResult.DuplicateCode
                MsgBox("Subject Code already exists", vbExclamation)
                HLTxt(txtSubjectCode)
                UpdateData = False

            Case TranDBResult.DuplicateTitle
                MsgBox("Title already existed.", vbExclamation)
                HLTxt(txtSubjectTitle)
                UpdateData = False

            Case TranDBResult.InvalidSubjectDescription
                MsgBox("Invalid Description.", vbExclamation)
                HLTxt(txtDescription)
                UpdateData = False


            Case Else
                'fatal
                'temp
                MsgBox("Unknown Error.", vbExclamation)
                UpdateData = False
        End Select
    End Function

    Private Function ValidateData() As Boolean

        'default
        ValidateData = False

        'check title
        If Not CheckTextBox(txtSubjectTitle, "Please Enter Subject Title") Then
            Exit Function
        End If

        If Not CheckTextBox(txtSubjectcode, "Please Enter Subject Code") Then
            Exit Function
        End If

        'check title
        If Not CheckTextBox(txtDescription, "Please Enter Description") Then
            Exit Function
        End If

        If Not CheckTextBox(txtLecUnits, "Please Enter Lecture/Academic Unit(s)") Then
            Exit Function
        End If

        If Not CheckTextBox(txtCreditUnits, "Please Enter Credited Unit(s)") Then
            Exit Function
        End If

        If Not CheckTextBox(txtLabUnits, "Please Enter Laboratory Unit(s)") Then
            Exit Function
        End If

        If Not CheckTextBox(txtLecHrs, "Please enter Lecture Hours") Then Exit Function

        If Not CheckTextBox(txtLabHrs, "Please enter Laboratory Hours") Then Exit Function

        ValidateData = True
    End Function


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Select Case OK_Button.Text
            Case "Update"
                If UpdateData() Then 'Edited
                    MsgBox("Subject Entry successfully Edited.", vbInformation)
                    RecordEdited = True
                    Close()
                End If
            Case Else
                If SaveData() Then 'added
                    MsgBox("Subject Entry successfully added.", vbInformation)
                    RecordAdded = True
                    Close()
                End If
        End Select
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub

    Private Sub frmAddSubject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillCombo(cboCourseLevel, "SELECT ClassDesc FROM tblProgram_Class")
        fillCombo(cboCourseLevelID, "SELECT ClassCode FROM tblProgram_Class")
    End Sub


    Private Sub cmdNewSubjectArea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNewSubjectArea.Click
        Dim frm As New frmAddSubjectAreas()
        frm.ShowForm()
    End Sub

    Private Sub cmdNewSubjectMode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNewSubjectMode.Click
        Dim frm As New frmAddSubjectMode()
        frm.ShowForm()
    End Sub

    Private Sub cmdBrowseSubjectArea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBrowseSubjectArea.Click
        Dim frm As New PickSubjectAreas()
        frm.GetSubjectAreas(txtSubjectArea.Text, SubjectAreaID)
    End Sub

    Private Sub cmdBrowseSubjectMode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBrowseSubjectMode.Click
        Dim frm As New PickSubjectMode()
        frm.GetSubjectMode(txtSubjectMode.Text, SubjectMode)
    End Sub

    Private Sub cboCourseLevel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCourseLevel.SelectedIndexChanged
        cboCourseLevelID.SelectedIndex = cboCourseLevel.SelectedIndex
    End Sub

    Private Sub cmdAlias2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAlias2.Click
        Dim frm As New frmCodeAliasSample()
        frm.ShowDialog()
    End Sub

    Private Sub cmdParent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdParent.Click
        Dim frm As New frmParentCodeSample()
        frm.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim frm As New PickAcademicPrograms()
        frm.GetAcademicProgram(, txtParentCode.Text, ParentSubjectID, )
    End Sub
End Class
