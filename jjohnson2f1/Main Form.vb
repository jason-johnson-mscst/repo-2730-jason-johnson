' Name:         Covington Resort Project
' Purpose:      Display the total room charge, tax, 
'               total resort fee, and total due
' Programmer:   Jason R. Johnson on 11/8-9/2015

Option Explicit On
Option Infer Off
Option Strict On

Public Class Main_Form
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'calculate and display total room charge, tax, total resort fee, and total due
        'declare name constants and variables

        Const intMAX_PER_ROOM As Integer = 6
        Const intDAILY_ROOM_CHARGE_QUEEN_STAND As Integer = 284
        Const intDAILY_ROOM_CHARGE_QUEEN_ATRIUM As Integer = 325
        Const intDAILY_ROOM_CHARGE_KING_STAND As Integer = 290
        Const intDAILY_ROOM_CHARGE_KING_ATRIUM As Integer = 350
        Const dblDAILY_PARKING_FEE As Double = 12.75
        Const dblTAX_RATE As Double = 0.1525
        Const intDAILY_RESORT_FEE As Integer = 15
        Const strMSG As String = "You have exceeded the maximum guests per room."
        Dim intRoomsReserved As Integer
        Dim intNights As Integer
        Dim intAdults As Integer
        Dim intChildren As Integer
        Dim intNumGuests As Integer
        Dim dblRoomsRequired As Double
        Dim dblParkingFee As Double
        Dim intDailyRoomChg As Integer
        Dim intTotalRoomChg As Integer
        Dim dblTax As Double
        Dim intTotalResortFee As Integer
        Dim dblTotalDue As Double

        'store input in variables:
        Integer.TryParse(txtRooms.Text, intRoomsReserved)
        Integer.TryParse(txtNights.Text, intNights)
        Integer.TryParse(txtAdults.Text, intAdults)
        Integer.TryParse(txtChildren.Text, intChildren)

        'calculate total number of guests
        intNumGuests = intAdults + intChildren

        'calculate the number of rooms required
        dblRoomsRequired = intNumGuests / intMAX_PER_ROOM

        'determine whether number of reserved
        'rooms is adequate and then either display a 
        'message Or calculate And display the charges
        If intRoomsReserved < dblRoomsRequired Then
            MessageBox.Show(strMSG, "Covington Resort",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        Else
            'calculate charges
            If radQueen.Checked Then
                If radStandard.Checked Then
                    intDailyRoomChg = intDAILY_ROOM_CHARGE_QUEEN_STAND
                Else
                    intDailyRoomChg = intDAILY_ROOM_CHARGE_QUEEN_ATRIUM
                End If
            Else
                If radStandard.Checked Then
                    intDailyRoomChg = intDAILY_ROOM_CHARGE_KING_STAND
                Else
                    intDailyRoomChg = intDAILY_ROOM_CHARGE_KING_ATRIUM
                End If
            End If

            'Alternate code for intDailyRoomChg
            'If radQueen.Checked AndAlso radStandard.Checked Then
            '    intDailyRoomChg = intDAILY_ROOM_CHARGE_QUEEN_STAND
            'ElseIf radQueen.Checked AndAlso radAtrium.Checked Then
            '    intDailyRoomChg = intDAILY_ROOM_CHARGE_QUEEN_ATRIUM
            'ElseIf radKing.Checked AndAlso radStandard.Checked Then
            '    intDailyRoomChg = intDAILY_ROOM_CHARGE_KING_STAND
            'ElseIf radKing.Checked AndAlso radAtrium.Checked Then
            '    intDailyRoomChg = intDAILY_ROOM_CHARGE_KING_ATRIUM
            'End If

            intTotalRoomChg = intRoomsReserved * intNights * intDailyRoomChg
            dblTax = intTotalRoomChg * dblTAX_RATE
            intTotalResortFee = intRoomsReserved * intNights * intDAILY_RESORT_FEE
            If chkParkingFee.Checked Then
                dblParkingFee = intNights * dblDAILY_PARKING_FEE
            End If
            dblTotalDue = intTotalRoomChg + dblTax + intTotalResortFee + dblParkingFee

            'display charges
            lblRoomChg.Text = intTotalRoomChg.ToString("N2")
            lblTax.Text = dblTax.ToString("N2")
            lblResortFee.Text = intTotalResortFee.ToString("N2")
            lblParkingFee.Text = dblParkingFee.ToString("N2")
            lblTotalDue.Text = dblTotalDue.ToString("C2")
        End If

    End Sub

    Private Sub lblResortFee_Click(sender As Object, e As EventArgs) Handles lblResortFee.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub lblTax_Click(sender As Object, e As EventArgs) Handles lblTax.Click

    End Sub

    Private Sub lblRoomChg_Click(sender As Object, e As EventArgs) Handles lblRoomChg.Click

    End Sub

    Private Sub lblTotalDue_Click(sender As Object, e As EventArgs) Handles lblTotalDue.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs) _
        Handles txtRooms.TextChanged, txtNights.TextChanged,
        txtAdults.TextChanged, txtChildren.TextChanged, radQueen.CheckedChanged, radKing.CheckedChanged, radStandard.CheckedChanged, radAtrium.CheckedChanged, chkParkingFee.CheckedChanged
        ' clear calculated amounts

        lblRoomChg.Text = String.Empty
        lblTax.Text = String.Empty
        lblResortFee.Text = String.Empty
        lblParkingFee.Text = String.Empty
        lblTotalDue.Text = String.Empty
    End Sub

    Private Sub txtRooms_KeyPress(sender As Object, e As KeyPressEventArgs
                                  ) Handles txtRooms.KeyPress, txtNights.KeyPress,
                                  txtAdults.KeyPress, txtChildren.KeyPress
        'allows the text box to accept only numbers 
        'and the backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back Then
            'cancel the key
            e.Handled = True
        End If
    End Sub

    Private Sub txtRooms_Enter(sender As Object, e As EventArgs) Handles txtRooms.Enter
        'selects the contents when
        'the text box receives the focus

        txtRooms.SelectAll()
    End Sub

    Private Sub txtNights_Enter(sender As Object, e As EventArgs) Handles txtNights.Enter
        'selects the contents when
        'the text box receives the focus

        txtNights.SelectAll()
    End Sub

    Private Sub txtAdults_Enter(sender As Object, e As EventArgs) Handles txtAdults.Enter
        'selects the contents when
        'the text box receives the focus

        txtAdults.SelectAll()
    End Sub

    Private Sub txtChildren_Enter(sender As Object, e As EventArgs) Handles txtChildren.Enter
        'selects the contents when
        'the text box receives the focus

        txtChildren.SelectAll()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles lblParkingFee.Click

    End Sub
End Class


'Notes: 
'11/11/15 - circling back to project after doing 2d1 and 2e1:
'    UI - 
'       Added 
'           2 Group Boxes: Type(radKing and radQueen, View(radStandard And radAtrium)
'           Parking Check Box(chkParkingFee)
'           Parking Label(lblParkingFee)
'    Code - 
'       Removed Constant: intDAILY_ROOM_CHARGE (now intDailyRoomCharge variable)
'       Added New Constants:
'           intDAILY_ROOM_CHARGE_QUEEN_STAND
'           intDAILY_ROOM_CHARGE_QUEEN_ATRIUM
'           intDAILY_ROOM_CHARGE_KING_STAND
'           intDAILY_ROOM_CHARGE_KING_ATRIUM
'           dblDAILY_PARKING_FEE
'      Updated Calculations with nested if/else for new Bed/View/Parking options.
'      Updated Display with new Parking Fee 
'      Updated Clear label event handlers with new options.
'    
