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
        Me.radLarge = New System.Windows.Forms.RadioButton()
        Me.radMedium = New System.Windows.Forms.RadioButton()
        Me.radSmall = New System.Windows.Forms.RadioButton()
        Me.chkMushroom = New System.Windows.Forms.CheckBox()
        Me.chkPepperoni = New System.Windows.Forms.CheckBox()
        Me.chkAnchovy = New System.Windows.Forms.CheckBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'radLarge
        '
        Me.radLarge.AutoSize = True
        Me.radLarge.Location = New System.Drawing.Point(58, 47)
        Me.radLarge.Name = "radLarge"
        Me.radLarge.Size = New System.Drawing.Size(80, 29)
        Me.radLarge.TabIndex = 0
        Me.radLarge.TabStop = True
        Me.radLarge.Text = "Large"
        Me.radLarge.UseVisualStyleBackColor = True
        '
        'radMedium
        '
        Me.radMedium.AutoSize = True
        Me.radMedium.Location = New System.Drawing.Point(58, 107)
        Me.radMedium.Name = "radMedium"
        Me.radMedium.Size = New System.Drawing.Size(103, 29)
        Me.radMedium.TabIndex = 1
        Me.radMedium.TabStop = True
        Me.radMedium.Text = "Medium"
        Me.radMedium.UseVisualStyleBackColor = True
        '
        'radSmall
        '
        Me.radSmall.AutoSize = True
        Me.radSmall.Location = New System.Drawing.Point(58, 167)
        Me.radSmall.Name = "radSmall"
        Me.radSmall.Size = New System.Drawing.Size(80, 29)
        Me.radSmall.TabIndex = 2
        Me.radSmall.TabStop = True
        Me.radSmall.Text = "Small"
        Me.radSmall.UseVisualStyleBackColor = True
        '
        'chkMushroom
        '
        Me.chkMushroom.AutoSize = True
        Me.chkMushroom.Location = New System.Drawing.Point(235, 48)
        Me.chkMushroom.Name = "chkMushroom"
        Me.chkMushroom.Size = New System.Drawing.Size(126, 29)
        Me.chkMushroom.TabIndex = 3
        Me.chkMushroom.Text = "Mushroom"
        Me.chkMushroom.UseVisualStyleBackColor = True
        '
        'chkPepperoni
        '
        Me.chkPepperoni.AutoSize = True
        Me.chkPepperoni.Location = New System.Drawing.Point(235, 107)
        Me.chkPepperoni.Name = "chkPepperoni"
        Me.chkPepperoni.Size = New System.Drawing.Size(118, 29)
        Me.chkPepperoni.TabIndex = 4
        Me.chkPepperoni.Text = "Pepperoni"
        Me.chkPepperoni.UseVisualStyleBackColor = True
        '
        'chkAnchovy
        '
        Me.chkAnchovy.AutoSize = True
        Me.chkAnchovy.Location = New System.Drawing.Point(235, 168)
        Me.chkAnchovy.Name = "chkAnchovy"
        Me.chkAnchovy.Size = New System.Drawing.Size(107, 29)
        Me.chkAnchovy.TabIndex = 5
        Me.chkAnchovy.Text = "Anchovy"
        Me.chkAnchovy.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(58, 285)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(112, 34)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(235, 285)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(112, 34)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(121, 227)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Total"
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.White
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(235, 227)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(94, 38)
        Me.lblTotal.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.chkAnchovy)
        Me.Controls.Add(Me.chkPepperoni)
        Me.Controls.Add(Me.chkMushroom)
        Me.Controls.Add(Me.radSmall)
        Me.Controls.Add(Me.radMedium)
        Me.Controls.Add(Me.radLarge)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents redLarge As RadioButton
    Friend WithEvents radMedium As RadioButton
    Friend WithEvents radSmall As RadioButton
    Friend WithEvents chkMushroom As CheckBox
    Friend WithEvents chkPepperoni As CheckBox
    Friend WithEvents chkAnchovy As CheckBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents radLarge As RadioButton
End Class
