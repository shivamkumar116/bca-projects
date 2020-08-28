<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class delfare
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtffadlt = New System.Windows.Forms.TextBox
        Me.txtbtype = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmddel = New System.Windows.Forms.Button
        Me.cmdcls = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.cbrout = New System.Windows.Forms.ComboBox
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Route ID"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtffadlt)
        Me.Panel1.Controls.Add(Me.txtbtype)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(54, 157)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(394, 154)
        Me.Panel1.TabIndex = 2
        '
        'txtffadlt
        '
        Me.txtffadlt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtffadlt.Location = New System.Drawing.Point(206, 87)
        Me.txtffadlt.Name = "txtffadlt"
        Me.txtffadlt.Size = New System.Drawing.Size(167, 20)
        Me.txtffadlt.TabIndex = 4
        '
        'txtbtype
        '
        Me.txtbtype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbtype.Location = New System.Drawing.Point(206, 32)
        Me.txtbtype.Name = "txtbtype"
        Me.txtbtype.Size = New System.Drawing.Size(167, 20)
        Me.txtbtype.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Fare For Adults"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Bus Type"
        '
        'cmddel
        '
        Me.cmddel.Location = New System.Drawing.Point(134, 22)
        Me.cmddel.Name = "cmddel"
        Me.cmddel.Size = New System.Drawing.Size(91, 45)
        Me.cmddel.TabIndex = 3
        Me.cmddel.Text = "Delete"
        Me.cmddel.UseVisualStyleBackColor = True
        '
        'cmdcls
        '
        Me.cmdcls.Location = New System.Drawing.Point(260, 22)
        Me.cmdcls.Name = "cmdcls"
        Me.cmdcls.Size = New System.Drawing.Size(99, 45)
        Me.cmdcls.TabIndex = 4
        Me.cmdcls.Text = "Close"
        Me.cmdcls.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.cmdcls)
        Me.Panel2.Controls.Add(Me.cmddel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 340)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(503, 81)
        Me.Panel2.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(118, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(300, 37)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Delete fare Record"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(503, 72)
        Me.Panel3.TabIndex = 9
        '
        'cbrout
        '
        Me.cbrout.FormattingEnabled = True
        Me.cbrout.Location = New System.Drawing.Point(265, 110)
        Me.cbrout.Name = "cbrout"
        Me.cbrout.Size = New System.Drawing.Size(163, 21)
        Me.cbrout.TabIndex = 10
        '
        'delfare
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(503, 421)
        Me.ControlBox = False
        Me.Controls.Add(Me.cbrout)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "delfare"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "delfare"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtffadlt As System.Windows.Forms.TextBox
    Friend WithEvents txtbtype As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmddel As System.Windows.Forms.Button
    Friend WithEvents cmdcls As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cbrout As System.Windows.Forms.ComboBox
End Class
