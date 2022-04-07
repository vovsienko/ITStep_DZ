Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblX.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        lblX.Text = e.X
        lblY.Text = e.Y
    End Sub
End Class
