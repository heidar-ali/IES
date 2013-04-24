'==========================================================================================
'Filename:      modScholarship.vb
'Type:          MODULE
'Date:          13.AUGUST.2012
'Notice:        ©2012 i4Link Systems, Inc. All rights reserved.
'
'Purpose:       Scholarship Grant Templates Configuration,Scholarship Providers, List of Scholars
'               Tagging of Scholarship/Financial Aids/Guarantor

'Programmer:        Philip Cesar B. Garay
'===========================================================================================

Option Explicit On

Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Module modScholarship

    Public Structure ScholarshipProviders
        Dim SchoProviderID As Integer
        Dim ProvCode As String
        Dim ProvAcronym As String
        Dim ProvName As String
        Dim ProvShort As String
        Dim ProvGroupID As Integer
        Dim InActive As Short
        Dim Remarks As String
        Dim CreatedBy As String
        Dim DateCreated As Date
        Dim ModifiedBy As String
        Dim DateModified As Date
        Dim IsAutoCredit As Short
    End Structure

    Public Structure ScholarshipProviderGroup
        Dim ProvGroupID As Integer
        Dim ProvGroupDesc As String
        Dim ProvGroupExplain As String
    End Structure

    Public Structure ScholarshipGrantTemplates
        Dim GrantTemplateID As Integer
        Dim TermID As Integer
        Dim SchoProviderID As Integer
        Dim TemplateCode As String
        Dim ShortName As String
        Dim Description As String
        Dim ModifiedBy As String
        Dim DateModified As Date
    End Structure

    Public Structure ScholarshipGrantTemplate_Details
        Dim DetailID As Integer
        Dim GrantTemplateID As Integer
        Dim AcctID As Integer
        Dim Amount As String
        Dim Percentage As Double
        Dim Remarks As String
        Dim ModifiedBy As String
        Dim DateModified As Date
    End Structure

    Public Structure Scholars
        Dim IndexID As Integer
        Dim TermID As Integer
        Dim StudentNo As String
        Dim SchoProviderID As Integer
    End Structure

    '================================= Scholarship Provider ==============================
    Public Function ScholarshipProviderRecordExists() As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblSchoProviders", con)
        Dim vrs As MySqlDataReader = com.ExecuteReader
        vrs.Read()
        If vrs.HasRows Then
            ScholarshipProviderRecordExists = TranDBResult.Success
        Else
            ScholarshipProviderRecordExists = TranDBResult.Failed
        End If
        vrs.Close()
    End Function

    Public Function ScholarshipProviderExistByID(ByVal SchoProviderID As Integer) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblSchoProviders WHERE SchoProviderID='" & SchoProviderID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            ScholarshipProviderExistByID = TranDBResult.Success
        Else
            ScholarshipProviderExistByID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function ScholarshipProviderExistByCode(ByVal ProvCode As String) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblSchoProviders WHERE ProvCode='" & ProvCode & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            ScholarshipProviderExistByCode = TranDBResult.Success
        Else
            ScholarshipProviderExistByCode = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function GetScholarshipProviderByID(ByVal SchoProviderID As String, ByRef Scho As ScholarshipProviders) As TranDBResult
        On Error Resume Next
        Dim com As New MySqlCommand("SELECT * FROM tblSchoProviders WHERE SchoProviderID='" & SchoProviderID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            Scho.ProvAcronym = vRS("ProvAcronym").ToString()
            Scho.ProvCode = vRS("ProvCode").ToString()
            Scho.SchoProviderID = vRS("SchoProviderID").ToString()
            Scho.ProvShort = vRS("ProvShort").ToString()
            Scho.ProvName = vRS("ProvName").ToString()
            Scho.InActive = vRS("InActive").ToString()
            Scho.Remarks = vRS("Remarks").ToString()
            Scho.CreatedBy = vRS("CreatedBy").ToString()
            Scho.DateCreated = vRS("DateCreated").ToString()
            Scho.ModifiedBy = vRS("ModifiedBy").ToString()
            Scho.IsAutoCredit = vRS("IsAutoCredit").ToString()
            Scho.ProvGroupID = vRS("ProvGroupID").ToString()
            'Scho.DateModified = vRS("DateModified").ToString()


            GetScholarshipProviderByID = TranDBResult.Success
        Else
            GetScholarshipProviderByID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function SaveScholarshipProvider(ByVal Scho As ScholarshipProviders) As TranDBResult

        If ScholarshipProviderExistByID(Scho.SchoProviderID) = TranDBResult.Success Then
            SaveScholarshipProvider = TranDBResult.DuplicateID
        End If

        Dim com As New MySqlCommand("INSERT INTO tblSchoProviders(ProvCode,ProvAcronym,ProvName,ProvShort,ProvGroupID,Remarks,InActive,CreatedBy,DateCreated,IsAutoCredit) VALUES ('" & _
                                    Scho.ProvCode & "','" & Scho.ProvAcronym & "','" & Scho.ProvName & "','" & Scho.ProvShort & "','" & Scho.ProvGroupID & "','" & Scho.Remarks & "','" & Scho.InActive & "','" & Scho.CreatedBy & "',@Date,'" & Scho.IsAutoCredit & "')", con)
        com.Parameters.Add("@Date", MySqlDbType.Date).Value = Scho.DateCreated
        com.ExecuteNonQuery()
        com.Parameters.Clear()

        SaveScholarshipProvider = TranDBResult.Success
    End Function

    Public Function UpdateScholarshipProvider(ByVal Scho As ScholarshipProviders) As TranDBResult
        If ScholarshipProviderExistByID(Scho.SchoProviderID) = TranDBResult.Success Then
            Dim com As New MySqlCommand("UPDATE tblSchoProviders SET ProvCode='" & Scho.ProvCode & "',ProvName='" & Scho.ProvName & "',ProvAcronym='" & Scho.ProvAcronym & "', ProvShort='" & Scho.ProvShort & _
                                        "',ProvGroupID='" & Scho.ProvGroupID & "',InActive='" & Scho.InActive & "',Remarks='" & Scho.Remarks & "',CreatedBy='" & Scho.CreatedBy & _
                                        "', DateCreated=@Date,IsAutoCredit='" & Scho.IsAutoCredit & "' WHERE SchoProviderID='" & Scho.SchoProviderID & "'", con)
            com.Parameters.Add("@Date", MySqlDbType.Date).Value = Scho.DateCreated
            com.ExecuteNonQuery()
            com.Parameters.Clear()

            UpdateScholarshipProvider = TranDBResult.Success
        Else
            UpdateScholarshipProvider = TranDBResult.Failed
        End If
    End Function


    Public Function ExecuteDeleteScholarshipProvider(ByVal SchoProviderID As String) As TranDBResult

        'check if record exist and if it is edited by other user
        If MsgBox("WARNING:" & vbNewLine & _
            "Deleting this Scholarship Provider entry will affect all other record" & vbNewLine & vbNewLine & _
            "Delete this record anyway?", vbQuestion + vbYesNo, Application.ProductName) = vbYes Then

            If DeleteScholarshipProvider(SchoProviderID) = TranDBResult.Success Then
                MsgBox("Scholarship Provider entry and other related record succesfully deleted.", vbInformation)
                ExecuteDeleteScholarshipProvider = TranDBResult.Success
            Else
                MsgBox("Deleting Scholarship Provider entry went failed.", vbExclamation)
                ExecuteDeleteScholarshipProvider = TranDBResult.Failed
            End If
        Else
            ExecuteDeleteScholarshipProvider = TranDBResult.Failed
        End If
    End Function

    Public Function DeleteScholarshipProvider(ByVal SchoProviderID As Integer) As TranDBResult
        Try
            Dim com As New MySqlCommand("DELETE FROM tblSchoProviders WHERE SchoProviderID='" & SchoProviderID & "'", con)
            com.ExecuteNonQuery()
            DeleteScholarshipProvider = TranDBResult.Success
        Catch
            DeleteScholarshipProvider = TranDBResult.Failed
        End Try
    End Function
    '================================== SCHOLARSHIP PROVIDER GROUPS ===========================================

    Public Function SchoProviderRecordExist() As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblSchoProvider_Groups", con)
        Dim rs As MySqlDataReader = com.ExecuteReader
        rs.Read()
        If rs.HasRows Then
            SchoProviderRecordExist = TranDBResult.Success
        Else
            SchoProviderRecordExist = TranDBResult.Failed
        End If
        rs.Close()
    End Function

    Public Function GetSchoProviderGroupByGroupID(ByVal ProvGroupID As Integer, ByRef Prov As ScholarshipProviderGroup) As TranDBResult
        Dim com As New MySqlCommand("SELECT *  FROM tblSchoProvider_Groups WHERE ProvGroupID='" & ProvGroupID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            Prov.ProvGroupID = vRS("ProvGroupID").ToString()
            Prov.ProvGroupDesc = vRS("ProvGroupDesc").ToString()
            Prov.ProvGroupExplain = vRS("ProvGroupExplain").ToString()
            GetSchoProviderGroupByGroupID = TranDBResult.Success
        Else
            GetSchoProviderGroupByGroupID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function


    '========================================= Scholarship Grant Template =======================================

    Public Function ScholarshipGrantTemplateRecordExist() As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblSchoGrantTemplates", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            ScholarshipGrantTemplateRecordExist = TranDBResult.Success
        Else
            ScholarshipGrantTemplateRecordExist = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function SchoGrantTemplateExistByID(ByVal GrantTemplatID As Integer, Optional ByVal TermID As Integer = 1) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblSchoGrantTemplates WHERE GrantTemplateID='" & GrantTemplatID & "' AND TermID='" & TermID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            SchoGrantTemplateExistByID = TranDBResult.Success
        Else
            SchoGrantTemplateExistByID = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function SchoGrantTemplateExistByCode(ByVal GrantTemplateCode As String, ByVal TermID As Integer) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblSchoGrantTemplates WHERE TemplateCode='" & GrantTemplateCode & "' AND TermID='" & TermID & "'", con)
        Dim vRS As MySqlDataReader = com.ExecuteReader
        vRS.Read()
        If vRS.HasRows Then
            SchoGrantTemplateExistByCode = TranDBResult.Success
        Else
            SchoGrantTemplateExistByCode = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function GetSchoGrantTemplateByID(ByVal GrantTemplateID As Integer, ByRef Temp As ScholarshipGrantTemplates) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblSchoGrantTemplates WHERE GrantTemplateID ='" & GrantTemplateID & "'", con)
        Dim rs As MySqlDataReader = com.ExecuteReader
        rs.Read()
        If rs.HasRows Then
            Temp.GrantTemplateID = rs("GrantTemplateID").ToString()
            Temp.SchoProviderID = rs("SchoProviderID").ToString()
            Temp.ShortName = rs("ShortName").ToString()
            Temp.Description = rs("Description").ToString()
            Temp.TemplateCode = rs("TemplateCode").ToString()
            Temp.TermID = rs("TermID").ToString()
            GetSchoGrantTemplateByID = TranDBResult.Success
        Else
            GetSchoGrantTemplateByID = TranDBResult.Failed
        End If
        rs.Close()
    End Function

    Public Function SaveScholarshipGrantTemplate(ByVal Scho As ScholarshipGrantTemplates) As TranDBResult
        If SchoGrantTemplateExistByID(Scho.SchoProviderID, Scho.TermID) = TranDBResult.Success Then
            If SchoGrantTemplateExistByCode(Scho.TemplateCode, Scho.TermID) = TranDBResult.Success Then
                SaveScholarshipGrantTemplate = TranDBResult.DuplicateCode
                Exit Function
            End If

            Dim com As New MySqlCommand("INSERT INTO tblSchoGrantTemplates(TermID,SchoProviderID,TemplateCode,ShortName,Description) VALUES ('" & Scho.TermID & _
                                        "','" & Scho.SchoProviderID & "','" & Scho.TemplateCode & "','" & Scho.ShortName & "','" & Scho.Description & "')", con)
            com.ExecuteNonQuery()

            SaveScholarshipGrantTemplate = TranDBResult.Success

        End If
    End Function

    Public Function UpdateScholarshipGrantTemplate(ByVal Scho As ScholarshipGrantTemplates) As TranDBResult
        If SchoGrantTemplateExistByID(Scho.GrantTemplateID, Scho.TermID) = TranDBResult.Success Then
            Dim com As New MySqlCommand("UPDATE tblSchoGrantTemplates SET TermID='" & Scho.TermID & "',SchoProviderID='" & Scho.SchoProviderID & _
                                        "',TemplateCode='" & Scho.TemplateCode & "',ShortName='" & Scho.ShortName & "',Description='" & Scho.Description & _
                                        "',LastModifiedBy='" & Scho.ModifiedBy & "',LastModifiedDate='" & Scho.DateModified & _
                                        "' WHERE GrantTemplateID='" & Scho.GrantTemplateID & "'", con)
            com.ExecuteNonQuery()
            UpdateScholarshipGrantTemplate = TranDBResult.Success
        Else
            UpdateScholarshipGrantTemplate = TranDBResult.Failed
        End If
    End Function

    Public Function ExecuteDeleteSchoGrantTemplate(ByVal GrantTemplateID As String) As TranDBResult

        'check if record exist and if it is edited by other user
        If MsgBox("WARNING:" & vbNewLine & _
            "Deleting this SCHOLARSHIP GRANT TEMPLATE entry will affect all other record" & vbNewLine & vbNewLine & _
            "Delete this record anyway?", vbQuestion + vbYesNo, Application.ProductName) = vbYes Then

            If DeleteSchoGrantTemplate(GrantTemplateID) = TranDBResult.Success Then
                MsgBox("SCHOLARSHIP GRANT TEMPLATE entry and other related record succesfully deleted.", vbInformation)
                ExecuteDeleteSchoGrantTemplate = TranDBResult.Success
            Else
                MsgBox("Deleting SCHOLARSHIP GRANT TEMPLATE entry went failed.", vbExclamation)
                ExecuteDeleteSchoGrantTemplate = TranDBResult.Failed
            End If
        Else
            ExecuteDeleteSchoGrantTemplate = TranDBResult.Failed
        End If
    End Function

    Public Function DeleteSchoGrantTemplate(ByVal GrantTemplateID As Integer) As TranDBResult
        Try
            Dim com As New MySqlCommand("DELETE FROM tblSchoGrantTemplates WHERE GrantTemplateID='" & GrantTemplateID & "'", con)
            com.ExecuteNonQuery()
            DeleteSchoGrantTemplate = TranDBResult.Success
        Catch
            DeleteSchoGrantTemplate = TranDBResult.Failed
        End Try
    End Function

    '================================ SCHOLARSHIP GRANT TEMPLATE DETAILS =========================================

    Public Function SchoGrantTemplateDetailsExistByAcctID(ByVal GrantTemplateID As Integer, AcctID As Integer) As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblSchoGrantTemplate_Details WHERE GrantTemplateID='" & GrantTemplateID & "' AND AcctID ='" & AcctID & "'", con)
        Dim rs As MySqlDataReader = com.ExecuteReader
        rs.Read()
        If rs.HasRows Then
            SchoGrantTemplateDetailsExistByAcctID = TranDBResult.Success
        Else
            SchoGrantTemplateDetailsExistByAcctID = TranDBResult.Failed
        End If
        rs.Close()
    End Function


    Public Function SaveGrantTemplateDetails(ByVal Temp As ScholarshipGrantTemplate_Details, ByVal TermID As Integer) As TranDBResult
        If SchoGrantTemplateExistByID(Temp.GrantTemplateID, TermID) = TranDBResult.Success Then
            Dim com As New MySqlCommand("INSERT INTO tblSchoGrantTemplate_Details(GrantTemplateID,AcctID,Amount,Percentage,Remarks) VALUES ('" & Temp.GrantTemplateID & _
                                        "','" & Temp.AcctID & "','" & Temp.Amount & "','" & Temp.Percentage & "','" & Temp.Remarks & "')", con)
            com.ExecuteNonQuery()

            SaveGrantTemplateDetails = TranDBResult.Success

        Else
            SaveGrantTemplateDetails = TranDBResult.Failed
        End If
    End Function

    Public Function UpdateGrantTemplateDetails(ByVal Temp As ScholarshipGrantTemplate_Details, ByVal TermID As Integer) As TranDBResult
        If SchoGrantTemplateExistByID(Temp.GrantTemplateID, TermID) = TranDBResult.Success Then
            Dim com As New MySqlCommand("UPDATE tblSchoGrantTemplate_Details SET Amount='" & Temp.Amount & "', Percentage='" & Temp.Percentage & "', Remarks='" & Temp.Remarks & _
                                        "' WHERE DetailID='" & Temp.GrantTemplateID & "' AND AcctID='" & Temp.AcctID & "'", con)
            com.ExecuteNonQuery()

            UpdateGrantTemplateDetails = TranDBResult.Success
        Else
            UpdateGrantTemplateDetails = TranDBResult.Failed
        End If
    End Function

    Public Function ExecuteDeleteSchoGrantTemplateDetails(ByVal DetailID As String) As TranDBResult

        'check if record exist and if it is edited by other user
        If MsgBox("WARNING:" & vbNewLine & _
            "Deleting this SCHOLARSHIP GRANT TEMPLATE ACCOUNT entry will affect all other record" & vbNewLine & vbNewLine & _
            "Delete this record anyway?", vbQuestion + vbYesNo, Application.ProductName) = vbYes Then

            If DeleteSchoGrantTemplateDetails(DetailID) = TranDBResult.Success Then
                MsgBox("SCHOLARSHIP GRANT TEMPLATE ACCOUNT entry and other related record succesfully deleted.", vbInformation)
                ExecuteDeleteSchoGrantTemplateDetails = TranDBResult.Success
            Else
                MsgBox("Deleting SCHOLARSHIP GRANT TEMPLATE ACCOUNT entry went failed.", vbExclamation)
                ExecuteDeleteSchoGrantTemplateDetails = TranDBResult.Failed
            End If
        Else
            ExecuteDeleteSchoGrantTemplateDetails = TranDBResult.Failed
        End If
    End Function

    Public Function DeleteSchoGrantTemplateDetails(ByVal DetailID As Integer) As TranDBResult
        Try
            Dim com As New MySqlCommand("DELETE FROM tblSchoGrantTemplate_Details WHERE DetailID='" & DetailID & "'", con)
            com.ExecuteNonQuery()
            DeleteSchoGrantTemplateDetails = TranDBResult.Success
        Catch
            DeleteSchoGrantTemplateDetails = TranDBResult.Failed
        End Try
    End Function

End Module
