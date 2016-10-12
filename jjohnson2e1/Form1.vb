' Name: JJohnson2e1 Multiple Projects 
' Programmer: Jason R. Johnson on 11/10/2015

' Purpose: Mastering Chapter 4 topics. P250 and 251. 

'   Group Box 1: p250 #8: OrElse:
'       Use Radio Buttons to populate Zip code field.
'       Use OrElse.
'       For identified zip codes, display shipping at $15.00 or 
'       Any other entry, display shipping at $17.75.
'       Clear shipping if text changes.

'   Group Box 2: p250 #8: AndAlso:
'       SAME REQ and results as Group Box 1, but using AndAlso

'   Group Box 3: p250 #10: Meter Reading - 
'       User enters current and previous meter reading.
'       Tool calculates and displays gallons used and total charge. 
'       Minimum water charge = $16.67.
'       Otherwise Charge for Water = $1.75 per 1000 gallons.
'       Text Boxes should accept numbers only (and Backspace).
'       Clear Gallons and Total if text input changes.
'       Select all text when entering the text field.
'       Display Error message if Gallons are negative (and clear gallon and total).
'       Ask Mark about String.Empty for meter being a possibility after error message if negative (Seems odd to list 0.0 and give a minimum charge after error). 

'Addl Notes: 
'    Added Radio buttons. Created Radio button Checked Change Process To place Zip Codes from radio into Text Box.
'    Introduced CType (Cast type or Convert/Type) - Where we converted the sender object into RadioButton Type via CType so we could store the CheckedChanged info in a variable.

Option Explicit On 'must define variable statements
Option Infer Off 'will not infer what type for conversions.
Option Strict On 'will not convert for you.

Public Class Form1
    'Defined class-level variables to use in both A and B exercises:
    Const decINZIP As Decimal = 15D
    Const decOUTZIP As Decimal = 17.75D

    'Place Zip Codes from radio A into Text Box if selected:
    Private Sub RadioACheckedChanged(sender As Object, e As EventArgs) _
        Handles rdo42164A.CheckedChanged, rdo42544A.CheckedChanged, rdo45134A.CheckedChanged, rdo60345A.CheckedChanged

        Dim rdoButton As RadioButton = CType(sender, RadioButton)
        If rdoButton.Checked Then
            txtZipA.Text = rdoButton.Text
        End If
    End Sub

    'Use OrElse (reverse logic to AndAlso). Calculate shipping at $15.00 for the identified zip codes. $17.75 if it is any other entry.
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculateA.Click
        'Define variable:
        Dim decZipA As Decimal = 0.0D

        'Convert and store input in variables.
        Decimal.TryParse(txtZipA.Text, decZipA)

        'Check to see if input IS one of the four zip codes:
        If decZipA = 42164 OrElse
           decZipA = 45134 OrElse
           decZipA = 60345 OrElse
           decZipA = 42544 Then
            lblShipChargeA.Text = decINZIP.ToString("C2")
        Else
            lblShipChargeA.Text = decOUTZIP.ToString("C2")
        End If
    End Sub

    'Clear Shipping amt if A Zip Code changed.
    Private Sub ClearShippingA(sender As Object, e As EventArgs) Handles txtZipA.TextChanged
        lblShipChargeA.Text = String.Empty
    End Sub

    'Place Zip Codes from radio B into Text Box if selected:
    Private Sub RadioBCheckedChanged(sender As Object, e As EventArgs) _
        Handles rdo42164B.CheckedChanged, rdo42544B.CheckedChanged, rdo45134B.CheckedChanged, rdo60345B.CheckedChanged

        Dim rdoButton As RadioButton = CType(sender, RadioButton)
        If rdoButton.Checked Then
            txtZipB.Text = rdoButton.Text
        End If

    End Sub

    'Use AndAlso (reverse logic to OrElse). Calculate shipping at $15.00 for the identified zip codes. $17.75 if it is any other entry.
    Private Sub btnCalculateB_Click(sender As Object, e As EventArgs) Handles btnCalculateB.Click
        'define variable
        Dim decZipB As Decimal = 0.0D

        'assign input to variable.
        Decimal.TryParse(txtZipB.Text, decZipB)

        'Check to see if input IS NOT one of the four zip codes:
        If decZipB <> 42164 AndAlso
           decZipB <> 45134 AndAlso
           decZipB <> 60345 AndAlso
           decZipB <> 42544 Then
            lblShipChargeB.Text = decOUTZIP.ToString("C2")
        Else
            lblShipChargeB.Text = decINZIP.ToString("C2")
        End If
    End Sub

    'Clear Shipping amt if B Zip Code changed.
    Private Sub ClearShippingB(sender As Object, e As EventArgs) Handles txtZipB.TextChanged
        lblShipChargeB.Text = String.Empty
    End Sub

    'Exit Form if Exit button clicked.
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    'Meter Reader 
    Private Sub btnCalculateMeter_Click(sender As Object, e As EventArgs) Handles btnCalculateMeter.Click
        'define variables:
        Const decPricePerUnit As Decimal = 1.75D
        Const decWaterUnit As Decimal = 1000D
        Const decMinCharge As Decimal = 16.67D
        Dim decCurrent As Decimal = 0.0D
        Dim decPrevious As Decimal = 0.0D
        Dim decGallons As Decimal = 0.0D
        Dim decTotalCharge As Decimal = 0.0D

        'convert/store input in variables:
        Decimal.TryParse(txtCurrentReading.Text, decCurrent)
        Decimal.TryParse(txtPreviousReading.Text, decPrevious)

        'Calculate number of Gallons
        decGallons = decCurrent - decPrevious

        'Calculate charges
        decTotalCharge = decGallons / decWaterUnit * decPricePerUnit

        'Display Total gallons
        lblGallonsUsed.Text = decGallons.ToString

        'Display minimum of $16.67 if less than $16.67. If not, calculate full charges.
        If decTotalCharge <= decMinCharge Then
            lblTotalCharge.Text = decMinCharge.ToString("C2")
        Else
            lblTotalCharge.Text = decTotalCharge.ToString("C2")
        End If
        If decGallons < 0 Then
            lblGallonsUsed.Text = "0.0"
            'lblTotalCharge.Text = String.Empty  
            MessageBox.Show("Please verify amounts. Current reading should be larger than Previous reading.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub

    'Verify only numbers and backspace are valid entries for Current and Previous Meter Readings.
    Private Sub NumberOnlyMeterKeyPress(sender As Object, e As KeyPressEventArgs) _
        Handles txtCurrentReading.KeyPress, txtPreviousReading.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    'Clear Gallons and Total if text changes.
    Private Sub txtCurrentReading_TextChanged(sender As Object, e As EventArgs) Handles txtCurrentReading.TextChanged, txtPreviousReading.TextChanged
        lblGallonsUsed.Text = String.Empty
        lblTotalCharge.Text = String.Empty
    End Sub

    'When entering text box, select all.
    Private Sub txtMeterreadings(sender As Object, e As EventArgs) Handles txtCurrentReading.Enter, txtPreviousReading.Enter
        Dim txtBoxSelect As TextBox = CType(sender, TextBox)
        txtBoxSelect.SelectAll()
    End Sub
End Class
