<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ventana_Principal
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
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnSalir = New FontAwesome.Sharp.IconButton()
        Me.btnUsuario = New FontAwesome.Sharp.IconButton()
        Me.btnConfiguraciones = New FontAwesome.Sharp.IconButton()
        Me.btnEntregas = New FontAwesome.Sharp.IconButton()
        Me.btnEliminar = New FontAwesome.Sharp.IconButton()
        Me.btnModificar = New FontAwesome.Sharp.IconButton()
        Me.btnRealizar = New FontAwesome.Sharp.IconButton()
        Me.panelLogo = New System.Windows.Forms.Panel()
        Me.pcbLogoEmpresa = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ipbMinimizar = New FontAwesome.Sharp.IconPictureBox()
        Me.ipcSalir = New FontAwesome.Sharp.IconPictureBox()
        Me.iconCurrentChildForm = New FontAwesome.Sharp.IconPictureBox()
        Me.lblGeneral = New System.Windows.Forms.Label()
        Me.PanelChildForm = New System.Windows.Forms.Panel()
        Me.PanelMenu.SuspendLayout()
        Me.panelLogo.SuspendLayout()
        CType(Me.pcbLogoEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ipbMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ipcSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconCurrentChildForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btnSalir)
        Me.PanelMenu.Controls.Add(Me.btnUsuario)
        Me.PanelMenu.Controls.Add(Me.btnConfiguraciones)
        Me.PanelMenu.Controls.Add(Me.btnEntregas)
        Me.PanelMenu.Controls.Add(Me.btnEliminar)
        Me.PanelMenu.Controls.Add(Me.btnModificar)
        Me.PanelMenu.Controls.Add(Me.btnRealizar)
        Me.PanelMenu.Controls.Add(Me.panelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(197, 450)
        Me.PanelMenu.TabIndex = 0
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        Me.btnSalir.IconColor = System.Drawing.Color.White
        Me.btnSalir.IconSize = 32
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.Location = New System.Drawing.Point(149, 404)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnSalir.Rotation = 0R
        Me.btnSalir.Size = New System.Drawing.Size(45, 46)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnUsuario
        '
        Me.btnUsuario.FlatAppearance.BorderSize = 0
        Me.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuario.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.3!)
        Me.btnUsuario.ForeColor = System.Drawing.Color.White
        Me.btnUsuario.IconChar = FontAwesome.Sharp.IconChar.UserAlt
        Me.btnUsuario.IconColor = System.Drawing.Color.White
        Me.btnUsuario.IconSize = 32
        Me.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsuario.Location = New System.Drawing.Point(0, 404)
        Me.btnUsuario.Name = "btnUsuario"
        Me.btnUsuario.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnUsuario.Rotation = 0R
        Me.btnUsuario.Size = New System.Drawing.Size(143, 46)
        Me.btnUsuario.TabIndex = 7
        Me.btnUsuario.Text = "Administrador"
        Me.btnUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUsuario.UseVisualStyleBackColor = True
        '
        'btnConfiguraciones
        '
        Me.btnConfiguraciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfiguraciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConfiguraciones.FlatAppearance.BorderSize = 0
        Me.btnConfiguraciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfiguraciones.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnConfiguraciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.btnConfiguraciones.ForeColor = System.Drawing.Color.White
        Me.btnConfiguraciones.IconChar = FontAwesome.Sharp.IconChar.Cogs
        Me.btnConfiguraciones.IconColor = System.Drawing.Color.White
        Me.btnConfiguraciones.IconSize = 32
        Me.btnConfiguraciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfiguraciones.Location = New System.Drawing.Point(0, 274)
        Me.btnConfiguraciones.Name = "btnConfiguraciones"
        Me.btnConfiguraciones.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnConfiguraciones.Rotation = 0R
        Me.btnConfiguraciones.Size = New System.Drawing.Size(197, 46)
        Me.btnConfiguraciones.TabIndex = 6
        Me.btnConfiguraciones.Text = "Configuraciones"
        Me.btnConfiguraciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfiguraciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConfiguraciones.UseVisualStyleBackColor = True
        '
        'btnEntregas
        '
        Me.btnEntregas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEntregas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEntregas.FlatAppearance.BorderSize = 0
        Me.btnEntregas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEntregas.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnEntregas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.btnEntregas.ForeColor = System.Drawing.Color.White
        Me.btnEntregas.IconChar = FontAwesome.Sharp.IconChar.Truck
        Me.btnEntregas.IconColor = System.Drawing.Color.White
        Me.btnEntregas.IconSize = 32
        Me.btnEntregas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEntregas.Location = New System.Drawing.Point(0, 228)
        Me.btnEntregas.Name = "btnEntregas"
        Me.btnEntregas.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnEntregas.Rotation = 0R
        Me.btnEntregas.Size = New System.Drawing.Size(197, 46)
        Me.btnEntregas.TabIndex = 5
        Me.btnEntregas.Text = "Entregas a domicilio"
        Me.btnEntregas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEntregas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEntregas.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.CalendarTimes
        Me.btnEliminar.IconColor = System.Drawing.Color.White
        Me.btnEliminar.IconSize = 32
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(0, 182)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnEliminar.Rotation = 0R
        Me.btnEliminar.Size = New System.Drawing.Size(197, 46)
        Me.btnEliminar.TabIndex = 4
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
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.btnModificar.IconColor = System.Drawing.Color.White
        Me.btnModificar.IconSize = 32
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(0, 136)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnModificar.Rotation = 0R
        Me.btnModificar.Size = New System.Drawing.Size(197, 46)
        Me.btnModificar.TabIndex = 3
        Me.btnModificar.Text = "Modificar Reservas"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnRealizar
        '
        Me.btnRealizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRealizar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRealizar.FlatAppearance.BorderSize = 0
        Me.btnRealizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRealizar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnRealizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.btnRealizar.ForeColor = System.Drawing.Color.White
        Me.btnRealizar.IconChar = FontAwesome.Sharp.IconChar.AddressBook
        Me.btnRealizar.IconColor = System.Drawing.Color.White
        Me.btnRealizar.IconSize = 32
        Me.btnRealizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRealizar.Location = New System.Drawing.Point(0, 90)
        Me.btnRealizar.Name = "btnRealizar"
        Me.btnRealizar.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnRealizar.Rotation = 0R
        Me.btnRealizar.Size = New System.Drawing.Size(197, 46)
        Me.btnRealizar.TabIndex = 2
        Me.btnRealizar.Text = "Realizar Reservas"
        Me.btnRealizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRealizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRealizar.UseVisualStyleBackColor = True
        '
        'panelLogo
        '
        Me.panelLogo.Controls.Add(Me.pcbLogoEmpresa)
        Me.panelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelLogo.Location = New System.Drawing.Point(0, 0)
        Me.panelLogo.Name = "panelLogo"
        Me.panelLogo.Size = New System.Drawing.Size(197, 90)
        Me.panelLogo.TabIndex = 1
        '
        'pcbLogoEmpresa
        '
        Me.pcbLogoEmpresa.Image = Global.Login.My.Resources.Resources.Logo_HotelCanino
        Me.pcbLogoEmpresa.Location = New System.Drawing.Point(12, 12)
        Me.pcbLogoEmpresa.Name = "pcbLogoEmpresa"
        Me.pcbLogoEmpresa.Size = New System.Drawing.Size(169, 62)
        Me.pcbLogoEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbLogoEmpresa.TabIndex = 1
        Me.pcbLogoEmpresa.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Panel1.Controls.Add(Me.ipbMinimizar)
        Me.Panel1.Controls.Add(Me.ipcSalir)
        Me.Panel1.Controls.Add(Me.iconCurrentChildForm)
        Me.Panel1.Controls.Add(Me.lblGeneral)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(197, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(603, 44)
        Me.Panel1.TabIndex = 1
        '
        'ipbMinimizar
        '
        Me.ipbMinimizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ipbMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ipbMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.ipbMinimizar.IconColor = System.Drawing.Color.White
        Me.ipbMinimizar.Location = New System.Drawing.Point(529, 5)
        Me.ipbMinimizar.Name = "ipbMinimizar"
        Me.ipbMinimizar.Size = New System.Drawing.Size(32, 32)
        Me.ipbMinimizar.TabIndex = 5
        Me.ipbMinimizar.TabStop = False
        '
        'ipcSalir
        '
        Me.ipcSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ipcSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ipcSalir.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.ipcSalir.IconColor = System.Drawing.Color.White
        Me.ipcSalir.Location = New System.Drawing.Point(567, 9)
        Me.ipcSalir.Name = "ipcSalir"
        Me.ipcSalir.Size = New System.Drawing.Size(32, 32)
        Me.ipcSalir.TabIndex = 4
        Me.ipcSalir.TabStop = False
        '
        'iconCurrentChildForm
        '
        Me.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.iconCurrentChildForm.Location = New System.Drawing.Point(8, 9)
        Me.iconCurrentChildForm.Name = "iconCurrentChildForm"
        Me.iconCurrentChildForm.Size = New System.Drawing.Size(32, 32)
        Me.iconCurrentChildForm.TabIndex = 3
        Me.iconCurrentChildForm.TabStop = False
        '
        'lblGeneral
        '
        Me.lblGeneral.AutoSize = True
        Me.lblGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.lblGeneral.ForeColor = System.Drawing.Color.White
        Me.lblGeneral.Location = New System.Drawing.Point(46, 16)
        Me.lblGeneral.Name = "lblGeneral"
        Me.lblGeneral.Size = New System.Drawing.Size(36, 15)
        Me.lblGeneral.TabIndex = 2
        Me.lblGeneral.Text = "Inicio"
        '
        'PanelChildForm
        '
        Me.PanelChildForm.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelChildForm.Location = New System.Drawing.Point(197, 44)
        Me.PanelChildForm.Name = "PanelChildForm"
        Me.PanelChildForm.Size = New System.Drawing.Size(603, 400)
        Me.PanelChildForm.TabIndex = 2
        '
        'Ventana_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelChildForm)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Ventana_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventana_Principal"
        Me.PanelMenu.ResumeLayout(False)
        Me.panelLogo.ResumeLayout(False)
        CType(Me.pcbLogoEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ipbMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ipcSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconCurrentChildForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents panelLogo As Panel
    Friend WithEvents btnConfiguraciones As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEntregas As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEliminar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnModificar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnRealizar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnUsuario As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSalir As FontAwesome.Sharp.IconButton
    Friend WithEvents pcbLogoEmpresa As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents iconCurrentChildForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lblGeneral As Label
    Friend WithEvents PanelChildForm As Panel
    Friend WithEvents ipbMinimizar As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents ipcSalir As FontAwesome.Sharp.IconPictureBox
End Class
