Imports System.Data.OleDb

Public Class household
    'db connection
    Dim conn As OleDbConnection = DatabaseConnection.GetConnection()

    Dim selectedHousehold As String

    Private Sub household_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        'clear the search bar 
        TextBox1.Text = String.Empty

        'full row will be selected
        HouseholdData.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        Dim query As String = "SELECT DISTINCT HOUSEHOLD FROM infostb"
        Using cmd As New OleDbCommand(query, conn)
            Dim adapter As New OleDbDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            ' Set the DataTable
            HouseholdData.DataSource = table
        End Using

        'select cell
        HouseholdData.ClearSelection()

    End Sub
    Private Sub HouseholdData_SelectionChanged(sender As Object, e As EventArgs) Handles HouseholdData.SelectionChanged
        If HouseholdData.SelectedRows.Count > 0 Then
            ' Retrieve the data from the selected row
            Dim selectedRow As DataGridViewRow = HouseholdData.SelectedRows(0)

            ' Retrieve the value of the selected cell in the "HOUSEHOLD" column
            selectedHousehold = selectedRow.Cells("HOUSEHOLD").Value.ToString()
        End If
    End Sub

    Private Sub viewbtn_Click(sender As Object, e As EventArgs) Handles viewbtn.Click

        ' Check if any cell is selected
        If HouseholdData.SelectedCells.Count = 0 Then
            MessageBox.Show("Please select a cell to view household member.")

            'clear the search bar 
            TextBox1.Text = String.Empty
            Return

        End If
        ' send the data clicked from the datagridview and send it to updateform
        Dim viewhouseholdmemeber As New viewhouseholdmember(selectedHousehold)
        viewhouseholdmemeber.ShowDialog()

        'clear the search bar 
        TextBox1.Text = String.Empty

    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        ' Get the search value from the TextBox
        Dim searchValue As String = TextBox1.Text

        ' Get the original DataTable from the DataGridView's DataSource
        Dim originalTable As DataTable = DirectCast(HouseholdData.DataSource, DataTable)

        ' Create a DataView to apply the filter
        Dim dataView As DataView = originalTable.DefaultView

        ' Apply the filter based on the search value
        dataView.RowFilter = "HOUSEHOLD LIKE '%" & searchValue & "%'"

        ' Check if the filtered DataView has any rows
        If dataView.Count = 0 Then
            ' If no rows match the search, create an empty row with the same schema as the original DataTable
            Dim emptyRow As DataRow = originalTable.NewRow()
            originalTable.Rows.Add(emptyRow)
        End If

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub closeBttn_Click(sender As Object, e As EventArgs) Handles closeBttn.Click
        'close
        Me.Close()
    End Sub
End Class