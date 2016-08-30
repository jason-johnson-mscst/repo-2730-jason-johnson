' Name: Play it again Project   
' Purpose: Calculate the total number of discs sold and the total sales amount
'
'
'
' Programmer: Jason R. Johnson on 9/28/2015


Public Class MainForm
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Prepare screen for next sale.
        txtBluRays.Text = String.Empty  ' clear dvd's text box.
        txtDvds.Text = String.Empty
        lblTotalDisks.Text = String.Empty
        lblTotalSales.Text = String.Empty
        txtDvds.Focus()
        ' Send focus to DVDs box.
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        Me.Width = Me.Width - 120
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
        Me.Width = Me.Width + 120
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculate number of disks sold and total sales

        lblTotalDisks.Text = Val(txtDvds.Text) + Val(txtBluRays.Text)
        lblTotalSales.Text = Val(lblTotalDisks.Text) * 7
        lblTotalSales.Text = Format(lblTotalSales.Text, "Currency")
    End Sub
End Class
