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
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPlusLeft = New System.Windows.Forms.Label()
        Me.lblPlusRight = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Sum = New System.Windows.Forms.NumericUpDown()
        Me.difference = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMinusRight = New System.Windows.Forms.Label()
        Me.lblMinusLeft = New System.Windows.Forms.Label()
        Me.product = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTimesRight = New System.Windows.Forms.Label()
        Me.lblTimesLeft = New System.Windows.Forms.Label()
        Me.quotient = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblDividedRight = New System.Windows.Forms.Label()
        Me.lblDividedLeft = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Sum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.difference, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.quotient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTime
        '
        Me.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTime.Location = New System.Drawing.Point(221, 9)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(205, 40)
        Me.lblTime.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(57, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Time Left"
        '
        'lblPlusLeft
        '
        Me.lblPlusLeft.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPlusLeft.Location = New System.Drawing.Point(85, 70)
        Me.lblPlusLeft.Name = "lblPlusLeft"
        Me.lblPlusLeft.Size = New System.Drawing.Size(60, 50)
        Me.lblPlusLeft.TabIndex = 2
        Me.lblPlusLeft.Text = "?"
        Me.lblPlusLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlusRight
        '
        Me.lblPlusRight.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPlusRight.Location = New System.Drawing.Point(189, 72)
        Me.lblPlusRight.Name = "lblPlusRight"
        Me.lblPlusRight.Size = New System.Drawing.Size(60, 50)
        Me.lblPlusRight.TabIndex = 6
        Me.lblPlusRight.Text = "?"
        Me.lblPlusRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(239, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 50)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "="
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Sum
        '
        Me.Sum.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Sum.Location = New System.Drawing.Point(293, 72)
        Me.Sum.Name = "Sum"
        Me.Sum.Size = New System.Drawing.Size(100, 48)
        Me.Sum.TabIndex = 2
        '
        'difference
        '
        Me.difference.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.difference.Location = New System.Drawing.Point(293, 126)
        Me.difference.Name = "difference"
        Me.difference.Size = New System.Drawing.Size(100, 48)
        Me.difference.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(137, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 50)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "-"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(241, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 50)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "="
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMinusRight
        '
        Me.lblMinusRight.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblMinusRight.Location = New System.Drawing.Point(189, 125)
        Me.lblMinusRight.Name = "lblMinusRight"
        Me.lblMinusRight.Size = New System.Drawing.Size(60, 50)
        Me.lblMinusRight.TabIndex = 11
        Me.lblMinusRight.Text = "?"
        Me.lblMinusRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMinusLeft
        '
        Me.lblMinusLeft.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblMinusLeft.Location = New System.Drawing.Point(85, 127)
        Me.lblMinusLeft.Name = "lblMinusLeft"
        Me.lblMinusLeft.Size = New System.Drawing.Size(60, 50)
        Me.lblMinusLeft.TabIndex = 8
        Me.lblMinusLeft.Text = "?"
        Me.lblMinusLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'product
        '
        Me.product.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.product.Location = New System.Drawing.Point(293, 180)
        Me.product.Name = "product"
        Me.product.Size = New System.Drawing.Size(100, 48)
        Me.product.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(137, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 50)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "×"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(241, 179)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 50)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "="
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTimesRight
        '
        Me.lblTimesRight.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTimesRight.Location = New System.Drawing.Point(189, 178)
        Me.lblTimesRight.Name = "lblTimesRight"
        Me.lblTimesRight.Size = New System.Drawing.Size(60, 50)
        Me.lblTimesRight.TabIndex = 16
        Me.lblTimesRight.Text = "?"
        Me.lblTimesRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTimesLeft
        '
        Me.lblTimesLeft.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTimesLeft.Location = New System.Drawing.Point(85, 179)
        Me.lblTimesLeft.Name = "lblTimesLeft"
        Me.lblTimesLeft.Size = New System.Drawing.Size(60, 50)
        Me.lblTimesLeft.TabIndex = 13
        Me.lblTimesLeft.Text = "?"
        Me.lblTimesLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'quotient
        '
        Me.quotient.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.quotient.Location = New System.Drawing.Point(293, 228)
        Me.quotient.Name = "quotient"
        Me.quotient.Size = New System.Drawing.Size(100, 48)
        Me.quotient.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label13.Location = New System.Drawing.Point(137, 228)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 50)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "÷"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label14.Location = New System.Drawing.Point(241, 231)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 50)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "="
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDividedRight
        '
        Me.lblDividedRight.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDividedRight.Location = New System.Drawing.Point(189, 229)
        Me.lblDividedRight.Name = "lblDividedRight"
        Me.lblDividedRight.Size = New System.Drawing.Size(60, 50)
        Me.lblDividedRight.TabIndex = 21
        Me.lblDividedRight.Text = "?"
        Me.lblDividedRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDividedLeft
        '
        Me.lblDividedLeft.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDividedLeft.Location = New System.Drawing.Point(85, 231)
        Me.lblDividedLeft.Name = "lblDividedLeft"
        Me.lblDividedLeft.Size = New System.Drawing.Size(60, 50)
        Me.lblDividedLeft.TabIndex = 18
        Me.lblDividedLeft.Text = "?"
        Me.lblDividedLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnStart
        '
        Me.btnStart.AutoSize = True
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnStart.Location = New System.Drawing.Point(141, 298)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(197, 42)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start the Quiz"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(137, 72)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 50)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "+"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 344)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.quotient)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblDividedRight)
        Me.Controls.Add(Me.lblDividedLeft)
        Me.Controls.Add(Me.product)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblTimesRight)
        Me.Controls.Add(Me.lblTimesLeft)
        Me.Controls.Add(Me.difference)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblMinusRight)
        Me.Controls.Add(Me.lblMinusLeft)
        Me.Controls.Add(Me.Sum)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblPlusRight)
        Me.Controls.Add(Me.lblPlusLeft)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTime)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Math Quiz"
        CType(Me.Sum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.difference, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.quotient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTime As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPlusLeft As Label
    Friend WithEvents lblPlusRight As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Sum As NumericUpDown
    Friend WithEvents difference As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblMinusRight As Label
    Friend WithEvents lblMinusLeft As Label
    Friend WithEvents product As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblTimesRight As Label
    Friend WithEvents lblTimesLeft As Label
    Friend WithEvents quotient As NumericUpDown
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblDividedRight As Label
    Friend WithEvents lblDividedLeft As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Timer1 As Timer
End Class
