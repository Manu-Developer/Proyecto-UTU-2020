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
        Me.bntCancelarReserva = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.image = New FontAwesome.Sharp.IconButton()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnnuevocliente = New FontAwesome.Sharp.IconButton()
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
        'bntCancelarReserva
        '
        Me.bntCancelarReserva.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bntCancelarReserva.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.bntCancelarReserva.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bntCancelarReserva.FlatAppearance.BorderSize = 0
        Me.bntCancelarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bntCancelarReserva.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.bntCancelarReserva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.bntCancelarReserva.ForeColor = System.Drawing.Color.White
        Me.bntCancelarReserva.IconChar = FontAwesome.Sharp.IconChar.CalendarTimes
        Me.bntCancelarReserva.IconColor = System.Drawing.Color.White
        Me.bntCancelarReserva.IconSize = 25
        Me.bntCancelarReserva.Location = New System.Drawing.Point(398, 551)
        Me.bntCancelarReserva.Name = "bntCancelarReserva"
        Me.bntCancelarReserva.Rotation = 0R
        Me.bntCancelarReserva.Size = New System.Drawing.Size(174, 37)
        Me.bntCancelarReserva.TabIndex = 7
        Me.bntCancelarReserva.Text = "Cancelar Reserva"
        Me.bntCancelarReserva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bntCancelarReserva.UseVisualStyleBackColor = False
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
        Me.IconButton2.Location = New System.Drawing.Point(218, 551)
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
        'btnnuevocliente
        '
        Me.btnnuevocliente.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnnuevocliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnnuevocliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnuevocliente.FlatAppearance.BorderSize = 0
        Me.btnnuevocliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnuevocliente.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnnuevocliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnuevocliente.ForeColor = System.Drawing.Color.White
        Me.btnnuevocliente.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.btnnuevocliente.IconColor = System.Drawing.Color.White
        Me.btnnuevocliente.IconSize = 25
        Me.btnnuevocliente.Location = New System.Drawing.Point(747, 551)
        Me.btnnuevocliente.Name = "btnnuevocliente"
        Me.btnnuevocliente.Rotation = 0R
        Me.btnnuevocliente.Size = New System.Drawing.Size(174, 37)
        Me.btnnuevocliente.TabIndex = 12
        Me.btnnuevocliente.Text = "Nuevo Cliente"
        Me.btnnuevocliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnnuevocliente.UseVisualStyleBackColor = False
        '
        'GestionReservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(967, 600)
        Me.Controls.Add(Me.btnnuevocliente)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.image)
        Me.Controls.Add(Me.IconButton2)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.bntCancelarReserva)
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
    Friend WithEvents bntCancelarReserva As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents image As FontAwesome.Sharp.IconButton
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnnuevocliente As FontAwesome.Sharp.IconButton
End Class
