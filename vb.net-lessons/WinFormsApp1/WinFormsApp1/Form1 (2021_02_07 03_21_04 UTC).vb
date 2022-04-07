Public Class Form1
    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Debug.Write(e.X & "," & e.Y & " ")

    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        Me.Text = "Clicked"

    End Sub
End Class
