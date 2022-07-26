Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class formStoreSales
    Dim totalSales As Integer
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Documents\CASdb.accdb")
    'Dim con As New OleDb.OleDbConnection(My.Settings.CASdbConnectionString)
    Private Sub formStoreSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadStoreData()
    End Sub
    Sub getStoreSales()
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            con.Open()
            sql = "Select prodTotalPrice from ORDERcomplete WHERE storeID=" & Val(lblStoreID.Text)
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)

            For Each Row As DataRow In dt.Rows
                totalSales += Row(0)
            Next
            txtSalesTotal.Text = totalSales
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
        con.Close()

    End Sub

    Sub loadStoreData()
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            con.Open()
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
        getStoreSales()
        getStoreSalesTable()

        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            con.Open()
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

    Sub getStoreSalesTable()
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            con.Open()
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
End Class