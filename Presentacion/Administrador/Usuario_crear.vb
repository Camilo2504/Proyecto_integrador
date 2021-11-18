Imports Negocio
Imports Transversal

Public Class Usuario_crear
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
        'Ejecuto el insert
        Dim modeloUsuario As New ModeloUsuario(Nothing,
                                      nombre:=txtNombre.Text.ToUpper(),
                                      apellido:=txtApellido.Text.ToUpper(),
                                      cedula:=txtCedula.Text,
                                      celular:=txtCelular.Text,
                                      correo:=txtCorreo.Text.ToLower(),
                                      clave:=txtContraseña.Text,
                                      estado:=cboxEstado.Text,
                                      rol:=idRol)
        Dim resultado = modeloUsuario.CrearUsuario()
        MessageBox.Show(resultado)
        ClearTxt()
    End Sub

    'Limpiar casillas
    Private Sub ClearTxt()
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtCedula.Text = ""
        txtCelular.Text = ""
        txtCorreo.Text = ""
        txtContraseña.Text = ""
        cboxEstado.Text = ""
        cboxRol.Text = ""
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ClearTxt()
    End Sub
End Class