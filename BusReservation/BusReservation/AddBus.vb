Imports System.Data
Imports System.Data.OleDb

Public Class AddBus

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim cmd1 As New OleDbCommand
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\Student_Management_System\Student_Management_System\Database\studentDB.accdb;Persist Security Info=True"
        conn.Open()
        cmd.CommandText = "insert into BusDetail values ('" & txtRoute.Text & "','" & txtFrom.Text & "','" & txtTo.Text & "','" & txtBusID.Text & "','" & txtDepatTime.Text & "','" & txtBusType.Text & "','" & txtfare.Text & "')"
        cmd.Connection = conn
        Try
            cmd.ExecuteNonQuery()
            lblMessage.ForeColor = Color.Green
            lblMessage.Text = "Data saved :)"
        Catch ex As Exception
            lblMessage.ForeColor = Color.Red
            lblMessage.Text = "Something Went Wrong"
        End Try
    End Sub

    Private Sub AddBus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblMessage.Text = ""
    End Sub
End Class