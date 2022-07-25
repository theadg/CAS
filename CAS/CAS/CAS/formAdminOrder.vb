﻿Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class formAdminOrder
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Documents\CASdb.accdb")
    Dim admID As Integer
    Public Sub New(adminID As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        admID = adminID

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub formAdminOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getProductDataInitial()
        getStoreInfo()
        getStoreID()
        getOrderTable()
        lblAdminID.Text = admID
    End Sub
    Dim adminID As Integer
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        getProductData()

        storeID = ComboBox1.Text
        storeName = lblStoreName.Text
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            Dim dt2 As New DataTable
            sql = "SELECT * FROM STOREtbl"
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt2)
        'DataGridView1.DataSource = dt2


        Dim store1, store2 As String
        store1 = dt2.Rows(0)(1)
        store2 = dt2.Rows(1)(1)

        If ComboBox1.SelectedIndex = 0 Then
            lblStoreName.Text = store1
            lblStoreLoc.Text = dt2.Rows(0)(2)
            lblStoreCon.Text = dt2.Rows(0)(3)
        ElseIf ComboBox1.SelectedIndex = 1 Then
            lblStoreName.Text = store2
            lblStoreLoc.Text = dt2.Rows(1)(2)
            lblStoreCon.Text = dt2.Rows(1)(3)
        End If
    End Sub
    Sub getOrderTable()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter
        sql = "SELECT * FROM ORDERactive"
        cmd.Connection = con
        cmd.CommandText = sql
        da.SelectCommand = cmd

        da.Fill(dt)
        DataGridView1.DataSource = dt






    End Sub
    Sub getProductData()
        'removed try para
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter
        'con.Open()

        'Dim testID As Integer = 2
        sql = "SELECT * FROM PRODUCTtbl WHERE storeID=" & Val(ComboBox1.Text)
        cmd.Connection = con
        cmd.CommandText = sql
        da.SelectCommand = cmd



        da.Fill(dt)
        'DataGridView1.DataSource = dt
        'varAdminID = dt.Rows(0)(0)
        '1
        lblID1.Text = dt.Rows(0)(1)
        lblName1.Text = dt.Rows(0)(2)
        lblDesc1.Text = dt.Rows(0)(3)
        lblPrice1.Text = dt.Rows(0)(5)
        Dim bytes As Byte() = dt.Rows(0)(6)
        Dim mstream As New System.IO.MemoryStream(bytes)
        pbProd1.Image = Image.FromStream(mstream)

        '2
        lblID2.Text = dt.Rows(1)(1)
        lblName2.Text = dt.Rows(1)(2)
        lblDesc2.Text = dt.Rows(1)(3)
        lblPrice2.Text = dt.Rows(1)(5)
        Dim bytes2 As Byte() = dt.Rows(1)(6)
        Dim mstream2 As New System.IO.MemoryStream(bytes2)
        pbProd2.Image = Image.FromStream(mstream2)

        '3
        lblID3.Text = dt.Rows(2)(1)
        lblName3.Text = dt.Rows(2)(2)
        lblDesc3.Text = dt.Rows(2)(3)
        lblPrice3.Text = dt.Rows(2)(5)
        Dim bytes3 As Byte() = dt.Rows(2)(6)
        Dim mstream3 As New System.IO.MemoryStream(bytes3)
        pbProd3.Image = Image.FromStream(mstream3)

        '4
        lblID4.Text = dt.Rows(3)(1)
        lblName4.Text = dt.Rows(3)(2)
        lblDesc4.Text = dt.Rows(3)(3)
        lblPrice4.Text = dt.Rows(3)(5)
        Dim bytes4 As Byte() = dt.Rows(3)(6)
        Dim mstream4 As New System.IO.MemoryStream(bytes4)
        pbProd4.Image = Image.FromStream(mstream4)

        '5
        lblID5.Text = dt.Rows(4)(1)
        lblName5.Text = dt.Rows(4)(2)
        lblDesc5.Text = dt.Rows(4)(3)
        lblPrice5.Text = dt.Rows(4)(5)
        Dim bytes5 As Byte() = dt.Rows(4)(6)
        Dim mstream5 As New System.IO.MemoryStream(bytes5)
        pbProd5.Image = Image.FromStream(mstream5)

        '6
        lblID6.Text = dt.Rows(5)(1)
        lblName6.Text = dt.Rows(5)(2)
        lblDesc6.Text = dt.Rows(5)(3)
        lblPrice6.Text = dt.Rows(5)(5)
        Dim bytes6 As Byte() = dt.Rows(5)(6)
        Dim mstream6 As New System.IO.MemoryStream(bytes6)
        pbProd6.Image = Image.FromStream(mstream6)

        '7
        lblID7.Text = dt.Rows(6)(1)
        lblName7.Text = dt.Rows(6)(2)
        lblDesc7.Text = dt.Rows(6)(3)
        lblPrice7.Text = dt.Rows(6)(5)
        Dim bytes7 As Byte() = dt.Rows(6)(6)
        Dim mstream7 As New System.IO.MemoryStream(bytes7)
        pbProd7.Image = Image.FromStream(mstream7)

        '8
        lblID8.Text = dt.Rows(7)(1)
        lblName8.Text = dt.Rows(7)(2)
        lblDesc8.Text = dt.Rows(7)(3)
        lblPrice8.Text = dt.Rows(7)(5)
        Dim bytes8 As Byte() = dt.Rows(7)(6)
        Dim mstream8 As New System.IO.MemoryStream(bytes8)
        pbProd8.Image = Image.FromStream(mstream8)

        '9
        lblID9.Text = dt.Rows(8)(1)
        lblName9.Text = dt.Rows(8)(2)
        lblDesc9.Text = dt.Rows(8)(3)
        lblPrice9.Text = dt.Rows(8)(5)
        Dim bytes9 As Byte() = dt.Rows(8)(6)
        Dim mstream9 As New System.IO.MemoryStream(bytes9)
        pbProd9.Image = Image.FromStream(mstream9)

        '10
        lblID10.Text = dt.Rows(9)(1)
        lblName10.Text = dt.Rows(9)(2)
        lblDesc10.Text = dt.Rows(9)(3)
        lblPrice10.Text = dt.Rows(9)(5)
        Dim bytes10 As Byte() = dt.Rows(9)(6)
        Dim mstream10 As New System.IO.MemoryStream(bytes10)
        pbProd10.Image = Image.FromStream(mstream10)



    End Sub

    Sub getStoreID()
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            Dim dt2 As New DataTable
            Sql = "SELECT * FROM STOREtbl"
            cmd.Connection = con
            cmd.CommandText = Sql
            da.SelectCommand = cmd

            da.Fill(dt2)
            'DataGridView1.DataSource = dt2
            ComboBox1.Items.Add(dt2.Rows(0)(0))
            ComboBox1.Items.Add(dt2.Rows(1)(0))




        Catch ex As Exception

        End Try
    End Sub
    Sub getProductDataInitial()
        'removed try para
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter
        'con.Open()


        sql = "SELECT * FROM PRODUCTtbl WHERE storeID=" & Val(ComboBox1.Text)
        cmd.Connection = con
        cmd.CommandText = sql
        da.SelectCommand = cmd



        da.Fill(dt)
        'DataGridView1.DataSource = dt
        'varAdminID = dt.Rows(0)(0)
        '1
        lblID1.Text = dt.Rows(0)(1)
        lblName1.Text = dt.Rows(0)(2)
        lblDesc1.Text = dt.Rows(0)(3)
        lblPrice1.Text = dt.Rows(0)(5)
        Dim bytes As Byte() = dt.Rows(0)(6)
        Dim mstream As New System.IO.MemoryStream(bytes)
        pbProd1.Image = Image.FromStream(mstream)

        '2
        lblID2.Text = dt.Rows(1)(1)
        lblName2.Text = dt.Rows(1)(2)
        lblDesc2.Text = dt.Rows(1)(3)
        lblPrice2.Text = dt.Rows(1)(5)
        Dim bytes2 As Byte() = dt.Rows(1)(6)
        Dim mstream2 As New System.IO.MemoryStream(bytes2)
        pbProd2.Image = Image.FromStream(mstream2)

        '3
        lblID3.Text = dt.Rows(2)(1)
        lblName3.Text = dt.Rows(2)(2)
        lblDesc3.Text = dt.Rows(2)(3)
        lblPrice3.Text = dt.Rows(2)(5)
        Dim bytes3 As Byte() = dt.Rows(2)(6)
        Dim mstream3 As New System.IO.MemoryStream(bytes3)
        pbProd3.Image = Image.FromStream(mstream3)

        '4
        lblID4.Text = dt.Rows(3)(1)
        lblName4.Text = dt.Rows(3)(2)
        lblDesc4.Text = dt.Rows(3)(3)
        lblPrice4.Text = dt.Rows(3)(5)
        Dim bytes4 As Byte() = dt.Rows(3)(6)
        Dim mstream4 As New System.IO.MemoryStream(bytes4)
        pbProd4.Image = Image.FromStream(mstream4)

        '5
        lblID5.Text = dt.Rows(4)(1)
        lblName5.Text = dt.Rows(4)(2)
        lblDesc5.Text = dt.Rows(4)(3)
        lblPrice5.Text = dt.Rows(4)(5)
        Dim bytes5 As Byte() = dt.Rows(4)(6)
        Dim mstream5 As New System.IO.MemoryStream(bytes5)
        pbProd5.Image = Image.FromStream(mstream5)

        '6
        lblID6.Text = dt.Rows(5)(1)
        lblName6.Text = dt.Rows(5)(2)
        lblDesc6.Text = dt.Rows(5)(3)
        lblPrice6.Text = dt.Rows(5)(5)
        Dim bytes6 As Byte() = dt.Rows(5)(6)
        Dim mstream6 As New System.IO.MemoryStream(bytes6)
        pbProd6.Image = Image.FromStream(mstream6)

        '7
        lblID7.Text = dt.Rows(6)(1)
        lblName7.Text = dt.Rows(6)(2)
        lblDesc7.Text = dt.Rows(6)(3)
        lblPrice7.Text = dt.Rows(6)(5)
        Dim bytes7 As Byte() = dt.Rows(6)(6)
        Dim mstream7 As New System.IO.MemoryStream(bytes7)
        pbProd7.Image = Image.FromStream(mstream7)

        '8
        lblID8.Text = dt.Rows(7)(1)
        lblName8.Text = dt.Rows(7)(2)
        lblDesc8.Text = dt.Rows(7)(3)
        lblPrice8.Text = dt.Rows(7)(5)
        Dim bytes8 As Byte() = dt.Rows(7)(6)
        Dim mstream8 As New System.IO.MemoryStream(bytes8)
        pbProd8.Image = Image.FromStream(mstream8)

        '9
        lblID9.Text = dt.Rows(8)(1)
        lblName9.Text = dt.Rows(8)(2)
        lblDesc9.Text = dt.Rows(8)(3)
        lblPrice9.Text = dt.Rows(8)(5)
        Dim bytes9 As Byte() = dt.Rows(8)(6)
        Dim mstream9 As New System.IO.MemoryStream(bytes9)
        pbProd9.Image = Image.FromStream(mstream9)

        '10
        lblID10.Text = dt.Rows(9)(1)
        lblName10.Text = dt.Rows(9)(2)
        lblDesc10.Text = dt.Rows(9)(3)
        lblPrice10.Text = dt.Rows(9)(5)
        Dim bytes10 As Byte() = dt.Rows(9)(6)
        Dim mstream10 As New System.IO.MemoryStream(bytes10)
        pbProd10.Image = Image.FromStream(mstream10)

    End Sub

    Sub getStoreInfo()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter
        Dim dt2 As New DataTable
        sql = "SELECT * FROM STOREtbl  WHERE storeID=" & Val(ComboBox1.Text)
        cmd.Connection = con
        cmd.CommandText = sql
        da.SelectCommand = cmd

        da.Fill(dt2)
        'DataGridView1.DataSource = dt2


        Dim store1 As String
        store1 = dt2.Rows(0)(1)



        lblStoreName.Text = store1
        lblStoreLoc.Text = dt2.Rows(0)(2)
        lblStoreCon.Text = dt2.Rows(0)(3)

    End Sub

    Dim productID, storeID As Integer
    Dim storeName As String

    Private Sub ButtonBuy1_Click(sender As Object, e As EventArgs) Handles btnBuy1.Click


        productID = lblID1.Text
        storeID = ComboBox1.Text
        storeName = lblStoreName.Text
        Dim formAdminOrderPopUp = New formAdminOrderPopUp(productID, storeID, admID, storeName)

        formAdminOrderPopUp.Show()
    End Sub

    Private Sub ButtonBuy2_Click(sender As Object, e As EventArgs) Handles btnBuy2.Click
        productID = lblID2.Text
        storeID = ComboBox1.Text
        storeName = lblStoreName.Text
        Dim formAdminOrderPopUp = New formAdminOrderPopUp(productID, storeID, admID, storeName)

        formAdminOrderPopUp.Show()
    End Sub

    Private Sub btnBuy3_Click(sender As Object, e As EventArgs) Handles btnBuy3.Click
        productID = lblID3.Text
        storeID = ComboBox1.Text
        storeName = lblStoreName.Text
        Dim formAdminOrderPopUp = New formAdminOrderPopUp(productID, storeID, admID, storeName)

        formAdminOrderPopUp.Show()
    End Sub

    Private Sub btnBuy4_Click(sender As Object, e As EventArgs) Handles btnBuy4.Click
        productID = lblID4.Text
        storeID = ComboBox1.Text
        storeName = lblStoreName.Text
        Dim formAdminOrderPopUp = New formAdminOrderPopUp(productID, storeID, admID, storeName)

        formAdminOrderPopUp.Show()
    End Sub

    Private Sub btnBuy5_Click(sender As Object, e As EventArgs) Handles btnBuy5.Click
        productID = lblID5.Text
        storeID = ComboBox1.Text
        storeName = lblStoreName.Text
        Dim formAdminOrderPopUp = New formAdminOrderPopUp(productID, storeID, admID, storeName)

        formAdminOrderPopUp.Show()
    End Sub

    Private Sub btnBuy6_Click(sender As Object, e As EventArgs) Handles btnBuy6.Click
        productID = lblID6.Text
        storeID = ComboBox1.Text
        storeName = lblStoreName.Text
        Dim formAdminOrderPopUp = New formAdminOrderPopUp(productID, storeID, admID, storeName)

        formAdminOrderPopUp.Show()
    End Sub

    Private Sub btnBuy7_Click(sender As Object, e As EventArgs) Handles btnBuy7.Click
        productID = lblID7.Text
        storeID = ComboBox1.Text
        storeName = lblStoreName.Text
        Dim formAdminOrderPopUp = New formAdminOrderPopUp(productID, storeID, admID, storeName)

        formAdminOrderPopUp.Show()
    End Sub

    Private Sub btnBuy8_Click(sender As Object, e As EventArgs) Handles btnBuy8.Click
        productID = lblID8.Text
        storeID = ComboBox1.Text
        storeName = lblStoreName.Text
        Dim formAdminOrderPopUp = New formAdminOrderPopUp(productID, storeID, admID, storeName)

        formAdminOrderPopUp.Show()
    End Sub

    Private Sub btnBuy9_Click(sender As Object, e As EventArgs) Handles btnBuy9.Click
        productID = lblID9.Text
        storeID = ComboBox1.Text
        storeName = lblStoreName.Text
        Dim formAdminOrderPopUp = New formAdminOrderPopUp(productID, storeID, admID, storeName)

        formAdminOrderPopUp.Show()
    End Sub

    Private Sub btnBuy10_Click(sender As Object, e As EventArgs) Handles btnBuy10.Click
        productID = lblID10.Text
        storeID = ComboBox1.Text
        storeName = lblStoreName.Text
        Dim formAdminOrderPopUp = New formAdminOrderPopUp(productID, storeID, admID, storeName)

        formAdminOrderPopUp.Show()
    End Sub
End Class