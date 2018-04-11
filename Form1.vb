Public Class Form1
    Const One As String = "TA man grows most tired while standing still."
    Const Two As String = "TDig the well before you are thirsty."
    Const Three As String = "TTell me, I forget. Show me, I remember. involve me, I understand."
    Const Four As String = "FIf you always give, you will always have."
    Const Five As String = "TWe count our miseries carefully, and accept our blessings without much thought."
    Const Six As String = "FThe person attempting to travel two roads at once will get nowhere."
    Const Seven As String = "TAll things are difficult before they are easy."

    Dim counter As Integer = 0
    Dim correctAnswers As Integer
    Dim currentProverb As String

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        counter += 1
        If counter <= 7 Then
            Proverbs()
            txtAnswer.Enabled = True
            btnDisplay.Enabled = False
            btnAnswer.Enabled = True
        Else
            DisplayResults()
        End If
    End Sub


    '''''''''''''''''PROCEDURES'''''''''''''''''''''''

    Private Sub Proverbs()
        Select Case counter
            Case 1
                currentProverb = One
            Case 2
                currentProverb = Two
            Case 3
                currentProverb = Three
            Case 4
                currentProverb = Four
            Case 5
                currentProverb = Five
            Case 6
                currentProverb = Six
            Case 7
                currentProverb = Seven
        End Select
    End Sub


    Private Sub DisplayResults()
        Select Case correctAnswers
            Case 7
                MessageBox.Show("Perfect. " & correctAnswers & " correct")
            Case 5, 6
                MessageBox.Show("Excellent. " & correctAnswers & " correct")
            Case Else
                MessageBox.Show("You might think about taking a Pysch 101 class. " & correctAnswers & " correct")
        End Select
    End Sub
End Class
