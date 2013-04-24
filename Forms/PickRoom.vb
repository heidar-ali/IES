Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class PickRoom

    Dim valid As Boolean = False
    Dim RoomID As String = ""
    Dim Room As String = ""

    Public ReadOnly Property getRoom As String
        Get
            Return Room
        End Get
    End Property
    Public ReadOnly Property isValid As Boolean
        Get
            Return valid
        End Get
    End Property

    Public ReadOnly Property getID As String
        Get
            Return RoomID
        End Get
    End Property
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click, ListView1.DoubleClick
        If ListView1.Items.Count > 0 Then
            valid = True
            Room = ListView1.FocusedItem.Text
            RoomID = ListView1.FocusedItem.SubItems(1).Text
            Me.Close()
            Return
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub LoadRooms()
        Dim com As New MySqlCommand("SELECT * FROM tblRoom", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        ListView1.Items.Clear()
        While vRS.Read()
            Dim lv As New ListViewItem(vRS("Room").ToString())
            lv.SubItems.Add(vRS("RoomID").ToString())
            ListView1.Items.AddRange(New ListViewItem() {lv})
        End While
        vRS.Close()
    End Sub

    Private Sub PickRoom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If clsCon.con.State = Data.ConnectionState.Open Then
            clsCon.con.Close()
        End If
        clsCon.con.Open()
        LoadRooms()
    End Sub
End Class
