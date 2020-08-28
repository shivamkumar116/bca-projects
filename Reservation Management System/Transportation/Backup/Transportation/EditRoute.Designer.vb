<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditRoute
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
        Me.txtdesti = New System.Windows.Forms.TextBox
        Me.txtsorc = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmdedit = New System.Windows.Forms.Button
        Me.cmdsav = New System.Windows.Forms.Button
        Me.cmdcls = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
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
        Me.Label1.Location = New System.Drawing.Point(72, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Route ID"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtdesti)
        Me.Panel1.Controls.Add(Me.txtsorc)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(58, 171)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(383, 139)
        Me.Panel1.TabIndex = 2
        '
        'txtdesti
        '
        Me.txtdesti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdesti.Location = New System.Drawing.Point(199, 97)
        Me.txtdesti.Name = "txtdesti"
        Me.txtdesti.Size = New System.Drawing.Size(146, 20)
        Me.txtdesti.TabIndex = 3
        '
        'txtsorc
        '
        Me.txtsorc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsorc.Location = New System.Drawing.Point(199, 36)
        Me.txtsorc.Name = "txtsorc"
        Me.txtsorc.Size = New System.Drawing.Size(146, 20)
        Me.txtsorc.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "To"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "From"
        '
        'cmdedit
        '
        Me.cmdedit.Location = New System.Drawing.Point(75, 24)
        Me.cmdedit.Name = "cmdedit"
        Me.cmdedit.Size = New System.Drawing.Size(98, 52)
        Me.cmdedit.TabIndex = 3
        Me.cmdedit.Text = "Clear"
        Me.cmdedit.UseVisualStyleBackColor = True
        '
        'cmdsav
        '
        Me.cmdsav.Location = New System.Drawing.Point(209, 24)
        Me.cmdsav.Name = "cmdsav"
        Me.cmdsav.Size = New System.Drawing.Size(95, 52)
        Me.cmdsav.TabIndex = 4
        Me.cmdsav.Text = "Update"
        Me.cmdsav.UseVisualStyleBackColor = True
        '
        'cmdcls
        '
        Me.cmdcls.Location = New System.Drawing.Point(338, 24)
        Me.cmdcls.Name = "cmdcls"
        Me.cmdcls.Size = New System.Drawing.Size(102, 52)
        Me.cmdcls.TabIndex = 5
        Me.cmdcls.Text = "Close"
        Me.cmdcls.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.cmdcls)
        Me.Panel2.Controls.Add(Me.cmdsav)
        Me.Panel2.Controls.Add(Me.cmdedit)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 341)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(497, 89)
        Me.Panel2.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(105, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(343, 37)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Update Route Record"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(497, 73)
        Me.Panel3.TabIndex = 8
        '
        'cbrout
        '
        Me.cbrout.FormattingEnabled = True
        Me.cbrout.Location = New System.Drawing.Point(258, 110)
        Me.cbrout.Name = "cbrout"
        Me.cbrout.Size = New System.Drawing.Size(155, 21)
        Me.cbrout.TabIndex = 9
        '
        'EditRoute
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(497, 430)
        Me.ControlBox = False
        Me.Controls.Add(Me.cbrout)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EditRoute"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditRoute"
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
    Friend WithEvents txtdesti As System.Windows.Forms.TextBox
    Friend WithEvents txtsorc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdedit As System.Windows.Forms.Button
    Friend WithEvents cmdsav As System.Windows.Forms.Button
    Friend WithEvents cmdcls As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cbrout As System.Windows.Forms.ComboBox
End Class
