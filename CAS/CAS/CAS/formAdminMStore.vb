'THIS FORM WAS CODED BY: BAGASON, ALBERT
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class formAdminMStore
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Documents\CASdb.accdb")
    'declarations for the image
    Dim da As New OleDb.OleDbDataAdapter
    Dim result As Integer
    Dim imgpath As String
    Dim arrImage() As Byte
    Dim sql As String
    'Dim con As New OleDb.OleDbConnection(My.Settings.CASdbConnectionString)
    Private Sub formAdminMStore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'calls the function to refresh the table in the datagrid
        refreshTable()
        'sets the column size of the datagrid as auto
        dgvStore.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
    End Sub
    'Add record to table
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        'checks if the required fields have input
        If txtStoreContact.Text = String.Empty Or txtStoreName.Text = String.Empty Or txtStoreLocation.Text = String.Empty Then
            MsgBox("Please complete necessary fields!")
        Else
            'calls the subs to insert the record and to update the datagrid
            insertTable()
            refreshTable()
        End If
    End Sub
    'adds record to the table
    Sub insertTable()
        'opens the database connection if it is closed
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If


        'saves the image of the picturebox into a variable 
        Dim mstream As New System.IO.MemoryStream()
        pbStorePic.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrImage = mstream.GetBuffer()
        Dim FileSize As UInt32
        FileSize = mstream.Length
        mstream.Close()


        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand

        'inserts the record into the storetbl with the corresponding values
        sql = "INSERT INTO STOREtbl([storeName],[storeLocation],[storeContact],[storeSales],[storeLogo]) 
                    VALUES (@storeName,@storeLocation,@storeContact, @storeSales, @storeLogo)"
        cmd.Parameters.AddWithValue("@storeName", CType(txtStoreName.Text, String))
        cmd.Parameters.AddWithValue("@storeLocation", CType(txtStoreLocation.Text, String))
        cmd.Parameters.AddWithValue("@storeContact", CType(txtStoreContact.Text, String))
        cmd.Parameters.AddWithValue("@storeSales", CType(txtStoreSales.Text, Decimal))
        cmd.Parameters.AddWithValue("@storeLogo", arrImage)

        cmd.Connection = con
        cmd.CommandText = sql

        Dim i = cmd.ExecuteNonQuery()
        If i > 0 Then
            'tells that user that ther ecord has been inserted successfully
            MsgBox("Record has been UPDATED successfully!")
        Else
            'tells the user that no record was inserted
            MsgBox("No record has been UPDATED!")
        End If


    End Sub
    'refrehses the table in the datagrid
    Public Sub refreshTable()
        'opens the connection if it is closed
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter

        'selects the corresponding fields in the storetbl
        sql = "Select storeID, storeName, storeLocation, storeContact, storeSales, storeLogo from STOREtbl"
        cmd.Connection = con
        cmd.CommandText = sql
        da.SelectCommand = cmd


        da.Fill(dt)
        'sets the datasource of the datagrid as the dt
        dgvStore.DataSource = dt

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        'calls the sub to refresh the table in the datagrid
        refreshTable()
    End Sub

    Private Sub dgvStore_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStore.CellClick
        'Whenever a cell in the datagrid is clicked, the data of the record will be placed into corresponding controls
        Dim storeID As Integer = dgvStore.CurrentRow.Cells(0).Value
        txtStoreID.Text = storeID
        txtStoreName.Text = dgvStore.CurrentRow.Cells(1).Value
        txtStoreLocation.Text = dgvStore.CurrentRow.Cells(2).Value
        txtStoreContact.Text = dgvStore.CurrentRow.Cells(3).Value
        txtStoreSales.Text = dgvStore.CurrentRow.Cells(4).Value

        Dim picVar = dgvStore.CurrentRow.Cells(5).Value
        If (picVar) IsNot DBNull.Value Then
            Dim bytes As Byte() = dgvStore.CurrentRow.Cells(5).Value
            Dim mstream As New System.IO.MemoryStream(bytes)
            pbStorePic.Image = Image.FromStream(mstream)
        Else
            pbStorePic.Image = pbStorePic.ErrorImage
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'checks if the necessary fields have input
        If txtStoreContact.Text = String.Empty Or txtStoreName.Text = String.Empty Or txtStoreLocation.Text = String.Empty Then
            MsgBox("Please complete necessary fields!")
        Else
            'calls the subs to update and refresh the datagrid
            updateTable()
            refreshTable()
        End If
    End Sub
    'updates the record in the storetable
    Sub updateTable()
        'opens the database connection if it is closed 
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        'saves the image of the picturebox into a variable 
        Dim mstream As New System.IO.MemoryStream()
        pbStorePic.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrImage = mstream.GetBuffer()
        Dim FileSize As UInt32
        FileSize = mstream.Length
        mstream.Close()


        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand


        'updates the record in the store table with the corresponding values
        sql = "UPDATE STOREtbl SET storeName =@storeName, storeLocation=@storeLocation, storeContact = @storeContact, storeSales=@storeSales, storeLogo = @storeLogo WHERE 
                    storeID=" & Val(txtStoreID.Text)
        cmd.Parameters.Add(New OleDbParameter("storeName", CType(txtStoreName.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("storeLocation", CType(txtStoreLocation.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("storeContact", CType(txtStoreContact.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("storeSales", CType(txtStoreSales.Text, Decimal)))
        cmd.Parameters.AddWithValue("@studimg", arrImage)
        cmd.Connection = con
        cmd.CommandText = sql



        Dim i = cmd.ExecuteNonQuery()
        If i > 0 Then
            'tells the user that the record has been successfully updated
            MsgBox("Record has been UPDATED successfully!")

        Else
            'tells the user that no record was updated
            MsgBox("No record has been UPDATED!")
        End If


    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'opens the database connection if it is closed
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand

        'deletes the record from the storetbl with the corresponding store id
        sql = "DELETE * from STOREtbl WHERE storeID=" & Val(txtStoreID.Text) & ""
        cmd.Connection = con
        cmd.CommandText = sql

        Dim i = cmd.ExecuteNonQuery()
        If i > 0 Then
            'tells the user that the record has been deleted
            MsgBox("Record has been DELETED successfully!")
        Else
            'tells the user that no record has been updated
            MsgBox("No record has been DELETED")
        End If

        'calls the sub to refresh the datagridview
        refreshTable()
    End Sub

    Private Sub btnAddImage_Click(sender As Object, e As EventArgs) Handles btnAddImage.Click
        'opens the openfile dialog control
        Try

            Dim OFD As FileDialog = New OpenFileDialog()

            OFD.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif"

            If OFD.ShowDialog() = DialogResult.OK Then
                imgpath = OFD.FileName
                pbStorePic.ImageLocation = imgpath

            End If

            OFD = Nothing

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub btnSaveImage_Click(sender As Object, e As EventArgs)
        'inserts a new record to the storetbl
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand


            con.Open()
            'inserts the record into the storetbl with the corresponding values
            sql = "INSERT INTO STOREtbl([storeName],[storeLocation],[storeContact],[storeSales],[storeLogo]) 
                    VALUES (@storeName,@storeLocation,@storeContact, @storeSales, @storeLogo)"
            cmd.Parameters.AddWithValue("@storeName", CType(txtStoreName.Text, String))
            cmd.Parameters.AddWithValue("@storeLocation", CType(txtStoreLocation.Text, String))
            cmd.Parameters.AddWithValue("@storeContact", CType(txtStoreContact.Text, String))
            cmd.Parameters.AddWithValue("@storeSales", CType(txtStoreSales.Text, Decimal))
            cmd.Parameters.AddWithValue("@storeLogo", arrImage)
            cmd.Connection = con
            cmd.CommandText = sql

            Dim i = cmd.ExecuteNonQuery()
            If i > 0 Then
                'tells the user that the record has been successfully updated
                MsgBox("Record has been UPDATED successfully!")
            Else
                'tells the user that no record was updarted
                MsgBox("No record has been UPDATED!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            'closes the connection
            con.Close()

        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'checks if the textbox is empty Or not a number
        If txtStoreIDReal.Text = String.Empty Or (Not IsNumeric(txtStoreIDReal.Text)) Then
            MsgBox("Invalid input", vbOKOnly + vbCritical)
        Else
            'calls the sub to search the table
            searchTable()
        End If

    End Sub
    'searches the storetbl with the corresponding storeID
    Sub searchTable()
        'opens the database connection if it is closed
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter

        'selects the specified fields from the storetbl with the correpsonding storeID
        sql = "Select storeID, storeName, storeLocation, storeContact, storeSales, storeLogo from STOREtbl WHERE storeID=" & Val(txtStoreIDReal.Text)
        cmd.Connection = con
        cmd.CommandText = sql
        da.SelectCommand = cmd

        'fills the datatable with the query
        da.Fill(dt)

        'sets the source of the datagrid as the datatable
        dgvStore.DataSource = dt

    End Sub


    'closes the form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class