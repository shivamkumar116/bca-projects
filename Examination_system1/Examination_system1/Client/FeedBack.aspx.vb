Imports System.Data.OleDb
Imports System.Data
Public Class FeedBack
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("Email") Is Nothing Then
            Response.Redirect("~/Login.aspx")
        Else
            ClientName.Text = Session("Email").ToString()
        End If
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click

        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim cmd1 As New OleDb.OleDbCommand

        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\Examination_system1\Examination_system1\Db\ExamDb.accdb"
        cmd.CommandText = "INSERT INTO FeedBack Values('" & Session("Email").ToString & "', '" & RadioButtonList1.SelectedValue & "')"
        cmd.Connection = conn
        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()
        ClientScript.RegisterClientScriptBlock(Page.GetType(), "script", "window.close();", True)
    End Sub
End Class