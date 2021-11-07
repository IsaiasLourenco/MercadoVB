Imports System.Data.SqlClient

Public Class Sangria
    Private Sub txtValorSangria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValorSangria.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btnGravar.Focus()
        End If
    End Sub

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click

        Dim cmd As SqlCommand

        If txtValorSangria.Text <> "" Then
            Try
                abrir()
                'RECUPERAÇÃO DO VALOR ANTERIOR DA SANGRIA
                Dim TotalSangria As Decimal
                Dim SangriaAtual As Decimal
                Dim SangriaBD As Decimal
                SangriaAtual = txtValorSangria.Text
                SangriaBD = lblValorTotalSangria.Text
                TotalSangria = SangriaAtual + SangriaBD

                'EDIÇÃO DA SANGRIA
                cmd = New SqlCommand("sp_EditarSangria", connect)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@data_abertura", Now.ToShortDateString())
                cmd.Parameters.AddWithValue("@funcionario", usuarioNome)
                cmd.Parameters.AddWithValue("@valor_sangria", TotalSangria)
                cmd.Parameters.AddWithValue("@hora_sangria", Now.ToLongTimeString())

                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.Hide()

            Catch ex As Exception
                MessageBox.Show("Erro ao editar dados!" + ex.Message)
                fechar()
            End Try
        End If

    End Sub

    Private Sub Sangria_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
            cmd.Parameters.AddWithValue("@total_vendido", SqlDbType.Decimal).Direction = 2
            cmd.ExecuteNonQuery()

            Dim ValorAbertura As Decimal

            If cmd.Parameters("@valor_abertura").Value Is DBNull.Value Or cmd.Parameters("@valor_abertura").Value = 0 Then
                cmd.Parameters("@valor_abertura").Value = 0
                ValorAbertura = cmd.Parameters("@valor_abertura").Value
                If ValorAbertura <= 0 Then
                    MessageBox.Show("O caixa ainda não foi aberto, impossível fazer sangria!!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If
            ElseIf cmd.Parameters("@valor_abertura").Value > 0 And cmd.Parameters("@qtdade_vendas").Value > 0 Then
                MessageBox.Show("O caixa já foi fechado, impossível fazer sangria!!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                Dim total_sangria As Decimal = cmd.Parameters("@valor_sangria").Value
                lblValorTotalSangria.Text = CStr(total_sangria)
                System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("pt-BR")
                lblValorTotalSangria.Text = String.Format("{0:C}", Convert.ToDouble(lblValorTotalSangria.Text))
            End If

            txtValorSangria.Text = ""
            txtValorSangria.Focus()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class