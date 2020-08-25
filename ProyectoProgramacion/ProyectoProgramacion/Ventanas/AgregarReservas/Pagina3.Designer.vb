<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pagina3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pagina3))
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
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.btnSalir = New FontAwesome.Sharp.IconPictureBox()
        CType(Me.ipbAnteriorFoto, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ipbAnteriorFoto.Location = New System.Drawing.Point(12, 623)
        Me.ipbAnteriorFoto.Name = "ipbAnteriorFoto"
        Me.ipbAnteriorFoto.Size = New System.Drawing.Size(38, 34)
        Me.ipbAnteriorFoto.TabIndex = 25
        Me.ipbAnteriorFoto.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(124, 9)
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
        Me.lblHoraRetiro.Location = New System.Drawing.Point(36, 241)
        Me.lblHoraRetiro.Name = "lblHoraRetiro"
        Me.lblHoraRetiro.Size = New System.Drawing.Size(113, 20)
        Me.lblHoraRetiro.TabIndex = 88
        Me.lblHoraRetiro.Text = "Hora de Retiro"
        '
        'cboHoraRetiro
        '
        Me.cboHoraRetiro.FormattingEnabled = True
        Me.cboHoraRetiro.Items.AddRange(New Object() {"Entre 11 AM y 12 AM", "Entre 12 AM y 13 PM", "Entre 14 PM y 15 PM", "Entre 15 PM y 16:30 PM", "Entre 17 PM y 18 PM", "Entre 18 PM y 19 PM"})
        Me.cboHoraRetiro.Location = New System.Drawing.Point(219, 241)
        Me.cboHoraRetiro.Name = "cboHoraRetiro"
        Me.cboHoraRetiro.Size = New System.Drawing.Size(192, 21)
        Me.cboHoraRetiro.TabIndex = 87
        '
        'cboModoRetiro
        '
        Me.cboModoRetiro.FormattingEnabled = True
        Me.cboModoRetiro.Items.AddRange(New Object() {"Entrega por Cliente", "Entrega por Camioneta"})
        Me.cboModoRetiro.Location = New System.Drawing.Point(219, 184)
        Me.cboModoRetiro.Name = "cboModoRetiro"
        Me.cboModoRetiro.Size = New System.Drawing.Size(192, 21)
        Me.cboModoRetiro.TabIndex = 86
        '
        'cboModoEntrega
        '
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
        Me.lblHoraEntrega.Location = New System.Drawing.Point(36, 123)
        Me.lblHoraEntrega.Name = "lblHoraEntrega"
        Me.lblHoraEntrega.Size = New System.Drawing.Size(127, 20)
        Me.lblHoraEntrega.TabIndex = 84
        Me.lblHoraEntrega.Text = "Hora de Entrega"
        '
        'cboHoraEntrega
        '
        Me.cboHoraEntrega.FormattingEnabled = True
        Me.cboHoraEntrega.Items.AddRange(New Object() {"Entre 11 AM y 12 AM", "Entre 12 AM y 13 PM", "Entre 14 PM y 15 PM", "Entre 15 PM y 16:30 PM", "Entre 17 PM y 18 PM", "Entre 18 PM y 19 PM"})
        Me.cboHoraEntrega.Location = New System.Drawing.Point(219, 123)
        Me.cboHoraEntrega.Name = "cboHoraEntrega"
        Me.cboHoraEntrega.Size = New System.Drawing.Size(192, 21)
        Me.cboHoraEntrega.TabIndex = 83
        '
        'lblModoRetiro
        '
        Me.lblModoRetiro.AutoSize = True
        Me.lblModoRetiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModoRetiro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblModoRetiro.Location = New System.Drawing.Point(36, 185)
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
        Me.lblModoEntrega.Location = New System.Drawing.Point(36, 61)
        Me.lblModoEntrega.Name = "lblModoEntrega"
        Me.lblModoEntrega.Size = New System.Drawing.Size(132, 20)
        Me.lblModoEntrega.TabIndex = 81
        Me.lblModoEntrega.Text = "Modo de Entrega"
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
        Me.IconButton1.Location = New System.Drawing.Point(140, 620)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Rotation = 0R
        Me.IconButton1.Size = New System.Drawing.Size(174, 37)
        Me.IconButton1.TabIndex = 89
        Me.IconButton1.Text = "Confirmar"
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = False
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
        'Pagina3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(452, 669)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.lblHoraRetiro)
        Me.Controls.Add(Me.cboHoraRetiro)
        Me.Controls.Add(Me.cboModoRetiro)
        Me.Controls.Add(Me.cboModoEntrega)
        Me.Controls.Add(Me.lblHoraEntrega)
        Me.Controls.Add(Me.cboHoraEntrega)
        Me.Controls.Add(Me.lblModoRetiro)
        Me.Controls.Add(Me.lblModoEntrega)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.ipbAnteriorFoto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Pagina3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hotel Canino"
        CType(Me.ipbAnteriorFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSalir As FontAwesome.Sharp.IconPictureBox
End Class
