<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TXTFIRSTNAME = New System.Windows.Forms.TextBox()
        Me.TXTLNAME = New System.Windows.Forms.TextBox()
        Me.TXTCOURSE = New System.Windows.Forms.TextBox()
        Me.TXTYR = New System.Windows.Forms.TextBox()
        Me.TXTAGE = New System.Windows.Forms.TextBox()
        Me.TXTEMAIL = New System.Windows.Forms.TextBox()
        Me.Pic1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StudentdbDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentdbDataSet = New ptuanginangpicture.studentdbDataSet()
        CType(Me.Pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentdbDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(68, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TXTFIRSTNAME
        '
        Me.TXTFIRSTNAME.Location = New System.Drawing.Point(112, 99)
        Me.TXTFIRSTNAME.Name = "TXTFIRSTNAME"
        Me.TXTFIRSTNAME.Size = New System.Drawing.Size(100, 20)
        Me.TXTFIRSTNAME.TabIndex = 1
        '
        'TXTLNAME
        '
        Me.TXTLNAME.Location = New System.Drawing.Point(112, 139)
        Me.TXTLNAME.Name = "TXTLNAME"
        Me.TXTLNAME.Size = New System.Drawing.Size(100, 20)
        Me.TXTLNAME.TabIndex = 2
        '
        'TXTCOURSE
        '
        Me.TXTCOURSE.Location = New System.Drawing.Point(112, 177)
        Me.TXTCOURSE.Name = "TXTCOURSE"
        Me.TXTCOURSE.Size = New System.Drawing.Size(100, 20)
        Me.TXTCOURSE.TabIndex = 3
        '
        'TXTYR
        '
        Me.TXTYR.Location = New System.Drawing.Point(112, 220)
        Me.TXTYR.Name = "TXTYR"
        Me.TXTYR.Size = New System.Drawing.Size(100, 20)
        Me.TXTYR.TabIndex = 4
        '
        'TXTAGE
        '
        Me.TXTAGE.Location = New System.Drawing.Point(112, 257)
        Me.TXTAGE.Name = "TXTAGE"
        Me.TXTAGE.Size = New System.Drawing.Size(100, 20)
        Me.TXTAGE.TabIndex = 5
        '
        'TXTEMAIL
        '
        Me.TXTEMAIL.Location = New System.Drawing.Point(112, 297)
        Me.TXTEMAIL.Name = "TXTEMAIL"
        Me.TXTEMAIL.Size = New System.Drawing.Size(100, 20)
        Me.TXTEMAIL.TabIndex = 6
        '
        'Pic1
        '
        Me.Pic1.Location = New System.Drawing.Point(326, 99)
        Me.Pic1.Name = "Pic1"
        Me.Pic1.Size = New System.Drawing.Size(280, 218)
        Me.Pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic1.TabIndex = 7
        Me.Pic1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(330, 349)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(275, 45)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Browse Image"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(112, 349)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 45)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "SAVE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(193, 11)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 45)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "SEARCH"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.DataSource = Me.StudentdbDataSetBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(112, 447)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1044, 133)
        Me.DataGridView1.TabIndex = 11
        '
        'StudentdbDataSetBindingSource
        '
        Me.StudentdbDataSetBindingSource.DataSource = Me.StudentdbDataSet
        Me.StudentdbDataSetBindingSource.Position = 0
        '
        'StudentdbDataSet
        '
        Me.StudentdbDataSet.DataSetName = "studentdbDataSet"
        Me.StudentdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1215, 815)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Pic1)
        Me.Controls.Add(Me.TXTEMAIL)
        Me.Controls.Add(Me.TXTAGE)
        Me.Controls.Add(Me.TXTYR)
        Me.Controls.Add(Me.TXTCOURSE)
        Me.Controls.Add(Me.TXTLNAME)
        Me.Controls.Add(Me.TXTFIRSTNAME)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Pic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentdbDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TXTFIRSTNAME As TextBox
    Friend WithEvents TXTLNAME As TextBox
    Friend WithEvents TXTCOURSE As TextBox
    Friend WithEvents TXTYR As TextBox
    Friend WithEvents TXTAGE As TextBox
    Friend WithEvents TXTEMAIL As TextBox
    Friend WithEvents Pic1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents StudentdbDataSetBindingSource As BindingSource
    Friend WithEvents StudentdbDataSet As studentdbDataSet
End Class
