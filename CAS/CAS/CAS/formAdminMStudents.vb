Imports System.Data
Imports System.Data.OleDb
Imports System.IO

Public Class formAdminMStudents
    'Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Documents\CASdb.accdb")
    Dim con As New OleDb.OleDbConnection(My.Settings.CASdbConnectionString)
    Private Sub formAdminMStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            con.Open()
            sql = "Select studID, studName, studCourse, studSection, studGender, studReligion, studBirthdate, studContact,studAddress,studPhoto from USERstudent"
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)
            dgvStudent.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub

    Private Sub dgvStudent_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudent.CellClick
        Me.Text = dgvStudent.CurrentRow.Cells(0).Value
        txtStudID.Text = dgvStudent.CurrentRow.Cells(0).Value
        txtStudName.Text = dgvStudent.CurrentRow.Cells(1).Value
        cbStudCourse.Text = dgvStudent.CurrentRow.Cells(2).Value
        txtStudSection.Text = dgvStudent.CurrentRow.Cells(3).Value '3
        cbStudentGender.Text = dgvStudent.CurrentRow.Cells(4).Value
        txtStudReligion.Text = dgvStudent.CurrentRow.Cells(5).Value
        dtpStudBirthday.Value = dgvStudent.CurrentRow.Cells(6).Value          'DATE ERROR
        txtStudContact.Text = dgvStudent.CurrentRow.Cells(7).Value
        txtStudAddress.Text = dgvStudent.CurrentRow.Cells(8).Value
        'pbStudPic.Image = dgvStudent.CurrentRow.Cells(9).Value

        'magical line of code right here for getting image from db
        'Dim bytes As Byte() = dgvStudent.CurrentRow.Cells(9).Value
        'Dim mstream As New System.IO.MemoryStream(bytes)
        'pbStudPic.Image = Image.FromStream(mstream)


    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand

            con.Open()
            'studID, studName, studCourse, studSection, studGender, studReligion, studBirthdate, studContact,studAddress
            sql = "UPDATE USERstudent SET studName ='" & txtStudName.Text & "', studCourse='" & cbStudCourse.Text & "', " &
                " studSection ='" & txtStudSection.Text & "', " & " studGender='" & cbStudentGender.Text & "', " &
                 " studReligion ='" & txtStudReligion.Text & "', " & "studBirthdate='" & dtpStudBirthday.Value.Date & "', " &
                  " studContact ='" & txtStudContact.Text & "', " & " studAddress='" & txtStudAddress.Text &
                    "' " & " WHERE studID=" & Val(Me.Text) & ""
            cmd.Connection = con
            cmd.CommandText = sql



            Dim i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MsgBox("Record has been UPDATED successfully!")
                Dim dt As New DataTable
                Dim da As New OleDbDataAdapter
                sql = "Select studID, studName, studCourse, studSection, studGender, studReligion, studBirthdate, studContact,studAddress from USERstudent"
                cmd.Connection = con
                cmd.CommandText = sql
                da.SelectCommand = cmd

                da.Fill(dt)
                dgvStudent.DataSource = dt
            Else
                MsgBox("No record has been UPDATED!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            con.Open()
            sql = "Select studID, studName, studCourse, studSection, studGender, studReligion, studBirthdate, studContact,studAddress from USERstudent"
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)
            dgvStudent.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub
    Dim cmd As New OleDb.OleDbCommand
    Dim da As New OleDb.OleDbDataAdapter
    Dim result As Integer
    Dim imgpath As String
    Dim arrImage() As Byte
    Dim sql As String
    Private Sub btnAddImage_Click(sender As Object, e As EventArgs) Handles btnAddImage.Click



    End Sub

    Private Sub btnSaveImage_Click(sender As Object, e As EventArgs) Handles btnSaveImage.Click

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand

            con.Open()
            sql = "DELETE * from USERstudent WHERE studID=" & Val(Me.Text) & "" 'make sure where condition 32:02
            cmd.Connection = con
            cmd.CommandText = sql

            Dim i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MsgBox("Record has been UPDATED successfully!")
            Else
                MsgBox("No record has been UPDATED!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            con.Close()

        End Try
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click

        'studID, studName, studCourse, studSection, studGender, studReligion, studBirthdate, studContact,studAddress from USERstudent
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand


            con.Open()
            sql = "INSERT INTO USERstudent([studName],[studCourse],[studSection],[studGender],[studReligion],[studBirthdate],[studContact],[studAddress]) VALUES (?,?,?,?,?,?,?,?)"
            cmd.Parameters.Add(New OleDbParameter("studName", CType(txtStudName.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("studCourse", CType(cbStudCourse.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("studSection", CType(txtStudSection.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("studGender", CType(cbStudentGender.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("studReligion", CType(txtStudReligion.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("studBirthdate", CType(dtpStudBirthday.Value.Date, Date)))
            cmd.Parameters.Add(New OleDbParameter("studContact", CType(txtStudContact.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("studAddress ", CType(txtStudAddress.Text, String)))



            cmd.Connection = con
            cmd.CommandText = sql

            Dim i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MsgBox("Record has been UPDATED successfully!")
            Else
                MsgBox("No record has been UPDATED!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            con.Close()

        End Try
    End Sub

End Class