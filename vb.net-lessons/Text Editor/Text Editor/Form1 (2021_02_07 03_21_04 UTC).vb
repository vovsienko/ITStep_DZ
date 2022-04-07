Imports System.IO
Public Class Form1
    Private Sub btnOpen_Click(sender As Object,
 e As EventArgs) Handles btnOpen.Click
        Dim readerVar As StreamReader
        Dim dr As DialogResult
        dr = dlgOpen.ShowDialog()
        If dr = DialogResult.OK Then
            'Debug.WriteLine("Open button was clicked")
            'Debug.WriteLine(dlgOpen.FileName)
            readerVar = New StreamReader(dlgOpen.FileName)
            txtEdit.Text = readerVar.ReadToEnd()
            readerVar.Close()
            'Else
            '    Debug.WriteLine("Cancel button was clicked")
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        dlgSave.Filter = "TXT Files (*.txt*)|*.txt"
        Dim dr As DialogResult
        dlgSave.FileName = dlgOpen.FileName   '//set FileName property to the corresponding property of the Open dialog box to show the filename in the Save dialog box will show the file that's opened
        dr = dlgSave.ShowDialog()
        If dr = DialogResult.OK Then
            'Debug.WriteLine(dlgSave.FileName)
            Dim writerVar As StreamWriter
            writerVar = New StreamWriter(dlgSave.FileName, False)

            'The value of this second argument is True if you want to add to the existing contents of the text file and False if instead you want to overwrite the existing contents of the text file.

            'If you instead wanted to add to the existing contents of the file, you would use True instead of False as the second argument of the StreamWriter constructor. One example would be a log file, which logs events or problems. Normally, you'd want to add a new event or problem to the prior list, not erase the prior list in the process.

            writerVar.Write(txtEdit.Text)
            writerVar.Close()

        End If
    End Sub
End Class
