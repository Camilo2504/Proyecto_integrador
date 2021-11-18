<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Legalizacion_pendiente
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
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridList = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAprobar = New System.Windows.Forms.Button()
        Me.btnRechazar = New System.Windows.Forms.Button()
        Me.lbID = New System.Windows.Forms.Label()
        Me.txtConsecutivo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        CType(Me.DataGridList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(19, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(221, 23)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Legalizaciones por verificar:"
        '
        'DataGridList
        '
        Me.DataGridList.AllowUserToAddRows = False
        Me.DataGridList.AllowUserToDeleteRows = False
        Me.DataGridList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridList.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.DataGridList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle22
        Me.DataGridList.ColumnHeadersHeight = 30
        Me.DataGridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridList.EnableHeadersVisualStyles = False
        Me.DataGridList.GridColor = System.Drawing.Color.SteelBlue
        Me.DataGridList.Location = New System.Drawing.Point(23, 119)
        Me.DataGridList.Name = "DataGridList"
        Me.DataGridList.ReadOnly = True
        Me.DataGridList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(100, Byte), Integer))
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle23.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridList.RowHeadersDefaultCellStyle = DataGridViewCellStyle23
        Me.DataGridList.RowHeadersVisible = False
        Me.DataGridList.RowHeadersWidth = 51
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle24.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridList.RowsDefaultCellStyle = DataGridViewCellStyle24
        Me.DataGridList.RowTemplate.Height = 24
        Me.DataGridList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridList.Size = New System.Drawing.Size(617, 282)
        Me.DataGridList.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(685, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 23)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "ID Legalización"
        '
        'btnAprobar
        '
        Me.btnAprobar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnAprobar.BackColor = System.Drawing.Color.Green
        Me.btnAprobar.Enabled = False
        Me.btnAprobar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAprobar.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnAprobar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAprobar.Location = New System.Drawing.Point(696, 205)
        Me.btnAprobar.Name = "btnAprobar"
        Me.btnAprobar.Size = New System.Drawing.Size(99, 30)
        Me.btnAprobar.TabIndex = 11
        Me.btnAprobar.Text = "Aprobar"
        Me.btnAprobar.UseVisualStyleBackColor = False
        '
        'btnRechazar
        '
        Me.btnRechazar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnRechazar.BackColor = System.Drawing.Color.Red
        Me.btnRechazar.Enabled = False
        Me.btnRechazar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRechazar.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnRechazar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRechazar.Location = New System.Drawing.Point(696, 272)
        Me.btnRechazar.Name = "btnRechazar"
        Me.btnRechazar.Size = New System.Drawing.Size(99, 30)
        Me.btnRechazar.TabIndex = 12
        Me.btnRechazar.Text = "Rechazar"
        Me.btnRechazar.UseVisualStyleBackColor = False
        '
        'lbID
        '
        Me.lbID.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbID.AutoSize = True
        Me.lbID.Font = New System.Drawing.Font("Segoe UI Semibold", 11.2!, System.Drawing.FontStyle.Bold)
        Me.lbID.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbID.Location = New System.Drawing.Point(685, 153)
        Me.lbID.MinimumSize = New System.Drawing.Size(125, 23)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(125, 25)
        Me.lbID.TabIndex = 13
        Me.lbID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtConsecutivo
        '
        Me.txtConsecutivo.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold)
        Me.txtConsecutivo.Location = New System.Drawing.Point(248, 30)
        Me.txtConsecutivo.Name = "txtConsecutivo"
        Me.txtConsecutivo.Size = New System.Drawing.Size(134, 30)
        Me.txtConsecutivo.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(70, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 23)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Buscar consecutivo:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(448, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 23)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Buscar por fecha:"
        '
        'txtFecha
        '
        Me.txtFecha.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold)
        Me.txtFecha.Location = New System.Drawing.Point(610, 30)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(134, 30)
        Me.txtFecha.TabIndex = 16
        '
        'Legalizacion_pendiente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(860, 423)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtConsecutivo)
        Me.Controls.Add(Me.lbID)
        Me.Controls.Add(Me.btnRechazar)
        Me.Controls.Add(Me.btnAprobar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Legalizacion_pendiente"
        Me.Text = "Legalizaciones pendientes"
        CType(Me.DataGridList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridList As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAprobar As Button
    Friend WithEvents btnRechazar As Button
    Friend WithEvents lbID As Label
    Friend WithEvents txtConsecutivo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFecha As TextBox
End Class
