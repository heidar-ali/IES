Option Explicit On

Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class frmBrowse

    Public sCommand As String
    Private m_isvalid As Boolean = False
    Private Value As String

    Public Function ShowForm() As String
        Value = ""

        Me.ShowDialog()

        ShowForm = Value
    End Function


    Private Sub frmBrowse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cboCriteria.SelectedIndex = cboCriteria.Items.IndexOf("Last name")
    End Sub

    Private Sub ShowFNAME(ByVal FName As String)
        Dim com As New MySqlCommand("SELECT CONCAT(UCASE(LastName),', ',FirstName,' ',MiddleName) as Fullname,StudentNo,Gender FROM tblStudent WHERE FirstName LIKE '%" & FName & "%'", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        lvSearch.Items.Clear()
        If vRS.HasRows = True Then
            While vRS.Read()
                Dim lv As New ListViewItem(vRS("Fullname").ToString())
                lv.SubItems.Add(vRS("StudentNo").ToString())
                lv.SubItems.Add(vRS("Gender").ToString())
                lvSearch.Items.AddRange(New ListViewItem() {lv})
            End While
        Else
            MsgBox("Sorry no record found containing " & FName & "'", vbExclamation + vbOKOnly)
            Exit Sub
        End If
        vRS.Close()
    End Sub

    Private Sub ShowLNAME(ByVal FName As String)
        Dim com As New MySqlCommand("SELECT CONCAT(UCASE(LastName),', ',FirstName,' ',MiddleName) as Fullname,StudentNo,Gender FROM tblStudent WHERE LastName LIKE '%" & FName & "%'", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        lvSearch.Items.Clear()
        If vRS.HasRows = True Then
            While vRS.Read()
                Dim lv As New ListViewItem(vRS("Fullname").ToString())
                lv.SubItems.Add(vRS("StudentNo").ToString())
                lv.SubItems.Add(vRS("Gender").ToString())
                lvSearch.Items.AddRange(New ListViewItem() {lv})
            End While
        Else
            MsgBox("Sorry no record found containing " & FName & "'", vbExclamation + vbOKOnly)
        End If
        vRS.Close()
    End Sub

    Private Sub ShowID(ByVal FName As String)
        Dim com As New MySqlCommand("SELECT CONCAT(UCASE(LastName),', ',FirstName,' ',MiddleName) as Fullname,StudentNo,Gender FROM tblStudent WHERE StudentID = '" & FName & "'", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        lvSearch.Items.Clear()
        If vRS.HasRows = True Then
            While vRS.Read()
                Dim lv As New ListViewItem(vRS("Fullname").ToString())
                lv.SubItems.Add(vRS("StudentNo").ToString())
                lv.SubItems.Add(vRS("Gender").ToString())
                lvSearch.Items.AddRange(New ListViewItem() {lv})
            End While
        Else
            MsgBox("Sorry no record found containing " & FName & "'", vbExclamation + vbOKOnly)
        End If
        vRS.Close()
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        If txtSearch.Text = "" Then
            MsgBox("Fill up the required fill when searching", vbExclamation + vbOKOnly)
            Exit Sub
        End If

        Select Case cboCriteria.Text
            Case "Last name"
                ShowLNAME(txtSearch.Text)
            Case "First name"
                ShowFNAME(txtSearch.Text)
            Case "ID number"
                ShowID(txtSearch.Text)
        End Select
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdSearch_Click(Me, New System.EventArgs)
        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click, lvSearch.DoubleClick
        If lvSearch.Items.Count > 0 Then
            GetValue()
        End If
    End Sub

    Private Sub GetValue()
        Value = lvSearch.FocusedItem.SubItems(1).Text
        Close()
    End Sub
    Private Sub CancelGetValue()
        Value = ""
    End Sub

    Private Sub UpdateStudentStatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateStudentStatusToolStripMenuItem.Click
        'frmStudentRecord.ShowForm(lvSearch.FocusedItem.SubItems(1).Text)
    End Sub

    Private Sub frmBrowse_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub
End Class