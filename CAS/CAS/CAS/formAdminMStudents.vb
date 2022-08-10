'THIS FORM WAS CODED BY: URETA, KISSES
Imports System.Data
Imports System.Data.OleDb
Imports System.IO


Public Class formAdminMStudents
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Documents\CASdb.accdb")
    'Dim con As New OleDb.OleDbConnection(My.Settings.CASdbConnectionString)
    Private Sub formAdminMStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'displays the user student table with the corresponding fields on load
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
        'whenenever a cell in the datagrid is clicked, the data of the record will be placed into corresponding controls
        Dim studID As Integer = dgvStudent.CurrentRow.Cells(0).Value
        txtStudID.Text = studID

        txtStudID.Text = dgvStudent.CurrentRow.Cells(0).Value
        txtStudName.Text = dgvStudent.CurrentRow.Cells(1).Value
        cbStudCourse.Text = dgvStudent.CurrentRow.Cells(2).Value
        txtStudSection.Text = dgvStudent.CurrentRow.Cells(3).Value
        cbStudentGender.Text = dgvStudent.CurrentRow.Cells(4).Value
        txtStudReligion.Text = dgvStudent.CurrentRow.Cells(5).Value
        dtpStudBirthday.Value = dgvStudent.CurrentRow.Cells(6).Value
        txtStudContact.Text = dgvStudent.CurrentRow.Cells(7).Value
        txtStudAddress.Text = dgvStudent.CurrentRow.Cells(8).Value



        Dim bytes As Byte() = dgvStudent.CurrentRow.Cells(9).Value
        Dim mstream As New System.IO.MemoryStream(bytes)
        pbStudPic.Image = Image.FromStream(mstream)



    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'checks if the required input is complete
        If txtStudName.Text = String.Empty Or cbStudCourse.Text = String.Empty Or txtStudSection.Text = String.Empty Or cbStudentGender.Text = String.Empty Or txtStudReligion.Text = String.Empty Or txtStudContact.Text = String.Empty Or (dtpStudBirthday.Value.Date >= Date.Now) Or txtStudAddress.Text = String.Empty Then
            MsgBox("Complete neccessary input")
        Else
            'updates the record in the userstudent table and refreshes the datagrid
            updateTable()
            refreshTable()
        End If

    End Sub
    'updates a record in the user student
    Sub updateTable()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim mstream As New System.IO.MemoryStream()
        If pbStudPic.Image Is Nothing Then
            pbStudPic.Image = pbStudPic.ErrorImage
        End If
        pbStudPic.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrImage = mstream.GetBuffer()
        Dim FileSize As UInt32
        FileSize = mstream.Length
        mstream.Close()
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand

        'con.Open()

        'updates the record in the userstudent with the corresponding fields and student id
        sql = "UPDATE USERstudent SET studName=@studName, studCourse=@studCourse, studSection=@studsection, studGender=@studGender, 
            studReligion=@studReligion,  studBirthdate=@studBirthdate, studContact=@studContact, studAddress=@studAddress , studPhoto=@studPhoto
            WHERE studID=" & Val(txtStudID.Text)
        cmd.Parameters.AddWithValue("@studName", CType(txtStudName.Text, String))
        cmd.Parameters.AddWithValue("@studCourse", CType(cbStudCourse.Text, String))
        cmd.Parameters.AddWithValue("@studSection", CType(txtStudSection.Text, String))
        cmd.Parameters.AddWithValue("@studGender", CType(cbStudentGender.Text, String))
        cmd.Parameters.AddWithValue("@studReligion", CType(txtStudReligion.Text, String))
        cmd.Parameters.AddWithValue("@studBirthdate", CType(dtpStudBirthday.Value.Date, Date))
        cmd.Parameters.AddWithValue("@studContact", CType(txtStudContact.Text, String))
        cmd.Parameters.AddWithValue("@studAddress ", CType(txtStudAddress.Text, String))
        cmd.Parameters.AddWithValue("@studPhoto", arrImage)

        cmd.Connection = con
        cmd.CommandText = sql



        Dim i = cmd.ExecuteNonQuery()
        If i > 0 Then
            MsgBox("Student Record has been UPDATED successfully!")

        Else
            MsgBox("No student record has been UPDATED!")
        End If


    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        'refreshes the datragrid
        refreshTable()
    End Sub
    'declarations for the image
    Dim cmd As New OleDb.OleDbCommand
    Dim da As New OleDb.OleDbDataAdapter
    Dim result As Integer
    Dim imgpath As String
    Dim arrImage() As Byte
    Dim sql As String
    Private Sub btnAddImage_Click(sender As Object, e As EventArgs) Handles btnAddImage.Click
        'opens the open file dialog
        Try

            Dim OFD As FileDialog = New OpenFileDialog()

            OFD.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif"

            If OFD.ShowDialog() = DialogResult.OK Then
                imgpath = OFD.FileName
                pbStudPic.ImageLocation = imgpath

            End If

            OFD = Nothing

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try


    End Sub



    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand

        'deletes the record in the user student table with the corresponding student id
        sql = "DELETE * from USERstudent WHERE studID=" & Val(txtStudID.Text) & ""
        cmd.Connection = con
            cmd.CommandText = sql

            Dim i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MsgBox("Record has been UPDATED successfully!")
            Else
                MsgBox("No record has been UPDATED!")
            End If

        'refrrhes the datagrid
        refreshTable()

    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        'checks if the required fields have input
        If txtStudName.Text = String.Empty Or cbStudCourse.Text = String.Empty Or txtStudSection.Text = String.Empty Or cbStudentGender.Text = String.Empty Or txtStudReligion.Text = String.Empty Or txtStudContact.Text = String.Empty Or (dtpStudBirthday.Value.Date >= Date.Now) Or txtStudAddress.Text = String.Empty Then
            MsgBox("Complete neccessary input")
        Else
            'inserts the record into the database and refreshes the datagrid
            insertTable()
            refreshTable()
        End If

    End Sub
    'inserts a record to the user student table 
    Sub insertTable()

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        'saves the image of the picturebox into a variable 
        Dim mstream As New System.IO.MemoryStream()
        If pbStudPic.Image Is Nothing Then
            pbStudPic.Image = pbStudPic.ErrorImage
        End If
        pbStudPic.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrImage = mstream.GetBuffer()
        Dim FileSize As UInt32
        FileSize = mstream.Length
        'mstream.Close()
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand


        'inserts the corresponding fields into the user student table
        sql = "INSERT INTO USERstudent([studName],[studCourse],[studSection],[studGender],[studReligion],[studBirthdate],[studContact],[studAddress],[studPhoto]) 
                    VALUES (@studName,@studCourse,@studSection,@studGender,@studReligion,@studBirthdate,@studContact,@studAddress, @studPhoto)"
        cmd.Parameters.Add(New OleDbParameter("@studName", CType(txtStudName.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("@studCourse", CType(cbStudCourse.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("@studSection", CType(txtStudSection.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("@studGender", CType(cbStudentGender.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("@studReligion", CType(txtStudReligion.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("@studBirthdate", CType(dtpStudBirthday.Value.Date, Date)))
        cmd.Parameters.Add(New OleDbParameter("@studContact", CType(txtStudContact.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("@studAddress", CType(txtStudAddress.Text, String)))
        cmd.Parameters.AddWithValue("@studPhoto", arrImage)


        cmd.Connection = con
        cmd.CommandText = sql

        Dim i = cmd.ExecuteNonQuery()
        If i > 0 Then
            'successful update
            MsgBox("Record has been UPDATED successfully!")

        Else
            'unsuccessful update
            MsgBox("No record has been UPDATED!")
        End If


    End Sub
    'refreshes the table in the datagrid view
    Sub refreshTable()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
        'selects the corresponding fields from the USERstudent table
        sql = "Select studID, studName, studCourse, studSection, studGender, studReligion, studBirthdate, studContact,studAddress,studPhoto from USERstudent"
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

        da.Fill(dt)
        'sets the source of the datagrid view ass the dt
        dgvStudent.DataSource = dt

    End Sub

    Private Sub dtpStudBirthday_ValueChanged(sender As Object, e As EventArgs) Handles dtpStudBirthday.ValueChanged
        'validates the value of the date time picker to be less than the date today
        If (dtpStudBirthday.Value.Date >= Date.Now) Then
            MsgBox("invalid date")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'closes the form
        Me.Close()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'checks if the required fields have input
        If txtStoreIDReal.Text = String.Empty Or (Not IsNumeric(txtStoreIDReal.Text)) Then
            MsgBox("Invalid input", vbOKOnly + vbCritical)
        Else
            'updates the table in the datagrid with the corresponding student id
            refreshTableSpecific()
        End If
    End Sub

    Sub refreshTableSpecific()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
        'con.Open()
        sql = "Select studID, studName, studCourse, studSection, studGender, studReligion, studBirthdate, studContact,studAddress,studPhoto from USERstudent WHERE studID=" & Val(txtStoreIDReal.Text)
        cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)
            dgvStudent.DataSource = dt
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        'con.Close()
    End Sub
End Class