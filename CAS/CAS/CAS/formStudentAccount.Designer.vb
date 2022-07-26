<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formStudentAccount
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
        Me.txtReligion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.cbGender = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpBirthday = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.cbSection = New System.Windows.Forms.ComboBox()
        Me.cbCourse = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pbStudPic = New System.Windows.Forms.PictureBox()
        Me.btnAddImage = New System.Windows.Forms.Button()
        CType(Me.pbStudPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtReligion
        '
        Me.txtReligion.Location = New System.Drawing.Point(371, 44)
        Me.txtReligion.Name = "txtReligion"
        Me.txtReligion.Size = New System.Drawing.Size(138, 20)
        Me.txtReligion.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(285, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Reliogion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 315)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Section"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(287, 277)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "ID"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(91, 40)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(138, 20)
        Me.txtID.TabIndex = 21
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(346, 351)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(138, 23)
        Me.btnSave.TabIndex = 20
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(371, 277)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(138, 20)
        Me.txtPassword.TabIndex = 19
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(91, 72)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(138, 20)
        Me.txtUsername.TabIndex = 18
        '
        'cbGender
        '
        Me.cbGender.FormattingEnabled = True
        Me.cbGender.Location = New System.Drawing.Point(103, 353)
        Me.cbGender.Name = "cbGender"
        Me.cbGender.Size = New System.Drawing.Size(138, 21)
        Me.cbGender.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 356)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Gender"
        '
        'dtpBirthday
        '
        Me.dtpBirthday.Location = New System.Drawing.Point(371, 86)
        Me.dtpBirthday.Name = "dtpBirthday"
        Me.dtpBirthday.Size = New System.Drawing.Size(200, 20)
        Me.dtpBirthday.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(286, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Birthday"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(291, 131)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Contact"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(291, 189)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Address"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(371, 182)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(138, 20)
        Me.txtAddress.TabIndex = 35
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(371, 131)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(138, 20)
        Me.txtContact.TabIndex = 36
        '
        'cbSection
        '
        Me.cbSection.FormattingEnabled = True
        Me.cbSection.Location = New System.Drawing.Point(103, 315)
        Me.cbSection.Name = "cbSection"
        Me.cbSection.Size = New System.Drawing.Size(138, 21)
        Me.cbSection.TabIndex = 37
        '
        'cbCourse
        '
        Me.cbCourse.FormattingEnabled = True
        Me.cbCourse.Location = New System.Drawing.Point(371, 233)
        Me.cbCourse.Name = "cbCourse"
        Me.cbCourse.Size = New System.Drawing.Size(138, 21)
        Me.cbCourse.TabIndex = 38
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(295, 241)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Course"
        '
        'pbStudPic
        '
        Me.pbStudPic.Location = New System.Drawing.Point(32, 120)
        Me.pbStudPic.Name = "pbStudPic"
        Me.pbStudPic.Size = New System.Drawing.Size(197, 132)
        Me.pbStudPic.TabIndex = 40
        Me.pbStudPic.TabStop = False
        '
        'btnAddImage
        '
        Me.btnAddImage.Location = New System.Drawing.Point(80, 274)
        Me.btnAddImage.Name = "btnAddImage"
        Me.btnAddImage.Size = New System.Drawing.Size(138, 23)
        Me.btnAddImage.TabIndex = 41
        Me.btnAddImage.Text = "ADD IMAGE"
        Me.btnAddImage.UseVisualStyleBackColor = True
        '
        'formStudentAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 491)
        Me.Controls.Add(Me.btnAddImage)
        Me.Controls.Add(Me.pbStudPic)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbCourse)
        Me.Controls.Add(Me.cbSection)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtpBirthday)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbGender)
        Me.Controls.Add(Me.txtReligion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Name = "formStudentAccount"
        Me.Text = "formStudentAccount"
        CType(Me.pbStudPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtReligion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents cbGender As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpBirthday As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents cbSection As ComboBox
    Friend WithEvents cbCourse As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents pbStudPic As PictureBox
    Friend WithEvents btnAddImage As Button
End Class
