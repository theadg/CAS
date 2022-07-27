<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAdminOrderHistory
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtProdPriceTotal = New System.Windows.Forms.TextBox()
        Me.txtProdQty = New System.Windows.Forms.TextBox()
        Me.txtProdName = New System.Windows.Forms.TextBox()
        Me.txtProdPrice = New System.Windows.Forms.TextBox()
        Me.txtStoreName = New System.Windows.Forms.TextBox()
        Me.txtProdID = New System.Windows.Forms.TextBox()
        Me.txtStoreID = New System.Windows.Forms.TextBox()
        Me.txtOrderID = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RANDOMLABEL = New System.Windows.Forms.Label()
        Me.pbProd = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.lblUserType = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(32, 72)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(698, 203)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Brown
        Me.GroupBox1.Controls.Add(Me.txtProdPriceTotal)
        Me.GroupBox1.Controls.Add(Me.txtProdQty)
        Me.GroupBox1.Controls.Add(Me.txtProdName)
        Me.GroupBox1.Controls.Add(Me.txtProdPrice)
        Me.GroupBox1.Controls.Add(Me.txtStoreName)
        Me.GroupBox1.Controls.Add(Me.txtProdID)
        Me.GroupBox1.Controls.Add(Me.txtStoreID)
        Me.GroupBox1.Controls.Add(Me.txtOrderID)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.RANDOMLABEL)
        Me.GroupBox1.Controls.Add(Me.pbProd)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(774, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(412, 509)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Order Information"
        '
        'txtProdPriceTotal
        '
        Me.txtProdPriceTotal.Location = New System.Drawing.Point(192, 466)
        Me.txtProdPriceTotal.Name = "txtProdPriceTotal"
        Me.txtProdPriceTotal.Size = New System.Drawing.Size(200, 20)
        Me.txtProdPriceTotal.TabIndex = 30
        Me.txtProdPriceTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtProdQty
        '
        Me.txtProdQty.Location = New System.Drawing.Point(192, 418)
        Me.txtProdQty.Name = "txtProdQty"
        Me.txtProdQty.Size = New System.Drawing.Size(200, 20)
        Me.txtProdQty.TabIndex = 29
        Me.txtProdQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtProdName
        '
        Me.txtProdName.Location = New System.Drawing.Point(186, 212)
        Me.txtProdName.Name = "txtProdName"
        Me.txtProdName.Size = New System.Drawing.Size(200, 20)
        Me.txtProdName.TabIndex = 28
        Me.txtProdName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtProdPrice
        '
        Me.txtProdPrice.Location = New System.Drawing.Point(192, 383)
        Me.txtProdPrice.Name = "txtProdPrice"
        Me.txtProdPrice.Size = New System.Drawing.Size(200, 20)
        Me.txtProdPrice.TabIndex = 28
        Me.txtProdPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStoreName
        '
        Me.txtStoreName.Location = New System.Drawing.Point(186, 111)
        Me.txtStoreName.Name = "txtStoreName"
        Me.txtStoreName.Size = New System.Drawing.Size(200, 20)
        Me.txtStoreName.TabIndex = 27
        Me.txtStoreName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtProdID
        '
        Me.txtProdID.Location = New System.Drawing.Point(186, 161)
        Me.txtProdID.Name = "txtProdID"
        Me.txtProdID.Size = New System.Drawing.Size(200, 20)
        Me.txtProdID.TabIndex = 26
        Me.txtProdID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStoreID
        '
        Me.txtStoreID.Location = New System.Drawing.Point(186, 83)
        Me.txtStoreID.Name = "txtStoreID"
        Me.txtStoreID.Size = New System.Drawing.Size(200, 20)
        Me.txtStoreID.TabIndex = 25
        Me.txtStoreID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtOrderID
        '
        Me.txtOrderID.Location = New System.Drawing.Point(186, 54)
        Me.txtOrderID.Name = "txtOrderID"
        Me.txtOrderID.Size = New System.Drawing.Size(200, 20)
        Me.txtOrderID.TabIndex = 24
        Me.txtOrderID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(186, 19)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(32, 418)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(139, 20)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "PRODUCT QTY:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(23, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 20)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "ORDER DATE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(28, 464)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 20)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "TOTAL PRICE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(28, 383)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(158, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "PRODUCT PRICE:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(23, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "PRODUCT NAME:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(23, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "STORE NAME:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(29, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "PRODUCT ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(21, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "STORE ID:"
        '
        'RANDOMLABEL
        '
        Me.RANDOMLABEL.AutoSize = True
        Me.RANDOMLABEL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RANDOMLABEL.ForeColor = System.Drawing.SystemColors.Control
        Me.RANDOMLABEL.Location = New System.Drawing.Point(21, 52)
        Me.RANDOMLABEL.Name = "RANDOMLABEL"
        Me.RANDOMLABEL.Size = New System.Drawing.Size(102, 20)
        Me.RANDOMLABEL.TabIndex = 6
        Me.RANDOMLABEL.Text = "ORDER ID:"
        '
        'pbProd
        '
        Me.pbProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbProd.Location = New System.Drawing.Point(28, 238)
        Me.pbProd.Name = "pbProd"
        Me.pbProd.Size = New System.Drawing.Size(347, 110)
        Me.pbProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbProd.TabIndex = 1
        Me.pbProd.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(429, 55)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ACTIVE ORDERS"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(32, 356)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(698, 203)
        Me.DataGridView2.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(31, 297)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(558, 55)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "COMPLETED ORDERS"
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserID.Location = New System.Drawing.Point(618, 14)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(112, 55)
        Me.lblUserID.TabIndex = 5
        Me.lblUserID.Text = "NO." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblUserType
        '
        Me.lblUserType.AutoSize = True
        Me.lblUserType.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserType.Location = New System.Drawing.Point(781, 1)
        Me.lblUserType.Name = "lblUserType"
        Me.lblUserType.Size = New System.Drawing.Size(153, 55)
        Me.lblUserType.TabIndex = 6
        Me.lblUserType.Text = "TYPE"
        '
        'formAdminOrderHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1198, 580)
        Me.Controls.Add(Me.lblUserType)
        Me.Controls.Add(Me.lblUserID)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "formAdminOrderHistory"
        Me.Text = "formAdminOrderHistory"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RANDOMLABEL As Label
    Friend WithEvents pbProd As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtProdPriceTotal As TextBox
    Friend WithEvents txtProdQty As TextBox
    Friend WithEvents txtProdName As TextBox
    Friend WithEvents txtProdPrice As TextBox
    Friend WithEvents txtStoreName As TextBox
    Friend WithEvents txtProdID As TextBox
    Friend WithEvents txtStoreID As TextBox
    Friend WithEvents txtOrderID As TextBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents lblUserID As Label
    Friend WithEvents lblUserType As Label
End Class
