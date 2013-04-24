Imports MySql.Data.MySqlClient

Module modRSUser

    Public Enum UserRights
        AllowRead = 1
        AllowWrite = 2
        AllowDelete = 3
        AllowPrint = 4
        AllowExport = 5
    End Enum

    Public Const sAdministratortitle As String = "Administrator"
    Public Const sEncoderTitle As String = "Encoder"


    Public Const sCanAddUser As String = "Can Add User"
    Public Const sCanEditUser As String = "Can Edit User"
    Public Const sCanDeleteUser As String = "Can Delete User"
    Public Const sCanViewUser As String = "Can View User"

    Public Const sCanAddSchoolYear As String = "Can Add School Year"
    Public Const sCanDeleteSchoolYear As String = "Can Delete School Year"
    Public Const sCanLockUnlockSchoolYear As String = "Can Lock/Unlock School Year"


    Public Const sCanAddDepartment As String = "Can Add Department"
    Public Const sCanEditDepartment As String = "Can Edit Department"
    Public Const sCanDeleteDepartment As String = "Can Delete Department"

    Public Const sCanAddSection As String = "Can Add Section"
    Public Const sCanEditSection As String = "Can Edit Section"
    Public Const sCanDeleteSection As String = "Can Delete Section"

    Public Const sCanAddSectionOffering As String = "Can Add Section Offering"
    Public Const sCanEditSectionOffering As String = "Can Edit Section Offering"
    Public Const sCanDeleteSectionOffering As String = "Can Delete Section Offering"

    Public Const sCanAddTeacher As String = "Can Add Teacher"
    Public Const sCanEditTeacher As String = "Can Edit Teacher"
    Public Const sCanDeleteTeacher As String = "Can Delete Teacher"

    Public Const sCanAddFee As String = "Can Add Fee"
    Public Const sCanEditFee As String = "Can Edit Fee"
    Public Const sCanDeleteFee As String = "Can Delete Fee"

    Public Const sCanAddCashier As String = "Can Add Cashier"
    Public Const sCanEditCashier As String = "Can Edit Cashier"
    Public Const sCanDeleteCashier As String = "Can Delete Cashier"

    Public Const sCanModifyDropped As String = "Can Add/Remove Dropped Student"

    Public Const sCanAddEnrolment As String = "Can Add Enrolment"
    Public Const sCanDeleteEnrolment As String = "Can Delete Enrolment"
    Public Const sCanModifyGraduate As String = "Can Add/Remove Graduate Student"
    Public Const sCanModifyLeaved As String = "Can Add/Remove Leaving Student"

    Public Const sCanAddStudent As String = "Can Add Student"
    Public Const sCanEditStudent As String = "Can Edit Student"
    Public Const sCanDeleteStudent As String = "Can Delete Student"

    Public Const sCanAddCredential As String = "Can Add Credential"
    Public Const sCanEditCredential As String = "Can Edit Credential"
    Public Const sCanDeleteCredential As String = "Can Delete Credential"

    Public Const sCanAddStudentCredential As String = "Can Add Student Credential"
    Public Const sCanDeleteStudentCredential As String = "Can Delete Student Credential"





    Public Const keyUser As String = "user"


    'U S E R
    '-----------------------------------------------------
    Public Structure User

        Dim UserName As String
        Dim Password As String
        Dim FullName As String
        Dim UserType As String
        Dim ModuleType As String
        Dim CreationDate As Date
        Dim DateModified As Date
        Dim LastModifiedBy As String
        Dim CreatedBy As String

        'misc
        Dim OnLine As Boolean

    End Structure



    Public Const CanAddUser As String = "Can Add User"
    Public Const CanEditUser As String = "Can Edit User"
    Public Const CanDeleteUser As String = "Can Delete User"
    Public Const CanClearUserLog As String = "Can Clear User Log"

    Public Const CanAddSchoolYear As String = "Can Add School Year"
    Public Const CanEditSchoolYear As String = "Can Edit School Year"
    Public Const CanDeleteSchoolYear As String = "Can Delete School Year"

    Public Function UserAllowedTo(ByVal sUserName As String, ByVal sAccessTitle As String) As Boolean
        Dim sSQL As String
        UserAllowedTo = False

        sSQL = "SELECT tblUserAccess.UserName, tblUserAccess.AllowedTo" & _
            " From tblUserAccess" & _
            " WHERE (((tblUserAccess.UserName)='" & sUserName & "') AND ((tblUserAccess.AllowedTo)='" & sAccessTitle & "'));"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            UserAllowedTo = True
        Else
            UserAllowedTo = False
        End If
        vRS.Close()
    End Function

    Private Function IsUserExisted(ByVal sUserName As String) As Boolean
        Dim sSQL As String

        sSQL = "SELECT tblUser.UserName" & _
                " From tblUser" & _
                " WHERE (((tblUser.UserName)='" & sUserName & "'));"
        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            IsUserExisted = True
        Else
            IsUserExisted = False
        End If
        vRS.Close()

    End Function

    Public Function UserRecordExist() As Boolean
        'default
        Dim sSQL As String

        UserRecordExist = False

        sSQL = "SELECT * From tblUser"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            UserRecordExist = True
        Else
            UserRecordExist = False
        End If
        vRS.Close()

    End Function

End Module
