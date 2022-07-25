<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formStore
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.lblStoreID = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnUpdateSales = New System.Windows.Forms.Button()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.txtSalesTotalMain = New System.Windows.Forms.TextBox()
        Me.btnUpdateQty = New System.Windows.Forms.Button()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnNotify = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InventoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateInventoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageOrdersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(488, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(429, 55)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ACTIVE ORDERS"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(498, 79)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(698, 234)
        Me.DataGridView1.TabIndex = 3
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
        Me.GroupBox1.Location = New System.Drawing.Point(34, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(412, 578)
        Me.GroupBox1.TabIndex = 5
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
        Me.txtProdName.Location = New System.Drawing.Point(183, 163)
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(499, 318)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(558, 55)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "COMPLETED ORDERS"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(498, 376)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(698, 234)
        Me.DataGridView2.TabIndex = 6
        '
        'lblStoreID
        '
        Me.lblStoreID.AutoSize = True
        Me.lblStoreID.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStoreID.ForeColor = System.Drawing.Color.Firebrick
        Me.lblStoreID.Location = New System.Drawing.Point(1084, 24)
        Me.lblStoreID.Name = "lblStoreID"
        Me.lblStoreID.Size = New System.Drawing.Size(112, 55)
        Me.lblStoreID.TabIndex = 8
        Me.lblStoreID.Text = "NO."
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Firebrick
        Me.Button1.Location = New System.Drawing.Point(34, 639)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(180, 61)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "REFRESH"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnUpdateSales
        '
        Me.btnUpdateSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateSales.ForeColor = System.Drawing.Color.Firebrick
        Me.btnUpdateSales.Location = New System.Drawing.Point(575, 639)
        Me.btnUpdateSales.Name = "btnUpdateSales"
        Me.btnUpdateSales.Size = New System.Drawing.Size(270, 61)
        Me.btnUpdateSales.TabIndex = 33
        Me.btnUpdateSales.Text = "UPDATE SALES"
        Me.btnUpdateSales.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(52, 967)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(1144, 82)
        Me.DataGridView3.TabIndex = 34
        '
        'txtSalesTotalMain
        '
        Me.txtSalesTotalMain.Location = New System.Drawing.Point(704, 726)
        Me.txtSalesTotalMain.Name = "txtSalesTotalMain"
        Me.txtSalesTotalMain.Size = New System.Drawing.Size(161, 20)
        Me.txtSalesTotalMain.TabIndex = 35
        '
        'btnUpdateQty
        '
        Me.btnUpdateQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateQty.ForeColor = System.Drawing.Color.Firebrick
        Me.btnUpdateQty.Location = New System.Drawing.Point(246, 639)
        Me.btnUpdateQty.Name = "btnUpdateQty"
        Me.btnUpdateQty.Size = New System.Drawing.Size(281, 61)
        Me.btnUpdateQty.TabIndex = 36
        Me.btnUpdateQty.Text = "UPDATE QTY"
        Me.btnUpdateQty.UseVisualStyleBackColor = True
        '
        'DataGridView4
        '
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Location = New System.Drawing.Point(52, 797)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.Size = New System.Drawing.Size(1144, 141)
        Me.DataGridView4.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 726)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(497, 55)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "STORE INVENTORY"
        '
        'btnNotify
        '
        Me.btnNotify.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotify.ForeColor = System.Drawing.Color.Firebrick
        Me.btnNotify.Location = New System.Drawing.Point(876, 639)
        Me.btnNotify.Name = "btnNotify"
        Me.btnNotify.Size = New System.Drawing.Size(320, 61)
        Me.btnNotify.TabIndex = 39
        Me.btnNotify.Text = "NOTIFY USER"
        Me.btnNotify.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InventoryToolStripMenuItem, Me.OrdersToolStripMenuItem, Me.AccountToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1231, 24)
        Me.MenuStrip1.TabIndex = 40
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InventoryToolStripMenuItem
        '
        Me.InventoryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateInventoryToolStripMenuItem})
        Me.InventoryToolStripMenuItem.Name = "InventoryToolStripMenuItem"
        Me.InventoryToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.InventoryToolStripMenuItem.Text = "Inventory"
        '
        'UpdateInventoryToolStripMenuItem
        '
        Me.UpdateInventoryToolStripMenuItem.Name = "UpdateInventoryToolStripMenuItem"
        Me.UpdateInventoryToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.UpdateInventoryToolStripMenuItem.Text = "Update Inventory"
        '
        'OrdersToolStripMenuItem
        '
        Me.OrdersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageOrdersToolStripMenuItem})
        Me.OrdersToolStripMenuItem.Name = "OrdersToolStripMenuItem"
        Me.OrdersToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.OrdersToolStripMenuItem.Text = "Orders"
        '
        'ManageOrdersToolStripMenuItem
        '
        Me.ManageOrdersToolStripMenuItem.Name = "ManageOrdersToolStripMenuItem"
        Me.ManageOrdersToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ManageOrdersToolStripMenuItem.Text = "Manage Orders"
        '
        'AccountToolStripMenuItem
        '
        Me.AccountToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.AccountToolStripMenuItem.Name = "AccountToolStripMenuItem"
        Me.AccountToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.AccountToolStripMenuItem.Text = "Account"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'formStore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1231, 1061)
        Me.Controls.Add(Me.btnNotify)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView4)
        Me.Controls.Add(Me.btnUpdateQty)
        Me.Controls.Add(Me.txtSalesTotalMain)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.btnUpdateSales)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblStoreID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "formStore"
        Me.Text = "formStore"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
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
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents lblStoreID As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnUpdateSales As Button
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents txtSalesTotalMain As TextBox
    Friend WithEvents btnUpdateQty As Button
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents btnNotify As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InventoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateInventoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrdersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageOrdersToolStripMenuItem As ToolStripMenuItem
End Class
