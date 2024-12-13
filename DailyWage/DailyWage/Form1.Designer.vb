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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCName = New System.Windows.Forms.TextBox()
        Me.cboPosition = New System.Windows.Forms.ComboBox()
        Me.txtHoursWork = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblOH = New System.Windows.Forms.Label()
        Me.lblOP = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblGrossPay = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblNetPay = New System.Windows.Forms.Label()
        Me.lblTotalDeduction = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblSSS = New System.Windows.Forms.Label()
        Me.lblPhilHealth = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnCalcu = New System.Windows.Forms.Button()
        Me.lblRegPay = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(124, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 67)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Payroll System"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Complete Name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Position              :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Hours work        :"
        '
        'txtCName
        '
        Me.txtCName.Location = New System.Drawing.Point(192, 104)
        Me.txtCName.Name = "txtCName"
        Me.txtCName.Size = New System.Drawing.Size(218, 22)
        Me.txtCName.TabIndex = 4
        '
        'cboPosition
        '
        Me.cboPosition.FormattingEnabled = True
        Me.cboPosition.Items.AddRange(New Object() {"Staff", "Supervisor", "Manager"})
        Me.cboPosition.Location = New System.Drawing.Point(192, 137)
        Me.cboPosition.Name = "cboPosition"
        Me.cboPosition.Size = New System.Drawing.Size(150, 24)
        Me.cboPosition.TabIndex = 5
        Me.cboPosition.Text = "Staff"
        '
        'txtHoursWork
        '
        Me.txtHoursWork.Location = New System.Drawing.Point(192, 174)
        Me.txtHoursWork.Name = "txtHoursWork"
        Me.txtHoursWork.Size = New System.Drawing.Size(87, 22)
        Me.txtHoursWork.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(48, 287)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 18)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Overtime Hours  :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(48, 319)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 18)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Overtime Pay      :"
        '
        'lblOH
        '
        Me.lblOH.BackColor = System.Drawing.Color.Turquoise
        Me.lblOH.Location = New System.Drawing.Point(193, 287)
        Me.lblOH.Name = "lblOH"
        Me.lblOH.Size = New System.Drawing.Size(122, 23)
        Me.lblOH.TabIndex = 9
        Me.lblOH.Text = "0"
        Me.lblOH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOP
        '
        Me.lblOP.BackColor = System.Drawing.Color.Turquoise
        Me.lblOP.Location = New System.Drawing.Point(193, 319)
        Me.lblOP.Name = "lblOP"
        Me.lblOP.Size = New System.Drawing.Size(122, 23)
        Me.lblOP.TabIndex = 10
        Me.lblOP.Text = "0"
        Me.lblOP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(46, 392)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 18)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Gross Pay           :"
        '
        'lblGrossPay
        '
        Me.lblGrossPay.BackColor = System.Drawing.Color.Turquoise
        Me.lblGrossPay.Location = New System.Drawing.Point(193, 392)
        Me.lblGrossPay.Name = "lblGrossPay"
        Me.lblGrossPay.Size = New System.Drawing.Size(122, 23)
        Me.lblGrossPay.TabIndex = 12
        Me.lblGrossPay.Text = "0"
        Me.lblGrossPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblNetPay)
        Me.GroupBox1.Controls.Add(Me.lblTotalDeduction)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.lblTax)
        Me.GroupBox1.Controls.Add(Me.lblSSS)
        Me.GroupBox1.Controls.Add(Me.lblPhilHealth)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Location = New System.Drawing.Point(51, 468)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(383, 277)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Deduction"
        '
        'lblNetPay
        '
        Me.lblNetPay.BackColor = System.Drawing.Color.DarkCyan
        Me.lblNetPay.Location = New System.Drawing.Point(165, 219)
        Me.lblNetPay.Name = "lblNetPay"
        Me.lblNetPay.Size = New System.Drawing.Size(122, 23)
        Me.lblNetPay.TabIndex = 21
        Me.lblNetPay.Text = "0"
        Me.lblNetPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalDeduction
        '
        Me.lblTotalDeduction.BackColor = System.Drawing.Color.DarkCyan
        Me.lblTotalDeduction.Location = New System.Drawing.Point(165, 185)
        Me.lblTotalDeduction.Name = "lblTotalDeduction"
        Me.lblTotalDeduction.Size = New System.Drawing.Size(122, 23)
        Me.lblTotalDeduction.TabIndex = 20
        Me.lblTotalDeduction.Text = "0"
        Me.lblTotalDeduction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(30, 224)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(124, 18)
        Me.Label18.TabIndex = 19
        Me.Label18.Text = "Net Pay               :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(30, 190)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(128, 18)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "Total Deduction   :"
        '
        'lblTax
        '
        Me.lblTax.BackColor = System.Drawing.Color.LightSeaGreen
        Me.lblTax.Location = New System.Drawing.Point(165, 118)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(122, 23)
        Me.lblTax.TabIndex = 17
        Me.lblTax.Text = "0"
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSSS
        '
        Me.lblSSS.BackColor = System.Drawing.Color.LightSeaGreen
        Me.lblSSS.Location = New System.Drawing.Point(165, 78)
        Me.lblSSS.Name = "lblSSS"
        Me.lblSSS.Size = New System.Drawing.Size(122, 23)
        Me.lblSSS.TabIndex = 16
        Me.lblSSS.Text = "0"
        Me.lblSSS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPhilHealth
        '
        Me.lblPhilHealth.BackColor = System.Drawing.Color.LightSeaGreen
        Me.lblPhilHealth.Location = New System.Drawing.Point(165, 38)
        Me.lblPhilHealth.Name = "lblPhilHealth"
        Me.lblPhilHealth.Size = New System.Drawing.Size(122, 23)
        Me.lblPhilHealth.TabIndex = 14
        Me.lblPhilHealth.Text = "0"
        Me.lblPhilHealth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(30, 118)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(120, 18)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Tax                     :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(30, 78)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(118, 18)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "SSS                   :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(30, 38)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 18)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "PhilHealth          :"
        '
        'btnCalcu
        '
        Me.btnCalcu.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCalcu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCalcu.Location = New System.Drawing.Point(192, 211)
        Me.btnCalcu.Name = "btnCalcu"
        Me.btnCalcu.Size = New System.Drawing.Size(119, 35)
        Me.btnCalcu.TabIndex = 14
        Me.btnCalcu.Text = "Calculate"
        Me.btnCalcu.UseVisualStyleBackColor = False
        '
        'lblRegPay
        '
        Me.lblRegPay.BackColor = System.Drawing.Color.Turquoise
        Me.lblRegPay.Location = New System.Drawing.Point(193, 356)
        Me.lblRegPay.Name = "lblRegPay"
        Me.lblRegPay.Size = New System.Drawing.Size(122, 23)
        Me.lblRegPay.TabIndex = 16
        Me.lblRegPay.Text = "0"
        Me.lblRegPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(47, 357)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 18)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Regular Pay         :"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 784)
        Me.Controls.Add(Me.lblRegPay)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnCalcu)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblGrossPay)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblOP)
        Me.Controls.Add(Me.lblOH)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtHoursWork)
        Me.Controls.Add(Me.cboPosition)
        Me.Controls.Add(Me.txtCName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Jason's Payroll System"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCName As TextBox
    Friend WithEvents cboPosition As ComboBox
    Friend WithEvents txtHoursWork As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblOH As Label
    Friend WithEvents lblOP As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblGrossPay As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblTax As Label
    Friend WithEvents lblSSS As Label
    Friend WithEvents lblPhilHealth As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lblNetPay As Label
    Friend WithEvents lblTotalDeduction As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents btnCalcu As Button
    Friend WithEvents lblRegPay As Label
    Friend WithEvents Label8 As Label
End Class
