Public Class Delroute
    Dim con As New ADODB.Connection
    Dim rs2 As New ADODB.Recordset

    Private Sub cmdcls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcls.Click
        Me.Close()

    End Sub

    Private Sub Delroute_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = main
        con.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\Reservation Management System\Transportation.accdb;Persist Security Info=False")
        rs2.Open("select * from Route", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        While Not rs2.EOF
            cbrout.Items.Add(rs2.Fields("Routeid").Value)
            rs2.MoveNext()
        End While

    End Sub

   

    Private Sub cmddel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddel.Click
        Dim ans As MsgBoxResult

        ans = MsgBox("Are you sure want to delete record ?", MsgBoxStyle.YesNo, "Confirmation")
        If ans = MsgBoxResult.Yes Then
            rs2.Delete()
            txtdesti.Text = ""
            txtsorc.Text = ""
            cbrout.Text = ""
            MsgBox("Record is deleted")


            rs2.Update()
            rs2.Close()
        End If

        

    End Sub

    
    Private Sub cbrout_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbrout.SelectedIndexChanged
        On Error Resume Next
        rs2.Close()

        rs2.Open("select * from Route where Routeid='" & cbrout.Text & "'", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        txtdesti.Text = rs2.Fields("To").Value
        txtsorc.Text = rs2.Fields("From").Value
    End Sub
End Class