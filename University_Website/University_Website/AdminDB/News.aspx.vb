Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class News
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblError.Text = ""
    End Sub

    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSubmit.Click
        If txtTitle.Text = Nothing Or txtDesc.Text = Nothing Then
            lblError.ForeColor = Drawing.Color.Red
            lblError.Text = "one or more field left blank"
        Else
            Dim conn As New OleDbConnection
            Dim cmd As New OleDbCommand
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\University_Website\University_Website\Database\universityDB.accdb"
            conn.Open()
            cmd.CommandText = "insert into News(Title,Description,dateOfNews) values ('" & txtTitle.Text & "','" & txtDesc.Text & "', '" & Date.Now() & "')"
            cmd.Connection = conn
            Try
                cmd.ExecuteNonQuery()
                lblError.ForeColor = Drawing.Color.Green
                lblError.Text = "News Created :)"
            Catch ex As Exception

            End Try
        End If
    End Sub

    Protected Sub btnDiscard_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDiscard.Click
        Response.Redirect("~/AdminDB/AdminDB.aspx")
    End Sub
End Class