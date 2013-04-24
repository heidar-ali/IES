Option Explicit On

Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Module modDBEmployee


    Public Structure tEmployee
        Dim EmployeeID As String
        Dim LastName As String
        Dim FirstName As String
        Dim MiddleName As String
        Dim MiddleInitial As String
        Dim ExtName As String
        Dim Prefix As String
        Dim PosnTitleID As String
        Dim DeptID As String
        Dim DateOfBirth As Date
        Dim PlaceOfBirth As String
        Dim Gender As String
        Dim CivilStatusID As String
        Dim EmpStatusID As String

        Dim CampusID As String
        Dim CollegeID As String

        Dim Inactive As Short
    End Structure

    Public Structure tEmpPosition
        Dim PositionID As String
        Dim PositionCode As String
        Dim Description As String
        Dim ShortName As String
    End Structure

    Public Structure tEmployeeClass
        Dim ClassCode As String
        Dim Classification As String
    End Structure

    Public Function EmployeeExistByID(ByVal sEmployeeID As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblEmployees WHERE tblEmployees.EmployeeID='" & sEmployeeID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            EmployeeExistByID = TranDBResult.Success
        Else
            EmployeeExistByID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function SaveEmployee(ByVal tEmp As tEmployee) As TranDBResult

        If EmployeeExistByID(tEmp.EmployeeID) = TranDBResult.Success Then
            SaveEmployee = TranDBResult.DuplicateID
            Exit Function
        End If

        Dim com As New MySqlCommand("INSERT INTO tblEmployees(EmployeeID,LastName,FirstName,MiddleName,MiddleInitial,ExtName,Prefix,PosnTitleID,DeptID,CampusID,DateOfBirth,Gender,CivilStatusID,InActive) VALUES " & _
                                    "(@EmployeeID,@LastName,@FirstName,@MiddleName,@MiddleInitial,@ExtName,@Prefix,@PosnTitleID,@DeptID,@CampusID,@DateOfBirth,@Gender,@CivilStatusID,@InActive)", con)
        com.Parameters.Add("@EmployeeID", MySqlDbType.VarChar, 45).Value = tEmp.EmployeeID
        com.Parameters.Add("@LastName", MySqlDbType.VarChar, 45).Value = tEmp.LastName
        com.Parameters.Add("@FirstName", MySqlDbType.VarChar, 45).Value = tEmp.FirstName
        com.Parameters.Add("@MiddleName", MySqlDbType.VarChar, 45).Value = tEmp.MiddleName
        com.Parameters.Add("@MiddleInitial", MySqlDbType.VarChar, 5).Value = tEmp.MiddleInitial
        com.Parameters.Add("@Prefix", MySqlDbType.VarChar, 45).Value = tEmp.Prefix
        com.Parameters.Add("@ExtName", MySqlDbType.VarChar, 45).Value = tEmp.ExtName
        com.Parameters.Add("@PosnTitleID", MySqlDbType.VarChar, 45).Value = tEmp.PosnTitleID
        com.Parameters.Add("@DeptID", MySqlDbType.VarChar, 45).Value = tEmp.DeptID
        com.Parameters.Add("@CampusID", MySqlDbType.VarChar, 45).Value = tEmp.CampusID
        'com.Parameters.Add("@CollegeID", MySqlDbType.VarChar, 45).Value = tEmp.CollegeID
        com.Parameters.Add("@DateOfBirth", MySqlDbType.Date).Value = tEmp.DateOfBirth
        com.Parameters.Add("@Gender", MySqlDbType.VarChar, 10).Value = tEmp.Gender
        com.Parameters.Add("@CivilStatusID", MySqlDbType.VarChar, 45).Value = tEmp.CivilStatusID
        com.Parameters.Add("@InActive", MySqlDbType.UInt16).Value = tEmp.Inactive

        com.ExecuteNonQuery()
        com.Parameters.Clear()

        SaveEmployee = TranDBResult.Success
    End Function

    Public Function UpdateEmployee(ByVal tEmp As tEmployee) As TranDBResult

        If EmployeeExistByID(tEmp.EmployeeID) = TranDBResult.Success Then

            Dim com As New MySqlCommand("UPDATE tblEmployees SET LastName = @LastName,FirstName=@FirstName,MiddleName=@MiddleName,MiddleInitial=@MiddleInitial,ExtName=@ExtName,Prefix=@Prefix,PosnTitleID=@PosnTitleID,DeptID=@DeptID,CampusID=@CampusID,DateOfBirth=@DateOfBirth,Gender=@Gender,CivilStatusID=@CivilStatusID,InActive=@InActive" & _
                                        " WHERE EmployeeID ='" & tEmp.EmployeeID & "'", con)
            com.Parameters.Add("@EmployeeID", MySqlDbType.VarChar, 45).Value = tEmp.EmployeeID
            com.Parameters.Add("@LastName", MySqlDbType.VarChar, 45).Value = tEmp.LastName
            com.Parameters.Add("@FirstName", MySqlDbType.VarChar, 45).Value = tEmp.FirstName
            com.Parameters.Add("@MiddleName", MySqlDbType.VarChar, 45).Value = tEmp.MiddleName
            com.Parameters.Add("@MiddleInitial", MySqlDbType.VarChar, 5).Value = tEmp.MiddleInitial
            com.Parameters.Add("@Prefix", MySqlDbType.VarChar, 45).Value = tEmp.Prefix
            'com.Parameters.Add("@EmpStatusID", MySqlDbType.VarChar, 45).Value = tEmp.EmpStatusID
            com.Parameters.Add("@PosnTitleID", MySqlDbType.VarChar, 45).Value = tEmp.PosnTitleID
            com.Parameters.Add("@DeptID", MySqlDbType.VarChar, 45).Value = tEmp.DeptID
            com.Parameters.Add("@CampusID", MySqlDbType.VarChar, 45).Value = tEmp.CampusID
            'com.Parameters.Add("@CollegeID", MySqlDbType.VarChar, 45).Value = tEmp.CollegeID
            com.Parameters.Add("@DateOfBirth", MySqlDbType.Date).Value = tEmp.DateOfBirth
            com.Parameters.Add("@Gender", MySqlDbType.VarChar, 10).Value = tEmp.Gender
            com.Parameters.Add("@CivilStatusID", MySqlDbType.VarChar, 45).Value = tEmp.CivilStatusID
            com.Parameters.Add("@InActive", MySqlDbType.UInt16).Value = tEmp.Inactive

            com.ExecuteNonQuery()
            com.Parameters.Clear()

            UpdateEmployee = TranDBResult.Success
        End If
    End Function

    Public Function ExecuteDeleteEmployee(ByVal sEmployeeID As String) As TranDBResult

        'check if record exist and if it is edited by other user
        If MsgBox("WARNING:" & vbNewLine & _
            "Deleting this EMPLOYEE record will affect all other record" & vbNewLine & vbNewLine & _
            "Delete this record anyway?", vbQuestion + vbYesNo, Application.ProductName) = vbYes Then

            If DeleteEmployee(sEmployeeID) = TranDBResult.Success Then
                MsgBox("EMPLOYEE record and other related record succesfully deleted.", vbInformation)
                ExecuteDeleteEmployee = TranDBResult.Success
            Else
                MsgBox("Deleting EMPLOYEE entry went failed.", vbExclamation)
                ExecuteDeleteEmployee = TranDBResult.Failed
            End If
        Else
            ExecuteDeleteEmployee = TranDBResult.Failed
        End If
    End Function

    Public Function DeleteEmployee(ByVal sEmployeeID As String) As TranDBResult
        DeleteEmployee = TranDBResult.Failed

        Dim com As New MySqlCommand("Delete From tblEmployees WHERE (((EmployeeID)='" & sEmployeeID & "'));", clsCon.con)
        com.ExecuteNonQuery()
        DeleteEmployee = TranDBResult.Success

    End Function

    Public Function GetEmployeeByEmployeeID(ByVal sEmployeeID As String, ByRef tEmp As tEmployee) As TranDBResult
        If EmployeeExistByID(sEmployeeID) <> TranDBResult.Success Then
            Exit Function
        End If

        Dim com As New MySqlCommand("SELECT * FROM tblEmployees AS E WHERE E.EmployeeID ='" & sEmployeeID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            tEmp.EmployeeID = vRS("EmployeeID").ToString()
            tEmp.CivilStatusID = vRS("CivilStatusID").ToString()
            tEmp.DateOfBirth = vRS("DateOfBirth").ToString()
            tEmp.LastName = vRS("LastName").ToString()
            tEmp.MiddleName = vRS("MiddleName").ToString()
            tEmp.MiddleInitial = vRS("MiddleInitial").ToString()
            tEmp.PosnTitleID = vRS("PosnTitleID").ToString()
            tEmp.FirstName = vRS("FirstName").ToString()
            tEmp.Gender = vRS("Gender").ToString()
            tEmp.Prefix = vRS("Prefix").ToString()
            tEmp.ExtName = vRS("ExtName").ToString()
            tEmp.DeptID = vRS("DeptID").ToString()

            GetEmployeeByEmployeeID = TranDBResult.Success
        Else
            GetEmployeeByEmployeeID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function getEmployeeFullNameByID(ByVal EmployeeID As String) As String
        Dim com As New MySqlCommand("SELECT CONCAT(E.LastName , ', ', E.FirstName,' ', E.MiddleInitial,'. ',E.ExtName) FROM tblemployees E WHERE E.EmployeeID = '" & EmployeeID & "' LIMIT 1", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            getEmployeeFullNameByID = vRS(0).ToString()
        Else
            getEmployeeFullNameByID = ""
        End If
        vRS.Close()
    End Function


    Public Function EmployeePositionTitleExistByCode(ByVal PositionCode As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblPositionTitles WHERE PositionCode='" & PositionCode & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            EmployeePositionTitleExistByCode = TranDBResult.Success
        Else
            EmployeePositionTitleExistByCode = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function EmployeePositionTitleExistByID(ByVal PositionID As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblPositionTitles WHERE PosnTitleID='" & PositionID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            EmployeePositionTitleExistByID = TranDBResult.Success
        Else
            EmployeePositionTitleExistByID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function EmployeePositionExistByName(ByVal sTitle As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblPositionTitles WHERE PositionCode LIKE '%" & sTitle & "'%", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            EmployeePositionExistByName = TranDBResult.Success
        Else
            EmployeePositionExistByName = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function ExecuteDeleteEmployeePosition(ByVal sDepartmentID As String) As TranDBResult

        'check if record exist and if it is edited by other user
        If MsgBox("WARNING:" & vbNewLine & _
            "Deleting this EMPLOYEE POSITION will affect all other record" & vbNewLine & vbNewLine & _
            "Delete this record anyway?", vbQuestion + vbYesNo, Application.ProductName) = vbYes Then

            If DeleteEmployeePosition(sDepartmentID) = TranDBResult.Success Then
                MsgBox("EMPLOYEE POSITION and other related record succesfully deleted.", vbInformation)
                ExecuteDeleteEmployeePosition = TranDBResult.Success
            Else
                MsgBox("Deleting EMPLOYEE POSITION entry went failed.", vbExclamation)
                ExecuteDeleteEmployeePosition = TranDBResult.Failed
            End If
        Else
            ExecuteDeleteEmployeePosition = TranDBResult.Failed
        End If
    End Function

    Public Function DeleteEmployeePosition(ByVal sPosnTitleID As String) As TranDBResult
        DeleteEmployeePosition = TranDBResult.Failed

        Dim com As New MySqlCommand("Delete From tblPositionTitles WHERE (((PosnTitleID)='" & sPosnTitleID & "'));", clsCon.con)
        com.ExecuteNonQuery()
        DeleteEmployeePosition = TranDBResult.Success

    End Function

    Public Function SaveEmployeePosition(ByVal Pos As tEmpPosition) As TranDBResult
        If EmployeePositionTitleExistByCode(Pos.PositionCode) = TranDBResult.Success Then
            SaveEmployeePosition = TranDBResult.DuplicateCode
            Exit Function
        End If

        Dim com As New MySqlCommand("INSERT INTO tblPositionTitles(PositionCode,PositionDesc,ShortName) VALUES ('" & Pos.PositionCode & "','" & Pos.Description & "','" & Pos.ShortName & "')", con)
        com.ExecuteNonQuery()

        SaveEmployeePosition = TranDBResult.Success
    End Function

    Public Function UpdateEmployeePosition(ByVal Pos As tEmpPosition) As TranDBResult
        If EmployeePositionTitleExistByID(Pos.PositionID) = TranDBResult.Success Then
            Dim com As New MySqlCommand("UPDATE tblPositionTitles SET PositionCode='" & Pos.PositionCode & "',PositionDesc='" & Pos.Description & "',ShortName='" & Pos.ShortName & "' WHERE PosnTitleID='" & Pos.PositionID & "'", con)
            com.ExecuteNonQuery()
            UpdateEmployeePosition = TranDBResult.Success
        Else
            UpdateEmployeePosition = TranDBResult.Failed
        End If
    End Function
End Module
