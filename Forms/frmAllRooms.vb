Option Explicit On
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class frmAllRooms

    
    Private Sub frmAllRooms_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim com As New MySqlCommand("SELECT SubjectCode,Description,LabUnits,Units,CreditUnits,LecHrs,LabHrs,IsSubjectGE,IsSubjectElective,IsMajorSubject,IsCompSubject,InclGWA,IsNonAcademic,AliasCode1,AliasCode2, " & _
                                    "fnProgramClassName(LevelID),MinSize,MaxSize,IsOtherSchool,InActive,CreatedBy,CreationDate FROM tblSubject", con)
        Dim daSubject As New MySqlDataAdapter()
        Dim dsSubject As New DataSet()
        Dim BS As New BindingSource
        daSubject.SelectCommand = com
        daSubject.Fill(dsSubject)

        BS.DataSource = dsSubject.Tables(0).DefaultView
        Me.dgView.AutoGenerateColumns = True
        Me.dgView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        Me.dgView.DataSource = BS

    End Sub
End Class