' Name:         Grades
' Purpose:      Learning different options for calculations.
' Programmer:   Jason R. Johnson on 11/11/2015

Option Explicit On
Option Infer Off
Option Strict On

Public Class Form1
    Private Sub btnIfAndAlso_Click(sender As Object, e As EventArgs) Handles btnIfAndAlso.Click
        'Define local variables
        Dim dblScore_1 As Double = 0.0
        Dim dblScore_2 As Double = 0.0
        Dim dblScore_3 As Double = 0.0
        Dim blnIsScore1OK As Boolean
        Dim blnIsScore2OK As Boolean
        Dim blnIsScore3OK As Boolean
        Dim dblAverageScore As Double = 0.0

        'Assign and validate variables using TryParse, calculate average
        blnIsScore1OK = Double.TryParse(txtScore1.Text, dblScore_1)
        blnIsScore2OK = Double.TryParse(txtScore2.Text, dblScore_2)
        blnIsScore3OK = Double.TryParse(txtScore3.Text, dblScore_3)

        If blnIsScore1OK AndAlso blnIsScore2OK AndAlso blnIsScore3OK Then
            dblAverageScore = (dblScore_1 + dblScore_2 + dblScore_3) / 3

            'Assign Grades using If AndAlso
            If dblAverageScore >= 90 AndAlso dblAverageScore <= 100 Then
                lblGrade.Text = "A"
            End If
            If dblAverageScore >= 80 AndAlso dblAverageScore < 90 Then
                lblGrade.Text = "B"
            End If
            If dblAverageScore >= 70 AndAlso dblAverageScore < 80 Then
                lblGrade.Text = "C"
            End If
            If dblAverageScore >= 60 AndAlso dblAverageScore < 70 Then
                lblGrade.Text = "D"
            End If
            If dblAverageScore < 60 AndAlso dblAverageScore >= 0 Then
                lblGrade.Text = "F"
            End If
        Else
                MessageBox.Show("You must enter valid numbers for all three scores.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End If
    End Sub

    Private Sub btnNestedIf_Click(sender As Object, e As EventArgs) Handles btnNestedIf.Click
        'Define local variables
        Dim dblScore_1 As Double = 0.0
        Dim dblScore_2 As Double = 0.0
        Dim dblScore_3 As Double = 0.0
        Dim blnIsScore1OK As Boolean
        Dim blnIsScore2OK As Boolean
        Dim blnIsScore3OK As Boolean
        Dim dblAverageScore As Double = 0.0

        'Assign and validate variables using TryParse, calculate average
        blnIsScore1OK = Double.TryParse(txtScore1.Text, dblScore_1)
        blnIsScore2OK = Double.TryParse(txtScore2.Text, dblScore_2)
        blnIsScore3OK = Double.TryParse(txtScore3.Text, dblScore_3)

        If blnIsScore1OK AndAlso blnIsScore2OK AndAlso blnIsScore3OK Then
            dblAverageScore = (dblScore_1 + dblScore_2 + dblScore_3) / 3
            'Assign Grades using NestedIf
            If dblAverageScore >= 90 Then
                lblGrade.Text = "A"
            Else
                If dblAverageScore >= 80 Then
                    lblGrade.Text = "B"
                Else
                    If dblAverageScore >= 70 Then
                        lblGrade.Text = "C"
                    Else
                        If dblAverageScore >= 60 Then
                            lblGrade.Text = "D"
                        Else
                            If dblAverageScore < 60 Then
                                lblGrade.Text = "F"
                            End If
                        End If
                    End If
                End If
            End If
        Else
            MessageBox.Show("You must enter valid numbers for all three scores.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End If
    End Sub

    Private Sub btnElseIf_Click(sender As Object, e As EventArgs) Handles btnElseIf.Click
        'Define local variables
        Dim dblScore_1 As Double = 0.0D
        Dim dblScore_2 As Double = 0.0D
        Dim dblScore_3 As Double = 0.0D
        Dim blnIsScore1OK As Boolean
        Dim blnIsScore2OK As Boolean
        Dim blnIsScore3OK As Boolean
        Dim dblAverageScore As Double = 0.0D

        'Assign and validate variables using TryParse, calculate average
        blnIsScore1OK = Double.TryParse(txtScore1.Text, dblScore_1)
        blnIsScore2OK = Double.TryParse(txtScore2.Text, dblScore_2)
        blnIsScore3OK = Double.TryParse(txtScore3.Text, dblScore_3)

        If blnIsScore1OK AndAlso blnIsScore2OK AndAlso blnIsScore3OK Then
            dblAverageScore = (dblScore_1 + dblScore_2 + dblScore_3) / 3
            'Assign Grades using ElseIf
            If dblAverageScore >= 90 Then
                lblGrade.Text = "A"
            ElseIf dblAverageScore >= 80 Then
                lblGrade.Text = "B"
            ElseIf dblAverageScore >= 70 Then
                lblGrade.Text = "C"
            ElseIf dblAverageScore >= 60 Then
                lblGrade.Text = "D"
            ElseIf dblAverageScore < 60 Then
                lblGrade.Text = "F"
            End If
        Else
            MessageBox.Show("You must enter valid numbers for all three scores.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End If
    End Sub
    Private Sub BtnSelectCase_Click(sender As Object, e As EventArgs) Handles BtnSelectCase.Click
        'Define local variables
        Dim dblScore_1 As Double = 0.0
        Dim dblScore_2 As Double = 0.0
        Dim dblScore_3 As Double = 0.0
        Dim blnIsScore1OK As Boolean
        Dim blnIsScore2OK As Boolean
        Dim blnIsScore3OK As Boolean
        Dim dblAverageScore As Double = 0.0

        'Assign and validate variables using TryParse
        blnIsScore1OK = Double.TryParse(txtScore1.Text, dblScore_1)
        blnIsScore2OK = Double.TryParse(txtScore2.Text, dblScore_2)
        blnIsScore3OK = Double.TryParse(txtScore3.Text, dblScore_3)

        'Perform calculation using SelectCase
        If blnIsScore1OK AndAlso blnIsScore2OK AndAlso blnIsScore3OK Then
            dblAverageScore = (dblScore_1 + dblScore_2 + dblScore_3) / 3

            'Assign Grades using SelectCase
            Select Case dblAverageScore
                Case Is >= 90
                    lblGrade.Text = "A"
                Case Is >= 80
                    lblGrade.Text = "B"
                Case Is >= 70
                    lblGrade.Text = "C"
                Case Is >= 60
                    lblGrade.Text = "D"
                Case Is < 60
                    lblGrade.Text = "F"
            End Select
        Else
            MessageBox.Show("You must enter valid numbers for all three scores.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End If
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtScore1_TextChanged(sender As Object, e As EventArgs) Handles txtScore1.TextChanged, txtScore2.TextChanged, txtScore3.TextChanged
        lblGrade.Text = String.Empty
    End Sub

    Private Sub SelectTextWhenEnteringTxtBox(sender As Object, e As EventArgs) Handles txtScore1.Enter, txtScore2.Enter, txtScore3.Enter
        Dim txtBoxSelect As TextBox = CType(sender, TextBox)
        txtBoxSelect.SelectAll()
    End Sub
End Class
