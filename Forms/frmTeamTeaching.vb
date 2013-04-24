Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frmTeamTeaching

    Dim tmpTermID As Integer
    Dim tmpOfferingID As String
    Dim tmpCampusID As Integer


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Public Sub ShowForm(ByVal TermID As Integer, SubjectOfferingID As String, ByVal CampusID As String)
        tmpTermID = TermID
        tmpOfferingID = SubjectOfferingID
        tmpCampusID = CampusID


        FillListView("SELECT fnEmployeeName(TeacherID),TeacherID FROM tblClassSchedule_TeamTeaching WHERE CampusID='" & CampusID & "' AND SubjectOfferingID ='" & SubjectOfferingID & "'", lvTeaching)

        Me.ShowDialog()
    End Sub

    Private Sub cmdAdd_Click(sender As System.Object, e As System.EventArgs) Handles cmdAdd.Click
        Dim tmpTeacherID As String = ""

        Dim frm As New PickTeacher()
        frm.GetTeacherID(tmpTeacherID)

        If SaveTeamTeaching(tmpTermID, tmpOfferingID, tmpCampusID, tmpTeacherID) = True Then
            FillListView("SELECT fnEmployeeName(TeacherID),TeacherID FROM tblClassSchedule_TeamTeaching WHERE CampusID='" & tmpCampusID & "' AND SubjectOfferingID ='" & tmpOfferingID & "'", lvTeaching)
        Else
            MsgBox("Saving team teaching went failed." & vbNewLine & vbNewLine & _
                "Unknown error occur...", vbExclamation)
            Exit Sub
        End If
    End Sub

    Private Function SaveTeamTeaching(ByVal TermID As Integer, SubjectOfferingID As String, _
                                      ByVal CampusID As Integer, ByVal TeacherID As String) As Boolean
        Try
            Dim com As New MySqlCommand("INSERT INTO tblClassSchedule_TeamTeaching(TermID,SubjectOffering,TeacherID,CampusID) VALUES " & _
                            "('" & TermID & "','" & SubjectOfferingID & "','" & CampusID & "','" & TeacherID & "')", con)

            com.ExecuteNonQuery()
            SaveTeamTeaching = True
        Catch ex As Exception
            SaveTeamTeaching = False
        End Try

    End Function

    Private Sub cmdRemove_Click(sender As System.Object, e As System.EventArgs) Handles cmdRemove.Click
        If lvTeaching.Items.Count > 0 Then
            If DeleteTeamTeaching() Then

                FillListView("SELECT fnEmployeeName(TeacherID),TeacherID FROM tblClassSchedule_TeamTeaching WHERE CampusID='" & tmpCampusID & "' AND SubjectOfferingID ='" & tmpOfferingID & "'", lvTeaching)

            End If
        End If
    End Sub

    Private Function DeleteTeamTeaching() As Boolean
        Try
            Dim com As New MySqlCommand("DELETE FROM tblClassSchedule_TeamTeaching WHERE TeacherID='" & lvTeaching.FocusedItem.SubItems(1).Text & "' AND SubjectOfferingID='" & tmpOfferingID & "'", con)
            com.ExecuteNonQuery()

            DeleteTeamTeaching = True
        Catch ex As Exception
            DeleteTeamTeaching = False
        End Try
    End Function

    Private Sub cmdCancel_Click(sender As System.Object, e As System.EventArgs) Handles cmdCancel.Click
        Close()
    End Sub
End Class
