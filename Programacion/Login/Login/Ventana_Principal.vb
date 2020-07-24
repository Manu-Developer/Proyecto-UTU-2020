Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp

Public Class Ventana_Principal
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form

    'Codigo para Drag'
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub pcbLogoEmpresa_MouseDown_1(sender As Object, e As MouseEventArgs) Handles pcbLogoEmpresa.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub panelLogo_MouseDown(sender As Object, e As MouseEventArgs) Handles panelLogo.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub PanelMenu_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelMenu.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub



    Public Sub New()
        InitializeComponent()
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 46)
        PanelMenu.Controls.Add(leftBorderBtn)
    End Sub

    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(238, 126, 44)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
            iconCurrentChildForm.IconChar = currentBtn.IconChar
            iconCurrentChildForm.IconColor = customColor
        Else

        End If
    End Sub
    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(238, 126, 44)
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub OpenChildForm(childForm As Form)
        'Open only form'
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelChildForm.Controls.Add(childForm)
        PanelChildForm.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        lblGeneral.Text = currentBtn.Text
    End Sub


    Private Sub btnRealizar_Click(sender As Object, e As EventArgs) Handles btnRealizar.Click
        ActivateButton(sender, Color.FromArgb(255, 176, 1))
        OpenChildForm(New FormularioHijo_Prueba)
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        ActivateButton(sender, Color.FromArgb(255, 176, 1))
        OpenChildForm(New FormularioHijo_Prueba)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ActivateButton(sender, Color.FromArgb(255, 176, 1))
        OpenChildForm(New FormularioHijo_Prueba)
    End Sub

    Private Sub btnEntregas_Click(sender As Object, e As EventArgs) Handles btnEntregas.Click
        ActivateButton(sender, Color.FromArgb(255, 176, 1))
        OpenChildForm(New FormularioHijo_Prueba)
    End Sub

    Private Sub btnConfiguraciones_Click(sender As Object, e As EventArgs) Handles btnConfiguraciones.Click
        ActivateButton(sender, Color.FromArgb(255, 176, 1))
        OpenChildForm(New FormularioHijo_Prueba)
    End Sub

    Private Sub ipcSalir_Click(sender As Object, e As EventArgs) Handles ipcSalir.Click
        Application.Exit()
    End Sub

    Private Sub ipbMinimizar_Click(sender As Object, e As EventArgs) Handles ipbMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If (opcion = Windows.Forms.DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub
End Class