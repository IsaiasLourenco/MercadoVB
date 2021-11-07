Imports System.Data.SqlClient

Public Class frnRelVenda
    Private Sub frnRelVenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtpData.Value = Now.Date()
        CarregarFuncionarios()
        UpdateRel()
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

    Private Sub dtpData_ValueChanged(sender As Object, e As EventArgs) Handles dtpData.ValueChanged
        UpdateRel()
    End Sub

    Private Sub UpdateRel()
        Me.Lista_de_VendasTableAdapter.Fill(Me.VendasDataSet.Lista_de_Vendas, dtpData.Text, cmbFuncionario.Text)
        Me.vendasTableAdapter.Fill(Me.VendasDataSet.vendas)

        Me.rpvRelVendas.RefreshReport()
    End Sub

    Private Sub cmbFuncionario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFuncionario.SelectedIndexChanged
        UpdateRel()
    End Sub
End Class