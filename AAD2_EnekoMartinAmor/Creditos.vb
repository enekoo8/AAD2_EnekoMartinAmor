Imports System.Net.Http
Imports System.Text.Json

Public Class Creditos
    Private perfilUrl As String
    Private Sub btVolver_Click(sender As Object, e As EventArgs) Handles btVolver.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Async Sub Creditos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim usuario As String = "enekoo8"
            Dim url As String = $"https://api.github.com/users/{usuario}"

            Using client As New HttpClient()
                client.DefaultRequestHeaders.UserAgent.ParseAdd("VBWinFormsApp")

                Dim json As String = Await client.GetStringAsync(url)
                Dim user As GithubUser =
                JsonSerializer.Deserialize(Of GithubUser)(json)

                lblUsuNom.Text = user.login
                lblCantRepos.Text = user.public_repos
                PictureBox1.Load(user.avatar_url)
                perfilUrl = user.html_url
            End Using
        Catch ex As Exception
            MessageBox.Show("No se pudo cargar la información de GitHub")
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Process.Start(New ProcessStartInfo With {
           .FileName = perfilUrl,
           .UseShellExecute = True
        })
    End Sub
End Class