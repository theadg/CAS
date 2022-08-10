'THIS FORM WAS CODED BY: DE GUZMAN, ANDREW
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class formStoreMActiveOrder
    ' Dim con As New OleDb.OleDbConnection(My.Settings.CASdbConnectionString)
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Documents\CASdb.accdb")
    'decalrations for the image
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
        'set the lblstoreID as stID
        lblStoreID.Text = stID
        'load active orders with the corresponding store id
        loadActiveOrders()
        'load complete orders with the corresponding store id
        loadCompleteOrders()
        'load store data with the corresponding store id
        loadStoreData()
        'load active pdocuts with the corresponding store id
        loadStoreProducts()
    End Sub
    'load active orders with the corresponding store id
    Sub loadActiveOrders()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
        'select everything from the active order table with the corresponding store id
        sql = "Select * from ORDERactive WHERE storeID=" & Val(stID)
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

        da.Fill(dt)
        'make the source of the datagrid as dt
        DataGridView1.DataSource = dt

    End Sub
    'load complete orders with the corresponding store id
    Sub loadCompleteOrders()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        ' Try
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter
        'select everything from the ordercompletenotif table with the corresponding store id
        sql = "Select * from ORDERcompleteNOTIF WHERE storeID=" & Val(stID)
        cmd.Connection = con
        cmd.CommandText = sql
        da.SelectCommand = cmd

        da.Fill(dt)
        'make the source of the datagrid as dt
        DataGridView2.DataSource = dt

    End Sub
    'loadstoredata with the correspoinding store id
    Sub loadStoreData()
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            con.Open()
            'select everything in the storetbl with the correspoinding store id
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
        'Whenever a cell in the datagrid is clicked, the data of the record will be placed into corresponding controls
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
        'remove the order from the table
        deleteOrder()
    End Sub

    Dim prodName, storeName, userType As String


    Dim totalSales As Integer = 0
    'Sub getStoreSales()
    '    Try
    '        Dim sql As String
    '        Dim cmd As New OleDb.OleDbCommand
    '        Dim dt As New DataTable
    '        Dim da As New OleDbDataAdapter
    '        con.Open()
    '        sql = "Select prodTotalPrice from ORDERcomplete WHERE storeID=" & Val(stID)
    '        cmd.Connection = con
    '        cmd.CommandText = sql
    '        da.SelectCommand = cmd

    '        da.Fill(dt)

    '        For Each Row As DataRow In dt.Rows
    '            totalSales += Row(0)
    '        Next
    '        txtSalesTotalMain.Text = totalSales
    '    Catch ex As Exception
    '        ' MsgBox(ex.Message)
    '    End Try

    '    con.Close()
    'End Sub
    'Sub updateStoreSales()
    '    Try
    '        Dim sql As String
    '        Dim cmd As New OleDb.OleDbCommand
    '        Dim dt As New DataTable
    '        Dim da As New OleDbDataAdapter
    '        con.Open()
    '        sql = "UPDATE STOREtbl set storeSales=@storeSales WHERE storeID=" & Val(stID)
    '        cmd.Parameters.Add(New OleDbParameter("@storeSales", CType(txtSalesTotalMain.Text, Integer)))
    '        cmd.Connection = con
    '        cmd.CommandText = sql
    '        da.SelectCommand = cmd

    '        da.Fill(dt)


    '    Catch ex As Exception
    '        'MsgBox(ex.Message)
    '    End Try

    '    con.Close()
    'End Sub
    'Private Sub btnUpdateSales_Click(sender As Object, e As EventArgs) 
    '    totalSales = 0
    '    getStoreSales()


    '    Try
    '        Dim sql As String
    '        Dim cmd As New OleDb.OleDbCommand
    '        Dim dt As New DataTable
    '        Dim da As New OleDbDataAdapter
    '        con.Open()
    '        sql = "UPDATE STOREtbl set storeSales=@storeSales WHERE storeID=" & Val(stID)
    '        cmd.Parameters.Add(New OleDbParameter("@storeSales", CType(txtSalesTotalMain.Text, Integer)))
    '        cmd.Connection = con
    '        cmd.CommandText = sql
    '        da.SelectCommand = cmd

    '        da.Fill(dt)


    '    Catch ex As Exception
    '        'MsgBox(ex.Message)
    '    End Try

    '    con.Close()

    '    loadStoreData()

    'End Sub
    'load store products with the corresponding store id
    Sub loadStoreProducts()
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            con.Open()
            'select everything fromr produbttbl with the corresponding store id
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
        'load active orders with the corresponding storeid
        loadActiveOrders()
        'load complete orders with the corresponding store id
        loadCompleteOrders()
        'updateQty()

        'load store pdocuts with the corresponding store id
        loadStoreProducts()
    End Sub
    'turned off kasi nakakalito
    'Private Sub btnUpdateQty_Click(sender As Object, e As EventArgs) Handles btnUpdateQty.Click
    '    getQty()
    '    updateQty()
    'End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        ' 'Whenever a cell in the datagrid is clicked, the data of the record will be placed into corresponding controls
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

        'call the get order data complete sub
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
        'select everything from the order complete table with the corresponding orrder id
        sql = "Select * from ORDERcomplete WHERE orderID=" & Val(txtOrderID.Text)
        cmd.Connection = con
        cmd.CommandText = sql
        da.SelectCommand = cmd

        da.Fill(dt)

        'put the data into corresponding variables
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
        'gets the quantity of the selected product
        getQty()

        'if the qty is 1 then prompt the user of the last stock
        If oldQty = 1 Then
            MsgBox("Warning, last stock of prodID " + txtProdID.Text + vbCrLf + "Please update inventory")
            'update the qty of the product
            updateQty()
            'remove the order from the order active table
            deleteOrder()

            'insert the order into the order complete table
            completeOrder()
            'inser tthe order into the order complete notif table
            completeOrderNotif()

            'load active orders witth the corresponding store id
            loadActiveOrders()
            'load complete orders with the corresponding store id
            loadCompleteOrders()
        ElseIf oldQty > 1 Then
            'update the qty of the product
            updateQty()
            'remove the order from the order active table
            deleteOrder()

            'insert the order into the order complete table
            completeOrder()
            'inser tthe order into the order complete notif table
            completeOrderNotif()

            'load active orders witth the corresponding store id
            loadActiveOrders()
            'load complete orders with the corresponding store id
            loadCompleteOrders()
        ElseIf oldQty = 0 Then
            'prompt the user to update the inventory
            MsgBox("Please update the inventory of prodID" + txtProdID.Text)
        End If

    End Sub

    Private Sub btnNotify_Click(sender As Object, e As EventArgs) Handles btnNotify.Click
        'check userType
        If userType = "Student" Then
            'call notifystudent sub to notifystudent
            notifyUserStudent()
            'remove order from ordercompletenotif
            removeOrderforNotif()
            'insert order into order notif table
            transferNotifOrder()

            'load complete orders into datagrid
            loadCompleteOrders()
        ElseIf userType = "Admin" Then
            'call notify admin sub to notify admin
            notifyUserAdmin()
            'remove order from ordercomplete notif
            removeOrderforNotif()
            'insert orderr into order notif table
            transferNotifOrder()

            'load complete orders into datagrid
            loadCompleteOrders()
        End If

    End Sub
    'remove order from ordercompletenotif table
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

        'remove everything frrom ordercompletenotif with teh corresponding order id
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
    'notify admin
    Sub notifyUserAdmin()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter
        Dim updateNum As Integer = 69
        'update adminorder field from useradmin with corresponding admin id
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

    End Sub
    Sub notifyUserStudent()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter
        Dim updateNum As Integer = 69
        'update student order field from userstudent with corresponding sutdent id
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



    End Sub

    'notify all users in the datagrid
    Private Sub btnNotifyAll_Click(sender As Object, e As EventArgs) Handles btnNotifyAll.Click
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            con.Open()
            'select everything from the ordercomplete notif table with the correrspondintg store id
            sql = "Select * from ORDERcompleteNOTIF WHERE storeID=" & Val(stID)
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)
            DataGridView2.DataSource = dt

            'get row count
            Dim rowCount = dt.Rows.Count
            Dim i = 0

            'for loop to go through all the rrows
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

                'put record data into corresponding variables
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

                'notify user dependent upon the usertype
                If userType = "Student" Then
                    'notify student
                    notifyUserStudent()
                    'remove order
                    removeOrderforNotif()
                    'transfer order into order notif table
                    transferNotifOrder()

                    'load complete orders table
                    loadCompleteOrders()
                ElseIf userType = "Admin" Then
                    'notify admin
                    notifyUserAdmin()
                    'remove order
                    removeOrderforNotif()
                    'transfer order into order notif table
                    transferNotifOrder()

                    'load compelte orders table
                    loadCompleteOrders()
                End If

            Next
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
        con.Close()

    End Sub
    'complete all orders in the active orders table
    Private Sub btnCompleteAll_Click(sender As Object, e As EventArgs) Handles btnCompleteAll.Click
        Try

            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            con.Open()
            'select everything in the active order table with the corresponding store id
            sql = "Select * from ORDERactive WHERE storeID=" & Val(stID)
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)
            DataGridView1.DataSource = dt

            'get row count
            Dim rowCount = dt.Rows.Count
            lblRowCount.Text = rowCount

            Dim i = 0
            'go through the each of the records
            For i = 0 To (rowCount)
                'put the record data into corrresponding variable
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

                'get the quantity of the product
                getQty()

                'verify the qty
                If oldQty = 1 Then
                    MsgBox("Warning, last stock of prodID " + txtProdID.Text + vbCrLf + "Please update inventory")
                    'update the qty by deducing the qty of the order to the currrent qty
                    updateQty()
                    'remove all orders fom the table
                    deleteOrderAll()

                    'transfer order to complete orders table
                    completeOrder()

                    'transfer order to complete order notif tale
                    completeOrderNotif()

                    'load active orders into datagrid
                    loadActiveOrders()
                    'load complete orders into datagrid
                    loadCompleteOrders()
                ElseIf oldQty > 1 Then
                    'update the qty by deducing the qty of the order to the currrent qty
                    updateQty()
                    'remove all orders from table
                    deleteOrderAll()

                    'trransfer order to complete order table
                    completeOrder()
                    'transfer order to complete order notif table
                    completeOrderNotif()

                    'load active orders into datagrid
                    loadActiveOrders()
                    'load complete order sinto datagrid
                    loadCompleteOrders()
                ElseIf oldQty < 0 Then
                    'tell the user the update the inventory
                    MsgBox("Please update the inventory of prodID" + txtProdID.Text)
                End If
            Next
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub
    'insert into order notif table
    Sub transferNotifOrder()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        'get the image from the picturebox
        Dim mstream As New System.IO.MemoryStream()

        If pbProd.Image Is Nothing Then
            pbProd.Image = pbProd.ErrorImage
        End If
        pbProd.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrImage = mstream.GetBuffer()
        Dim FileSize As UInt32
        FileSize = mstream.Length
        mstream.Close()
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand


        'insert into the order notif table with the corresponding fields and values
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
    'remove order from orderactive table
    Sub deleteOrder()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand

        'remove everything from orderactive table with the corresponding order id
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'close table
        Me.Close()
    End Sub
    'remove all orders
    Sub deleteOrderAll()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand

        'remove all orders from orrderactive wit the corresponding order id
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
    'get order data
    Sub getOrderData()

        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter
        'select everything from orderactive table with the corresponding order id
        sql = "Select * from ORDERactive WHERE orderID=" & Val(txtOrderID.Text)
        cmd.Connection = con
        cmd.CommandText = sql
        da.SelectCommand = cmd

        da.Fill(dt)
        'put the data into corresponding variables
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
    'get qty of product
    Public Sub getQty()

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter
        'select corresponding fields from the producttbl with the corresponding product id
        sql = "SELECT productQty,productName,productID FROM PRODUCTtbl WHERE productID=" & Val(prodID)
        cmd.Connection = con
        cmd.CommandText = sql

        da.SelectCommand = cmd
        da.Fill(dt)

        'get old qty of the product and put it into a variable
        oldQty = dt.Rows(0)(0)


        con.Close()
    End Sub
    Dim newQty As Integer
    'update qty of product
    Sub updateQty()
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter

            con.Open()
            'update the productqty from the producttbl with the corresponding product id
            sql = "UPDATE PRODUCTtbl SET productQty=@productQty WHERE productID=" & Val(prodID)
            'compute the new qty
            newQty = oldQty - prodQty
            'updatte the new qty
            cmd.Parameters.Add(New OleDbParameter("@productQty", CType(newQty, Integer)))
            cmd.Connection = con
            cmd.CommandText = sql

            da.SelectCommand = cmd
            da.Fill(dt)
        Catch ex As Exception

        End Try

        con.Close()
    End Sub
    'compelte all orders in the active order table
    Sub completeOrderAll()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter
        con.Open()
        'select everything from the orderactive table with the corresponding store id
        sql = "Select * from ORDERactive WHERE storeID=" & Val(stID)
        cmd.Connection = con
        cmd.CommandText = sql
        da.SelectCommand = cmd

        'get the picture from the database

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



        'insert record into the ordercomplete table with the corresponding values
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
    'transferr the order into the ordercomplete table
    Sub completeOrder()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        'get image from database
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


        'insert record into ordercomplete table with the corrersponding values
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
    'insert into ordercomplete notif table
    Sub completeOrderNotif()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        'get pic from db
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


        'insert record into ordercompletenotif table with the corresponding fields and values
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