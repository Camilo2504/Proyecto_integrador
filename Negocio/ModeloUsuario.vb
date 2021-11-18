Imports Persistencia
Imports Transversal

Public Class ModeloUsuario
    'Instancio objeto de persistencia del usuario
    Dim usuarioPO As New UsuarioPO
    'Creo atributos
    Private id_usuario
    Private nombre
    Private apellido
    Private cedula
    Private celular
    Private correo
    Private clave
    Private estado
    Private rol

    'Inicializo los atributos
    Public Sub New(id_usuario As Object, nombre As Object, apellido As Object, cedula As Object, celular As Object, correo As Object, clave As Object, estado As Object, rol As Object)
        Me.id_usuario = id_usuario
        Me.nombre = nombre
        Me.apellido = apellido
        Me.cedula = cedula
        Me.celular = celular
        Me.correo = correo
        Me.clave = clave
        Me.estado = estado
        Me.rol = rol
    End Sub

    'Creo una función de logueo
    Public Function Login(email As String, pass As String) As Boolean
        Return usuarioPO.LogIn(email, pass)
    End Function

    'Función de seguridad
    Public Function Security(id As Integer) As Boolean
        'Primer filtro de seguridad
        If UsuarioActivo.idUsuario >= 1 Then
            'Segundo filtro de seguridad
            If usuarioPO.existsUser(UsuarioActivo.idUsuario) = True Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    'Creo un método para editar usuario
    Public Function EditarUsuario() As String
        Try
            usuarioPO.EditarUsuario(id_usuario, nombre, apellido, cedula, celular, correo, clave, estado, rol)
            Return "Los datos del usuario han sido actualizados satisfactoriamente"
        Catch ex As Exception
            Return "Error: " & ex.Message
        End Try
    End Function

    'Creo un método para buscar por ID usuario
    Public Function BuscarUsuario(idUsuario As Integer, correo As String, cedula As String, nombre As String, apellido As String) As Boolean
        Return usuarioPO.BuscarUsuario(idUsuario, correo, cedula, nombre, apellido)
    End Function

    'Creo un método para crear usuario
    Public Function CrearUsuario() As String
        Try
            usuarioPO.CrearUsuario(nombre, apellido, cedula, celular, correo, clave, estado, rol)
            Return "Se ha creado el usuario satisfactoriamente"
        Catch ex As Exception
            Return "Error: " & ex.Message
        End Try
    End Function

    'Creo un método para inactivar usuario
    Public Function InactivarUsuario() As String
        Try
            usuarioPO.InactivarUsuario(id_usuario)
            Return "Se ha inactivado el usuario satisfactoriamente"
        Catch ex As Exception
            Return "Error: " & ex.Message
        End Try
    End Function

    'Creo una función para listar usuarios
    Public Function ListarUsuarios() As DataSet
        Return usuarioPO.ListarUsuarios()
    End Function
End Class
