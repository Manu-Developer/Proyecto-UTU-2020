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
        Me.LateralPanel = New System.Windows.Forms.Panel()
        Me.fechaReserva = New System.Windows.Forms.Label()
        Me.fechaSalida = New System.Windows.Forms.Label()
        Me.modoDeEntrega = New System.Windows.Forms.Label()
        Me.modoDeRetiro = New System.Windows.Forms.Label()
        Me.horaDeEntrega = New System.Windows.Forms.Label()
        Me.btnIniciar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.horaDeSalida = New System.Windows.Forms.Label()
        Me.monto = New System.Windows.Forms.Label()
        Me.tipoDePago = New System.Windows.Forms.Label()
        Me.estado = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LateralPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'info
        '
        Me.info.AutoSize = True
        Me.info.BackColor = System.Drawing.Color.Transparent
        Me.info.Font = New System.Drawing.Font("Palatino Linotype", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.info.Location = New System.Drawing.Point(226, 9)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(261, 36)
        Me.info.TabIndex = 1
        Me.info.Text = "Viendo la Reserva De"
        '
        'LateralPanel
        '
        Me.LateralPanel.Controls.Add(Me.Panel1)
        Me.LateralPanel.Controls.Add(Me.info)
        Me.LateralPanel.Controls.Add(Me.estado)
        Me.LateralPanel.Controls.Add(Me.tipoDePago)
        Me.LateralPanel.Controls.Add(Me.monto)
        Me.LateralPanel.Controls.Add(Me.horaDeSalida)
        Me.LateralPanel.Controls.Add(Me.btnIniciar)
        Me.LateralPanel.Controls.Add(Me.horaDeEntrega)
        Me.LateralPanel.Controls.Add(Me.modoDeRetiro)
        Me.LateralPanel.Controls.Add(Me.modoDeEntrega)
        Me.LateralPanel.Controls.Add(Me.fechaSalida)
        Me.LateralPanel.Controls.Add(Me.fechaReserva)
        Me.LateralPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LateralPanel.Location = New System.Drawing.Point(0, 0)
        Me.LateralPanel.Name = "LateralPanel"
        Me.LateralPanel.Size = New System.Drawing.Size(967, 384)
        Me.LateralPanel.TabIndex = 2
        '
        'fechaReserva
        '
        Me.fechaReserva.AutoSize = True
        Me.fechaReserva.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechaReserva.Location = New System.Drawing.Point(12, 73)
        Me.fechaReserva.Name = "fechaReserva"
        Me.fechaReserva.Size = New System.Drawing.Size(170, 26)
        Me.fechaReserva.TabIndex = 2
        Me.fechaReserva.Text = "Fecha de Reserva:"
        '
        'fechaSalida
        '
        Me.fechaSalida.AutoSize = True
        Me.fechaSalida.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechaSalida.Location = New System.Drawing.Point(12, 100)
        Me.fechaSalida.Name = "fechaSalida"
        Me.fechaSalida.Size = New System.Drawing.Size(156, 26)
        Me.fechaSalida.TabIndex = 3
        Me.fechaSalida.Text = "Fecha de Salida:"
        '
        'modoDeEntrega
        '
        Me.modoDeEntrega.AutoSize = True
        Me.modoDeEntrega.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modoDeEntrega.Location = New System.Drawing.Point(12, 126)
        Me.modoDeEntrega.Name = "modoDeEntrega"
        Me.modoDeEntrega.Size = New System.Drawing.Size(172, 26)
        Me.modoDeEntrega.TabIndex = 4
        Me.modoDeEntrega.Text = "Modo de Entrega:"
        '
        'modoDeRetiro
        '
        Me.modoDeRetiro.AutoSize = True
        Me.modoDeRetiro.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modoDeRetiro.Location = New System.Drawing.Point(12, 151)
        Me.modoDeRetiro.Name = "modoDeRetiro"
        Me.modoDeRetiro.Size = New System.Drawing.Size(158, 26)
        Me.modoDeRetiro.TabIndex = 5
        Me.modoDeRetiro.Text = "Modo de Retiro:"
        '
        'horaDeEntrega
        '
        Me.horaDeEntrega.AutoSize = True
        Me.horaDeEntrega.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.horaDeEntrega.Location = New System.Drawing.Point(12, 178)
        Me.horaDeEntrega.Name = "horaDeEntrega"
        Me.horaDeEntrega.Size = New System.Drawing.Size(164, 26)
        Me.horaDeEntrega.TabIndex = 6
        Me.horaDeEntrega.Text = "Hora de Entrega:"
        '
        'btnIniciar
        '
        Me.btnIniciar.ActiveBorderThickness = 1
        Me.btnIniciar.ActiveCornerRadius = 20
        Me.btnIniciar.ActiveFillColor = System.Drawing.SystemColors.Control
        Me.btnIniciar.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnIniciar.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnIniciar.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.btnIniciar.BackColor = System.Drawing.SystemColors.Control
        Me.btnIniciar.BackgroundImage = CType(resources.GetObject("btnIniciar.BackgroundImage"), System.Drawing.Image)
        Me.btnIniciar.ButtonText = "Ver Mascotas"
        Me.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIniciar.ForeColor = System.Drawing.Color.White
        Me.btnIniciar.IdleBorderThickness = 1
        Me.btnIniciar.IdleCornerRadius = 20
        Me.btnIniciar.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnIniciar.IdleForecolor = System.Drawing.SystemColors.Control
        Me.btnIniciar.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnIniciar.Location = New System.Drawing.Point(330, 329)
        Me.btnIniciar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(181, 41)
        Me.btnIniciar.TabIndex = 8
        Me.btnIniciar.TabStop = False
        Me.btnIniciar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'horaDeSalida
        '
        Me.horaDeSalida.AutoSize = True
        Me.horaDeSalida.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.horaDeSalida.Location = New System.Drawing.Point(12, 204)
        Me.horaDeSalida.Name = "horaDeSalida"
        Me.horaDeSalida.Size = New System.Drawing.Size(150, 26)
        Me.horaDeSalida.TabIndex = 9
        Me.horaDeSalida.Text = "Hora de Salida:"
        '
        'monto
        '
        Me.monto.AutoSize = True
        Me.monto.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.monto.Location = New System.Drawing.Point(12, 281)
        Me.monto.Name = "monto"
        Me.monto.Size = New System.Drawing.Size(77, 26)
        Me.monto.TabIndex = 10
        Me.monto.Text = "Monto:"
        '
        'tipoDePago
        '
        Me.tipoDePago.AutoSize = True
        Me.tipoDePago.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tipoDePago.Location = New System.Drawing.Point(12, 230)
        Me.tipoDePago.Name = "tipoDePago"
        Me.tipoDePago.Size = New System.Drawing.Size(134, 26)
        Me.tipoDePago.TabIndex = 11
        Me.tipoDePago.Text = "Tipo de Pago:"
        '
        'estado
        '
        Me.estado.AutoSize = True
        Me.estado.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estado.Location = New System.Drawing.Point(12, 256)
        Me.estado.Name = "estado"
        Me.estado.Size = New System.Drawing.Size(77, 26)
        Me.estado.TabIndex = 12
        Me.estado.Text = "Estado:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Location = New System.Drawing.Point(580, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(375, 314)
        Me.Panel1.TabIndex = 13
        '
        'VerReserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 384)
        Me.Controls.Add(Me.LateralPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VerReserva"
        Me.Text = "VerReserva"
        Me.LateralPanel.ResumeLayout(False)
        Me.LateralPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents info As Label
    Friend WithEvents LateralPanel As Panel
    Friend WithEvents fechaReserva As Label
    Friend WithEvents horaDeEntrega As Label
    Friend WithEvents modoDeRetiro As Label
    Friend WithEvents modoDeEntrega As Label
    Friend WithEvents fechaSalida As Label
    Friend WithEvents tipoDePago As Label
    Friend WithEvents monto As Label
    Friend WithEvents horaDeSalida As Label
    Friend WithEvents btnIniciar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Panel1 As Panel
    Friend WithEvents estado As Label
End Class
