Imports System.Data.OleDb
Imports System.Data
Public Class ClientLogin
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoginError.Text = ""


    End Sub


    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click

        If TxtUser.Text = "" Then
            LoginError.Text = "Username field cannot be blank."

        ElseIf TxtPassword.Text = "" Then
            LoginError.Text = "Password field cannot be blank."

        Else

            Dim conn As New OleDb.OleDbConnection
            Dim cmd As New OleDb.OleDbCommand

            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\Examination_system1\Examination_system1\Db\ExamDb.accdb"

            cmd.CommandText = "SELECT * FROM Login_Detail WHERE UserID =@username and Password=@password"
            cmd.Connection = conn
            conn.Open()
            cmd.Parameters.AddWithValue("@username", TxtUser.Text)
            cmd.Parameters.AddWithValue("@password", TxtPassword.Text)

            Dim da As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                Session("Admin") = TxtUser.Text
                Response.Redirect("Admin/Dashboard.aspx")
            Else
                cmd.CommandText = "SELECT UserID , Password FROM Student_detail"
                cmd.Connection = conn
                Dim da1 As New OleDbDataAdapter(cmd)
                Dim dt1 As New DataTable()
                da1.Fill(dt1)
                If dt1.Rows.Count > 0 Then
                    Session("Email") = TxtUser.Text
                    Response.Redirect("~/Client/instruction.aspx")
                End If
                LoginError.Text = "Invalid Username/Password"

        End If

        End If
    End Sub
End Class