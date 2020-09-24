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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VerReserva))
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.info = New System.Windows.Forms.Label()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.Mascota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Medicamentos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dosis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HorMedicina = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Peso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Raza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlimentacionHabitual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaReserv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDeSalida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HabitacionReserv = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Modificar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.estado = New System.Windows.Forms.Label()
        Me.monto = New System.Windows.Forms.Label()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'info
        '
        Me.info.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.info.AutoSize = True
        Me.info.BackColor = System.Drawing.Color.Transparent
        Me.info.Font = New System.Drawing.Font("Palatino Linotype", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.info.Location = New System.Drawing.Point(377, 9)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(261, 36)
        Me.info.TabIndex = 1
        Me.info.Text = "Viendo la Reserva De"
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.AllowUserToDeleteRows = False
        Me.dgvClientes.AllowUserToResizeColumns = False
        Me.dgvClientes.AllowUserToResizeRows = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.dgvClientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvClientes.BackgroundColor = System.Drawing.Color.White
        Me.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.dgvClientes.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvClientes.ColumnHeadersHeight = 27
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Mascota, Me.DataGridViewTextBoxColumn1, Me.Medicamentos, Me.Dosis, Me.HorMedicina, Me.Peso, Me.Raza, Me.AlimentacionHabitual, Me.FechaReserv, Me.FechaDeSalida, Me.HabitacionReserv, Me.Modificar, Me.Eliminar})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvClientes.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvClientes.EnableHeadersVisualStyles = False
        Me.dgvClientes.GridColor = System.Drawing.Color.White
        Me.dgvClientes.Location = New System.Drawing.Point(16, 152)
        Me.dgvClientes.MultiSelect = False
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.ReadOnly = True
        Me.dgvClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(210, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(210, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(210, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvClientes.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvClientes.RowHeadersVisible = False
        Me.dgvClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.dgvClientes.RowsDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvClientes.ShowEditingIcon = False
        Me.dgvClientes.Size = New System.Drawing.Size(948, 434)
        Me.dgvClientes.TabIndex = 30
        Me.dgvClientes.TabStop = False
        '
        'Mascota
        '
        Me.Mascota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Mascota.DefaultCellStyle = DataGridViewCellStyle3
        Me.Mascota.HeaderText = "Nombre de la Mascota"
        Me.Mascota.Name = "Mascota"
        Me.Mascota.ReadOnly = True
        Me.Mascota.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Mascota.Width = 202
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn1.HeaderText = "Fecha de Nacimiento"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 190
        '
        'Medicamentos
        '
        Me.Medicamentos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Medicamentos.DefaultCellStyle = DataGridViewCellStyle5
        Me.Medicamentos.HeaderText = "Medicamentos"
        Me.Medicamentos.Name = "Medicamentos"
        Me.Medicamentos.ReadOnly = True
        Me.Medicamentos.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Medicamentos.Width = 141
        '
        'Dosis
        '
        Me.Dosis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Dosis.DefaultCellStyle = DataGridViewCellStyle6
        Me.Dosis.HeaderText = "Dosis"
        Me.Dosis.Name = "Dosis"
        Me.Dosis.ReadOnly = True
        Me.Dosis.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dosis.Width = 75
        '
        'HorMedicina
        '
        Me.HorMedicina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HorMedicina.DefaultCellStyle = DataGridViewCellStyle7
        Me.HorMedicina.HeaderText = "Horario de Medicina"
        Me.HorMedicina.Name = "HorMedicina"
        Me.HorMedicina.ReadOnly = True
        Me.HorMedicina.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.HorMedicina.Width = 183
        '
        'Peso
        '
        Me.Peso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Peso.DefaultCellStyle = DataGridViewCellStyle8
        Me.Peso.HeaderText = "Peso"
        Me.Peso.Name = "Peso"
        Me.Peso.ReadOnly = True
        Me.Peso.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Peso.Width = 70
        '
        'Raza
        '
        Me.Raza.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Raza.HeaderText = "Raza"
        Me.Raza.Name = "Raza"
        Me.Raza.ReadOnly = True
        Me.Raza.Width = 70
        '
        'AlimentacionHabitual
        '
        Me.AlimentacionHabitual.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.AlimentacionHabitual.HeaderText = "Alimentacion Habitual"
        Me.AlimentacionHabitual.Name = "AlimentacionHabitual"
        Me.AlimentacionHabitual.ReadOnly = True
        Me.AlimentacionHabitual.Width = 193
        '
        'FechaReserv
        '
        Me.FechaReserv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.FechaReserv.HeaderText = "Fecha a Reservar"
        Me.FechaReserv.Name = "FechaReserv"
        Me.FechaReserv.ReadOnly = True
        Me.FechaReserv.Width = 164
        '
        'FechaDeSalida
        '
        Me.FechaDeSalida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.FechaDeSalida.HeaderText = "Fecha de Salida"
        Me.FechaDeSalida.Name = "FechaDeSalida"
        Me.FechaDeSalida.ReadOnly = True
        Me.FechaDeSalida.Width = 151
        '
        'HabitacionReserv
        '
        Me.HabitacionReserv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.HabitacionReserv.HeaderText = "Habitacion a Reservar"
        Me.HabitacionReserv.Name = "HabitacionReserv"
        Me.HabitacionReserv.ReadOnly = True
        Me.HabitacionReserv.Width = 179
        '
        'Modificar
        '
        Me.Modificar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle9.NullValue = CType(resources.GetObject("DataGridViewCellStyle9.NullValue"), Object)
        Me.Modificar.DefaultCellStyle = DataGridViewCellStyle9
        Me.Modificar.HeaderText = "Modificar"
        Me.Modificar.Image = Global.ProyectoProgramacion.My.Resources.Resources.editar
        Me.Modificar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Modificar.Name = "Modificar"
        Me.Modificar.ReadOnly = True
        Me.Modificar.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Modificar.Width = 82
        '
        'Eliminar
        '
        Me.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle10.NullValue = CType(resources.GetObject("DataGridViewCellStyle10.NullValue"), Object)
        Me.Eliminar.DefaultCellStyle = DataGridViewCellStyle10
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Image = Global.ProyectoProgramacion.My.Resources.Resources.eliminar
        Me.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Eliminar.Width = 73
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconPictureBox1.BackColor = System.Drawing.Color.White
        Me.IconPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.IconPictureBox1.IconColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.IconPictureBox1.IconSize = 34
        Me.IconPictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.IconPictureBox1.Location = New System.Drawing.Point(932, 3)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.IconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IconPictureBox1.TabIndex = 38
        Me.IconPictureBox1.TabStop = False
        '
        'estado
        '
        Me.estado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.estado.AutoSize = True
        Me.estado.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.estado.Location = New System.Drawing.Point(783, 71)
        Me.estado.Name = "estado"
        Me.estado.Size = New System.Drawing.Size(77, 26)
        Me.estado.TabIndex = 40
        Me.estado.Text = "Estado:"
        '
        'monto
        '
        Me.monto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.monto.AutoSize = True
        Me.monto.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.monto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.monto.Location = New System.Drawing.Point(783, 109)
        Me.monto.Name = "monto"
        Me.monto.Size = New System.Drawing.Size(77, 26)
        Me.monto.TabIndex = 39
        Me.monto.Text = "Monto:"
        '
        'VerReserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(970, 598)
        Me.Controls.Add(Me.estado)
        Me.Controls.Add(Me.monto)
        Me.Controls.Add(Me.IconPictureBox1)
        Me.Controls.Add(Me.info)
        Me.Controls.Add(Me.dgvClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VerReserva"
        Me.ShowInTaskbar = False
        Me.Text = "VerReserva"
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents info As Label
    Public WithEvents dgvClientes As DataGridView
    Friend WithEvents Mascota As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Medicamentos As DataGridViewTextBoxColumn
    Friend WithEvents Dosis As DataGridViewTextBoxColumn
    Friend WithEvents HorMedicina As DataGridViewTextBoxColumn
    Friend WithEvents Peso As DataGridViewTextBoxColumn
    Friend WithEvents Raza As DataGridViewTextBoxColumn
    Friend WithEvents AlimentacionHabitual As DataGridViewTextBoxColumn
    Friend WithEvents FechaReserv As DataGridViewTextBoxColumn
    Friend WithEvents FechaDeSalida As DataGridViewTextBoxColumn
    Friend WithEvents HabitacionReserv As DataGridViewImageColumn
    Friend WithEvents Modificar As DataGridViewImageColumn
    Friend WithEvents Eliminar As DataGridViewImageColumn
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents estado As Label
    Friend WithEvents monto As Label
End Class
