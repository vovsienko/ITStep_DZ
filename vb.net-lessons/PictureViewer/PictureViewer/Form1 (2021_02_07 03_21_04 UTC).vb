Public Class Form1
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        'Show the Open File dialogue. If the user clicks OK, 
        'load the picture that the user chose.

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.Load(OpenFileDialog1.FileName)
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear the picture
        PictureBox1.Image = Nothing

    End Sub

    Private Sub btnBackground_Click(sender As Object, e As EventArgs) Handles btnBackground.Click
        'Show the colour dialogue box. If the user clicks OK, change the 
        'PictureBox's control's background to the colour the user chose.
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Close the form
        Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        ' If the user selects the Stretch check box, change 
        ' the PictureBox's SizeMode property to "Stretch". If the user 
        ' clears the check box, change it to "Normal".
        If CheckBox1.Checked Then
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            PictureBox1.SizeMode = PictureBoxSizeMode.Normal
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub
End Class
