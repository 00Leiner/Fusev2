<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class viewform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(viewform))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.closeBttn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.personalinfo = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.personalinfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(88, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 31)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Residents"
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
        Me.closeBttn.TabIndex = 44
        Me.closeBttn.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.personalinfo)
        Me.Panel1.Location = New System.Drawing.Point(10, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1102, 635)
        Me.Panel1.TabIndex = 45
        '
        'personalinfo
        '
        Me.personalinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.personalinfo.Location = New System.Drawing.Point(22, 12)
        Me.personalinfo.Name = "personalinfo"
        Me.personalinfo.ReadOnly = True
        Me.personalinfo.Size = New System.Drawing.Size(1060, 597)
        Me.personalinfo.TabIndex = 0
        '
        'viewform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1121, 702)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.closeBttn)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "viewform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "viewall"
        Me.Panel1.ResumeLayout(False)
        CType(Me.personalinfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents closeBttn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents personalinfo As DataGridView
End Class
