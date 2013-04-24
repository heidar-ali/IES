Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Windows.Forms

Public Class frmSYAE
    Inherits Form
    Dim RecordSaved As Boolean

    Public Sub New()
        InitializeComponent()
    End Sub


    Public Function ShowForm(Optional ByVal newSchoolYearTitleFrom As String = "") As Boolean

        '-------------------------------------------------------
        'check user access
        '-------------------------------------------------------
        '-------------------------------------------------------

        If newSchoolYearTitleFrom <> "" Then
            txtFrom.Text = newSchoolYearTitleFrom
        End If

        'show form
        Me.ShowDialog()

        ShowForm = RecordSaved
    End Function

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdSave.Click
        'check if filled
        If Len(txtSchoolYear.Text) < 1 Then
            'temp
            MsgBox("Fill 'From Year' Text Field First", vbInformation)
            Exit Sub
        End If

        'save
        Dim newSchoolYear As tSchoolYear

        'set object
        newSchoolYear.SchoolYearTitle = txtSchoolYear.Text

        Select Case AddSchoolYear(newSchoolYear)
            Case TranDBResult.Success

                'ADD success
                '------------------------------------------------------

                'temp
                MsgBox("School Year created.", vbInformation)

                'return true
                RecordSaved = True

                'close this form

                Close()

            Case TranDBResult.DuplicateTitle
                MsgBox("The Entry you have entered is already existed. Enter another entry.", vbExclamation)
                HLTxt(txtFrom)


            Case Else
                'temp
                MsgBox("Error: Creating School Year", vbCritical)
        End Select
    End Sub

    Private Sub txtFrom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFrom.TextChanged
        If Len(txtFrom) = 4 And Val(txtFrom) > 1000 Then
            'auto fill
            txtTo.Text = Val(txtFrom.Text) + 1
            txtSchoolYear.Text = txtFrom.Text & "-" & txtTo.Text
        Else
            txtTo.Text = ""
            txtSchoolYear.Text = ""
        End If
    End Sub

    Private Sub frmSYAE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If clsCon.con.State = ConnectionState.Open Then
            clsCon.con.Close()
        End If
        clsCon.con.Open()

    End Sub

    Private Sub TabPage4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage4.Click

    End Sub
End Class
