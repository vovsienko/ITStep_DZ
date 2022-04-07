Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler cmnuEditCut.Click, AddressOf Me.mnuEditCut_Click
        AddHandler tbtnEditCut.Click, AddressOf Me.mnuEditCut_Click
    End Sub

    Private Sub mnuEditCut_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuEditCut.Click
        txtEdit.Cut()
    End Sub

    Private Sub mnuEditCopy_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
Handles mnuEditCopy.Click, cmnuEditCopy.Click, tbtnEditCopy.Click
        txtEdit.Copy()

    End Sub

    Private Sub mnuEditPaste_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuEditPaste.Click
        txtEdit.Paste()
    End Sub

    Private Sub cmnuEditPaste_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmnuEditPaste.Click
        mnuEditPaste_Click(sender, e)
    End Sub

    Private Sub tbtnEditPaste_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbtnEditPaste.Click
        mnuEditPaste_Click(sender, e)
    End Sub
End Class
