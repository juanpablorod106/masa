Public Class cine
    Private _nombre As String
    Private _id As Integer
    Private _sala As String
    Private _asiento As String
    Private _pelicula As String
    Private _hora As String
    Private _funcion As String
    '"Public" Para acceder a estas variables en cualquier clase.'

    Public Sub New(ByVal nombre As String, ByVal id As Integer, ByVal sala As String, ByVal asiento As String, ByVal pelicula As String, ByVal hora As String, ByVal funcion As String)
        Me._nombre = nombre
        Me._id = id
        Me._sala = sala
        Me._asiento = asiento
        Me._pelicula = pelicula
        Me._hora = hora
        Me._funcion = funcion
        'Ejemplo de Constructor en VB'
    End Sub
    Public Property nombre As String 'Property, Getter and Setter'
        Get
            Return _nombre
        End Get
        Set(value As String)
            Me._nombre = value
        End Set
    End Property

    Public Property id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            Me._id = value
        End Set
    End Property

    Public Property sala As String
        Get
            Return _sala
        End Get
        Set(value As String)
            Me._sala = value
        End Set
    End Property

    Public Property asiento As String
        Get
            Return _asiento
        End Get
        Set(value As String)
            Me._asiento = value
        End Set
    End Property

    Public Property pelicula As String
        Get
            Return _pelicula
        End Get
        Set(value As String)
            Me._pelicula = value
        End Set
    End Property

    Public Property hora As String
        Get
            Return _hora
        End Get
        Set(value As String)
            Me._hora = value
        End Set
    End Property

    Public Property funcion As String
        Get
            Return _funcion
        End Get
        Set(value As String)
            Me._funcion = value
        End Set
    End Property
    'Se usa encapsulacion para evitar la manipulación de código y  alteración de datos por quien no está autorizado.'
End Class
