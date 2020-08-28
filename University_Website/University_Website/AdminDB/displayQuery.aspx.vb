Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Net.Mail
Imports System.Net
Imports System.IO

Public Class displayQuery
    Inherits System.Web.UI.Page
    Dim email As String
    Dim Subject As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblMessage.Text = ""

        Dim userId As Integer = Request.QueryString("id")
        userId = Convert.ToInt32(userId)
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\University_Website\University_Website\Database\universityDB.accdb"
        conn.Open()
        cmd.CommandText = "SELECT * FROM contactQuery where id=@id"
        cmd.Parameters.AddWithValue("@id", userId)
        cmd.Connection = conn
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        While dr.Read
            email = dr("Email")
            Subject = dr("Subject")
        End While
    End Sub

    Protected Sub btnReply_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnReply.Click
        If txtReply.Text = "" Then
            lblMessage.ForeColor = Drawing.Color.Red

            lblMessage.Text = "Field cannot be left blank"
        Else
            Dim myMessage As MailMessage = New MailMessage()
            myMessage.Subject = Subject
            myMessage.Body = txtReply.Text

            myMessage.From = New MailAddress("shivamkumar116@gmail.com", "University of Palampur")
            myMessage.To.Add(New MailAddress(email))
            Dim mySmtpClient As SmtpClient = New SmtpClient()
            mySmtpClient.Host = "smtp.gmail.com"
            mySmtpClient.DeliveryMethod = SmtpDeliveryMethod.Network
            mySmtpClient.Port = 587
            Dim networkCred As New NetworkCredential("<Email>", "<Password>")
            mySmtpClient.UseDefaultCredentials = True
            mySmtpClient.Credentials = networkCred
            mySmtpClient.EnableSsl = True
            Try
                mySmtpClient.Send(myMessage)
                lblMessage.ForeColor = Drawing.Color.Green
                lblMessage.Text = "Replied :)"


            Catch ex As Exception
                lblMessage.ForeColor = Drawing.Color.Red
                lblMessage.Text = "Something Went Wrong"
            End Try
        End If
       

    End Sub
End Class