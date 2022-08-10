'THIS FORM WAS CODED BY: URETA, KISSES
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class formAdminOrderPopUp
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Documents\CASdb.accdb")
    'Dim con As New OleDb.OleDbConnection(My.Settings.CASdbConnectionString)
    'declarations for the image 
    Dim prodID, stID, adminID As Integer
    Dim cmd As New OleDb.OleDbCommand
    Dim da As New OleDb.OleDbDataAdapter
    Dim result As Integer
    Dim imgpath As String
    Dim arrImage() As Byte
    Dim sql, stName As String
    Public Sub New(productID As Integer, storeID As Integer, admID As Integer, storeName As String)

        ' This call is required by the designer.
        InitializeComponent()

        prodID = productID
        stID = storeID
        adminID = admID
        stName = storeName
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub lblID1_Click(sender As Object, e As EventArgs) Handles lblID.Click

    End Sub

    Private Sub formAdminOrderPopUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim total, price, qty As Integer
        'sets the product id
        lblID.Text = prodID

        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            'selects everything from the producttbl with the correpsonding productid
            sql = "SELECT * FROM PRODUCTtbl WHERE productID=" & Val(prodID)
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)
            'puts the data from the dt to the correspnoding controls
            lblID.Text = dt.Rows(0)(1)
            lblName.Text = dt.Rows(0)(2)
            lblDesc.Text = dt.Rows(0)(3)
            lblPrice.Text = dt.Rows(0)(5)
            Dim bytes As Byte() = dt.Rows(0)(6)
            Dim mstream As New System.IO.MemoryStream(bytes)
            pbProd1.Image = Image.FromStream(mstream)


            qty = CInt(txtQty.Text)
            price = Int32.Parse(lblPrice.Text)
            total = price * qty

            txtTotal.Text = total
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim total, qty As Integer
        qty = txtQty.Text
        'increase the qty of the product
        qty += 1
        txtQty.Text = qty
        'increase the price as the qty increases
        total = lblPrice.Text * qty
        txtTotal.Text = total

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'closes the form
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'closes the form
        Me.Close()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        Dim total, qty, price As Integer
        total = txtTotal.Text

        'reduces the quantity of the prpoduct
        price = CInt(lblPrice.Text)
        qty = txtQty.Text
        qty -= 1

        'checks if the qty is = 0
        If qty = 0 Then
            'prompt the user 
            MsgBox("Quantity must be greater than 0")
            'reset the qty
            qty = 1
            total = price
        Else
            'reduce the qty of the product as is
            txtQty.Text = qty
            total -= price
        End If

        'update the total
        txtTotal.Text = total
    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        Try

            Dim mstream As New System.IO.MemoryStream()
            'verify the image of the picturebox
            If pbProd1.Image Is Nothing Then
                pbProd1.Image = pbProd1.ErrorImage
            End If
            'save the image  of the picturebox
            pbProd1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrImage = mstream.GetBuffer()
            Dim FileSize As UInt32
            FileSize = mstream.Length
            mstream.Close()
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim userType As String = "Admin"

            con.Open()
            'insert the record into the order active table with the corresponding fields
            sql = "INSERT INTO ORDERactive([storeID],[prodID],[orderDate],[storeName],[prodName],[prodPrice],[prodTotalPrice],[prodQty],[userType],[userID],[prodPic]) 
                    VALUES (@storeID,@prodID,@orderDate,@storeName,@prodName,@prodPrice,@prodTotalPrice,@prodQty,@userType,@userID,@prodPic)"
            cmd.Parameters.Add(New OleDbParameter("@storeID", CType(stID, Integer))) 'variable passed on
            cmd.Parameters.Add(New OleDbParameter("@prodID", CType(lblID.Text, Integer)))
            cmd.Parameters.Add(New OleDbParameter("@orderDate", CType(DateTimePicker1.Value.Date, Date)))
            cmd.Parameters.Add(New OleDbParameter("@storeName", CType(stName, String)))
            cmd.Parameters.Add(New OleDbParameter("@prodName", CType(lblName.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("@prodPrice", CType(lblPrice.Text, Integer)))
            cmd.Parameters.Add(New OleDbParameter("@prodTotalPrice", CType(txtTotal.Text, Integer)))
            cmd.Parameters.Add(New OleDbParameter("@prodQty", CType(txtQty.Text, Integer)))
            cmd.Parameters.Add(New OleDbParameter("@userType", CType(userType, String))) 'variable  passed on
            cmd.Parameters.Add(New OleDbParameter("@userID", CType(adminID, Integer))) 'varriable passed on 
            cmd.Parameters.AddWithValue("@prodPic", arrImage)


            cmd.Connection = con
            cmd.CommandText = sql

            Dim i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MsgBox("Order placed SUCCESSFULLY!")
                Me.Close()
            Else
                MsgBox("No order has been placed")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            con.Close()

        End Try
    End Sub
End Class