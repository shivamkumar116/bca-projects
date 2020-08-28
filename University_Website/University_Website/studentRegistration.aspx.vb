Imports System.Data
Imports System.Data.OleDb
Public Class studentRegistration
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblEror.Text = ""

    End Sub

    Protected Sub btnRegister_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRegister.Click
        If txtEmail.Text = "" Or txtPassword.Text = "" Or txtConfirmPassword.Text = "" Then
            lblEror.ForeColor = Drawing.Color.Red
            lblEror.Text = "One or more field left blank"
        Else
            Dim conn As New OleDbConnection
            Dim cmd As New OleDbCommand
            Dim cmd1 As New OleDbCommand
            Dim exist As Integer
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\University_Website\University_Website\Database\universityDB.accdb"
            conn.Open()
            cmd.CommandText = "insert into studentReg values('" & txtEmail.Text & "','" & txtPassword.Text & "')"
            cmd1.CommandText = "select count(Email) from studentReg where Email= '" & txtEmail.Text & "'"
            cmd1.Connection = conn
            cmd.Connection = conn
            exist = Convert.ToInt16(cmd1.ExecuteScalar())
            If txtPassword.Text = txtConfirmPassword.Text Then
                Try

                    If exist > 0 Then
                        lblEror.Text = "An account already exist with this Email-ID"
                    Else
                        cmd.ExecuteNonQuery()
                        lblEror.ForeColor = Drawing.Color.Green
                        lblEror.Text = "Account Created"


                    End If

                Catch ex As Exception
                    lblEror.ForeColor = Drawing.Color.Red

                    lblEror.Text = "Something Went Wrong"
                End Try
            Else
                lblEror.ForeColor = Drawing.Color.Red
                lblEror.Text = "Password doesn't match :("
            End If
        End If

    End Sub

    Protected Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Response.Redirect("~/index.aspx")
    End Sub
End Class