Imports System.Data
Imports System.Data.OleDb

Public Class students
    Dim con As New OleDb.OleDbConnection(My.Settings.CASFOODdbConnectionString)
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
