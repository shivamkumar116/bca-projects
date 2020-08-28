<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AddStudentToolMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.MenuStrip1)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(557, 441)
        Me.Panel2.TabIndex = 3
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.SeaGreen
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddStudentToolMenuItem, Me.DeleteStudentToolStripMenuItem, Me.UpdateInformationToolStripMenuItem, Me.SearchToolStripMenuItem, Me.AllRecordToolStripMenuItem, Me.ToolStripMenuItem1, Me.SettingToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(175, 441)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(557, 441)
        Me.Panel1.TabIndex = 1
        '
        'AddStudentToolMenuItem
        '
        Me.AddStudentToolMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.AddStudentToolMenuItem.ForeColor = System.Drawing.Color.White
        Me.AddStudentToolMenuItem.Image = Global.Student_Management_System.My.Resources.Resources.Add_User_Male_96px
        Me.AddStudentToolMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddStudentToolMenuItem.Margin = New System.Windows.Forms.Padding(0, 30, 0, 0)
        Me.AddStudentToolMenuItem.Name = "AddStudentToolMenuItem"
        Me.AddStudentToolMenuItem.Padding = New System.Windows.Forms.Padding(0)
        Me.AddStudentToolMenuItem.Size = New System.Drawing.Size(162, 24)
        Me.AddStudentToolMenuItem.Text = "Add Student"
        Me.AddStudentToolMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DeleteStudentToolStripMenuItem
        '
        Me.DeleteStudentToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.DeleteStudentToolStripMenuItem.Image = Global.Student_Management_System.My.Resources.Resources.Denied_96px
        Me.DeleteStudentToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DeleteStudentToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 30, 0, 0)
        Me.DeleteStudentToolStripMenuItem.Name = "DeleteStudentToolStripMenuItem"
        Me.DeleteStudentToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0)
        Me.DeleteStudentToolStripMenuItem.Size = New System.Drawing.Size(162, 24)
        Me.DeleteStudentToolStripMenuItem.Text = "Delete Student"
        Me.DeleteStudentToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UpdateInformationToolStripMenuItem
        '
        Me.UpdateInformationToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.UpdateInformationToolStripMenuItem.Image = Global.Student_Management_System.My.Resources.Resources.Change_User_96px
        Me.UpdateInformationToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 30, 0, 0)
        Me.UpdateInformationToolStripMenuItem.Name = "UpdateInformationToolStripMenuItem"
        Me.UpdateInformationToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0)
        Me.UpdateInformationToolStripMenuItem.Size = New System.Drawing.Size(162, 24)
        Me.UpdateInformationToolStripMenuItem.Text = "Update Information"
        Me.UpdateInformationToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SearchToolStripMenuItem.Image = Global.Student_Management_System.My.Resources.Resources.Find_User_Male_96px
        Me.SearchToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SearchToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 30, 0, 0)
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0)
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(162, 24)
        Me.SearchToolStripMenuItem.Text = "Search"
        Me.SearchToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AllRecordToolStripMenuItem
        '
        Me.AllRecordToolStripMenuItem.AutoSize = False
        Me.AllRecordToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AllRecordToolStripMenuItem.Image = Global.Student_Management_System.My.Resources.Resources.User_Groups_96px
        Me.AllRecordToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AllRecordToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 30, 0, 0)
        Me.AllRecordToolStripMenuItem.Name = "AllRecordToolStripMenuItem"
        Me.AllRecordToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0)
        Me.AllRecordToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.AllRecordToolStripMenuItem.Size = New System.Drawing.Size(164, 24)
        Me.AllRecordToolStripMenuItem.Text = "All Record"
        Me.AllRecordToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem1.Image = Global.Student_Management_System.My.Resources.Resources.ID_Verified_96px
        Me.ToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripMenuItem1.Margin = New System.Windows.Forms.Padding(0, 30, 0, 0)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(162, 24)
        Me.ToolStripMenuItem1.Text = "Report"
        Me.ToolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SettingToolStripMenuItem.Image = Global.Student_Management_System.My.Resources.Resources.Automation_96px
        Me.SettingToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SettingToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 30, 0, 0)
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0)
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(162, 24)
        Me.SettingToolStripMenuItem.Text = "Setting"
        Me.SettingToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.LogoutToolStripMenuItem.Image = Global.Student_Management_System.My.Resources.Resources.Shutdown_96px
        Me.LogoutToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LogoutToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 30, 0, 0)
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0)
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(162, 24)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        Me.LogoutToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 441)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Home"
        Me.Text = "Dashboard | Student Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AddStudentToolMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteStudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateInformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
