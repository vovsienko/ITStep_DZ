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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblX = New System.Windows.Forms.Label()
        Me.lblY = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(81, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "X Coordinate"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(81, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 40)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Y Coordinate"
        '
        'lblX
        '
        Me.lblX.BackColor = System.Drawing.Color.White
        Me.lblX.Location = New System.Drawing.Point(267, 39)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(70, 40)
        Me.lblX.TabIndex = 2
        '
        'lblY
        '
        Me.lblY.BackColor = System.Drawing.Color.White
        Me.lblY.Location = New System.Drawing.Point(267, 84)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(70, 40)
        Me.lblY.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblY)
        Me.Controls.Add(Me.lblX)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblX As Label
    Friend WithEvents lblY As Label

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class
