﻿Imports System.Data
Imports System.Data.OleDb
Public Class courses1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim conn As New OleDbConnection
            Dim cmd As New OleDbCommand
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\University_Website\University_Website\Database\universityDB.accdb"
            conn.Open()
            cmd.CommandText = "select * from courses"
            cmd.Connection = conn
            Dim ds As New DataSet
            Dim adp As New OleDbDataAdapter(cmd)
            adp.Fill(ds)
            Repeater1.DataSource = ds
            Repeater1.DataBind()
        End If
    End Sub

End Class