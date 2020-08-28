Imports System.Data
Imports System.Data.OleDb
Public Class displayNews
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim userId As Integer = Request.QueryString("ID")
        userId = Convert.ToInt32(userId)
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\University_Website\University_Website\Database\universityDB.accdb"
        conn.Open()
        cmd.CommandText = "SELECT * FROM News where ID=@id"
        cmd.Parameters.AddWithValue("@id", userId)
        cmd.Connection = conn
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        While dr.Read
            lblTitle.Text = dr("Title")
            lblDate.Text = dr("dateOfNews").ToString()
            lblDesc.Text = dr("Description")
        End While
    End Sub

    Protected Sub btnBack_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBack.Click
        Response.Redirect("~/News.aspx")
    End Sub
End Class