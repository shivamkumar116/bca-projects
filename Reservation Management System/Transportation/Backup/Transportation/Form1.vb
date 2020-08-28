Public Class busform
    Dim con As New ADODB.Connection
    Dim rs As New ADODB.Recordset

    Private Sub cmdcls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcls.Click
        Me.Close()
    End Sub

   

    Private Sub cmdnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnew.Click

        txtbid.Text = ""
        txtbtyp.Text = ""


        txtbtime.Text = ""

    End Sub

    Private Sub cmdsav_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsav.Click
        rs.AddNew()
        rs.Fields("Busid").Value = txtbid.Text
        rs.Fields("Bustype").Value = txtbtyp.Text


        rs.Fields("Departuretime").Value = txtbtime.Text
        rs.Update()
        MsgBox("Record Saved")

    End Sub

    Private Sub busform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = main

        con.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Reservation Management System\Transportation.accdb;Persist Security Info=False")
        rs.Open("Bus", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

    End Sub
End Class
