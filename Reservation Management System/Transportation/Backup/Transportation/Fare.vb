Public Class Fare
    Dim con As New ADODB.Connection
    Dim rs As New ADODB.Recordset

    Private Sub Fare_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = main
        con.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Reservation Management System\Transportation.accdb;Persist Security Info=False")
        rs.Open("Fare", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

    End Sub

    Private Sub cmdnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnew.Click
        txtbtyp.Text = ""
        txtffadul.Text = ""
        txtrid.Text = ""

    End Sub

    Private Sub cmdcls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcls.Click
        Me.Close()
    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        rs.AddNew()
        rs.Fields("Bustype").Value = txtbtyp.Text
        rs.Fields("Routeid").Value = txtrid.Text
        rs.Fields("Amntadults").Value = txtffadul.Text
        rs.Update()
        MsgBox("Record Saved")

    End Sub
End Class