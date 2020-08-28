<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashBoard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AddBusToolMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteBusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookTicketToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DailyCashBookToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.SeaGreen
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddBusToolMenuItem, Me.DeleteBusToolStripMenuItem, Me.UpdateInformationToolStripMenuItem, Me.SearchToolStripMenuItem, Me.BookTicketToolStripMenuItem, Me.DailyCashBookToolStrip, Me.SettingToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(170, 474)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AddBusToolMenuItem
        '
        Me.AddBusToolMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.AddBusToolMenuItem.ForeColor = System.Drawing.Color.White
        Me.AddBusToolMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddBusToolMenuItem.Margin = New System.Windows.Forms.Padding(0, 30, 0, 0)
        Me.AddBusToolMenuItem.Name = "AddBusToolMenuItem"
        Me.AddBusToolMenuItem.Padding = New System.Windows.Forms.Padding(0)
        Me.AddBusToolMenuItem.Size = New System.Drawing.Size(157, 24)
        Me.AddBusToolMenuItem.Text = "Add Bus"
        Me.AddBusToolMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DeleteBusToolStripMenuItem
        '
        Me.DeleteBusToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.DeleteBusToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DeleteBusToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 30, 0, 0)
        Me.DeleteBusToolStripMenuItem.Name = "DeleteBusToolStripMenuItem"
        Me.DeleteBusToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0)
        Me.DeleteBusToolStripMenuItem.Size = New System.Drawing.Size(157, 24)
        Me.DeleteBusToolStripMenuItem.Text = "Delete Bus"
        Me.DeleteBusToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UpdateInformationToolStripMenuItem
        '
        Me.UpdateInformationToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.UpdateInformationToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 30, 0, 0)
        Me.UpdateInformationToolStripMenuItem.Name = "UpdateInformationToolStripMenuItem"
        Me.UpdateInformationToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0)
        Me.UpdateInformationToolStripMenuItem.Size = New System.Drawing.Size(157, 24)
        Me.UpdateInformationToolStripMenuItem.Text = "Update Information"
        Me.UpdateInformationToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SearchToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SearchToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 30, 0, 0)
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0)
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(157, 24)
        Me.SearchToolStripMenuItem.Text = "Search"
        Me.SearchToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BookTicketToolStripMenuItem
        '
        Me.BookTicketToolStripMenuItem.AutoSize = False
        Me.BookTicketToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.BookTicketToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BookTicketToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 30, 0, 0)
        Me.BookTicketToolStripMenuItem.Name = "BookTicketToolStripMenuItem"
        Me.BookTicketToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0)
        Me.BookTicketToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BookTicketToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.BookTicketToolStripMenuItem.Text = "Book Ticket"
        Me.BookTicketToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DailyCashBookToolStrip
        '
        Me.DailyCashBookToolStrip.ForeColor = System.Drawing.Color.White
        Me.DailyCashBookToolStrip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DailyCashBookToolStrip.Margin = New System.Windows.Forms.Padding(0, 30, 0, 0)
        Me.DailyCashBookToolStrip.Name = "DailyCashBookToolStrip"
        Me.DailyCashBookToolStrip.Size = New System.Drawing.Size(157, 24)
        Me.DailyCashBookToolStrip.Text = "Daily Cash Book"
        Me.DailyCashBookToolStrip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SettingToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SettingToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 30, 0, 0)
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0)
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(157, 24)
        Me.SettingToolStripMenuItem.Text = "Setting"
        Me.SettingToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.LogoutToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LogoutToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 30, 0, 0)
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0)
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(157, 24)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        Me.LogoutToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DashBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 474)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "DashBoard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "DashBoard | Bus Reservation System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AddBusToolMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteBusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateInformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookTicketToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DailyCashBookToolStrip As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
