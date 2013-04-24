Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports System.Drawing.Drawing2D

Public Class frmReplaceSubject
    Inherits Form

    Dim SubjectIDSource As String
    Dim SubjectIDReplace As String

    Public Sub New()
        InitializeComponent()
    End Sub


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub

    Public Sub ShowForm()

        Me.ShowDialog()
    End Sub
End Class
