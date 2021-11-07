Imports System.Data.SqlClient
Imports System.IO
Imports iTextSharp.text.pdf

Public Class Produtos

    Private ImagemCarregada As Image


    Private Sub txtDescricao_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescricao.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            cmbFornecedores.Focus()
        End If
    End Sub

    Private Sub txtQuantidade_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantidade.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txtValor.Focus()
        End If
    End Sub

    Private Sub txtMinimo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMinimo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btnGravar.Focus()
        End If
    End Sub

    Private Sub Produtos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarImagem()
        DesabilitarCampos()
        txtCodigoBarras.Enabled = True
        txtCodigoBarras.Focus()

        btnEditar.Enabled = False
        btnExcluir.Enabled = False
        Listar()
        FormatarDGV()
    End Sub

    Private Sub FormatarDGV()
        Try
            dgvProdutos.ReadOnly = True
            dgvProdutos.Columns(0).HeaderText = "Descrição"
            dgvProdutos.Columns(0).Width = 250
            dgvProdutos.Columns(1).HeaderText = "Fornecedor"
            dgvProdutos.Columns(1).Width = 300
            dgvProdutos.Columns(2).HeaderText = "Unidade"
            dgvProdutos.Columns(3).HeaderText = "Quantidade"
            dgvProdutos.Columns(3).DefaultCellStyle.Format = "0000"
            dgvProdutos.Columns(3).Width = 100
            dgvProdutos.Columns(4).HeaderText = "Valor"
            dgvProdutos.Columns(4).DefaultCellStyle.Format = "C2"
            dgvProdutos.Columns(4).Width = 90
            dgvProdutos.Columns(5).HeaderText = "Estoque Mínimo"
            dgvProdutos.Columns(5).DefaultCellStyle.Format = "0000"
            dgvProdutos.Columns(5).Width = 150
            dgvProdutos.Columns(6).Visible = False
            dgvProdutos.Columns(7).Visible = False
            dgvProdutos.Columns(8).HeaderText = "Qtdde Vendida"
            dgvProdutos.Columns(8).DefaultCellStyle.Format = "0000"
            dgvProdutos.Columns(8).Width = 150
            dgvProdutos.Columns(9).HeaderText = "Código de Barras"
            dgvProdutos.Columns(9).DefaultCellStyle.Format = "0000000000000"
            dgvProdutos.Columns(9).Width = 150

        Catch ex As Exception
            MessageBox.Show(MessageBoxOptions.ServiceNotification, "Algo saiu errado!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        End Try
    End Sub

    Private Sub Listar()

        Dim dt As New DataTable
        Dim dta As SqlDataAdapter

        Try
            abrir()
            dta = New SqlDataAdapter("SELECT p.descricao, f.nome_for, p.unidade, p.quantidade, p.valor, p.minimo, p.imagem,
                           p.id_fornecedor, p.qtdade_vendida, p.codigobarras FROM produtos AS p INNER JOIN fornecedores AS f ON p.id_fornecedor = f.id_fornecedor", connect)
            dta.Fill(dt)
            dgvProdutos.DataSource = dt
            ContarLinhas()
            FormatarDGV()
        Catch ex As Exception
            MessageBox.Show(MessageBoxOptions.ServiceNotification, "Erro ao conectar ao banco de dados!")
            fechar()
        End Try
    End Sub

    Private Sub ContarLinhas()
        Dim Total As Integer = dgvProdutos.Rows.Count
        lblQtdeTotal.Text = Total
        lblQtdeTotal.Text = lblQtdeTotal.Text.PadLeft(4, "0")
    End Sub

    Private Sub DesabilitarCampos()
        txtDescricao.Enabled = False
        cmbFornecedores.Enabled = False
        txtQuantidade.Enabled = False
        cmbUnidade.Enabled = False
        txtValor.Enabled = False
        btnExcluir.Enabled = False
        txtMinimo.Enabled = False
    End Sub

    Private Sub HabilitarCampos()
        txtBuscar.Enabled = True
        txtDescricao.Enabled = True
        cmbFornecedores.Enabled = True
        cmbUnidade.Enabled = True
        txtValor.Enabled = True
        btnExcluir.Enabled = True
        txtMinimo.Enabled = True
    End Sub

    Private Sub LimparCampos()
        txtBuscar.Text = ""
        txtDescricao.Text = ""
        cmbFornecedores.Text = ""
        txtQuantidade.Text = "0"
        cmbUnidade.Text = ""
        txtValor.Text = ""
        btnExcluir.Text = ""
        txtMinimo.Text = "0"
        CarregarImagem()
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        HabilitarCampos()
        LimparCampos()
        CarregarFornecedores()
        cmbFornecedores.Text = ""
        btnNovo.Enabled = False
        btnExcluir.Enabled = False
        btnGravar.Enabled = True
        txtDescricao.Focus()
        btnImage.Enabled = True
        txtQuantidade.Enabled = True
        CriarCodigoBarras()
    End Sub

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click
        Dim cmd As SqlCommand

        If txtCodigoBarras.Text <> "" Then
            Try

                'CARREGANDO IMAGEM NO BANCO
                Dim ms As New IO.MemoryStream
                ImagemCarregada.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim ByArr = ms.ToArray
                abrir()
                cmd = New SqlCommand("sp_SalvarProd", connect)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text)
                cmd.Parameters.AddWithValue("@quantidade", txtQuantidade.Text)
                cmd.Parameters.AddWithValue("@unidade", cmbUnidade.Text)
                cmd.Parameters.AddWithValue("@valor", CDec(txtValor.Text))
                cmd.Parameters.AddWithValue("@minimo", txtMinimo.Text)
                cmd.Parameters.AddWithValue("@imagem", ByArr)
                cmd.Parameters.AddWithValue("@id_fornecedor", cmbFornecedores.SelectedValue)
                cmd.Parameters.AddWithValue("@qtdade_vendida", 0)
                cmd.Parameters.AddWithValue("@codigobarras", txtCodigoBarras.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                PrintPreviewDialog1.Document = PrintDocument1
                PrintPreviewDialog1.Show()
                Listar()
                LimparCampos()

            Catch ex As Exception
                MessageBox.Show("Erro ao gravar informações! " + ex.Message)
                fechar()
            End Try
        Else
            MessageBox.Show(MessageBoxOptions.ServiceNotification, "Favor preencher todos os campos!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
            fechar()
        End If
        btnNovo.Enabled = True
        btnGravar.Enabled = False
        LimparCampos()
        DesabilitarCampos()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim cmd As SqlCommand

        If txtDescricao.Text <> "" And
                cmbFornecedores.Text <> "" And
                txtQuantidade.Text <> "" And
                txtValor.Text <> "" And
                txtMinimo.Text <> "" Then
            Try
                abrir()
                'CARREGANDO IMAGEM NO BANCO
                Dim ms As New IO.MemoryStream
                ImagemCarregada.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim ByArr = ms.ToArray

                txtCodigoBarras.Enabled = False
                cmd = New SqlCommand("sp_EditarProd", connect)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@codigobarras", txtCodigoBarras.Text)
                cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text)
                cmd.Parameters.AddWithValue("@quantidade", txtQuantidade.Text)
                cmd.Parameters.AddWithValue("@unidade", cmbUnidade.Text)
                cmd.Parameters.AddWithValue("@valor", CDec(txtValor.Text))
                cmd.Parameters.AddWithValue("@minimo", txtMinimo.Text)
                cmd.Parameters.AddWithValue("@imagem", ByArr)
                cmd.Parameters.AddWithValue("@id_fornecedor", cmbFornecedores.SelectedValue)
                cmd.Parameters.Add("@qtdade_vendida", SqlDbType.Int).Direction = 2
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString

                MessageBox.Show(msg, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Listar()
                LimparCampos()

            Catch ex As Exception
                MessageBox.Show("Erro ao atualizar informações! " + ex.Message)
                fechar()
            End Try
        Else
            MessageBox.Show(MessageBoxOptions.ServiceNotification, "Favor preencher todos os campos!!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
            fechar()
        End If
        DesabilitarCampos()
        txtBuscar.Focus()
        btnEditar.Enabled = False
        btnExcluir.Enabled = False
        Listar()
        btnNovo.Enabled = True
        CriarCodigoBarras()
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim cmd As SqlCommand

        If txtDescricao.Text <> "" Then
            Try
                abrir()
                cmd = New SqlCommand("sp_ExcluirProd", connect)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@codigobarras", txtCodigoBarras.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                Dim result As DialogResult = MessageBox.Show("Tem certeza de que quer excluir o registro?", "Validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                Select Case result
                    Case Windows.Forms.DialogResult.Yes
                        cmd.ExecuteNonQuery()
                        Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                        MessageBox.Show(msg, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        Listar()
                        LimparCampos()
                        btnGravar.Enabled = False
                        btnExcluir.Enabled = False
                        btnEditar.Enabled = False
                        btnNovo.Enabled = True
                        Listar()
                        fechar()
                    Case Windows.Forms.DialogResult.No
                        HabilitarCampos()
                        LimparCampos()
                        btnNovo.Enabled = False
                        btnGravar.Enabled = True
                        txtCodigoBarras.Focus()
                End Select

            Catch ex As Exception
                MessageBox.Show("Erro ao atualizar banco de dados! " + ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Private Sub txtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
            txtDescricao.Focus()
        End If

        If e.KeyChar = ChrW(Keys.Escape) Then
            LimparCampos()
            DesabilitarCampos()
            btnNovo.Enabled = True
            btnGravar.Enabled = False
            btnEditar.Enabled = False
            btnExcluir.Enabled = False
            txtCodigoBarras.Text = ""
            txtCodigoBarras.Focus()
            btnImage.Enabled = False
        End If
    End Sub

    Private Sub dgvProdutos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProdutos.CellClick
        HabilitarCampos()
        txtCodigoBarras.Focus()
        CarregarFornecedores()
        btnEditar.Enabled = True
        btnExcluir.Enabled = True
        btnNovo.Enabled = False
        btnImage.Enabled = True

        txtCodigoBarras.Text = dgvProdutos.CurrentRow.Cells(9).Value
        txtCodigoBarras.Text = txtCodigoBarras.Text.PadLeft(13, "0")
        txtDescricao.Text = dgvProdutos.CurrentRow.Cells(0).Value
        cmbFornecedores.Text = dgvProdutos.CurrentRow.Cells(1).Value
        cmbUnidade.Text = dgvProdutos.CurrentRow.Cells(2).Value
        txtQuantidade.Text = dgvProdutos.CurrentRow.Cells(3).Value
        txtValor.Text = dgvProdutos.CurrentRow.Cells(4).Value
        txtMinimo.Text = dgvProdutos.CurrentRow.Cells(5).Value

        Dim tempImagem As Byte() = DirectCast(dgvProdutos.CurrentRow.Cells(6).Value, Byte())
        If tempImagem Is Nothing Then
            MessageBox.Show("Imagem não localizada", "Erro")
            Exit Sub
        End If
        Dim strArquivo As String = Convert.ToString(DateTime.Now.ToFileTime())
        Dim fs As New FileStream(strArquivo, FileMode.CreateNew, FileAccess.Write)
        fs.Write(tempImagem, 0, tempImagem.Length)
        fs.Flush()
        fs.Close()
        ImagemCarregada = Image.FromFile(strArquivo)
        pcbProdutos.Image = ImagemCarregada

        CriarCodigoBarras()
        txtBuscar.Text = ""

    End Sub

    Private Sub txtCodigo_LostFocus(sender As Object, e As EventArgs)
        txtCodigoBarras.Text = txtCodigoBarras.Text.PadLeft(13, "0")
    End Sub

    Private Sub txtValor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValor.KeyPress
        Select Case (txtValor.TextLength)
            Case 4
                txtValor.SelectionStart = 5
        End Select
        If e.KeyChar = ChrW(Keys.Enter) Then
            txtMinimo.Focus()
        End If
    End Sub

    Private Sub cmbUnidade_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbUnidade.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txtQuantidade.Focus()
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

        If txtBuscar.Text = "" Then
            Listar()
        Else

            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()
                da = New SqlDataAdapter("sp_BuscarProdDesc", connect)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@descricao", txtBuscar.Text)
                da.SelectCommand.Parameters.AddWithValue("@codigobarras", txtBuscar.Text)
                da.Fill(dt)

                dgvProdutos.DataSource = dt

                ContarLinhas()

            Catch ex As Exception
                MessageBox.Show("Algo saiu errado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnImage_Click(sender As Object, e As EventArgs) Handles btnImage.Click
        Using OFD As New OpenFileDialog With {.Filter = "Image File(*.jpg; *.bmp; *.png)|*.jpg; *.bmp; *.png"}
            If OFD.ShowDialog = DialogResult.OK Then
                ImagemCarregada = Image.FromFile(OFD.FileName)
                pcbProdutos.Image = ImagemCarregada
            End If
        End Using
    End Sub

    Sub CarregarImagem()
        pcbProdutos.Image = My.Resources.sem_foto
    End Sub

    Private Sub txtValor_GotFocus(sender As Object, e As EventArgs) Handles txtValor.GotFocus
        With txtValor
            .SelectionStart = 0
            .SelectionLength = Len(.Text)
        End With
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("pt-BR")
        txtValor.Text = String.Format("{0:C}", Convert.ToDouble(txtValor.Text))
    End Sub

    Private Sub CarregarFornecedores()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("SELECT * FROM fornecedores", connect)
            da.Fill(dt)
            cmbFornecedores.DisplayMember = "nome_for"
            cmbFornecedores.ValueMember = "id_fornecedor"
            cmbFornecedores.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        fechar()
    End Sub

    Private Sub cmbFornecedores_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbFornecedores.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            cmbUnidade.Focus()
        End If
    End Sub

    Public Shared Sub Moeda(ByRef txt As TextBox)
        Dim n As String = String.Empty
        Dim v As Double = 0

        Try

            n = txt.Text.Replace(",", "").Replace(".", "")
            If n.Equals("") Then n = ""
            n = n.PadLeft(3, "0")
            If n.Length > 3 And n.Substring(0, 1) = "0" Then n.Substring(1, n.Length - 1)
            v = Convert.ToDouble(n) / 100
            txt.Text = String.Format("{0:N}", v)
            txt.SelectionStart = txt.Text.Length

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtValor_TextChanged(sender As Object, e As EventArgs) Handles txtValor.TextChanged

        Produtos.Moeda(txtValor)

    End Sub

    Sub CriarCodigoBarras()
        Dim CodBarras As New Barcode128
        With CodBarras
            .BarHeight = 50
            .Code = txtCodigoBarras.Text
            .GenerateChecksum = True
            .CodeType = Barcode.CODE128

            Try
                Dim bmp As New Bitmap(.CreateDrawingImage(Color.Black, Color.White))
                Dim img As Image
                img = New Bitmap(bmp.Width, bmp.Height)
                Dim graph As Graphics = Graphics.FromImage(img)
                graph.FillRectangle(New SolidBrush(Color.White), 0, 0, bmp.Width, bmp.Height)
                graph.DrawImage(bmp, 0, 0)
                pcbCodBarras.Image = img
            Catch ex As Exception
                MsgBox("Erro!" + ex.Message)
            End Try
        End With
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bmp As New Bitmap(pcbCodBarras.Width, pcbCodBarras.Height)
        pcbCodBarras.DrawToBitmap(bmp, New Rectangle(0, 0, bmp.Width, bmp.Height))
        e.Graphics.DrawImage(bmp, 0, 0)
    End Sub

    Private Sub txtCodigoBarras_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigoBarras.KeyPress
        If e.KeyChar = ChrW(Keys.Escape) Then
            DesabilitarCampos()
            btnNovo.Enabled = True
            btnGravar.Enabled = False
            btnEditar.Enabled = False
            btnExcluir.Enabled = False
            txtCodigoBarras.Text = ""
            txtCodigoBarras.Focus()
        End If
    End Sub

End Class