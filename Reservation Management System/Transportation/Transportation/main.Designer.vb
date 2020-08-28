<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.RouteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModifyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewBusRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditBusRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteBusRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewFareRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditFareRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteFareRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TicketToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TicketBookingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TicketCancellingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DailyCashBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Button1 = New System.Windows.Forms.Button
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RouteToolStripMenuItem, Me.BusToolStripMenuItem, Me.FareToolStripMenuItem, Me.TicketToolStripMenuItem, Me.DailyCashBookToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(1009, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RouteToolStripMenuItem
        '
        Me.RouteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.ModifyToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.RouteToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RouteToolStripMenuItem.Name = "RouteToolStripMenuItem"
        Me.RouteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.RouteToolStripMenuItem.Size = New System.Drawing.Size(113, 20)
        Me.RouteToolStripMenuItem.Text = "Route               "
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.NewToolStripMenuItem.Text = "New Route"
        '
        'ModifyToolStripMenuItem
        '
        Me.ModifyToolStripMenuItem.Name = "ModifyToolStripMenuItem"
        Me.ModifyToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ModifyToolStripMenuItem.Text = "Edit Route"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete Route"
        '
        'BusToolStripMenuItem
        '
        Me.BusToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewBusRecordToolStripMenuItem, Me.EditBusRecordToolStripMenuItem, Me.DeleteBusRecordToolStripMenuItem})
        Me.BusToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BusToolStripMenuItem.Name = "BusToolStripMenuItem"
        Me.BusToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BusToolStripMenuItem.Size = New System.Drawing.Size(108, 20)
        Me.BusToolStripMenuItem.Text = " Bus                "
        '
        'NewBusRecordToolStripMenuItem
        '
        Me.NewBusRecordToolStripMenuItem.Name = "NewBusRecordToolStripMenuItem"
        Me.NewBusRecordToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.NewBusRecordToolStripMenuItem.Text = "New Bus Record"
        '
        'EditBusRecordToolStripMenuItem
        '
        Me.EditBusRecordToolStripMenuItem.Name = "EditBusRecordToolStripMenuItem"
        Me.EditBusRecordToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.EditBusRecordToolStripMenuItem.Text = "Edit Bus Record"
        '
        'DeleteBusRecordToolStripMenuItem
        '
        Me.DeleteBusRecordToolStripMenuItem.Name = "DeleteBusRecordToolStripMenuItem"
        Me.DeleteBusRecordToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.DeleteBusRecordToolStripMenuItem.Text = "Delete Bus Record"
        '
        'FareToolStripMenuItem
        '
        Me.FareToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewFareRecordToolStripMenuItem, Me.EditFareRecordToolStripMenuItem, Me.DeleteFareRecordToolStripMenuItem})
        Me.FareToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FareToolStripMenuItem.Name = "FareToolStripMenuItem"
        Me.FareToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FareToolStripMenuItem.Size = New System.Drawing.Size(122, 20)
        Me.FareToolStripMenuItem.Text = "Fare                   "
        '
        'NewFareRecordToolStripMenuItem
        '
        Me.NewFareRecordToolStripMenuItem.Name = "NewFareRecordToolStripMenuItem"
        Me.NewFareRecordToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.NewFareRecordToolStripMenuItem.Text = "New Fare Record"
        '
        'EditFareRecordToolStripMenuItem
        '
        Me.EditFareRecordToolStripMenuItem.Name = "EditFareRecordToolStripMenuItem"
        Me.EditFareRecordToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.EditFareRecordToolStripMenuItem.Text = "Edit Fare Record"
        '
        'DeleteFareRecordToolStripMenuItem
        '
        Me.DeleteFareRecordToolStripMenuItem.Name = "DeleteFareRecordToolStripMenuItem"
        Me.DeleteFareRecordToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.DeleteFareRecordToolStripMenuItem.Text = "Delete Fare Record"
        '
        'TicketToolStripMenuItem
        '
        Me.TicketToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TicketBookingToolStripMenuItem, Me.TicketCancellingToolStripMenuItem})
        Me.TicketToolStripMenuItem.Name = "TicketToolStripMenuItem"
        Me.TicketToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.TicketToolStripMenuItem.Text = "Ticket                "
        '
        'TicketBookingToolStripMenuItem
        '
        Me.TicketBookingToolStripMenuItem.Name = "TicketBookingToolStripMenuItem"
        Me.TicketBookingToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.TicketBookingToolStripMenuItem.Text = "Ticket Booking"
        '
        'TicketCancellingToolStripMenuItem
        '
        Me.TicketCancellingToolStripMenuItem.Name = "TicketCancellingToolStripMenuItem"
        Me.TicketCancellingToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.TicketCancellingToolStripMenuItem.Text = "Ticket Cancelling"
        '
        'DailyCashBookToolStripMenuItem
        '
        Me.DailyCashBookToolStripMenuItem.Name = "DailyCashBookToolStripMenuItem"
        Me.DailyCashBookToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.DailyCashBookToolStripMenuItem.Text = "Daily Cash Book"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(907, 37)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 33)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Log-out"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1009, 446)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "main"
        Me.Text = "Home"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents RouteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewBusRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditBusRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteBusRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FareToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewFareRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditFareRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteFareRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TicketToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DailyCashBookToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TicketBookingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TicketCancellingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
