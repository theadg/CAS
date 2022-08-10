''THIS FORM WAS CODED BY: SILVA, MATTHEW AND BAGASON, ALBERT
Imports System.Data
Imports System.Data.OleDb
Imports System.IO

Public Class formStudentOrderHistory
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Documents\CASdb.accdb")
    'Dim con As New OleDb.OleDbConnection(My.Settings.CASdbConnectionString)
    Private Sub formStudentOrderHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load active orders
        loadActiveOrders()
        'load complete orders
        loadCompletedOrders()
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'Whenever a cell in the datagrid is clicked, the data of the record will be placed into corresponding controls
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


        'magical line of code right here for getting image from db

        Dim picVar = DataGridView1.CurrentRow.Cells(11).Value
        If (picVar) IsNot DBNull.Value Then
            Dim bytes As Byte() = DataGridView1.CurrentRow.Cells(11).Value
            Dim mstream As New System.IO.MemoryStream(bytes)
            pbProd.Image = Image.FromStream(mstream)
        Else
            pbProd.Image = pbProd.ErrorImage
        End If
    End Sub
    'get active orders table
    Sub loadActiveOrders()
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            Dim userType As String = "Student"
            con.Open()
            'select everything from orderactive table with corresponding userid and usertype
            sql = "Select * from ORDERactive WHERE userID=" & Val(lblUserID.Text) & "AND userType ='" & userType & "'"
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub
    'get complete orders table
    Sub loadCompletedOrders()
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            Dim userType As String = "Student"
            con.Open()
            'select everything from ordercomplete table with corresponding userid and usertype
            sql = "Select * from ORDERcomplete WHERE userID=" & Val(lblUserID.Text) & "AND userType ='" & userType & "'"
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)
            DataGridView2.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub
    Private Sub formAdminOrderHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'get active orders
        loadActiveOrders()
        'get complete orders
        loadCompletedOrders()
    End Sub

    Private Sub lblQty_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        'Whenever a cell in the datagrid is clicked, the data of the record will be placed into corresponding controls
        Dim orderID As Integer = DataGridView2.CurrentRow.Cells(0).Value
        txtOrderID.Text = orderID

        txtStoreID.Text = DataGridView2.CurrentRow.Cells(1).Value
        txtProdID.Text = DataGridView2.CurrentRow.Cells(2).Value
        DateTimePicker1.Value = DataGridView2.CurrentRow.Cells(3).Value
        txtStoreName.Text = DataGridView2.CurrentRow.Cells(4).Value
        txtProdName.Text = DataGridView2.CurrentRow.Cells(5).Value '3
        txtProdPrice.Text = DataGridView2.CurrentRow.Cells(6).Value
        txtProdPriceTotal.Text = DataGridView2.CurrentRow.Cells(7).Value
        txtProdQty.Text = DataGridView2.CurrentRow.Cells(8).Value


        'magical line of code right here for getting image from db

        Dim picVar = DataGridView2.CurrentRow.Cells(11).Value
        If (picVar) IsNot DBNull.Value Then
            Dim bytes As Byte() = DataGridView2.CurrentRow.Cells(11).Value
            Dim mstream As New System.IO.MemoryStream(bytes)
            pbProd.Image = Image.FromStream(mstream)
        Else
            pbProd.Image = pbProd.ErrorImage
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'close table
        Me.Close()
    End Sub
End Class