'THIS FORM WAS CODED BY: DE GUZMAN, ANDREW
Imports System.Data
Imports System.Data.OleDb
Imports System.IO

Public Class formStudentAccount

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Documents\CASdb.accdb")
    'Dim con As New OleDb.OleDbConnection(My.Settings.CASdbConnectionString)
    Dim result As Integer
    Dim imgpath As String
    Dim arrImage() As Byte
    Dim sql As String

    Private Sub formStudentAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'get student info 
        getDetails()
        'load student pic
        loadPic()
    End Sub
    Dim studName, studSection, studPassword, studGender, studReligion, studAddress, studCourse As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'close form
        Me.Close()
    End Sub

    Private Sub btnAddImage_Click(sender As Object, e As EventArgs) Handles btnAddImage.Click
        'open open file dialog form
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
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
        'update userstudent table with corresponding values and fields and studentid
        sql = "UPDATE USERstudent SET studName=@studName, studSection=@studSection, studPassword=@studPassword,studGender=@studGender,
                    studReligion=@studReligion,studBirthdate=@studBirthdate, studContact=@studContact, studAddress=@studAddress, studCourse=@studCourse,
                    studPhoto=@studPhoto WHERE studID=" & Val(txtID.Text)
            cmd.Parameters.AddWithValue("@studName", CType(txtUsername.Text, String))
            cmd.Parameters.AddWithValue("@studSection", CType(txtSection.Text, String))
            cmd.Parameters.AddWithValue("@studPassword", CType(txtPassword.Text, String))
            cmd.Parameters.AddWithValue("@studGender", CType(cbGender.Text, String))
            cmd.Parameters.AddWithValue("@studReligion", CType(txtReligion.Text, String))
            cmd.Parameters.AddWithValue("@studBirthdate", CType(dtpBirthday.Value.Date, Date))
            cmd.Parameters.AddWithValue("@studContact", CType(txtContact.Text, String))
            cmd.Parameters.AddWithValue("@studAddress ", CType(txtAddress.Text, String))
            cmd.Parameters.AddWithValue("@studCourse", CType(cbCourse.Text, String))
            cmd.Parameters.AddWithValue("@studPhoto", arrImage)

            cmd.Connection = con
            cmd.CommandText = sql



            Dim i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MsgBox("Record has been UPDATED successfully!")

            Else
                MsgBox("No record has been UPDATED!")
            End If

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'Finally
        '    con.Close()
        'End Try
    End Sub

    Dim studContact As String
    Dim studBirthday As Date
    'get info of student
    Sub getDetails()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter
        'con.Open()
        'select all fields from user student with the corresponding student id
        sql = "Select * from USERstudent WHERE studID=" & Val(txtID.Text)
        cmd.Connection = con
        cmd.CommandText = sql
        da.SelectCommand = cmd

        da.Fill(dt)
        'put the data of the record into corresponding variables
        studName = dt.Rows(0)(1)
        studSection = dt.Rows(0)(2)
        studPassword = dt.Rows(0)(3)
        studGender = dt.Rows(0)(4)
        studReligion = dt.Rows(0)(5)
        studBirthday = dt.Rows(0)(6)
        studContact = dt.Rows(0)(7)
        studAddress = dt.Rows(0)(8)
        studCourse = dt.Rows(0)(9)

        'put the corresponding variables into corresponding controlsd
        txtUsername.Text = studName
        txtSection.Text = studSection
        cbGender.Text = studGender
        txtReligion.Text = studReligion
        dtpBirthday.Value = studBirthday
        txtContact.Text = studContact
        txtAddress.Text = studAddress
        cbCourse.Text = studCourse
        txtPassword.Text = studPassword


    End Sub
    'get pic of student
    Sub loadPic()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If


        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter
        'con.Open()
        'select studphoto from userstudent with coiresponding student id
        sql = "Select studPhoto from USERstudent WHERE studID=" & Val(txtID.Text)
        cmd.Connection = con
        cmd.CommandText = sql
        da.SelectCommand = cmd

        da.Fill(dt)

        'set picturebox image from database
        Dim bytes As Byte() = dt.Rows(0)(0)
        Dim mstream As New System.IO.MemoryStream(bytes)
        pbStudPic.Image = Image.FromStream(mstream)




    End Sub
End Class