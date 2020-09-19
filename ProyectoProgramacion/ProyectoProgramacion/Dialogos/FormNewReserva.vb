Public Class FormNewReserva

    Public Function callForm()
        Dim reserva As FormNewReserva = New FormNewReserva
        Return reserva.ShowDialog
    End Function


    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub BunifuThinButton21_KeyDown(sender As Object, e As KeyEventArgs) Handles BunifuThinButton21.KeyDown
        If (e.KeyCode.Equals(Keys.Enter)) Then
            Me.DialogResult = DialogResult.OK
        End If
    End Sub

    Private Sub BunifuThinButton22_KeyDown(sender As Object, e As KeyEventArgs) Handles BunifuThinButton22.KeyDown
        If (e.KeyCode.Equals(Keys.Escape)) Then
            Me.DialogResult = DialogResult.Cancel
        End If
    End Sub

End Class