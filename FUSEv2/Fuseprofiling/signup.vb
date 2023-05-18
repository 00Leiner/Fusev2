Imports System.Data.OleDb

Public Class signup
    'call GetConnection() from dbconnection.vb
    Dim conn As OleDbConnection = DatabaseConnection.GetConnection()

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        'used for trapping and prompt
        If String.IsNullOrEmpty(userbox.Text) Then
            MessageBox.Show("Please fill the First Name.")
            Return
        End If
        If String.IsNullOrEmpty(passbox.Text) Then
            MessageBox.Show("Please fill the Last Name")
            Return
        End If

        'inserting data to the db
        Dim mycmd As New OleDbCommand("Insert into Account(Uname, passw) Values ('" & userbox.Text & "' , '" & passbox.Text & "')", conn)
        If MsgBox("Registration Successful") Then
        End If

        Try
            mycmd.ExecuteNonQuery()
            conn.Close()
            userbox.Clear()
            passbox.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class