Public Class Form1
    Private Sub Form1_Click(sender As Object,
 e As EventArgs) Handles Me.Click
        Const PIXELS_TO_INCHES As Double = 1 / 96
        Debug.Write(Me.Height)
        Debug.WriteLine(" pixels =")
        Debug.Write(Me.Height * PIXELS_TO_INCHES)
        Debug.WriteLine(" inches")
    End Sub
End Class
