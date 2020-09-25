<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModificarMascota
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarMascota))
        Me.lblDatosCliente = New System.Windows.Forms.Label()
        Me.btnSalir = New FontAwesome.Sharp.IconPictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCerrar = New FontAwesome.Sharp.IconPictureBox()
        Me.modificar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.NombreMascota = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuDropdown5 = New Bunifu.Framework.UI.BunifuDropdown()
        Me.BunifuDropdown1 = New Bunifu.Framework.UI.BunifuDropdown()
        Me.BunifuDropdown4 = New Bunifu.Framework.UI.BunifuDropdown()
        Me.BunifuDropdown3 = New Bunifu.Framework.UI.BunifuDropdown()
        Me.BunifuDropdown2 = New Bunifu.Framework.UI.BunifuDropdown()
        Me.BunifuDatepicker1 = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.fechaNac = New Bunifu.Framework.UI.BunifuDatepicker()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDatosCliente
        '
        Me.lblDatosCliente.AutoSize = True
        Me.lblDatosCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatosCliente.ForeColor = System.Drawing.Color.White
        Me.lblDatosCliente.Location = New System.Drawing.Point(282, 9)
        Me.lblDatosCliente.Name = "lblDatosCliente"
        Me.lblDatosCliente.Size = New System.Drawing.Size(178, 24)
        Me.lblDatosCliente.TabIndex = 65
        Me.lblDatosCliente.Text = "Modificar Mascota"
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
        Me.btnSalir.Location = New System.Drawing.Point(721, 0)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(32, 32)
        Me.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSalir.TabIndex = 94
        Me.btnSalir.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnCerrar)
        Me.Panel3.Controls.Add(Me.lblDatosCliente)
        Me.Panel3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(753, 42)
        Me.Panel3.TabIndex = 96
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.btnCerrar.IconColor = System.Drawing.Color.White
        Me.btnCerrar.IconSize = 34
        Me.btnCerrar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCerrar.Location = New System.Drawing.Point(716, 5)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(32, 32)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCerrar.TabIndex = 8
        Me.btnCerrar.TabStop = False
        '
        'modificar
        '
        Me.modificar.ActiveBorderThickness = 1
        Me.modificar.ActiveCornerRadius = 20
        Me.modificar.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.modificar.ActiveForecolor = System.Drawing.Color.White
        Me.modificar.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.modificar.BackColor = System.Drawing.Color.White
        Me.modificar.BackgroundImage = CType(resources.GetObject("modificar.BackgroundImage"), System.Drawing.Image)
        Me.modificar.ButtonText = "Modificar"
        Me.modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modificar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.modificar.IdleBorderThickness = 1
        Me.modificar.IdleCornerRadius = 30
        Me.modificar.IdleFillColor = System.Drawing.Color.White
        Me.modificar.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.modificar.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.modificar.Location = New System.Drawing.Point(286, 197)
        Me.modificar.Margin = New System.Windows.Forms.Padding(5)
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(192, 49)
        Me.modificar.TabIndex = 97
        Me.modificar.TabStop = False
        Me.modificar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NombreMascota
        '
        Me.NombreMascota.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.NombreMascota.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NombreMascota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.NombreMascota.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.NombreMascota.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.NombreMascota.HintText = "Nombre de la Mascota"
        Me.NombreMascota.isPassword = False
        Me.NombreMascota.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.NombreMascota.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.NombreMascota.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.NombreMascota.LineThickness = 3
        Me.NombreMascota.Location = New System.Drawing.Point(8, 62)
        Me.NombreMascota.Margin = New System.Windows.Forms.Padding(4)
        Me.NombreMascota.Name = "NombreMascota"
        Me.NombreMascota.Size = New System.Drawing.Size(169, 44)
        Me.NombreMascota.TabIndex = 105
        Me.NombreMascota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuDropdown5
        '
        Me.BunifuDropdown5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BunifuDropdown5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuDropdown5.BorderRadius = 50
        Me.BunifuDropdown5.ForeColor = System.Drawing.Color.White
        Me.BunifuDropdown5.Items = New String(-1) {}
        Me.BunifuDropdown5.Location = New System.Drawing.Point(188, 151)
        Me.BunifuDropdown5.Name = "BunifuDropdown5"
        Me.BunifuDropdown5.NomalColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuDropdown5.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuDropdown5.selectedIndex = -1
        Me.BunifuDropdown5.Size = New System.Drawing.Size(174, 26)
        Me.BunifuDropdown5.TabIndex = 104
        '
        'BunifuDropdown1
        '
        Me.BunifuDropdown1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BunifuDropdown1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuDropdown1.BorderRadius = 50
        Me.BunifuDropdown1.ForeColor = System.Drawing.Color.White
        Me.BunifuDropdown1.Items = New String(-1) {}
        Me.BunifuDropdown1.Location = New System.Drawing.Point(368, 80)
        Me.BunifuDropdown1.Name = "BunifuDropdown1"
        Me.BunifuDropdown1.NomalColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuDropdown1.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuDropdown1.selectedIndex = -1
        Me.BunifuDropdown1.Size = New System.Drawing.Size(174, 26)
        Me.BunifuDropdown1.TabIndex = 103
        '
        'BunifuDropdown4
        '
        Me.BunifuDropdown4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BunifuDropdown4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuDropdown4.BorderRadius = 50
        Me.BunifuDropdown4.ForeColor = System.Drawing.Color.White
        Me.BunifuDropdown4.Items = New String(-1) {}
        Me.BunifuDropdown4.Location = New System.Drawing.Point(551, 151)
        Me.BunifuDropdown4.Name = "BunifuDropdown4"
        Me.BunifuDropdown4.NomalColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuDropdown4.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuDropdown4.selectedIndex = -1
        Me.BunifuDropdown4.Size = New System.Drawing.Size(153, 26)
        Me.BunifuDropdown4.TabIndex = 102
        '
        'BunifuDropdown3
        '
        Me.BunifuDropdown3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BunifuDropdown3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuDropdown3.BorderRadius = 50
        Me.BunifuDropdown3.ForeColor = System.Drawing.Color.White
        Me.BunifuDropdown3.Items = New String(-1) {}
        Me.BunifuDropdown3.Location = New System.Drawing.Point(368, 151)
        Me.BunifuDropdown3.Name = "BunifuDropdown3"
        Me.BunifuDropdown3.NomalColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuDropdown3.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuDropdown3.selectedIndex = -1
        Me.BunifuDropdown3.Size = New System.Drawing.Size(174, 26)
        Me.BunifuDropdown3.TabIndex = 101
        '
        'BunifuDropdown2
        '
        Me.BunifuDropdown2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BunifuDropdown2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuDropdown2.BorderRadius = 50
        Me.BunifuDropdown2.ForeColor = System.Drawing.Color.White
        Me.BunifuDropdown2.Items = New String(-1) {}
        Me.BunifuDropdown2.Location = New System.Drawing.Point(548, 80)
        Me.BunifuDropdown2.Name = "BunifuDropdown2"
        Me.BunifuDropdown2.NomalColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuDropdown2.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuDropdown2.selectedIndex = -1
        Me.BunifuDropdown2.Size = New System.Drawing.Size(156, 26)
        Me.BunifuDropdown2.TabIndex = 100
        '
        'BunifuDatepicker1
        '
        Me.BunifuDatepicker1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BunifuDatepicker1.BackColor = System.Drawing.Color.White
        Me.BunifuDatepicker1.BorderRadius = 2
        Me.BunifuDatepicker1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.BunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.BunifuDatepicker1.FormatCustom = Nothing
        Me.BunifuDatepicker1.Location = New System.Drawing.Point(12, 148)
        Me.BunifuDatepicker1.Name = "BunifuDatepicker1"
        Me.BunifuDatepicker1.Size = New System.Drawing.Size(165, 29)
        Me.BunifuDatepicker1.TabIndex = 99
        Me.BunifuDatepicker1.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'fechaNac
        '
        Me.fechaNac.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.fechaNac.BackColor = System.Drawing.Color.White
        Me.fechaNac.BorderRadius = 2
        Me.fechaNac.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.fechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaNac.FormatCustom = Nothing
        Me.fechaNac.Location = New System.Drawing.Point(185, 77)
        Me.fechaNac.Name = "fechaNac"
        Me.fechaNac.Size = New System.Drawing.Size(177, 29)
        Me.fechaNac.TabIndex = 98
        Me.fechaNac.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'ModificarMascota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(753, 259)
        Me.Controls.Add(Me.NombreMascota)
        Me.Controls.Add(Me.BunifuDropdown5)
        Me.Controls.Add(Me.BunifuDropdown1)
        Me.Controls.Add(Me.BunifuDropdown4)
        Me.Controls.Add(Me.BunifuDropdown3)
        Me.Controls.Add(Me.BunifuDropdown2)
        Me.Controls.Add(Me.BunifuDatepicker1)
        Me.Controls.Add(Me.fechaNac)
        Me.Controls.Add(Me.modificar)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnSalir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ModificarMascota"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hotel Canino"
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblDatosCliente As Label
    Friend WithEvents btnSalir As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnCerrar As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents modificar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents NombreMascota As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuDropdown5 As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents BunifuDropdown1 As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents BunifuDropdown4 As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents BunifuDropdown3 As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents BunifuDropdown2 As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents BunifuDatepicker1 As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents fechaNac As Bunifu.Framework.UI.BunifuDatepicker
End Class
