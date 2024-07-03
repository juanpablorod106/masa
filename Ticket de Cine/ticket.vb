'                                                             Juan Rodríguez - 31.021.385
'                                                                   Algoritmos y Programación III
Imports System.IO
'es una instrucción que se usa en Visual Basic .NET para importar las clases
'y los miembros definidos en el espacio de nombres System.IO.
'Proposito: Acceso a clases de archivo y E/S.

Public Class Form1

    Private Sub btn_ticket_Click(sender As Object, e As EventArgs) Handles btn_ticket.Click
        Dim ticket As New Cine("Juan Rodriguez", 31021385, "A", "F5", "Niku Daruma", "15:00", "15/03/2005")
        ticket.nombre = tbx_name.Text
        ticket.id = tbx_id.Text
        ticket.sala = tbx_stage.Text
        ticket.asiento = tbx_site.Text
        ticket.pelicula = tbx_movie.Text
        ticket.hora = tbx_hour.Text
        ticket.funcion = tbx_fecha.Text
        MessageBox.Show("************* Boleto de Cine *************" & vbCr & "Cliente: " & ticket.nombre & vbCr & "  ID: " & ticket.id & vbCr & "  Sala: " & ticket.sala & vbCr & "  Asiento: " & ticket.asiento & vbCr & "  Pelicula: " & ticket.pelicula & vbCr & "  Hora de la funcion: " & ticket.hora & vbCr & "  Fecha de la funcion: " & ticket.funcion & vbCr)

        ' "vbCr" representa un carácter de retorno de carro,
        ' lo que significa que se utiliza para mover el cursor al principio de la otra línea.
        'vbCr': Caracter del salto de linea.

        Dim archivo As New cine(tbx_name.Text, tbx_id.Text, tbx_stage.Text, tbx_site.Text,
                               tbx_movie.Text, tbx_hour.Text, tbx_fecha.Text)

        ' Construccion del string del ticket. Esto se hizo con apoyo aparte a las clases, por lo tanto encontrarle
        ' facilidad se me hizo imposible por el tiempo.

        Dim ticketText As String = String.Format(
            "************* Boleto de Cine *************" & vbCr &
            "Nombre: " & ticket.nombre & vbCr &
            "ID: " & ticket.id & vbCr &
            "Sala: " & ticket.sala & vbCr &
            "Asiento: " & ticket.asiento & vbCr &
            "Película: " & ticket.pelicula & vbCr &
            "Hora: " & ticket.hora & vbCr &
            "Función: " & ticket.funcion & vbCr &
            "**************************************",
            ticket.nombre, ticket.id, ticket.sala, ticket.asiento, ticket.pelicula, ticket.hora, ticket.funcion)

        ' Escribir el ticket en formato txt.
        'La variable filePath se construye mediante el método Path.Combine que como metodo
        'tiene la tarea de combinar varios segmentos de rutas de acceso. (Como por ejemplo Directorios y Nombres de un archivo).

        Dim filePath As String = Path.Combine(My.Computer.FileSystem.CurrentDirectory, "ticket.txt")

        'Se utiliza para escribir el contenido de una cadena,
        '(en este caso, ticketText) en una ruta de acceso de archivo especificada.

        File.WriteAllText(filePath, ticketText)

    End Sub
End Class
