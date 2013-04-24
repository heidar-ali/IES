Option Explicit On

Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data
Imports System.Drawing
Imports System.Diagnostics

Module modFunction
    Public DBPath As String

    Private Const MODULE_NAME As String = "Main Module"
    Public Const PROJECT_NAME As String = "i 4Link Systems Library Management System"
    Public Const MAJORVERSION As String = "version 1.0"
    Public Const PRODUCT_COMPANY_NAME As String = "i 4Link Systems InCorporation"
    Public Const i4ls_CEOPRESIDENT As String = "Joel Harvey V. Agsaoay"

    Public CONFIG_INI_FILE As String       'the configuration file
    Public LICENSE_FILE As String       'the license file
    Public ERRORS_LOG_FILE As String       'the errors-log file
    Public ACCESS_LOG_FILE As String       'access log file

    Public DEFAULT_DATABASE As String
    Public MySQL_SERVER As String
    Public DB_USERID As String
    Public DB_CONNECTION_STRING As String
    Public DB_PORT As String
    Public DB_PASSWORD As String

    Public IsNTAuthentication As Boolean
    Public IsIPConnection As Boolean

    Public COPYRIGHT_NOTICE As String       'the copyright string notice

    Public CLIENT_COMPUTER_NAME As String       'the client's computer name
    Public CLIENT_COMPUTER_USERID As String       'the client's Window's Authenticated UserID

    Public SYSTEM_NAME As String   'Name of the System

    Public COMPANY_NAME As String
    Public COMPANY_ADDRESS As String
    Public COMPANY_WEBSITE As String
    Public COMPANY_INFO_EMAIL As String
    Public COMPANY_SUPPORT_EMAIL As String

    Public Enum FormState
        addFormState = 1
        updateFormState = 2
        readFormState = 3
        deleteFormState = 4
    End Enum


    Public Enum YearTerm
        Semestral = 2
        Trimestral = 3
        YearlyHS = 1
        YearlyElem = 1
    End Enum

    Public Enum ImageState
        WithImage = 1
        NoImage = 2
    End Enum

    Sub initProgramPaths()

        CONFIG_INI_FILE = Application.StartupPath & "\config.ini"                                         'the main configuration .ini file
        ' "C:\Program Files\Princetech Solutions\ESv2\config.ini"                                   'the main configuration .ini file

        LICENSE_FILE = Application.StartupPath & ReadINI("Paths", "LicenseFile", CONFIG_INI_FILE)          'the license file
        ERRORS_LOG_FILE = Application.StartupPath & ReadINI("Paths", "ErrorsLogFile", CONFIG_INI_FILE)     'the errors log file
        ACCESS_LOG_FILE = Application.StartupPath & ReadINI("Paths", "AccessLogFile", CONFIG_INI_FILE)     'the access log file

    End Sub

    '====================================================================
    ' This procedure prepares the default variables used in the program
    '====================================================================

    Sub initProgramDefaults()

        Const PROCEDURE_NAME As String = "::initProgramDefaults()"

        On Error GoTo ErrorHandler

        COPYRIGHT_NOTICE = Application.CompanyName & vbNewLine & "All rights reserved. Tiano-Kalambagohan St., Cagayan de Oro City, PHILIPPINES"


ErrorHandler:

        If (Err.Number <> 0) Then
            DisplayErrorMsg(MODULE_NAME, PROCEDURE_NAME, Err.Number, Err.Description)                                 'alert the error message

            Err.Clear()           'clear the error message buffer

            Exit Sub            'exit this procedure

        End If

    End Sub

    '======================================================
    ' This procedure will parse the database configuration
    '======================================================
    Sub initDBConfig()

        Const PROCEDURE_NAME As String = "::initDBConfig()"

        MySQL_SERVER = ReadINI("Database", "MySQLServer", CONFIG_INI_FILE)

        DEFAULT_DATABASE = ReadINI("Database", "DefaultDB", CONFIG_INI_FILE)

        DB_USERID = (ReadINI("Database", "UID", CONFIG_INI_FILE))

        DB_PORT = (ReadINI("Database", "Port", CONFIG_INI_FILE))

        DB_PASSWORD = (ReadINI("Database", "Password", CONFIG_INI_FILE))

        DB_CONNECTION_STRING = (ReadINI("Database", "ConnectionString", CONFIG_INI_FILE))
    End Sub


    Public Sub prepareDBConnString()

        '----------------------------
        ' Reset
        '----------------------------
        Dim strServer As String
        Dim strDatabase As String
        Dim strUserID As String
        Dim strPassword As String
        Dim strPort As String

        '----------------------------
        ' Init DB Config
        '----------------------------
        'Call initDBConfig                                                       'fetch all public-database-related variables

        '----------------------------
        ' Connection String
        '----------------------------

        'If Check1.Value = vbChecked Then                                        'Use Windows NT authentication using the network login ID.
        On Error GoTo prepareDBConnString_Error

        strServer = "Server=" & MySQL_SERVER & ";"                          'the .NET Mysql Connector
        strDatabase = "Database=" & DEFAULT_DATABASE & ";"                  'default Database
        strPort = "Port=" & DB_PORT & ";"                                   'Database Port
        strUserID = "UID=" & DB_USERID & ";"                                'database user
        strPassword = "Password=" & DB_PASSWORD & ";"                       'database password


        DB_CONNECTION_STRING = strServer & strDatabase & strPort & strUserID & strPassword

        con.ConnectionString = DB_CONNECTION_STRING
        con.Open()

        On Error GoTo 0
        Exit Sub

