Option Explicit On
Imports MySql.Data.MySqlClient
Imports System.Data

Module modDBTeacher


    Public Const KeyTeacher As String = "teac"
    Public Const KeyAdviser As String = "advr"

    Public Structure tTeacher
        Dim TeacherID As String
        Dim TeacherTitle As String
        Dim Password As String
        Dim FirstName As String
        Dim MiddleName As String
        Dim LastName As String
        Dim Address As String
        Dim Active As Boolean
        Dim ContactNumber As String
        Dim CreationDate As String
    End Structure

    Public Structure tAdviser
        Dim AdviserID As String
        Dim TeacherID As String
        Dim SectionID As String
        Dim DepartmentID As String
        Dim YearLevelID As String
        Dim SchoolYear As String
    End Structure

    
    Public Function AddTeacher(ByVal newTeacher As tTeacher) As TranDBResult

        Dim oldTeacher As tTeacher
        Dim dsTeacher As New DataSet()
        Dim daTeacher As New MySqlDataAdapter()


        'check duplicate id
        If TeacherExistByID(newTeacher.TeacherID) = TranDBResult.Success Then
            AddTeacher = TranDBResult.DuplicateID
            CatchError("modDBTeacher", "TeacherExistByID", "Duplicated ID found")
            GoTo ReleaseAndExit
        End If

        If TeacherExistByTitle(newTeacher.TeacherTitle) = TranDBResult.Success Then
            AddTeacher = TranDBResult.DuplicateTitle
            CatchError("modDBTeacher", "TeacherExistByTitle", "Duplicated Teacher Title found")
            GoTo ReleaseAndExit
        End If


        'check each field
        If Len(Trim(newTeacher.TeacherID)) < 1 Then
            AddTeacher = TranDBResult.InvalidID
            CatchError("modDBTeacher", "Len(Trim(newTeacher.TeacherID)) < 1", "TranDBResult.InvalidID")
            GoTo ReleaseAndExit
        End If

        If Len(Trim(newTeacher.TeacherTitle)) < 1 Then
            AddTeacher = TranDBResult.InvalidTitle
            CatchError("modDBTeacher", "Len(Trim(newTeacher.TeacherTitle)) < 1", "TranDBResult.InvalidTitle")
            GoTo ReleaseAndExit
        End If


        If Len(Trim(newTeacher.Password)) < 1 Then
            AddTeacher = TranDBResult.InvalidTeacherPassword
            CatchError("modDBTeacher", "Len(Trim(newTeacher.Password)) < 1", "TranDBResult.InvalidTeacherPassword")
            GoTo ReleaseAndExit
        End If
        If Len(Trim(newTeacher.FirstName)) < 1 Then
            AddTeacher = TranDBResult.InvalidTeacherFirstName
            CatchError("modDBTeacher", "Len(Trim(newTeacher.FirstName)) < 1", "TranDBResult.InvalidTeacherFirstName")
            GoTo ReleaseAndExit
        End If
        If Len(Trim(newTeacher.MiddleName)) < 1 Then
            AddTeacher = TranDBResult.InvalidTeacherMiddleName
            CatchError("modDBTeacher", "Len(Trim(newTeacher.MiddleName)) < 1 ", "TranDBResult.InvalidTeacherMiddleName")
            GoTo ReleaseAndExit
        End If
        If Len(Trim(newTeacher.LastName)) < 1 Then
            AddTeacher = TranDBResult.InvalidTeacherLastName
            CatchError("modDBTeacher", "LLen(Trim(newTeacher.LastName)) < 1", "TranDBResult.InvalidTeacherLastName")
            GoTo ReleaseAndExit
        End If
        If Len(Trim(newTeacher.Address)) < 1 Then
            AddTeacher = TranDBResult.InvalidTeacherAddress
            CatchError("modDBTeacher", "Len(Trim(newTeacher.Address)) < 1", "TranDBResult.InvalidTeacherAddress")
            GoTo ReleaseAndExit
        End If

        Dim com As New MySqlCommand("INSERT INTO tblTeacher(TeacherID,TeacherTitle,Password,FirstName,MiddleName,LastName,Address,ContactNumber,Active) VALUES" & _
                                    " ('" & newTeacher.TeacherID & "','" & newTeacher.TeacherTitle & "','" & newTeacher.Password & "','" & newTeacher.FirstName & "','" & newTeacher.MiddleName & "','" & newTeacher.LastName & "','" & newTeacher.Address & "','" & newTeacher.ContactNumber & "','" & newTeacher.Active & "')", clsCon.con)
        com.ExecuteNonQuery()

        AddTeacher = TranDBResult.Success

