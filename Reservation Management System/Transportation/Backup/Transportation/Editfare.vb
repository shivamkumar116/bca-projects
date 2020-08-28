Public Class Editfare
    Dim con As New ADODB.Connection
    Dim rs2 As New ADODB.Recordset

    
    Private Sub Editfare_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click

        rs2.Fields("Bustype").Value = txtbtype.Text
        rs2.Fields("Amntadults").Value = txtffadlt.Text

        rs2.Update()

        MsgBox("Record Updated")
        rs2.Close()
    End Sub

    Private Sub cmdedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdedit.Click
        cbrout.Text = ""
        txtbtype.Text = ""
        txtffadlt.Text = ""
    End Sub


    Private Sub cbrout_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbrout.SelectedIndexChanged
        On Error Resume Next
        rs2.Close()
        rs2.Open("select * from Fare where Routeid='" & cbrout.Text & "'", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        txtbtype.Text = rs2.Fields("Bustype").Value
        txtffadlt.Text = rs2.Fields("Amntadults").Value

    End Sub
End Class