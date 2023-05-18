Imports System.Data.OleDb
Imports System.IO

Public Class viewform
    Public Sub UpdateDataGridView(buttonClicked As String)
        'connection to db
        Dim conn As OleDbConnection = DatabaseConnection.GetConnection()
        'adapter
        Dim adapter As OleDbDataAdapter = Nothing
        'table
        Dim table As New DataTable()
        'conditions on what data will show in datagridview
        If buttonClicked = "All" Then

            Label2.Text = "RESIDENTS"
            ' table for view all 
            adapter = New OleDbDataAdapter("SELECT * FROM infostb ORDER BY SURNAME ASC", conn)

        ElseIf buttonClicked = "Male" Then

            Label2.Text = "MALE"
            ' table for male 
            adapter = New OleDbDataAdapter("SELECT * FROM infostb WHERE SEX = 'Male' ORDER BY SURNAME ASC", conn)

        ElseIf buttonClicked = "Female" Then
            Label2.Text = "FEMALE"
            ' table for female
            adapter = New OleDbDataAdapter("SELECT * FROM infostb WHERE SEX = 'Female' ORDER BY SURNAME ASC", conn)

        ElseIf buttonClicked = "Child" Then
            Label2.Text = "CHILDREN"
            'table for child
            adapter = New OleDbDataAdapter("SELECT * FROM infostb WHERE DateDiff('yyyy', BIRTHDATE, Date()) <= 12", conn)

        ElseIf buttonClicked = "Adolescent" Then
            Label2.Text = "ADOLENCENT"
            'adolescent
            adapter = New OleDbDataAdapter("SELECT * FROM infostb WHERE DateDiff('d', BIRTHDATE, Date()) / 365.25 BETWEEN 13 AND 17", conn)

        ElseIf buttonClicked = "Adult" Then
            Label2.Text = "ADULT"
            'adult
            adapter = New OleDbDataAdapter("SELECT * FROM infostb WHERE DateDiff('d', BIRTHDATE, Date()) / 365.25 BETWEEN 18 AND 59", conn)

        ElseIf buttonClicked = "Elderly" Then
            Label2.Text = "ELDERLY"
            'Elderly
            adapter = New OleDbDataAdapter("SELECT * FROM infostb WHERE DateDiff('yyyy', BIRTHDATE, Date()) >= 60", conn)

        ElseIf buttonClicked = "1" Then
            Label2.Text = "PUROK 1"
            'Show population in purok 1
            adapter = New OleDbDataAdapter("SELECT * FROM infostb WHERE Purok = '1'", conn)

        ElseIf buttonClicked = "2" Then
            Label2.Text = "PUROK 2"
            'Show population in purok 1
            adapter = New OleDbDataAdapter("SELECT * FROM infostb WHERE Purok = '2'", conn)

        ElseIf buttonClicked = "3" Then
            Label2.Text = "PUROK 3"
            'Show population in purok 1
            adapter = New OleDbDataAdapter("SELECT * FROM infostb WHERE Purok = '3'", conn)

        ElseIf buttonClicked = "4" Then
            Label2.Text = "PUROK 4"
            'Show population in purok 1
            adapter = New OleDbDataAdapter("SELECT * FROM infostb WHERE Purok = '4'", conn)

        ElseIf buttonClicked = "5" Then
            Label2.Text = "PUROK 5"
            'Show population in purok 1
            adapter = New OleDbDataAdapter("SELECT * FROM infostb WHERE Purok = '5'", conn)

        ElseIf buttonClicked = "Single" Then
            Label2.Text = "SINGLE"
            'Single
            adapter = New OleDbDataAdapter("SELECT * FROM infostb WHERE CIVILSTATUS = 'Single'", conn)

        ElseIf buttonClicked = "Married" Then
            Label2.Text = "MARRIED"
            'Married
            adapter = New OleDbDataAdapter("SELECT * FROM infostb WHERE CIVILSTATUS = 'Married'", conn)

        ElseIf buttonClicked = "Divorced" Then
            Label2.Text = "DIVORCED"
            'Divorced
            adapter = New OleDbDataAdapter("SELECT * FROM infostb WHERE CIVILSTATUS = 'Divorced'", conn)

        ElseIf buttonClicked = "Separated" Then
            Label2.Text = "SEPARATED"
            'Separated
            adapter = New OleDbDataAdapter("SELECT * FROM infostb WHERE CIVILSTATUS = 'Separated'", conn)

        ElseIf buttonClicked = "Widowed" Then
            Label2.Text = "WIDOWED"
            'Widowed
            adapter = New OleDbDataAdapter("SELECT * FROM infostb WHERE CIVILSTATUS = 'Widowed'", conn)

        ElseIf buttonClicked = "Pensioner" Then
            Label2.Text = "PENSIONER"
            'Pensioner
            adapter = New OleDbDataAdapter("SELECT * FROM infostb WHERE OCCUPATIONSTATUS = 'Pensioner'", conn)

        ElseIf buttonClicked = "Employed" Then
            Label2.Text = "EMPLOYED"
            'Employed
            adapter = New OleDbDataAdapter("SELECT * FROM infostb WHERE OCCUPATIONSTATUS = 'Employed'", conn)

        ElseIf buttonClicked = "Unemployed" Then
            Label2.Text = "UNEMPLOYED"
            'Unemployed
            adapter = New OleDbDataAdapter("SELECT * FROM infostb WHERE OCCUPATIONSTATUS = 'Unemployed'", conn)

        ElseIf buttonClicked = "Self-employed" Then
            Label2.Text = "SELF-EMPLOYED"
            'Self-employed
            adapter = New OleDbDataAdapter("SELECT * FROM infostb WHERE OCCUPATIONSTATUS = 'Self-employed'", conn)

        ElseIf buttonClicked = "Student" Then
            Label2.Text = "STUDENTS"
            'Student
            adapter = New OleDbDataAdapter("SELECT * FROM infostb WHERE OCCUPATIONSTATUS = 'Student'", conn)

        End If

        'input data
        adapter.Fill(table)

        'remove primary key
        table.Columns.Remove("ID")

        'add No. rows alternative for primary key  
        Dim noColumn As DataColumn = table.Columns.Add("No.", GetType(Integer))
        For i As Integer = 0 To table.Rows.Count - 1
            table.Rows(i)("No.") = i + 1
        Next

        noColumn.SetOrdinal(0)
        'show data in datagridview
        personalinfo.DataSource = table
        personalinfo.Columns("images").Visible = False
    End Sub

    Private Sub closeBttn_Click(sender As Object, e As EventArgs) Handles closeBttn.Click
        'close
        Me.Close()
    End Sub
End Class