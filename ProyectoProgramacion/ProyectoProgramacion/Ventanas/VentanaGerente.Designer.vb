<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaGerente
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentanaGerente))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnReservas = New FontAwesome.Sharp.IconButton()
        Me.btnModificarPrecio = New FontAwesome.Sharp.IconButton()
        Me.btnGestion = New FontAwesome.Sharp.IconButton()
        Me.btnInicio = New FontAwesome.Sharp.IconButton()
        Me.txtNombreUsuario = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnCerarSesion = New FontAwesome.Sharp.IconButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.photo = New System.Windows.Forms.PictureBox()
        Me.edit = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.nombre = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pbLogoEmpresa = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.gerenteSalir = New FontAwesome.Sharp.IconPictureBox()
        Me.gerenteMinimizar = New FontAwesome.Sharp.IconPictureBox()
        Me.lblGeneral = New System.Windows.Forms.Label()
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.ipbSalir = New FontAwesome.Sharp.IconPictureBox()
        Me.ipbMinimizar = New FontAwesome.Sharp.IconPictureBox()
        Me.PanelDesktop = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuSeparator5 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.lblhora = New System.Windows.Forms.Label()
        Me.phototrasparent = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.horayfecha = New System.Windows.Forms.Timer(Me.components)
        Me.PanelMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PictureBox1.SuspendLayout()
        CType(Me.photo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.photo.SuspendLayout()
        CType(Me.pbLogoEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.gerenteSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gerenteMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ipbSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ipbMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDesktop.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.Panel1)
        Me.PanelMenu.Controls.Add(Me.txtNombreUsuario)
        Me.PanelMenu.Controls.Add(Me.btnCerarSesion)
        Me.PanelMenu.Controls.Add(Me.PictureBox1)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(199, 590)
        Me.PanelMenu.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnReservas)
        Me.Panel1.Controls.Add(Me.btnModificarPrecio)
        Me.Panel1.Controls.Add(Me.btnGestion)
        Me.Panel1.Controls.Add(Me.btnInicio)
        Me.Panel1.Location = New System.Drawing.Point(0, 201)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(197, 284)
        Me.Panel1.TabIndex = 23
        '
        'btnReservas
        '
        Me.btnReservas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReservas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReservas.FlatAppearance.BorderSize = 0
        Me.btnReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReservas.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnReservas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservas.ForeColor = System.Drawing.Color.White
        Me.btnReservas.IconChar = FontAwesome.Sharp.IconChar.Truck
        Me.btnReservas.IconColor = System.Drawing.Color.White
        Me.btnReservas.IconSize = 32
        Me.btnReservas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReservas.Location = New System.Drawing.Point(0, 138)
        Me.btnReservas.Name = "btnReservas"
        Me.btnReservas.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnReservas.Rotation = 0R
        Me.btnReservas.Size = New System.Drawing.Size(197, 46)
        Me.btnReservas.TabIndex = 18
        Me.btnReservas.Text = "Reservas confirmadas"
        Me.btnReservas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReservas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReservas.UseVisualStyleBackColor = True
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
        Me.btnModificarPrecio.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.btnModificarPrecio.IconColor = System.Drawing.Color.White
        Me.btnModificarPrecio.IconSize = 32
        Me.btnModificarPrecio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificarPrecio.Location = New System.Drawing.Point(0, 92)
        Me.btnModificarPrecio.Name = "btnModificarPrecio"
        Me.btnModificarPrecio.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnModificarPrecio.Rotation = 0R
        Me.btnModificarPrecio.Size = New System.Drawing.Size(197, 46)
        Me.btnModificarPrecio.TabIndex = 17
        Me.btnModificarPrecio.Text = "Modificar precio de las habitaciones"
        Me.btnModificarPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificarPrecio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnModificarPrecio.UseVisualStyleBackColor = True
        '
        'btnGestion
        '
        Me.btnGestion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGestion.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnGestion.FlatAppearance.BorderSize = 0
        Me.btnGestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGestion.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnGestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGestion.ForeColor = System.Drawing.Color.White
        Me.btnGestion.IconChar = FontAwesome.Sharp.IconChar.AddressBook
        Me.btnGestion.IconColor = System.Drawing.Color.White
        Me.btnGestion.IconSize = 32
        Me.btnGestion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGestion.Location = New System.Drawing.Point(0, 46)
        Me.btnGestion.Name = "btnGestion"
        Me.btnGestion.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnGestion.Rotation = 0R
        Me.btnGestion.Size = New System.Drawing.Size(197, 46)
        Me.btnGestion.TabIndex = 13
        Me.btnGestion.Text = "Gestionar Reservas"
        Me.btnGestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGestion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGestion.UseVisualStyleBackColor = True
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
        Me.btnInicio.Location = New System.Drawing.Point(0, 0)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnInicio.Rotation = 0R
        Me.btnInicio.Size = New System.Drawing.Size(197, 46)
        Me.btnInicio.TabIndex = 7
        Me.btnInicio.Text = "Inicio"
        Me.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.AutoSize = True
        Me.txtNombreUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreUsuario.ForeColor = System.Drawing.Color.White
        Me.txtNombreUsuario.Location = New System.Drawing.Point(36, 158)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.Size = New System.Drawing.Size(128, 20)
        Me.txtNombreUsuario.TabIndex = 18
        Me.txtNombreUsuario.Text = "Nora Alejandra"
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
        Me.btnCerarSesion.Location = New System.Drawing.Point(0, 544)
        Me.btnCerarSesion.Name = "btnCerarSesion"
        Me.btnCerarSesion.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnCerarSesion.Rotation = 0R
        Me.btnCerarSesion.Size = New System.Drawing.Size(199, 46)
        Me.btnCerarSesion.TabIndex = 12
        Me.btnCerarSesion.Text = "Cerrar Sesion"
        Me.btnCerarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCerarSesion.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Controls.Add(Me.photo)
        Me.PictureBox1.Image = Global.ProyectoProgramacion.My.Resources.Resources.imagenPrueba2
        Me.PictureBox1.Location = New System.Drawing.Point(31, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(142, 132)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'photo
        '
        Me.photo.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.photo.Controls.Add(Me.edit)
        Me.photo.Location = New System.Drawing.Point(0, 0)
        Me.photo.Name = "photo"
        Me.photo.Size = New System.Drawing.Size(143, 134)
        Me.photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.photo.TabIndex = 3
        Me.photo.TabStop = False
        Me.photo.Visible = False
        '
        'edit
        '
        Me.edit.AutoSize = True
        Me.edit.BackColor = System.Drawing.Color.Transparent
        Me.edit.Font = New System.Drawing.Font("PMingLiU-ExtB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit.Location = New System.Drawing.Point(29, 55)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(82, 16)
        Me.edit.TabIndex = 2
        Me.edit.Text = "Click aqui"
        Me.edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nombre
        '
        Me.nombre.AutoSize = True
        Me.nombre.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre.ForeColor = System.Drawing.Color.White
        Me.nombre.Location = New System.Drawing.Point(45, 149)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(115, 21)
        Me.nombre.TabIndex = 13
        Me.nombre.Text = "Nora Alejandra"
        '
        'pbLogoEmpresa
        '
        Me.pbLogoEmpresa.BackColor = System.Drawing.Color.Transparent
        Me.pbLogoEmpresa.Image = Global.ProyectoProgramacion.My.Resources.Resources.Logo_HotelCanino
        Me.pbLogoEmpresa.Location = New System.Drawing.Point(163, 78)
        Me.pbLogoEmpresa.Name = "pbLogoEmpresa"
        Me.pbLogoEmpresa.Size = New System.Drawing.Size(505, 313)
        Me.pbLogoEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLogoEmpresa.TabIndex = 1
        Me.pbLogoEmpresa.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Panel3.Controls.Add(Me.gerenteSalir)
        Me.Panel3.Controls.Add(Me.gerenteMinimizar)
        Me.Panel3.Controls.Add(Me.lblGeneral)
        Me.Panel3.Controls.Add(Me.IconCurrentForm)
        Me.Panel3.Controls.Add(Me.ipbSalir)
        Me.Panel3.Controls.Add(Me.ipbMinimizar)
        Me.Panel3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(199, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(860, 42)
        Me.Panel3.TabIndex = 4
        '
        'gerenteSalir
        '
        Me.gerenteSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.gerenteSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gerenteSalir.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.gerenteSalir.IconColor = System.Drawing.Color.White
        Me.gerenteSalir.IconSize = 34
        Me.gerenteSalir.Location = New System.Drawing.Point(825, 5)
        Me.gerenteSalir.Name = "gerenteSalir"
        Me.gerenteSalir.Size = New System.Drawing.Size(32, 32)
        Me.gerenteSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.gerenteSalir.TabIndex = 8
        Me.gerenteSalir.TabStop = False
        '
        'gerenteMinimizar
        '
        Me.gerenteMinimizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.gerenteMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gerenteMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.gerenteMinimizar.IconColor = System.Drawing.Color.White
        Me.gerenteMinimizar.IconSize = 34
        Me.gerenteMinimizar.Location = New System.Drawing.Point(797, 4)
        Me.gerenteMinimizar.Name = "gerenteMinimizar"
        Me.gerenteMinimizar.Size = New System.Drawing.Size(32, 32)
        Me.gerenteMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.gerenteMinimizar.TabIndex = 7
        Me.gerenteMinimizar.TabStop = False
        '
        'lblGeneral
        '
        Me.lblGeneral.AutoSize = True
        Me.lblGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGeneral.ForeColor = System.Drawing.Color.White
        Me.lblGeneral.Location = New System.Drawing.Point(42, 13)
        Me.lblGeneral.Name = "lblGeneral"
        Me.lblGeneral.Size = New System.Drawing.Size(44, 22)
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
        Me.ipbSalir.Location = New System.Drawing.Point(1005, 5)
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
        Me.ipbMinimizar.Location = New System.Drawing.Point(969, 5)
        Me.ipbMinimizar.Name = "ipbMinimizar"
        Me.ipbMinimizar.Size = New System.Drawing.Size(38, 34)
        Me.ipbMinimizar.TabIndex = 5
        Me.ipbMinimizar.TabStop = False
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackgroundImage = CType(resources.GetObject("PanelDesktop.BackgroundImage"), System.Drawing.Image)
        Me.PanelDesktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelDesktop.Controls.Add(Me.BunifuSeparator5)
        Me.PanelDesktop.Controls.Add(Me.lblfecha)
        Me.PanelDesktop.Controls.Add(Me.lblhora)
        Me.PanelDesktop.Controls.Add(Me.pbLogoEmpresa)
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.PanelDesktop.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.PanelDesktop.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.PanelDesktop.GradientTopRight = System.Drawing.Color.White
        Me.PanelDesktop.Location = New System.Drawing.Point(199, 42)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Quality = 10
        Me.PanelDesktop.Size = New System.Drawing.Size(860, 548)
        Me.PanelDesktop.TabIndex = 9
        '
        'BunifuSeparator5
        '
        Me.BunifuSeparator5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator5.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSeparator5.LineThickness = 3
        Me.BunifuSeparator5.Location = New System.Drawing.Point(-7, -42)
        Me.BunifuSeparator5.Name = "BunifuSeparator5"
        Me.BunifuSeparator5.Size = New System.Drawing.Size(16, 750)
        Me.BunifuSeparator5.TabIndex = 22
        Me.BunifuSeparator5.Transparency = 255
        Me.BunifuSeparator5.Vertical = True
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.BackColor = System.Drawing.Color.Transparent
        Me.lblfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfecha.ForeColor = System.Drawing.Color.White
        Me.lblfecha.Location = New System.Drawing.Point(254, 486)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(371, 33)
        Me.lblfecha.TabIndex = 11
        Me.lblfecha.Text = "viernes, 24 de julio de 2020"
        '
        'lblhora
        '
        Me.lblhora.AutoSize = True
        Me.lblhora.BackColor = System.Drawing.Color.Transparent
        Me.lblhora.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhora.ForeColor = System.Drawing.Color.White
        Me.lblhora.Location = New System.Drawing.Point(377, 423)
        Me.lblhora.Name = "lblhora"
        Me.lblhora.Size = New System.Drawing.Size(127, 33)
        Me.lblhora.TabIndex = 10
        Me.lblhora.Text = "17:43:12"
        '
        'phototrasparent
        '
        Me.phototrasparent.ElipseRadius = 175
        Me.phototrasparent.TargetControl = Me.photo
        '
        'horayfecha
        '
        Me.horayfecha.Enabled = True
        '
        'VentanaGerente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 590)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PanelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VentanaGerente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VentanaPrincipal"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenu.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PictureBox1.ResumeLayout(False)
        CType(Me.photo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.photo.ResumeLayout(False)
        Me.photo.PerformLayout()
        CType(Me.pbLogoEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.gerenteSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gerenteMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ipbSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ipbMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDesktop.ResumeLayout(False)
        Me.PanelDesktop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnGestion As FontAwesome.Sharp.IconButton
    Friend WithEvents btnInicio As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCerarSesion As FontAwesome.Sharp.IconButton
    Friend WithEvents pbLogoEmpresa As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblGeneral As Label
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents ipbSalir As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents ipbMinimizar As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnModificarPrecio As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelDesktop As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents edit As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents photo As PictureBox
    Friend WithEvents nombre As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents phototrasparent As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents txtNombreUsuario As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuSeparator5 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblfecha As Label
    Friend WithEvents lblhora As Label
    Friend WithEvents btnReservas As FontAwesome.Sharp.IconButton
    Friend WithEvents horayfecha As Timer
    Friend WithEvents gerenteMinimizar As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents gerenteSalir As FontAwesome.Sharp.IconPictureBox
End Class