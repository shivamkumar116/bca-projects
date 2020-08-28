Imports System.Data
Imports System.Data.OleDb

Public Class RedirectStudentForm
    Inherits System.Web.UI.Page
    Dim email As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            If Session("Student") Is Nothing Then
                Response.Redirect("~/Login.aspx")
            End If
            Panel1.Visible = False

            email = Request.QueryString("Email").ToString()
            Dim conn As New OleDbConnection
            Dim cmd As New OleDbCommand
            Dim cmd1 As New OleDbCommand
            Dim name As String
            Dim stat As String
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\University_Website\University_Website\Database\universityDB.accdb"
            conn.Open()
            cmd.CommandText = "select StudentName from stuBasic_Details where Email='" & email & "'"
            cmd1.CommandText = "select Status from status where Email='" & email & "'"
            cmd.Connection = conn
            cmd1.Connection = conn
            name = cmd.ExecuteScalar()
            stat = cmd1.ExecuteScalar()
            lblMessage.ForeColor = Drawing.Color.Green
            lblMessage.Text = "Dear" & " " & name & ", Your application is already Submitted. Status is : " & stat & "."
            conn.Close()
        End If

    End Sub

    Protected Sub btnLogout_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLogout.Click
        Session.RemoveAll()
        Response.Redirect("~/Login.aspx")
    End Sub

    Protected Sub btnDetails_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDetails.Click
        If IsPostBack Then
            email = Request.QueryString("Email")
            Panel1.Visible = True
            Dim conn As New OleDbConnection
            Dim cmd As New OleDbCommand
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\University_Website\University_Website\Database\universityDB.accdb"
            conn.Open()
            cmd.CommandText = "SELECT  stuBasic_Details.Email, stuBasic_Details.StudentName, stuBasic_Details.FatherName, stuBasic_Details.MotherName, stuBasic_Details.Address, stuBasic_Details.DOB, stuBasic_Details.Gender, stuBasic_Details.Mobile, stuBasic_Details.Category, stuQualification_Details.PercentageTenth, stuQualification_Details.BoardTenth, stuQualification_Details.SchoolTenth, stuQualification_Details.PassingYearTenth, stuQualification_Details.PercentageTwelth, stuQualification_Details.BoardTwelth, stuQualification_Details.SchoolTwelth, stuQualification_Details.PassingYearTwelth, stuQualification_Details.CourseOpt FROM (stuBasic_Details INNER JOIN stuQualification_Details ON stuBasic_Details.Email = stuQualification_Details.Email) where stuBasic_Details.Email='" & email.ToString() & "'"
            cmd.Connection = conn
            Dim adp As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            adp.Fill(dt)
            DetailsView1.DataSource = dt
            DetailsView1.DataBind()

        End If
        
    End Sub
End Class