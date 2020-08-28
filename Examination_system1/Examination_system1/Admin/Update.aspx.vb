

Imports System.Data.OleDb
Imports System.Data
Public Class Update
    Inherits System.Web.UI.Page
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim cmd2 As New OleDb.OleDbCommand
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Panel1.Visible = False
        Label1.Text = ""



    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
       
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\Examination_system1\Examination_system1\Db\ExamDb.accdb"

        If DropDownList1.SelectedValue = "Roll number" Then

            cmd.CommandText = "SELECT * FROM  Student_detail WHERE RollNo= ' " & TextBox1.Text & " ' "
        ElseIf DropDownList1.SelectedValue = "Email-ID" Then
            cmd.CommandText = "SELECT * FROM  Student_detail WHERE UserID = ' " & TextBox1.Text & " ' "

        End If
        cmd.Connection = conn
        conn.Open()
        Panel1.Visible = True

        Dim dbdr As OleDb.OleDbDataReader = cmd.ExecuteReader

        While dbdr.Read
            TextBox2.Text = dbdr("StudentName")
            TextBox3.Text = dbdr("Address")
            TextBox4.Text = dbdr("State")
            TextBox5.Text = dbdr("DOB")
            TextBox6.Text = dbdr("UserID")
            TextBox7.Text = dbdr("Mobile")
            TextBox8.Text = dbdr("Class")
            TextBox9.Text = dbdr("RollNo")
            TextBox10.Text = dbdr("Password")
            TextBox11.Text = dbdr("Gender")
        End While





        conn.Close()


    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\Examination_system1\Examination_system1\Db\ExamDb.accdb"
        cmd2.Connection = conn
        conn.Open()
        If DropDownList1.SelectedValue = "Roll number" Then

            cmd2.CommandText = "DELETE * FROM  Student_detail WHERE RollNo= ' " & TextBox1.Text & " ' "
            MsgBox("Are you sure you want to delete the record?", MsgBoxStyle.OkCancel, Title:="Delete")
            If MsgBoxResult.Ok Then
                cmd2.ExecuteNonQuery()
                Label1.Text = "Record Deleted!"
                TextBox1.Text = ""
            End If

           
            Response.Redirect("~/Admin/Update.aspx")
        ElseIf DropDownList1.SelectedValue = "Email-ID" Then
            cmd2.CommandText = "DELETE * FROM  Student_detail WHERE UserID = ' " & TextBox1.Text & " ' "
            If MsgBoxResult.Ok Then
                cmd2.ExecuteNonQuery()
                Label1.Text = "Record Deleted!"
                TextBox1.Text = ""
            End If
            Response.Redirect("~/Admin/Update.aspx")
        End If
        conn.Close()
    End Sub

   
End Class