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
        Me.txtEdit = New System.Windows.Forms.TextBox()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.dlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'txtEdit
        '
        Me.txtEdit.Location = New System.Drawing.Point(174, 23)
        Me.txtEdit.Multiline = True
        Me.txtEdit.Name = "txtEdit"
        Me.txtEdit.Size = New System.Drawing.Size(436, 264)
        Me.txtEdit.TabIndex = 0
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(174, 312)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(112, 34)
        Me.btnOpen.TabIndex = 1
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(498, 312)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(112, 34)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'dlgOpen
        '
        Me.dlgOpen.FileName = "OpenFileDialog1"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(660, 92)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(146, 29)
        Me.RadioButton1.TabIndex = 3
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.txtEdit)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEdit As TextBox
    Friend WithEvents btnOpen As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents dlgOpen As OpenFileDialog
    Friend WithEvents dlgSave As SaveFileDialog
    Friend WithEvents RadioButton1 As RadioButton
End Class
