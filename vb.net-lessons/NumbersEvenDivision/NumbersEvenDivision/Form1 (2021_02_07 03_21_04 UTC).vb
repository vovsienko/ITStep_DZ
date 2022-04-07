Public Class Form1

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click

        Dim num1, num2, divnum As Integer
        Dim found As Boolean
        num1 = Integer.Parse(txtFirst.Text)
        num2 = Integer.Parse(txtSecond.Text)
        For divnum = 1 To 100
            If divnum Mod num1 = 0 And divnum Mod num2 = 0 Then
                Debug.Write(divnum & " is evenly divisible by " & num1 & " and " & num2)
                found = True
                Exit For
            End If
        Next divnum
        If Not found Then
            Debug.Write("No number between 1 and 100 " &
   "is evenly divisible by " & num1 & " and " & num2)
        End If

    End Sub

End Class
