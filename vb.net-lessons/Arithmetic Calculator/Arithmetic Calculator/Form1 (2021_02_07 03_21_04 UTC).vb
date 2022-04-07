Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Dim Op1 As Double
        'Dim OP2 As Double
        'Dim dblResult As Double

        'If radAdd.Checked = True Then
        '    lblResult.Text = Op1 + OP2
        'ElseIf radSubstract.Checked = True Then
        '    dblResult = Op1 - OP2
        'ElseIf radMultiply.Checked = True Then
        '    dblResult = Op1 * OP2
        'Else
        '    radDivide.Checked = True
        '    dblResult = Op1 / OP2
        '    If OP2 = 0 Then
        '        lblResult.Text = "No division by zero"
        '    End If
        'End If

        'lblResult.Text = lblResult.ToString()

        Dim intFirst As Integer = Integer.Parse(txtOp1.Text)
        Dim intSecond As Integer = Integer.Parse(txtOp2.Text)
        If radAdd.Checked = True Then
            lblResult.Text = (intFirst + intSecond).ToString
        ElseIf radSubtract.Checked = True Then
            lblResult.Text = (intFirst - intSecond).ToString
        ElseIf radMultiply.Checked = True Then
            lblResult.Text = (intFirst * intSecond).ToString
        Else
            If intSecond = 0 Then
                lblResult.Text = "No division by zero"
            Else
                lblResult.Text = (intFirst / intSecond).ToString
            End If
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtOp1.Text = ""
        txtOp2.Text = ""
        lblResult.Text = ""

    End Sub
End Class
