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
        Me.radAdd = New System.Windows.Forms.RadioButton()
        Me.radSubtract = New System.Windows.Forms.RadioButton()
        Me.radMultiply = New System.Windows.Forms.RadioButton()
        Me.radDivide = New System.Windows.Forms.RadioButton()
        Me.txtOp1 = New System.Windows.Forms.TextBox()
        Me.txtOp2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'radAdd
        '
        Me.radAdd.AutoSize = True
        Me.radAdd.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.radAdd.Location = New System.Drawing.Point(31, 71)
        Me.radAdd.Name = "radAdd"
        Me.radAdd.Size = New System.Drawing.Size(50, 29)
        Me.radAdd.TabIndex = 0
        Me.radAdd.TabStop = True
        Me.radAdd.Text = "+"
        Me.radAdd.UseVisualStyleBackColor = True
        '
        'radSubtract
        '
        Me.radSubtract.AutoSize = True
        Me.radSubtract.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.radSubtract.Location = New System.Drawing.Point(31, 122)
        Me.radSubtract.Name = "radSubtract"
        Me.radSubtract.Size = New System.Drawing.Size(44, 29)
        Me.radSubtract.TabIndex = 1
        Me.radSubtract.TabStop = True
        Me.radSubtract.Text = "-"
        Me.radSubtract.UseVisualStyleBackColor = True
        '
        'radMultiply
        '
        Me.radMultiply.AutoSize = True
        Me.radMultiply.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.radMultiply.Location = New System.Drawing.Point(31, 180)
        Me.radMultiply.Name = "radMultiply"
        Me.radMultiply.Size = New System.Drawing.Size(45, 29)
        Me.radMultiply.TabIndex = 2
        Me.radMultiply.TabStop = True
        Me.radMultiply.Text = "*"
        Me.radMultiply.UseVisualStyleBackColor = True
        '
        'radDivide
        '
        Me.radDivide.AutoSize = True
        Me.radDivide.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.radDivide.Location = New System.Drawing.Point(31, 235)
        Me.radDivide.Name = "radDivide"
        Me.radDivide.Size = New System.Drawing.Size(45, 29)
        Me.radDivide.TabIndex = 3
        Me.radDivide.TabStop = True
        Me.radDivide.Text = "/"
        Me.radDivide.UseVisualStyleBackColor = True
        '
        'txtOp1
        '
        Me.txtOp1.Location = New System.Drawing.Point(273, 59)
        Me.txtOp1.Name = "txtOp1"
        Me.txtOp1.Size = New System.Drawing.Size(150, 31)
        Me.txtOp1.TabIndex = 4
        '
        'txtOp2
        '
        Me.txtOp2.Location = New System.Drawing.Point(490, 59)
        Me.txtOp2.Name = "txtOp2"
        Me.txtOp2.Size = New System.Drawing.Size(150, 31)
        Me.txtOp2.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(273, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Result"
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.Color.White
        Me.lblResult.Location = New System.Drawing.Point(490, 148)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(94, 38)
        Me.lblResult.TabIndex = 7
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(273, 230)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(112, 34)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(490, 235)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(112, 34)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtOp2)
        Me.Controls.Add(Me.txtOp1)
        Me.Controls.Add(Me.radDivide)
        Me.Controls.Add(Me.radMultiply)
        Me.Controls.Add(Me.radSubtract)
        Me.Controls.Add(Me.radAdd)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents radAdd As RadioButton
    Friend WithEvents radSubtract As RadioButton
    Friend WithEvents radMultiply As RadioButton
    Friend WithEvents radDivide As RadioButton
    Friend WithEvents txtOp1 As TextBox
    Friend WithEvents txtOp2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
End Class
