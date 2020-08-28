Public Class Result1
    Inherits System.Web.UI.Page
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\Examination_system1\Examination_system1\Db\ExamDb.accdb"
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = " SELECT * FROM  Result where Email='" & TextBox1.Text & "'"
        cmd.Connection = conn

        cmd.ExecuteNonQuery()
        Dim da As New OleDb.OleDbDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        GridView1.DataSource = dt
        GridView1.DataBind()





        conn.Close()
    End Sub
End Class