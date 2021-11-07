Imports System.Data.SqlClient

Public Class Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim usuario As String = txtUsuario.Text
        Dim senha As String = txtSenha.Text

        If usuario = "" Or senha = "" Then
            MsgBox("Preencha todos os campos!")
            txtSenha.Clear()
            txtUsuario.Clear()
            txtUsuario.Focus()
        Else

            Dim cmd As New SqlCommand("sp_Login", connect)

            Try
                abrir()
                cmd.CommandType = 4
                With cmd.Parameters
                    .AddWithValue("@nome", usuario)
                    .AddWithValue("@senha", senha)
                    .Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                    cmd.ExecuteNonQuery()
                End With
                usuarioNome = txtUsuario.Text
                Dim msg As String = cmd.Parameters("@mensagem").Value
                MsgBox(msg, vbInformation)

                If (msg = "Dados incorretos!") Then
                    txtSenha.Clear()
                    txtUsuario.Clear()
                    txtUsuario.Focus()
                Else
                    Dim form = New MDIPrincipal
                    Me.Hide()
                    form.ShowDialog()
                End If
            Catch ex As Exception
                MessageBox.Show("Erro ao efetuar Login!" + ex.Message)
                fechar()
            End Try

        End If

    End Sub

    Private Sub txtUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsuario.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txtSenha.Focus()
        End If
    End Sub

    Private Sub txtSenha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSenha.KeyPress

        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then
            btnLogin.Focus()
        End If
    End Sub

End Class