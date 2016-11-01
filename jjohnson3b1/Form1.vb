' Name: Chapter 6 Loops and List Boxes
' Purpose: Learning different options for loops and List Boxes
'     'Multiplication Tables GroupBox: 
'     '     'For Loop (pretest) - Collects start value and creates multiplication table from 1-9:
'     '     'While Loop (pretest) same as For Loop but with While Loop.

'     'Sales Expenses GroupBox: To add default items to list box: Properties > Collection(drop-down).
'     '     'lstSales uses For/Next loop.
'     '     'lstExpense uses Do While loop.
'     '     '     ' Both Add number to list after converting to decimal.
'     '     '     ' Both determine number of items in list and total lists.
'     '     '     ' Chain-linked events. Button changes list And uses SelectedIndex To highlight item In list. That kicks off SelectedValueChanged To re-calculate And give total, Total change uses TextChanged to then calculate net.
'     '     '     ' Both use key-down events to allow users to remove items from the lists.


' Programmer: Jason R. Johnson on 11/24/2015

Option Explicit On
Option Infer Off
Option Strict On

Public Class Form1
    Private decTotalSales As Decimal = 0D
    Private decTotalExpense As Decimal = 0D

    Private Sub btnForLoopDT_Click(sender As Object, e As EventArgs) Handles btnForLoopDT.Click

        'declare variables
        Dim intStartValue, intProduct, intCount As Integer
        intCount = 1

        'clear list
        lstMultTable.Items.Clear()

        'add list intro:
        lstMultTable.Items.Add("For Loop:")

        'collect start value
        Integer.TryParse(txtInputNum.Text, intStartValue)

        'For Loop:
        For i As Integer = 1 To 9
            intProduct = intStartValue * intCount
            lstMultTable.Items.Add("     " & intStartValue.ToString & " * " & intCount.ToString & " = " & intProduct.ToString)
            intCount = intCount + 1
        Next i
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnWileLoopDT_Click(sender As Object, e As EventArgs) Handles btnWileLoopDT.Click
        'declare variables
        Dim intStartValue, intProduct, intCount As Integer
        intCount = 1

        'clear list
        lstMultTable.Items.Clear()

        'add list intro:
        lstMultTable.Items.Add("While Loop:")

        'collect start value
        Integer.TryParse(txtInputNum.Text, intStartValue)

        Do While intCount >= 1 AndAlso intCount < 10
            intProduct = intStartValue * intCount
            lstMultTable.Items.Add("     " & intStartValue.ToString & " * " & intCount.ToString & " = " & intProduct.ToString)
            intCount = intCount + 1
        Loop
    End Sub

    Private Sub btnAddSale_Click(sender As Object, e As EventArgs) Handles btnAddSale.Click
        Dim decSale As Decimal = 0D
        Decimal.TryParse(txtAddSale.Text, decSale)

        If decSale > 0D Then
            lstSales.Items.Add(decSale.ToString("N2"))
            lstSales.SelectedIndex = lstSales.Items.Count - 1
        Else
            MessageBox.Show("Enter dollar amount", "Invalid number")
        End If
        txtAddSale.Focus()
    End Sub

    Private Sub btnAddExpense_Click(sender As Object, e As EventArgs) Handles btnAddExpense.Click
        Dim decExpense As Decimal = 0D
        Decimal.TryParse(txtAddExpense.Text, decExpense)

        If decExpense > 0D Then
            lstExpenses.Items.Add(decExpense.ToString("N2"))
            lstExpenses.SelectedIndex = lstExpenses.Items.Count - 1
        Else
            MessageBox.Show("Enter dollar amount", "Invalid number")
        End If
        txtAddExpense.Focus()
    End Sub

    Private Sub lstSales_SelectedValueChanged(sender As Object, e As EventArgs) Handles lstSales.SelectedValueChanged

        decTotalSales = 0D 'declared as Class-level variable.
        Dim decAmount As Decimal = 0D
        Dim intLastIndex As Integer = lstSales.Items.Count - 1  '-1 here because index starts at 0.
        Dim intCount As Integer = 0

        'Counting loop: 0 to intLastIndex
        For i As Integer = 0 To intLastIndex
            'Convert lstSales.Items(i) to Decimal
            Decimal.TryParse(lstSales.Items(i).ToString, decAmount)
            'Add Amount to total
            decTotalSales = decTotalSales + decAmount
            intCount = intCount + 1
        Next i
        lblTotalSales.Text = decTotalSales.ToString("N2")
    End Sub

    Private Sub lstExpenses_SelectedValueChanged(sender As Object, e As EventArgs) Handles lstExpenses.SelectedValueChanged

        decTotalExpense = 0D 'declared as Class-level variable.
        Dim decAmount As Decimal = 0D
        Dim intLastIndex As Integer = lstExpenses.Items.Count - 1  '-1 here because index starts at 0.
        Dim intCount As Integer = 0

        'Counting loop: 0 to intLastIndex

        Do While intCount <= intLastIndex
            'Convert lstExpenses.Items(i) to Decimal
            Decimal.TryParse(lstExpenses.Items(intCount).ToString, decAmount)
            'Add Amount to total
            decTotalExpense = decTotalExpense + decAmount
            intCount = intCount + 1
        Loop
        lblTotalExpenses.Text = decTotalExpense.ToString("N2")
    End Sub

    Private Sub NetChanged(sender As Object, e As EventArgs) Handles lblTotalSales.TextChanged, lblTotalExpenses.TextChanged
        lblTotalNet.Text = (decTotalSales - decTotalExpense).ToString("N2")
    End Sub

    Private Sub lstSales_KeyDown(sender As Object, e As KeyEventArgs) Handles lstSales.KeyDown
        If lstSales.SelectedIndex >= 0 AndAlso (e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back) Then
            lstSales.Items.RemoveAt(lstSales.SelectedIndex)
        End If
    End Sub

    Private Sub lstExpenses_KeyDown(sender As Object, e As KeyEventArgs) Handles lstExpenses.KeyDown
        If lstExpenses.SelectedIndex >= 0 AndAlso (e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back) Then
            lstExpenses.Items.RemoveAt(lstExpenses.SelectedIndex)
        End If
    End Sub
End Class
