Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim strFile As String
        Dim dr As DialogResult
        dr = dlgOpen.ShowDialog()
        If dr = Windows.Forms.DialogResult.OK Then
            strFile = dlgOpen.FileName
            MessageBox.Show("File Selected " & strFile)
        Else
            MessageBox.Show("Cancel button clicked")
        End If
    End Sub
End Class
