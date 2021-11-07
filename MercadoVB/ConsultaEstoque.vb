Imports System.Data.SqlClient

Public Class ConsultaEstoque

    Private Sub rbtEntradaSaída_CheckedChanged(sender As Object, e As EventArgs) Handles rbtEntradaSaída.CheckedChanged
        cmbEntradaSaída.Text = ""
        cmbEntradaSaída.Visible = True
        dtpDataInicial.Visible = False
        dtpDataFinal.Visible = False
        rbtEntreDatas.Visible = False
        lblFinal.Visible = False
    End Sub

    Private Sub rbtData_CheckedChanged(sender As Object, e As EventArgs) Handles rbtData.CheckedChanged
        cmbEntradaSaída.Text = ""
        cmbEntradaSaída.Visible = False
        dtpDataInicial.Visible = True
        dtpDataFinal.Visible = False
        rbtEntreDatas.Visible = True
        lblFinal.Visible = False
    End Sub

    Private Sub cmbEntradaSaída_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEntradaSaída.SelectedIndexChanged
        If cmbEntradaSaída.Text = "" And dgvConsultaEstoque.Rows.Count > 0 Then
            Listar()
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
                    dgvConsultaEstoque.DataSource = dt
                    FormatarDGV()
                Else
                    abrir()
                    cmd = New SqlCommand("Select t.id_estoque, t.descricao, t.quantidade, t.data_alteracao, t.id_produto, t.funcionaio,
                                    t.id_fornecedor, p.descricao, f.nome_for FROM estoque AS t INNER JOIN produtos AS p ON 
                                    t.id_produto = p.id_produto INNER JOIN fornecedores As f On t.id_fornecedor = f.id_fornecedor
                                    WHERE t.descricao = @descricao ", connect)
                    cmd.Parameters.AddWithValue("@descricao", cmbEntradaSaída.Text)
                    da = New SqlDataAdapter(cmd)
                    da.Fill(dt)
                    dgvConsultaEstoque.DataSource = dt
                    FormatarDGV()
                End If

            Catch ex As Exception
                MessageBox.Show("Algo saiu errado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                fechar()
            End Try

        End If
    End Sub

    Private Sub Listar()

        Dim dt As New DataTable
        Dim dta As SqlDataAdapter

        Try
            abrir()
            dta = New SqlDataAdapter("SELECT t.id_estoque, t.descricao, t.quantidade, t.data_alteracao, t.id_produto, t.funcionaio, 
                                    t.id_fornecedor, p.descricao, f.nome_for FROM estoque AS t INNER JOIN produtos AS p ON 
                                    t.id_produto = p.id_produto INNER JOIN fornecedores AS f ON t.id_fornecedor = f.id_fornecedor", connect)
            dta.Fill(dt)
            dgvConsultaEstoque.DataSource = dt

            FormatarDGV()
        Catch ex As Exception
            MessageBox.Show(MessageBoxOptions.ServiceNotification, "Erro ao conectar ao banco de dados!")
            fechar()
        End Try
    End Sub

    Private Sub FormatarDGV()

        Try
            dgvConsultaEstoque.ReadOnly = True
            dgvConsultaEstoque.Columns(0).Visible = False
            dgvConsultaEstoque.Columns(4).Visible = False
            dgvConsultaEstoque.Columns(6).Visible = False
            dgvConsultaEstoque.Columns(1).HeaderText = "Saída/Entrada"
            dgvConsultaEstoque.Columns(1).Width = 100
            dgvConsultaEstoque.Columns(2).HeaderText = "Quantidade"
            dgvConsultaEstoque.Columns(2).DefaultCellStyle.Format = "0000"
            dgvConsultaEstoque.Columns(2).Width = 80
            dgvConsultaEstoque.Columns(3).HeaderText = "Data Alteração"
            dgvConsultaEstoque.Columns(3).Width = 115
            dgvConsultaEstoque.Columns(7).HeaderText = "Produto"
            dgvConsultaEstoque.Columns(7).Width = 200
            dgvConsultaEstoque.Columns(5).HeaderText = "Funcionário"
            dgvConsultaEstoque.Columns(5).Width = 80
            dgvConsultaEstoque.Columns(8).HeaderText = "Fornecedor"
            dgvConsultaEstoque.Columns(8).Width = 300

        Catch ex As Exception
            MessageBox.Show(MessageBoxOptions.ServiceNotification, "Algo saiu errado!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        End Try
    End Sub

    Private Sub ConsultaEstoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()
    End Sub

    Private Sub dtpDataInicial_ValueChanged(sender As Object, e As EventArgs) Handles dtpDataInicial.ValueChanged
        Dim dt As New DataTable
        Dim dta As SqlDataAdapter
        Dim cmd As SqlCommand

        Try
            abrir()
            cmd = New SqlCommand("SELECT t.id_estoque, t.descricao, t.quantidade, t.data_alteracao, t.id_produto, t.funcionaio, 
                                    t.id_fornecedor, p.descricao, f.nome_for FROM estoque AS t INNER JOIN produtos AS p ON 
                                    t.id_produto = p.id_produto INNER JOIN fornecedores AS f ON t.id_fornecedor = f.id_fornecedor 
                                    WHERE data_alteracao = @data", connect)
            cmd.Parameters.AddWithValue("@data", dtpDataInicial.Text)
            dta = New SqlDataAdapter(cmd)
            dta.Fill(dt)
            dgvConsultaEstoque.DataSource = dt
            FormatarDGV()
        Catch ex As Exception
            MessageBox.Show(MessageBoxOptions.ServiceNotification, "Erro ao conectar ao banco de dados!")
            fechar()
        End Try
    End Sub

    Private Sub rbtEntreDatas_CheckedChanged(sender As Object, e As EventArgs) Handles rbtEntreDatas.CheckedChanged
        cmbEntradaSaída.Text = ""
        cmbEntradaSaída.Visible = False
        dtpDataInicial.Visible = True
        dtpDataFinal.Visible = True
        lblFinal.Visible = True
    End Sub

    Private Sub dtpDataFinal_ValueChanged(sender As Object, e As EventArgs) Handles dtpDataFinal.ValueChanged

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
            dgvConsultaEstoque.DataSource = dt
            FormatarDGV()

        Catch ex As Exception
            MessageBox.Show(MessageBoxOptions.ServiceNotification, "Erro ao conectar ao banco de dados!")
            fechar()
        End Try
    End Sub

End Class