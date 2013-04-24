Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class PickStudent

    Dim tmpStudentID As String

    Dim MaxEntryCount As Long
    Dim CurRecPos As Long
    Dim CurStudentCount As Long

    Dim curStudentFullName As String

    Dim curExcludeDropped As Boolean
    Dim curExcludeGraduate As Boolean

    Public Function GetStudentID(Optional ByRef TextObject As Object = Nothing, Optional ByRef sStudentFullName As String = "", Optional ByVal lMaxEntryCount As Long = 15, Optional ByVal ExcludeDropped As Boolean = True, Optional ByVal ExcludeGraduate As Boolean = True) As String

        Dim sSQL As String


        'set fail to default
        GetStudentID = ""
        tmpStudentID = ""
        CurRecPos = 0

        'set parameters
        MaxEntryCount = lMaxEntryCount
        curExcludeDropped = ExcludeDropped
        curExcludeGraduate = ExcludeGraduate


        If ExcludeDropped = False And ExcludeGraduate = False Then

            sSQL = "SELECT tblStudent.StudentID as lvID ,tblStudent.StudentID, CONCAT(tblStudent.LastName,', ',tblStudent.FirstName,' ',tblStudent.MiddleName) AS FullName From tblStudent" & _
                    " ORDER BY CONCAT(tblStudent.LastName,', ',tblStudent.FirstName,' ',tblStudent.MiddleName);"
        ElseIf ExcludeDropped = True And ExcludeGraduate = True Then

            sSQL = "SELECT tblStudent.StudentID AS lvID, tblStudent.StudentID,  CONCAT(tblStudent.LastName,', ',tblStudent.FirstName,' ',tblStudent.MiddleName) AS FullName" & _
                    " FROM tblGraduate RIGHT JOIN (tblDropped RIGHT JOIN tblStudent ON tblDropped.StudentID = tblStudent.StudentID) ON tblGraduate.StudentID = tblStudent.StudentID" & _
                    " GROUP BY tblStudent.StudentID, tblStudent.StudentID,  CONCAT(tblStudent.LastName,', ',tblStudent.FirstName,' ',tblStudent.MiddleName)" & _
                    " Having (((Count(tblGraduate.StudentID)) < 1) And ((Count(tblDropped.StudentID)) < 1))" & _
                    " ORDER BY  CONCAT(tblStudent.LastName,', ',tblStudent.FirstName,' ',tblStudent.MiddleName);"

        ElseIf ExcludeDropped = True And ExcludeGraduate = False Then
            sSQL = "SELECT tblStudent.StudentID AS lvID, tblStudent.StudentID,  CONCAT(tblStudent.LastName,', ',tblStudent.FirstName,' ',tblStudent.MiddleName) AS FullName" & _
                    " FROM tblGraduate RIGHT JOIN (tblDropped RIGHT JOIN tblStudent ON tblDropped.StudentID = tblStudent.StudentID) ON tblGraduate.StudentID = tblStudent.StudentID" & _
                    " GROUP BY tblStudent.StudentID, tblStudent.StudentID,  CONCAT(tblStudent.LastName,', ',tblStudent.FirstName,' ',tblStudent.MiddleName)" & _
                    " Having (((Count(tblDropped.StudentID)) < 1))" & _
                    " ORDER BY  CONCAT(tblStudent.LastName,', ',tblStudent.FirstName,' ',tblStudent.MiddleName);"
        ElseIf ExcludeDropped = False And ExcludeGraduate = True Then
            sSQL = "SELECT tblStudent.StudentID AS lvID, tblStudent.StudentID,  CONCAT(tblStudent.LastName,', ',tblStudent.FirstName,' ',tblStudent.MiddleName)AS FullName" & _
                    " FROM tblGraduate RIGHT JOIN (tblDropped RIGHT JOIN tblStudent ON tblDropped.StudentID = tblStudent.StudentID) ON tblGraduate.StudentID = tblStudent.StudentID" & _
                    " GROUP BY tblStudent.StudentID, tblStudent.StudentID, CONCAT(tblStudent.LastName,', ',tblStudent.FirstName,' ',tblStudent.MiddleName)" & _
                    " Having (((Count(tblGraduate.StudentID)) < 1) )" & _
                    " ORDER BY  CONCAT(tblStudent.LastName,', ',tblStudent.FirstName,' ',tblStudent.MiddleName);"

        End If



        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        While vRS.Read()
            Dim lv As New ListViewItem(vRS("lvID").ToString())
            lv.SubItems.Add(vRS("FullName").ToString())
            listRecord.Items.AddRange(New ListViewItem() {lv})
        End While



