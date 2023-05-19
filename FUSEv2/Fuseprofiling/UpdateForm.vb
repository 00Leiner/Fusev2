Imports System.Data.OleDb
Public Class UpdateForm
    'call GetConnection() from dbconnection.vb
    Dim conn As OleDbConnection = DatabaseConnection.GetConnection()
    'adapting query
    Dim adapter As OleDbDataAdapter = New OleDbDataAdapter("SELECT * FROM infostb", conn)
    'var for command
    Dim comm As OleDbCommand
    'variable
    Private _ID As Integer
    Private _surname As String
    Private _firstname As String
    Private _middlename As String
    Private _suffix As String
    Private _household As String
    Private _purok As String
    Private _address As String
    Private _birthdate As String
    Private _sex As String
    Private _OCCUPATIONSTATUS As String
    Private _civilstatus As String
    Private _contact As String


    Sub returndefault()
        ' asign the textbox values using the received data from resident datagridview
        surnamebox.Text = _surname
        firstbox.Text = _firstname
        middlebox.Text = _middlename
        suffixbox.Text = _suffix
        householdbox.Text = _household
        purokbox.Text = _purok
        addressbox.Text = _address
        birthdatepicker.Text = _birthdate
        sexbox.Text = _sex
        occupationstatusbox.Text = _OCCUPATIONSTATUS
        civilstatusbox.Text = _civilstatus
        contactbox.Text = _contact
    End Sub
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
    Public Sub New(id As Integer, surname As String, firstname As String, middlename As String, suffix As String, household As String, purok As String, address As String, birthdate As String, sex As String, OCCUPATIONSTATUS As String, civilstatus As String, contact As String)
        InitializeComponent()
        ' Store the received data in the private variables'
        _ID = id
        _surname = surname
        _firstname = firstname
        _middlename = middlename
        _suffix = suffix
        _household = household
        _purok = purok
        _address = address
        _birthdate = birthdate
        _sex = sex
        _OCCUPATIONSTATUS = OCCUPATIONSTATUS
        _civilstatus = civilstatus
        _contact = contact
        ' Set the textbox values using the received data from resident datagridview
        returndefault()
    End Sub

    'update button
    Private Sub updatebtn_Click(sender As Object, e As EventArgs) Handles updatebtn.Click
        'hold the user if the box is empty
        If String.IsNullOrEmpty(surnamebox.Text) Then
            MessageBox.Show("Please fill the Surname")
            Return
        End If
        If String.IsNullOrEmpty(firstbox.Text) Then
            MessageBox.Show("Please fill the First Name.")
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

        comm = New OleDbCommand
        comm.Connection = conn
        Try
            comm.CommandText = "UPDATE infostb SET SURNAME='" & surnamebox.Text & "', FIRSTNAME='" & firstbox.Text & "', MIDDLENAME='" & middlebox.Text & "', SUFFIX='" & suffixbox.Text & "', HOUSEHOLD='" & householdbox.Text & "', PUROK='" & purokbox.Text & "', ADDRESS='" & addressbox.Text & "', BIRTHDATE='" & birthdatepicker.Text & "', SEX='" & sexbox.Text & "', OCCUPATIONSTATUS='" & occupationstatusbox.Text & "', CIVILSTATUS='" & civilstatusbox.Text & "', CONTACT='" & contactbox.Text & "' WHERE ID=" & _ID

            comm.ExecuteNonQuery()


            'to hide the default column in datagridview
            columnvisible(False)
            'add one column to hide because in datagridview collection dont have an ID  column 
            householdmember.Columns(12).Visible = False

            Dim table As New DataTable()
            adapter = New OleDbDataAdapter("SELECT * FROM infostb ORDER BY SURNAME ASC", conn)
            adapter.Fill(table)
            householdmember.DataSource = table

            'message box if the insertion is successfully inserted
            MessageBox.Show("RECORD UPDATED SUCCESSFULLY.", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

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

    'showing their family in datagridview
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

    'undo
    Private Sub undo_Click(sender As Object, e As EventArgs) Handles undo.Click
        ' Set the textbox values using the received data from resident datagridview
        returndefault()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'hide this form
        Me.Hide()
        'back to dashboard
        dashboard.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim logout As DialogResult = MessageBox.Show("Are you sure you want to logout?", "logout", MessageBoxButtons.YesNo)
        If logout = DialogResult.Yes Then
            Me.Hide()
            Form1.Show()
        End If
    End Sub

    Private Sub create_Click(sender As Object, e As EventArgs) Handles create.Click
        'hide this form
        Me.Hide()
        'back to dashboard
        registry.Show()
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
End Class