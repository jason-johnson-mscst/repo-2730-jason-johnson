' Name: JJohnson2A1 Play it again Project   
' Purpose: Calculate the total number of discs sold and the total sales amount, pop window to collect sales clerk name, keep sales clerk name until changed. Clear calculations if inputs are updated via event handler. Initially had popup window display on form load - to do this we used a class-level variable to allow us to use the strClerk in both the form load and another procedure.
' Programmer: Jason R. Johnson on 10/24-26/2015


Option Explicit On
Option Infer Off
Option Strict On


Public Class Form1
    'declare class-level variable
    'Private strClerk As String

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Prepare screen for next sale.
        txtBluRays.Text = String.Empty  ' clear dvd's text box.
        txtDvds.Text = String.Empty
        lblTotalDisks.Text = String.Empty
        lblTotalSales.Text = String.Empty
        lblMessage.Text = String.Empty
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

        'lblTotalDisks.Text = Val(txtDvds.Text) + Val(txtBluRays.Text)
        'lblTotalSales.Text = Val(lblTotalDisks.Text) * 7
        'lblTotalSales.Text = Format(lblTotalSales.Text, "Currency")

        'Using older project (replacing code above). Replacing with variables, local constants, TryParce conversions, etc.
        Const strPROMPT As String = "Salesclerks name:"
        Const strTITLE As String = "Name Entry"
        'Const strDEFAULTNAME As String = "Jason R. Johnson"
        Const decDISC_PRICE As Decimal = 7D
        Const decTAX_RATE As Decimal = 0.03D

        Dim intDvds As Integer = 0
        Dim intBluRays As Integer = 0
        Dim intTotalDisks As Integer = 0
        Dim decSubtotal As Decimal = 0.0D
        Dim decSalesTax As Decimal = 0.0D
        Dim decTotalSales As Decimal = 0.0D
        Static strClerk As String

        'Fire Input box, collect name, and assign the name to a static variable
        strClerk = InputBox(strPROMPT, strTITLE, strClerk)

        'Calculate the total number of disks sold
        Integer.TryParse(txtDvds.Text, intDvds)
        Integer.TryParse(txtBluRays.Text, intBluRays)
        intTotalDisks = intDvds + intBluRays

        'Calculate the subtotal
        decSubtotal = intTotalDisks * decDISC_PRICE

        'Calculate the sales tax
        decSalesTax = decSubtotal * decTAX_RATE

        'Calculate the total sales
        decTotalSales = decSubtotal + decSalesTax

        'Display total amounts
        lblTotalDisks.Text = Convert.ToString(intTotalDisks)
        'lblTotalSales.Text = Convert.ToString(decTotalSales) Line below does the same but using a format of currency:
        lblTotalSales.Text = decTotalSales.ToString("C2")

        'Display tax and salesclerks name
        lblMessage.Text = "The sales tax was " & Convert.ToString(decSalesTax) & "." & ControlChars.NewLine & strClerk

    End Sub

    Private Sub txtDvds_TextChanged(sender As Object, e As EventArgs) _
        Handles txtDvds.TextChanged, txtBluRays.TextChanged
        'Clears total sales, total disks, and message content when txtDvds.Text or txtBluRays.Text is updated. 

        lblTotalSales.Text = String.Empty
        lblTotalDisks.Text = String.Empty
        lblMessage.Text = String.Empty
    End Sub

    'Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
    '    'gets the sales clerk's name
    '    Const strPROMPT As String = "Salesclerks name:"
    '    Const strTITLE As String = "Name Entry"
    '    Const strDEFAULTNAME As String = "Jason R. Johnson"

    '    'Assign the name to a class-level variable
    '    strClerk = InputBox(strPROMPT, strTITLE, strDEFAULTNAME)
    'End Sub
End Class


' This project starts explaining concepts. Setting Options in the project via the initial Options in the page. 
' Learned:
' New way to Copy content from one project to another: 
'   1. Created New forms project. 
'   2. Copied form UI from another project into New form. 
'   3. Copy/paste code from between Class Tags. 
' Modified project options in code adding the following in above class tag:
'   1. Option Explicit On = if I'm going to use a variable I need to declare it (needs Dim)
'   2. Option Infer Off = (When I declare a variable I have to say what type of variable it is. I have to say dim "As Integer, Decimal, etc", it won't infer the data type.)
'   3. Option Strict On = (Strict rules For type conversion. Won't allow me to take a number and put it into a string.)
' Set number variables as integers and decimals.
' Created class-level variable strClerk () as variable needed to be used for form load and later in lblMessage string.
' String concatenation with & vs +. Note: "&" should be for concatenation, "+" for calculations.
' InputBox Function:
'   1. Using Drop-downs at top for form name "events", then Load
'   2. Defined Constants.
'   3. syntax = InputBox(prompt, title)
' ControlChars.NewLine = entry for new line in string (aka return).
' New way to useToString using the currency format syntax: numbericVariableName.ToString(formatString) Format String can be:
'   1. C Or c For currency "C2" gives Two decimals, dollar sign, And thousands comma. 
'   2. N Or n gives Number - does Not include dollar sign - negative values display a negative sign. 
'   3. F or f for fixed point - same as number but does not include a thousands separator.
' Designated a default button for form:
'   1. Click on Form and update "Accept Button" property. This will be the button that "fires" when return is pressed.
' Questions:
'   1. On initial copy, image came with but I'm not sure why? Not listed in this projects resources. 
'   2. printform process didn't come in but was able to add again. Re-Added under toolbox controls via right click > Choose Items
'   3. Renaming form does not seem to change name for the Class Name List drop-down (still form1). 
' Later removed class-level "Private strClerk As String" and revised it to use "Static keyword so that it could be used within the sub-procedure.
' Added click event "Private Sub txtDvds_TextChanged(sender As Object, e As EventArgs) _ Handles txtDvds.TextChanged, txtBluRays.TextChanged" learned:
'   1. The when using the drop-downs to enter the click event it enters a default "name" in this case "txtDvds_TextChanged" you can change this to anything you want and it usually has PascalCase (both first and sequential words capped) - we updated to "ClearLabels". 
'   2. The underscore is added for a return, and is called a "Line Continuation character". You can then list multiple objects using "object.event" separated with a comma and "object.event". Like we did above with: "_ Handles txtDvds.TextChanged, txtBluRays.TextChanged"
