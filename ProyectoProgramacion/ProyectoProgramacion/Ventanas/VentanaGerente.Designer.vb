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
        Me.btnModificarPrecio = New FontAwesome.Sharp.IconButton()
        Me.btnInsertar = New FontAwesome.Sharp.IconButton()
        Me.btnDelivery = New FontAwesome.Sharp.IconButton()
        Me.btnInicio = New FontAwesome.Sharp.IconButton()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnCerarSesion = New FontAwesome.Sharp.IconButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.photo = New System.Windows.Forms.PictureBox()
        Me.edit = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.nombre = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pbLogoEmpresa = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblGeneral = New System.Windows.Forms.Label()
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.ipbSalir = New FontAwesome.Sharp.IconPictureBox()
        Me.ipbMinimizar = New FontAwesome.Sharp.IconPictureBox()
        Me.PanelDesktop = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuSeparator5 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.phototrasparent = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.PanelMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PictureBox1.SuspendLayout()
        CType(Me.photo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.photo.SuspendLayout()
        CType(Me.pbLogoEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
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
        Me.PanelMenu.Controls.Add(Me.BunifuCustomLabel1)
        Me.PanelMenu.Controls.Add(Me.btnCerarSesion)
        Me.PanelMenu.Controls.Add(Me.PictureBox1)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(199, 750)
        Me.PanelMenu.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnModificarPrecio)
        Me.Panel1.Controls.Add(Me.btnInsertar)
        Me.Panel1.Controls.Add(Me.btnDelivery)
        Me.Panel1.Controls.Add(Me.btnInicio)
        Me.Panel1.Location = New System.Drawing.Point(0, 201)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(197, 284)
        Me.Panel1.TabIndex = 23
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
        Me.btnModificarPrecio.Location = New System.Drawing.Point(0, 138)
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
        Me.btnInsertar.Location = New System.Drawing.Point(0, 92)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnInsertar.Rotation = 0R
        Me.btnInsertar.Size = New System.Drawing.Size(197, 46)
        Me.btnInsertar.TabIndex = 13
        Me.btnInsertar.Text = "Gestionar Reservas"
        Me.btnInsertar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInsertar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInsertar.UseVisualStyleBackColor = True
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
        Me.btnDelivery.Location = New System.Drawing.Point(0, 46)
        Me.btnDelivery.Name = "btnDelivery"
        Me.btnDelivery.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnDelivery.Rotation = 0R
        Me.btnDelivery.Size = New System.Drawing.Size(197, 46)
        Me.btnDelivery.TabIndex = 16
        Me.btnDelivery.Text = "Reservas confirmadas"
        Me.btnDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelivery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelivery.UseVisualStyleBackColor = True
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
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(48, 158)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(115, 21)
        Me.BunifuCustomLabel1.TabIndex = 18
        Me.BunifuCustomLabel1.Text = "Nora Alejandra"
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
        Me.btnCerarSesion.Location = New System.Drawing.Point(0, 704)
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
        Me.pbLogoEmpresa.Location = New System.Drawing.Point(167, 116)
        Me.pbLogoEmpresa.Name = "pbLogoEmpresa"
        Me.pbLogoEmpresa.Size = New System.Drawing.Size(704, 475)
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
        Me.Panel3.Location = New System.Drawing.Point(199, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1045, 42)
        Me.Panel3.TabIndex = 4
        '
        'lblGeneral
        '
        Me.lblGeneral.AutoSize = True
        Me.lblGeneral.Font = New System.Drawing.Font("Verdana", 14.25!)
        Me.lblGeneral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblGeneral.Location = New System.Drawing.Point(40, 13)
        Me.lblGeneral.Name = "lblGeneral"
        Me.lblGeneral.Size = New System.Drawing.Size(60, 29)
        Me.lblGeneral.TabIndex = 6
        Me.lblGeneral.Text = "Inicio"
        Me.lblGeneral.UseCompatibleTextRendering = True
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.IconCurrentForm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconCurrentForm.IconColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
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
        Me.PanelDesktop.Controls.Add(Me.Label2)
        Me.PanelDesktop.Controls.Add(Me.Label1)
        Me.PanelDesktop.Controls.Add(Me.pbLogoEmpresa)
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.PanelDesktop.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.PanelDesktop.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.PanelDesktop.GradientTopRight = System.Drawing.Color.White
        Me.PanelDesktop.Location = New System.Drawing.Point(199, 42)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Quality = 10
        Me.PanelDesktop.Size = New System.Drawing.Size(1045, 708)
        Me.PanelDesktop.TabIndex = 9
        '
        'BunifuSeparator5
        '
        Me.BunifuSeparator5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator5.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSeparator5.LineThickness = 3
        Me.BunifuSeparator5.Location = New System.Drawing.Point(0, -42)
        Me.BunifuSeparator5.Name = "BunifuSeparator5"
        Me.BunifuSeparator5.Size = New System.Drawing.Size(16, 750)
        Me.BunifuSeparator5.TabIndex = 22
        Me.BunifuSeparator5.Transparency = 255
        Me.BunifuSeparator5.Vertical = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(323, 662)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(475, 42)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "viernes, 24 de julio de 2020"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(467, 608)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 42)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "17:43:12"
        '
        'phototrasparent
        '
        Me.phototrasparent.ElipseRadius = 175
        Me.phototrasparent.TargetControl = Me.photo
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'VentanaGerente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1244, 750)
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
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ipbSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ipbMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDesktop.ResumeLayout(False)
        Me.PanelDesktop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnDelivery As FontAwesome.Sharp.IconButton
    Friend WithEvents btnInsertar As FontAwesome.Sharp.IconButton
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
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents edit As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents photo As PictureBox
    Friend WithEvents nombre As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents phototrasparent As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuSeparator5 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Panel1 As Panel
End Class
