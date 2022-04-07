Public Class Form1
    'Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    AddHandler cmnuEditSelectAll.Click, AddressOf Me.mnuEditSelectAll_Click
    'End Sub

    Private Sub mnuFileNew_Click(ByVal sender As System.Object,
 ByVal e As System.EventArgs) Handles mnuFileNew.Click
        Debug.WriteLine("New")
    End Sub

    '   Private Sub mnuEditSelectAll_Click(ByVal sender As Object,
    'ByVal e As System.EventArgs) Handles mnuEditSelectAll.Click, cmnuEditSelectAll.Click
    '       txtEdit.SelectAll()
    '   End Sub

    '   Private Sub cmnuEditSelectAll_Click(ByVal sender As System.Object,
    'ByVal e As System.EventArgs) Handles cmnuEditSelectAll.Click
    '       mnuEditSelectAll_Click(sender, e)
    '   End Sub


End Class
