Public Class Form1

    Dim VFirstNum As Decimal
    Dim VSecondNum As Decimal
    Dim Operations As Integer
    Dim Operator_Selector As Boolean = False

    Private Sub txtDisplay_TextChanged(sender As Object, e As EventArgs) Handles txtDisplay.TextChanged

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtDisplay.Text = txtDisplay.Text + "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtDisplay.Text = txtDisplay.Text + "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtDisplay.Text = txtDisplay.Text + "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtDisplay.Text = txtDisplay.Text + "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtDisplay.Text = txtDisplay.Text + "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtDisplay.Text = txtDisplay.Text + "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtDisplay.Text = txtDisplay.Text + "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtDisplay.Text = txtDisplay.Text + "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtDisplay.Text = txtDisplay.Text + "9"
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtDisplay.Text = txtDisplay.Text + "0"
    End Sub

    Private Sub btn00_Click(sender As Object, e As EventArgs) Handles btn00.Click
        txtDisplay.Text = txtDisplay.Text + "00"
    End Sub

    Private Sub btnDecimal_Click(sender As Object, e As EventArgs) Handles btnDecimal.Click
        If Not (txtDisplay.Text.Contains(".")) Then
            txtDisplay.Text += "."
        End If
    End Sub

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        If Operator_Selector = True Then
            VSecondNum = txtDisplay.Text

            If Operations = 1 Then
                txtDisplay.Text = VFirstNum + VSecondNum

            ElseIf Operations = 2 Then
                txtDisplay.Text = VFirstNum - VSecondNum

            ElseIf Operations = 3 Then
                txtDisplay.Text = VFirstNum * VSecondNum

            Else
                If VSecondNum = 0 Then
                    txtDisplay.Text = "Error"
                Else
                    txtDisplay.Text = VFirstNum / VSecondNum

                End If
            End If
            Operator_Selector = False
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        VFirstNum = txtDisplay.Text
        txtDisplay.Text = ""
        Operator_Selector = True
        Operations = 1 ' = +
    End Sub

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        VFirstNum = txtDisplay.Text
        txtDisplay.Text = ""
        Operator_Selector = True
        Operations = 2 ' = -
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        VFirstNum = txtDisplay.Text
        txtDisplay.Text = ""
        Operator_Selector = True
        Operations = 3 ' = ×
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        VFirstNum = txtDisplay.Text
        txtDisplay.Text = ""
        Operator_Selector = True
        Operations = 4 ' = ÷
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDisplay.Clear()
    End Sub
End Class
