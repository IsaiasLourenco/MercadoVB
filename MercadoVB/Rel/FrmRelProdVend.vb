Imports Microsoft.Reporting.WinForms

Public Class FrmRelProdVend

    Private Sub dtpDataFinal_ValueChanged(sender As Object, e As EventArgs) Handles dtpDataFinal.ValueChanged
        ListarRel()
    End Sub

    Sub ListarRel()
        Me.QtddeVendidaDataTableAdapter.Fill(Me.ProdutosDataSet.QtddeVendidaData, dtpDataInicial.Text, dtpDataFinal.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub FrmRelProdVend_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'ProdutosDataSet.QtddeVendidaData'. Você pode movê-la ou removê-la conforme necessário.
        Me.QtddeVendidaDataTableAdapter.Fill(Me.ProdutosDataSet.QtddeVendidaData, dtpDataInicial.Text, dtpDataFinal.Text)
        ListarRel()

        Me.ReportViewer1.RefreshReport
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub dtpDataInicial_ValueChanged(sender As Object, e As EventArgs) Handles dtpDataInicial.ValueChanged
        ListarRel()
    End Sub
End Class