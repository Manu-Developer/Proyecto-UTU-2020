Imports System.Runtime.InteropServices
Imports System.Windows
Imports FontAwesome.Sharp

Public Class Ventana_Principal
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
        DataGridView1.Rows.Add("0", "Gonzalo", "Perez", "094656804", "Julio y Herrera", "US$ 1500")
        DataGridView1.Rows.Add("1", "Manuel", "Muñiz", "095202365", "Calle 4 de Julio", "US$ 2000")
        DataGridView1.Rows.Add("2", "Agustin", "Robaina", "093246566", "Calle Hotelero", "US$ 3000")
        DataGridView1.Rows.Add("3", "Fabrizio", "Bravo", "093547687", "Julio y Herrera", "US$ 1500")
        DataGridView1.Rows.Add("4", "Ignacio", "De Mello", "097823546", "Calle Sauce", "US$ 150")
        DataGridView1.Rows.Add("5", "Fabrizio", "Bravo", "093547687", "Julio y Herrera", "US$ 1500")
        DataGridView1.Rows.Add("6", "Manuel", "Muñiz", "095202365", "Calle 4 de Julio", "US$ 2000")
        DataGridView1.Rows.Add("7", "Gonzalo", "Perez", "094656804", "Julio y Herrera", "US$ 1500")
        DataGridView1.Rows.Add("8", "Ignacio", "De Mello", "097823546", "Calle Sauce", "US$ 150")
        DataGridView1.Rows.Add("9", "Fabrizio", "Bravo", "093547687", "Julio y Herrera", "US$ 1500")
        DataGridView1.Rows.Add("10", "Gonzalo", "Perez", "094656804", "Julio y Herrera", "US$ 1500")
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
    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button'
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(0, 141, 252)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'Left Border'
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
            'current Form icon'
            IconCurrentForm.IconChar = currentBtn.IconChar
            IconCurrentForm.IconColor = customColor
        End If
    End Sub
    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(0, 118, 210)
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.Gainsboro
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
        OpenChildForm(New ChildForm_Prueba, "Agregar Reserva")
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        ActivateButton(sender, Color.FromArgb(255, 255, 255))
        OpenChildForm(New ChildForm_Prueba, "Modificar Reserva")
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ActivateButton(sender, Color.FromArgb(255, 255, 255))
        OpenChildForm(New ChildForm_Prueba, "Eliminar Reserva")
    End Sub

    Private Sub btnDelivery_Click(sender As Object, e As EventArgs) Handles btnDelivery.Click
        ActivateButton(sender, Color.FromArgb(255, 255, 255))
        OpenChildForm(New ChildForm_Prueba, "Diliver Reserva")
    End Sub

    Private Sub Panel3_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel3.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub PanelMenu_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelMenu.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub ipbLogOut_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub bntHora_Tick(sender As Object, e As EventArgs) Handles bntHora.Tick
        lblHora.Text = DateTime.Now.ToString("HH:mm:ss")
        lblFecha.Text = DateTime.Now.ToLongDateString()

    End Sub

    Private Sub ipbMinimizar_Click(sender As Object, e As EventArgs) Handles ipbMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ipbSalir_Click(sender As Object, e As EventArgs) Handles ipbSalir.Click
        Application.Exit()
    End Sub

    Private Sub bntAgregarReserva1_Click(sender As Object, e As EventArgs) Handles bntAgregarReserva1.Click
        Formulario_Alerta.ShowDialog()
    End Sub

    Private Sub btnCerarSesion_Click(sender As Object, e As EventArgs) Handles btnCerarSesion.Click

    End Sub
End Class