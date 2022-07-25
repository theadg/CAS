Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class formAdminMStore
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Documents\CASdb.accdb")
    Dim da As New OleDb.OleDbDataAdapter
    Dim result As Integer
    Dim imgpath As String
    Dim arrImage() As Byte
    Dim sql As String
    'Dim con As New OleDb.OleDbConnection(My.Settings.CASdbConnectionString)
    Private Sub formAdminMStore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshTable()
    End Sub
    'Add record to table
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Try
            'pic code
            Dim mstream As New System.IO.MemoryStream()

            pbStorePic.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrImage = mstream.GetBuffer()
            Dim FileSize As UInt32
            FileSize = mstream.Length
            mstream.Close()
            'end of pic code

            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand


            con.Open()
            sql = "INSERT INTO STOREtbl([storeName],[storeLocation],[storeContact],[storeSales],[storeLogo]) 
                    VALUES (@storeName,@storeLocation,@storeContact, @storeSales, @storeLogo)"
            cmd.Parameters.AddWithValue("@storeName", CType(txtStoreName.Text, String))
            cmd.Parameters.AddWithValue("@storeLocation", CType(txtStoreLocation.Text, String))
            cmd.Parameters.AddWithValue("@storeContact", CType(txtStoreContact.Text, String))
            cmd.Parameters.AddWithValue("@storeSales", CType(txtStoreSales.Text, Decimal))
            cmd.Parameters.AddWithValue("@storeLogo", arrImage)

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
    Public Sub refreshTable()
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            con.Open()
            sql = "Select storeLogo,storeID, storeName, storeLocation, storeContact, storeSales from STOREtbl"
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)
            dgvStore.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        refreshTable()
    End Sub

    Private Sub dgvStore_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStore.CellClick
        Dim storeID As Integer = dgvStore.CurrentRow.Cells(1).Value
        txtStoreID.Text = storeID
        txtStoreName.Text = dgvStore.CurrentRow.Cells(2).Value
        txtStoreLocation.Text = dgvStore.CurrentRow.Cells(3).Value
        txtStoreContact.Text = dgvStore.CurrentRow.Cells(4).Value
        txtStoreSales.Text = dgvStore.CurrentRow.Cells(5).Value



        'magical line of code right here for getting image from db

        Dim picVar = dgvStore.CurrentRow.Cells(0).Value
        If (picVar) IsNot DBNull.Value Then
            Dim bytes As Byte() = dgvStore.CurrentRow.Cells(0).Value
            Dim mstream As New System.IO.MemoryStream(bytes)
            pbStorePic.Image = Image.FromStream(mstream)
        Else
            pbStorePic.Image = pbStorePic.ErrorImage
        End If



    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            'pic code
            Dim mstream As New System.IO.MemoryStream()

            pbStorePic.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrImage = mstream.GetBuffer()
            Dim FileSize As UInt32
            FileSize = mstream.Length
            mstream.Close()
            'end of pic code

            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand

            con.Open()

            sql = "UPDATE STOREtbl SET storeName =@storeName, storeLocation=@storeLocation, storeContact = @storeContact, storeSales=@storeSales, storeLogo = @storeLogo WHERE 
                    storeID=" & Val(txtStoreID.Text)
            cmd.Parameters.Add(New OleDbParameter("storeName", CType(txtStoreName.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("storeLocation", CType(txtStoreLocation.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("storeContact", CType(txtStoreContact.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("storeSales", CType(txtStoreSales.Text, Decimal)))
            cmd.Parameters.AddWithValue("@studimg", arrImage)
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
            sql = "DELETE * from STOREtbl WHERE storeID=" & Val(txtStoreID.Text) & ""
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
    'PICTURE SHIT
    Private Sub btnAddImage_Click(sender As Object, e As EventArgs) Handles btnAddImage.Click
        Try

            Dim OFD As FileDialog = New OpenFileDialog()

            OFD.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif"

            If OFD.ShowDialog() = DialogResult.OK Then
                imgpath = OFD.FileName
                pbStorePic.ImageLocation = imgpath

            End If

            OFD = Nothing

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub btnSaveImage_Click(sender As Object, e As EventArgs)
        Try
            'pic code


            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand


            con.Open()
            sql = "INSERT INTO STOREtbl([storeName],[storeLocation],[storeContact],[storeSales],[storeLogo]) 
                    VALUES (@storeName,@storeLocation,@storeContact, @storeSales, @storeLogo)"
            cmd.Parameters.AddWithValue("@storeName", CType(txtStoreName.Text, String))
            cmd.Parameters.AddWithValue("@storeLocation", CType(txtStoreLocation.Text, String))
            cmd.Parameters.AddWithValue("@storeContact", CType(txtStoreContact.Text, String))
            cmd.Parameters.AddWithValue("@storeSales", CType(txtStoreSales.Text, Decimal))

            cmd.Parameters.AddWithValue("@storeLogo", arrImage)



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


End Class