<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formStoreMActiveOrder
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
        Me.btnNotify = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblStoreID = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnComplete = New System.Windows.Forms.Button()
        Me.txtProdPriceTotal = New System.Windows.Forms.TextBox()
        Me.txtProdQty = New System.Windows.Forms.TextBox()
        Me.txtProdName = New System.Windows.Forms.TextBox()
        Me.txtProdPrice = New System.Windows.Forms.TextBox()
        Me.txtProdID = New System.Windows.Forms.TextBox()
        Me.txtOrderID = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RANDOMLABEL = New System.Windows.Forms.Label()
        Me.pbProd = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnNotifyAll = New System.Windows.Forms.Button()
        Me.btnUpdateSales = New System.Windows.Forms.Button()
        Me.txtSalesTotalMain = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblRowCount = New System.Windows.Forms.Label()
        Me.btnCompleteAll = New System.Windows.Forms.Button()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNotify
        '
        Me.btnNotify.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotify.ForeColor = System.Drawing.Color.Firebrick
        Me.btnNotify.Location = New System.Drawing.Point(19, 274)
        Me.btnNotify.Name = "btnNotify"
        Me.btnNotify.Size = New System.Drawing.Size(320, 61)
        Me.btnNotify.TabIndex = 51
        Me.btnNotify.Text = "NOTIFY USER"
        Me.btnNotify.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Firebrick
        Me.Button1.Location = New System.Drawing.Point(58, 617)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(180, 61)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "REFRESH"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblStoreID
        '
        Me.lblStoreID.AutoSize = True
        Me.lblStoreID.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStoreID.ForeColor = System.Drawing.Color.Firebrick
        Me.lblStoreID.Location = New System.Drawing.Point(1083, 2)
        Me.lblStoreID.Name = "lblStoreID"
        Me.lblStoreID.Size = New System.Drawing.Size(112, 55)
        Me.lblStoreID.TabIndex = 44
        Me.lblStoreID.Text = "NO."
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(0, 19)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(698, 234)
        Me.DataGridView2.TabIndex = 43
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Brown
        Me.GroupBox1.Controls.Add(Me.btnComplete)
        Me.GroupBox1.Controls.Add(Me.txtProdPriceTotal)
        Me.GroupBox1.Controls.Add(Me.txtProdQty)
        Me.GroupBox1.Controls.Add(Me.txtProdName)
        Me.GroupBox1.Controls.Add(Me.txtProdPrice)
        Me.GroupBox1.Controls.Add(Me.txtProdID)
        Me.GroupBox1.Controls.Add(Me.txtOrderID)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.RANDOMLABEL)
        Me.GroupBox1.Controls.Add(Me.pbProd)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(33, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(412, 578)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Order Information"
        '
        'btnComplete
        '
        Me.btnComplete.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComplete.ForeColor = System.Drawing.Color.Firebrick
        Me.btnComplete.Location = New System.Drawing.Point(25, 492)
        Me.btnComplete.Name = "btnComplete"
        Me.btnComplete.Size = New System.Drawing.Size(361, 61)
        Me.btnComplete.TabIndex = 31
        Me.btnComplete.Text = "MARK AS COMPLETE"
        Me.btnComplete.UseVisualStyleBackColor = True
        '
        'txtProdPriceTotal
        '
        Me.txtProdPriceTotal.Location = New System.Drawing.Point(186, 440)
        Me.txtProdPriceTotal.Name = "txtProdPriceTotal"
        Me.txtProdPriceTotal.Size = New System.Drawing.Size(200, 20)
        Me.txtProdPriceTotal.TabIndex = 30
        Me.txtProdPriceTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtProdQty
        '
        Me.txtProdQty.Location = New System.Drawing.Point(186, 392)
        Me.txtProdQty.Name = "txtProdQty"
        Me.txtProdQty.Size = New System.Drawing.Size(200, 20)
        Me.txtProdQty.TabIndex = 29
        Me.txtProdQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtProdName
        '
        Me.txtProdName.Location = New System.Drawing.Point(186, 163)
        Me.txtProdName.Name = "txtProdName"
        Me.txtProdName.Size = New System.Drawing.Size(200, 20)
        Me.txtProdName.TabIndex = 28
        Me.txtProdName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtProdPrice
        '
        Me.txtProdPrice.Location = New System.Drawing.Point(186, 357)
        Me.txtProdPrice.Name = "txtProdPrice"
        Me.txtProdPrice.Size = New System.Drawing.Size(200, 20)
        Me.txtProdPrice.TabIndex = 28
        Me.txtProdPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtProdID
        '
        Me.txtProdID.Location = New System.Drawing.Point(186, 121)
        Me.txtProdID.Name = "txtProdID"
        Me.txtProdID.Size = New System.Drawing.Size(200, 20)
        Me.txtProdID.TabIndex = 26
        Me.txtProdID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.Label9.Location = New System.Drawing.Point(26, 392)
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
        Me.Label8.Location = New System.Drawing.Point(22, 438)
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
        Me.Label6.Location = New System.Drawing.Point(22, 357)
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
        Me.Label5.Location = New System.Drawing.Point(23, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "PRODUCT NAME:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(21, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "PRODUCT ID:"
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
        Me.pbProd.Location = New System.Drawing.Point(27, 231)
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
        Me.Label1.Location = New System.Drawing.Point(487, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(429, 55)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "ACTIVE ORDERS"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(32, 20)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(698, 234)
        Me.DataGridView1.TabIndex = 40
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnNotifyAll)
        Me.GroupBox2.Controls.Add(Me.DataGridView2)
        Me.GroupBox2.Controls.Add(Me.btnNotify)
        Me.GroupBox2.Location = New System.Drawing.Point(530, 391)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(698, 354)
        Me.GroupBox2.TabIndex = 52
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'btnNotifyAll
        '
        Me.btnNotifyAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotifyAll.ForeColor = System.Drawing.Color.Firebrick
        Me.btnNotifyAll.Location = New System.Drawing.Point(372, 274)
        Me.btnNotifyAll.Name = "btnNotifyAll"
        Me.btnNotifyAll.Size = New System.Drawing.Size(320, 61)
        Me.btnNotifyAll.TabIndex = 52
        Me.btnNotifyAll.Text = "NOTIFY ALL USERS"
        Me.btnNotifyAll.UseVisualStyleBackColor = True
        '
        'btnUpdateSales
        '
        Me.btnUpdateSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateSales.ForeColor = System.Drawing.Color.Firebrick
        Me.btnUpdateSales.Location = New System.Drawing.Point(63, 693)
        Me.btnUpdateSales.Name = "btnUpdateSales"
        Me.btnUpdateSales.Size = New System.Drawing.Size(270, 61)
        Me.btnUpdateSales.TabIndex = 46
        Me.btnUpdateSales.Text = "UPDATE SALES"
        Me.btnUpdateSales.UseVisualStyleBackColor = True
        '
        'txtSalesTotalMain
        '
        Me.txtSalesTotalMain.Location = New System.Drawing.Point(258, 658)
        Me.txtSalesTotalMain.Name = "txtSalesTotalMain"
        Me.txtSalesTotalMain.Size = New System.Drawing.Size(161, 20)
        Me.txtSalesTotalMain.TabIndex = 47
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblRowCount)
        Me.GroupBox3.Controls.Add(Me.btnCompleteAll)
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Location = New System.Drawing.Point(498, 64)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(742, 321)
        Me.GroupBox3.TabIndex = 53
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'lblRowCount
        '
        Me.lblRowCount.AutoSize = True
        Me.lblRowCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRowCount.ForeColor = System.Drawing.Color.Firebrick
        Me.lblRowCount.Location = New System.Drawing.Point(41, 257)
        Me.lblRowCount.Name = "lblRowCount"
        Me.lblRowCount.Size = New System.Drawing.Size(112, 55)
        Me.lblRowCount.TabIndex = 54
        Me.lblRowCount.Text = "NO."
        '
        'btnCompleteAll
        '
        Me.btnCompleteAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompleteAll.ForeColor = System.Drawing.Color.Firebrick
        Me.btnCompleteAll.Location = New System.Drawing.Point(181, 260)
        Me.btnCompleteAll.Name = "btnCompleteAll"
        Me.btnCompleteAll.Size = New System.Drawing.Size(549, 61)
        Me.btnCompleteAll.TabIndex = 53
        Me.btnCompleteAll.Text = "MARK ALL AS COMPLETE"
        Me.btnCompleteAll.UseVisualStyleBackColor = True
        '
        'formStoreMActiveOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1267, 783)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtSalesTotalMain)
        Me.Controls.Add(Me.btnUpdateSales)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblStoreID)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "formStoreMActiveOrder"
        Me.Text = "formStoreMActiveOrder"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNotify As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lblStoreID As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnComplete As Button
    Friend WithEvents txtProdPriceTotal As TextBox
    Friend WithEvents txtProdQty As TextBox
    Friend WithEvents txtProdName As TextBox
    Friend WithEvents txtProdPrice As TextBox
    Friend WithEvents txtProdID As TextBox
    Friend WithEvents txtOrderID As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RANDOMLABEL As Label
    Friend WithEvents pbProd As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnNotifyAll As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnUpdateSales As Button
    Friend WithEvents txtSalesTotalMain As TextBox
    Friend WithEvents btnCompleteAll As Button
    Friend WithEvents lblRowCount As Label
End Class
