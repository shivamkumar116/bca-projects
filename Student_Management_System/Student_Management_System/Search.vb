Imports System.Data
Imports System.Data.OleDb
Public Class Search
    Private bitmap As Bitmap


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
            Panel3.Show()
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

    Private Sub Search_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel3.Hide()
    End Sub

    Private Sub txtRollNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRollNumber.TextChanged
        If txtRollNumber.TextLength = 0 Then
            Panel3.Hide()
        End If
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Dim panel As New Panel()
        Me.Controls.Add(panel)
        Dim grp As Graphics = panel.CreateGraphics()
        Dim formsize As Size = Me.ClientSize
        bitmap = New Bitmap(formsize.Width, formsize.Height, grp)
        grp = Graphics.FromImage(bitmap)

        Dim panelLocation As Point = PointToScreen(panel.Location)
        grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formsize)

        PrintDialog1.Document = PrintDocument1
        PrintDialog1.ShowDialog()
        PrintDocument1.Print()


    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bitmap, 0, 0)
    End Sub
End Class