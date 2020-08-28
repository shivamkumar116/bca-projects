<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class deleteStudent
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblIntro = New System.Windows.Forms.Label()
        Me.txtRollNumber = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lbPercentage = New System.Windows.Forms.Label()
        Me.lbBoard = New System.Windows.Forms.Label()
        Me.lbSchool = New System.Windows.Forms.Label()
        Me.lbRoll = New System.Windows.Forms.Label()
        Me.lbEmail = New System.Windows.Forms.Label()
        Me.lbName = New System.Windows.Forms.Label()
        Me.lbAddress = New System.Windows.Forms.Label()
        Me.lbPassing = New System.Windows.Forms.Label()
        Me.lbFather = New System.Windows.Forms.Label()
        Me.lbMother = New System.Windows.Forms.Label()
        Me.lbMobile = New System.Windows.Forms.Label()
        Me.lbGender = New System.Windows.Forms.Label()
        Me.lbCategory = New System.Windows.Forms.Label()
        Me.lbDOB = New System.Windows.Forms.Label()
        Me.lblPercentage12th = New System.Windows.Forms.Label()
        Me.lblBoard12th = New System.Windows.Forms.Label()
        Me.lblSchool = New System.Windows.Forms.Label()
        Me.lblRollNumber = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblPassingYear = New System.Windows.Forms.Label()
        Me.lblFatherName = New System.Windows.Forms.Label()
        Me.lblMotherName = New System.Windows.Forms.Label()
        Me.lblMobile = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(751, 45)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Student_Management_System.My.Resources.Resources.Denied_96px
        Me.PictureBox1.Location = New System.Drawing.Point(228, 4)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(42, 37)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(278, 9)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(171, 33)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Delete Student"
        '
        'lblIntro
        '
        Me.lblIntro.AutoSize = True
        Me.lblIntro.Location = New System.Drawing.Point(13, 68)
        Me.lblIntro.Name = "lblIntro"
        Me.lblIntro.Size = New System.Drawing.Size(92, 17)
        Me.lblIntro.TabIndex = 2
        Me.lblIntro.Text = " Roll number "
        '
        'txtRollNumber
        '
        Me.txtRollNumber.Location = New System.Drawing.Point(111, 68)
        Me.txtRollNumber.Name = "txtRollNumber"
        Me.txtRollNumber.Size = New System.Drawing.Size(268, 23)
        Me.txtRollNumber.TabIndex = 3
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
        Me.btnSearch.Location = New System.Drawing.Point(406, 65)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(138, 26)
        Me.btnSearch.TabIndex = 14
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Controls.Add(Me.lbPercentage)
        Me.Panel2.Controls.Add(Me.lbBoard)
        Me.Panel2.Controls.Add(Me.lbSchool)
        Me.Panel2.Controls.Add(Me.lbRoll)
        Me.Panel2.Controls.Add(Me.lbEmail)
        Me.Panel2.Controls.Add(Me.lbName)
        Me.Panel2.Controls.Add(Me.lbAddress)
        Me.Panel2.Controls.Add(Me.lbPassing)
        Me.Panel2.Controls.Add(Me.lbFather)
        Me.Panel2.Controls.Add(Me.lbMother)
        Me.Panel2.Controls.Add(Me.lbMobile)
        Me.Panel2.Controls.Add(Me.lbGender)
        Me.Panel2.Controls.Add(Me.lbCategory)
        Me.Panel2.Controls.Add(Me.lbDOB)
        Me.Panel2.Controls.Add(Me.lblPercentage12th)
        Me.Panel2.Controls.Add(Me.lblBoard12th)
        Me.Panel2.Controls.Add(Me.lblSchool)
        Me.Panel2.Controls.Add(Me.lblRollNumber)
        Me.Panel2.Controls.Add(Me.lblEmail)
        Me.Panel2.Controls.Add(Me.lblName)
        Me.Panel2.Controls.Add(Me.lblAddress)
        Me.Panel2.Controls.Add(Me.lblPassingYear)
        Me.Panel2.Controls.Add(Me.lblFatherName)
        Me.Panel2.Controls.Add(Me.lblMotherName)
        Me.Panel2.Controls.Add(Me.lblMobile)
        Me.Panel2.Controls.Add(Me.lblGender)
        Me.Panel2.Controls.Add(Me.lblCategory)
        Me.Panel2.Controls.Add(Me.lblDOB)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 124)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(751, 332)
        Me.Panel2.TabIndex = 15
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
        Me.btnCancel.Location = New System.Drawing.Point(284, 290)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(78, 30)
        Me.btnCancel.TabIndex = 77
        Me.btnCancel.Text = "Delete"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lbPercentage
        '
        Me.lbPercentage.AutoSize = True
        Me.lbPercentage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPercentage.Location = New System.Drawing.Point(502, 12)
        Me.lbPercentage.Name = "lbPercentage"
        Me.lbPercentage.Size = New System.Drawing.Size(128, 17)
        Me.lbPercentage.TabIndex = 73
        Me.lbPercentage.Text = "12th Percentage"
        '
        'lbBoard
        '
        Me.lbBoard.AutoSize = True
        Me.lbBoard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBoard.Location = New System.Drawing.Point(502, 45)
        Me.lbBoard.Name = "lbBoard"
        Me.lbBoard.Size = New System.Drawing.Size(88, 17)
        Me.lbBoard.TabIndex = 74
        Me.lbBoard.Text = "12th Board"
        '
        'lbSchool
        '
        Me.lbSchool.AutoSize = True
        Me.lbSchool.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSchool.Location = New System.Drawing.Point(502, 84)
        Me.lbSchool.Name = "lbSchool"
        Me.lbSchool.Size = New System.Drawing.Size(57, 17)
        Me.lbSchool.TabIndex = 75
        Me.lbSchool.Text = "School"
        '
        'lbRoll
        '
        Me.lbRoll.AutoSize = True
        Me.lbRoll.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRoll.Location = New System.Drawing.Point(164, 12)
        Me.lbRoll.Name = "lbRoll"
        Me.lbRoll.Size = New System.Drawing.Size(97, 17)
        Me.lbRoll.TabIndex = 72
        Me.lbRoll.Text = "Roll Number"
        '
        'lbEmail
        '
        Me.lbEmail.AutoSize = True
        Me.lbEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEmail.Location = New System.Drawing.Point(502, 161)
        Me.lbEmail.Name = "lbEmail"
        Me.lbEmail.Size = New System.Drawing.Size(67, 17)
        Me.lbEmail.TabIndex = 71
        Me.lbEmail.Text = "Email ID"
        '
        'lbName
        '
        Me.lbName.AutoSize = True
        Me.lbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbName.Location = New System.Drawing.Point(164, 45)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(49, 17)
        Me.lbName.TabIndex = 63
        Me.lbName.Text = "Name"
        '
        'lbAddress
        '
        Me.lbAddress.AutoSize = True
        Me.lbAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAddress.Location = New System.Drawing.Point(502, 207)
        Me.lbAddress.Name = "lbAddress"
        Me.lbAddress.Size = New System.Drawing.Size(67, 17)
        Me.lbAddress.TabIndex = 66
        Me.lbAddress.Text = "Address"
        '
        'lbPassing
        '
        Me.lbPassing.AutoSize = True
        Me.lbPassing.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPassing.Location = New System.Drawing.Point(502, 124)
        Me.lbPassing.Name = "lbPassing"
        Me.lbPassing.Size = New System.Drawing.Size(104, 17)
        Me.lbPassing.TabIndex = 76
        Me.lbPassing.Text = "Passing Year"
        '
        'lbFather
        '
        Me.lbFather.AutoSize = True
        Me.lbFather.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFather.Location = New System.Drawing.Point(164, 84)
        Me.lbFather.Name = "lbFather"
        Me.lbFather.Size = New System.Drawing.Size(113, 17)
        Me.lbFather.TabIndex = 64
        Me.lbFather.Text = "Father's Name"
        '
        'lbMother
        '
        Me.lbMother.AutoSize = True
        Me.lbMother.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMother.Location = New System.Drawing.Point(164, 124)
        Me.lbMother.Name = "lbMother"
        Me.lbMother.Size = New System.Drawing.Size(116, 17)
        Me.lbMother.TabIndex = 65
        Me.lbMother.Text = "Mother's Name"
        '
        'lbMobile
        '
        Me.lbMobile.AutoSize = True
        Me.lbMobile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMobile.Location = New System.Drawing.Point(164, 207)
        Me.lbMobile.Name = "lbMobile"
        Me.lbMobile.Size = New System.Drawing.Size(55, 17)
        Me.lbMobile.TabIndex = 67
        Me.lbMobile.Text = "Mobile"
        '
        'lbGender
        '
        Me.lbGender.AutoSize = True
        Me.lbGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbGender.Location = New System.Drawing.Point(164, 249)
        Me.lbGender.Name = "lbGender"
        Me.lbGender.Size = New System.Drawing.Size(62, 17)
        Me.lbGender.TabIndex = 68
        Me.lbGender.Text = "Gender"
        '
        'lbCategory
        '
        Me.lbCategory.AutoSize = True
        Me.lbCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCategory.Location = New System.Drawing.Point(502, 249)
        Me.lbCategory.Name = "lbCategory"
        Me.lbCategory.Size = New System.Drawing.Size(73, 17)
        Me.lbCategory.TabIndex = 69
        Me.lbCategory.Text = "Category"
        '
        'lbDOB
        '
        Me.lbDOB.AutoSize = True
        Me.lbDOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDOB.Location = New System.Drawing.Point(164, 161)
        Me.lbDOB.Name = "lbDOB"
        Me.lbDOB.Size = New System.Drawing.Size(100, 17)
        Me.lbDOB.TabIndex = 70
        Me.lbDOB.Text = "Date of Birth"
        '
        'lblPercentage12th
        '
        Me.lblPercentage12th.AutoSize = True
        Me.lblPercentage12th.Location = New System.Drawing.Point(370, 12)
        Me.lblPercentage12th.Name = "lblPercentage12th"
        Me.lblPercentage12th.Size = New System.Drawing.Size(113, 17)
        Me.lblPercentage12th.TabIndex = 59
        Me.lblPercentage12th.Text = "12th Percentage"
        '
        'lblBoard12th
        '
        Me.lblBoard12th.AutoSize = True
        Me.lblBoard12th.Location = New System.Drawing.Point(370, 45)
        Me.lblBoard12th.Name = "lblBoard12th"
        Me.lblBoard12th.Size = New System.Drawing.Size(78, 17)
        Me.lblBoard12th.TabIndex = 60
        Me.lblBoard12th.Text = "12th Board"
        '
        'lblSchool
        '
        Me.lblSchool.AutoSize = True
        Me.lblSchool.Location = New System.Drawing.Point(370, 84)
        Me.lblSchool.Name = "lblSchool"
        Me.lblSchool.Size = New System.Drawing.Size(51, 17)
        Me.lblSchool.TabIndex = 61
        Me.lblSchool.Text = "School"
        '
        'lblRollNumber
        '
        Me.lblRollNumber.AutoSize = True
        Me.lblRollNumber.Location = New System.Drawing.Point(32, 12)
        Me.lblRollNumber.Name = "lblRollNumber"
        Me.lblRollNumber.Size = New System.Drawing.Size(86, 17)
        Me.lblRollNumber.TabIndex = 58
        Me.lblRollNumber.Text = "Roll Number"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(370, 161)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(59, 17)
        Me.lblEmail.TabIndex = 57
        Me.lblEmail.Text = "Email ID"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(32, 45)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(45, 17)
        Me.lblName.TabIndex = 49
        Me.lblName.Text = "Name"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(370, 207)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(60, 17)
        Me.lblAddress.TabIndex = 52
        Me.lblAddress.Text = "Address"
        '
        'lblPassingYear
        '
        Me.lblPassingYear.AutoSize = True
        Me.lblPassingYear.Location = New System.Drawing.Point(370, 124)
        Me.lblPassingYear.Name = "lblPassingYear"
        Me.lblPassingYear.Size = New System.Drawing.Size(92, 17)
        Me.lblPassingYear.TabIndex = 62
        Me.lblPassingYear.Text = "Passing Year"
        '
        'lblFatherName
        '
        Me.lblFatherName.AutoSize = True
        Me.lblFatherName.Location = New System.Drawing.Point(32, 84)
        Me.lblFatherName.Name = "lblFatherName"
        Me.lblFatherName.Size = New System.Drawing.Size(100, 17)
        Me.lblFatherName.TabIndex = 50
        Me.lblFatherName.Text = "Father's Name"
        '
        'lblMotherName
        '
        Me.lblMotherName.AutoSize = True
        Me.lblMotherName.Location = New System.Drawing.Point(32, 124)
        Me.lblMotherName.Name = "lblMotherName"
        Me.lblMotherName.Size = New System.Drawing.Size(103, 17)
        Me.lblMotherName.TabIndex = 51
        Me.lblMotherName.Text = "Mother's Name"
        '
        'lblMobile
        '
        Me.lblMobile.AutoSize = True
        Me.lblMobile.Location = New System.Drawing.Point(32, 207)
        Me.lblMobile.Name = "lblMobile"
        Me.lblMobile.Size = New System.Drawing.Size(49, 17)
        Me.lblMobile.TabIndex = 53
        Me.lblMobile.Text = "Mobile"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(32, 249)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(56, 17)
        Me.lblGender.TabIndex = 54
        Me.lblGender.Text = "Gender"
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Location = New System.Drawing.Point(370, 249)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(65, 17)
        Me.lblCategory.TabIndex = 55
        Me.lblCategory.Text = "Category"
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Location = New System.Drawing.Point(32, 161)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(87, 17)
        Me.lblDOB.TabIndex = 56
        Me.lblDOB.Text = "Date of Birth"
        '
        'deleteStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 456)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtRollNumber)
        Me.Controls.Add(Me.lblIntro)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "deleteStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "deleteStudent"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblIntro As System.Windows.Forms.Label
    Friend WithEvents txtRollNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lbPercentage As System.Windows.Forms.Label
    Friend WithEvents lbBoard As System.Windows.Forms.Label
    Friend WithEvents lbSchool As System.Windows.Forms.Label
    Friend WithEvents lbRoll As System.Windows.Forms.Label
    Friend WithEvents lbEmail As System.Windows.Forms.Label
    Friend WithEvents lbName As System.Windows.Forms.Label
    Friend WithEvents lbAddress As System.Windows.Forms.Label
    Friend WithEvents lbPassing As System.Windows.Forms.Label
    Friend WithEvents lbFather As System.Windows.Forms.Label
    Friend WithEvents lbMother As System.Windows.Forms.Label
    Friend WithEvents lbMobile As System.Windows.Forms.Label
    Friend WithEvents lbGender As System.Windows.Forms.Label
    Friend WithEvents lbCategory As System.Windows.Forms.Label
    Friend WithEvents lbDOB As System.Windows.Forms.Label
    Friend WithEvents lblPercentage12th As System.Windows.Forms.Label
    Friend WithEvents lblBoard12th As System.Windows.Forms.Label
    Friend WithEvents lblSchool As System.Windows.Forms.Label
    Friend WithEvents lblRollNumber As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblPassingYear As System.Windows.Forms.Label
    Friend WithEvents lblFatherName As System.Windows.Forms.Label
    Friend WithEvents lblMotherName As System.Windows.Forms.Label
    Friend WithEvents lblMobile As System.Windows.Forms.Label
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents lblCategory As System.Windows.Forms.Label
    Friend WithEvents lblDOB As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
