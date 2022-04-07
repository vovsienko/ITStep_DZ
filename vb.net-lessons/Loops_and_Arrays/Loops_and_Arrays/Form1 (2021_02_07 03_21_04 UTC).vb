Public Class Form1

    'For . . . Next Statement
    '   Private Sub Form1_Load(sender As Object,
    'e As EventArgs) Handles Me.Load

    '       For x As Integer = 1 To 3
    '           Debug.WriteLine(x)
    '       Next x
    '       Debug.WriteLine("This line will always print")
    '   End Sub

    'Step Statement
    '   Private Sub Form1_Load(sender As Object,
    'e As EventArgs) Handles Me.Load

    '       For x As Integer = 1 To 3 Step 2
    '           Debug.WriteLine(x)
    '       Next x
    '       Debug.WriteLine("This line will always print")
    '   End Sub

    'Step statement may be a negative number 
    '   Private Sub Form1_Load(sender As Object,
    'e As EventArgs) Handles Me.Load

    '       For x As Integer = 1 To 3 Step -1
    '           Debug.WriteLine(x)
    '       Next x
    '       Debug.WriteLine("This line will always print")
    '   End Sub

    'Printing numbers 3 to 1
    '   Private Sub Form1_Load(sender As Object,
    'e As EventArgs) Handles Me.Load

    '       For x As Integer = 3 To 1 Step -1
    '           Debug.WriteLine(x)
    '       Next x
    '       Debug.WriteLine("This line will always print")
    '   End Sub

    ' Exit For Statement
    '   Private Sub Form1_Load(sender As Object,
    'e As EventArgs) Handles Me.Load

    '       For x As Integer = 1 To 5
    '           If x > 3 Then
    '               Exit For
    '           End If
    '           Debug.WriteLine(x)
    '       Next x
    '       Debug.WriteLine("This line will always print")
    '   End Sub

    'Nesting 

    'you can nest an If . . . Then statement In a For . . . Next statement. 
    '   Private Sub Form1_Load(sender As Object,
    'e As EventArgs) Handles Me.Load

    '       Debug.WriteLine("Multiples of 3 between 1 and 100:")
    '       For x As Integer = 1 To 100
    '           If x Mod 3 = 0 Then
    '               Debug.WriteLine(x)
    '           End If
    '       Next x
    '       Debug.WriteLine("This line will always print")
    '   End Sub

    'You can also nest For . . . Next statements by placing one For . . . Next statement within another. 

    'Nesting For . . . Next statements is a good way to print values in the rows and columns of a table. The outside For . . . Next statement represents the rows, and the inside For . . . Next statement represents the columns.

    '   Private Sub Form1_Load(sender As Object,
    'e As EventArgs) Handles Me.Load

    '       For I As Integer = 1 To 3
    '           For X As Integer = 1 To 3
    '               Debug.WriteLine("I = " & I)
    '               Debug.WriteLine("X = " & X)
    '           Next X
    '       Next I
    '       Debug.WriteLine("This line will always print")
    '   End Sub

    'For Each . . . Next Statement
    '   Private Sub Form1_Load(sender As Object,
    'e As EventArgs) Handles Me.Load
    '       For Each ctl As Control In Me.Controls
    '           Debug.WriteLine(ctl.Name)
    '       Next ctl
    '   End Sub

    'While . . . End While Statement
    '    Private Sub Form1_Load(sender As Object,
    'e As EventArgs) Handles Me.Load
    '        Dim x As Integer = 1
    '        While x <= 3
    '            Debug.WriteLine(x)
    '            x += 1
    '        End While
    '        Debug.WriteLine("This line will always print")
    '    End Sub

    'no numbers will write to the Output window, because the condition is initially False
    '    Private Sub Form1_Load(sender As Object,
    'e As EventArgs) Handles Me.Load
    '        Dim x As Integer = 1
    '        While x >= 5
    '            Debug.WriteLine(x) x += 1 
    '  End While
    '        Debug.WriteLine("This line will always print")
    '    End Sub

    'nesting - code will only output 1 through 3, not 1 through 5, to the Output window:
    '    Private Sub Form1_Load(sender As Object,
    'e As EventArgs) Handles Me.Load
    '        Dim x As Integer = 1
    '        While x <= 5
    '            If x = 4 Then
    '                Exit While
    '            End If
    '            Debug.WriteLine(x)
    '            x += 1
    '        End While
    '        Debug.WriteLine("This line will always print")
    '    End Sub

    'Do Statement
    'Testing a Condition at the Top of a Do Statement

    'the following code uses the While keyword to output to the Output window 1 through 5, followed by "This line will always print"
    '   Private Sub Form1_Load(sender As Object,
    'e As EventArgs) Handles Me.Load
    '       Dim x As Integer
    '       x = 1
    '       Do While x <= 5
    '           Debug.WriteLine(x)
    '           x += 1
    '       Loop
    '       Debug.WriteLine("This line will always print")
    '    End Sub
    'the same result by using the Until keyword
    '   Private Sub Form1_Load(sender As Object,
    'e As EventArgs) Handles Me.Load
    '       Dim x As Integer
    '       x = 1
    '       Do Until x > 5
    '           Debug.WriteLine(x)
    '           x += 1
    '       Loop
    '       Debug.WriteLine("This line will always print")
    '   End Sub

    'Testing a Condition at the Bottom of a Do Statement
    '    Private Sub Form1_Load(sender As Object,
    'e As EventArgs) Handles Me.Load
    '        Dim x As Integer
    '        x = 100
    '        Do
    '            Debug.WriteLine(x)
    '            x += 1
    '        Loop While x <= 5
    '        Debug.WriteLine("This line will always print")
    '    End Sub

    'Arrays - default value
    '   Private Sub Form1_Load(sender As Object,
    'e As EventArgs) Handles Me.Load

    '       Dim arrSalesPerDay(6) As Integer
    '       For x As Integer = 0 To 6
    '           Debug.WriteLine(arrSalesPerDay(x))
    '       Next x
    '   End Sub

    'Array - assign values to each element and then output these values
    '   Private Sub Form1_Load(sender As Object,
    'e As EventArgs) Handles Me.Load

    '       Dim arrSalesPerDay(6) As Integer
    '       For x As Integer = 0 To 6
    '           arrSalesPerDay(x) = x + 1
    '       Next x
    '       For x As Integer = 0 To 6
    '           Debug.WriteLine(arrSalesPerDay(x))
    '       Next x
    '   End Sub

    'Arrays - The first loop assigns 1 through 7 to the elements of the array. The second loop sums these values
    Private Sub Form1_Load(sender As Object,
e As EventArgs) Handles Me.Load

        Dim arrSalesPerDay(6) As Integer
        Dim total As Integer = 0
        For x As Integer = 0 To 6
            arrSalesPerDay(x) = x + 1
        Next x
        For x As Integer = 0 To 6
            total += arrSalesPerDay(x)
        Next x
        Debug.WriteLine("Total Sales: " & total)
    End Sub

End Class
