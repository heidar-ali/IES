Option Explicit On

Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class frmLogin
    Private m_isvalid As Boolean = False
    Private User As String = ""
    Private UserType As String = ""

    Public ReadOnly Property getUser() As String
        Get
            Return User
        End Get
    End Property

    Public ReadOnly Property getUserType() As String
        Get
            Return UserType
        End Get
    End Property


    Public ReadOnly Property isValid() As Boolean
        Get
            Return m_isvalid
        End Get
    End Property

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
            MessageBox.Show("Invalid Username or Password", "Controller", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            LoginUser(UsernameTextBox.Text, PasswordTextBox.Text)
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub


    Private Sub LoginUser(ByVal UName As String, ByVal UPass As String)
        Dim cmd As New MySqlCommand()
        Dim dr As MySqlDataReader

        cmd.CommandText = "SELECT * FROM tblUser WHERE UserName='" & UName & "' and Password ='" & UPass & "'"
        cmd.Connection = clsCon.con
        cmd.CommandType = CommandType.Text

        dr = cmd.ExecuteReader()
        dr.Read()
        If dr.HasRows Then
            m_isvalid = True
            User = dr("Fullname").ToString()
            CurrentUser.UserID = dr("UserName").ToString()
            CurrentUser.UserName = dr("Username").ToString()
            CurrentUser.FullName = dr("Fullname").ToString()
            CurrentUser.UserType = dr("UserType").ToString()
            UserType = dr("UserType").ToString()
            dr.Close()
            Close()
            Return
        Else
            dr.Close()
            MessageBox.Show("Username or Password is incorrect", "Registrar Module", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If clsCon.con.State = ConnectionState.Open Then
            clsCon.con.Close()
        End If
        clsCon.con.Open()
    End Sub
End Class
