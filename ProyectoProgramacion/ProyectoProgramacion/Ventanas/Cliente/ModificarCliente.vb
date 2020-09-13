Imports System.Drawing.Imaging
Imports System.IO
Imports System.Runtime.InteropServices

Public Class ModificarCliente

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Public Sub setDataGridView(ci As Integer, nombre As String, apellido As String, direccion As String, telefono As Integer, fecha As Date)
        txtCI.Text = ci
        txtNombre.Text = nombre
        txtApellido.Text = apellido
        txtDireccion.Text = direccion
        txtTelefono.Text = telefono
        fechaNac.Value = fecha
    End Sub

    Private Sub Pagina1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles modificar.Click
        Dim age As Integer
        age = Year(Date.Now) - Year(fechaNac.Value)
        Dim Validaciones As ValidacionesBasicas = New ValidacionesBasicas
        If Validaciones.validarCedula(txtCI) And Validaciones.validarTexto(txtNombre) And Validaciones.validarTexto(txtApellido) And Validaciones.validarTexto(txtDireccion) And Validaciones.validarNumeroTelefono(txtTelefono) And age > 18 Then
            Me.Close()
            FormSucess.callFormWithMessage("Se ha modificado con exito!")
        Else
            FormInfo.callFormWithMessage("La Fecha de nacimiento es incorrecta")
        End If
    End Sub

    Private Function ImageToByte(img As Image)

        Dim result As Byte()
        Dim memoryStream As MemoryStream = New MemoryStream

        img.Save(memoryStream, ImageFormat.Png)
        result = memoryStream.ToArray()

        Return result
    End Function
End Class