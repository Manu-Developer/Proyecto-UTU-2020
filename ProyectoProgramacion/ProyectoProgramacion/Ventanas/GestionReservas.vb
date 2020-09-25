Imports System.Drawing.Imaging
Imports System.IO

Public Class GestionReservas
    Private Sub nuevocliente_Click(sender As Object, e As EventArgs) Handles btnNuevoCliente.Click
        Dim newClient As NuevoCliente = New NuevoCliente
        newClient.ShowDialog()

    End Sub

    Private Sub image_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub GestionReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvClientes.Rows.Add("0", "Martin", "No", "No", "096394345", "1/1/2000")
        dgvClientes.Rows.Add("1", "Juan", "No", "No", "096394345", "1/1/2000")
        dgvClientes.Rows.Add("2", "Violeta", "No", "No", "096394345", "1/1/2000")
        dgvClientes.Rows.Add("3", "Ricky", "No", "No", "096394345", "1/1/2000")
        dgvClientes.Rows.Add("4", "Carlos", "No", "No", "096394345", "1/1/2000")
        dgvClientes.Rows.Add("5", "Jorge", "No", "No", "096394345", "1/1/2000")
        dgvClientes.Rows.Add("6", "Julian", "No", "No", "096394345", "1/1/2000")
        dgvClientes.Rows.Add("7", "Julio", "No", "No", "096394345", "1/1/2000")

    End Sub

    Private Sub clientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellContentClick
        If e.ColumnIndex.Equals(6) Then
            Dim openModify As ModificarMascota = New ModificarMascota
            openModify.setDataGridView(dgvClientes.Rows(e.RowIndex).Cells(0).Value, dgvClientes.Rows(e.RowIndex).Cells(1).Value, dgvClientes.Rows(e.RowIndex).Cells(2).Value,
         dgvClientes.Rows(e.RowIndex).Cells(3).Value, dgvClientes.Rows(e.RowIndex).Cells(4).Value, Date.Parse(dgvClientes.Rows(e.RowIndex).Cells(5).Value))
            openModify.ShowDialog()
        ElseIf e.ColumnIndex.Equals(7) Then
            Dim result As DialogResult = New DialogResult()
            result = FormWarn.callFormWithMessage("AVISO", "¿Estas seguro que desea eliminar este cliente?")
            If result = DialogResult.OK Then
                dgvClientes.Rows.RemoveAt(e.RowIndex)
                FormSucess.callFormWithMessage("La Eliminacion ha sido exitosa!")
            End If
        ElseIf e.ColumnIndex.Equals(8) Then
            'SELECT FROM MYSQL PARA SABER SI TIENE RESERVAS'

            'SI NO TIENE RESERVA'
            Dim result As DialogResult = New DialogResult()
            result = FormNewReserva.callForm()
            If result = DialogResult.OK Then
                General.OpenChildForm(New NuevaReserva)
            End If
        End If
    End Sub
End Class