Public Class ViewExam
    Inherits System.Web.UI.Page
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If IsPostBack = False Then


            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\Examination_system1\Examination_system1\Db\ExamDb.accdb"
            conn.Open()
            cmd.Connection = conn
            cmd.CommandText = "Select ExamID from Exam_detail"
            Dim dbdr As OleDb.OleDbDataReader = cmd.ExecuteReader
            While dbdr.Read
                DropDownList1.Items.Add(dbdr("ExamID"))
            End While
            conn.Close()
        End If
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\Examination_system1\Examination_system1\Db\ExamDb.accdb"
        conn.Open()
        cmd.Connection = conn
        cmd.CommandText = "Select QuestionID,Question,Choice1,Choice2,Choice3,Choice4,Answer from Exam_Questions where ExamID='" & DropDownList1.Text & "'"
        cmd.ExecuteNonQuery()
        Dim da As New OleDb.OleDbDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            GridView1.DataSource = dt
            GridView1.DataBind()
        Else
            GridView1.EmptyDataText = "No Question to show for this ExamCode"
        End If
       
    End Sub
End Class