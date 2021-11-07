Imports System.Data.SqlClient

Public Class Fornecedores
    Private Sub Fornecedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DesabilitarCampos()

        If rbtNome.Checked Then
            txtBuscar.Focus()
        End If

        btnEditar.Enabled = False
        btnExcluir.Enabled = False
        Listar()
        FormatarDGV()
    End Sub

    Private Sub FormatarDGV()
        Try
            dgvFornecedores.ReadOnly = True
            dgvFornecedores.Columns(0).Visible = False
            dgvFornecedores.Columns(3).Visible = False
            dgvFornecedores.Columns(1).HeaderText = "Nome"
            dgvFornecedores.Columns(1).Width = 250
            dgvFornecedores.Columns(2).HeaderText = "CNPJ"
            dgvFornecedores.Columns(2).Width = 110
            dgvFornecedores.Columns(4).HeaderText = "Rua"
            dgvFornecedores.Columns(5).HeaderText = "Número"
            dgvFornecedores.Columns(5).Width = 50
            dgvFornecedores.Columns(6).HeaderText = "Bairro"
            dgvFornecedores.Columns(6).Width = 120
            dgvFornecedores.Columns(7).HeaderText = "Cidade"
            dgvFornecedores.Columns(7).Width = 70
            dgvFornecedores.Columns(8).HeaderText = "UF"
            dgvFornecedores.Columns(8).Width = 30
            dgvFornecedores.Columns(9).HeaderText = "Telefone"
            dgvFornecedores.Columns(10).HeaderText = "E-mail"
            dgvFornecedores.Columns(10).Width = 120
            dgvFornecedores.Columns(11).HeaderText = "Contato"
            dgvFornecedores.Columns(11).Width = 70
        Catch ex As Exception
            MessageBox.Show(MessageBoxOptions.ServiceNotification, "Algo saiu errado!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        End Try
    End Sub

    Private Sub Listar()
        Dim dt As New DataTable
        Dim dta As SqlDataAdapter

        Try
            abrir()
            dta = New SqlDataAdapter("SELECT * FROM fornecedores", connect)
            dta.Fill(dt)
            dgvFornecedores.DataSource = dt
            ContarLinhas()
        Catch ex As Exception
            MessageBox.Show(MessageBoxOptions.ServiceNotification, "Erro ao conectar ao banco de dados!")
            fechar()
        End Try
    End Sub

    Private Sub ContarLinhas()
        Dim Total As Integer = dgvFornecedores.Rows.Count
        lblQtdeTotal.Text = Total
        lblQtdeTotal.Text = lblQtdeTotal.Text.PadLeft(4, "0")
    End Sub

    Private Sub DesabilitarCampos()
        txtNome.Enabled = False
        mktCNPJ.Enabled = False
        mktCEP.Enabled = False
        txtRua.Enabled = False
        txtNumero.Enabled = False
        txtBairro.Enabled = False
        txtCidade.Enabled = False
        txtEstado.Enabled = False
        mktTelefone.Enabled = False
        txtEmail.Enabled = False
        txtContato.Enabled = False
    End Sub

    Private Sub HabilitarCampos()
        txtNome.Enabled = True
        mktCNPJ.Enabled = True
        mktCEP.Enabled = True
        txtRua.Enabled = True
        txtNumero.Enabled = True
        txtBairro.Enabled = True
        txtCidade.Enabled = True
        txtEstado.Enabled = True
        mktTelefone.Enabled = True
        txtEmail.Enabled = True
        txtContato.Text = True
    End Sub

    Private Sub LimparCampos()
        txtNome.Text = ""
        mktCNPJ.Text = ""
        mktCEP.Text = ""
        txtRua.Text = ""
        txtNumero.Text = ""
        txtBairro.Text = ""
        txtCidade.Text = ""
        txtEstado.Text = ""
        mktTelefone.Text = ""
        txtEmail.Text = ""
        txtContato.Text = ""
    End Sub

    Private Sub txtNome_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNome.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            mktCNPJ.Focus()
        End If

        If e.KeyChar = ChrW(Keys.Escape) Then
            LimparCampos()
            DesabilitarCampos()
            btnNovo.Enabled = True
            btnGravar.Enabled = False
            btnEditar.Enabled = False
            btnExcluir.Enabled = False
        End If
    End Sub

    Private Sub mktCNPJ_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mktCNPJ.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            mktCEP.Focus()
        End If
    End Sub

    Private Sub mktCEP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mktCEP.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btnBuscaCEP.Focus()
        End If
    End Sub

    Private Sub btnBuscaCEP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnBuscaCEP.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txtNumero.Focus()
        End If
    End Sub

    Private Sub txtNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            mktTelefone.Focus()
        End If
    End Sub

    Private Sub mktTelefone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mktTelefone.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txtEmail.Focus()
        End If
    End Sub

    Private Sub txtEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmail.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txtContato.Focus()
        End If
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        HabilitarCampos()
        LimparCampos()
        btnNovo.Enabled = False
        btnGravar.Enabled = True
        txtNome.Focus()
    End Sub

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click
        Dim cmd As SqlCommand

        If mktCNPJ.Text <> "" And
                txtNome.Text <> "" And
                txtRua.Text <> "" And
                mktTelefone.Text <> "" And
                txtEmail.Text <> "" Then
            Try
                abrir()
                cmd = New SqlCommand("sp_SalvarFornecedor", connect)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@nome_for", txtNome.Text)
                cmd.Parameters.AddWithValue("@cnpj", mktCNPJ.Text)
                cmd.Parameters.AddWithValue("@cep", mktCEP.Text)
                cmd.Parameters.AddWithValue("@rua", txtRua.Text)
                cmd.Parameters.AddWithValue("@num", txtNumero.Text)
                cmd.Parameters.AddWithValue("@bairro", txtBairro.Text)
                cmd.Parameters.AddWithValue("@cidade", txtCidade.Text)
                cmd.Parameters.AddWithValue("@uf", txtEstado.Text)
                cmd.Parameters.AddWithValue("@telefone", mktTelefone.Text)
                cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                cmd.Parameters.AddWithValue("@contato", txtContato.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Listar()
                LimparCampos()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Catch ex As Exception
                MessageBox.Show("Erro ao gravar informações!" + ex.Message)
                fechar()
            End Try
        Else
            MessageBox.Show(MessageBoxOptions.ServiceNotification, "Favor preencer todos os campos!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
            fechar()
        End If
        btnNovo.Enabled = True
        btnGravar.Enabled = False
        LimparCampos()
        DesabilitarCampos()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim cmd As SqlCommand

        If mktCNPJ.Text <> "" And
                txtNome.Text <> "" And
                txtRua.Text <> "" And
                mktTelefone.Text <> "" And
                txtEmail.Text <> "" Then
            Try
                abrir()
                cmd = New SqlCommand("sp_EditarFornecedor", connect)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@nome_for", txtNome.Text)
                cmd.Parameters.AddWithValue("@cnpj", mktCNPJ.Text)
                cmd.Parameters.AddWithValue("@cep", mktCEP.Text)
                cmd.Parameters.AddWithValue("@rua", txtRua.Text)
                cmd.Parameters.AddWithValue("@num", txtNumero.Text)
                cmd.Parameters.AddWithValue("@bairro", txtBairro.Text)
                cmd.Parameters.AddWithValue("@cidade", txtCidade.Text)
                cmd.Parameters.AddWithValue("@uf", txtEstado.Text)
                cmd.Parameters.AddWithValue("@telefone", mktTelefone.Text)
                cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                cmd.Parameters.AddWithValue("@contato", txtContato.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString

                MessageBox.Show(msg, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Listar()
                LimparCampos()


            Catch ex As Exception
                MessageBox.Show("Erro ao atualizar informações!" + ex.Message)
                fechar()
            End Try
        Else
            MessageBox.Show(MessageBoxOptions.ServiceNotification, "Favor preencher todos os campos!!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
            fechar()
        End If
        DesabilitarCampos()
        If rbtNome.Checked Then
            txtBuscar.Focus()
        End If
        btnEditar.Enabled = False
        btnExcluir.Enabled = False
        Listar()
        btnNovo.Enabled = True
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim cmd As SqlCommand

        If mktCNPJ.Text <> "" Then
            Try
                abrir()
                cmd = New SqlCommand("sp_ExcluirFornecedor", connect)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@cnpj", mktCNPJ.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                Dim result As DialogResult = MessageBox.Show("Tem certeza de que quer excluir o registro?", "Validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                Select Case result
                    Case Windows.Forms.DialogResult.Yes
                        cmd.ExecuteNonQuery()
                        Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                        MessageBox.Show(msg, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        Listar()
                        LimparCampos()
                        btnGravar.Enabled = False
                        btnExcluir.Enabled = False
                        btnEditar.Enabled = False
                        btnNovo.Enabled = True
                        Listar()
                        fechar()
                    Case Windows.Forms.DialogResult.No
                        HabilitarCampos()
                        LimparCampos()
                        btnNovo.Enabled = False
                        btnGravar.Enabled = True
                        txtNome.Focus()
                End Select

            Catch ex As Exception
                MessageBox.Show("Erro ao atualizar banco de dados! " + ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If txtBuscar.Text = "" Then
            Listar()
        Else

            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()
                da = New SqlDataAdapter("sp_BuscarFornecedorNome", connect)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@nome_for", txtBuscar.Text)

                da.Fill(dt)
                dgvFornecedores.DataSource = dt

                ContarLinhas()

            Catch ex As Exception
                MsgBox("Erro!", +ex.Message)
            End Try
        End If
    End Sub

    Private Sub mktCNPJBusca_TextChanged(sender As Object, e As EventArgs) Handles mktCNPJBusca.TextChanged
        If mktCNPJBusca.Text = "  .   .   /    -" Then
            Listar()
        Else

            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()
                da = New SqlDataAdapter("sp_BuscarFornecedorCNPJ", connect)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@cnpj", mktCNPJBusca.Text)

                da.Fill(dt)
                dgvFornecedores.DataSource = dt

                ContarLinhas()

            Catch ex As Exception
                MessageBox.Show("Algo saiu errado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnBuscaCEP_Click(sender As Object, e As EventArgs) Handles btnBuscaCEP.Click
        Try
            Dim ds As New DataSet()
            Dim xml As String = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", mktCEP.Text)
            ds.ReadXml(xml)
            txtRua.Text = ds.Tables(0).Rows(0)("logradouro").ToString()
            txtBairro.Text = ds.Tables(0).Rows(0)("bairro").ToString()
            txtCidade.Text = ds.Tables(0).Rows(0)("cidade").ToString()
            txtEstado.Text = ds.Tables(0).Rows(0)("uf").ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro")
        End Try
        txtNumero.Focus()
    End Sub

    Private Sub dgvFornecedores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFornecedores.CellClick
        HabilitarCampos()
        txtNome.Focus()
        btnEditar.Enabled = True
        btnExcluir.Enabled = True
        btnNovo.Enabled = False
        mktCNPJ.Enabled = False

        txtNome.Text = dgvFornecedores.CurrentRow.Cells(1).Value
        mktCNPJ.Text = dgvFornecedores.CurrentRow.Cells(2).Value
        mktCEP.Text = dgvFornecedores.CurrentRow.Cells(3).Value
        txtRua.Text = dgvFornecedores.CurrentRow.Cells(4).Value
        txtNumero.Text = dgvFornecedores.CurrentRow.Cells(5).Value
        txtBairro.Text = dgvFornecedores.CurrentRow.Cells(6).Value
        txtCidade.Text = dgvFornecedores.CurrentRow.Cells(7).Value
        txtEstado.Text = dgvFornecedores.CurrentRow.Cells(8).Value
        mktTelefone.Text = dgvFornecedores.CurrentRow.Cells(9).Value
        txtEmail.Text = dgvFornecedores.CurrentRow.Cells(10).Value
        txtContato.Text = dgvFornecedores.CurrentRow.Cells(11).Value

        mktCNPJBusca.Text = ""
    End Sub

    Private Sub rbtNome_CheckedChanged(sender As Object, e As EventArgs) Handles rbtNome.CheckedChanged
        mktCNPJBusca.Text = ""
        txtBuscar.Text = ""
        mktCNPJBusca.Visible = False
        txtBuscar.Visible = True
        txtBuscar.Focus()
    End Sub

    Private Sub rbtCNPJ_CheckedChanged(sender As Object, e As EventArgs) Handles rbtCNPJ.CheckedChanged
        mktCNPJBusca.Text = ""
        txtBuscar.Text = ""
        mktCNPJBusca.Visible = True
        txtBuscar.Visible = False
        mktCNPJBusca.Focus()
    End Sub
End Class