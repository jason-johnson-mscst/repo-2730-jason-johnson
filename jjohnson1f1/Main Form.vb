' Name: KJ Sales Projections
' Purpose: Calculate calculate projected sales.
'
' Programmer: Jason R. Johnson on 10/05/2015

Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNsales.Text = "25000"
        txtSsales.Text = "10000"
        txtEsales.Text = "10000"
        txtWsales.Text = "15000"
        txtNincrease.Text = "0.10"
        txtSincrease.Text = "0.05"
        txtEincrease.Text = "0.04"
        txtWincrease.Text = "0.11"
        lblNorth.Text = String.Empty
        lblSouth.Text = String.Empty
        lblEast.Text = String.Empty
        lblWest.Text = String.Empty
        txtNsales.Focus()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        lblNorth.Text = Format(Val(txtNsales.Text) * Val(txtNincrease.Text), "Currency")
        lblSouth.Text = Format(Val(txtSsales.Text) * Val(txtSincrease.Text), "Currency")
        lblEast.Text = Format(Val(txtEsales.Text) * Val(txtEincrease.Text), "Currency")
        lblWest.Text = Format(Val(txtWsales.Text) * Val(txtWincrease.Text), "Currency")

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Me.Height = Me.Height - 50
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
        Me.Height = Me.Height + 50
    End Sub

End Class
