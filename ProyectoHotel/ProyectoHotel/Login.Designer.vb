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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ipbSalir = New FontAwesome.Sharp.IconPictureBox()
        Me.ipbMinimizar = New FontAwesome.Sharp.IconPictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ipbSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ipbMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProyectoHotel.My.Resources.Resources.Diseño_Login
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(877, 500)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnLogin)
        Me.Panel1.Controls.Add(Me.txtContraseña)
        Me.Panel1.Controls.Add(Me.lblContraseña)
        Me.Panel1.Controls.Add(Me.txtUsuario)
        Me.Panel1.Controls.Add(Me.lblUsuario)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label1)
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 397)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(402, 5)
        Me.Panel3.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(64, 54)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(165, 4)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 23.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(64, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bienvenido"
        '
        'ipbSalir
        '
        Me.ipbSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ipbSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ipbSalir.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.ipbSalir.IconColor = System.Drawing.Color.White
        Me.ipbSalir.IconSize = 31
        Me.ipbSalir.Location = New System.Drawing.Point(844, 2)
        Me.ipbSalir.Name = "ipbSalir"
        Me.ipbSalir.Size = New System.Drawing.Size(31, 34)
        Me.ipbSalir.TabIndex = 2
        Me.ipbSalir.TabStop = False
        '
        'ipbMinimizar
        '
        Me.ipbMinimizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ipbMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ipbMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.ipbMinimizar.IconColor = System.Drawing.Color.White
        Me.ipbMinimizar.IconSize = 31
        Me.ipbMinimizar.Location = New System.Drawing.Point(815, -1)
        Me.ipbMinimizar.Name = "ipbMinimizar"
        Me.ipbMinimizar.Size = New System.Drawing.Size(31, 34)
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
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iniciar Sesion"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ipbSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ipbMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents lblUsuario As Label
    Friend WithEvents ipbSalir As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents ipbMinimizar As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents lblContraseña As Label
End Class
