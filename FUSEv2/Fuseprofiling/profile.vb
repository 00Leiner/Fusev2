Imports System.Data.OleDb
Imports System.IO

Public Class profile
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
    End Sub

    Private Sub closeBttn_Click(sender As Object, e As EventArgs) Handles closeBttn.Click
        'close
        Me.Close()
    End Sub

    Private Sub personalinfo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles personalinfo.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = personalinfo.Rows(e.RowIndex)
            Dim househld As String = row.Cells("HOUSEHOLD").Value.ToString()
            Dim Fname As String = String.Format("{0} {1} {2}", row.Cells("FIRSTNAME").Value.ToString(), row.Cells("MIDDLENAME").Value.ToString(), row.Cells("SURNAME").Value.ToString())
            Dim suf As String = row.Cells("SUFFIX").Value.ToString()
            Dim address As String = String.Format("Purok {0}, {1}", row.Cells("PUROK").Value.ToString(), row.Cells("ADDRESS").Value.ToString())
            Dim sex As String = row.Cells("SEX").Value.ToString()
            Dim civilstat As String = row.Cells("CIVILSTATUS").Value.ToString()
            Dim bdate As String = row.Cells("BIRTHDATE").Value.ToString()
            Dim occupationstat As String = row.Cells("OCCUPATIONSTATUS").Value.ToString()
            Dim contact As String = row.Cells("CONTACT").Value.ToString()
            Dim sname As String = String.Format("{0} {1}", row.Cells("FIRSTNAME").Value.ToString(), row.Cells("SURNAME").Value.ToString())
            Dim imageData As Byte()

            If TypeOf row.Cells("Images").Value Is Byte() Then
                imageData = DirectCast(row.Cells("Images").Value, Byte())
            ElseIf TypeOf row.Cells("Images").Value Is String Then
                ' Assuming the value is a string representing the byte array, you can use appropriate conversion methods
                imageData = Convert.FromBase64String(row.Cells("Images").Value.ToString())
            Else
                ' Handle the case when the value is neither a Byte() nor a String
                ' You might want to show an error message or take appropriate action here
            End If

            ' Convert the byte array to an Image object
            Using ms As New MemoryStream(imageData)
                Dim image As Image = Image.FromStream(ms)

                ' Display the image in the PictureBox
                PictureBox1.Image = image
                'Display the data in the panel
                lblhousehold.Text = househld
                lblname.Text = Fname
                lblsex.Text = sex
                lblcivil.Text = civilstat
                lbloccupation.Text = occupationstat
                lblbirthdate.Text = bdate
                lblcontact.Text = contact
                lbladdress.Text = address
                lblsname.Text = sname
            End Using
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles search.TextChanged
        'call GetConnection() from dbconnection.vb
        Dim conn As OleDbConnection = DatabaseConnection.GetConnection()
        'adapting query
        Dim adapter As OleDbDataAdapter = New OleDbDataAdapter("SELECT * FROM infostb", conn)

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
            personalinfo.Columns("images").Visible = False
        End Using
    End Sub
End Class