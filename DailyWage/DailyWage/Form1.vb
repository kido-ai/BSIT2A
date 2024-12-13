Imports System.Linq.Expressions

Public Class Form1
    Dim regularRate As Double = 0
    Dim overtimeRate As Double = 0
    Dim regularHours As Double = 8
    Dim overtimeHours As Double = 0
    Dim grossPay As Double = 0
    Dim philHealth As Double = 50.68
    Dim sss As Double = 78.54
    Dim tax As Double = 0
    Dim totalDeductions As Double = 0
    Dim netPay As Double = 0

    Private Sub cboPosition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPosition.SelectedIndexChanged
        Dim position As String = cboPosition.SelectedItem.ToString()


        Select Case position
            Case "Staff"
                regularRate = 260
                overtimeRate = 275
            Case "Supervisor"
                regularRate = 280
                overtimeRate = 295
            Case "Manager"
                regularRate = 312
                overtimeRate = 330
            Case Else
                MessageBox.Show("Please select a valid position.")
                Exit Sub
        End Select
    End Sub
    Private Sub btnCalcu_Click(sender As Object, e As EventArgs) Handles btnCalcu.Click
        Dim hoursWorked As Double = CDbl(txtHoursWork.Text)
        Dim overtimePay As Double = overtimeHours * overtimeRate

        If hoursWorked > regularHours Then
            overtimeHours = hoursWorked - regularHours
        Else
            overtimeHours = 0
        End If

        grossPay = (regularRate * Math.Min(hoursWorked, regularHours)) + (overtimeRate * overtimeHours)

        totalDeductions = philHealth + sss

        If grossPay > 2500 Then
            tax = grossPay * 0.14
        Else
            tax = 0
        End If

        totalDeductions += tax

        netPay = grossPay - totalDeductions

        lblOH.Text = overtimeHours
        lblOP.Text = overtimePay
        lblRegPay.Text = regularRate * regularHours


        lblSSS.Text = sss
        lblTax.Text = tax
        lblPhilHealth.Text = philHealth
        lblGrossPay.Text = grossPay
        lblTotalDeduction.Text = totalDeductions
        lblNetPay.Text = netPay
    End Sub
End Class
