<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerReserva
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VerReserva))
        Me.info = New System.Windows.Forms.Label()
        Me.Top = New System.Windows.Forms.Panel()
        Me.estado = New System.Windows.Forms.Label()
        Me.monto = New System.Windows.Forms.Label()
        Me.btnNuevoCliente = New System.Windows.Forms.Button()
        Me.btnIniciar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.fechaNac = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.BunifuDatepicker1 = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.BunifuDropdown2 = New Bunifu.Framework.UI.BunifuDropdown()
        Me.BunifuDropdown3 = New Bunifu.Framework.UI.BunifuDropdown()
        Me.BunifuDropdown4 = New Bunifu.Framework.UI.BunifuDropdown()
        Me.BunifuDropdown1 = New Bunifu.Framework.UI.BunifuDropdown()
        Me.BunifuDropdown5 = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Top.SuspendLayout()
        Me.SuspendLayout()
        '
        'info
        '
        Me.info.AutoSize = True
        Me.info.BackColor = System.Drawing.Color.Transparent
        Me.info.Font = New System.Drawing.Font("Palatino Linotype", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info.ForeColor = System.Drawing.Color.White
        Me.info.Location = New System.Drawing.Point(25, 3)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(261, 36)
        Me.info.TabIndex = 1
        Me.info.Text = "Viendo la Reserva De"
        '
        'Top
        '
        Me.Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Top.Controls.Add(Me.info)
        Me.Top.Dock = System.Windows.Forms.DockStyle.Top
        Me.Top.Location = New System.Drawing.Point(0, 0)
        Me.Top.Name = "Top"
        Me.Top.Size = New System.Drawing.Size(466, 46)
        Me.Top.TabIndex = 2
        '
        'estado
        '
        Me.estado.AutoSize = True
        Me.estado.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.estado.Location = New System.Drawing.Point(10, 269)
        Me.estado.Name = "estado"
        Me.estado.Size = New System.Drawing.Size(77, 26)
        Me.estado.TabIndex = 12
        Me.estado.Text = "Estado:"
        '
        'monto
        '
        Me.monto.AutoSize = True
        Me.monto.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.monto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.monto.Location = New System.Drawing.Point(321, 269)
        Me.monto.Name = "monto"
        Me.monto.Size = New System.Drawing.Size(77, 26)
        Me.monto.TabIndex = 10
        Me.monto.Text = "Monto:"
        '
        'btnNuevoCliente
        '
        Me.btnNuevoCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevoCliente.BackColor = System.Drawing.Color.White
        Me.btnNuevoCliente.FlatAppearance.BorderSize = 0
        Me.btnNuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoCliente.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnNuevoCliente.Image = Global.ProyectoProgramacion.My.Resources.Resources.rervaeditar
        Me.btnNuevoCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevoCliente.Location = New System.Drawing.Point(127, 455)
        Me.btnNuevoCliente.Name = "btnNuevoCliente"
        Me.btnNuevoCliente.Size = New System.Drawing.Size(189, 59)
        Me.btnNuevoCliente.TabIndex = 16
        Me.btnNuevoCliente.TabStop = False
        Me.btnNuevoCliente.Text = "Modificar Rerserva"
        Me.btnNuevoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevoCliente.UseVisualStyleBackColor = False
        '
        'btnIniciar
        '
        Me.btnIniciar.ActiveBorderThickness = 1
        Me.btnIniciar.ActiveCornerRadius = 20
        Me.btnIniciar.ActiveFillColor = System.Drawing.Color.White
        Me.btnIniciar.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnIniciar.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnIniciar.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.btnIniciar.BackColor = System.Drawing.Color.White
        Me.btnIniciar.BackgroundImage = CType(resources.GetObject("btnIniciar.BackgroundImage"), System.Drawing.Image)
        Me.btnIniciar.ButtonText = "Ver Mascotas"
        Me.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIniciar.ForeColor = System.Drawing.Color.White
        Me.btnIniciar.IdleBorderThickness = 1
        Me.btnIniciar.IdleCornerRadius = 20
        Me.btnIniciar.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnIniciar.IdleForecolor = System.Drawing.Color.White
        Me.btnIniciar.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnIniciar.Location = New System.Drawing.Point(135, 351)
        Me.btnIniciar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(181, 41)
        Me.btnIniciar.TabIndex = 8
        Me.btnIniciar.TabStop = False
        Me.btnIniciar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fechaNac
        '
        Me.fechaNac.BackColor = System.Drawing.Color.White
        Me.fechaNac.BorderRadius = 2
        Me.fechaNac.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.fechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaNac.FormatCustom = Nothing
        Me.fechaNac.Location = New System.Drawing.Point(12, 65)
        Me.fechaNac.Name = "fechaNac"
        Me.fechaNac.Size = New System.Drawing.Size(192, 29)
        Me.fechaNac.TabIndex = 22
        Me.fechaNac.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'BunifuDatepicker1
        '
        Me.BunifuDatepicker1.BackColor = System.Drawing.Color.White
        Me.BunifuDatepicker1.BorderRadius = 2
        Me.BunifuDatepicker1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.BunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.BunifuDatepicker1.FormatCustom = Nothing
        Me.BunifuDatepicker1.Location = New System.Drawing.Point(249, 65)
        Me.BunifuDatepicker1.Name = "BunifuDatepicker1"
        Me.BunifuDatepicker1.Size = New System.Drawing.Size(192, 29)
        Me.BunifuDatepicker1.TabIndex = 23
        Me.BunifuDatepicker1.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'BunifuDropdown2
        '
        Me.BunifuDropdown2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuDropdown2.BorderRadius = 50
        Me.BunifuDropdown2.ForeColor = System.Drawing.Color.White
        Me.BunifuDropdown2.Items = New String(-1) {}
        Me.BunifuDropdown2.Location = New System.Drawing.Point(249, 115)
        Me.BunifuDropdown2.Name = "BunifuDropdown2"
        Me.BunifuDropdown2.NomalColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuDropdown2.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuDropdown2.selectedIndex = -1
        Me.BunifuDropdown2.Size = New System.Drawing.Size(189, 26)
        Me.BunifuDropdown2.TabIndex = 25
        '
        'BunifuDropdown3
        '
        Me.BunifuDropdown3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuDropdown3.BorderRadius = 50
        Me.BunifuDropdown3.ForeColor = System.Drawing.Color.White
        Me.BunifuDropdown3.Items = New String(-1) {}
        Me.BunifuDropdown3.Location = New System.Drawing.Point(249, 157)
        Me.BunifuDropdown3.Name = "BunifuDropdown3"
        Me.BunifuDropdown3.NomalColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuDropdown3.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuDropdown3.selectedIndex = -1
        Me.BunifuDropdown3.Size = New System.Drawing.Size(189, 26)
        Me.BunifuDropdown3.TabIndex = 26
        '
        'BunifuDropdown4
        '
        Me.BunifuDropdown4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuDropdown4.BorderRadius = 50
        Me.BunifuDropdown4.ForeColor = System.Drawing.Color.White
        Me.BunifuDropdown4.Items = New String(-1) {}
        Me.BunifuDropdown4.Location = New System.Drawing.Point(15, 157)
        Me.BunifuDropdown4.Name = "BunifuDropdown4"
        Me.BunifuDropdown4.NomalColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuDropdown4.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuDropdown4.selectedIndex = -1
        Me.BunifuDropdown4.Size = New System.Drawing.Size(189, 26)
        Me.BunifuDropdown4.TabIndex = 27
        '
        'BunifuDropdown1
        '
        Me.BunifuDropdown1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuDropdown1.BorderRadius = 50
        Me.BunifuDropdown1.ForeColor = System.Drawing.Color.White
        Me.BunifuDropdown1.Items = New String(-1) {}
        Me.BunifuDropdown1.Location = New System.Drawing.Point(15, 115)
        Me.BunifuDropdown1.Name = "BunifuDropdown1"
        Me.BunifuDropdown1.NomalColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuDropdown1.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuDropdown1.selectedIndex = -1
        Me.BunifuDropdown1.Size = New System.Drawing.Size(189, 26)
        Me.BunifuDropdown1.TabIndex = 28
        '
        'BunifuDropdown5
        '
        Me.BunifuDropdown5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuDropdown5.BorderRadius = 50
        Me.BunifuDropdown5.ForeColor = System.Drawing.Color.White
        Me.BunifuDropdown5.Items = New String(-1) {}
        Me.BunifuDropdown5.Location = New System.Drawing.Point(135, 200)
        Me.BunifuDropdown5.Name = "BunifuDropdown5"
        Me.BunifuDropdown5.NomalColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuDropdown5.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuDropdown5.selectedIndex = -1
        Me.BunifuDropdown5.Size = New System.Drawing.Size(189, 26)
        Me.BunifuDropdown5.TabIndex = 29
        '
        'VerReserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(466, 526)
        Me.Controls.Add(Me.btnNuevoCliente)
        Me.Controls.Add(Me.BunifuDropdown5)
        Me.Controls.Add(Me.BunifuDropdown1)
        Me.Controls.Add(Me.BunifuDropdown4)
        Me.Controls.Add(Me.BunifuDropdown3)
        Me.Controls.Add(Me.BunifuDropdown2)
        Me.Controls.Add(Me.BunifuDatepicker1)
        Me.Controls.Add(Me.fechaNac)
        Me.Controls.Add(Me.Top)
        Me.Controls.Add(Me.estado)
        Me.Controls.Add(Me.monto)
        Me.Controls.Add(Me.btnIniciar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VerReserva"
        Me.Text = "VerReserva"
        Me.Top.ResumeLayout(False)
        Me.Top.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents info As Label
    Friend WithEvents Top As Panel
    Friend WithEvents monto As Label
    Friend WithEvents btnIniciar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents estado As Label
    Friend WithEvents btnNuevoCliente As Button
    Friend WithEvents fechaNac As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents BunifuDatepicker1 As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents BunifuDropdown2 As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents BunifuDropdown3 As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents BunifuDropdown4 As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents BunifuDropdown1 As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents BunifuDropdown5 As Bunifu.Framework.UI.BunifuDropdown
End Class
