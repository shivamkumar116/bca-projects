Public Class Dailycashbook
    Dim con As New ADODB.Connection
    Dim rs As New ADODB.Recordset

    Private Sub Dailycashbook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Reservation Management System\Transportation.accdb;Persist Security Info=False")

    End Sub

    Private Sub cmdshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdshow.Click
        Dim tot As Double
        tot = 0
        rs.Open("select * from Ticket where Reservationdate= #" & dtp1.Text & "# ", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
       

        grid.Rows.Clear()
        While Not rs.EOF
            grid.Rows.Add(rs.Fields("customerid").Value, rs.Fields("Customername").Value, rs.Fields("amount").Value, rs.Fields("Routeid").Value)
            tot = tot + Val(rs.Fields("Amount").Value)
            rs.MoveNext()
        End While

        rs.Close()

    End Sub

    

    
   
    Private Sub cmdcls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcls.Click
        Me.Close()
    End Sub

    
End Class