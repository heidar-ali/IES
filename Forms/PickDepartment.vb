Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class PickDepartment


    Dim Alignable As Boolean = False

    Dim tmpDepartment As String = ""

    Dim MaxEntryCount As Long
    Dim CurRecPos As Long
    Dim CurRecordCount As Long

    Dim sOldDepartment As String

    Dim sGetDepartmentTitle As String = ""
    Dim sDepartmentID As String = ""

    Public ReadOnly Property getID As String
        Get
            Return sDepartmentID
        End Get
    End Property
    Public ReadOnly Property getDepartment As String
        Get
            Return sGetDepartmentTitle
        End Get
    End Property
    Public ReadOnly Property IsValid As Boolean
        Get
            Return Alignable
        End Get
    End Property

    Public Function GetItem(Optional ByRef sDepartmentTitle As Object = Nothing, Optional ByVal lMaxEntryCount As Long = 15, Optional ByVal OldDepartment As String = "0000", Optional ByVal ExcludeClosed As Boolean = False) As String

        Dim sSQL As String
        Dim vDepartment As tDepartment

        'set fail to default
        GetItem = ""
        tmpDepartment = ""


        MaxEntryCount = lMaxEntryCount
        CurRecPos = 0

        sDepartmentID = ""
        sGetDepartmentTitle = ""

        If DepartmentRecordExist() <> TranDBResult.Success Then
            MsgBox("There are no record yet in Department Entries", vbExclamation)
            Exit Function
        End If


        sSQL = "SELECT tblDepartment.DepartmentID as lvKey,tblDepartment.DepartmentTitle " & _
                " FROM tblDepartment" & _
                " ORDER BY tblDepartment.DepartmentTitle"

        'add yr to list
        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        listRecord.Items.Clear()
        While vRS.Read()
            If vRS.HasRows = True Then
                Dim lv As New ListViewItem(vRS("DepartmentTitle").ToString())
                lv.SubItems.Add(vRS("lvKey").ToString())
                listRecord.Items.AddRange(New ListViewItem() {lv})
            Else
                'error
                MsgBox("No Department  to be selected." & vbNewLine & "Please Add New Department  first.", vbExclamation)
                Close()
                Exit Function
            End If
        End While
        vRS.Close()
        'show form
        Me.ShowDialog()

        'this next line will not execute unload this for will be unloaded
        sDepartmentTitle = sGetDepartmentTitle
        GetItem = tmpDepartment
    End Function


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            Dim sSQL As String

            sSQL = "SELECT tblDepartment.DepartmentTitle AS lvKey, tblDepartment.DepartmentTitle" & _
                    " From tblDepartment" & _
                    " WHERE  ((DepartmentTitle) like '%" & TextBox1.Text & "%')"
            Dim com As New MySqlCommand(sSQL, clsCon.con)
            Dim vRS As MySqlDataReader = com.ExecuteReader()
            listRecord.Items.Clear()
            While vRS.Read()
                    Dim lv As New ListViewItem(vRS("DepartmentTitle").ToString())
                    lv.SubItems.Add(vRS("DepartmentID").ToString())
                    listRecord.Items.AddRange(New ListViewItem() {lv})
            End While
            vRS.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSelect.Click, listRecord.DoubleClick
        If listRecord.Items.Count > 0 Then
            Alignable = True
            sGetDepartmentTitle = listRecord.FocusedItem.Text
            sDepartmentID = listRecord.FocusedItem.SubItems(1).Text
            Close()
            Return
        Else
            Alignable = False
            sGetDepartmentTitle = ""
            sDepartmentID = ""
            Close()
            Return
        End If
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click

    End Sub
End Class