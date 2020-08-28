Imports System.Data.OleDb
Imports System.Timers.Timer
Imports System.Data

Public Class MainExam

    Inherits System.Web.UI.Page
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim cmd1 As New OleDb.OleDbCommand
    Dim cmd2 As New OleDb.OleDbCommand
    Dim cmd3 As New OleDb.OleDbCommand
    
    Public Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("Email") Is Nothing Then
            Response.Redirect("~/Login.aspx")
        End If

        Dim code As String = Request.QueryString("ExamCode")


        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\Examination_system1\Examination_system1\Db\ExamDb.accdb"
        cmd.CommandText = "select * FROM Exam_Questions where ExamID='" & code & "'"
        cmd.Connection = conn
        conn.Open()
        cmd.ExecuteNonQuery()

        Dim da As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)


        If dt.Rows.Count > 0 Then
            If IsPostBack = False Then
                grd.DataSource = dt

                grd.DataBind()
            End If


        Else
            grd.EmptyDataText = "Empty"
        End If

        cmd2.CommandText = "Select * from Exam_detail where ExamID='" & code & "'"
        cmd2.Connection = conn
        Dim rdr As OleDbDataReader = cmd2.ExecuteReader()
        rdr.Read()
        Label1.Text = rdr("ExamHeading").ToString()
        Label2.Text = rdr("SetBy").ToString()

        conn.Close()

    End Sub
  

    Protected Sub btn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn.Click
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\Examination_system1\Examination_system1\Db\ExamDb.accdb"
        conn.Open()
        
        Dim r1 As RadioButton, r2 As RadioButton, r3 As RadioButton, r4 As RadioButton
        Dim hdn As HiddenField
        Dim count As Double = 0
        Dim selans As String = "-1"
        For i As Integer = 0 To grd.Rows.Count - 1
            r1 = DirectCast(grd.Rows(i).Cells(0).FindControl("rad1"), RadioButton)
            r2 = DirectCast(grd.Rows(i).Cells(0).FindControl("rad2"), RadioButton)
            r3 = DirectCast(grd.Rows(i).Cells(0).FindControl("rad3"), RadioButton)
            r4 = DirectCast(grd.Rows(i).Cells(0).FindControl("rad4"), RadioButton)
            hdn = DirectCast(grd.Rows(i).Cells(0).FindControl("hf"), HiddenField)
            If r1.Checked Then
                selans = "1"
            ElseIf r2.Checked Then
                selans = "2"
            ElseIf r3.Checked Then
                selans = "3"
            ElseIf r4.Checked Then
                selans = "4"
            End If

            If hdn.Value = selans Then
                count += 1
            End If

        Next
        cmd1.Connection = conn

        cmd1.CommandText = "Insert into Result Values('" & Session("Email").ToString() & "','" & count & "')"
        cmd1.ExecuteNonQuery()
        Response.Redirect("~/Client/StudentResult.aspx?Score=" & count)

    End Sub
 
End Class