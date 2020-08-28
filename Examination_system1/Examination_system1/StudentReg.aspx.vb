Public Class StudentReg
    Inherits System.Web.UI.Page
    

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
        ElseIf TextBox6.Text = "" Then
            TextBox6.BorderColor = Drawing.Color.Red
        ElseIf TextBox7.Text = "" Then
            TextBox7.BorderColor = Drawing.Color.Red
        ElseIf TextBox8.Text = "" Then
            TextBox8.BorderColor = Drawing.Color.Red
        ElseIf DropDownList1.SelectedIndex = 0 Then
            DropDownList1.BorderColor = Drawing.Color.Red
        ElseIf DropDownList2.SelectedIndex = 0 Then
            DropDownList2.BorderColor = Drawing.Color.Red
        Else
            Dim conn As New OleDb.OleDbConnection
            Dim cmd As New OleDb.OleDbCommand
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\Examination_system1\Examination_system1\Db\ExamDb.accdb"
            cmd.CommandText = "INSERT INTO  Student_detail VALUES('" & TextBox1.Text & "','" & TextBox2.Text & " ' , ' " & DropDownList1.SelectedValue & " ' , ' " & DropDownList2.SelectedValue & " ' , ' " & TextBox3.Text & " ' , ' " & TextBox4.Text & " ' , ' " & TextBox5.Text & " ' , ' " & TextBox6.Text & " ' , ' " & TextBox7.Text & " ','" & TextBox8.Text & "')"
            cmd.Connection = conn
            conn.Open()
            If TextBox8.Text = TextBox9.Text Then
                cmd.ExecuteNonQuery()
                MsgBox("Account Successfully Generated :)", MsgBoxStyle.Information, Title:="Account Creation")
                Response.Redirect("~/Login.aspx")
            Else
                MsgBox("Password didn't match :(", MsgBoxStyle.Critical, Title:="Account Creation")
            End If

            conn.Close()
        End If
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        DropDownList1.SelectedIndex = 0
        DropDownList2.SelectedIndex = 0
    End Sub

End Class