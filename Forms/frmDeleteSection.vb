Imports MySql.Data.MySqlClient

Public Class frmDeleteSection

    Dim RecordDeleted As Boolean

    Dim curSection As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sSection As String
        Dim frm As New PickSection()
        frm.GetSectionID(txtSection, , , , sSection)

        If sSection <> "" Then
            txtSection.Text = sSection
        End If

    End Sub
    Public Function ShowForm(Optional ByVal sSectionTitle As String = "") As Boolean


        '-------------------------------------------------------
        'check user access
        '-------------------------------------------------------
        If UserAllowedTo(CurrentUser.UserName, sCanDeleteSection) = False Then
            MsgBox("Unable to continue Deleteing Section entry." & vbNewLine & vbNewLine & _
                    "You are not permitted to do this. Please contact your administrator for more information.", vbExclamation)
            Exit Function
        End If
        '-------------------------------------------------------


        curSection = sSectionTitle

        Me.ShowDialog()

        ShowForm = RecordDeleted
    End Function

    Private Sub txtSection_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSection.TextChanged
        cmdDelete.Enabled = False : lblAskMsg.Visible = False
        ShowSectionDetail()
    End Sub
    Private Sub ShowSectionDetail()

        Dim sSQL As String

        sSQL = "SELECT Count(tblSectionOffering.SectionOfferingID) AS CountOfSectionOfferingID" & _
                " FROM tblYearLevel INNER JOIN (tblSection LEFT JOIN tblSectionOffering ON tblSection.SectionID = tblSectionOffering.SectionID) ON tblYearLevel.YearLevelID = tblSection.YearLevelID" & _
                " WHERE ((CONCAT(tblYearLevel.YearLevelTitle , ' - ' , tblSection.SectionTitle)='" & txtSection.Text & "'));"

        If SectionExistByFullTitle(txtSection.Text) <> TranDBResult.Success Then
            lblDetail.Text = "Section not found!"
            cmdDelete.Enabled = False : lblAskMsg.Visible = False

            Exit Sub
        End If

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            If CInt(vRS("CountOfSectionOfferingID").ToString()) < 1 Then

                lblDetail.Text = "Ready to delete this record."

                cmdDelete.Enabled = True : lblAskMsg.Visible = True
            Else

                lblDetail.Text = "This Section Record cannot be deleted." & vbNewLine & _
                "Reason: This record contain " & (vRS("CountOfSectionOfferingID").ToString()) & " Section Offering record/s."

                cmdDelete.Enabled = False : lblAskMsg.Visible = False
            End If
        Else
            lblDetail.Text = "Section not found."

            'Section not found
            cmdDelete.Enabled = False : lblAskMsg.Visible = False
        End If
        vRS.Close()
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click

        Dim vSection As tSection

        If GetSectionByFullTitle(txtSection.Text, vSection) = TranDBResult.Success Then
            If DeleteSection(vSection.SectionID) = TranDBResult.Success Then
                MsgBox("Section record successfully deleted.", vbInformation)

                RecordDeleted = True
                Close()
            Else
                MsgBox("Unable to delete Section Record!", vbExclamation)
            End If
        Else
            MsgBox("Section ID Not found.", vbCritical)
        End If

    End Sub
End Class