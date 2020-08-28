Imports System.Data
Imports System.Data.OleDb
Public Class Login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblError.Text = ""
    End Sub

    Protected Sub btnLogin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLogin.Click

        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            lblError.Text = "one or more field left blank"
        Else
            Dim conn As New OleDbConnection
            Dim cmd As New OleDbCommand
            Dim cmd1 As New OleDbCommand
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\University_Website\University_Website\Database\universityDB.accdb"
            conn.Open()
            cmd.CommandText = "select * from adminLogin where UserID  =@user and Pass=@pass"
            cmd1.CommandText = "select * from studentReg Where Email=@email and Pass= @pass"
            cmd.Connection = conn
            cmd1.Connection = conn
            cmd.Parameters.AddWithValue("@user", txtUsername.Text)
            cmd.Parameters.AddWithValue("@pass", txtPassword.Text)
            cmd1.Parameters.AddWithValue("@email", txtUsername.Text)
            cmd1.Parameters.AddWithValue("@pass", txtPassword.Text)

            Dim adp As New OleDbDataAdapter(cmd)
            Dim adp1 As New OleDbDataAdapter(cmd1)
            Dim dt As New DataTable
            Dim dt1 As New DataTable
            adp.Fill(dt)
            adp1.Fill(dt1)
            Try
                If dt.Rows.Count > 0 Then
                    Session("Admin") = txtUsername.Text
                    Response.Redirect("~/AdminDB/AdminDB.aspx")
                ElseIf dt1.Rows.Count > 0 Then
                    Session("Student") = txtUsername.Text
                    Response.Redirect("~/StudentDB/studentDB.aspx")
                Else
                    lblError.Text = "Username/Password is incorrect."
                End If

            Catch ex As Exception
                lblError.Text = "Something went wrong"
            End Try
        End If

    End Sub

    Protected Sub btnForgot_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnForgot.Click
        Response.Redirect("~/ForgotPassword.aspx")
    End Sub
End Class