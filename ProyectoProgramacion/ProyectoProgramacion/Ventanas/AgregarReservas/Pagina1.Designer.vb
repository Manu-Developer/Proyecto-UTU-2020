<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pagina1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pagina1))
        Me.ipbSiguienteFoto = New FontAwesome.Sharp.IconPictureBox()
        Me.lblDatosCliente = New System.Windows.Forms.Label()
        Me.dateSalida = New System.Windows.Forms.DateTimePicker()
        Me.lblSalida = New System.Windows.Forms.Label()
        Me.dateReservar = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.dateNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.lblReservar = New System.Windows.Forms.Label()
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
        CType(Me.ipbSiguienteFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ipbSiguienteFoto
        '
        Me.ipbSiguienteFoto.BackColor = System.Drawing.Color.White
        Me.ipbSiguienteFoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ipbSiguienteFoto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ipbSiguienteFoto.IconChar = FontAwesome.Sharp.IconChar.AngleRight
        Me.ipbSiguienteFoto.IconColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ipbSiguienteFoto.IconSize = 34
        Me.ipbSiguienteFoto.Location = New System.Drawing.Point(402, 621)
        Me.ipbSiguienteFoto.Name = "ipbSiguienteFoto"
        Me.ipbSiguienteFoto.Size = New System.Drawing.Size(38, 34)
        Me.ipbSiguienteFoto.TabIndex = 24
        Me.ipbSiguienteFoto.TabStop = False
        '
        'lblDatosCliente
        '
        Me.lblDatosCliente.AutoSize = True
        Me.lblDatosCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatosCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblDatosCliente.Location = New System.Drawing.Point(124, 9)
        Me.lblDatosCliente.Name = "lblDatosCliente"
        Me.lblDatosCliente.Size = New System.Drawing.Size(168, 24)
        Me.lblDatosCliente.TabIndex = 65
        Me.lblDatosCliente.Text = "Datos del Cliente"
        '
        'dateSalida
        '
        Me.dateSalida.Location = New System.Drawing.Point(217, 498)
        Me.dateSalida.Name = "dateSalida"
        Me.dateSalida.Size = New System.Drawing.Size(192, 20)
        Me.dateSalida.TabIndex = 83
        '
        'lblSalida
        '
        Me.lblSalida.AutoSize = True
        Me.lblSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalida.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblSalida.Location = New System.Drawing.Point(34, 499)
        Me.lblSalida.Name = "lblSalida"
        Me.lblSalida.Size = New System.Drawing.Size(121, 20)
        Me.lblSalida.TabIndex = 82
        Me.lblSalida.Text = "Fecha de salida"
        '
        'dateReservar
        '
        Me.dateReservar.Location = New System.Drawing.Point(217, 434)
        Me.dateReservar.Name = "dateReservar"
        Me.dateReservar.Size = New System.Drawing.Size(192, 20)
        Me.dateReservar.TabIndex = 81
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(39, 571)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(159, 20)
        Me.Label12.TabIndex = 80
        Me.Label12.Text = "Habitacion a reservar"
        '
        'TextBox12
        '
        Me.TextBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.TextBox12.Location = New System.Drawing.Point(222, 564)
        Me.TextBox12.Multiline = True
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(192, 29)
        Me.TextBox12.TabIndex = 79
        '
        'dateNacimiento
        '
        Me.dateNacimiento.Location = New System.Drawing.Point(217, 231)
        Me.dateNacimiento.Name = "dateNacimiento"
        Me.dateNacimiento.Size = New System.Drawing.Size(192, 20)
        Me.dateNacimiento.TabIndex = 78
        Me.dateNacimiento.TabStop = False
        '
        'lblReservar
        '
        Me.lblReservar.AutoSize = True
        Me.lblReservar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReservar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblReservar.Location = New System.Drawing.Point(34, 435)
        Me.lblReservar.Name = "lblReservar"
        Me.lblReservar.Size = New System.Drawing.Size(128, 20)
        Me.lblReservar.TabIndex = 77
        Me.lblReservar.Text = "Fecha a reservar"
        '
        'lblCelular
        '
        Me.lblCelular.AutoSize = True
        Me.lblCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCelular.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblCelular.Location = New System.Drawing.Point(34, 369)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(140, 20)
        Me.lblCelular.TabIndex = 76
        Me.lblCelular.Text = "Numero de Celular"
        '
        'txtCelular
        '
        Me.txtCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelular.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtCelular.Location = New System.Drawing.Point(217, 362)
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
        Me.lblDireccion.Location = New System.Drawing.Point(34, 303)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(75, 20)
        Me.lblDireccion.TabIndex = 74
        Me.lblDireccion.Text = "Dirección"
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtDireccion.Location = New System.Drawing.Point(217, 296)
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
        Me.lblNacimiento.Location = New System.Drawing.Point(34, 238)
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
        Me.lblApellido.Location = New System.Drawing.Point(34, 183)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(143, 20)
        Me.lblApellido.TabIndex = 71
        Me.lblApellido.Text = "Apellido del Cliente"
        '
        'txtApellido
        '
        Me.txtApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtApellido.Location = New System.Drawing.Point(217, 174)
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
        Me.lblNombre.Location = New System.Drawing.Point(34, 124)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(143, 20)
        Me.lblNombre.TabIndex = 69
        Me.lblNombre.Text = "Nombre del Cliente"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtNombre.Location = New System.Drawing.Point(217, 115)
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
        Me.lblCI.Location = New System.Drawing.Point(34, 62)
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
        'Pagina1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(452, 667)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.dateSalida)
        Me.Controls.Add(Me.lblSalida)
        Me.Controls.Add(Me.dateReservar)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.dateNacimiento)
        Me.Controls.Add(Me.lblReservar)
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
        Me.Controls.Add(Me.lblDatosCliente)
        Me.Controls.Add(Me.ipbSiguienteFoto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Pagina1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hotel Canino"
        CType(Me.ipbSiguienteFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ipbSiguienteFoto As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lblDatosCliente As Label
    Friend WithEvents dateSalida As DateTimePicker
    Friend WithEvents lblSalida As Label
    Friend WithEvents dateReservar As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents dateNacimiento As DateTimePicker
    Friend WithEvents lblReservar As Label
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
End Class
