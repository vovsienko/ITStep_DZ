Public Class Form1
    Private Sub btnCalculate_Click(sender As Object,
 e As EventArgs) Handles btnCalculate.Click
        Dim intLeftover As Integer
        Debug.WriteLine("Total Pennies: " & txtPennies.Text)
        intLeftover = Integer.Parse(txtPennies.Text)
        lblDollars.Text = (intLeftover \ 100).ToString
        Debug.WriteLine("Dollars: " & lblDollars.Text)
        intLeftover = intLeftover Mod 100
        lblQuarters.Text = (intLeftover \ 25).ToString
        Debug.WriteLine("Quarters: " & lblQuarters.Text)
        intLeftover = intLeftover Mod 25
        lblDimes.Text = (intLeftover \ 10).ToString
        Debug.WriteLine("Dimes: " & lblDimes.Text)
        intLeftover = intLeftover Mod 10
        lblNickels.Text = (intLeftover \ 5).ToString
        Debug.WriteLine("Nickels: " & lblNickels.Text)
        intLeftover = intLeftover Mod 5
        lblPennies.Text = intLeftover.ToString
        Debug.WriteLine("Pennies: " & lblPennies.Text)
    End Sub

    Private Sub btnClear_Click(sender As Object,
 e As EventArgs) Handles btnClear.Click
        txtPennies.Text = ""
        lblDollars.Text = ""
        lblQuarters.Text = ""
        lblDimes.Text = ""
        lblNickels.Text = ""
        lblPennies.Text = ""
    End Sub

End Class
