Option Explicit On
Imports System.Data.SqlTypes
Imports System.Data.SqlClient

Public Class VendasDiaAbreFechaCaixa

    Private ImagemCarregada As Image

    Private Sub Listar()

        Dim dt As New DataTable
        Dim dta As SqlDataAdapter
        Dim cmd As SqlCommand

        Try
            abrir()
            cmd = New SqlCommand("Select v.id_vendas, p.descricao, f.nome, c.nome, 
                                    v.quantidade, p.valor, v.total, v.data_venda, v.id_produto, v.id_cli, v.id_func FROM vendas 
                                    AS v INNER JOIN produtos AS p ON v.id_produto = p.id_produto INNER JOIN clientes AS c ON
                                    c.id_cli = v.id_cli INNER JOIN funcionarios AS f ON f.id_func = v.id_func WHERE v.data_venda = 
                                    @data AND f.nome = @nome", connect)
            cmd.Parameters.AddWithValue("@data", Now.Date())
            cmd.Parameters.AddWithValue("@nome", usuarioNome)
            dta = New SqlDataAdapter(cmd)
            dta.Fill(dt)
            dgvVendas.DataSource = dt

            FormatarDGV()

            Linhas()
            Totalizar()
            SomarQuantidadeProdutos()

        Catch ex As Exception
            MessageBox.Show(MessageBoxOptions.ServiceNotification, "Erro ao conectar ao banco de dados!")
            MsgBox(ex.Message)
            fechar()
        End Try
    End Sub

    Private Sub Linhas()
        lblItensVendidosDia.Text = dgvVendas.Rows.Count()
        lblItensVendidosDia.Text = lblItensVendidosDia.Text.PadLeft(4, "0")
    End Sub

    Private Sub FormatarDGV()
        Try
            dgvVendas.ReadOnly = True
            dgvVendas.Columns(0).Visible = False
            dgvVendas.Columns(1).HeaderText = "Produto"
            dgvVendas.Columns(1).Width = 200
            dgvVendas.Columns(2).Visible = False
            dgvVendas.Columns(3).HeaderText = "Cliente"
            dgvVendas.Columns(4).HeaderText = "Quantidade"
            dgvVendas.Columns(4).DefaultCellStyle.Format = "0000"
            dgvVendas.Columns(4).Width = 80
            dgvVendas.Columns(5).HeaderText = "Valor Unitário"
            dgvVendas.Columns(5).DefaultCellStyle.Format = "C2"
            dgvVendas.Columns(5).Width = 90
            dgvVendas.Columns(6).HeaderText = "Total"
            dgvVendas.Columns(6).DefaultCellStyle.Format = "C2"
            dgvVendas.Columns(6).Width = 90
            dgvVendas.Columns(7).Visible = False
            dgvVendas.Columns(8).Visible = False
            dgvVendas.Columns(9).Visible = False
            dgvVendas.Columns(10).Visible = False
        Catch ex As Exception
            MessageBox.Show(MessageBoxOptions.ServiceNotification, "Algo saiu errado!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        End Try
    End Sub

    Sub SomarQuantidadeProdutos()
        Dim qtde As Decimal
        For Each linha As DataGridViewRow In dgvVendas.Rows
            qtde = qtde + linha.Cells(5).Value
        Next
        lblLabelProdutosVendidos.Text = qtde
        lblLabelProdutosVendidos.Text = lblLabelProdutosVendidos.Text.PadLeft(4, "0")
    End Sub

    Private Sub VendasDiaAbreFechaCaixa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        VerificarAbertura()
        If abertura = True Then
            CarregarDados()
        Else
            CarregarDados()
        End If

        Totalizar()

        txtTotalVendido.ForeColor = Color.LightGreen

        lblLabelOperador.Text = usuarioNome

        Decimal.TryParse(txtTotalVendido.Text, TotalVendidoDia)

        txtTotalVendido.Text = CType(txtTotalVendido.Text, String)
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("pt-BR")

    End Sub

    Private Sub Totalizar()

        Dim total As Decimal

        For Each linha As DataGridViewRow In dgvVendas.Rows
            total = total + linha.Cells(6).Value
        Next

        txtTotalVendido.Text = total

        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("pt-BR")
        txtTotalVendido.Text = String.Format("{0:C}", Convert.ToDouble(txtTotalVendido.Text))
        TotalVendidoDia = total

    End Sub

    Public Sub CarregarImagem()

        If abertura = True Then
            pcbCaixa.Image = My.Resources.CaixaAberto
            lblTextoCaixa.Text = "CAIXA ABERTO"
            lblAbrirFechar.Text = "FECHAR CAIXA"
        Else
            pcbCaixa.Image = My.Resources.CaixaFechado
            lblTextoCaixa.Text = "CAIXA FECHADO"
            lblAbrirFechar.Text = "ABRIR CAIXA"
        End If

    End Sub

    Sub VerificarAbertura()

        abrir()

        Dim cmdo As New SqlCommand("sp_Verificar_Abertura", connect)
        Try
            cmdo.CommandType = 4
            With cmdo.Parameters
                .AddWithValue("@data_abertura", Now.ToShortDateString)
                .AddWithValue("@funcionario", usuarioNome)
                .Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmdo.ExecuteNonQuery()
            End With

            Dim msg As String = cmdo.Parameters("@mensagem").Value
            ValorAbertura = lblLabelValorAbertura.Text

            If (msg = "Abra primeiro o caixa!") And ValorAbertura = 0 Then
                abertura = False
                CarregarImagem()
            ElseIf (msg = "Abra primeiro o caixa!") And ValorAbertura > 0 Then
                abertura = False
                CarregarImagem()
                MessageBox.Show("O caixa já foi aberto hoje!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                abertura = True
                CarregarImagem()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            fechar()
        End Try
    End Sub

    Private Sub pcbCaixa_Click(sender As Object, e As EventArgs) Handles pcbCaixa.Click

        Try
            If abertura = True Then

                Dim ValorAbertura As Decimal
                ValorAbertura = lblLabelValorAbertura.Text

                Dim qtdeVendas As Integer
                qtdeVendas = lblItensVendidosDia.Text

                Dim prodVendidos As Integer
                prodVendidos = lblLabelProdutosVendidos.Text

                Dim total_vendido As Decimal
                total_vendido = txtTotalVendido.Text

                Dim HoraAbertura As TimeSpan
                HoraAbertura = TimeSpan.Parse(lblLabelHoraAbertura.Text)

                Dim ValorSangria As Decimal
                ValorSangria = lblLabelUltimaSangria.Text

                Dim TotalCaixa As Decimal
                TotalCaixa = txtTotalVendido.Text

                Dim ParamForm = New FecharCaixa(ValorAbertura, qtdeVendas, prodVendidos, total_vendido, HoraAbertura, ValorSangria, TotalCaixa)

                Dim newMDIchild = New LoginAdm(ParamForm)
                newMDIchild.MdiParent = Me.MdiParent
                newMDIchild.Show()
                CarregarImagem()
                Me.Hide()
            Else
                Dim ValorAbertura As Decimal
                ValorAbertura = lblLabelValorAbertura.Text
                If ValorAbertura > 0 Then
                    MessageBox.Show("O caixa já foi aberto hoje!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CarregarImagem()
                Else
                    Dim ParamForm As Form
                    ParamForm = AbrirCaixa
                    Dim newMDIchild = New LoginAdm(ParamForm)
                    newMDIchild.MdiParent = Me.MdiParent
                    newMDIchild.Show()
                    CarregarImagem()
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

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
            lblItensVendidosDia.Text = CStr(QtdeVendas)

            Dim hora_abertura As TimeSpan
            hora_abertura = cmd.Parameters("@hora_abertura").Value
            lblLabelHoraAbertura.Text = hora_abertura.ToString()

            Dim hora_sangria As TimeSpan
            hora_sangria = cmd.Parameters("@hora_sangria").Value
            lblLabelUltimaSangria.Text = hora_sangria.ToString()

            Dim valor_abertura As Decimal = cmd.Parameters("@valor_abertura").Value
            lblLabelValorAbertura.Text = valor_abertura.ToString
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("pt-BR")
            lblLabelValorAbertura.Text = String.Format("{0:C}", Convert.ToDouble(lblLabelValorAbertura.Text))

            Dim total_sangria As Decimal = cmd.Parameters("@valor_sangria").Value
            lblLabelUltimaSangria.Text = CStr(total_sangria)
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("pt-BR")
            lblLabelUltimaSangria.Text = String.Format("{0:C}", Convert.ToDouble(lblLabelUltimaSangria.Text))

            Dim total_vendido As Decimal = cmd.Parameters("@total_vendido").Value
            txtTotalVendido.Text = CStr(total_vendido)
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("pt-BR")
            txtTotalVendido.Text = String.Format("{0:C}", Convert.ToDouble(txtTotalVendido.Text))

            If valor_abertura = 0 And cmd.Parameters("@total_vendido").Value = 0 Then
                abertura = False
                CarregarImagem()
            ElseIf valor_abertura > 0 And cmd.Parameters("@total_vendido").Value > 0 Then
                abertura = False
                CarregarImagem()
            ElseIf valor_abertura = 0 Then
                abertura = True
                CarregarImagem()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        lblHora.Text = Now.ToLongTimeString()
        lblData.Text = Now.ToShortDateString()

    End Sub

    Private Sub VendasDiaAbreFechaCaixa_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        VerificarNiveis()
        Listar()
        Totalizar()
        VerificarAbertura()
        If abertura = True Then
            CarregarDados()
        Else
            CarregarDados()
        End If

        Linhas()
        Totalizar()
        SomarQuantidadeProdutos()
    End Sub

    Sub VerificarFechamento()
        Dim cmd As SqlCommand
        Try
            abrir()
            cmd = New SqlCommand("SELECT * FROM caixa WHERE funcionario = @funcionario AND data_abertura = @data_abertura", connect)
            cmd.Parameters.AddWithValue("@funcionario", usuarioNome)
            cmd.Parameters.AddWithValue("@data_abertura", Now.ToShortDateString())

            FormatarDGV()
        Catch ex As Exception
            MessageBox.Show(MessageBoxOptions.ServiceNotification, "Erro ao conectar ao banco de dados!")
            fechar()
        End Try

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
                pcbNivel.Image = My.Resources.CaixaFechado
                lblNivel.Text = "ESTOQUE BAIXO"
            Else
                pcbNivel.Image = My.Resources.CaixaAberto
                lblNivel.Text = "ESTOQUE BOM"
            End If
        Catch ex As Exception
            MessageBox.Show("Erro ao efetuar procedimento!" + ex.Message)
            fechar()
        End Try
    End Sub

    Private Sub pcbNivel_Click(sender As Object, e As EventArgs) Handles pcbNivel.Click
        Dim newMDIchild = New frmNivel
        newMDIchild.MdiParent = Me.MdiParent
        newMDIchild.Show()
    End Sub
End Class