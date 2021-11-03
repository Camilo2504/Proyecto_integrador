﻿Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp
Public Class Usarios
    'Creo campos
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form

    'Creo un constructor
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 60)
        PanelMenu.Controls.Add(leftBorderBtn)
        'Formulario
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub

    'Creo un método para resaltar el botón que se seleccione
    Private Sub ActiveButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Personalizo el botón
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(37, 36, 81)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage

            'Borde izquierdo
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()

            'Cambio el icono de la barra
            IconTitle.IconChar = currentBtn.IconChar
            IconTitle.IconColor = customColor
        End If
    End Sub

    'Creo un método para desactivar el resaltado del botón que se seleccione
    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            'Personalizo el botón
            currentBtn.BackColor = Color.FromArgb(31, 30, 68)
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    'Para abrir cada una de los formularios hijos
    Private Sub OpenChildForm(childForm As Form)
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm

        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(childForm)
        PanelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        LbTitleForm.Text = childForm.Text
    End Sub

    'Click en el botón de agregar usuario
    Private Sub AddUser_Click(sender As Object, e As EventArgs) Handles AddUser.Click
        ActiveButton(sender, Color.FromArgb(172, 126, 241))
        OpenChildForm(New Crear_usuario)
    End Sub

    'Click en el botón de listar usuarios
    Private Sub ListUser_Click(sender As Object, e As EventArgs) Handles ListUser.Click
        ActiveButton(sender, Color.FromArgb(249, 118, 176))
        OpenChildForm(New Listar_usuarios)
    End Sub

    'Click en el botón de editar usuario
    Private Sub EditUser_Click(sender As Object, e As EventArgs) Handles EditUser.Click
        ActiveButton(sender, Color.FromArgb(253, 138, 114))
        OpenChildForm(New Editar_usuario)
    End Sub

    'Click en el botón de inactivar usuario
    Private Sub Inactivate_Click(sender As Object, e As EventArgs) Handles Inactivate.Click
        ActiveButton(sender, Color.FromArgb(95, 77, 221))
        OpenChildForm(New Inactivar_usuario)
    End Sub

    'Click en el logo del aplicativo
    Private Sub PictureCSM_W_Click(sender As Object, e As EventArgs) Handles PictureCSM_W.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        Reset()
    End Sub

    'Creo un métoo para reiniciar el menú
    Private Sub Reset()
        DisableButton()
        leftBorderBtn.Visible = False
        IconTitle.IconChar = IconChar.Home
        IconTitle.IconColor = Color.MistyRose
        LbTitleForm.Text = "Home"
    End Sub

    'Arrastrar formulario desde el panel superior
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PanelTitle_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTitle.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    'Quito bordes cuando maximizo
    Private Sub Usarios_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub

    'Botón de salir
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Application.Exit()
    End Sub

    'Botón de maximizar
    Private Sub BtnMaximize_Click(sender As Object, e As EventArgs) Handles BtnMaximize.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    'Botón de minimizar
    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles BtnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub
End Class