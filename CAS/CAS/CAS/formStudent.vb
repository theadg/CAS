Public Class formStudent

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'This will open stall1 form
        With stall1_students
            .TopLevel = False
            Panel1.Controls.Add(stall1_students)
            .BringToFront()
            .Show()
        End With

        'This will hide stall2 whenever clicking the stall1 button
        stall2_students.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'This will open stall2 form
        With stall2_students
            .TopLevel = False
            Panel1.Controls.Add(stall2_students)
            .BringToFront()
            .Show()
        End With

        'This will hide the stall1 whenever clicking the stall2 button
        stall1_students.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        With students_profile
            .TopLevel = False
            Panel2.Controls.Add(students_profile)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class
