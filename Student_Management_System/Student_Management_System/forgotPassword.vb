Imports System.Data.OleDb
Imports System.Data
Public Class forgotPassword

    Private Sub forgotPassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblMessage.Text = Nothing

    End Sub
    Private Sub lblBack_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblBack.LinkClicked
        Me.Close()
        Dim obj As New Login()
        obj.Show()
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        If txtUser.Text = Nothing Then
            ErrorProvider1.SetError(txtUser, "Username cannot be left blank")
        Else
            Dim conn As New OleDbConnection
            Dim cmd As New OleDbCommand
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\Student_Management_System\Student_Management_System\Database\studentDB.accdb;Persist Security Info=True"
            conn.Open()
            cmd.CommandText = "Select Pass from adminLogin where userID=@user "
            cmd.Parameters.AddWithValue("@user", txtUser.Text)
            cmd.Connection = conn
            Dim adp As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            adp.Fill(dt)
            If dt.Rows.Count > 0 Then
                lblMessage.ForeColor = Color.Green
                lblMessage.Text = "Your password for System is : " & " " & cmd.ExecuteScalar()
            Else
                lblMessage.ForeColor = Color.Red
                lblMessage.Text = "Sorry! Username is not registered on our system"
            End If
            conn.Close()
        End If
    End Sub


    Private Sub txtUser_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUser.TextChanged
        If txtUser.TextLength = 0 Then
            lblMessage.Text = ""
        ElseIf txtUser.TextLength > 0 Then
            ErrorProvider1.Clear()
        End If

    End Sub
End Class