<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administrador_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Administrador_form))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.Logout = New FontAwesome.Sharp.IconButton()
        Me.Inactivate = New FontAwesome.Sharp.IconButton()
        Me.EditUser = New FontAwesome.Sharp.IconButton()
        Me.ListUser = New FontAwesome.Sharp.IconButton()
        Me.AddUser = New FontAwesome.Sharp.IconButton()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PictureCSM_W = New System.Windows.Forms.PictureBox()
        Me.PanelTitle = New System.Windows.Forms.Panel()
        Me.Info_user = New System.Windows.Forms.Label()
        Me.BtnMinimize = New FontAwesome.Sharp.IconButton()
        Me.BtnMaximize = New FontAwesome.Sharp.IconButton()
        Me.BtnExit = New FontAwesome.Sharp.IconButton()
        Me.LbTitleForm = New System.Windows.Forms.Label()
        Me.IconTitle = New FontAwesome.Sharp.IconPictureBox()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.info_email = New System.Windows.Forms.Label()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.info_user2 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.PictureCSM_W, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitle.SuspendLayout()
        CType(Me.IconTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDesktop.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.Logout)
        Me.PanelMenu.Controls.Add(Me.Inactivate)
        Me.PanelMenu.Controls.Add(Me.EditUser)
        Me.PanelMenu.Controls.Add(Me.ListUser)
        Me.PanelMenu.Controls.Add(Me.AddUser)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(187, 503)
        Me.PanelMenu.TabIndex = 0
        '
        'Logout
        '
        Me.Logout.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Logout.FlatAppearance.BorderSize = 0
        Me.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Logout.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Logout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        Me.Logout.IconColor = System.Drawing.Color.Gainsboro
        Me.Logout.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Logout.IconSize = 40
        Me.Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Logout.Location = New System.Drawing.Point(0, 415)
        Me.Logout.Name = "Logout"
        Me.Logout.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.Logout.Size = New System.Drawing.Size(187, 70)
        Me.Logout.TabIndex = 5
        Me.Logout.Text = "Cerrar sesión"
        Me.Logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Logout.UseVisualStyleBackColor = True
        '
        'Inactivate
        '
        Me.Inactivate.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Inactivate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Inactivate.Dock = System.Windows.Forms.DockStyle.Top
        Me.Inactivate.FlatAppearance.BorderSize = 0
        Me.Inactivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Inactivate.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Inactivate.IconChar = FontAwesome.Sharp.IconChar.UserSlash
        Me.Inactivate.IconColor = System.Drawing.Color.Gainsboro
        Me.Inactivate.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Inactivate.IconSize = 40
        Me.Inactivate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Inactivate.Location = New System.Drawing.Point(0, 340)
        Me.Inactivate.Name = "Inactivate"
        Me.Inactivate.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.Inactivate.Size = New System.Drawing.Size(187, 70)
        Me.Inactivate.TabIndex = 4
        Me.Inactivate.Text = "Inactivar usuario"
        Me.Inactivate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Inactivate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Inactivate.UseVisualStyleBackColor = True
        '
        'EditUser
        '
        Me.EditUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EditUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.EditUser.FlatAppearance.BorderSize = 0
        Me.EditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditUser.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditUser.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.EditUser.IconColor = System.Drawing.Color.Gainsboro
        Me.EditUser.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.EditUser.IconSize = 40
        Me.EditUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EditUser.Location = New System.Drawing.Point(0, 270)
        Me.EditUser.Name = "EditUser"
        Me.EditUser.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.EditUser.Size = New System.Drawing.Size(187, 70)
        Me.EditUser.TabIndex = 3
        Me.EditUser.Text = "Editar usuario"
        Me.EditUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EditUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.EditUser.UseVisualStyleBackColor = True
        '
        'ListUser
        '
        Me.ListUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.ListUser.FlatAppearance.BorderSize = 0
        Me.ListUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ListUser.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListUser.IconChar = FontAwesome.Sharp.IconChar.ListUl
        Me.ListUser.IconColor = System.Drawing.Color.Gainsboro
        Me.ListUser.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ListUser.IconSize = 40
        Me.ListUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ListUser.Location = New System.Drawing.Point(0, 200)
        Me.ListUser.Name = "ListUser"
        Me.ListUser.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.ListUser.Size = New System.Drawing.Size(187, 70)
        Me.ListUser.TabIndex = 2
        Me.ListUser.Text = "Listar usuarios"
        Me.ListUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ListUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ListUser.UseVisualStyleBackColor = True
        '
        'AddUser
        '
        Me.AddUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.AddUser.FlatAppearance.BorderSize = 0
        Me.AddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddUser.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddUser.IconChar = FontAwesome.Sharp.IconChar.UserPlus
        Me.AddUser.IconColor = System.Drawing.Color.Gainsboro
        Me.AddUser.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.AddUser.IconSize = 40
        Me.AddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddUser.Location = New System.Drawing.Point(0, 130)
        Me.AddUser.Name = "AddUser"
        Me.AddUser.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.AddUser.Size = New System.Drawing.Size(187, 70)
        Me.AddUser.TabIndex = 1
        Me.AddUser.Text = "Crear usuario"
        Me.AddUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.AddUser.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.PictureCSM_W)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(187, 130)
        Me.PanelLogo.TabIndex = 0
        '
        'PictureCSM_W
        '
        Me.PictureCSM_W.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureCSM_W.Image = CType(resources.GetObject("PictureCSM_W.Image"), System.Drawing.Image)
        Me.PictureCSM_W.Location = New System.Drawing.Point(7, 13)
        Me.PictureCSM_W.Name = "PictureCSM_W"
        Me.PictureCSM_W.Size = New System.Drawing.Size(172, 103)
        Me.PictureCSM_W.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureCSM_W.TabIndex = 0
        Me.PictureCSM_W.TabStop = False
        '
        'PanelTitle
        '
        Me.PanelTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PanelTitle.Controls.Add(Me.Info_user)
        Me.PanelTitle.Controls.Add(Me.BtnMinimize)
        Me.PanelTitle.Controls.Add(Me.BtnMaximize)
        Me.PanelTitle.Controls.Add(Me.BtnExit)
        Me.PanelTitle.Controls.Add(Me.LbTitleForm)
        Me.PanelTitle.Controls.Add(Me.IconTitle)
        Me.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitle.Location = New System.Drawing.Point(187, 0)
        Me.PanelTitle.Name = "PanelTitle"
        Me.PanelTitle.Size = New System.Drawing.Size(860, 80)
        Me.PanelTitle.TabIndex = 1
        '
        'Info_user
        '
        Me.Info_user.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Info_user.AutoSize = True
        Me.Info_user.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Info_user.Location = New System.Drawing.Point(354, 43)
        Me.Info_user.MinimumSize = New System.Drawing.Size(500, 0)
        Me.Info_user.Name = "Info_user"
        Me.Info_user.Size = New System.Drawing.Size(500, 25)
        Me.Info_user.TabIndex = 6
        Me.Info_user.Text = "User"
        Me.Info_user.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnMinimize
        '
        Me.BtnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMinimize.FlatAppearance.BorderSize = 0
        Me.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMinimize.ForeColor = System.Drawing.Color.Transparent
        Me.BtnMinimize.IconChar = FontAwesome.Sharp.IconChar.MinusCircle
        Me.BtnMinimize.IconColor = System.Drawing.Color.Goldenrod
        Me.BtnMinimize.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.BtnMinimize.IconSize = 32
        Me.BtnMinimize.Location = New System.Drawing.Point(756, 11)
        Me.BtnMinimize.Name = "BtnMinimize"
        Me.BtnMinimize.Size = New System.Drawing.Size(30, 30)
        Me.BtnMinimize.TabIndex = 4
        Me.BtnMinimize.UseVisualStyleBackColor = True
        '
        'BtnMaximize
        '
        Me.BtnMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMaximize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMaximize.FlatAppearance.BorderSize = 0
        Me.BtnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMaximize.ForeColor = System.Drawing.Color.Transparent
        Me.BtnMaximize.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleUp
        Me.BtnMaximize.IconColor = System.Drawing.Color.LimeGreen
        Me.BtnMaximize.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.BtnMaximize.IconSize = 32
        Me.BtnMaximize.Location = New System.Drawing.Point(791, 11)
        Me.BtnMaximize.Name = "BtnMaximize"
        Me.BtnMaximize.Size = New System.Drawing.Size(30, 30)
        Me.BtnMaximize.TabIndex = 3
        Me.BtnMaximize.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock
        Me.BtnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExit.FlatAppearance.BorderSize = 0
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.ForeColor = System.Drawing.Color.Transparent
        Me.BtnExit.IconChar = FontAwesome.Sharp.IconChar.TimesCircle
        Me.BtnExit.IconColor = System.Drawing.Color.Firebrick
        Me.BtnExit.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.BtnExit.IconSize = 32
        Me.BtnExit.Location = New System.Drawing.Point(824, 11)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(30, 30)
        Me.BtnExit.TabIndex = 2
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'LbTitleForm
        '
        Me.LbTitleForm.AutoSize = True
        Me.LbTitleForm.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTitleForm.Location = New System.Drawing.Point(70, 24)
        Me.LbTitleForm.Name = "LbTitleForm"
        Me.LbTitleForm.Size = New System.Drawing.Size(83, 32)
        Me.LbTitleForm.TabIndex = 1
        Me.LbTitleForm.Text = "Home"
        '
        'IconTitle
        '
        Me.IconTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.IconTitle.ForeColor = System.Drawing.Color.MistyRose
        Me.IconTitle.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconTitle.IconColor = System.Drawing.Color.MistyRose
        Me.IconTitle.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconTitle.IconSize = 45
        Me.IconTitle.Location = New System.Drawing.Point(19, 21)
        Me.IconTitle.Name = "IconTitle"
        Me.IconTitle.Size = New System.Drawing.Size(45, 45)
        Me.IconTitle.TabIndex = 0
        Me.IconTitle.TabStop = False
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.PanelDesktop.Controls.Add(Me.info_email)
        Me.PanelDesktop.Controls.Add(Me.IconPictureBox1)
        Me.PanelDesktop.Controls.Add(Me.info_user2)
        Me.PanelDesktop.Controls.Add(Me.Label2)
        Me.PanelDesktop.Controls.Add(Me.PictureBox1)
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(187, 80)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PanelDesktop.Size = New System.Drawing.Size(860, 423)
        Me.PanelDesktop.TabIndex = 2
        '
        'info_email
        '
        Me.info_email.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.info_email.AutoSize = True
        Me.info_email.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info_email.Location = New System.Drawing.Point(136, 256)
        Me.info_email.MinimumSize = New System.Drawing.Size(600, 32)
        Me.info_email.Name = "info_email"
        Me.info_email.Size = New System.Drawing.Size(600, 32)
        Me.info_email.TabIndex = 8
        Me.info_email.Text = "info_email"
        Me.info_email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IconPictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.IconPictureBox1.ForeColor = System.Drawing.Color.PeachPuff
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserSecret
        Me.IconPictureBox1.IconColor = System.Drawing.Color.PeachPuff
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 50
        Me.IconPictureBox1.Location = New System.Drawing.Point(409, 310)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.IconPictureBox1.TabIndex = 7
        Me.IconPictureBox1.TabStop = False
        '
        'info_user2
        '
        Me.info_user2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.info_user2.AutoSize = True
        Me.info_user2.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info_user2.Location = New System.Drawing.Point(136, 213)
        Me.info_user2.MinimumSize = New System.Drawing.Size(600, 32)
        Me.info_user2.Name = "info_user2"
        Me.info_user2.Size = New System.Drawing.Size(600, 32)
        Me.info_user2.TabIndex = 3
        Me.info_user2.Text = "Info_user"
        Me.info_user2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(317, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(235, 32)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hola Administrador!"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(275, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(314, 110)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Administrador_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1047, 503)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.PanelTitle)
        Me.Controls.Add(Me.PanelMenu)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.ForeColor = System.Drawing.Color.Gainsboro
        Me.MinimumSize = New System.Drawing.Size(1065, 550)
        Me.Name = "Administrador_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Ususarios"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.PictureCSM_W, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitle.ResumeLayout(False)
        Me.PanelTitle.PerformLayout()
        CType(Me.IconTitle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDesktop.ResumeLayout(False)
        Me.PanelDesktop.PerformLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents AddUser As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PictureCSM_W As PictureBox
    Friend WithEvents EditUser As FontAwesome.Sharp.IconButton
    Friend WithEvents ListUser As FontAwesome.Sharp.IconButton
    Friend WithEvents Inactivate As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelTitle As Panel
    Friend WithEvents LbTitleForm As Label
    Friend WithEvents IconTitle As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Logout As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnExit As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnMinimize As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnMaximize As FontAwesome.Sharp.IconButton
    Friend WithEvents Info_user As Label
    Friend WithEvents info_user2 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents info_email As Label
End Class
