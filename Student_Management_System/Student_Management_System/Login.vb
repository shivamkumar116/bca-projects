Imports System.Data
Imports System.Data.OleDb
Public Class Login

    Dim count As Integer = 0

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblerror.Text = ""
        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        If txtUsername.Text = Nothing Then
            ErrorProvider1.SetError(txtUsername, "Username cannot be blank")
        ElseIf txtPassword.Text = Nothing Then
            ErrorProvider1.SetError(txtPassword, "Password cannot be left blank")

        Else
            Dim conn As New OleDbConnection
            Dim cmd As New OleDbCommand
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\Student_Management_System\Student_Management_System\Database\studentDB.accdb;Persist Security Info=True"
            conn.Open()
            cmd.CommandText = "Select * from adminLogin where userID=@user and Pass= @pass "
            cmd.Parameters.AddWithValue("@user", txtUsername.Text)
            cmd.Parameters.AddWithValue("@Pass", txtPassword.Text)
            cmd.Connection = conn
            Dim adp As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            adp.Fill(dt)
            If dt.Rows.Count > 0 Then
                count = 0
                txtPassword.Text = ""
                lblerror.Text = ""
                Dim obj As New Home()

                obj.Show()
                Me.Hide()


            Else
                count += 1
                lblerror.Text = "Invalid username or password"
                txtPassword.Text = ""
                If count = 3 Then
                    MsgBox("Application will now close because of too many wrong login attempt")
                    Me.Close()
                End If
            End If
            conn.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub txtUsername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsername.TextChanged
        If txtUsername.TextLength > 0 Then
            ErrorProvider1.Clear()

        End If
    End Sub

    Private Sub txtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged
        If txtUsername.TextLength > 0 Then
            ErrorProvider2.Clear()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Dim obj As New forgotPassword()

        obj.Show()

    End Sub
End Class
