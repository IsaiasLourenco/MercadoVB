Imports System.Data.SqlClient

Public Class Funcionarios
    Private Sub Funcionarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DesabilitarCampos()
        dtpDataAdm.Value = Now

        If rbtNome.Checked Then
            txtBuscar.Focus()
        End If

        btnEditar.Enabled = False
        btnExcluir.Enabled = False
        Listar()
        FormatarDGV()

    End Sub

    Private Sub Listar()
        Dim dt As New DataTable
        Dim dta As SqlDataAdapter

        Try
            abrir()
            dta = New SqlDataAdapter("SELECT * FROM funcionarios", connect)
            dta.Fill(dt)
            dgvFuncionarios.DataSource = dt
            ContarLinhas()
        Catch ex As Exception
            MessageBox.Show(MessageBoxOptions.ServiceNotification, "Erro ao conectar ao banco de dados!")
            fechar()
        End Try
    End Sub

    Private Sub ContarLinhas()
        Dim Total As Integer = dgvFuncionarios.Rows.Count
        lblQtdeTotal.Text = Total
        lblQtdeTotal.Text = lblQtdeTotal.Text.PadLeft(4, "0")

    End Sub

    Private Sub FormatarDGV()
        Try
            dgvFuncionarios.ReadOnly = True
            dgvFuncionarios.Columns(0).Visible = False
            dgvFuncionarios.Columns(2).Visible = False
            dgvFuncionarios.Columns(3).Visible = False
            dgvFuncionarios.Columns(5).Visible = False
            dgvFuncionarios.Columns(12).Visible = False
            dgvFuncionarios.Columns(13).Visible = False
            dgvFuncionarios.Columns(15).Visible = False
            dgvFuncionarios.Columns(1).HeaderText = "Nome"
            dgvFuncionarios.Columns(4).HeaderText = "C.P.F."
            dgvFuncionarios.Columns(4).Width = 85
            dgvFuncionarios.Columns(6).HeaderText = "Rua"
            dgvFuncionarios.Columns(7).HeaderText = "Número"
            dgvFuncionarios.Columns(7).Width = 70
            dgvFuncionarios.Columns(8).HeaderText = "Bairro"
            dgvFuncionarios.Columns(8).Width = 150
            dgvFuncionarios.Columns(9).HeaderText = "Cidade"
            dgvFuncionarios.Columns(10).HeaderText = "Estado"
            dgvFuncionarios.Columns(10).Width = 70
            dgvFuncionarios.Columns(11).HeaderText = "Cargo"
            dgvFuncionarios.Columns(14).HeaderText = "Turno"
        Catch ex As Exception
            MessageBox.Show(MessageBoxOptions.ServiceNotification, "Algo saiui errado!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        End Try

    End Sub

    Private Sub DesabilitarCampos()
        txtNome.Enabled = False
        cmbSexo.Enabled = False
        txtSenha.Enabled = False
        mktCPF.Enabled = False
        mktCEP.Enabled = False
        txtRua.Enabled = False
        txtNumero.Enabled = False
        txtBairro.Enabled = False
        txtCidade.Enabled = False
        txtEstado.Enabled = False
        cmbCargo.Enabled = False
        mktTelefone.Enabled = False
        txtEmail.Enabled = False
        cmbTurno.Enabled = False
        dtpDataAdm.Enabled = False
    End Sub

    Private Sub HabilitarCampos()
        txtNome.Enabled = True
        cmbSexo.Enabled = True
        txtSenha.Enabled = True
        mktCPF.Enabled = True
        mktCEP.Enabled = True
        txtRua.Enabled = True
        txtNumero.Enabled = True
        txtBairro.Enabled = True
        txtCidade.Enabled = True
        txtEstado.Enabled = True
        cmbCargo.Enabled = True
        mktTelefone.Enabled = True
        txtEmail.Enabled = True
        cmbTurno.Enabled = True
        dtpDataAdm.Enabled = True
    End Sub

    Private Sub LimparCampos()
        txtNome.Text = ""
        cmbSexo.Text = ""
        txtSenha.Text = ""
        mktCPF.Text = ""
        mktCEP.Text = ""
        txtRua.Text = ""
        txtNumero.Text = ""
        txtBairro.Text = ""
        txtCidade.Text = ""
        txtEstado.Text = ""
        cmbCargo.Text = ""
        mktTelefone.Text = ""
        txtEmail.Text = ""
        cmbTurno.Text = ""
        dtpDataAdm.Value = Now
        txtBuscar.Text = ""
        mktCPFBusca.Text = ""
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

        If mktCPF.Text <> "" And
           txtNome.Text <> "" And
           cmbSexo.Text <> "" And
           txtSenha.Text <> "" And
           mktCPF.Text <> "" And
           txtRua.Text <> "" And
           mktTelefone.Text <> "" And
           txtEmail.Text <> "" And
           cmbTurno.Text <> "" Then

            Try
                abrir()
                cmd = New SqlCommand("sp_SalvarFunc", connect)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@nome", txtNome.Text)
                cmd.Parameters.AddWithValue("@sexo", cmbSexo.Text)
                cmd.Parameters.AddWithValue("@senha", txtSenha.Text)
                cmd.Parameters.AddWithValue("@cpf", mktCPF.Text)
                cmd.Parameters.AddWithValue("@cep", mktCEP.Text)
                cmd.Parameters.AddWithValue("@rua", txtRua.Text)
                cmd.Parameters.AddWithValue("@num", txtNumero.Text)
                cmd.Parameters.AddWithValue("@bairro", txtBairro.Text)
                cmd.Parameters.AddWithValue("@cidade", txtCidade.Text)
                cmd.Parameters.AddWithValue("@uf", txtEstado.Text)
                cmd.Parameters.AddWithValue("@cargo", cmbCargo.Text)
                cmd.Parameters.AddWithValue("@telefone", mktTelefone.Text)
                cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                cmd.Parameters.AddWithValue("@turno ", cmbTurno.Text)
                cmd.Parameters.AddWithValue("@data_clt", dtpDataAdm.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Listar()
                LimparCampos()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso!!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

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

    Private Sub rbtNome_CheckedChanged(sender As Object, e As EventArgs) Handles rbtNome.CheckedChanged
        mktCPFBusca.Text = ""
        txtBuscar.Text = ""
        mktCPFBusca.Visible = False
        txtBuscar.Visible = True
        txtBuscar.Focus()
    End Sub

    Private Sub rbtCPF_CheckedChanged(sender As Object, e As EventArgs) Handles rbtCPF.CheckedChanged
        mktCPFBusca.Text = ""
        txtBuscar.Text = ""
        mktCPFBusca.Visible = True
        txtBuscar.Visible = False
        mktCPFBusca.Focus()
    End Sub

    Private Sub txtBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txtNome.Focus()
        End If
    End Sub

    Private Sub mktCPFBusca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mktCPFBusca.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txtNome.Focus()
        End If
    End Sub

    Private Sub txtNome_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNome.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            cmbSexo.Focus()
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

    Private Sub cmbSexo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbSexo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txtSenha.Focus()
        End If
    End Sub

    Private Sub txtSenha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSenha.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            mktCPF.Focus()
        End If
    End Sub

    Private Sub mktCPF_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mktCPF.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            mktCEP.Focus()
        End If
    End Sub

    Private Sub mktTelefone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mktTelefone.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txtEmail.Focus()
        End If
    End Sub

    Private Sub txtEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmail.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            cmbTurno.Focus()
        End If
    End Sub

    Private Sub cmbTurno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbTurno.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            dtpDataAdm.Focus()
        End If
    End Sub

    Private Sub dtpDataAdm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtpDataAdm.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btnNovo.Focus()
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        Dim cmd As SqlCommand

        If mktCPF.Text <> "" And
           txtNome.Text <> "" And
           cmbSexo.Text <> "" And
           txtSenha.Text <> "" And
           mktCPF.Text <> "" And
           txtRua.Text <> "" And
           mktTelefone.Text <> "" And
           txtEmail.Text <> "" And
           cmbTurno.Text <> "" Then

            Try
                abrir()
                cmd = New SqlCommand("sp_EditarFunc", connect)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@nome", txtNome.Text)
                cmd.Parameters.AddWithValue("@sexo", cmbSexo.Text)
                cmd.Parameters.AddWithValue("@senha", txtSenha.Text)
                cmd.Parameters.AddWithValue("@cpf", mktCPF.Text)
                cmd.Parameters.AddWithValue("@cep", mktCEP.Text)
                cmd.Parameters.AddWithValue("@rua", txtRua.Text)
                cmd.Parameters.AddWithValue("@num", txtNumero.Text)
                cmd.Parameters.AddWithValue("@bairro", txtBairro.Text)
                cmd.Parameters.AddWithValue("@cidade", txtCidade.Text)
                cmd.Parameters.AddWithValue("@uf", txtEstado.Text)
                cmd.Parameters.AddWithValue("@cargo", cmbCargo.Text)
                cmd.Parameters.AddWithValue("@telefone", mktTelefone.Text)
                cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                cmd.Parameters.AddWithValue("@turno ", cmbTurno.Text)
                cmd.Parameters.AddWithValue("@data_clt", dtpDataAdm.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso!!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Listar()
                LimparCampos()

            Catch ex As Exception
                MessageBox.Show("Erro ao atualizar informações!" + ex.Message)
                fechar()
            End Try

        Else
            MessageBox.Show(MessageBoxOptions.ServiceNotification, "Favor preencher todos os campos!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
            fechar()
        End If

        DesabilitarCampos()
        dtpDataAdm.Value = Now
        If rbtNome.Checked Then
            txtBuscar.Focus()
        End If
        btnEditar.Enabled = False
        btnExcluir.Enabled = False
        Listar()
        btnNovo.Enabled = True
    End Sub

    Private Sub dgvFuncionarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFuncionarios.CellClick
        HabilitarCampos()
        txtNome.Focus()
        btnEditar.Enabled = True
        btnExcluir.Enabled = True
        btnNovo.Enabled = False
        mktCPF.Enabled = False

        txtNome.Text = dgvFuncionarios.CurrentRow.Cells(1).Value
        cmbSexo.Text = dgvFuncionarios.CurrentRow.Cells(2).Value
        txtSenha.Text = dgvFuncionarios.CurrentRow.Cells(3).Value
        mktCPF.Text = dgvFuncionarios.CurrentRow.Cells(4).Value
        mktCEP.Text = dgvFuncionarios.CurrentRow.Cells(5).Value
        txtRua.Text = dgvFuncionarios.CurrentRow.Cells(6).Value
        txtNumero.Text = dgvFuncionarios.CurrentRow.Cells(7).Value
        txtBairro.Text = dgvFuncionarios.CurrentRow.Cells(8).Value
        txtCidade.Text = dgvFuncionarios.CurrentRow.Cells(9).Value
        txtEstado.Text = dgvFuncionarios.CurrentRow.Cells(10).Value
        cmbCargo.Text = dgvFuncionarios.CurrentRow.Cells(11).Value
        mktTelefone.Text = dgvFuncionarios.CurrentRow.Cells(12).Value
        txtEmail.Text = dgvFuncionarios.CurrentRow.Cells(13).Value
        cmbTurno.Text = dgvFuncionarios.CurrentRow.Cells(14).Value
        dtpDataAdm.Text = dgvFuncionarios.CurrentRow.Cells(15).Value

        mktCPFBusca.Text = ""

    End Sub

    Private Sub mktCPFBusca_TextChanged(sender As Object, e As EventArgs) Handles mktCPFBusca.TextChanged
        If mktCPFBusca.Text = "   .   .   -" Then
            Listar()
        Else

            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()
                da = New SqlDataAdapter("sp_BuscarFuncCPF", connect)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@cpf", mktCPFBusca.Text)

                da.Fill(dt)
                dgvFuncionarios.DataSource = dt

                ContarLinhas()

            Catch ex As Exception
                MessageBox.Show("Algo saiu errado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If txtBuscar.Text = "" Then
            Listar()
        Else

            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()
                da = New SqlDataAdapter("sp_BuscarFuncNome", connect)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@nome", txtBuscar.Text)

                da.Fill(dt)
                dgvFuncionarios.DataSource = dt

                ContarLinhas()

            Catch ex As Exception
                MessageBox.Show("Algo saiu errado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        Dim cmd As SqlCommand

        If mktCPF.Text <> "" Then
            Try
                abrir()
                cmd = New SqlCommand("sp_ExcluirFunc", connect)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@cpf", mktCPF.Text)
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

    Private Sub mktCEP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mktCEP.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btnBuscarCEP.Focus()
        End If
    End Sub

    Private Sub txtNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            cmbCargo.Focus()
        End If
    End Sub

    Private Sub btnBuscarCEP_Click(sender As Object, e As EventArgs) Handles btnBuscarCEP.Click
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

    Private Sub cmbCargo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbCargo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            mktTelefone.Focus()
        End If
    End Sub
End Class