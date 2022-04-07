Public Class Form1

    'Write a function, called isValidScore, that takes as its one argument an Integer and returns a Boolean value that's True if the number is between 0 and 100. Make it return a value of False otherwise.

    'The isValidScore function may be written as follows:

    Public Function IsValidScore(num As Integer) As Boolean
        Return num >= 0 And num <= 100
    End Function

    'You also could write this Function As follows

    'Public Function IsValidScore(num As Integer) As Boolean
    '    If num >= 0 And num <= 100 Then
    '        Return True
    '    Else
    '        Return False
    '    End If
    'End Function

    'The second way Is more typing, but equally valid.

End Class
