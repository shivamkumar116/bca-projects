Public Class forgotPassword

    Private Sub lblBack_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblBack.LinkClicked
        Dim obj As New Login()
        Me.Close()
        obj.Show()
    End Sub
End Class