' Name: Play it again Project   
' Purpose: Calculate the total number of discs sold and the total sales amount
'
'
'
' Programmer: Jason R. Johnson 
' Date: 10/17/2015


Public Class MainForm
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Prepare screen for next sale.
        txtDvdQuantity.Text = String.Empty  ' clear dvd's text box.
        txtBlueRayQuantity.Text = String.Empty
        txtDvdPrice.Text = String.Empty
        txtBlueRayPrice.Text = String.Empty
        lblDvdTotal.Text = String.Empty
        lblBlueRayTotal.Text = String.Empty
        lblTotalDisks.Text = String.Empty
        lblTotalSales.Text = String.Empty
        txtDvdQuantity.Focus()
        ' Send focus to DVDs box.
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        ' remove buttons from print view and add back after print.
        Me.Width = Me.Width - 120
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
        Me.Width = Me.Width + 120
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculate number of disks sold
        ' Val converts to number for calculation.
        ' CStr converts to string to string to be moved to Text label.
        ' Fixed formats as number but without dollar sign.
        ' Currency formats as currency - with dollar sign.

        lblTotalDisks.Text = CStr(Val(txtDvdQuantity.Text) + Val(txtBlueRayQuantity.Text))
        lblDvdTotal.Text = CStr(Val(txtDvdQuantity.Text) * Val(txtDvdPrice.Text))
        lblBlueRayTotal.Text = CStr(Val(txtBlueRayQuantity.Text) * Val(txtBlueRayPrice.Text))
        lblTotalSales.Text = Format(Val(lblDvdTotal.Text) + Val(lblBlueRayTotal.Text), "Currency")



    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblTotalSales_Click(sender As Object, e As EventArgs) Handles lblTotalSales.Click

    End Sub
End Class
