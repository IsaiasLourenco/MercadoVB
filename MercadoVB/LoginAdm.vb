Option Explicit On
Imports System.Data.SqlClient

Public Class LoginAdm

    Dim FormSangria As Form

    Sub New(ParamForm As Form)

        InitializeComponent()
        FormSangria = ParamForm

    End Sub

    Private Sub txtSenhaAdm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSenhaAdm.KeyPress

        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then
            btnAcessoAdm.Focus()
        End If

    End Sub

    Private Sub btnAcessoAdm_Click(sender As Object, e As EventArgs) Handles btnAcessoAdm.Click

        Dim usuario As String = usuarioNome
        Dim senha As String = txtSenhaAdm.Text

        If senha = "" Then
            MsgBox("Preencha o campo senha!")
            txtSenhaAdm.Text = ""
            txtSenhaAdm.Focus()
        Else

            Dim cmd As New SqlCommand("sp_AcessoAdm", connect)

            Try
                abrir()
                cmd.CommandType = 4
                With cmd.Parameters
                    .AddWithValue("@senha", senha)
                    .Add("@cargo", SqlDbType.VarChar, 50).Direction = 2
                    .Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                    cmd.ExecuteNonQuery()
                End With

                Dim acesso = cmd.Parameters("@cargo").Value
                Dim msg = cmd.Parameters("@mensagem").Value

                If acesso = "Administrador" Then
                    Me.Hide()
                    FormSangria.MdiParent = Me.MdiParent
                    FormSangria.Show()
                Else
                    MessageBox.Show("Senha do Adm incorreta!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtSenhaAdm.Text = ""
                    txtSenhaAdm.Focus()
                End If
            Catch ex As Exception
                MessageBox.Show("Erro ao efetuar Login de Administrador!" + ex.Message)
                fechar()
            End Try

        End If

    End Sub

End Class