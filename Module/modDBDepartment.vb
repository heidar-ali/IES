'==========================================================================================
'Filename:      modDBDepartment.vb
'Type:          MODULE
'Date:          03.MARCH.2012
'Notice:        ©2012 i4Link Systems, Inc. All rights reserved.
'
'Purpose:       Department

'Programmer:        Philip Cesar B. Garay
'===========================================================================================

Option Explicit On
Imports MySql.Data.MySqlClient
Module modDBDepartment
    Public Const keyDepartment As String = "dept"

    Public Structure tDepartment
        Dim DepartmentID As String
        Dim DepartmentCode As String
        Dim DepartmentTitle As String
        Dim ShortName As String
        Dim CampusID As String
        Dim CollegeID As String
    End Structure


    Public Function AddDepartment(ByVal newDepartment As tDepartment) As TranDBResult
        'find duplicate ID
        If DepartmentExistByID(newDepartment.DepartmentID) = TranDBResult.Success Then
            AddDepartment = TranDBResult.DuplicateID
            GoTo ReleaseAndExit
        End If

        'find duplicate TITLE
        If DepartmentExistByTitle(newDepartment.DepartmentTitle) = TranDBResult.Success Then
            AddDepartment = TranDBResult.DuplicateTitle
            GoTo ReleaseAndExit
        End If

        Dim com As New MySqlCommand("INSERT INTO tblDepartment(DepartmentID,DeptCode,DepartmentTitle,DeptShortName,CollegeID,CampusID) VALUES ('" & newDepartment.DepartmentID & _
                                    "','" & newDepartment.DepartmentCode & _
                                    "','" & newDepartment.DepartmentTitle & _
                                    "','" & newDepartment.ShortName & _
                                    "','" & newDepartment.CollegeID & _
                                    "','" & newDepartment.CampusID & "')", clsCon.con)
        com.ExecuteNonQuery()
        AddDepartment = TranDBResult.Success


