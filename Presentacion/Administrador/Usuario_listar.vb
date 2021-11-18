Imports Negocio
Public Class Usuario_listar
    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        ListarUsuarios()
    End Sub

    Private Sub ListarUsuarios()
        Dim modeloUsuario As New ModeloUsuario(id_usuario:=Nothing, nombre:=Nothing, apellido:=Nothing, cedula:=Nothing, celular:=Nothing, correo:=Nothing, clave:=Nothing, estado:=Nothing, rol:=Nothing)
        Dim resultado = modeloUsuario.ListarUsuarios()
        DataGridList.DataSource = resultado.Tables(0)
    End Sub
End Class