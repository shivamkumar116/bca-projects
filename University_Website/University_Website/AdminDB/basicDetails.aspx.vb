Imports System.Data
Imports System.Data.OleDb
Public Class basicDetails
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblMessage.Text = ""
        If Not IsPostBack Then
            Dim conn As New OleDbConnection
            Dim cmd As New OleDbCommand
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\University_Website\University_Website\Database\universityDB.accdb"
            conn.Open()
            cmd.CommandText = "Select * from adminLogin"
            cmd.Connection = conn
            Dim rdr As OleDbDataReader = cmd.ExecuteReader
            While rdr.Read
                txtUserName.Text = rdr("UserID")
                txtPassword.Text = rdr("Pass")
            End While
        End If
        Dim password As String = txtPassword.Text
        txtPassword.Attributes.Add("value", password)
    End Sub


    Protected Sub chkPassword_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkPassword.CheckedChanged
        If chkPassword.Checked = True Then
            txtPassword.TextMode = TextBoxMode.SingleLine
        Else
            txtPassword.TextMode = TextBoxMode.Password
        End If
    End Sub

    Protected Sub btnDiscard_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDiscard.Click
        Response.Redirect("~/AdminDB/AdminDB.aspx")
    End Sub

    Protected Sub btnUpdate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUpdate.Click
        If txtUserName.Text.Trim() = "" Or txtPassword.Text.Trim() = "" Then
            lblMessage.ForeColor = Drawing.Color.Red
            lblMessage.Text = "One or more Field Cannot be left blank"
        Else
            Dim conn As New OleDbConnection
            Dim cmd As New OleDbCommand
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\University_Website\University_Website\Database\universityDB.accdb"
            conn.Open()
            cmd.CommandText = "update adminLogin set UserID='" & txtUserName.Text & "',Pass='" & txtPassword.Text & "'"
            cmd.Connection = conn
            Try
                cmd.ExecuteNonQuery()
                lblMessage.ForeColor = Drawing.Color.Green
                lblMessage.Text = "Record Updated :)"
            Catch ex As Exception
                lblMessage.ForeColor = Drawing.Color.Red
                lblMessage.Text = "Something went Wrong"
            End Try
        End If

    End Sub
End Class