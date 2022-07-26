<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formStudentOrderPopUp
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnSub = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.RANDOMLABEL = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.pbProd1 = New System.Windows.Forms.PictureBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbProd1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Brown
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Controls.Add(Me.btnSub)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.txtQty)
        Me.GroupBox1.Controls.Add(Me.lblID)
        Me.GroupBox1.Controls.Add(Me.RANDOMLABEL)
        Me.GroupBox1.Controls.Add(Me.lblPrice)
        Me.GroupBox1.Controls.Add(Me.lblDesc)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.btnOrder)
        Me.GroupBox1.Controls.Add(Me.pbProd1)
        Me.GroupBox1.Location = New System.Drawing.Point(72, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(354, 358)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(25, 262)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "TOTAL"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(167, 262)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(113, 20)
        Me.txtTotal.TabIndex = 11
        '
        'btnSub
        '
        Me.btnSub.Location = New System.Drawing.Point(167, 185)
        Me.btnSub.Name = "btnSub"
        Me.btnSub.Size = New System.Drawing.Size(26, 23)
        Me.btnSub.TabIndex = 10
        Me.btnSub.Text = "-"
        Me.btnSub.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(278, 184)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(31, 23)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(208, 187)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(54, 20)
        Me.txtQty.TabIndex = 8
        Me.txtQty.Text = "1"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.SystemColors.Control
        Me.lblID.Location = New System.Drawing.Point(234, 66)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(28, 20)
        Me.lblID.TabIndex = 7
        Me.lblID.Text = "ID"
        '
        'RANDOMLABEL
        '
        Me.RANDOMLABEL.AutoSize = True
        Me.RANDOMLABEL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RANDOMLABEL.ForeColor = System.Drawing.SystemColors.Control
        Me.RANDOMLABEL.Location = New System.Drawing.Point(184, 66)
        Me.RANDOMLABEL.Name = "RANDOMLABEL"
        Me.RANDOMLABEL.Size = New System.Drawing.Size(33, 20)
        Me.RANDOMLABEL.TabIndex = 6
        Me.RANDOMLABEL.Text = "ID:"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.ForeColor = System.Drawing.SystemColors.Control
        Me.lblPrice.Location = New System.Drawing.Point(15, 190)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(63, 20)
        Me.lblPrice.TabIndex = 5
        Me.lblPrice.Text = "PRICE"
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.ForeColor = System.Drawing.SystemColors.Control
        Me.lblDesc.Location = New System.Drawing.Point(15, 155)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(129, 20)
        Me.lblDesc.TabIndex = 4
        Me.lblDesc.Text = "DESCRIPTION"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.SystemColors.Control
        Me.lblName.Location = New System.Drawing.Point(184, 26)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(59, 20)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "NAME"
        '
        'btnOrder
        '
        Me.btnOrder.Location = New System.Drawing.Point(167, 303)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(165, 37)
        Me.btnOrder.TabIndex = 2
        Me.btnOrder.Text = "ORDER"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'pbProd1
        '
        Me.pbProd1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbProd1.Location = New System.Drawing.Point(19, 26)
        Me.pbProd1.Name = "pbProd1"
        Me.pbProd1.Size = New System.Drawing.Size(150, 110)
        Me.pbProd1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbProd1.TabIndex = 1
        Me.pbProd1.TabStop = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(153, 405)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(199, 20)
        Me.DateTimePicker1.TabIndex = 15
        Me.DateTimePicker1.Visible = False
        '
        'formStudentOrderPopUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Name = "formStudentOrderPopUp"
        Me.Text = "formStudentOrderPopUp"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbProd1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnSub As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtQty As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents RANDOMLABEL As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblDesc As Label
    Friend WithEvents lblName As Label
    Friend WithEvents btnOrder As Button
    Friend WithEvents pbProd1 As PictureBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
