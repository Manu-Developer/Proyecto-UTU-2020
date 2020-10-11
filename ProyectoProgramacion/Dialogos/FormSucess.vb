Public Class FormSucess

    Public Sub callFormWithMessage(message As String)
        Dim sucess As FormSucess = New FormSucess
        sucess.message.Text = message
        sucess.ShowDialog()
    End Sub


    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles  BunifuThinButton21.Click
        Me.Close()
    End Sub

    Private Sub BunifuThinButton21_KeyDown(sender As Object, e As KeyEventArgs) Handles BunifuThinButton21.KeyDown
        If (e.KeyCode.Equals(Keys.Enter)) Then
            Me.Close()
        End If
    End Sub
End Class