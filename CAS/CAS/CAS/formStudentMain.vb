''THIS FORM WAS CODED BY: URETA, KISSES
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class formStudentMain

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Documents\CASdb.accdb")
    'Dim con As New OleDb.OleDbConnection(My.Settings.CASdbConnectionString)
    Dim studID, studOrder As Integer
    Public Sub New(ByVal varStudID As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        studID = varStudID 'pass this to admin order

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub formStudentMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'check if there is notification prompt
        checkNotif()
    End Sub
    'check if there is notification prompt
    Sub checkNotif()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter
        'get studorder field from userstudent table with corresponding student id
        sql = "SELECT studOrder FROM USERstudent WHERE studID=" & Val(studID)
        cmd.Connection = con
        cmd.CommandText = sql

        da.SelectCommand = cmd
        da.Fill(dt)

        studOrder = dt.Rows(0)(0)

        'if studorder field has a value greater than 0, open and pass values to notification form
        If studOrder > 0 Then
            Dim formNotify = New formNotify
            formNotify.MdiParent = Me
            formNotify.lblUserType.Text = "Student"
            formNotify.lbluserID.Text = studID
            formNotify.Show()
        End If
    End Sub
    Private Sub OrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrderToolStripMenuItem.Click
        'open OrderForm as child and pass on studID
        Dim formStudentOrder = New formStudentOrder(studID)
        formStudentOrder.MdiParent = Me
        formStudentOrder.Show()
    End Sub

    Private Sub OrderHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrderHistoryToolStripMenuItem.Click
        'Open Order History as Child and pass on Stud ID
        Dim formStudentOrderHistory = New formStudentOrderHistory
        formStudentOrderHistory.MdiParent = Me


        formStudentOrderHistory.lblUserID.Text = studID
        formStudentOrderHistory.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        'Open Account form and pass on studID
        Dim formStudentAccount = New formStudentAccount
        formStudentAccount.MdiParent = Me

        formStudentAccount.txtID.Text = studID
        formStudentAccount.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        'Close form and open log in  forrm
        Me.Close()
        formLogIn.Show()
    End Sub
End Class