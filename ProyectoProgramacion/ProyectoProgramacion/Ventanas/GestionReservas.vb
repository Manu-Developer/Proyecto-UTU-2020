Public Class GestionReservas
    Private Sub nuevocliente_Click(sender As Object, e As EventArgs) Handles btnnuevocliente.Click
        NuevoCliente.ShowDialog()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Pagina1.ShowDialog()
    End Sub
End Class