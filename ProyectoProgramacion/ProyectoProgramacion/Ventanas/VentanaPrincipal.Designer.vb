<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaPrincipal
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
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnDelivery = New FontAwesome.Sharp.IconButton()
        Me.btnModificarPrecio = New FontAwesome.Sharp.IconButton()
        Me.btnInsertar = New FontAwesome.Sharp.IconButton()
        Me.btnInicio = New FontAwesome.Sharp.IconButton()
        Me.btnCerarSesion = New FontAwesome.Sharp.IconButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pbLogoEmpresa = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblGeneral = New System.Windows.Forms.Label()
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.ipbSalir = New FontAwesome.Sharp.IconPictureBox()
        Me.ipbMinimizar = New FontAwesome.Sharp.IconPictureBox()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.panelUsuario = New System.Windows.Forms.Panel()
        Me.lblCargo = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.pbImagenUsuario = New System.Windows.Forms.PictureBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.PanelMenu.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.pbLogoEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ipbSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ipbMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelUsuario.SuspendLayout()
        CType(Me.pbImagenUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btnDelivery)
        Me.PanelMenu.Controls.Add(Me.btnModificarPrecio)
        Me.PanelMenu.Controls.Add(Me.btnInsertar)
        Me.PanelMenu.Controls.Add(Me.btnInicio)
        Me.PanelMenu.Controls.Add(Me.btnCerarSesion)
        Me.PanelMenu.Controls.Add(Me.Panel2)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(218, 581)
        Me.PanelMenu.TabIndex = 2
        '
        'btnDelivery
        '
        Me.btnDelivery.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelivery.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDelivery.FlatAppearance.BorderSize = 0
        Me.btnDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelivery.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnDelivery.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelivery.ForeColor = System.Drawing.Color.White
        Me.btnDelivery.IconChar = FontAwesome.Sharp.IconChar.Truck
        Me.btnDelivery.IconColor = System.Drawing.Color.White
        Me.btnDelivery.IconSize = 32
        Me.btnDelivery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelivery.Location = New System.Drawing.Point(0, 244)
        Me.btnDelivery.Name = "btnDelivery"
        Me.btnDelivery.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnDelivery.Rotation = 0R
        Me.btnDelivery.Size = New System.Drawing.Size(218, 46)
        Me.btnDelivery.TabIndex = 16
        Me.btnDelivery.Text = "Reservas confirmadas"
        Me.btnDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelivery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelivery.UseVisualStyleBackColor = True
        '
        'btnModificarPrecio
        '
        Me.btnModificarPrecio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificarPrecio.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnModificarPrecio.FlatAppearance.BorderSize = 0
        Me.btnModificarPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificarPrecio.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnModificarPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarPrecio.ForeColor = System.Drawing.Color.White
        Me.btnModificarPrecio.IconChar = FontAwesome.Sharp.IconChar.Truck
        Me.btnModificarPrecio.IconColor = System.Drawing.Color.White
        Me.btnModificarPrecio.IconSize = 32
        Me.btnModificarPrecio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificarPrecio.Location = New System.Drawing.Point(0, 198)
        Me.btnModificarPrecio.Name = "btnModificarPrecio"
        Me.btnModificarPrecio.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnModificarPrecio.Rotation = 0R
        Me.btnModificarPrecio.Size = New System.Drawing.Size(218, 46)
        Me.btnModificarPrecio.TabIndex = 17
        Me.btnModificarPrecio.Text = "Modificar precio de las habitaciones"
        Me.btnModificarPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificarPrecio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnModificarPrecio.UseVisualStyleBackColor = True
        '
        'btnInsertar
        '
        Me.btnInsertar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInsertar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnInsertar.FlatAppearance.BorderSize = 0
        Me.btnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsertar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnInsertar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsertar.ForeColor = System.Drawing.Color.White
        Me.btnInsertar.IconChar = FontAwesome.Sharp.IconChar.AddressBook
        Me.btnInsertar.IconColor = System.Drawing.Color.White
        Me.btnInsertar.IconSize = 32
        Me.btnInsertar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInsertar.Location = New System.Drawing.Point(0, 152)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnInsertar.Rotation = 0R
        Me.btnInsertar.Size = New System.Drawing.Size(218, 46)
        Me.btnInsertar.TabIndex = 13
        Me.btnInsertar.Text = "Gestionar Reservas"
        Me.btnInsertar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInsertar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'btnInicio
        '
        Me.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInicio.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnInicio.FlatAppearance.BorderSize = 0
        Me.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInicio.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInicio.ForeColor = System.Drawing.Color.White
        Me.btnInicio.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.btnInicio.IconColor = System.Drawing.Color.White
        Me.btnInicio.IconSize = 32
        Me.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInicio.Location = New System.Drawing.Point(0, 106)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnInicio.Rotation = 0R
        Me.btnInicio.Size = New System.Drawing.Size(218, 46)
        Me.btnInicio.TabIndex = 7
        Me.btnInicio.Text = "Inicio"
        Me.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'btnCerarSesion
        '
        Me.btnCerarSesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerarSesion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnCerarSesion.FlatAppearance.BorderSize = 0
        Me.btnCerarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerarSesion.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnCerarSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCerarSesion.ForeColor = System.Drawing.Color.White
        Me.btnCerarSesion.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        Me.btnCerarSesion.IconColor = System.Drawing.Color.White
        Me.btnCerarSesion.IconSize = 32
        Me.btnCerarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerarSesion.Location = New System.Drawing.Point(0, 535)
        Me.btnCerarSesion.Name = "btnCerarSesion"
        Me.btnCerarSesion.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnCerarSesion.Rotation = 0R
        Me.btnCerarSesion.Size = New System.Drawing.Size(218, 46)
        Me.btnCerarSesion.TabIndex = 12
        Me.btnCerarSesion.Text = "Cerrar Sesion"
        Me.btnCerarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCerarSesion.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.pbLogoEmpresa)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(218, 106)
        Me.Panel2.TabIndex = 1
        '
        'pbLogoEmpresa
        '
        Me.pbLogoEmpresa.Image = Global.ProyectoProgramacion.My.Resources.Resources.Logo_HotelCanino
        Me.pbLogoEmpresa.Location = New System.Drawing.Point(3, 3)
        Me.pbLogoEmpresa.Name = "pbLogoEmpresa"
        Me.pbLogoEmpresa.Size = New System.Drawing.Size(205, 88)
        Me.pbLogoEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLogoEmpresa.TabIndex = 1
        Me.pbLogoEmpresa.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lblGeneral)
        Me.Panel3.Controls.Add(Me.IconCurrentForm)
        Me.Panel3.Controls.Add(Me.ipbSalir)
        Me.Panel3.Controls.Add(Me.ipbMinimizar)
        Me.Panel3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(218, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(736, 42)
        Me.Panel3.TabIndex = 4
        '
        'lblGeneral
        '
        Me.lblGeneral.AutoSize = True
        Me.lblGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblGeneral.ForeColor = System.Drawing.Color.White
        Me.lblGeneral.Location = New System.Drawing.Point(40, 13)
        Me.lblGeneral.Name = "lblGeneral"
        Me.lblGeneral.Size = New System.Drawing.Size(39, 20)
        Me.lblGeneral.TabIndex = 6
        Me.lblGeneral.Text = "Inicio"
        Me.lblGeneral.UseCompatibleTextRendering = True
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconCurrentForm.IconColor = System.Drawing.Color.White
        Me.IconCurrentForm.IconSize = 35
        Me.IconCurrentForm.Location = New System.Drawing.Point(5, 7)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Size = New System.Drawing.Size(38, 35)
        Me.IconCurrentForm.TabIndex = 0
        Me.IconCurrentForm.TabStop = False
        '
        'ipbSalir
        '
        Me.ipbSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ipbSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ipbSalir.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.ipbSalir.IconColor = System.Drawing.Color.White
        Me.ipbSalir.IconSize = 34
        Me.ipbSalir.Location = New System.Drawing.Point(699, 4)
        Me.ipbSalir.Name = "ipbSalir"
        Me.ipbSalir.Size = New System.Drawing.Size(38, 34)
        Me.ipbSalir.TabIndex = 4
        Me.ipbSalir.TabStop = False
        '
        'ipbMinimizar
        '
        Me.ipbMinimizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ipbMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ipbMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.ipbMinimizar.IconColor = System.Drawing.Color.White
        Me.ipbMinimizar.IconSize = 34
        Me.ipbMinimizar.Location = New System.Drawing.Point(663, 5)
        Me.ipbMinimizar.Name = "ipbMinimizar"
        Me.ipbMinimizar.Size = New System.Drawing.Size(38, 34)
        Me.ipbMinimizar.TabIndex = 5
        Me.ipbMinimizar.TabStop = False
        '
        'PanelDesktop
        '
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelDesktop.Location = New System.Drawing.Point(218, 42)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(736, 471)
        Me.PanelDesktop.TabIndex = 7
        '
        'panelUsuario
        '
        Me.panelUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.panelUsuario.Controls.Add(Me.lblCargo)
        Me.panelUsuario.Controls.Add(Me.lblApellido)
        Me.panelUsuario.Controls.Add(Me.lblNombre)
        Me.panelUsuario.Controls.Add(Me.pbImagenUsuario)
        Me.panelUsuario.Controls.Add(Me.lblFecha)
        Me.panelUsuario.Controls.Add(Me.lblHora)
        Me.panelUsuario.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelUsuario.Location = New System.Drawing.Point(218, 511)
        Me.panelUsuario.Name = "panelUsuario"
        Me.panelUsuario.Size = New System.Drawing.Size(736, 70)
        Me.panelUsuario.TabIndex = 8
        '
        'lblCargo
        '
        Me.lblCargo.AutoSize = True
        Me.lblCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblCargo.ForeColor = System.Drawing.Color.White
        Me.lblCargo.Location = New System.Drawing.Point(65, 47)
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Size = New System.Drawing.Size(134, 16)
        Me.lblCargo.TabIndex = 3
        Me.lblCargo.Text = "Cargo: Administrador"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblApellido.ForeColor = System.Drawing.Color.White
        Me.lblApellido.Location = New System.Drawing.Point(65, 26)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(180, 16)
        Me.lblApellido.TabIndex = 2
        Me.lblApellido.Text = "Apellidos: Varela Hernandez"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(65, 5)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(161, 16)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombres: Nora Alejandra"
        '
        'pbImagenUsuario
        '
        Me.pbImagenUsuario.Image = Global.ProyectoProgramacion.My.Resources.Resources.imagenPrueba2
        Me.pbImagenUsuario.Location = New System.Drawing.Point(3, 8)
        Me.pbImagenUsuario.Name = "pbImagenUsuario"
        Me.pbImagenUsuario.Size = New System.Drawing.Size(58, 60)
        Me.pbImagenUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImagenUsuario.TabIndex = 1
        Me.pbImagenUsuario.TabStop = False
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblFecha.ForeColor = System.Drawing.Color.White
        Me.lblFecha.Location = New System.Drawing.Point(533, 41)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(200, 20)
        Me.lblFecha.TabIndex = 1
        Me.lblFecha.Text = "viernes, 24 de julio de 2020"
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblHora.ForeColor = System.Drawing.Color.White
        Me.lblHora.Location = New System.Drawing.Point(662, 8)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(71, 20)
        Me.lblHora.TabIndex = 0
        Me.lblHora.Text = "17:43:12"
        '
        'VentanaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 581)
        Me.Controls.Add(Me.panelUsuario)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PanelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VentanaPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VentanaPrincipal"
        Me.PanelMenu.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.pbLogoEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ipbSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ipbMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelUsuario.ResumeLayout(False)
        Me.panelUsuario.PerformLayout()
        CType(Me.pbImagenUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnDelivery As FontAwesome.Sharp.IconButton
    Friend WithEvents btnInsertar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnInicio As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCerarSesion As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pbLogoEmpresa As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblGeneral As Label
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents ipbSalir As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents ipbMinimizar As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents panelUsuario As Panel
    Friend WithEvents lblCargo As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents pbImagenUsuario As PictureBox
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblHora As Label
    Friend WithEvents btnModificarPrecio As FontAwesome.Sharp.IconButton
End Class
