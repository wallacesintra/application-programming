﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btnWelcome = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBxName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnWelcome
        '
        Me.btnWelcome.Location = New System.Drawing.Point(132, 126)
        Me.btnWelcome.Name = "btnWelcome"
        Me.btnWelcome.Size = New System.Drawing.Size(75, 23)
        Me.btnWelcome.TabIndex = 0
        Me.btnWelcome.Text = "welcome"
        Me.btnWelcome.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name: "
        '
        'txtBxName
        '
        Me.txtBxName.Location = New System.Drawing.Point(132, 23)
        Me.txtBxName.Name = "txtBxName"
        Me.txtBxName.Size = New System.Drawing.Size(190, 20)
        Me.txtBxName.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 261)
        Me.Controls.Add(Me.txtBxName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnWelcome)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnWelcome As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBxName As System.Windows.Forms.TextBox

End Class
