Public Class Form1

    ' Create a Random object called randomizer 
    ' to generate random numbers.
    Private randomizer As New Random

    ' These integer variables store the numbers 
    ' for the addition problem. 
    Private addend1 As Integer
    Private addend2 As Integer


    ' These integer variables store the numbers 
    ' for the subtraction problem. 
    Private minuend As Integer
    Private subtrahend As Integer

    ' These integer variables store the numbers 
    ' for the multiplication problem. 
    Private multiplicand As Integer
    Private multiplier As Integer

    ' These integer variables store the numbers 
    ' for the division problem. 
    Private dividend As Integer
    Private divisor As Integer

    ' This integer variable keeps track of the 
    ' remaining time.
    Private timeLeft As Integer

    ''' <summary>
    ''' Start the quiz by filling in all of the problem 
    ''' values and starting the timer. 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub StartTheQuiz()

        ' Fill in the addition problem.
        ' Generate two random numbers to add.
        ' Store the values in the variables 'addend1' and 'addend2'.
        addend1 = randomizer.Next(51)
        addend2 = randomizer.Next(51)

        ' Convert the two randomly generated numbers
        ' into strings so that they can be displayed
        ' in the label controls.
        lblPlusLeft.Text = addend1.ToString()
        lblPlusRight.Text = addend2.ToString()

        ' 'sum' is the name of the NumericUpDown control.
        ' This step makes sure its value is zero before
        ' adding any values to it.
        Sum.Value = 0

        ' Fill in the subtraction problem.
        minuend = randomizer.Next(1, 101)
        subtrahend = randomizer.Next(1, minuend)
        lblMinusLeft.Text = minuend.ToString()
        lblMinusRight.Text = subtrahend.ToString()
        difference.Value = 0

        ' Fill in the multiplication problem.
        multiplicand = randomizer.Next(2, 11)
        multiplier = randomizer.Next(2, 11)
        lblTimesLeft.Text = multiplicand.ToString()
        lblTimesRight.Text = multiplier.ToString()
        product.Value = 0

        ' Fill in the division problem.
        divisor = randomizer.Next(2, 11)
        Dim temporaryQuotient As Integer = randomizer.Next(2, 11)
        dividend = divisor * temporaryQuotient
        lblDividedLeft.Text = dividend.ToString()
        lblDividedRight.Text = divisor.ToString()
        quotient.Value = 0

        ' Start the timer.
        timeLeft = 30
        lblTime.Text = "30 seconds"
        Timer1.Start()

    End Sub

    ''' <summary>
    ''' Check the answers to see if the user got everything right.
    ''' </summary>
    ''' <returns>True if the answer's correct, false otherwise.</returns>
    ''' <remarks></remarks>
    Public Function CheckTheAnswer() As Boolean

        If addend1 + addend2 = Sum.Value AndAlso
           minuend - subtrahend = difference.Value AndAlso
           multiplicand * multiplier = product.Value AndAlso
           dividend / divisor = quotient.Value Then

            Return True
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
        Else
            Return False
        End If

    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If CheckTheAnswer() Then
            ' If CheckTheAnswer() returns true, then the user 
            ' got the answer right. Stop the timer  
            ' and show a MessageBox.
            Timer1.Stop()

            lblTime.BackColor = DefaultBackColor
            MessageBox.Show("You got all of the answers right!", "Congratulations!")
            btnStart.Enabled = True


        ElseIf timeLeft > 0 Then
            'If CheckTheAnswer() Then Return False, keep counting
            ' down.Decrease the time left by one second And 
            ' display the New time left by updating the 
            ' Time Left label.
            timeLeft -= 1
            lblTime.Text = timeLeft & " seconds"
            If timeLeft <= 5 Then
                lblTime.BackColor = Color.Red
            End If
        Else
                ' If the user ran out of time, stop the timer, show 
                ' a MessageBox, and fill in the answers.
                Timer1.Stop()
            lblTime.Text = "Time's up!"
            MessageBox.Show("You didn't finish in time.", "Sorry!")
            Sum.Value = addend1 + addend2
            difference.Value = minuend - subtrahend
            product.Value = multiplicand * multiplier
            quotient.Value = dividend / divisor
            btnStart.Enabled = True
            lblTime.BackColor = DefaultBackColor
        End If
    End Sub



    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        StartTheQuiz()
        btnStart.Enabled = False
    End Sub

    ''' <summary> 
    ''' Modify the behavior of the NumericUpDown control
    ''' to make it easier to enter numeric values for
    ''' the quiz.
    ''' </summary> 
    Private Sub answer_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sum.Enter, quotient.Enter, product.Enter, difference.Enter, Sum.ValueChanged, quotient.ValueChanged, product.ValueChanged, difference.ValueChanged



        ' Select the whole answer in the NumericUpDown control.
        Dim answerBox = TryCast(sender, NumericUpDown)

        If answerBox IsNot Nothing Then
            Dim lengthOfAnswer = answerBox.Value.ToString().Length
            answerBox.Select(0, lengthOfAnswer)
        End If




    End Sub


End Class
