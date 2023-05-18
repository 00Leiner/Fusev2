Imports System.Data.OleDb
Imports System.IO
Imports System.Windows

Public Class residents
    'call GetConnection() from dbconnection.vb
    Dim conn As OleDbConnection = DatabaseConnection.GetConnection()
    'adapting query
    Dim adapter As OleDbDataAdapter = New OleDbDataAdapter("SELECT * FROM infostb", conn)
    'var for command
    Dim comm As OleDbCommand

    'declair variable to get value from datagridview
    Dim ID As Integer
    Dim surname As String
    Dim firstname As String
    Dim middlename As String
    Dim suffix As String
    Dim household As String
    Dim purok As String
    Dim address As String
    Dim birthdate As String
    Dim sex As String
    Dim OCCUPATIONSTATUS As String
    Dim civilstatus As String
    Dim contact As String

    Private Sub residents_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'full row will be selected
        personalinfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        'showing data in datagridview
        Dim table As New DataTable()
        adapter = New OleDbDataAdapter("SELECT * FROM infostb ORDER BY SURNAME ASC", conn)
        adapter.Fill(table)
        personalinfo.DataSource = table

        'hide ID column
        personalinfo.Columns(0).Visible = False
        personalinfo.Columns("images").Visible = False
        'select cell
        personalinfo.ClearSelection()
    End Sub

    Private Sub search_TextChanged(sender As Object, e As EventArgs) Handles search.TextChanged

        'searchvalue variable 
        Dim searchValue As String = search.Text
        'selecting colums
        Dim query As String = "SELECT * FROM infostb WHERE SURNAME LIKE '%" & searchValue & "%' OR FIRSTNAME LIKE '%" & searchValue & "%' OR MIDDLENAME LIKE '%" & searchValue & "%' OR SUFFIX LIKE '%" & searchValue & "%' OR HOUSEHOLD LIKE '%" & searchValue & "%' OR PUROK LIKE '%" & searchValue & "%' OR ADDRESS LIKE '%" & searchValue & "%' OR BIRTHDATE LIKE '%" & searchValue & "%' OR SEX LIKE '%" & searchValue & "%' OR OCCUPATIONSTATUS LIKE '%" & searchValue & "%' OR CIVILSTATUS LIKE '%" & searchValue & "%' OR CONTACT LIKE '%" & searchValue & "%'"
        'use db
        Using comm = New OleDbCommand(query, conn)
            'new adapting query
            adapter = New OleDbDataAdapter(comm)
            Dim table As New DataTable()
            'showing data in datagridview
            adapter.Fill(table)
            personalinfo.DataSource = table

        End Using
    End Sub

    Private Sub personalinfo_SelectionChanged(sender As Object, e As EventArgs) Handles personalinfo.SelectionChanged
        If personalinfo.SelectedRows.Count > 0 Then
            ' Retrieve the data from the selected row
            Dim selectedRow As DataGridViewRow = personalinfo.SelectedRows(0)
            ID = Convert.ToInt32(selectedRow.Cells(0).Value)
            surname = selectedRow.Cells(1).Value.ToString()
            firstname = selectedRow.Cells(2).Value.ToString()
            middlename = selectedRow.Cells(3).Value.ToString()
            suffix = selectedRow.Cells(4).Value.ToString()
            address = selectedRow.Cells(5).Value.ToString()
            sex = selectedRow.Cells(6).Value.ToString()
            civilstatus = selectedRow.Cells(7).Value.ToString()
            household = selectedRow.Cells(8).Value.ToString()
            purok = selectedRow.Cells(9).Value.ToString()
            birthdate = selectedRow.Cells(10).Value.ToString()
            contact = selectedRow.Cells(11).Value.ToString()
            OCCUPATIONSTATUS = selectedRow.Cells(12).Value.ToString()

        End If
    End Sub

    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click
        ' Check if any cell is selected
        If personalinfo.SelectedCells.Count = 0 Then
            MessageBox.Show("Please select a cell to Delete.")

            'clear the search bar 
            search.Text = String.Empty

            Return
        Else
            ' Ask user to confirm deletion
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to permanently delete this data? ", "Confirmation", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                'delete command
                comm = New OleDbCommand("DELETE FROM infostb WHERE ID = @ID", conn)
                comm.Parameters.AddWithValue("@ID", ID)

                'execute
                Dim rowsAffected As Integer = comm.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Record deleted successfully.")
                Else
                    MessageBox.Show("Failed to delete record.")
                End If

                'show updated data in datagridview
                Dim table As New DataTable()
                adapter.Fill(table)
                personalinfo.DataSource = table

            End If

            'clear the search bar 
            search.Text = String.Empty

        End If
    End Sub

    Private Sub updatebtn_Click(sender As Object, e As EventArgs) Handles updatebtn.Click

        ' Check if any cell is selected
        If personalinfo.SelectedCells.Count = 0 Then
            MessageBox.Show("Please select a cell to update.")

            'clear the search bar 
            search.Text = String.Empty
            Return

        End If
        ' send the data clicked from the datagridview and send it to updateform
        Dim updateForm As New UpdateForm(ID, surname, firstname, middlename, suffix, household, purok, address, birthdate, sex, OCCUPATIONSTATUS, civilstatus, contact)

        'hide this form
        Me.Hide()

        'clear the search bar 
        search.Text = String.Empty

        'navidate to update form 
        updateForm.Show()
    End Sub

    Private Sub viewall_Click(sender As Object, e As EventArgs) Handles viewall.Click
        'clear the search bar 
        search.Text = String.Empty
        'navigate to viewform
        profile.UpdateDataGridView("All")
        profile.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'hide this form
        Me.Hide()
        'clear the search bar 
        search.Text = String.Empty
        'navigate to dashboard
        dashboard.Show()
    End Sub

    Private Sub demographicsbtn_Click(sender As Object, e As EventArgs) Handles demographicsbtn.Click
        'hide this form
        Me.Hide()
        'clear the search bar 
        search.Text = String.Empty
        'navigate to dashboard
        demographics.Show()
    End Sub

    Private Sub create_Click(sender As Object, e As EventArgs) Handles create.Click
        'hide this form
        Me.Hide()
        'clear the search bar 
        search.Text = String.Empty
        'navigate to dashboard
        registry.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim logout As DialogResult = MessageBox.Show("Are you sure you want to logout?", "logout", MessageBoxButtons.YesNo)
        If logout = DialogResult.Yes Then
            Me.Hide()
            Form1.Show()
        End If
    End Sub

End Class