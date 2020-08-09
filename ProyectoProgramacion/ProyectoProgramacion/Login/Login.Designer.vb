<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.pcbImagen = New System.Windows.Forms.PictureBox()
        Me.panelPrincipal = New System.Windows.Forms.Panel()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.panelDebajo = New System.Windows.Forms.Panel()
        Me.panelBienvenido = New System.Windows.Forms.Panel()
        Me.lblBienvenido = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.ipbMinimizar = New FontAwesome.Sharp.IconPictureBox()
        Me.ipbSalir = New FontAwesome.Sharp.IconPictureBox()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.usuario = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.contraseña = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        CType(Me.pcbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelPrincipal.SuspendLayout()
        CType(Me.ipbMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ipbSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pcbImagen
        '
        Me.pcbImagen.Image = Global.ProyectoProgramacion.My.Resources.Resources.Diseño_Login
        Me.pcbImagen.Location = New System.Drawing.Point(-1, 0)
        Me.pcbImagen.Name = "pcbImagen"
        Me.pcbImagen.Size = New System.Drawing.Size(831, 471)
        Me.pcbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbImagen.TabIndex = 1
        Me.pcbImagen.TabStop = False
        '
        'panelPrincipal
        '
        Me.panelPrincipal.BackColor = System.Drawing.Color.Transparent
        Me.panelPrincipal.BackgroundImage = Global.ProyectoProgramacion.My.Resources.Resources.Shadow_Notificaciones
        Me.panelPrincipal.Controls.Add(Me.BunifuFlatButton1)
        Me.panelPrincipal.Controls.Add(Me.lblContraseña)
        Me.panelPrincipal.Controls.Add(Me.lblNombre)
        Me.panelPrincipal.Controls.Add(Me.panelDebajo)
        Me.panelPrincipal.Controls.Add(Me.panelBienvenido)
        Me.panelPrincipal.Controls.Add(Me.lblBienvenido)
        Me.panelPrincipal.Location = New System.Drawing.Point(479, 38)
        Me.panelPrincipal.Name = "panelPrincipal"
        Me.panelPrincipal.Size = New System.Drawing.Size(282, 390)
        Me.panelPrincipal.TabIndex = 2
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 7
        Me.BunifuFlatButton1.ButtonText = "Iniciar Sesión"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = CType(resources.GetObject("BunifuFlatButton1.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = False
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = False
        Me.BunifuFlatButton1.IconZoom = 90.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(49, 331)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(193, 36)
        Me.BunifuFlatButton1.TabIndex = 6
        Me.BunifuFlatButton1.Text = "Iniciar Sesión"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContraseña.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblContraseña.Location = New System.Drawing.Point(44, 212)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(100, 20)
        Me.lblContraseña.TabIndex = 11
        Me.lblContraseña.Text = "Constraseña"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblNombre.Location = New System.Drawing.Point(44, 98)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(68, 20)
        Me.lblNombre.TabIndex = 10
        Me.lblNombre.Text = "Usuario:"
        '
        'panelDebajo
        '
        Me.panelDebajo.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.panelDebajo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.panelDebajo.Location = New System.Drawing.Point(0, 386)
        Me.panelDebajo.Name = "panelDebajo"
        Me.panelDebajo.Size = New System.Drawing.Size(282, 7)
        Me.panelDebajo.TabIndex = 4
        '
        'panelBienvenido
        '
        Me.panelBienvenido.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.panelBienvenido.ForeColor = System.Drawing.SystemColors.ControlText
        Me.panelBienvenido.Location = New System.Drawing.Point(64, 56)
        Me.panelBienvenido.Name = "panelBienvenido"
        Me.panelBienvenido.Size = New System.Drawing.Size(150, 4)
        Me.panelBienvenido.TabIndex = 3
        '
        'lblBienvenido
        '
        Me.lblBienvenido.AutoSize = True
        Me.lblBienvenido.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBienvenido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblBienvenido.Location = New System.Drawing.Point(66, 24)
        Me.lblBienvenido.Name = "lblBienvenido"
        Me.lblBienvenido.Size = New System.Drawing.Size(144, 29)
        Me.lblBienvenido.TabIndex = 1
        Me.lblBienvenido.Text = "Bienvenido"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(239, 281)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(192, 36)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.TabStop = False
        Me.btnLogin.Text = "Iniciar Sesión"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'ipbMinimizar
        '
        Me.ipbMinimizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ipbMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ipbMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.ipbMinimizar.IconColor = System.Drawing.Color.White
        Me.ipbMinimizar.IconSize = 34
        Me.ipbMinimizar.Location = New System.Drawing.Point(772, -1)
        Me.ipbMinimizar.Name = "ipbMinimizar"
        Me.ipbMinimizar.Size = New System.Drawing.Size(32, 32)
        Me.ipbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ipbMinimizar.TabIndex = 5
        Me.ipbMinimizar.TabStop = False
        '
        'ipbSalir
        '
        Me.ipbSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ipbSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ipbSalir.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.ipbSalir.IconColor = System.Drawing.Color.White
        Me.ipbSalir.IconSize = 34
        Me.ipbSalir.Location = New System.Drawing.Point(798, -1)
        Me.ipbSalir.Name = "ipbSalir"
        Me.ipbSalir.Size = New System.Drawing.Size(32, 32)
        Me.ipbSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ipbSalir.TabIndex = 4
        Me.ipbSalir.TabStop = False
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 10
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 20
        Me.BunifuElipse2.TargetControl = Me.panelPrincipal
        '
        'usuario
        '
        Me.usuario.AutoSize = True
        Me.usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.usuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.usuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.usuario.HintForeColor = System.Drawing.Color.Silver
        Me.usuario.HintText = "Ingrese Usuario"
        Me.usuario.isPassword = False
        Me.usuario.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.usuario.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.usuario.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.usuario.LineThickness = 3
        Me.usuario.Location = New System.Drawing.Point(528, 171)
        Me.usuario.Margin = New System.Windows.Forms.Padding(4)
        Me.usuario.Name = "usuario"
        Me.usuario.Size = New System.Drawing.Size(193, 45)
        Me.usuario.TabIndex = 8
        Me.usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'contraseña
        '
        Me.contraseña.AutoSize = True
        Me.contraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.contraseña.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.contraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.contraseña.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.contraseña.HintForeColor = System.Drawing.Color.Silver
        Me.contraseña.HintText = "Ingrese Contraseña"
        Me.contraseña.isPassword = True
        Me.contraseña.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.contraseña.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.contraseña.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.contraseña.LineThickness = 3
        Me.contraseña.Location = New System.Drawing.Point(528, 293)
        Me.contraseña.Margin = New System.Windows.Forms.Padding(4)
        Me.contraseña.Name = "contraseña"
        Me.contraseña.Size = New System.Drawing.Size(193, 45)
        Me.contraseña.TabIndex = 9
        Me.contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 469)
        Me.Controls.Add(Me.contraseña)
        Me.Controls.Add(Me.usuario)
        Me.Controls.Add(Me.ipbMinimizar)
        Me.Controls.Add(Me.ipbSalir)
        Me.Controls.Add(Me.panelPrincipal)
        Me.Controls.Add(Me.pcbImagen)
        Me.Controls.Add(Me.btnLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.pcbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelPrincipal.ResumeLayout(False)
        Me.panelPrincipal.PerformLayout()
        CType(Me.ipbMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ipbSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pcbImagen As PictureBox
    Friend WithEvents panelPrincipal As Panel
    Friend WithEvents lblContraseña As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents panelDebajo As Panel
    Friend WithEvents panelBienvenido As Panel
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblBienvenido As Label
    Friend WithEvents ipbMinimizar As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents ipbSalir As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents usuario As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents contraseña As Bunifu.Framework.UI.BunifuMaterialTextbox
End Class
