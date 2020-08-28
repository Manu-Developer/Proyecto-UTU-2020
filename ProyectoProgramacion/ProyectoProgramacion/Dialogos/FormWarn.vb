Public Class FormWarn

    Public Function callFormWithMessage(aviso As String, message As String)
        Dim warn As FormWarn = New FormWarn
        warn.aviso.Text = aviso
        warn.message.Text = message
        Return warn.ShowDialog
    End Function


    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
End Class