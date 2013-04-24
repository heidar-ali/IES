Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class PickYearLevel
    Dim valid As Boolean = True
    Dim Year As String = ""
    Dim sYearLevel As String

    Public ReadOnly Property getYearLevel As String
        Get
            Return Year
        End Get
    End Property
    Public ReadOnly Property isValid As Boolean
        Get
            Return valid
        End Get
    End Property

    Public Function GetYearLevelTitle() As String

        If Not YearLevelRecordExist() Then
            MsgBox("There are no revords yeat in Year Level.", vbExclamation)
            Close()
            Exit Function
        End If

        FillList()

        Me.ShowDialog()


        'return
        Return sYearLevel
    End Function

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click, lvList.DoubleClick
        If lvList.Items.Count > 0 Then
            valid = True
            Year = lvList.FocusedItem.Text
            Close()
            Return
        Else
            valid = False
            Year = ""
            Close()
            Return
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub PickYearLevel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If clsCon.con.State = Data.ConnectionState.Open Then
            clsCon.con.Close()
        End If
        clsCon.con.Open()



    End Sub
    Private Sub FillList()
        Dim com As New MySqlCommand("SELECT tblYearLevel.YearLevelTitle as lvKey, tblYearLevel.YearLevelTitle FROM tblYearLevel;", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        lvList.Items.Clear()
        While vRS.Read()
            Dim lv As New ListViewItem(vRS("lvKey").ToString())
            lvList.Items.AddRange(New ListViewItem() {lv})
        End While
        vRS.Close()
    End Sub
End Class
