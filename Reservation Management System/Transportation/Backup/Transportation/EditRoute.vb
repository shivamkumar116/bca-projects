Public Class EditRoute
    Dim con As New ADODB.Connection
    Dim rs2 As New ADODB.Recordset

    Private Sub EditRoute_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        Me.MdiParent = main
        con.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Reservation Management System\Transportation.accdb;Persist Security Info=False")
        rs2.Open("select * from Route", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        While Not rs2.EOF
            cbrout.Items.Add(rs2.Fields("Routeid").Value)
            rs2.MoveNext()
        End While

    End Sub

    Private Sub cmdcls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcls.Click
        Me.Close()

    End Sub

    Private Sub cmdsav_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsav.Click

        rs2.Fields("From").Value = txtsorc.Text
        rs2.Fields("To").Value = txtdesti.Text
        rs2.Update()
        MsgBox("Record Updated")
        rs2.Close()
    End Sub

    Private Sub cmdedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdedit.Click
        txtdesti.Text = ""
        txtsorc.Text = ""
        cbrout.Text = ""
    End Sub

    Private Sub cbrout_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbrout.SelectedIndexChanged
        On Error Resume Next
        rs2.Close()
        rs2.Open("select * from Route where Routeid='" & cbrout.Text & "'", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        txtdesti.Text = rs2.Fields("To").Value
        txtsorc.Text = rs2.Fields("From").Value

       End Sub
End Class