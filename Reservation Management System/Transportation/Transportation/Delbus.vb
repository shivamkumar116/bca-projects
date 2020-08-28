Public Class Delbus
    Dim con As New ADODB.Connection
    Dim rs1 As New ADODB.Recordset

    Private Sub cmdcls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcls.Click
        Me.Close()
    End Sub

    Private Sub Delbus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = main
        con.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\Reservation Management System\Transportation.accdb;Persist Security Info=False")
        rs1.Open("select * from Bus", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        While Not rs1.EOF
            cbbus.Items.Add(rs1.Fields("Busid").Value)
            rs1.MoveNext()
        End While
    End Sub

    Private Sub cmddel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddel.Click
        Dim ans As MsgBoxResult

        ans = MsgBox("Are you sure want to delete record ?", MsgBoxStyle.YesNo, "Confirmation")
        If ans = MsgBoxResult.Yes Then
            rs1.Delete()
            txtbtype.Text = ""
            txtdtime.Text = ""
            MsgBox("Record is deleted")
            rs1.Update()
            rs1.Close()
        End If
    End Sub

    Private Sub cbbus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbbus.SelectedIndexChanged
        On Error Resume Next
        rs1.Close()
        rs1.Open("select * from Bus where Busid='" & cbbus.Text & "'", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        txtbtype.Text = rs1.Fields("Bustype").Value
        txtdtime.Text = rs1.Fields("Departuretime").Value
    End Sub
End Class