' Name: Chapter 9 Arrays
' Purpose: Learning Arrays
'     'Days in Month Group box: 
'     '     'Creates array with number of days in month January = 31, February = 28 etc.
'     '     'Takes user input, verifies it's a number via TryParse, verifies it's greater or equal to 1 and less than or equal to 12. If not displays error. If so, subtracts one number to get Array element index and displays that in label.

'     'Display Scores, Lowest, Average Group box - creates an array with scores. Displays full string, finds lowest number in array and displays, Calculates average and displays. All done via separate functions.

' Programmer: Jason R. Johnson on 11/27 - 12/2/2015

Option Explicit On
Option Infer Off
Option Strict Off 'Turned option Strict off - I could not get the function CalcLowestScore to work with it turned on. Kept throwing error about late binding which I did not know how to correct.

Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDisplayDays_Click(sender As Object, e As EventArgs) Handles btnDisplayDays.Click
        'Define Array and variable
        Dim intDaysInMonth() As Integer = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}
        Dim intMonth As Integer

        'Verify valid number and range
        If Integer.TryParse(txtMonthNumber.Text, intMonth) AndAlso intMonth >= 1 AndAlso intMonth <= 12 Then
            'Subtract 1 to get array index value
            intMonth = intMonth - 1
            'Display result
            lblNumberDays.Text = intDaysInMonth(intMonth).ToString
        Else
            MessageBox.Show("Invalid month, please enter number from 1-12.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnDisplayStats_Click(sender As Object, e As EventArgs) Handles btnDisplayStats.Click
        'Define array of scores
        Dim arrScores() As Integer = {78, 87, 95, 94, 77, 82, 81, 82, 65, 45, 66, 54, 32, 24, 100, 78, 86, 13, 92, 91}
        'perform calculations via functions
        lblScores.Text = GetScores(arrScores)
        lblLowest.Text = CalcLowestScore(arrScores).ToString
        lblAverage.Text = CalcAverageScore(arrScores).ToString("n2")
    End Sub
    Private Function GetScores(arrScores As Array) As String
        'Define variable
        Dim strElement As String = String.Empty

        'loop through string and concatenate
        For Each strItem As String In arrScores
            strElement += strItem & ", "
        Next

        'return string after removing last ", "
        Return strElement.Remove(strElement.Length - 2)
    End Function
    Private Function CalcLowestScore(arrScores As Array) As Integer
        'declare variables, set first element in array as lowest.
        Dim intLowest As Integer = arrScores(0)
        Dim intLastSub As Integer = arrScores.GetUpperBound(0)

        'Loop to compare starting at 1. 0 is intLowest.
        For intSub As Integer = 1 To intLastSub
            If arrScores(intSub) < intLowest Then
                intLowest = arrScores(intSub)
            End If
        Next intSub
        Return intLowest
    End Function


    Private Function CalcAverageScore(arrScores As Array) As Double
        'define variable
        Dim intTotal As Double = 0.0

        ' loop through array and add items
        For Each dblElement As Double In arrScores
            intTotal += dblElement
        Next dblElement
        'divide total by number in array
        intTotal = intTotal / arrScores.Length

        Return intTotal
    End Function

    Private Sub btnIncrease_Click(sender As Object, e As EventArgs) Handles btnIncrease.Click
        'Define Array
        Dim arrPrices() As Decimal = {6.75D, 12.5D, 33.5D, 10D, 9.5D, 25.5D, 7.65D, 8.35D, 9.75D, 3.5D}
        'Define variable for input
        Dim decPercent As Decimal = 0D

        'Clear lst fields
        lstOriginal.Items.Clear()
        lstNew.Items.Clear()

        'Verify input, display original price, calculate new price using input, and display in second column
        If Decimal.TryParse(txtPercent.Text, decPercent) AndAlso decPercent >= -100 AndAlso decPercent <= 100 Then
            For Each decElement As Decimal In arrPrices
                'list original prices in first list
                lstOriginal.Items.Add(decElement.ToString("N2"))
                'calculate new price using user input and add to second list
                decElement = decElement + (decElement * decPercent / 100D)
                lstNew.Items.Add(decElement.ToString("N2"))
            Next decElement

        Else
            MessageBox.Show("Please enter a number between -100 and +100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub

    Private Sub lblScores_Click(sender As Object, e As EventArgs) Handles lblScores.Click

    End Sub
End Class
