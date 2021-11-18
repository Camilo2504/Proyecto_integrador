Imports MySql.Data.MySqlClient
Imports Transversal
Public Class UsuarioPO
    'Hereda de la clase conexion
    Inherits Conexion

    'Creo una función para el inicio de sesión
    Public Function LogIn(email As String, pass As String) As Boolean
        Using connection = getConnection()
            'Abro conexión
            connection.Open()
            email.ToLower()
            'Realizo la consulta
            Using command = New MySqlCommand()
                command.Connection = connection
                command.CommandText = "SELECT id_usuario, nombre_usuario, apellido_usuario, correo, estado, rol_usuario 
                                        FROM usuario join rol r on r.id_rol = usuario.id_rol 
                                        WHERE correo = @email and clave = @pass"
                command.Parameters.AddWithValue("@email", email)
                command.Parameters.AddWithValue("@pass", pass)
                command.CommandType = CommandType.Text
                Dim reader = command.ExecuteReader()
                'Verifico si retorna resultado
                If reader.HasRows Then
                    'Recojo la info y la guardo en cache
                    While reader.Read()
                        UsuarioActivo.idUsuario = reader.GetString("id_usuario")
                        UsuarioActivo.nombre = reader.GetString("nombre_usuario")
                        UsuarioActivo.apellido = reader.GetString("apellido_usuario")
                        UsuarioActivo.correo = reader.GetString("correo")
                        UsuarioActivo.estado = reader.GetString("estado")
                        UsuarioActivo.rol = reader.GetString("rol_usuario")
                    End While
                    reader.Dispose()
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function

    'Creo una función para verificar usuario (seguridad)
    Public Function existsUser(id As Integer) As Boolean
        Using connection = getConnection()
            'Abro conexión
            connection.Open()
            'Realizo la consulta
            Using command = New MySqlCommand()
                command.Connection = connection
                command.CommandText = "SELECT * FROM usuario WHERE id_usuario = @id"
                command.Parameters.AddWithValue("@id", id)
                command.CommandType = CommandType.Text
                Dim reader = command.ExecuteReader()
                'Verifico si retorna resultado
                If reader.HasRows Then
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function

    'Creo una método para la validación de permisos de usuario
    Public Sub ValidUser()
        If UsuarioActivo.rol = Roles.administrador Then

        End If
        If UsuarioActivo.rol = Roles.aprobador Then

        End If
    End Sub

    'Creo un método para editar usuario
    Public Sub EditarUsuario(id, nombre, apellido, cedula, celular, correo, clave, estado, rol)
        Using connection = getConnection()
            'Abro conexión
            connection.Open()
            'Realizo el script
            Using command = New MySqlCommand()
                command.Connection = connection
                command.CommandText = "UPDATE usuario SET 
                                        nombre_usuario = @nombre, apellido_usuario = @apellido, cedula_usuario = @cedula, 
                                        celular = @celular, correo = @correo, clave = @clave, estado = @estado, id_rol = @rol 
                                       WHERE id_usuario = @id"
                command.Parameters.AddWithValue("@nombre", nombre)
                command.Parameters.AddWithValue("@apellido", apellido)
                command.Parameters.AddWithValue("@cedula", cedula)
                command.Parameters.AddWithValue("@celular", celular)
                command.Parameters.AddWithValue("@correo", correo)
                command.Parameters.AddWithValue("@clave", clave)
                command.Parameters.AddWithValue("@estado", estado)
                command.Parameters.AddWithValue("@rol", rol)
                command.Parameters.AddWithValue("@id", id)
                command.CommandType = CommandType.Text
                Dim reader = command.ExecuteReader()
            End Using
        End Using
    End Sub

    'Creo una función para buscar usuario
    Public Function BuscarUsuario(idUsuario As Integer, correo As String, cedula As String, nombre As String, apellido As String) As Boolean
        Using connection = getConnection()
            'Abro conexión
            connection.Open()
            'Realizo la consulta
            Using command = New MySqlCommand()
                command.Connection = connection
                'Si es búsqueda por id_usuario
                If idUsuario <> Nothing Then
                    command.CommandText = "SELECT id_usuario, nombre_usuario, apellido_usuario, cedula_usuario , 
                                        celular, correo, clave, estado, rol_usuario 
                                        FROM usuario join rol r on r.id_rol = usuario.id_rol 
                                        WHERE id_usuario = @idUsuario"
                    command.Parameters.AddWithValue("@idUsuario", idUsuario)
                    'Si es búsqueda por correo
                ElseIf correo <> Nothing Then
                    command.CommandText = "SELECT id_usuario, nombre_usuario, apellido_usuario, cedula_usuario , 
                                        celular, correo, clave, estado, rol_usuario 
                                        FROM usuario join rol r on r.id_rol = usuario.id_rol 
                                        WHERE correo = @correo"
                    command.Parameters.AddWithValue("@correo", correo)
                    'Si es búsqueda por cédula
                ElseIf cedula <> Nothing Then
                    command.CommandText = "SELECT id_usuario, nombre_usuario, apellido_usuario, cedula_usuario , 
                                        celular, correo, clave, estado, rol_usuario 
                                        FROM usuario join rol r on r.id_rol = usuario.id_rol 
                                        WHERE cedula_usuario = @cedula"
                    command.Parameters.AddWithValue("@cedula", cedula)
                    'Si es búsqueda por nombres y/o apellidos
                ElseIf nombre <> Nothing Or apellido <> Nothing Then
                    command.CommandText = "SELECT id_usuario, nombre_usuario, apellido_usuario, cedula_usuario , 
                                        celular, correo, clave, estado, rol_usuario 
                                        FROM usuario join rol r on r.id_rol = usuario.id_rol 
                                        WHERE nombre_usuario like @nombre and apellido_usuario like @apellido"
                    command.Parameters.AddWithValue("@nombre", "%" + nombre + "%")
                    command.Parameters.AddWithValue("@apellido", "%" + apellido + "%")
                End If

                command.CommandType = CommandType.Text
                Dim reader = command.ExecuteReader()
                'Verifico si retorna resultado
                If reader.HasRows Then
                    'Recojo la info y la guardo en cache
                    While reader.Read()
                        UsuarioBuscado.idUsuario = reader.GetString("id_usuario")
                        UsuarioBuscado.nombre = reader.GetString("nombre_usuario")
                        UsuarioBuscado.apellido = reader.GetString("apellido_usuario")
                        UsuarioBuscado.cedula = reader.GetString("cedula_usuario")
                        UsuarioBuscado.celular = reader.GetString("celular")
                        UsuarioBuscado.correo = reader.GetString("correo")
                        UsuarioBuscado.contraseña = reader.GetString("clave")
                        UsuarioBuscado.estado = reader.GetString("estado")
                        UsuarioBuscado.rol = reader.GetString("rol_usuario")
                    End While
                    reader.Dispose()
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function

    'Creo un método para crear usuario
    Public Sub CrearUsuario(nombre, apellido, cedula, celular, correo, clave, estado, rol)
        Using connection = getConnection()
            'Abro conexión
            connection.Open()
            'Realizo el script
            Using command = New MySqlCommand()
                command.Connection = connection
                command.CommandText = "INSERT INTO usuario 
                                        (nombre_usuario, apellido_usuario, cedula_usuario, celular, correo, clave, estado, id_rol) 
                                        VALUES (@nombre, @apellido, @cedula, @celular, @correo, @clave, @estado, @rol)"
                command.Parameters.AddWithValue("@nombre", nombre)
                command.Parameters.AddWithValue("@apellido", apellido)
                command.Parameters.AddWithValue("@cedula", cedula)
                command.Parameters.AddWithValue("@celular", celular)
                command.Parameters.AddWithValue("@correo", correo)
                command.Parameters.AddWithValue("@clave", clave)
                command.Parameters.AddWithValue("@estado", estado)
                command.Parameters.AddWithValue("@rol", rol)
                command.CommandType = CommandType.Text
                Dim reader = command.ExecuteReader()
            End Using
        End Using
    End Sub

    'Creo un método para inactivar usuario
    Public Sub InactivarUsuario(id)
        Using connection = getConnection()
            'Abro conexión
            connection.Open()
            'Realizo el script
            Using command = New MySqlCommand()
                command.Connection = connection
                command.CommandText = "UPDATE usuario SET estado = 'INACTIVO' WHERE id_usuario = @id"
                command.Parameters.AddWithValue("@id", id)
                command.CommandType = CommandType.Text
                Dim reader = command.ExecuteReader()
            End Using
        End Using
    End Sub

    'Creo una función para listar todos los usuarios
    Public Function ListarUsuarios() As DataSet
        Dim consulta As String
        Dim leer As MySqlDataAdapter
        Dim info As DataSet
        Using connection = getConnection()
            'Abro conexión
            connection.Open()
            consulta = "SELECT id_usuario, nombre_usuario, apellido_usuario, cedula_usuario, celular, correo, clave, estado, rol_usuario FROM usuario INNER JOIN rol r ON usuario.id_rol = r.id_rol"
            leer = New MySqlDataAdapter(consulta, connection)
            info = New DataSet
            leer.Fill(info)
            Return info
        End Using
    End Function
End Class
