Imports System.Data
Imports System.Data.OleDb

Public Class deleteStudent

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click


        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim cmd1 As New OleDbCommand
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\Student_Management_System\Student_Management_System\Database\studentDB.accdb;Persist Security Info=True"
        conn.Open()
        cmd.CommandText = "Select * from basicDetails where RollNumber='" & txtRollNumber.Text & "'"
        cmd.Connection = conn
        cmd1.CommandText = "select Percentage,Board,School,PassingYear from basicQualification where RollNumber='" & txtRollNumber.Text & "'"
        cmd1.Connection = conn
        Dim adp As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable

        adp.Fill(dt)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        Dim dr1 As OleDbDataReader = cmd1.ExecuteReader
      
        If dt.Rows.Count > 0 Then
            Panel2.Show()
            While dr.Read
                lbRoll.Text = dr("RollNumber")
                lbName.Text = dr("StudentName")
                lbFather.Text = dr("FatherName")
                lbMother.Text = dr("MotherName")
                lbDOB.Text = dr("DOB")
                lbGender.Text = dr("Gender")
                lbEmail.Text = dr("Email")
                lbAddress.Text = dr("Address")
                lbMobile.Text = dr("Mobile")
                lbCategory.Text = dr("Category")
            End While
            While dr1.Read
                lbPercentage.Text = dr1("Percentage")
                lbBoard.Text = dr1("Board")
                lbSchool.Text = dr1("School")
                lbPassing.Text = dr1("PassingYear")
            End While
        Else
            MsgBox("No Record found")
        End If


        conn.Close()


    End Sub

    Private Sub txtRollNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRollNumber.TextChanged
        If txtRollNumber.TextLength = 0 Then
            Panel2.Hide()
        End If
    End Sub

    Private Sub deleteStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel2.Hide()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim cmd1 As New OleDbCommand
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\Student_Management_System\Student_Management_System\Database\studentDB.accdb;Persist Security Info=True"
        conn.Open()
        cmd.CommandText = "Delete * from basicDetails where RollNumber= '" & txtRollNumber.Text & "'"
        cmd1.CommandText = "Delete * from basicQualification where RollNumber= '" & txtRollNumber.Text & "'"
        cmd.Connection = conn
        cmd1.Connection = conn
        Try
            MsgBox("Are you sure?", MsgBoxStyle.YesNo)
            If MsgBoxResult.Yes Then
                cmd.ExecuteNonQuery()
                cmd1.ExecuteNonQuery()
                Panel2.Hide()
                MsgBox ("Record Deleted :)",MsgBoxStyle.OkOnly )
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class