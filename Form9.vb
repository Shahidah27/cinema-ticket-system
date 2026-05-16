Public Class Form9

    Dim totalPrice As Double = 0.00
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        lstReceipt.Items.Clear()

        totalPrice = Form8.seatPrice + Form7.totalAll

        If txtName.Text = "" Then
            MessageBox.Show("Please enter name!")
            txtName.Focus()
            Exit Sub
        End If

        If txtPhoneNum.Text = "" Then
            MessageBox.Show("Please enter phone number!")
            txtPhoneNum.Focus()
            Exit Sub
        End If

        lstReceipt.Items.Add("================================================================================")
        lstReceipt.Items.Add("RECEIPT")
        lstReceipt.Items.Add("================================================================================")
        lstReceipt.Items.Add("")
        lstReceipt.Items.Add("Name: " & txtName.Text)
        lstReceipt.Items.Add("Phone Number: " & txtPhoneNum.Text)
        lstReceipt.Items.Add("Movie: " & Form5.movieBook)
        lstReceipt.Items.Add("Number of Seat: " & Form8.qtySeat)
        lstReceipt.Items.Add("Seat Number(s): " & Form8.seat)

        If Form7.receiptItems.Count > 0 Then
            lstReceipt.Items.Add("-------------------------Food & Beverage-------------------------")

            For Each line As String In Form7.receiptItems
                lstReceipt.Items.Add(line)
            Next
        End If

        lstReceipt.Items.Add("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~")
        lstReceipt.Items.Add("Food Price: RM" & Form7.totalAll.ToString("N2"))
        lstReceipt.Items.Add("Ticket Price: RM" & Form8.seatPrice.ToString("N2"))
        lstReceipt.Items.Add("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~")
        lstReceipt.Items.Add("Total Price: RM" & totalPrice.ToString("N2"))
        lstReceipt.Items.Add("Payment Method: " & Form8.paymentMethod)
        lstReceipt.Items.Add("================================================================================")
    End Sub

    Private Sub pdPrint_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pdPrint.PrintPage
        e.Graphics.DrawString("SEGAR AMAT CINEMA", New Font("Times New Roman", 20, FontStyle.Bold), Brushes.Black, 240, 80)

        Dim startY1 As Integer = 120
        Dim startY As Integer = 180

        e.Graphics.DrawString("============================================================", New Font("Times New Roman", 12), Brushes.Black, 100, startY1)
        startY1 += 20

        e.Graphics.DrawString("RECEIPT", New Font("Times New Roman", 12, FontStyle.Bold), Brushes.Black, 340, startY1)
        startY1 += 20

        e.Graphics.DrawString("============================================================", New Font("Times New Roman", 12), Brushes.Black, 100, startY1)
        startY += 20

        e.Graphics.DrawString("Name: " & txtName.Text, New Font("Times New Roman", 12), Brushes.Black, 100, startY)
        startY += 20

        e.Graphics.DrawString("Phone Number: " & txtPhoneNum.Text, New Font("Times New Roman", 12), Brushes.Black, 100, startY)
        startY += 20

        e.Graphics.DrawString("Movie: " & Form5.movieBook, New Font("Times New Roman", 12), Brushes.Black, 100, startY)
        startY += 20

        e.Graphics.DrawString("Number of Seat: " & Form8.qtySeat, New Font("Times New Roman", 12), Brushes.Black, 100, startY)
        startY += 20

        e.Graphics.DrawString("Seat Number(s): " & Form8.seat, New Font("Times New Roman", 12), Brushes.Black, 100, startY)
        startY += 30

        If Form7.receiptItems.Count > 0 Then
            e.Graphics.DrawString("-------------------------Food & Beverage-------------------------", New Font("Times New Roman", 12, FontStyle.Italic), Brushes.Black, 100, startY)
            startY += 20


            For Each line As String In Form7.receiptItems
                e.Graphics.DrawString(line, New Font("Times New Roman", 12), Brushes.Black, 100, startY)
                startY += 20
            Next
        End If

        startY += 30

        e.Graphics.DrawString("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~", New Font("Times New Roman", 12), Brushes.Black, 100, startY)
        startY += 20

        e.Graphics.DrawString("Food Price: RM" & Form7.totalAll.ToString("N2"), New Font("Times New Roman", 12), Brushes.Black, 100, startY)
        startY += 20

        e.Graphics.DrawString("Ticket Price: RM" & Form8.seatPrice.ToString("N2"), New Font("Times New Roman", 12), Brushes.Black, 100, startY)
        startY += 20

        e.Graphics.DrawString("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~", New Font("Times New Roman", 12), Brushes.Black, 100, startY)
        startY += 20

        e.Graphics.DrawString("Total Price: RM" & totalPrice.ToString("N2"), New Font("Times New Roman", 12, FontStyle.Bold), Brushes.Black, 100, startY)
        startY += 20

        e.Graphics.DrawString("Payment Method: " & Form8.paymentMethod, New Font("Times New Roman", 12), Brushes.Black, 100, startY)
        startY += 20

        e.Graphics.DrawString("============================================================", New Font("Times New Roman", 12), Brushes.Black, 100, startY)
        startY += 20
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        pdPrint.Print()
    End Sub

    Private Sub btnPrintPreview_Click(sender As Object, e As EventArgs) Handles btnPrintPreview.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        MessageBox.Show("Thank you for using our system~~")
        End
    End Sub
End Class