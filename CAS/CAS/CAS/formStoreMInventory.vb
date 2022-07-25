Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class formStoreMInventory
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Documents\CASdb.accdb")
    Dim da As New OleDb.OleDbDataAdapter
    Dim result As Integer
    Dim imgpath As String
    Dim arrImage() As Byte
    Dim sql As String
    Private Sub formStoreMInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadProducts()
    End Sub
    Sub loadProducts()

        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            con.Open()
            sql = "Select * from PRODUCTtbl WHERE storeID=" & Val(lblStoreID.Text)
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub
    Private Sub btnComplete_Click(sender As Object, e As EventArgs) Handles btnComplete.Click
        Try
            'pic code
            Dim mstream As New System.IO.MemoryStream()

            If pbProd.Image Is Nothing Then
                pbProd.Image = pbProd.ErrorImage
            End If
            pbProd.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrImage = mstream.GetBuffer()
            Dim FileSize As UInt32
            FileSize = mstream.Length
            mstream.Close()
            'end of pic code

            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand

            con.Open()


            sql = "UPDATE PRODUCTtbl SET productName=@productName, productDesc=@productDesc, productQty=@productQty,
                    productPrice=@productPrice,productPhoto=@productPhoto WHERE productID=" & Val(txtProdID.Text)
            'cmd.Parameters.AddWithValue("@storeID", CType(txtStoreIDreal.Text, Integer))
            cmd.Parameters.AddWithValue("@productName", CType(txtProdName.Text, String))
            cmd.Parameters.AddWithValue("@productDesc", CType(txtProdDesc.Text, String))
            cmd.Parameters.AddWithValue("@productQty", CType(txtProdQty.Text, Integer))
            cmd.Parameters.AddWithValue("@productPrice", CType(txtProdPrice.Text, Integer))
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

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim storeID As Integer = DataGridView1.CurrentRow.Cells(0).Value
        ' txtOrderID.Text = orderID


        txtProdID.Text = DataGridView1.CurrentRow.Cells(1).Value
        txtProdName.Text = DataGridView1.CurrentRow.Cells(2).Value '3
        txtProdDesc.Text = DataGridView1.CurrentRow.Cells(3).Value
        txtProdQty.Text = DataGridView1.CurrentRow.Cells(4).Value
        txtProdPrice.Text = DataGridView1.CurrentRow.Cells(5).Value


        'magical line of code right here for getting image from db

        Dim picVar = DataGridView1.CurrentRow.Cells(6).Value
        If (picVar) IsNot DBNull.Value Then
            Dim bytes As Byte() = DataGridView1.CurrentRow.Cells(6).Value
            Dim mstream As New System.IO.MemoryStream(bytes)
            pbProd.Image = Image.FromStream(mstream)
        Else
            pbProd.Image = pbProd.ErrorImage
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Dim OFD As FileDialog = New OpenFileDialog()

            OFD.Filter = "Image File (*.jpg;*.jpeg;*.bmp;*.gif)|*.jpg;*.jpeg;*.bmp;*.gif"

            If OFD.ShowDialog() = DialogResult.OK Then
                imgpath = OFD.FileName
                pbProd.ImageLocation = imgpath

            End If

            OFD = Nothing

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Try
            'pic code
            Dim mstream As New System.IO.MemoryStream()

            If pbProd.Image Is Nothing Then
                pbProd.Image = pbProd.ErrorImage
            End If

            pbProd.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrImage = mstream.GetBuffer()
            Dim FileSize As UInt32
            FileSize = mstream.Length
            mstream.Close()
            'end of pic code

            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand


            con.Open()
            sql = "INSERT INTO PRODUCTtbl([productName],[productDesc],[productQty],[productPrice],[productPhoto]) 
                    VALUES (@productName,@productDesc, @productQty, @productPrice, @productPhoto)"
            'cmd.Parameters.AddWithValue("@storeID", CType(txtStoreIDreal.Text, Integer))
            cmd.Parameters.AddWithValue("@productName", CType(txtProdName.Text, String))
            cmd.Parameters.AddWithValue("@productDesc", CType(txtProdDesc.Text, String))
            cmd.Parameters.AddWithValue("@productQty", CType(txtProdQty.Text, Integer))
            cmd.Parameters.AddWithValue("@productPrice", CType(txtProdPrice.Text, Integer))
            cmd.Parameters.AddWithValue("@productPhoto", arrImage)

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
        loadProducts()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand

            con.Open()
            sql = "DELETE * from PRODUCTtbl WHERE productID=" & Val(txtProdID.Text) & ""
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
End Class