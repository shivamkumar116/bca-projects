Imports System.Data
Imports System.Data.OleDb
Public Class allRecords

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\Student_Management_System\Student_Management_System\Database\studentDB.accdb;Persist Security Info=True"
        conn.Open()
        cmd.CommandText = "Select * from basicDetails"
        cmd.Connection = conn
        Dim adp As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable()
        adp.Fill(dt)
        DataGridView1.DataSource = dt
        conn.Close()
    End Sub

   
End Class