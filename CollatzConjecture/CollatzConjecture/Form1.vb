Public Class Form1

    Dim n As Integer

    Private Sub btnResult_Click(sender As Object, e As EventArgs) Handles btnResult.Click
        Integer.TryParse(txtNumber.Text, n)
        If n <= 0 Then
            MsgBox("Please enter a positive integer greater than 0.")

        Else

            lblOutput.Text = "Collatz sequence: " & n

            While n <> 1

                If n Mod 2 = 0 Then
                    n = n \ 2
                Else
                    n = 3 * n + 1
                End If

                lblOutput.Text &= ", " & n

                End While
        End If
    End Sub

    Private Sub txtNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumber.KeyPress
        If e.KeyChar = "Enter" Then
            e.Handled = True
        End If
    End Sub
End Class
