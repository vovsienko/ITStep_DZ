Public Class Form1
    'declaring a subroutine
    'Private Sub PrintInput()
    '    Debug.WriteLine("Here is some output")
    'End Sub

    'calling a subrouting
    '   Private Sub Form1_Click(sender As Object,
    'e As EventArgs) Handles Me.Click
    '       PrintInput()
    '       Debug.WriteLine("When does this line display?")
    '   End Sub

    'parameters
    'Private Sub Power(num As Double)
    '    Debug.WriteLine((num ^ 2).ToString)
    'End Sub

    'The ToString method is used to convert an Integer into the String representation of an Integer because the WriteLine method expects an argument of the String data type.

    '   Private Sub Form1_Click(sender As Object,
    'e As EventArgs) Handles Me.Click
    '       Power(5)
    '   End Sub

    'The term Argument Is used To refer to the value in the parentheses when the procedure is called. The term Parameter is used to refer to the value in the parentheses in the procedure heading.

    'Multiple Parameters
    '   Private Sub Power(num As Double,
    'exponent As Double)
    '       Debug.WriteLine(num ^ exponent)
    '   End Sub

    'When call with several arguments
    'Power(5, 3)

    'ByVal vs. ByRef

    'Private Sub Power(num As Double)
    '    Debug.WriteLine("In Power num starts at " & num.ToString)
    '    num = num ^ 2
    '    Debug.WriteLine("After num = num ^ 2 num = " & num.ToString)
    'End Sub
    'Private Sub Form1_Click(sender As Object,
    'e As EventArgs) Handles Me.Click
    '    Dim x As Double = 5
    '    Debug.WriteLine("Before calling Power x = " & x.ToString)
    '    Power(x)
    '    Debug.WriteLine("After calling Power x = " & x.ToString)
    'End Sub

    '   Private Sub Form1_Click(sender As Object,
    'e As EventArgs) Handles Me.Click
    '       Dim x As Double = 5
    '       Debug.WriteLine("Before calling Power x = " & x.ToString)
    '       Power(x)
    '       Debug.WriteLine("After calling Power x = " & x.ToString)
    '   End Sub
    '   Private Sub Power(ByRef num As Double)
    '       Debug.WriteLine("In Power num starts at " & num.ToString)
    '       num = num ^ 2
    '       Debug.WriteLine("After num = num ^ 2 num = " & num.ToString)
    '   End Sub

    'When a parameter has the ByRef attribute, any change to the value of the parameter in the called procedure does affect the value of the corresponding argument in the calling procedure.
    'Normally, Visual Basic will use the ByVal attribute, which is the default.

    'Functions
    'Example
    '   Private Function Power(num As Double,
    'exponent As Double) As Double
    '       Return num ^ exponent
    '   End Function

    'Other option - You can assign the value to be returned to the function name. 
    'Private Function Power(num As Double, _
    ' exponent As Double) As Double
    ' Power = num ^ exponent
    'End Function


    'Calling Functions
    '   Private Sub Form1_Click(sender As Object,
    'e As EventArgs) Handles Me.Click
    '       Dim dblResult As Double
    '       dblResult = Power(5, 3)
    '       Debug.WriteLine(dblResult.ToString)
    '   End Sub

    'Returning a Boolean Value
    Private Function IsEven(num As Integer) As Boolean
        If num Mod 2 = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Form1_Click(sender As Object,
 e As EventArgs) Handles Me.Click
        If IsEven(5) Then
            Debug.WriteLine("The number is even")
        Else
            Debug.WriteLine("The number is odd")
        End If
    End Sub
End Class
