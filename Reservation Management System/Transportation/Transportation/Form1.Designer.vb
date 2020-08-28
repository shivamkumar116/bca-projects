<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class busform
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
        Me.cmdnew = New System.Windows.Forms.Button
        Me.cmdsav = New System.Windows.Forms.Button
        Me.cmdcls = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtbid = New System.Windows.Forms.TextBox
        Me.txtbtyp = New System.Windows.Forms.TextBox
        Me.txtbtime = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdnew
        '
        Me.cmdnew.Location = New System.Drawing.Point(63, 24)
        Me.cmdnew.Name = "cmdnew"
        Me.cmdnew.Size = New System.Drawing.Size(103, 50)
        Me.cmdnew.TabIndex = 0
        Me.cmdnew.Text = "New"
        Me.cmdnew.UseVisualStyleBackColor = True
        '
        'cmdsav
        '
        Me.cmdsav.Location = New System.Drawing.Point(201, 24)
        Me.cmdsav.Name = "cmdsav"
        Me.cmdsav.Size = New System.Drawing.Size(102, 50)
        Me.cmdsav.TabIndex = 1
        Me.cmdsav.Text = "Save"
        Me.cmdsav.UseVisualStyleBackColor = True
        '
        'cmdcls
        '
        Me.cmdcls.Location = New System.Drawing.Point(336, 24)
        Me.cmdcls.Name = "cmdcls"
        Me.cmdcls.Size = New System.Drawing.Size(98, 50)
        Me.cmdcls.TabIndex = 3
        Me.cmdcls.Text = "Close"
        Me.cmdcls.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Bus ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(60, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Bus type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(60, 235)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Departure Time"
        '
        'txtbid
        '
        Me.txtbid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbid.Location = New System.Drawing.Point(249, 124)
        Me.txtbid.Name = "txtbid"
        Me.txtbid.Size = New System.Drawing.Size(186, 20)
        Me.txtbid.TabIndex = 9
        '
        'txtbtyp
        '
        Me.txtbtyp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbtyp.Location = New System.Drawing.Point(249, 179)
        Me.txtbtyp.Name = "txtbtyp"
        Me.txtbtyp.Size = New System.Drawing.Size(186, 20)
        Me.txtbtyp.TabIndex = 10
        '
        'txtbtime
        '
        Me.txtbtime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbtime.Location = New System.Drawing.Point(249, 235)
        Me.txtbtime.Name = "txtbtime"
        Me.txtbtime.Size = New System.Drawing.Size(186, 20)
        Me.txtbtime.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(114, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(270, 37)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "New Bus Record"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(493, 72)
        Me.Panel1.TabIndex = 15
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.cmdcls)
        Me.Panel2.Controls.Add(Me.cmdsav)
        Me.Panel2.Controls.Add(Me.cmdnew)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 306)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(493, 87)
        Me.Panel2.TabIndex = 16
        '
        'busform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(493, 393)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtbtime)
        Me.Controls.Add(Me.txtbtyp)
        Me.Controls.Add(Me.txtbid)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "busform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Bus"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdnew As System.Windows.Forms.Button
    Friend WithEvents cmdsav As System.Windows.Forms.Button
    Friend WithEvents cmdcls As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtbid As System.Windows.Forms.TextBox
    Friend WithEvents txtbtyp As System.Windows.Forms.TextBox
    Friend WithEvents txtbtime As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel

End Class
