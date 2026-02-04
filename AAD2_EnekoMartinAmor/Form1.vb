Imports System.Net
Imports MySql.Data.MySqlClient

Public Class Form1
    Dim cadenaCon As String = "server=localhost;userid=root;password=;database=cine"
    Dim conexion As MySqlConnection
    Dim peliculas(4) As Pelicula
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarFechaHora()
        Timer1.Start()
        Try
            conexion = New MySqlConnection(cadenaCon)
            conexion.Open()
            MessageBox.Show("¡Conexión exitosa a la base de datos!")
        Catch ex As MySqlException
            MessageBox.Show("Error al conectar: " & ex.Message)
            Application.Exit()
            Return
        Finally
            conexion.Close()
        End Try
        CargarDatos()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ActualizarFechaHora()
    End Sub

    Private Sub ActualizarFechaHora()
        lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        lblHora.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Creditos.Show()
        Me.Hide()
    End Sub

    Private Sub CargarDatos()
        Try
            conexion.Open()
            Dim query As String = "SELECT * FROM pelicula"
            Dim cmd As New MySqlCommand(query, conexion)
            Dim rd As MySqlDataReader = cmd.ExecuteReader()

            Dim imagenes() As PictureBox = {imgPeli1, imgPeli2, imgPeli3, imgPeli4, imgPeli5}
            Dim labels() As Label = {lblPel1, lblPel2, lblPeli3, lblPeli4, lblPeli5}

            Dim i As Integer = 0
            While rd.Read() And i < 5
                peliculas(i) = New Pelicula()
                peliculas(i).Titulo = rd("titulo").ToString()
                peliculas(i).Anio = rd("anio_estreno").ToString()
                peliculas(i).Duracion = rd("duracion").ToString()
                peliculas(i).Sinopsis = rd("sinopsis").ToString()
                peliculas(i).UrlImagen = rd("url_imagen").ToString()
                peliculas(i).AsientosDisponibles = CInt(rd("entradas_disponibles"))
                peliculas(i).Precio = rd("precio")

                labels(i).Text = peliculas(i).Titulo
                Try
                    Dim webClient As New WebClient()
                    Dim stream As IO.Stream = webClient.OpenRead(peliculas(i).UrlImagen)
                    imagenes(i).Image = Image.FromStream(stream)
                    stream.Close()
                Catch ex As Exception
                    imagenes(i).Image = Nothing
                End Try

                i += 1
            End While
            rd.Close()
        Catch ex As MySqlException
            MessageBox.Show("Error al leer datos: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub
    Private Sub imgPeli1_Click(sender As Object, e As EventArgs) Handles imgPeli1.Click
        Dim detalles As New InfoPeli(peliculas(0), conexion)
        detalles.Show()
        Me.Hide()
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles imgPeli2.Click
        Dim detalles As New InfoPeli(peliculas(1), conexion)
        detalles.Show()
        Me.Hide()
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles imgPeli3.Click
        Dim detalles As New InfoPeli(peliculas(2), conexion)
        detalles.Show()
        Me.Hide()
    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles imgPeli4.Click
        Dim detalles As New InfoPeli(peliculas(3), conexion)
        detalles.Show()
        Me.Hide()
    End Sub

    Private Sub imgPeli5_Click(sender As Object, e As EventArgs) Handles imgPeli5.Click
        Dim detalles As New InfoPeli(peliculas(4), conexion)
        detalles.Show()
        Me.Hide()
    End Sub
End Class
