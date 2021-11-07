Imports System.Data.SqlClient

Public Class frmRelCaixa
    Private Sub frmRelCaixa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtpRelatorioCaixa.Value = Now.ToShortDateString
        cmbFuncionario.Text = usuarioNome

        CarregarFuncionarios()
        IniciarRel()
    End Sub

    Private Sub CarregarFuncionarios()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("Select * from funcionarios", connect)
            da.Fill(dt)
            cmbFuncionario.DisplayMember = "nome"
            cmbFuncionario.ValueMember = "id_func"
            cmbFuncionario.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        fechar()
    End Sub

    Private Sub cmbFuncionario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFuncionario.SelectedIndexChanged
        IniciarRel()
    End Sub

    Private Sub IniciarRel()
        Me.CaixaTableAdapter.Fill(Me.CaixaVBDataSet.caixa, cmbFuncionario.Text, dtpRelatorioCaixa.Value)
        Me.Lista_de_VendasTableAdapter.Fill(Me.VendasDataSet.Lista_de_Vendas, dtpRelatorioCaixa.Text, cmbFuncionario.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub dtpRelatorioCaixa_ValueChanged(sender As Object, e As EventArgs) Handles dtpRelatorioCaixa.ValueChanged
        IniciarRel()
    End Sub
End Class