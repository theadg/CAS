Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class formNotify
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Documents\CASdb.accdb")
    Private Sub formNotify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadTable()
    End Sub
    Sub loadTable()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter



        sql = "SELECT * FROM ORDERnotif WHERE userType='" & (lblUserType.Text) & "' " & "AND userID=" & Val(lbluserID.Text)
        'sql = "SELECT * FROM ORDERnotif WHERE userID=" & Val(lbluserID.Text)
        cmd.Connection = con
        cmd.CommandText = sql

        da.SelectCommand = cmd
        da.Fill(dt)

        DataGridView1.DataSource = dt
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
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

    Private Sub btnComplete_Click(sender As Object, e As EventArgs) Handles btnComplete.Click
        removeOrders()
        removeNotif()
        Me.Close()
    End Sub
    Sub removeOrders()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter



        sql = "DELETE * FROM ORDERnotif WHERE userType='" & (lblUserType.Text) & "' " & "AND userID=" & Val(lbluserID.Text)
        'sql = "SELECT * FROM ORDERnotif WHERE userID=" & Val(lbluserID.Text)
        cmd.Connection = con
        cmd.CommandText = sql

        da.SelectCommand = cmd
        da.Fill(dt)

        DataGridView1.DataSource = dt
    End Sub
    Sub removeNotif()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        'Try
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter
        Dim updateNum As Integer = 0

        sql = "UPDATE USERadmin SET adminOrder=@adminOrder WHERE adminID=" & Val(lbluserID.Text)
        cmd.Parameters.Add(New OleDbParameter("@adminOrder", CType(updateNum, Integer)))
        cmd.Connection = con
        cmd.CommandText = sql
        da.SelectCommand = cmd

        Dim i = cmd.ExecuteNonQuery()
        If i > 0 Then
            MsgBox("CHECK FUCKING USERADMIN")
        Else
            MsgBox("No record has been UPDATED!")
        End If
        'Catch ex As Exception
        '    'MsgBox(ex.Message)
        'End Try

    End Sub
End Class