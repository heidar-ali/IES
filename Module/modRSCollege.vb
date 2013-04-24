Option Explicit On

Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.Strings

Module modRSCollege

    Public Const keyCollege As String = "college"

    Public Structure tCollege
        Dim CollegeID As String
        Dim CollegeCode As String
        Dim CampusID As String
        Dim CollegeName As String
        Dim CollegeDean As String
        Dim DeanID As String
        Dim InActive As Short
    End Structure

    Public Function AddCollege(ByVal newCollege As tCollege) As TranDBResult
        'find duplicate ID
        If CollegeExistByID(newCollege.CollegeID) = TranDBResult.Success Then
            AddCollege = TranDBResult.DuplicateID
            GoTo ReleaseAndExit
        End If

        'find duplicate TITLE
        If CollegeExistByCode(newCollege.CollegeCode, newCollege.CampusID) = TranDBResult.Success Then
            AddCollege = TranDBResult.DuplicateTitle
            GoTo ReleaseAndExit
        End If

        Dim com As New MySqlCommand("INSERT INTO tblColleges(CollegeID,CampusID,CollegeCode,CollegeName,CollegeDean,InActive) VALUES ('" & _
                                    newCollege.CollegeID & "','" & _
                                    newCollege.CampusID & "','" & _
                                    newCollege.CollegeCode & "','" & _
                                    newCollege.CollegeName & "','" & _
                                    newCollege.CollegeDean & "','" & _
                                    newCollege.InActive & "')", clsCon.con)
        com.ExecuteNonQuery()
        AddCollege = TranDBResult.Success


