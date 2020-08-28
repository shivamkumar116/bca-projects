Imports System.Data
Imports System.Data.OleDb
Public Class Contact
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblMsg.Text = ""
    End Sub

    Protected Sub btnSend_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSend.Click
        If Page.IsValid Then
            If txtName.Text = "" Or txtEmail.Text = "" Or txtMessage.Text = "" Or txtSubject.Text = "" Then
                lblMsg.ForeColor = Drawing.Color.Red
                lblMsg.Text = "One or more field cannot be left blank"
            Else
                Dim conn As New OleDbConnection
                Dim cmd As New OleDbCommand
                conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\University_Website\University_Website\Database\universityDB.accdb"
                conn.Open()
                cmd.CommandText = "insert into contactQuery(PersonName,Email,Subject,Message) values('" & txtName.Text & "','" & txtEmail.Text & "','" & txtSubject.Text & "','" & txtMessage.Text & "')"
                cmd.Connection = conn
                Try
                    cmd.ExecuteNonQuery()
                    lblMsg.Text = "Thank you for Writing to us. We will get back to you shortly"
                    txtEmail.Text = ""
                    txtName.Text = ""
                    txtSubject.Text = ""
                    txtMessage.Text = ""
                Catch ex As Exception
                    lblMsg.ForeColor = Drawing.Color.Red

                    lblMsg.Text = "Something went wrong"
                End Try
            End If

        End If

    End Sub

    Protected Sub btnDiscard_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDiscard.Click
        Response.Redirect("~/index.aspx")
    End Sub


End Class