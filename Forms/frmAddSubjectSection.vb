Imports System.Windows.Forms

Public Class frmAddSubjectSection

    Dim tmpSectionID As String
    Dim tmpTermID As Integer

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub frmAddSubjectSection_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub ShowForm(ByVal SectionID As String, ByVal TermID As Integer)

        tmpSectionID = SectionID
        tmpTermID = TermID

        FillListView("SELECT SubjectCode,SubjectID,SubjectTitle,Units,LabUnits,LecHrs,LabHrs FROM tblSubject", lvSubjects, False)

        Me.ShowDialog()
    End Sub

    Private Sub cmdFind_Click(sender As System.Object, e As System.EventArgs) Handles cmdFind.Click
        FillListView("SELECT SubjectCode,SubjectID,SubjectTitle,Units,LabUnits,LecHrs,LabHrs FROM tblSubject WHERE SubjectCode LIKE '%" & txtFind.Text & "%' OR SubjectTitle LIKE '%" & txtFind.Text & "%'", lvSubjects, False)
    End Sub
    Private Sub SaveData()
        Dim Offer As tSubjectOffering

        Offer.SubjectOfferingID = DateTime.Now.Year & "-" & tmpSectionID & "-" & lvSubjects.FocusedItem.SubItems(1).Text
        Offer.SubjectID = lvSubjects.FocusedItem.SubItems(1).Text
        Offer.SectionID = tmpSectionID
        Offer.TermID = tmpTermID
        Offer.CreatedBy = CurrentUser.FullName
        Offer.CreationDate = DateTime.Now.Date


        Select Case AddSubjectOffering(Offer)
            Case TranDBResult.Success
                MsgBox("Subject successfully added !!!", vbInformation)
            Case TranDBResult.Failed
                MsgBox("Adding Subject went failed !!!", vbExclamation)
                Exit Sub
        End Select

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        SaveData()
    End Sub

    Private Sub txtFind_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtFind.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdFind_Click(sender, e)
        End If
    End Sub
End Class