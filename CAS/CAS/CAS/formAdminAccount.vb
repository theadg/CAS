'THIS FORM WAS CODED BY: SILVA, MATTHEW
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class formAdminAccount
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Documents\CASdb.accdb")
    'Dim con As New OleDb.OleDbConnection(My.Settings.CASdbConnectionString)

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'updates the account of the Admin
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand

            con.Open()

            sql = "UPDATE USERadmin SET adminUsername=@adminUsername, adminPassword=@adminPassword
                    WHERE adminID=" & Val(txtID.Text)
            cmd.Parameters.AddWithValue("@adminUsername", CType(txtUsername.Text, String))
            cmd.Parameters.AddWithValue("@adminPassword", CType(txtPassword.Text, String))

            cmd.Connection = con
            cmd.CommandText = sql

            Dim i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MsgBox("Admin account has been SUCCESSFULLY updated ")

            Else
                MsgBox("No record has been UPDATED!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub


    Private Sub formAdminAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'gets the account information from the database and puts it into the respective textboxes ON LOAD
        getDetails()
    End Sub
    Dim adminUsername, adminPassword As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    'gets the account information from the database and puts it into the respective textboxes
    Sub getDetails()
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            con.Open()
            sql = "Select * from USERadmin WHERE adminID=" & Val(txtID.Text)
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)
            adminUsername = dt.Rows(0)(1)
            adminPassword = dt.Rows(0)(2)

            txtUsername.Text = adminUsername
            txtPassword.Text = adminPassword

        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub
End Class