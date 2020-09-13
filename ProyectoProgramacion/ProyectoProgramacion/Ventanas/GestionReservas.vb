Imports System.Drawing.Imaging
Imports System.IO

Public Class GestionReservas
    Private Sub nuevocliente_Click(sender As Object, e As EventArgs) Handles nuevocliente.Click
        Dim newClient As NuevoCliente = New NuevoCliente
        newClient.ShowDialog()

    End Sub

    Private Sub image_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub GestionReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clientes.Rows.Add("0", "Martin", "No", "No", "096394345", "1/1/2000")
        clientes.Rows.Add("1", "Juan", "No", "No", "096394345", "1/1/2000")
        clientes.Rows.Add("2", "Violeta", "No", "No", "096394345", "1/1/2000")
        clientes.Rows.Add("3", "Ricky", "No", "No", "096394345", "1/1/2000")
        clientes.Rows.Add("4", "Carlos", "No", "No", "096394345", "1/1/2000")
        clientes.Rows.Add("5", "Jorge", "No", "No", "096394345", "1/1/2000")
        clientes.Rows.Add("6", "Julian", "No", "No", "096394345", "1/1/2000")
        clientes.Rows.Add("7", "Julio", "No", "No", "096394345", "1/1/2000")

    End Sub

    Private Sub clientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles clientes.CellContentClick
        If e.ColumnIndex.Equals(6) Then
            Dim openModify As ModificarCliente = New ModificarCliente
            openModify.setDataGridView(clientes.Rows(e.RowIndex).Cells(0).Value, clientes.Rows(e.RowIndex).Cells(1).Value, clientes.Rows(e.RowIndex).Cells(2).Value,
         clientes.Rows(e.RowIndex).Cells(3).Value, clientes.Rows(e.RowIndex).Cells(4).Value, Date.Parse(clientes.Rows(e.RowIndex).Cells(5).Value))
            openModify.ShowDialog()
        ElseIf e.ColumnIndex.Equals(7) Then
            Dim result As DialogResult = New DialogResult()
            result = FormWarn.callFormWithMessage("AVISO", "¿Estas seguro que desea eliminar este cliente?")
            If result = DialogResult.OK Then
                clientes.Rows.RemoveAt(e.RowIndex)
                FormSucess.callFormWithMessage("La Eliminacion ha sido exitosa!")
            End If
        ElseIf e.ColumnIndex.Equals(8) Then
            'Ver Reserva'
        End If
    End Sub
End Class