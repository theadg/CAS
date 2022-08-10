'THIS FORM WAS CODED BY: DE GUZMAN, ANDREW
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class formNotify
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Documents\CASdb.accdb")
    'Dim con As New OleDb.OleDbConnection(My.Settings.CASdbConnectionString)
    Private Sub formNotify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'loads the table into the datagrid
        loadTable()
        'sets the column width of the datagrid as autio
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
    End Sub
    Sub loadTable()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter

        'select everything from the ordernotif with the corresponding usertype and userid
        sql = "SELECT * FROM ORDERnotif WHERE userType='" & (lblUserType.Text) & "' " & "AND userID=" & Val(lbluserID.Text)
        cmd.Connection = con
        cmd.CommandText = sql

        da.SelectCommand = cmd
        da.Fill(dt)

        DataGridView1.DataSource = dt
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' 'Whenever a cell in the datagrid is clicked, the data of the record will be placed into corresponding controls
        Dim orderID As Integer = DataGridView1.CurrentRow.Cells(0).Value
        txtOrderID.Text = orderID

        txtStoreID.Text = DataGridView1.CurrentRow.Cells(1).Value
        txtProdID.Text = DataGridView1.CurrentRow.Cells(2).Value
        DateTimePicker1.Value = DataGridView1.CurrentRow.Cells(3).Value
        txtStoreName.Text = DataGridView1.CurrentRow.Cells(4).Value
        txtProdName.Text = DataGridView1.CurrentRow.Cells(5).Value '3
        txtProdPrice.Text = DataGridView1.CurrentRow.Cells(6).Value
        txtProdPriceTotal.Text = DataGridView1.CurrentRow.Cells(7).Value
        txtProdQty.Text = DataGridView1.CurrentRow.Cells(8).Value


        'get the image from the database
        Dim picVar = DataGridView1.CurrentRow.Cells(11).Value
        If (picVar) IsNot DBNull.Value Then
            Dim bytes As Byte() = DataGridView1.CurrentRow.Cells(11).Value
            Dim mstream As New System.IO.MemoryStream(bytes)
            pbProd.Image = Image.FromStream(mstream)
        Else
            pbProd.Image = pbProd.ErrorImage
        End If
    End Sub

    Private Sub btnComplete_Click(sender As Object, e As EventArgs) Handles btnComplete.Click
        'calls the sub to remove all the orders from the order notif table
        removeOrders()
        If lblUserType.Text = "Admin" Then
            'removes the notifcation prompt for admin
            removeNotifAdmin()
        ElseIf lblUserType.Text = "Student" Then
            'removes the notifcation prompt for student
            removeNotifStud()
        End If

        Me.Close()
    End Sub
    'removes all the orders from order notif with the corresponding usertype and userid
    Sub removeOrders()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter

        'removes all the orders from order notif with the corresponding usertype and userid
        sql = "DELETE * FROM ORDERnotif WHERE userType='" & (lblUserType.Text) & "' " & "AND userID=" & Val(lbluserID.Text)
        cmd.Connection = con
        cmd.CommandText = sql

        da.SelectCommand = cmd
        da.Fill(dt)

        DataGridView1.DataSource = dt
    End Sub
    'removes notifcation prompt for admin
    Sub removeNotifAdmin()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter
        Dim updateNum As Integer = 0

        'updates the adminorde field to 0 to remove notifcation prompt with the corresponding admin id
        sql = "UPDATE USERadmin SET adminOrder=@adminOrder WHERE adminID=" & Val(lbluserID.Text)
        cmd.Parameters.Add(New OleDbParameter("@adminOrder", CType(updateNum, Integer)))
        cmd.Connection = con
        cmd.CommandText = sql
        da.SelectCommand = cmd

        Dim i = cmd.ExecuteNonQuery()
        If i > 0 Then
            MsgBox("Orders are SUCCESSFULLY removed")
        Else
            MsgBox("No order/s have been removed")
        End If
    End Sub
    'removes notifacation prompt for student
    Sub removeNotifStud()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter
        Dim updateNum As Integer = 0
        'updates the studentorde rfield to 0 to remove notifcation prompt with the corresponding student
        sql = "UPDATE USERstudent SET studOrder=@studOrder WHERE studID=" & Val(lbluserID.Text)
        cmd.Parameters.Add(New OleDbParameter("@studOrder", CType(updateNum, Integer)))
        cmd.Connection = con
        cmd.CommandText = sql
        da.SelectCommand = cmd

        Dim i = cmd.ExecuteNonQuery()
        If i > 0 Then
            MsgBox("Orders are SUCCESSFULLY removed")
        Else
            MsgBox("No order/s have been removed")
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'closes the form
        Me.Close()
    End Sub
End Class