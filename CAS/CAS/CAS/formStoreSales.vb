'THIS FORM WAS CODED BY: DE GUZMAN, ANDREW
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class formStoreSales
    Dim totalSales As Integer
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Documents\CASdb.accdb")
    'Dim con As New OleDb.OleDbConnection(My.Settings.CASdbConnectionString)
    Private Sub formStoreSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load info about store into datagrid
        loadStoreData()
    End Sub
    'get store sales 
    Sub getStoreSales()
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            con.Open()
            'select prodtotalprice field from ordercomplete with corresponding store id
            sql = "Select prodTotalPrice from ORDERcomplete WHERE storeID=" & Val(lblStoreID.Text)
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)

            'go through all the rows
            For Each Row As DataRow In dt.Rows
                'add each productTotalPrice to totalSales
                totalSales += Row(0)
            Next
            'update totalsales textbox
            txtSalesTotal.Text = totalSales
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
        con.Close()

    End Sub
    'load info of store with corresponding id
    Sub loadStoreData()
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            con.Open()
            'select everything from ordercomplete table with corresponding store id
            sql = "Select * from ORDERcomplete WHERE storeID=" & Val(lblStoreID.Text)
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        totalSales = 0
        'get store sales
        getStoreSales()
        'get info of store
        getStoreSalesTable()

        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            con.Open()
            'update storeSales from storetbl with corresponding storeID
            sql = "UPDATE STOREtbl set storeSales=@storeSales WHERE storeID=" & Val(lblStoreID.Text)
            cmd.Parameters.Add(New OleDbParameter("@storeSales", CType(txtSalesTotal.Text, Integer)))
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)


        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        con.Close()

        loadStoreData()
    End Sub
    'get info of store
    Sub getStoreSalesTable()
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            con.Open()
            'select everything from storetable with corresponding store id
            sql = "Select * from STOREtbl WHERE storeID=" & Val(lblStoreID.Text)
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)

            DataGridView2.DataSource = dt
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try

        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class