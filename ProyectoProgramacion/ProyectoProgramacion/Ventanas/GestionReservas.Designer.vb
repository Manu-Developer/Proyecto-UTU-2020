<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestionReservas
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
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionReservas))
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.CI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaNac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modificar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.VerReservas = New System.Windows.Forms.DataGridViewImageColumn()
        Me.txtBuscar = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btnNuevoCliente = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.AllowUserToDeleteRows = False
        Me.dgvClientes.AllowUserToResizeColumns = False
        Me.dgvClientes.AllowUserToResizeRows = False
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.dgvClientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle18
        Me.dgvClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvClientes.BackgroundColor = System.Drawing.Color.White
        Me.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.dgvClientes.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.dgvClientes.ColumnHeadersHeight = 27
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CI, Me.Nombre, Me.Apellido, Me.Direccion, Me.Telefono, Me.FechaNac, Me.Modificar, Me.Eliminar, Me.VerReservas})
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle29.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle29.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvClientes.DefaultCellStyle = DataGridViewCellStyle29
        Me.dgvClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvClientes.EnableHeadersVisualStyles = False
        Me.dgvClientes.GridColor = System.Drawing.Color.White
        Me.dgvClientes.Location = New System.Drawing.Point(17, 96)
        Me.dgvClientes.MultiSelect = False
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.ReadOnly = True
        Me.dgvClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle30.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(210, Byte), Integer))
        DataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(210, Byte), Integer))
        DataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(210, Byte), Integer))
        DataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvClientes.RowHeadersDefaultCellStyle = DataGridViewCellStyle30
        Me.dgvClientes.RowHeadersVisible = False
        Me.dgvClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle31.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle31.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.dgvClientes.RowsDefaultCellStyle = DataGridViewCellStyle31
        Me.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvClientes.ShowEditingIcon = False
        Me.dgvClientes.Size = New System.Drawing.Size(938, 492)
        Me.dgvClientes.TabIndex = 2
        Me.dgvClientes.TabStop = False
        '
        'CI
        '
        Me.CI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CI.DefaultCellStyle = DataGridViewCellStyle20
        Me.CI.HeaderText = "Cedula"
        Me.CI.Name = "CI"
        Me.CI.ReadOnly = True
        Me.CI.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CI.Width = 83
        '
        'Nombre
        '
        Me.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Nombre.DefaultCellStyle = DataGridViewCellStyle21
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Apellido
        '
        Me.Apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Apellido.DefaultCellStyle = DataGridViewCellStyle22
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        Me.Apellido.ReadOnly = True
        Me.Apellido.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Direccion
        '
        Me.Direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Direccion.DefaultCellStyle = DataGridViewCellStyle23
        Me.Direccion.HeaderText = "Direccion"
        Me.Direccion.Name = "Direccion"
        Me.Direccion.ReadOnly = True
        Me.Direccion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Telefono
        '
        Me.Telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Telefono.DefaultCellStyle = DataGridViewCellStyle24
        Me.Telefono.HeaderText = "Telefono"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = True
        Me.Telefono.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'FechaNac
        '
        Me.FechaNac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FechaNac.DefaultCellStyle = DataGridViewCellStyle25
        Me.FechaNac.HeaderText = "Fecha de Nacimiento"
        Me.FechaNac.Name = "FechaNac"
        Me.FechaNac.ReadOnly = True
        Me.FechaNac.Width = 190
        '
        'Modificar
        '
        Me.Modificar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle26.NullValue = CType(resources.GetObject("DataGridViewCellStyle26.NullValue"), Object)
        Me.Modificar.DefaultCellStyle = DataGridViewCellStyle26
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
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle27.NullValue = CType(resources.GetObject("DataGridViewCellStyle27.NullValue"), Object)
        Me.Eliminar.DefaultCellStyle = DataGridViewCellStyle27
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Image = Global.ProyectoProgramacion.My.Resources.Resources.eliminar
        Me.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Eliminar.Width = 73
        '
        'VerReservas
        '
        Me.VerReservas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle28.NullValue = CType(resources.GetObject("DataGridViewCellStyle28.NullValue"), Object)
        Me.VerReservas.DefaultCellStyle = DataGridViewCellStyle28
        Me.VerReservas.HeaderText = "Ver Reservas"
        Me.VerReservas.Image = Global.ProyectoProgramacion.My.Resources.Resources.reserva
        Me.VerReservas.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.VerReservas.Name = "VerReservas"
        Me.VerReservas.ReadOnly = True
        Me.VerReservas.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.VerReservas.Width = 113
        '
        'txtBuscar
        '
        Me.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtBuscar.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.txtBuscar.HintText = "Buscar"
        Me.txtBuscar.isPassword = False
        Me.txtBuscar.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.txtBuscar.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.txtBuscar.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.txtBuscar.LineThickness = 3
        Me.txtBuscar.Location = New System.Drawing.Point(17, 14)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(682, 40)
        Me.txtBuscar.TabIndex = 18
        Me.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle32.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle32.NullValue = CType(resources.GetObject("DataGridViewCellStyle32.NullValue"), Object)
        Me.DataGridViewImageColumn1.DefaultCellStyle = DataGridViewCellStyle32
        Me.DataGridViewImageColumn1.HeaderText = "Modificar"
        Me.DataGridViewImageColumn1.Image = Global.ProyectoProgramacion.My.Resources.Resources.editar
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle33.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle33.NullValue = CType(resources.GetObject("DataGridViewCellStyle33.NullValue"), Object)
        Me.DataGridViewImageColumn2.DefaultCellStyle = DataGridViewCellStyle33
        Me.DataGridViewImageColumn2.HeaderText = "Eliminar"
        Me.DataGridViewImageColumn2.Image = Global.ProyectoProgramacion.My.Resources.Resources.eliminar
        Me.DataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.ReadOnly = True
        Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'DataGridViewImageColumn3
        '
        Me.DataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle34.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle34.NullValue = CType(resources.GetObject("DataGridViewCellStyle34.NullValue"), Object)
        Me.DataGridViewImageColumn3.DefaultCellStyle = DataGridViewCellStyle34
        Me.DataGridViewImageColumn3.HeaderText = "Ver Reservas"
        Me.DataGridViewImageColumn3.Image = Global.ProyectoProgramacion.My.Resources.Resources.reserva
        Me.DataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn3.Name = "DataGridViewImageColumn3"
        Me.DataGridViewImageColumn3.ReadOnly = True
        Me.DataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'btnNuevoCliente
        '
        Me.btnNuevoCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevoCliente.BackColor = System.Drawing.Color.White
        Me.btnNuevoCliente.FlatAppearance.BorderSize = 0
        Me.btnNuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoCliente.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnNuevoCliente.Image = Global.ProyectoProgramacion.My.Resources.Resources.anadir
        Me.btnNuevoCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevoCliente.Location = New System.Drawing.Point(784, 14)
        Me.btnNuevoCliente.Name = "btnNuevoCliente"
        Me.btnNuevoCliente.Size = New System.Drawing.Size(150, 59)
        Me.btnNuevoCliente.TabIndex = 15
        Me.btnNuevoCliente.TabStop = False
        Me.btnNuevoCliente.Text = "Nuevo Cliente"
        Me.btnNuevoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevoCliente.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(970, 598)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.ProyectoProgramacion.My.Resources.Resources.Buscar
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(662, 14)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(37, 37)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = False
        '
        'GestionReservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(967, 600)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.btnNuevoCliente)
        Me.Controls.Add(Me.dgvClientes)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GestionReservas"
        Me.Text = "Hotel Canino"
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents dgvClientes As DataGridView
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn3 As DataGridViewImageColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnNuevoCliente As Button
    Friend WithEvents txtBuscar As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents CI As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Direccion As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents FechaNac As DataGridViewTextBoxColumn
    Friend WithEvents Modificar As DataGridViewImageColumn
    Friend WithEvents Eliminar As DataGridViewImageColumn
    Friend WithEvents VerReservas As DataGridViewImageColumn
End Class
