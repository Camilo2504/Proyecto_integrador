Imports System.Runtime.InteropServices
Imports Negocio
Imports Transversal

Public Class Login
    'Botón de salir
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        If MessageBox.Show("¿Esta seguro que desea salir de la aplicación?", "Advertencia",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    'Botón de minimizar
    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles BtnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'Arrastrar formulario desde el panel superior
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub TitleBar_MouseMove(sender As Object, e As MouseEventArgs) Handles TitleBar.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    'Forma del botón de log in
    Private Sub Log_Paint(sender As Object, e As PaintEventArgs)
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btnLog.ClientRectangle
        myRectangle.Inflate(0, 32)
        buttonPath.AddEllipse(myRectangle)
        btnLog.Region = New Region(buttonPath)
    End Sub

    'Iniciar sesión
    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        'Instancio un objeto de la clase ModeloUsuario
        Dim modeloUsuario As New ModeloUsuario(id_usuario:=UsuarioActivo.idUsuario, nombre:=UsuarioActivo.nombre, apellido:=UsuarioActivo.apellido, cedula:=UsuarioActivo.cedula, celular:=UsuarioActivo.celular, correo:=UsuarioActivo.correo, clave:=UsuarioActivo.contraseña, estado:=UsuarioActivo.estado, rol:=UsuarioActivo.rol)
        'Creo una variable y asigno el valor de Login (capa de negocio)
        Dim validLogin = modeloUsuario.Login(txtEmail.Text, txtPassword.Text)
        'Verifico si retorno consulta
        If validLogin = True Then
            'Valido si el usuario esta activo
            If UsuarioActivo.estado = "ACTIVO" Then
                'Valido el tipo de usuario
                If UsuarioActivo.rol = Roles.administrador Then
                    Dim frm As New Administrador_form()
                    frm.Show()
                    AddHandler frm.FormClosed, AddressOf Me.Logout
                    Me.Hide()
                ElseIf UsuarioActivo.rol = Roles.aprobador Then
                    Dim frm As New Aprobador_form()
                    frm.Show()
                    AddHandler frm.FormClosed, AddressOf Me.Logout
                    Me.Hide()
                Else
                    MessageBox.Show("Su usuario no cuenta con privilegios para ingresar a la aplicación de escritorio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MsgBox("El usuario se encuentra inactivo, no puede ingresar a la aplicación", MsgBoxStyle.Critical, "ERROR")
                txtEmail.Clear()
                txtPassword.Clear()
            End If
        Else
            MsgBox("Usuario o contraseña incorrectos" + vbNewLine + "Intente nuevamente", MsgBoxStyle.Critical, "ERROR")
            txtPassword.Clear()
            txtPassword.Focus()
        End If
    End Sub

    'Cerrar sesión
    Private Sub Logout(sender As Object, e As FormClosedEventArgs)
        txtEmail.Clear()
        txtPassword.Clear()
        Me.Show()
        txtEmail.Focus()
    End Sub

    'Función para recordar usuario
    Private Sub chRemember_CheckedChanged(sender As Object, e As EventArgs) Handles chRemember.CheckedChanged
        If txtEmail.Text = Nothing Then

        End If
        If chRemember.Checked = True Then
            My.Settings.Correo = txtEmail.Text
            My.Settings.Recordar = 1
            My.Settings.Save()
        End If
    End Sub

    'Cargo los valores recordados
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtEmail.Text = My.Settings.Correo
        chRemember.CheckState = My.Settings.Recordar
    End Sub
End Class
