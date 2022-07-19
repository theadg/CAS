Public Class formAdmin


    Private Sub StudentsToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub StudentsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles msMStudents.Click
        Dim formAdminMStudents = New formAdminMStudents
        formAdminMStudents.MdiParent = Me

        formAdminMStudents.Show()
    End Sub
End Class