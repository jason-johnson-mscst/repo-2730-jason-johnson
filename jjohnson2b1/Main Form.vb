' Name: JJohnson2B1 Fairmont Sales and Car Expenses Projects   
' Purpose: Define variables, convert via TryParse, Calculate, Display. Add Static Variable to Car Expense Yearly total to keep track and add month by month.
' Programmer: Jason R. Johnson on 10/26-27/2015

Option Explicit On
Option Infer Off
Option Strict On

Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnFairmontCalculate_Click(sender As Object, e As EventArgs) Handles btnFairmontCalculate.Click
        'define variables

        Dim decILSales As Decimal = 0D
        Dim decINSales As Decimal = 0D
        Dim decAKSales As Decimal = 0D
        Dim decTotalSales As Decimal = 0D
        Dim decTotalComm As Decimal = 0.03D

        'perform conversions

        Decimal.TryParse(txtILSales.Text, decILSales)
        Decimal.TryParse(txtINSales.Text, decINSales)
        Decimal.TryParse(txtAKSales.Text, decAKSales)

        'perform calculations

        decTotalSales = decILSales + decINSales + decAKSales
        decTotalComm = decTotalSales * decTotalComm

        'display results
        lblFairTotSales.Text = decTotalSales.ToString("N2")
        lblFairTotComm.Text = decTotalComm.ToString("N2")
    End Sub

    Private Sub btnCarCalculate_Click(sender As Object, e As EventArgs) Handles btnCarCalculate.Click

        'define variables
        Dim decLoanPmt As Decimal = 300D
        Dim decInsPmt As Decimal = 100D
        Dim decOilChg As Decimal = 20D
        Dim decMaint As Decimal = 80D
        Dim decCarWsh As Decimal = 20D
        Dim decGas As Decimal = 180D
        Dim decMonthlyTotal As Decimal = 0.0D
        ' need to remember total from one calculate to the next so use static'
        Static decYearlyTotal As Decimal = 0.0D

        'perform conversions
        Decimal.TryParse(txtLoanPmt.Text, decLoanPmt)
        Decimal.TryParse(txtInsPayment.Text, decInsPmt)
        Decimal.TryParse(txtOilChange.Text, decOilChg)
        Decimal.TryParse(txtMaintenance.Text, decMaint)
        Decimal.TryParse(txtCarWash.Text, decCarWsh)
        Decimal.TryParse(txtGas.Text, decGas)

        'perform calculations
        decMonthlyTotal = decLoanPmt + decInsPmt + decOilChg + decMaint + decCarWsh + decGas
        decYearlyTotal = decMonthlyTotal + decYearlyTotal
        'display results
        lblCarMonthlyTotal.Text = decMonthlyTotal.ToString("N2")
        lblCarYearlyTotal.Text = decYearlyTotal.ToString("N2")
    End Sub

    Private Sub txtInsPayment_TextChanged(sender As Object, e As EventArgs) Handles txtInsPayment.TextChanged

    End Sub

    Private Sub txtLoanPmt_TextChanged(sender As Object, e As EventArgs) Handles txtLoanPmt.TextChanged

    End Sub

    Private Sub txtILSales_TextChanged(sender As Object, e As EventArgs) Handles txtILSales.TextChanged

    End Sub

    Private Sub txtGas_TextChanged(sender As Object, e As EventArgs) Handles txtGas.TextChanged

    End Sub
End Class
