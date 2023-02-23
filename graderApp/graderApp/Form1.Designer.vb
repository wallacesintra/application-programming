<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtMarks = New System.Windows.Forms.TextBox()
        Me.btnGrader = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(143, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter marks:  "
        '
        'TxtMarks
        '
        Me.TxtMarks.Location = New System.Drawing.Point(279, 37)
        Me.TxtMarks.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtMarks.MaxLength = 3
        Me.TxtMarks.Name = "TxtMarks"
        Me.TxtMarks.Size = New System.Drawing.Size(116, 21)
        Me.TxtMarks.TabIndex = 1
        '
        'btnGrader
        '
        Me.btnGrader.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnGrader.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnGrader.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrader.ForeColor = System.Drawing.SystemColors.Control
        Me.btnGrader.Location = New System.Drawing.Point(279, 142)
        Me.btnGrader.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGrader.Name = "btnGrader"
        Me.btnGrader.Size = New System.Drawing.Size(87, 28)
        Me.btnGrader.TabIndex = 2
        Me.btnGrader.Text = "Grade"
        Me.btnGrader.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(839, 321)
        Me.Controls.Add(Me.btnGrader)
        Me.Controls.Add(Me.TxtMarks)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtMarks As System.Windows.Forms.TextBox
    Friend WithEvents btnGrader As System.Windows.Forms.Button

End Class
