Imports System.Data
Imports System.Data.OleDb
Imports System.IO

Public Class formStudentAccount

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Documents\CASdb.accdb")
    Dim result As Integer
    Dim imgpath As String
    Dim arrImage() As Byte
    Dim sql As String

    Private Sub formStudentAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getDetails()
        loadPic()
    End Sub
    Dim studName, studSection, studPassword, studGender, studReligion, studAddress, studCourse As String

    Private Sub btnAddImage_Click(sender As Object, e As EventArgs) Handles btnAddImage.Click
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
        Try
            'pic code
            Dim mstream As New System.IO.MemoryStream()
            If pbStudPic.Image Is Nothing Then
                pbStudPic.Image = pbStudPic.ErrorImage
            End If
            pbStudPic.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrImage = mstream.GetBuffer()
            Dim FileSize As UInt32
            FileSize = mstream.Length
            mstream.Close()
            'end of pic code


            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand

            con.Open()

            sql = "UPDATE USERstudent SET studName=@studName, studSection=@studSection, studPassword=@studPassword,studGender=@studGender,
                    studReligion=@studReligion,studBirthdate=@studBirthdate, studContact=@studContact, studAddress=@studAddress, studCourse=@studCourse,
                    studPhoto=@studPhoto WHERE studID=" & Val(txtID.Text)
            cmd.Parameters.AddWithValue("@studName", CType(txtUsername.Text, String))
            cmd.Parameters.AddWithValue("@studSection", CType(cbSection.Text, String))
            cmd.Parameters.AddWithValue("@studPassword", CType(txtPassword.Text, String))
            cmd.Parameters.AddWithValue("@studGender", CType(cbGender.Text, String))
            cmd.Parameters.AddWithValue("@studReligion", CType(txtReligion.Text, String))
            cmd.Parameters.AddWithValue("@studBirthdate", CType(dtpBirthday.Value.Date, Date))
            cmd.Parameters.AddWithValue("@studContact", CType(txtContact.Text, Integer))
            cmd.Parameters.AddWithValue("@studAddress ", CType(txtAddress.Text, String))
            cmd.Parameters.AddWithValue("@studCourse", CType(cbCourse.Text, String))
            cmd.Parameters.AddWithValue("@studPhoto", arrImage)

            cmd.Connection = con
            cmd.CommandText = sql

            '  txtUsername.Text = studName
            'cbSection.Text = studSection
            'cbGender.Text = studGender
            'txtReligion.Text = studReligion
            'dtpBirthday.Value = studBirthday
            'txtContact.Text = studContact
            'txtAddress.Text = studAddress
            'cbCourse.Text = studCourse
            'txtPassword.Text = studPassword

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

    Dim studContact As Integer
    Dim studBirthday As Date
    Sub getDetails()
        Try


            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            con.Open()
            sql = "Select * from USERstudent WHERE studID=" & Val(txtID.Text)
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)
            studName = dt.Rows(0)(1)
            studSection = dt.Rows(0)(2)
            studPassword = dt.Rows(0)(3)
            studGender = dt.Rows(0)(4)
            studReligion = dt.Rows(0)(5)
            studBirthday = dt.Rows(0)(6)
            studContact = dt.Rows(0)(7)
            studAddress = dt.Rows(0)(8)
            studCourse = dt.Rows(0)(9)

            txtUsername.Text = studName
            cbSection.Text = studSection
            cbGender.Text = studGender
            txtReligion.Text = studReligion
            dtpBirthday.Value = studBirthday
            txtContact.Text = studContact
            txtAddress.Text = studAddress
            cbCourse.Text = studCourse
            txtPassword.Text = studPassword

        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub
    Sub loadPic()
        Try


            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            con.Open()
            sql = "Select studPhoto from USERstudent WHERE studID=" & Val(txtID.Text)
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)


            Dim bytes As Byte() = dt.Rows(0)(0)
            Dim mstream As New System.IO.MemoryStream(bytes)
            pbStudPic.Image = Image.FromStream(mstream)



        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub
End Class