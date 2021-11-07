Imports System.Data.SqlClient

Public Class AbrirCaixa

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click

        Dim cmd As SqlCommand

        txtValorAbertura.Text.ToString()

        If txtValorAbertura.Text = "" Then
            MessageBox.Show("Favor entrar com valor de abertura!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                abrir()
                cmd = New SqlCommand("sp_AberturaCaixa", connect)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@data_abertura", Now.ToShortDateString())
                cmd.Parameters.AddWithValue("@funcionario", usuarioNome)
                cmd.Parameters.AddWithValue("@valor_abertura", txtValorAbertura.Text)
                cmd.Parameters.AddWithValue("@hora_abertura", Now.ToLongTimeString())
                cmd.Parameters.AddWithValue("@valor_sangria", 0)
                cmd.Parameters.AddWithValue("@hora_sangria", Now.ToShortTimeString)
                cmd.Parameters.AddWithValue("@qtdade_vendas", 0)
                cmd.Parameters.AddWithValue("@total_itens", 0)
                cmd.Parameters.AddWithValue("@total_vendido", TotalVendido)
                cmd.Parameters.AddWithValue("@total_caixa", 0)
                cmd.Parameters.AddWithValue("@saldo_total", 0)
                cmd.Parameters.AddWithValue("@valor_quebra", 0)
                cmd.Parameters.AddWithValue("@hora_fechamento", Now.ToShortTimeString)

                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString

                MessageBox.Show(msg, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Dim form = New VendasDiaAbreFechaCaixa()
                form.Show()
                Me.Close()

            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados! " + ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Private Sub txtValorAbertura_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValorAbertura.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btnGravar.Focus()
        End If
    End Sub

End Class