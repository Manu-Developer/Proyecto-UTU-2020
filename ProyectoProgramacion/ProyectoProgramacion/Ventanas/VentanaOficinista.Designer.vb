﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VentanaOficinista
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentanaOficinista))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnGestion = New FontAwesome.Sharp.IconButton()
        Me.btnInicio = New FontAwesome.Sharp.IconButton()
        Me.txtNombreUsuario = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnCerarSesion = New FontAwesome.Sharp.IconButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.photo = New System.Windows.Forms.PictureBox()
        Me.edit = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.nombre = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.oficinistaSalir = New FontAwesome.Sharp.IconPictureBox()
        Me.oficinistaMinimizar = New FontAwesome.Sharp.IconPictureBox()
        Me.lblGeneral = New System.Windows.Forms.Label()
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.phototrasparent = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.horayfecha = New System.Windows.Forms.Timer(Me.components)
        Me.PanelDesktop = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.lblhora = New System.Windows.Forms.Label()
        Me.pbLogoEmpresa = New System.Windows.Forms.PictureBox()
        Me.BunifuSeparator5 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.PanelMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PictureBox1.SuspendLayout()
        CType(Me.photo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.photo.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.oficinistaSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.oficinistaMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDesktop.SuspendLayout()
        CType(Me.pbLogoEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.Panel1)
        Me.PanelMenu.Controls.Add(Me.txtNombreUsuario)
        Me.PanelMenu.Controls.Add(Me.btnCerarSesion)
        Me.PanelMenu.Controls.Add(Me.PictureBox1)
        resources.ApplyResources(Me.PanelMenu, "PanelMenu")
        Me.PanelMenu.Name = "PanelMenu"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnGestion)
        Me.Panel1.Controls.Add(Me.btnInicio)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'btnGestion
        '
        Me.btnGestion.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.btnGestion, "btnGestion")
        Me.btnGestion.FlatAppearance.BorderSize = 0
        Me.btnGestion.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnGestion.ForeColor = System.Drawing.Color.White
        Me.btnGestion.IconChar = FontAwesome.Sharp.IconChar.AddressBook
        Me.btnGestion.IconColor = System.Drawing.Color.White
        Me.btnGestion.IconSize = 32
        Me.btnGestion.Name = "btnGestion"
        Me.btnGestion.Rotation = 0R
        Me.btnGestion.UseVisualStyleBackColor = True
        '
        'btnInicio
        '
        Me.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.btnInicio, "btnInicio")
        Me.btnInicio.FlatAppearance.BorderSize = 0
        Me.btnInicio.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnInicio.ForeColor = System.Drawing.Color.White
        Me.btnInicio.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.btnInicio.IconColor = System.Drawing.Color.White
        Me.btnInicio.IconSize = 32
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Rotation = 0R
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'txtNombreUsuario
        '
        resources.ApplyResources(Me.txtNombreUsuario, "txtNombreUsuario")
        Me.txtNombreUsuario.ForeColor = System.Drawing.Color.White
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        '
        'btnCerarSesion
        '
        resources.ApplyResources(Me.btnCerarSesion, "btnCerarSesion")
        Me.btnCerarSesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerarSesion.FlatAppearance.BorderSize = 0
        Me.btnCerarSesion.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnCerarSesion.ForeColor = System.Drawing.Color.White
        Me.btnCerarSesion.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        Me.btnCerarSesion.IconColor = System.Drawing.Color.White
        Me.btnCerarSesion.IconSize = 32
        Me.btnCerarSesion.Name = "btnCerarSesion"
        Me.btnCerarSesion.Rotation = 0R
        Me.btnCerarSesion.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Controls.Add(Me.photo)
        Me.PictureBox1.Image = Global.ProyectoProgramacion.My.Resources.Resources.imagenPrueba2
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'photo
        '
        Me.photo.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.photo.Controls.Add(Me.edit)
        resources.ApplyResources(Me.photo, "photo")
        Me.photo.Name = "photo"
        Me.photo.TabStop = False
        '
        'edit
        '
        resources.ApplyResources(Me.edit, "edit")
        Me.edit.BackColor = System.Drawing.Color.Transparent
        Me.edit.Name = "edit"
        '
        'nombre
        '
        resources.ApplyResources(Me.nombre, "nombre")
        Me.nombre.ForeColor = System.Drawing.Color.White
        Me.nombre.Name = "nombre"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Panel3.Controls.Add(Me.oficinistaSalir)
        Me.Panel3.Controls.Add(Me.oficinistaMinimizar)
        Me.Panel3.Controls.Add(Me.lblGeneral)
        Me.Panel3.Controls.Add(Me.IconCurrentForm)
        Me.Panel3.Cursor = System.Windows.Forms.Cursors.Arrow
        resources.ApplyResources(Me.Panel3, "Panel3")
        Me.Panel3.Name = "Panel3"
        '
        'oficinistaSalir
        '
        resources.ApplyResources(Me.oficinistaSalir, "oficinistaSalir")
        Me.oficinistaSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.oficinistaSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.oficinistaSalir.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.oficinistaSalir.IconColor = System.Drawing.Color.White
        Me.oficinistaSalir.IconSize = 34
        Me.oficinistaSalir.Name = "oficinistaSalir"
        Me.oficinistaSalir.TabStop = False
        '
        'oficinistaMinimizar
        '
        resources.ApplyResources(Me.oficinistaMinimizar, "oficinistaMinimizar")
        Me.oficinistaMinimizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.oficinistaMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.oficinistaMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.oficinistaMinimizar.IconColor = System.Drawing.Color.White
        Me.oficinistaMinimizar.IconSize = 34
        Me.oficinistaMinimizar.Name = "oficinistaMinimizar"
        Me.oficinistaMinimizar.TabStop = False
        '
        'lblGeneral
        '
        resources.ApplyResources(Me.lblGeneral, "lblGeneral")
        Me.lblGeneral.ForeColor = System.Drawing.Color.Transparent
        Me.lblGeneral.Name = "lblGeneral"
        Me.lblGeneral.UseCompatibleTextRendering = True
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconCurrentForm.IconColor = System.Drawing.Color.White
        Me.IconCurrentForm.IconSize = 35
        resources.ApplyResources(Me.IconCurrentForm, "IconCurrentForm")
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.TabStop = False
        '
        'phototrasparent
        '
        Me.phototrasparent.ElipseRadius = 175
        Me.phototrasparent.TargetControl = Me.photo
        '
        'horayfecha
        '
        Me.horayfecha.Enabled = True
        '
        'PanelDesktop
        '
        resources.ApplyResources(Me.PanelDesktop, "PanelDesktop")
        Me.PanelDesktop.Controls.Add(Me.BunifuSeparator5)
        Me.PanelDesktop.Controls.Add(Me.lblfecha)
        Me.PanelDesktop.Controls.Add(Me.lblhora)
        Me.PanelDesktop.Controls.Add(Me.pbLogoEmpresa)
        Me.PanelDesktop.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.PanelDesktop.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.PanelDesktop.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.PanelDesktop.GradientTopRight = System.Drawing.Color.White
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Quality = 10
        '
        'lblfecha
        '
        resources.ApplyResources(Me.lblfecha, "lblfecha")
        Me.lblfecha.BackColor = System.Drawing.Color.Transparent
        Me.lblfecha.ForeColor = System.Drawing.Color.White
        Me.lblfecha.Name = "lblfecha"
        '
        'lblhora
        '
        resources.ApplyResources(Me.lblhora, "lblhora")
        Me.lblhora.BackColor = System.Drawing.Color.Transparent
        Me.lblhora.ForeColor = System.Drawing.Color.White
        Me.lblhora.Name = "lblhora"
        '
        'pbLogoEmpresa
        '
        resources.ApplyResources(Me.pbLogoEmpresa, "pbLogoEmpresa")
        Me.pbLogoEmpresa.BackColor = System.Drawing.Color.Transparent
        Me.pbLogoEmpresa.Image = Global.ProyectoProgramacion.My.Resources.Resources.Logo_HotelCanino
        Me.pbLogoEmpresa.Name = "pbLogoEmpresa"
        Me.pbLogoEmpresa.TabStop = False
        '
        'BunifuSeparator5
        '
        resources.ApplyResources(Me.BunifuSeparator5, "BunifuSeparator5")
        Me.BunifuSeparator5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator5.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSeparator5.LineThickness = 3
        Me.BunifuSeparator5.Name = "BunifuSeparator5"
        Me.BunifuSeparator5.Transparency = 255
        Me.BunifuSeparator5.Vertical = True
        '
        'VentanaOficinista
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PanelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VentanaOficinista"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenu.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PictureBox1.ResumeLayout(False)
        CType(Me.photo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.photo.ResumeLayout(False)
        Me.photo.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.oficinistaSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.oficinistaMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDesktop.ResumeLayout(False)
        Me.PanelDesktop.PerformLayout()
        CType(Me.pbLogoEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnGestion As FontAwesome.Sharp.IconButton
    Friend WithEvents btnInicio As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCerarSesion As FontAwesome.Sharp.IconButton
    Friend WithEvents pbLogoEmpresa As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblGeneral As Label
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelDesktop As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents edit As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents photo As PictureBox
    Friend WithEvents nombre As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents phototrasparent As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents txtNombreUsuario As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblfecha As Label
    Friend WithEvents lblhora As Label
    Friend WithEvents horayfecha As Timer
    Friend WithEvents oficinistaMinimizar As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents oficinistaSalir As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents BunifuSeparator5 As Bunifu.Framework.UI.BunifuSeparator
End Class