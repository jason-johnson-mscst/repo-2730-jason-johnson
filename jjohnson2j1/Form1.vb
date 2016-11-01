' Name: Strings 8 - p. 520 // Ex: 2, 5, and 6.
' Purpose: Learning different options for Strings
' Programmer: Jason R. Johnson on 11/19/2015

Option Explicit On
Option Infer Off
Option Strict On

Public Class Form1
    Private Sub btnDisplayColor_Click(sender As Object, e As EventArgs) Handles btnDisplayColor.Click
        DisplayColor(txtExTwo1.Text)
        DisplayColor(txtExTwo2.Text)
        DisplayColor(txtExTwo3.Text)
        DisplayColor(txtExTwo4.Text)
        DisplayColor(txtExTwo5.Text)
    End Sub

    Private Sub DisplayColor(ByVal strItmNum As String)
        Dim strLength As Integer

        strLength = strItmNum.Length

        If strLength = 7 Then
            If stritmNum.ToLower Like "???b???" Then
                lstColors.Items.Add(strItmNum & ": Blue")
            ElseIf strItmNum.ToLower Like "???g???" Then
                lstColors.Items.Add(strItmNum & ": Green")
            ElseIf strItmNum.ToLower Like "???r???" Then
                lstColors.Items.Add(strItmNum & ": Red")
            ElseIf strItmNum.ToLower Like "???w???" Then
                lstColors.Items.Add(strItmNum & ": White")
            Else
                lstColors.Items.Add("Invalid: " & strItmNum)
            End If
        Else
            lstColors.Items.Add("Invalid: Blank Entry")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtExTwo1_TextChanged(sender As Object, e As EventArgs) Handles txtExTwo1.TextChanged, txtExTwo2.TextChanged, txtExTwo3.TextChanged, txtExTwo4.TextChanged, txtExTwo5.TextChanged
        lstColors.Items.Clear()
    End Sub

    Private Sub DisplayDelivery(sender As Object, e As EventArgs) Handles btnDisplayDelivery.Click
        DisplayDelivery(txtExSix1.Text)
        DisplayDelivery(txtExSix2.Text)
        DisplayDelivery(txtExSix3.Text)
        DisplayDelivery(txtExSix4.Text)
        DisplayDelivery(txtExSix5.Text)
        DisplayDelivery(txtExSix6.Text)
    End Sub

    Private Sub DisplayDelivery(ByVal partNum As String)

        If partNum.Length >= 3 And partNum.Length <= 4 And partNum.ToLower Like "##[a-z]*" Then
            Select Case partNum.ToLower.Substring(2)
                Case "ms"
                    lstDelivery.Items.Add("Mail-Standard")
                Case "mp"
                    lstDelivery.Items.Add("Mail-Priority")
                Case "fs"
                    lstDelivery.Items.Add("FedEx-Standard")
                Case "fo"
                    lstDelivery.Items.Add("FedEx-Overnight")
                Case "u"
                    lstDelivery.Items.Add("UPS")
                Case Else
                    lstDelivery.Items.Add("Invalid: " & partNum)
            End Select
        Else
            lstDelivery.Items.Add("Invalid: " & partNum)
        End If
    End Sub

    Private Sub txtExSix1_TextChanged(sender As Object, e As EventArgs) Handles txtExSix1.TextChanged, txtExSix2.TextChanged, txtExSix3.TextChanged, txtExSix4.TextChanged, txtExSix5.TextChanged, txtExSix6.TextChanged
        lstDelivery.Items.Clear()
    End Sub

    Private Sub btnProperCase_Click(sender As Object, e As EventArgs) Handles btnProperCase.Click
        'define variables:
        Dim strName As String
        Dim strFirstLet As String
        Dim intIndex As Integer

        'Convert txtName.Text to lowercase and assign to variable
        strName = txtName.Text.ToLower

        'Find space'
        intIndex = strName.IndexOf(" ")

        'Correct First Name Caps.
        strFirstLet = strName.Substring(0, 1)
        strFirstLet = strFirstLet.ToUpper
        strName = strName.Remove(0, 1)
        strName = strName.Insert(0, strFirstLet)

        'Correct Last Name Caps
        strFirstLet = strName.Substring(intIndex + 1, 1)
        strFirstLet = strFirstLet.ToUpper
        strName = strName.Remove(intIndex + 1, 1)
        strName = strName.Insert(intIndex + 1, strFirstLet)

        lblProperCase.Text = strName
    End Sub
End Class
