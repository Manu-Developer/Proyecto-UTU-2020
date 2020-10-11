Public Class FormInfo

    Public Sub callFormWithMessage(message As String)
        Dim warn As FormInfo = New FormInfo
        warn.message.Text = message
        warn.ShowDialog()
    End Sub


    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Me.Close()
    End Sub

    Private Sub BunifuFlatButton1_KeyDown(sender As Object, e As KeyEventArgs) Handles BunifuFlatButton1.KeyDown
        If (e.KeyCode.Equals(Keys.Enter)) Then
            Me.Close()
        End If
    End Sub
End Class