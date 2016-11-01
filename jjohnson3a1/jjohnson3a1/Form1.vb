' Name: Chapter 6 Loops
' Purpose: Learning different options for Strings
'     'p371 #13 Loop 7-19 GroupBox: Counts to 19 using odd numbers and different loop types:
'     '     'Do While loop (pretest). Evaluates first.
'     '     'Do Until loop (pretest). Evaluates first.
'     '     'Loop While (posttest). Evaluates after first run through.
'     '     'Loop Until (posttest). Evaluates after first run through.
'     '     'For Loop (Pretest). Evaluates first and runs for a set number of times

'     'Sales Express GroupBox:
'     '     'p354 Do While - prompts for first sales amount. Uses Do While Loop to cycle until user hits ok with empty string. Displays entered values in multi-line text-box (settings: multi-line=true, scrollbars=vertical, ReadOnly). Calculates average of entries.
'     '     'p354 Loop Until - same as Do While but Loop Until.
'     '     'p373 For Next - revised logic for For Next Loop. Added new InputBox to collect number of times for loop. Prompts user for that number of entries. Once that number is hit, Completes calculation.

' Programmer: Jason R. Johnson on 11/23/2015

Option Explicit On
Option Infer Off
Option Strict On

Public Class Form1
    Private Sub btnPreDoWhile_Click(sender As Object, e As EventArgs) Handles btnPreDoWhile.Click
        lblOddNums.Text = "Pretest Do While" & ControlChars.NewLine
        Dim intOdd As Integer = 7
        Do While intOdd <= 19
            lblOddNums.Text = lblOddNums.Text & intOdd.ToString & ControlChars.NewLine
            intOdd = intOdd + 2
        Loop
    End Sub

    Private Sub btnPreDoUntil_Click(sender As Object, e As EventArgs) Handles btnPreDoUntil.Click
        lblOddNums.Text = "Pretest Do Until" & ControlChars.NewLine
        Dim intOdd As Integer = 7
        Do Until intOdd > 19
            lblOddNums.Text = lblOddNums.Text & intOdd.ToString & ControlChars.NewLine
            intOdd = intOdd + 2
        Loop
    End Sub

    Private Sub btnPostLoopWhile_Click(sender As Object, e As EventArgs) Handles btnPostLoopWhile.Click
        lblOddNums.Text = "Posttest Loop While" & ControlChars.NewLine
        Dim intOdd As Integer = 7
        Do
            lblOddNums.Text = lblOddNums.Text & intOdd.ToString & ControlChars.NewLine
            intOdd = intOdd + 2
        Loop While intOdd <= 19
    End Sub

    Private Sub btnPostLoopUntil_Click(sender As Object, e As EventArgs) Handles btnPostLoopUntil.Click
        lblOddNums.Text = "Posttest Loop Until" & ControlChars.NewLine
        Dim intOdd As Integer = 7
        Do
            lblOddNums.Text = lblOddNums.Text & intOdd.ToString & ControlChars.NewLine
            intOdd = intOdd + 2
        Loop Until intOdd > 19
    End Sub

    Private Sub btnPretestFor_Click(sender As Object, e As EventArgs) Handles btnPretestFor.Click
        lblOddNums.Text = "For Loop" & ControlChars.NewLine

        For intOdd As Integer = 7 To 19 Step +2
            lblOddNums.Text = lblOddNums.Text & intOdd.ToString & ControlChars.NewLine
        Next intOdd
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDoWhile_Click(sender As Object, e As EventArgs) Handles btnDoWhile.Click
        'calculates the average sales amount

        Const strPROMPT As String = "Enter a sales amount. " & ControlChars.NewLine & "Click Cancel or Leave Blank to end."
        Const strTITLE As String = "Sales Entry"
        Dim strInputSales As String
        Dim decSales As Decimal
        Dim intNumSales As Integer
        Dim decTotalSales As Decimal
        Dim decAvgSales As Decimal

        'get first sales amount
        strInputSales = InputBox(strPROMPT, strTITLE, "0")

        'repeat as long as the user enters a sales amount
        Do While strInputSales <> String.Empty
            'convert the sales amount to a number
            Decimal.TryParse(strInputSales, decSales)

            'display the sales amount in the text box
            txtList.Text = txtList.Text & decSales.ToString("N2") & ControlChars.NewLine

            'update the counter and accumulator
            intNumSales = intNumSales + 1
            decTotalSales = decTotalSales + decSales

            'get next sales amount
            strInputSales = InputBox(strPROMPT, strTITLE)
        Loop

        'verify that the counter is greater than 0
        If intNumSales > 0 Then
            decAvgSales = decTotalSales / intNumSales
            lblAvg.Text = decAvgSales.ToString("C2")
        Else
            lblAvg.Text = "N/A"
        End If
    End Sub

    Private Sub btnStartOver_Click(sender As Object, e As EventArgs) Handles btnStartOver.Click
        txtList.Text = String.Empty
        lblAvg.Text = String.Empty
    End Sub

    Private Sub btnLoopUntil_Click(sender As Object, e As EventArgs) Handles btnLoopUntil.Click
        'calculates the average sales amount

        Const strPROMPT As String = "Enter a sales amount. " & ControlChars.NewLine & "Click Cancel or Leave Blank to end."
        Const strTITLE As String = "Sales Entry"
        Dim strInputSales As String
        Dim decSales As Decimal
        Dim intNumSales As Integer
        Dim decTotalSales As Decimal
        Dim decAvgSales As Decimal

        'get first sales amount
        strInputSales = InputBox(strPROMPT, strTITLE, "0")

        'repeat as long as the user enters a sales amount
        Do
            'convert the sales amount to a number
            Decimal.TryParse(strInputSales, decSales)

            'display the sales amount in the text box
            txtList.Text = txtList.Text & decSales.ToString("N2") & ControlChars.NewLine

            'update the counter and accumulator
            intNumSales = intNumSales + 1
            decTotalSales = decTotalSales + decSales

            'get next sales amount
            strInputSales = InputBox(strPROMPT, strTITLE)
        Loop Until strInputSales = String.Empty

        'verify that the counter is greater than 0
        If intNumSales > 0 Then
            decAvgSales = decTotalSales / intNumSales
            lblAvg.Text = decAvgSales.ToString("C2")
        Else
            lblAvg.Text = "N/A"
        End If
    End Sub

    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click
        'calculates the average sales amount

        Const strCOUNT As String = "Enter count of sales values."
        Const strCOUNTTITLE As String = "Sales Count"
        Const strPROMPT As String = "Enter a sales amount."
        Const strTITLE As String = "Sales Entry"
        Dim strLoopNum As String
        Dim strInputSales As String
        Dim decSales As Decimal
        Dim intCount As Integer
        Dim intNumSales As Integer
        Dim decTotalSales As Decimal
        Dim decAvgSales As Decimal

        'get Loop Count
        strLoopNum = InputBox(strCOUNT, strCOUNTTITLE, "0")

        'convert loop string into integer
        Integer.TryParse(strLoopNum, intCount)

        'repeat for intCount
        For intX As Integer = 1 To intCount

            'get sales amount
            strInputSales = InputBox(strPROMPT, strTITLE)

            'convert the sales amount to a number
            Decimal.TryParse(strInputSales, decSales)

            'display the sales amount in the text box
            txtList.Text = txtList.Text & decSales.ToString("N2") & ControlChars.NewLine

            'update the counter and accumulator
            intNumSales = intNumSales + 1
            decTotalSales = decTotalSales + decSales
        Next intX

        'verify that the counter is greater than 0
        If intNumSales > 0 Then
            decAvgSales = decTotalSales / intNumSales
            lblAvg.Text = decAvgSales.ToString("C2")
        Else
            lblAvg.Text = "N/A"
        End If
    End Sub
End Class
