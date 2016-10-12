' Name: JJohnson2d1 Multiple Projects 
' Purpose: Mastering Chapter 4 topics. Exercises  p237-238 of book. 
'   Group box 1: p237 #1 Calculate employee salary and display at new rate. Pay Grade 1 gets 3% all others get 2%. Modified UI to have label display the new salary.
'   Group box 2: p238 #2 same idea as #1 but now will calculate Pay Grades of 1-3 at 3% all others get 2%.  
'   Group box 3: p238 #3 Message box asks if shipping should be applied. Calculates price and adds shipping if yes is selected.
'   Group box 4: p238 #4 Compares both amounts to see which is larger, then takes 50% discount on smaller number. Displays savings in message box. Calculates total. The Instructor video said to see page 199 to review code for finding the larger number to use but mine is different. My "Temp" variable is outside of the if/then so I could use it inside and out for the message. May want to ask before handing in.

' Programmer: Jason R. Johnson on 11/8-9/2015

Option Explicit On 'must define variable statements
Option Infer Off 'will not infer what type for conversions.
Option Strict On 'will not convert for you.

Public Class frmMain
    Private Sub btnCalculate1_Click(sender As Object, e As EventArgs) Handles btnCalculate1.Click
        'define variables:

        Const decTHREEPERCENT1 As Decimal = 0.03D
        Const decTWOPERCENT1 As Decimal = 0.02D
        Dim intPayGrade1 As Integer = 0I
        Dim decCurrentSalary1 As Decimal = 0.0D
        Dim decRaise1 As Decimal = 0.0D
        Dim decNewSalary1 As Decimal = 0.0D

        'store input in variables
        Decimal.TryParse(txtCurrentSalary1.Text, decCurrentSalary1)
        Integer.TryParse(txtPayGrade1.Text, intPayGrade1)

        'Calculate increase. Pay grade 1 receives 3%. All others receive 2% increase.
        If intPayGrade1 = 1 Then
            'calculate amount using three percent.
            decRaise1 = decCurrentSalary1 * decTHREEPERCENT1
            decNewSalary1 = decCurrentSalary1 + decRaise1
        Else
            'calculate amount using two percent
            decRaise1 = decCurrentSalary1 * decTWOPERCENT1
            decNewSalary1 = decCurrentSalary1 + decRaise1
        End If
        'Display New Salary
        lblNewSalary1.Text = decNewSalary1.ToString("C2")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate2_Click(sender As Object, e As EventArgs) Handles btnCalculate2.Click
        'define variables:

        Const decTHREEPERCENT2 As Decimal = 0.03D
        Const decTWOPERCENT2 As Decimal = 0.02D
        Dim intPayGrade2 As Integer = 0I
        Dim decCurrentSalary2 As Decimal = 0.0D
        Dim decRaise2 As Decimal = 0.0D
        Dim decNewSalary2 As Decimal = 0.0D

        'store input in variables
        Decimal.TryParse(txtCurrentSalary2.Text, decCurrentSalary2)
        Integer.TryParse(txtPayGrade2.Text, intPayGrade2)

        'Calculate increase. Pay grade 1 through 3 receive 3%. All others receive 2% increase.
        If intPayGrade2 >= 1 AndAlso intPayGrade2 <= 3 Then
            'calculate amount using three percent.
            decRaise2 = decCurrentSalary2 * decTHREEPERCENT2
            decNewSalary2 = decCurrentSalary2 + decRaise2
        Else
            'calculate amount using two percent
            decRaise2 = decCurrentSalary2 * decTWOPERCENT2
            decNewSalary2 = decCurrentSalary2 + decRaise2
        End If
        'Display New Salary
        lblNewSalary2.Text = decNewSalary2.ToString("C2")
    End Sub

    Private Sub btnCalculate3_Click(sender As Object, e As EventArgs) Handles btnCalculate3.Click
        'define variables:

        Const decSHIPPINGFEE3 As Decimal = 15D
        Dim intTeaPounds3 As Integer = 0I
        Dim decTeaPrice3 As Decimal = 0.0D
        Dim decPreShipping3 As Decimal = 0.0D
        Dim decTotalPrice3 As Decimal = 0.0D
        Dim dlgButton3 As DialogResult

        'store input in variables
        Integer.TryParse(txtPoundsOfTea.Text, intTeaPounds3)
        Decimal.TryParse(txtPricePerPound.Text, decTeaPrice3)

        'Calculate price before shipping:
        decPreShipping3 = intTeaPounds3 * decTeaPrice3

        'Ask if shipping should be added
        dlgButton3 =
            MessageBox.Show("Charge for shipping?", "Shipping Charge",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If dlgButton3 = 6 Then
            decTotalPrice3 = decPreShipping3 + decSHIPPINGFEE3
        Else
            decTotalPrice3 = decPreShipping3
        End If
        'Display final Price
        lblTotal3.Text = decTotalPrice3.ToString("C2")


    End Sub

    Private Sub ClearAmounts(sender As Object, e As EventArgs) Handles txtPoundsOfTea.TextChanged, txtPricePerPound.TextChanged, txtItemOnePrice4.TextChanged, txtItemTwoPrice4.TextChanged
        'Clear Amounts if text box info changes
        lblTotal3.Text = String.Empty
        lblTotalPrice4.Text = String.Empty
    End Sub

    Private Sub btnCalculate4_Click(sender As Object, e As EventArgs) Handles btnCalculate4.Click
        'define variables:
        Const decDISCOUNT As Decimal = 0.5D
        Dim decItem1Price4 As Decimal = 0.0D
        Dim decItem2Price4 As Decimal = 0.0D
        Dim decDiscountTemp4 As Decimal = 0.0D
        Dim decTotalPrice4 As Decimal = 0.0D

        'store input in variables
        Decimal.TryParse(txtItemOnePrice4.Text, decItem1Price4)
        Decimal.TryParse(txtItemTwoPrice4.Text, decItem2Price4)

        'Determine larger number and take half off lower number.
        If decItem1Price4 > decItem2Price4 Then
            decDiscountTemp4 = decItem2Price4 * decDISCOUNT
            decTotalPrice4 = decItem1Price4 + decDiscountTemp4
        Else
            'else also covers if numbers are equal.
            decDiscountTemp4 = decItem1Price4 * decDISCOUNT
            decTotalPrice4 = decItem2Price4 + decDiscountTemp4
        End If
        'Display Total in total label.
        lblTotalPrice4.Text = decTotalPrice4.ToString("C2")

        'Display discount in message box.
        MessageBox.Show("You saved " & decDiscountTemp4.ToString("C2"), "Discount",
            MessageBoxButtons.OK)
    End Sub

    Private Sub txtCurrentSalary1_TextChanged(sender As Object, e As EventArgs) Handles txtCurrentSalary1.TextChanged

    End Sub
End Class
