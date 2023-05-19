Imports System.Data.OleDb


Public Class viewhouseholdmember

    'call GetConnection() from dbconnection.vb
    Dim conn As OleDbConnection = DatabaseConnection.GetConnection()

    Public Sub New(selectedHousehold As String)

        ' Initialize the form and set the values of the corresponding controls
        InitializeComponent()
        householdID.Text = selectedHousehold

        ' Retrieve the data based on the selected household ID and populate the DataGridView
        Dim query As String = "SELECT * FROM infostb WHERE HOUSEHOLD = @SelectedHouseholdID"
        Using cmd As New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@SelectedHouseholdID", selectedHousehold)
            Dim adapter As New OleDbDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
        End Using
    End Sub

    Private Sub closeBttn_Click(sender As Object, e As EventArgs) Handles closeBttn.Click
        'close
        Me.Close()
    End Sub

    Private Sub householdID_Click(sender As Object, e As EventArgs) Handles householdID.Click

    End Sub
End Class