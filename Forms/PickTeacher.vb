Imports System.Windows.Forms
Imports System.Data
Imports MySql.Data.MySqlClient

Public Class PickTeacher
    Dim valid As Boolean = False
    Dim tmpTeacherID As String = ""
    Dim tmpTeacherFullName As String = ""

    Public ReadOnly Property getID As String
        Get
            Return tmpTeacherID
        End Get
    End Property
    Public ReadOnly Property getTeacher As String
        Get
            Return tmpTeacherFullName
        End Get
    End Property

    Public ReadOnly Property isValid As Boolean
        Get
            Return valid
        End Get
    End Property

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click, lvList.DoubleClick
        If lvList.Items.Count > 0 Then
            tmpTeacherFullName = lvList.FocusedItem.Text
            tmpTeacherID = lvList.FocusedItem.SubItems(1).Text
            Close()
            Return
        Else
            tmpTeacherFullName = ""
            tmpTeacherID = ""
            Close()
            Return
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub PickTeacher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Public Function GetTeacherID(Optional ByRef sTeacherFullName As String = "") As String

        'set fail to default
        GetTeacherID = ""

        'add yr to list
        If Not FillList() Then
            MsgBox("There is no TEACHER entries to display.", vbExclamation)
            Close()
            Exit Function
        End If

        Me.ShowDialog()

        'return
        sTeacherFullName = tmpTeacherFullName
        GetTeacherID = tmpTeacherID
    End Function

    Private Function FillList() As Boolean
        Dim com As New MySqlCommand("SELECT tblTeacher.TeacherID AS lvKEY, CONCAT(tblTeacher.LastName, ', ' ,tblTeacher.FirstName ,' ', tblTeacher.MiddleName) AS `Full Name` FROM tblTeacher;", clsCon.con)
        Dim vrs As MySqlDataReader = com.ExecuteReader()
        While vrs.Read()
            If vrs.HasRows = True Then
                Dim lv As New ListViewItem(vrs("Full Name").ToString())
                lv.SubItems.Add(vrs("lvKEY").ToString())
                lvList.Items.AddRange(New ListViewItem() {lv})
                FillList = True
            Else
                FillList = False
            End If
        End While
        vrs.Close()
    End Function

End Class
