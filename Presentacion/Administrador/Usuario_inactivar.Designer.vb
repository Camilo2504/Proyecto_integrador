<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuario_inactivar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.txtRol = New System.Windows.Forms.TextBox()
        Me.btnInactivar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtParametro = New System.Windows.Forms.TextBox()
        Me.cboxBuscar = New System.Windows.Forms.ComboBox()
        Me.txtBuscarApellido = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBuscarNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.txtEstado)
        Me.GroupBox2.Controls.Add(Me.txtRol)
        Me.GroupBox2.Controls.Add(Me.btnInactivar)
        Me.GroupBox2.Controls.Add(Me.btnCancelar)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtContraseña)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtCorreo)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtCelular)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtCedula)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtApellido)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtNombre)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtID)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(19, 128)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(822, 280)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Inactivar usuario"
        '
        'txtEstado
        '
        Me.txtEstado.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtEstado.Enabled = False
        Me.txtEstado.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.Location = New System.Drawing.Point(553, 169)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(210, 30)
        Me.txtEstado.TabIndex = 25
        '
        'txtRol
        '
        Me.txtRol.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtRol.Enabled = False
        Me.txtRol.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRol.Location = New System.Drawing.Point(553, 125)
        Me.txtRol.Name = "txtRol"
        Me.txtRol.Size = New System.Drawing.Size(210, 30)
        Me.txtRol.TabIndex = 24
        '
        'btnInactivar
        '
        Me.btnInactivar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnInactivar.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnInactivar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnInactivar.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInactivar.Location = New System.Drawing.Point(614, 219)
        Me.btnInactivar.Name = "btnInactivar"
        Me.btnInactivar.Size = New System.Drawing.Size(125, 34)
        Me.btnInactivar.TabIndex = 23
        Me.btnInactivar.Text = "Inactivar"
        Me.btnInactivar.UseVisualStyleBackColor = False
        Me.btnInactivar.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancelar.BackColor = System.Drawing.Color.Firebrick
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(459, 219)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(125, 34)
        Me.btnCancelar.TabIndex = 22
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        Me.btnCancelar.Visible = False
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label11.Location = New System.Drawing.Point(430, 172)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 23)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Estado:"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label10.Location = New System.Drawing.Point(430, 127)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 23)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Rol:"
        '
        'txtContraseña
        '
        Me.txtContraseña.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtContraseña.Enabled = False
        Me.txtContraseña.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.Location = New System.Drawing.Point(553, 81)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(210, 30)
        Me.txtContraseña.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Location = New System.Drawing.Point(430, 83)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 23)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Contraseña:"
        '
        'txtCorreo
        '
        Me.txtCorreo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCorreo.Enabled = False
        Me.txtCorreo.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreo.Location = New System.Drawing.Point(553, 37)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(210, 30)
        Me.txtCorreo.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Location = New System.Drawing.Point(430, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 23)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Correo:"
        '
        'txtCelular
        '
        Me.txtCelular.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCelular.Enabled = False
        Me.txtCelular.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelular.Location = New System.Drawing.Point(157, 216)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(210, 30)
        Me.txtCelular.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Location = New System.Drawing.Point(42, 218)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 23)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Celular:"
        '
        'txtCedula
        '
        Me.txtCedula.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCedula.Enabled = False
        Me.txtCedula.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedula.Location = New System.Drawing.Point(157, 170)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(210, 30)
        Me.txtCedula.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(42, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 23)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Cédula:"
        '
        'txtApellido
        '
        Me.txtApellido.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtApellido.Enabled = False
        Me.txtApellido.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.Location = New System.Drawing.Point(157, 125)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(210, 30)
        Me.txtApellido.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(42, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 23)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Apellido(s):"
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(157, 81)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(210, 30)
        Me.txtNombre.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(42, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nombre(s):"
        '
        'txtID
        '
        Me.txtID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtID.Enabled = False
        Me.txtID.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(157, 37)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(210, 30)
        Me.txtID.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(42, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ID Usuario:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.txtParametro)
        Me.GroupBox1.Controls.Add(Me.cboxBuscar)
        Me.GroupBox1.Controls.Add(Me.txtBuscarApellido)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtBuscarNombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(19, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(822, 100)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar usuario"
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBuscar.Location = New System.Drawing.Point(706, 41)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(83, 30)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        Me.btnBuscar.Visible = False
        '
        'txtParametro
        '
        Me.txtParametro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtParametro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtParametro.Location = New System.Drawing.Point(507, 44)
        Me.txtParametro.Name = "txtParametro"
        Me.txtParametro.Size = New System.Drawing.Size(157, 27)
        Me.txtParametro.TabIndex = 5
        Me.txtParametro.Visible = False
        '
        'cboxBuscar
        '
        Me.cboxBuscar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboxBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxBuscar.FormattingEnabled = True
        Me.cboxBuscar.Items.AddRange(New Object() {"ID Usuario", "Correo", "Cédula", "Nombres y/o apellidos"})
        Me.cboxBuscar.Location = New System.Drawing.Point(186, 42)
        Me.cboxBuscar.Name = "cboxBuscar"
        Me.cboxBuscar.Size = New System.Drawing.Size(170, 28)
        Me.cboxBuscar.TabIndex = 1
        '
        'txtBuscarApellido
        '
        Me.txtBuscarApellido.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBuscarApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarApellido.Location = New System.Drawing.Point(507, 58)
        Me.txtBuscarApellido.Name = "txtBuscarApellido"
        Me.txtBuscarApellido.Size = New System.Drawing.Size(157, 27)
        Me.txtBuscarApellido.TabIndex = 4
        Me.txtBuscarApellido.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(23, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar usuario por:"
        '
        'txtBuscarNombre
        '
        Me.txtBuscarNombre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBuscarNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarNombre.Location = New System.Drawing.Point(507, 28)
        Me.txtBuscarNombre.Name = "txtBuscarNombre"
        Me.txtBuscarNombre.Size = New System.Drawing.Size(157, 27)
        Me.txtBuscarNombre.TabIndex = 3
        Me.txtBuscarNombre.Visible = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(380, 33)
        Me.Label2.MaximumSize = New System.Drawing.Size(120, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 46)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Parámetro de búsqueda:"
        '
        'Inactivar_usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(860, 423)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Inactivar_usuario"
        Me.Text = "Inactivar usuario"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents txtRol As TextBox
    Friend WithEvents btnInactivar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCelular As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtParametro As TextBox
    Friend WithEvents cboxBuscar As ComboBox
    Friend WithEvents txtBuscarApellido As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBuscarNombre As TextBox
    Friend WithEvents Label2 As Label
End Class
