Public Class ExamInstruction1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Button1.Visible = False



    End Sub

    
   

    Protected Sub CheckBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Button1.Visible = True
        ElseIf CheckBox1.Checked = False Then
            Button1.Visible = False
        End If
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\Examination_system1\Examination_system1\Db\ExamDb.accdb"
        cmd.CommandText = "INSERT INTO Exam_detail  VALUES('" & TextBox1.Text & "','" & TextBox2.Text & " ' ,' " & TextBox3.Text & " ')"
        cmd.Connection = conn
        conn.Open()
        cmd.ExecuteNonQuery()
        Response.Redirect("~/Admin/SetExam.aspx?ExamID=" + TextBox1.Text)

        conn.Close()


    End Sub

   
End Class