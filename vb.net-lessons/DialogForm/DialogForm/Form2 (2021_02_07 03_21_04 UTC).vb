Public Class Form2
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim frm As Form1
        frm = CType(Me.Owner, Form1)
        txtNewCaption.Text = frm.Text
    End Sub

    Private Sub btnOK_Click(ByVal sender As Object,
ByVal e As System.EventArgs) Handles btnOK.Click
        'Dim str As String
        'str = txtNewCaption.Text.Trim
        'If str.Length = 0 Then

        'combined version of the above 3 lines:
        If txtNewCaption.Text.Trim.Length = 0 Then

            MessageBox.Show("Type text or click Cancel")
            Me.DialogResult = Windows.Forms.DialogResult.None
            txtNewCaption.Focus()
        End If
    End Sub
End Class