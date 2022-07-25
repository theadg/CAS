Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class formAdminMProduct
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Documents\CASdb.accdb")
    Dim da As New OleDb.OleDbDataAdapter
    Dim result As Integer
    Dim imgpath As String
    Dim arrImage() As Byte
    Dim sql As String

    Sub refreshTable()
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            con.Open()
            sql = "Select * from PRODUCTtbl WHERE storeID=" & Val(txtStoreID.Text)
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)
            dgvProduct.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        refreshTable()
    End Sub
    Private Sub dgvStore_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProduct.CellClick
        Dim productID As Integer = dgvProduct.CurrentRow.Cells(1).Value
        txtProductID.Text = productID

        txtStoreIDreal.Text = dgvProduct.CurrentRow.Cells(0).Value
        txtProductName.Text = dgvProduct.CurrentRow.Cells(2).Value
        txtProductDescription.Text = dgvProduct.CurrentRow.Cells(3).Value
        txtProductQty.Text = dgvProduct.CurrentRow.Cells(4).Value
        txtProductPrice.Text = dgvProduct.CurrentRow.Cells(5).Value '3



        'magical line of code right here for getting image from db

        Dim picVar = dgvProduct.CurrentRow.Cells(6).Value
        If (picVar) IsNot DBNull.Value Then
            Dim bytes As Byte() = dgvProduct.CurrentRow.Cells(6).Value
            Dim mstream As New System.IO.MemoryStream(bytes)
            pbProductPic.Image = Image.FromStream(mstream)
        Else
            pbProductPic.Image = pbProductPic.ErrorImage
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            'pic code
            Dim mstream As New System.IO.MemoryStream()

            If pbProductPic.Image Is Nothing Then
                pbProductPic.Image = pbProductPic.ErrorImage
            End If
            pbProductPic.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrImage = mstream.GetBuffer()
            Dim FileSize As UInt32
            FileSize = mstream.Length
            mstream.Close()
            'end of pic code

            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand

            con.Open()


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
            If i > 0 Then
                MsgBox("Record has been UPDATED successfully!")

            Else
                MsgBox("No record has been UPDATED!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        refreshTable()
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Try
            'pic code
            Dim mstream As New System.IO.MemoryStream()

            If pbProductPic.Image Is Nothing Then
                pbProductPic.Image = pbProductPic.ErrorImage
            End If

            pbProductPic.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrImage = mstream.GetBuffer()
            Dim FileSize As UInt32
            FileSize = mstream.Length
            mstream.Close()
            'end of pic code

            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand


            con.Open()
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
            If i > 0 Then
                MsgBox("Record has been UPDATED successfully!")
            Else
                MsgBox("No record has been UPDATED!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            con.Close()

        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand

            con.Open()
            sql = "DELETE * from PRODUCTtbl WHERE productID=" & Val(txtProductID.Text) & ""
            cmd.Connection = con
            cmd.CommandText = sql

            Dim i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MsgBox("Record has been DELETED successfully!")
            Else
                MsgBox("No record has been DELETED")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            con.Close()

        End Try
    End Sub

    Private Sub btnAddImage_Click(sender As Object, e As EventArgs) Handles btnAddImage.Click
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

    End Sub
End Class