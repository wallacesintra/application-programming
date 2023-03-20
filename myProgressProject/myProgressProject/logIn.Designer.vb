<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class logIn
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
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chckBoxManager = New System.Windows.Forms.CheckBox()
        Me.chckBoxEmployee = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBxPasswordLog = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBxEmployeeIdLog = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLogIn
        '
        Me.btnLogIn.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogIn.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogIn.ForeColor = System.Drawing.Color.White
        Me.btnLogIn.Location = New System.Drawing.Point(158, 354)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(144, 45)
        Me.btnLogIn.TabIndex = 8
        Me.btnLogIn.Text = "LOG IN"
        Me.btnLogIn.UseVisualStyleBackColor = False
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.chckBoxManager)
        Me.SplitContainer1.Panel2.Controls.Add(Me.chckBoxEmployee)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnLogIn)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtBxPasswordLog)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtBxEmployeeIdLog)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SplitContainer1.Panel2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.SplitContainer1.Size = New System.Drawing.Size(951, 555)
        Me.SplitContainer1.SplitterDistance = 316
        Me.SplitContainer1.TabIndex = 1
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
        'chckBoxManager
        '
        Me.chckBoxManager.AutoSize = True
        Me.chckBoxManager.Font = New System.Drawing.Font("Century Gothic", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckBoxManager.ForeColor = System.Drawing.Color.Black
        Me.chckBoxManager.Location = New System.Drawing.Point(180, 216)
        Me.chckBoxManager.Name = "chckBoxManager"
        Me.chckBoxManager.Size = New System.Drawing.Size(107, 25)
        Me.chckBoxManager.TabIndex = 11
        Me.chckBoxManager.Text = "Manager"
        Me.chckBoxManager.UseVisualStyleBackColor = True
        '
        'chckBoxEmployee
        '
        Me.chckBoxEmployee.AutoSize = True
        Me.chckBoxEmployee.Font = New System.Drawing.Font("Century Gothic", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckBoxEmployee.ForeColor = System.Drawing.Color.Black
        Me.chckBoxEmployee.Location = New System.Drawing.Point(180, 185)
        Me.chckBoxEmployee.Name = "chckBoxEmployee"
        Me.chckBoxEmployee.Size = New System.Drawing.Size(109, 25)
        Me.chckBoxEmployee.TabIndex = 10
        Me.chckBoxEmployee.Text = "Employee"
        Me.chckBoxEmployee.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 21)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Employee Title:"
        '
        'txtBxPasswordLog
        '
        Me.txtBxPasswordLog.Location = New System.Drawing.Point(42, 288)
        Me.txtBxPasswordLog.MaxLength = 8
        Me.txtBxPasswordLog.Name = "txtBxPasswordLog"
        Me.txtBxPasswordLog.Size = New System.Drawing.Size(417, 31)
        Me.txtBxPasswordLog.TabIndex = 4
        Me.txtBxPasswordLog.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 252)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password"
        '
        'txtBxEmployeeIdLog
        '
        Me.txtBxEmployeeIdLog.Location = New System.Drawing.Point(42, 127)
        Me.txtBxEmployeeIdLog.Name = "txtBxEmployeeIdLog"
        Me.txtBxEmployeeIdLog.Size = New System.Drawing.Size(417, 31)
        Me.txtBxEmployeeIdLog.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 21)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Employee ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 26)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Let's get started"
        '
        'logIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 555)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "logIn"
        Me.Text = "logIn"
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
    Friend WithEvents txtBxPasswordLog As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtBxEmployeeIdLog As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnLogIn As System.Windows.Forms.Button
    Friend WithEvents chckBoxManager As System.Windows.Forms.CheckBox
    Friend WithEvents chckBoxEmployee As System.Windows.Forms.CheckBox
End Class
