<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddBus
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblRoute = New System.Windows.Forms.Label()
        Me.txtRoute = New System.Windows.Forms.TextBox()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.txtFrom = New System.Windows.Forms.TextBox()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.lblBusID = New System.Windows.Forms.Label()
        Me.txtBusID = New System.Windows.Forms.TextBox()
        Me.txtDepatTime = New System.Windows.Forms.TextBox()
        Me.lblDeparture = New System.Windows.Forms.Label()
        Me.txtBusType = New System.Windows.Forms.TextBox()
        Me.lblBusType = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.lblFare = New System.Windows.Forms.Label()
        Me.txtfare = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(483, 45)
        Me.Panel1.TabIndex = 1
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(109, 9)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(226, 33)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Add Bus And Route"
        '
        'lblRoute
        '
        Me.lblRoute.AutoSize = True
        Me.lblRoute.Location = New System.Drawing.Point(36, 83)
        Me.lblRoute.Name = "lblRoute"
        Me.lblRoute.Size = New System.Drawing.Size(63, 17)
        Me.lblRoute.TabIndex = 2
        Me.lblRoute.Text = "Route ID"
        '
        'txtRoute
        '
        Me.txtRoute.Location = New System.Drawing.Point(160, 77)
        Me.txtRoute.Name = "txtRoute"
        Me.txtRoute.Size = New System.Drawing.Size(244, 23)
        Me.txtRoute.TabIndex = 3
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(36, 127)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(40, 17)
        Me.lblFrom.TabIndex = 4
        Me.lblFrom.Text = "From"
        '
        'txtFrom
        '
        Me.txtFrom.Location = New System.Drawing.Point(160, 121)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(244, 23)
        Me.txtFrom.TabIndex = 5
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(36, 171)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(25, 17)
        Me.lblTo.TabIndex = 6
        Me.lblTo.Text = "To"
        '
        'txtTo
        '
        Me.txtTo.Location = New System.Drawing.Point(160, 165)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(244, 23)
        Me.txtTo.TabIndex = 7
        '
        'lblBusID
        '
        Me.lblBusID.AutoSize = True
        Me.lblBusID.Location = New System.Drawing.Point(36, 221)
        Me.lblBusID.Name = "lblBusID"
        Me.lblBusID.Size = New System.Drawing.Size(49, 17)
        Me.lblBusID.TabIndex = 8
        Me.lblBusID.Text = "Bus ID"
        '
        'txtBusID
        '
        Me.txtBusID.Location = New System.Drawing.Point(160, 215)
        Me.txtBusID.Name = "txtBusID"
        Me.txtBusID.Size = New System.Drawing.Size(244, 23)
        Me.txtBusID.TabIndex = 9
        '
        'txtDepatTime
        '
        Me.txtDepatTime.Location = New System.Drawing.Point(160, 260)
        Me.txtDepatTime.Name = "txtDepatTime"
        Me.txtDepatTime.Size = New System.Drawing.Size(244, 23)
        Me.txtDepatTime.TabIndex = 11
        '
        'lblDeparture
        '
        Me.lblDeparture.AutoSize = True
        Me.lblDeparture.Location = New System.Drawing.Point(36, 266)
        Me.lblDeparture.Name = "lblDeparture"
        Me.lblDeparture.Size = New System.Drawing.Size(107, 17)
        Me.lblDeparture.TabIndex = 10
        Me.lblDeparture.Text = "Departure Time"
        '
        'txtBusType
        '
        Me.txtBusType.Location = New System.Drawing.Point(160, 309)
        Me.txtBusType.Name = "txtBusType"
        Me.txtBusType.Size = New System.Drawing.Size(244, 23)
        Me.txtBusType.TabIndex = 13
        '
        'lblBusType
        '
        Me.lblBusType.AutoSize = True
        Me.lblBusType.Location = New System.Drawing.Point(36, 315)
        Me.lblBusType.Name = "lblBusType"
        Me.lblBusType.Size = New System.Drawing.Size(68, 17)
        Me.lblBusType.TabIndex = 12
        Me.lblBusType.Text = "Bus Type"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCancel.Location = New System.Drawing.Point(248, 406)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(78, 30)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "Discard"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.SeaGreen
        Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSubmit.Location = New System.Drawing.Point(160, 406)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(82, 30)
        Me.btnSubmit.TabIndex = 14
        Me.btnSubmit.Text = "Save"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(157, 439)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(85, 17)
        Me.lblMessage.TabIndex = 16
        Me.lblMessage.Text = "{{Message}}"
        '
        'lblFare
        '
        Me.lblFare.AutoSize = True
        Me.lblFare.Location = New System.Drawing.Point(39, 352)
        Me.lblFare.Name = "lblFare"
        Me.lblFare.Size = New System.Drawing.Size(37, 17)
        Me.lblFare.TabIndex = 17
        Me.lblFare.Text = "Fare"
        '
        'txtfare
        '
        Me.txtfare.Location = New System.Drawing.Point(160, 352)
        Me.txtfare.Name = "txtfare"
        Me.txtfare.Size = New System.Drawing.Size(244, 23)
        Me.txtfare.TabIndex = 18
        '
        'AddBus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 480)
        Me.Controls.Add(Me.txtfare)
        Me.Controls.Add(Me.lblFare)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtBusType)
        Me.Controls.Add(Me.lblBusType)
        Me.Controls.Add(Me.txtDepatTime)
        Me.Controls.Add(Me.lblDeparture)
        Me.Controls.Add(Me.txtBusID)
        Me.Controls.Add(Me.lblBusID)
        Me.Controls.Add(Me.txtTo)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.txtFrom)
        Me.Controls.Add(Me.lblFrom)
        Me.Controls.Add(Me.txtRoute)
        Me.Controls.Add(Me.lblRoute)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AddBus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddBus"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblRoute As System.Windows.Forms.Label
    Friend WithEvents txtRoute As System.Windows.Forms.TextBox
    Friend WithEvents lblFrom As System.Windows.Forms.Label
    Friend WithEvents txtFrom As System.Windows.Forms.TextBox
    Friend WithEvents lblTo As System.Windows.Forms.Label
    Friend WithEvents txtTo As System.Windows.Forms.TextBox
    Friend WithEvents lblBusID As System.Windows.Forms.Label
    Friend WithEvents txtBusID As System.Windows.Forms.TextBox
    Friend WithEvents txtDepatTime As System.Windows.Forms.TextBox
    Friend WithEvents lblDeparture As System.Windows.Forms.Label
    Friend WithEvents txtBusType As System.Windows.Forms.TextBox
    Friend WithEvents lblBusType As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents lblFare As System.Windows.Forms.Label
    Friend WithEvents txtfare As System.Windows.Forms.TextBox
End Class
