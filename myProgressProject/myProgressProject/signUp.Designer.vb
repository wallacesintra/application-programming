<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class signUp
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.chckBxAgree = New System.Windows.Forms.CheckBox()
        Me.txtBxPassword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBxEmployeeId = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBxUserName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnSignUp)
        Me.SplitContainer1.Panel2.Controls.Add(Me.chckBxAgree)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtBxPassword)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtBxEmployeeId)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtBxUserName)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SplitContainer1.Panel2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.SplitContainer1.Size = New System.Drawing.Size(976, 558)
        Me.SplitContainer1.SplitterDistance = 325
        Me.SplitContainer1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(34, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 47)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MyProgress"
        '
        'btnSignUp
        '
        Me.btnSignUp.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSignUp.FlatAppearance.BorderSize = 0
        Me.btnSignUp.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignUp.ForeColor = System.Drawing.Color.White
        Me.btnSignUp.Location = New System.Drawing.Point(196, 440)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(144, 45)
        Me.btnSignUp.TabIndex = 8
        Me.btnSignUp.Text = "SIGN UP"
        Me.btnSignUp.UseVisualStyleBackColor = False
        '
        'chckBxAgree
        '
        Me.chckBxAgree.AutoSize = True
        Me.chckBxAgree.Font = New System.Drawing.Font("Century Gothic", 10.25!)
        Me.chckBxAgree.ForeColor = System.Drawing.Color.Black
        Me.chckBxAgree.Location = New System.Drawing.Point(42, 377)
        Me.chckBxAgree.Name = "chckBxAgree"
        Me.chckBxAgree.Size = New System.Drawing.Size(284, 23)
        Me.chckBxAgree.TabIndex = 7
        Me.chckBxAgree.Text = "I agree with the terms and conditions"
        Me.chckBxAgree.UseVisualStyleBackColor = True
        '
        'txtBxPassword
        '
        Me.txtBxPassword.Location = New System.Drawing.Point(42, 309)
        Me.txtBxPassword.MaxLength = 8
        Me.txtBxPassword.Name = "txtBxPassword"
        Me.txtBxPassword.Size = New System.Drawing.Size(417, 31)
        Me.txtBxPassword.TabIndex = 6
        Me.txtBxPassword.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 274)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 21)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Password"
        '
        'txtBxEmployeeId
        '
        Me.txtBxEmployeeId.Location = New System.Drawing.Point(42, 222)
        Me.txtBxEmployeeId.Name = "txtBxEmployeeId"
        Me.txtBxEmployeeId.Size = New System.Drawing.Size(417, 31)
        Me.txtBxEmployeeId.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Employee ID"
        '
        'txtBxUserName
        '
        Me.txtBxUserName.Location = New System.Drawing.Point(42, 138)
        Me.txtBxUserName.Name = "txtBxUserName"
        Me.txtBxUserName.Size = New System.Drawing.Size(417, 31)
        Me.txtBxUserName.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 21)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(235, 26)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Create your account"
        '
        'signUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(976, 558)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "signUp"
        Me.Text = "signUp"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBxEmployeeId As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtBxUserName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSignUp As System.Windows.Forms.Button
    Friend WithEvents chckBxAgree As System.Windows.Forms.CheckBox
    Friend WithEvents txtBxPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
