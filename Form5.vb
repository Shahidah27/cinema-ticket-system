Imports System.Data.OleDb
Public Class Form5
    Public movieBook As String = ""

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MOVIE_DATADataSet.Movie' table. You can move, or remove it, as needed.
        'Me.MovieTableAdapter.Fill(Me.MOVIE_DATADataSet.Movie)

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\MOVIE_DATA.accdb")
        conn.Open()

        Dim cmd As New OleDbCommand("Select * From Movie WHERE movieTitle=?", conn)
        cmd.Parameters.AddWithValue("?", txtSearch.Text)
        Dim myreader As OleDbDataReader = cmd.ExecuteReader()

        If myreader.Read() Then
            txtMovieID.Text = myreader("movieID").ToString
            txtMovieTitle.Text = myreader("movieTitle").ToString
            txtMovieGenre.Text = myreader("movieGenre").ToString
            txtMovieDuration.Text = myreader("movieDuration").ToString
            txtMovieShowDate.Text = myreader("movieShowDate").ToString
            txtMovieShowTime.Text = myreader("movieShowTime").ToString
            txtMovieDesc.Text = myreader("movieDesc").ToString
        Else
            txtMovieID.Text = ""
            txtMovieTitle.Text = ""
            txtMovieGenre.Text = ""
            txtMovieDuration.Text = ""
            txtMovieShowDate.Text = ""
            txtMovieShowTime.Text = ""
            txtMovieDesc.Text = ""
            MessageBox.Show("No Data Found!!")
        End If
        conn.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If movieBook = "" Then
            MessageBox.Show("Please choose movie to book!")
            Exit Sub
        End If
        Me.Hide()
        Form6.Show()
    End Sub

    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        If movieBook = "" And txtMovieID.Text = "" Then
            MessageBox.Show("Please choose movie to book!")
            Exit Sub
        End If

        movieBook = txtSearch.Text
        MessageBox.Show(txtSearch.Text & " is book!")
        btnBook.Enabled = False
    End Sub
End Class