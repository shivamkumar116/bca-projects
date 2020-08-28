Public Class EditBus
    Dim con As New ADODB.Connection
    Dim rs1 As New ADODB.Recordset




    Private Sub EditBus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\Reservation Management System\Transportation.accdb;Persist Security Info=False")

        rs1.Open("select * from Bus", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        While Not rs1.EOF
            cbbus.Items.Add(rs1.Fields("Busid").Value)
            rs1.MoveNext()
        End While
        
        Me.MdiParent = main
       

    End Sub

  
    Private Sub cmdcls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcls.Click
        Me.Close()
    End Sub

    
    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        rs1.Fields("Bustype").Value = txtbtype.Text
        rs1.Fields("Departuretime").Value = txtdetime.Text
        rs1.Update()
        MsgBox("Record Updated")
        rs1.Close()
    End Sub

    Private Sub cmdedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdedit.Click
        cbbus.Text = ""
        txtbtype.Text = ""
        txtdetime.Text = ""
    End Sub

    Private Sub cbbus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbbus.SelectedIndexChanged
        On Error Resume Next
        rs1.Close()
        rs1.Open("select * from Bus where Busid='" & cbbus.Text & "'", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        txtbtype.Text = rs1.Fields("Bustype").Value
        txtdetime.Text = rs1.Fields("Departuretime").Value

    End Sub

End Class