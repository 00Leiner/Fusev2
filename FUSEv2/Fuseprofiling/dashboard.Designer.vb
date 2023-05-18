<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashboard))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.create = New System.Windows.Forms.Button()
        Me.demographicsbtn = New System.Windows.Forms.Button()
        Me.residentsbtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.total_male = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.total_household = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.total_female = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.total_population = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'create
        '
        Me.create.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.create.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.create.Cursor = System.Windows.Forms.Cursors.Hand
        Me.create.FlatAppearance.BorderSize = 0
        Me.create.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.create.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.create.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.create.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.create.ForeColor = System.Drawing.Color.White
        Me.create.Location = New System.Drawing.Point(31, 329)
        Me.create.Name = "create"
        Me.create.Size = New System.Drawing.Size(213, 65)
        Me.create.TabIndex = 3
        Me.create.Text = "Registry"
        Me.create.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.create.UseVisualStyleBackColor = False
        '
        'demographicsbtn
        '
        Me.demographicsbtn.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.demographicsbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.demographicsbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.demographicsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.demographicsbtn.Font = New System.Drawing.Font("Sitka Text", 9.749999!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.demographicsbtn.Location = New System.Drawing.Point(30, 619)
        Me.demographicsbtn.Name = "demographicsbtn"
        Me.demographicsbtn.Size = New System.Drawing.Size(171, 42)
        Me.demographicsbtn.TabIndex = 4
        Me.demographicsbtn.Text = "demographics"
        Me.demographicsbtn.UseVisualStyleBackColor = False
        '
        'residentsbtn
        '
        Me.residentsbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.residentsbtn.FlatAppearance.BorderSize = 0
        Me.residentsbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.residentsbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.residentsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.residentsbtn.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.residentsbtn.ForeColor = System.Drawing.Color.White
        Me.residentsbtn.Location = New System.Drawing.Point(31, 416)
        Me.residentsbtn.Name = "residentsbtn"
        Me.residentsbtn.Size = New System.Drawing.Size(213, 65)
        Me.residentsbtn.TabIndex = 4
        Me.residentsbtn.Text = "Resident"
        Me.residentsbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.residentsbtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(31, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(182, 183)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(1063, 26)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(39, 39)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Tan
        Me.Panel6.Location = New System.Drawing.Point(12, 332)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(12, 59)
        Me.Panel6.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(245, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(498, 27)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "BARANGAY MASAPANG PROFILING SYSTEM"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Silver
        Me.Label5.Location = New System.Drawing.Point(247, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(283, 14)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Purok 3 Brgy Hall, Brgy Masapang, Victoria, Laguna"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Tan
        Me.Panel7.Location = New System.Drawing.Point(12, 419)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(12, 59)
        Me.Panel7.TabIndex = 13
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel8.Location = New System.Drawing.Point(12, 244)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(12, 59)
        Me.Panel8.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(31, 241)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(213, 65)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Dashboard"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel5.Controls.Add(Me.Chart1)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.Panel3)
        Me.Panel5.Controls.Add(Me.Panel1)
        Me.Panel5.Controls.Add(Me.Panel4)
        Me.Panel5.Controls.Add(Me.PictureBox4)
        Me.Panel5.Controls.Add(Me.Panel2)
        Me.Panel5.Controls.Add(Me.PictureBox3)
        Me.Panel5.Location = New System.Drawing.Point(245, 95)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(857, 581)
        Me.Panel5.TabIndex = 17
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Transparent
        Me.Chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Chart1.BorderlineColor = System.Drawing.Color.Transparent
        ChartArea1.Area3DStyle.Enable3D = True
        ChartArea1.Area3DStyle.Inclination = 50
        ChartArea1.BackColor = System.Drawing.Color.Transparent
        ChartArea1.BorderColor = System.Drawing.Color.Transparent
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Cursor = System.Windows.Forms.Cursors.No
        Me.Chart1.Enabled = False
        Legend1.BackColor = System.Drawing.Color.Transparent
        Legend1.Name = "Legend1"
        Legend1.Position.Auto = False
        Legend1.Position.Height = 41.77778!
        Legend1.Position.Width = 14.88251!
        Legend1.Position.X = 82.11749!
        Legend1.Position.Y = 4.0!
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(137, 348)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale
        Series1.BackImageTransparentColor = System.Drawing.Color.Transparent
        Series1.BackSecondaryColor = System.Drawing.Color.Transparent
        Series1.BorderColor = System.Drawing.Color.Transparent
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.Color = System.Drawing.Color.Transparent
        Series1.LabelBackColor = System.Drawing.Color.Transparent
        Series1.LabelBorderColor = System.Drawing.Color.Transparent
        Series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        Series1.LabelForeColor = System.Drawing.Color.Transparent
        Series1.Legend = "Legend1"
        Series1.MarkerBorderColor = System.Drawing.Color.Transparent
        Series1.MarkerColor = System.Drawing.Color.Transparent
        Series1.MarkerImageTransparentColor = System.Drawing.Color.Transparent
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(543, 260)
        Me.Chart1.TabIndex = 5
        Me.Chart1.Text = "Chart1"
        Title1.Name = "Title1"
        Title1.Position.Auto = False
        Title1.Position.Height = 6.636756!
        Title1.Position.X = 20.0!
        Title1.Position.Y = 10.0!
        Title1.Text = "SEX:"
        Me.Chart1.Titles.Add(Title1)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(362, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 23)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "DASHBOARD"
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.total_male)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel3.Location = New System.Drawing.Point(96, 222)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(301, 124)
        Me.Panel3.TabIndex = 22
        '
        'total_male
        '
        Me.total_male.AutoSize = True
        Me.total_male.BackColor = System.Drawing.Color.Transparent
        Me.total_male.Font = New System.Drawing.Font("Tahoma", 26.0!)
        Me.total_male.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.total_male.Location = New System.Drawing.Point(49, 68)
        Me.total_male.Name = "total_male"
        Me.total_male.Size = New System.Drawing.Size(37, 42)
        Me.total_male.TabIndex = 1
        Me.total_male.Text = "_"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(19, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 23)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Male"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.total_household)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(96, 85)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(301, 124)
        Me.Panel1.TabIndex = 20
        '
        'total_household
        '
        Me.total_household.AutoSize = True
        Me.total_household.BackColor = System.Drawing.Color.Transparent
        Me.total_household.Font = New System.Drawing.Font("Tahoma", 26.0!)
        Me.total_household.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.total_household.Location = New System.Drawing.Point(49, 59)
        Me.total_household.Name = "total_household"
        Me.total_household.Size = New System.Drawing.Size(37, 42)
        Me.total_household.TabIndex = 1
        Me.total_household.Text = "_"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Label1.Location = New System.Drawing.Point(19, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Household"
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.total_female)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel4.Location = New System.Drawing.Point(456, 222)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(301, 124)
        Me.Panel4.TabIndex = 20
        '
        'total_female
        '
        Me.total_female.AutoSize = True
        Me.total_female.BackColor = System.Drawing.Color.Transparent
        Me.total_female.Font = New System.Drawing.Font("Tahoma", 26.0!)
        Me.total_female.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.total_female.Location = New System.Drawing.Point(63, 68)
        Me.total_female.Name = "total_female"
        Me.total_female.Size = New System.Drawing.Size(37, 42)
        Me.total_female.TabIndex = 1
        Me.total_female.Text = "_"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.Label8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Location = New System.Drawing.Point(23, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 23)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Female "
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(0, -180)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(379, 425)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 56
        Me.PictureBox4.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.total_population)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel2.Location = New System.Drawing.Point(457, 85)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(301, 124)
        Me.Panel2.TabIndex = 19
        '
        'total_population
        '
        Me.total_population.AutoSize = True
        Me.total_population.Font = New System.Drawing.Font("Tahoma", 26.0!)
        Me.total_population.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.total_population.Location = New System.Drawing.Point(62, 59)
        Me.total_population.Name = "total_population"
        Me.total_population.Size = New System.Drawing.Size(37, 42)
        Me.total_population.TabIndex = 1
        Me.total_population.Text = "_"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.Window
        Me.Label4.Location = New System.Drawing.Point(23, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Population"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(477, -181)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(380, 425)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 55
        Me.PictureBox3.TabStop = False
        '
        'dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1121, 702)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.residentsbtn)
        Me.Controls.Add(Me.demographicsbtn)
        Me.Controls.Add(Me.create)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "dashboard"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents create As Button
    Friend WithEvents demographicsbtn As Button
    Friend WithEvents residentsbtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents total_male As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents total_household As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents total_female As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents total_population As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox3 As PictureBox
End Class
