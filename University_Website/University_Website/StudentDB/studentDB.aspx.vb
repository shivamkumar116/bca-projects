Imports System.Data
Imports System.Data.OleDb

Imports System.IO

Public Class studentDB
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblMessage.Text = ""
        If Not IsPostBack Then
            If Session("Student") Is Nothing Then
                Response.Redirect("~/Login.aspx")
            End If

            Dim conn As New OleDbConnection
            Dim cmd As New OleDbCommand
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\University_Website\University_Website\Database\universityDB.accdb"
            conn.Open()
            cmd.CommandText = "select * from stuBasic_Details where Email='" & Session("Student") & "'"
            cmd.Connection = conn
            Dim adp As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            adp.Fill(dt)
            If dt.Rows.Count > 0 Then
                Response.Redirect("RedirectStudentForm.aspx?Email=" & Session("Student"))
            Else
                txtEmail.Text = Session("Student").ToString()
                lblFees.Text = ""
                MultiView1.SetActiveView(View1)
            End If
            conn.Close()

          
        End If
    End Sub

    Protected Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
        If txtName.Text = "" Or txtBirth.Text = "" Or TxtAddress.Text = "" Or txtFatherName.Text = "" Or txtMobile.Text = "" Or txtMotherName.Text = "" Then
            lblMessage.ForeColor = Drawing.Color.Red

            lblMessage.Text = "one or more field is left blank"
        Else
            MultiView1.SetActiveView(View2)

            Dim conn As New OleDbConnection
            Dim cmd As New OleDbCommand
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\University_Website\University_Website\Database\universityDB.accdb"
            conn.Open()
            cmd.CommandText = "select Title from courses"
            cmd.Connection = conn
            Dim ds As New DataSet
            Dim adp As New OleDbDataAdapter(cmd)
            adp.Fill(ds)
            dropDownCourse.DataTextField = "Title"
            dropDownCourse.DataValueField = "Title"
            dropDownCourse.DataSource = ds
            dropDownCourse.DataBind()

            conn.Close()
        End If
       

    End Sub

    Protected Sub dropDownCourse_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dropDownCourse.SelectedIndexChanged


        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\University_Website\University_Website\Database\universityDB.accdb"
        conn.Open()
        cmd.CommandText = "select Fees from courses where Title = '" & dropDownCourse.SelectedValue & "'"
        cmd.Connection = conn
        lblFees.Text = "You have to pay rupees " & cmd.ExecuteScalar().ToString() & "/- at the univeristy counter"
        conn.Close()
    End Sub

    Protected Sub btnSendForm_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSendForm.Click
        
        If txtBoard10.Text = "" Or txtBoard12.Text = "" Or txtPercentage10.Text = "" Or txtPercentage12.Text = "" Or txtSchool10.Text = "" Or txtPercentage12.Text = "" Or txtYear10.Text = "" Or txtYear12.Text = "" Or dropDownCourse.Text = "Please Select" Then
            lblFees.Text = "one or more field is left blank"

        Else
            Dim conn As New OleDbConnection
            Dim cmd As New OleDbCommand
            Dim cmd1 As New OleDbCommand

            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\University_Website\University_Website\Database\universityDB.accdb"
            conn.Open()
            cmd.CommandText = "Insert into stuBasic_Details values ('" & Session("Student").ToString() & "','" & txtName.Text & "','" & txtFatherName.Text & "','" & txtMotherName.Text & "','" & TxtAddress.Text & "','" & txtBirth.Text & "','" & dropDownGender.SelectedValue & "','" & txtMobile.Text & "','" & dropDownCategory.SelectedValue & "')"
            cmd1.CommandText = "Insert into stuQualification_Details values ('" & Session("Student").ToString() & "','" & txtPercentage10.Text & "','" & txtBoard10.Text & "','" & txtSchool10.Text & "','" & txtYear10.Text & "','" & txtPercentage12.Text & "','" & txtBoard12.Text & "','" & txtSchool12.Text & "','" & txtYear12.Text & "','" & dropDownCourse.SelectedValue & "')"
            cmd.Connection = conn
            cmd1.Connection = conn
            Try
                cmd.ExecuteNonQuery()
                cmd1.ExecuteNonQuery()
                Response.Redirect("~/StudentDB/RedirectStudentForm.aspx")

            Catch ex As Exception

            End Try
            conn.Close()
        End If


    End Sub

    Protected Sub btnLogout_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLogout.Click
        Session.RemoveAll()
        Response.Redirect("~/Login.aspx")
    End Sub

   

End Class