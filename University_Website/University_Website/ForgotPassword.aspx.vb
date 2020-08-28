Imports System.Net.Mail
Imports System.Net
Imports System.IO
Imports System.Data
Imports System.Data.OleDb


Public Class ForgotPassword
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblMsg.Text = ""
    End Sub

    Protected Sub btnSend_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSend.Click
        If txtEmail.Text = "" Then
            lblMsg.ForeColor = Drawing.Color.Red
            lblMsg.Text = "Email cannot be left blank"
        Else
            Dim conn As New OleDbConnection
            Dim cmd As New OleDbCommand
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\University_Website\University_Website\Database\universityDB.accdb"
            conn.Open()
            cmd.CommandText = "select Pass from studentReg where Email = '" & txtEmail.Text & "'"
            cmd.Connection = conn
            Dim adp As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable()
            adp.Fill(dt)
            If dt.Rows.Count = 0 Then
                lblMsg.ForeColor = Drawing.Color.Red
                lblMsg.Text = "Email not registered on our system"
            Else

                Dim pass As String = cmd.ExecuteScalar

                Dim fileName As String = Server.MapPath("~/forgotPassword.txt")
                Dim mailBody As String = File.ReadAllText(fileName)

                mailBody = mailBody.Replace("##password##", pass.ToString())

                Dim myMessage As MailMessage = New MailMessage()
                myMessage.Subject = "Password for University of Palampur"
                myMessage.Body = mailBody
                myMessage.From = New MailAddress("shivamkumar116@gmail.com", "University of Palampur")
                myMessage.To.Add(New MailAddress(txtEmail.Text))
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
                    lblMsg.ForeColor = Drawing.Color.Green
                    lblMsg.Text = "Check your Email for your password"


                Catch ex As Exception
                    lblMsg.ForeColor = Drawing.Color.Red
                    lblMsg.Text = "Something Went Wrong"
                End Try

            End If

        End If



    End Sub
End Class