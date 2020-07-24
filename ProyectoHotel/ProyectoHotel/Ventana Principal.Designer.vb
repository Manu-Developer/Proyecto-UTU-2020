<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventana_Principal
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
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.ipbLogOut = New FontAwesome.Sharp.IconPictureBox()
        Me.ibUsuario = New FontAwesome.Sharp.IconButton()
        Me.btnDelivery = New FontAwesome.Sharp.IconButton()
        Me.btnEliminar = New FontAwesome.Sharp.IconButton()
        Me.btnModificar = New FontAwesome.Sharp.IconButton()
        Me.btnInsertar = New FontAwesome.Sharp.IconButton()
        Me.btnInicio = New FontAwesome.Sharp.IconButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pbLogoEmpresa = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.bntHora = New System.Windows.Forms.Timer(Me.components)
        Me.ipbMinimizar = New FontAwesome.Sharp.IconPictureBox()
        Me.ipbSalir = New FontAwesome.Sharp.IconPictureBox()
        Me.PanelMenu.SuspendLayout()
        CType(Me.ipbLogOut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.pbLogoEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDesktop.SuspendLayout()
        CType(Me.ipbMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ipbSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.ipbLogOut)
        Me.PanelMenu.Controls.Add(Me.ibUsuario)
        Me.PanelMenu.Controls.Add(Me.btnDelivery)
        Me.PanelMenu.Controls.Add(Me.btnEliminar)
        Me.PanelMenu.Controls.Add(Me.btnModificar)
        Me.PanelMenu.Controls.Add(Me.btnInsertar)
        Me.PanelMenu.Controls.Add(Me.btnInicio)
        Me.PanelMenu.Controls.Add(Me.Panel2)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(211, 450)
        Me.PanelMenu.TabIndex = 0
        '
        'ipbLogOut
        '
        Me.ipbLogOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ipbLogOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ipbLogOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        Me.ipbLogOut.IconColor = System.Drawing.Color.White
        Me.ipbLogOut.IconSize = 35
        Me.ipbLogOut.Location = New System.Drawing.Point(170, 412)
        Me.ipbLogOut.Name = "ipbLogOut"
        Me.ipbLogOut.Size = New System.Drawing.Size(38, 35)
        Me.ipbLogOut.TabIndex = 2
        Me.ipbLogOut.TabStop = False
        '
        'ibUsuario
        '
        Me.ibUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ibUsuario.FlatAppearance.BorderSize = 0
        Me.ibUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ibUsuario.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.ibUsuario.ForeColor = System.Drawing.Color.White
        Me.ibUsuario.IconChar = FontAwesome.Sharp.IconChar.User
        Me.ibUsuario.IconColor = System.Drawing.Color.White
        Me.ibUsuario.IconSize = 32
        Me.ibUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ibUsuario.Location = New System.Drawing.Point(1, 404)
        Me.ibUsuario.Name = "ibUsuario"
        Me.ibUsuario.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.ibUsuario.Rotation = 0R
        Me.ibUsuario.Size = New System.Drawing.Size(165, 46)
        Me.ibUsuario.TabIndex = 12
        Me.ibUsuario.Text = "Administrador"
        Me.ibUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ibUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ibUsuario.UseVisualStyleBackColor = True
        '
        'btnDelivery
        '
        Me.btnDelivery.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelivery.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDelivery.FlatAppearance.BorderSize = 0
        Me.btnDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelivery.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnDelivery.ForeColor = System.Drawing.Color.White
        Me.btnDelivery.IconChar = FontAwesome.Sharp.IconChar.Truck
        Me.btnDelivery.IconColor = System.Drawing.Color.White
        Me.btnDelivery.IconSize = 32
        Me.btnDelivery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelivery.Location = New System.Drawing.Point(0, 277)
        Me.btnDelivery.Name = "btnDelivery"
        Me.btnDelivery.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnDelivery.Rotation = 0R
        Me.btnDelivery.Size = New System.Drawing.Size(211, 46)
        Me.btnDelivery.TabIndex = 11
        Me.btnDelivery.Text = "Entregas a domicilio"
        Me.btnDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelivery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelivery.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.CalendarTimes
        Me.btnEliminar.IconColor = System.Drawing.Color.White
        Me.btnEliminar.IconSize = 32
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(0, 231)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnEliminar.Rotation = 0R
        Me.btnEliminar.Size = New System.Drawing.Size(211, 46)
        Me.btnEliminar.TabIndex = 10
        Me.btnEliminar.Text = "Eliminar Reservas"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.btnModificar.IconColor = System.Drawing.Color.White
        Me.btnModificar.IconSize = 32
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(0, 185)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnModificar.Rotation = 0R
        Me.btnModificar.Size = New System.Drawing.Size(211, 46)
        Me.btnModificar.TabIndex = 9
        Me.btnModificar.Text = "Modificar Reservas"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnInsertar
        '
        Me.btnInsertar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInsertar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnInsertar.FlatAppearance.BorderSize = 0
        Me.btnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsertar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnInsertar.ForeColor = System.Drawing.Color.White
        Me.btnInsertar.IconChar = FontAwesome.Sharp.IconChar.AddressBook
        Me.btnInsertar.IconColor = System.Drawing.Color.White
        Me.btnInsertar.IconSize = 32
        Me.btnInsertar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInsertar.Location = New System.Drawing.Point(0, 139)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnInsertar.Rotation = 0R
        Me.btnInsertar.Size = New System.Drawing.Size(211, 46)
        Me.btnInsertar.TabIndex = 8
        Me.btnInsertar.Text = "Insertar Reservas"
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
        Me.btnInicio.ForeColor = System.Drawing.Color.White
        Me.btnInicio.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.btnInicio.IconColor = System.Drawing.Color.White
        Me.btnInicio.IconSize = 32
        Me.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInicio.Location = New System.Drawing.Point(0, 93)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnInicio.Rotation = 0R
        Me.btnInicio.Size = New System.Drawing.Size(211, 46)
        Me.btnInicio.TabIndex = 7
        Me.btnInicio.Text = "Inicio"
        Me.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.pbLogoEmpresa)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(211, 93)
        Me.Panel2.TabIndex = 1
        '
        'pbLogoEmpresa
        '
        Me.pbLogoEmpresa.Image = Global.ProyectoHotel.My.Resources.Resources.Logo_HotelCanino
        Me.pbLogoEmpresa.Location = New System.Drawing.Point(3, 3)
        Me.pbLogoEmpresa.Name = "pbLogoEmpresa"
        Me.pbLogoEmpresa.Size = New System.Drawing.Size(205, 87)
        Me.pbLogoEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLogoEmpresa.TabIndex = 1
        Me.pbLogoEmpresa.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Panel3.Controls.Add(Me.ipbMinimizar)
        Me.Panel3.Controls.Add(Me.ipbSalir)
        Me.Panel3.Controls.Add(Me.lblFormTitle)
        Me.Panel3.Controls.Add(Me.IconCurrentForm)
        Me.Panel3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(211, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(589, 45)
        Me.Panel3.TabIndex = 2
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.ForeColor = System.Drawing.Color.White
        Me.lblFormTitle.Location = New System.Drawing.Point(54, 18)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(32, 13)
        Me.lblFormTitle.TabIndex = 1
        Me.lblFormTitle.Text = "Inicio"
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.IconCurrentForm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconCurrentForm.IconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.IconCurrentForm.IconSize = 35
        Me.IconCurrentForm.Location = New System.Drawing.Point(11, 5)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Size = New System.Drawing.Size(38, 35)
        Me.IconCurrentForm.TabIndex = 0
        Me.IconCurrentForm.TabStop = False
        '
        'PanelDesktop
        '
        Me.PanelDesktop.Controls.Add(Me.lblFecha)
        Me.PanelDesktop.Controls.Add(Me.lblHora)
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelDesktop.Location = New System.Drawing.Point(211, 45)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(589, 405)
        Me.PanelDesktop.TabIndex = 3
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.lblFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.lblFecha.Location = New System.Drawing.Point(60, 223)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(506, 46)
        Me.lblFecha.TabIndex = 1
        Me.lblFecha.Text = "viernes, 24 de julio de 2020"
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.lblHora.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.lblHora.Location = New System.Drawing.Point(152, 124)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(293, 76)
        Me.lblHora.TabIndex = 0
        Me.lblHora.Text = "00:00:00"
        '
        'bntHora
        '
        Me.bntHora.Enabled = True
        '
        'ipbMinimizar
        '
        Me.ipbMinimizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ipbMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ipbMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.ipbMinimizar.IconColor = System.Drawing.Color.White
        Me.ipbMinimizar.IconSize = 34
        Me.ipbMinimizar.Location = New System.Drawing.Point(523, 3)
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
        Me.ipbSalir.Location = New System.Drawing.Point(557, 5)
        Me.ipbSalir.Name = "ipbSalir"
        Me.ipbSalir.Size = New System.Drawing.Size(38, 34)
        Me.ipbSalir.TabIndex = 4
        Me.ipbSalir.TabStop = False
        '
        'Ventana_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PanelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Ventana_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventana_Principal"
        Me.PanelMenu.ResumeLayout(False)
        CType(Me.ipbLogOut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.pbLogoEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDesktop.ResumeLayout(False)
        Me.PanelDesktop.PerformLayout()
        CType(Me.ipbMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ipbSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pbLogoEmpresa As PictureBox
    Friend WithEvents btnDelivery As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEliminar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnModificar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnInsertar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnInicio As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents ipbLogOut As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents ibUsuario As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents lblHora As Label
    Friend WithEvents bntHora As Timer
    Friend WithEvents lblFecha As Label
    Friend WithEvents ipbMinimizar As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents ipbSalir As FontAwesome.Sharp.IconPictureBox
End Class
