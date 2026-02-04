Imports System.Net
Imports MySql.Data.MySqlClient
Public Class InfoPeli
    Dim peliSeleccionada As Pelicula
    Dim conexion As MySqlConnection

    ' El constructor ahora recibe el objeto Pelicula
    Public Sub New(peli As Pelicula, con As MySqlConnection)
        InitializeComponent()
        peliSeleccionada = peli
        conexion = con
    End Sub
    Private Sub InfoPeli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPelicula.Text = $"{peliSeleccionada.Titulo} ({peliSeleccionada.Anio})"
        lblDuracion.Text = peliSeleccionada.Duracion
        lblSipnosis.Text = "Sinopsis: " & peliSeleccionada.Sinopsis
        lblPrec.Text = peliSeleccionada.Precio & " €"
        Try
            Dim webClient As New WebClient()
            Dim stream As IO.Stream = webClient.OpenRead(peliSeleccionada.UrlImagen)
            PictureBox1.Image = Image.FromStream(stream)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            stream.Close()
        Catch ex As Exception
            PictureBox1.Image = Nothing
        End Try
    End Sub

    Private Sub btVolver_Click(sender As Object, e As EventArgs) Handles btVolver.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btVender_Click(sender As Object, e As EventArgs) Handles btVender.Click
        Dim venta As New VentaEntrada(peliSeleccionada, conexion)
        venta.Show()
        Me.Close()
    End Sub
End Class