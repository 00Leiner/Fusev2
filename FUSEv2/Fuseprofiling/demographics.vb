Imports System.Data.OleDb
Imports System.Windows.Forms.DataVisualization.Charting

Public Class demographics

    'db connection
    Dim conn As OleDbConnection = DatabaseConnection.GetConnection()

    Private Sub demographics_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'SHOW AND HIDE PANELL
        demographicsinfo.Visible = True
        purokstats.Visible = False
        civilstatuspanel.Visible = False
        occupationalstatspanel.Visible = False
        overviewpanel.Visible = False

        'SHOW ACTIVATION 
        activedemographic.Visible = True
        activepurok.Visible = False
        activemaritalstatus.Visible = False
        activeoccupational.Visible = False
        activeoverview.Visible = False
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click

        Me.Hide()
        'back to dashboard
        dashboard.Show()
    End Sub
    'button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'SHOW AND HIDE PANELL
        demographicsinfo.Visible = True
        purokstats.Visible = False
        civilstatuspanel.Visible = False
        occupationalstatspanel.Visible = False
        overviewpanel.Visible = False

        'SHOW ACTIVATION 
        activedemographic.Visible = True
        activepurok.Visible = False
        activemaritalstatus.Visible = False
        activeoccupational.Visible = False
        activeoverview.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'SHOW AND HIDE PANELL
        demographicsinfo.Visible = False
        purokstats.Visible = True
        civilstatuspanel.Visible = False
        occupationalstatspanel.Visible = False
        overviewpanel.Visible = False

        'SHOW ACTIVATION 
        activedemographic.Visible = False
        activepurok.Visible = True
        activemaritalstatus.Visible = False
        activeoccupational.Visible = False
        activeoverview.Visible = False
    End Sub

    Private Sub civilstatsbtn_Click(sender As Object, e As EventArgs) Handles civilstatsbtn.Click
        'SHOW AND HIDE PANELL
        demographicsinfo.Visible = False
        purokstats.Visible = False
        civilstatuspanel.Visible = True
        occupationalstatspanel.Visible = False
        overviewpanel.Visible = False

        'SHOW ACTIVATION 
        activedemographic.Visible = False
        activepurok.Visible = False
        activemaritalstatus.Visible = True
        activeoccupational.Visible = False
        activeoverview.Visible = False
    End Sub

    Private Sub occupationstatsbtn_Click(sender As Object, e As EventArgs) Handles occupationstatsbtn.Click
        'SHOW AND HIDE PANELL
        demographicsinfo.Visible = False
        purokstats.Visible = False
        civilstatuspanel.Visible = False
        occupationalstatspanel.Visible = True
        overviewpanel.Visible = False

        'SHOW ACTIVATION 
        activedemographic.Visible = False
        activepurok.Visible = False
        activemaritalstatus.Visible = False
        activeoccupational.Visible = True
        activeoverview.Visible = False
    End Sub

    Private Sub overviewbtn_Click(sender As Object, e As EventArgs) Handles overviewbtn.Click
        'SHOW AND HIDE PANELL
        demographicsinfo.Visible = False
        purokstats.Visible = False
        civilstatuspanel.Visible = False
        occupationalstatspanel.Visible = False
        overviewpanel.Visible = True

        'SHOW ACTIVATION 
        activedemographic.Visible = False
        activepurok.Visible = False
        activemaritalstatus.Visible = False
        activeoccupational.Visible = False
        activeoverview.Visible = True

    End Sub

    'demographics -----------------------------------------------------------------------------------------------------------------------------------------------------------------
    'age------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    Private Sub demographicsinfo_Paint_1(sender As Object, e As PaintEventArgs) Handles demographicsinfo.Paint

        'child
        Dim cmdchildAge = New OleDbCommand("SELECT COUNT(*) FROM infostb WHERE DateDiff('yyyy', BIRTHDATE, Date()) <= 12", conn)
        Dim countchild = Convert.ToString(cmdchildAge.ExecuteScalar)
        childcount.Text = countchild

        'adolescent
        Dim cmdadolescentAge = New OleDbCommand("SELECT COUNT(*) FROM infostb WHERE DateDiff('d', BIRTHDATE, Date()) / 365.25 BETWEEN 13 AND 17", conn)
        Dim countadolescent = Convert.ToString(cmdadolescentAge.ExecuteScalar)
        Adolescentcount.Text = countadolescent

        'adult
        Dim cmdadultAge = New OleDbCommand("SELECT COUNT(*) FROM infostb WHERE DateDiff('d', BIRTHDATE, Date()) / 365.25 BETWEEN 18 AND 59", conn)
        Dim countadult = Convert.ToString(cmdadultAge.ExecuteScalar)
        Adultcount.Text = countadult

        'Elderly
        Dim cmdelderAge = New OleDbCommand("SELECT COUNT(*) FROM infostb WHERE DateDiff('yyyy', BIRTHDATE, Date()) >= 60", conn)
        Dim countelder = Convert.ToString(cmdelderAge.ExecuteScalar)
        Elderlycount.Text = countelder

        ' add data points to the chart series
        Dim Person As New Series()
        Person.ChartType = SeriesChartType.Column
        Person.Points.AddXY("Child", countchild)
        Person.Points.AddXY("Adolescent", countadolescent)
        Person.Points.AddXY("Adult", countadult)
        Person.Points.AddXY("Elderly", countelder)

        ' clear chart series to prevent continues adding 
        Chart1.Series.Clear()
        'show chart
        Chart1.Series.Add(Person)

    End Sub

    'view list
    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        'show the list of child
        viewform.UpdateDataGridView("Child")
        viewform.ShowDialog()
    End Sub
    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        'show the list of Adolescent
        viewform.UpdateDataGridView("Adolescent")
        viewform.ShowDialog()
    End Sub
    Private Sub Panel4_Click(sender As Object, e As EventArgs) Handles Panel4.Click
        'show the list of Adult
        viewform.UpdateDataGridView("Adult")
        viewform.ShowDialog()
    End Sub
    Private Sub Panel5_Click(sender As Object, e As EventArgs) Handles Panel5.Click
        'show the list of Elderly
        viewform.UpdateDataGridView("Elderly")
        viewform.ShowDialog()
    End Sub


    'purok-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    Private Sub purokstats_Paint(sender As Object, e As PaintEventArgs) Handles purokstats.Paint

        'count population in purok 1
        Dim cmdpurok1 = New OleDbCommand("SELECT COUNT(*) FROM infostb WHERE Purok = '1'", conn)
        Dim countpurok1 = Convert.ToString(cmdpurok1.ExecuteScalar)
        purok1count.Text = countpurok1
        'count population in purok 2
        Dim cmdpurok2 = New OleDbCommand("SELECT COUNT(*) FROM infostb WHERE Purok = '2'", conn)
        Dim countpurok2 = Convert.ToString(cmdpurok2.ExecuteScalar)
        purok2count.Text = countpurok2
        'count population in purok 3
        Dim cmdpurok3 = New OleDbCommand("SELECT COUNT(*) FROM infostb WHERE Purok = '3'", conn)
        Dim countpurok3 = Convert.ToString(cmdpurok3.ExecuteScalar)
        purok3count.Text = countpurok3
        'count population in purok 4
        Dim cmdpurok4 = New OleDbCommand("SELECT COUNT(*) FROM infostb WHERE Purok = '4'", conn)
        Dim countpurok4 = Convert.ToString(cmdpurok4.ExecuteScalar)
        purok4count.Text = countpurok4
        'count population in purok 5
        Dim cmdpurok5 = New OleDbCommand("SELECT COUNT(*) FROM infostb WHERE Purok = '5'", conn)
        Dim countpurok5 = Convert.ToString(cmdpurok5.ExecuteScalar)
        purok5count.Text = countpurok5


        ' add data points to the chart series
        Dim Person As New Series()
        Person.ChartType = SeriesChartType.Column
        Person.Points.AddXY("Purok 1", countpurok1)
        Person.Points.AddXY("Purok 2", countpurok2)
        Person.Points.AddXY("Purok 3", countpurok3)
        Person.Points.AddXY("Purok 4", countpurok4)
        Person.Points.AddXY("Purok 5", countpurok5)

        ' clear chart series to prevent continues adding 
        Chart2.Series.Clear()
        'show chart
        Chart2.Series.Add(Person)

    End Sub

    'view list
    Private Sub purok1panel_Click(sender As Object, e As EventArgs) Handles purok1panel.Click
        'show the list in purok  1
        viewform.UpdateDataGridView("1")
        viewform.ShowDialog()
    End Sub
    Private Sub purok2panel_Click(sender As Object, e As EventArgs) Handles purok2panel.Click
        'show the list in purok  2
        viewform.UpdateDataGridView("2")
        viewform.ShowDialog()
    End Sub

    Private Sub purok3panel_Click(sender As Object, e As EventArgs) Handles purok3panel.Click
        'show the list in purok  3
        viewform.UpdateDataGridView("3")
        viewform.ShowDialog()
    End Sub

    Private Sub purok4panel_Click(sender As Object, e As EventArgs) Handles purok4panel.Click
        'show the list in purok  4
        viewform.UpdateDataGridView("4")
        viewform.ShowDialog()
    End Sub

    Private Sub purok5panel_Click(sender As Object, e As EventArgs) Handles purok5panel.Click
        'show the list in purok  5
        viewform.UpdateDataGridView("5")
        viewform.ShowDialog()
    End Sub


    'civilstatus ----------------------------------------------------------------------------------------------------------------------------------------------------------------------
    Private Sub civilstatuspanel_Paint(sender As Object, e As PaintEventArgs) Handles civilstatuspanel.Paint
        'SINGLE
        Dim cmdsingl = New OleDbCommand("SELECT COUNT(*) FROM infostb WHERE CIVILSTATUS = 'Single'", conn)
        Dim countsingl = Convert.ToString(cmdsingl.ExecuteScalar)
        singlecount.Text = countsingl

        'married
        Dim cmdmarried = New OleDbCommand("SELECT COUNT(*) FROM infostb WHERE CIVILSTATUS = 'Married'", conn)
        Dim countmarried = Convert.ToString(cmdmarried.ExecuteScalar)
        marriedcount.Text = countmarried

        'Divorced
        Dim cmdDivorced = New OleDbCommand("SELECT COUNT(*) FROM infostb WHERE CIVILSTATUS = 'Divorced'", conn)
        Dim countDivorced = Convert.ToString(cmdDivorced.ExecuteScalar)
        divorcedcount.Text = countDivorced

        'Separated
        Dim cmdSeparated = New OleDbCommand("SELECT COUNT(*) FROM infostb WHERE CIVILSTATUS = 'Separated'", conn)
        Dim countSeparated = Convert.ToString(cmdSeparated.ExecuteScalar)
        separatedcount.Text = countSeparated

        'Widowed
        Dim cmdWidowed = New OleDbCommand("SELECT COUNT(*) FROM infostb WHERE CIVILSTATUS = 'Widowed'", conn)
        Dim countWidowed = Convert.ToString(cmdWidowed.ExecuteScalar)
        widowedcount.Text = countWidowed

        ' add data points to the chart series
        Dim Person As New Series()
        Person.ChartType = SeriesChartType.Column
        Person.Points.AddXY("Single", countsingl)
        Person.Points.AddXY("Married", countmarried)
        Person.Points.AddXY("Divorced", countDivorced)
        Person.Points.AddXY("Separated", countSeparated)
        Person.Points.AddXY("Widowed", countWidowed)

        ' clear chart series to prevent continues adding 
        Chart3.Series.Clear()
        'show chart
        Chart3.Series.Add(Person)
    End Sub

    'view list
    Private Sub singlepanel_Click(sender As Object, e As EventArgs) Handles singlepanel.Click
        'show the list of Single
        viewform.UpdateDataGridView("Single")
        viewform.ShowDialog()
    End Sub
    Private Sub marreidpanel_Click(sender As Object, e As EventArgs) Handles marreidpanel.Click
        'show the list of Married
        viewform.UpdateDataGridView("Married")
        viewform.ShowDialog()
    End Sub
    Private Sub divorcedpanel_Click(sender As Object, e As EventArgs) Handles divorcedpanel.Click
        'show the list of Divorced
        viewform.UpdateDataGridView("Divorced")
        viewform.ShowDialog()
    End Sub
    Private Sub separatedpanel_Click(sender As Object, e As EventArgs) Handles separatedpanel.Click
        'show the list of Separated
        viewform.UpdateDataGridView("Separated")
        viewform.ShowDialog()
    End Sub
    Private Sub widowedpanel_Click(sender As Object, e As EventArgs) Handles widowedpanel.Click
        'show the list of Widowed
        viewform.UpdateDataGridView("Widowed")
        viewform.ShowDialog()
    End Sub


    'occupational------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    Private Sub occupationalstatspanel_Paint(sender As Object, e As PaintEventArgs) Handles occupationalstatspanel.Paint

        'Pensioner
        Dim cmdPensioner = New OleDbCommand("SELECT COUNT(*) FROM infostb WHERE OCCUPATIONSTATUS = 'Pensioner'", conn)
        Dim countPensioner = Convert.ToString(cmdPensioner.ExecuteScalar)
        pensionercount.Text = countPensioner
        'Employed
        Dim cmdEmployed = New OleDbCommand("SELECT COUNT(*) FROM infostb WHERE OCCUPATIONSTATUS = 'Employed'", conn)
        Dim countEmployed = Convert.ToString(cmdEmployed.ExecuteScalar)
        employedcount.Text = countEmployed
        'Unemployed
        Dim cmdUnemployed = New OleDbCommand("SELECT COUNT(*) FROM infostb WHERE OCCUPATIONSTATUS = 'Unemployed'", conn)
        Dim countUnemployed = Convert.ToString(cmdUnemployed.ExecuteScalar)
        unemployedcount.Text = countUnemployed
        'selfemployed
        Dim cmdselfemployed = New OleDbCommand("SELECT COUNT(*) FROM infostb WHERE OCCUPATIONSTATUS = 'Self-employed'", conn)
        Dim countselfemployed = Convert.ToString(cmdselfemployed.ExecuteScalar)
        selfemployedcount.Text = countselfemployed
        'Student
        Dim cmdStudent = New OleDbCommand("SELECT COUNT(*) FROM infostb WHERE OCCUPATIONSTATUS = 'Student'", conn)
        Dim countStudent = Convert.ToString(cmdStudent.ExecuteScalar)
        studentcount.Text = countStudent

        ' add data points to the chart series
        Dim Person As New Series()
        Person.ChartType = SeriesChartType.Column
        Person.Points.AddXY("Pensioner", countPensioner)
        Person.Points.AddXY("Employed", countEmployed)
        Person.Points.AddXY("Unemployed", countUnemployed)
        Person.Points.AddXY("Self-employed", countselfemployed)
        Person.Points.AddXY("Student", countStudent)

        ' clear chart series to prevent continues adding 
        Chart4.Series.Clear()
        'show chart
        Chart4.Series.Add(Person)
    End Sub

    'view list
    Private Sub pensionerpanel_Click(sender As Object, e As EventArgs) Handles pensionerpanel.Click
        'show the list of Pensioner
        viewform.UpdateDataGridView("Pensioner")
        viewform.ShowDialog()
    End Sub
    Private Sub employedpanel_Click(sender As Object, e As EventArgs) Handles employedpanel.Click
        'show the list of Employed
        viewform.UpdateDataGridView("Employed")
        viewform.ShowDialog()
    End Sub
    Private Sub unemployedpanel_Click(sender As Object, e As EventArgs) Handles unemployedpanel.Click
        'show the list of Unemployed
        viewform.UpdateDataGridView("Unemployed")
        viewform.ShowDialog()
    End Sub
    Private Sub selfemployedpanel_Click(sender As Object, e As EventArgs) Handles selfemployedpanel.Click
        'show the list of Self-employed
        viewform.UpdateDataGridView("Self-employed")
        viewform.ShowDialog()
    End Sub
    Private Sub studentpanel_Click(sender As Object, e As EventArgs) Handles studentpanel.Click
        'show the list of Student
        viewform.UpdateDataGridView("Student")
        viewform.ShowDialog()
    End Sub
    'overview----------------------------------------------------------------------------------------------------------------------------
    '
    '
    '
    '
    '
End Class