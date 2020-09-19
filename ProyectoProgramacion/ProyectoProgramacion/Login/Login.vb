Imports System.Runtime.InteropServices

Public Class Login
    'Codigo para draggear'
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub pcbImagen_MouseMove(sender As Object, e As MouseEventArgs) Handles pcbImagen.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub panelPrincipal_MouseMove(sender As Object, e As MouseEventArgs) Handles panelPrincipal.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub ipbSalir_Click(sender As Object, e As EventArgs) Handles ipbSalir.Click
        Application.Exit()
    End Sub

    Private Sub ipbMinimizar_Click(sender As Object, e As EventArgs) Handles ipbMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click, btnIniciar.Click
        login()
    End Sub

    Private Sub login()
        If Validaciones.validarTexto(txtUsuario) And Validaciones.validarContraseña(txtContraseña) Then
            Dim datos = New Datos
            If datos.login(txtUsuario, txtContraseña) Then
                Me.Visible = False
            End If
        End If
    End Sub

    Private Sub txtUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsuario.KeyDown, txtContraseña.KeyDown
        If (e.KeyCode.Equals(Keys.Enter)) Then
            login()
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim datos = New Datos
        If Not datos.checkConnection() Then
            Application.Exit()
        End If
    End Sub
End Class
