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

End Module
