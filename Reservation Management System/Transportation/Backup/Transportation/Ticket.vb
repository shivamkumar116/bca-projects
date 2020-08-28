Public Class Ticket
    Dim x As Integer
    Dim seat() As Label
    Dim lb As Label
    Dim con As New ADODB.Connection
    Dim con1 As New ADODB.Connection
    Dim rs, rs4 As New ADODB.Recordset
    Dim rs1 As New ADODB.Recordset
    Dim rs2 As New ADODB.Recordset
    Dim rs3 As New ADODB.Recordset
    Dim rs5 As New ADODB.Recordset
    Dim temprs As New ADODB.Recordset

    Private Sub Ticket_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = main
        con.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Reservation Management System\Transportation.accdb;Persist Security Info=False")
        con1.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Reservation Management System\report.mdb;Persist Security Info=False")
        rs.Open("Ticket", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        rs4.Open("select Count(*)+1 as Num from Ticket", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        rs5.Open("Printticket", con1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        'MsgBox(rs4.Fields("Num").Value)
        rs1.Open("select * from Bus", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        rs2.Open("select * from Route", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        rs3.Open("Fare", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        txtcusid.Text = rs4.Fields("Num").Value

        While Not rs1.EOF
            cbbus.Items.Add(rs1.Fields("Busid").Value)
            rs1.MoveNext()
        End While
        rs1.Close()
        While Not rs2.EOF
            cbrout.Items.Add(rs2.Fields("Routeid").Value)
            rs2.MoveNext()
        End While

        rs2.Close()



        x = 0
        seat = New Label() {Seat1, Seat2, Seat3, Seat4, Seat5, Seat6, Seat7, Seat8, Seat9, Seat10, Seat11, Seat12, Seat13, Seat14, Seat15, Seat16, Seat17, Seat18, Seat19, Seat20, Seat21, Seat22, Seat23, Seat24, Seat25, Seat26, Seat27, Seat28, Seat29, Seat30, Seat31, Seat32, Seat33, Seat34, Seat35, Seat36, Seat37, Seat38, Seat39, Seat40, Seat41, Seat42, Seat43, Seat44, Seat45, Seat46, Seat47}
        For i = 0 To 46
            seat(i).BackColor = Color.White
        Next

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con1.Execute("delete from Printticket")
        rs5.AddNew()
        rs5.Fields("Customerid").Value = txtcusid.Text
        rs5.Fields("Customername").Value = txtcusnm.Text
        rs5.Fields("Routeid").Value = cbrout.Text
        rs5.Fields("Busno").Value = cbbus.Text
        rs5.Fields("Reservationdate").Value = dtpdate.Text
        rs5.Fields("Reservationtime").Value = txttim.Text
        rs5.Fields("Seatno").Value = txtseatno.Text
        rs5.Fields("Amount").Value = txtamnt.Text
        rs5.Fields("From").Value = txtfrm.Text
        rs5.Fields("To").Value = txtto.Text
        'rs5.Fields("Bustype").Value = txtbtyp.Text
        rs5.Update()
        rs5.Close()
        For i = 1 To 100
            report.Refresh()
        Next


        rs.AddNew()
        rs.Fields("Customerid").Value = txtcusid.Text
        rs.Fields("Customername").Value = txtcusnm.Text
        rs.Fields("Routeid").Value = cbrout.Text
        rs.Fields("Busno").Value = cbbus.Text
        rs.Fields("Reservationdate").Value = dtpdate.Text
        rs.Fields("Reservationtime").Value = txttim.Text
        rs.Fields("Seatno").Value = txtseatno.Text
        rs.Fields("Amount").Value = txtamnt.Text
        rs.Fields("From").Value = txtfrm.Text
        rs.Fields("To").Value = txtto.Text
        ' rs.Fields("Bustype").Value = txtbtyp.Text
        rs.Update()
        'If txtamnt.Text = "" Then
        '    lblempty.Text = "One Of The Field Remain Empty"
        'ElseIf txtbtyp.Text = "" Then
        '    lblempty.Text = "One Of The Field Remain Empty"
        'ElseIf txtcusid.Text = "" Then
        '    lblempty.Text = "One Of The Field Remain Empty"
        'ElseIf txtcusnm.Text = "" Then
        '    lblempty.Text = "One Of The Field Remain Empty"
        'ElseIf txtfrm.Text = "" Then
        '    lblempty.Text = "One Of The Field Remain Empty"
        'ElseIf txtseatno.Text = "" Then
        '    lblempty.Text = "One Of The Field Remain Empty"
        'ElseIf txttim.Text = "" Then
        '    lblempty.Text = "One Of The Field Remain Empty"
        'ElseIf txtto.Text = "" Then
        '    lblempty.Text = "One Of The Field Remain Empty"
        'ElseIf cbbus.Text = "" Then
        '    lblempty.Text = "One Of The Field Remain Empty"
        'ElseIf cbrout.Text = "" Then
        '    lblempty.Text = "One Of The Field Remain Empty"
        'ElseIf dtpdate.Text = "" Then
        '    lblempty.Text = "One Of The Field Remain Empty"
        'End If
        



        MsgBox("Record saved")
        txtamnt.Text = ""
        txtbtyp.Text = ""
        txtcusid.Text = ""
        txtcusnm.Text = ""
        txtfrm.Text = ""
        txtseatno.Text = ""
        txttim.Text = ""
        txtto.Text = ""
        cbbus.Text = ""
        cbrout.Text = ""
        report.PrintToPrinter(1, True, 0, 0)


    End Sub

    Private Sub cbbus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbbus.SelectedIndexChanged
        rs1.Open("select * from Bus where Busid='" & cbbus.Text & "'", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        txtbtyp.Text = rs1.Fields("Bustype").Value
        txttim.Text = rs1.Fields("Departuretime").Value

        rs1.Close()

    End Sub

    Private Sub cbrout_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbrout.SelectedIndexChanged
        rs2.Open("select * from Fare where Routeid='" & cbrout.Text & "'", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        txtamnt.Text = rs2.Fields("Amntadults").Value
        rs2.Close()
        rs2.Open("select * from Route where Routeid='" & cbrout.Text & "'", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        txtfrm.Text = rs2.Fields("From").Value
        txtto.Text = rs2.Fields("To").Value
        rs2.Close()
    End Sub

    Private Sub Seat1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Seat1.Click, Seat2.Click, Seat3.Click, Seat4.Click, Seat5.Click, Seat6.Click, Seat7.Click, Seat8.Click, Seat9.Click, Seat10.Click, Seat11.Click, Seat12.Click, Seat13.Click, Seat14.Click, Seat15.Click, Seat16.Click, Seat17.Click, Seat18.Click, Seat19.Click, Seat20.Click, Seat21.Click, Seat22.Click, Seat23.Click, Seat24.Click, Seat25.Click, Seat26.Click, Seat27.Click, Seat28.Click, Seat29.Click, Seat30.Click, Seat31.Click, Seat32.Click, Seat33.Click, Seat34.Click, Seat35.Click, Seat36.Click, Seat37.Click, Seat38.Click, Seat39.Click, Seat40.Click, Seat41.Click, Seat42.Click, Seat43.Click, Seat44.Click, Seat45.Click, Seat46.Click, Seat47.Click
        lb = sender
        'MsgBox(sender.Text)
        For i = 0 To 46
            If lb.Text = seat(i).Text Then
                If seat(i).BackColor = Color.GreenYellow Then
                    txtseatno.Text = ""
                    seat(i).BackColor = Color.White
                Else
                    seat(i).BackColor = Color.GreenYellow
                    txtseatno.Text = lb.Text
                End If
            End If
        Next
    End Sub

    

    Private Sub cmddetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddetail.Click
        temprs.Open("select seatno from ticket where busno='" & cbbus.Text & "' and routeid='" & cbrout.Text & "' and reservationdate=#" & dtpdate.Text & "#", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        For i = 0 To 46
            seat(i).BackColor = Color.White
        Next
        If Not temprs.EOF Then
            For i = 0 To 46
                temprs.MoveFirst()
                While Not temprs.EOF
                    If temprs.Fields("seatno").Value = seat(i).Text Then
                        seat(i).BackColor = Color.GreenYellow
                    End If
                    temprs.MoveNext()
                End While
            Next
        End If
        temprs.Close()
    End Sub

   
   
    Private Sub cmdclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclose.Click
        Me.Close()
    End Sub
End Class