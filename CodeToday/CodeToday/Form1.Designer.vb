﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnum1 = New System.Windows.Forms.TextBox()
        Me.btncalcu = New System.Windows.Forms.Button()
        Me.lblADD = New System.Windows.Forms.Label()
        Me.lblresult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ENTER A NUMBER : "
        '
        'txtnum1
        '
        Me.txtnum1.Location = New System.Drawing.Point(202, 168)
        Me.txtnum1.Name = "txtnum1"
        Me.txtnum1.Size = New System.Drawing.Size(105, 22)
        Me.txtnum1.TabIndex = 2
        '
        'btncalcu
        '
        Me.btncalcu.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncalcu.Location = New System.Drawing.Point(337, 171)
        Me.btncalcu.Name = "btncalcu"
        Me.btncalcu.Size = New System.Drawing.Size(119, 23)
        Me.btncalcu.TabIndex = 4
        Me.btncalcu.Text = "CALCULATE"
        Me.btncalcu.UseVisualStyleBackColor = True
        '
        'lblADD
        '
        Me.lblADD.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblADD.Location = New System.Drawing.Point(117, 36)
        Me.lblADD.Name = "lblADD"
        Me.lblADD.Size = New System.Drawing.Size(308, 73)
        Me.lblADD.TabIndex = 5
        Me.lblADD.Text = "Prime Number"
        Me.lblADD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblresult
        '
        Me.lblresult.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblresult.Location = New System.Drawing.Point(116, 274)
        Me.lblresult.Name = "lblresult"
        Me.lblresult.Size = New System.Drawing.Size(292, 60)
        Me.lblresult.TabIndex = 6
        Me.lblresult.Text = "0"
        Me.lblresult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 462)
        Me.Controls.Add(Me.lblresult)
        Me.Controls.Add(Me.lblADD)
        Me.Controls.Add(Me.btncalcu)
        Me.Controls.Add(Me.txtnum1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtnum1 As TextBox
    Friend WithEvents btncalcu As Button
    Friend WithEvents lblADD As Label
    Friend WithEvents lblresult As Label
End Class
