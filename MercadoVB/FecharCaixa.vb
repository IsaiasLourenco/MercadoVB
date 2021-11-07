Imports System.Data.SqlClient

Public Class FecharCaixa
    Private valorAbertura As Decimal
    Private qtdeVendas As Integer
    Private prodVendidos As Integer
    Private total_vendido As Decimal
    Private HoraAbertura As TimeSpan
    Private ValorSangria As Decimal
    Private TotalCaixa As Decimal

    Public Sub New(valorAbertura As Decimal, qtdeVendas As Integer, prodVendidos As Integer, total_vendido As Decimal, HoraAbertura As TimeSpan, ValorSangria As Decimal, TotalCaixa As Decimal)
        InitializeComponent()
        Me.valorAbertura = valorAbertura
        Me.qtdeVendas = qtdeVendas
        Me.prodVendidos = prodVendidos
        Me.total_vendido = total_vendido
        Me.HoraAbertura = HoraAbertura
        Me.ValorSangria = ValorSangria
        Me.TotalCaixa = TotalCaixa
    End Sub

    Private Sub txtValorAbertura_TextChanged(sender As Object, e As EventArgs) Handles txtValorAbertura.TextChanged
        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("pt-BR")
            txtValorAbertura.Text = String.Format("{0:C}", Convert.ToDouble(txtValorAbertura.Text))
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click

        Dim cmd As SqlCommand

        If txtTotalCaixa.Text <> "" Then

            Dim subtotal As Decimal
            subtotal = TotalCaixa + ValorSangria

            Dim quebra As Decimal
            quebra = TotalCaixa + ValorSangria - subtotal
            Try
                abrir()
                cmd = New SqlCommand("sp_FecharCaixa", connect)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@data_abertura", Now.ToShortDateString())
                cmd.Parameters.AddWithValue("@funcionario", usuarioNome)
                cmd.Parameters.AddWithValue("@valor_abertura", CDec(txtValorAbertura.Text))
                cmd.Parameters.AddWithValue("@hora_abertura", HoraAbertura)
                cmd.Parameters.AddWithValue("@qtdade_vendas", qtdeVendas)
                cmd.Parameters.AddWithValue("@total_itens", prodVendidos)
                cmd.Parameters.AddWithValue("@total_vendido", CDec(total_vendido))
                cmd.Parameters.AddWithValue("@total_caixa", CDec(txtTotalCaixa.Text))
                cmd.Parameters.AddWithValue("@saldo_total", CDec(subtotal))
                cmd.Parameters.AddWithValue("@valor_quebra", CDec(quebra))
                cmd.Parameters.AddWithValue("@hora_fechamento", Now.ToLongTimeString())

                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.Hide()
                abertura = False
                VendasDiaAbreFechaCaixa.Show()

            Catch ex As Exception
                MessageBox.Show("Erro ao editar dados!" + ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Private Sub txtTotalCaixa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotalCaixa.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btnGravar.Focus()
        End If
    End Sub

    Private Sub FecharCaixa_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtTotalCaixa.Focus()
        txtValorAbertura.Text = valorAbertura
    End Sub

    Private Sub txtTotalCaixa_LostFocus(sender As Object, e As EventArgs) Handles txtTotalCaixa.LostFocus
        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("pt-BR")
            txtTotalCaixa.Text = String.Format("{0:C}", Convert.ToDouble(txtTotalCaixa.Text))
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Listar()
        Dim dt As New DataTable
        Dim dta As SqlDataAdapter
        Dim cmd As SqlCommand
        Try
            abrir()
            cmd = New SqlCommand("SELECT * FROM caixa WHERE funcionario = @funcionario AND data_abertura = @data_abertura", connect)
            cmd.Parameters.AddWithValue("@funcionario", usuarioNome)
            cmd.Parameters.AddWithValue("@data_abertura", Now.ToShortDateString())
            dta = New SqlDataAdapter(cmd)
            dta.Fill(dt)
            dgvFechaCaixa.DataSource = dt
            FormatarDGV()
        Catch ex As Exception
            MessageBox.Show(MessageBoxOptions.ServiceNotification, "Erro ao conectar ao banco de dados!")
            fechar()
        End Try
    End Sub

    Private Sub FormatarDGV()
        Try
            dgvFechaCaixa.ReadOnly = True
            dgvFechaCaixa.Columns(0).Visible = False
            dgvFechaCaixa.Columns(1).Visible = False
            dgvFechaCaixa.Columns(2).Visible = False
            dgvFechaCaixa.Columns(3).Visible = False
            dgvFechaCaixa.Columns(6).Visible = False
            dgvFechaCaixa.Columns(10).Visible = False
            dgvFechaCaixa.Columns(11).Visible = False
            dgvFechaCaixa.Columns(12).Visible = False
            dgvFechaCaixa.Columns(13).Visible = False
            dgvFechaCaixa.Columns(4).HeaderText = "Hora da Abertura"
            dgvFechaCaixa.Columns(4).Width = 100
            dgvFechaCaixa.Columns(5).HeaderText = "Valor das Sangrias"
            dgvFechaCaixa.Columns(5).Width = 140
            dgvFechaCaixa.Columns(5).DefaultCellStyle.Format = "C2"
            dgvFechaCaixa.Columns(7).HeaderText = "Quantidade de Vendas"
            dgvFechaCaixa.Columns(7).Width = 140
            dgvFechaCaixa.Columns(7).DefaultCellStyle.Format = "0000"
            dgvFechaCaixa.Columns(8).HeaderText = "Total de Itens Vendidos"
            dgvFechaCaixa.Columns(8).Width = 150
            dgvFechaCaixa.Columns(8).DefaultCellStyle.Format = "0000"
            dgvFechaCaixa.Columns(9).HeaderText = "Total Vendido"
            dgvFechaCaixa.Columns(9).DefaultCellStyle.Format = "C2"
            dgvFechaCaixa.Columns(9).Width = 150

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FecharCaixa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VendasDiaAbreFechaCaixa.Close()
        TotalCaixa = valorAbertura + total_vendido - ValorSangria
        txtTotalCaixa.Text = TotalCaixa
        EditarCaixa()
        Listar()
    End Sub

    Private Sub EditarCaixa()
        Dim cmd As SqlCommand

        Dim subtotal As Decimal
        subtotal = TotalCaixa + valorAbertura + ValorSangria

        Dim quebra As Decimal
        quebra = TotalCaixa + total_vendido + valorAbertura - ValorSangria

        Try
            abrir()

            cmd = New SqlCommand("sp_EditarCaixa", connect)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@data_abertura", Now.ToShortDateString())
            cmd.Parameters.AddWithValue("@funcionario", usuarioNome)
            cmd.Parameters.AddWithValue("@qtdade_vendas", qtdeVendas)
            cmd.Parameters.AddWithValue("@total_itens", prodVendidos)
            cmd.Parameters.AddWithValue("@total_vendido", CDec(total_vendido))
            cmd.Parameters.AddWithValue("@total_caixa", CDec(TotalCaixa))
            cmd.Parameters.AddWithValue("@saldo_total", CDec(subtotal))
            cmd.Parameters.AddWithValue("@valor_quebra", CDec(quebra))

            cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
            cmd.ExecuteNonQuery()

            Dim msg As String = cmd.Parameters("@mensagem").Value.ToString

            Me.Hide()

        Catch ex As Exception
            MessageBox.Show("Erro ao editar dados!" + ex.Message)
            fechar()
        End Try
    End Sub
End Class