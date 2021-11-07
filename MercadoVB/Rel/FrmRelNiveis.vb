Public Class FrmRelNiveis
    Private Sub FrmRelNiveis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'ProdutosDataSet.NívelBaixo'. Você pode movê-la ou removê-la conforme necessário.
        Me.NívelBaixoTableAdapter.Fill(Me.ProdutosDataSet.NívelBaixo)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class