Option Explicit On

Imports MySql.Data.MySqlClient
Imports System.Data

Module modDBRoom
    Public Const KeyRoom As String = "room"

    Public Structure vRoom
        Dim RoomNo As Integer
        Dim Roomname As String
        Dim RoomID As String
        Dim BldgID As Integer
        Dim Capacity As Integer
        Dim RoomTypeID As Integer
        Dim Floor As Integer

        Dim IsAirConditioned As Short
        Dim IsUsable As Short
        Dim IsLANReady As Short
        Dim AllowNightClass As Short
        Dim IsShared As Short
    End Structure

    Public Structure vBuilding
        Dim BldgID As Integer
        Dim CampusID As Integer
        Dim BldgName As String
        Dim OtherName As String
        Dim Acronym As String
        Dim Floors As Integer

        Dim IsLAN As Short
        Dim HasElevator As Short
        Dim HasEscalator As Short
    End Structure

    Public Structure vRoomTypes
        Dim RoomTypeID As Integer
        Dim RoomType As String
    End Structure

    Public Function Quoted(ByVal str As String) As String
        Quoted = "'" & str & "'"
    End Function

    Public Function TimeorDate(ByVal str As String) As String
        TimeorDate = "#" & str & "#"
    End Function

    Public Function GetNewBuildingID(ByRef sNewBuildingID As String) As TranDBResult
        Dim sSQL As String
        Dim NewDNumber As Integer


        'default
        GetNewBuildingID = TranDBResult.Failed

        sSQL = "SELECT CONCAT(LEFT('0',2-Length(Count(*)+1)),'',Count(*)+1) AS NewID FROM tblBuilding;"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = False Then
            GetNewBuildingID = TranDBResult.Failed
            Exit Function
        Else
            sNewBuildingID = vRS("NewID").ToString()
        End If
        vRS.Close()

        While BuildingExistByID(sNewBuildingID) = TranDBResult.Success
            NewDNumber = CInt(Right(sNewBuildingID, 2)) + 1
            sNewBuildingID = StrDup(2 - Len(NewDNumber), "0") & NewDNumber
        End While

        GetNewBuildingID = TranDBResult.Success

    End Function
    Public Function GetNewRoomID(ByRef sNewRoomID As String) As TranDBResult
        Dim sSQL As String
        Dim NewDNumber As Integer


        'default
        GetNewRoomID = TranDBResult.Failed

        sSQL = "SELECT CONCAT('R','-',LEFT('000000',6-Length(Count(*)+1)),'',Count(*)+1) AS NewID FROM tblRoom;"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = False Then
            GetNewRoomID = TranDBResult.Failed
            Exit Function
        Else
            sNewRoomID = vRS("NewID").ToString()
        End If
        vRS.Close()

        While BuildingExistByID(sNewRoomID) = TranDBResult.Success
            NewDNumber = CInt(Right(sNewRoomID, 2)) + 1
            sNewRoomID = StrDup(2 - Len(NewDNumber), "0") & NewDNumber
        End While

        GetNewRoomID = TranDBResult.Success

    End Function

    Public Function AddRoom(ByVal newRoom As vRoom) As TranDBResult
        Dim daRoom As New MySqlDataAdapter()
        Dim dsRoom As New DataSet()


        If RoomExistByID(newRoom.RoomID) = TranDBResult.Success Then
            AddRoom = TranDBResult.DuplicateID
            Exit Function
        End If


        If RoomExistByName(newRoom.Roomname) = TranDBResult.Success Then
            AddRoom = TranDBResult.DuplicateTitle
            Exit Function
        End If

        Dim com As New MySqlCommand("INSERT INTO tblRoom(RoomID,Room,Capacity) VALUES ('" & newRoom.RoomID & "','" & newRoom.Roomname & "','" & newRoom.Capacity & "')", clsCon.con)
        com.ExecuteNonQuery()

        AddRoom = TranDBResult.Success
    End Function

    Public Function AddBuilding(ByVal tBuilding As vBuilding) As TranDBResult

        If BuildingExistByName(tBuilding.BldgName) = TranDBResult.Success Then
            AddBuilding = TranDBResult.DuplicateFullName
            CatchError("modDBRoom", "AddBuilding", "Unable to save entry building name already exist in record")
            Exit Function
        End If

        If BuildingExistByOtherName(tBuilding.OtherName) = TranDBResult.Success Then
            AddBuilding = TranDBResult.DuplicateTitle
            CatchError("modDBRoom", "AddBuilding", "Unable to save entry building Alias name already exist in record")
            Exit Function
        End If

        If BuildingExistByAcronym(tBuilding.Acronym) = TranDBResult.Success Then
            AddBuilding = TranDBResult.DuplicateLoginName
            CatchError("modDBRoom", "AddBuilding", "Unable to save entry building Acronym already exist in record")
            Exit Function
        End If

        Dim com As New MySqlCommand("INSERT INTO tblBuilding(BldgID,CampusID,BldgName,BldgOtherName,Acronym,FloorsCount,IsLANReady) VALUES " & _
                                    "(@ID,@CampusID,@Name,@Alias,@Acronym,@Floors,@LAN)", clsCon.con)
        com.Parameters.Add("@ID", MySqlDbType.Int32).Value = tBuilding.BldgID
        com.Parameters.Add("@CampusID", MySqlDbType.Int32, 3).Value = tBuilding.CampusID
        com.Parameters.Add("@Name", MySqlDbType.VarChar, 150).Value = tBuilding.BldgName
        com.Parameters.Add("@Alias", MySqlDbType.VarChar, 45).Value = tBuilding.OtherName
        com.Parameters.Add("@Acronym", MySqlDbType.VarChar, 45).Value = tBuilding.Acronym
        com.Parameters.Add("@Floors", MySqlDbType.Int32, 3).Value = tBuilding.Floors
        com.Parameters.Add("@LAN", MySqlDbType.UInt16, 3).Value = tBuilding.IsLAN

        com.ExecuteNonQuery()
        com.Parameters.Clear()

        AddBuilding = TranDBResult.Success
    End Function
    Public Function EditRoom(ByVal newRoom As vRoom) As TranDBResult

        Dim oldRoom As vRoom
        Dim daRoom As New MySqlDataAdapter()
        Dim dsRoom As New DataSet()

        'get old Subject
        If GetRoomByID(newRoom.RoomID, oldRoom) = TranDBResult.Success Then

            If oldRoom.Roomname <> newRoom.Roomname Then
                'find duplicate title
                EditRoom = TranDBResult.Success
                GoTo ReleaseAndExit
            End If
        Else
            'department not found
            'exit function
            EditRoom = TranDBResult.InvalidID
            GoTo ReleaseAndExit
        End If


        'find record to edit

        Dim com As New MySqlCommand("UPDATE tblRoom Set Room='" & newRoom.Roomname & "', Capacity='" & newRoom.Capacity & "' WHERE (((tblroom.roomID)='" & newRoom.RoomID & "'));", clsCon.con)
        com.ExecuteNonQuery()

        EditRoom = TranDBResult.Success
