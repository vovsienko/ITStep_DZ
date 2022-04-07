Public Class Form1

    Const LARGE As Double = 10
    Const MEDIUM As Double = 7.5
    Const SMALL As Double = 5
    Const TOPPING As Double = 0.5

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim dblTotal As Double
        If radLarge.Checked = True Then
            dblTotal = LARGE
        ElseIf radMedium.Checked = True Then
            dblTotal = MEDIUM
        Else
            dblTotal = SMALL
        End If
        If chkMushroom.Checked = True Then
            dblTotal += TOPPING
        End If
        If chkPepperoni.Checked = True Then
            dblTotal += TOPPING
        End If
        If chkAnchovy.Checked = True Then
            dblTotal += TOPPING
        End If
        lblTotal.Text = dblTotal.ToString("c")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        radLarge.Checked = True
        radMedium.Checked = False
        radSmall.Checked = False
        chkMushroom.Checked = False
        chkPepperoni.Checked = False
        chkAnchovy.Checked = False
        lblTotal.Text = ""
    End Sub
End Class
