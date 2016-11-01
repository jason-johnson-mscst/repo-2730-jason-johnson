' Name:         Sales Commissions - Slight variations on Chapter 5 - p. 326 
' Purpose:      Learning different options for calculations. 
'   '   '   '   'Requirements:
'   '   '   '   '   'Include exit button.
'   '   '   '   '   'Message box For invalid characters In Sales entry.
'   '   '   '   '   'Calculates sales commissions (3-levels) (same calculations performed in four ways - If Then, Nested If, If Else If, and Select Case).
'   '   '   '   '   '   '1-100000.99 = Commission of 2% of sales
'   '   '   '   '   '   '100001-400000.99 = commission $2,000 plus 5% sales over $100,000
'   '   '   '   '   '   '400,000 and over = commission $17000 plus 10% over %400,000
'   '   '   '   '   'Each button performs the same calculations above but in a different way.
'   '   '   '   '   'Add $500 if over ten years is checked.
'   '   '   '   '   'Add $700 if traveling is checked.
'   '   '   '   '   'Clear Sales if check boxes or text changed.
'   '   '   '   '   '
' Programmer:   Jason R. Johnson on 11/12/2015

Option Explicit On
Option Infer Off
Option Strict On

Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_IfThen_Click(sender As Object, e As EventArgs) Handles btnCalc_IfThen.Click
        'define variables:
        Dim dblSales As Double = 0.0
        Dim blnIsSalesOK As Boolean = Double.TryParse(txtSales.Text, dblSales)
        Dim dblCommission As Double = 0.0

        'If not OK display error
        If Not blnIsSalesOK Then
            MessageBox.Show("Please enter a numerical value for Sales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        'If OK Calculate Commission
        If blnIsSalesOK AndAlso dblSales < 100001.0 Then 'calculate commission at 2% of sales
            dblCommission = dblSales * 0.02
        End If
        If blnIsSalesOK AndAlso dblSales >= 100001.0 AndAlso dblSales < 400001.0 Then 'calculate commission $2,000 plus 5% sales over $100,000
            dblCommission = (dblSales - 100000.0) * 0.05 + 2000.0
        End If
        If blnIsSalesOK AndAlso dblSales >= 400001.0 Then 'calculate commission $17000 plus 10% over %400,000
            dblCommission = (dblSales - 400000.0) * 0.1 + 17000.0
        End If

        'Add $500 if over ten years is checked.
        If chkMorThan10.Checked Then
            dblCommission = dblCommission + 500.0
        End If

        'Add $700 if traveling is checked.
        If chkTravel.Checked Then 'add 500 to Commission
            dblCommission = dblCommission + 700.0
        End If

        'Display Commission
        lblCommission.Text = dblCommission.ToString("C2")
    End Sub

    Private Sub btnCalc_NestedIf_Click(sender As Object, e As EventArgs) Handles btnCalc_NestedIf.Click
        'define variables:
        Dim dblSales As Double = 0.0
        Dim blnIsSalesOK As Boolean = Double.TryParse(txtSales.Text, dblSales)
        Dim dblCommission As Double = 0.0

        'If OK Perform Calculation
        If blnIsSalesOK Then
            If dblSales < 100001.0 Then 'calculate commission at 2% of sales
                dblCommission = dblSales * 0.02
            Else
                If dblSales >= 100001 AndAlso dblSales < 400001.0 Then 'calculate commission $2,000 plus 5% sales over $100,000
                    dblCommission = (dblSales - 100000.0) * 0.05 + 2000.0
                Else
                    If dblSales >= 400001.0 Then 'calculate commission $17000 plus 10% over %400,000
                        dblCommission = (dblSales - 400000.0) * 0.1 + 17000.0
                    End If
                End If
            End If
        Else ' If not OK display error.
            MessageBox.Show("Please enter a numerical value for Sales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        'Add $500 if over ten years is checked.
        If chkMorThan10.Checked Then
            dblCommission = dblCommission + 500.0
        End If

        'Add $700 if traveling is checked.
        If chkTravel.Checked Then
            dblCommission = dblCommission + 700.0
        End If
        'Display Commission
        lblCommission.Text = dblCommission.ToString("C2")
    End Sub

    Private Sub btnCalc_IfElseIf_Click(sender As Object, e As EventArgs) Handles btnCalc_IfElseIf.Click
        'define variables:
        Dim dblSales As Double = 0.0
        Dim blnIsSalesOK As Boolean = Double.TryParse(txtSales.Text, dblSales)
        Dim dblCommission As Double = 0.0

        'Perform Calculation
        If blnIsSalesOK Then 'Calculate Commission
            If dblSales < 100001.0 Then 'calculate commission at 2% of sales
                dblCommission = dblSales * 0.02
            ElseIf dblSales >= 100001 AndAlso dblSales < 400001.0 Then 'calculate commission $2,000 plus 5% sales over $100,000
                dblCommission = (dblSales - 100000.0) * 0.05 + 2000.0
            ElseIf dblSales >= 400001.0 Then 'calculate commission $17000 plus 10% over %400,000
                dblCommission = (dblSales - 400000.0) * 0.1 + 17000.0
            End If
        Else 'display error message if entry not valid
            MessageBox.Show("Please enter a numerical value for Sales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        'Add $500 if over ten years is checked.
        If chkMorThan10.Checked Then
            dblCommission = dblCommission + 500.0
        End If

        'Add $700 if traveling is checked.
        If chkTravel.Checked Then
            dblCommission = dblCommission + 700.0
        End If

        'Display Commission
        lblCommission.Text = dblCommission.ToString("C2")
    End Sub

    Private Sub btnCalc_SelectCase_Click(sender As Object, e As EventArgs) Handles btnCalc_SelectCase.Click
        'define variables:
        Dim dblSales As Double = 0.0
        Dim blnIsSalesOK As Boolean = Double.TryParse(txtSales.Text, dblSales)
        Dim dblCommission As Double = 0.0

        'Perform Calculation
        If blnIsSalesOK Then 'Calculate Commission
            'Assign commissions using SelectCase
            Select Case dblSales
                Case Is < 100001.0 'calculate commission at 2% of sales
                    dblCommission = dblSales * 0.02
                Case 100001.0 To 400000.99 'calculate commission $2,000 plus 5% sales over $100,000
                    dblCommission = (dblSales - 100000.0) * 0.05 + 2000.0
                Case Is > 400000.99 'calculate commission $17000 plus 10% over %400,000
                    dblCommission = (dblSales - 400000.0) * 0.1 + 17000.0
            End Select
        Else 'display error message if entry not valid
            MessageBox.Show("Please enter a numerical value for Sales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        'Add $500 if over ten years is checked.
        If chkMorThan10.Checked Then
            dblCommission = dblCommission + 500.0
        End If

        'Add $700 if traveling is checked.
        If chkTravel.Checked Then
            dblCommission = dblCommission + 700.0
        End If

        'Display Commission
        lblCommission.Text = dblCommission.ToString("C2")
    End Sub

End Class
