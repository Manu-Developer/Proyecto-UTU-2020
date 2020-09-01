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

    Private Sub Pagina3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Public Function getLocation()
        Return Me.Location
    End Function


    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub ipbAnteriorVentana_Click(sender As Object, e As EventArgs) Handles ipbAnteriorVentana.Click
        Me.Visible = False
        Pagina1.Visible = True
        Pagina1.Location = getLocation()
    End Sub
End Class