ConShowForm:

        'show form
        Me.ShowDialog()

        'this next line will not execute unload this for will be unloaded
        GetStudentID = tmpStudentID
        sStudentFullName = curStudentFullName

    End Function


    Private Sub ReturnGetStudentID()
        If listRecord.Items.Count > 0 Then
            tmpStudentID = listRecord.FocusedItem.Text
            curStudentFullName = listRecord.FocusedItem.SubItems(1).Text
            Close()
        End If
    End Sub
    Private Sub CancelGetStudentID()
        tmpStudentID = ""
        Close()
    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       ReturnGetStudentID()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CancelGetStudentID()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFind.TextChanged
        Dim sSQL As String


        If curExcludeDropped = False And curExcludeGraduate = False Then

            sSQL = "SELECT tblStudent.StudentID as lvID ,tblStudent.StudentID, CONCAT(tblStudent.LastName,', ',tblStudent.FirstName,' ',tblStudent.MiddleName) AS FullName From tblStudent" & _
                    " WHERE ((CONCAT(tblStudent.LastName,', ',tblStudent.FirstName,' ',tblStudent.MiddleName) like '%" & txtFind.Text & "%'))" & _
                    " ORDER BY CONCAT(tblStudent.LastName,', ',tblStudent.FirstName,' ',tblStudent.MiddleName);"
        ElseIf curExcludeDropped = True And curExcludeGraduate = True Then

            sSQL = "SELECT tblStudent.StudentID AS lvID, tblStudent.StudentID, CONCAT(tblStudent.LastName,', ',tblStudent.FirstName,' ',tblStudent.MiddleName)AS FullName" & _
                    " FROM tblGraduate RIGHT JOIN (tblDropped RIGHT JOIN tblStudent ON tblDropped.StudentID = tblStudent.StudentID) ON tblGraduate.StudentID = tblStudent.StudentID" & _
                    " WHERE ((CONCAT(tblStudent.LastName,', ',tblStudent.FirstName,' ',tblStudent.MiddleName) like '%" & txtFind.Text & "%'))" & _
                    " GROUP BY tblStudent.StudentID, tblStudent.StudentID, CONCAT(tblStudent.LastName,', ',tblStudent.FirstName,' ',tblStudent.MiddleName)" & _
                    " Having (((Count(tblGraduate.StudentID)) < 1) And ((Count(tblDropped.StudentID)) < 1))" & _
                    " ORDER BY CONCAT(tblStudent.LastName,', ',tblStudent.FirstName,' ',tblStudent.MiddleName);"

        ElseIf curExcludeDropped = True And curExcludeGraduate = False Then
            sSQL = "SELECT tblStudent.StudentID AS lvID, tblStudent.StudentID, CONCAT(tblStudent.LastName,', ',tblStudent.FirstName,' ',tblStudent.MiddleName) AS FullName" & _
                    " FROM tblGraduate RIGHT JOIN (tblDropped RIGHT JOIN tblStudent ON tblDropped.StudentID = tblStudent.StudentID) ON tblGraduate.StudentID = tblStudent.StudentID" & _
                    " WHERE ((CONCAT(tblStudent.LastName,', ',tblStudent.FirstName,' ',tblStudent.MiddleName) like '%" & txtFind.Text & "%'))" & _
                    " GROUP BY tblStudent.StudentID, tblStudent.StudentID, CONCAT(tblStudent.LastName,', ',tblStudent.FirstName,' ',tblStudent.MiddleName)" & _
                    " Having (((Count(tblDropped.StudentID)) < 1))" & _
                    " ORDER BY CONCAT(tblStudent.LastName,', ',tblStudent.FirstName,' ',tblStudent.MiddleName);"
        ElseIf curExcludeDropped = False And curExcludeGraduate = True Then
            sSQL = "SELECT tblStudent.StudentID AS lvID, tblStudent.StudentID,CONCAT(tblStudent.LastName,', ',tblStudent.FirstName,' ',tblStudent.MiddleName) AS FullName" & _
                    " FROM tblGraduate RIGHT JOIN (tblDropped RIGHT JOIN tblStudent ON tblDropped.StudentID = tblStudent.StudentID) ON tblGraduate.StudentID = tblStudent.StudentID" & _
                    " WHERE ((CONCAT(tblStudent.LastName,', ',tblStudent.FirstName,' ',tblStudent.MiddleName) like '%" & txtFind.Text & "%'))" & _
                    " GROUP BY tblStudent.StudentID, tblStudent.StudentID, CONCAT(tblStudent.LastName,', ',tblStudent.FirstName,' ',tblStudent.MiddleName)" & _
                    " Having (((Count(tblGraduate.StudentID)) < 1) )" & _
                    " ORDER BY CONCAT(tblStudent.LastName,', ',tblStudent.FirstName,' ',tblStudent.MiddleName);"

        End If

        Dim com As New MySqlCommand(sSQL, clsCon.con)
        Dim vRS As MySqlDataReader = com.ExecuteReader()
        While vRS.Read()
            Dim lv As New ListViewItem(vRS("lvID").ToString())
            lv.SubItems.Add(vRS("FullName").ToString())
            listRecord.Items.AddRange(New ListViewItem() {lv})
        End While


    End Sub

    Private Sub listRecord_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listRecord.DoubleClick
        ReturnGetStudentID()
    End Sub
End Class
