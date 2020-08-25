<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionReservas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionReservas))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.bntAgregarReserva1 = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.image = New FontAwesome.Sharp.IconButton()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaEntrada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaSalida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Habitacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreMascota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MascotaNac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vacunas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dosis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Horario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Peso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Raza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Alimetancion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModoEntrega = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraEntrega = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModoRetiro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HorarioRetiro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeight = 27
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.Nombre, Me.Apellido, Me.Nac, Me.Telefono, Me.Direccion, Me.Precio, Me.Monto, Me.FechaEntrada, Me.FechaSalida, Me.Habitacion, Me.NombreMascota, Me.MascotaNac, Me.Vacunas, Me.Dosis, Me.Horario, Me.Peso, Me.Raza, Me.Alimetancion, Me.ModoEntrega, Me.HoraEntrega, Me.ModoRetiro, Me.HorarioRetiro})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(17, 87)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(210, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(210, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(210, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(928, 430)
        Me.DataGridView1.TabIndex = 2
        '
        'bntAgregarReserva1
        '
        Me.bntAgregarReserva1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bntAgregarReserva1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.bntAgregarReserva1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bntAgregarReserva1.FlatAppearance.BorderSize = 0
        Me.bntAgregarReserva1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bntAgregarReserva1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.bntAgregarReserva1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.bntAgregarReserva1.ForeColor = System.Drawing.Color.White
        Me.bntAgregarReserva1.IconChar = FontAwesome.Sharp.IconChar.CalendarTimes
        Me.bntAgregarReserva1.IconColor = System.Drawing.Color.White
        Me.bntAgregarReserva1.IconSize = 25
        Me.bntAgregarReserva1.Location = New System.Drawing.Point(689, 551)
        Me.bntAgregarReserva1.Name = "bntAgregarReserva1"
        Me.bntAgregarReserva1.Rotation = 0R
        Me.bntAgregarReserva1.Size = New System.Drawing.Size(174, 37)
        Me.bntAgregarReserva1.TabIndex = 7
        Me.bntAgregarReserva1.Text = "Cancelar Reserva"
        Me.bntAgregarReserva1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bntAgregarReserva1.UseVisualStyleBackColor = False
        '
        'IconButton1
        '
        Me.IconButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.IconButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.IconButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.Color.White
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.IconButton1.IconColor = System.Drawing.Color.White
        Me.IconButton1.IconSize = 25
        Me.IconButton1.Location = New System.Drawing.Point(38, 551)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Rotation = 0R
        Me.IconButton1.Size = New System.Drawing.Size(174, 37)
        Me.IconButton1.TabIndex = 8
        Me.IconButton1.Text = "Agregar Reserva"
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'IconButton2
        '
        Me.IconButton2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.IconButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.IconButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.IconButton2.ForeColor = System.Drawing.Color.White
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.IconButton2.IconColor = System.Drawing.Color.White
        Me.IconButton2.IconSize = 25
        Me.IconButton2.Location = New System.Drawing.Point(358, 551)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Rotation = 0R
        Me.IconButton2.Size = New System.Drawing.Size(174, 37)
        Me.IconButton2.TabIndex = 9
        Me.IconButton2.Text = "Modificar Reserva"
        Me.IconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'image
        '
        Me.image.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.image.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.image.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.image.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.image.IconColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.image.IconSize = 26
        Me.image.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.image.Location = New System.Drawing.Point(17, 22)
        Me.image.Name = "image"
        Me.image.Rotation = 0R
        Me.image.Size = New System.Drawing.Size(31, 32)
        Me.image.TabIndex = 10
        Me.image.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.image.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.image.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.BackColor = System.Drawing.Color.White
        Me.txtBuscar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtBuscar.Location = New System.Drawing.Point(47, 22)
        Me.txtBuscar.Multiline = True
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(654, 32)
        Me.txtBuscar.TabIndex = 11
        '
        'id
        '
        Me.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 47
        '
        'Nombre
        '
        Me.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 88
        '
        'Apellido
        '
        Me.Apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        Me.Apellido.ReadOnly = True
        Me.Apellido.Width = 90
        '
        'Nac
        '
        Me.Nac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Nac.HeaderText = "Fecha Nacimiento"
        Me.Nac.Name = "Nac"
        Me.Nac.ReadOnly = True
        Me.Nac.Width = 161
        '
        'Telefono
        '
        Me.Telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Telefono.HeaderText = "Telefono"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = True
        Me.Telefono.Width = 96
        '
        'Direccion
        '
        Me.Direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Direccion.HeaderText = "Direccion"
        Me.Direccion.Name = "Direccion"
        Me.Direccion.ReadOnly = True
        '
        'Precio
        '
        Me.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        Me.Precio.Width = 78
        '
        'Monto
        '
        Me.Monto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Monto.HeaderText = "Monto"
        Me.Monto.Name = "Monto"
        Me.Monto.ReadOnly = True
        Me.Monto.Width = 76
        '
        'FechaEntrada
        '
        Me.FechaEntrada.HeaderText = "Entrada"
        Me.FechaEntrada.Name = "FechaEntrada"
        Me.FechaEntrada.ReadOnly = True
        '
        'FechaSalida
        '
        Me.FechaSalida.HeaderText = "Salida"
        Me.FechaSalida.Name = "FechaSalida"
        Me.FechaSalida.ReadOnly = True
        '
        'Habitacion
        '
        Me.Habitacion.HeaderText = "Habitacion"
        Me.Habitacion.Name = "Habitacion"
        Me.Habitacion.ReadOnly = True
        '
        'NombreMascota
        '
        Me.NombreMascota.HeaderText = "Mascota"
        Me.NombreMascota.Name = "NombreMascota"
        Me.NombreMascota.ReadOnly = True
        '
        'MascotaNac
        '
        Me.MascotaNac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.MascotaNac.HeaderText = "Nacimiento Mascota"
        Me.MascotaNac.Name = "MascotaNac"
        Me.MascotaNac.ReadOnly = True
        Me.MascotaNac.Width = 177
        '
        'Vacunas
        '
        Me.Vacunas.HeaderText = "Vacunas"
        Me.Vacunas.Name = "Vacunas"
        Me.Vacunas.ReadOnly = True
        '
        'Dosis
        '
        Me.Dosis.HeaderText = "Dosis"
        Me.Dosis.Name = "Dosis"
        Me.Dosis.ReadOnly = True
        '
        'Horario
        '
        Me.Horario.HeaderText = "Horario"
        Me.Horario.Name = "Horario"
        Me.Horario.ReadOnly = True
        '
        'Peso
        '
        Me.Peso.HeaderText = "Peso"
        Me.Peso.Name = "Peso"
        Me.Peso.ReadOnly = True
        '
        'Raza
        '
        Me.Raza.HeaderText = "Raza"
        Me.Raza.Name = "Raza"
        Me.Raza.ReadOnly = True
        '
        'Alimetancion
        '
        Me.Alimetancion.HeaderText = "Alimetancion"
        Me.Alimetancion.Name = "Alimetancion"
        Me.Alimetancion.ReadOnly = True
        '
        'ModoEntrega
        '
        Me.ModoEntrega.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ModoEntrega.HeaderText = "Modo Entrega"
        Me.ModoEntrega.Name = "ModoEntrega"
        Me.ModoEntrega.ReadOnly = True
        Me.ModoEntrega.Width = 133
        '
        'HoraEntrega
        '
        Me.HoraEntrega.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.HoraEntrega.HeaderText = "Hora Entrega"
        Me.HoraEntrega.Name = "HoraEntrega"
        Me.HoraEntrega.ReadOnly = True
        Me.HoraEntrega.Width = 129
        '
        'ModoRetiro
        '
        Me.ModoRetiro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ModoRetiro.HeaderText = "Modo Retiro"
        Me.ModoRetiro.Name = "ModoRetiro"
        Me.ModoRetiro.ReadOnly = True
        Me.ModoRetiro.Width = 120
        '
        'HorarioRetiro
        '
        Me.HorarioRetiro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.HorarioRetiro.HeaderText = "Horario Retiro"
        Me.HorarioRetiro.Name = "HorarioRetiro"
        Me.HorarioRetiro.ReadOnly = True
        Me.HorarioRetiro.Width = 135
        '
        'GestionReservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(967, 600)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.image)
        Me.Controls.Add(Me.IconButton2)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.bntAgregarReserva1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GestionReservas"
        Me.Text = "Hotel Canino"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents bntAgregarReserva1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents image As FontAwesome.Sharp.IconButton
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Nac As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents Direccion As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Monto As DataGridViewTextBoxColumn
    Friend WithEvents FechaEntrada As DataGridViewTextBoxColumn
    Friend WithEvents FechaSalida As DataGridViewTextBoxColumn
    Friend WithEvents Habitacion As DataGridViewTextBoxColumn
    Friend WithEvents NombreMascota As DataGridViewTextBoxColumn
    Friend WithEvents MascotaNac As DataGridViewTextBoxColumn
    Friend WithEvents Vacunas As DataGridViewTextBoxColumn
    Friend WithEvents Dosis As DataGridViewTextBoxColumn
    Friend WithEvents Horario As DataGridViewTextBoxColumn
    Friend WithEvents Peso As DataGridViewTextBoxColumn
    Friend WithEvents Raza As DataGridViewTextBoxColumn
    Friend WithEvents Alimetancion As DataGridViewTextBoxColumn
    Friend WithEvents ModoEntrega As DataGridViewTextBoxColumn
    Friend WithEvents HoraEntrega As DataGridViewTextBoxColumn
    Friend WithEvents ModoRetiro As DataGridViewTextBoxColumn
    Friend WithEvents HorarioRetiro As DataGridViewTextBoxColumn
End Class
