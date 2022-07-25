Public Class Form1
    Dim conn As New OleDb.OleDbConnection
    Dim Myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Documents\studentdb.accdb"
    Dim cmd As New OleDb.OleDbCommand
    Dim da As New OleDb.OleDbDataAdapter
    Dim result As Integer
    Dim imgpath As String
    Dim arrImage() As Byte
    Dim sql As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshTable()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Dim OFD As FileDialog = New OpenFileDialog()

            OFD.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif"

            If OFD.ShowDialog() = DialogResult.OK Then
                imgpath = OFD.FileName
                Pic1.ImageLocation = imgpath

            End If

            OFD = Nothing

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try

            Dim mstream As New System.IO.MemoryStream()

            Pic1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrImage = mstream.GetBuffer()
            Dim FileSize As UInt32
            FileSize = mstream.Length
            mstream.Close()

            conn.ConnectionString = Myconnection
            conn.Open()
            sql = "INSERT INTO tblstudent(FNAME,LNAME, COURSE, YR, AGE, EMAIL,studimg) " &
            " VALUES (@a, @LNAME, @COURSE, @YR, @AGE, @EMAIL,@studimg)"

            cmd.Connection = conn
            cmd.CommandText = sql
            cmd.Parameters.AddWithValue("@a", TXTFIRSTNAME.Text)
            cmd.Parameters.AddWithValue("@LNAME", TXTLNAME.Text)
            cmd.Parameters.AddWithValue("@COURSE", TXTCOURSE.Text)
            cmd.Parameters.AddWithValue("@YR", TXTYR.Text)
            cmd.Parameters.AddWithValue("@AGE", TXTAGE.Text)
            cmd.Parameters.AddWithValue("@EMAIL", TXTEMAIL.Text)
            cmd.Parameters.AddWithValue("@studimg", arrImage)
            Dim r As Integer
            r = cmd.ExecuteNonQuery()
            If r > 0 Then
                MsgBox("Student Record hass been Saved!")
            Else
                MsgBox("No record has been saved!")
            End If
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sql = "Select * from tblstudent where FNAME='" & Val(TextBox1.Text) & "' "
        conn.ConnectionString = Myconnection
        conn.Open()
        With cmd
            .Connection = conn
            .CommandText = sql
        End With
        Dim arrImage() As Byte
        Dim publictable As New DataTable
        Try
            da.SelectCommand = cmd
            da.Fill(publictable)
            TXTLNAME.Text = publictable.Rows(0).Item(2)
            TXTFIRSTNAME.Text = publictable.Rows(0).Item(1)
            TXTCOURSE.Text = publictable.Rows(0).Item(3)
            TXTYR.Text = publictable.Rows(0).Item(4)
            TXTAGE.Text = publictable.Rows(0).Item(5)
            TXTEMAIL.Text = publictable.Rows(0).Item(6)
            arrImage = publictable.Rows(0).Item(7)

            Dim mstream As New System.IO.MemoryStream(arrImage)
            Pic1.Image = Image.FromStream(mstream)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            da.Dispose()
            conn.Close()

        End Try
    End Sub
    Public Sub refreshTable()
        Try
            DataGridView1.AutoGenerateColumns = True
            Dim dt As New DataTable

            conn.ConnectionString = Myconnection
            conn.Open()
            sql = "Select * from tblstudent"
            cmd.Connection = conn
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        TXTLNAME.Text = DataGridView1.CurrentRow.Cells(2).Value
        TXTFIRSTNAME.Text = DataGridView1.CurrentRow.Cells(1).Value
        TXTCOURSE.Text = DataGridView1.CurrentRow.Cells(3).Value
        TXTYR.Text = DataGridView1.CurrentRow.Cells(4).Value
        TXTAGE.Text = DataGridView1.CurrentRow.Cells(5).Value
        TXTEMAIL.Text = DataGridView1.CurrentRow.Cells(6).Value
        arrImage = DataGridView1.CurrentRow.Cells(7).Value

        Dim mstream As New System.IO.MemoryStream(arrImage)
        Pic1.Image = Image.FromStream(mstream)
    End Sub
End Class
