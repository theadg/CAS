<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAdminMStore
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formAdminMStore))
        Me.btnAddImage = New System.Windows.Forms.Button()
        Me.pbStorePic = New System.Windows.Forms.PictureBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtStoreSales = New System.Windows.Forms.TextBox()
        Me.txtStoreLocation = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtStoreID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtStoreContact = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtStoreName = New System.Windows.Forms.TextBox()
        Me.dgvStore = New System.Windows.Forms.DataGridView()
        CType(Me.pbStorePic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvStore, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAddImage
        '
        Me.btnAddImage.Location = New System.Drawing.Point(663, 437)
        Me.btnAddImage.Name = "btnAddImage"
        Me.btnAddImage.Size = New System.Drawing.Size(109, 23)
        Me.btnAddImage.TabIndex = 30
        Me.btnAddImage.Text = "ADD IMAGE"
        Me.btnAddImage.UseVisualStyleBackColor = True
        '
        'pbStorePic
        '
        Me.pbStorePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbStorePic.ErrorImage = CType(resources.GetObject("pbStorePic.ErrorImage"), System.Drawing.Image)
        Me.pbStorePic.InitialImage = CType(resources.GetObject("pbStorePic.InitialImage"), System.Drawing.Image)
        Me.pbStorePic.Location = New System.Drawing.Point(663, 270)
        Me.pbStorePic.Name = "pbStorePic"
        Me.pbStorePic.Size = New System.Drawing.Size(204, 161)
        Me.pbStorePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbStorePic.TabIndex = 29
        Me.pbStorePic.TabStop = False
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(76, 403)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 28
        Me.btnRefresh.Text = "REFRESH"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(76, 365)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 27
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(76, 322)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 26
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(76, 284)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 23)
        Me.btnInsert.TabIndex = 25
        Me.btnInsert.Text = "ADD"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtStoreSales)
        Me.GroupBox1.Controls.Add(Me.txtStoreLocation)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtStoreID)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtStoreContact)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtStoreName)
        Me.GroupBox1.Location = New System.Drawing.Point(256, 261)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(338, 278)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Store Information"
        '
        'txtStoreSales
        '
        Me.txtStoreSales.Location = New System.Drawing.Point(139, 197)
        Me.txtStoreSales.Name = "txtStoreSales"
        Me.txtStoreSales.Size = New System.Drawing.Size(153, 20)
        Me.txtStoreSales.TabIndex = 20
        '
        'txtStoreLocation
        '
        Me.txtStoreLocation.Location = New System.Drawing.Point(139, 118)
        Me.txtStoreLocation.Name = "txtStoreLocation"
        Me.txtStoreLocation.Size = New System.Drawing.Size(153, 20)
        Me.txtStoreLocation.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(40, 125)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Location"
        '
        'txtStoreID
        '
        Me.txtStoreID.Location = New System.Drawing.Point(139, 47)
        Me.txtStoreID.Name = "txtStoreID"
        Me.txtStoreID.Size = New System.Drawing.Size(51, 20)
        Me.txtStoreID.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(40, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Product ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 204)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Sales"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Contact"
        '
        'txtStoreContact
        '
        Me.txtStoreContact.Location = New System.Drawing.Point(139, 156)
        Me.txtStoreContact.Name = "txtStoreContact"
        Me.txtStoreContact.Size = New System.Drawing.Size(153, 20)
        Me.txtStoreContact.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name"
        '
        'txtStoreName
        '
        Me.txtStoreName.Location = New System.Drawing.Point(139, 79)
        Me.txtStoreName.Name = "txtStoreName"
        Me.txtStoreName.Size = New System.Drawing.Size(153, 20)
        Me.txtStoreName.TabIndex = 0
        '
        'dgvStore
        '
        Me.dgvStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStore.Location = New System.Drawing.Point(62, 22)
        Me.dgvStore.Name = "dgvStore"
        Me.dgvStore.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvStore.Size = New System.Drawing.Size(842, 220)
        Me.dgvStore.TabIndex = 23
        '
        'formAdminMStore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 561)
        Me.Controls.Add(Me.btnAddImage)
        Me.Controls.Add(Me.pbStorePic)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvStore)
        Me.Name = "formAdminMStore"
        Me.Text = "formAdminMStore"
        CType(Me.pbStorePic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvStore, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAddImage As Button
    Friend WithEvents pbStorePic As PictureBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnInsert As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtStoreID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtStoreContact As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtStoreName As TextBox
    Friend WithEvents dgvStore As DataGridView
    Friend WithEvents txtStoreSales As TextBox
    Friend WithEvents txtStoreLocation As TextBox
End Class
