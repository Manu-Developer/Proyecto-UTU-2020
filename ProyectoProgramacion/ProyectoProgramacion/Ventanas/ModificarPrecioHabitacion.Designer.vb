<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModificarPrecioHabitacion
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
        Me.txtIdHabitacion = New System.Windows.Forms.TextBox()
        Me.lblHabitacion = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.ipbAnteriorFoto = New FontAwesome.Sharp.IconPictureBox()
        Me.ipbSiguienteFoto = New FontAwesome.Sharp.IconPictureBox()
        Me.ptbImagen = New System.Windows.Forms.PictureBox()
        CType(Me.ipbAnteriorFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ipbSiguienteFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtIdHabitacion
        '
        Me.txtIdHabitacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdHabitacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtIdHabitacion.Location = New System.Drawing.Point(215, 34)
        Me.txtIdHabitacion.Multiline = True
        Me.txtIdHabitacion.Name = "txtIdHabitacion"
        Me.txtIdHabitacion.Size = New System.Drawing.Size(192, 29)
        Me.txtIdHabitacion.TabIndex = 0
        '
        'lblHabitacion
        '
        Me.lblHabitacion.AutoSize = True
        Me.lblHabitacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHabitacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblHabitacion.Location = New System.Drawing.Point(33, 34)
        Me.lblHabitacion.Name = "lblHabitacion"
        Me.lblHabitacion.Size = New System.Drawing.Size(106, 20)
        Me.lblHabitacion.TabIndex = 10
        Me.lblHabitacion.Text = "ID Habitacion"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblNombre.Location = New System.Drawing.Point(33, 100)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(145, 20)
        Me.lblNombre.TabIndex = 12
        Me.lblNombre.Text = "Nombre Habitacion"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtNombre.Location = New System.Drawing.Point(215, 91)
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(192, 29)
        Me.txtNombre.TabIndex = 11
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblPrecio.Location = New System.Drawing.Point(33, 159)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(133, 20)
        Me.lblPrecio.TabIndex = 14
        Me.lblPrecio.Text = "Precio Habitacion"
        '
        'txtPrecio
        '
        Me.txtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtPrecio.Location = New System.Drawing.Point(215, 150)
        Me.txtPrecio.Multiline = True
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(192, 29)
        Me.txtPrecio.TabIndex = 13
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblCantidad.Location = New System.Drawing.Point(33, 214)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(182, 20)
        Me.lblCantidad.TabIndex = 22
        Me.lblCantidad.Text = "Cantidad max. de Perros"
        '
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtCantidad.Location = New System.Drawing.Point(215, 208)
        Me.txtCantidad.Multiline = True
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(192, 29)
        Me.txtCantidad.TabIndex = 21
        '
        'ipbAnteriorFoto
        '
        Me.ipbAnteriorFoto.BackColor = System.Drawing.SystemColors.Control
        Me.ipbAnteriorFoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ipbAnteriorFoto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ipbAnteriorFoto.IconChar = FontAwesome.Sharp.IconChar.AngleLeft
        Me.ipbAnteriorFoto.IconColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ipbAnteriorFoto.IconSize = 34
        Me.ipbAnteriorFoto.Location = New System.Drawing.Point(36, 463)
        Me.ipbAnteriorFoto.Name = "ipbAnteriorFoto"
        Me.ipbAnteriorFoto.Size = New System.Drawing.Size(38, 34)
        Me.ipbAnteriorFoto.TabIndex = 20
        Me.ipbAnteriorFoto.TabStop = False
        '
        'ipbSiguienteFoto
        '
        Me.ipbSiguienteFoto.BackColor = System.Drawing.SystemColors.Control
        Me.ipbSiguienteFoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ipbSiguienteFoto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ipbSiguienteFoto.IconChar = FontAwesome.Sharp.IconChar.AngleRight
        Me.ipbSiguienteFoto.IconColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ipbSiguienteFoto.IconSize = 34
        Me.ipbSiguienteFoto.Location = New System.Drawing.Point(369, 463)
        Me.ipbSiguienteFoto.Name = "ipbSiguienteFoto"
        Me.ipbSiguienteFoto.Size = New System.Drawing.Size(38, 34)
        Me.ipbSiguienteFoto.TabIndex = 18
        Me.ipbSiguienteFoto.TabStop = False
        '
        'ptbImagen
        '
        Me.ptbImagen.Image = Global.ProyectoProgramacion.My.Resources.Resources.instalaciones6
        Me.ptbImagen.Location = New System.Drawing.Point(36, 266)
        Me.ptbImagen.Name = "ptbImagen"
        Me.ptbImagen.Size = New System.Drawing.Size(371, 197)
        Me.ptbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbImagen.TabIndex = 15
        Me.ptbImagen.TabStop = False
        '
        'ModificarPrecioHabitacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 512)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.ipbAnteriorFoto)
        Me.Controls.Add(Me.ipbSiguienteFoto)
        Me.Controls.Add(Me.ptbImagen)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblHabitacion)
        Me.Controls.Add(Me.txtIdHabitacion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ModificarPrecioHabitacion"
        Me.Text = "ModificarPrecioHabitacion"
        CType(Me.ipbAnteriorFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ipbSiguienteFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtIdHabitacion As TextBox
    Friend WithEvents lblHabitacion As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblPrecio As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents ptbImagen As PictureBox
    Friend WithEvents ipbSiguienteFoto As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents ipbAnteriorFoto As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lblCantidad As Label
    Friend WithEvents txtCantidad As TextBox
End Class
