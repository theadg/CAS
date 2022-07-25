Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class formAdmin
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Documents\CASdb.accdb")
    'Dim con As New OleDb.OleDbConnection(My.Settings.CASdbConnectionString)
    Dim adminUN, adminPW As String
    Dim adminID As Integer

    Public Sub New(ByVal varAdminID As String, ByVal varAdminUN As String, ByVal varAdminPW As String)

        ' This call is required by the designer.
        InitializeComponent()
        adminID = varAdminID  'pass this to admin order
        adminUN = varAdminUN
        adminPW = varAdminPW
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub StudentsToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub StudentsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles msMStudents.Click
        Dim formAdminMStudents = New formAdminMStudents
        formAdminMStudents.MdiParent = Me

        formAdminMStudents.Show()
    End Sub



    Private Sub ProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductsToolStripMenuItem.Click
        Dim formAdminMProduct = New formAdminMProduct
        formAdminMProduct.MdiParent = Me

        formAdminMProduct.Show()
    End Sub



    Private Sub homeOrder_Click(sender As Object, e As EventArgs) Handles homeOrder.Click
        Dim formAdminOrder = New formAdminOrder(adminID)
        formAdminOrder.MdiParent = Me
        formAdminOrder.Show()
    End Sub

    Private Sub OrderHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrderHistoryToolStripMenuItem.Click
        Dim formAdminOrderHistory = New formAdminOrderHistory
        formAdminOrderHistory.MdiParent = Me

        formAdminOrderHistory.Show()
    End Sub

    Private Sub formAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkNotif()
    End Sub
    Dim adminOrder As Integer
    Sub checkNotif()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter



        sql = "SELECT adminOrder FROM USERadmin WHERE adminID=" & Val(adminID) & ""
        cmd.Connection = con
            cmd.CommandText = sql

            da.SelectCommand = cmd
            da.Fill(dt)

            adminOrder = dt.Rows(0)(0)
        'DataGridView5.DataSource = dt
        If adminOrder > 0 Then
            Dim formNotify = New formNotify
            formNotify.MdiParent = Me
            formNotify.lblUserType.Text = "Admin"
            formNotify.lbluserID.Text = adminID
            formNotify.Show()
        End If

    End Sub

    Private Sub LogoutAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutAccountToolStripMenuItem.Click
        formLogIn.Show()
        Me.Close()
    End Sub

    Private Sub UpdateAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateAccountToolStripMenuItem.Click
        Dim formAdminAccount = New formAdminAccount
        formAdminAccount.MdiParent = Me

        formAdminAccount.txtID.Text = adminID
        formAdminAccount.txtUsername.Text = adminUN
        formAdminAccount.txtPassword.Text = adminPW
        formAdminAccount.Show()
    End Sub
End Class