<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class household
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(household))
        Me.HouseholdData = New System.Windows.Forms.DataGridView()
        Me.viewbtn = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.closeBttn = New System.Windows.Forms.Button()
        CType(Me.HouseholdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'HouseholdData
        '
        Me.HouseholdData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.HouseholdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HouseholdData.Location = New System.Drawing.Point(20, 16)
        Me.HouseholdData.Name = "HouseholdData"
        Me.HouseholdData.ReadOnly = True
        Me.HouseholdData.Size = New System.Drawing.Size(1061, 532)
        Me.HouseholdData.TabIndex = 0
        '
        'viewbtn
        '
        Me.viewbtn.Location = New System.Drawing.Point(953, 7)
        Me.viewbtn.Name = "viewbtn"
        Me.viewbtn.Size = New System.Drawing.Size(130, 39)
        Me.viewbtn.TabIndex = 2
        Me.viewbtn.Text = "view"
        Me.viewbtn.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(114, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(495, 29)
        Me.TextBox1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Search:"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.HouseholdData)
        Me.Panel1.Location = New System.Drawing.Point(10, 123)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1102, 568)
        Me.Panel1.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.viewbtn)
        Me.Panel2.Location = New System.Drawing.Point(10, 60)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1102, 57)
        Me.Panel2.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(88, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(234, 31)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "HOUSEHOLD ID"
        '
        'closeBttn
        '
        Me.closeBttn.BackColor = System.Drawing.Color.Transparent
        Me.closeBttn.BackgroundImage = CType(resources.GetObject("closeBttn.BackgroundImage"), System.Drawing.Image)
        Me.closeBttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.closeBttn.FlatAppearance.BorderSize = 0
        Me.closeBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closeBttn.Location = New System.Drawing.Point(1057, 6)
        Me.closeBttn.Margin = New System.Windows.Forms.Padding(2)
        Me.closeBttn.Name = "closeBttn"
        Me.closeBttn.Size = New System.Drawing.Size(45, 45)
        Me.closeBttn.TabIndex = 45
        Me.closeBttn.UseVisualStyleBackColor = False
        '
        'household
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(1121, 702)
        Me.Controls.Add(Me.closeBttn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "household"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "household"
        CType(Me.HouseholdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HouseholdData As DataGridView
    Friend WithEvents viewbtn As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents closeBttn As Button
End Class
