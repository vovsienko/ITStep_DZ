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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtEdit = New System.Windows.Forms.TextBox()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmnuEditCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuEditCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuEditPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.tbtnEditCut = New System.Windows.Forms.ToolStripButton()
        Me.tbtnEditCopy = New System.Windows.Forms.ToolStripButton()
        Me.tbtnEditPaste = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip.SuspendLayout()
        Me.ContextMenuStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtEdit
        '
        Me.txtEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEdit.Location = New System.Drawing.Point(201, 78)
        Me.txtEdit.Multiline = True
        Me.txtEdit.Name = "txtEdit"
        Me.txtEdit.Size = New System.Drawing.Size(382, 272)
        Me.txtEdit.TabIndex = 0
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEdit})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(800, 33)
        Me.MenuStrip.TabIndex = 1
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEditCut, Me.mnuEditCopy, Me.mnuEditPaste})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(58, 29)
        Me.mnuEdit.Text = "Edit"
        '
        'mnuEditCut
        '
        Me.mnuEditCut.Name = "mnuEditCut"
        Me.mnuEditCut.Size = New System.Drawing.Size(156, 34)
        Me.mnuEditCut.Text = "Cut"
        '
        'mnuEditCopy
        '
        Me.mnuEditCopy.Name = "mnuEditCopy"
        Me.mnuEditCopy.Size = New System.Drawing.Size(156, 34)
        Me.mnuEditCopy.Text = "Copy"
        '
        'mnuEditPaste
        '
        Me.mnuEditPaste.Name = "mnuEditPaste"
        Me.mnuEditPaste.Size = New System.Drawing.Size(156, 34)
        Me.mnuEditPaste.Text = "Paste"
        '
        'ContextMenuStrip
        '
        Me.ContextMenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmnuEditCut, Me.cmnuEditCopy, Me.cmnuEditPaste})
        Me.ContextMenuStrip.Name = "ContextMenuStrip"
        Me.ContextMenuStrip.ShowImageMargin = False
        Me.ContextMenuStrip.Size = New System.Drawing.Size(102, 100)
        '
        'cmnuEditCut
        '
        Me.cmnuEditCut.Name = "cmnuEditCut"
        Me.cmnuEditCut.Size = New System.Drawing.Size(101, 32)
        Me.cmnuEditCut.Text = "Cut"
        '
        'cmnuEditCopy
        '
        Me.cmnuEditCopy.Name = "cmnuEditCopy"
        Me.cmnuEditCopy.Size = New System.Drawing.Size(101, 32)
        Me.cmnuEditCopy.Text = "Copy"
        '
        'cmnuEditPaste
        '
        Me.cmnuEditPaste.Name = "cmnuEditPaste"
        Me.cmnuEditPaste.Size = New System.Drawing.Size(101, 32)
        Me.cmnuEditPaste.Text = "Paste"
        '
        'ToolStrip
        '
        Me.ToolStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbtnEditCut, Me.tbtnEditCopy, Me.tbtnEditPaste})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 33)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(800, 33)
        Me.ToolStrip.TabIndex = 2
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'tbtnEditCut
        '
        Me.tbtnEditCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbtnEditCut.Image = CType(resources.GetObject("tbtnEditCut.Image"), System.Drawing.Image)
        Me.tbtnEditCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtnEditCut.Name = "tbtnEditCut"
        Me.tbtnEditCut.Size = New System.Drawing.Size(34, 28)
        Me.tbtnEditCut.ToolTipText = "Cut"
        '
        'tbtnEditCopy
        '
        Me.tbtnEditCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbtnEditCopy.Image = CType(resources.GetObject("tbtnEditCopy.Image"), System.Drawing.Image)
        Me.tbtnEditCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtnEditCopy.Name = "tbtnEditCopy"
        Me.tbtnEditCopy.Size = New System.Drawing.Size(34, 28)
        Me.tbtnEditCopy.ToolTipText = "Copy"
        '
        'tbtnEditPaste
        '
        Me.tbtnEditPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbtnEditPaste.Image = CType(resources.GetObject("tbtnEditPaste.Image"), System.Drawing.Image)
        Me.tbtnEditPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtnEditPaste.Name = "tbtnEditPaste"
        Me.tbtnEditPaste.Size = New System.Drawing.Size(34, 28)
        Me.tbtnEditPaste.ToolTipText = "Paste"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.txtEdit)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ContextMenuStrip.ResumeLayout(False)
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEdit As TextBox
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents mnuEdit As ToolStripMenuItem
    Friend WithEvents mnuEditCut As ToolStripMenuItem
    Friend WithEvents mnuEditCopy As ToolStripMenuItem
    Friend WithEvents mnuEditPaste As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip As ContextMenuStrip
    Friend WithEvents cmnuEditCut As ToolStripMenuItem
    Friend WithEvents cmnuEditCopy As ToolStripMenuItem
    Friend WithEvents cmnuEditPaste As ToolStripMenuItem
    Friend WithEvents ToolStrip As ToolStrip
    Friend WithEvents tbtnEditCut As ToolStripButton
    Friend WithEvents tbtnEditCopy As ToolStripButton
    Friend WithEvents tbtnEditPaste As ToolStripButton
End Class
