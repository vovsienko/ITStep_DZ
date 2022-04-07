Imports System.IO

Public Class Form1
    Inherits System.Windows.Forms.Form
    Private Sub Form1_Load(ByVal sender As System.Object,
    ByVal e As System.EventArgs) Handles Me.Load
        Dim strFile As String
        Dim dr As DialogResult
        Dim blnContinue As Boolean
        Do
            dr = dlgOpen.ShowDialog()
            If dr = Windows.Forms.DialogResult.OK Then
                strFile = dlgOpen.FileName
                Dim readerVar As StreamReader
                readerVar = New StreamReader(strFile)
                txtData.Text = readerVar.ReadToEnd
                readerVar.Close()
                blnContinue = False
            Else
                'MessageBox.Show("Try again to choose file?", "Try again?", MessageBoxButtons.YesNo)
                'MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo)

                dr = MessageBox.Show("Try again to choose file?", "Try again?", MessageBoxButtons.YesNo)
                If dr = Windows.Forms.DialogResult.Yes Then
                    blnContinue = True
                Else
                    blnContinue = False
                End If
            End If
        Loop While blnContinue = True
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object,
ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim strFile As String
        Dim dr As DialogResult
        dr = dlgSave.ShowDialog()
        If dr = Windows.Forms.DialogResult.OK Then
            strFile = dlgSave.FileName
            Dim writerVar As StreamWriter
            writerVar = New StreamWriter(strFile, False)
            writerVar.Write(txtData.Text)
            writerVar.Close()
        End If
    End Sub
End Class
