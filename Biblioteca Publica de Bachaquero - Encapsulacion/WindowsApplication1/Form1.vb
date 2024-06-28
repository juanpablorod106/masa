Public Class Form1

    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        Dim libroactual As New Libro(" Blood Meridian ", " Cormac McCarthy ", 1985)
        MessageBox.Show("Titulo del libro: " & libroactual.titulo & " Nombre del autor: " & libroactual.autor & " Año de publicacion: " & libroactual.anio)
        libroactual.titulo = tbx_name.Text
        libroactual.autor = tbx_A.Text
        libroactual.anio = CInt(tbx_year.Text)
        MessageBox.Show("Titulo del libro: " & libroactual.titulo & " Nombre del autor: " & libroactual.autor & " Año de publicacion: " & libroactual.anio)
    End Sub
End Class
