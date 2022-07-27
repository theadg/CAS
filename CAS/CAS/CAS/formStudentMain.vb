Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class formStudentMain

    'Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Documents\CASdb.accdb")
    Dim con As New OleDb.OleDbConnection(My.Settings.CASdbConnectionString)
    Dim studID, studOrder As Integer
    Public Sub New(ByVal varStudID As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        studID = varStudID 'pass this to admin order

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub formStudentMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkNotif()
    End Sub
    Sub checkNotif()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter



        sql = "SELECT studOrder FROM USERstudent WHERE studID=" & Val(studID)
        cmd.Connection = con
        cmd.CommandText = sql

        da.SelectCommand = cmd
        da.Fill(dt)
        'note
        studOrder = dt.Rows(0)(0)
        'DataGridView5.DataSource = dt
        If studOrder > 0 Then
            Dim formNotify = New formNotify
            formNotify.MdiParent = Me
            formNotify.lblUserType.Text = "Student"
            formNotify.lbluserID.Text = studID
            formNotify.Show()
        End If
    End Sub
    Private Sub OrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrderToolStripMenuItem.Click
        Dim formStudentOrder = New formStudentOrder(studID)
        formStudentOrder.MdiParent = Me
        formStudentOrder.Show()
    End Sub

    Private Sub OrderHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrderHistoryToolStripMenuItem.Click
        Dim formStudentOrderHistory = New formStudentOrderHistory
        formStudentOrderHistory.MdiParent = Me


        formStudentOrderHistory.lblUserID.Text = studID
        formStudentOrderHistory.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        Dim formStudentAccount = New formStudentAccount
        formStudentAccount.MdiParent = Me

        formStudentAccount.txtID.Text = studID
        formStudentAccount.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Close()
        formLogIn.Show()
    End Sub
End Class