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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnBackground = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.CheckBox1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(953, 404)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TableLayoutPanel1.SetColumnSpan(Me.PictureBox1, 2)
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(947, 357)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("MV Boli", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CheckBox1.Location = New System.Drawing.Point(3, 366)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBox1.Size = New System.Drawing.Size(102, 27)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.Text = "Stretch"
        Me.CheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnShow)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnClear)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnBackground)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnClose)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(145, 366)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(805, 35)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'btnShow
        '
        Me.btnShow.AutoSize = True
        Me.btnShow.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnShow.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnShow.Font = New System.Drawing.Font("MV Boli", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnShow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnShow.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnShow.Location = New System.Drawing.Point(608, 2)
        Me.btnShow.Margin = New System.Windows.Forms.Padding(2)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(195, 36)
        Me.btnShow.TabIndex = 0
        Me.btnShow.Text = "Show a picture"
        Me.btnShow.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.AutoSize = True
        Me.btnClear.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnClear.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("MV Boli", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClear.Location = New System.Drawing.Point(409, 2)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(195, 36)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear a picture"
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnBackground
        '
        Me.btnBackground.AutoSize = True
        Me.btnBackground.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnBackground.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBackground.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBackground.Font = New System.Drawing.Font("MV Boli", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBackground.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBackground.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBackground.Location = New System.Drawing.Point(145, 2)
        Me.btnBackground.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBackground.Name = "btnBackground"
        Me.btnBackground.Size = New System.Drawing.Size(260, 36)
        Me.btnBackground.TabIndex = 2
        Me.btnBackground.Text = "Set the background color"
        Me.btnBackground.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBackground.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("MV Boli", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClose.Location = New System.Drawing.Point(6, 2)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(135, 36)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" &
    "s (*.*)|*.*"
        Me.OpenFileDialog1.Title = "Select a picture file"
        '
        'Form1
        '
        Me.AcceptButton = Me.btnShow
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(953, 404)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("MV Boli", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Picture Viewer"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnShow As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnBackground As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ColorDialog1 As ColorDialog
End Class
