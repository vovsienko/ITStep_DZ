Public Class Form1
    Private Sub btnNewCaption_Click(sender As Object, e As EventArgs) Handles btnNewCaption.Click
        Dim frmCaption As New Form2
        frmCaption.ShowDialog(Me)
        If frmCaption.DialogResult = Windows.Forms.DialogResult.OK Then
            Me.Text = frmCaption.txtNewCaption.Text
        End If

        'comparison, if the form had three buttons - Yes, No, Cancel
        '       If frmCaption.DialogResult =
        'Windows.Forms.DialogResult.Yes Then
        '           ' execute code based on user clicking Yes button
        '       ElseIf frmCaption.DialogResult =
        '        Windows.Forms.DialogResult.No Then
        '           ' execute code based on user clicking No button
        '       Else
        '           ' execute code based on user clicking Cancel button
        '       End If

        'to prevent from closing
        'Me.DialogResult = Windows.Forms.DialogResult.None
    End Sub
End Class
