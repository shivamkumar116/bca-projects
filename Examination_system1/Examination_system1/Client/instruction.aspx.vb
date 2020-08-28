Imports System.Data
Imports System.Data.OleDb

Public Class instruction
    Inherits System.Web.UI.Page
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("Email") Is Nothing Then
            Response.Redirect("~/Login.aspx")
        Else
            Label1.Text = "Welcome" & " " & Session("Email").ToString()
        End If
        If IsPostBack = False Then


            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\Examination_system1\Examination_system1\Db\ExamDb.accdb"
            conn.Open()
            cmd.Connection = conn
            cmd.CommandText = "Select ExamID from Exam_detail"
            Dim dbdr As OleDb.OleDbDataReader = cmd.ExecuteReader
            While dbdr.Read
                DropDownList1.Items.Add(dbdr("ExamID"))
            End While
            conn.Close()
        End If

    End Sub

    Protected Sub Btn1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn.ServerClick
        Response.Redirect("~/Client/MainExam.aspx?ExamCode=" & DropDownList1.Text)
    End Sub
End Class