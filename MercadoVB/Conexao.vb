Imports System.Data.SqlClient

Module Conexao

    Public connect As New SqlConnection("Server=.; Database=MercadoVB; Integrated Security=SSPI")

    Sub abrir()
        If connect.State = 0 Then
            connect.Open()
        End If
    End Sub

    Sub fechar()
        If connect.State = 1 Then
            connect.Close()
        End If
    End Sub

    Public usuarioNome As String

    Public cargo As String

    Public TotalVendido As Integer

    Public TotalVendidoDia As Decimal

    Public abertura As Boolean

    Public ValorAbertura As Decimal

    Public DataAbertura As DateTime

End Module
