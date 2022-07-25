<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formAdminMStudents
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formAdminMStudents))
        Me.dgvStudent = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbStudCourse = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbStudentGender = New System.Windows.Forms.ComboBox()
        Me.dtpStudBirthday = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtStudReligion = New System.Windows.Forms.TextBox()
        Me.txtStudID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtStudAddress = New System.Windows.Forms.TextBox()
        Me.txtStudContact = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtStudSection = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtStudName = New System.Windows.Forms.TextBox()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.pbStudPic = New System.Windows.Forms.PictureBox()
        Me.btnAddImage = New System.Windows.Forms.Button()
        Me.btnSaveImage = New System.Windows.Forms.Button()
        CType(Me.dgvStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbStudPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvStudent
        '
        Me.dgvStudent.AllowUserToAddRows = False
        Me.dgvStudent.AllowUserToDeleteRows = False
        Me.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudent.Location = New System.Drawing.Point(27, 27)
        Me.dgvStudent.Name = "dgvStudent"
        Me.dgvStudent.ReadOnly = True
        Me.dgvStudent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvStudent.Size = New System.Drawing.Size(1177, 220)
        Me.dgvStudent.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbStudCourse)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cbStudentGender)
        Me.GroupBox1.Controls.Add(Me.dtpStudBirthday)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtStudReligion)
        Me.GroupBox1.Controls.Add(Me.txtStudID)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtStudAddress)
        Me.GroupBox1.Controls.Add(Me.txtStudContact)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtStudSection)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtStudName)
        Me.GroupBox1.Location = New System.Drawing.Point(221, 266)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(722, 278)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Information"
        '
        'cbStudCourse
        '
        Me.cbStudCourse.FormattingEnabled = True
        Me.cbStudCourse.Items.AddRange(New Object() {"DICT"})
        Me.cbStudCourse.Location = New System.Drawing.Point(169, 149)
        Me.cbStudCourse.Name = "cbStudCourse"
        Me.cbStudCourse.Size = New System.Drawing.Size(153, 21)
        Me.cbStudCourse.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(50, 152)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Section"
        '
        'cbStudentGender
        '
        Me.cbStudentGender.AutoCompleteCustomSource.AddRange(New String() {"M", "F"})
        Me.cbStudentGender.FormattingEnabled = True
        Me.cbStudentGender.Location = New System.Drawing.Point(169, 223)
        Me.cbStudentGender.Name = "cbStudentGender"
        Me.cbStudentGender.Size = New System.Drawing.Size(121, 21)
        Me.cbStudentGender.TabIndex = 17
        '
        'dtpStudBirthday
        '
        Me.dtpStudBirthday.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStudBirthday.Location = New System.Drawing.Point(515, 111)
        Me.dtpStudBirthday.Name = "dtpStudBirthday"
        Me.dtpStudBirthday.Size = New System.Drawing.Size(153, 20)
        Me.dtpStudBirthday.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(397, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Religion"
        '
        'txtStudReligion
        '
        Me.txtStudReligion.Location = New System.Drawing.Point(515, 77)
        Me.txtStudReligion.Name = "txtStudReligion"
        Me.txtStudReligion.Size = New System.Drawing.Size(153, 20)
        Me.txtStudReligion.TabIndex = 14
        '
        'txtStudID
        '
        Me.txtStudID.Location = New System.Drawing.Point(169, 74)
        Me.txtStudID.Name = "txtStudID"
        Me.txtStudID.Size = New System.Drawing.Size(51, 20)
        Me.txtStudID.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(50, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "ID"
        '
        'txtStudAddress
        '
        Me.txtStudAddress.Location = New System.Drawing.Point(515, 188)
        Me.txtStudAddress.Name = "txtStudAddress"
        Me.txtStudAddress.Size = New System.Drawing.Size(153, 20)
        Me.txtStudAddress.TabIndex = 11
        '
        'txtStudContact
        '
        Me.txtStudContact.Location = New System.Drawing.Point(515, 149)
        Me.txtStudContact.Name = "txtStudContact"
        Me.txtStudContact.Size = New System.Drawing.Size(153, 20)
        Me.txtStudContact.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(397, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(394, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Contact"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(394, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Birthday"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 231)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Gender"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Section"
        '
        'txtStudSection
        '
        Me.txtStudSection.Location = New System.Drawing.Point(169, 191)
        Me.txtStudSection.Name = "txtStudSection"
        Me.txtStudSection.Size = New System.Drawing.Size(153, 20)
        Me.txtStudSection.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name"
        '
        'txtStudName
        '
        Me.txtStudName.Location = New System.Drawing.Point(169, 109)
        Me.txtStudName.Name = "txtStudName"
        Me.txtStudName.Size = New System.Drawing.Size(153, 20)
        Me.txtStudName.TabIndex = 0
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(41, 289)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 23)
        Me.btnInsert.TabIndex = 2
        Me.btnInsert.Text = "ADD"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(41, 327)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(41, 370)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(41, 408)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 5
        Me.btnRefresh.Text = "REFRESH"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'pbStudPic
        '
        Me.pbStudPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbStudPic.ErrorImage = CType(resources.GetObject("pbStudPic.ErrorImage"), System.Drawing.Image)
        Me.pbStudPic.Location = New System.Drawing.Point(1000, 253)
        Me.pbStudPic.Name = "pbStudPic"
        Me.pbStudPic.Size = New System.Drawing.Size(204, 161)
        Me.pbStudPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbStudPic.TabIndex = 20
        Me.pbStudPic.TabStop = False
        '
        'btnAddImage
        '
        Me.btnAddImage.Location = New System.Drawing.Point(1000, 420)
        Me.btnAddImage.Name = "btnAddImage"
        Me.btnAddImage.Size = New System.Drawing.Size(109, 23)
        Me.btnAddImage.TabIndex = 21
        Me.btnAddImage.Text = "ADD IMAGE"
        Me.btnAddImage.UseVisualStyleBackColor = True
        '
        'btnSaveImage
        '
        Me.btnSaveImage.Location = New System.Drawing.Point(1000, 457)
        Me.btnSaveImage.Name = "btnSaveImage"
        Me.btnSaveImage.Size = New System.Drawing.Size(109, 23)
        Me.btnSaveImage.TabIndex = 22
        Me.btnSaveImage.Text = "SAVE IMAGE"
        Me.btnSaveImage.UseVisualStyleBackColor = True
        '
        'formAdminMStudents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1301, 594)
        Me.Controls.Add(Me.btnSaveImage)
        Me.Controls.Add(Me.btnAddImage)
        Me.Controls.Add(Me.pbStudPic)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvStudent)
        Me.Name = "formAdminMStudents"
        Me.Text = "formAdminMStudents"
        CType(Me.dgvStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbStudPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvStudent As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnInsert As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtStudID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtStudAddress As TextBox
    Friend WithEvents txtStudContact As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtStudSection As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtStudName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtStudReligion As TextBox
    Friend WithEvents dtpStudBirthday As DateTimePicker
    Friend WithEvents cbStudentGender As ComboBox
    Friend WithEvents cbStudCourse As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents pbStudPic As PictureBox
    Friend WithEvents btnAddImage As Button
    Friend WithEvents btnSaveImage As Button
End Class
