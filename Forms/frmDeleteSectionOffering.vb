Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frmDeleteSectionOffering

    Dim RecordDeleted As Boolean

    Dim curSectionOfferingID As String

    Public Function ShowForm(Optional ByVal sSectionOfferingID As String = "") As Boolean


        '-------------------------------------------------------
        'check user access
        '-------------------------------------------------------
        If UserAllowedTo(CurrentUser.UserName, sCanDeleteSectionOffering) = False Then
            MsgBox("Unable to continue Deleteing Section Offering entry." & vbNewLine & vbNewLine & _
                    "You are not permitted to do this. Please contact your administrator for more information.", vbExclamation)
            Exit Function
        End If
        '-------------------------------------------------------



        curSectionOfferingID = sSectionOfferingID

        Me.ShowDialog()

        ShowForm = RecordDeleted
    End Function
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Select Case DeleteSectionOffering(txtSectionOfferingID.Text)
            Case TranDBResult.Success
                MsgBox("Section record successfully deleted.", vbInformation)

                RecordDeleted = True
                Me.Close()
            Case Else
                MsgBox("Unable to delete Section Record!", vbExclamation)
        End Select
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sSectionOfferingID As String
        Dim frm As New PickSectionOffering()

        sSectionOfferingID = frm.GetSectionOfferingID(txtSectionOfferingID)

        If sSectionOfferingID <> "" Then
            txtSectionOfferingID.Text = sSectionOfferingID
        End If
    End Sub
    Private Sub ShowSectionOfferingDetail()

        Dim sSQL As String

        sSQL = "SELECT Count(tblEnrolment.EnrolmentID) AS CountOfEnrolmentID" & _
                " FROM tblSectionOffering LEFT JOIN tblEnrolment ON tblSectionOffering.SectionOfferingID = tblEnrolment.SectionOfferingID" & _
                " WHERE (((tblSectionOffering.SectionOfferingID)='" & txtSectionOfferingID.Text & "'));"

        If SectionOfferingExistByID(txtSectionOfferingID.Text) <> TranDBResult.Success Then
            lblDetail.Text = "Section not found!"
            cmdDelete.Enabled = False : lblAskMsg.Visible = False

            Exit Sub
        End If

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            If CInt(vRS("CountOfEnrolmentID").ToString()) < 1 Then

                lblDetail.Text = "Ready to delete this record."

                cmdDelete.Enabled = True : lblAskMsg.Visible = True
            Else

                lblDetail.Text = "This Section Offering Record cannot be deleted." & vbNewLine & _
                "Reason: This record contain " & (vRS("CountOfEnrolmentID").ToString()) & " Enrolment  entry/s."

                cmdDelete.Enabled = False : lblAskMsg.Visible = False
            End If
        Else
            lblDetail.Text = "Section Offering not found."

            'Section not found
            cmdDelete.Enabled = False : lblAskMsg.Visible = False
        End If
        vRS.Close()
    End Sub

    Private Sub txtSectionOfferingID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSectionOfferingID.TextChanged
        cmdDelete.Enabled = False : lblAskMsg.Visible = False

        ShowSectionOfferingDetail()
    End Sub
End Class
