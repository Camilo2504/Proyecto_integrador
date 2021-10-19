Imports FontAwesome.Sharp
Public Class Usarios
    'Creo campos
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel

    'Creo un constructor
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 60)
        PanelMenu.Controls.Add(leftBorderBtn)
    End Sub

    'Creo un método para resaltar el botón que se seleccione
    Private Sub ActiveButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            'Personalizo el botón
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(37, 36, 81)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight

        End If
    End Sub
End Class