Imports System.Data.SqlClient
Imports System.IO

Public Class Estoque

    Private ImagemCarregada As Image
    Dim id_produto As Integer

    Sub New(id_produto As Integer)

        InitializeComponent()
        Me.id_produto = id_produto

    End Sub

    Private Sub Estoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DesabilitarCampos()
        LimparCampos()
        txtBuscar.Enabled = True
        txtBuscar.Text = ""
        txtBuscar.Focus()
        Listar()
        FormatarDGV()

        btnExcluir.Enabled = False
        btnGravar.Enabled = False
        cmbDescricao.Text = "Entrada"
        CarregarFornecedores()
        CarregarProdutos()
        If id_produto > 0 Then
            cmbProduto.SelectedValue = id_produto
            txtQuantidade.Enabled = True
            cmbFornecedores.Enabled = True
            txtQuantidade.Focus()
            btnGravar.Enabled = True
        End If

    End Sub

    Private Sub Listar()

        Dim dt As New DataTable
        Dim dta As SqlDataAdapter

        Try
            abrir()
            dta = New SqlDataAdapter("SELECT t.id_estoque, t.descricao, t.quantidade, t.data_alteracao, t.id_produto, t.funcionaio, 
                                    t.id_fornecedor, t.motivo, p.descricao, f.nome_for FROM estoque AS t INNER JOIN produtos AS p ON 
                                    t.id_produto = p.id_produto INNER JOIN fornecedores AS f ON t.id_fornecedor = f.id_fornecedor
                                    ORDER BY id_estoque DESC", connect)
            dta.Fill(dt)
            dgvEstoque.DataSource = dt

            FormatarDGV()
        Catch ex As Exception
            MessageBox.Show(MessageBoxOptions.ServiceNotification, "Erro ao conectar ao banco de dados!")
            fechar()
        End Try
    End Sub

    Private Sub FormatarDGV()

        Try
            dgvEstoque.ReadOnly = True
            dgvEstoque.Columns(0).Visible = False
            dgvEstoque.Columns(1).HeaderText = "Saída/Entrada"
            dgvEstoque.Columns(1).Width = 100
            dgvEstoque.Columns(2).HeaderText = "Quantidade"
            dgvEstoque.Columns(2).DefaultCellStyle.Format = "0000"
            dgvEstoque.Columns(2).Width = 80
            dgvEstoque.Columns(3).HeaderText = "Data Alteração"
            dgvEstoque.Columns(3).Width = 115
            dgvEstoque.Columns(4).Visible = False
            dgvEstoque.Columns(5).HeaderText = "Funcionário"
            dgvEstoque.Columns(5).Width = 80
            dgvEstoque.Columns(6).Visible = False
            dgvEstoque.Columns(7).HeaderText = "Motivo"
            dgvEstoque.Columns(7).Width = 180
            dgvEstoque.Columns(8).HeaderText = "Produto"
            dgvEstoque.Columns(8).Width = 200
            dgvEstoque.Columns(9).HeaderText = "Fornecedor"
            dgvEstoque.Columns(9).Width = 250

        Catch ex As Exception
            MessageBox.Show(MessageBoxOptions.ServiceNotification, "Algo saiu errado!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        End Try
    End Sub

    Private Sub DesabilitarCampos()
        cmbProduto.Enabled = False
        txtEstoque.Enabled = False
        cmbDescricao.Enabled = False
        txtQuantidade.Enabled = False
        cmbFornecedores.Enabled = False
        txtBuscar.Enabled = False
        txtBuscar.Focus()
    End Sub

    Private Sub HabilitarCampos()
        cmbProduto.Enabled = True
        cmbDescricao.Enabled = True
        txtQuantidade.Enabled = True
        cmbFornecedores.Enabled = True
        txtBuscar.Enabled = True
        cmbProduto.Focus()
    End Sub

    Private Sub LimparCampos()
        cmbProduto.Text = ""
        cmbDescricao.Text = "Entrada"
        txtQuantidade.Text = ""
        cmbFornecedores.Text = ""
        txtBuscar.Text = ""
        cmbProduto.Focus()
    End Sub

    Private Sub CarregarProdutos()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("SELECT * FROM produtos", connect)
            da.Fill(dt)
            cmbProduto.DisplayMember = "descricao"
            cmbProduto.ValueMember = "id_produto"
            cmbProduto.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        fechar()
    End Sub

    Private Sub CarregarFornecedores()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("SELECT * FROM fornecedores", connect)
            da.Fill(dt)
            cmbFornecedores.DisplayMember = "nome_for"
            cmbFornecedores.ValueMember = "id_fornecedor"
            cmbFornecedores.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        fechar()
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        btnNovo.Enabled = False
        btnExcluir.Enabled = False
        btnGravar.Enabled = True
        cmbProduto.Focus()
        CarregarProdutos()
        CarregarFornecedores()
        LimparCampos()
        HabilitarCampos()
    End Sub

    Private Sub cmbProduto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbProduto.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            cmbDescricao.Focus()
        End If

        If e.KeyChar = ChrW(Keys.Escape) Then
            LimparCampos()
            DesabilitarCampos()
            btnNovo.Enabled = True
            btnGravar.Enabled = False
            btnExcluir.Enabled = False
            cmbProduto.Text = ""
            cmbProduto.Focus()
        End If
    End Sub

    Private Sub cmbDescricao_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbDescricao.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txtQuantidade.Focus()
        End If
    End Sub

    Private Sub txtQuantidade_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantidade.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            cmbFornecedores.Focus()
        End If
    End Sub

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click
        Dim cmd As SqlCommand
        Dim cmdo As SqlCommand

        Dim quantidade As Decimal
        Dim estoque As Decimal
        Dim TotalEstoque As Decimal

        quantidade = txtQuantidade.Text
        estoque = txtEstoque.Text

        If cmbDescricao.Text = "Saída" Then
            TotalEstoque = estoque - quantidade
        Else
            TotalEstoque = estoque + quantidade
        End If

        If txtQuantidade.Text <> "" Then
            Try
                abrir()

                'ATUALIZANDO QUANTIDADE EM ESTOQUE

                cmdo = New SqlCommand("sp_EditarEstoqueProduto", connect)
                cmdo.CommandType = CommandType.StoredProcedure
                cmdo.Parameters.AddWithValue("@quantidade", TotalEstoque)
                cmdo.Parameters.AddWithValue("@id_produto", cmbProduto.SelectedValue)
                cmdo.ExecuteNonQuery()

                cmd = New SqlCommand("sp_SalvarEstoque", connect)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@descricao", cmbDescricao.Text)
                cmd.Parameters.AddWithValue("@quantidade", txtQuantidade.Text)
                cmd.Parameters.AddWithValue("@data_alteracao", Now.ToShortDateString)
                cmd.Parameters.AddWithValue("@id_produto", cmbProduto.SelectedValue)
                cmd.Parameters.AddWithValue("@funcionaio", usuarioNome)
                cmd.Parameters.AddWithValue("@id_fornecedor", cmbFornecedores.SelectedValue)
                cmd.Parameters.AddWithValue("@motivo", cmbMotivo.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Listar()
                AtualizarValor()
                LimparCampos()
                DesabilitarCampos()
                frmNivel.Activate()

            Catch ex As Exception
                MessageBox.Show("Erro ao gravar informações! " + ex.Message)
                fechar()
            End Try
        Else
            MessageBox.Show(MessageBoxOptions.ServiceNotification, "Favor preencher todos os campos!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
            fechar()
        End If
        btnNovo.Enabled = True
        btnGravar.Enabled = False
        LimparCampos()
        DesabilitarCampos()
    End Sub

    Private Sub cmbProduto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProduto.SelectedIndexChanged
        AtualizarValor()
    End Sub

    Private Sub AtualizarValor()

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

            Dim QtdeVdda As Int32 = cmd.Parameters("@qtdade_vendida").Value
            txtQtddeVendida.Text = CStr(QtdeVdda)

            Dim cmdo As New SqlCommand("SELECT imagem FROM produtos WHERE id_produto = @id_produto", connect)
            cmdo.Parameters.AddWithValue("@id_produto", cmbProduto.SelectedValue)
            cmdo.ExecuteNonQuery()

            Dim tempImagem As Byte() = DirectCast(cmdo.ExecuteScalar, Byte())
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

            Dim comando As New SqlCommand("sp_BuscarFornecedor", connect)
            comando.CommandType = 4
            comando.Parameters.AddWithValue("@id_produto", cmbProduto.SelectedValue)
            comando.Parameters.AddWithValue("@id_fornecedor", cmbFornecedores.SelectedValue)
            comando.Parameters.Add("@fornecedor", SqlDbType.VarChar, 50).Direction = 2
            comando.ExecuteNonQuery()

            Dim fornecedor As String = comando.Parameters("@fornecedor").Value
            cmbFornecedores.Text = fornecedor

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvEstoque_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEstoque.CellClick
        HabilitarCampos()
        cmbProduto.Focus()
        btnExcluir.Enabled = True
        btnNovo.Enabled = False

        CarregarProdutos()

        txtcodigo.Text = dgvEstoque.CurrentRow.Cells(0).Value
        cmbDescricao.Text = dgvEstoque.CurrentRow.Cells(1).Value
        txtQuantidade.Text = dgvEstoque.CurrentRow.Cells(2).Value
        cmbMotivo.Text = dgvEstoque.CurrentRow.Cells(7).Value
        cmbProduto.Text = dgvEstoque.CurrentRow.Cells(8).Value
        cmbFornecedores.Text = dgvEstoque.CurrentRow.Cells(9).Value

        txtBuscar.Text = ""
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        Dim cmd As SqlCommand
        Dim cmdo As SqlCommand

        If txtcodigo.Text <> "" Then
            Try
                abrir()

                Dim quantidade As Decimal
                Dim estoque As Decimal
                Dim TotalEstoque As Decimal

                quantidade = txtQuantidade.Text
                estoque = txtEstoque.Text

                If cmbDescricao.Text = "Saída" Then
                    TotalEstoque = estoque + quantidade
                Else
                    TotalEstoque = estoque - quantidade
                End If

                'ATUALIZANDO QUANTIDADE NO ESTOQUE

                cmdo = New SqlCommand("sp_EditarEstoqueProduto", connect)
                cmdo.CommandType = CommandType.StoredProcedure
                cmdo.Parameters.AddWithValue("@quantidade", TotalEstoque)
                cmdo.Parameters.AddWithValue("@id_produto", cmbProduto.SelectedValue)


                cmd = New SqlCommand("sp_ExcluirEstoque", connect)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id_estoque", txtcodigo.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                Dim result As DialogResult = MessageBox.Show("Tem certeza de que quer excluir o registro?", "Validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                Select Case result
                    Case Windows.Forms.DialogResult.Yes
                        cmdo.ExecuteNonQuery()
                        AtualizarValor()
                        cmd.ExecuteNonQuery()
                        Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                        MessageBox.Show(msg, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        Listar()
                        LimparCampos()
                        btnGravar.Enabled = False
                        btnExcluir.Enabled = False
                        btnNovo.Enabled = True
                        Listar()
                        fechar()
                    Case Windows.Forms.DialogResult.No
                        HabilitarCampos()
                        LimparCampos()
                        btnNovo.Enabled = False
                        btnGravar.Enabled = True
                        txtcodigo.Focus()
                End Select

            Catch ex As Exception
                MessageBox.Show("Erro ao atualizar banco de dados! " + ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If txtBuscar.Text = "" And dgvEstoque.Rows.Count > 0 Then
            Listar()
        Else

            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()
                da = New SqlDataAdapter("sp_BuscarEstoque ", connect)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@descricao", txtBuscar.Text)
                FormatarDGV()
                da.Fill(dt)
                dgvEstoque.DataSource = dt

            Catch ex As Exception
                MessageBox.Show("Algo saiu errado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub

    Private Sub txtBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = ChrW(Keys.Escape) Then
            LimparCampos()
            DesabilitarCampos()
            btnNovo.Enabled = True
            btnGravar.Enabled = False
            btnExcluir.Enabled = False
            txtBuscar.Enabled = True
            txtBuscar.Text = ""
            txtBuscar.Focus()
            Listar()
        End If
    End Sub

    Private Sub txtEstoque_TextChanged(sender As Object, e As EventArgs) Handles txtEstoque.TextChanged
        txtEstoque.Text = txtEstoque.Text.PadLeft(4, "0")
    End Sub

    Private Sub txtQuantidade_TextChanged(sender As Object, e As EventArgs) Handles txtQuantidade.TextChanged
        txtQuantidade.Text = txtQuantidade.Text.PadLeft(4, "0")
    End Sub
End Class