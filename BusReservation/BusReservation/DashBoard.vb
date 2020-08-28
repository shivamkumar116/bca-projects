Public Class DashBoard

   
   
    Private Sub AddBusToolMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBusToolMenuItem.Click
        Dim obj As New AddBus()
        obj.Show()
    End Sub

    Private Sub DeleteBusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteBusToolStripMenuItem.Click
        Dim obj As New DeleteBus()
        obj.Show()
    End Sub

    Private Sub UpdateInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateInformationToolStripMenuItem.Click
        Dim obj As New UpdateBus()
        obj.Show()
    End Sub

    Private Sub SearchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchToolStripMenuItem.Click
        Dim obj As New SearchBus()
        obj.Show()
    End Sub

    Private Sub SettingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingToolStripMenuItem.Click
        Dim obj As New Settings()

        obj.Show()
    End Sub

    Private Sub DailyCashBookToolStrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DailyCashBookToolStrip.Click
        Dim obj As New DailyCashBook()
        obj.Show()

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim obj As New Login()
        Me.Close()
        obj.Show()
    End Sub

    Private Sub BookTicketToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookTicketToolStripMenuItem.Click

    End Sub
End Class