ReleaseAndExit:
        'release
        Exit Function
    End Function

    Public Function EditDepartment(ByVal newDepartment As tDepartment) As TranDBResult
        'possibe return values
        'Success
        'InvalidID
        'DuplicateTitle

        Dim OldDepartment As tDepartment

        'check duplicate title
        If GetDepartmentByID(newDepartment.DepartmentID, OldDepartment) Then
            If OldDepartment.DepartmentTitle = newDepartment.DepartmentTitle Then
                'there is nothing to do, no fields changes in NEW DEPARTMENT
                'return success
                EditDepartment = TranDBResult.Success
                'exit function
                GoTo ReleaseAndExit
            Else
                'find duplicate title
                If DepartmentExistByTitle(newDepartment.DepartmentTitle) = TranDBResult.Success Then
                    EditDepartment = TranDBResult.DuplicateTitle
                    'exit function
                    GoTo ReleaseAndExit
                End If
            End If
        Else
            'department not found
            'exit function
            EditDepartment = TranDBResult.InvalidID
            GoTo ReleaseAndExit
        End If


        'find record to edit

        Dim com As New MySqlCommand("SELECT * From tblDepartment WHERE (((tblDepartment.DepartmentID)='" & newDepartment.DepartmentID & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = False Then
            EditDepartment = TranDBResult.InvalidID
            Exit Function
        End If
        vRS.Close()

        Dim com1 As New MySqlCommand("UPDATE tblDepartment SET DepartmentTitle='" & newDepartment.DepartmentTitle & _
                                     "', DeptCode='" & newDepartment.DepartmentCode & _
                                     "', DeptShortName='" & newDepartment.ShortName & _
                                     "', CollegeID='" & newDepartment.CollegeID & _
                                     "', CampusID='" & newDepartment.CampusID & _
                                     "' WHERE DepartmentID ='" & newDepartment.DepartmentID & "'", clsCon.con)
        com1.ExecuteNonQuery()
        EditDepartment = TranDBResult.Success


ReleaseAndExit:
        'release
        Exit Function
    End Function

    Public Function DepartmentRecordExist() As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblDepartment", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            DepartmentRecordExist = TranDBResult.Success
        Else
            DepartmentRecordExist = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function ExecuteDeleteDepartment(ByVal sDepartmentID As String) As TranDBResult

        'check if record exist and if it is edited by other user
        If MsgBox("WARNING:" & vbNewLine & _
            "Deleting this DEPARTMENT entry will affect all other record" & vbNewLine & vbNewLine & _
            "Delete this record anyway?", vbQuestion + vbYesNo, "Controller") = vbYes Then

            If DeleteDepartment(sDepartmentID) = TranDBResult.Success Then
                MsgBox("DEPARTMENT entry and other related record succesfully deleted.", vbInformation)
                ExecuteDeleteDepartment = TranDBResult.Success
            Else
                MsgBox("Deleting DEPARTMENT entry went failed.", vbExclamation)
                ExecuteDeleteDepartment = TranDBResult.Failed
            End If
        Else
            ExecuteDeleteDepartment = TranDBResult.Failed
        End If
    End Function

    Public Function DeleteDepartment(ByVal sDepartmentCode As String) As TranDBResult
        DeleteDepartment = TranDBResult.Failed

        Dim com As New MySqlCommand("Delete From tblDepartment WHERE (((tblDepartment.DeptCode)='" & sDepartmentCode & "'));", clsCon.con)
        com.ExecuteNonQuery()
        DeleteDepartment = TranDBResult.Success

    End Function



    Public Function GetDepartmentByID(ByVal sDepartmentID As String, ByRef vDepartment As tDepartment) As Boolean
        Dim com As New MySqlCommand("SELECT * From tblDepartment WHERE (((tblDepartment.DepartmentID)='" & sDepartmentID & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            'SUCCESS: Record exist
            'get values
            '----------------------------------------------------------------
            vDepartment.DepartmentID = (vRS("DepartmentID").ToString())
            vDepartment.DepartmentTitle = (vRS("DepartmentTitle").ToString())
            vDepartment.DepartmentCode = vRS("DeptCode").ToString()
            vDepartment.ShortName = vRS("DeptShortName").ToString()
            vDepartment.CampusID = vRS("CampusID").ToString()
            vDepartment.CollegeID = vRS("CollegeID").ToString()

            GetDepartmentByID = True
        Else

            'FAILED: record does not exist
            GetDepartmentByID = False
        End If

        'release
        vRS.Close()
    End Function

    Public Function GetDepartmentByCode(ByVal sDepartmentCode As String, ByRef vDepartment As tDepartment) As Boolean
        Dim com As New MySqlCommand("SELECT * From tblDepartment WHERE (((tblDepartment.DeptCode)='" & sDepartmentCode & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            'SUCCESS: Record exist
            'get values
            '----------------------------------------------------------------
            vDepartment.DepartmentID = (vRS("DepartmentID").ToString())
            vDepartment.DepartmentTitle = (vRS("DepartmentTitle").ToString())
            vDepartment.DepartmentCode = vRS("DeptCode").ToString()
            vDepartment.ShortName = vRS("DeptShortName").ToString()
            vDepartment.CampusID = vRS("CampusID").ToString()
            vDepartment.CollegeID = vRS("CollegeID").ToString()

            GetDepartmentByCode = True
        Else

            'FAILED: record does not exist
            GetDepartmentByCode = False
        End If

        'release
        vRS.Close()
    End Function

    Public Function GetDepartmentByTitle(ByVal sDepartmentTitle As String, ByRef vDepartment As tDepartment) As TranDBResult

        Dim com As New MySqlCommand("SELECT *  FROM tblDepartment WHERE (((tblDepartment.DepartmentTitle)='" & sDepartmentTitle & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            vDepartment.DepartmentID = (vRS("DepartmentID").ToString())
            vDepartment.DepartmentTitle = (vRS("DepartmentTitle").ToString())
            vDepartment.DepartmentCode = vRS("DeptCode").ToString()
            vDepartment.ShortName = vRS("DeptShortName").ToString()
            vDepartment.CampusID = vRS("CampusID").ToString()
            vDepartment.CollegeID = vRS("CollegeID").ToString()


            GetDepartmentByTitle = TranDBResult.Success
        Else
            GetDepartmentByTitle = TranDBResult.Failed
        End If

        'release
        vRS.Close()
    End Function


    Private Sub ReadFromRecord(ByRef vDepartment As tDepartment, ByVal DepartmentID As String)
        Dim com As New MySqlCommand("SELECT * FROM tblDepartment WHERE DepartmentID='" & DepartmentID & "'", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            vDepartment.DepartmentID = vRS("Departmentid").ToString()
            vDepartment.DepartmentTitle = vRS("Departmenttitle").ToString()
            vDepartment.DepartmentCode = vRS("DeptCode").ToString()
            vDepartment.ShortName = vRS("DeptShortName").ToString()
            vDepartment.CampusID = vRS("CampusID").ToString()
            vDepartment.CollegeID = vRS("CollegeID").ToString()

        End If
        vRS.Close()
    End Sub


    Public Function DepartmentExistByTitle(ByVal sDepartmentTitle As String) As TranDBResult

        Dim com As New MySqlCommand("SELECT * From tblDepartment WHERE (((tblDepartment.DepartmentTitle)='" & sDepartmentTitle & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            DepartmentExistByTitle = TranDBResult.Success
        Else
            DepartmentExistByTitle = TranDBResult.Failed
        End If
        'release
        vRS.Close()
    End Function


    Public Function DepartmentExistByID(ByVal sDepartmentID As String) As TranDBResult

        Dim com As New MySqlCommand("SELECT * From tblDepartment WHERE (((tblDepartment.DepartmentID)='" & sDepartmentID & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then

            DepartmentExistByID = TranDBResult.Success
        Else
            DepartmentExistByID = TranDBResult.Failed
        End If

        'release
        vRS.Close()
    End Function
    Public Function GetNewDepartmentID(ByRef sNewDepartmentID As String) As TranDBResult
        Dim sSQL As String
        Dim NewDNumber As Integer


        'default
        GetNewDepartmentID = TranDBResult.Failed

        sSQL = "SELECT CONCAT('D-','',LEFT('0',2-Length(Count(*)+1)),'',Count(*)+1) AS NewID FROM tblDepartment;"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = False Then
            GetNewDepartmentID = TranDBResult.Failed
            Exit Function
        Else
            sNewDepartmentID = vRS("NewID").ToString()
            GetNewDepartmentID = TranDBResult.Success
        End If
        vRS.Close()

        While DepartmentExistByID(sNewDepartmentID) = TranDBResult.Success
            NewDNumber = Val(Right(sNewDepartmentID, 2)) + 1
            sNewDepartmentID = "D-" & Left("0", 2) & NewDNumber
        End While


    End Function
End Module
