Imports System.Data
Imports System.Data.OleDb
Imports System.IO

Public Class formStudentOrderPopUp

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Documents\CASdb.accdb")
    Dim prodID, stID, studID As Integer
    Dim cmd As New OleDb.OleDbCommand
    Dim da As New OleDb.OleDbDataAdapter
    Dim result As Integer
    Dim imgpath As String
    Dim arrImage() As Byte
    Dim sql, stName As String
    Public Sub New(productID As Integer, storeID As Integer, stdID As Integer, storeName As String)

        ' This call is required by the designer.
        InitializeComponent()

        prodID = productID
        stID = storeID
        studID = stdID
        stName = storeName
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub formAdminOrderPopUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim total, price, qty As Integer




        lblID.Text = prodID

        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            sql = "SELECT * FROM PRODUCTtbl WHERE productID=" & Val(prodID)
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)
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

        qty += 1
        txtQty.Text = qty

        total = lblPrice.Text * qty
        txtTotal.Text = total

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        Dim total, qty, price As Integer
        total = txtTotal.Text

        price = CInt(lblPrice.Text)
        qty = txtQty.Text
        qty -= 1
        If qty = 0 Then
            MsgBox("Quantity must be greater than 0")
            qty = 1
            total = price
        Else
            txtQty.Text = qty
            total -= price
        End If

        txtTotal.Text = total
    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        Try
            'pic code
            Dim mstream As New System.IO.MemoryStream()

            If pbProd1.Image Is Nothing Then
                pbProd1.Image = pbProd1.ErrorImage
            End If
            pbProd1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrImage = mstream.GetBuffer()
            Dim FileSize As UInt32
            FileSize = mstream.Length
            mstream.Close()

            'end of pic code
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim userType As String = "Student"

            con.Open()
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
            cmd.Parameters.Add(New OleDbParameter("@userID", CType(studID, Integer))) 'varriable passed on 
            cmd.Parameters.AddWithValue("@prodPic", arrImage)


            cmd.Connection = con
            cmd.CommandText = sql

            Dim i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MsgBox("Order placed SUCCESSFULLY!")
                Me.Close()
            Else
                MsgBox("No record has been UPDATED!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            con.Close()

        End Try
    End Sub
End Class