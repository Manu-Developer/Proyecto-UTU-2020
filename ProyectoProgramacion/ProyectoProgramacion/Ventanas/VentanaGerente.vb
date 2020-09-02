Imports System.Drawing.Text
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

    'Resizable'


    Private Sub Ventana_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Width = SystemInformation.VirtualScreen.Width - 250
        Me.Height = SystemInformation.VirtualScreen.Height - 250
        ActivateButton(btnInicio, Color.FromArgb(255, 255, 255))
    End Sub


    Public Sub New()
        ' This call is required by the designer.'
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.'
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 46)
        Panel1.Controls.Add(leftBorderBtn)
        DoubleBuffered = True
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
        PanelDesktop.Controls.Clear()
        PanelDesktop.Controls.Add(pbLogoEmpresa)
        PanelDesktop.Controls.Add(lblhora)
        PanelDesktop.Controls.Add(lblfecha)
        Reset()
    End Sub

    Private Sub ipbMinimizar_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ipbSalir_Click(sender As Object, e As EventArgs)
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

    Private Sub btnDelivery_Click(sender As Object, e As EventArgs) Handles btnReservas.Click
        ActivateButton(sender, Color.FromArgb(255, 255, 255))
        OpenChildForm(New ReservasConfirmadas, "Gestionar Reservas")
    End Sub

    Private Sub btnCerarSesion_Click(sender As Object, e As EventArgs) Handles btnCerarSesion.Click
        Dim result As DialogResult = New DialogResult()
        result = FormWarn.callFormWithMessage("AVISO", "¿Estas seguro de cerrar sesión?")
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

    Private Sub horayfecha_Tick(sender As Object, e As EventArgs) Handles horayfecha.Tick
        lblhora.Text = DateTime.Now.ToString("HH:mm:ss")
        lblfecha.Text = DateTime.Now.ToLongDateString

    End Sub

    Private Sub gerenteSalir_Click(sender As Object, e As EventArgs) Handles gerenteSalir.Click
        Application.Exit()
    End Sub

    Private Sub gerenteMinimizar_Click(sender As Object, e As EventArgs) Handles gerenteMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnGestion.Click
        ActivateButton(sender, Color.FromArgb(255, 255, 255))
        OpenChildForm(New GestionReservas, "Gestionar Reservas")
    End Sub

    Private Sub btnHEntrada_Click(sender As Object, e As EventArgs) Handles btnHEntrada.Click
        ActivateButton(sender, Color.FromArgb(255, 255, 255))
        OpenChildForm(New ReservasEntradaConfirmada, "Entradas Confirmadas")
    End Sub

    Private Sub btnHSalida_Click(sender As Object, e As EventArgs) Handles btnHSalida.Click
        ActivateButton(sender, Color.FromArgb(255, 255, 255))
        OpenChildForm(New ReservasSalidaConfirmada, "Salidas Confirmadas")
    End Sub
End Class