' Name: Chapter 6 Loops and List Boxes
' Purpose: Learning Sub-procedures and Functions
'     '#12 Groupbox: 
'     '     'Convert between Celsius and Fahrenheit using sub-procedures.

'     '#13 Groupbox: 
'     '     'Convert between Celsius and Fahrenheit using functions.

'Extra: Learned that Alt+248 gives ° sign. 

' Programmer: Jason R. Johnson on 11/25/2015

Option Explicit On
Option Infer Off
Option Strict On

Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btn12FtoC_Click(sender As Object, e As EventArgs) Handles btn12FtoC.Click
        Dim sigF, sigC As Single
        Dim isConverted As Boolean

        'verify and convert Text to single
        isConverted = Single.TryParse(txtFar12.Text, sigF)

        If isConverted = True Then
            Call ChangeFtoC12Sub(sigF, sigC)
        Else
            MessageBox.Show("Fahrenheit degrees must be a number.", "Fahrenheit to Celsius", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        txtCel12.Text = sigC.ToString("N2")
        txtFar12.SelectAll()
    End Sub
    Private Sub btn12CtoF_Click(sender As Object, e As EventArgs) Handles btn12CtoF.Click
        Dim sigF, sigC As Single
        Dim isConverted As Boolean

        'verify and convert Text to single
        isConverted = Single.TryParse(txtCel12.Text, sigC)

        If isConverted = True Then
            Call ChangeCtoF12Sub(sigF, sigC)
        Else
            MessageBox.Show("Celsius degrees must be a number.", "Celsius to Fahrenheit", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        txtFar12.Text = sigF.ToString("N2")
        txtCel12.SelectAll()
    End Sub

    Private Sub ChangeFtoC12Sub(ByVal fahrenheit As Single, ByRef celsius As Single)
        celsius = (fahrenheit - 32.0F) * 5.0F / 9.0F
    End Sub

    Private Sub ChangeCtoF12Sub(ByRef fahrenheit As Single, ByVal celsius As Single)
        fahrenheit = celsius * 9.0F / 5.0F + 32
    End Sub

    Private Sub btn13FtoC_Click(sender As Object, e As EventArgs) Handles btn13FtoC.Click
        Dim sigF, sigC As Single
        Dim isConverted As Boolean

        'verify and convert Text to single
        isConverted = Single.TryParse(txtFar13.Text, sigF)

        If isConverted = True Then
            sigC = ChangeFtoC13Fun(sigF)
        Else
            MessageBox.Show("Fahrenheit degrees must be a number.", "Fahrenheit to Celsius", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        txtCel13.Text = sigC.ToString("N2")
        txtFar13.SelectAll()
    End Sub

    Private Sub btn13CtoF_Click(sender As Object, e As EventArgs) Handles btn13CtoF.Click
        Dim sigF, sigC As Single
        Dim isConverted As Boolean

        'verify and convert Text to single
        isConverted = Single.TryParse(txtCel13.Text, sigC)

        If isConverted = True Then
            sigF = ChangeCtoF13Fun(sigC)
        Else
            MessageBox.Show("Celsius degrees must be a number.", "Celsius to Fahrenheit", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        txtFar13.Text = sigF.ToString("N2")
        txtCel13.SelectAll()
    End Sub

    Private Function ChangeFtoC13Fun(ByVal fahrenheit As Single) As Single
        Return (fahrenheit - 32.0F) * 5.0F / 9.0F
    End Function

    Private Function ChangeCtoF13Fun(ByVal celsius As Single) As Single
        Return celsius * 9.0F / 5.0F + 32.0F
    End Function

    Private Sub btnRanCalSubpro_Click(sender As Object, e As EventArgs) Handles btnRanCalSubpro.Click
        ' calls a sub-procedure to calculate average and total rainfall amounts, then displays amounts.

        ' declare variables - keep track of Total.
        Static decRainTotal As Decimal = 0D
        Dim decRainMonth As Decimal = 0D
        Dim decRainAverage As Decimal = 0D

        'Calculations
        If Decimal.TryParse(txtMonRain.Text, decRainMonth) AndAlso decRainMonth > 0 Then
            CalcAvgandTotSub(decRainAverage, decRainMonth, decRainTotal)
        Else
            MessageBox.Show("Rainfall must be a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        lblTotRain.Text = decRainTotal.ToString("N2")
        lblAvgRain.Text = decRainAverage.ToString("N2")
    End Sub

    Private Sub CalcAvgandTotSub(ByRef Average As Decimal, ByVal Monthly As Decimal, ByRef Total As Decimal)
        Static countHit As Decimal = 0D

        'Count Tracker
        countHit = countHit + 1

        'Calculate total:
        Total = Total + Monthly

        'Calculate Average
        Average = Total / countHit
    End Sub

    Private Sub btnRainCalFunc_Click(sender As Object, e As EventArgs) Handles btnRainCalFunc.Click
        'calls functions to calculate average and total rainfall amounts, then displays amounts.

        Dim decRainTotalF As Decimal = 0D
        Dim decRainMonthF As Decimal = 0D
        Dim decRainAverageF As Decimal = 0D

        If Decimal.TryParse(txtMonRain.Text, decRainMonthF) AndAlso decRainMonthF > 0 Then
            'calculate Total and Average via Functions
            decRainTotalF = CalcFTot(decRainMonthF)
            decRainAverageF = CalcFAvg(decRainTotalF)

            'Display Results
            lblTotRain.Text = decRainTotalF.ToString("N2")
            lblAvgRain.Text = decRainAverageF.ToString("N2")
        Else
            MessageBox.Show("Rainfall must be a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        txtMonRain.Focus()
    End Sub
    Private Function CalcFTot(ByVal decMonthly As Decimal) As Decimal
        'declare variable
        Static decNewTotal As Decimal

        'calculate new total
        decNewTotal = decNewTotal + decMonthly

        'Add monthly to total
        Return decNewTotal
    End Function

    Private Function CalcFAvg(ByVal decTotal As Decimal) As Decimal

        'declare static counter
        Static decCountHitF As Decimal = 0D

        'Add on per count
        decCountHitF = decCountHitF + 1

        'Calculate total
        decTotal = decTotal / decCountHitF

        Return decTotal
    End Function

    Private Sub txtMonRain_TextChanged(sender As Object, e As EventArgs) Handles txtMonRain.TextChanged
        lblAvgRain.Text = String.Empty
        lblTotRain.Text = String.Empty
    End Sub
End Class
