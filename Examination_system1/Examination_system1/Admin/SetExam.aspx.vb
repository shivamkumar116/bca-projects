Imports System.Data.OleDb
Imports System.Data

Public Class SetExam1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        TxtExamCode.Text = Request.QueryString("ExamID")


    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            TextBox1.BorderColor = Drawing.Color.Red
        ElseIf TextBox2.Text = "" Then
            TextBox2.BorderColor = Drawing.Color.Red
        ElseIf TextBox3.Text = "" Then
            TextBox3.BorderColor = Drawing.Color.Red
        ElseIf TextBox4.Text = "" Then
            TextBox4.BorderColor = Drawing.Color.Red
        ElseIf TextBox5.Text = "" Then
            TextBox5.BorderColor = Drawing.Color.Red
        Else

            Dim answer As String = "-1"
            If RadioButton1.Checked Then
                answer = "1"
            ElseIf RadioButton2.Checked = True Then
                answer = "2"
            ElseIf RadioButton3.Checked = True Then
                answer = "3"
            ElseIf RadioButton4.Checked = True Then
                answer = "4"
            End If

            Dim conn As New OleDb.OleDbConnection
            Dim cmd As New OleDb.OleDbCommand
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\Examination_system1\Examination_system1\Db\ExamDb.accdb"
            cmd.CommandText = "INSERT INTO  Exam_Questions(Question,Choice1,Choice2,Choice3,Choice4,Answer,ExamID) VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "' ,'" & TextBox3.Text & "' , '" & TextBox4.Text & "' , '" & TextBox5.Text & "' ,'" & answer.ToString & "','" & TxtExamCode.Text & "')"
            cmd.Connection = conn
            conn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Saved ")
            conn.Close()
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False

        End If


    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Response.Redirect("~/Admin/Dashboard.aspx")
    End Sub
End Class