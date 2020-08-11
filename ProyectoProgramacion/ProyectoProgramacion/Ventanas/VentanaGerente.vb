﻿Imports System.Drawing.Text
Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp

Public Class VentanaGerente
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form

    'Drag Form'
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub Ventana_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActivateButton(btnInicio, Color.FromArgb(255, 255, 255))
    End Sub


    Public Sub New()
        ' This call is required by the designer.'
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.'
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 46)
        Panel1.Controls.Add(leftBorderBtn)
        'Form'
    End Sub
    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button'
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(218, 111, 22)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'Left Border'
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Top = senderBtn.Top
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
            'current Form icon'
            IconCurrentForm.IconChar = currentBtn.IconChar
            IconCurrentForm.IconColor = customColor
        End If
    End Sub
    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(238, 126, 44)
            currentBtn.ForeColor = Color.White
            currentBtn.IconColor = Color.White
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub
    Private Sub OpenChildForm(childForm As Form, textoDeseado As String)
        'Open only form'
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'end'
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(childForm)
        PanelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        lblGeneral.Text = currentBtn.Text
    End Sub
    Private Sub Reset()
        IconCurrentForm.IconChar = IconChar.Home
        IconCurrentForm.IconColor = Color.FromArgb(255, 255, 255)
        lblGeneral.Text = "Inicio"

    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        ActivateButton(sender, Color.FromArgb(255, 255, 255))
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        Reset()
    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        ActivateButton(sender, Color.FromArgb(255, 255, 255))
        OpenChildForm(New GestionReservas, "Gestionar Reservas")
    End Sub

    Private Sub btnDelivery_Click(sender As Object, e As EventArgs) Handles btnDelivery.Click
        ActivateButton(sender, Color.FromArgb(255, 255, 255))
        OpenChildForm(New ReservasConfirmadas, "Gestionar Reservas")
    End Sub

    Private Sub ipbMinimizar_Click(sender As Object, e As EventArgs) Handles ipbMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ipbSalir_Click(sender As Object, e As EventArgs) Handles ipbSalir.Click
        Application.Exit()
    End Sub

    Private Sub Panel3_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel3.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub PanelMenu_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelMenu.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnModificarPrecio_Click(sender As Object, e As EventArgs) Handles btnModificarPrecio.Click
        ActivateButton(sender, Color.FromArgb(255, 255, 255))
        OpenChildForm(New ModificarPrecioHabitacion, "Gestionar Reservas")
    End Sub
    Private Sub bntAgregarReserva1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCerarSesion_Click(sender As Object, e As EventArgs) Handles btnCerarSesion.Click
        Dim result As DialogResult = New DialogResult()
        result = FormWarn.callFormWithMessage("AVISO", "Estas seguro de querer cerrar sesion?")
        If result = DialogResult.OK Then
            Me.Close()
            Login.Visible = True
        End If
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        photo.Visible = True
    End Sub

    Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click
        photo.Visible = False
    End Sub

    Private Sub photo_Click(sender As Object, e As EventArgs) Handles photo.Click
        photo.Visible = False
    End Sub

    Private Sub PanelMenu_MouseEnter(sender As Object, e As EventArgs) Handles PanelMenu.MouseEnter
        photo.Visible = False
    End Sub

    Private Sub PanelDesktop_MouseEnter(sender As Object, e As EventArgs) Handles PanelDesktop.MouseEnter
        photo.Visible = False
    End Sub
End Class