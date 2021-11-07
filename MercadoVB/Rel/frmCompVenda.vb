
Public Class frmCompVenda

    Private venda As String

    Public Sub New(venda As String)
        InitializeComponent()
        Me.venda = venda
    End Sub

    Public Sub CompRel(ByVal venda As String)
        InitializeComponent()
    End Sub

    Private Sub frmCompVenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CompRel(venda)

        Me.ComprovanteTableAdapter.Fill(Me.VendasDataSet.Comprovante, venda)

        Me.rpvComprovante.RefreshReport()
    End Sub
End Class