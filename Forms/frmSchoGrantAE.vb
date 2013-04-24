Imports System.Windows.Forms

Public Class frmSchoGrantAE

    Dim State As FormState
    Dim Scho As ScholarshipGrantTemplates

    Dim TemplateID As String

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmSchoGrantAE_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub ShowForm()

        State = FormState.addFormState

        fillCombo(cboTerm, "SELECT fnAcademicYearTerm(TermID) From tblAYTerm")
        fillCombo(cboProvider, "SELECT CONCAT(ProvCode, ' - ' ,ProvName) FROM tblSchoProviders")

        fillCombo(cboTermID, "SELECT tblAYTerm.TermID From tblAYTerm")
        fillCombo(cboProviderID, "SELECT SchoProviderID FROM tblSchoProviders")

        Me.ShowDialog()
    End Sub

    Public Sub ShowEdit(ByVal GrantTemplateID As Integer)
        Dim Scho As ScholarshipGrantTemplates
        Dim Prov As ScholarshipProviders
        Dim Term As tSchoolYear

        State = FormState.updateFormState

        If GetSchoGrantTemplateByID(GrantTemplateID, Scho) = TranDBResult.Success Then
            txtDescription.Text = Scho.Description
            txtShortName.Text = Scho.ShortName
            txtTemplateCode.Text = Scho.TemplateCode

            TemplateID = Scho.GrantTemplateID

            If GetScholarshipProviderByID(Scho.SchoProviderID, Prov) = TranDBResult.Success Then
                cboProvider.Text = Prov.ProvName
                cboProviderID.Text = Prov.SchoProviderID
            End If

            If GetAcademicYearTerm(Scho.TermID, Term) = TranDBResult.Success Then
                cboTerm.Text = Term.SchoolYearTitle & "-" & Term.SchoolTerm
                cboTermID.Text = Scho.TermID
            End If

        End If

        Me.ShowDialog()
    End Sub

    Private Sub cmdSave_Click(sender As System.Object, e As System.EventArgs) Handles cmdSave.Click
        Select Case State
            Case FormState.addFormState
                SaveData()
            Case FormState.updateFormState
                UpdateData()
        End Select
    End Sub

    Private Sub SaveData()
        If Not CheckTextBox(txtShortName, "Please enter Shortname for Scholarship Grant Template") Then HLTxt(txtShortName) : Exit Sub
        If Not CheckTextBox(txtTemplateCode, "Please enter Template Code for Scholarship Grant Template") Then HLTxt(txtTemplateCode) : Exit Sub

        If cboProvider.Text = "" Then cboProvider.Focus() : Exit Sub
        If cboTerm.Text = "" Then MsgBox("Please select Academic Year Term", MsgBoxStyle.Exclamation) : cboTerm.Focus() : Exit Sub


        Scho.TemplateCode = txtTemplateCode.Text
        Scho.ShortName = txtShortName.Text
        Scho.TermID = cboTermID.Text
        Scho.Description = txtDescription.Text
        Scho.SchoProviderID = cboProviderID.Text

        Select Case SaveScholarshipGrantTemplate(Scho)
            Case TranDBResult.Success
                MsgBox("Record successfully saved", vbInformation, Application.ProductName)
                Close()
            Case TranDBResult.DuplicateCode
                CatchError("modScholarship", "SaveScholarshipGrantTemplate", "Unable to save entry duplicate Template code found..." & vbNewLine & "Please enter different Template Code")
                Exit Sub
            Case TranDBResult.DuplicateID
                CatchError("modScholarship", "SaveScholarshipGrantTemplate", "Unable to save entry duplicate Template ID found..." & vbNewLine & "Please enter different Template ID")
                Exit Sub
        End Select
    End Sub

    Private Sub UpdateData()
        If Not CheckTextBox(txtShortName, "Please enter Shortname for Scholarship Grant Template") Then HLTxt(txtShortName) : Exit Sub
        If Not CheckTextBox(txtTemplateCode, "Please enter Template Code for Scholarship Grant Template") Then HLTxt(txtTemplateCode) : Exit Sub

        If cboProvider.Text = "" Then cboProvider.Focus() : Exit Sub
        If cboTerm.Text = "" Then MsgBox("Please select Academic Year Term", MsgBoxStyle.Exclamation) : cboTerm.Focus() : Exit Sub


        Scho.TemplateCode = txtTemplateCode.Text
        Scho.ShortName = txtShortName.Text
        Scho.TermID = cboTermID.Text
        Scho.Description = txtDescription.Text
        Scho.SchoProviderID = cboProviderID.Text
        Scho.GrantTemplateID = TemplateID

        Select Case UpdateScholarshipGrantTemplate(Scho)
            Case TranDBResult.Success
                MsgBox("Record successfully Updated", vbInformation, Application.ProductName)
                Close()
            Case TranDBResult.DuplicateCode
                CatchError("modScholarship", "UpdateScholarshipGrantTemplate", "Unable to Update entry duplicate Template code found..." & vbNewLine & "Please enter different Template Code")
                Exit Sub
            Case TranDBResult.DuplicateID
                CatchError("modScholarship", "UpdateScholarshipGrantTemplate", "Unable to Update entry duplicate Template ID found..." & vbNewLine & "Please enter different Template ID")
                Exit Sub
        End Select
    End Sub

    Private Sub cboTerm_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboTerm.SelectedIndexChanged
        cboTermID.SelectedIndex = cboTerm.SelectedIndex
    End Sub

    Private Sub cboProvider_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboProvider.SelectedIndexChanged
        cboProviderID.SelectedIndex = cboProvider.SelectedIndex
    End Sub
End Class
