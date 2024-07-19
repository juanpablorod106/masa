Public Class Estudiantes
    Public Property nombre As String
    Public Property Apellido As String
    Public Property Edad As Integer

    Public Function validate() As List(Of String)
        Dim errors As New List(Of String)
        If String.IsNullOrWhiteSpace(nombre) Then
            errors.Add("ingrese el primer nombre")
        End If
        If String.IsNullOrWhiteSpace(Apellido) Then
            errors.Add("Ingrese el apellido")
        End If
        If Edad <= 0 And Edad >= 19 Then
            errors.Add("Ingrese una edad valida")
        End If
        Return errors
    End Function
End Class
