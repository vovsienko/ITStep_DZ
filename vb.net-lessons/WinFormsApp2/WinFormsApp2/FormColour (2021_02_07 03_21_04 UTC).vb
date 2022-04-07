Public Class FormColour
    Private Sub FormColour_Click(sender As Object, e As EventArgs) Handles Me.Click
        'Me.BackColor = System.Drawing.Color.Red
        Me.BackColor = Color.Red
        Me.Text = "Clicked"

    End Sub

    Private Sub FormColour_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        'Me.BackColor = System.Drawing.Color.Green
        Me.BackColor = Color.Green
        Me.Text = "Double Clicked"
    End Sub
End Class
