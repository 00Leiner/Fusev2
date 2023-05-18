<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TCamera
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TCamera))
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TakeBttn = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.closeBttn = New System.Windows.Forms.Button()
        Me.Panel5.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Linen
        Me.Panel5.Controls.Add(Me.TakeBttn)
        Me.Panel5.Controls.Add(Me.Label17)
        Me.Panel5.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel5.Location = New System.Drawing.Point(12, 47)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(784, 441)
        Me.Panel5.TabIndex = 62
        '
        'TakeBttn
        '
        Me.TakeBttn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.TakeBttn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TakeBttn.Location = New System.Drawing.Point(334, 378)
        Me.TakeBttn.Name = "TakeBttn"
        Me.TakeBttn.Size = New System.Drawing.Size(117, 40)
        Me.TakeBttn.TabIndex = 36
        Me.TakeBttn.Text = "Capture"
        Me.TakeBttn.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label17.Location = New System.Drawing.Point(3, 8)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(106, 24)
        Me.Label17.TabIndex = 34
        Me.Label17.Text = "Add profile:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox6, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox5, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(17, 42)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(750, 330)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'PictureBox6
        '
        Me.PictureBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox6.Location = New System.Drawing.Point(378, 4)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(368, 322)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 1
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox5.Location = New System.Drawing.Point(4, 4)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(367, 322)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 0
        Me.PictureBox5.TabStop = False
        '
        'closeBttn
        '
        Me.closeBttn.BackColor = System.Drawing.Color.Transparent
        Me.closeBttn.BackgroundImage = CType(resources.GetObject("closeBttn.BackgroundImage"), System.Drawing.Image)
        Me.closeBttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.closeBttn.FlatAppearance.BorderSize = 0
        Me.closeBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closeBttn.Location = New System.Drawing.Point(767, 11)
        Me.closeBttn.Margin = New System.Windows.Forms.Padding(2)
        Me.closeBttn.Name = "closeBttn"
        Me.closeBttn.Size = New System.Drawing.Size(30, 30)
        Me.closeBttn.TabIndex = 64
        Me.closeBttn.UseVisualStyleBackColor = False
        '
        'TCamera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(808, 500)
        Me.Controls.Add(Me.closeBttn)
        Me.Controls.Add(Me.Panel5)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TCamera"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Camera"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel5 As Panel
    Friend WithEvents TakeBttn As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents closeBttn As Button
End Class
