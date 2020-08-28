<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class route
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtrid = New System.Windows.Forms.TextBox
        Me.txtfrm = New System.Windows.Forms.TextBox
        Me.txtdesti = New System.Windows.Forms.TextBox
        Me.cmdnew = New System.Windows.Forms.Button
        Me.cmdsave = New System.Windows.Forms.Button
        Me.cmdcls = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(85, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Route ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(85, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "From"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(85, 263)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "To"
        '
        'txtrid
        '
        Me.txtrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtrid.Location = New System.Drawing.Point(286, 143)
        Me.txtrid.Name = "txtrid"
        Me.txtrid.Size = New System.Drawing.Size(161, 20)
        Me.txtrid.TabIndex = 4
        '
        'txtfrm
        '
        Me.txtfrm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfrm.Location = New System.Drawing.Point(286, 198)
        Me.txtfrm.Name = "txtfrm"
        Me.txtfrm.Size = New System.Drawing.Size(161, 20)
        Me.txtfrm.TabIndex = 5
        '
        'txtdesti
        '
        Me.txtdesti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdesti.Location = New System.Drawing.Point(286, 256)
        Me.txtdesti.Name = "txtdesti"
        Me.txtdesti.Size = New System.Drawing.Size(161, 20)
        Me.txtdesti.TabIndex = 6
        '
        'cmdnew
        '
        Me.cmdnew.Location = New System.Drawing.Point(65, 18)
        Me.cmdnew.Name = "cmdnew"
        Me.cmdnew.Size = New System.Drawing.Size(101, 57)
        Me.cmdnew.TabIndex = 7
        Me.cmdnew.Text = "New"
        Me.cmdnew.UseVisualStyleBackColor = True
        '
        'cmdsave
        '
        Me.cmdsave.Location = New System.Drawing.Point(218, 18)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(97, 57)
        Me.cmdsave.TabIndex = 8
        Me.cmdsave.Text = "Save"
        Me.cmdsave.UseVisualStyleBackColor = True
        '
        'cmdcls
        '
        Me.cmdcls.Location = New System.Drawing.Point(361, 18)
        Me.cmdcls.Name = "cmdcls"
        Me.cmdcls.Size = New System.Drawing.Size(100, 57)
        Me.cmdcls.TabIndex = 9
        Me.cmdcls.Text = "Close"
        Me.cmdcls.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cmdcls)
        Me.Panel1.Controls.Add(Me.cmdsave)
        Me.Panel1.Controls.Add(Me.cmdnew)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 339)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(517, 91)
        Me.Panel1.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(133, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(301, 37)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "New Route Record"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(517, 81)
        Me.Panel2.TabIndex = 12
        '
        'route
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(517, 430)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtdesti)
        Me.Controls.Add(Me.txtfrm)
        Me.Controls.Add(Me.txtrid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "route"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Route"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtrid As System.Windows.Forms.TextBox
    Friend WithEvents txtfrm As System.Windows.Forms.TextBox
    Friend WithEvents txtdesti As System.Windows.Forms.TextBox
    Friend WithEvents cmdnew As System.Windows.Forms.Button
    Friend WithEvents cmdsave As System.Windows.Forms.Button
    Friend WithEvents cmdcls As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
