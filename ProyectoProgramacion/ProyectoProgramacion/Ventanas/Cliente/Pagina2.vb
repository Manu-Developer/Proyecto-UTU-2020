Imports System.Runtime.InteropServices

Public Class Pagina2

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub Pagina3_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Public Function getLocation()
        Return Me.Location
    End Function


    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub ipbAnteriorVentana_Click(sender As Object, e As EventArgs) Handles ipbAnteriorVentana.Click
        Me.Close()
        Pagina1.Visible = False
        Pagina1.Location = getLocation()
        Pagina1.Show()
    End Sub
End Class