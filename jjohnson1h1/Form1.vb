' Name: Play it again Project   
' Purpose: Calculate the total number of discs sold and the total sales amount
'
'
'
' Programmer: Jason R. Johnson 
' Date: 09/23/2016


Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Text = String.Empty
        txtHours.Text = String.Empty
        txtPayRate.Text = String.Empty
        lblGrossPay.Text = String.Empty
        lblFWT.Text = String.Empty
        lblFICA.Text = String.Empty
        lblStateTax.Text = String.Empty
        lblNetPay.Text = String.Empty
        txtName.Focus()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'fixed - formats with decimals.
        'currency - formats with decimal and dollar sign.

        lblGrossPay.Text = Format(Val(txtHours.Text) * Val(txtPayRate.Text), "Fixed")
        lblFWT.Text = Format(Val(lblGrossPay.Text) * 0.2, "Fixed")
        lblFICA.Text = Format(Val(lblGrossPay.Text) * 0.08, "Fixed")
        lblStateTax.Text = Format(Val(lblGrossPay.Text) * 0.03, "Fixed")
        lblNetPay.Text = Format(Val(lblGrossPay.Text) - Val(lblFWT.Text) - Val(lblFICA.Text) - Val(lblStateTax.Text), "Currency")
    End Sub
End Class