ReleaseAndExit:
        'AddTeacher = TranDBResult.Failed
            Exit Function
    End Function

    Public Function EditTeacher(ByVal newTeacher As tTeacher) As TranDBResult
        Dim oldTeacher As tTeacher
        Dim dsTeacher As New DataSet()
        Dim daTeacher As New MySqlDataAdapter()

        If GetTeacherByID(newTeacher.TeacherID, oldTeacher) = TranDBResult.Success Then

            If Trim(LCase(newTeacher.TeacherTitle)) <> LCase(Trim(oldTeacher.TeacherTitle)) Then
                If TeacherExistByTitle(newTeacher.TeacherTitle) = TranDBResult.Success Then
                    'duplicate found
                    EditTeacher = TranDBResult.DuplicateTitle
                    GoTo ReleaseAndExit
                End If
            Else

            End If

            'check each field
            If Len(Trim(newTeacher.TeacherTitle)) < 1 Then
                EditTeacher = TranDBResult.InvalidTeacherTitle
                GoTo ReleaseAndExit
            End If
            If Len(Trim(newTeacher.Password)) < 1 Then
                EditTeacher = TranDBResult.InvalidTeacherPassword
                GoTo ReleaseAndExit
            End If
            If Len(Trim(newTeacher.FirstName)) < 1 Then
                EditTeacher = TranDBResult.InvalidTeacherFirstName
                GoTo ReleaseAndExit
            End If
            If Len(Trim(newTeacher.MiddleName)) < 1 Then
                EditTeacher = TranDBResult.InvalidTeacherMiddleName
                GoTo ReleaseAndExit
            End If
            If Len(Trim(newTeacher.LastName)) < 1 Then
                EditTeacher = TranDBResult.InvalidTeacherLastName
                GoTo ReleaseAndExit
            End If
            If Len(Trim(newTeacher.ContactNumber)) < 1 Then
                EditTeacher = TranDBResult.InvalidTeacherContactNumber
                GoTo ReleaseAndExit
            End If
            If Len(Trim(newTeacher.Address)) < 1 Then
                EditTeacher = TranDBResult.InvalidTeacherAddress
                GoTo ReleaseAndExit
            End If

            Dim com As New MySqlCommand("UPDATE tblTeacher SET TeacherTitle='" & newTeacher.TeacherTitle & _
                                        "',Password='" & newTeacher.Password & _
                                        "',FirstName='" & newTeacher.FirstName & _
                                        "',MiddleName='" & newTeacher.MiddleName & _
                                        "',LastName='" & newTeacher.LastName & _
                                        "',Address='" & newTeacher.Address & _
                                        "',ContactNumber='" & newTeacher.ContactNumber & _
                                        "',Active='" & newTeacher.Active & _
                                        "' WHERE tblTeacher.TeacherID='" & newTeacher.TeacherID & "'", clsCon.con)
            com.ExecuteNonQuery()

            EditTeacher = TranDBResult.Success
        Else
            EditTeacher = TranDBResult.Failed
        End If

