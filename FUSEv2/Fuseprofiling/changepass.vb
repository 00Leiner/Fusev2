Imports System.Data.OleDb

Public Class changepass
    Dim conn As OleDbConnection = DatabaseConnection.GetConnection()
    Private Sub changebttn_Click(sender As Object, e As EventArgs) Handles changebttn.Click


        Dim username As String = usernametextbox.Text
        Dim currentPassword As String = currentpasswordbox.Text
        Dim newPassword As String = newpasswordbox.Text

        If Not String.IsNullOrEmpty(username) AndAlso Not String.IsNullOrEmpty(currentPassword) AndAlso Not String.IsNullOrEmpty(newPassword) Then

            Dim query As String = "SELECT Passw FROM Account WHERE Uname = @Uname"
            Using command As New OleDbCommand(query, conn)
                command.Parameters.AddWithValue("@Uname", username)
                Dim currentStoredPassword As String = DirectCast(command.ExecuteScalar(), String)

                If currentStoredPassword = currentPassword Then
                    query = "UPDATE Account SET Passw = @NewPassword WHERE Uname = @Uname"
                    Using updateCommand As New OleDbCommand(query, conn)
                        updateCommand.Parameters.AddWithValue("@NewPassword", newPassword)
                        updateCommand.Parameters.AddWithValue("@Uname", username)
                        Dim rowsAffected As Integer = updateCommand.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show("Password changed successfully.")
                        Else
                            MessageBox.Show("Failed to change password.")
                        End If
                    End Using
                Else
                    MessageBox.Show("Invalid current password.")
                End If
            End Using
            conn.Close()
        Else
            MessageBox.Show("Please enter all fields.")
        End If
    End Sub

    Private Sub closeBttn_Click(sender As Object, e As EventArgs) Handles closeBttn.Click
        'close
        Me.Close()
    End Sub
End Class