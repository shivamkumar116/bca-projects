<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateBus
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
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtRollNumber = New System.Windows.Forms.TextBox()
        Me.lblIntro = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblBusType = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblDeparture = New System.Windows.Forms.Label()
        Me.txtBusID = New System.Windows.Forms.TextBox()
        Me.lblBusID = New System.Windows.Forms.Label()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.txtFrom = New System.Windows.Forms.TextBox()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.txtRoute = New System.Windows.Forms.TextBox()
        Me.lblRoute = New System.Windows.Forms.Label()
        Me.txtfare = New System.Windows.Forms.TextBox()
        Me.lblFare = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(491, 45)
        Me.Panel1.TabIndex = 3
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(65, 9)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(378, 33)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Update Bus Or Route Information"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Tomato
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Tomato
        Me.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed
        Me.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSearch.Location = New System.Drawing.Point(325, 49)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(86, 26)
        Me.btnSearch.TabIndex = 31
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtRollNumber
        '
        Me.txtRollNumber.Location = New System.Drawing.Point(116, 51)
        Me.txtRollNumber.Name = "txtRollNumber"
        Me.txtRollNumber.Size = New System.Drawing.Size(190, 23)
        Me.txtRollNumber.TabIndex = 30
        '
        'lblIntro
        '
        Me.lblIntro.AutoSize = True
        Me.lblIntro.Location = New System.Drawing.Point(43, 55)
        Me.lblIntro.Name = "lblIntro"
        Me.lblIntro.Size = New System.Drawing.Size(49, 17)
        Me.lblIntro.TabIndex = 29
        Me.lblIntro.Text = "Bus ID"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtfare)
        Me.Panel2.Controls.Add(Me.lblFare)
        Me.Panel2.Controls.Add(Me.lblMessage)
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Controls.Add(Me.btnSubmit)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.lblBusType)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.lblDeparture)
        Me.Panel2.Controls.Add(Me.txtBusID)
        Me.Panel2.Controls.Add(Me.lblBusID)
        Me.Panel2.Controls.Add(Me.txtTo)
        Me.Panel2.Controls.Add(Me.lblTo)
        Me.Panel2.Controls.Add(Me.txtFrom)
        Me.Panel2.Controls.Add(Me.lblFrom)
        Me.Panel2.Controls.Add(Me.txtRoute)
        Me.Panel2.Controls.Add(Me.lblRoute)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 80)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(491, 409)
        Me.Panel2.TabIndex = 32
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(164, 383)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(85, 17)
        Me.lblMessage.TabIndex = 43
        Me.lblMessage.Text = "{{Message}}"
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
        Me.btnCancel.Location = New System.Drawing.Point(261, 331)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(78, 30)
        Me.btnCancel.TabIndex = 42
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
        Me.btnSubmit.Location = New System.Drawing.Point(167, 331)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(82, 30)
        Me.btnSubmit.TabIndex = 41
        Me.btnSubmit.Text = "Update"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(167, 268)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(244, 23)
        Me.TextBox2.TabIndex = 40
        '
        'lblBusType
        '
        Me.lblBusType.AutoSize = True
        Me.lblBusType.Location = New System.Drawing.Point(43, 274)
        Me.lblBusType.Name = "lblBusType"
        Me.lblBusType.Size = New System.Drawing.Size(68, 17)
        Me.lblBusType.TabIndex = 39
        Me.lblBusType.Text = "Bus Type"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(167, 219)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(244, 23)
        Me.TextBox1.TabIndex = 38
        '
        'lblDeparture
        '
        Me.lblDeparture.AutoSize = True
        Me.lblDeparture.Location = New System.Drawing.Point(43, 225)
        Me.lblDeparture.Name = "lblDeparture"
        Me.lblDeparture.Size = New System.Drawing.Size(107, 17)
        Me.lblDeparture.TabIndex = 37
        Me.lblDeparture.Text = "Departure Time"
        '
        'txtBusID
        '
        Me.txtBusID.Location = New System.Drawing.Point(167, 174)
        Me.txtBusID.Name = "txtBusID"
        Me.txtBusID.Size = New System.Drawing.Size(244, 23)
        Me.txtBusID.TabIndex = 36
        '
        'lblBusID
        '
        Me.lblBusID.AutoSize = True
        Me.lblBusID.Location = New System.Drawing.Point(43, 180)
        Me.lblBusID.Name = "lblBusID"
        Me.lblBusID.Size = New System.Drawing.Size(49, 17)
        Me.lblBusID.TabIndex = 35
        Me.lblBusID.Text = "Bus ID"
        '
        'txtTo
        '
        Me.txtTo.Location = New System.Drawing.Point(167, 124)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(244, 23)
        Me.txtTo.TabIndex = 34
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(43, 130)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(25, 17)
        Me.lblTo.TabIndex = 33
        Me.lblTo.Text = "To"
        '
        'txtFrom
        '
        Me.txtFrom.Location = New System.Drawing.Point(167, 80)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(244, 23)
        Me.txtFrom.TabIndex = 32
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(43, 86)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(40, 17)
        Me.lblFrom.TabIndex = 31
        Me.lblFrom.Text = "From"
        '
        'txtRoute
        '
        Me.txtRoute.Location = New System.Drawing.Point(167, 36)
        Me.txtRoute.Name = "txtRoute"
        Me.txtRoute.Size = New System.Drawing.Size(244, 23)
        Me.txtRoute.TabIndex = 30
        '
        'lblRoute
        '
        Me.lblRoute.AutoSize = True
        Me.lblRoute.Location = New System.Drawing.Point(43, 42)
        Me.lblRoute.Name = "lblRoute"
        Me.lblRoute.Size = New System.Drawing.Size(63, 17)
        Me.lblRoute.TabIndex = 29
        Me.lblRoute.Text = "Route ID"
        '
        'txtfare
        '
        Me.txtfare.Location = New System.Drawing.Point(167, 302)
        Me.txtfare.Name = "txtfare"
        Me.txtfare.Size = New System.Drawing.Size(244, 23)
        Me.txtfare.TabIndex = 45
        '
        'lblFare
        '
        Me.lblFare.AutoSize = True
        Me.lblFare.Location = New System.Drawing.Point(43, 308)
        Me.lblFare.Name = "lblFare"
        Me.lblFare.Size = New System.Drawing.Size(37, 17)
        Me.lblFare.TabIndex = 44
        Me.lblFare.Text = "Fare"
        '
        'UpdateBus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 489)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtRollNumber)
        Me.Controls.Add(Me.lblIntro)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UpdateBus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UpdateBus"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtRollNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblIntro As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents lblBusType As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblDeparture As System.Windows.Forms.Label
    Friend WithEvents txtBusID As System.Windows.Forms.TextBox
    Friend WithEvents lblBusID As System.Windows.Forms.Label
    Friend WithEvents txtTo As System.Windows.Forms.TextBox
    Friend WithEvents lblTo As System.Windows.Forms.Label
    Friend WithEvents txtFrom As System.Windows.Forms.TextBox
    Friend WithEvents lblFrom As System.Windows.Forms.Label
    Friend WithEvents txtRoute As System.Windows.Forms.TextBox
    Friend WithEvents lblRoute As System.Windows.Forms.Label
    Friend WithEvents txtfare As System.Windows.Forms.TextBox
    Friend WithEvents lblFare As System.Windows.Forms.Label
End Class
