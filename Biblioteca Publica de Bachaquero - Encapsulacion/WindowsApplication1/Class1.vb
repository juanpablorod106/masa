Public Class Libro
    Private _titulo As String
    Private _autor As String
    Private _anio_publicacion As Integer
    '"Public" Para acceder a esta variable en cualquier clase.'

    Public Sub New(ByVal titulo As String, ByVal autor As String, ByVal anio As Integer)
        Me._titulo = titulo
        Me._autor = autor
        Me._anio_publicacion = anio 'Ejemplo de Constructor en VB'

    End Sub
    Public Property titulo As String 'Property, Getter and Setter'
        Get
            Return _titulo
        End Get
        Set(value As String)
            Me._titulo = value
        End Set
    End Property

    Public Property autor As String
        Get
            Return _autor
        End Get
        Set(value As String)
            Me._autor = value
        End Set
    End Property

    Public Property anio As Integer
        Get
            Return _anio_publicacion
        End Get
        Set(value As Integer)
            Me._anio_publicacion = value
        End Set
    End Property
End Class
