<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.dlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.dlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.txtData = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tbtnFileOpen = New System.Windows.Forms.ToolStripButton()
        Me.tbtnFileSave = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dlgOpen
        '
        Me.dlgOpen.FileName = "dlgOpen"
        '
        'MenuStrip
        '
        Me.MenuStrip.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(800, 33)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileOpen, Me.mnuFileSave})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(54, 29)
        Me.mnuFile.Text = "File"
        '
        'mnuFileOpen
        '
        Me.mnuFileOpen.Name = "mnuFileOpen"
        Me.mnuFileOpen.Size = New System.Drawing.Size(270, 34)
        Me.mnuFileOpen.Text = "Open"
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Name = "mnuFileSave"
        Me.mnuFileSave.Size = New System.Drawing.Size(270, 34)
        Me.mnuFileSave.Text = "Save"
        '
        'txtData
        '
        Me.txtData.Location = New System.Drawing.Point(160, 62)
        Me.txtData.Multiline = True
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(471, 305)
        Me.txtData.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbtnFileOpen, Me.tbtnFileSave})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 33)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 33)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tbtnFileOpen
        '
        Me.tbtnFileOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbtnFileOpen.Image = CType(resources.GetObject("tbtnFileOpen.Image"), System.Drawing.Image)
        Me.tbtnFileOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtnFileOpen.Name = "tbtnFileOpen"
        Me.tbtnFileOpen.Size = New System.Drawing.Size(34, 28)
        Me.tbtnFileOpen.ToolTipText = "Open"
        '
        'tbtnFileSave
        '
        Me.tbtnFileSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbtnFileSave.Image = CType(resources.GetObject("tbtnFileSave.Image"), System.Drawing.Image)
        Me.tbtnFileSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtnFileSave.Name = "tbtnFileSave"
        Me.tbtnFileSave.Size = New System.Drawing.Size(34, 28)
        Me.tbtnFileSave.ToolTipText = "Save"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dlgOpen As OpenFileDialog
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileOpen As ToolStripMenuItem
    Friend WithEvents mnuFileSave As ToolStripMenuItem
    Friend WithEvents dlgSave As SaveFileDialog
    Friend WithEvents txtData As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tbtnFileOpen As ToolStripButton
    Friend WithEvents tbtnFileSave As ToolStripButton
End Class
