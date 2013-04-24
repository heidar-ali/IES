Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Text

Public Class frmPrerequisite
    Dim vSub As tSubject
    Dim tmpCurriculumID As String
    Dim tmpCurSubjectID As String


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmPrerequisite_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub ShowForm(ByVal CurriculumSubjectID As String, ByVal CurriculumID As String, ByVal YearTermID As Integer)

        If GetSubjectByID(CurriculumSubjectID, vSub) = TranDBResult.Success Then
            lblSubject.Text = vSub.SubjectCode & "-" & vSub.Description
        End If

        FillRequisite(CurriculumID, CurriculumSubjectID)

        MarkPreCoRequisite(CurriculumID, CurriculumSubjectID)

        tmpCurriculumID = CurriculumID
        tmpCurSubjectID = CurriculumSubjectID

        Me.ShowDialog()
    End Sub


    Private Sub FillRequisite(ByVal CurriculumID As String, CurriculumSubjectID As String)
        Dim com As New MySqlCommand("SELECT fnYearTerm(YearTermID),fnSubjectCode(SubjectID),fnSubjectDesc(SubjectID),"","",SubjectID FROM tblCurriculumDetails WHERE CurriculumID='" & CurriculumID & "' ORDER BY YearTermID", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        dgPreq.Rows.Clear()
        While vRS.Read
            Dim n As Integer = dgPreq.Rows.Add()
            dgPreq.Rows(n).Cells(0).Value = vRS(0).ToString()
            dgPreq.Rows(n).Cells(1).Value = vRS(1).ToString()
            dgPreq.Rows(n).Cells(2).Value = vRS(2).ToString()
            dgPreq.Rows(n).Cells(3).Value = False
            dgPreq.Rows(n).Cells(4).Value = False
            dgPreq.Rows(n).Cells(5).Value = vRS("SubjectID").ToString()

            'dgPreq.FirstDisplayedScrollingColumnIndex = n
            dgPreq.CurrentCell = dgPreq.Rows(n).Cells(0)
            dgPreq.Rows(n).Selected = True
        End While
        vRS.Close()

        For row As Integer = 0 To dgPreq.Rows.Count - 1
            For col As Integer = 0 To dgPreq.Columns.Count - 1
                If dgPreq.Rows(row).Cells(col).Value IsNot Nothing AndAlso dgPreq.Rows(row).Cells(col).Value.Equals(CurriculumSubjectID) Then
                    dgPreq.Rows.RemoveAt(row) ' Remove the name of the subject to have a pre requisite/co requisite
                    Return
                End If
            Next
        Next
    End Sub

    Private Sub MarkPreCoRequisite(ByVal CurriculumID As String, ByVal CurriculumSubjectID As String)
        For row As Integer = 0 To dgPreq.Rows.Count - 1
            For col As Integer = 0 To dgPreq.Columns.Count - 1
                dgPreq.Rows(row).Cells(3).Value = SetPreRequisite(CurriculumID, CurriculumSubjectID, dgPreq.Rows(row).Cells(5).Value.ToString())
                dgPreq.Rows(row).Cells(4).Value = SetCoRequisite(CurriculumID, CurriculumSubjectID, dgPreq.Rows(row).Cells(5).Value.ToString())
            Next
        Next
    End Sub

    Private Function SetPreRequisite(Optional ByVal CurriculumID As String = "", _
                                     Optional ByVal CurSubjectID As String = "", _
                                     Optional ByVal SubjectID As String = "") As Boolean

        Dim com As New MySqlCommand("SELECT * FROM tblPrerequisite WHERE CurriculumID='" & CurriculumID & _
                                    "' AND Curriculum_SubjectID='" & CurSubjectID & "' AND SubjectID ='" & SubjectID & _
                                    "' AND Remarks='Pre-Requisite'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            SetPreRequisite = True
        Else
            SetPreRequisite = False
        End If
        vRS.Close()
    End Function

    Private Function SetCoRequisite(Optional ByVal CurriculumID As String = "", _
                                     Optional ByVal CurSubjectID As String = "", _
                                     Optional ByVal SubjectID As String = "") As Boolean

        Dim com As New MySqlCommand("SELECT * FROM tblPrerequisite WHERE CurriculumID='" & CurriculumID & _
                                    "' AND Curriculum_SubjectID='" & CurSubjectID & "' AND SubjectID ='" & SubjectID & _
                                    "' AND Remarks='Co-Requisite'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            SetCoRequisite = True
        Else
            SetCoRequisite = False
        End If
        vRS.Close()
    End Function


    Private Sub dgPreq_CellPainting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dgPreq.CellPainting

        If e.ColumnIndex = 0 AndAlso e.RowIndex <> -1 Then
            Using gridBrush As Brush = New SolidBrush(Me.dgPreq.GridColor), backColorBrush As Brush = New SolidBrush(e.CellStyle.BackColor)
                Using gridLinePen As Pen = New Pen(gridBrush)
                    e.Graphics.FillRectangle(backColorBrush, e.CellBounds)

                    If e.RowIndex < dgPreq.Rows.Count - 1 AndAlso dgPreq.Rows(e.RowIndex + 1).Cells(e.ColumnIndex).Value.ToString() <> e.Value.ToString() Then
                        e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right - 1, e.CellBounds.Bottom - 1)
                    End If

                    e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom)

                    If Not e.Value Is Nothing Then
                        Dim previos As Integer = 0
                        Dim siguientes As Integer = 0
                        For i As Integer = e.RowIndex - 1 To 0 Step -1
                            If dgPreq.Item(e.ColumnIndex, i).Value <> e.Value Or i = 0 Then
                                previos = e.RowIndex - i - 1
                                Exit For
                            End If
                        Next
                        For i As Integer = e.RowIndex + 1 To dgPreq.Rows.Count - 1
                            If dgPreq.Item(e.ColumnIndex, i).Value <> e.Value Or dgPreq.Rows.Count - 1 = i Then
                                siguientes = i - e.RowIndex - 1
                                Exit For
                            End If
                        Next

                        If siguientes = previos Or siguientes - 1 = previos Then
                            e.Graphics.DrawString(CType(e.Value, String), e.CellStyle.Font, Brushes.Black, e.CellBounds.X + 2, e.CellBounds.Y + 3, StringFormat.GenericDefault)
                        End If
                        'End If
                    End If
                    e.Handled = True

                End Using
            End Using
        End If

        dgPreq.Columns(0).DefaultCellStyle.WrapMode = DataGridViewTriState.True
    End Sub


    Private Sub dgPreq_CurrentCellDirtyStateChanged(sender As System.Object, e As System.EventArgs) Handles dgPreq.CurrentCellDirtyStateChanged
        If dgPreq.IsCurrentCellDirty Then
            dgPreq.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub dgPreq_CellValueChanged(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgPreq.CellValueChanged
        On Error Resume Next

        Dim Pre As tPrerequisite


        If dgPreq.Columns(e.ColumnIndex).Name = "Pre" Then

            Pre.CurriculumID = tmpCurriculumID
            Pre.CurriculumID_SubjectID = tmpCurSubjectID
            Pre.Remarks = "Pre-Requisite"
            Pre.SubjectID = dgPreq.Rows(dgPreq.CurrentRow.Index).Cells(5).Value.ToString

            If CBool(dgPreq.Rows(dgPreq.CurrentRow.Index).Cells(3).Value) = True Then
                Select Case SavePreRequisite(Pre)
                    Case TranDBResult.Success
                        'FillRequisite(tmpCurriculumID, tmpCurSubjectID)

                    Case TranDBResult.DuplicateID
                        MsgBox("Subject already set as its PRE-REQUISITE", vbExclamation) : Exit Sub

                    Case TranDBResult.DuplicateCode
                        MsgBox("Subject already set as its CO-REQUISITE", vbExclamation) : Exit Sub
                End Select
            Else
                If DeletePreRequisite(Pre) = TranDBResult.Success Then
                    'FillRequisite(tmpCurriculumID, tmpCurSubjectID)
                End If
            End If
        End If


        If dgPreq.Columns(e.ColumnIndex).Name = "Co" Then

            Pre.CurriculumID = tmpCurriculumID
            Pre.CurriculumID_SubjectID = tmpCurSubjectID
            Pre.Remarks = "Co-Requisite"

            Pre.SubjectID = dgPreq.Rows(dgPreq.CurrentRow.Index).Cells(5).Value.ToString

            If dgPreq.Rows(dgPreq.CurrentRow.Index).Cells(3).Value = True Then
                Select Case SavePreRequisite(Pre)
                    Case TranDBResult.Success
                        'FillRequisite(tmpCurriculumID, tmpCurSubjectID)

                    Case TranDBResult.DuplicateID
                        MsgBox("Subject already set as its PRE-REQUISITE", vbExclamation) : Exit Sub

                    Case TranDBResult.DuplicateCode
                        MsgBox("Subject already set as its CO-REQUISITE", vbExclamation) : Exit Sub
                End Select
            Else
                If DeletePreRequisite(Pre) = TranDBResult.Success Then
                    'FillRequisite(tmpCurriculumID, tmpCurSubjectID)
                End If
            End If
        End If

        dgPreq.Invalidate()

        'err:
        '        MsgBox(Err.Description, vbExclamation)
        '        Exit Sub
    End Sub
End Class
