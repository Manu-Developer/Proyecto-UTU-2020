Public Class FormSucess
    Private Sub FormSucess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        esclarecer.ShowAsyc(Me)
    End Sub

    Public Sub callFormWithMessage(message As String)
        Dim sucess As FormSucess = New FormSucess
        sucess.message.Text = message
        sucess.ShowDialog()
    End Sub


    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Me.Close()
    End Sub
End Class