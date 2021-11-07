Imports System.Data.SqlClient

Public Class MDIPrincipal

    Private Sub menuCadastroProdutos_Click(sender As Object, e As EventArgs) Handles menuCadastroProdutos.Click
        Dim newMDIchild = New Produtos
        newMDIchild.MdiParent = Me
        newMDIchild.Show()
    End Sub

    Private Sub menuCadastroFuncionarios_Click(sender As Object, e As EventArgs) Handles menuCadastroFuncionarios.Click
        Dim newMDIchild = New Funcionarios
        newMDIchild.MdiParent = Me
        newMDIchild.Show()
    End Sub

    Private Sub menuCadastroClientes_Click(sender As Object, e As EventArgs) Handles menuCadastroClientes.Click
        Dim newMDIchild = New Clientes
        newMDIchild.MdiParent = Me
        newMDIchild.Show()
    End Sub

    Private Sub menuCadastroFornecedores_Click(sender As Object, e As EventArgs) Handles menuCadastroFornecedores.Click
        Dim newMDIchild = New Fornecedores
        newMDIchild.MdiParent = Me
        newMDIchild.Show()
    End Sub

    Private Sub menuVendasRegistroDeVendas_Click(sender As Object, e As EventArgs) Handles menuVendasRegistroDeVendas.Click

        CarregarDados()
        Dim cmdo As New SqlCommand("sp_Verificar_Abertura", connect)
        Try
            abrir()
            cmdo.CommandType = 4
            With cmdo.Parameters
                .AddWithValue("@data_abertura", Now.ToShortDateString)
                .AddWithValue("@funcionario", usuarioNome)
                .Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmdo.ExecuteNonQuery()
            End With

            Dim msg As String = cmdo.Parameters("@mensagem").Value
            ValorAbertura = VendasDiaAbreFechaCaixa.lblLabelValorAbertura.Text

            If (msg = "Abra primeiro o caixa!") And ValorAbertura = 0 Then
                abertura = False
                MessageBox.Show("O caixa está fechado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf (msg = "Abra primeiro o caixa!") And ValorAbertura > 0 Then
                abertura = False
                MessageBox.Show("O caixa já foi aberto hoje!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim newMDIchild = New Vendas
                newMDIchild.MdiParent = Me
                newMDIchild.Show()
                abertura = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            fechar()
        End Try
    End Sub

    Private Sub menuVendasDoDiaAbreFechaCaixa_Click(sender As Object, e As EventArgs) Handles menuVendasDoDiaAbreFechaCaixa.Click
        Dim newMDIchild = New VendasDiaAbreFechaCaixa()
        newMDIchild.MdiParent = Me
        newMDIchild.Show()
    End Sub

    Private Sub menuVendasDetalhesDasVendas_Click(sender As Object, e As EventArgs) Handles menuVendasDetalhesDasVendas.Click
        Dim newMDIchild = New DetalhesVenda
        newMDIchild.MdiParent = Me
        newMDIchild.Show()
    End Sub

    Private Sub menuVendasSangria_Click(sender As Object, e As EventArgs) Handles menuVendasSangria.Click

        Dim ParamForm As Form
        ParamForm = Sangria

        Dim newMDIchild = New LoginAdm(ParamForm)
        newMDIchild.MdiParent = Me.MdiParent
        newMDIchild.Show()
        CarregarDados()

    End Sub

    Private Sub menuRelatorioDeProdutos_Click(sender As Object, e As EventArgs) Handles menuRelatorioDeProdutos.Click
        Dim newMDIchild = New frmRelProdutos
        newMDIchild.MdiParent = Me
        newMDIchild.Show()
    End Sub

    Private Sub menuRelatorioDeVendas_Click(sender As Object, e As EventArgs) Handles menuRelatorioDeVendas.Click
        Dim newMDIchild = New frnRelVenda
        newMDIchild.MdiParent = Me
        newMDIchild.Show()
    End Sub

    Private Sub menuSairSair_Click(sender As Object, e As EventArgs) Handles menuSairSair.Click
        Application.Exit()
    End Sub

    Private Sub menuSairLogOff_Click(sender As Object, e As EventArgs) Handles menuSairLogOff.Click
        Dim form = New Login
        Me.Hide()
        form.ShowDialog()
    End Sub

    Private Sub MDIPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        VerificarNiveis()

        sslUsuario.Text = usuarioNome

        Dim usuario As String = Login.txtUsuario.Text

        Dim cmd As New SqlCommand("sp_BuscarCargo", connect)

        Try
            abrir()
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@nome", usuario)
            cmd.Parameters.Add("@cargo", SqlDbType.VarChar, 50).Direction = 2
            cmd.ExecuteNonQuery()

            cargo = cmd.Parameters("@cargo").Value

            If cargo = "Administrador" Then
                menuCadastroFuncionarios.Enabled = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        sslHora.Text = Now.ToLongTimeString()
        sslData.Text = Now.ToShortDateString()
    End Sub

    Private Sub menuRelatorioDoCaixa_Click(sender As Object, e As EventArgs) Handles menuRelatorioDoCaixa.Click
        Dim newMDIchild = New frmRelCaixa
        newMDIchild.MdiParent = Me
        newMDIchild.Show()
    End Sub

    Private Sub CarregarDados()

        Dim cmd As New SqlCommand("sp_BuscarDadosCaixa", connect)

        Try
            abrir()
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@data_abertura", Now.ToShortDateString())
            cmd.Parameters.AddWithValue("@funcionario", usuarioNome)
            cmd.Parameters.Add("@qtdade_vendas", SqlDbType.Int).Direction = 2
            cmd.Parameters.Add("@hora_abertura", SqlDbType.Time).Direction = 2
            cmd.Parameters.Add("@hora_sangria", SqlDbType.Time).Direction = 2
            cmd.Parameters.Add("@valor_abertura", SqlDbType.Decimal).Direction = 2
            cmd.Parameters.Add("@valor_sangria", SqlDbType.Decimal).Direction = 2
            cmd.Parameters.Add("@total_vendido", SqlDbType.Decimal).Direction = 2
            cmd.ExecuteNonQuery()

            Dim QtdeVendas As Integer
            QtdeVendas = cmd.Parameters("@qtdade_vendas").Value
            VendasDiaAbreFechaCaixa.lblItensVendidosDia.Text = CStr(QtdeVendas)

            Dim hora_sangria As TimeSpan
            hora_sangria = cmd.Parameters("@hora_sangria").Value
            VendasDiaAbreFechaCaixa.lblLabelUltimaSangria.Text = hora_sangria.ToString()

            Dim hora_abertura As TimeSpan
            hora_abertura = cmd.Parameters("@hora_abertura").Value
            VendasDiaAbreFechaCaixa.lblLabelHoraAbertura.Text = hora_abertura.ToString()

            Dim valor_abertura As Decimal = cmd.Parameters("@valor_abertura").Value
            VendasDiaAbreFechaCaixa.lblLabelValorAbertura.Text = valor_abertura.ToString
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("pt-BR")
            VendasDiaAbreFechaCaixa.lblLabelValorAbertura.Text = String.Format("{0:C}", Convert.ToDouble(VendasDiaAbreFechaCaixa.lblLabelValorAbertura.Text))

            Dim total_sangria As Decimal = cmd.Parameters("@valor_sangria").Value
            VendasDiaAbreFechaCaixa.lblLabelUltimaSangria.Text = CStr(total_sangria)
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("pt-BR")
            VendasDiaAbreFechaCaixa.lblLabelUltimaSangria.Text = String.Format("{0:C}", Convert.ToDouble(VendasDiaAbreFechaCaixa.lblLabelUltimaSangria.Text))

            Dim total_caixa As Decimal = cmd.Parameters("@total_vendido").Value
            VendasDiaAbreFechaCaixa.txtTotalVendido.Text = CStr(total_caixa)
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("pt-BR")
            VendasDiaAbreFechaCaixa.txtTotalVendido.Text = String.Format("{0:C}", Convert.ToDouble(VendasDiaAbreFechaCaixa.txtTotalVendido.Text))

            If valor_abertura = 0 And DataAbertura <> Now.ToShortDateString Then
                abertura = False
                CarregarImagem()
            ElseIf valor_abertura = 0 And DataAbertura = Now.ToShortDateString Then
                abertura = True
                CarregarImagem()
            ElseIf valor_abertura > 0 Then
                abertura = False
                CarregarImagem()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub CarregarImagem()

        If abertura = True Then
            VendasDiaAbreFechaCaixa.pcbCaixa.Image = My.Resources.CaixaAberto
            VendasDiaAbreFechaCaixa.lblTextoCaixa.Text = "CAIXA ABERTO"
            VendasDiaAbreFechaCaixa.lblAbrirFechar.Text = "FECHAR CAIXA"
        Else
            VendasDiaAbreFechaCaixa.pcbCaixa.Image = My.Resources.CaixaFechado
            VendasDiaAbreFechaCaixa.lblTextoCaixa.Text = "CAIXA FECHADO"
            VendasDiaAbreFechaCaixa.lblAbrirFechar.Text = "ABRIR CAIXA"
        End If

    End Sub

    Private Sub EntradaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradaToolStripMenuItem.Click
        Dim newMDIchild = New Estoque(0)
        newMDIchild.MdiParent = Me
        newMDIchild.Show()
    End Sub

    Private Sub ConsultasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultasToolStripMenuItem.Click
        Dim newMDIchild = New ConsultaEstoque
        newMDIchild.MdiParent = Me
        newMDIchild.Show()
    End Sub

    Private Sub RelatórioDeEntradaSaídaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelatórioDeEntradaSaídaToolStripMenuItem.Click
        Dim newMDIchild = New frmEstoqueData
        newMDIchild.MdiParent = Me
        newMDIchild.Show()
    End Sub

    Private Sub NíveisDeProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NíveisDeProdutosToolStripMenuItem.Click
        Dim newMDIchild = New frmNivel
        newMDIchild.MdiParent = Me
        newMDIchild.Show()
    End Sub

    Private Sub ProdutosComNívelCríticoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdutosComNívelCríticoToolStripMenuItem.Click
        Dim newMDIchild = New FrmRelNiveis
        newMDIchild.MdiParent = Me
        newMDIchild.Show()
    End Sub

    Sub VerificarNiveis()
        Dim cmd As New SqlCommand("sp_VerificarNivel", connect)

        Try
            abrir()
            cmd.CommandType = 4
            With cmd.Parameters
                .Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()
            End With

            Dim msg As String = cmd.Parameters("@mensagem").Value
            If (msg = "Estoque Baixo!") Then
                sslNivel.BackColor = Color.Red
                sslNivel.Text = "BAIXO"
                sslNivel.ForeColor = Color.White
            Else
                sslNivel.BackColor = Color.Green
                sslNivel.Text = "BOM"
                sslNivel.ForeColor = Color.White
            End If
        Catch ex As Exception
            MessageBox.Show("Erro ao efetuar procedimento!" + ex.Message)
            fechar()
        End Try
    End Sub

    Private Sub MDIPrincipal_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        VerificarNiveis()
    End Sub

    Private Sub sslNivel_Click(sender As Object, e As EventArgs) Handles sslNivel.Click
        Dim newMDIchild = New frmNivel
        newMDIchild.MdiParent = Me
        newMDIchild.Show()
    End Sub

    Private Sub ProdutosMaisVendidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdutosMaisVendidosToolStripMenuItem.Click
        Dim newMDIchild = New FrmRelProdVend
        newMDIchild.MdiParent = Me
        newMDIchild.Show()
    End Sub

End Class