prepareDBConnString_Error:

        MsgBox("Error " & Err.Number & " (" & Err.Description & ") in procedure prepareDBConnString of Module mod_Main")
        End
    End Sub

    Sub initCompanyInfo()

        Const PROCEDURE_NAME As String = "::initCompanyInfo()"

        COMPANY_WEBSITE = ReadINI("CompanyInfo", "URL", CONFIG_INI_FILE)
        COMPANY_INFO_EMAIL = ReadINI("CompanyInfo", "Info", CONFIG_INI_FILE)
        COMPANY_SUPPORT_EMAIL = ReadINI("CompanyInfo", "Support", CONFIG_INI_FILE)

        'Debug.Print PROCEDURE_NAME & " completed without errors...."

    End Sub

    '=============================================================
    ' This procedure will strip-off any single quote character
    ' and the ampersand symbol
    '=============================================================

    Function Strip(ByVal pString As String) As String

        On Error Resume Next

        Dim strResult As String

        strResult = Replace(pString, "'", "''")         'replace all single-quotes with double-single-quote

        strResult = Replace(strResult, "&", "&&")       'replace all ampersand with double-ampersand

        Strip = Trim(strResult)

    End Function

    Function logTransaction(ByVal pModule As String, ByVal pAction As String, Optional ByVal pParameters As String = "") As Long


        Const PROCEDURE_NAME = "LogTransaction()"

        On Error GoTo ErrorHandler

        Dim lngRecordsAffected As Long          'number of records affected during the insert
        Dim strDML As String                    'the data manipulation language

        'build the DML statement
        strDML = "INSERT INTO AS_TransactionsLog (EventDate, UserID, ComputerName, WhichModule, TheAction, Parameters) VALUES (GETDATE(),'" & CurrentUser.UserID & "', HOSTNAME(),'" & Trim$(pModule) & "','" & Strip(Trim$(pAction)) & "', '" & Strip(Trim$(pParameters)) & "')"

        Dim com As New MySqlCommand(strDML, con)
        com.ExecuteNonQuery()

        logTransaction = lngRecordsAffected                          'return the result

        Debug.Print("Transaction:= " & pModule & " " & pAction & " " & pParameters & " successfully recorded in the TransactionsLog.....")

        Exit Function

ErrorHandler:

        If (Err.Number <> 0) Then

            DisplayErrorMsg("Module sub_Main()", PROCEDURE_NAME, Err.Number, Err.Description)

            Err.Clear()           'clear the error message buffer

            Exit Function

        End If

    End Function

    Public Sub GetPhoto(ByVal sSQL As String, ByRef Pic As PictureBox)
        On Error GoTo err
        Dim adapter As New MySqlDataAdapter
        adapter.SelectCommand = New MySqlCommand(sSQL, con)
        Dim Data As New DataTable
        Dim commandbuild As New MySqlCommandBuilder(adapter)
        adapter.Fill(Data)

        Dim lb() As Byte = Data.Rows(0).Item(0)
        Dim lstr As New System.IO.MemoryStream(lb)
        Pic.Image = Image.FromStream(lstr)
        Pic.SizeMode = PictureBoxSizeMode.StretchImage
        lstr.Close()

        Exit Sub

