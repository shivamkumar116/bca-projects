Public Class Changpass
    Dim con As New ADODB.Connection
    Dim rs As New ADODB.Recordset
    Private Sub cmdchng_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdchng.Click
        rs.Open("Usertab ", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        If txtusr.Text = "a" And txtol.Text = rs.Fields("Password").Value Then
            rs.Fields("Password").Value = txtnew.Text
            rs.Update()
            MsgBox("Password is changed")

        Else
            MsgBox("Username And Password Doesn't Match", MsgBoxStyle.Critical, "Invalid Data")
        End If
        txtnew.Text = ""
        txtol.Text = ""
        txtusr.Text = ""
        rs.Close()


    End Sub

    Private Sub Changpass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\Reservation Management System\Transportation.accdb;Persist Security Info=False")
    End Sub

    
    Private Sub cmdcls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcls.Click
        Me.Close()
    End Sub

    
End Class