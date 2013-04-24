Imports MySql.Data.MySqlClient

Public Class frmDeleteDepartment

    Dim RecordDeleted As Boolean

    Dim curDepartmentTitle As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sDepartment As String
        Dim frm As New PickDepartment()

        sDepartment = frm.GetItem(txtDepartmentTitle)

        If sDepartment <> "" Then
            txtDepartmentTitle.Text = sDepartment
        End If
    End Sub
    Public Function ShowForm(Optional sDepartmentTitle As String = "") As Boolean

        '-------------------------------------------------------
        'check user access
        '-------------------------------------------------------
        If UserAllowedTo(CurrentUser.UserName, sCanDeleteDepartment) = False Then
            MsgBox("Unable to continue deleting Department entry." & vbNewLine & vbNewLine & _
                    "You are not permitted to do this. Please contact your administrator for more information.", vbExclamation)
            Exit Function
        End If
        '-------------------------------------------------------

        curDepartmentTitle = sDepartmentTitle

        Me.ShowDialog()

        ShowForm = RecordDeleted
    End Function
    Private Sub txtSection_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDepartmentTitle.TextChanged
        cmdDelete.Enabled = False : lblAskMsg.Visible = False
        ShowDepartmentDetail()

    End Sub
    Private Sub ShowDepartmentDetail()

        Dim sSQL As String

        sSQL = "SELECT Count(tblSection.SectionID) AS CountOfSectionID" & _
                " FROM tblDepartment LEFT JOIN tblSection ON tblDepartment.DepartmentID = tblSection.DepartmentID" & _
                " WHERE (((tblDepartment.DepartmentTitle)='" & curDepartmentTitle & "'));"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()

        If vRS.HasRows = True Then
            If CInt(vRS("CountOfSectionID").ToString()) < 1 Then

                lblDetail.Text = "Ready to delete this record."

                cmdDelete.Enabled = True : lblAskMsg.Visible = True
            Else

                lblDetail.Text = "This Department Record cannot be deleted." & vbNewLine & _
                "Reason: This record contain " & (vRS("CountOfSectionID").ToString()) & " Section record/s."

                cmdDelete.Enabled = False : lblAskMsg.Visible = False
            End If
        Else
            lblDetail.Text = "Department not found."

            'Department not found
            cmdDelete.Enabled = False : lblAskMsg.Visible = False
        End If
        vRS.Close()
    End Sub


    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click

        Dim vDepartment As tDepartment

        If GetDepartmentByTitle(txtDepartmentTitle.Text, vDepartment) = TranDBResult.Success Then
            If DeleteDepartment(vDepartment.DepartmentID) = TranDBResult.Success Then
                MsgBox("Department record successfully deleted.", vbInformation)

                RecordDeleted = True
                Close()
            Else
                MsgBox("Unable to delete Department Record!", vbExclamation)
            End If
        End If

    End Sub
End Class