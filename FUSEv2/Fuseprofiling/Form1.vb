Imports System.Data.OleDb

Public Class Form1
    'call GetConnection() from dbconnection.vb
    Dim conn As OleDbConnection = DatabaseConnection.GetConnection()

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        userbox.Clear()
        passbox.Clear()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        If String.IsNullOrEmpty(userbox.Text) Then
            MessageBox.Show("Please fill the First Name.")
            Return
        End If
        If String.IsNullOrEmpty(passbox.Text) Then
            MessageBox.Show("Please fill the Last Name")
            Return
        End If
        'variavle for counting attempt
        Dim attempt As Integer = 0


        Dim mycmd As New OleDbCommand("SELECT * FROM account WHERE uname = '" & userbox.Text & "' AND passw = '" & passbox.Text & "'", conn)
        Dim myread As OleDbDataReader = mycmd.ExecuteReader
        If myread.Read Then
            MsgBox("Login Successfully")
            dashboard.Show()
            Me.Hide()
        Else
            userbox.Clear()
            userbox.Focus()
            passbox.Clear()
            attempt += 1
            MessageBox.Show("WARNING: INVALID INPUT!!!")
        End If


        'final attempt before system error
        If attempt = 5 Then
            passbox.Enabled = False
            userbox.Enabled = False
            loginbtn.Enabled = False
            MessageBox.Show("ERROR: TOO MANY ATTEMPS!!")
        End If

    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Application.Exit()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        signup.Show()
        Me.Hide()
    End Sub
End Class
