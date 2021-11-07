Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class frmEstoqueData

    Private Sub dtpDataFinal_ValueChanged(sender As Object, e As EventArgs) Handles dtpDataFinal.ValueChanged
        ChamarRelData()
        If rbtEntradaSaída.Checked = True Then
            ChamarRelEntradaSaida()
        End If
    End Sub

    Private Sub frmEstoqueData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbEntradaSaída.Text = "Entrada"
        dtpDataInicial.Text = Now.ToShortDateString
        dtpDataFinal.Text = Now.ToShortDateString
    End Sub

    Private Sub rbtEntreDatas_CheckedChanged(sender As Object, e As EventArgs) Handles rbtEntreDatas.CheckedChanged
        cmbEntradaSaída.Visible = False
        ReportViewer1.Visible = True
        ReportViewer2.Visible = False
        dtpDataInicial.Text = Now.ToShortDateString
        dtpDataFinal.Text = Now.ToShortDateString
    End Sub

    Private Sub rbtEntradaSaída_CheckedChanged(sender As Object, e As EventArgs) Handles rbtEntradaSaída.CheckedChanged
        cmbEntradaSaída.Visible = True
        ReportViewer1.Visible = False
        ReportViewer2.visible = True
    End Sub

    Private Sub cmbEntradaSaída_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEntradaSaída.SelectedIndexChanged
        ChamarRelEntradaSaida()
    End Sub

    Sub ChamarRelEntradaSaida()
        Dim descricao As String
        If cmbEntradaSaída.Text = "Entrada" Then
            descricao = "Relatório de Entradas"
        Else
            descricao = "Relatório de Saídas"
        End If
        Me.EntradasSaidasTableAdapter.Fill(Me.EstoqueDataSet.EntradasSaidas, cmbEntradaSaída.Text, dtpDataInicial.Text, dtpDataFinal.Text)
        Dim parametro(2) As ReportParameter
        parametro(0) = New ReportParameter("data_inicial", dtpDataInicial.Text)
        parametro(1) = New ReportParameter("data_final", dtpDataFinal.Text)
        parametro(2) = New ReportParameter("descricao", descricao)
        Me.ReportViewer2.LocalReport.SetParameters(parametro)
        Me.ReportViewer2.RefreshReport()
    End Sub

    Sub ChamarRelData()
        Me.EstoqueEntreDatasTableAdapter.Fill(Me.EstoqueDataSet.EstoqueEntreDatas, dtpDataInicial.Text, dtpDataFinal.Text)
        Me.EstoqueEntradaTableAdapter1.Fill(Me.EstoqueDataSet.EstoqueEntrada, dtpDataInicial.Text, dtpDataFinal.Text)
        Me.EstoqueSaídaTableAdapter1.Fill(Me.EstoqueDataSet.EstoqueSaída, dtpDataInicial.Text, dtpDataFinal.Text)
        Dim parametro(1) As ReportParameter
        parametro(0) = New ReportParameter("data_inicial", dtpDataInicial.Text)
        parametro(1) = New ReportParameter("data_final", dtpDataFinal.Text)
        Me.ReportViewer1.LocalReport.SetParameters(parametro)
        Me.ReportViewer1.RefreshReport()
    End Sub

End Class