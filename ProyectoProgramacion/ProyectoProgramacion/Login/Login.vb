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

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim validacion As ValidacionesBasicas = New ValidacionesBasicas

        If usuario.Text = "gerente" And contraseña.Text = "1234" Then
            Dim ventana As VentanaPrincipal = New VentanaPrincipal
            Me.Visible = False
            ventana.Show()
        Else
            MessageBox.Show("Contraseña o Usuario incorrectos!")
        End If

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblNombre_Click(sender As Object, e As EventArgs) Handles lblNombre.Click

    End Sub

    Private Sub usuario_TextChanged(sender As Object, e As EventArgs) Handles usuario.TextChanged

    End Sub
End Class
