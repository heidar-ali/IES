Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frmRoomAE
    Inherits Form
    Public mFormState As String
    Public myID As Integer
    Dim RecordAdded As Boolean
    Dim RecordEdited As Boolean
    Dim newRoom As vRoom
    Dim tBuilding As vBuilding

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button3.Click
        Me.Close()
    End Sub
    Public Function ShowForm(Optional ByVal sRoomTitle As String = "", Optional ByVal sYearLevelTitle As String = "", Optional ByVal sTeacherTitle As String = "") As Boolean

        'set defaults
        ShowForm = False
        RecordAdded = False

        'show form
        ShowDialog()

        'return
        ShowForm = RecordAdded
    End Function
    Public Function ShowEdit(Optional ByVal sRoomTitle As String = "", Optional ByVal sYearLevelTitle As String = "", Optional ByVal sTeacherTitle As String = "") As Boolean

        'set defaults
        ShowEdit = False
        RecordEdited = False

        If GetRoomByID(sRoomTitle, newRoom) = TranDBResult.Success Then

            'set text fields
            txtRoomNo.Text = newRoom.RoomID
            txtRoom.Text = newRoom.Roomname
            txtCapacity.Text = newRoom.Capacity

        End If

        cmdSave.Text = "Update"
        'show form
        ShowDialog()

        'return
        ShowEdit = RecordEdited
    End Function


    Private Sub frmRoomAE_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            If clsCon.con.State = ConnectionState.Open Then
                clsCon.con.Close()
            End If
            clsCon.con.Open()

            fillCombo(cboBuilding, "SELECT Acronym FROM tblBuilding ORDER BY BldgID")
            fillCombo(cboRoomType, "SELECT RoomType FROM tblRoomTypes ORDER BY RoomTypeID")
            fillCombo(cboRoomTypeID, "SELECT RoomTypeID FROM tblRoomTypes ORDER BY RoomTypeID")

        Catch exp As Exception
            MsgBox(exp.ToString(), vbExclamation)
        End Try
    End Sub
    Private Sub BuildingFloor(ByVal BldgID As String)
        Dim bldg As Integer
        Dim cmd As New MySqlCommand("SELECT FloorsCount,BldgID FROM tblBuilding WHERE tblBuilding.Acronym='" & BldgID & "'", clsCon.con)
        Dim vRS As MySqlDataReader = cmd.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            For bldg = 1 To CInt(vRS("FloorsCount").ToString())
                cboFloorLocation.Items.Clear()
                cboFloorLocation.Items.Add(bldg & " Floor")
            Next
        End If
        vRS.Close()
    End Sub
    Private Sub cmdSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdSave.Click
        Select Case cmdSave.Text
            Case "Update"
                UpdateData()
            Case Else
                SaveData()
        End Select

    End Sub
    Private Function SaveData() As Boolean

        'check id
        If Not CheckTextBox(txtRoomNo, "Please Enter Room ID") Then
            Exit Function
        End If

        'check title
        If Not CheckTextBox(txtRoom, "Please Enter Room name") Then
            Exit Function
        End If

        If Not CheckTextBox(txtCapacity, "Please Enter Room capacity") Then
            Exit Function
        End If


        Dim newRoom As vRoom
        'set rs field
        newRoom.RoomID = txtRoomID.Text
        newRoom.Roomname = txtRoom.Text
        newRoom.Capacity = CInt(txtCapacity.Text)
        newRoom.BldgID = cboBuilding.SelectedIndex
        newRoom.RoomNo = CInt(txtRoomNo.Text)
        newRoom.RoomTypeID = cboRoomTypeID.Text

        newRoom.IsLANReady = BooleanToInt(chkLAN.CheckState)
        newRoom.IsShared = BooleanToInt(chkShared.CheckState)
        newRoom.IsUsable = BooleanToInt(chkActive.CheckState)
        newRoom.IsAirConditioned = BooleanToInt(chkAirConditioned.CheckState)
        newRoom.AllowNightClass = BooleanToInt(chkNight.CheckState)
        'try

        Select Case AddRoom(newRoom)
            Case TranDBResult.Success
                MsgBox("Room Entry successfully added.", vbInformation)
                RecordAdded = True
                Close()

            Case TranDBResult.DuplicateID
                MsgBox("ID already existed.", vbExclamation)
                HLTxt(txtRoomNo)
                SaveData = False

            Case TranDBResult.DuplicateTitle
                MsgBox("Title already existed.", vbExclamation)
                HLTxt(txtRoom)
                SaveData = False

            Case Else
                'fatal
                'temp
                MsgBox("Unknown Error.", vbExclamation)
        End Select
    End Function

    Private Function UpdateData() As Boolean

        'check id
        If Not CheckTextBox(txtRoomNo, "Please Enter Room ID") Then
            Exit Function
        End If

        'check title
        If Not CheckTextBox(txtRoom, "Please Enter Room name") Then
            Exit Function
        End If

        If Not CheckTextBox(txtCapacity, "Please Enter Room capacity") Then
            Exit Function
        End If


        Dim newRoom As vRoom
        'set rs field
        newRoom.RoomID = txtRoomNo.Text
        newRoom.Roomname = txtRoom.Text
        newRoom.Capacity = CInt(txtCapacity.Text)
        'try

        Select Case EditRoom(newRoom)
            Case TranDBResult.Success
                MsgBox("Room Entry successfully added.", vbInformation)
                RecordAdded = True
                Close()

            Case TranDBResult.DuplicateID
                MsgBox("ID already existed.", vbExclamation)
                HLTxt(txtRoomNo)
                UpdateData = False

            Case TranDBResult.DuplicateTitle
                MsgBox("Title already existed.", vbExclamation)
                HLTxt(txtRoom)
                UpdateData = False

            Case Else
                'fatal
                'temp
                MsgBox("Unknown Error.", vbExclamation)
        End Select
    End Function

    Private Sub cboRoomType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRoomType.SelectedIndexChanged
        cboRoomTypeID.SelectedIndex = cboRoomType.SelectedIndex
    End Sub

    Private Sub cboBuilding_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBuilding.SelectedIndexChanged
        If GetBuildingByAcronym(cboBuilding.Text, tBuilding) = TranDBResult.Success Then
            BuildingFloor(tBuilding.Acronym)
        Else
            MsgBox("Error", vbExclamation)
        End If

    End Sub
End Class


