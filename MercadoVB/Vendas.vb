Imports System.Data.SqlClient
Imports System.IO
Imports System.Configuration
Imports System.Math

Public Class Vendas

    Dim conexaoMySQL As SqlConnection
    Dim comandoMySQL As SqlCommand
    Dim leitorDataReader As SqlDataReader
    Dim abertura As Boolean

    Private Sub Vendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarFuncionarios()
        DesabilitarCampos()

        Listar()

        txtCodBarras.Focus()
        Totalizar()

    End Sub

    Private Sub Listar()

        Dim cmd As SqlCommand
        Dim dt As New DataTable
        Dim dta As SqlDataAdapter


        Try
            abrir()

            cmd = New SqlCommand("SELECT     v.id_vendas, p.codigobarras, p.descricao, f.nome, c.nome, v.quantidade, p.valor, 
                                                 v.total, v.data_venda, v.id_produto, v.id_cli, v.id_func 
                                      FROM       vendas AS v 
                                      INNER JOIN produtos AS p ON v.id_produto = p.id_produto 
                                      INNER JOIN clientes AS c ON c.id_cli = v.id_cli 
                                      INNER JOIN funcionarios AS f ON f.id_func = v.id_func
                                      WHERE v.data_venda = @data", connect)
            cmd.Parameters.AddWithValue("@data", Now.Date())
            dta = New SqlDataAdapter(cmd)
            dta.Fill(dt)
            dgvVendas.DataSource = dt

            FormatarDGV()
        Catch ex As Exception
            MessageBox.Show(MessageBoxOptions.ServiceNotification, "Erro ao conectar ao banco de dados!")
            fechar()
        End Try
    End Sub

    Private Sub FormatarDGV()

        Try
            dgvVendas.ReadOnly = True
            dgvVendas.Columns(0).HeaderText = "Nº Venda"
            dgvVendas.Columns(0).DefaultCellStyle.Format = "0000"
            dgvVendas.Columns(0).Width = 90
            dgvVendas.Columns(1).Visible = False
            dgvVendas.Columns(2).HeaderText = "Produto"
            dgvVendas.Columns(3).Visible = False
            dgvVendas.Columns(4).Visible = False
            dgvVendas.Columns(5).HeaderText = "Quantidade"
            dgvVendas.Columns(5).DefaultCellStyle.Format = "0000"
            dgvVendas.Columns(6).HeaderText = "Valor Unitário"
            dgvVendas.Columns(6).DefaultCellStyle.Format = "C2"
            dgvVendas.Columns(6).Width = 90
            dgvVendas.Columns(7).HeaderText = "Total"
            dgvVendas.Columns(7).DefaultCellStyle.Format = "C2"
            dgvVendas.Columns(7).Width = 90
            dgvVendas.Columns(8).Visible = False
            dgvVendas.Columns(9).Visible = False
            dgvVendas.Columns(10).Visible = False
            dgvVendas.Columns(11).Visible = False

        Catch ex As Exception
            MessageBox.Show(MessageBoxOptions.ServiceNotification, "Algo saiu errado!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        End Try
    End Sub

    Private Sub DesabilitarCampos()
        txtVenda.Enabled = False
        cmbProduto.Enabled = False
        cmbCliente.Enabled = False
        cmbFuncionario.Enabled = False
        txtQuantidade.Enabled = False
        txtCodBarras.Focus()
    End Sub

    Private Sub HabilitarCampos()
        txtVenda.Enabled = True
        cmbProduto.Enabled = True
        cmbCliente.Enabled = True
        cmbFuncionario.Enabled = True
        txtQuantidade.Enabled = True
        txtVenda.Focus()
    End Sub

    Private Sub LimparCampos()
        cmbProduto.Text = ""
        cmbFuncionario.Text = usuarioNome
        txtTotal.Text = ""
        lblSubTotal.Text = ""
        txtDesconto.Text = ""
        txtTotalCompra.Text = ""
        txtValorRecebido.Text = ""
        lblTroco.Text = ""
        cmbCliente.Text = ""
        txtQuantidade.Text = "0000"
        txtValor.Text = ""
        txtEstoque.Text = ""
        txtCodBarras.Text = ""
        txtCodBarras.Focus()
    End Sub

    Private Sub CarregarFuncionarios()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("SELECT * FROM funcionarios", connect)
            da.Fill(dt)
            cmbFuncionario.DisplayMember = "nome"
            cmbFuncionario.ValueMember = "id_func"
            cmbFuncionario.DataSource = dt

        Catch ex As Exception

        End Try
        fechar()
    End Sub

    Private Sub CarregarProdutos()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("Select * from produtos", connect)
            da.Fill(dt)
            cmbProduto.DisplayMember = "descricao"
            cmbProduto.ValueMember = "id_produto"
            cmbProduto.DataSource = dt
        Catch ex As Exception

        End Try
        fechar()
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
            'btnCompVenda.Enabled = True
        Catch ex As Exception

        End Try
        fechar()
    End Sub

    Private Sub CarregarFornecedores()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("Select * from fornecedores", connect)
            da.Fill(dt)
            cmbFornecedor.DisplayMember = "nome_for"
            cmbFornecedor.ValueMember = "id_fornecedor"
            cmbFornecedor.DataSource = dt
            'btnCompVenda.Enabled = True
        Catch ex As Exception

        End Try
        fechar()
    End Sub

    Private Sub cmbProduto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProduto.SelectedIndexChanged

        AtualizarValorEstoque()

        Dim Dt As DataTable
        Dim Drs As DataRow()

        Dt = DirectCast(cmbProduto.DataSource, DataTable)
        Drs = Dt.Select("id_produto=" + cmbProduto.SelectedValue.ToString())

        Dim cmd As New SqlCommand("sp_BuscarFornecedor", connect)

        Try
            abrir()
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@id_produto", cmbProduto.SelectedValue)
            cmd.Parameters.AddWithValue("@id_fornecedor", cmbFornecedor.SelectedValue)
            cmd.Parameters.Add("@fornecedor", SqlDbType.VarChar, 50).Direction = 2
            cmd.ExecuteNonQuery()

            Dim fornecedor As String = cmd.Parameters("@fornecedor").Value
            cmbFornecedor.Text = fornecedor
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If Drs.Length > 0 Then
            txtValor.Text = Drs(0)("valor")
        End If

    End Sub

    Private Sub AtualizarValorEstoque()

        CarregarFornecedores()

        Dim cmd As New SqlCommand("sp_BuscarQtdeProd", connect)

        Try
            abrir()
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@id_produto", cmbProduto.SelectedValue)
            cmd.Parameters.Add("@quantidade", SqlDbType.Int).Direction = 2
            cmd.Parameters.Add("@qtdade_vendida", SqlDbType.Int).Direction = 2
            cmd.Parameters.Add("@codigobarras", SqlDbType.VarChar, 100).Direction = 2
            cmd.ExecuteNonQuery()

            Dim qtde As Int32 = cmd.Parameters("@quantidade").Value
            txtEstoque.Text = CStr(qtde)

            Dim qtdeVend As Int32 = cmd.Parameters("@qtdade_vendida").Value
            txtQtddeVendida.Text = CStr(qtdeVend)

            Dim comando As New SqlCommand("SELECT imagem FROM produtos WHERE id_produto = @id_produto", connect)
            comando.Parameters.AddWithValue("@id_produto", cmbProduto.SelectedValue)
            comando.ExecuteNonQuery()

            Dim tempImagem As Byte() = DirectCast(comando.ExecuteScalar, Byte())
            If tempImagem Is Nothing Then
                MessageBox.Show("Imagem não localizada", "Erro")
                Exit Sub
            End If
            Dim strArquivo As String = Convert.ToString(DateTime.Now.ToFileTime())
            Dim fs As New FileStream(strArquivo, FileMode.CreateNew, FileAccess.Write)
            fs.Write(tempImagem, 0, tempImagem.Length)
            fs.Flush()
            fs.Close()
            pcbProdutos.Image = Image.FromFile(strArquivo)

            Dim CodBarras As String = cmd.Parameters("@codigobarras").Value
            txtCodBarras.Text = CodBarras

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgvVendas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVendas.CellClick

        HabilitarCampos()
        txtVenda.Focus()
        CarregarProdutos()
        CarregarFornecedores()
        CarregarClientes()

        txtVenda.Text = dgvVendas.CurrentRow.Cells(0).Value
        txtVenda.Text = txtVenda.Text.PadLeft(4, "0")
        txtCodBarras.Text = dgvVendas.CurrentRow.Cells(1).Value
        cmbProduto.Text = dgvVendas.CurrentRow.Cells(2).Value
        cmbFuncionario.Text = dgvVendas.CurrentRow.Cells(3).Value
        cmbCliente.Text = dgvVendas.CurrentRow.Cells(4).Value
        txtQuantidade.Text = dgvVendas.CurrentRow.Cells(5).Value
        txtQuantidade.Text = txtQuantidade.Text.PadLeft(4, "0")
        txtValor.Text = dgvVendas.CurrentRow.Cells(6).Value
        txtCodBarras.Enabled = True

    End Sub

    Private Sub txtValor_TextChanged(sender As Object, e As EventArgs) Handles txtValor.TextChanged
        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("pt-BR")
            txtValor.Text = String.Format("{0:C}", Convert.ToDouble(txtValor.Text))
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Totalizar()
        Dim total As Decimal
        Try
            For Each linha As DataGridViewRow In dgvVendas.Rows
                total = total + linha.Cells(7).Value
            Next

            lblSubTotal.Text = total

            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("pt-BR")
            lblSubTotal.Text = String.Format("{0:C}", Convert.ToDouble(lblSubTotal.Text))
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BuscarVenda()
        If txtVenda.Text = "" Then
            Listar()
            Totalizar()
        Else

            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()
                da = New SqlDataAdapter("sp_BuscarVenda ", connect)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@id_vendas", txtVenda.Text)
                FormatarDGV()
                da.Fill(dt)
                dgvVendas.DataSource = dt

                Totalizar()

            Catch ex As Exception
                MessageBox.Show("Algo saiu errado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Private Sub txtEstoque_LostFocus(sender As Object, e As EventArgs) Handles txtEstoque.LostFocus
        txtEstoque.Text = txtEstoque.Text.PadLeft(4, "0")
    End Sub

    Private Sub Vendas_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        cmbFuncionario.Text = usuarioNome

    End Sub

    Private Sub txtCodBarras_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodBarras.KeyDown
        If e.KeyCode = Keys.F2 Then
            LimparCampos()
        End If
        If e.KeyCode = Keys.F3 Then
            BuscarInfCodBarras()
        End If
        If e.KeyCode = Keys.F4 Then
            txtVenda.Focus()
            CarregarProdutos()
            CarregarClientes()
            CarregarFuncionarios()
            'LimparCampos()
            HabilitarCampos()
        End If
    End Sub

    Private Sub BuscarInfCodBarras()
        CarregarProdutos()
        CarregarFornecedores()
        CarregarClientes()

        Dim cmd As New SqlCommand("sp_BuscarCodBarras", connect)

        Try
            abrir()
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@codigobarras", txtCodBarras.Text)
            cmd.Parameters.Add("@id_produto", SqlDbType.Int).Direction = 2
            cmd.ExecuteNonQuery()

            Dim id_produto As String = cmd.Parameters("@id_produto").Value
            cmbProduto.SelectedValue = id_produto
            My.Computer.Audio.Play(My.Resources.beep_01a, AudioPlayMode.WaitToComplete)

            txtQuantidade.Enabled = True

        Catch ex As Exception
            MsgBox("Produto não encontrado!")
        End Try
    End Sub

    Private Sub txtCodBarras_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodBarras.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txtQuantidade.Focus()
        End If
    End Sub

    Private Sub txtDesconto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDesconto.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txtValorRecebido.Focus()
        End If

    End Sub

    Private Sub txtQuantidade_TextChanged(sender As Object, e As EventArgs) Handles txtQuantidade.TextChanged
        If txtQuantidade.Text <> "0" And txtValor.Text <> "" Then
            Dim valor As Decimal
            Dim qtde As Integer
            Dim total As Decimal
            valor = txtValor.Text
            qtde = txtQuantidade.Text
            total = valor * qtde
            txtTotal.Text = total
            txtQuantidade.Text.PadLeft(4, "0")
            Produtos.Moeda(txtTotal)
        End If
    End Sub

    Private Sub txtValorRecebido_TextChanged(sender As Object, e As EventArgs) Handles txtValorRecebido.TextChanged
        Dim Total As Decimal
        Dim ValorRecebido As Decimal
        Dim Troco As Decimal
        Total = txtTotalCompra.Text
        ValorRecebido = txtValorRecebido.Text
        Troco = Total - ValorRecebido
        lblTroco.Text = Troco
        lblTroco.Text = lblTroco.Text * -1
        Produtos.Moeda(txtValorRecebido)
    End Sub

    Private Sub txtTotalCompra_TextChanged(sender As Object, e As EventArgs) Handles txtTotalCompra.TextChanged
        Dim Total As Decimal
        Dim ValorRecebido As Decimal
        Dim Troco As Decimal
        Total = txtTotalCompra.Text
        If txtValorRecebido.Text = "" Then
            txtValorRecebido.Text = "0,00"
        End If
        ValorRecebido = txtValorRecebido.Text
        Troco = Total - ValorRecebido
        lblTroco.Text = Troco
        Produtos.Moeda(txtTotalCompra)
    End Sub

    Private Sub txtQuantidade_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantidade.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txtDesconto.Focus()
        End If
    End Sub

    Private Sub txtQuantidade_LostFocus(sender As Object, e As EventArgs) Handles txtQuantidade.LostFocus
        txtQuantidade.Text = txtQuantidade.Text.PadLeft(4, "0")
    End Sub

    Private Sub txtValorRecebido_KeyDown(sender As Object, e As KeyEventArgs) Handles txtValorRecebido.KeyDown
        If e.KeyCode = Keys.F5 Then
            Dim cm As SqlCommand
            Dim cmd As SqlCommand
            Dim cmdo As SqlCommand
            Dim comando As SqlCommand

            Dim quantidade As Integer
            Dim estoque As Integer
            Dim TotalEstoque As Integer
            Dim QtddeVend As Integer
            Dim TotalQtVend As Integer

            quantidade = txtQuantidade.Text
            estoque = txtEstoque.Text
            TotalEstoque = estoque - quantidade

            QtddeVend = txtQtddeVendida.Text
            TotalQtVend = QtddeVend + quantidade

            If txtCodBarras.Text <> "" And TotalEstoque > 0 Then

                Dim total As Decimal
                Dim valor As Decimal
                Dim qtde As Integer

                valor = txtValor.Text
                qtde = txtQuantidade.Text
                total = valor * qtde

                Try
                    abrir()

                    'ABATENDO QUANTIDADE EM ESTOQUE
                    cmdo = New SqlCommand("sp_EditarEstoqueProduto", connect)
                    cmdo.CommandType = CommandType.StoredProcedure
                    cmdo.Parameters.AddWithValue("@quantidade", TotalEstoque)
                    cmdo.Parameters.AddWithValue("@codigobarras", txtCodBarras.Text)
                    cmdo.ExecuteNonQuery()

                    'ACRESCENTAR QUANTIDADE DE PRODUTOS VENDIDOS
                    cm = New SqlCommand("sp_EditarQuantidadeVendida", connect)
                    cm.CommandType = CommandType.StoredProcedure
                    cm.Parameters.AddWithValue("@qtdade_vendida", TotalQtVend)
                    cm.Parameters.AddWithValue("@codigobarras", txtCodBarras.Text)
                    cm.ExecuteNonQuery()

                    'SALVAR SAÍDA NA TABELA DE ESTOQUE
                    comando = New SqlCommand("sp_SalvarEstoque", connect)
                    comando.CommandType = CommandType.StoredProcedure
                    comando.Parameters.AddWithValue("@descricao", "Saída")
                    comando.Parameters.AddWithValue("@quantidade", txtQuantidade.Text)
                    comando.Parameters.AddWithValue("@data_alteracao", Now.ToShortDateString)
                    comando.Parameters.AddWithValue("@id_produto", cmbProduto.SelectedValue)
                    comando.Parameters.AddWithValue("@funcionaio", usuarioNome)
                    comando.Parameters.AddWithValue("@id_fornecedor", cmbFornecedor.SelectedValue)
                    comando.Parameters.AddWithValue("@motivo", "Venda")
                    comando.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                    comando.ExecuteNonQuery()

                    'SALVANDO A VENDA
                    cmd = New SqlCommand("sp_SalvarVenda", connect)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@id_produto", CStr(cmbProduto.SelectedValue))
                    cmd.Parameters.AddWithValue("@id_func", CStr(cmbFuncionario.SelectedValue))
                    cmd.Parameters.AddWithValue("@id_cli", CStr(cmbCliente.SelectedValue))
                    cmd.Parameters.AddWithValue("@quantidade", CStr(txtQuantidade.Text))
                    cmd.Parameters.AddWithValue("@total", total)
                    cmd.Parameters.AddWithValue("@data_venda", Now.ToShortDateString)
                    cmd.Parameters.AddWithValue("@id_fornecedor", CStr(cmbFornecedor.SelectedValue))
                    cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                    cmd.ExecuteNonQuery()

                    AtualizarValorEstoque()
                    BuscarVenda()
                    Totalizar()

                    cmbCliente.Enabled = False
                    txtCodBarras.Enabled = False

                    Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                    MessageBox.Show(msg, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Catch ex As Exception
                    MessageBox.Show("Erro ao gravar informações! " + ex.Message)
                    fechar()
                End Try
            Else

                MsgBox("A quantidade em estoque é insuficiente para a venda!!")
                fechar()
            End If
        End If
        If e.KeyCode = Keys.F7 Then
            If txtCodBarras.Text = "" Then
                MsgBox("Selecione uma venda na tabela!")
                Exit Sub
            End If
            Dim venda As String
            venda = txtVenda.Text
            Dim newMDIchild = New frmCompVenda(venda)
            newMDIchild.MdiParent = Me.MdiParent
            newMDIchild.Show()
        End If
    End Sub
    Private Sub dgvVendas_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvVendas.KeyDown
        If e.KeyCode = Keys.F6 Then
            Dim cm As SqlCommand
            Dim cmd As SqlCommand
            Dim cmdo As SqlCommand
            Dim comando As SqlCommand

            Dim quantidade As Decimal
            Dim estoque As Decimal
            Dim TotalEstoque As Decimal
            Dim QtddeVend As Integer
            Dim TotalQtVend As Integer

            quantidade = txtQuantidade.Text
            estoque = txtEstoque.Text
            TotalEstoque = estoque + quantidade

            QtddeVend = txtQtddeVendida.Text
            TotalQtVend = QtddeVend - quantidade

            If txtCodBarras.Text <> "" Then
                Try
                    abrir()

                    'SALVAR SAÍDA NA TABELA DE ESTOQUE
                    comando = New SqlCommand("sp_SalvarEstoque", connect)
                    comando.CommandType = CommandType.StoredProcedure
                    comando.Parameters.AddWithValue("@descricao", "Entrada")
                    comando.Parameters.AddWithValue("@quantidade", txtQuantidade.Text)
                    comando.Parameters.AddWithValue("@data_alteracao", Now.ToShortDateString)
                    comando.Parameters.AddWithValue("@id_produto", cmbProduto.SelectedValue)
                    comando.Parameters.AddWithValue("@funcionaio", usuarioNome)
                    comando.Parameters.AddWithValue("@id_fornecedor", cmbFornecedor.SelectedValue)
                    comando.Parameters.AddWithValue("@motivo", "Devolução/Cancelamento")
                    comando.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2

                    'RETIRAR QUANTIDADE DE PRODUTOS VENDIDOS
                    cm = New SqlCommand("sp_EditarQuantidadeVendida", connect)
                    cm.CommandType = CommandType.StoredProcedure
                    cm.Parameters.AddWithValue("@qtdade_vendida", TotalQtVend)
                    cm.Parameters.AddWithValue("@codigobarras", txtCodBarras.Text)
                    cm.ExecuteNonQuery()

                    'DEVOLVENDO QUANTIDADE AO ESTOQUE
                    cmdo = New SqlCommand("sp_EditarEstoqueProduto", connect)
                    cmdo.CommandType = CommandType.StoredProcedure
                    cmdo.Parameters.AddWithValue("@quantidade", TotalEstoque)
                    cmdo.Parameters.AddWithValue("@codigobarras", txtCodBarras.Text)

                    'EXCLUINDO VENDA
                    cmd = New SqlCommand("sp_ExcluirVenda", connect)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@id_vendas", txtVenda.Text)
                    cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                    Dim result As DialogResult = MessageBox.Show("Tem certeza de que quer excluir o registro?", "Validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Select Case result
                        Case Windows.Forms.DialogResult.Yes
                            comando.ExecuteNonQuery()
                            cmdo.ExecuteNonQuery()
                            AtualizarValorEstoque()
                            cmd.ExecuteNonQuery()
                            Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                            MessageBox.Show(msg, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                            Listar()
                            Totalizar()
                            fechar()
                        Case Windows.Forms.DialogResult.No
                            HabilitarCampos()
                            LimparCampos()
                            txtCodBarras.Focus()
                            Totalizar()
                    End Select

                Catch ex As Exception
                    MessageBox.Show("Erro ao atualizar banco de dados! " + ex.Message)
                    fechar()
                End Try
            End If
        End If
        If e.Control = True And e.KeyCode = Keys.NumPad6 Then
            If txtCodBarras.Text = "" Then
                MsgBox("Selecione uma venda na tabela!")
                Exit Sub
            End If
            Dim venda As String
            venda = txtVenda.Text
            Dim newMDIchild = New frmCompVenda(venda)
            newMDIchild.MdiParent = Me.MdiParent
            newMDIchild.Show()
        End If
    End Sub

    Private Sub txtDesconto_TextChanged(sender As Object, e As EventArgs) Handles txtDesconto.TextChanged
        If txtTotal.Text <> "0" And txtDesconto.Text <> "" Then
            Dim subtotal As Decimal
            Dim desconto As Decimal
            Dim total As Decimal
            subtotal = txtTotal.Text
            desconto = txtDesconto.Text
            total = subtotal - desconto
            txtTotalCompra.Text = total
            Produtos.Moeda(txtDesconto)
        End If
    End Sub

    Private Sub cmbProduto_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbProduto.KeyDown
        Dim texto As String = cmbProduto.Text + e.KeyCode.ToString()
        'If Not String.IsNullOrEmpty(cmbProduto.Contains(texto)) Then
        ' e.SuppressKeyPress = True
        ' End If
    End Sub
End Class