﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddStudent
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblError = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtRollNumber = New System.Windows.Forms.TextBox()
        Me.lblRollNumber = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblIntro = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.comboCategory = New System.Windows.Forms.ComboBox()
        Me.lblFatherName = New System.Windows.Forms.Label()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.lblMotherName = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.DatePickerDOB = New System.Windows.Forms.DateTimePicker()
        Me.lblMobile = New System.Windows.Forms.Label()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.txtMother = New System.Windows.Forms.TextBox()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.txtFather = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblEducation = New System.Windows.Forms.Label()
        Me.txtPercentage = New System.Windows.Forms.TextBox()
        Me.lblPercentage12th = New System.Windows.Forms.Label()
        Me.txtBoard = New System.Windows.Forms.TextBox()
        Me.lblBoard12th = New System.Windows.Forms.Label()
        Me.txtSchool = New System.Windows.Forms.TextBox()
        Me.lblSchool = New System.Windows.Forms.Label()
        Me.txtPassingYear = New System.Windows.Forms.TextBox()
        Me.lblPassingYear = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(880, 45)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Student_Management_System.My.Resources.Resources.Add_User_Male_96px
        Me.PictureBox1.Location = New System.Drawing.Point(317, 0)
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
        Me.lblTitle.Location = New System.Drawing.Point(367, 4)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(155, 33)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Add Student "
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 45)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(880, 593)
        Me.Panel2.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.lblError)
        Me.Panel5.Controls.Add(Me.btnSubmit)
        Me.Panel5.Controls.Add(Me.btnCancel)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 478)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(880, 115)
        Me.Panel5.TabIndex = 55
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Location = New System.Drawing.Point(285, 59)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(74, 17)
        Me.lblError.TabIndex = 55
        Me.lblError.Text = "{{lblError}}"
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
        Me.btnSubmit.Location = New System.Drawing.Point(372, 11)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(82, 30)
        Me.btnSubmit.TabIndex = 53
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
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
        Me.btnCancel.Location = New System.Drawing.Point(460, 11)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(78, 30)
        Me.btnCancel.TabIndex = 54
        Me.btnCancel.Text = "Exit"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtRollNumber)
        Me.Panel3.Controls.Add(Me.lblRollNumber)
        Me.Panel3.Controls.Add(Me.txtEmail)
        Me.Panel3.Controls.Add(Me.lblIntro)
        Me.Panel3.Controls.Add(Me.lblEmail)
        Me.Panel3.Controls.Add(Me.lblName)
        Me.Panel3.Controls.Add(Me.comboCategory)
        Me.Panel3.Controls.Add(Me.lblFatherName)
        Me.Panel3.Controls.Add(Me.RadioButton2)
        Me.Panel3.Controls.Add(Me.lblMotherName)
        Me.Panel3.Controls.Add(Me.RadioButton1)
        Me.Panel3.Controls.Add(Me.lblAddress)
        Me.Panel3.Controls.Add(Me.DatePickerDOB)
        Me.Panel3.Controls.Add(Me.lblMobile)
        Me.Panel3.Controls.Add(Me.txtMobile)
        Me.Panel3.Controls.Add(Me.lblGender)
        Me.Panel3.Controls.Add(Me.txtAddress)
        Me.Panel3.Controls.Add(Me.lblCategory)
        Me.Panel3.Controls.Add(Me.txtMother)
        Me.Panel3.Controls.Add(Me.lblDOB)
        Me.Panel3.Controls.Add(Me.txtFather)
        Me.Panel3.Controls.Add(Me.txtName)
        Me.Panel3.Location = New System.Drawing.Point(3, 18)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(451, 460)
        Me.Panel3.TabIndex = 0
        '
        'txtRollNumber
        '
        Me.txtRollNumber.Location = New System.Drawing.Point(197, 41)
        Me.txtRollNumber.Name = "txtRollNumber"
        Me.txtRollNumber.Size = New System.Drawing.Size(214, 23)
        Me.txtRollNumber.TabIndex = 44
        '
        'lblRollNumber
        '
        Me.lblRollNumber.AutoSize = True
        Me.lblRollNumber.Location = New System.Drawing.Point(32, 41)
        Me.lblRollNumber.Name = "lblRollNumber"
        Me.lblRollNumber.Size = New System.Drawing.Size(86, 17)
        Me.lblRollNumber.TabIndex = 43
        Me.lblRollNumber.Text = "Roll Number"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(197, 419)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(214, 23)
        Me.txtEmail.TabIndex = 42
        '
        'lblIntro
        '
        Me.lblIntro.AutoSize = True
        Me.lblIntro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntro.Location = New System.Drawing.Point(172, 4)
        Me.lblIntro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIntro.Name = "lblIntro"
        Me.lblIntro.Size = New System.Drawing.Size(128, 18)
        Me.lblIntro.TabIndex = 23
        Me.lblIntro.Text = "BASIC DETAILS"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(32, 419)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(59, 17)
        Me.lblEmail.TabIndex = 41
        Me.lblEmail.Text = "Email ID"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(32, 74)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(45, 17)
        Me.lblName.TabIndex = 24
        Me.lblName.Text = "Name"
        '
        'comboCategory
        '
        Me.comboCategory.FormattingEnabled = True
        Me.comboCategory.Items.AddRange(New Object() {"SC", "ST", "GENERAL", "OBC"})
        Me.comboCategory.Location = New System.Drawing.Point(197, 315)
        Me.comboCategory.Name = "comboCategory"
        Me.comboCategory.Size = New System.Drawing.Size(214, 24)
        Me.comboCategory.TabIndex = 40
        '
        'lblFatherName
        '
        Me.lblFatherName.AutoSize = True
        Me.lblFatherName.Location = New System.Drawing.Point(32, 113)
        Me.lblFatherName.Name = "lblFatherName"
        Me.lblFatherName.Size = New System.Drawing.Size(100, 17)
        Me.lblFatherName.TabIndex = 25
        Me.lblFatherName.Text = "Father's Name"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(309, 278)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(72, 21)
        Me.RadioButton2.TabIndex = 39
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Female"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'lblMotherName
        '
        Me.lblMotherName.AutoSize = True
        Me.lblMotherName.Location = New System.Drawing.Point(32, 153)
        Me.lblMotherName.Name = "lblMotherName"
        Me.lblMotherName.Size = New System.Drawing.Size(103, 17)
        Me.lblMotherName.TabIndex = 26
        Me.lblMotherName.Text = "Mother's Name"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(197, 278)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(56, 21)
        Me.RadioButton1.TabIndex = 38
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Male"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(32, 356)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(60, 17)
        Me.lblAddress.TabIndex = 27
        Me.lblAddress.Text = "Address"
        '
        'DatePickerDOB
        '
        Me.DatePickerDOB.Location = New System.Drawing.Point(197, 190)
        Me.DatePickerDOB.Name = "DatePickerDOB"
        Me.DatePickerDOB.Size = New System.Drawing.Size(200, 23)
        Me.DatePickerDOB.TabIndex = 37
        '
        'lblMobile
        '
        Me.lblMobile.AutoSize = True
        Me.lblMobile.Location = New System.Drawing.Point(32, 236)
        Me.lblMobile.Name = "lblMobile"
        Me.lblMobile.Size = New System.Drawing.Size(49, 17)
        Me.lblMobile.TabIndex = 28
        Me.lblMobile.Text = "Mobile"
        '
        'txtMobile
        '
        Me.txtMobile.Location = New System.Drawing.Point(197, 236)
        Me.txtMobile.MaxLength = 10
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(214, 23)
        Me.txtMobile.TabIndex = 36
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(32, 278)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(56, 17)
        Me.lblGender.TabIndex = 29
        Me.lblGender.Text = "Gender"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(197, 353)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(214, 47)
        Me.txtAddress.TabIndex = 35
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Location = New System.Drawing.Point(32, 315)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(65, 17)
        Me.lblCategory.TabIndex = 30
        Me.lblCategory.Text = "Category"
        '
        'txtMother
        '
        Me.txtMother.Location = New System.Drawing.Point(197, 153)
        Me.txtMother.Name = "txtMother"
        Me.txtMother.Size = New System.Drawing.Size(214, 23)
        Me.txtMother.TabIndex = 34
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Location = New System.Drawing.Point(32, 190)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(87, 17)
        Me.lblDOB.TabIndex = 31
        Me.lblDOB.Text = "Date of Birth"
        '
        'txtFather
        '
        Me.txtFather.Location = New System.Drawing.Point(197, 107)
        Me.txtFather.Name = "txtFather"
        Me.txtFather.Size = New System.Drawing.Size(214, 23)
        Me.txtFather.TabIndex = 33
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(197, 71)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(214, 23)
        Me.txtName.TabIndex = 32
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.lblEducation)
        Me.Panel4.Controls.Add(Me.txtPercentage)
        Me.Panel4.Controls.Add(Me.lblPercentage12th)
        Me.Panel4.Controls.Add(Me.txtBoard)
        Me.Panel4.Controls.Add(Me.lblBoard12th)
        Me.Panel4.Controls.Add(Me.txtSchool)
        Me.Panel4.Controls.Add(Me.lblSchool)
        Me.Panel4.Controls.Add(Me.txtPassingYear)
        Me.Panel4.Controls.Add(Me.lblPassingYear)
        Me.Panel4.Location = New System.Drawing.Point(457, 18)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(423, 354)
        Me.Panel4.TabIndex = 1
        '
        'lblEducation
        '
        Me.lblEducation.AutoSize = True
        Me.lblEducation.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEducation.Location = New System.Drawing.Point(90, 4)
        Me.lblEducation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEducation.Name = "lblEducation"
        Me.lblEducation.Size = New System.Drawing.Size(232, 18)
        Me.lblEducation.TabIndex = 45
        Me.lblEducation.Text = "EDUCATION QUALIFICATION"
        '
        'txtPercentage
        '
        Me.txtPercentage.Location = New System.Drawing.Point(178, 38)
        Me.txtPercentage.Name = "txtPercentage"
        Me.txtPercentage.Size = New System.Drawing.Size(214, 23)
        Me.txtPercentage.TabIndex = 49
        '
        'lblPercentage12th
        '
        Me.lblPercentage12th.AutoSize = True
        Me.lblPercentage12th.Location = New System.Drawing.Point(13, 41)
        Me.lblPercentage12th.Name = "lblPercentage12th"
        Me.lblPercentage12th.Size = New System.Drawing.Size(113, 17)
        Me.lblPercentage12th.TabIndex = 45
        Me.lblPercentage12th.Text = "12th Percentage"
        '
        'txtBoard
        '
        Me.txtBoard.Location = New System.Drawing.Point(178, 74)
        Me.txtBoard.Name = "txtBoard"
        Me.txtBoard.Size = New System.Drawing.Size(214, 23)
        Me.txtBoard.TabIndex = 50
        '
        'lblBoard12th
        '
        Me.lblBoard12th.AutoSize = True
        Me.lblBoard12th.Location = New System.Drawing.Point(13, 80)
        Me.lblBoard12th.Name = "lblBoard12th"
        Me.lblBoard12th.Size = New System.Drawing.Size(78, 17)
        Me.lblBoard12th.TabIndex = 46
        Me.lblBoard12th.Text = "12th Board"
        '
        'txtSchool
        '
        Me.txtSchool.Location = New System.Drawing.Point(178, 120)
        Me.txtSchool.Name = "txtSchool"
        Me.txtSchool.Size = New System.Drawing.Size(214, 23)
        Me.txtSchool.TabIndex = 51
        '
        'lblSchool
        '
        Me.lblSchool.AutoSize = True
        Me.lblSchool.Location = New System.Drawing.Point(13, 120)
        Me.lblSchool.Name = "lblSchool"
        Me.lblSchool.Size = New System.Drawing.Size(51, 17)
        Me.lblSchool.TabIndex = 47
        Me.lblSchool.Text = "School"
        '
        'txtPassingYear
        '
        Me.txtPassingYear.Location = New System.Drawing.Point(178, 171)
        Me.txtPassingYear.Name = "txtPassingYear"
        Me.txtPassingYear.Size = New System.Drawing.Size(214, 23)
        Me.txtPassingYear.TabIndex = 52
        '
        'lblPassingYear
        '
        Me.lblPassingYear.AutoSize = True
        Me.lblPassingYear.Location = New System.Drawing.Point(13, 174)
        Me.lblPassingYear.Name = "lblPassingYear"
        Me.lblPassingYear.Size = New System.Drawing.Size(92, 17)
        Me.lblPassingYear.TabIndex = 48
        Me.lblPassingYear.Text = "Passing Year"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'AddStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 638)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AddStudent"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddStudent"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblIntro As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents comboCategory As System.Windows.Forms.ComboBox
    Friend WithEvents lblFatherName As System.Windows.Forms.Label
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents lblMotherName As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents DatePickerDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblMobile As System.Windows.Forms.Label
    Friend WithEvents txtMobile As System.Windows.Forms.TextBox
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblCategory As System.Windows.Forms.Label
    Friend WithEvents txtMother As System.Windows.Forms.TextBox
    Friend WithEvents lblDOB As System.Windows.Forms.Label
    Friend WithEvents txtFather As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtRollNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblRollNumber As System.Windows.Forms.Label
    Friend WithEvents lblEducation As System.Windows.Forms.Label
    Friend WithEvents txtPercentage As System.Windows.Forms.TextBox
    Friend WithEvents lblPercentage12th As System.Windows.Forms.Label
    Friend WithEvents txtBoard As System.Windows.Forms.TextBox
    Friend WithEvents lblBoard12th As System.Windows.Forms.Label
    Friend WithEvents txtSchool As System.Windows.Forms.TextBox
    Friend WithEvents lblSchool As System.Windows.Forms.Label
    Friend WithEvents txtPassingYear As System.Windows.Forms.TextBox
    Friend WithEvents lblPassingYear As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lblError As System.Windows.Forms.Label
End Class
