Imports System.Data.SqlClient

Public Class DetalhesVenda

    Private Sub rbtCliente_CheckedChanged(sender As Object, e As EventArgs) Handles rbtCliente.CheckedChanged
        cmbCliente.Text = ""
        cmbFuncionario.Text = ""
        cmbFuncionario.Visible = False
        cmbCliente.Visible = True
        dtpData.Visible = False
    End Sub

    Private Sub rbtFuncionário_CheckedChanged(sender As Object, e As EventArgs) Handles rbtFuncionário.CheckedChanged
        cmbCliente.Text = ""
        cmbFuncionario.Text = ""
        cmbFuncionario.Visible = True
        cmbCliente.Visible = False
        dtpData.Visible = False
    End Sub

    Private Sub rbtData_CheckedChanged(sender As Object, e As EventArgs) Handles rbtData.CheckedChanged
        cmbCliente.Text = ""
        cmbFuncionario.Text = ""
        cmbFuncionario.Visible = False
        cmbCliente.Visible = False
        dtpData.Visible = True
    End Sub

    Private Sub DetalhesVenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarFuncionarios()
        CarregarClientes()
        Listar()
        cmbCliente.Text = ""
        cmbFuncionario.Text = ""
        cmbFuncionario.Visible = False
        cmbCliente.Visible = False
        dtpData.Visible = True
    End Sub

    Private Sub CarregarClientes()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("Select * from clientes", connect)
            da.Fill(dt)
            cmbCliente.DisplayMember = "nome"
            cmbCliente.ValueMember = "id_cli"
            cmbCliente.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        fechar()
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

    Private Sub Listar()

        Dim dt As New DataTable
        Dim dta As SqlDataAdapter
        Dim cmd As SqlCommand

        Try
            abrir()
            cmd = New SqlCommand("Select v.id_vendas, p.descricao, f.nome, c.nome, 
                                    v.quantidade, p.valor, v.total, v.data_venda, v.id_produto, v.id_cli, v.id_func FROM vendas 
                                    AS v INNER JOIN produtos AS p ON v.id_produto = p.id_produto INNER JOIN clientes AS c ON
                                    c.id_cli = v.id_cli INNER JOIN funcionarios AS f ON f.id_func = v.id_func AND v.data_venda = @data", connect)
            cmd.Parameters.AddWithValue("@data", Now.Date())
            dta = New SqlDataAdapter(cmd)
            dta.Fill(dt)
            dgvDetalhesVendas.DataSource = dt

            FormatarDGV()
            Totalizar()
        Catch ex As Exception
            MessageBox.Show(MessageBoxOptions.ServiceNotification, "Erro ao conectar ao banco de dados!")
            fechar()
        End Try
    End Sub

    Private Sub Totalizar()
        Dim total As Decimal
        Try
            For Each linha As DataGridViewRow In dgvDetalhesVendas.Rows
                total = total + linha.Cells(6).Value
            Next

            lblQtdeTotalDetalhes.Text = total

            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("pt-BR")
            lblQtdeTotalDetalhes.Text = String.Format("{0:C}", Convert.ToDouble(lblQtdeTotalDetalhes.Text))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FormatarDGV()
        Try
            dgvDetalhesVendas.ReadOnly = True
            dgvDetalhesVendas.Columns(0).HeaderText = "Nº Venda"
            dgvDetalhesVendas.Columns(0).DefaultCellStyle.Format = "0000"
            dgvDetalhesVendas.Columns(0).Width = 70
            dgvDetalhesVendas.Columns(1).HeaderText = "Produto"
            dgvDetalhesVendas.Columns(2).HeaderText = "Funcionário"
            dgvDetalhesVendas.Columns(3).HeaderText = "Cliente"
            dgvDetalhesVendas.Columns(4).HeaderText = "Quantidade"
            dgvDetalhesVendas.Columns(4).DefaultCellStyle.Format = "0000"
            dgvDetalhesVendas.Columns(5).HeaderText = "Valor Unitário"
            dgvDetalhesVendas.Columns(5).DefaultCellStyle.Format = "C2"
            dgvDetalhesVendas.Columns(5).Width = 90
            dgvDetalhesVendas.Columns(6).HeaderText = "Total"
            dgvDetalhesVendas.Columns(6).DefaultCellStyle.Format = "C2"
            dgvDetalhesVendas.Columns(6).Width = 90
            dgvDetalhesVendas.Columns(7).HeaderText = "Data Venda"
            dgvDetalhesVendas.Columns(8).Visible = False
            dgvDetalhesVendas.Columns(9).Visible = False
            dgvDetalhesVendas.Columns(10).Visible = False
        Catch ex As Exception
            MessageBox.Show(MessageBoxOptions.ServiceNotification, "Algo saiu errado!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        End Try
    End Sub

    Private Sub dtpData_ValueChanged(sender As Object, e As EventArgs) Handles dtpData.ValueChanged
        Dim dt As New DataTable
        Dim dta As SqlDataAdapter
        Dim cmd As SqlCommand

        Try
            abrir()
            cmd = New SqlCommand("Select v.id_vendas, p.descricao, f.nome, c.nome, 
                                    v.quantidade, p.valor, v.total, v.data_venda, v.id_produto, v.id_cli, v.id_func FROM vendas 
                                    AS v INNER JOIN produtos AS p ON v.id_produto = p.id_produto INNER JOIN clientes AS c ON
                                    c.id_cli = v.id_cli INNER JOIN funcionarios AS f ON f.id_func = v.id_func AND v.data_venda = @data", connect)
            cmd.Parameters.AddWithValue("@data", dtpData.Text)
            dta = New SqlDataAdapter(cmd)
            dta.Fill(dt)
            dgvDetalhesVendas.DataSource = dt

            FormatarDGV()
            Totalizar()
        Catch ex As Exception
            MessageBox.Show(MessageBoxOptions.ServiceNotification, "Erro ao conectar ao banco de dados!")
            fechar()
        End Try
    End Sub

    Private Sub cmbFuncionario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFuncionario.SelectedIndexChanged
        Dim dt As New DataTable
        Dim dta As SqlDataAdapter
        Dim cmd As SqlCommand

        Try
            abrir()
            cmd = New SqlCommand("Select v.id_vendas, p.descricao, f.nome, c.nome, 
                                    v.quantidade, p.valor, v.total, v.data_venda, v.id_produto, v.id_cli, v.id_func FROM vendas 
                                    AS v INNER JOIN produtos AS p ON v.id_produto = p.id_produto INNER JOIN clientes AS c ON
                                    c.id_cli = v.id_cli INNER JOIN funcionarios AS f ON f.id_func = v.id_func AND f.nome = @nome", connect)
            cmd.Parameters.AddWithValue("@nome", cmbFuncionario.Text)
            dta = New SqlDataAdapter(cmd)
            dta.Fill(dt)
            dgvDetalhesVendas.DataSource = dt

            FormatarDGV()
            Totalizar()
        Catch ex As Exception
            MessageBox.Show(MessageBoxOptions.ServiceNotification, "Erro ao conectar ao banco de dados!")
            fechar()
        End Try
    End Sub

    Private Sub cmbCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCliente.SelectedIndexChanged
        Dim dt As New DataTable
        Dim dta As SqlDataAdapter
        Dim cmd As SqlCommand

        Try
            abrir()
            cmd = New SqlCommand("Select v.id_vendas, p.descricao, f.nome, c.nome, 
                                    v.quantidade, p.valor, v.total, v.data_venda, v.id_produto, v.id_cli, v.id_func FROM vendas 
                                    AS v INNER JOIN produtos AS p ON v.id_produto = p.id_produto INNER JOIN clientes AS c ON
                                    c.id_cli = v.id_cli INNER JOIN funcionarios AS f ON f.id_func = v.id_func AND c.nome = @nome", connect)
            cmd.Parameters.AddWithValue("@nome", cmbCliente.Text)
            dta = New SqlDataAdapter(cmd)
            dta.Fill(dt)
            dgvDetalhesVendas.DataSource = dt

            FormatarDGV()
            Totalizar()
        Catch ex As Exception
            MessageBox.Show(MessageBoxOptions.ServiceNotification, "Erro ao conectar ao banco de dados!")
            fechar()
        End Try
    End Sub
End Class