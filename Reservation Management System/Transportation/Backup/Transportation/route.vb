Public Class route
    Dim con As New ADODB.Connection
    Dim rs As New ADODB.Recordset

    Private Sub route_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = main
        con.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Reservation Management System\Transportation.accdb;Persist Security Info=False")
        rs.Open("Route", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        rs.AddNew()
        rs.Fields("Routeid").Value = txtrid.Text
        rs.Fields("From").Value = txtfrm.Text
        rs.Fields("To").Value = txtdesti.Text
        rs.Update()
        MsgBox("Record saved")


    End Sub

    Private Sub cmdnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnew.Click
        txtdesti.Text = ""
        txtfrm.Text = ""
        txtrid.Text = ""

    End Sub

    Private Sub cmdcls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcls.Click
        Me.Close()

    End Sub
End Class