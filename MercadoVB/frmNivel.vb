Imports System.Data.SqlClient

Public Class frmNivel

    Private Sub FormatarDGV()
        Try
            dgvNivel.ReadOnly = True
            dgvNivel.Columns(0).Visible = False
            dgvNivel.Columns(1).HeaderText = "Descrição"
            dgvNivel.Columns(1).Width = 250
            dgvNivel.Columns(2).HeaderText = "Fornecedor"
            dgvNivel.Columns(2).Width = 300
            dgvNivel.Columns(3).HeaderText = "Unidade"
            dgvNivel.Columns(4).HeaderText = "Quantidade"
            dgvNivel.Columns(4).DefaultCellStyle.Format = "0000"
            dgvNivel.Columns(4).Width = 100
            dgvNivel.Columns(5).HeaderText = "Valor"
            dgvNivel.Columns(5).DefaultCellStyle.Format = "C2"
            dgvNivel.Columns(5).Width = 90
            dgvNivel.Columns(6).HeaderText = "Estoque Mínimo"
            dgvNivel.Columns(6).DefaultCellStyle.Format = "0000"
            dgvNivel.Columns(6).Width = 120
            dgvNivel.Columns(7).Visible = False
            dgvNivel.Columns(8).Visible = False
        Catch ex As Exception
            MessageBox.Show(MessageBoxOptions.ServiceNotification, "Algo saiu errado!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        End Try
    End Sub

    Private Sub Listar()

        Dim dt As New DataTable
        Dim dta As SqlDataAdapter

        Try
            abrir()
            dta = New SqlDataAdapter("SELECT p.id_produto, p.descricao, f.nome_for, p.unidade, p.quantidade, p.valor, p.minimo, p.imagem,
                                     p.id_fornecedor FROM produtos AS p INNER JOIN fornecedores AS f ON p.id_fornecedor = f.id_fornecedor 
                                     WHERE quantidade < minimo", connect)
            dta.Fill(dt)
            dgvNivel.DataSource = dt
            ContarLinhas()
            FormatarDGV()
        Catch ex As Exception
            MessageBox.Show(MessageBoxOptions.ServiceNotification, "Erro ao conectar ao banco de dados!")
            fechar()
        End Try
    End Sub

    Private Sub ContarLinhas()
        Dim Total As Integer = dgvNivel.Rows.Count
        lblQtdeTotal.Text = Total
        lblQtdeTotal.Text = lblQtdeTotal.Text.PadLeft(4, "0")
    End Sub

    Private Sub frmNivel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()
    End Sub

    Private Sub dgvNivel_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNivel.CellDoubleClick
        Dim id_produto As Integer
        id_produto = dgvNivel.CurrentRow.Cells(0).Value
        Dim newMDIchild = New Estoque(id_produto)
        newMDIchild.MdiParent = Me.MdiParent
        newMDIchild.Show()
    End Sub

    Private Sub frmNivel_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Listar()
    End Sub
End Class