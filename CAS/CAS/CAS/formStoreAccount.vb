Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class formStoreAccount
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Documents\CASdb.accdb")
    'Dim con As New OleDb.OleDbConnection(My.Settings.CASdbConnectionString)
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            'pic code


            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand

            con.Open()

            sql = "UPDATE USERstore SET storeName=@storeName, storeAddress=@storeAddress,storeContactNo=@storeContactNo,storePassword=@storePassword
                    WHERE adminID=" & Val(txtID.Text)
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
    End Sub

    Private Sub formStoreAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getDetails()
    End Sub
    Dim storeName, storeLocation, storeContact, storePassword As String
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
End Class