Imports System.Text.RegularExpressions

Public Class ValidacionesBasicas
    Public Sub validarNumeros(txtValidar As TextBox)
        Dim validador As New Regex("^[0-9]$")
        If Not txtValidar.Text = "" Then
        ElseIf validador.IsMatch(txtValidar.Text) Then
            'Codigo a ejecutar'
        Else
            MessageBox.Show("Insierte solo numeros", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
        End If
        MessageBox.Show("Insierte algo en el cuadro de diálogo", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
    End Sub
End Class
