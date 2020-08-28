Imports System.Data
Imports System.Data.OleDb
Public Class courses
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblMsg.Text = ""
    End Sub

    Protected Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        
            Dim conn As New OleDbConnection
            Dim cmd As New OleDbCommand
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\University_Website\University_Website\Database\universityDB.accdb"
            conn.Open()
            cmd.CommandText = "INSERT INTO courses(Title, Fees, Seats, Duration) values('" & txtTitle.Text & "','" & txtFee.Text & "','" & txtSeats.Text & "','" & txtDuration.Text & "')"
            cmd.Connection = conn
            If txtTitle.Text = "" Or txtFee.Text = "" Or txtDuration.Text = "" Or txtSeats.Text = "" Then
                lblMsg.ForeColor = Drawing.Color.Red

                lblMsg.Text = "* one or more field left blank"
            Else
                Try
                    cmd.ExecuteNonQuery()
                    lblMsg.ForeColor = Drawing.Color.DarkGreen
                    lblMsg.Text = "Data Saved :)"
                    conn.Close()
                    txtTitle.Text = ""
                    txtFee.Text = ""
                    txtSeats.Text = ""
                    txtDuration.Text = ""
                Catch ex As Exception
                    lblMsg.ForeColor = Drawing.Color.Red
                    lblMsg.Text = "Couldn't save. Try again :("
                End Try
            End If


        
    End Sub

    Protected Sub btnLink_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLink.Click
        Response.Redirect("~/AdminDB/allCourses.aspx")

    End Sub
End Class