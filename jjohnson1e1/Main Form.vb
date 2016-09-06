' Name: Shiloh Products Bonus Form  
' Purpose: Calculate employee bonus at 1%.
'
' Programmer: Jason R. Johnson on 9/6/29/2016

Public Class frmBonus
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close form
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear screen and set focus to ID field.
        txtId.Text = String.Empty
        txtAnnualSales.Text = String.Empty
        lblBonus.Text = String.Empty
        txtId.Focus()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ' Set print preview to remove button view for print.
        Me.Height = Me.Height - 75
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
        Me.Height = Me.Height + 75
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Calculate bonus at 1%. 
        ' lblBonus.Text = txtAnnualSales.Text * 0.01
        ' lblBonus.Text = Val(txtAnnualSales.Text) * 0.01
        lblBonus.Text = Format(Val(txtAnnualSales.Text) * 0.01, "Currency")
    End Sub

    Private Sub txtAnnualSales_TextChanged(sender As Object, e As EventArgs) Handles txtAnnualSales.TextChanged

    End Sub
End Class
