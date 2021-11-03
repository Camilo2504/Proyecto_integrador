Imports MySql.Data.MySqlClient
Public MustInherit Class Conexion

    'Declaro la cadena de conexión
    Private connectionString As String

    'Creo el constructor
    Protected Sub New()
        connectionString = "server=localhost;user id=root;password=C5greenday;persistsecurityinfo=True;database=taller_visual"
    End Sub

    'Creo un método para obtener la conexión
    Protected Function getConnection() As MySqlConnection
        Return New MySqlConnection(connectionString)
    End Function
End Class
