' Name: JJohnson2E1 
' Programmer: Jason R. Johnson on 12/02/2015

' Purpose: Array searches 

'   Group Box #16
'       '1. Assign user input to integer variable
'       '2. If input is valid
'       '       'a. For each element in array that matches input, up counter
'       '3. Display Counter

'   Group Box #17:
'       '1. Assign user input for both min and max to variables
'       '2. If input valid
'       '       'a. For each element in array if between min/max raise counter
'       '3. Display counter
' 

'Additional Notes: Not sure if there is a way to re-use the array. Project said to define it on form load and populate larger labels but that doesn't make it accessible to the other sub-procedures. 

Option Explicit On 'must define variable statements
Option Infer Off 'will not infer what type for conversions.
Option Strict On 'will not convert for you.

Public Class Form1

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'On form-load display array in both 16, and 17 labels via loop
        Dim arrCount() As Integer = {88, 72, 99, 20, 66, 95, 99, 100, 72, 88, 78, 45, 57, 89, 85, 78, 75, 88, 72, 88}

        For Each arrCountElement As Integer In arrCount
            lblFindTestScores.Text += arrCountElement.ToString & " "
            lblCountTestScores.Text += arrCountElement.ToString & " "
        Next arrCountElement
    End Sub
    Private Sub btnCountScore_Click(sender As Object, e As EventArgs) Handles btnCount16.Click
        'define array and variables
        Dim arrCount() As Integer = {88, 72, 99, 20, 66, 95, 99, 100, 72, 88, 78, 45, 57, 89, 85, 78, 75, 88, 72, 88}

        Dim intCounter As Integer = 0
        Dim decScore As Decimal = 0

        If Decimal.TryParse(txtEnterScore.Text, decScore) AndAlso decScore >= 0 AndAlso decScore <= 100 Then
            For Each arrElement As Integer In arrCount
                If arrElement = decScore Then
                    intCounter += 1
                End If
            Next arrElement
        Else
            MessageBox.Show("Please enter a number between 0 and 100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        lbl16CountScores.Text = intCounter.ToString
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCount17_Click(sender As Object, e As EventArgs) Handles btnCount17.Click
        'define array and variables
        Dim arrCount() As Integer = {88, 72, 99, 20, 66, 95, 99, 100, 72, 88, 78, 45, 57, 89, 85, 78, 75, 88, 72, 88}

        Dim intCounter As Integer = 0
        Dim decScoreMin As Decimal = 0
        Dim decScoreMax As Decimal = 0

        If Decimal.TryParse(txtMin.Text, decScoreMin) AndAlso Decimal.TryParse(txtMax.Text, decScoreMax) Then
            For Each arrElement As Integer In arrCount
                If arrElement >= decScoreMin AndAlso arrElement <= decScoreMax Then
                    intCounter += 1
                End If
            Next arrElement
        Else
            MessageBox.Show("Please enter a valid number for Min and Max", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        lbl17CountScores.Text = intCounter.ToString
    End Sub
End Class
