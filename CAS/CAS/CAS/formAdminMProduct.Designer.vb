<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAdminMProduct
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formAdminMProduct))
        Me.btnAddImage = New System.Windows.Forms.Button()
        Me.pbProductPic = New System.Windows.Forms.PictureBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtStoreIDreal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtProductQty = New System.Windows.Forms.TextBox()
        Me.txtProductDescription = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtProductID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProductPrice = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.dgvProduct = New System.Windows.Forms.DataGridView()
        Me.txtStoreID = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        CType(Me.pbProductPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAddImage
        '
        Me.btnAddImage.Location = New System.Drawing.Point(703, 474)
        Me.btnAddImage.Name = "btnAddImage"
        Me.btnAddImage.Size = New System.Drawing.Size(109, 23)
        Me.btnAddImage.TabIndex = 39
        Me.btnAddImage.Text = "ADD IMAGE"
        Me.btnAddImage.UseVisualStyleBackColor = True
        '
        'pbProductPic
        '
        Me.pbProductPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbProductPic.ErrorImage = CType(resources.GetObject("pbProductPic.ErrorImage"), System.Drawing.Image)
        Me.pbProductPic.InitialImage = CType(resources.GetObject("pbProductPic.InitialImage"), System.Drawing.Image)
        Me.pbProductPic.Location = New System.Drawing.Point(658, 284)
        Me.pbProductPic.Name = "pbProductPic"
        Me.pbProductPic.Size = New System.Drawing.Size(204, 161)
        Me.pbProductPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbProductPic.TabIndex = 38
        Me.pbProductPic.TabStop = False
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(30, 422)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 37
        Me.btnRefresh.Text = "REFRESH"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(30, 384)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 36
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(30, 341)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 35
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(30, 303)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 23)
        Me.btnInsert.TabIndex = 34
        Me.btnInsert.Text = "ADD"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtStoreIDreal)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtProductQty)
        Me.GroupBox1.Controls.Add(Me.txtProductDescription)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtProductID)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtProductPrice)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtProductName)
        Me.GroupBox1.Location = New System.Drawing.Point(210, 280)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(375, 278)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product Information"
        '
        'txtStoreIDreal
        '
        Me.txtStoreIDreal.Location = New System.Drawing.Point(135, 43)
        Me.txtStoreIDreal.Name = "txtStoreIDreal"
        Me.txtStoreIDreal.Size = New System.Drawing.Size(51, 20)
        Me.txtStoreIDreal.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Store ID"
        '
        'txtProductQty
        '
        Me.txtProductQty.Location = New System.Drawing.Point(135, 222)
        Me.txtProductQty.Name = "txtProductQty"
        Me.txtProductQty.Size = New System.Drawing.Size(153, 20)
        Me.txtProductQty.TabIndex = 20
        '
        'txtProductDescription
        '
        Me.txtProductDescription.Location = New System.Drawing.Point(135, 143)
        Me.txtProductDescription.Name = "txtProductDescription"
        Me.txtProductDescription.Size = New System.Drawing.Size(153, 20)
        Me.txtProductDescription.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(36, 150)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Description"
        '
        'txtProductID
        '
        Me.txtProductID.Location = New System.Drawing.Point(135, 72)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.Size = New System.Drawing.Size(51, 20)
        Me.txtProductID.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(36, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Product ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 229)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Qty"
        '
        'txtProductPrice
        '
        Me.txtProductPrice.Location = New System.Drawing.Point(135, 181)
        Me.txtProductPrice.Name = "txtProductPrice"
        Me.txtProductPrice.Size = New System.Drawing.Size(153, 20)
        Me.txtProductPrice.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name"
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(135, 104)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(153, 20)
        Me.txtProductName.TabIndex = 0
        '
        'dgvProduct
        '
        Me.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProduct.Location = New System.Drawing.Point(30, 74)
        Me.dgvProduct.Name = "dgvProduct"
        Me.dgvProduct.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvProduct.Size = New System.Drawing.Size(846, 187)
        Me.dgvProduct.TabIndex = 32
        '
        'txtStoreID
        '
        Me.txtStoreID.Location = New System.Drawing.Point(30, 32)
        Me.txtStoreID.Name = "txtStoreID"
        Me.txtStoreID.Size = New System.Drawing.Size(105, 20)
        Me.txtStoreID.TabIndex = 21
        Me.txtStoreID.Text = "2"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(163, 32)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 40
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'formAdminMProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(977, 598)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtStoreID)
        Me.Controls.Add(Me.btnAddImage)
        Me.Controls.Add(Me.pbProductPic)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvProduct)
        Me.Name = "formAdminMProduct"
        Me.Text = "formAdminMProduct"
        CType(Me.pbProductPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAddImage As Button
    Friend WithEvents pbProductPic As PictureBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnInsert As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtProductQty As TextBox
    Friend WithEvents txtProductDescription As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtProductID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtProductPrice As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents dgvProduct As DataGridView
    Friend WithEvents txtStoreID As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtStoreIDreal As TextBox
    Friend WithEvents Label4 As Label
End Class
