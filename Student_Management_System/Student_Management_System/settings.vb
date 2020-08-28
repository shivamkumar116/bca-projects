Imports System.Data
Imports System.Data.OleDb
Public Class settings
    Dim user As String
    Dim pass As String
    Private Sub settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblError.Text = ""
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\Student_Management_System\Student_Management_System\Database\studentDB.accdb;Persist Security Info=True"
        conn.Open()
        cmd.CommandText = "select * from adminLogin"
        cmd.Connection = conn
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        While dr.Read
            user = dr("UserID")
            pass = dr("Pass")
        End While
        conn.Close()
        txtUsername.Text = user
        txtpassword.Text = pass
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        txtpassword.PasswordChar = If(CheckBox1.Checked, "", "*")
    End Sub



    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\Student_Management_System\Student_Management_System\Database\studentDB.accdb;Persist Security Info=True"
        conn.Open()
        cmd.CommandText = "update adminLogin set UserID='" & txtUsername.Text & "',Pass='" & txtpassword.Text & "'"
        cmd.Connection = conn
        Try
            cmd.ExecuteNonQuery()
            lblError.ForeColor = Color.Green
            lblError.Text = "Updated Successfully"
        Catch ex As Exception
            lblError.ForeColor = Color.Red

            lblError.Text = "Something Went Wrong"
        End Try
    End Sub

    Private Sub txtUsername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsername.TextChanged
        If txtUsername.TextLength = 0 Then
            lblError.Text = ""
        End If
    End Sub

    Private Sub txtpassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpassword.TextChanged
        If txtpassword.TextLength = 0 Then
            lblError.Text = ""
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class