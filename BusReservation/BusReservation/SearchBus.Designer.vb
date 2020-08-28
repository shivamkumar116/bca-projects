<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchBus
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
        Me.lblType = New System.Windows.Forms.Label()
        Me.blDTime = New System.Windows.Forms.Label()
        Me.lblBusIDNumber = New System.Windows.Forms.Label()
        Me.lblBusTo = New System.Windows.Forms.Label()
        Me.lblBusFrom = New System.Windows.Forms.Label()
        Me.lblRouteID = New System.Windows.Forms.Label()
        Me.lblBusType = New System.Windows.Forms.Label()
        Me.lblDeparture = New System.Windows.Forms.Label()
        Me.lblBusID = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblRoute = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblFareBus = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.Panel1.Size = New System.Drawing.Size(496, 45)
        Me.Panel1.TabIndex = 2
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(159, 9)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(129, 33)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Search Bus"
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
        Me.btnSearch.Location = New System.Drawing.Point(311, 72)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(86, 26)
        Me.btnSearch.TabIndex = 35
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtRollNumber
        '
        Me.txtRollNumber.Location = New System.Drawing.Point(115, 74)
        Me.txtRollNumber.Name = "txtRollNumber"
        Me.txtRollNumber.Size = New System.Drawing.Size(190, 23)
        Me.txtRollNumber.TabIndex = 34
        '
        'lblIntro
        '
        Me.lblIntro.AutoSize = True
        Me.lblIntro.Location = New System.Drawing.Point(38, 80)
        Me.lblIntro.Name = "lblIntro"
        Me.lblIntro.Size = New System.Drawing.Size(49, 17)
        Me.lblIntro.TabIndex = 33
        Me.lblIntro.Text = "Bus ID"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblFareBus)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btnSubmit)
        Me.Panel2.Controls.Add(Me.lblType)
        Me.Panel2.Controls.Add(Me.blDTime)
        Me.Panel2.Controls.Add(Me.lblBusIDNumber)
        Me.Panel2.Controls.Add(Me.lblBusTo)
        Me.Panel2.Controls.Add(Me.lblBusFrom)
        Me.Panel2.Controls.Add(Me.lblRouteID)
        Me.Panel2.Controls.Add(Me.lblBusType)
        Me.Panel2.Controls.Add(Me.lblDeparture)
        Me.Panel2.Controls.Add(Me.lblBusID)
        Me.Panel2.Controls.Add(Me.lblTo)
        Me.Panel2.Controls.Add(Me.lblFrom)
        Me.Panel2.Controls.Add(Me.lblRoute)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 104)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(496, 343)
        Me.Panel2.TabIndex = 36
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(267, 247)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(76, 17)
        Me.lblType.TabIndex = 89
        Me.lblType.Text = "Bus Type"
        '
        'blDTime
        '
        Me.blDTime.AutoSize = True
        Me.blDTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.blDTime.Location = New System.Drawing.Point(267, 198)
        Me.blDTime.Name = "blDTime"
        Me.blDTime.Size = New System.Drawing.Size(121, 17)
        Me.blDTime.TabIndex = 88
        Me.blDTime.Text = "Departure Time"
        '
        'lblBusIDNumber
        '
        Me.lblBusIDNumber.AutoSize = True
        Me.lblBusIDNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusIDNumber.Location = New System.Drawing.Point(267, 153)
        Me.lblBusIDNumber.Name = "lblBusIDNumber"
        Me.lblBusIDNumber.Size = New System.Drawing.Size(55, 17)
        Me.lblBusIDNumber.TabIndex = 87
        Me.lblBusIDNumber.Text = "Bus ID"
        '
        'lblBusTo
        '
        Me.lblBusTo.AutoSize = True
        Me.lblBusTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusTo.Location = New System.Drawing.Point(267, 103)
        Me.lblBusTo.Name = "lblBusTo"
        Me.lblBusTo.Size = New System.Drawing.Size(27, 17)
        Me.lblBusTo.TabIndex = 86
        Me.lblBusTo.Text = "To"
        '
        'lblBusFrom
        '
        Me.lblBusFrom.AutoSize = True
        Me.lblBusFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusFrom.Location = New System.Drawing.Point(267, 59)
        Me.lblBusFrom.Name = "lblBusFrom"
        Me.lblBusFrom.Size = New System.Drawing.Size(44, 17)
        Me.lblBusFrom.TabIndex = 85
        Me.lblBusFrom.Text = "From"
        '
        'lblRouteID
        '
        Me.lblRouteID.AutoSize = True
        Me.lblRouteID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRouteID.Location = New System.Drawing.Point(267, 15)
        Me.lblRouteID.Name = "lblRouteID"
        Me.lblRouteID.Size = New System.Drawing.Size(71, 17)
        Me.lblRouteID.TabIndex = 84
        Me.lblRouteID.Text = "Route ID"
        '
        'lblBusType
        '
        Me.lblBusType.AutoSize = True
        Me.lblBusType.Location = New System.Drawing.Point(110, 247)
        Me.lblBusType.Name = "lblBusType"
        Me.lblBusType.Size = New System.Drawing.Size(68, 17)
        Me.lblBusType.TabIndex = 83
        Me.lblBusType.Text = "Bus Type"
        '
        'lblDeparture
        '
        Me.lblDeparture.AutoSize = True
        Me.lblDeparture.Location = New System.Drawing.Point(110, 198)
        Me.lblDeparture.Name = "lblDeparture"
        Me.lblDeparture.Size = New System.Drawing.Size(107, 17)
        Me.lblDeparture.TabIndex = 82
        Me.lblDeparture.Text = "Departure Time"
        '
        'lblBusID
        '
        Me.lblBusID.AutoSize = True
        Me.lblBusID.Location = New System.Drawing.Point(110, 153)
        Me.lblBusID.Name = "lblBusID"
        Me.lblBusID.Size = New System.Drawing.Size(49, 17)
        Me.lblBusID.TabIndex = 81
        Me.lblBusID.Text = "Bus ID"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(110, 103)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(25, 17)
        Me.lblTo.TabIndex = 80
        Me.lblTo.Text = "To"
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(110, 59)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(40, 17)
        Me.lblFrom.TabIndex = 79
        Me.lblFrom.Text = "From"
        '
        'lblRoute
        '
        Me.lblRoute.AutoSize = True
        Me.lblRoute.Location = New System.Drawing.Point(110, 15)
        Me.lblRoute.Name = "lblRoute"
        Me.lblRoute.Size = New System.Drawing.Size(63, 17)
        Me.lblRoute.TabIndex = 78
        Me.lblRoute.Text = "Route ID"
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
        Me.btnSubmit.Location = New System.Drawing.Point(178, 301)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(82, 30)
        Me.btnSubmit.TabIndex = 90
        Me.btnSubmit.Text = "Print"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'lblFareBus
        '
        Me.lblFareBus.AutoSize = True
        Me.lblFareBus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFareBus.Location = New System.Drawing.Point(267, 279)
        Me.lblFareBus.Name = "lblFareBus"
        Me.lblFareBus.Size = New System.Drawing.Size(41, 17)
        Me.lblFareBus.TabIndex = 94
        Me.lblFareBus.Text = "Fare"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(112, 279)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 17)
        Me.Label1.TabIndex = 93
        Me.Label1.Text = "Fare"
        '
        'SearchBus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 447)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtRollNumber)
        Me.Controls.Add(Me.lblIntro)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "SearchBus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SearchBus"
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
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents blDTime As System.Windows.Forms.Label
    Friend WithEvents lblBusIDNumber As System.Windows.Forms.Label
    Friend WithEvents lblBusTo As System.Windows.Forms.Label
    Friend WithEvents lblBusFrom As System.Windows.Forms.Label
    Friend WithEvents lblRouteID As System.Windows.Forms.Label
    Friend WithEvents lblBusType As System.Windows.Forms.Label
    Friend WithEvents lblDeparture As System.Windows.Forms.Label
    Friend WithEvents lblBusID As System.Windows.Forms.Label
    Friend WithEvents lblTo As System.Windows.Forms.Label
    Friend WithEvents lblFrom As System.Windows.Forms.Label
    Friend WithEvents lblRoute As System.Windows.Forms.Label
    Friend WithEvents lblFareBus As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
