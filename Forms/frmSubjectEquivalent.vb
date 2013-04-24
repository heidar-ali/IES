Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frmSubjectEquivalent

    Dim tmpSubjectID, tmpSubjectCode, tmpSubjectDesc As String

    Dim sSubjectID, CurSubjectID As String

    Dim Pre As tPrerequisite

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim frm As New PickSubject()
        frm.GetSubjectTitle(tmpSubjectCode, tmpSubjectDesc, tmpSubjectID, tmpSubjectID)

        Pre.CurriculumID = ""
        Pre.CurriculumID_SubjectID = CurSubjectID
        Pre.SubjectID = tmpSubjectID
        Pre.Remarks = "Equivalence"

        If tmpSubjectID <> "" Then
            If MsgBox("Are you sure you want to ADD the selected Subject?" & vbNewLine & vbNewLine & tmpSubjectCode & " - " & tmpSubjectDesc, vbQuestion + vbYesNo, Application.ProductName) = vbYes Then

                Select Case SaveSubjectEquivalence(Pre)
                    Case TranDBResult.Success
                        ShowSubjectEquivalence(CurSubjectID)

                    Case TranDBResult.DuplicateID
                        MsgBox("Subject already set as its EQUIVALENCE", vbExclamation) : Exit Sub

                End Select
            End If
        Else
            Exit Sub
        End If
    End Sub

    Private Sub frmSubjectEquivalent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub ShowForm(ByVal mSubjectID As String)
        Dim subs As tSubject

        If GetSubjectByID(mSubjectID, subs) = TranDBResult.Success Then
            lblSubject.Text = subs.SubjectCode & " - " & subs.Description

            CurSubjectID = subs.SubjectID

        Else
            MsgBox("Unable to show Subject Equivalent form..." & vbNewLine & "Subject may not be exist in the records", vbExclamation)
            Exit Sub
        End If

        ShowSubjectEquivalence(CurSubjectID)

        Me.ShowDialog()
    End Sub

    Private Sub ShowSubjectEquivalence(ByVal CurSubjectID As String)
        Dim com As New MySqlCommand("SELECT fnSubjectCode(SubjectID),SubjectID,fnSubjectDesc(SubjectID),fnSubjectLectUnits(SubjectID),fnSubjectLabUnits(SubjectID),fnSubjectCreditUnits(SubjectID) FROM tblPrerequisite WHERE Remarks = 'Equivalence' AND Curriculum_SubjectID='" & CurSubjectID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        dgSubject.Rows.Clear()
        While vRS.Read
            Dim n As Integer = dgSubject.Rows.Add()
            dgSubject.Rows(n).Cells(0).Value = vRS(0).ToString()
            dgSubject.Rows(n).Cells(1).Value = vRS(1).ToString()
            dgSubject.Rows(n).Cells(2).Value = vRS(2).ToString()
            dgSubject.Rows(n).Cells(3).Value = vRS(3).ToString()
            dgSubject.Rows(n).Cells(4).Value = vRS(4).ToString()
            dgSubject.Rows(n).Cells(5).Value = vRS(5).ToString()

            dgSubject.FirstDisplayedScrollingRowIndex = n
            dgSubject.CurrentCell = dgSubject.Rows(n).Cells(0)
            dgSubject.Rows(n).Selected = True

        End While
        vRS.Close()

        lblCount.Text = "No. of Item(s): " & dgSubject.RowCount

    End Sub

    Private Sub cmdRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemove.Click
        If dgSubject.RowCount > 0 Then
            If dgSubject.SelectedRows.Count > 0 Then

                Pre.SubjectID = dgSubject.Rows(dgSubject.CurrentRow.Index).Cells(1).Value.ToString()
                Pre.CurriculumID_SubjectID = CurSubjectID
                Pre.Remarks = "Equivalence"

                If MsgBox("Are you sure you want to REMOVE the selected Subject?" & vbNewLine & vbNewLine & dgSubject.Rows(dgSubject.CurrentRow.Index).Cells(0).Value.ToString() & " - " & dgSubject.Rows(dgSubject.CurrentRow.Index).Cells(2).Value.ToString(), vbQuestion + vbYesNo, Application.ProductName) = vbYes Then

                    If DeleteSubjectEquivalence(Pre) = TranDBResult.Success Then
                        ShowSubjectEquivalence(CurSubjectID)
                    End If

                End If
            Else
                MessageBox.Show("Select subject to remove!")
            End If
        End If
    End Sub

    Private Sub cmdRemoveAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemoveAll.Click
        If dgSubject.RowCount > 0 Then

            If MsgBox("Are you sure you want to REMOVE all the Subject?", vbQuestion + vbYesNo, Application.ProductName) = vbYes Then

                For i As Integer = 0 To dgSubject.RowCount - 1

                    Pre.SubjectID = dgSubject.Rows(i).Cells(1).Value.ToString()
                    Pre.CurriculumID_SubjectID = CurSubjectID
                    Pre.Remarks = "Equivalence"

                    If DeleteSubjectEquivalence(Pre) = TranDBResult.Success Then
                        ShowSubjectEquivalence(CurSubjectID)
                    End If

                Next

            End If


        End If
    End Sub



End Class
