<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Changpass
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
        Me.cmdchng = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtusr = New System.Windows.Forms.TextBox
        Me.txtol = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtnew = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cmdcls = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdchng
        '
        Me.cmdchng.Location = New System.Drawing.Point(120, 264)
        Me.cmdchng.Name = "cmdchng"
        Me.cmdchng.Size = New System.Drawing.Size(91, 31)
        Me.cmdchng.TabIndex = 0
        Me.cmdchng.Text = "OK"
        Me.cmdchng.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "User-Name"
        '
        'txtusr
        '
        Me.txtusr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtusr.Location = New System.Drawing.Point(220, 23)
        Me.txtusr.Name = "txtusr"
        Me.txtusr.Size = New System.Drawing.Size(125, 20)
        Me.txtusr.TabIndex = 2
        '
        'txtol
        '
        Me.txtol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtol.Location = New System.Drawing.Point(220, 78)
        Me.txtol.Name = "txtol"
        Me.txtol.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtol.Size = New System.Drawing.Size(125, 20)
        Me.txtol.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Old password"
        '
        'txtnew
        '
        Me.txtnew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnew.Location = New System.Drawing.Point(220, 134)
        Me.txtnew.Name = "txtnew"
        Me.txtnew.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtnew.Size = New System.Drawing.Size(125, 20)
        Me.txtnew.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "New Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(114, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(225, 29)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Change Password"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(465, 49)
        Me.Panel1.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtnew)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtol)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtusr)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(56, 64)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(363, 189)
        Me.Panel2.TabIndex = 9
        '
        'cmdcls
        '
        Me.cmdcls.Location = New System.Drawing.Point(277, 264)
        Me.cmdcls.Name = "cmdcls"
        Me.cmdcls.Size = New System.Drawing.Size(90, 31)
        Me.cmdcls.TabIndex = 10
        Me.cmdcls.Text = "Close"
        Me.cmdcls.UseVisualStyleBackColor = True
        '
        'Changpass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(459, 302)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdcls)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmdchng)
        Me.Name = "Changpass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Changpass"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdchng As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtusr As System.Windows.Forms.TextBox
    Friend WithEvents txtol As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnew As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmdcls As System.Windows.Forms.Button
End Class
