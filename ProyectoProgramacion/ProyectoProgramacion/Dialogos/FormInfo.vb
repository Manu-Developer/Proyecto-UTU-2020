Public Class FormInfo
    Private Sub FormSucess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        esclarecer.ShowAsyc(Me)
    End Sub

    Public Sub callFormWithMessage(message As String)
        Dim warn As FormInfo = New FormInfo
        warn.message.Text = message
        warn.ShowDialog()
    End Sub


    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Me.Close()
    End Sub

End Class