err:
        Pic.Image = Nothing
        Debug.Print(Err.Number & " - " & Err.Description)
        'DisplayErrorMsg("modFunction", "GetPhoto", Err.Number, Err.Description)
    End Sub


    Public Sub fillCombo(ByVal cmb As ComboBox, ByVal sSQL As String)
        Dim Com As New MySqlCommand(sSQL, con)
        Dim reader As MySqlDataReader = Com.ExecuteReader()
        cmb.Items.Clear()
        While reader.Read()
            cmb.Items.AddRange(New Object() {reader(0).ToString()})
        End While
        reader.Close()
    End Sub

    Public Sub fillComboAcademicMajors(ByVal cmb As ComboBox, ByVal sSQL As String)
        Dim Com As New MySqlCommand(sSQL, con)
        Dim reader As MySqlDataReader = Com.ExecuteReader()
        cmb.Items.Clear()
        cmb.Items.Add("[All Major Study, If any]")
        While reader.Read()
            cmb.Items.AddRange(New Object() {reader(0).ToString()})
        End While
        reader.Close()
    End Sub
    Public Sub fillToolStripCombo(ByVal cmb As ToolStripComboBox, ByVal sSQL As String)
        Dim Com As New MySqlCommand(sSQL, con)
        Dim reader As MySqlDataReader = Com.ExecuteReader()
        cmb.Items.Clear()
        While reader.Read()
            cmb.Items.AddRange(New Object() {reader(0).ToString()})
        End While
        reader.Close()
    End Sub
    Public Sub fillMultiColumnCombo1(ByVal cmb As MTGCComboBox, ByVal sSQL As String)
        Dim Com As New MySqlCommand(sSQL, con)
        Dim reader As MySqlDataReader = Com.ExecuteReader()
        cmb.Items.Clear()
        Do While reader.Read()
            Dim cbo As New MTGCComboBoxItem(reader(0).ToString())
            cmb.Items.AddRange(New MTGCComboBoxItem() {cbo})
        Loop
        cmb.SelectedIndex = -1
        cmb.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        reader.Close()
    End Sub

    Public Sub fillMultiColumnCombo2(ByVal cmb As MTGCComboBox, ByVal sSQL As String)
        Dim Com As New MySqlCommand(sSQL, con)
        Dim reader As MySqlDataReader = Com.ExecuteReader()
        cmb.Items.Clear()
        Do While reader.Read()
            Dim cbo As New MTGCComboBoxItem(reader(0).ToString(), reader(1).ToString())
            cmb.Items.AddRange(New MTGCComboBoxItem() {cbo})
        Loop
        cmb.SelectedIndex = -1
        cmb.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        reader.Close()
    End Sub

    Public Sub fillMultiColumnCombo3(ByVal cmb As MTGCComboBox, ByVal sSQL As String)
        Dim Com As New MySqlCommand(sSQL, con)
        Dim reader As MySqlDataReader = Com.ExecuteReader()
        cmb.Items.Clear()
        Do While reader.Read()
            Dim cbo As New MTGCComboBoxItem(reader(0).ToString(), reader(1).ToString(), reader(2).ToString())
            cmb.Items.AddRange(New MTGCComboBoxItem() {cbo})
        Loop
        cmb.SelectedIndex = -1
        cmb.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        reader.Close()
    End Sub

    Public Sub fillMultiColumnCombo4(ByVal cmb As MTGCComboBox, ByVal sSQL As String)
        Dim Com As New MySqlCommand(sSQL, con)
        Dim reader As MySqlDataReader = Com.ExecuteReader()
        cmb.Items.Clear()
        Do While reader.Read()
            Dim cbo As New MTGCComboBoxItem(reader(0).ToString(), reader(1).ToString(), reader(2).ToString(), reader(3).ToString())
            cmb.Items.AddRange(New MTGCComboBoxItem() {cbo})
        Loop
        cmb.SelectedIndex = -1
        cmb.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        reader.Close()
    End Sub

    Public Function CheckTextBox(ByRef txt As TextBox, Optional ByVal sMSG As String = "TextBox", Optional ByVal ShowMSG As Boolean = True, Optional ByVal MinimumChar As Integer = 1) As Boolean
        On Error Resume Next
        If Len(Trim(txt.Text)) < MinimumChar Then

            If ShowMSG Then
                MsgBox(sMSG, vbExclamation)
            End If

            txt.Text = ""
            txt.Focus()

            CheckTextBox = False
        Else
            CheckTextBox = True
        End If
    End Function

    Public Sub FillListView(ByVal sSQL As String, ByRef ListView As ListView, Optional ByVal ShowIcon As Boolean = False, Optional ByVal IconNo As Integer = 0) ' Fill up Listview with data from tables
        Dim c As Integer

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()

        ListView.Items.Clear()
        Do While vRS.Read()
            Dim lv As New ListViewItem(vRS(0).ToString())

            For c = 1 To vRS.FieldCount - 1
                lv.SubItems.Add(vRS.Item(c).ToString)
            Next

            If ShowIcon = True Then
                lv.ImageIndex = IconNo
            End If

            ListView.Items.AddRange(New ListViewItem() {lv})
        Loop
        vRS.Close()
    End Sub

    Public Sub HLTxt(ByRef txt As TextBox)
        On Error Resume Next
        txt.SelectionStart = 0
        txt.SelectionLength = Len(txt)
        txt.Focus()
    End Sub
    Public Function getMyAge(ByVal dteBirth As String, ByVal dteNow As String) As Integer

        Dim intFromDay As Integer, _
            intFromMon As Integer, _
            intFromYr As Integer

        Dim intToDay As Integer, _
            intToMon As Integer, _
            intToYr As Integer

        Dim intResultAge As Integer

        On Error GoTo ErrHandler

        intFromYr = Year(dteBirth)
        intFromMon = Month(dteBirth)
        intFromDay = Microsoft.VisualBasic.Day(dteBirth)

        intToYr = Year(dteNow)
        intToMon = Month(dteNow)
        intToDay = Microsoft.VisualBasic.Day(dteNow)

        If intFromYr <= intToYr Then
            intResultAge = intToYr - intFromYr
        Else
            getMyAge = -1 : Exit Function ' invalid value
        End If

        If intFromMon <= intToMon Then
            If (intFromMon = intToMon) And (intFromDay > intToDay) Then
                intResultAge = intResultAge - 1
            Else
                intResultAge = intResultAge
            End If
        Else
            intResultAge = intResultAge - 1
        End If
        getMyAge = intResultAge

