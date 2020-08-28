Imports System.Data
Imports System.Data.OleDb
Public Class AddStudent
    Dim gender As String = ""
    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        If txtName.Text = Nothing Or txtAddress.Text = Nothing Or txtBoard.Text = Nothing Or txtEmail.Text = Nothing Or txtFather.Text = Nothing Or txtMobile.Text = Nothing Or txtMother.Text = Nothing Or txtPassingYear.Text = Nothing Or txtPercentage.Text = Nothing Or txtRollNumber.Text = Nothing Or txtSchool.Text = Nothing Then
            lblError.ForeColor = Color.Red
            lblError.Text = "Error.One or more field left blank.Please check for blank fields"
        Else
            If RadioButton1.Checked Then
                gender = "Male"
            Else
                gender = "Female"
            End If
            Dim conn As New OleDbConnection
            Dim cmd As New OleDbCommand
            Dim cmd1 As New OleDbCommand
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\Student_Management_System\Student_Management_System\Database\studentDB.accdb;Persist Security Info=True"
            conn.Open()
            cmd.CommandText = "INSERT INTO  basicDetails values('" & txtRollNumber.Text & "','" & txtName.Text & "','" & txtFather.Text & "','" & txtMother.Text & "','" & DatePickerDOB.Value & "','" & txtMobile.Text & "','" & gender & "','" & comboCategory.SelectedItem & "','" & txtAddress.Text & "','" & txtEmail.Text & "')"
            cmd1.CommandText = "Insert into basicQualification values('" & txtRollNumber.Text & "','" & txtPercentage.Text & "','" & txtBoard.Text & "','" & txtSchool.Text & "','" & txtPassingYear.Text & "')"
            cmd.Connection = conn
            cmd1.Connection = conn
            Try
                cmd.ExecuteNonQuery()
                cmd1.ExecuteNonQuery()
                lblError.ForeColor = Color.Green
                lblError.Text = "Record Successfully Added :)"
                comboCategory.SelectedItem = ""
                DatePickerDOB.Text = ""
                txtAddress.Text = ""
                txtBoard.Text = ""
                txtEmail.Text = ""
                txtFather.Text = ""
                txtMobile.Text = ""
                txtMother.Text = ""
                txtName.Text = ""
                txtPassingYear.Text = ""
                txtPercentage.Text = ""
                txtRollNumber.Text = ""
                txtSchool.Text = ""

            Catch ex As Exception
                lblError.ForeColor = Color.Red

                lblError.Text = "Something went Wrong"

            End Try

        End If

    End Sub

    Private Sub AddStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblError.Text = ""
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class