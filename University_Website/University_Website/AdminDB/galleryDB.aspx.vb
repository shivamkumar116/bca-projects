Imports System.Data
Imports System.Data.OleDb
Public Class galleryDB
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblError.Text = ""
    End Sub

    Protected Sub btnUpload_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUpload.Click
        If FileUpload1.HasFile = Nothing Then
            lblError.ForeColor = Drawing.Color.Red

            lblError.Text = "Please choose image"
        Else
            If FileUpload1.HasFile Then
                Dim fileName As String = FileUpload1.PostedFile.FileName
                Dim imgPath As String = "Images/" & fileName

                FileUpload1.SaveAs(Server.MapPath(imgPath))

                Dim fullUrl As String = "~/AdminDB/" & imgPath
                Dim conn As New OleDbConnection
                Dim cmd As New OleDbCommand
                conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\University_Website\University_Website\Database\universityDB.accdb"
                conn.Open()
                cmd.CommandText = "INSERT INTO gallery values('" & fullUrl & "' )"

                cmd.Connection = conn
                Try
                    cmd.ExecuteNonQuery()
                    lblError.ForeColor = Drawing.Color.Green
                    lblError.Text = "Uploaded successfully"


                    uploadImage.ImageUrl = "~/AdminDB/" & imgPath

                Catch ex As Exception
                    lblError.ForeColor = Drawing.Color.Red
                    lblError.Text = "Couldn't upload image :("

                End Try
            Else

                lblError.ForeColor = Drawing.Color.Red
                lblError.Text = "Please select an Image"
            End If

        End If
       



    End Sub
End Class