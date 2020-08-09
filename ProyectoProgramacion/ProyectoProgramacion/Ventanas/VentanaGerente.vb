Imports System.Drawing.Text
Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp

Public Class VentanaGerente
    Private currentBtn As Bunifu.Framework.UI.BunifuFlatButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form

    'Drag Form'
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Public Sub New()
        ' This call is required by the designer.'
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.'
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 46)
        PanelMenu.Controls.Add(leftBorderBtn)
        'Form'
    End Sub

    Private Sub FollowButton(button As Bunifu.Framework.UI.BunifuFlatButton)
        flecha.Top = button.Top
        flecha.Visible = True
        linicio.Text = button.Text
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
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        FollowButton(sender)
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        Reset()
    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        FollowButton(sender)
        OpenChildForm(New GestionReservas, "Gestionar Reservas")
    End Sub

    Private Sub btnDelivery_Click(sender As Object, e As EventArgs) Handles btnDelivery.Click
        FollowButton(sender)
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
        FollowButton(sender)
        OpenChildForm(New ModificarPrecioHabitacion, "Gestionar Reservas")
    End Sub
    Private Sub bntAgregarReserva1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCerarSesion_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
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

    Private Sub edit_Click(sender As Object, e As EventArgs)
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