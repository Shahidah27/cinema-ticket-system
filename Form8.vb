Public Class Form8
    Public paymentMethod As String = ""
    Public seat As String = ""
    Public qtySeat As Integer = 0
    Public seatPrice As Double = 0.00

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Form6.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        qtySeat = Val(txtQtySeat.Text)
        seat = txtSeat.Text

        If txtQtySeat.Text = "" Then
            MessageBox.Show("Please enter number of seat!")
            txtQtySeat.Focus()
            Exit Sub
        End If

        If txtSeat.Text = "" Then
            MessageBox.Show("Please enter seat number(s)!")
            txtSeat.Focus()
            Exit Sub
        End If

        If radStandard.Checked Then
            seatPrice = 15.0 * qtySeat
        ElseIf radPremium.Checked Then
            seatPrice = 25.0 * qtySeat
        End If

        If radBanking.Checked Then
            If txtBank.Text = "" Then
                MessageBox.Show("Please enter bank name!")
                txtBank.Focus()
                Exit Sub
            End If
            paymentMethod = "Online Banking ( " & txtBank.Text & " )"
        ElseIf radCard.Checked Then
            paymentMethod = "Credit/Debit Card"
            If txtCardNum.Text = "" Then
                MessageBox.Show("Please enter card number!")
                txtCardNum.Focus()
                Exit Sub
            End If
        ElseIf radApplePay.Checked Then
            paymentMethod = "Apple Pay"
        ElseIf radDuitNow.Checked Then
            paymentMethod = "Duit Now QR"
        ElseIf radBoost.Checked Then
            paymentMethod = "Boost Wallet"
        Else
            MessageBox.Show("Please choose payment method!")
            Exit Sub
        End If

        MessageBox.Show("PAYMENT SUCCESS!")

        Me.Hide()
        Form9.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form7.Show()
    End Sub
End Class