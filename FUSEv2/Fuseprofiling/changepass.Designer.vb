<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class changepass
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(changepass))
        Me.usernametextbox = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.currentpasswordbox = New System.Windows.Forms.TextBox()
        Me.changebttn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.newpasswordbox = New System.Windows.Forms.TextBox()
        Me.closeBttn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'usernametextbox
        '
        Me.usernametextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.usernametextbox.Location = New System.Drawing.Point(380, 175)
        Me.usernametextbox.Multiline = True
        Me.usernametextbox.Name = "usernametextbox"
        Me.usernametextbox.Size = New System.Drawing.Size(251, 45)
        Me.usernametextbox.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'currentpasswordbox
        '
        Me.currentpasswordbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.currentpasswordbox.Location = New System.Drawing.Point(380, 237)
        Me.currentpasswordbox.Multiline = True
        Me.currentpasswordbox.Name = "currentpasswordbox"
        Me.currentpasswordbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.currentpasswordbox.Size = New System.Drawing.Size(251, 45)
        Me.currentpasswordbox.TabIndex = 2
        '
        'changebttn
        '
        Me.changebttn.FlatAppearance.BorderSize = 0
        Me.changebttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.changebttn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.changebttn.Location = New System.Drawing.Point(504, 359)
        Me.changebttn.Name = "changebttn"
        Me.changebttn.Size = New System.Drawing.Size(127, 44)
        Me.changebttn.TabIndex = 3
        Me.changebttn.Text = "Change "
        Me.changebttn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(315, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Change Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(236, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Username:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(236, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Current Password:"
        '
        'newpasswordbox
        '
        Me.newpasswordbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.newpasswordbox.Location = New System.Drawing.Point(380, 298)
        Me.newpasswordbox.Multiline = True
        Me.newpasswordbox.Name = "newpasswordbox"
        Me.newpasswordbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.newpasswordbox.Size = New System.Drawing.Size(251, 45)
        Me.newpasswordbox.TabIndex = 7
        '
        'closeBttn
        '
        Me.closeBttn.BackColor = System.Drawing.Color.Transparent
        Me.closeBttn.BackgroundImage = CType(resources.GetObject("closeBttn.BackgroundImage"), System.Drawing.Image)
        Me.closeBttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.closeBttn.FlatAppearance.BorderSize = 0
        Me.closeBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closeBttn.Location = New System.Drawing.Point(810, 12)
        Me.closeBttn.Name = "closeBttn"
        Me.closeBttn.Size = New System.Drawing.Size(45, 45)
        Me.closeBttn.TabIndex = 45
        Me.closeBttn.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(236, 309)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 20)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "New Password:"
        '
        'changepass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(867, 506)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.closeBttn)
        Me.Controls.Add(Me.newpasswordbox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.changebttn)
        Me.Controls.Add(Me.currentpasswordbox)
        Me.Controls.Add(Me.usernametextbox)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "changepass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "changepass"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents usernametextbox As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents currentpasswordbox As TextBox
    Friend WithEvents changebttn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents newpasswordbox As TextBox
    Friend WithEvents closeBttn As Button
    Friend WithEvents Label4 As Label
End Class
