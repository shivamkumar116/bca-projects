Public Class main

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        route.Show()
    End Sub

   
    Private Sub ModifyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifyToolStripMenuItem.Click
        EditRoute.Show()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Delroute.Show()
    End Sub

    Private Sub NewBusRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewBusRecordToolStripMenuItem.Click
        busform.Show()
    End Sub

    Private Sub EditBusRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditBusRecordToolStripMenuItem.Click
        EditBus.Show()
    End Sub

    Private Sub DeleteBusRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteBusRecordToolStripMenuItem.Click
        Delbus.Show()
    End Sub

    Private Sub NewFareRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewFareRecordToolStripMenuItem.Click
        Fare.Show()

    End Sub

    Private Sub EditFareRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditFareRecordToolStripMenuItem.Click
        Editfare.Show()

    End Sub

    Private Sub DeleteFareRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteFareRecordToolStripMenuItem.Click
        delfare.Show()
    End Sub

    Private Sub TicketToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TicketToolStripMenuItem.Click

    End Sub

    Private Sub main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        login.ShowDialog()
    End Sub


    Private Sub DailyCashBookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DailyCashBookToolStripMenuItem.Click
        Dailycashbook.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        login.ShowDialog()
    End Sub

    Private Sub TicketBookingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TicketBookingToolStripMenuItem.Click
        Ticket.Show()
    End Sub

    Private Sub TicketCancellingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TicketCancellingToolStripMenuItem.Click
        Cancel_Ticket.Show()
    End Sub
End Class