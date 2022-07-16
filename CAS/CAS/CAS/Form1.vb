Imports System.Data
Imports System.Data.OleDb
Public Class Form1
    'Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Documents\CASdb.accdb")
    Dim con As New OleDb.OleDbConnection(My.Settings.CASdbConnectionString)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub txtUsername_Click(sender As Object, e As EventArgs) Handles txtUsername.Click
        txtUsername.Text = ""
    End Sub

    Private Sub txtPassword_Click(sender As Object, e As EventArgs) Handles txtPassword.Click
        txtPassword.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If


        'Checking user type
        If cbUser.SelectedItem = "Student" Then
            'Checking complete input
            If txtUsername.Text = String.Empty Or txtPassword.Text = String.Empty Then
                MsgBox("Complete necessary Fields", MsgBoxStyle.Exclamation)
            Else
                'Checks if the user is inside the db
                Dim cmd As New OleDbCommand("select count(*) from USERstudent where studName=? and studPassword=?", con)
                cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = txtUsername.Text
                cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = txtPassword.Text
                Dim count = Convert.ToInt32(cmd.ExecuteScalar())


                If (count > 0) Then
                    MsgBox("Login succeed", MsgBoxStyle.Information)
                Else

                    MsgBox("Account not found check credentials", MsgBoxStyle.Exclamation)

                End If
            End If

        ElseIf cbUser.SelectedItem = "Admin" Then
            'Checking complete input
            If txtUsername.Text = String.Empty Or txtPassword.Text = String.Empty Then
                MsgBox("Complete necessary Fields", MsgBoxStyle.Exclamation)
            Else
                'Checks if the user is inside the db
                Dim cmd As New OleDbCommand("select count(*) from USERadmin where adminUsername=? and adminPassword=?", con)
                cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = txtUsername.Text
                cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = txtPassword.Text
                Dim count = Convert.ToInt32(cmd.ExecuteScalar())


                If (count > 0) Then
                    MsgBox("Login succeed", MsgBoxStyle.Information)
                Else
                    MsgBox("Account not found check credentials", MsgBoxStyle.Exclamation)
                End If
            End If

        ElseIf cbUser.SelectedItem = "Store" Then
            'Checking complete input
            If txtUsername.Text = String.Empty Or txtPassword.Text = String.Empty Then
                MsgBox("Complete necessary Fields", MsgBoxStyle.Exclamation)
            Else
                'Checks if the user is inside the db
                Dim cmd As New OleDbCommand("select count(*) from USERstore where storeName=? and storePassword=?", con)
                cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = txtUsername.Text
                cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = txtPassword.Text
                Dim count = Convert.ToInt32(cmd.ExecuteScalar())


                If (count > 0) Then
                    MsgBox("Login succeed", MsgBoxStyle.Information)
                Else
                    MsgBox("Account not found check credentials", MsgBoxStyle.Exclamation)
                End If
            End If
        Else
            MsgBox("Please Select User Type")
        End If

    End Sub
End Class
