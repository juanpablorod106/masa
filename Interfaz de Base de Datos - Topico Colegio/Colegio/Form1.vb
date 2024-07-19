
Imports System.Data.OleDb
Public Class Form1
    Dim connection_string As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Colegio.mdb"

    Private Sub ColegioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ColegioBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ColegioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ColegioDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ColegioDataSet.Colegio' Puede moverla o quitarla según sea necesario.
        Me.ColegioTableAdapter.Fill(Me.ColegioDataSet.Colegio)


    End Sub

    Private Sub btn_agg_Click(sender As Object, e As EventArgs) Handles btn_agg.Click
        Dim student As New Estudiantes With {
        .nombre = NombreTextBox.Text,
        .Apellido = ApellidoTextBox.Text,
        .Edad = Int(EdadTextBox.Text)
}

        Using connection As New OleDbConnection(connection_string)
            Try
                connection.Open()
                Dim sqlInsert As String = "INSERT INTO Colegio (nombre,apellido, edad) VALUES (@nombre,@apellido,@edad)"
                Using cmd As New OleDbCommand(sqlInsert, connection)

                    cmd.Parameters.AddWithValue("@Nombre", student.nombre)
                    cmd.Parameters.AddWithValue("@Apellido", student.Apellido)
                    cmd.Parameters.AddWithValue("@Edad", student.Edad)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Se inserto el registro")
                        NombreTextBox.Clear()
                        ApellidoTextBox.Clear()
                        EdadTextBox.Clear()
                        Me.ColegioTableAdapter.Fill(Me.ColegioDataSet.Colegio)
                    Else
                        MessageBox.Show("No tio")
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error" & ex.Message)

            End Try
        End Using
    End Sub

End Class
