Imports MySql.Data.MySqlClient
Imports Transversal
Public Class LegalizacionPO
    'Hereda de la clase conexion
    Inherits Conexion

    'Creo una función para listar las legalizaciones pendientes
    Public Function ListarLegalizaciones(listar As String) As DataSet
        Dim consulta As String
        Dim leer As MySqlDataAdapter
        Dim info As DataSet
        Using connection = getConnection()
            'Abro conexión
            connection.Open()
            consulta = "SELECT * FROM legalizacion WHERE estado = '" + listar + "'"
            leer = New MySqlDataAdapter(consulta, connection)
            info = New DataSet
            leer.Fill(info)
            Return info
        End Using
    End Function

    'Creo un método para gestionar las legalizaciones
    Public Sub GestionLegalizacion(id, estado)
        Using connection = getConnection()
            'Abro conexión
            connection.Open()
            'Realizo el script
            Using command = New MySqlCommand()
                command.Connection = connection
                command.CommandText = "UPDATE legalizacion SET estado = @estado WHERE id_legalizacion = @id"
                command.Parameters.AddWithValue("@estado", estado)
                command.Parameters.AddWithValue("@id", id)
                command.CommandType = CommandType.Text
                Dim reader = command.ExecuteReader()
            End Using
        End Using
    End Sub
End Class
