Public Class GestionReservas
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

    End Sub

    Private Sub GestionReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Pagina1.ShowDialog()
    End Sub

    Private Sub nuevocliente_Click(sender As Object, e As EventArgs) Handles btnnuevocliente.Click
        NuevoCliente.ShowDialog()
    End Sub
End Class