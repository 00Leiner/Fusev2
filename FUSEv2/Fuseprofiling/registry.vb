Imports System.Data.OleDb
Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.IO
Public Class registry
    'setup connection for camera
    Dim camera As VideoCaptureDevice
    Dim bmp As Bitmap

    'db connection
    Dim conn As OleDbConnection = DatabaseConnection.GetConnection()
    'adapting query
    Dim adapter As OleDbDataAdapter = New OleDbDataAdapter("SELECT * FROM infostb", conn)

    ' Declare a global variable to hold the video source object
    Private videoSource As VideoCaptureDevice

    Sub columnvisible(tof)

        'to hide the column in datagridview

        Dim visibleToF As Boolean = tof

        householdmember.Columns(0).Visible = visibleToF
        householdmember.Columns(1).Visible = visibleToF
        householdmember.Columns(2).Visible = visibleToF
        householdmember.Columns(3).Visible = visibleToF
        householdmember.Columns(4).Visible = visibleToF
        householdmember.Columns(5).Visible = visibleToF
        householdmember.Columns(6).Visible = visibleToF
        householdmember.Columns(7).Visible = visibleToF
        householdmember.Columns(8).Visible = visibleToF
        householdmember.Columns(9).Visible = visibleToF
        householdmember.Columns(10).Visible = visibleToF
        householdmember.Columns(11).Visible = visibleToF
    End Sub
    Private Sub residents_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'full row will be selected
        householdmember.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        'clear the inputed text 
        clearText()

        'showing data in datagridview
        Dim table As New DataTable()
        adapter = New OleDbDataAdapter("SELECT * FROM infostb ORDER BY SURNAME ASC", conn)
        adapter.Fill(table)
        householdmember.DataSource = table

        'to hide the default column in datagridview
        columnvisible(False)
        'add one column to hide because in datagridview collection dont have an ID  column 
        householdmember.Columns(12).Visible = False

        'hide ID column
        householdmember.Columns(0).Visible = False
        householdmember.Columns("images").Visible = False
    End Sub

    'Sub for clearing text fields
    Sub clearText()
        surnamebox.Text = ""
        firstbox.Text = ""
        middlebox.Text = ""
        suffixbox.SelectedIndex = -1
        householdbox.Text = ""
        purokbox.SelectedIndex = -1
        birthdatepicker.Value = DateTime.Now.Date
        sexbox.SelectedIndex = -1
        occupationstatusbox.SelectedIndex = -1
        civilstatusbox.SelectedIndex = -1
        contactbox.Text = ""
        PictureBox6.Image = Nothing
    End Sub

    Private Sub captured(sender As Object, eventargs As NewFrameEventArgs)
        'shows the preview from camera
        PictureBox5.Image = DirectCast(eventargs.Frame.Clone(), Bitmap)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'shows the generated image
        PictureBox6.Image = PictureBox5.Image
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        'hold the user if the box is empty
        If String.IsNullOrEmpty(firstbox.Text) Then
            MessageBox.Show("Please fill the First Name.")
            Return
        End If
        If String.IsNullOrEmpty(surnamebox.Text) Then
            MessageBox.Show("Please fill the Surname")
            Return
        End If
        If String.IsNullOrEmpty(middlebox.Text) Then
            MessageBox.Show("Please fill the Middle Name.")
            Return
        End If
        If String.IsNullOrEmpty(householdbox.Text) Then
            MessageBox.Show("Please fill the Household ID.")
            Return
        End If
        If String.IsNullOrEmpty(purokbox.Text) Then
            MessageBox.Show("Please fill the Purok.")
            Return
        End If
        If String.IsNullOrEmpty(civilstatusbox.Text) Then
            MessageBox.Show("Please fill the Civil Status.")
            Return
        End If
        If String.IsNullOrEmpty(sexbox.Text) Then
            MessageBox.Show("Please fill the Gender.")
            Return
        End If
        If String.IsNullOrEmpty(contactbox.Text) Then
            MessageBox.Show("Please fill the Contact No.")
            Return
        End If
        If Not contactbox.Text.StartsWith("09") Then
            MessageBox.Show("Invalid Phone Number")
            Return
        End If
        If contactbox.Text.Length <> 11 Then
            MessageBox.Show("Invalid Phone Number")
        End If
        If PictureBox6.Image Is Nothing Then
            MessageBox.Show("Please take a picture.")

        End If

        'declare variables
        Dim SURNAME As String = surnamebox.Text
        Dim FIRSTNAME As String = firstbox.Text
        Dim MIDDLENAME As String = middlebox.Text
        Dim SUFFIX As String = suffixbox.Text
        Dim HOUSEHOLD As String = householdbox.Text
        Dim PUROK As String = purokbox.Text
        Dim ADDRESS As String = addressbox.Text
        Dim BIRTHDATE As String = birthdatepicker.Text
        Dim SEX As String = sexbox.Text
        Dim OCCUPATIONSTATUS As String = occupationstatusbox.Text
        Dim CIVILSTATUS As String = civilstatusbox.Text
        Dim CONTACT As String = contactbox.Text

        Dim ms As New MemoryStream()
        Dim imageBytes() As Byte = ms.ToArray()


        'where to insert data
        Dim insertquery As String = "INSERT INTO infostb (SURNAME, FIRSTNAME, MIDDLENAME, SUFFIX, HOUSEHOLD, PUROK, ADDRESS, BIRTHDATE, SEX, OCCUPATIONSTATUS, CIVILSTATUS, CONTACT, IMAGES) " &
                            "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"

        'assigning data
        Using cmdInsert As New OleDbCommand(insertquery, conn)
            Try
                'inserting data
                cmdInsert.Parameters.AddWithValue("@SURNAME", SURNAME)
                cmdInsert.Parameters.AddWithValue("@FIRSTNAME", FIRSTNAME)
                cmdInsert.Parameters.AddWithValue("@MIDDLENAME", MIDDLENAME)
                cmdInsert.Parameters.AddWithValue("@SUFFIX", SUFFIX)
                cmdInsert.Parameters.AddWithValue("@HOUSEHOLD", HOUSEHOLD)
                cmdInsert.Parameters.AddWithValue("@PUROK", PUROK)
                cmdInsert.Parameters.AddWithValue("@ADDRESS", ADDRESS)
                cmdInsert.Parameters.AddWithValue("@BIRTHDATE", BIRTHDATE)
                cmdInsert.Parameters.AddWithValue("@SEX", SEX)
                cmdInsert.Parameters.AddWithValue("@OCCUPATIONSTATUS", OCCUPATIONSTATUS)
                cmdInsert.Parameters.AddWithValue("@CIVILSTATUS", CIVILSTATUS)
                cmdInsert.Parameters.AddWithValue("@CONTACT", CONTACT)
                cmdInsert.Parameters.Add("@images", OleDbType.VarBinary).Value = imageBytes
                cmdInsert.ExecuteNonQuery()

                'message box if the insertion is successfully inserted
                MessageBox.Show("RECORD INSERTED SUCCESSFULLY.", "INSERT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If PictureBox6.Image Is Nothing = False Then
                    PictureBox6.Image.Save(ms, Imaging.ImageFormat.Jpeg)
                End If
                'clear the inputed text 
                clearText()

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)

            End Try

        End Using


    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        'clear the inputed text 
        clearText()
    End Sub

    'condition in imputing data
    Private Sub surnamebox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles surnamebox.KeyPress
        ' Check if the pressed key is a space or a letter or the backspace key
        If e.KeyChar = " " OrElse Char.IsLetter(e.KeyChar) OrElse e.KeyChar = ChrW(Keys.Back) Then
            ' Allow spaces, letters, and backspace
            e.Handled = False
        Else
            ' Block other characters
            e.Handled = True
        End If
    End Sub
    Private Sub firstbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles firstbox.KeyPress
        ' Check if the pressed key is a space or a letter or the backspace key
        If e.KeyChar = " " OrElse Char.IsLetter(e.KeyChar) OrElse e.KeyChar = ChrW(Keys.Back) Then
            ' Allow spaces, letters, and backspace
            e.Handled = False
        Else
            ' Block other characters
            e.Handled = True
        End If
    End Sub
    Private Sub middlebox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles middlebox.KeyPress
        ' Check if the pressed key is a space or a letter or the backspace key
        If e.KeyChar = " " OrElse Char.IsLetter(e.KeyChar) OrElse e.KeyChar = ChrW(Keys.Back) Then
            ' Allow spaces, letters, and backspace
            e.Handled = False
        Else
            ' Block other characters
            e.Handled = True
        End If
    End Sub
    Private Sub householdbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles householdbox.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
    Private Sub contactbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles contactbox.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = ControlChars.Back Then
            e.Handled = True
        End If

    End Sub


    Private Sub householdbox_TextChanged(sender As Object, e As EventArgs) Handles householdbox.TextChanged
        'searchvalue variable 
        Dim searchValue As String = householdbox.Text
        'selecting colums
        Dim query As String = "SELECT * FROM infostb WHERE HOUSEHOLD LIKE '%" & searchValue & "%'"
        'use db
        Using command As New OleDbCommand(query, conn)
            'adapting query
            adapter = New OleDbDataAdapter(command)
            Dim table As New DataTable()
            'showing data in datagridview
            adapter.Fill(table)
            If table.Rows.Count > 0 Then
                householdmember.DataSource = table

                'to hide the column in datagridview
                columnvisible(False)
                'add one column to hide because in datagridview collection dont have an ID  column 
                householdmember.Columns(12).Visible = False
            Else
                householdmember.DataSource = Nothing ' Clear the datasource if no data found

                'to show the column in datagridview
                columnvisible(True)
            End If
        End Using
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim logout As DialogResult = MessageBox.Show("Are you sure you want to logout?", "logout", MessageBoxButtons.YesNo)
        If logout = DialogResult.Yes Then
            Me.Hide()
            Form1.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'hide this form
        Me.Hide()
        'back to dashboard
        dashboard.Show()
    End Sub

    Private Sub residentsbtn_Click(sender As Object, e As EventArgs) Handles residentsbtn.Click
        'hide this form
        Me.Hide()
        'back to dashboard
        residents.Show()
    End Sub

    Private Sub demographicsbtn_Click(sender As Object, e As EventArgs) Handles demographicsbtn.Click
        'hide this form
        Me.Hide()
        'back to dashboard
        demographics.Show()
    End Sub

    Private Sub registry_Load(sender As Object, e As EventArgs) Handles Me.Load
        'to show directly the permission to open camera
        Me.Show()
        Dim cameras As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
        If cameras.ShowDialog() = Windows.Forms.DialogResult.OK Then
            camera = cameras.VideoDevice
            AddHandler camera.NewFrame, New NewFrameEventHandler(AddressOf captured)
            camera.Start()
        Else
            MessageBox.Show("No camera/video devices found.")
        End If

    End Sub

    Private Sub birthdatepicker_ValueChanged(sender As Object, e As EventArgs) Handles birthdatepicker.ValueChanged
        ' Calculate the age based on the selected date
        Dim selectedDate As DateTime = birthdatepicker.Value
        Dim age As Integer = DateTime.Now.Year - selectedDate.Year

        ' Check if the birthday has already passed this year
        If DateTime.Now < selectedDate.AddYears(age) Then
            age -= 1 ' Reduce the age by 1 if the birthday hasn't occurred yet this year
        End If

    End Sub


End Class