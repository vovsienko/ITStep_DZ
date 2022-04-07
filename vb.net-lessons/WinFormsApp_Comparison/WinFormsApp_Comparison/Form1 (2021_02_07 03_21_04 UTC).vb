Public Class Form1

    'Comparison operators

    'Private Sub Form1_Load(sender As Object,
    ' e As EventArgs) Handles Me.Load
    ' Dim A As Integer = 10
    ' Dim B As Integer = 8
    'Dim C As Integer = 10
    '    Debug.WriteLine(A > B) ' Outputs True
    '   Debug.WriteLine(A >= B) ' Outputs True
    '  Debug.WriteLine(A = B) ' Outputs False
    ' Debug.WriteLine(A <> B) ' Outputs True
    ' Debug.WriteLine(A < B) ' Outputs False
    ' Debug.WriteLine(A <= B) ' Outputs False
    ' Debug.WriteLine(A > C) ' Outputs False
    ' Debug.WriteLine(A >= C) ' Outputs True
    'Debug.WriteLine(A = C) ' Outputs True
    'Debug.WriteLine(A <> C) ' Outputs False
    'Debug.WriteLine(A < C) ' Outputs False
    'Debug.WriteLine(A <= C) ' Outputs True
    'End Sub

    'AND operator

    'Private Sub Form1_Load(sender As Object,
    'e As EventArgs) Handles Me.Load
    'Dim A As Integer = 10
    'Dim B As Integer = 8
    'Dim C As Integer = 6
    '   Debug.WriteLine(A > B And B > C) ' Outputs True
    '   Debug.WriteLine(A > B And C > B) ' Outputs False
    '   Debug.WriteLine(B > A And B > C) ' Outputs False
    'End Sub

    'OR operator
    ' Private Sub Form1_Load(sender As Object,
    ' e As EventArgs) Handles Me.Load
    ' Dim A As Integer = 10
    'Dim B As Integer = 8
    'Dim C As Integer = 6
    '    Debug.WriteLine(A > B Or B > C) ' Outputs True
    '     Debug.WriteLine(A > B Or C > B) ' Outputs True
    '    Debug.WriteLine(B > A Or B > C) ' Outputs True
    ' End Sub

    'XOR operator
    'Private Sub Form1_Load(sender As Object,
    'e As EventArgs) Handles Me.Load
    'Dim A As Integer = 10
    ' Dim B As Integer = 8
    ' Dim C As Integer = 6
    '     Debug.WriteLine(A > B Xor B > C) ' Outputs False
    '    Debug.WriteLine(A > B Xor C > B) ' Outputs True
    '     Debug.WriteLine(B > A Xor B > C) ' Outputs True
    ' End Sub

    'IF ... THEN statement
    'Private Sub Form1_Load(sender As Object, e As EventArgs) _
    'Handles Me.Load
    '    If Me.Height > Me.Width Then
    '        Debug.WriteLine("The form is taller than wider")
    '    End If
    '    Debug.WriteLine("This line will always print")
    'End Sub


    'IF ... ELSE statement
    '    Private Sub Form1_Load(sender As Object, e As _
    'EventArgs) Handles Me.Load
    '        If Me.Height > Me.Width Then
    '            Debug.WriteLine("The form is taller than wider")
    '        Else
    '            Debug.WriteLine("The form is not taller than wider")
    '        End If
    '        Debug.WriteLine("This line will always print")
    '    End Sub


    'If . . . ElseIf Statement
    '    Private Sub Form1_Load(sender As Object, e As _
    'EventArgs) Handles Me.Load
    '        If Me.Height > Me.Width Then
    '            Debug.WriteLine("The form is taller than wider")
    '        ElseIf Me.Height < Me.Width Then
    '            Debug.WriteLine("The form is wider than taller")
    '        Else
    '            Debug.WriteLine("The form's height and width are equal")
    '        End If
    '        Debug.WriteLine("This line will always print")
    '    End Sub

    'CheckBox Control
    ' If chkPizza.Checked = True Then
    '  Debug.WriteLine "I want pizza!"
    ' Else
    '  Debug.WriteLine "I don't want pizza."
    ' End If

    'RadioButton Control
    'If radLarge.Checked = True Then
    ' Debug.WriteLine "I want a large pizza."
    'ElseIf radMedium.Checked = True Then
    ' Debug.WriteLine "I want a medium pizza."
    'Else
    ' Debug.WriteLine "I want a small pizza."
    'End If

    'Select Case Control
    '   Private Sub Form1_Click(sender As Object,
    'e As EventArgs) Handles Me.Click
    '       Dim intScore As Integer
    '       intScore = Integer.Parse(txtScore.Text)
    '       Select Case intScore
    '           Case 100
    '               Debug.WriteLine("Perfect score! Your grade is an A")
    '           Case 90 To 99
    '               Debug.WriteLine("Your grade is an A")
    '           Case 80 To 89
    '               Debug.WriteLine("Your grade is a B")
    '           Case 70 To 79
    '               Debug.WriteLine("Your grade is a C")
    '           Case 60 To 69
    '               Debug.WriteLine("Your grade is a D")
    '           Case 0 To 59
    '               Debug.WriteLine("Your grade is an F")
    '           Case Else
    '               Debug.WriteLine("Invalid score")
    '       End Select
    '       Debug.WriteLine("This line will always print")
    '   End Sub



End Class
