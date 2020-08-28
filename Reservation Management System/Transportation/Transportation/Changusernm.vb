Public Class Changusernm

    Dim con As New ADODB.Connection
    Dim rs As New ADODB.Recordset

    
    
    Private Sub Changusernm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\Reservation Management System\Transportation.accdb;Persist Security Info=False")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdchng.Click
        rs.Open("Usertab ", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        If txtpass.Text = "z" And txtoldus.Text = rs.Fields("Userid").Value Then
            rs.Fields("Userid").Value = txtnwus.Text
            rs.Update()
            MsgBox("User-Name is changed")

        Else
            MsgBox("Username And Password Doesn't Match", MsgBoxStyle.Critical, "Invalid Data")
        End If
        txtnwus.Text = ""
        txtoldus.Text = ""
        txtnwus.Text = ""
        rs.Close()

    End Sub

    
    Private Sub cmdcls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcls.Click
        Me.Close()

    End Sub
End Class