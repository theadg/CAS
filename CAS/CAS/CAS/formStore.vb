'THIS FORM WAS CODED BY: CAPILI, MIA
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class formStore
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Documents\CASdb.accdb")
    'Dim con As New OleDb.OleDbConnection(My.Settings.CASdbConnectionString)
    'declarations for image in the databse
    Dim storeID As Integer
    Dim result As Integer
    Dim imgpath As String
    Dim arrImage() As Byte
    Dim sql As String
    Public Sub New(ByVal varStoreID As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        storeID = varStoreID 'pass this to admin order

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub UpdateInventoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateInventoryToolStripMenuItem.Click
        'open Manage Inventory form as child and set the lblstoreid with the corresponding value
        Dim formStoreMInventory = New formStoreMInventory
        formStoreMInventory.MdiParent = Me
        formStoreMInventory.lblStoreID.Text = storeID
        formStoreMInventory.Show()
    End Sub

    Private Sub ManageOrdersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageOrdersToolStripMenuItem.Click
        'open Active Orders form as a child and pass storeID variable 
        Dim formStoreMActiveOrder = New formStoreMActiveOrder(storeID)
        formStoreMActiveOrder.MdiParent = Me

        formStoreMActiveOrder.Show()
    End Sub


    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        'closes the form and shows log in form
        Me.Close()
        formLogIn.Show()
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        'opens Account Form as child and pass storeID variable
        Dim formStoreAccount = New formStoreAccount
        formStoreAccount.MdiParent = Me
        formStoreAccount.txtID.Text = storeID
        formStoreAccount.Show()

    End Sub

    Private Sub ViewSalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewSalesToolStripMenuItem.Click

    End Sub

    Private Sub ViewSalesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ViewSalesToolStripMenuItem1.Click
        'opens Sales Form as child and pass storeID variable
        Dim formStoreSales = New formStoreSales
        formStoreSales.MdiParent = Me
        formStoreSales.lblStoreID.Text = storeID
        formStoreSales.Show()
    End Sub

    Private Sub formStore_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class