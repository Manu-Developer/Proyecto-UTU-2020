<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pagina2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pagina2))
        Me.ipbAnteriorFoto = New FontAwesome.Sharp.IconPictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblHoraRetiro = New System.Windows.Forms.Label()
        Me.cboHoraRetiro = New System.Windows.Forms.ComboBox()
        Me.cboModoRetiro = New System.Windows.Forms.ComboBox()
        Me.cboModoEntrega = New System.Windows.Forms.ComboBox()
        Me.lblHoraEntrega = New System.Windows.Forms.Label()
        Me.cboHoraEntrega = New System.Windows.Forms.ComboBox()
        Me.lblModoRetiro = New System.Windows.Forms.Label()
        Me.lblModoEntrega = New System.Windows.Forms.Label()
        Me.btnSalir = New FontAwesome.Sharp.IconPictureBox()
        Me.confirm = New FontAwesome.Sharp.IconButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.oficinistaSalir = New FontAwesome.Sharp.IconPictureBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNacimiento = New System.Windows.Forms.Label()
        Me.lbCosto = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.ipbAnteriorFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.oficinistaSalir, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ipbAnteriorFoto.Location = New System.Drawing.Point(12, 479)
        Me.ipbAnteriorFoto.Name = "ipbAnteriorFoto"
        Me.ipbAnteriorFoto.Size = New System.Drawing.Size(38, 34)
        Me.ipbAnteriorFoto.TabIndex = 25
        Me.ipbAnteriorFoto.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(146, 9)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(177, 24)
        Me.Label17.TabIndex = 67
        Me.Label17.Text = "Datos Adicionales"
        '
        'lblHoraRetiro
        '
        Me.lblHoraRetiro.AutoSize = True
        Me.lblHoraRetiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoraRetiro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblHoraRetiro.Location = New System.Drawing.Point(41, 164)
        Me.lblHoraRetiro.Name = "lblHoraRetiro"
        Me.lblHoraRetiro.Size = New System.Drawing.Size(113, 20)
        Me.lblHoraRetiro.TabIndex = 88
        Me.lblHoraRetiro.Text = "Hora de Retiro"
        '
        'cboHoraRetiro
        '
        Me.cboHoraRetiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboHoraRetiro.FormattingEnabled = True
        Me.cboHoraRetiro.Items.AddRange(New Object() {"Entre 11 AM y 12 AM", "Entre 12 AM y 13 PM", "Entre 14 PM y 15 PM", "Entre 15 PM y 16:30 PM", "Entre 17 PM y 18 PM", "Entre 18 PM y 19 PM"})
        Me.cboHoraRetiro.Location = New System.Drawing.Point(219, 163)
        Me.cboHoraRetiro.Name = "cboHoraRetiro"
        Me.cboHoraRetiro.Size = New System.Drawing.Size(192, 21)
        Me.cboHoraRetiro.TabIndex = 87
        '
        'cboModoRetiro
        '
        Me.cboModoRetiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboModoRetiro.FormattingEnabled = True
        Me.cboModoRetiro.Items.AddRange(New Object() {"Entrega por Cliente", "Entrega por Camioneta"})
        Me.cboModoRetiro.Location = New System.Drawing.Point(219, 126)
        Me.cboModoRetiro.Name = "cboModoRetiro"
        Me.cboModoRetiro.Size = New System.Drawing.Size(192, 21)
        Me.cboModoRetiro.TabIndex = 86
        '
        'cboModoEntrega
        '
        Me.cboModoEntrega.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboModoEntrega.FormattingEnabled = True
        Me.cboModoEntrega.Items.AddRange(New Object() {"Entrega por Cliente", "Entrega por Camioneta"})
        Me.cboModoEntrega.Location = New System.Drawing.Point(219, 61)
        Me.cboModoEntrega.Name = "cboModoEntrega"
        Me.cboModoEntrega.Size = New System.Drawing.Size(192, 21)
        Me.cboModoEntrega.TabIndex = 85
        '
        'lblHoraEntrega
        '
        Me.lblHoraEntrega.AutoSize = True
        Me.lblHoraEntrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoraEntrega.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblHoraEntrega.Location = New System.Drawing.Point(41, 95)
        Me.lblHoraEntrega.Name = "lblHoraEntrega"
        Me.lblHoraEntrega.Size = New System.Drawing.Size(127, 20)
        Me.lblHoraEntrega.TabIndex = 84
        Me.lblHoraEntrega.Text = "Hora de Entrega"
        '
        'cboHoraEntrega
        '
        Me.cboHoraEntrega.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboHoraEntrega.FormattingEnabled = True
        Me.cboHoraEntrega.Items.AddRange(New Object() {"Entre 11 AM y 12 AM", "Entre 12 AM y 13 PM", "Entre 14 PM y 15 PM", "Entre 15 PM y 16:30 PM", "Entre 17 PM y 18 PM", "Entre 18 PM y 19 PM"})
        Me.cboHoraEntrega.Location = New System.Drawing.Point(219, 94)
        Me.cboHoraEntrega.Name = "cboHoraEntrega"
        Me.cboHoraEntrega.Size = New System.Drawing.Size(192, 21)
        Me.cboHoraEntrega.TabIndex = 83
        '
        'lblModoRetiro
        '
        Me.lblModoRetiro.AutoSize = True
        Me.lblModoRetiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModoRetiro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblModoRetiro.Location = New System.Drawing.Point(41, 127)
        Me.lblModoRetiro.Name = "lblModoRetiro"
        Me.lblModoRetiro.Size = New System.Drawing.Size(118, 20)
        Me.lblModoRetiro.TabIndex = 82
        Me.lblModoRetiro.Text = "Modo de Retiro"
        '
        'lblModoEntrega
        '
        Me.lblModoEntrega.AutoSize = True
        Me.lblModoEntrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModoEntrega.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblModoEntrega.Location = New System.Drawing.Point(41, 62)
        Me.lblModoEntrega.Name = "lblModoEntrega"
        Me.lblModoEntrega.Size = New System.Drawing.Size(132, 20)
        Me.lblModoEntrega.TabIndex = 81
        Me.lblModoEntrega.Text = "Modo de Entrega"
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
        Me.btnSalir.TabIndex = 90
        Me.btnSalir.TabStop = False
        '
        'confirm
        '
        Me.confirm.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.confirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.confirm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.confirm.FlatAppearance.BorderSize = 0
        Me.confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.confirm.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.confirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirm.ForeColor = System.Drawing.Color.White
        Me.confirm.IconChar = FontAwesome.Sharp.IconChar.Paw
        Me.confirm.IconColor = System.Drawing.Color.White
        Me.confirm.IconSize = 25
        Me.confirm.Location = New System.Drawing.Point(150, 476)
        Me.confirm.Name = "confirm"
        Me.confirm.Rotation = 0R
        Me.confirm.Size = New System.Drawing.Size(174, 37)
        Me.confirm.TabIndex = 96
        Me.confirm.Text = "Confirmar"
        Me.confirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.confirm.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Panel3.Controls.Add(Me.oficinistaSalir)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(452, 42)
        Me.Panel3.TabIndex = 101
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
        Me.oficinistaSalir.Location = New System.Drawing.Point(414, 5)
        Me.oficinistaSalir.Name = "oficinistaSalir"
        Me.oficinistaSalir.Size = New System.Drawing.Size(32, 32)
        Me.oficinistaSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.oficinistaSalir.TabIndex = 8
        Me.oficinistaSalir.TabStop = False
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtNombre.Location = New System.Drawing.Point(219, 195)
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(192, 29)
        Me.txtNombre.TabIndex = 105
        '
        'lblNacimiento
        '
        Me.lblNacimiento.AutoSize = True
        Me.lblNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNacimiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblNacimiento.Location = New System.Drawing.Point(41, 239)
        Me.lblNacimiento.Name = "lblNacimiento"
        Me.lblNacimiento.Size = New System.Drawing.Size(102, 20)
        Me.lblNacimiento.TabIndex = 104
        Me.lblNacimiento.Text = "Tipo de Pago"
        '
        'lbCosto
        '
        Me.lbCosto.AutoSize = True
        Me.lbCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCosto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lbCosto.Location = New System.Drawing.Point(41, 204)
        Me.lbCosto.Name = "lbCosto"
        Me.lbCosto.Size = New System.Drawing.Size(54, 20)
        Me.lbCosto.TabIndex = 102
        Me.lbCosto.Text = "Monto"
        '
        'ComboBox1
        '
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Contado", "Debito", "Credito"})
        Me.ComboBox1.Location = New System.Drawing.Point(219, 241)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(192, 21)
        Me.ComboBox1.TabIndex = 106
        '
        'Pagina3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.ProyectoProgramacion.My.Resources.Resources.Shadow_Notificaciones
        Me.ClientSize = New System.Drawing.Size(452, 519)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNacimiento)
        Me.Controls.Add(Me.lbCosto)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.confirm)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblHoraRetiro)
        Me.Controls.Add(Me.cboHoraRetiro)
        Me.Controls.Add(Me.cboModoRetiro)
        Me.Controls.Add(Me.cboModoEntrega)
        Me.Controls.Add(Me.lblHoraEntrega)
        Me.Controls.Add(Me.cboHoraEntrega)
        Me.Controls.Add(Me.lblModoRetiro)
        Me.Controls.Add(Me.lblModoEntrega)
        Me.Controls.Add(Me.ipbAnteriorFoto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Pagina3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hotel Canino"
        CType(Me.ipbAnteriorFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.oficinistaSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ipbAnteriorFoto As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label17 As Label
    Friend WithEvents lblHoraRetiro As Label
    Friend WithEvents cboHoraRetiro As ComboBox
    Friend WithEvents cboModoRetiro As ComboBox
    Friend WithEvents cboModoEntrega As ComboBox
    Friend WithEvents lblHoraEntrega As Label
    Friend WithEvents cboHoraEntrega As ComboBox
    Friend WithEvents lblModoRetiro As Label
    Friend WithEvents lblModoEntrega As Label
    Friend WithEvents btnSalir As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents confirm As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents oficinistaSalir As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNacimiento As Label
    Friend WithEvents lbCosto As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
