Imports System.Text.RegularExpressions

Friend Class ValidacionesBasicas
    Public Function validarContraseña(txtValidarContraseña As TextBox) As Boolean
        Dim validador As New Regex("^\d{8,}$")
        Dim verdaderoFalso As Boolean

        If txtValidarContraseña.Text.Trim = "" Then
            FormInfo.callFormWithMessage("El campo para la contraseña no puede estar vacío")
            verdaderoFalso = False
        ElseIf Not validador.IsMatch(txtValidarContraseña.Text) Then
            FormInfo.callFormWithMessage("El formato de la contraseña debe de ser solo numérico y tiene que tener un mínimo de 8 carácteres")
            verdaderoFalso = False
        Else
            verdaderoFalso = True
        End If
        Return verdaderoFalso
    End Function

    Public Function validarNumeroTelefono(txtValidarTelefono As TextBox) As Boolean
        Dim validador As New Regex("^\d{9}$")
        Dim verdaderoFalso As Boolean

        If txtValidarTelefono.Text.Trim = "" Then
            FormInfo.callFormWithMessage("El campo númerico puede estar vacìo")
            verdaderoFalso = False
        ElseIf Not validador.IsMatch(txtValidarTelefono.Text) Then
            FormInfo.callFormWithMessage("El formato debe de ser solo numérico y tiene que tener estrictamente 8 carácteres")
            verdaderoFalso = False
        Else
            verdaderoFalso = True
        End If
        Return verdaderoFalso
    End Function

    Public Function validarTexto(txtValidarTexto As TextBox) As Boolean
        Dim validador As New Regex("^[a-zA-Z]{7,}$")
        Dim verdaderoFalso As Boolean
        If txtValidarTexto.Text.Trim = "" Then
            FormInfo.callFormWithMessage("El campo de texto no puede estar vacìo")
            verdaderoFalso = False
        ElseIf Not validador.IsMatch(txtValidarTexto.Text) Then
            FormInfo.callFormWithMessage("El campo de texto debe ser solo alfanumérico y tiene que tener un mínimo de 8 carácteres")
            verdaderoFalso = False
        Else
            verdaderoFalso = True
        End If
        Return verdaderoFalso
    End Function
End Class
