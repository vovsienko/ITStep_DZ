Imports System.IO
Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object,
    ByVal e As System.EventArgs) Handles Me.Load
        mnuFileSave.Enabled = False
        tbtnFileSave.Enabled = False

    End Sub

    Private Sub mnuFileOpen_Click(ByVal sender As Object,
    ByVal e As System.EventArgs) Handles mnuFileOpen.Click, tbtnFileOpen.Click
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
                dr = MessageBox.Show("Try again to choose file?",
                   "Try again?", MessageBoxButtons.YesNo)
                If dr = Windows.Forms.DialogResult.Yes Then
                    blnContinue = True
                Else
                    blnContinue = False
                    Exit Sub
                End If
            End If
        Loop While blnContinue = True
        mnuFileSave.Enabled = True
        mnuFileOpen.Enabled = False
        tbtnFileSave.Enabled = True
        tbtnFileOpen.Enabled = False
    End Sub

    Private Sub mnuFileSave_Click(ByVal sender As Object,
    ByVal e As System.EventArgs) Handles mnuFileSave.Click, tbtnFileSave.Click
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