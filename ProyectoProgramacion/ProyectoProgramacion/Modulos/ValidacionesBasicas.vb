Imports System.Text.RegularExpressions

Friend Class ValidacionesBasicas
    Public Function validarContraseña(txtValidarContraseña As TextBox) As Boolean
        Dim validador As New Regex("^\d{7,}$")

        If txtValidarContraseña.Text.Trim = "" Then
            FormInfo.callFormWithMessage("El campo para la contraseña no puede estar vacío")
            Return False
        ElseIf Not validador.IsMatch(txtValidarContraseña.Text) Then
            FormInfo.callFormWithMessage("El formato de la contraseña debe de ser solo numérico y tiene que tener un mínimo de 7 carácteres")
            txtValidarContraseña.Text = ""
            Return False
        Else
            Return True
        End If
    End Function

    Public Function validarNumeroTelefono(txtValidarTelefono As TextBox) As Boolean
        Dim validador As New Regex("^\d{9}$")

        If txtValidarTelefono.Text.Trim = "" Then
            FormInfo.callFormWithMessage("El campo númerico no puede estar vacío")
            Return False
        ElseIf Not validador.IsMatch(txtValidarTelefono.Text) Then
            FormInfo.callFormWithMessage("El formato debe de ser solo numérico y tiene que tener estrictamente 9 carácteres")
            txtValidarTelefono.Text = ""
            Return False
        Else
            Return True
        End If
    End Function

    Public Function validarTexto(txtValidarTexto As TextBox) As Boolean
        Dim validador As New Regex("^[a-zA-Z]{7,}$")
        If txtValidarTexto.Text.Trim = "" Then
            FormInfo.callFormWithMessage("El campo de texto no puede estar vacío")
            Return False
        ElseIf Not validador.IsMatch(txtValidarTexto.Text) Then
            FormInfo.callFormWithMessage("El campo de texto solo debe de tener letras y tiene que tener un mínimo de 7 carácteres")
            txtValidarTexto.Text = ""
            Return False
        Else
            Return True
        End If
    End Function
End Class
