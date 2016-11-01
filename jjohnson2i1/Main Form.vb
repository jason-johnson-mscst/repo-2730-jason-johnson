
' Name: Strings 8 - p. 474 
' Purpose: Learning different options for Strings
' Programmer:   Jason R. Johnson on 11/18/2015

Option Explicit On
Option Infer Off
Option Strict On

Public Class Form1
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' #3 Remove/Insert: Remove "d" from "door" and replace with "fl" to make "floor"
        Dim strWord As String = txt03RemoveInsert.Text
        strWord = strWord.Remove(0, 1)
        strWord = strWord.Insert(0, "fl")
        lbl03RemoveInsert.Text = strWord

        ' #4 Substring: from "456ANK6" assign the string "6ANK" to strPartNum and display in the lbl
        Dim strPartNum As String = txt04Substring.Text
        strPartNum = strPartNum.Substring(2, 4)
        lbl04Substring.Text = strPartNum

        ' #5a: Display the string length in the lbl.
        Dim strLength As String = txt05aLength.Text
        strLength = strLength.Length.ToString
        lbl05aLength.Text = strLength

        ' #5b: Remove the leading and trailing spaces from strCity:
        Dim strCity As String = txt05bTrim.Text
        strCity = strCity.Trim
        lbl05bTrim.Text = strCity

        ' #5c: use the Remove/insert to change the word in the string from "cater" to "cattle".
        Dim strCater As String = txt05cRemoveInsert.Text
        strCater = strCater.Remove(3, 2)
        strCater = strCater.Insert(3, "tle")
        lbl05cRemoveInsert.Text = strCater

        ' #5d: using Insert, change "men" to "women"
        Dim strMen As String = txt05dInsert.Text
        strMen = strMen.Insert(0, "wo")
        lbl05dInsert.Text = strMen

        ' #5e: Change the string  from "667.99" to "**667.99"
        Dim strPay As String = txt05ePad.Text
        strPay = strPay.PadLeft(8, "*"c)
        lbl05ePad.Text = strPay

        '#06: Remove commas from the string "1,123,560" - known locations.
        Dim strRemoveComma As String = txt06Remove.Text
        strRemoveComma = strRemoveComma.Remove(1, 1)
        strRemoveComma = strRemoveComma.Remove(4, 1)
        lbl06Remove.Text = strRemoveComma

        '#07: Search string to see if it contains Jefferson St. 
        Dim strSearchJeff As String = txt07Contains.Text
        If strSearchJeff.ToUpper.Contains("JEFFERSON ST") Then
            lbl07Contains.Text = "Jeff St. Found"
        Else
            lbl07Contains.Text = "Jeff St. Not Found"
        End If

        '#12 - Search for "%" using index, Remove if it exits, then calculate 

        'Define variables
        Const intSALES As Integer = 1000
        Const intPERCENT As Integer = 100
        Dim strInput As String
        Dim intCharIndex As Integer
        Dim intTemp As Integer

        'Assign variable
        strInput = txt12LenRemove.Text

        'identify if % exists at what char
        intCharIndex = strInput.IndexOf("%")

        'if strPercentR contained a %:
        If intCharIndex <> -1 Then
            strInput = strInput.Remove(intCharIndex, 1)
        End If

        intTemp = CInt(strInput)
        intTemp = CInt(intTemp * intSALES / intPERCENT)
        lbl12LenRemove.Text = intTemp.ToString

        '#13 Compare ZipCodes - if 605 anything, then string: Shipping: $25, If 606 anything then string Shipping: $30, Else, invalid.

        Dim strZip As String

        strZip = txt13Like.Text

        If strZip Like "605##" Then
            lbl13Like.Text = "Shipping: $25"
        ElseIf strZip Like "606##" Then
            lbl13Like.Text = "Shipping: $30"
        Else
            lbl13Like.Text = "Invalid Amount"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
