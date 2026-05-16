Imports System.Data.OleDb
Public Class Form3
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\MOVIE_DATA.accdb")
        conn.Open()

        If radStaff.Checked Then
            Dim cmd1 As New OleDbCommand("Select * From Staff_Login WHERE staffUsername='" & txtUsername.Text & "' and staffPassword='" & txtPassword.Text & "'", conn)

            Dim sUser As String = ""
            Dim sPass As String = ""

            Dim sdr As OleDbDataReader = cmd1.ExecuteReader()

            If (sdr.Read() = True) Then
                sUser = sdr("staffUsername")
                sPass = sdr("staffPassword")
                MessageBox.Show("Login Successfully!")
                Me.Close()
                Form1.Hide()
                Form10.Show()
            Else
                MessageBox.Show("Invalid username or password!")
            End If
        ElseIf radCust.Checked Then
            Dim cmd2 As New OleDbCommand("Select * From Cust_Login WHERE custUsername='" & txtUsername.Text & "' and custPassword='" & txtPassword.Text & "'", conn)

            Dim cUser As String = ""
            Dim cPass As String = ""

            Dim sdr As OleDbDataReader = cmd2.ExecuteReader()

            If (sdr.Read() = True) Then
                cUser = sdr("custUsername")
                cPass = sdr("custPassword")
                MessageBox.Show("Login Successfully!")
                Me.Hide()
                Form1.Hide()
                Form4.Show()
            Else
                MessageBox.Show("Invalid username or password!")
            End If
        End If
    End Sub

End Class