Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class formStore
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Documents\CASdb.accdb")
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
        Dim formStoreMInventory = New formStoreMInventory
        formStoreMInventory.MdiParent = Me
        formStoreMInventory.lblStoreID.Text = storeID
        formStoreMInventory.Show()
    End Sub

    Private Sub ManageOrdersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageOrdersToolStripMenuItem.Click
        Dim formStoreMActiveOrder = New formStoreMActiveOrder(storeID)
        formStoreMActiveOrder.MdiParent = Me
        'formStoreMActiveOrder.lblStoreID.Text = storeID
        formStoreMActiveOrder.Show()
    End Sub

    Private Sub formStore_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Close()
        formLogIn.Show()
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        Dim formStoreAccount = New formStoreAccount
        formStoreAccount.MdiParent = Me
        formStoreAccount.txtID.Text = storeID
        formStoreAccount.Show()

    End Sub

    Private Sub ViewSalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewSalesToolStripMenuItem.Click

    End Sub

    Private Sub ViewSalesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ViewSalesToolStripMenuItem1.Click
        Dim formStoreSales = New formStoreSales
        formStoreSales.MdiParent = Me
        formStoreSales.lblStoreID.text = storeID
        formStoreSales.Show()
    End Sub

    Private Sub InventoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventoryToolStripMenuItem.Click

    End Sub
End Class