Public Class Cancel_Ticket
    Dim con As New ADODB.Connection
    Dim rs1 As New ADODB.Recordset
    Dim rs2 As New ADODB.Recordset


   
    Private Sub Cancel_Ticket_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Reservation Management System\Transportation.accdb;Persist Security Info=False")
        rs2.Open("Cancelticket", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        Me.MdiParent = main
    End Sub

    

    Private Sub txtcid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcid.KeyDown
        If e.KeyCode = Keys.Enter Then
            rs1.Open("select * from Ticket where Customerid=" & txtcid.Text, con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            'lblbtyp.Text = rs1.Fields("Bustype").Value
            lblcname.Text = rs1.Fields("Customername").Value
            lblfare.Text = rs1.Fields("Amount").Value
            lblrdate.Text = rs1.Fields("Reservationdate").Value
            lblrid.Text = rs1.Fields("Routeid").Value
            lblrtime.Text = rs1.Fields("Reservationtime").Value
            lblseatno.Text = rs1.Fields("Seatno").Value
            lblto.Text = rs1.Fields("To").Value
            lblfrm.Text = rs1.Fields("from").Value
            rs1.Close()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ans As MsgBoxResult
        ans = MsgBox("Are you sure want to delete record ?", MsgBoxStyle.YesNo, "Confirmation")
        If ans = MsgBoxResult.Yes Then

            rs2.AddNew()
            rs2.Fields("Customerid").Value = txtcid.Text

            'rs2.Fields("Bustype").Value = lblbtyp.Text
            rs2.Fields("Customername").Value = lblcname.Text
            rs2.Fields("Fare").Value = lblfare.Text

            rs2.Fields("Reservationdate").Value = lblrdate.Text

            rs2.Fields("Routeid").Value = lblrid.Text

            rs2.Fields("Reservationtime").Value = lblrtime.Text
            rs2.Fields("Seatno").Value = lblseatno.Text
            rs2.Fields("To").Value = lblto.Text

            rs2.Fields("from").Value = lblfrm.Text
            rs2.Update()
            rs1.Open("Ticket", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            rs1.Delete()
            MsgBox("Ticket Is Cancelled")
            rs1.Close()
            txtcid.Text = ""
            'lblbtyp.Text = ""
            lblcname.Text = ""
            lblfare.Text = ""
            lblfrm.Text = ""
            lblrdate.Text = ""
            lblrid.Text = ""
            lblrtime.Text = ""
            lblseatno.Text = ""
            lblto.Text = ""
        End If
    End Sub

    Private Sub cmdcls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcls.Click
        Me.Close()
    End Sub

    
End Class