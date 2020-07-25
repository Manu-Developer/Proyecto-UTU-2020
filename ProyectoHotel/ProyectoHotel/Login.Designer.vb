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
        Me.pcbLogin = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.panelFinal = New System.Windows.Forms.Panel()
        Me.panelBienvenido = New System.Windows.Forms.Panel()
        Me.lblBienvenido = New System.Windows.Forms.Label()
        Me.ipbSalir = New FontAwesome.Sharp.IconPictureBox()
        Me.ipbMinimizar = New FontAwesome.Sharp.IconPictureBox()
        CType(Me.pcbLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ipbSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ipbMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pcbLogin
        '
        Me.pcbLogin.Image = Global.ProyectoHotel.My.Resources.Resources.Diseño_Login
        Me.pcbLogin.Location = New System.Drawing.Point(0, 0)
        Me.pcbLogin.Name = "pcbLogin"
        Me.pcbLogin.Size = New System.Drawing.Size(877, 500)
        Me.pcbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbLogin.TabIndex = 0
        Me.pcbLogin.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnLogin)
        Me.Panel1.Controls.Add(Me.txtContraseña)
        Me.Panel1.Controls.Add(Me.lblContraseña)
        Me.Panel1.Controls.Add(Me.txtUsuario)
        Me.Panel1.Controls.Add(Me.lblUsuario)
        Me.Panel1.Controls.Add(Me.panelFinal)
        Me.Panel1.Controls.Add(Me.panelBienvenido)
        Me.Panel1.Controls.Add(Me.lblBienvenido)
        Me.Panel1.Location = New System.Drawing.Point(502, 39)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(299, 402)
        Me.Panel1.TabIndex = 1
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Bahnschrift", 10.0!)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(45, 328)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(193, 37)
        Me.btnLogin.TabIndex = 7
        Me.btnLogin.Text = "Iniciar Sesion"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'txtContraseña
        '
        Me.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContraseña.Font = New System.Drawing.Font("Ebrima", 10.0!)
        Me.txtContraseña.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.txtContraseña.Location = New System.Drawing.Point(42, 252)
        Me.txtContraseña.Multiline = True
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(193, 29)
        Me.txtContraseña.TabIndex = 6
        Me.txtContraseña.UseSystemPasswordChar = True
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Font = New System.Drawing.Font("Ebrima", 10.0!)
        Me.lblContraseña.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.lblContraseña.Location = New System.Drawing.Point(44, 218)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(82, 19)
        Me.lblContraseña.TabIndex = 5
        Me.lblContraseña.Text = "Contraseña:"
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.Font = New System.Drawing.Font("Ebrima", 10.0!)
        Me.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.txtUsuario.Location = New System.Drawing.Point(48, 135)
        Me.txtUsuario.Multiline = True
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(193, 29)
        Me.txtUsuario.TabIndex = 4
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Ebrima", 10.0!)
        Me.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.lblUsuario.Location = New System.Drawing.Point(44, 102)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(59, 19)
        Me.lblUsuario.TabIndex = 3
        Me.lblUsuario.Text = "Usuario:"
        '
        'panelFinal
        '
        Me.panelFinal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.panelFinal.Location = New System.Drawing.Point(0, 397)
        Me.panelFinal.Name = "panelFinal"
        Me.panelFinal.Size = New System.Drawing.Size(402, 5)
        Me.panelFinal.TabIndex = 2
        '
        'panelBienvenido
        '
        Me.panelBienvenido.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.panelBienvenido.Location = New System.Drawing.Point(64, 54)
        Me.panelBienvenido.Name = "panelBienvenido"
        Me.panelBienvenido.Size = New System.Drawing.Size(165, 4)
        Me.panelBienvenido.TabIndex = 1
        '
        'lblBienvenido
        '
        Me.lblBienvenido.AutoSize = True
        Me.lblBienvenido.Font = New System.Drawing.Font("Bahnschrift", 23.0!)
        Me.lblBienvenido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.lblBienvenido.Location = New System.Drawing.Point(64, 19)
        Me.lblBienvenido.Name = "lblBienvenido"
        Me.lblBienvenido.Size = New System.Drawing.Size(171, 37)
        Me.lblBienvenido.TabIndex = 0
        Me.lblBienvenido.Text = "Bienvenido"
        '
        'ipbSalir
        '
        Me.ipbSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ipbSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ipbSalir.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.ipbSalir.IconColor = System.Drawing.Color.White
        Me.ipbSalir.IconSize = 34
        Me.ipbSalir.Location = New System.Drawing.Point(844, 3)
        Me.ipbSalir.Name = "ipbSalir"
        Me.ipbSalir.Size = New System.Drawing.Size(38, 34)
        Me.ipbSalir.TabIndex = 2
        Me.ipbSalir.TabStop = False
        '
        'ipbMinimizar
        '
        Me.ipbMinimizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ipbMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ipbMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.ipbMinimizar.IconColor = System.Drawing.Color.White
        Me.ipbMinimizar.IconSize = 34
        Me.ipbMinimizar.Location = New System.Drawing.Point(810, 1)
        Me.ipbMinimizar.Name = "ipbMinimizar"
        Me.ipbMinimizar.Size = New System.Drawing.Size(38, 34)
        Me.ipbMinimizar.TabIndex = 3
        Me.ipbMinimizar.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 499)
        Me.Controls.Add(Me.ipbMinimizar)
        Me.Controls.Add(Me.ipbSalir)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pcbLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iniciar Sesion"
        CType(Me.pcbLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ipbSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ipbMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pcbLogin As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents panelFinal As Panel
    Friend WithEvents panelBienvenido As Panel
    Friend WithEvents lblBienvenido As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents lblUsuario As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents lblContraseña As Label
    Friend WithEvents ipbSalir As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents ipbMinimizar As FontAwesome.Sharp.IconPictureBox
End Class
