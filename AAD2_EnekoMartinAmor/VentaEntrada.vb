Imports System.IO
Imports MySql.Data.MySqlClient

Public Class VentaEntrada
    Private conexion As MySqlConnection
    Private peliSelec As Pelicula
    Dim cantidad As Integer
    Public Sub New(peli As Pelicula, con As MySqlConnection)
        InitializeComponent()
        peliSelec = peli
        conexion = con
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cantidad = cantEntradas.Value
        If cantidad = 0 Or cantidad > 10 Then
            MessageBox.Show("Introduzca una cantidad valida... Minimo 1, Maximo 10")
            Return
        End If

        If cantidad > peliSelec.AsientosDisponibles Then
            MessageBox.Show($"Cantidad no disponible, solo quedan {peliSelec.AsientosDisponibles} entradas.")
            Return
        End If

        Try
            conexion.Open()
            Dim sql As String = "UPDATE pelicula SET entradas_disponibles = entradas_disponibles - @cant WHERE titulo = @tit"
            Dim cmd As New MySqlCommand(sql, conexion)
            cmd.Parameters.AddWithValue("@cant", cantidad)
            cmd.Parameters.AddWithValue("@tit", peliSelec.Titulo)
            cmd.ExecuteNonQuery()

            MessageBox.Show("¡Venta realizada con éxito!")
            escribirFichero(peliSelec, cantidad)
            Form1.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error en la transacción: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub
    Private Sub escribirFichero(peliSelec, cantidad)
        Dim linea As String = $"{DateTime.Now:dd/MM/yyyy HH:mm} | {peliSelec.Titulo} ({peliSelec.Anio}) | Duración: {peliSelec.Duracion}" & vbCrLf &
                     $"Entradas: {cantidad} | Precio Entrada: {peliSelec.Precio}€ | Total: {peliSelec.Precio * cantidad}€"
        Try
            Dim streamWriter As New StreamWriter("../../../ventasCine.txt", True)
            streamWriter.WriteLine(linea)
            streamWriter.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class