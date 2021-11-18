Imports Negocio
Imports Transversal
Public Class Usuario_editar
    'Creo variables
    Dim placeholder As String
    'Elección de busqueda de usuario
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxBuscar.SelectedIndexChanged
        btnBuscar.Visible = True
        'Búsqueda por ID usuario
        If cboxBuscar.SelectedIndex = 0 Then
            txtBuscarNombre.Visible = False
            txtBuscarApellido.Visible = False
            txtParametro.Visible = True
            placeholder = "ID del usuario"
            If txtParametro.Text = Nothing Then
                txtParametro.ForeColor = Color.Gray
                txtParametro.Text = placeholder
            End If
        End If
        'Búsqueda por correo
        If cboxBuscar.SelectedIndex = 1 Then
            txtBuscarNombre.Visible = False
            txtBuscarApellido.Visible = False
            txtParametro.Visible = True
            placeholder = "Dirección de correo"
            If txtParametro.Text = Nothing Then
                txtParametro.ForeColor = Color.Gray
                txtParametro.Text = placeholder
            End If
        End If
        'Búsqueda por cédula
        If cboxBuscar.SelectedIndex = 2 Then
            txtBuscarNombre.Visible = False
            txtBuscarApellido.Visible = False
            txtParametro.Visible = True
            placeholder = "Número de cédula"
            If txtParametro.Text = Nothing Then
                txtParametro.ForeColor = Color.Gray
                txtParametro.Text = placeholder
            End If
        End If
        'Búsqueda por nombres y/o apellidos
        If cboxBuscar.SelectedIndex = 3 Then
            txtParametro.Visible = False
            txtBuscarNombre.Visible = True
            txtBuscarApellido.Visible = True
        End If
    End Sub

    'Placeholder de los textbox de búsqueda
    Private Sub Editar_usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If txtBuscarNombre.Text = Nothing Then
            txtBuscarNombre.ForeColor = Color.Gray
            txtBuscarNombre.Text = "Nombre"
        End If
        If txtBuscarApellido.Text = Nothing Then
            txtBuscarApellido.ForeColor = Color.Gray
            txtBuscarApellido.Text = "Apellido"
        End If
    End Sub

    'Hacer desaparecer el placeholder
    Private Sub txtBuscarNombre_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscarNombre.GotFocus
        If txtBuscarNombre.Text = "Nombre" Then
            txtBuscarNombre.ForeColor = Color.Black
            txtBuscarNombre.Text = ""
        End If
    End Sub
    Private Sub txtBuscarApellido_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscarApellido.GotFocus
        If txtBuscarApellido.Text = "Apellido" Then
            txtBuscarApellido.ForeColor = Color.Black
            txtBuscarApellido.Text = ""
        End If
    End Sub
    Private Sub txtParametro_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtParametro.GotFocus
        If txtParametro.Text <> Nothing Then
            txtParametro.ForeColor = Color.Black
            txtParametro.Text = ""
        End If
    End Sub

    'Hacer reaparecer el placeholder
    Private Sub txtBuscarNombre_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscarNombre.LostFocus
        If txtBuscarNombre.Text = Nothing Then
            txtBuscarNombre.ForeColor = Color.Gray
            txtBuscarNombre.Text = "Nombre"
        End If
    End Sub
    Private Sub txtBuscarApellido_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscarApellido.LostFocus
        If txtBuscarApellido.Text = Nothing Then
            txtBuscarApellido.ForeColor = Color.Gray
            txtBuscarApellido.Text = "Apellido"
        End If
    End Sub

    'Buscar usuario
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Dim busqueda As Boolean
        Dim modeloUsuario As New ModeloUsuario(id_usuario:=UsuarioBuscado.idUsuario,
                                          nombre:=UsuarioBuscado.nombre,
                                          apellido:=UsuarioBuscado.apellido,
                                          cedula:=UsuarioBuscado.cedula,
                                          celular:=UsuarioBuscado.celular,
                                          correo:=UsuarioBuscado.correo,
                                          clave:=UsuarioBuscado.contraseña,
                                          estado:=UsuarioBuscado.estado,
                                          rol:=UsuarioBuscado.rol)
        'Valido las variables
        Dim parametro As String = ""
        Dim nombre As String = ""
        Dim apellido As String = ""

        If txtParametro.Visible = True Then
            parametro = txtParametro.Text.ToLower()
            If parametro = "id del usuario" Or parametro = "dirección de correo" Or parametro = "número de cédula" Then
                parametro = Nothing
            End If
        Else
            nombre = txtBuscarNombre.Text.ToUpper()
            If nombre = "NOMBRE" Then
                nombre = Nothing
            End If
            apellido = txtBuscarApellido.Text.ToUpper()
            If apellido = "APELLIDO" Then
                apellido = Nothing
            End If
        End If

        'Verifico que la consulta no este vacia
        If (txtParametro.Visible = True And parametro = Nothing) Or (txtBuscarNombre.Visible = True And nombre = Nothing And apellido = Nothing) Then
            MsgBox("Debe ingresar un parámetro de búsqueda", MsgBoxStyle.Critical, "ERROR")
        Else
            'Si es busqueda por ID Usuario
            If cboxBuscar.Text = "ID Usuario" Then
                busqueda = modeloUsuario.BuscarUsuario(parametro, Nothing, Nothing, Nothing, Nothing)
                'Si es busqueda por correo
            ElseIf cboxBuscar.Text = "Correo" Then
                busqueda = modeloUsuario.BuscarUsuario(Nothing, parametro, Nothing, Nothing, Nothing)
                'Si es busqueda por cédula
            ElseIf cboxBuscar.Text = "Cédula" Then
                busqueda = modeloUsuario.BuscarUsuario(Nothing, Nothing, parametro, Nothing, Nothing)
                'Si es busqueda por nombres y/o apellidos
            ElseIf cboxBuscar.Text = "Nombres y/o apellidos" Then
                busqueda = modeloUsuario.BuscarUsuario(Nothing, Nothing, Nothing, nombre, apellido)
            End If

            'Verifico si retorno consulta
            If busqueda = True Then
                txtID.Text = UsuarioBuscado.idUsuario
                txtNombre.Text = UsuarioBuscado.nombre
                txtApellido.Text = UsuarioBuscado.apellido
                txtCedula.Text = UsuarioBuscado.cedula
                txtCelular.Text = UsuarioBuscado.celular
                txtCorreo.Text = UsuarioBuscado.correo
                txtContraseña.Text = UsuarioBuscado.contraseña
                cboxEstado.Text = UsuarioBuscado.estado
                cboxRol.Text = UsuarioBuscado.rol
                UnlockTxt()
            Else
                MsgBox("No sencontró ningún resultado para su búsqueda", MsgBoxStyle.Critical, "ERROR")
            End If
        End If
    End Sub

    'Guardar cambios al usuario
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'Asigno el valor del id_rol según su rol
        Dim idRol As Integer
        If cboxRol.Text = Roles.administrador Then
            idRol = 1
        ElseIf cboxRol.Text = Roles.aprobador Then
            idRol = 2
        ElseIf cboxRol.Text = Roles.cliente Then
            idRol = 3
        End If
        'Ejecuto el update
        Dim modeloUsuario As New ModeloUsuario(id_usuario:=txtID.Text,
                                      nombre:=txtNombre.Text.ToUpper(),
                                      apellido:=txtApellido.Text.ToUpper(),
                                      cedula:=txtCedula.Text,
                                      celular:=txtCelular.Text,
                                      correo:=txtCorreo.Text.ToLower(),
                                      clave:=txtContraseña.Text,
                                      estado:=cboxEstado.Text,
                                      rol:=idRol)
        Dim resultado = modeloUsuario.EditarUsuario()
        MessageBox.Show(resultado)
        BlockTxt()
    End Sub

    'Bloquear casillas
    Private Sub BlockTxt()
        txtNombre.Enabled = False
        txtApellido.Enabled = False
        txtCedula.Enabled = False
        txtCelular.Enabled = False
        txtCorreo.Enabled = False
        txtContraseña.Enabled = False
        cboxEstado.Enabled = False
        cboxRol.Enabled = False
        btnGuardar.Visible = False
        btnCancelar.Visible = False
    End Sub

    'Desbloquear casillas
    Private Sub UnlockTxt()
        txtNombre.Enabled = True
        txtApellido.Enabled = True
        txtCedula.Enabled = True
        txtCelular.Enabled = True
        txtCorreo.Enabled = True
        txtContraseña.Enabled = True
        cboxEstado.Enabled = True
        cboxRol.Enabled = True
        btnGuardar.Visible = True
        btnCancelar.Visible = True
    End Sub

    'Limpiar info de las casillas
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtID.Text = ""
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtCedula.Text = ""
        txtCelular.Text = ""
        txtCorreo.Text = ""
        txtContraseña.Text = ""
        cboxEstado.Text = ""
        cboxRol.Text = ""
        BlockTxt()
    End Sub
End Class