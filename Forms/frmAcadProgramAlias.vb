Imports System.Windows.Forms

Public Class frmAcadProgramAlias
    Dim valid As Boolean = False
    Dim tmpTeacherFullName As String = ""


    Public ReadOnly Property getAlias As String
        Get
            Return tmpTeacherFullName
        End Get
    End Property

    Public ReadOnly Property isValid As Boolean
        Get
            Return valid
        End Get
    End Property

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If txtAlias.Text <> "" Then
            tmpTeacherFullName = txtAlias.Text
            Close()
            Return
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
