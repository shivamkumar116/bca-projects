Imports System.Data
Imports System.Data.OleDb
Public Class update

    Private Sub update_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblError.Text = ""
        Panel2.Hide()
    End Sub
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
                txtRoll.Text = dr("RollNumber")
                txtName.Text = dr("StudentName")
                txtFather.Text = dr("FatherName")
                txtMother.Text = dr("MotherName")
                txtDOB.Text = dr("DOB")
                txtGender.Text = dr("Gender")
                txtEmail.Text = dr("Email")
                txtAddress.Text = dr("Address")
                txtMobile.Text = dr("Mobile")
                txtCategory.Text = dr("Category")
            End While
            While dr1.Read
                txtPercentage.Text = dr1("Percentage")
                txtBoard.Text = dr1("Board")
                txtSchool.Text = dr1("School")
                txtPassingYear.Text = dr1("PassingYear")
            End While
        Else
            MsgBox("No Record found")
        End If


        conn.Close()

    End Sub


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtRollNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRollNumber.TextChanged
        If txtRollNumber.TextLength = 0 Then
            Panel2.Hide()
        End If
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim cmd1 As New OleDbCommand
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\Student_Management_System\Student_Management_System\Database\studentDB.accdb;Persist Security Info=True"
        conn.Open()
        cmd.CommandText = "UPDATE basicDetails set StudentName = '" & txtName.Text & "',FatherName='" & txtFather.Text & "', MotherName='" & txtMother.Text & "',DOB='" & txtDOB.Text & "',Mobile='" & txtMobile.Text & "',Gender='" & txtGender.Text & "',Category='" & txtCategory.Text & "',Address='" & txtAddress.Text & "',Email='" & txtEmail.Text & "' where RollNumber='" & txtRoll.Text & "'"
        cmd.Connection = conn
        cmd1.CommandText = "UPDATE basicQualification set Percentage ='" & txtPercentage.Text & "',Board='" & txtBoard.Text & "',School='" & txtSchool.Text & "',PassingYear='" & txtPassingYear.Text & "' where RollNumber='" & txtRoll.Text & "'"
        cmd1.Connection = conn
        Try
            cmd.ExecuteNonQuery()
            cmd1.ExecuteNonQuery()
            lblError.ForeColor = Color.Green
            lblError.Text = "Record Updated"
            txtAddress.Text = ""
            txtBoard.Text = ""
            txtEmail.Text = ""
            txtFather.Text = ""
            txtMobile.Text = ""
            txtMother.Text = ""
            txtName.Text = ""
            txtPassingYear.Text = ""
            txtPercentage.Text = ""
            txtRoll.Text = ""
            txtSchool.Text = ""
            txtDOB.Text = ""
            txtCategory.Text = ""
            txtGender.Text = ""

        Catch ex As Exception
            lblError.ForeColor = Color.Red

            lblError.Text = "Something Went Wrong"
        End Try
    End Sub



    
End Class