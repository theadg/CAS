Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class formStoreAccount
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Documents\CASdb.accdb")
    Dim result As Integer
    Dim imgpath As String
    Dim arrImage() As Byte
    Dim sql As String
    'Dim con As New OleDb.OleDbConnection(My.Settings.CASdbConnectionString)
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            'pic code


            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand

            con.Open()

            sql = "UPDATE USERstore SET storeName=@storeName, storeAddress=@storeAddress,storeContactNo=@storeContactNo,storePassword=@storePassword
                    WHERE storeID=" & Val(txtID.Text)
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

        updateStorePic()
    End Sub
    Sub updateStorePic()
        Try

            'pic code
            Dim mstream As New System.IO.MemoryStream()

            If pbStudPic.Image Is Nothing Then
                pbStudPic.Image = pbStudPic.ErrorImage
            End If
            pbStudPic.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrImage = mstream.GetBuffer()
            Dim FileSize As UInt32
            FileSize = mstream.Length
            mstream.Close()
            'end of pic code

            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand

            con.Open()

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
        getDetails()
        loadPic()
    End Sub
    Dim storeName, storeLocation, storeContact, storePassword As String

    Private Sub btnAddImage_Click(sender As Object, e As EventArgs) Handles btnAddImage.Click
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

    Sub getDetails()
        Try


            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            con.Open()
            sql = "Select * from USERstore WHERE storeID=" & Val(txtID.Text)
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)
            storeName = dt.Rows(0)(1)
            storeLocation = dt.Rows(0)(2)
            storeContact = dt.Rows(0)(3)
            storePassword = dt.Rows(0)(4)

            txtUsername.Text = storeName
            txtLocation.Text = storeLocation
            txtContact.Text = storeContact
            txtPassword.Text = storePassword

        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
        con.Close()

    End Sub

    Sub loadPic()
        Try


            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            con.Open()
            sql = "Select storeLogo from STOREtbl WHERE storeID=" & Val(txtID.Text)
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)


            Dim bytes As Byte() = dt.Rows(0)(0)
            Dim mstream As New System.IO.MemoryStream(bytes)
            pbStudPic.Image = Image.FromStream(mstream)



        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub
End Class