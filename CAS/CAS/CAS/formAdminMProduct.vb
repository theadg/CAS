'THIS FORM WAS CODED BY: RACKHOLD, RENZ
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class formAdminMProduct
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Documents\CASdb.accdb")
    'Dim con As New OleDb.OleDbConnection(My.Settings.CASdbConnectionString)

    'declarations for getting the image from the database
    Dim da As New OleDb.OleDbDataAdapter
    Dim result As Integer
    Dim imgpath As String
    Dim arrImage() As Byte
    Dim sql As String

    'refreshes the table in the datagrid view
    Sub refreshTable()
        'opens the database connection if it is closed
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter

        'selects everything from the product table where the storeId is based on the storeID textbox
        sql = "Select * from PRODUCTtbl WHERE storeID=" & Val(txtStoreID.Text)
        cmd.Connection = con
        cmd.CommandText = sql
        da.SelectCommand = cmd

        da.Fill(dt)
        dgvProduct.DataSource = dt

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'checks if the textbox is empty Or not a number
        If txtStoreID.Text = String.Empty Or (Not IsNumeric(txtStoreID.Text)) Then
            MsgBox("Invalid input", vbOKOnly + vbCritical)
        Else
            'refreshes the table in the datagrid view
            refreshTable()
        End If

    End Sub
    Private Sub dgvStore_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProduct.CellClick
        'Whenever a cell in the datagrid is clicked, the data of the record will be placed into corresponding controls
        Dim productID As Integer = dgvProduct.CurrentRow.Cells(1).Value
        txtProductID.Text = productID

        txtStoreIDreal.Text = dgvProduct.CurrentRow.Cells(0).Value
        txtProductName.Text = dgvProduct.CurrentRow.Cells(2).Value
        txtProductDescription.Text = dgvProduct.CurrentRow.Cells(3).Value
        txtProductQty.Text = dgvProduct.CurrentRow.Cells(4).Value
        txtProductPrice.Text = dgvProduct.CurrentRow.Cells(5).Value


        Dim picVar = dgvProduct.CurrentRow.Cells(6).Value
        'checks if the image is not Null
        If (picVar) IsNot DBNull.Value Then
            Dim bytes As Byte() = dgvProduct.CurrentRow.Cells(6).Value
            Dim mstream As New System.IO.MemoryStream(bytes)
            pbProductPic.Image = Image.FromStream(mstream)

            'if the image is null, the image will be errorImage
        Else
            pbProductPic.Image = pbProductPic.ErrorImage
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'checks if all necessary controls are with input
        If txtStoreIDreal.Text = String.Empty Or txtProductName.Text = String.Empty Or txtProductDescription.Text = String.Empty Or txtProductPrice.Text = String.Empty Or txtProductQty.Text = String.Empty Then
            'prmpts the user to complete the necessary fields
            MsgBox("Please Complete Necessary fields! ")

        Else
            'updates and refreshes the tables by calling the subs
            updateTable()
            refreshTable()
        End If


    End Sub
    Sub updateTable()
        'opens the database connection if it is closed
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        'saves the image of the picturebox into a variable 
        Dim mstream As New System.IO.MemoryStream()
        If pbProductPic.Image Is Nothing Then
            pbProductPic.Image = pbProductPic.ErrorImage
        End If
        pbProductPic.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrImage = mstream.GetBuffer()
        Dim FileSize As UInt32
        FileSize = mstream.Length
        mstream.Close()

        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        ' con.Open()

        'updates the producttbl with the new values where the product id is based on the productID textbox
        sql = "UPDATE PRODUCTtbl SET storeID=@storeID,productName=@productName, productDesc=@productDesc, productQty=@productQty,
                    productPrice=@productPrice,productPhoto=@productPhoto WHERE productID=" & Val(txtProductID.Text)
        cmd.Parameters.AddWithValue("@storeID", CType(txtStoreIDreal.Text, Integer))
        cmd.Parameters.AddWithValue("@productName", CType(txtProductName.Text, String))
        cmd.Parameters.AddWithValue("@productDesc", CType(txtProductDescription.Text, String))
        cmd.Parameters.AddWithValue("@productQty", CType(txtProductQty.Text, Integer))
        cmd.Parameters.AddWithValue("@productPrice", CType(txtProductPrice.Text, Integer))
        cmd.Parameters.AddWithValue("@productPhoto", arrImage)
        cmd.Connection = con
        cmd.CommandText = sql

        Dim i = cmd.ExecuteNonQuery()
        'tells the user that the record has been successfully updated
        If i > 0 Then
            MsgBox("Record has been UPDATED successfully!")
        Else
            'tells the user that the record has not been successfully updated
            MsgBox("No record has been UPDATED!")
        End If
    End Sub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        'calls the sub that refreshes the table in the datagridview control
        refreshTable()
    End Sub
    'adds the product into the product table
    Sub addProduct()
        'opens the database connection if it is closed
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If


        'saves the image of the picturebox into a variable 
        Dim mstream As New System.IO.MemoryStream()
        If pbProductPic.Image Is Nothing Then
            pbProductPic.Image = pbProductPic.ErrorImage
        End If
        pbProductPic.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrImage = mstream.GetBuffer()
        Dim FileSize As UInt32
        FileSize = mstream.Length
        mstream.Close()


        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand


        'adds the product into the producttbl with the corresponding values
        sql = "INSERT INTO PRODUCTtbl([storeID],[productName],[productDesc],[productQty],[productPrice],[productPhoto]) 
                    VALUES (@storeID,@productName,@productDesc, @productQty, @productPrice, @productPhoto)"
        cmd.Parameters.AddWithValue("@storeID", CType(txtStoreIDreal.Text, Integer))
        cmd.Parameters.AddWithValue("@productName", CType(txtProductName.Text, String))
        cmd.Parameters.AddWithValue("@productDesc", CType(txtProductDescription.Text, String))
        cmd.Parameters.AddWithValue("@productQty", CType(txtProductQty.Text, Integer))
        cmd.Parameters.AddWithValue("@productPrice", CType(txtProductPrice.Text, Integer))

        cmd.Parameters.AddWithValue("@productPhoto", arrImage)

        cmd.Connection = con
        cmd.CommandText = sql

        Dim i = cmd.ExecuteNonQuery()

        'tells the user that the record has been successfully updated
        If i > 0 Then
            MsgBox("Record has been UPDATED successfully!")
        Else
            'tells the user that the record has not been successfully updated
            MsgBox("No record has been UPDATED!")
        End If


    End Sub
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        'checks if all necessary controls are with input
        If txtStoreIDreal.Text = String.Empty Or txtProductName.Text = String.Empty Or txtProductDescription.Text = String.Empty Or txtProductPrice.Text = String.Empty Or txtProductQty.Text = String.Empty Then
            MsgBox("Please Complete Necessary fields! ")
        Else
            'calls the sub to add the prouct to the table 
            addProduct()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'opens the database connection if it is closed
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand

        'delets the record from the product table where the product id is the content of product id textbox
        sql = "DELETE * from PRODUCTtbl WHERE productID=" & Val(txtProductID.Text) & ""
        cmd.Connection = con
        cmd.CommandText = sql

        Dim i = cmd.ExecuteNonQuery()
        If i > 0 Then
            'tells the user that the record has been successfully deleted
            MsgBox("Record has been DELETED successfully!")
        Else
            'tells the user that the record was not deleted
            MsgBox("No record has been DELETED")
        End If


        refreshTable()
    End Sub

    Private Sub btnAddImage_Click(sender As Object, e As EventArgs) Handles btnAddImage.Click
        'opens the openfile dialog control
        Try

            Dim OFD As FileDialog = New OpenFileDialog()

            OFD.Filter = "Image File (*.jpg;*.jpeg;*.bmp;*.gif)|*.jpg;*.jpeg;*.bmp;*.gif"

            If OFD.ShowDialog() = DialogResult.OK Then
                imgpath = OFD.FileName
                pbProductPic.ImageLocation = imgpath

            End If

            OFD = Nothing

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub formAdminMProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'calls the sub to load the table
        loadTable()
        'adjust the size of the column
        dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
    End Sub
    'loads the table
    Sub loadTable()
        'opens the database connection if it is closed
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter

        'selects everything from the producttbl
        sql = "Select * from PRODUCTtbl"
        cmd.Connection = con
        cmd.CommandText = sql
        da.SelectCommand = cmd

        'puts everything into the datatable
        da.Fill(dt)
        'sets the datasource of the datagridview to the table
        dgvProduct.DataSource = dt

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'closes the form
        Me.Close()
    End Sub
End Class