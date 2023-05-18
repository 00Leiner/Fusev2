<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewhouseholdmember
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(viewhouseholdmember))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.householdID = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.closeBttn = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(20, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1061, 597)
        Me.DataGridView1.TabIndex = 0
        '
        'householdID
        '
        Me.householdID.AutoSize = True
        Me.householdID.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold)
        Me.householdID.ForeColor = System.Drawing.Color.White
        Me.householdID.Location = New System.Drawing.Point(345, 15)
        Me.householdID.Name = "householdID"
        Me.householdID.Size = New System.Drawing.Size(101, 31)
        Me.householdID.TabIndex = 1
        Me.householdID.Text = "Label1"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(10, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1102, 635)
        Me.Panel1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(88, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(251, 31)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "HOUSEHOLD ID: "
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
        'viewhouseholdmember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(1121, 702)
        Me.Controls.Add(Me.closeBttn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.householdID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "viewhouseholdmember"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "viewhouseholdmember"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents householdID As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents closeBttn As Button
End Class
