Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class frmRelEstoque

    Private Sub dtpDataInicial_ValueChanged(sender As Object, e As EventArgs) Handles dtpDataInicial.ValueChanged

        BuscaPorData()

    End Sub

    Private Sub dtpDataFinal_ValueChanged(sender As Object, e As EventArgs) Handles dtpDataFinal.ValueChanged

        BuscaPorData()

    End Sub

    Sub BuscaPorData()

        If rbtEntradaSaída.Checked = False Then

            Dim dt As New DataTable
            Dim dta As SqlDataAdapter
            Dim cmd As SqlCommand

            Try
                cmd = New SqlCommand("sp_BuscarEstoqueEntreDatas", connect)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@data_inicial", dtpDataInicial.Text)
                cmd.Parameters.AddWithValue("@data_final", dtpDataFinal.Value)
                dta = New SqlDataAdapter(cmd)
                dta.Fill(dt)

            Catch ex As Exception
                MessageBox.Show(MessageBoxOptions.ServiceNotification, "Erro ao conectar ao banco de dados!")
                fechar()
            End Try

            'Me.EstoqueEntreDatasTableAdapter.Fill(Me.EstoqueDataSet.EstoqueEntreDatas, dtpDataInicial.Text, dtpDataFinal.Text)

            Me.ReportViewer1.RefreshReport()

        End If

    End Sub

    Private Sub rbtEntradaSaída_CheckedChanged(sender As Object, e As EventArgs) Handles rbtEntradaSaída.CheckedChanged
        cmbEntradaSaída.Text = ""
        cmbEntradaSaída.Visible = True
        dtpDataInicial.Visible = False
        dtpDataFinal.Visible = False
        rbtEntreDatas.Visible = False
        lblInicio.Visible = False
        lblFinal.Visible = False
    End Sub

    Private Sub rbtEntreDatas_CheckedChanged(sender As Object, e As EventArgs) Handles rbtEntreDatas.CheckedChanged
        cmbEntradaSaída.Text = ""
        cmbEntradaSaída.Visible = False
        dtpDataInicial.Visible = True
        dtpDataFinal.Visible = True
        lblFinal.Visible = True
    End Sub

    Private Sub cmbEntradaSaída_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEntradaSaída.SelectedIndexChanged

        If rbtEntradaSaída.Checked = True Then

            If cmbEntradaSaída.Text = "" Then
                MessageBox.Show("Escolher uma opção na lista!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbEntradaSaída.Focus()
            Else
                Dim dt As New DataTable
                Dim da As SqlDataAdapter
                Dim cmd As SqlCommand

                Try

                    If cmbEntradaSaída.Text = "Saída" Then
                        abrir()
                        cmd = New SqlCommand("Select t.id_estoque, t.descricao, t.quantidade, t.data_alteracao, t.id_produto, t.funcionaio,
                                    t.id_fornecedor, p.descricao, f.nome_for FROM estoque AS t INNER JOIN produtos AS p ON 
                                    t.id_produto = p.id_produto INNER JOIN fornecedores As f On t.id_fornecedor = f.id_fornecedor
                                    WHERE t.descricao = @descricao ", connect)
                        cmd.Parameters.AddWithValue("@descricao", cmbEntradaSaída.Text)
                        da = New SqlDataAdapter(cmd)
                        da.Fill(dt)


                        Me.ReportViewer1.RefreshReport()
                    Else
                        abrir()
                        cmd = New SqlCommand("Select t.id_estoque, t.descricao, t.quantidade, t.data_alteracao, t.id_produto, t.funcionaio,
                                    t.id_fornecedor, p.descricao, f.nome_for FROM estoque AS t INNER JOIN produtos AS p ON 
                                    t.id_produto = p.id_produto INNER JOIN fornecedores As f On t.id_fornecedor = f.id_fornecedor
                                    WHERE t.descricao = @descricao ", connect)
                        cmd.Parameters.AddWithValue("@descricao", cmbEntradaSaída.Text)
                        da = New SqlDataAdapter(cmd)
                        da.Fill(dt)
                        Me.ReportViewer1.RefreshReport()
                    End If

                Catch ex As Exception
                    MessageBox.Show("Algo saiu errado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    fechar()
                End Try

            End If

        End If
    End Sub

End Class