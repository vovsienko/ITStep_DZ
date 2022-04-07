Imports System.IO
Public Class Form1
    Dim filename As String

    'beginning of btnOpen_Click procedure
    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Dim readerVar As StreamReader
        Dim dr As DialogResult
        dr = dlgOpen.ShowDialog()
        If dr = DialogResult.OK Then
            filename = dlgOpen.FileName
            readerVar = New StreamReader(dlgOpen.FileName)
            txtEdit.Text = readerVar.ReadToEnd()
            readerVar.Close()  '// comment this line for testing exceptions
            btnOpen.Enabled = False
            btnSave.Enabled = True
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim dr As DialogResult
        dlgSave.FileName = filename
        dr = dlgSave.ShowDialog()
        If dr = DialogResult.OK Then
            Dim writerVar As StreamWriter
            writerVar = New StreamWriter(filename, False)
            writerVar.WriteLine(txtEdit.Text)
            writerVar.Close()
        End If
    End Sub
End Class
