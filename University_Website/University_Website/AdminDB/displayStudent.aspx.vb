Imports System.Data
Imports System.Data.OleDb
Public Class displayStudent
    Inherits System.Web.UI.Page
    Dim email As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        email = Request.QueryString("Email")
        lblMsg.Text = ""
        lblStat.Text = ""
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\University_Website\University_Website\Database\universityDB.accdb"
        conn.Open()
        cmd.CommandText = "select status from Status where Email='" & email & "'"

        cmd.Connection = conn
        Dim stat As String = cmd.ExecuteScalar()
        If stat = "Approved" Or stat = "Rejected" Then
            btnApprove.Visible = False
            btnReject.Visible = False
            lblStat.ForeColor = Drawing.Color.DarkBlue

            lblStat.Text = "This Student is already" & " " & stat.ToString() & ". No action Required"
        End If
    End Sub

    Protected Sub btnApprove_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnApprove.Click

        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\University_Website\University_Website\Database\universityDB.accdb"
        conn.Open()
        cmd.CommandText = "insert into status values('" & email & "','Approved') "
        cmd.Connection = conn

        cmd.ExecuteNonQuery()
        lblMsg.ForeColor = Drawing.Color.Green

        lblMsg.Text = "Status Approved"
        conn.Close()
    End Sub

    Protected Sub btnReject_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnReject.Click
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\University_Website\University_Website\Database\universityDB.accdb"
        conn.Open()
        cmd.CommandText = "insert into status values('" & email & "','Rejected') "
        cmd.Connection = conn

        cmd.ExecuteNonQuery()
        lblMsg.ForeColor = Drawing.Color.Red

        lblMsg.Text = "Status Rejected"
        conn.Close()
    End Sub
End Class