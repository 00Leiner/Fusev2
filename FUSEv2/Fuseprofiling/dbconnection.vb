Imports System.Configuration
Imports System.Data.OleDb

Module DatabaseConnection
    'if configuration is not declaired install system.configuration 
    Public Function GetConnection() As OleDbConnection
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString
        Dim conn As New OleDbConnection(connectionString)
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
        Return conn
    End Function
End Module