Imports System.Text.RegularExpressions

Friend Class ValidacionesBasicas
    Public Function validarNumeros(txtValidar As TextBox)
        Dim validador As New Regex("^[0-9]$")
        If Not txtValidar.Text = "" Then
            txtValidar.ResetText()
            Return False
        ElseIf validador.IsMatch(txtValidar.Text) Then
            Return True
        Else
            txtValidar.ResetText()
            Return False
        End If
        Return False
    End Function
End Class
