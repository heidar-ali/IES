'==========================================================================================
'Filename:      clsCon.vb
'Type:          MODULE
'Date:          29.MAY.2012
'Notice:        ©2012 i4Link Systems, Inc. All rights reserved.
'
'Purpose:       Main program configuration module

'Programmer:        Philip Cesar B. Garay
'===========================================================================================


Imports MySql.Data.MySqlClient
Imports System.Data.Common
Imports System.Data
Imports System.Windows.Forms
Imports System.IO
Imports Microsoft.VisualBasic.FileIO

Module clsCon
    Public con As New MySqlConnection()
    Public dataBytes() As Byte
    Public tmpStr As String
    Public CnString As String
    Public openedFileStream As System.IO.Stream

    Public CurrentUser As User
    Public CurrentSchoolYear As tSchoolYear

    Public Structure LogRec
        Dim UserName As String
        Dim TimeIn As Date
        Dim TimeOut As Date
        Dim SuccessfullyOut As Boolean
    End Structure

    Public Structure User
        Dim UserID As String
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

    Public Enum TranDBResult
        Success = 1
        NoResult = 0
        Failed = -99

        NotConnected = -1
        NoRecordExist = -2

        InvalidID = -11
        InvalidTitle = -12
        InvalidAlias = -13

        DuplicateID = -21
        DuplicateTitle = -22
        DuplicateCode = -23

        'teacher invalid result
        InvalidTeacherTitle = -201
        InvalidTeacherPassword = -202
        InvalidTeacherFirstName = -203
        InvalidTeacherMiddleName = -204
        InvalidTeacherLastName = -205
        InvalidTeacherContactNumber = -206
        InvalidTeacherAddress = -207


        'section invalid result
        DuplicateTeacherID = -301

        'student
        DuplicateFullName = -402

        'section
        InvalidSectionSectionID = -501
        InvalidSectionCurriculumID = -502
        InvalidSectionTeacherID = -503
        InvalidSectionSectionTitle = -504
        InvalidSectionYearLevelID = -505
        InvalidSectionRoomNumber = -506
        InvalidSectionMinAveGrade = -507
        InvalidSectionMaxAveGrade = -508
        InvalidSectionMaxStudentCount = -509
        InvalidSectionProgramID = -500

        'enrolment
        EnrolmentDuplicateEntryWithInYear = -591
        EnrolmentSchoolYearNotFound = -592
        EnrolmentStudentIDNotFound = -593
        EnrolmentSectionIDNotFound = -594
        EnrolmentInvalidAveGrade = 595

        'subject
        InvalidSubjectSubjectID = -701
        InvalidSubjectSubjectTitle = -702
        InvalidSubjectDepartmentID = -703
        InvalidSubjectCode = -704
        InvalidSubjectDescription = -705
        InvalidSubjectCreditUnits = -706
        InvalidSubjectUnits = -707
        InvalidSubjectLabUnits = -708
        InvalidSubjectLecUnits = -709

        'Subject Area
        InvalidSubjectAreaID = -600
        InvalidSubjectAreaName = -601

        'Subject Mode
        InvalidSubjectModeID = -603
        InvalidSubjectMode = -604

        'grade
        InvalidGradeID = -801
        InvalidGradeEnrolmentID = -802
        InvalidGradeSubjectID = -803
        InvalidGradeGradeValue = -804

        'user
        UserNotExist = -901
        UserDuplicate = -902

        'log
        AlreadyLogIn = -1001
        SuccessIn = 1001

        DuplicateLoginName = -1101
    End Enum

   
    Public Sub writeFileStrData(ByVal MyData As Object, ByVal filePath As String, Optional ByVal transType As String = "", Optional ByVal dataEncoding As String = "")

        Dim Str As String
        Dim fs As FileStream
        Dim tempBytes() As Byte

        tempBytes = Nothing

        If transType = "" Then
            transType = "Append" 'Set default 
        End If

        If dataEncoding = "" Then
            dataEncoding = "ANSI"
        End If

        Try
            Str = CType(MyData, String)
            If dataEncoding = "ANSI" Then
                tempBytes = System.Text.Encoding.Default.GetBytes(Str)
            ElseIf dataEncoding = "Unicode" Then
                tempBytes = System.Text.Encoding.Unicode.GetBytes(Str)
            End If

            fs = New FileStream(filePath, FileMode.Create, FileAccess.Write)
            If transType = "Append" Then
                fs.Seek(0, SeekOrigin.End)
            ElseIf transType = "Overwrite" Then
                fs.Seek(0, SeekOrigin.Begin)
            End If

            fs.Write(tempBytes, 0, tempBytes.Length)
            fs.Close()
        Catch ex As Exception

            MsgBox(ex.Message & vbCrLf & ex.StackTrace)
        End Try

    End Sub

    Public Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        Const PROCEDURE_NAME As String = "Main()"

        Call initProgramPaths()           'prepare the program paths
        Call initProgramDefaults()        'prepare program default settings
        'Call initLicenseInfo           'parse the license info
        Call initDBConfig()               'parse the database configuration
        Call initCompanyInfo()            'parse the company info
        Call prepareDBConnString()        'prepare database connection

        If CheckUser() < 0 Then
            Exit Sub
        End If

        GetDataSettings()
        Application.Run(New MainForm1())
    End Sub
    Private Sub GetDataSettings()
        GetActiveSchoolYear()
    End Sub

    Private Function CheckUser() As Integer
        If UserRecordExist() = False Then
            MsgBox("WARNING: No user account exist.. Please add new user account." & vbNewLine & "HINT: Use Administrator Module to create Accounts", vbExclamation)
            CheckUser = -1
        Else
            CheckUser = 1
        End If
    End Function

    Public Function ShowAdvancedPropertiesDialog(ByRef CSB As DbConnectionStringBuilder) As DialogResult
        Dim frmx As New frmProperties()
        frmx.ConnectionProperties = CSB
        If frmx.ShowDialog() = DialogResult.OK Then
            CSB.ConnectionString = frmx.ConnectionProperties.ConnectionString
            Return DialogResult.OK
        Else
            Return DialogResult.Cancel
        End If
    End Function

    Public Function CheckServer() As Boolean
        Try
            Dim frm As New frmConnector()
            With frm
                .OpenFileDialog1.FileName = Application.StartupPath & "\Config.ini"
                openedFileStream = .OpenFileDialog1.OpenFile()
            End With

            ReDim dataBytes(openedFileStream.Length - 1) 'Init 
            openedFileStream.Read(dataBytes, 0, openedFileStream.Length)
            openedFileStream.Close()
            tmpStr = System.Text.Encoding.Unicode.GetString(dataBytes)

            With frm
                If Len(Split(tmpStr, ":")(0)) > 0 Then
                    CnString = "Server=" & Split(tmpStr, ":")(0) & _
                              ";Port=" & Split(tmpStr, ":")(1) & _
                              ";Database=" & Split(tmpStr, ":")(2) & _
                              ";Uid=" & Split(tmpStr, ":")(3) & _
                              ";Password= " & Split(tmpStr, ":")(4)
                Else
                    CnString = "Server=" & Split(tmpStr, ":")(0) & ";Port=3306;Database=hses;Uid=" & Split(tmpStr, ":")(3) & ";Password=;"

                End If
            End With
            con.ConnectionString = CnString

            con.Open()
            CheckServer = True
        Catch ex As Exception
            CheckServer = False
        End Try
    End Function


End Module
