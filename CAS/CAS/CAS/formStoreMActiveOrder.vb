﻿Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class formStoreMActiveOrder

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Documents\CASdb.accdb")
    Dim storeID As Integer
    Dim result, stID As Integer
    Dim imgpath As String
    Dim arrImage() As Byte
    Dim sql As String
    Public Sub New(ByVal storeID As Integer)

        'This call Is required by the designer.
        InitializeComponent()
        stID = storeID 'pass this to admin order

        'Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub formStore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblStoreID.Text = stID
        loadActiveOrders()
        loadCompleteOrders()
        loadStoreData()
        loadStoreProducts()
    End Sub

    Sub loadActiveOrders()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
        'con.Open()
        sql = "Select * from ORDERactive WHERE storeID=" & Val(stID)
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)
            DataGridView1.DataSource = dt
        'Catch ex As Exception
        '    ' MsgBox(ex.Message)
        'End Try
        'con.Close()
    End Sub
    Sub loadCompleteOrders()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        ' Try
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter
        'con.Open()
        sql = "Select * from ORDERcompleteNOTIF WHERE storeID=" & Val(stID)
        cmd.Connection = con
        cmd.CommandText = sql
        da.SelectCommand = cmd

        da.Fill(dt)
        DataGridView2.DataSource = dt
        'Catch ex As Exception
        '    'MsgBox(ex.Message)
        'End Try
        'con.Close()
    End Sub
    Sub loadStoreData()
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            con.Open()
            sql = "Select * from STOREtbl WHERE storeID=" & Val(stID)
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)
            'DataGridView3.DataSource = dt
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        btnComplete.Visible = True

        Dim orderID As Integer = DataGridView1.CurrentRow.Cells(0).Value
        txtOrderID.Text = orderID

        ' txtStoreID.Text = DataGridView1.CurrentRow.Cells(1).Value
        txtProdID.Text = DataGridView1.CurrentRow.Cells(2).Value
        DateTimePicker1.Value = DataGridView1.CurrentRow.Cells(3).Value
        'txtStoreName.Text = DataGridView1.CurrentRow.Cells(4).Value
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

        getOrderData()
    End Sub
    Dim orderID, prodID, strID, prodPrice, prodTotalPrice, prodQty, userID As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        deleteOrder()
    End Sub

    Dim prodName, storeName, userType As String


    Dim totalSales As Integer = 0
    Sub getStoreSales()
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            con.Open()
            sql = "Select prodTotalPrice from ORDERcomplete WHERE storeID=" & Val(stID)
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)

            For Each Row As DataRow In dt.Rows
                totalSales += Row(0)
            Next
            txtSalesTotalMain.Text = totalSales
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try

        con.Close()
    End Sub
    Sub updateStoreSales()
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            con.Open()
            sql = "UPDATE STOREtbl set storeSales=@storeSales WHERE storeID=" & Val(stID)
            cmd.Parameters.Add(New OleDbParameter("@storeSales", CType(txtSalesTotalMain.Text, Integer)))
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)


        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        con.Close()
    End Sub
    Private Sub btnUpdateSales_Click(sender As Object, e As EventArgs) Handles btnUpdateSales.Click
        totalSales = 0
        getStoreSales()


        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            con.Open()
            sql = "UPDATE STOREtbl set storeSales=@storeSales WHERE storeID=" & Val(stID)
            cmd.Parameters.Add(New OleDbParameter("@storeSales", CType(txtSalesTotalMain.Text, Integer)))
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
    Sub loadStoreProducts()
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            con.Open()
            sql = "Select * from PRODUCTtbl WHERE storeID=" & Val(stID)
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)

            'DataGridView4.DataSource = dt
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        con.Close()
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        loadActiveOrders()
        loadCompleteOrders()
        'updateQty()
        loadStoreProducts()
    End Sub
    'turned off kasi nakakalito
    'Private Sub btnUpdateQty_Click(sender As Object, e As EventArgs) Handles btnUpdateQty.Click
    '    getQty()
    '    updateQty()
    'End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        btnComplete.Visible = False
        Dim orderID As Integer = DataGridView2.CurrentRow.Cells(0).Value
        txtOrderID.Text = orderID

        ' txtStoreID.Text = DataGridView1.CurrentRow.Cells(1).Value
        txtProdID.Text = DataGridView2.CurrentRow.Cells(2).Value
        DateTimePicker1.Value = DataGridView2.CurrentRow.Cells(3).Value
        'txtStoreName.Text = DataGridView1.CurrentRow.Cells(4).Value
        txtProdName.Text = DataGridView2.CurrentRow.Cells(5).Value '3
        txtProdPrice.Text = DataGridView2.CurrentRow.Cells(6).Value
        txtProdPriceTotal.Text = DataGridView2.CurrentRow.Cells(7).Value
        txtProdQty.Text = DataGridView2.CurrentRow.Cells(8).Value



        Dim picVar = DataGridView2.CurrentRow.Cells(11).Value
        If (picVar) IsNot DBNull.Value Then
            Dim bytes As Byte() = DataGridView2.CurrentRow.Cells(11).Value
            Dim mstream As New System.IO.MemoryStream(bytes)
            pbProd.Image = Image.FromStream(mstream)
        Else
            pbProd.Image = pbProd.ErrorImage
        End If

        getOrderDataComplete()
    End Sub
    Sub getOrderDataComplete()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter

        sql = "Select * from ORDERcomplete WHERE orderID=" & Val(txtOrderID.Text)
        cmd.Connection = con
        cmd.CommandText = sql
        da.SelectCommand = cmd

        da.Fill(dt)

        orderID = dt.Rows(0)(0)
        strID = dt.Rows(0)(1)
        prodID = dt.Rows(0)(2)
        orderDate = dt.Rows(0)(3)
        storeName = dt.Rows(0)(4)
        prodName = dt.Rows(0)(5)
        prodPrice = dt.Rows(0)(6)
        prodTotalPrice = dt.Rows(0)(7)
        prodQty = dt.Rows(0)(8)
        userType = dt.Rows(0)(9)
        userID = dt.Rows(0)(10)

        'magical line of code right here for getting image from db
        Dim picVar = dt.Rows(0)(11)
        If (picVar) IsNot DBNull.Value Then
            Dim bytes As Byte() = dt.Rows(0)(11)
            Dim mstream As New System.IO.MemoryStream(bytes)
            pbProd.Image = Image.FromStream(mstream)
        Else
            pbProd.Image = pbProd.ErrorImage
        End If
    End Sub
    Dim orderDate As Date
    Private Sub btnComplete_Click(sender As Object, e As EventArgs) Handles btnComplete.Click

        getQty()

        If oldQty = 1 Then
            MsgBox("Warning, last stock of prodID " + txtProdID.Text + vbCrLf + "Please update inventory")
            updateQty()
            deleteOrder()

            completeOrder()
            completeOrderNotif()

            loadActiveOrders()
            loadCompleteOrders()
        ElseIf oldQty > 1 Then
            updateQty()
            deleteOrder()

            completeOrder()
            completeOrderNotif()

            loadActiveOrders()
            loadCompleteOrders()
        ElseIf oldQty = 0 Then
            MsgBox("Please update the inventory of prodID" + txtProdID.Text)
        End If






    End Sub

    Private Sub btnNotify_Click(sender As Object, e As EventArgs) Handles btnNotify.Click
        If userType = "Student" Then
            notifyUserStudent()
            removeOrderforNotif()
            transferNotifOrder()

            loadCompleteOrders()
        ElseIf userType = "Admin" Then
            notifyUserAdmin()
            removeOrderforNotif()
            transferNotifOrder()

            loadCompleteOrders()
        End If

    End Sub
    Sub removeOrderforNotif()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        'Try
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter
        Dim updateNum As Integer = 69

        sql = "DELETE * FROM ORDERcompleteNOTIF WHERE orderID=" & Val(orderID)

        cmd.Connection = con
        cmd.CommandText = sql
        da.SelectCommand = cmd

        Dim i = cmd.ExecuteNonQuery()
        If i > 0 Then
            MsgBox("ORDER REMOVED")
        Else
            MsgBox("No record has been UPDATED!")
        End If
    End Sub
    Sub notifyUserAdmin()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        'Try
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter
        Dim updateNum As Integer = 69

        sql = "UPDATE USERadmin SET adminOrder=@adminOrder WHERE adminID=" & Val(userID)
        cmd.Parameters.Add(New OleDbParameter("@adminOrder", CType(updateNum, Integer)))
        cmd.Connection = con
        cmd.CommandText = sql
        da.SelectCommand = cmd

        Dim i = cmd.ExecuteNonQuery()
        If i > 0 Then
            MsgBox("Admin notified")
        Else
            MsgBox("No record has been UPDATED!")
        End If
        'Catch ex As Exception
        '    'MsgBox(ex.Message)
        'End Try


    End Sub
    Sub notifyUserStudent()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        'Try
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter
        Dim updateNum As Integer = 69

        sql = "UPDATE USERstudent SET studOrder=@studOrder WHERE studID=" & Val(userID)
        cmd.Parameters.Add(New OleDbParameter("@studOrder", CType(updateNum, Integer)))
        cmd.Connection = con
        cmd.CommandText = sql
        da.SelectCommand = cmd

        Dim i = cmd.ExecuteNonQuery()
        If i > 0 Then
            MsgBox("User notified")
        Else
            MsgBox("No record has been UPDATED!")
        End If
        'Catch ex As Exception
        '    'MsgBox(ex.Message)
        'End Try


    End Sub


    Private Sub btnNotifyAll_Click(sender As Object, e As EventArgs) Handles btnNotifyAll.Click
        Try


            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            con.Open()
            sql = "Select * from ORDERcompleteNOTIF WHERE storeID=" & Val(stID)
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)
            DataGridView2.DataSource = dt

            Dim rowCount = dt.Rows.Count
            Dim i = 0
            'For Each Row As DataRow In dt.Rows
            '    userID = dt.Rows(i)(10)
            '    i += 1

            '    notifyUser()
            '    removeOrderforNotif()
            '    transferNotifOrder()

            '    loadCompleteOrders()
            'Next
            For i = 0 To rowCount '- 1
                Dim mstream As New System.IO.MemoryStream()
                If pbProd.Image Is Nothing Then
                    pbProd.Image = pbProd.ErrorImage
                End If
                pbProd.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                arrImage = mstream.GetBuffer()
                Dim FileSize As UInt32
                FileSize = mstream.Length
                mstream.Close()

                orderID = dt.Rows(i)(0)
                storeID = dt.Rows(i)(1)
                prodID = dt.Rows(i)(2)
                orderDate = dt.Rows(i)(3)
                storeName = dt.Rows(i)(4)
                prodName = dt.Rows(i)(5)
                prodPrice = dt.Rows(i)(6)
                prodTotalPrice = dt.Rows(i)(7)
                prodQty = dt.Rows(i)(8)
                userType = dt.Rows(i)(9)
                userID = dt.Rows(i)(10)
                arrImage = dt.Rows(i)(11)

                If userType = "Student" Then
                    notifyUserStudent()
                    removeOrderforNotif()
                    transferNotifOrder()

                    loadCompleteOrders()
                ElseIf userType = "Admin" Then
                    notifyUserAdmin()
                    removeOrderforNotif()
                    transferNotifOrder()

                    loadCompleteOrders()
                End If

            Next
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
        con.Close()

    End Sub

    Private Sub btnCompleteAll_Click(sender As Object, e As EventArgs) Handles btnCompleteAll.Click
        Try

            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            con.Open()
            sql = "Select * from ORDERactive WHERE storeID=" & Val(stID)
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)
            DataGridView1.DataSource = dt

            Dim rowCount = dt.Rows.Count
            lblRowCount.Text = rowCount

            Dim i = 0

            For i = 0 To (rowCount)

                orderID = dt.Rows(i)(0)
                strID = dt.Rows(i)(1)
                prodID = dt.Rows(i)(2)
                orderDate = dt.Rows(i)(3)
                storeName = dt.Rows(i)(4)
                prodName = dt.Rows(i)(5)
                prodPrice = dt.Rows(i)(6)
                prodTotalPrice = dt.Rows(i)(7)
                prodQty = dt.Rows(i)(8)
                userType = dt.Rows(i)(9)
                userID = dt.Rows(i)(10)
                arrImage = dt.Rows(i)(11)

                getQty()

                If oldQty = 1 Then
                    MsgBox("Warning, last stock of prodID " + txtProdID.Text + vbCrLf + "Please update inventory")
                    updateQty()
                    deleteOrderAll()

                    completeOrder()
                    'completeOrderAll()
                    completeOrderNotif()

                    loadActiveOrders()
                    loadCompleteOrders()
                ElseIf oldQty > 1 Then
                    updateQty()
                    deleteOrderAll()

                    completeOrder()
                    'completeOrderAll()
                    completeOrderNotif()

                    loadActiveOrders()
                    loadCompleteOrders()
                ElseIf oldQty < 0 Then
                    MsgBox("Please update the inventory of prodID" + txtProdID.Text)
                End If
            Next
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub

    Sub transferNotifOrder()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        'pic code
        Dim mstream As New System.IO.MemoryStream()

        If pbProd.Image Is Nothing Then
            pbProd.Image = pbProd.ErrorImage
        End If
        pbProd.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrImage = mstream.GetBuffer()
        Dim FileSize As UInt32
        FileSize = mstream.Length
        mstream.Close()

        'end of pic code
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand



        sql = "INSERT INTO ORDERnotif([orderID],[storeID],[prodID],[orderDate],[storeName],[prodName],[prodPrice],[prodTotalPrice],[prodQty],[userType],[userID],[prodPic]) 
                    VALUES (@orderID,@storeID,@prodID,@orderDate,@storeName,@prodName,@prodPrice,@prodTotalPrice,@prodQty,@userType,@userID,@prodPic)"
        cmd.Parameters.Add(New OleDbParameter("@orderID", CType(orderID, Integer)))
        cmd.Parameters.Add(New OleDbParameter("@storeID", CType(strID, Integer))) 'variable passed on
        cmd.Parameters.Add(New OleDbParameter("@prodID", CType(prodID, Integer)))
        cmd.Parameters.Add(New OleDbParameter("@orderDate", CType(orderDate, Date)))
        cmd.Parameters.Add(New OleDbParameter("@storeName", CType(storeName, String)))
        cmd.Parameters.Add(New OleDbParameter("@prodName", CType(prodName, String)))
        cmd.Parameters.Add(New OleDbParameter("@prodPrice", CType(prodPrice, Integer)))
        cmd.Parameters.Add(New OleDbParameter("@prodTotalPrice", CType(prodTotalPrice, Integer)))
        cmd.Parameters.Add(New OleDbParameter("@prodQty", CType(prodQty, Integer)))
        cmd.Parameters.Add(New OleDbParameter("@userType", CType(userType, String))) 'variable  passed on
        cmd.Parameters.Add(New OleDbParameter("@userID", CType(userID, Integer))) 'varriable passed on 
        cmd.Parameters.AddWithValue("@prodPic", arrImage)


        cmd.Connection = con
        cmd.CommandText = sql

        Dim i = cmd.ExecuteNonQuery()
        If i > 0 Then
            MsgBox("User notified")
        Else
            MsgBox("USER NOT NOTIFIED (DB)!")
        End If
    End Sub

    Sub deleteOrder()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand


        sql = "DELETE * from ORDERactive WHERE orderID=" & Val(txtOrderID.Text)
        cmd.Connection = con
        cmd.CommandText = sql

        Dim i = cmd.ExecuteNonQuery()
        If i > 0 Then
            MsgBox("Order completed SUCCESSFULLY")
        Else
            MsgBox("No record has been DELETED")
        End If

    End Sub
    Sub deleteOrderAll()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand


        sql = "DELETE * from ORDERactive WHERE orderID=" & Val(orderID)
        cmd.Connection = con
        cmd.CommandText = sql

        Dim i = cmd.ExecuteNonQuery()
        If i > 0 Then
            MsgBox("Order completed SUCCESSFULLY")
        Else
            MsgBox("No record has been DELETED")
        End If

    End Sub

    Sub getOrderData()

        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter

        sql = "Select * from ORDERactive WHERE orderID=" & Val(txtOrderID.Text)
        cmd.Connection = con
        cmd.CommandText = sql
        da.SelectCommand = cmd

        da.Fill(dt)

        orderID = dt.Rows(0)(0)
        strID = dt.Rows(0)(1)
        prodID = dt.Rows(0)(2)
        orderDate = dt.Rows(0)(3)
        storeName = dt.Rows(0)(4)
        prodName = dt.Rows(0)(5)
        prodPrice = dt.Rows(0)(6)
        prodTotalPrice = dt.Rows(0)(7)
        prodQty = dt.Rows(0)(8)
        userType = dt.Rows(0)(9)
        userID = dt.Rows(0)(10)

        'magical line of code right here for getting image from db
        Dim picVar = dt.Rows(0)(11)
        If (picVar) IsNot DBNull.Value Then
            Dim bytes As Byte() = dt.Rows(0)(11)
            Dim mstream As New System.IO.MemoryStream(bytes)
            pbProd.Image = Image.FromStream(mstream)
        Else
            pbProd.Image = pbProd.ErrorImage
        End If
    End Sub

    Dim oldQty As Integer
    Public Sub getQty()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter

        'con.Open()


        sql = "SELECT productQty,productName,productID FROM PRODUCTtbl WHERE productID=" & Val(prodID)
            cmd.Connection = con
            cmd.CommandText = sql

            da.SelectCommand = cmd
            da.Fill(dt)

            oldQty = dt.Rows(0)(0)


        'DataGridView5.DataSource = dt

        'Catch ex As Exception
        '    ' MsgBox(ex.Message)
        'End Try


        con.Close()
    End Sub
    Dim newQty As Integer
    Sub updateQty()
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter

            con.Open()
            sql = "UPDATE PRODUCTtbl SET productQty=@productQty WHERE productID=" & Val(prodID)
            newQty = oldQty - prodQty

            cmd.Parameters.Add(New OleDbParameter("@productQty", CType(newQty, Integer)))
            cmd.Connection = con
            cmd.CommandText = sql

            da.SelectCommand = cmd
            da.Fill(dt)

            'oldQty = dt.Rows(0)(4)
            'newQty = oldQty - prodQty

            'DataGridView5.DataSource = dt

        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        con.Close()
    End Sub
    Sub completeOrderAll()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter
        con.Open()
        sql = "Select * from ORDERactive WHERE storeID=" & Val(stID)
        cmd.Connection = con
        cmd.CommandText = sql
        da.SelectCommand = cmd

        'pic code

        Dim mstream As New System.IO.MemoryStream()

        If pbProd.Image Is Nothing Then
            pbProd.Image = pbProd.ErrorImage
        End If
        pbProd.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrImage = mstream.GetBuffer()
        Dim FileSize As UInt32
        FileSize = mstream.Length
        mstream.Close()

        'end of pic code




        sql = "INSERT INTO ORDERcomplete([orderID],[storeID],[prodID],[orderDate],[storeName],[prodName],[prodPrice],[prodTotalPrice],[prodQty],[userType],[userID],[prodPic]) 
                    VALUES (@orderID,@storeID,@prodID,@orderDate,@storeName,@prodName,@prodPrice,@prodTotalPrice,@prodQty,@userType,@userID,@prodPic)"
        cmd.Parameters.Add(New OleDbParameter("@orderID", CType(orderID, Integer)))
        cmd.Parameters.Add(New OleDbParameter("@storeID", CType(strID, Integer))) 'variable passed on
        cmd.Parameters.Add(New OleDbParameter("@prodID", CType(prodID, Integer)))
        cmd.Parameters.Add(New OleDbParameter("@orderDate", CType(orderDate, Date)))
        cmd.Parameters.Add(New OleDbParameter("@storeName", CType(storeName, String)))
        cmd.Parameters.Add(New OleDbParameter("@prodName", CType(prodName, String)))
        cmd.Parameters.Add(New OleDbParameter("@prodPrice", CType(prodPrice, Integer)))
        cmd.Parameters.Add(New OleDbParameter("@prodTotalPrice", CType(prodTotalPrice, Integer)))
        cmd.Parameters.Add(New OleDbParameter("@prodQty", CType(prodQty, Integer)))
        cmd.Parameters.Add(New OleDbParameter("@userType", CType(userType, String))) 'variable  passed on
        cmd.Parameters.Add(New OleDbParameter("@userID", CType(userID, Integer))) 'varriable passed on 
        cmd.Parameters.AddWithValue("@prodPic", arrImage)


        cmd.Connection = con
        cmd.CommandText = sql

        Dim i = cmd.ExecuteNonQuery()
        If i > 0 Then
            'MsgBox("ORDER NALIPAT NA")
        Else
            MsgBox("No record has been UPDATED!")
        End If


    End Sub
    Sub completeOrder()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        'pic code
        Dim mstream As New System.IO.MemoryStream()

        If pbProd.Image Is Nothing Then
            pbProd.Image = pbProd.ErrorImage
        End If
        pbProd.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrImage = mstream.GetBuffer()
        Dim FileSize As UInt32
        FileSize = mstream.Length
        mstream.Close()

        'end of pic code
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand



        sql = "INSERT INTO ORDERcomplete([orderID],[storeID],[prodID],[orderDate],[storeName],[prodName],[prodPrice],[prodTotalPrice],[prodQty],[userType],[userID],[prodPic]) 
                    VALUES (@orderID,@storeID,@prodID,@orderDate,@storeName,@prodName,@prodPrice,@prodTotalPrice,@prodQty,@userType,@userID,@prodPic)"
        cmd.Parameters.Add(New OleDbParameter("@orderID", CType(orderID, Integer)))
        cmd.Parameters.Add(New OleDbParameter("@storeID", CType(strID, Integer))) 'variable passed on
        cmd.Parameters.Add(New OleDbParameter("@prodID", CType(prodID, Integer)))
        cmd.Parameters.Add(New OleDbParameter("@orderDate", CType(orderDate, Date)))
        cmd.Parameters.Add(New OleDbParameter("@storeName", CType(storeName, String)))
        cmd.Parameters.Add(New OleDbParameter("@prodName", CType(prodName, String)))
        cmd.Parameters.Add(New OleDbParameter("@prodPrice", CType(prodPrice, Integer)))
        cmd.Parameters.Add(New OleDbParameter("@prodTotalPrice", CType(prodTotalPrice, Integer)))
        cmd.Parameters.Add(New OleDbParameter("@prodQty", CType(prodQty, Integer)))
        cmd.Parameters.Add(New OleDbParameter("@userType", CType(userType, String))) 'variable  passed on
        cmd.Parameters.Add(New OleDbParameter("@userID", CType(userID, Integer))) 'varriable passed on 
        cmd.Parameters.AddWithValue("@prodPic", arrImage)


        cmd.Connection = con
        cmd.CommandText = sql

        Dim i = cmd.ExecuteNonQuery()
        If i > 0 Then
            'MsgBox("ORDER NALIPAT NA")
        Else
            MsgBox("No record has been UPDATED!")
        End If


    End Sub
    Sub completeOrderNotif()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        'pic code
        Dim mstream As New System.IO.MemoryStream()

        If pbProd.Image Is Nothing Then
            pbProd.Image = pbProd.ErrorImage
        End If
        pbProd.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrImage = mstream.GetBuffer()
        Dim FileSize As UInt32
        FileSize = mstream.Length
        mstream.Close()

        'end of pic code
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand



        sql = "INSERT INTO ORDERcompleteNOTIF([orderID],[storeID],[prodID],[orderDate],[storeName],[prodName],[prodPrice],[prodTotalPrice],[prodQty],[userType],[userID],[prodPic]) 
                    VALUES (@orderID,@storeID,@prodID,@orderDate,@storeName,@prodName,@prodPrice,@prodTotalPrice,@prodQty,@userType,@userID,@prodPic)"
        cmd.Parameters.Add(New OleDbParameter("@orderID", CType(orderID, Integer)))
        cmd.Parameters.Add(New OleDbParameter("@storeID", CType(strID, Integer))) 'variable passed on
        cmd.Parameters.Add(New OleDbParameter("@prodID", CType(prodID, Integer)))
        cmd.Parameters.Add(New OleDbParameter("@orderDate", CType(orderDate, Date)))
        cmd.Parameters.Add(New OleDbParameter("@storeName", CType(storeName, String)))
        cmd.Parameters.Add(New OleDbParameter("@prodName", CType(prodName, String)))
        cmd.Parameters.Add(New OleDbParameter("@prodPrice", CType(prodPrice, Integer)))
        cmd.Parameters.Add(New OleDbParameter("@prodTotalPrice", CType(prodTotalPrice, Integer)))
        cmd.Parameters.Add(New OleDbParameter("@prodQty", CType(prodQty, Integer)))
        cmd.Parameters.Add(New OleDbParameter("@userType", CType(userType, String))) 'variable  passed on
        cmd.Parameters.Add(New OleDbParameter("@userID", CType(userID, Integer))) 'varriable passed on 
        cmd.Parameters.AddWithValue("@prodPic", arrImage)


        cmd.Connection = con
        cmd.CommandText = sql

        Dim i = cmd.ExecuteNonQuery()
        If i > 0 Then
            'MsgBox("ORDER NALIPAT NA")
        Else
            MsgBox("No record has been UPDATED!")
        End If


    End Sub
End Class