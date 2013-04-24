Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports System.Drawing.Drawing2D

Public Class frmCollegeAE
    Inherits Form

    Dim imgState As ImageState
    Dim vEmp As tEmployee

    Dim mFormState As FormState

    Dim CollegeID As String

    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub ShowForm()

        GetNewCollegeID(CollegeID)
        imgState = ImageState.NoImage
        mFormState = FormState.addFormState

        cmdSave.Text = "Save"

        Me.ShowDialog()
    End Sub

    Public Sub ShowEdit(ByVal sCollegeCode As String)
        Dim vCollege As tCollege

        If GetCollegeByID(sCollegeCode, vCollege) <> TranDBResult.Success Then Exit Sub

        CollegeID = vCollege.CollegeID
        txtCollegeCode.Text = vCollege.CollegeCode
        txtCollegeName.Text = vCollege.CollegeName

        chkActive.Checked = IntToBoolean(vCollege.InActive)
        cboCampus.SelectedIndex = vCollege.CampusID - 1

        cboDeanID.Text = vCollege.CollegeDean
        cboDean.Text = getEmployeeFullNameByID(cboDeanID.Text)

        GetPhoto("SELECT CollegeLogo FROM tblColleges WHERE CollegeID='" & vCollege.CollegeID & "'", picLogo)

        cmdSave.Text = "Update"

        mFormState = FormState.updateFormState

        'Me.ShowDialog()
    End Sub
    Private Sub frmFacultySchedule_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillCombo(cboCampus, "SELECT ShortName FROM tblCampus")
        fillCombo(cboCampusID, "SELECT CampusID FROM tblCampus")
        'fillMultiColumnCombo2(cboCampusID, "SELECT ShortName,CampusID FROM tblCampus")
        'cboCampus.SelectedIndex = ReadINI("Campus", "Campus", CONFIG_INI_FILE)
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Select Case mFormState
            Case FormState.updateFormState
                UpdateData()
            Case FormState.addFormState
                SaveData()
        End Select
    End Sub
    Private Function SaveData() As Boolean
        Dim vCollege As tCollege

        If cboCampusID.Text = "" Then
            MsgBox("Please select campus for this college", vbExclamation)
            Exit Function
        End If

        If Not CheckTextBox(txtCollegeCode, "Please enter College Code or Acronym") Then Exit Function

        If Not CheckTextBox(txtCollegeName, "Please enter College Name") Then Exit Function

        vCollege.CampusID = cboCampusID.Text
        vCollege.CollegeCode = txtCollegeCode.Text
        vCollege.CollegeName = txtCollegeName.Text
        vCollege.CollegeDean = cboDean.Text
        vCollege.DeanID = cboDeanID.Text
        vCollege.CollegeID = CollegeID
        vCollege.InActive = BooleanToInt(chkActive.CheckState)

        Select Case AddCollege(vCollege)
            Case TranDBResult.Success
                Select Case imgState
                    Case ImageState.NoImage
                        MsgBox("Record successfully save", vbInformation)
                        LoadCollegesByCampus(cboCampusID.Text)
                    Case ImageState.WithImage
                        Select Case SaveCollegePhoto(vCollege, picLogo)
                            Case TranDBResult.Success
                                MsgBox("Record successfully save - WITH LOGO", vbInformation)
                                LoadCollegesByCampus(cboCampusID.Text)
                            Case TranDBResult.Failed
                                MsgBox("Record successfully save but there is an error while uploading the College logo", vbCritical)
                                LoadCollegesByCampus(cboCampusID.Text)
                        End Select
                End Select

            Case TranDBResult.DuplicateCode
                MsgBox("Duplicate College Code found. Please enter another college code", vbExclamation)
                Close()
            Case TranDBResult.Failed
                CatchError("frmCollegeAE", "cmdSave_OnClick - SaveData()", "Unknown Error")
                Exit Function
        End Select
    End Function

    Private Function UpdateData() As Boolean
        Dim vCollege As tCollege

        If cboCampusID.Text = "" Then
            MsgBox("Please select campus for this college", vbExclamation)
            Exit Function
        End If

        If Not CheckTextBox(txtCollegeCode, "Please enter College Code or Acronym") Then Exit Function

        If Not CheckTextBox(txtCollegeName, "Please enter College Name") Then Exit Function

        vCollege.CampusID = cboCampusID.Text
        vCollege.CollegeCode = txtCollegeCode.Text
        vCollege.CollegeName = txtCollegeName.Text
        vCollege.CollegeDean = cboDean.Text
        vCollege.DeanID = cboDeanID.Text
        vCollege.CollegeID = CollegeID
        vCollege.InActive = BooleanToInt(chkActive.CheckState)

        Select Case EditCollege(vCollege)
            Case TranDBResult.Success
                Select Case imgState
                    Case ImageState.NoImage
                        MsgBox("Record successfully updated", vbInformation)
                        LoadCollegesByCampus(cboCampusID.Text)
                    Case ImageState.WithImage
                        Select Case SaveCollegePhoto(vCollege, picLogo)
                            Case TranDBResult.Success
                                MsgBox("Record successfully updated - WITH LOGO", vbInformation)
                                LoadCollegesByCampus(cboCampusID.Text)
                            Case TranDBResult.Failed
                                MsgBox("Record successfully updated but there is an error while uploading the College logo", vbCritical)
                                LoadCollegesByCampus(cboCampusID.Text)
                        End Select
                End Select
            Case TranDBResult.DuplicateCode
                MsgBox("Duplicate College Code found. Please enter another college code", vbExclamation)
                Close()
            Case TranDBResult.Failed
                CatchError("frmCollegeAE", "cmdSave_OnClick - UpdateData()", "Unknown Error")
                Exit Function
        End Select
    End Function
    Private Sub cboCampus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCampus.SelectedIndexChanged
        cboCampusID.SelectedIndex = cboCampus.SelectedIndex
        LoadCollegesByCampus(cboCampusID.Text)

        fillCombo(cboDean, "SELECT fnEmployeeName(EmployeeID) FROM tblTeacher WHERE CampusID='" & cboCampusID.Text & "' ORDER BY TeacherID")
        fillCombo(cboDeanID, "SELECT EmployeeID FROM tblTeacher WHERE CampusID='" & cboCampusID.Text & "' ORDER BY TeacherID")

    End Sub

    Private Sub cboDean_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDean.SelectedIndexChanged
        cboDeanID.SelectedIndex = cboDean.SelectedIndex
    End Sub

    Private Sub cboCampus_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCampus.SelectedValueChanged
        'cboCampusID.SelectedIndex = cboCampus.SelectedIndex
    End Sub

   
    Private Sub cmdBrowse_Click(sender As System.Object, e As System.EventArgs) Handles cmdBrowse.Click
        Dim OpenFile As New OpenFileDialog()
        Try
            With OpenFile
                .FileName = ""
                .Title = "Photo:"
                .Filter = "Image files: (*.jpg)|*.jpg|(*.jpeg)|*.jpeg|(*.png)|*.png|(*.gif)|*.gif|(*.bmp)|*.bmp| All Files (*.*)|*.*"
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.picLogo.Image = System.Drawing.Image.FromFile(.FileName)
                    imgState = ImageState.WithImage
                Else
                    'Wala lang po...
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error...")
        End Try
    End Sub


    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        If dgCollege.Rows.Count > 0 Then
            Dim n As Integer = dgCollege.CurrentRow.Index
            ExecuteDeleteCollege(dgCollege.Rows(n).Cells(1).Value.ToString())
        End If
    End Sub

    Private Sub cmdEditCollege_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditCollege.Click
        If dgCollege.Rows.Count > 0 Then
            Dim n As Integer = dgCollege.CurrentRow.Index
            Dim frm As New frmCollegeAE()
            frm.ShowEdit(dgCollege.Rows(n).Cells(1).Value.ToString())
        End If
    End Sub


    Private Sub LoadCollegesByCampus(ByVal CampusID As String)

        Dim com As New MySqlCommand("SELECT CollegeID,CollegeName, CollegeCode,CollegeDean,fnEmployeeName(CollegeDean) AS `Dean`,InActive, IF(LENGTH(CollegeLogo) > 1,'WITH LOGO','NO LOGO') AS CollegeLogo  FROM tblcolleges WHERE CampusID='" & CampusID & "'", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        'Dim dA As New MySqlDataAdapter()
        'Dim dS As New DataSet()
        'Dim BS As New BindingSource

        'dA.SelectCommand = com
        'dA.Fill(dS)
        'BS.DataSource = dS.Tables(0).DefaultView

        'dgCollege.AutoGenerateColumns = True
        'dgCollege.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        'dgCollege.AutoResizeColumn(0)
        'dgCollege.DataSource = BS

        dgCollege.Rows.Clear()
        While vRS.Read()
            Dim n As Integer = dgCollege.Rows.Add()
            dgCollege.Rows(n).Cells(0).Value = vRS("CollegeCode").ToString()
            dgCollege.Rows(n).Cells(1).Value = vRS("CollegeName").ToString()
            dgCollege.Rows(n).Cells(2).Value = vRS("CollegeDean").ToString()

            dgCollege.Rows(n).Cells(3).Value = vRS("Dean").ToString()
            dgCollege.Rows(n).Cells(4).Value = vRS("CollegeLogo").ToString()
            dgCollege.Rows(n).Cells(5).Value = IntToBoolean(vRS("InActive").ToString())
            dgCollege.Rows(n).Cells(6).Value = vRS("CollegeID").ToString()
        End While
        vRS.Close()
    End Sub

    Private Sub ToolStripButtonNew_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonNew.Click, cmdNewCollege.Click

    End Sub

    Private Sub dgCollege_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgCollege.CellClick
        If dgCollege.RowCount > 0 Then
            ShowEdit(dgCollege.Item(6, dgCollege.CurrentRow.Index).Value.ToString())
        End If
    End Sub
End Class
