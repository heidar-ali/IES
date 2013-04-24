Option Explicit On

Imports MySql.Data.MySqlClient

Module modRSSubjectOffering
    Public Const KeySubjectOffering As String = "seof"

    Public Structure tSubjectOffering
        Dim SubjectOfferingID As String
        Dim SubjectID As String
        Dim SectionID As String
        Dim TermID As Integer

        Dim IsSpecialClass As Short
        Dim OverrideConflict As Short
        Dim IsDissolved As Short
        Dim Limit As Integer

        Dim SchedTimeStart As String
        Dim SchedTimeEnd As String
        Dim TeacherID As String
        Dim Days As String
        Dim RoomID As String
        Dim Event1 As String
        Dim Sched1 As String

        Dim SchedTimeStart2 As String
        Dim SchedTimeEnd2 As String
        Dim TeacherID2 As String
        Dim Days2 As String
        Dim RoomID2 As String
        Dim Event2 As String
        Dim Sched2 As String

        Dim SchedTimeStart3 As String
        Dim SchedTimeEnd3 As String
        Dim TeacherID3 As String
        Dim Days3 As String
        Dim RoomID3 As String
        Dim Event3 As String
        Dim Sched3 As String

        Dim SchedTimeStart4 As String
        Dim SchedTimeEnd4 As String
        Dim TeacherID4 As String
        Dim Days4 As String
        Dim RoomID4 As String
        Dim Event4 As String
        Dim Sched4 As String

        Dim SchedTimeStart5 As String
        Dim SchedTimeEnd5 As String
        Dim TeacherID5 As String
        Dim Days5 As String
        Dim RoomID5 As String
        Dim Event5 As String
        Dim Sched5 As String

        Dim PostedBy As String
        Dim DatePosted As Date
        Dim RoomPostedBy As String
        Dim RoomDatePosted As Date
        Dim FacultyPostedBy As String
        Dim FacultyDatePosted As Date

        Dim CreationDate As Date
        Dim CreatedBy As String
        Dim ModifiedDate As Date
        Dim ModifiedBy As String

    End Structure

    Public Enum SchedulePrint
        ClassSchedule = 0
        RoomSchedule = 1
        FacultySchedule = 2
    End Enum

    Public Function CheckSubjectOfferingSchedule(ByVal ScheduleID As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT Sched1,Sched2,Sched3,Sched4,Sched5 FROM tblClassSchedule WHERE SubjectOfferingID ='" & ScheduleID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            CheckSubjectOfferingSchedule = TranDBResult.Success
        Else
            CheckSubjectOfferingSchedule = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function AddSubjectOffering(ByVal vSubjectOffering As tSubjectOffering) As TranDBResult

        If SubjectOfferingExistByID(vSubjectOffering.SubjectOfferingID) = TranDBResult.Success Then
            AddSubjectOffering = TranDBResult.DuplicateID
            GoTo ReleaseAndExit
        End If

        Dim com As New MySqlCommand("INSERT INTO tblClassSchedule(SubjectOfferingID,SubjectID,SectionID,TermID,`Limit`,CreatedBy,CreationDate) VALUES " & _
        " ('" & vSubjectOffering.SubjectOfferingID & "','" & vSubjectOffering.SubjectID & "','" & vSubjectOffering.SectionID & "','" & vSubjectOffering.TermID & "','" & vSubjectOffering.Limit & "',@Date,'" & vSubjectOffering.CreatedBy & "')", clsCon.con)
        com.Parameters.Add("@Date", MySqlDbType.Date).Value = vSubjectOffering.CreationDate
        com.ExecuteNonQuery()
        com.Parameters.Clear()

        AddSubjectOffering = TranDBResult.Success

ReleaseAndExit:
        Exit Function
    End Function

    Public Function AddSchedule1(ByVal vSubjectOffering As tSubjectOffering) As TranDBResult
        If SubjectOfferingExistByID(vSubjectOffering.SubjectOfferingID) = TranDBResult.Success Then
            Dim com As New MySqlCommand("UPDATE tblClassSchedule SET SchedTimeStart='" & vSubjectOffering.SchedTimeStart & _
                                        "', SchedTimeEnd='" & vSubjectOffering.SchedTimeEnd & "',Days='" & vSubjectOffering.Days & _
                                        "', Sched1='" & vSubjectOffering.Sched1 & "',EventID1='" & vSubjectOffering.Event1 & _
                                        "', TeacherID='" & vSubjectOffering.TeacherID & "',RoomID='" & vSubjectOffering.RoomID & _
                                        "', OverRideConflict='" & vSubjectOffering.OverrideConflict & "',IsDissolved='" & vSubjectOffering.IsDissolved & "',IsSpecialClasses='" & vSubjectOffering.IsSpecialClass & _
                                        "' WHERE SubjectOfferingID='" & vSubjectOffering.SubjectOfferingID & "'", con)
            com.ExecuteNonQuery()
            AddSchedule1 = TranDBResult.Success
        End If
    End Function

    Public Function AddSchedule2(ByVal vSubjectOffering As tSubjectOffering) As TranDBResult
        If SubjectOfferingExistByID(vSubjectOffering.SubjectOfferingID) = TranDBResult.Success Then
            Dim com As New MySqlCommand("UPDATE tblClassSchedule SET SchedTimeStart2='" & vSubjectOffering.SchedTimeStart2 & _
                                        "', SchedTimeEnd2='" & vSubjectOffering.SchedTimeEnd2 & "',Days2='" & vSubjectOffering.Days2 & _
                                        "', Sched2='" & vSubjectOffering.Sched2 & "',EventID2='" & vSubjectOffering.Event2 & _
                                        "', TeacherID2='" & vSubjectOffering.TeacherID2 & "',RoomID2='" & vSubjectOffering.RoomID2 & _
                                        "', OverRideConflict='" & vSubjectOffering.OverrideConflict & "',IsDissolved='" & vSubjectOffering.IsDissolved & "',IsSpecialClasses='" & vSubjectOffering.IsSpecialClass & _
                                        "' WHERE SubjectOfferingID='" & vSubjectOffering.SubjectOfferingID & "'", con)
            com.ExecuteNonQuery()
            AddSchedule2 = TranDBResult.Success
        End If
    End Function

    Public Function AddSchedule3(ByVal vSubjectOffering As tSubjectOffering) As TranDBResult
        If SubjectOfferingExistByID(vSubjectOffering.SubjectOfferingID) = TranDBResult.Success Then
            Dim com As New MySqlCommand("UPDATE tblClassSchedule SET SchedTimeStart3='" & vSubjectOffering.SchedTimeStart3 & _
                                        "', SchedTimeEnd3='" & vSubjectOffering.SchedTimeEnd3 & "',Days3='" & vSubjectOffering.Days3 & _
                                        "', Sched3='" & vSubjectOffering.Sched3 & "',EventID3='" & vSubjectOffering.Event3 & _
                                        "', TeacherID3='" & vSubjectOffering.TeacherID3 & "',RoomID3='" & vSubjectOffering.RoomID3 & _
                                        "', OverRideConflict='" & vSubjectOffering.OverrideConflict & "',IsDissolved='" & vSubjectOffering.IsDissolved & "',IsSpecialClasses='" & vSubjectOffering.IsSpecialClass & _
                                        "' WHERE SubjectOfferingID='" & vSubjectOffering.SubjectOfferingID & "'", con)
            com.ExecuteNonQuery()
            AddSchedule3 = TranDBResult.Success
        End If
    End Function

    Public Function AddSchedule4(ByVal vSubjectOffering As tSubjectOffering) As TranDBResult
        If SubjectOfferingExistByID(vSubjectOffering.SubjectOfferingID) = TranDBResult.Success Then
            Dim com As New MySqlCommand("UPDATE tblClassSchedule SET SchedTimeStart4='" & vSubjectOffering.SchedTimeStart4 & _
                                        "', SchedTimeEnd4='" & vSubjectOffering.SchedTimeEnd4 & "',Days4='" & vSubjectOffering.Days4 & _
                                        "', Sched4='" & vSubjectOffering.Sched4 & "',EventID4='" & vSubjectOffering.Event4 & _
                                        "', TeacherID4='" & vSubjectOffering.TeacherID4 & "',RoomID4='" & vSubjectOffering.RoomID4 & _
                                        "', OverRideConflict='" & vSubjectOffering.OverrideConflict & "',IsDissolved='" & vSubjectOffering.IsDissolved & "',IsSpecialClasses='" & vSubjectOffering.IsSpecialClass & _
                                        "' WHERE SubjectOfferingID='" & vSubjectOffering.SubjectOfferingID & "'", con)
            com.ExecuteNonQuery()
            AddSchedule4 = TranDBResult.Success
        End If
    End Function

    Public Function AddSchedule5(ByVal vSubjectOffering As tSubjectOffering) As TranDBResult
        If SubjectOfferingExistByID(vSubjectOffering.SubjectOfferingID) = TranDBResult.Success Then
            Dim com As New MySqlCommand("UPDATE tblClassSchedule SET SchedTimeStart5='" & vSubjectOffering.SchedTimeStart5 & _
                                        "', SchedTimeEnd5='" & vSubjectOffering.SchedTimeEnd5 & "',Days5='" & vSubjectOffering.Days5 & _
                                        "', Sched5='" & vSubjectOffering.Sched5 & "',EventID5='" & vSubjectOffering.Event5 & _
                                        "', TeacherID5='" & vSubjectOffering.TeacherID5 & "',RoomID5='" & vSubjectOffering.RoomID5 & _
                                        "', OverRideConflict='" & vSubjectOffering.OverrideConflict & "',IsDissolved='" & vSubjectOffering.IsDissolved & "',IsSpecialClasses='" & vSubjectOffering.IsSpecialClass & _
                                        "' WHERE SubjectOfferingID='" & vSubjectOffering.SubjectOfferingID & "'", con)
            com.ExecuteNonQuery()
            AddSchedule5 = TranDBResult.Success
        End If
    End Function

    Public Function GetSubjectOfferingBySectionIDSubjectID(ByVal sSubjectID As String, ByVal sSectionID As String, ByRef sSubjectOfferingID As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT SubjectOfferingID FROM tblClassSchedule WHERE SubjectID='" & sSubjectID & "' AND SectionID='" & sSectionID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            sSubjectOfferingID = vRS("SubjectOfferingID").ToString()
            GetSubjectOfferingBySectionIDSubjectID = TranDBResult.Success
        Else
            GetSubjectOfferingBySectionIDSubjectID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function
   
    Public Function SubjectOfferingExistByID(ByVal sSubjectOfferingID As String) As TranDBResult
        Dim sSQL As String

        sSQL = "SELECT tblClassSchedule.SubjectOfferingID " & _
                " From tblClassSchedule" & _
                " WHERE (((tblClassSchedule.SubjectOfferingID)='" & sSubjectOfferingID & "'));"


        'default
        SubjectOfferingExistByID = TranDBResult.Failed

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            SubjectOfferingExistByID = TranDBResult.Success
        Else
            SubjectOfferingExistByID = TranDBResult.Failed
        End If

        vRS.Close()
    End Function

    Public Function DeleteTempSubjectOffering(ByVal sSubjectOfferingID As String) As TranDBResult

        Dim com As New MySqlCommand("Delete From tblTempSubjectOffering WHERE (((tblTempSubjectOffering.SubjectOfferingID)='" & sSubjectOfferingID & "'));", clsCon.con)
        com.ExecuteNonQuery()
        DeleteTempSubjectOffering = TranDBResult.Success

    End Function

    Public Function CheckEnrolledSubjectOffering(ByVal sSubjectOfferingID As String) As Integer
        Dim com As New MySqlCommand("SELECT Count(ScheduleID) AS RecCount FROM tblEnrolmentDetails WHERE ScheduleID = '" & sSubjectOfferingID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            CheckEnrolledSubjectOffering = vRS(0).ToString()
        Else
            CheckEnrolledSubjectOffering = 0
        End If
        vRS.Close()
    End Function

    Public Function GetSubjectOfferingSchedule(ByVal SubjectOfferingID As String, ByVal CurrentSched As Integer, ByRef sSched As String, ByRef SectionTitle As String, ByRef SubjectTitle As String)
        Dim com As New MySqlCommand("SELECT *,fnSectionName(SectionID) AS SectionTitle,fnSubjectDesc(SubjectID) AS SubjectTitle, fnSubjectCode(SubjectID) AS SubjectCode FROM tblClassSchedule WHERE SubjectOfferingID='" & SubjectOfferingID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        While vRS.Read
            If vRS.HasRows Then
                Select Case CurrentSched
                    Case 1
                        sSched = IIf(vRS("Sched1").ToString() <> "", vRS("Sched1").ToString(), "")
                        SectionTitle = vRS("SectionTitle").ToString()
                        SubjectTitle = "(" & vRS("SubjectCode").ToString() & ") " & vRS("SubjectTitle").ToString()
                        Exit Select
                    Case 2
                        sSched = IIf(vRS("Sched1").ToString() <> "", vRS("Sched1").ToString() & vbNewLine, "") & _
                                  IIf(vRS("Sched2").ToString() <> "", vRS("Sched2").ToString(), "")
                        SectionTitle = vRS("SectionTitle").ToString()
                        SubjectTitle = "(" & vRS("SubjectCode").ToString() & ") " & vRS("SubjectTitle").ToString()
                        Exit Select
                    Case 3
                        sSched = IIf(vRS("Sched1").ToString() <> "", vRS("Sched1").ToString() & vbNewLine, "") & _
                                   IIf(vRS("Sched2").ToString() <> "", vRS("Sched2").ToString() & vbNewLine, "") & _
                                       IIf(vRS("Sched3").ToString() <> "", vRS("Sched3").ToString(), "")

                        SectionTitle = vRS("SectionTitle").ToString()
                        SubjectTitle = "(" & vRS("SubjectCode").ToString() & ") " & vRS("SubjectTitle").ToString()
                        Exit Select
                    Case 4
                        sSched = IIf(vRS("Sched1").ToString() <> "", vRS("Sched1").ToString() & vbNewLine, "") & _
                                   IIf(vRS("Sched2").ToString() <> "", vRS("Sched2").ToString() & vbNewLine, "") & _
                                       IIf(vRS("Sched3").ToString() <> "", vRS("Sched3").ToString() & vbNewLine, "") & _
                                           IIf(vRS("Sched4").ToString() <> "", vRS("Sched4").ToString(), "")
                        SectionTitle = vRS("SectionTitle").ToString()
                        SubjectTitle = "(" & vRS("SubjectCode").ToString() & ") " & vRS("SubjectTitle").ToString()
                        Exit Select
                    Case 5
                        sSched = IIf(vRS("Sched1").ToString() <> "", vRS("Sched1").ToString() & vbNewLine, "") & _
                                   IIf(vRS("Sched2").ToString() <> "", vRS("Sched2").ToString() & vbNewLine, "") & _
                                       IIf(vRS("Sched3").ToString() <> "", vRS("Sched3").ToString() & vbNewLine, "") & _
                                           IIf(vRS("Sched4").ToString() <> "", vRS("Sched4").ToString() & vbNewLine, "") & _
                                               IIf(vRS("Sched5").ToString() <> "", vRS("Sched5").ToString(), "")
                        SectionTitle = vRS("SectionTitle").ToString()
                        SubjectTitle = "(" & vRS("SubjectCode").ToString() & ") " & vRS("SubjectTitle").ToString()
                        Exit Select
                End Select
            Else
                sSched = ""
                SectionTitle = ""
                SubjectTitle = ""
            End If
        End While
        vRS.Close()
    End Function

    Public Function GetNoOfTempEnrolledSubjects(ByVal EnrolmentID As String) As Integer
        Dim com As New MySqlCommand("SELECT COUNT(EnrollmentID) AS Result FROM tblEnrolmentDetails_Temp WHERE EnrollmentID='" & EnrolmentID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            GetNoOfTempEnrolledSubjects = vRS(0).ToString()
        Else
            GetNoOfTempEnrolledSubjects = 0
        End If
        vRS.Close()
    End Function

    Public Function CheckSubjectOfferingIfConflict(ByVal EnrolmentID As String, ByVal TermID As Integer, ByVal sDay As String, ByVal TimeStart As String, ByVal TimeEnd As String, ByVal CurrentSched As Integer, _
                                                   ByRef sSubjectCode As String, _
                                                   ByRef sSubjectTitle As String, _
                                                   ByRef sSectionName As String, _
                                                   ByRef sSched As String) As Boolean
        Dim com As New MySqlCommand("CALL GetSubjectRegistrationIfConflict('" & EnrolmentID & "','" & TermID & "','%" & sDay & "%','" & TimeStart & "','" & TimeEnd & "','" & CurrentSched & "')", con)
        Dim vrS As MySqlDataReader = com.ExecuteReader()
        While vrS.Read()
            If vrS.HasRows = True Then

                sSched = IIf(vrS("Sched1").ToString() <> "", vrS("Sched1").ToString() & vbNewLine, "") & _
                                 IIf(vrS("Sched2").ToString() <> "", vrS("Sched2").ToString() & vbNewLine, "") & _
                                     IIf(vrS("Sched3").ToString() <> "", vrS("Sched3").ToString() & vbNewLine, "") & _
                                         IIf(vrS("Sched4").ToString() <> "", vrS("Sched4").ToString() & vbNewLine, "") & _
                                             IIf(vrS("Sched5").ToString() <> "", vrS("Sched5").ToString(), "")

                sSubjectCode = vrS("SubjectCode").ToString()
                sSubjectTitle = vrS("SubjectTitle").ToString()
                sSectionName = vrS("SectionTitle").ToString()

                CheckSubjectOfferingIfConflict = True
                Exit While
            Else
                CheckSubjectOfferingIfConflict = False
            End If
        End While
        vrS.Close()
    End Function

    Public Sub GetSubjectOfferingInfo(ByVal OfferingID As String, ByVal sTermID As Integer, ByVal CurrentSched As Integer, _
                                           ByRef sDay As String, ByRef TimeStart As String, ByRef TimeEnd As String)

        Dim com As New MySqlCommand()

        Select Case CurrentSched
            Case 1
                com.CommandText = "SELECT  CS.SubjectOfferingID, CS.TermID,CS.Sched1,fnRoomName2(CS.RoomID) AS Room_1,CS.Days AS sDay,CS.SchedTimeStart AS TimeStart,CS.SchedTimeEnd AS TimeEnd " & _
                              "FROM tblClassSchedule AS CS WHERE (CS.SubjectOfferingID ='" & OfferingID & "') AND (CS.TermID='" & sTermID & "') AND Sched1 <> '';"
                Exit Select
            Case 2
                com.CommandText = "SELECT  CS.SubjectOfferingID, CS.TermID,CS.Sched1,fnRoomName2(CS.RoomID) AS Room_1,CS.Days AS sDay,CS.SchedTimeStart AS TimeStart ,CS.SchedTimeEnd AS TimeEnd " & _
                             "FROM tblClassSchedule AS CS WHERE (CS.SubjectOfferingID ='" & OfferingID & "') AND (CS.TermID='" & sTermID & "') AND Sched1 <> ''" & _
                                "UNION " & _
                                "SELECT  CS.SubjectOfferingID, CS.TermID,CS.Sched2, fnRoomName2(CS.RoomID2) AS Room_2, CS.Days2 AS sDay,CS.SchedTimeStart2 AS TimeStart,CS.SchedTimeEnd2 AS TimeEnd " & _
                             "FROM tblClassSchedule AS CS WHERE (CS.SubjectOfferingID ='" & OfferingID & "') AND (CS.TermID='" & sTermID & "') AND Sched2 <> '';"

                Exit Select
            Case 3
                com.CommandText = "SELECT  CS.SubjectOfferingID, CS.TermID,CS.Sched1,fnRoomName2(CS.RoomID) AS Room_1,CS.Days AS sDay,CS.SchedTimeStart AS TimeStart,CS.SchedTimeEnd AS TimeEnd " & _
                             "FROM tblClassSchedule AS CS WHERE (CS.SubjectOfferingID ='" & OfferingID & "') AND (CS.TermID='" & sTermID & "')  AND Sched1 <> ''" & _
                                "UNION " & _
                                "SELECT  CS.SubjectOfferingID, CS.TermID,CS.Sched2, fnRoomName2(CS.RoomID2) AS Room_2, CS.Days2 AS sDay,CS.SchedTimeStart2 AS TimeStart,CS.SchedTimeEnd2 AS TimeEnd " & _
                             "FROM tblClassSchedule AS CS WHERE (CS.SubjectOfferingID ='" & OfferingID & "') AND (CS.TermID='" & sTermID & "')  AND Sched2 <> ''" & _
                            "UNION" & _
                            "SELECT  CS.SubjectOfferingID, CS.TermID,CS.Sched3, fnRoomName2(CS.RoomID3) AS Room_3, CS.Days3 AS sDay,CS.SchedTimeStart3 AS TimeStart ,CS.SchedTimeEnd3 AS TimeEnd " & _
                             "FROM tblClassSchedule AS CS WHERE (CS.SubjectOfferingID ='" & OfferingID & "') AND (CS.TermID='" & sTermID & "') AND Sched3 <> '';"

                Exit Select
            Case 4
                com.CommandText = "SELECT  CS.SubjectOfferingID, CS.TermID,CS.Sched1,fnRoomName2(CS.RoomID) AS Room_1,CS.Days AS sDay,CS.SchedTimeStart AS TimeStart ,CS.SchedTimeEnd AS TimeEnd " & _
                             "FROM tblClassSchedule AS CS WHERE (CS.SubjectOfferingID ='" & OfferingID & "') AND (CS.TermID='" & sTermID & "')  AND Sched1 <> ''" & _
                            "UNION " & _
                            "SELECT  CS.SubjectOfferingID, CS.TermID,CS.Sched2, fnRoomName2(CS.RoomID2) AS Room_2, CS.Days2 AS sDay,CS.SchedTimeStart2 AS TimeStart,CS.SchedTimeEnd2 AS TimeEnd " & _
                             "FROM tblClassSchedule AS CS WHERE (CS.SubjectOfferingID ='" & OfferingID & "') AND (CS.TermID='" & sTermID & "')  AND Sched2 <> ''" & _
                            "UNION" & _
                            "SELECT  CS.SubjectOfferingID, CS.TermID,CS.Sched3, fnRoomName2(CS.RoomID3) AS Room_3, CS.Days3 AS sDay,CS.SchedTimeStart3 AS TimeStart,CS.SchedTimeEnd3 AS TimeEnd " & _
                             "FROM tblClassSchedule AS CS WHERE (CS.SubjectOfferingID ='" & OfferingID & "') AND (CS.TermID='" & sTermID & "')  AND Sched3 <> ''" & _
                            "UNION " & _
                            "SELECT  CS.SubjectOfferingID, CS.TermID,CS.Sched4, fnRoomName2(CS.RoomID4) AS Room_4, CS.Days4 AS sDay,CS.SchedTimeStart4 AS TimeStart ,CS.SchedTimeEnd4 AS TimeEnd " & _
                            "FROM tblClassSchedule AS CS WHERE (CS.SubjectOfferingID ='" & OfferingID & "') AND (CS.TermID='" & sTermID & "') AND Sched4 <> '';"

                Exit Select
            Case 5
                com.CommandText = "SELECT  CS.SubjectOfferingID, CS.TermID,CS.Sched1,fnRoomName2(CS.RoomID) AS Room_1,CS.Days AS sDay,CS.SchedTimeStart AS TimeStart,CS.SchedTimeEnd AS TimeEnd " & _
                             "FROM tblClassSchedule AS CS WHERE (CS.SubjectOfferingID ='" & OfferingID & "') AND (CS.TermID='" & sTermID & "') AND Sched1 <> ''" & _
                            "UNION " & _
                              "SELECT  CS.SubjectOfferingID, CS.TermID,CS.Sched2, fnRoomName2(CS.RoomID2) AS Room_2, CS.Days2 AS sDay,CS.SchedTimeStart2 AS TimeStart,CS.SchedTimeEnd2 AS TimeEnd " & _
                             "FROM tblClassSchedule AS CS WHERE (CS.SubjectOfferingID ='" & OfferingID & "') AND (CS.TermID='" & sTermID & "')  AND Sched2 <> ''" & _
                            "UNION" & _
                            "SELECT  CS.SubjectOfferingID, CS.TermID,CS.Sched3, fnRoomName2(CS.RoomID3) AS Room_3, CS.Days3 AS sDay,CS.SchedTimeStart3 AS TimeStart,CS.SchedTimeEnd3 AS TimeEnd " & _
                             "FROM tblClassSchedule AS CS WHERE (CS.SubjectOfferingID ='" & OfferingID & "') AND (CS.TermID='" & sTermID & "')  AND Sched3 <> ''" & _
                            "UNION " & _
                            "SELECT  CS.SubjectOfferingID, CS.TermID,CS.Sched4, fnRoomName2(CS.RoomID4) AS Room_4, CS.Days4 AS sDay,CS.SchedTimeStart4 AS TimeStart ,CS.SchedTimeEnd4 AS TimeEnd " & _
                            "FROM tblClassSchedule AS CS WHERE (CS.SubjectOfferingID ='" & OfferingID & "') AND (CS.TermID='" & sTermID & "')  AND Sched4 <> ''" & _
                            "UNION " & _
                            "SELECT  CS.SubjectOfferingID, CS.TermID,CS.Sched5, fnRoomName2(CS.RoomID5) AS Room_5, CS.Days5 AS sDay,CS.SchedTimeStart5 AS TimeStart ,CS.SchedTimeEnd5 AS TimeEnd " & _
                            "FROM tblClassSchedule AS CS WHERE (CS.SubjectOfferingID ='" & OfferingID & "') AND (CS.TermID='" & sTermID & "') AND Sched5 <> '';"

                Exit Select
        End Select

        com.Connection = con

        Dim vrs As MySqlDataReader = com.ExecuteReader
        While vrs.Read
            If vrs.HasRows Then
                sDay = vrs("sDay").ToString()
                TimeStart = vrs("TimeStart").ToString()
                TimeEnd = vrs("TimeEnd").ToString()
            End If
        End While
        vrs.Close()
    End Sub

    Public Function GetNoOfCurrentSchedule(ByVal SchedID As String, ByVal TermID As Integer) As Integer
        Dim com As New MySqlCommand("SELECT Sched1,Sched2,Sched3,Sched4,Sched5 FROM tblClassSchedule WHERE SubjectOfferingID='" & SchedID & "' AND TermID='" & TermID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows = True Then
            If (vRS("Sched5").ToString() <> "") And (vRS("Sched4").ToString() <> "") And (vRS("Sched3").ToString() <> "") And (vRS("Sched2").ToString() <> "") And (vRS("Sched1").ToString() <> "") Then
                GetNoOfCurrentSchedule = 5
            ElseIf (vRS("Sched4").ToString() <> "") And (vRS("Sched3").ToString() <> "") And (vRS("Sched2").ToString() <> "") And (vRS("Sched1").ToString() <> "") Then
                GetNoOfCurrentSchedule = 4
            ElseIf (vRS("Sched3").ToString() <> "") And (vRS("Sched2").ToString() <> "") And (vRS("Sched1").ToString() <> "") Then
                GetNoOfCurrentSchedule = 3
            ElseIf (vRS("Sched2").ToString() <> "") And (vRS("Sched1").ToString() <> "") Then
                GetNoOfCurrentSchedule = 2
            ElseIf (vRS("Sched1").ToString() <> "") Then
                GetNoOfCurrentSchedule = 1
            End If
        End If
        vRS.Close()
    End Function

End Module

