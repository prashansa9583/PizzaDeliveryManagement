<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EMPLOGIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EMPLOGIN))
        Me.user = New System.Windows.Forms.TextBox()
        Me.pass = New System.Windows.Forms.TextBox()
        Me.UserName = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'user
        '
        Me.user.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.user.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.user.Location = New System.Drawing.Point(466, 138)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(160, 34)
        Me.user.TabIndex = 0
        '
        'pass
        '
        Me.pass.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.pass.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pass.Location = New System.Drawing.Point(466, 227)
        Me.pass.Name = "pass"
        Me.pass.Size = New System.Drawing.Size(160, 34)
        Me.pass.TabIndex = 1
        '
        'UserName
        '
        Me.UserName.AutoSize = True
        Me.UserName.BackColor = System.Drawing.Color.Transparent
        Me.UserName.Font = New System.Drawing.Font("Arial MT Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.UserName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UserName.Location = New System.Drawing.Point(284, 136)
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(163, 31)
        Me.UserName.TabIndex = 2
        Me.UserName.Text = "Username"
        '
        'Password
        '
        Me.Password.AutoSize = True
        Me.Password.BackColor = System.Drawing.Color.Transparent
        Me.Password.Font = New System.Drawing.Font("Arial MT Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Password.Location = New System.Drawing.Point(284, 225)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(156, 31)
        Me.Password.TabIndex = 3
        Me.Password.Text = "Password"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(386, 318)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 50)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "CONFIRM"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(376, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 60)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "LOGIN"
        '
        'EMPLOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(680, 427)
        Me.Controls.Add(Me.UserName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.user)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.Password)
        Me.Name = "EMPLOGIN"
        Me.Text = "EMPLOGIN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents user As TextBox
    Friend WithEvents pass As TextBox
    Friend WithEvents UserName As Label
    Friend WithEvents Password As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
