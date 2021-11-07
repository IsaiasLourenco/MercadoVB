<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Produtos
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Produtos))
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.lblFornecedor = New System.Windows.Forms.Label()
        Me.lblQtdeTotal = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.dgvProdutos = New System.Windows.Forms.DataGridView()
        Me.txtMinimo = New System.Windows.Forms.TextBox()
        Me.lblMinimo = New System.Windows.Forms.Label()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.lblUnidade = New System.Windows.Forms.Label()
        Me.cmbUnidade = New System.Windows.Forms.ComboBox()
        Me.btnImage = New System.Windows.Forms.Button()
        Me.cmbFornecedores = New System.Windows.Forms.ComboBox()
        Me.pcbProdutos = New System.Windows.Forms.PictureBox()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGravar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.txtCodigoBarras = New System.Windows.Forms.TextBox()
        Me.pcbCodBarras = New System.Windows.Forms.PictureBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbCodBarras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Location = New System.Drawing.Point(106, 143)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(132, 20)
        Me.txtQuantidade.TabIndex = 5
        Me.txtQuantidade.Text = "0"
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.Location = New System.Drawing.Point(10, 145)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(65, 13)
        Me.lblQuantidade.TabIndex = 107
        Me.lblQuantidade.Text = "Quantidade:"
        '
        'lblFornecedor
        '
        Me.lblFornecedor.AutoSize = True
        Me.lblFornecedor.Location = New System.Drawing.Point(8, 110)
        Me.lblFornecedor.Name = "lblFornecedor"
        Me.lblFornecedor.Size = New System.Drawing.Size(64, 13)
        Me.lblFornecedor.TabIndex = 105
        Me.lblFornecedor.Text = "Fornecedor:"
        '
        'lblQtdeTotal
        '
        Me.lblQtdeTotal.AutoSize = True
        Me.lblQtdeTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQtdeTotal.Location = New System.Drawing.Point(915, 384)
        Me.lblQtdeTotal.Name = "lblQtdeTotal"
        Me.lblQtdeTotal.Size = New System.Drawing.Size(11, 13)
        Me.lblQtdeTotal.TabIndex = 95
        Me.lblQtdeTotal.Text = "-"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(838, 384)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(40, 13)
        Me.lblTotal.TabIndex = 94
        Me.lblTotal.Text = "Total:"
        '
        'dgvProdutos
        '
        Me.dgvProdutos.AllowUserToAddRows = False
        Me.dgvProdutos.AllowUserToDeleteRows = False
        Me.dgvProdutos.AllowUserToResizeColumns = False
        Me.dgvProdutos.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvProdutos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvProdutos.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProdutos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProdutos.Location = New System.Drawing.Point(14, 173)
        Me.dgvProdutos.Name = "dgvProdutos"
        Me.dgvProdutos.ReadOnly = True
        Me.dgvProdutos.RowHeadersVisible = False
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvProdutos.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProdutos.Size = New System.Drawing.Size(973, 208)
        Me.dgvProdutos.TabIndex = 87
        '
        'txtMinimo
        '
        Me.txtMinimo.Location = New System.Drawing.Point(649, 143)
        Me.txtMinimo.Name = "txtMinimo"
        Me.txtMinimo.Size = New System.Drawing.Size(135, 20)
        Me.txtMinimo.TabIndex = 7
        Me.txtMinimo.Text = "0"
        '
        'lblMinimo
        '
        Me.lblMinimo.AutoSize = True
        Me.lblMinimo.Location = New System.Drawing.Point(558, 146)
        Me.lblMinimo.Name = "lblMinimo"
        Me.lblMinimo.Size = New System.Drawing.Size(87, 13)
        Me.lblMinimo.TabIndex = 86
        Me.lblMinimo.Text = "Estoque Mínimo:"
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(248, 146)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(73, 13)
        Me.lblValor.TabIndex = 85
        Me.lblValor.Text = "Valor Unitário:"
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(455, 72)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(329, 20)
        Me.txtDescricao.TabIndex = 2
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(391, 75)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(58, 13)
        Me.lblDescricao.TabIndex = 74
        Me.lblDescricao.Text = "Descrição:"
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(772, 13)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(43, 13)
        Me.lblBuscar.TabIndex = 71
        Me.lblBuscar.Text = "Buscar:"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(7, 74)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(91, 13)
        Me.lblCodigo.TabIndex = 109
        Me.lblCodigo.Text = "Código de Barras:"
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(328, 142)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(183, 20)
        Me.txtValor.TabIndex = 6
        '
        'lblUnidade
        '
        Me.lblUnidade.AutoSize = True
        Me.lblUnidade.Location = New System.Drawing.Point(519, 108)
        Me.lblUnidade.Name = "lblUnidade"
        Me.lblUnidade.Size = New System.Drawing.Size(50, 13)
        Me.lblUnidade.TabIndex = 111
        Me.lblUnidade.Text = "Unidade:"
        '
        'cmbUnidade
        '
        Me.cmbUnidade.FormattingEnabled = True
        Me.cmbUnidade.Items.AddRange(New Object() {"Kilo", "Pacote", "Gramo", "Lata", "Litro", "Garrafa", "Item", "Unidade"})
        Me.cmbUnidade.Location = New System.Drawing.Point(575, 105)
        Me.cmbUnidade.Name = "cmbUnidade"
        Me.cmbUnidade.Size = New System.Drawing.Size(209, 21)
        Me.cmbUnidade.TabIndex = 4
        '
        'btnImage
        '
        Me.btnImage.Enabled = False
        Me.btnImage.Location = New System.Drawing.Point(948, 90)
        Me.btnImage.Name = "btnImage"
        Me.btnImage.Size = New System.Drawing.Size(24, 23)
        Me.btnImage.TabIndex = 114
        Me.btnImage.Text = "+"
        Me.btnImage.UseVisualStyleBackColor = True
        '
        'cmbFornecedores
        '
        Me.cmbFornecedores.FormattingEnabled = True
        Me.cmbFornecedores.Location = New System.Drawing.Point(106, 108)
        Me.cmbFornecedores.Name = "cmbFornecedores"
        Me.cmbFornecedores.Size = New System.Drawing.Size(405, 21)
        Me.cmbFornecedores.TabIndex = 3
        '
        'pcbProdutos
        '
        Me.pcbProdutos.ErrorImage = CType(resources.GetObject("pcbProdutos.ErrorImage"), System.Drawing.Image)
        Me.pcbProdutos.Location = New System.Drawing.Point(822, 42)
        Me.pcbProdutos.Name = "pcbProdutos"
        Me.pcbProdutos.Size = New System.Drawing.Size(120, 120)
        Me.pcbProdutos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbProdutos.TabIndex = 113
        Me.pcbProdutos.TabStop = False
        '
        'btnEditar
        '
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.Enabled = False
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.Location = New System.Drawing.Point(609, 405)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(121, 100)
        Me.btnEditar.TabIndex = 90
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnGravar
        '
        Me.btnGravar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGravar.Enabled = False
        Me.btnGravar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGravar.Image = CType(resources.GetObject("btnGravar.Image"), System.Drawing.Image)
        Me.btnGravar.Location = New System.Drawing.Point(312, 405)
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(121, 100)
        Me.btnGravar.TabIndex = 8
        Me.btnGravar.Text = "Gravar"
        Me.btnGravar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGravar.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovo.Image = CType(resources.GetObject("btnNovo.Image"), System.Drawing.Image)
        Me.btnNovo.Location = New System.Drawing.Point(14, 405)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(121, 100)
        Me.btnNovo.TabIndex = 6
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluir.Enabled = False
        Me.btnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.Location = New System.Drawing.Point(862, 405)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(125, 100)
        Me.btnExcluir.TabIndex = 88
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(822, 12)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(164, 20)
        Me.txtBuscar.TabIndex = 400
        '
        'txtCodigoBarras
        '
        Me.txtCodigoBarras.Location = New System.Drawing.Point(104, 72)
        Me.txtCodigoBarras.Name = "txtCodigoBarras"
        Me.txtCodigoBarras.Size = New System.Drawing.Size(281, 20)
        Me.txtCodigoBarras.TabIndex = 0
        '
        'pcbCodBarras
        '
        Me.pcbCodBarras.Location = New System.Drawing.Point(106, 13)
        Me.pcbCodBarras.Name = "pcbCodBarras"
        Me.pcbCodBarras.Size = New System.Drawing.Size(93, 53)
        Me.pcbCodBarras.TabIndex = 117
        Me.pcbCodBarras.TabStop = False
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Produtos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(993, 519)
        Me.Controls.Add(Me.pcbCodBarras)
        Me.Controls.Add(Me.txtCodigoBarras)
        Me.Controls.Add(Me.cmbFornecedores)
        Me.Controls.Add(Me.btnImage)
        Me.Controls.Add(Me.pcbProdutos)
        Me.Controls.Add(Me.cmbUnidade)
        Me.Controls.Add(Me.lblUnidade)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.txtQuantidade)
        Me.Controls.Add(Me.lblQuantidade)
        Me.Controls.Add(Me.lblFornecedor)
        Me.Controls.Add(Me.lblQtdeTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnGravar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.dgvProdutos)
        Me.Controls.Add(Me.txtMinimo)
        Me.Controls.Add(Me.lblMinimo)
        Me.Controls.Add(Me.lblValor)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.lblDescricao)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.lblBuscar)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Produtos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Produtos"
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbCodBarras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtQuantidade As TextBox
    Friend WithEvents lblQuantidade As Label
    Friend WithEvents lblFornecedor As Label
    Friend WithEvents lblQtdeTotal As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnGravar As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents dgvProdutos As DataGridView
    Friend WithEvents txtMinimo As TextBox
    Friend WithEvents lblMinimo As Label
    Friend WithEvents lblValor As Label
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents lblDescricao As Label
    Friend WithEvents lblBuscar As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents txtValor As TextBox
    Friend WithEvents lblUnidade As Label
    Friend WithEvents cmbUnidade As ComboBox
    Friend WithEvents pcbProdutos As PictureBox
    Friend WithEvents btnImage As Button
    Friend WithEvents cmbFornecedores As ComboBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents txtCodigoBarras As TextBox
    Friend WithEvents pcbCodBarras As PictureBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
