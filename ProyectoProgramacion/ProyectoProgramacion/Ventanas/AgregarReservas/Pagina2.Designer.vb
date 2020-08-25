<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pagina2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pagina2))
        Me.ipbAnteriorFoto = New FontAwesome.Sharp.IconPictureBox()
        Me.ipbSiguienteFoto = New FontAwesome.Sharp.IconPictureBox()
        Me.lblDatosMascota = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.lblRaza = New System.Windows.Forms.Label()
        Me.txtRaza = New System.Windows.Forms.TextBox()
        Me.lblPeso = New System.Windows.Forms.Label()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.lblMedicina = New System.Windows.Forms.Label()
        Me.txtMedicina = New System.Windows.Forms.TextBox()
        Me.lblDosis = New System.Windows.Forms.Label()
        Me.txtDosis = New System.Windows.Forms.TextBox()
        Me.lblMedicamentos = New System.Windows.Forms.Label()
        Me.txtMedicamentos = New System.Windows.Forms.TextBox()
        Me.lblVacunas = New System.Windows.Forms.Label()
        Me.txtVacunas = New System.Windows.Forms.TextBox()
        Me.lblNacimiento = New System.Windows.Forms.Label()
        Me.txtNacimiento = New System.Windows.Forms.TextBox()
        Me.lblNombreMascota = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnSalir = New FontAwesome.Sharp.IconPictureBox()
        CType(Me.ipbAnteriorFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ipbSiguienteFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ipbAnteriorFoto
        '
        Me.ipbAnteriorFoto.BackColor = System.Drawing.Color.White
        Me.ipbAnteriorFoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ipbAnteriorFoto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ipbAnteriorFoto.IconChar = FontAwesome.Sharp.IconChar.AngleLeft
        Me.ipbAnteriorFoto.IconColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ipbAnteriorFoto.IconSize = 34
        Me.ipbAnteriorFoto.Location = New System.Drawing.Point(12, 621)
        Me.ipbAnteriorFoto.Name = "ipbAnteriorFoto"
        Me.ipbAnteriorFoto.Size = New System.Drawing.Size(38, 34)
        Me.ipbAnteriorFoto.TabIndex = 24
        Me.ipbAnteriorFoto.TabStop = False
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
        Me.ipbSiguienteFoto.TabIndex = 23
        Me.ipbSiguienteFoto.TabStop = False
        '
        'lblDatosMascota
        '
        Me.lblDatosMascota.AutoSize = True
        Me.lblDatosMascota.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatosMascota.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblDatosMascota.Location = New System.Drawing.Point(124, 9)
        Me.lblDatosMascota.Name = "lblDatosMascota"
        Me.lblDatosMascota.Size = New System.Drawing.Size(175, 24)
        Me.lblDatosMascota.TabIndex = 66
        Me.lblDatosMascota.Text = "Datos de Mascota"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(35, 558)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(163, 20)
        Me.Label21.TabIndex = 91
        Me.Label21.Text = "Alimentación Habitual"
        '
        'TextBox15
        '
        Me.TextBox15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.TextBox15.Location = New System.Drawing.Point(218, 551)
        Me.TextBox15.Multiline = True
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(192, 29)
        Me.TextBox15.TabIndex = 90
        '
        'lblRaza
        '
        Me.lblRaza.AutoSize = True
        Me.lblRaza.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRaza.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblRaza.Location = New System.Drawing.Point(33, 498)
        Me.lblRaza.Name = "lblRaza"
        Me.lblRaza.Size = New System.Drawing.Size(47, 20)
        Me.lblRaza.TabIndex = 89
        Me.lblRaza.Text = "Raza"
        '
        'txtRaza
        '
        Me.txtRaza.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRaza.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtRaza.Location = New System.Drawing.Point(216, 491)
        Me.txtRaza.Multiline = True
        Me.txtRaza.Name = "txtRaza"
        Me.txtRaza.Size = New System.Drawing.Size(192, 29)
        Me.txtRaza.TabIndex = 88
        '
        'lblPeso
        '
        Me.lblPeso.AutoSize = True
        Me.lblPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblPeso.Location = New System.Drawing.Point(33, 434)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(45, 20)
        Me.lblPeso.TabIndex = 87
        Me.lblPeso.Text = "Peso"
        '
        'txtPeso
        '
        Me.txtPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtPeso.Location = New System.Drawing.Point(216, 427)
        Me.txtPeso.Multiline = True
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(192, 29)
        Me.txtPeso.TabIndex = 86
        '
        'lblMedicina
        '
        Me.lblMedicina.AutoSize = True
        Me.lblMedicina.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedicina.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblMedicina.Location = New System.Drawing.Point(33, 368)
        Me.lblMedicina.Name = "lblMedicina"
        Me.lblMedicina.Size = New System.Drawing.Size(150, 20)
        Me.lblMedicina.TabIndex = 85
        Me.lblMedicina.Text = "Horario de Medicina"
        '
        'txtMedicina
        '
        Me.txtMedicina.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMedicina.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtMedicina.Location = New System.Drawing.Point(216, 361)
        Me.txtMedicina.Multiline = True
        Me.txtMedicina.Name = "txtMedicina"
        Me.txtMedicina.Size = New System.Drawing.Size(192, 29)
        Me.txtMedicina.TabIndex = 84
        '
        'lblDosis
        '
        Me.lblDosis.AutoSize = True
        Me.lblDosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDosis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblDosis.Location = New System.Drawing.Point(33, 302)
        Me.lblDosis.Name = "lblDosis"
        Me.lblDosis.Size = New System.Drawing.Size(49, 20)
        Me.lblDosis.TabIndex = 83
        Me.lblDosis.Text = "Dosis"
        '
        'txtDosis
        '
        Me.txtDosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDosis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtDosis.Location = New System.Drawing.Point(216, 295)
        Me.txtDosis.Multiline = True
        Me.txtDosis.Name = "txtDosis"
        Me.txtDosis.Size = New System.Drawing.Size(192, 29)
        Me.txtDosis.TabIndex = 82
        '
        'lblMedicamentos
        '
        Me.lblMedicamentos.AutoSize = True
        Me.lblMedicamentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedicamentos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblMedicamentos.Location = New System.Drawing.Point(33, 237)
        Me.lblMedicamentos.Name = "lblMedicamentos"
        Me.lblMedicamentos.Size = New System.Drawing.Size(113, 20)
        Me.lblMedicamentos.TabIndex = 81
        Me.lblMedicamentos.Text = "Medicamentos"
        '
        'txtMedicamentos
        '
        Me.txtMedicamentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMedicamentos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtMedicamentos.Location = New System.Drawing.Point(216, 230)
        Me.txtMedicamentos.Multiline = True
        Me.txtMedicamentos.Name = "txtMedicamentos"
        Me.txtMedicamentos.Size = New System.Drawing.Size(192, 29)
        Me.txtMedicamentos.TabIndex = 80
        '
        'lblVacunas
        '
        Me.lblVacunas.AutoSize = True
        Me.lblVacunas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVacunas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblVacunas.Location = New System.Drawing.Point(33, 182)
        Me.lblVacunas.Name = "lblVacunas"
        Me.lblVacunas.Size = New System.Drawing.Size(72, 20)
        Me.lblVacunas.TabIndex = 79
        Me.lblVacunas.Text = "Vacunas"
        '
        'txtVacunas
        '
        Me.txtVacunas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVacunas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtVacunas.Location = New System.Drawing.Point(216, 173)
        Me.txtVacunas.Multiline = True
        Me.txtVacunas.Name = "txtVacunas"
        Me.txtVacunas.Size = New System.Drawing.Size(192, 29)
        Me.txtVacunas.TabIndex = 78
        '
        'lblNacimiento
        '
        Me.lblNacimiento.AutoSize = True
        Me.lblNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNacimiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblNacimiento.Location = New System.Drawing.Point(33, 123)
        Me.lblNacimiento.Name = "lblNacimiento"
        Me.lblNacimiento.Size = New System.Drawing.Size(137, 20)
        Me.lblNacimiento.TabIndex = 77
        Me.lblNacimiento.Text = "Fecha Nacimiento"
        '
        'txtNacimiento
        '
        Me.txtNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNacimiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtNacimiento.Location = New System.Drawing.Point(216, 114)
        Me.txtNacimiento.Multiline = True
        Me.txtNacimiento.Name = "txtNacimiento"
        Me.txtNacimiento.Size = New System.Drawing.Size(192, 29)
        Me.txtNacimiento.TabIndex = 76
        '
        'lblNombreMascota
        '
        Me.lblNombreMascota.AutoSize = True
        Me.lblNombreMascota.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreMascota.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblNombreMascota.Location = New System.Drawing.Point(33, 61)
        Me.lblNombreMascota.Name = "lblNombreMascota"
        Me.lblNombreMascota.Size = New System.Drawing.Size(152, 20)
        Me.lblNombreMascota.TabIndex = 75
        Me.lblNombreMascota.Text = "Nombre de Mascota"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtNombre.Location = New System.Drawing.Point(218, 61)
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(192, 29)
        Me.txtNombre.TabIndex = 92
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
        Me.btnSalir.TabIndex = 93
        Me.btnSalir.TabStop = False
        '
        'Pagina2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(452, 667)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.TextBox15)
        Me.Controls.Add(Me.lblRaza)
        Me.Controls.Add(Me.txtRaza)
        Me.Controls.Add(Me.lblPeso)
        Me.Controls.Add(Me.txtPeso)
        Me.Controls.Add(Me.lblMedicina)
        Me.Controls.Add(Me.txtMedicina)
        Me.Controls.Add(Me.lblDosis)
        Me.Controls.Add(Me.txtDosis)
        Me.Controls.Add(Me.lblMedicamentos)
        Me.Controls.Add(Me.txtMedicamentos)
        Me.Controls.Add(Me.lblVacunas)
        Me.Controls.Add(Me.txtVacunas)
        Me.Controls.Add(Me.lblNacimiento)
        Me.Controls.Add(Me.txtNacimiento)
        Me.Controls.Add(Me.lblNombreMascota)
        Me.Controls.Add(Me.lblDatosMascota)
        Me.Controls.Add(Me.ipbAnteriorFoto)
        Me.Controls.Add(Me.ipbSiguienteFoto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Pagina2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hotel Canino"
        CType(Me.ipbAnteriorFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ipbSiguienteFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ipbAnteriorFoto As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents ipbSiguienteFoto As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lblDatosMascota As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents lblRaza As Label
    Friend WithEvents txtRaza As TextBox
    Friend WithEvents lblPeso As Label
    Friend WithEvents txtPeso As TextBox
    Friend WithEvents lblMedicina As Label
    Friend WithEvents txtMedicina As TextBox
    Friend WithEvents lblDosis As Label
    Friend WithEvents txtDosis As TextBox
    Friend WithEvents lblMedicamentos As Label
    Friend WithEvents txtMedicamentos As TextBox
    Friend WithEvents lblVacunas As Label
    Friend WithEvents txtVacunas As TextBox
    Friend WithEvents lblNacimiento As Label
    Friend WithEvents txtNacimiento As TextBox
    Friend WithEvents lblNombreMascota As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents btnSalir As FontAwesome.Sharp.IconPictureBox
End Class
