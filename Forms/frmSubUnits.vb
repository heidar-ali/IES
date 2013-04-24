Imports System.Windows.Forms

Public Class frmSubUnits

    Dim Subs As tSubUnits
    Dim State As FormState

    Dim UnitID As String

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub RefreshToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles RefreshToolStripButton.Click
        FillListView("SELECT UnitCode,UnitName,ShortName,SubUnitID FROM tblAccountSubUnits", lvSubUnits, False)
    End Sub

    Private Sub frmSubUnits_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        FillListView("SELECT UnitCode,UnitName,ShortName,SubUnitID FROM tblAccountSubUnits", lvSubUnits, False)
    End Sub

    Public Sub ShowForm()
        State = FormState.addFormState
        RefreshToolStripButton_Click(Me, New System.EventArgs)
        Me.ShowDialog()
    End Sub

    Private Sub NewToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles NewToolStripButton.Click
        txtCode.Text = ""
        txtDescription.Text = ""
        txtShortName.Text = ""
        UnitID = ""

        State = FormState.addFormState

        RefreshToolStripButton_Click(sender, e)

    End Sub

    Private Sub lvSubUnits_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lvSubUnits.SelectedIndexChanged
        On Error Resume Next

        If lvSubUnits.Items.Count > 0 Then
            txtCode.Text = lvSubUnits.FocusedItem.Text
            txtDescription.Text = lvSubUnits.FocusedItem.SubItems(1).Text
            txtShortName.Text = lvSubUnits.FocusedItem.SubItems(2).Text

            UnitID = lvSubUnits.FocusedItem.SubItems(3).Text

            State = FormState.updateFormState
        End If
    End Sub

    Private Sub DeleteToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles DeleteToolStripButton.Click
        If lvSubUnits.Items.Count > 0 Then
            If ExecuteDeleteAccountSubUnits(lvSubUnits.FocusedItem.SubItems(3).Text) = TranDBResult.Success Then
                RefreshToolStripButton_Click(sender, e)
                NewToolStripButton_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub SaveToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles SaveToolStripButton.Click
        Select Case State
            Case FormState.addFormState
                SaveData()
            Case FormState.updateFormState
                UpdateData()
        End Select
    End Sub

    Private Sub SaveData()
        If Not CheckTextBox(txtCode, "Please enter Account Sub-Unit Code") Then HLTxt(txtCode) : Exit Sub
        If Not CheckTextBox(txtDescription, "Please enter Account Sub-Unit Description") Then HLTxt(txtDescription) : Exit Sub

        Subs.ShortName = txtShortName.Text
        Subs.UnitCode = txtCode.Text
        Subs.UnitName = txtDescription.Text

        Select Case SaveSubUnits(Subs)
            Case TranDBResult.Success
                RefreshToolStripButton_Click(Me, New System.EventArgs)
                NewToolStripButton_Click(Me, New System.EventArgs)

            Case TranDBResult.DuplicateCode
                CatchError("modAccounting", "SaveSubUnits", "There is an error while saving Account Sub Units - Duplicate Account Sub Unit")
                Exit Sub
            Case TranDBResult.Failed
                CatchError("modAccounting", "SaveSubUnits", "There is an error while saving Account Sub Units - Unknown Error")
                Exit Sub
        End Select
    End Sub
    Private Sub UpdateData()
        If Not CheckTextBox(txtCode, "Please enter Account Sub-Unit Code") Then HLTxt(txtCode) : Exit Sub
        If Not CheckTextBox(txtDescription, "Please enter Account Sub-Unit Description") Then HLTxt(txtDescription) : Exit Sub

        Subs.ShortName = txtShortName.Text
        Subs.UnitCode = txtCode.Text
        Subs.UnitName = txtDescription.Text
        Subs.IndexID = UnitID

        Select Case UpdateSubUnits(Subs)
            Case TranDBResult.Success
                RefreshToolStripButton_Click(Me, New System.EventArgs)
                NewToolStripButton_Click(Me, New System.EventArgs)

            Case TranDBResult.DuplicateCode
                CatchError("modAccounting", "UpdateSubUnits", "There is an error while saving Account Sub Units - Duplicate Account Sub Unit")
                Exit Sub
            Case TranDBResult.Failed
                CatchError("modAccounting", "UpdateSubUnits", "There is an error while saving Account Sub Units - Unknown Error")
                Exit Sub
        End Select

    End Sub
End Class
