'==========================================================================================
'Filename:      modCampus.vb
'Type:          MODULE
'Date:          15.APRIL.2012
'Notice:        ©2012 i4Link Systems, Inc. All rights reserved.
'
'Purpose:       Institution/Campus/University/School Details and Informations

'Programmer:        Philip Cesar B. Garay
'===========================================================================================


Option Explicit On

Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Module modCampus
    Public SchoolExisted As Boolean


    Public Const keyCampus = "Camp"

    Public Structure tSchool
        Dim CampusID As Integer
        Dim InstCode As Integer
        Dim ShortName As String
        Dim Acronym As String
        Dim CampusName As String


        Dim RegionID As Integer
        Dim Barangay As String
        Dim TownCity As String
        Dim District As String
        Dim Province As String
        Dim ZipCode As String
        Dim MailingAddress As String
        Dim WebSite As String
        Dim TelNo As String
        Dim FaxNo As String
        Dim Email As String


        Dim RegistrarName As String
        Dim RegistrarOffice As String
        Dim RegistrarPositionID As String

        Dim CashierName As String
        Dim CashierOffice As String
        Dim CashierPositionID As String

        Dim AccountantName As String
        Dim AccountingOffice As String
        Dim AccountantPositionID As String

        Property SchoolName As String

    End Structure

    Public Structure tInstitution
        Dim InstID As Integer
        Dim InstClassID As Integer
        Dim CampusCount As Integer
        Dim PPCode As Integer
        Dim HeadID As String
        Dim HeadPosTitleID As Integer
        Dim MapOwnershipClass As Integer
        Dim Address_Street As String
        Dim Address_Municipality As String
        Dim Address_CityProvince As String
        Dim Address_Region As String
        Dim Address_ZipCode As String
        Dim TelNo As String
        Dim FaxNo As String
        Dim HeadTelNo As String
        Dim EmailAddress As String
        Dim WebSite As String
        Dim YearEstablished As String
        Dim LatestSecReg As String
        Dim DateGranted As String
        Dim YearConvertedCollege As String
        Dim YearConvertedUniversity As String

    End Structure

    Public Structure tPhilRegions
        Dim RegionID As String
        Dim RegionName As String
        Dim ShortName As String
    End Structure

    Public CurrentSchool As tSchool
    Public CurrentInstitution As tInstitution


    Public Function CheckSchoolInfo()
        If Not isSchoolExisted() Then
            MsgBox("WARNING: No Institution information exist in the record. Please provide some information." & vbNewLine & "HINT: Use Administrative Panel Module to provide school information", vbExclamation)
            Exit Function
        End If

        SchoolExisted = True
        Call GetSchoolInfo(CurrentInstitution)
    End Function

    Public Function CheckCurrentCampusInfo()
        If Not isSchoolExisted() Then
            MsgBox("WARNING: No Campus information exist in the record. Please provide some information." & vbNewLine & "HINT: Use Administrative Panel Module to provide school information", vbExclamation)
            Exit Function
        End If

        SchoolExisted = True
        Call GetSchoolInfo(CurrentInstitution)
    End Function

    Public Function GetSchoolInfo(ByRef vSchool As tInstitution) As Boolean
        Dim sSQL As String

        sSQL = "SELECT * FROM tblInstitution LIMIT 1"
        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            vSchool.InstID = vRS("InstID").ToString()
            vSchool.InstClassID = vRS("InsClassID").ToString()
            vSchool.CampusCount = vRS("CampusCount").ToString()
            vSchool.PPCode = vRS("PPCode").ToString()
            vSchool.HeadID = vRS("HeadID").ToString()
            vSchool.HeadPosTitleID = vRS("HeadPosTitleID").ToString()
            vSchool.MapOwnershipClass = vRS("MapOwnershipClass").ToString()
            vSchool.Address_Street = vRS("Address_Street").ToString()
            vSchool.Address_Region = vRS("Address_Region").ToString()
            vSchool.Address_Municipality = vRS("Address_Municipality").ToString()

            vSchool.Address_CityProvince = vRS("Address_CityProvince").ToString()
            vSchool.Address_ZipCode = vRS("AddressP_ZipCode").ToString()
            vSchool.TelNo = vRS("TelNo").ToString()
            vSchool.FaxNo = vRS("FaxNo").ToString()
            vSchool.HeadTelNo = vRS("HeadTelNo").ToString()
            vSchool.EmailAddress = vRS("EmailAddress").ToString()
            vSchool.WebSite = vRS("WebSite").ToString()
            vSchool.YearEstablished = vRS("YearEstablished").ToString()
            vSchool.LatestSecReg = vRS("LatestSecReg").ToString()
            vSchool.DateGranted = vRS("DateGranted").ToString()

            GetSchoolInfo = True
        Else
            GetSchoolInfo = False
        End If
        vRS.Close()
    End Function

    Public Function GetCampusInfo(ByVal CampusID As String, ByRef Camp As tSchool) As Boolean
        Dim sSQL As String

        sSQL = "SELECT * FROM tblCampus WHERE CampusID='" & CampusID & "'"
        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            Camp.CampusID = vRS("CampusID").ToString()
            Camp.Barangay = vRS("Barangay").ToString()
            Camp.AccountantName = vRS("Accountant").ToString()
            Camp.AccountantPositionID = vRS("AccountantPositionID").ToString()
            Camp.AccountingOffice = vRS("AccountingOffice").ToString()
            Camp.Acronym = vRS("Acronym").ToString()
            Camp.Barangay = vRS("Barangay").ToString()

            GetCampusInfo = True
        Else
            GetCampusInfo = False
        End If
        vRS.Close()
    End Function

    Public Function GetInstitutionByID(ByVal InstID As String, ByRef vSchool As tInstitution) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblInstitution WHERE InstID='" & InstID & "' LIMIT 1", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            vSchool.InstID = vRS("InstID").ToString()
            vSchool.InstClassID = CInt(vRS("InsClassID").ToString())
            vSchool.CampusCount = vRS("CampusCount").ToString()
            vSchool.PPCode = vRS("PPCode").ToString()
            vSchool.HeadID = vRS("HeadID").ToString()
            vSchool.HeadPosTitleID = vRS("HeadPosTitleID").ToString()
            vSchool.MapOwnershipClass = vRS("MapOwnershipClass").ToString()
            vSchool.Address_Street = vRS("Address_Street").ToString()
            vSchool.Address_Region = vRS("Address_Region").ToString()
            vSchool.Address_Municipality = vRS("Address_Municipality").ToString()

            vSchool.Address_CityProvince = vRS("Address_CityProvince").ToString()
            vSchool.Address_ZipCode = vRS("AddressP_ZipCode").ToString()
            vSchool.TelNo = vRS("TelNo").ToString()
            vSchool.FaxNo = vRS("FaxNo").ToString()
            vSchool.HeadTelNo = vRS("HeadTelNo").ToString()
            vSchool.EmailAddress = vRS("EmailAddress").ToString()
            vSchool.WebSite = vRS("WebSite").ToString()
            vSchool.YearEstablished = vRS("YearEstablished").ToString()
            vSchool.LatestSecReg = vRS("LatestSecReg").ToString()
            vSchool.DateGranted = vRS("DateGranted").ToString()
            '-----TODO-------
            GetInstitutionByID = TranDBResult.Success
        Else
            GetInstitutionByID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function isSchoolExisted() As Boolean
        Dim sSQL As String

        sSQL = "SELECT * FROM tblInstitution LIMIT 1"
        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            isSchoolExisted = True
        Else
            isSchoolExisted = False
        End If
        vRS.Close()
    End Function

    Public Function isCampusExisted(Optional ByVal CampusID As String = "") As Boolean
        Dim sSQL As String

        If Len(CampusID) > 0 Then
            sSQL = "SELECT * FROM tblCampus WHERE CampusID = '" & CampusID & "'"
            Dim com As New MySqlCommand(sSQL, clsCon.con)
            Dim vRS As MySqlDataReader = com.ExecuteReader()
            vRS.Read()
            If vRS.HasRows = True Then
                isCampusExisted = True
            Else
                isCampusExisted = False
            End If
            vRS.Close()
        Else
            sSQL = "SELECT * FROM tblCampus"
            Dim com As New MySqlCommand(sSQL, clsCon.con)
            Dim vRS As MySqlDataReader = com.ExecuteReader()
            vRS.Read()
            If vRS.HasRows = True Then
                isCampusExisted = True
            Else
                isCampusExisted = False
            End If
            vRS.Close()
        End If
    End Function

    Public Function SaveInstitution(ByVal vInst As tInstitution) As Boolean
        Dim sSQL As String

        If isSchoolExisted() = True Then
            Dim com As New MySqlCommand("UPDATE FROM tblInstitution SET InstClassID='" & vInst.InstClassID & _
                                        "',CampusCount= '" & vInst.CampusCount & "', HeadID='" & vInst.HeadID & "'", con)

        Else


        End If
    End Function


    Public Function SaveCampusInfo(ByVal vSchool As tSchool) As Boolean
        Dim sSQL As String

        If isCampusExisted(vSchool.CampusID) = True Then
            sSQL = "UPDATE tblCampus SET InstCode=@InstCode,ShortName=@SchoolName,Acronym=@Acronym,CampusName=@CampusName," & _
                    "RegionID=@RegionID,Barangay=@Barangay,TownCity=@TownCity,District=@District,Province=@Province,ZipCode=@ZipCode,MailingAddress=@MailingAddress," & _
                    "RegistrarName=@RegistrarName,RegistrarOffice=@RegistrarOffice,RegistrarPositionID=@RegistrarPositionID," & _
                    "AccountingOffice=@AccountingOffice,Accountant=@AccountantName,AccountantPositionID=@AccountantPositionID," & _
                    "CashierOffice=@CashierOffice,Cashier=@CashierName,CashierPositionID=@CashierPositionID," & _
                    "SchoolWebsite=@WebSite,TelNo=@TelNo,FaxNo=@FaxNo,Email=@Email"
        Else
            sSQL = "INSERT INTO tblCampus(InstCode,ShortName,Acronym,CampusName," & _
                    "RegionID,Barangay,TownCity,District,Province,ZipCode,MailingAddress," & _
                    "RegistrarName,RegistrarOffice,RegistrarPositionID," & _
                    "AccountingOffice,Accountant,AccountantPositionID," & _
                    "CashierOffice,Cashier,CashierPositionID," & _
                    "SchoolWebsite,TelNo,FaxNo,Email) VALUES (@InstCode,@SchoolName," & _
                    "@Acronym,@CampusName,@RegionID,@Barangay,@TownCity,@District,@Province," & _
                    "@ZipCode,@MailingAddress,@RegistrarName,@RegistrarOffice,@RegistrarPositionID," & _
                    "@AccountingOffice,@AccountantName,@AccountantPositionID," & _
                    "@CashierOffice,@CashierName,@CashierPositionID," & _
                    "@WebSite,@TelNo,@FaxNo,@Email)"
        End If

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        com.Parameters.Add("@InstCode", MySqlDbType.Int32).Value = vSchool.InstCode
        com.Parameters.Add("@SchoolName", MySqlDbType.VarChar, 200).Value = vSchool.ShortName
        com.Parameters.Add("@Acronym", MySqlDbType.VarChar, 50).Value = vSchool.Acronym
        com.Parameters.Add("@CampusName", MySqlDbType.VarChar, 150).Value = vSchool.CampusName
        com.Parameters.Add("@RegionID", MySqlDbType.Int32).Value = vSchool.RegionID
        com.Parameters.Add("@Barangay", MySqlDbType.VarChar, 50).Value = vSchool.Barangay
        com.Parameters.Add("@TownCity", MySqlDbType.VarChar, 50).Value = vSchool.TownCity
        com.Parameters.Add("@District", MySqlDbType.VarChar, 45).Value = vSchool.District
        com.Parameters.Add("@Province", MySqlDbType.VarChar, 50).Value = vSchool.Province
        com.Parameters.Add("@ZipCode", MySqlDbType.VarChar, 45).Value = vSchool.ZipCode
        com.Parameters.Add("@MailingAddress", MySqlDbType.VarChar, 100).Value = vSchool.MailingAddress
        com.Parameters.Add("@RegistrarName", MySqlDbType.VarChar, 60).Value = vSchool.RegistrarName
        com.Parameters.Add("@RegistrarOffice", MySqlDbType.VarChar, 200).Value = vSchool.RegistrarOffice
        com.Parameters.Add("@RegistrarPositionID", MySqlDbType.Int32).Value = vSchool.RegistrarPositionID
        com.Parameters.Add("@AccountingOffice", MySqlDbType.VarChar, 200).Value = vSchool.AccountingOffice
        com.Parameters.Add("@AccountantName", MySqlDbType.VarChar, 60).Value = vSchool.AccountantName
        com.Parameters.Add("@AccountantPositionID", MySqlDbType.Int32).Value = vSchool.AccountantPositionID
        com.Parameters.Add("@CashierOffice", MySqlDbType.VarChar, 200).Value = vSchool.CashierOffice
        com.Parameters.Add("@CashierName", MySqlDbType.VarChar, 60).Value = vSchool.CashierName
        com.Parameters.Add("@CashierPositionID", MySqlDbType.Int32).Value = vSchool.CashierPositionID
        com.Parameters.Add("@Website", MySqlDbType.VarChar, 45).Value = vSchool.WebSite
        com.Parameters.Add("@TelNo", MySqlDbType.VarChar, 45).Value = vSchool.TelNo
        com.Parameters.Add("@FaxNo", MySqlDbType.VarChar, 45).Value = vSchool.FaxNo
        com.Parameters.Add("@Email", MySqlDbType.VarChar, 60).Value = vSchool.Email
        com.ExecuteNonQuery()
        com.Parameters.Clear()
        SaveCampusInfo = True
    End Function

    Public Function GetCampusByAcronym(ByVal Acronym As String, ByRef vCampus As tSchool) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblCampus WHERE Acronym='" & Acronym & "' LIMIT 1", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            vCampus.ShortName = vRS("ShortName").ToString()
            vCampus.CampusID = CInt(vRS("CampusID").ToString())
            vCampus.Acronym = vRS("Acronym").ToString()
            vCampus.AccountantName = vRS("Accountant").ToString()
            vCampus.AccountantPositionID = vRS("AccountantPositionID").ToString()
            vCampus.AccountingOffice = vRS("AccountingOffice").ToString()
            vCampus.CampusName = vRS("CampusName").ToString()
            vCampus.CashierName = vRS("Cashier").ToString()
            vCampus.CashierOffice = vRS("CashierOffice").ToString()
            vCampus.CashierPositionID = vRS("CashierPositionID").ToString()
            vCampus.RegistrarName = vRS("RegistrarName").ToString()
            vCampus.RegistrarOffice = vRS("RegistrarOffice").ToString()
            vCampus.RegistrarPositionID = vRS("RegistrarPositionID").ToString()
            vCampus.District = vRS("District").ToString()
            vCampus.Email = vRS("Email").ToString()
            vCampus.FaxNo = vRS("FaxNo").ToString()
            vCampus.InstCode = vRS("InstCode").ToString()
            vCampus.MailingAddress = vRS("MailingAddress").ToString()
            vCampus.Province = vRS("Province").ToString()
            vCampus.RegionID = vRS("RegionID").ToString()
            vCampus.WebSite = vRS("SchoolWebSite").ToString()
            vCampus.TelNo = vRS("TelNo").ToString()
            vCampus.TownCity = vRS("TownCity").ToString()
            vCampus.ZipCode = vRS("ZipCode").ToString()
            vCampus.Barangay = vRS("Barangay").ToString()
            GetCampusByAcronym = TranDBResult.Success
        Else
            GetCampusByAcronym = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function GetCampusByCampusID(ByVal CampusID As String, ByRef vCampus As tSchool) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblCampus WHERE CampusID='" & CampusID & "' LIMIT 1", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            vCampus.ShortName = vRS("ShortName").ToString()
            vCampus.CampusID = CInt(vRS("CampusID").ToString())
            vCampus.Acronym = vRS("Acronym").ToString()
            vCampus.AccountantName = vRS("Accountant").ToString()
            vCampus.AccountantPositionID = vRS("AccountantPositionID").ToString()
            vCampus.AccountingOffice = vRS("AccountingOffice").ToString()
            vCampus.CampusName = vRS("CampusName").ToString()
            vCampus.CashierName = vRS("Cashier").ToString()
            vCampus.CashierOffice = vRS("CashierOffice").ToString()
            vCampus.CashierPositionID = vRS("CashierPositionID").ToString()
            vCampus.RegistrarName = vRS("RegistrarName").ToString()
            vCampus.RegistrarOffice = vRS("RegistrarOffice").ToString()
            vCampus.RegistrarPositionID = vRS("RegistrarPositionID").ToString()
            vCampus.District = vRS("District").ToString()
            vCampus.Email = vRS("Email").ToString()
            vCampus.FaxNo = vRS("FaxNo").ToString()
            vCampus.InstCode = vRS("InstCode").ToString()
            vCampus.MailingAddress = vRS("MailingAddress").ToString()
            vCampus.Province = vRS("Province").ToString()
            vCampus.RegionID = vRS("RegionID").ToString()
            vCampus.WebSite = vRS("SchoolWebSite").ToString()
            vCampus.TelNo = vRS("TelNo").ToString()
            vCampus.TownCity = vRS("TownCity").ToString()
            vCampus.ZipCode = vRS("ZipCode").ToString()
            vCampus.Barangay = vRS("Barangay").ToString()

            '-----TODO-------
            GetCampusByCampusID = TranDBResult.Success
        Else
            GetCampusByCampusID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function GetPhilRegionByID(ByVal RegionID As String, ByRef Reg As tPhilRegions) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblPhilRegions", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            Reg.RegionID = vRS("RegionID").ToString()
            Reg.RegionName = vRS("RegionName").ToString()
            Reg.ShortName = vRS("ShortName").ToString()

            GetPhilRegionByID = TranDBResult.Success
        Else
            GetPhilRegionByID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function


    Public Sub SaveActiveCampus(ByVal sCampusName As String)

        SaveSetting(Application.ProductName, "DataSetting", "activecampus", sCampusName)

    End Sub

    Public Function GetActiveCampus() As String

        GetActiveCampus = GetSetting(Application.ProductName, "DataSetting", "activecampus", "---")

    End Function


End Module
