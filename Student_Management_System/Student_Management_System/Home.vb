Public Class Home

    Private Sub AddStudentToolMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddStudentToolMenuItem.Click
        Dim obj As New AddStudent()
        obj.Show()
    End Sub


    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Hide()
        Dim obj As New Login()
        obj.Show()
    End Sub

    Private Sub DeleteStudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteStudentToolStripMenuItem.Click
        Dim obj As New deleteStudent()
        obj.Show()
    End Sub

    Private Sub UpdateInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateInformationToolStripMenuItem.Click
        Dim obj As New update()
        obj.Show()
    End Sub

    Private Sub SettingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingToolStripMenuItem.Click
        Dim obj As New settings()
        obj.Show()
    End Sub

    Private Sub AllRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllRecordToolStripMenuItem.Click
        Dim obj As New allRecords()
        obj.Show()
    End Sub

    Private Sub SearchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchToolStripMenuItem.Click
        Dim obj As New Search()
        obj.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Dim obj As New Report()
        obj.Show()
    End Sub
End Class