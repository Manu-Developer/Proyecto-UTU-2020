<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VentanaGerente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim edit As Bunifu.Framework.UI.BunifuCustomLabel
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentanaGerente))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.flecha = New System.Windows.Forms.PictureBox()
        Me.btnModificarPrecio = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnDelivery = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnInsertar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnInicio = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuSeparator4 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuSeparator5 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuSeparator3 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.nombre = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.photo = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.linicio = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.ipbMinimizar = New FontAwesome.Sharp.IconPictureBox()
        Me.ipbSalir = New FontAwesome.Sharp.IconPictureBox()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.PanelDesktop = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.phototrasparent = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        edit = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PanelMenu.SuspendLayout()
        CType(Me.flecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PictureBox1.SuspendLayout()
        CType(Me.photo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.photo.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.ipbMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ipbSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDesktop.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'edit
        '
        edit.AutoSize = True
        edit.BackColor = System.Drawing.Color.Transparent
        edit.Font = New System.Drawing.Font("PMingLiU-ExtB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        edit.Location = New System.Drawing.Point(50, 80)
        edit.Name = "edit"
        edit.Size = New System.Drawing.Size(82, 16)
        edit.TabIndex = 2
        edit.Text = "Click aqui"
        edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        AddHandler edit.Click, AddressOf Me.edit_Click
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.BunifuFlatButton1)
        Me.PanelMenu.Controls.Add(Me.flecha)
        Me.PanelMenu.Controls.Add(Me.btnModificarPrecio)
        Me.PanelMenu.Controls.Add(Me.btnDelivery)
        Me.PanelMenu.Controls.Add(Me.btnInsertar)
        Me.PanelMenu.Controls.Add(Me.btnInicio)
        Me.PanelMenu.Controls.Add(Me.BunifuSeparator4)
        Me.PanelMenu.Controls.Add(Me.BunifuSeparator2)
        Me.PanelMenu.Controls.Add(Me.BunifuSeparator5)
        Me.PanelMenu.Controls.Add(Me.BunifuSeparator3)
        Me.PanelMenu.Controls.Add(Me.nombre)
        Me.PanelMenu.Controls.Add(Me.BunifuSeparator1)
        Me.PanelMenu.Controls.Add(Me.PictureBox1)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(233, 750)
        Me.PanelMenu.TabIndex = 2
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "Cerrar Sesion"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuFlatButton1.ForeColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = Global.ProyectoProgramacion.My.Resources.Resources.icons8_salida_52
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 60.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(19, 673)
        Me.BunifuFlatButton1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(185, 46)
        Me.BunifuFlatButton1.TabIndex = 27
        Me.BunifuFlatButton1.Text = "Cerrar Sesion"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        '
        'flecha
        '
        Me.flecha.Image = CType(resources.GetObject("flecha.Image"), System.Drawing.Image)
        Me.flecha.Location = New System.Drawing.Point(192, 302)
        Me.flecha.Name = "flecha"
        Me.flecha.Size = New System.Drawing.Size(61, 46)
        Me.flecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.flecha.TabIndex = 2
        Me.flecha.TabStop = False
        Me.flecha.Visible = False
        '
        'btnModificarPrecio
        '
        Me.btnModificarPrecio.Activecolor = System.Drawing.Color.Transparent
        Me.btnModificarPrecio.BackColor = System.Drawing.Color.Transparent
        Me.btnModificarPrecio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnModificarPrecio.BorderRadius = 0
        Me.btnModificarPrecio.ButtonText = "Modificar precio de las habitaciones"
        Me.btnModificarPrecio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificarPrecio.DisabledColor = System.Drawing.Color.Transparent
        Me.btnModificarPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnModificarPrecio.ForeColor = System.Drawing.Color.White
        Me.btnModificarPrecio.Iconcolor = System.Drawing.Color.Transparent
        Me.btnModificarPrecio.Iconimage = Global.ProyectoProgramacion.My.Resources.Resources.icons8_autobús_96
        Me.btnModificarPrecio.Iconimage_right = Nothing
        Me.btnModificarPrecio.Iconimage_right_Selected = Nothing
        Me.btnModificarPrecio.Iconimage_Selected = Nothing
        Me.btnModificarPrecio.IconMarginLeft = 0
        Me.btnModificarPrecio.IconMarginRight = 0
        Me.btnModificarPrecio.IconRightVisible = True
        Me.btnModificarPrecio.IconRightZoom = 0R
        Me.btnModificarPrecio.IconVisible = True
        Me.btnModificarPrecio.IconZoom = 60.0R
        Me.btnModificarPrecio.IsTab = False
        Me.btnModificarPrecio.Location = New System.Drawing.Point(13, 477)
        Me.btnModificarPrecio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnModificarPrecio.Name = "btnModificarPrecio"
        Me.btnModificarPrecio.Normalcolor = System.Drawing.Color.Transparent
        Me.btnModificarPrecio.OnHovercolor = System.Drawing.Color.Transparent
        Me.btnModificarPrecio.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnModificarPrecio.selected = False
        Me.btnModificarPrecio.Size = New System.Drawing.Size(206, 46)
        Me.btnModificarPrecio.TabIndex = 26
        Me.btnModificarPrecio.Text = "Modificar precio de las habitaciones"
        Me.btnModificarPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificarPrecio.Textcolor = System.Drawing.Color.White
        Me.btnModificarPrecio.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        '
        'btnDelivery
        '
        Me.btnDelivery.Activecolor = System.Drawing.Color.Transparent
        Me.btnDelivery.BackColor = System.Drawing.Color.Transparent
        Me.btnDelivery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnDelivery.BorderRadius = 0
        Me.btnDelivery.ButtonText = "Reservas confirmadas"
        Me.btnDelivery.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelivery.DisabledColor = System.Drawing.Color.Transparent
        Me.btnDelivery.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnDelivery.ForeColor = System.Drawing.Color.White
        Me.btnDelivery.Iconcolor = System.Drawing.Color.Transparent
        Me.btnDelivery.Iconimage = Global.ProyectoProgramacion.My.Resources.Resources.icons8_reserva_2_100
        Me.btnDelivery.Iconimage_right = Nothing
        Me.btnDelivery.Iconimage_right_Selected = Nothing
        Me.btnDelivery.Iconimage_Selected = Nothing
        Me.btnDelivery.IconMarginLeft = 0
        Me.btnDelivery.IconMarginRight = 0
        Me.btnDelivery.IconRightVisible = True
        Me.btnDelivery.IconRightZoom = 0R
        Me.btnDelivery.IconVisible = True
        Me.btnDelivery.IconZoom = 60.0R
        Me.btnDelivery.IsTab = False
        Me.btnDelivery.Location = New System.Drawing.Point(13, 421)
        Me.btnDelivery.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDelivery.Name = "btnDelivery"
        Me.btnDelivery.Normalcolor = System.Drawing.Color.Transparent
        Me.btnDelivery.OnHovercolor = System.Drawing.Color.Transparent
        Me.btnDelivery.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDelivery.selected = False
        Me.btnDelivery.Size = New System.Drawing.Size(206, 46)
        Me.btnDelivery.TabIndex = 25
        Me.btnDelivery.Text = "Reservas confirmadas"
        Me.btnDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelivery.Textcolor = System.Drawing.Color.White
        Me.btnDelivery.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        '
        'btnInsertar
        '
        Me.btnInsertar.Activecolor = System.Drawing.Color.Transparent
        Me.btnInsertar.BackColor = System.Drawing.Color.Transparent
        Me.btnInsertar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnInsertar.BorderRadius = 0
        Me.btnInsertar.ButtonText = "Gestionar Reservas"
        Me.btnInsertar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInsertar.DisabledColor = System.Drawing.Color.Transparent
        Me.btnInsertar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnInsertar.ForeColor = System.Drawing.Color.White
        Me.btnInsertar.Iconcolor = System.Drawing.Color.Transparent
        Me.btnInsertar.Iconimage = Global.ProyectoProgramacion.My.Resources.Resources.icons8_reserva_2_96
        Me.btnInsertar.Iconimage_right = Nothing
        Me.btnInsertar.Iconimage_right_Selected = Nothing
        Me.btnInsertar.Iconimage_Selected = Nothing
        Me.btnInsertar.IconMarginLeft = 0
        Me.btnInsertar.IconMarginRight = 0
        Me.btnInsertar.IconRightVisible = True
        Me.btnInsertar.IconRightZoom = 0R
        Me.btnInsertar.IconVisible = True
        Me.btnInsertar.IconZoom = 60.0R
        Me.btnInsertar.IsTab = False
        Me.btnInsertar.Location = New System.Drawing.Point(13, 365)
        Me.btnInsertar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Normalcolor = System.Drawing.Color.Transparent
        Me.btnInsertar.OnHovercolor = System.Drawing.Color.Transparent
        Me.btnInsertar.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnInsertar.selected = False
        Me.btnInsertar.Size = New System.Drawing.Size(206, 46)
        Me.btnInsertar.TabIndex = 24
        Me.btnInsertar.Text = "Gestionar Reservas"
        Me.btnInsertar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInsertar.Textcolor = System.Drawing.Color.White
        Me.btnInsertar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        '
        'btnInicio
        '
        Me.btnInicio.Activecolor = System.Drawing.Color.Transparent
        Me.btnInicio.BackColor = System.Drawing.Color.Transparent
        Me.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnInicio.BorderRadius = 0
        Me.btnInicio.ButtonText = "Inicio"
        Me.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInicio.DisabledColor = System.Drawing.Color.Transparent
        Me.btnInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnInicio.ForeColor = System.Drawing.Color.White
        Me.btnInicio.Iconcolor = System.Drawing.Color.Transparent
        Me.btnInicio.Iconimage = Global.ProyectoProgramacion.My.Resources.Resources.icons8_casa_208
        Me.btnInicio.Iconimage_right = Nothing
        Me.btnInicio.Iconimage_right_Selected = Nothing
        Me.btnInicio.Iconimage_Selected = Nothing
        Me.btnInicio.IconMarginLeft = 0
        Me.btnInicio.IconMarginRight = 0
        Me.btnInicio.IconRightVisible = True
        Me.btnInicio.IconRightZoom = 0R
        Me.btnInicio.IconVisible = True
        Me.btnInicio.IconZoom = 60.0R
        Me.btnInicio.IsTab = False
        Me.btnInicio.Location = New System.Drawing.Point(13, 303)
        Me.btnInicio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Normalcolor = System.Drawing.Color.Transparent
        Me.btnInicio.OnHovercolor = System.Drawing.Color.Transparent
        Me.btnInicio.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnInicio.selected = False
        Me.btnInicio.Size = New System.Drawing.Size(206, 46)
        Me.btnInicio.TabIndex = 2
        Me.btnInicio.Text = "Inicio"
        Me.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInicio.Textcolor = System.Drawing.Color.White
        Me.btnInicio.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        '
        'BunifuSeparator4
        '
        Me.BunifuSeparator4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSeparator4.LineThickness = 2
        Me.BunifuSeparator4.Location = New System.Drawing.Point(13, 267)
        Me.BunifuSeparator4.Name = "BunifuSeparator4"
        Me.BunifuSeparator4.Size = New System.Drawing.Size(205, 35)
        Me.BunifuSeparator4.TabIndex = 23
        Me.BunifuSeparator4.Transparency = 255
        Me.BunifuSeparator4.Vertical = False
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 1
        Me.BunifuSeparator2.Location = New System.Drawing.Point(13, 710)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(205, 37)
        Me.BunifuSeparator2.TabIndex = 22
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'BunifuSeparator5
        '
        Me.BunifuSeparator5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator5.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSeparator5.LineThickness = 1
        Me.BunifuSeparator5.Location = New System.Drawing.Point(211, 21)
        Me.BunifuSeparator5.Name = "BunifuSeparator5"
        Me.BunifuSeparator5.Size = New System.Drawing.Size(14, 708)
        Me.BunifuSeparator5.TabIndex = 21
        Me.BunifuSeparator5.Transparency = 255
        Me.BunifuSeparator5.Vertical = True
        '
        'BunifuSeparator3
        '
        Me.BunifuSeparator3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSeparator3.LineThickness = 1
        Me.BunifuSeparator3.Location = New System.Drawing.Point(3, 21)
        Me.BunifuSeparator3.Name = "BunifuSeparator3"
        Me.BunifuSeparator3.Size = New System.Drawing.Size(18, 708)
        Me.BunifuSeparator3.TabIndex = 19
        Me.BunifuSeparator3.Transparency = 255
        Me.BunifuSeparator3.Vertical = True
        '
        'nombre
        '
        Me.nombre.AutoSize = True
        Me.nombre.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre.ForeColor = System.Drawing.Color.White
        Me.nombre.Location = New System.Drawing.Point(59, 244)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(115, 21)
        Me.nombre.TabIndex = 2
        Me.nombre.Text = "Nora Alejandra"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(12, 2)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(207, 35)
        Me.BunifuSeparator1.TabIndex = 2
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Controls.Add(Me.photo)
        Me.PictureBox1.Image = Global.ProyectoProgramacion.My.Resources.Resources.imagenPrueba2
        Me.PictureBox1.Location = New System.Drawing.Point(26, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(178, 181)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'photo
        '
        Me.photo.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.photo.Controls.Add(edit)
        Me.photo.Location = New System.Drawing.Point(0, 0)
        Me.photo.Name = "photo"
        Me.photo.Size = New System.Drawing.Size(178, 181)
        Me.photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.photo.TabIndex = 3
        Me.photo.TabStop = False
        Me.photo.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Panel3.Controls.Add(Me.linicio)
        Me.Panel3.Controls.Add(Me.ipbMinimizar)
        Me.Panel3.Controls.Add(Me.ipbSalir)
        Me.Panel3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(233, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1011, 47)
        Me.Panel3.TabIndex = 4
        '
        'linicio
        '
        Me.linicio.AutoSize = True
        Me.linicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.linicio.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.linicio.Location = New System.Drawing.Point(16, 13)
        Me.linicio.Name = "linicio"
        Me.linicio.Size = New System.Drawing.Size(64, 23)
        Me.linicio.TabIndex = 27
        Me.linicio.Text = "Inicio"
        '
        'ipbMinimizar
        '
        Me.ipbMinimizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ipbMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ipbMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.ipbMinimizar.IconColor = System.Drawing.Color.White
        Me.ipbMinimizar.IconSize = 34
        Me.ipbMinimizar.Location = New System.Drawing.Point(940, 5)
        Me.ipbMinimizar.Name = "ipbMinimizar"
        Me.ipbMinimizar.Size = New System.Drawing.Size(38, 34)
        Me.ipbMinimizar.TabIndex = 5
        Me.ipbMinimizar.TabStop = False
        '
        'ipbSalir
        '
        Me.ipbSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ipbSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ipbSalir.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.ipbSalir.IconColor = System.Drawing.Color.White
        Me.ipbSalir.IconSize = 34
        Me.ipbSalir.Location = New System.Drawing.Point(972, 5)
        Me.ipbSalir.Name = "ipbSalir"
        Me.ipbSalir.Size = New System.Drawing.Size(38, 34)
        Me.ipbSalir.TabIndex = 4
        Me.ipbSalir.TabStop = False
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.Color.Transparent
        Me.PanelDesktop.BackgroundImage = CType(resources.GetObject("PanelDesktop.BackgroundImage"), System.Drawing.Image)
        Me.PanelDesktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelDesktop.Controls.Add(Me.PictureBox2)
        Me.PanelDesktop.Controls.Add(Me.lblHora)
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.PanelDesktop.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.PanelDesktop.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.PanelDesktop.GradientTopRight = System.Drawing.Color.White
        Me.PanelDesktop.Location = New System.Drawing.Point(233, 47)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Quality = 10
        Me.PanelDesktop.Size = New System.Drawing.Size(1011, 703)
        Me.PanelDesktop.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.ProyectoProgramacion.My.Resources.Resources.Logo_HotelCanino
        Me.PictureBox2.Location = New System.Drawing.Point(173, 154)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(657, 335)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.BackColor = System.Drawing.Color.Transparent
        Me.lblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.ForeColor = System.Drawing.Color.White
        Me.lblHora.Location = New System.Drawing.Point(418, 646)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(212, 55)
        Me.lblHora.TabIndex = 0
        Me.lblHora.Text = "17:43:12"
        '
        'phototrasparent
        '
        Me.phototrasparent.ElipseRadius = 175
        Me.phototrasparent.TargetControl = Me.photo
        '
        'VentanaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1244, 750)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PanelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VentanaPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VentanaPrincipal"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenu.PerformLayout()
        CType(Me.flecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PictureBox1.ResumeLayout(False)
        CType(Me.photo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.photo.ResumeLayout(False)
        Me.photo.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.ipbMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ipbSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDesktop.ResumeLayout(False)
        Me.PanelDesktop.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ipbSalir As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents ipbMinimizar As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lblHora As Label
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuSeparator5 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuSeparator3 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents nombre As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PanelDesktop As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents flecha As PictureBox
    Friend WithEvents btnInicio As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnModificarPrecio As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnDelivery As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnInsertar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents linicio As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuSeparator4 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents photo As PictureBox
    Friend WithEvents phototrasparent As Bunifu.Framework.UI.BunifuElipse
End Class
