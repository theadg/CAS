'THIS FORM WAS CODED BY: RACKHOLD, RENZ
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class formStoreAccount
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Documents\CASdb.accdb")
    'Dim con As New OleDb.OleDbConnection(My.Settings.CASdbConnectionString)
    'declarations for image
    Dim result As Integer
    Dim imgpath As String
    Dim arrImage() As Byte
    Dim sql As String
    'Dim con As New OleDb.OleDbConnection(My.Settings.CASdbConnectionString)
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try

            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand

            con.Open()
            'updates the userStore table with the corresponding fields and values and storeID
            sql = "UPDATE USERstore SET storeName=@storeName, storeAddress=@storeAddress,storeContactNo=@storeContactNo,storePassword=@storePassword,
                    storeLogo=@storeLogo WHERE storeID=" & Val(txtID.Text)
            cmd.Parameters.AddWithValue("@storeName", CType(txtUsername.Text, String))
            cmd.Parameters.AddWithValue("@storeAddress", CType(txtLocation.Text, String))
            cmd.Parameters.AddWithValue("@storeContactNo", CType(txtContact.Text, String))
            cmd.Parameters.AddWithValue("@storePassword", CType(txtPassword.Text, String))
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

        'calls the sub to update the picture of the Store
        updateStorePic()
    End Sub
    'updates the picture of the store
    Sub updateStorePic()
        Try
            Dim mstream As New System.IO.MemoryStream()

            'code for saving the picture into the database
            If pbStudPic.Image Is Nothing Then
                pbStudPic.Image = pbStudPic.ErrorImage
            End If
            pbStudPic.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrImage = mstream.GetBuffer()
            Dim FileSize As UInt32
            FileSize = mstream.Length
            mstream.Close()


            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand

            con.Open()

            'updates the record in the store table with the corresponding storePhoto and StoreID
            sql = "UPDATE STOREtbl SET storeLogo=@storePhoto
                    WHERE storeID=" & Val(txtID.Text)
            cmd.Parameters.AddWithValue("@storePhoto", arrImage)
            cmd.Connection = con
            cmd.CommandText = sql

            Dim i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MsgBox("Record has been UPDATED successfully!")

            Else
                MsgBox("No record has been UPDATED!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub formStoreAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'get store details and load the picture of the store with the corresponding store id ON LOAD
        getDetails()
        loadPic()
    End Sub
    Dim storeName, storeLocation, storeContact, storePassword As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'closes the database
        Me.Close()
    End Sub

    Private Sub btnAddImage_Click(sender As Object, e As EventArgs) Handles btnAddImage.Click
        'opens the openfile dialog control 
        Try

            Dim OFD As FileDialog = New OpenFileDialog()

            OFD.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif"

            If OFD.ShowDialog() = DialogResult.OK Then
                imgpath = OFD.FileName
                pbStudPic.ImageLocation = imgpath

            End If

            OFD = Nothing

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
    'get store details
    Sub getDetails()
        Try


            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            con.Open()
            'selects everything from the userstore table with the correpsonding store id
            sql = "Select * from USERstore WHERE storeID=" & Val(txtID.Text)
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)
            'get data from the data table
            storeName = dt.Rows(0)(1)
            storeLocation = dt.Rows(0)(2)
            storeContact = dt.Rows(0)(3)
            storePassword = dt.Rows(0)(4)
            'put data into corresponding controls
            txtUsername.Text = storeName
            txtLocation.Text = storeLocation
            txtContact.Text = storeContact
            txtPassword.Text = storePassword

        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
        con.Close()

    End Sub
    'get store logo
    Sub loadPic()
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            con.Open()
            'selects the store logo from store tbl with the corresponding store id
            sql = "Select storeLogo from STOREtbl WHERE storeID=" & Val(txtID.Text)
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)

            'put the corresponding image into the picturebox
            Dim bytes As Byte() = dt.Rows(0)(0)
            Dim mstream As New System.IO.MemoryStream(bytes)
            pbStudPic.Image = Image.FromStream(mstream)


        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub
End Class