Imports System.Data.OleDb
Imports System.Windows.Forms.DataVisualization.Charting

Public Class dashboard
    Dim isCollapsed As Boolean = True
    Dim iscollapsed2 As Boolean = True


    Private Sub residents_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        'db connection
        Dim conn As OleDbConnection = DatabaseConnection.GetConnection()

        'showing totals
        Dim cmdHouseholdID As New OleDbCommand("SELECT COUNT(*) FROM (SELECT DISTINCT HOUSEHOLD FROM infostb)", conn)
        Dim countHouseholdID = Convert.ToString(cmdHouseholdID.ExecuteScalar)
        total_household.Text = countHouseholdID

        Dim cmdpopulation As New OleDbCommand("SELECT COUNT(FIRSTNAME) FROM infostb", conn)
        Dim countpopulation = Convert.ToString(cmdpopulation.ExecuteScalar)
        total_population.Text = countpopulation

        Dim cmdfemale = New OleDbCommand("SELECT COUNT(*) FROM infostb WHERE SEX = 'FEMALE'", conn)
        Dim countfemale = Convert.ToString(cmdfemale.ExecuteScalar)
        total_female.Text = countfemale

        Dim cmdmale = New OleDbCommand("SELECT COUNT(*) FROM infostb WHERE SEX = 'MALE'", conn)
        Dim countmale = Convert.ToString(cmdmale.ExecuteScalar)
        total_male.Text = countmale


        ' add data points to the chart series
        Dim series1 As New Series()
        series1.ChartType = SeriesChartType.Pie
        series1.Points.AddXY("FEMALE", countfemale)
        series1.Points.AddXY("MALE", countmale)

        ' clear chart series to prevent continues adding 
        Chart1.Series.Clear()
        'show chart
        Chart1.Series.Add(series1)


    End Sub
    Private Sub create_Click(sender As Object, e As EventArgs) Handles create.Click
        Me.Hide()
        'navigate to registry
        registry.Show()
    End Sub

    Private Sub residentsbtn_Click(sender As Object, e As EventArgs) Handles residentsbtn.Click
        Me.Hide()
        'navigate to residents
        residents.Show()
    End Sub

    Private Sub demographicsbtn_Click(sender As Object, e As EventArgs) Handles demographicsbtn.Click
        Me.Hide()
        'navigate to demographics
        demographics.Show()
    End Sub

    Private Sub Panel4_Click(sender As Object, e As EventArgs) Handles Panel4.Click
        'show the list of Female
        viewform.UpdateDataGridView("Female")
        viewform.ShowDialog()
    End Sub

    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        'show the list of Male
        viewform.UpdateDataGridView("Male")
        viewform.ShowDialog()
    End Sub

    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        'show the list of All recidents
        viewform.UpdateDataGridView("All")
        viewform.ShowDialog()
    End Sub

    Private Sub Panel1_click(sender As Object, e As EventArgs) Handles Panel1.Click
        'show the list of household
        household.Show()
    End Sub

    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        droppanel.Size = droppanel.MinimumSize
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If isCollapsed Then

            droppanel.Height += 10
            If droppanel.Size = droppanel.MaximumSize Then
                Timer1.Stop()
                isCollapsed = False
            End If
        Else
            droppanel.Height -= 10
            If droppanel.Size = droppanel.MinimumSize Then
                Timer1.Stop()
                isCollapsed = True
            End If
        End If
    End Sub

    Private Sub dropbttn1_Click(sender As Object, e As EventArgs) Handles dropbttn1.Click
        iscollapsed2 = False

        Timer1.Start()
    End Sub

    Private Sub dropbttn3_Click(sender As Object, e As EventArgs) Handles dropbttn3.Click
        Dim logout As DialogResult = MessageBox.Show("Are you sure you want to logout?", "logout", MessageBoxButtons.YesNo)
        If logout = DialogResult.Yes Then
            Me.Hide()
            Form1.Show()
        End If
    End Sub
End Class