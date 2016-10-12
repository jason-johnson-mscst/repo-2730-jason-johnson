' Name: JJohnson2C1 Project not in book. 
' Purpose: Study number conversions and partner with info on page 117 of book to test number limits
' Programmer: Jason R. Johnson on 11/8/2015

Option Explicit On 'must define variable statements
Option Infer Off 'will not infer what type for conversions.
Option Strict On 'will not convert for you.

' this project is to help study numbers and conversions. Also reference page 117 in book.

Public Class Form1
    'set class-level variables:
    Private string1, string2, string3 As String
    Private byte1, byte2, byte3 As Byte
    Private short1, short2, short3 As Short
    Private integer1, integer2, integer3 As Integer
    Private long1, long2, long3 As Long
    Private single1, single2, single3 As Single
    Private double1, double2, double3 As Double
    Private decimal1, decimal2, decimal3 As Decimal
    Private date1, date2, date3 As Date

    Private Sub Clear()
        'clear values in third column
        lblByte3.Text = String.Empty
        byte3 = 0

        lblShort3.Text = String.Empty
        short3 = 0S

        lblInteger3.Text = String.Empty
        integer3 = 0I

        lblLong3.Text = String.Empty
        long3 = 0L

        lblSingle3.Text = String.Empty
        single3 = 0.0F

        lblDouble3.Text = String.Empty
        double3 = 0.0R

        lblDecimal3.Text = String.Empty
        decimal3 = 0D

        lblDate3.Text = String.Empty
        date3 = Date.MinValue
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Clear()

        'clear assign value to variables:
        string1 = String.Empty 'could also be "" (double quotes)
        string2 = String.Empty
        string3 = String.Empty
        byte1 = 0 'one byte
        byte2 = 0
        byte3 = 0
        short1 = 0S '2 bytes or 16-bit signed integer
        short2 = 0S
        short3 = 0S
        integer1 = 0I '4 bytes or 32-bit signed integer
        integer2 = 0I
        integer3 = 0I
        long1 = 0L '8 bytes or 64-bit signed integer.
        long2 = 0L
        long3 = 0L
        single1 = 0.0F '4 bytes - single-precision floating-point number
        single2 = 0.0F
        single3 = 0.0F
        double1 = 0.0R '8 bytes - Real - double-precision floating-point number
        double2 = 0.0R
        double3 = 0.0R
        decimal1 = 0D '16 bytes - 
        decimal2 = 0D
        decimal3 = 0D
        date1 = Date.MinValue
        date2 = Date.MinValue
        date3 = Date.MinValue

        'take text from input field and place in variable, then take from variable and display as label

        string1 = txtInput1.Text
        lblString1.Text = string1
        string2 = txtInput2.Text
        lblString2.Text = string2

        Byte.TryParse(txtInput1.Text, byte1)
        lblByte1.Text = byte1.ToString()
        Byte.TryParse(txtInput2.Text, byte2)
        lblByte2.Text = byte2.ToString()

        Short.TryParse(txtInput1.Text, short1)
        lblShort1.Text = short1.ToString()
        Short.TryParse(txtInput2.Text, short2)
        lblShort2.Text = short2.ToString()

        Integer.TryParse(txtInput1.Text, integer1)
        lblInteger1.Text = integer1.ToString()
        Integer.TryParse(txtInput2.Text, integer2)
        lblInteger2.Text = integer2.ToString()

        Long.TryParse(txtInput1.Text, long1)
        lblLong1.Text = long1.ToString()
        Long.TryParse(txtInput2.Text, long2)
        lblLong2.Text = long2.ToString()

        Single.TryParse(txtInput1.Text, single1)
        lblSingle1.Text = single1.ToString()
        Single.TryParse(txtInput2.Text, single2)
        lblSingle2.Text = single2.ToString()

        Double.TryParse(txtInput1.Text, double1)
        lblDouble1.Text = double1.ToString()
        Double.TryParse(txtInput2.Text, double2)
        lblDouble2.Text = double2.ToString()

        Decimal.TryParse(txtInput1.Text, decimal1)
        lblDecimal1.Text = decimal1.ToString()
        Decimal.TryParse(txtInput2.Text, decimal2)
        lblDecimal2.Text = decimal2.ToString()

        Date.TryParse(txtInput1.Text, date1)
        lblDate1.Text = date1.ToString()
        Date.TryParse(txtInput2.Text, date2)
        lblDate2.Text = date2.ToString()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'add column 1 and column 2, display in column 3
        On Error Resume Next
        Clear()

        string3 = string1 + string2
        lblString3.Text = string3.ToString()

        byte3 = byte1 + byte2
        lblByte3.Text = byte3.ToString()

        short3 = short1 + short2
        lblShort3.Text = short3.ToString()

        integer3 = integer1 + integer2
        lblInteger3.Text = integer3.ToString()

        long3 = long1 + long2
        lblLong3.Text = long3.ToString()

        single3 = single1 + single2
        lblSingle3.Text = single3.ToString()

        double3 = double1 + double2
        lblDouble3.Text = double3.ToString()

        decimal3 = decimal1 + decimal2
        lblDecimal3.Text = decimal3.ToString()

        Dim span As TimeSpan
        TimeSpan.TryParse(txtInput1.Text, span)
        date3 = date1 + span
        lblDate3.Text = date3.ToString()

    End Sub
    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        'subtract column two from column 1 and display in column 3.
        On Error Resume Next
        Clear()

        'string3 = string1 + string2
        'lblString3.Text = string3.ToString()

        byte3 = byte1 - byte2
        lblByte3.Text = byte3.ToString()

        short3 = short1 - short2
        lblShort3.Text = short3.ToString()

        integer3 = integer1 - integer2
        lblInteger3.Text = integer3.ToString()

        long3 = long1 - long2
        lblLong3.Text = long3.ToString()

        single3 = single1 - single2
        lblSingle3.Text = single3.ToString()

        double3 = double1 - double2
        lblDouble3.Text = double3.ToString()

        decimal3 = decimal1 - decimal2
        lblDecimal3.Text = decimal3.ToString()

        Dim span As TimeSpan = date1 - date2
        lblDate3.Text = span.ToString()

    End Sub
    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        'multiply column 1 and column 2 and display in column 3
        On Error Resume Next
        Clear()

        'string3 = string1 * string2
        'lblString3.Text = string3.ToString()

        byte3 = byte1 * byte2
        lblByte3.Text = byte3.ToString()

        short3 = short1 * short2
        lblShort3.Text = short3.ToString()

        integer3 = integer1 * integer2
        lblInteger3.Text = integer3.ToString()

        long3 = long1 * long2
        lblLong3.Text = long3.ToString()

        single3 = single1 * single2
        lblSingle3.Text = single3.ToString()

        double3 = double1 * double2
        lblDouble3.Text = double3.ToString()

        decimal3 = decimal1 * decimal2
        lblDecimal3.Text = decimal3.ToString()
    End Sub
    Private Sub btnDivideFloatingPoint_Click(sender As Object, e As EventArgs) Handles btnDivideFloatingPoint.Click
        'Divide using normal division / When we do this, think of example 1/3 where you get 0.33333333 since the decimal comes in the lower numbers move them up to "doubles" to do the calculation, we then need to convert "back" before we can put into the lower variables. 
        On Error Resume Next
        Clear()

        'string3 = string1 / string2
        'lblString3.Text = string3.ToString()

        byte3 = Convert.ToByte(byte1 / byte2) 'had to convert to byte. with such low numbers it converts bytes to doubles, then performs division, then conversion back to byte.
        lblByte3.Text = byte3.ToString()

        short3 = Convert.ToInt16(short1 / short2) 'same as above converts to doubles then back.
        lblShort3.Text = short3.ToString()

        integer3 = Convert.ToInt32(integer1 / integer2) 'same as above converts to doubles then back.
        lblInteger3.Text = integer3.ToString()

        long3 = Convert.ToInt64(long1 / long2) 'same as above converts to doubles then back.
        lblLong3.Text = long3.ToString()

        single3 = single1 / single2
        lblSingle3.Text = single3.ToString()

        double3 = double1 / double2
        lblDouble3.Text = double3.ToString()

        decimal3 = decimal1 / decimal2
        lblDecimal3.Text = decimal3.ToString()
    End Sub
    Private Sub btnDivideInteger_Click(sender As Object, e As EventArgs) Handles btnDivideInteger.Click
        'divide using integer division aka the backslash: \ . But now...you can't do integer division when you have floating point numbers so we removed/hid those calculations.  Also note if you do 7/3 you get 2 (no decimal remainder only "integers").
        On Error Resume Next
        Clear()

        'string3 = string1 \ string2
        'lblString3.Text = string3.ToString()

        byte3 = byte1 \ byte2
        lblByte3.Text = byte3.ToString()

        short3 = short1 \ short2
        lblShort3.Text = short3.ToString()

        integer3 = integer1 \ integer2
        lblInteger3.Text = integer3.ToString()

        long3 = long1 \ long2
        lblLong3.Text = long3.ToString()

        'single3 = single1 \ single2
        'lblSingle3.Text = single3.ToString()

        'double3 = double1 \ double2
        'lblDouble3.Text = double3.ToString()

        'decimal3 = decimal1 \ decimal2
        'lblDecimal3.Text = decimal3.ToString()
    End Sub
    Private Sub btnMultiTypes_Click(sender As Object, e As EventArgs) Handles btnMultiTypes.Click
        'The rules here is that the lower number for the calculation will be implicitly converted to the larger number to do the calculation. Once complete it will error if you then try to pop into the smaller "type" variable. 

        ' integer3 = integer1 + long2 'this errors because the calculations are performed using long (the larger number). To work...You would to convert it to long to place in a long size variable:
        long3 = integer1 + long2

        'short3 = integer1 + short2 'again this will error because you are using the larger "integer" number for the calculation and you end up with a "integer answer" that you cannot place back into a short variable. Again you would need to convert - or in this case...store in the integer variable:
        short3 = Convert.ToInt16(integer1 + short2) 'or:
        integer3 = integer1 + short2

        'long3 = single1 + long2 ' errors again because of mismatch like above. 
        single3 = single1 + long2

        'long3 = long1 + (short2 * single2) 'errors again you would End up With a Single.
        single3 = long1 + (short2 * single2)

    End Sub
End Class
