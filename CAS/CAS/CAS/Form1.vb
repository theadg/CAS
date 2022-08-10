'THIS FORM WAS CODED BY: DE GUZMAN, ANDREW
Imports System.Data
Imports System.Data.OleDb
Public Class formLogIn
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Documents\CASdb.accdb")
    'Dim con As New OleDb.OleDbConnection(My.Settings.CASdbConnectionString)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Dim varAdminUN, varAdminPW, varStoreUN, varStorePW As String 'asdasd
    Dim varAdminID, varStoreID, varStudID As Integer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Gets User ID dependent upon the type of User from respective table
        If cbUser.SelectedItem = "Student" Then
            getStudentID()
        ElseIf cbUser.SelectedItem = "Admin" Then
            getAdminID()
        ElseIf cbUser.SelectedItem = "Store" Then
            getStoreID()
        End If

        'opens the connection to the database if it is closed
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
                    Dim formStudentMain = New formStudentMain(varStudID)
                    Me.Hide()
                    formStudentMain.Show()
                Else

                    MsgBox("Account not found check credentials", MsgBoxStyle.Exclamation)

                End If
            End If

            'Checking user type
        ElseIf cbUser.SelectedItem = "Admin" Then

            'Checking complete input
            If txtUsername.Text = String.Empty Or txtPassword.Text = String.Empty Then
                MsgBox("Complete necessary Fields", MsgBoxStyle.Exclamation)
            Else
                'Checks if the user is inside the db


                Dim cmd As New OleDbCommand("select count(*) from USERadmin where adminUsername=? and adminPassword=? ", con)
                cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = txtUsername.Text
                cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = txtPassword.Text
                Dim count = Convert.ToInt32(cmd.ExecuteScalar())

                varAdminUN = txtUsername.Text
                varAdminPW = txtPassword.Text


                If (count > 0) Then
                    getAdminID()
                    MsgBox("Login succeed", MsgBoxStyle.Information)
                    Dim formAdmin = New formAdmin(varAdminID, varAdminUN, varAdminPW)
                    Me.Hide()
                    formAdmin.Show()
                Else
                    MsgBox("Account not found check credentials", MsgBoxStyle.Exclamation)
                End If
            End If

            'Checking user type
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
                    Dim formAdmin = New formStore(varStoreID)
                    Me.Hide()
                    formAdmin.Show()
                Else
                    MsgBox("Account not found check credentials", MsgBoxStyle.Exclamation)
                End If
            End If
        Else
            MsgBox("Please Select User Type")
        End If

        'clears the combobox and txtboxes after logging in
        cbUser.Text = String.Empty
        txtUsername.Text = String.Empty
        txtPassword.Text = String.Empty
    End Sub
    'gets the adminID of admin
    Sub getAdminID()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter


        sql = "SELECT adminID,adminUsername, adminPassword FROM USERadmin WHERE adminUsername ='" & txtUsername.Text & "' AND adminPassword='" & txtPassword.Text & "' "
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)


        If dt.Rows.Count > 0 Then
            'puts the adminID in a variable
            varAdminID = dt.Rows(0)(0)
        Else
            varAdminID = 0
        End If




    End Sub
    'gets the storeID of store
    Sub getStoreID()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter


        sql = "SELECT storeID FROM USERstore where storeName='" & txtUsername.Text & "' "
        cmd.Connection = con
        cmd.CommandText = sql
        da.SelectCommand = cmd

        da.Fill(dt)


        If dt.Rows.Count > 0 Then
            'puts the storeID in a variable
            varStoreID = dt.Rows(0)(0)
        Else
            varStoreID = 0
        End If
    End Sub
    'gets the studentID of Student 
    Sub getStudentID()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter


        sql = "SELECT studID FROM USERstudent WHERE studName='" & txtUsername.Text & "' AND studPassword='" & txtPassword.Text & "' "
        cmd.Connection = con
        cmd.CommandText = sql
        da.SelectCommand = cmd

        da.Fill(dt)
        'gets the 
        If dt.Rows.Count > 0 Then
            'puts the studentID in a variable
            varStudID = dt.Rows(0)(0)
        Else
            varStudID = 0
        End If




    End Sub
End Class
