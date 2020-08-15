Imports System.Text.RegularExpressions

Friend Class ValidacionesBasicas
    Public Function validarContraseña(txtValidarContraseña As TextBox) As Boolean
        Dim validador As New Regex("^\d{8,}$")
        Dim verdaderoFalso As Boolean

        If txtValidarContraseña.Text.Trim = "" Then
            MessageBox.Show("El campo para la contraseña no puede estar vacio", "Error al digitar", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            verdaderoFalso = False
        ElseIf Not validador.IsMatch(txtValidarContraseña.Text) Then
            MessageBox.Show("El formato debe de ser solo numérico y tiene que tener un minimo de 8 caracteres", "Error al digitar", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
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
            MessageBox.Show("El campo númerico puede estar vacio", "Error al digitar", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            verdaderoFalso = False
        ElseIf Not validador.IsMatch(txtValidarTelefono.Text) Then
            MessageBox.Show("El formato debe de ser solo numérico y tiene que tener estrictamente 8 caracteres", "Error al digitar", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
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
            MessageBox.Show("El campo de texto no puede estar vacio", "Error al digitar", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            verdaderoFalso = False
        ElseIf Not validador.IsMatch(txtValidarTexto.Text) Then
            MessageBox.Show("El formato debe de ser solo alfanumérico y tiene que tener un minimo de 8 caracteres", "Error al digitar", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            verdaderoFalso = False
        Else
            verdaderoFalso = True
        End If
        Return verdaderoFalso
    End Function
End Class
