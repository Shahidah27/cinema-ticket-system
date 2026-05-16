Public Class Form1
    Private Sub btnBookNow_Click(sender As Object, e As EventArgs) Handles btnBookNow.Click
        Form3.Show()
    End Sub

    Private Sub lblAboutUs_Click_1(sender As Object, e As EventArgs) Handles lblAboutUs.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class