ReleaseAndExit:
        Exit Function
    End Function

    Public Function ExecDeleteTeacher(ByVal sTeacherID As String) As TranDBResult

        If MsgBox("You are about to delete this Teacher with ID :" & vbNewLine & sTeacherID & vbNewLine & "Are you sure to DELETE this Teahcer Account?", vbQuestion + vbOKCancel) = vbOK Then

            If DeleteTeacher(sTeacherID) = TranDBResult.Success Then
                MsgBox("TEACHER entry successfully deleted.", vbInformation)
                ExecDeleteTeacher = TranDBResult.Success
            Else
                MsgBox("Unable to delete Teacher Account. The current was edited by another user", vbExclamation)
                ExecDeleteTeacher = TranDBResult.Failed
            End If
        Else
            ExecDeleteTeacher = TranDBResult.Failed
        End If

    End Function

    Public Function DeleteTeacher(ByVal sTeacherID As String) As TranDBResult

        Dim com As New MySqlCommand("DELETE FROM tblTeacher WHERE (((tblTeacher.TeacherID)='" & sTeacherID & "'));", clsCon.con)
        com.ExecuteNonQuery()
        DeleteTeacher = TranDBResult.Success

    End Function


    Public Function GetTeacherByTitle(ByVal sTeacherTitle As String, ByRef vTeacher As tTeacher) As TranDBResult

        Dim com As New MySqlCommand("SELECT * From tblTeacher WHERE (((tblTeacher.TeacherTitle)='" & sTeacherTitle & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            vTeacher.TeacherID = (vRS("teacherid").ToString())
            vTeacher.TeacherTitle = (vRS("TeacherTitle").ToString())
            vTeacher.Password = (vRS("Password").ToString())
            vTeacher.FirstName = (vRS("FirstName").ToString())
            vTeacher.MiddleName = (vRS("MiddleName").ToString())
            vTeacher.LastName = (vRS("LastName").ToString())
            vTeacher.Address = (vRS("Address").ToString())
            vTeacher.ContactNumber = (vRS("ContactNumber").ToString())
            vTeacher.Active = vRS("Active").ToString()
            vTeacher.CreationDate = Convert.ToDateTime(vRS("CreationDate").ToString())

            GetTeacherByTitle = TranDBResult.Success
        Else
            GetTeacherByTitle = TranDBResult.Failed
        End If
        vRS.Close()

    End Function

    Public Function GetTeacherByFullName(ByVal sTeacherFullName As String, ByRef vTeacher As tTeacher) As TranDBResult
        Dim sSQL As String



        sSQL = "SELECT CONCAT(LastName , ', ' , FirstName , '  ' , MiddleName) AS TeacherFullName" & _
                 " From tblTeacher" & _
                 " WHERE (((TeacherFullName)='" & sTeacherFullName & "'));"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            vTeacher.TeacherID = (vRS("teacherid").ToString())
            vTeacher.TeacherTitle = (vRS("TeacherTitle").ToString())
            vTeacher.Password = (vRS("Password").ToString())
            vTeacher.FirstName = (vRS("FirstName").ToString())
            vTeacher.MiddleName = (vRS("MiddleName").ToString())
            vTeacher.LastName = (vRS("LastName").ToString())
            vTeacher.Address = (vRS("Address").ToString())
            vTeacher.ContactNumber = (vRS("ContactNumber").ToString())
            vTeacher.Active = vRS("Active").ToString()
            vTeacher.CreationDate = Convert.ToDateTime(vRS("CreationDate").ToString())

            GetTeacherByFullName = TranDBResult.Success
        Else
            GetTeacherByFullName = TranDBResult.Failed
        End If

        vRS.Close()

    End Function

    Public Function GetTeacherByID(ByVal sTeacherID As String, ByRef vTeacher As tTeacher) As TranDBResult
        Dim com As New MySqlCommand("SELECT * From tblTeacher WHERE (((tblTeacher.TeacherID)='" & sTeacherID & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            vTeacher.TeacherID = (vRS("teacherid").ToString())
            vTeacher.TeacherTitle = (vRS("TeacherTitle").ToString())
            vTeacher.Password = (vRS("Password").ToString())
            vTeacher.FirstName = (vRS("FirstName").ToString())
            vTeacher.MiddleName = (vRS("MiddleName").ToString())
            vTeacher.LastName = (vRS("LastName").ToString())
            vTeacher.Address = (vRS("Address").ToString())
            vTeacher.ContactNumber = (vRS("ContactNumber").ToString())
            vTeacher.Active = vRS("Active").ToString()
            vTeacher.CreationDate = (vRS("CreationDate").ToString())

            GetTeacherByID = TranDBResult.Success
        Else
            GetTeacherByID = TranDBResult.Failed
        End If

        vRS.Close()
    End Function
    Public Function GetAdviserByID(ByVal sADviserID As String, ByRef vAdviser As tAdviser) As TranDBResult

        Dim com As New MySqlCommand("SELECT * From tblAdviser WHERE (((tblAdviser.TeacherID)='" & sADviserID & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            vAdviser.TeacherID = (vRS("teacherid").ToString())
            vAdviser.AdviserID = (vRS("AdviserId").ToString())
            vAdviser.DepartmentID = (vRS("DepartmentId").ToString())
            vAdviser.SectionID = (vRS("SectionId").ToString())
            vAdviser.YearLevelID = (vRS("YearLevelID").ToString())
            vAdviser.SchoolYear = (vRS("SchoolYear").ToString())

            GetAdviserByID = TranDBResult.Success
        Else
            GetAdviserByID = TranDBResult.Failed
        End If

        vRS.Close()
    End Function
    Public Function FacultyExistInRecord() As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblTeacher", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            FacultyExistInRecord = TranDBResult.Success
        Else
            FacultyExistInRecord = TranDBResult.Failed
        End If
        vRS.Close()
    End Function


    Public Function TeacherExistByTitle(ByVal sTeacherTitle As String) As TranDBResult

        Dim com As New MySqlCommand("SELECT * From tblTeacher WHERE (((tblTeacher.TeacherTitle)='" & sTeacherTitle & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            TeacherExistByTitle = TranDBResult.Success
        Else
            TeacherExistByTitle = TranDBResult.Failed
        End If

        vRS.Close()
    End Function

    Public Function TeacherExistByFullName(ByVal sTeacherFullName As String) As TranDBResult

        Dim sSQL As String

        'deafult
        TeacherExistByFullName = TranDBResult.Failed


        If Len(sTeacherFullName) < 1 Then Exit Function

        sSQL = "SELECT CONCAT(LastName , ', ' , FirstName , '  ' , MiddleName) AS TeacherFullName" & _
                " From tblTeacher" & _
                " WHERE (((TeacherFullName)='" & sTeacherFullName & "'));"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            TeacherExistByFullName = TranDBResult.Success
        Else
            TeacherExistByFullName = TranDBResult.Failed
        End If

        vRS.Close()
    End Function

    Public Function TeacherExistByID(ByVal sTeacherID As String) As TranDBResult

        Dim com As New MySqlCommand("SELECT * From tblTeacher WHERE (((tblTeacher.TeacherID)='" & sTeacherID & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        If vRS.HasRows = True Then
            TeacherExistByID = TranDBResult.Success
        Else
            TeacherExistByID = TranDBResult.Failed
        End If

        'release
        vRS.Close()
    End Function
    Public Function AdviserExistByID(ByVal sTeacherID As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * From tblAdviser WHERE (((tblAdviser.TeacherID)='" & sTeacherID & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        If vRS.HasRows = True Then
            AdviserExistByID = TranDBResult.Success
        Else
            AdviserExistByID = TranDBResult.Failed
        End If

        'release
        vRS.Close()
    End Function

    Public Function GetFacultyNameByFacultyID(ByVal FacultyID As String) As String
        Dim com As New MySqlCommand("SELECT fnEmployeeName(EmployeeID) FROM tblTeacher WHERE TeacherID='" & FacultyID & "'", con)
        Dim vrs As MySqlDataReader = com.ExecuteReader
        vrs.Read()
        If vrs.HasRows Then
            GetFacultyNameByFacultyID = vrs(0).ToString
        Else
            GetFacultyNameByFacultyID = ""
        End If
        vrs.Close()
    End Function


End Module
