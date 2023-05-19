Imports System.Data.OleDb

Public Class profile
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
    Private _selectedImage As Image


    Public Sub New(id As Integer, surname As String, firstname As String, middlename As String, suffix As String, household As String, purok As String, address As String, birthdate As String, sex As String, OCCUPATIONSTATUS As String, civilstatus As String, contact As String, selectedImage As Image)
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
        _selectedImage = selectedImage

        ' asign the textbox values using the received data from resident datagridview
        lblsname.Text = _surname
        lblfname.Text = _firstname
        lblhousehold.Text = _household
        lbladdress.Text = _address
        lblbirthdate.Text = _birthdate
        lblsex.Text = _sex
        lbloccupation.Text = _OCCUPATIONSTATUS
        lblcivil.Text = _civilstatus
        lblcontact.Text = _contact
        lblsuffix.Text = _suffix
        lblmname.Text = _middlename
        vbcvbcv.Text = _purok
        'Display the image in the PictureBox
        PictureBox1.Image = _selectedImage

    End Sub



    Private Sub closeBttn_Click(sender As Object, e As EventArgs) Handles closeBttn.Click
        'close
        Me.Close()
        'navidate to residents
        residents.Show()
    End Sub

End Class