Imports MySql.Data.MySqlClient
Imports System.Data.Common
Imports System.Windows.Forms

Public Class frmConnector
    Private m_isvalid As Boolean = False
    Public ReadOnly Property isValid() As Boolean
        Get
            Return m_isvalid
        End Get
    End Property
    Const DefaultConnection As String = "server=MyServer;port=3306;database=SampleDatabase;user id=sysadmin;password=adminpwd"
    Private _csb As New DbConnectionStringBuilder
    Private Sub UpdateCSB()
        Dim CnnStr As String = ""
        With _csb
            CnnStr = "Server = " & ServerTextBox.Text & ";"
            CnnStr += "Port = " & PortTextBox.Text & ";"
            CnnStr += "Database = " & DatabaseTextBox.Text & ";"
            CnnStr += "User ID = " & UserTextBox.Text & ";"
            CnnStr += "Password = " & PasswordTextBox.Text & ""
            .ConnectionString = CnnStr
        End With
    End Sub
    Private Sub UpdateControls()
        With _csb
            .TryGetValue("Server", ServerTextBox.Text)
            .TryGetValue("Port", PortTextBox.Text)
            .TryGetValue("Database", DatabaseTextBox.Text)
            .TryGetValue("User ID", UserTextBox.Text)
            .TryGetValue("Password", PasswordTextBox.Text)
        End With
    End Sub
    Public Function TestConnection() As Boolean

        ' +===============================================+
        ' ¦ 'For MySQL you may write something like this: ¦
        ' +===============================================+
        UpdateCSB()
        Dim cnn As New MySql.Data.MySqlClient.MySqlConnection(_csb.ConnectionString)
        Cursor = Cursors.WaitCursor
        Try
            cnn.Open()
            cnn.Close()
            MessageBox.Show("Test connection succeeded.", "Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return True
        Catch ex As Exception
            MessageBox.Show("Test connection failed because of an error in initializing provider." & vbCrLf & ex.Message, "Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            Cursor = Cursors.Default
        End Try

        MessageBox.Show("Test connection succeeded.", "Fake Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return True
    End Function

    Public ReadOnly Property ConnectionProperties() As System.Data.Common.DbConnectionStringBuilder
        Get
            UpdateCSB()
            Return _csb
        End Get
    End Property

    Public Property ConnectionString() As String
        Get
            UpdateCSB()
            Return _csb.ConnectionString
        End Get
        Set(ByVal value As String)
            If value = "" Then
                'load a sample ConnectionString
                _csb.ConnectionString = DefaultConnection
            Else
                _csb.ConnectionString = value
            End If
            UpdateControls()
        End Set
    End Property
    Public Sub ShowAdvancedProperties()
        UpdateCSB()
        Dim tempCSB As New DbConnectionStringBuilder
        tempCSB.ConnectionString = _csb.ConnectionString
        If ShowAdvancedPropertiesDialog(tempCSB) = DialogResult.OK Then
            _csb.ConnectionString = tempCSB.ConnectionString
            UpdateControls()
        End If
    End Sub

    Private Sub TestConnectionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestConnectionButton.Click
        TestConnection()
    End Sub

    Private Sub PropertiesButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PropertiesButton.Click
        ShowAdvancedProperties()
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        writeFileStrData(ServerTextBox.Text & ":" & PortTextBox.Text & ":" & DatabaseTextBox.Text & ":" & UserTextBox.Text & ":" & PasswordTextBox.Text, Application.StartupPath & "\Config.ini", , "Unicode")
        CheckServer()
        m_isvalid = True
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
        Return
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class