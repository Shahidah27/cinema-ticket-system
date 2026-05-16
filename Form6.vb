Imports System.Data.OleDb
Public Class Form6
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\MOVIE_DATA.accdb")
    Dim seats(27) As String
    Dim seatButton(27) As Button
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        seatButton(0) = btnSeat1
        seatButton(1) = btnSeat2
        seatButton(2) = btnSeat3
        seatButton(3) = btnSeat4
        seatButton(4) = btnSeat5
        seatButton(5) = btnSeat6
        seatButton(6) = btnSeat7
        seatButton(7) = btnSeat8
        seatButton(8) = btnSeat9
        seatButton(9) = btnSeat10
        seatButton(10) = btnSeat11
        seatButton(11) = btnSeat12
        seatButton(12) = btnSeat13
        seatButton(13) = btnSeat14
        seatButton(14) = btnSeat15
        seatButton(15) = btnSeat16
        seatButton(16) = btnSeat17
        seatButton(17) = btnSeat18
        seatButton(18) = btnSeat19
        seatButton(19) = btnSeat20
        seatButton(20) = btnSeat21
        seatButton(21) = btnSeat22
        seatButton(22) = btnSeat23
        seatButton(23) = btnSeat24
        seatButton(24) = btnSeat25
        seatButton(25) = btnSeat26
        seatButton(26) = btnSeat27
        seatButton(27) = btnSeat28

        LoadSeats()
        DisplaySeats()
    End Sub

    Private Sub LoadSeats()
        conn.Open()
        Dim cmd As New OleDbCommand("Select * From Seat ORDER BY seatID", conn)
        Dim myreader As OleDbDataReader = cmd.ExecuteReader()

        Dim i As Integer = 0
        While myreader.Read()
            seats(i) = myreader("seatAvailability").ToString()
            i += 1
        End While
    End Sub

    Private Sub DisplaySeats()
        For i As Integer = 0 To seatButton.Length - 1
            If seats(i) = "Not Available" Then
                seatButton(i).BackColor = Color.Red
                seatButton(i).Enabled = False
            ElseIf seats(i) = "Available" Then
                seatButton(i).BackColor = Color.LimeGreen
                seatButton(i).Enabled = True
            End If
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.Hide()
        Form8.Show()
    End Sub

End Class