ReleaseAndExit:
        'release
        Exit Function
    End Function

    Public Function EditCollege(ByVal newCollege As tCollege) As TranDBResult

        Dim OldCollege As tCollege

        'check duplicate Code
        If GetCollegeByCode(newCollege.CollegeCode, OldCollege) Then
            Dim com As New MySqlCommand("SELECT * From tblColleges WHERE (((tblColleges.CollegeID)='" & newCollege.CollegeID & "'));", clsCon.con)
            Dim vRS As MySqlDataReader = com.ExecuteReader()
            vRS.Read()
            If Not vRS.HasRows Then
                EditCollege = TranDBResult.InvalidID
                Exit Function
            End If
            vRS.Close()

            Dim com1 As New MySqlCommand("UPDATE tblcolleges SET CollegeCode='" & newCollege.CollegeCode & _
                                         "',CollegeName='" & newCollege.CollegeName & _
                                         "',CollegeDean='" & newCollege.DeanID & _
                                         "',InActive ='" & newCollege.InActive & _
                                         "' WHERE CollegeID ='" & newCollege.CollegeID & "'", clsCon.con)
            com1.ExecuteNonQuery()
            EditCollege = TranDBResult.Success
        End If
    End Function


    Public Function GetCollegeByProgramID(ByVal sProgramID As String, ByRef vCollege As tCollege) As TranDBResult
        Dim com As New MySqlCommand("SELECT *  FROM tblPrograms WHERE (((tblPrograms.ProgID)='" & sProgramID & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            vCollege.CollegeID = (vRS("CollegeID").ToString())
            GetCollegeByProgramID = TranDBResult.Success
        Else
            GetCollegeByProgramID = TranDBResult.Failed
        End If
        'release
        vRS.Close()
    End Function

    Public Function CollegeRecordExist() As TranDBResult
        Dim com As New MySqlCommand("SELECT * FROM tblColleges", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            CollegeRecordExist = TranDBResult.Success
        Else
            CollegeRecordExist = TranDBResult.Failed
        End If
        vRS.Close()
    End Function

    Public Function CollegeExistByID(ByVal sCollegeID As String) As TranDBResult

        Dim com As New MySqlCommand("SELECT * From tblColleges WHERE tblColleges.CollegeID='" & sCollegeID & "'", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then

            CollegeExistByID = TranDBResult.Success
        Else
            CollegeExistByID = TranDBResult.Failed
        End If
        'release
        vRS.Close()
    End Function
    Public Function CollegeExistByCode(ByVal sCollegeCode As String, ByVal sCampusID As String) As TranDBResult

        Dim com As New MySqlCommand("SELECT * From tblColleges WHERE tblColleges.CollegeCode='" & sCollegeCode & "' AND tblColleges.CampusID='" & sCampusID & "';;", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            CollegeExistByCode = TranDBResult.Success
        Else
            CollegeExistByCode = TranDBResult.Failed
        End If
        'release
        vRS.Close()
    End Function

    Public Function GetCollegeByCode(ByVal sCollegeCode As String, ByRef vCollege As tCollege) As TranDBResult

        Dim com As New MySqlCommand("SELECT *  FROM tblColleges WHERE (((tblColleges.CollegeCode)='" & sCollegeCode & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows Then
            vCollege.CollegeID = (vRS("CollegeID").ToString())
            vCollege.CollegeCode = (vRS("CollegeCode").ToString())
            vCollege.CollegeName = (vRS("CollegeName").ToString())
            vCollege.CollegeDean = (vRS("CollegeDean").ToString())
            vCollege.InActive = CShort(vRS("InActive").ToString())
            vCollege.CampusID = (vRS("CampusID").ToString())
            GetCollegeByCode = TranDBResult.Success
        Else
            GetCollegeByCode = TranDBResult.Failed
        End If

        'release
        vRS.Close()
    End Function
    Public Function GetCollegeByID(ByVal sCollegeID As String, ByRef vCollege As tCollege) As TranDBResult

        Dim com As New MySqlCommand("SELECT *  FROM tblColleges WHERE (((tblColleges.CollegeID)='" & sCollegeID & "'));", clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = True Then
            vCollege.CollegeID = (vRS("CollegeID").ToString())
            vCollege.CollegeCode = (vRS("CollegeCode").ToString())
            vCollege.CollegeName = (vRS("CollegeName").ToString())
            vCollege.CollegeDean = (vRS("CollegeDean").ToString())
            vCollege.InActive = CShort(vRS("InActive").ToString())
            vCollege.CampusID = (vRS("CampusID").ToString())
            GetCollegeByID = TranDBResult.Success
        Else
            GetCollegeByID = TranDBResult.Failed
        End If

        'release
        vRS.Close()
    End Function
    Public Function ExecuteDeleteCollege(ByVal sCollegeID As String) As TranDBResult

        'check if record exist and if it is edited by other user
        If MsgBox("WARNING:" & vbNewLine & _
            "Deleting this COLLEGE will affect all other record" & vbNewLine & vbNewLine & _
            "Delete this record anyway?", vbQuestion + vbYesNo, Application.ProductName) = vbYes Then

            If DeleteCollege(sCollegeID) = TranDBResult.Success Then
                MsgBox("COLLEGE entry and other related record succesfully deleted.", vbInformation)
                ExecuteDeleteCollege = TranDBResult.Success
            Else
                MsgBox("Deleting COLLEGE entry went failed.", vbExclamation)
                ExecuteDeleteCollege = TranDBResult.Failed
            End If
        Else
            ExecuteDeleteCollege = TranDBResult.Failed
        End If
    End Function

    Public Function DeleteCollege(ByVal sCollegeID As String) As TranDBResult
        DeleteCollege = TranDBResult.Failed

        Dim com As New MySqlCommand("DELETE FROM tblColleges WHERE (((tblColleges.CollegeCode)='" & sCollegeID & "'));", clsCon.con)
        com.ExecuteNonQuery()
        DeleteCollege = TranDBResult.Success

    End Function


    Public Function GetNewCollegeID(ByRef sNewCollegeID As String) As TranDBResult
        Dim sSQL As String
        Dim NewDNumber As Integer


        'default
        GetNewCollegeID = TranDBResult.Failed

        sSQL = "SELECT CONCAT(LEFT('0',2-Length(Count(*)+1)),'',Count(*)+1) AS NewID FROM tblColleges;"

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        vRS.Read()
        If vRS.HasRows = False Then
            GetNewCollegeID = TranDBResult.Failed
            Exit Function
        Else
            sNewCollegeID = vRS("NewID").ToString()
            GetNewCollegeID = TranDBResult.Success
        End If
        vRS.Close()

        While CollegeExistByID(sNewCollegeID) = TranDBResult.Success
            NewDNumber = Val(Right(sNewCollegeID, 2)) + 1
            sNewCollegeID = Left("0", 2) & NewDNumber
        End While

    End Function

    Public Function SaveCollegePhoto(ByVal Cand As tCollege, Photo As PictureBox) As TranDBResult

        If CollegeExistByID(Cand.CollegeID) = TranDBResult.Success Then
            Dim FileSize As UInt32

            Dim mstream As New System.IO.MemoryStream()
            Photo.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim arrImage() As Byte = mstream.GetBuffer()

            FileSize = mstream.Length
            mstream.Close()
            Dim com As New MySqlCommand("UPDATE tblColleges SET CollegeLogo=@Pic WHERE CollegeID='" & Cand.CollegeID & "'", con)
            com.Parameters.AddWithValue("@Pic", arrImage)

            com.ExecuteNonQuery()
            com.Parameters.Clear()

            SaveCollegePhoto = TranDBResult.Success
        Else
            SaveCollegePhoto = TranDBResult.Failed
        End If
    End Function
End Module
