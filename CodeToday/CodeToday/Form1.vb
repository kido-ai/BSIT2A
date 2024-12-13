Public Class Form1
    Private Sub btncalcu_Click(sender As Object, e As EventArgs) Handles btncalcu.Click
        Dim num As Integer

        Integer.TryParse(txtnum1.Text, num)

        If IsPrime(num) Then
            lblresult.Text = "Prime"

        Else
            lblresult.Text = "Not Prime"
        End If
    End Sub
    Function IsPrime(ByVal num As Integer) As Boolean
        If num <= 1 Then
            Return False
        End If

        For i As Integer = 2 To Math.Sqrt(num)
            If num Mod i = 0 Then
                Return False
            End If
        Next

        Return True
    End Function
End Class
