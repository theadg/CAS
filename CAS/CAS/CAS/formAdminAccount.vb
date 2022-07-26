Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class formAdminAccount
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Documents\CASdb.accdb")
    'Dim con As New OleDb.OleDbConnection(My.Settings.CASdbConnectionString)

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            'pic code


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

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub formAdminAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class