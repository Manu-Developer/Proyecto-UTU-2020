<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevaReserva
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
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NuevaReserva))
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.btnNuevoCliente = New System.Windows.Forms.Button()
        Me.BunifuDropdown5 = New Bunifu.Framework.UI.BunifuDropdown()
        Me.BunifuDropdown1 = New Bunifu.Framework.UI.BunifuDropdown()
        Me.BunifuDropdown4 = New Bunifu.Framework.UI.BunifuDropdown()
        Me.BunifuDropdown3 = New Bunifu.Framework.UI.BunifuDropdown()
        Me.BunifuDropdown2 = New Bunifu.Framework.UI.BunifuDropdown()
        Me.BunifuDatepicker1 = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.fechaNac = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.NombreMascota = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.info = New System.Windows.Forms.Label()
        Me.gerenteSalir = New FontAwesome.Sharp.IconPictureBox()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gerenteSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.AllowUserToDeleteRows = False
        Me.dgvClientes.AllowUserToResizeColumns = False
        Me.dgvClientes.AllowUserToResizeRows = False
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.dgvClientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle14
        Me.dgvClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvClientes.BackgroundColor = System.Drawing.Color.White
        Me.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.dgvClientes.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.dgvClientes.ColumnHeadersHeight = 27
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Mascota, Me.DataGridViewTextBoxColumn1, Me.Medicamentos, Me.Dosis, Me.HorMedicina, Me.Peso, Me.Raza, Me.AlimentacionHabitual, Me.FechaReserv, Me.FechaDeSalida, Me.HabitacionReserv, Me.Modificar, Me.Eliminar})
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle24.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvClientes.DefaultCellStyle = DataGridViewCellStyle24
        Me.dgvClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvClientes.EnableHeadersVisualStyles = False
        Me.dgvClientes.GridColor = System.Drawing.Color.White
        Me.dgvClientes.Location = New System.Drawing.Point(10, 234)
        Me.dgvClientes.MultiSelect = False
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.ReadOnly = True
        Me.dgvClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle25.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(210, Byte), Integer))
        DataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(210, Byte), Integer))
        DataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(210, Byte), Integer))
        DataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvClientes.RowHeadersDefaultCellStyle = DataGridViewCellStyle25
        Me.dgvClientes.RowHeadersVisible = False
        Me.dgvClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle26.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.dgvClientes.RowsDefaultCellStyle = DataGridViewCellStyle26
        Me.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvClientes.ShowEditingIcon = False
        Me.dgvClientes.Size = New System.Drawing.Size(948, 361)
        Me.dgvClientes.TabIndex = 42
        Me.dgvClientes.TabStop = False
        '
        'Mascota
        '
        Me.Mascota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Mascota.DefaultCellStyle = DataGridViewCellStyle16
        Me.Mascota.HeaderText = "Nombre de la Mascota"
        Me.Mascota.Name = "Mascota"
        Me.Mascota.ReadOnly = True
        Me.Mascota.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Mascota.Width = 202
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridViewTextBoxColumn1.HeaderText = "Fecha de Nacimiento"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 190
        '
        'Medicamentos
        '
        Me.Medicamentos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Medicamentos.DefaultCellStyle = DataGridViewCellStyle18
        Me.Medicamentos.HeaderText = "Medicamentos"
        Me.Medicamentos.Name = "Medicamentos"
        Me.Medicamentos.ReadOnly = True
        Me.Medicamentos.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Medicamentos.Width = 141
        '
        'Dosis
        '
        Me.Dosis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Dosis.DefaultCellStyle = DataGridViewCellStyle19
        Me.Dosis.HeaderText = "Dosis"
        Me.Dosis.Name = "Dosis"
        Me.Dosis.ReadOnly = True
        Me.Dosis.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dosis.Width = 75
        '
        'HorMedicina
        '
        Me.HorMedicina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HorMedicina.DefaultCellStyle = DataGridViewCellStyle20
        Me.HorMedicina.HeaderText = "Horario de Medicina"
        Me.HorMedicina.Name = "HorMedicina"
        Me.HorMedicina.ReadOnly = True
        Me.HorMedicina.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.HorMedicina.Width = 183
        '
        'Peso
        '
        Me.Peso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Peso.DefaultCellStyle = DataGridViewCellStyle21
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
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle22.NullValue = CType(resources.GetObject("DataGridViewCellStyle22.NullValue"), Object)
        Me.Modificar.DefaultCellStyle = DataGridViewCellStyle22
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
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle23.NullValue = CType(resources.GetObject("DataGridViewCellStyle23.NullValue"), Object)
        Me.Eliminar.DefaultCellStyle = DataGridViewCellStyle23
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Image = Global.ProyectoProgramacion.My.Resources.Resources.eliminar
        Me.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Eliminar.Width = 73
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
        Me.btnNuevoCliente.Location = New System.Drawing.Point(748, 24)
        Me.btnNuevoCliente.Name = "btnNuevoCliente"
        Me.btnNuevoCliente.Size = New System.Drawing.Size(181, 48)
        Me.btnNuevoCliente.TabIndex = 34
        Me.btnNuevoCliente.TabStop = False
        Me.btnNuevoCliente.Text = "Agregar Mascota"
        Me.btnNuevoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevoCliente.UseVisualStyleBackColor = False
        '
        'BunifuDropdown5
        '
        Me.BunifuDropdown5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BunifuDropdown5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuDropdown5.BorderRadius = 50
        Me.BunifuDropdown5.ForeColor = System.Drawing.Color.White
        Me.BunifuDropdown5.Items = New String(-1) {}
        Me.BunifuDropdown5.Location = New System.Drawing.Point(212, 169)
        Me.BunifuDropdown5.Name = "BunifuDropdown5"
        Me.BunifuDropdown5.NomalColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuDropdown5.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuDropdown5.selectedIndex = -1
        Me.BunifuDropdown5.Size = New System.Drawing.Size(189, 26)
        Me.BunifuDropdown5.TabIndex = 41
        '
        'BunifuDropdown1
        '
        Me.BunifuDropdown1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BunifuDropdown1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuDropdown1.BorderRadius = 50
        Me.BunifuDropdown1.ForeColor = System.Drawing.Color.White
        Me.BunifuDropdown1.Items = New String(-1) {}
        Me.BunifuDropdown1.Location = New System.Drawing.Point(404, 98)
        Me.BunifuDropdown1.Name = "BunifuDropdown1"
        Me.BunifuDropdown1.NomalColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuDropdown1.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuDropdown1.selectedIndex = -1
        Me.BunifuDropdown1.Size = New System.Drawing.Size(189, 26)
        Me.BunifuDropdown1.TabIndex = 40
        '
        'BunifuDropdown4
        '
        Me.BunifuDropdown4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BunifuDropdown4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuDropdown4.BorderRadius = 50
        Me.BunifuDropdown4.ForeColor = System.Drawing.Color.White
        Me.BunifuDropdown4.Items = New String(-1) {}
        Me.BunifuDropdown4.Location = New System.Drawing.Point(602, 169)
        Me.BunifuDropdown4.Name = "BunifuDropdown4"
        Me.BunifuDropdown4.NomalColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuDropdown4.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuDropdown4.selectedIndex = -1
        Me.BunifuDropdown4.Size = New System.Drawing.Size(189, 26)
        Me.BunifuDropdown4.TabIndex = 39
        '
        'BunifuDropdown3
        '
        Me.BunifuDropdown3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BunifuDropdown3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuDropdown3.BorderRadius = 50
        Me.BunifuDropdown3.ForeColor = System.Drawing.Color.White
        Me.BunifuDropdown3.Items = New String(-1) {}
        Me.BunifuDropdown3.Location = New System.Drawing.Point(407, 169)
        Me.BunifuDropdown3.Name = "BunifuDropdown3"
        Me.BunifuDropdown3.NomalColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuDropdown3.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuDropdown3.selectedIndex = -1
        Me.BunifuDropdown3.Size = New System.Drawing.Size(189, 26)
        Me.BunifuDropdown3.TabIndex = 38
        '
        'BunifuDropdown2
        '
        Me.BunifuDropdown2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BunifuDropdown2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuDropdown2.BorderRadius = 50
        Me.BunifuDropdown2.ForeColor = System.Drawing.Color.White
        Me.BunifuDropdown2.Items = New String(-1) {}
        Me.BunifuDropdown2.Location = New System.Drawing.Point(599, 98)
        Me.BunifuDropdown2.Name = "BunifuDropdown2"
        Me.BunifuDropdown2.NomalColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuDropdown2.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuDropdown2.selectedIndex = -1
        Me.BunifuDropdown2.Size = New System.Drawing.Size(189, 26)
        Me.BunifuDropdown2.TabIndex = 37
        '
        'BunifuDatepicker1
        '
        Me.BunifuDatepicker1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BunifuDatepicker1.BackColor = System.Drawing.Color.White
        Me.BunifuDatepicker1.BorderRadius = 2
        Me.BunifuDatepicker1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.BunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.BunifuDatepicker1.FormatCustom = Nothing
        Me.BunifuDatepicker1.Location = New System.Drawing.Point(14, 166)
        Me.BunifuDatepicker1.Name = "BunifuDatepicker1"
        Me.BunifuDatepicker1.Size = New System.Drawing.Size(192, 29)
        Me.BunifuDatepicker1.TabIndex = 36
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
        Me.fechaNac.Location = New System.Drawing.Point(202, 95)
        Me.fechaNac.Name = "fechaNac"
        Me.fechaNac.Size = New System.Drawing.Size(192, 29)
        Me.fechaNac.TabIndex = 35
        Me.fechaNac.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
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
        Me.NombreMascota.Location = New System.Drawing.Point(10, 80)
        Me.NombreMascota.Margin = New System.Windows.Forms.Padding(4)
        Me.NombreMascota.Name = "NombreMascota"
        Me.NombreMascota.Size = New System.Drawing.Size(185, 44)
        Me.NombreMascota.TabIndex = 43
        Me.NombreMascota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'info
        '
        Me.info.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.info.AutoSize = True
        Me.info.BackColor = System.Drawing.Color.Transparent
        Me.info.Font = New System.Drawing.Font("Palatino Linotype", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.info.Location = New System.Drawing.Point(457, 9)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(187, 36)
        Me.info.TabIndex = 1
        Me.info.Text = "Nueva Reserva"
        '
        'gerenteSalir
        '
        Me.gerenteSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gerenteSalir.BackColor = System.Drawing.Color.White
        Me.gerenteSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gerenteSalir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.gerenteSalir.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.gerenteSalir.IconColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.gerenteSalir.IconSize = 34
        Me.gerenteSalir.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.gerenteSalir.Location = New System.Drawing.Point(935, 2)
        Me.gerenteSalir.Name = "gerenteSalir"
        Me.gerenteSalir.Size = New System.Drawing.Size(32, 32)
        Me.gerenteSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.gerenteSalir.TabIndex = 44
        Me.gerenteSalir.TabStop = False
        '
        'NuevaReserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(970, 598)
        Me.Controls.Add(Me.gerenteSalir)
        Me.Controls.Add(Me.info)
        Me.Controls.Add(Me.NombreMascota)
        Me.Controls.Add(Me.dgvClientes)
        Me.Controls.Add(Me.btnNuevoCliente)
        Me.Controls.Add(Me.BunifuDropdown5)
        Me.Controls.Add(Me.BunifuDropdown1)
        Me.Controls.Add(Me.BunifuDropdown4)
        Me.Controls.Add(Me.BunifuDropdown3)
        Me.Controls.Add(Me.BunifuDropdown2)
        Me.Controls.Add(Me.BunifuDatepicker1)
        Me.Controls.Add(Me.fechaNac)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "NuevaReserva"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "NuevaReserva"
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gerenteSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents dgvClientes As DataGridView
    Friend WithEvents btnNuevoCliente As Button
    Friend WithEvents BunifuDropdown5 As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents BunifuDropdown1 As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents BunifuDropdown4 As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents BunifuDropdown3 As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents BunifuDropdown2 As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents BunifuDatepicker1 As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents fechaNac As Bunifu.Framework.UI.BunifuDatepicker
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
    Friend WithEvents NombreMascota As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents info As Label
    Friend WithEvents gerenteSalir As FontAwesome.Sharp.IconPictureBox
End Class
