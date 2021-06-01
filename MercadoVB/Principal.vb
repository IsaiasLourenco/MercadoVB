Public Class Principal
    Private Sub menuSairSai_Click(sender As Object, e As EventArgs) Handles menuSairSai.Click
        Application.Exit()
    End Sub

    Private Sub menuCadastroFuncionarios_Click(sender As Object, e As EventArgs) Handles menuCadastroFuncionarios.Click
        Dim form = New Funcionarios
        form.ShowDialog()
    End Sub
End Class