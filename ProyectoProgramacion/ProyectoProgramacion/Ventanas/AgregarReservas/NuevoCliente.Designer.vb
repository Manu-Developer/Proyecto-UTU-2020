<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NuevoCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NuevoCliente))
        Me.lblDatosCliente = New System.Windows.Forms.Label()
        Me.dateNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.lblCelular = New System.Windows.Forms.Label()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.lblNacimiento = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblCI = New System.Windows.Forms.Label()
        Me.txtCI = New System.Windows.Forms.TextBox()
        Me.btnSalir = New FontAwesome.Sharp.IconPictureBox()
        Me.save = New FontAwesome.Sharp.IconButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.oficinistaSalir = New FontAwesome.Sharp.IconPictureBox()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.oficinistaSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDatosCliente
        '
        Me.lblDatosCliente.AutoSize = True
        Me.lblDatosCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatosCliente.ForeColor = System.Drawing.Color.White
        Me.lblDatosCliente.Location = New System.Drawing.Point(147, 8)
        Me.lblDatosCliente.Name = "lblDatosCliente"
        Me.lblDatosCliente.Size = New System.Drawing.Size(142, 24)
        Me.lblDatosCliente.TabIndex = 65
        Me.lblDatosCliente.Text = "Nuevo Cliente"
        '
        'dateNacimiento
        '
        Me.dateNacimiento.CustomFormat = "mm/dd/yyyy"
        Me.dateNacimiento.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dateNacimiento.Location = New System.Drawing.Point(217, 182)
        Me.dateNacimiento.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dateNacimiento.Name = "dateNacimiento"
        Me.dateNacimiento.Size = New System.Drawing.Size(192, 20)
        Me.dateNacimiento.TabIndex = 78
        Me.dateNacimiento.TabStop = False
        Me.dateNacimiento.Value = New Date(2020, 8, 28, 0, 0, 0, 0)
        '
        'lblCelular
        '
        Me.lblCelular.AutoSize = True
        Me.lblCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCelular.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblCelular.Location = New System.Drawing.Point(34, 261)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(140, 20)
        Me.lblCelular.TabIndex = 76
        Me.lblCelular.Text = "Numero de Celular"
        '
        'txtCelular
        '
        Me.txtCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelular.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtCelular.Location = New System.Drawing.Point(217, 252)
        Me.txtCelular.Multiline = True
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(192, 29)
        Me.txtCelular.TabIndex = 75
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblDireccion.Location = New System.Drawing.Point(34, 226)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(75, 20)
        Me.lblDireccion.TabIndex = 74
        Me.lblDireccion.Text = "Dirección"
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtDireccion.Location = New System.Drawing.Point(217, 217)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(192, 29)
        Me.txtDireccion.TabIndex = 73
        '
        'lblNacimiento
        '
        Me.lblNacimiento.AutoSize = True
        Me.lblNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNacimiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblNacimiento.Location = New System.Drawing.Point(34, 183)
        Me.lblNacimiento.Name = "lblNacimiento"
        Me.lblNacimiento.Size = New System.Drawing.Size(159, 20)
        Me.lblNacimiento.TabIndex = 72
        Me.lblNacimiento.Text = "Fecha de Nacimiento"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblApellido.Location = New System.Drawing.Point(34, 141)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(143, 20)
        Me.lblApellido.TabIndex = 71
        Me.lblApellido.Text = "Apellido del Cliente"
        '
        'txtApellido
        '
        Me.txtApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtApellido.Location = New System.Drawing.Point(217, 132)
        Me.txtApellido.Multiline = True
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(192, 29)
        Me.txtApellido.TabIndex = 70
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblNombre.Location = New System.Drawing.Point(34, 106)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(143, 20)
        Me.lblNombre.TabIndex = 69
        Me.lblNombre.Text = "Nombre del Cliente"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtNombre.Location = New System.Drawing.Point(217, 97)
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(192, 29)
        Me.txtNombre.TabIndex = 68
        '
        'lblCI
        '
        Me.lblCI.AutoSize = True
        Me.lblCI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCI.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblCI.Location = New System.Drawing.Point(34, 71)
        Me.lblCI.Name = "lblCI"
        Me.lblCI.Size = New System.Drawing.Size(103, 20)
        Me.lblCI.TabIndex = 67
        Me.lblCI.Text = "CI del Cliente"
        '
        'txtCI
        '
        Me.txtCI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCI.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtCI.Location = New System.Drawing.Point(217, 62)
        Me.txtCI.Multiline = True
        Me.txtCI.Name = "txtCI"
        Me.txtCI.Size = New System.Drawing.Size(192, 29)
        Me.txtCI.TabIndex = 66
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackColor = System.Drawing.Color.White
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnSalir.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.btnSalir.IconColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnSalir.IconSize = 34
        Me.btnSalir.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSalir.Location = New System.Drawing.Point(420, 0)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(32, 32)
        Me.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSalir.TabIndex = 94
        Me.btnSalir.TabStop = False
        '
        'save
        '
        Me.save.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.save.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.save.FlatAppearance.BorderSize = 0
        Me.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.save.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save.ForeColor = System.Drawing.Color.White
        Me.save.IconChar = FontAwesome.Sharp.IconChar.ArrowDown
        Me.save.IconColor = System.Drawing.Color.White
        Me.save.IconSize = 25
        Me.save.Location = New System.Drawing.Point(140, 470)
        Me.save.Name = "save"
        Me.save.Rotation = 0R
        Me.save.Size = New System.Drawing.Size(174, 37)
        Me.save.TabIndex = 95
        Me.save.Text = "Guardar"
        Me.save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.save.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Panel3.Controls.Add(Me.oficinistaSalir)
        Me.Panel3.Controls.Add(Me.lblDatosCliente)
        Me.Panel3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(452, 42)
        Me.Panel3.TabIndex = 96
        '
        'oficinistaSalir
        '
        Me.oficinistaSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.oficinistaSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.oficinistaSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.oficinistaSalir.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.oficinistaSalir.IconColor = System.Drawing.Color.White
        Me.oficinistaSalir.IconSize = 34
        Me.oficinistaSalir.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.oficinistaSalir.Location = New System.Drawing.Point(415, 5)
        Me.oficinistaSalir.Name = "oficinistaSalir"
        Me.oficinistaSalir.Size = New System.Drawing.Size(32, 32)
        Me.oficinistaSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.oficinistaSalir.TabIndex = 8
        Me.oficinistaSalir.TabStop = False
        '
        'Pagina1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.ProyectoProgramacion.My.Resources.Resources.Shadow_Notificaciones
        Me.ClientSize = New System.Drawing.Size(452, 519)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.dateNacimiento)
        Me.Controls.Add(Me.lblCelular)
        Me.Controls.Add(Me.txtCelular)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.lblNacimiento)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblCI)
        Me.Controls.Add(Me.txtCI)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Pagina1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hotel Canino"
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.oficinistaSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDatosCliente As Label
    Friend WithEvents dateNacimiento As DateTimePicker
    Friend WithEvents lblCelular As Label
    Friend WithEvents txtCelular As TextBox
    Friend WithEvents lblDireccion As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents lblNacimiento As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblCI As Label
    Friend WithEvents txtCI As TextBox
    Friend WithEvents btnSalir As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents save As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents oficinistaSalir As FontAwesome.Sharp.IconPictureBox
End Class
