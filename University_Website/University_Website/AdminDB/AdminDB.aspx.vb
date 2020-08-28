Imports System.Data
Imports System.Data.OleDb
Public Class AdminDB
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim cmd1 As New OleDbCommand
        Dim numberStudent As Integer
        Dim numberCourses As Integer
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\University_Website\University_Website\Database\universityDB.accdb"
        conn.Open()
        cmd.CommandText = "select count(Email) from studentReg"
        cmd1.CommandText = "select count(Title) from courses"
        cmd1.Connection = conn
        cmd.Connection = conn
        numberStudent = Convert.ToInt16(cmd.ExecuteScalar())

        numberCourses = Convert.ToInt16(cmd1.ExecuteScalar())
        lblStudentCount.Text = numberStudent.ToString()
        lblCourseCount.Text = numberCourses.ToString()
    End Sub

End Class