ReleaseAndExit:
        'release
        Exit Function
    End Function

    Public Function BuildingExistByID(ByVal sBuilding As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * From tblBuilding WHERE (((tblBuilding.BldgID)='" & sBuilding & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            BuildingExistByID = TranDBResult.Success
        Else
            BuildingExistByID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function BuildingExistByName(ByVal sBuilding As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * From tblBuilding WHERE (((tblBuilding.BldgName)='" & sBuilding & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            BuildingExistByName = TranDBResult.Success
        Else
            BuildingExistByName = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function BuildingExistByAcronym(ByVal sBuilding As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * From tblBuilding WHERE (((tblBuilding.Acronym)='" & sBuilding & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            BuildingExistByAcronym = TranDBResult.Success
        Else
            BuildingExistByAcronym = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function BuildingExistByOtherName(ByVal sBuilding As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * From tblBuilding WHERE (((tblBuilding.BldgOtherName)='" & sBuilding & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            BuildingExistByOtherName = TranDBResult.Success
        Else
            BuildingExistByOtherName = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function RoomExistByName(ByVal sRoomname As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * From tblroom WHERE (((tblroom.room)='" & sRoomname & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            RoomExistByName = TranDBResult.Success
        Else
            RoomExistByName = TranDBResult.Failed
        End If

        vRS.Close()
    End Function
    Public Function RoomExistByID(ByVal sRoomID As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * From tblRoom WHERE (((tblRoom.RoomID)='" & sRoomID & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            RoomExistByID = TranDBResult.Success
        Else
            RoomExistByID = TranDBResult.Failed
        End If

        vRS.Close()
    End Function

    Public Function GetBuildingByID(ByVal BuildingID As Integer, ByRef tBuilding As vBuilding) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblBuilding WHERE tblBuilding.BldgID='" & BuildingID & "'", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        If vRS.HasRows = True Then
            tBuilding.BldgID = CInt(vRS("BldgID").ToString())
            tBuilding.BldgName = vRS("BldgName").ToString()
            tBuilding.CampusID = CInt(vRS("CampusID").ToString())
            tBuilding.Acronym = vRS("Acronym").ToString()
            tBuilding.Floors = CInt(vRS("FloorsCount").ToString())
            tBuilding.OtherName = vRS("BldgOtherName").ToString()
            tBuilding.IsLAN = CShort(vRS("IsLANReady").ToString())
            tBuilding.HasElevator = CShort(vRS("Elevator").ToString())
            tBuilding.HasEscalator = CShort(vRS("Escalator").ToString())

            GetBuildingByID = TranDBResult.Success
        Else
            GetBuildingByID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function
    Public Function GetBuildingByAcronym(ByVal BuildingID As String, ByRef tBuilding As vBuilding) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblBuilding WHERE tblBuilding.Acronym='" & BuildingID & "'", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            tBuilding.BldgID = CInt(vRS("BldgID").ToString())
            tBuilding.BldgName = vRS("BldgName").ToString()
            tBuilding.CampusID = CInt(vRS("CampusID").ToString())
            tBuilding.Acronym = vRS("Acronym").ToString()
            tBuilding.Floors = CInt(vRS("FloorsCount").ToString())
            tBuilding.OtherName = vRS("BldgOtherName").ToString()
            tBuilding.IsLAN = CShort(vRS("IsLANReady").ToString())
            'tBuilding.HasElevator = CShort(vRS("Elevator").ToString())
            'tBuilding.HasEscalator = CShort(vRS("Escalator").ToString())

            GetBuildingByAcronym = TranDBResult.Success
        Else
            GetBuildingByAcronym = TranDBResult.Failed
        End If
        vRS.Close()
    End Function
    Public Function GetRoomByID(ByVal sRoomID As String, ByRef tRoom As vRoom) As TranDBResult

        Dim com As New MySqlCommand("SELECT * From tblRoom WHERE (((tblRoom.RoomID)='" & sRoomID & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            tRoom.RoomID = (vRS("RoomID").ToString())
            tRoom.Roomname = (vRS("Room").ToString())
            tRoom.Capacity = Convert.ToInt32(vRS("Capacity").ToString())
            GetRoomByID = TranDBResult.Success
        Else
            GetRoomByID = TranDBResult.Failed
        End If

        vRS.Close()
    End Function

    Public Function DeleteRoom(ByVal sRoomID As String) As TranDBResult
        Dim com As New MySqlCommand("DELETE FROM tblRoom WHERE RoomID='" & sRoomID & "'", clsCon.con)
        com.ExecuteNonQuery()
        DeleteRoom = TranDBResult.Success
    End Function

    Public Function GetBuildingByRoomID(ByVal RoomID As String) As String
        Dim com As New MySqlCommand("SELECT fnBuildingName(BldgID) FROM tblRoom WHERE RoomID='" & RoomID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows = True Then
            GetBuildingByRoomID = vRS(0).ToString
        Else
            GetBuildingByRoomID = ""
        End If
        vRS.Close()
    End Function

    Public Function GetRoomNameByRoomID(ByVal RoomID As String) As String
        Dim com As New MySqlCommand("SELECT Room FROM tblRoom WHERE RoomID='" & RoomID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows = True Then
            GetRoomNameByRoomID = vRS(0).ToString
        Else
            GetRoomNameByRoomID = ""
        End If
        vRS.Close()
    End Function

End Module