getMyAgeExit:
        Exit Function

ErrHandler:
        getMyAge = -1

    End Function
    Public Function cSentenceCase(ByVal sText As String) As String

        Dim splitText() As String
        Dim newWord As String
        Dim i As Integer

        'check if null---------------
        If Len(sText) < 1 Then
            cSentenceCase = ""
            Exit Function
        End If
        'end Null --------------------

        'convert
        sText = Trim(sText)

        splitText = Split(sText, " ")

        For i = 0 To UBound(splitText)
            If Len(Trim(splitText(i))) > 0 Then
                newWord = UCase(Left(Trim(splitText(i)), 1)) & LCase(Right(Trim(splitText(i)), Len(Trim(splitText(i))) - 1))
                cSentenceCase = cSentenceCase & " " & newWord
            End If
        Next

        cSentenceCase = Trim(cSentenceCase)
    End Function

    Public Function BooleanToInt(ByVal Bool As Boolean) As Integer
        Select Case Bool
            Case True
                BooleanToInt = 1
            Case False
                BooleanToInt = 0
        End Select
    End Function

    Public Function IntToBoolean(ByVal Int As Short) As Boolean
        Select Case Int
            Case 1
                IntToBoolean = True
            Case 0
                IntToBoolean = False
        End Select
    End Function


    Public Function GetLVSelectedCount(ByRef lv As ListView) As Integer
        Dim i As Integer
        Dim iSelectedCount As Integer

        'default
        GetLVSelectedCount = 0

        'check if there is a record in the list
        If lv.Items.Count < 1 Then Exit Function


        iSelectedCount = 0
        For i = 1 To lv.Items.Count
            If lv.Items(i).Selected = True Then
                iSelectedCount = iSelectedCount + 1
            End If
        Next

        'return
        GetLVSelectedCount = iSelectedCount
    End Function

    Public Sub CatchError(ByVal sModuleName As String, ByVal sRoutineName As String, ByVal sDetail As String)
        MsgBox(sModuleName & " - " & sRoutineName & " - " & sDetail)
    End Sub

    Public Function DisplayErrorMsg(ByVal pModule As String, ByVal pProcedure As String, ByVal ErrorNbr As Long, ByVal ErrorDesc As String)

        Dim strErrorMsg As String

        On Error Resume Next

        strErrorMsg = "------------------------------------------------------------------------------------------------------------------------------------------" & vbNewLine & _
                      "Error          : " & ErrorNbr & vbNewLine & _
                      "Description: " & ErrorDesc & vbNewLine & _
                      "------------------------------------------------------------------------------------------------------------------------------------------" & vbNewLine & vbNewLine & _
                      "Module       : " & pModule & vbNewLine & _
                      "Procedure: " & pProcedure & vbNewLine & vbNewLine & _
                      "If this is the first time you saw this message, " & _
                      "kindly inform your Database Administrator" & vbNewLine & _
                      "or notify the Technical Support of i 4Link Systems, Inc." & vbNewLine & vbNewLine & _
                      "support@i4LinkSystems.wix.com/main " & vbNewLine & vbNewLine & _
                      "Indicate the information shown in this dialog and what you were doing when this error occured." & vbNewLine & vbNewLine & _
                      "Thank you."

        MsgBox(strErrorMsg, vbCritical + vbOKOnly, "Error No. " & ErrorNbr)

    End Function

End Module
