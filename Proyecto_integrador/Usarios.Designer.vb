<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usarios))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PictureCSM_W = New System.Windows.Forms.PictureBox()
        Me.AddUser = New FontAwesome.Sharp.IconButton()
        Me.ListUser = New FontAwesome.Sharp.IconButton()
        Me.EditUser = New FontAwesome.Sharp.IconButton()
        Me.Logout = New FontAwesome.Sharp.IconButton()
        Me.PanelTitle = New System.Windows.Forms.Panel()
        Me.IconTitle = New FontAwesome.Sharp.IconPictureBox()
        Me.LbTitleForm = New System.Windows.Forms.Label()
        Me.PanelMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.PictureCSM_W, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitle.SuspendLayout()
        CType(Me.IconTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.Logout)
        Me.PanelMenu.Controls.Add(Me.EditUser)
        Me.PanelMenu.Controls.Add(Me.ListUser)
        Me.PanelMenu.Controls.Add(Me.AddUser)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(220, 585)
        Me.PanelMenu.TabIndex = 0
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.PictureCSM_W)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(220, 120)
        Me.PanelLogo.TabIndex = 0
        '
        'PictureCSM_W
        '
        Me.PictureCSM_W.Image = CType(resources.GetObject("PictureCSM_W.Image"), System.Drawing.Image)
        Me.PictureCSM_W.Location = New System.Drawing.Point(12, 16)
        Me.PictureCSM_W.Name = "PictureCSM_W"
        Me.PictureCSM_W.Size = New System.Drawing.Size(194, 82)
        Me.PictureCSM_W.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureCSM_W.TabIndex = 0
        Me.PictureCSM_W.TabStop = False
        '
        'AddUser
        '
        Me.AddUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.AddUser.FlatAppearance.BorderSize = 0
        Me.AddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddUser.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddUser.IconChar = FontAwesome.Sharp.IconChar.UserPlus
        Me.AddUser.IconColor = System.Drawing.Color.Gainsboro
        Me.AddUser.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.AddUser.IconSize = 40
        Me.AddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddUser.Location = New System.Drawing.Point(0, 120)
        Me.AddUser.Name = "AddUser"
        Me.AddUser.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.AddUser.Size = New System.Drawing.Size(220, 60)
        Me.AddUser.TabIndex = 1
        Me.AddUser.Text = "Crear usuario"
        Me.AddUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.AddUser.UseVisualStyleBackColor = True
        '
        'ListUser
        '
        Me.ListUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.ListUser.FlatAppearance.BorderSize = 0
        Me.ListUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ListUser.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListUser.IconChar = FontAwesome.Sharp.IconChar.ListUl
        Me.ListUser.IconColor = System.Drawing.Color.Gainsboro
        Me.ListUser.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ListUser.IconSize = 40
        Me.ListUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ListUser.Location = New System.Drawing.Point(0, 180)
        Me.ListUser.Name = "ListUser"
        Me.ListUser.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.ListUser.Size = New System.Drawing.Size(220, 60)
        Me.ListUser.TabIndex = 2
        Me.ListUser.Text = "Listar usuarios"
        Me.ListUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ListUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ListUser.UseVisualStyleBackColor = True
        '
        'EditUser
        '
        Me.EditUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.EditUser.FlatAppearance.BorderSize = 0
        Me.EditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditUser.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditUser.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.EditUser.IconColor = System.Drawing.Color.Gainsboro
        Me.EditUser.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.EditUser.IconSize = 40
        Me.EditUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EditUser.Location = New System.Drawing.Point(0, 240)
        Me.EditUser.Name = "EditUser"
        Me.EditUser.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.EditUser.Size = New System.Drawing.Size(220, 60)
        Me.EditUser.TabIndex = 3
        Me.EditUser.Text = "Editar usuario"
        Me.EditUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EditUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.EditUser.UseVisualStyleBackColor = True
        '
        'Logout
        '
        Me.Logout.Dock = System.Windows.Forms.DockStyle.Top
        Me.Logout.FlatAppearance.BorderSize = 0
        Me.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Logout.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Logout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        Me.Logout.IconColor = System.Drawing.Color.Gainsboro
        Me.Logout.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Logout.IconSize = 40
        Me.Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Logout.Location = New System.Drawing.Point(0, 300)
        Me.Logout.Name = "Logout"
        Me.Logout.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.Logout.Size = New System.Drawing.Size(220, 60)
        Me.Logout.TabIndex = 4
        Me.Logout.Text = "Cerrar sesión"
        Me.Logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Logout.UseVisualStyleBackColor = True
        '
        'PanelTitle
        '
        Me.PanelTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PanelTitle.Controls.Add(Me.LbTitleForm)
        Me.PanelTitle.Controls.Add(Me.IconTitle)
        Me.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitle.Location = New System.Drawing.Point(220, 0)
        Me.PanelTitle.Name = "PanelTitle"
        Me.PanelTitle.Size = New System.Drawing.Size(872, 75)
        Me.PanelTitle.TabIndex = 1
        '
        'IconTitle
        '
        Me.IconTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.IconTitle.ForeColor = System.Drawing.Color.MistyRose
        Me.IconTitle.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconTitle.IconColor = System.Drawing.Color.MistyRose
        Me.IconTitle.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconTitle.Location = New System.Drawing.Point(36, 25)
        Me.IconTitle.Name = "IconTitle"
        Me.IconTitle.Size = New System.Drawing.Size(32, 32)
        Me.IconTitle.TabIndex = 0
        Me.IconTitle.TabStop = False
        '
        'LbTitleForm
        '
        Me.LbTitleForm.AutoSize = True
        Me.LbTitleForm.Location = New System.Drawing.Point(87, 25)
        Me.LbTitleForm.Name = "LbTitleForm"
        Me.LbTitleForm.Size = New System.Drawing.Size(45, 17)
        Me.LbTitleForm.TabIndex = 1
        Me.LbTitleForm.Text = "Home"
        '
        'Usarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1092, 585)
        Me.Controls.Add(Me.PanelTitle)
        Me.Controls.Add(Me.PanelMenu)
        Me.ForeColor = System.Drawing.Color.Gainsboro
        Me.Name = "Usarios"
        Me.Text = "Gestión de Ususarios"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.PictureCSM_W, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitle.ResumeLayout(False)
        Me.PanelTitle.PerformLayout()
        CType(Me.IconTitle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents AddUser As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PictureCSM_W As PictureBox
    Friend WithEvents EditUser As FontAwesome.Sharp.IconButton
    Friend WithEvents ListUser As FontAwesome.Sharp.IconButton
    Friend WithEvents Logout As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelTitle As Panel
    Friend WithEvents LbTitleForm As Label
    Friend WithEvents IconTitle As FontAwesome.Sharp.IconPictureBox
End Class
