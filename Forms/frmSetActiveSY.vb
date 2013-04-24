Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms

Public Class frmSetActiveSY
    Inherits Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmSetActiveSY_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
      
    End Sub

    Private Sub cmdGetSchoolYear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetSchoolYear.Click
        Dim sSchoolYearTitle As String
        Dim frm As New PickSchoolYear()

        sSchoolYearTitle = frm.GetItem(txtSchoolYear)

        If sSchoolYearTitle <> "" Then
            txtSchoolYear.Text = sSchoolYearTitle
        End If
    End Sub
    Public Sub setSchoolYear()

        If SchoolYearRecordExisted() <> TranDBResult.Success Then
            MsgBox("There are no records yet in School Year.", vbInformation)
            Close()
            Exit Sub
        End If

        If Len(CurrentSchoolYear.SchoolYearTitle) > 0 Then
            txtSchoolYear.Text = CurrentSchoolYear.SchoolYearTitle
        End If

        Me.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub cmdSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSet.Click

        SaveActiveSchoolYear(txtSchoolYear.Text)
        CurrentSchoolYear.SchoolYearTitle = txtSchoolYear.Text
        Close()

        'If SchoolYearExistByTitle(txtSchoolYear.Text) = TranDBResult.Success Then
        'SaveActiveSchoolYear(txtSchoolYear.Text)
        'CurrentSchoolYear.SchoolYearTitle = txtSchoolYear.Text
        'Close()
        'Else
        'MsgBox("The selected School Year does not exist in record!" & vbNewLine & _
        '"Please enter valid School Year.", vbExclamation)
        'End If
    End Sub

    Private Sub txtSchoolYear_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Len(txtSchoolYear) < 1 Then
            cmdSet.Enabled = False
        Else
            cmdSet.Enabled = True
        End If
    End Sub
End Class
