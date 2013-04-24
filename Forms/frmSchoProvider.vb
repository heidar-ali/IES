Imports System.Windows.Forms

Public Class frmSchoProvider
    Dim State As FormState
    Dim Scho As ScholarshipProviders

    Dim ProviderID As Integer
    Dim ProvGroupID As Integer

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmSchoProvider_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub ShowForm()
        State = FormState.addFormState

        fillCombo(cboGroup, "SELECT ProvGroupDesc FROM tblSchoProvider_Groups")
        fillCombo(cboGroupID, "SELECT ProvGroupID FROM tblSchoProvider_Groups")

        RefreshToolStripButton_Click(Me, New System.EventArgs)

        Me.ShowDialog()
    End Sub

    Private Sub SaveData()
        If Not CheckTextBox(txtCode, "Please enter Scholarship Provider Code") Then HLTxt(txtCode) : Exit Sub
        If Not CheckTextBox(txtProvider, "Please enter Scholarship Provider Name") Then HLTxt(txtProvider) : Exit Sub
        If Not CheckTextBox(txtShortName, "Please enter Scholarship Provider Shortname") Then HLTxt(txtShortName) : Exit Sub


        Scho.ProvCode = txtCode.Text
        Scho.ProvAcronym = txtAcronym.Text
        Scho.ProvName = txtProvider.Text
        Scho.ProvShort = txtShortName.Text

        If cboGroupID.Text = "" Then
            Scho.ProvGroupID = 0
        Else
            Scho.ProvGroupID = cboGroupID.Text
        End If

        Scho.InActive = BooleanToInt(chkInActive.Checked)
        Scho.Remarks = txtRemarks.Text

        Scho.CreatedBy = CurrentUser.UserID
        Scho.DateCreated = DateTime.Now.Date

        Select Case SaveScholarshipProvider(Scho)
            Case TranDBResult.Success
                RefreshToolStripButton_Click(Me, New System.EventArgs)
                cmdNew_Click(Me, New System.EventArgs)

            Case TranDBResult.Failed
                CatchError("modScholarship", "SaveScholarshipProvider", "Unknown Error Occur while saving")
                Exit Sub

            Case TranDBResult.DuplicateID
                CatchError("modScholarship", "SaveScholarshipProvider", "Duplicate ScholarshipID")
                Exit Sub
        End Select

    End Sub

    Private Sub UpdateData()
        If Not CheckTextBox(txtCode, "Please enter Scholarship Provider Code") Then HLTxt(txtCode) : Exit Sub
        If Not CheckTextBox(txtProvider, "Please enter Scholarship Provider Name") Then HLTxt(txtProvider) : Exit Sub
        If Not CheckTextBox(txtShortName, "Please enter Scholarship Provider Shortname") Then HLTxt(txtShortName) : Exit Sub

        Scho.SchoProviderID = ProviderID

        Scho.ProvCode = txtCode.Text
        Scho.ProvAcronym = txtAcronym.Text
        Scho.ProvName = txtProvider.Text
        Scho.ProvShort = txtShortName.Text
        Scho.SchoProviderID = ProviderID

        If cboGroup.Text = "" Then
            Scho.ProvGroupID = 0
        Else
            Scho.ProvGroupID = cboGroupID.Text
        End If

        Scho.InActive = BooleanToInt(chkInActive.Checked)
        Scho.Remarks = txtRemarks.Text

        Scho.CreatedBy = CurrentUser.UserID
        Scho.DateCreated = DateTime.Now.Date

        Select Case UpdateScholarshipProvider(Scho)
            Case TranDBResult.Success
                RefreshToolStripButton_Click(Me, New System.EventArgs)
                cmdNew_Click(Me, New System.EventArgs)

            Case TranDBResult.Failed
                CatchError("modScholarship", "UpdateScholarshipProvider", "Unknown Error Occur while saving")
                Exit Sub

            Case TranDBResult.DuplicateID
                CatchError("modScholarship", "UpdateScholarshipProvider", "Duplicate ScholarshipID")
                Exit Sub
        End Select

    End Sub


    Private Sub cboGroup_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboGroup.SelectedIndexChanged
        cboGroupID.SelectedIndex = cboGroup.SelectedIndex
    End Sub

    Private Sub OK_Button_Click(sender As System.Object, e As System.EventArgs) Handles OK_Button.Click
        Select Case State
            Case FormState.addFormState
                SaveData()
            Case FormState.updateFormState
                UpdateData()
        End Select
    End Sub

    Private Sub lvProvider_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lvProvider.SelectedIndexChanged
        Dim Scho As ScholarshipProviders
        Dim Prov As ScholarshipProviderGroup

        If lvProvider.Items.Count > 0 Then

            If GetScholarshipProviderByID(lvProvider.FocusedItem.SubItems(6).Text, Scho) = TranDBResult.Success Then

                State = FormState.updateFormState

                txtAcronym.Text = Scho.ProvAcronym
                txtCode.Text = Scho.ProvCode
                txtProvider.Text = Scho.ProvName
                txtShortName.Text = Scho.ProvShort
                txtRemarks.Text = Scho.Remarks

                ProviderID = lvProvider.FocusedItem.SubItems(6).Text

                If GetSchoProviderGroupByGroupID(Scho.ProvGroupID, Prov) = TranDBResult.Success Then
                    cboGroup.Text = Prov.ProvGroupDesc
                    cboGroupID.Text = Prov.ProvGroupID
                End If

                chkAutoCredit.Checked = IntToBoolean(Scho.IsAutoCredit)
                chkInActive.Checked = IntToBoolean(Scho.InActive)
            End If

        End If
    End Sub

    Private Sub cmdNew_Click(sender As System.Object, e As System.EventArgs) Handles NewToolStripButton.Click
        txtAcronym.Text = ""
        txtCode.Text = ""
        txtProvider.Text = ""
        txtRemarks.Text = ""
        txtShortName.Text = ""
        cboGroup.Text = ""

        State = FormState.addFormState

    End Sub

    Private Sub RefreshToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles RefreshToolStripButton.Click
        FillListView("SELECT ProvCode,ProvName,ProvShort,ProvAcronym,fnScholarProviderGroupName(ProvGroupID),Remarks,SchoProviderID,ProvGroupID FROM tblSchoProviders", lvProvider, False)
        lblCount.Text = lvProvider.Items.Count
    End Sub

    Private Sub DeleteToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles DeleteToolStripButton.Click
        If lvProvider.Items.Count > 0 Then
            If ExecuteDeleteScholarshipProvider(lvProvider.FocusedItem.SubItems(6).Text) = TranDBResult.Success Then
                RefreshToolStripButton_Click(sender, e)
                cmdNew_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub PrintToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles PrintToolStripButton.Click

    End Sub
End Class
