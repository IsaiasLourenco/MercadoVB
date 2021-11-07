<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Vendas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vendas))
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.dgvVendas = New System.Windows.Forms.DataGridView()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.cmbProduto = New System.Windows.Forms.ComboBox()
        Me.txtEstoque = New System.Windows.Forms.TextBox()
        Me.pcbProdutos = New System.Windows.Forms.PictureBox()
        Me.txtQtddeVendida = New System.Windows.Forms.TextBox()
        Me.txtCodBarras = New System.Windows.Forms.TextBox()
        Me.txtVenda = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtDesconto = New System.Windows.Forms.TextBox()
        Me.txtValorRecebido = New System.Windows.Forms.TextBox()
        Me.cmbFuncionario = New System.Windows.Forms.ComboBox()
        Me.cmbFornecedor = New System.Windows.Forms.ComboBox()
        Me.txtTotalCompra = New System.Windows.Forms.TextBox()
        Me.lblTroco = New System.Windows.Forms.Label()
        Me.lblRealTotal = New System.Windows.Forms.Label()
        Me.lblRealDesconto = New System.Windows.Forms.Label()
        Me.lblRealTotalCompra = New System.Windows.Forms.Label()
        Me.lblRealValorRecebido = New System.Windows.Forms.Label()
        Me.lblRealTroco = New System.Windows.Forms.Label()
        Me.gbxInformacoes = New System.Windows.Forms.GroupBox()
        Me.lblF6 = New System.Windows.Forms.Label()
        Me.lblF5 = New System.Windows.Forms.Label()
        Me.lblF4 = New System.Windows.Forms.Label()
        Me.lblF3 = New System.Windows.Forms.Label()
        Me.lblF2 = New System.Windows.Forms.Label()
        Me.lblF1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CaixaVBDataSet1 = New MercadoVB.CaixaVBDataSet()
        CType(Me.dgvVendas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxInformacoes.SuspendLayout()
        CType(Me.CaixaVBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbCliente
        '
        Me.cmbCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(446, 249)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(463, 39)
        Me.cmbCliente.TabIndex = 3
        '
        'txtValor
        '
        Me.txtValor.BackColor = System.Drawing.SystemColors.Window
        Me.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.Location = New System.Drawing.Point(457, 416)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.ReadOnly = True
        Me.txtValor.Size = New System.Drawing.Size(163, 31)
        Me.txtValor.TabIndex = 5
        '
        'txtQuantidade
        '
        Me.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtQuantidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantidade.Location = New System.Drawing.Point(457, 342)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(163, 31)
        Me.txtQuantidade.TabIndex = 4
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal.Location = New System.Drawing.Point(922, 154)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(0, 46)
        Me.lblSubTotal.TabIndex = 130
        '
        'dgvVendas
        '
        Me.dgvVendas.AllowUserToAddRows = False
        Me.dgvVendas.AllowUserToDeleteRows = False
        Me.dgvVendas.AllowUserToResizeColumns = False
        Me.dgvVendas.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvVendas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvVendas.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVendas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVendas.Location = New System.Drawing.Point(12, 58)
        Me.dgvVendas.Name = "dgvVendas"
        Me.dgvVendas.ReadOnly = True
        Me.dgvVendas.RowHeadersVisible = False
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvVendas.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVendas.Size = New System.Drawing.Size(413, 340)
        Me.dgvVendas.TabIndex = 125
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(280, 149)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(34, 13)
        Me.lblValor.TabIndex = 123
        Me.lblValor.Text = "Valor:"
        '
        'cmbProduto
        '
        Me.cmbProduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProduto.FormattingEnabled = True
        Me.cmbProduto.Location = New System.Drawing.Point(445, 169)
        Me.cmbProduto.Name = "cmbProduto"
        Me.cmbProduto.Size = New System.Drawing.Size(465, 37)
        Me.cmbProduto.TabIndex = 1
        '
        'txtEstoque
        '
        Me.txtEstoque.BackColor = System.Drawing.SystemColors.Window
        Me.txtEstoque.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEstoque.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstoque.Location = New System.Drawing.Point(457, 498)
        Me.txtEstoque.Name = "txtEstoque"
        Me.txtEstoque.ReadOnly = True
        Me.txtEstoque.Size = New System.Drawing.Size(163, 31)
        Me.txtEstoque.TabIndex = 139
        '
        'pcbProdutos
        '
        Me.pcbProdutos.ErrorImage = CType(resources.GetObject("pcbProdutos.ErrorImage"), System.Drawing.Image)
        Me.pcbProdutos.Location = New System.Drawing.Point(690, 297)
        Me.pcbProdutos.Name = "pcbProdutos"
        Me.pcbProdutos.Size = New System.Drawing.Size(190, 190)
        Me.pcbProdutos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbProdutos.TabIndex = 141
        Me.pcbProdutos.TabStop = False
        '
        'txtQtddeVendida
        '
        Me.txtQtddeVendida.Enabled = False
        Me.txtQtddeVendida.Location = New System.Drawing.Point(207, 1)
        Me.txtQtddeVendida.Name = "txtQtddeVendida"
        Me.txtQtddeVendida.ReadOnly = True
        Me.txtQtddeVendida.Size = New System.Drawing.Size(72, 20)
        Me.txtQtddeVendida.TabIndex = 148
        Me.txtQtddeVendida.Visible = False
        '
        'txtCodBarras
        '
        Me.txtCodBarras.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodBarras.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodBarras.Location = New System.Drawing.Point(456, 74)
        Me.txtCodBarras.Name = "txtCodBarras"
        Me.txtCodBarras.Size = New System.Drawing.Size(453, 38)
        Me.txtCodBarras.TabIndex = 0
        '
        'txtVenda
        '
        Me.txtVenda.Enabled = False
        Me.txtVenda.Location = New System.Drawing.Point(87, 1)
        Me.txtVenda.Name = "txtVenda"
        Me.txtVenda.ReadOnly = True
        Me.txtVenda.Size = New System.Drawing.Size(72, 20)
        Me.txtVenda.TabIndex = 150
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(995, 66)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(174, 46)
        Me.txtTotal.TabIndex = 151
        '
        'txtDesconto
        '
        Me.txtDesconto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDesconto.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesconto.Location = New System.Drawing.Point(997, 242)
        Me.txtDesconto.Name = "txtDesconto"
        Me.txtDesconto.Size = New System.Drawing.Size(138, 46)
        Me.txtDesconto.TabIndex = 1
        '
        'txtValorRecebido
        '
        Me.txtValorRecebido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtValorRecebido.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorRecebido.Location = New System.Drawing.Point(994, 429)
        Me.txtValorRecebido.Name = "txtValorRecebido"
        Me.txtValorRecebido.Size = New System.Drawing.Size(138, 46)
        Me.txtValorRecebido.TabIndex = 2
        '
        'cmbFuncionario
        '
        Me.cmbFuncionario.FormattingEnabled = True
        Me.cmbFuncionario.Location = New System.Drawing.Point(300, 1)
        Me.cmbFuncionario.Name = "cmbFuncionario"
        Me.cmbFuncionario.Size = New System.Drawing.Size(67, 21)
        Me.cmbFuncionario.TabIndex = 144
        Me.cmbFuncionario.Visible = False
        '
        'cmbFornecedor
        '
        Me.cmbFornecedor.Enabled = False
        Me.cmbFornecedor.FormattingEnabled = True
        Me.cmbFornecedor.Location = New System.Drawing.Point(576, 605)
        Me.cmbFornecedor.Name = "cmbFornecedor"
        Me.cmbFornecedor.Size = New System.Drawing.Size(290, 21)
        Me.cmbFornecedor.TabIndex = 147
        Me.cmbFornecedor.Visible = False
        '
        'txtTotalCompra
        '
        Me.txtTotalCompra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotalCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCompra.Location = New System.Drawing.Point(996, 336)
        Me.txtTotalCompra.Name = "txtTotalCompra"
        Me.txtTotalCompra.Size = New System.Drawing.Size(138, 46)
        Me.txtTotalCompra.TabIndex = 156
        '
        'lblTroco
        '
        Me.lblTroco.AutoSize = True
        Me.lblTroco.BackColor = System.Drawing.Color.Transparent
        Me.lblTroco.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTroco.ForeColor = System.Drawing.Color.Red
        Me.lblTroco.Location = New System.Drawing.Point(995, 535)
        Me.lblTroco.Name = "lblTroco"
        Me.lblTroco.Size = New System.Drawing.Size(0, 46)
        Me.lblTroco.TabIndex = 157
        '
        'lblRealTotal
        '
        Me.lblRealTotal.AutoSize = True
        Me.lblRealTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblRealTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRealTotal.Location = New System.Drawing.Point(924, 66)
        Me.lblRealTotal.Name = "lblRealTotal"
        Me.lblRealTotal.Size = New System.Drawing.Size(71, 46)
        Me.lblRealTotal.TabIndex = 159
        Me.lblRealTotal.Text = "R$"
        '
        'lblRealDesconto
        '
        Me.lblRealDesconto.AutoSize = True
        Me.lblRealDesconto.BackColor = System.Drawing.Color.Transparent
        Me.lblRealDesconto.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRealDesconto.Location = New System.Drawing.Point(924, 242)
        Me.lblRealDesconto.Name = "lblRealDesconto"
        Me.lblRealDesconto.Size = New System.Drawing.Size(71, 46)
        Me.lblRealDesconto.TabIndex = 160
        Me.lblRealDesconto.Text = "R$"
        '
        'lblRealTotalCompra
        '
        Me.lblRealTotalCompra.AutoSize = True
        Me.lblRealTotalCompra.BackColor = System.Drawing.Color.Transparent
        Me.lblRealTotalCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRealTotalCompra.Location = New System.Drawing.Point(924, 336)
        Me.lblRealTotalCompra.Name = "lblRealTotalCompra"
        Me.lblRealTotalCompra.Size = New System.Drawing.Size(71, 46)
        Me.lblRealTotalCompra.TabIndex = 161
        Me.lblRealTotalCompra.Text = "R$"
        '
        'lblRealValorRecebido
        '
        Me.lblRealValorRecebido.AutoSize = True
        Me.lblRealValorRecebido.BackColor = System.Drawing.Color.Transparent
        Me.lblRealValorRecebido.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRealValorRecebido.Location = New System.Drawing.Point(922, 431)
        Me.lblRealValorRecebido.Name = "lblRealValorRecebido"
        Me.lblRealValorRecebido.Size = New System.Drawing.Size(71, 46)
        Me.lblRealValorRecebido.TabIndex = 162
        Me.lblRealValorRecebido.Text = "R$"
        '
        'lblRealTroco
        '
        Me.lblRealTroco.AutoSize = True
        Me.lblRealTroco.BackColor = System.Drawing.Color.Transparent
        Me.lblRealTroco.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRealTroco.ForeColor = System.Drawing.Color.Red
        Me.lblRealTroco.Location = New System.Drawing.Point(926, 537)
        Me.lblRealTroco.Name = "lblRealTroco"
        Me.lblRealTroco.Size = New System.Drawing.Size(71, 46)
        Me.lblRealTroco.TabIndex = 163
        Me.lblRealTroco.Text = "R$"
        '
        'gbxInformacoes
        '
        Me.gbxInformacoes.Controls.Add(Me.lblF6)
        Me.gbxInformacoes.Controls.Add(Me.lblF5)
        Me.gbxInformacoes.Controls.Add(Me.lblF4)
        Me.gbxInformacoes.Controls.Add(Me.lblF3)
        Me.gbxInformacoes.Controls.Add(Me.lblF2)
        Me.gbxInformacoes.Controls.Add(Me.lblF1)
        Me.gbxInformacoes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxInformacoes.Location = New System.Drawing.Point(13, 416)
        Me.gbxInformacoes.Name = "gbxInformacoes"
        Me.gbxInformacoes.Size = New System.Drawing.Size(412, 143)
        Me.gbxInformacoes.TabIndex = 164
        Me.gbxInformacoes.TabStop = False
        Me.gbxInformacoes.Text = "Informações:"
        '
        'lblF6
        '
        Me.lblF6.AutoSize = True
        Me.lblF6.Location = New System.Drawing.Point(12, 124)
        Me.lblF6.Name = "lblF6"
        Me.lblF6.Size = New System.Drawing.Size(212, 13)
        Me.lblF6.TabIndex = 5
        Me.lblF6.Text = "F7 - Imprimir Comprovante de Venda"
        '
        'lblF5
        '
        Me.lblF5.AutoSize = True
        Me.lblF5.Location = New System.Drawing.Point(11, 106)
        Me.lblF5.Name = "lblF5"
        Me.lblF5.Size = New System.Drawing.Size(111, 13)
        Me.lblF5.TabIndex = 4
        Me.lblF5.Text = "F6 - Excluir Venda"
        '
        'lblF4
        '
        Me.lblF4.AutoSize = True
        Me.lblF4.Location = New System.Drawing.Point(12, 86)
        Me.lblF4.Name = "lblF4"
        Me.lblF4.Size = New System.Drawing.Size(111, 13)
        Me.lblF4.TabIndex = 3
        Me.lblF4.Text = "F5 - Gravar Venda"
        '
        'lblF3
        '
        Me.lblF3.AutoSize = True
        Me.lblF3.Location = New System.Drawing.Point(12, 67)
        Me.lblF3.Name = "lblF3"
        Me.lblF3.Size = New System.Drawing.Size(103, 13)
        Me.lblF3.TabIndex = 2
        Me.lblF3.Text = "F4 - Nova Venda"
        '
        'lblF2
        '
        Me.lblF2.AutoSize = True
        Me.lblF2.Location = New System.Drawing.Point(12, 48)
        Me.lblF2.Name = "lblF2"
        Me.lblF2.Size = New System.Drawing.Size(217, 13)
        Me.lblF2.TabIndex = 1
        Me.lblF2.Text = "F3 - Adiciona Novo Código de Barras"
        '
        'lblF1
        '
        Me.lblF1.AutoSize = True
        Me.lblF1.Location = New System.Drawing.Point(12, 32)
        Me.lblF1.Name = "lblF1"
        Me.lblF1.Size = New System.Drawing.Size(131, 13)
        Me.lblF1.TabIndex = 0
        Me.lblF1.Text = "F2 - Limpa os Campos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(921, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 26)
        Me.Label1.TabIndex = 165
        Me.Label1.Text = "SUB TOTAL DO DIA"
        '
        'CaixaVBDataSet1
        '
        Me.CaixaVBDataSet1.DataSetName = "CaixaVBDataSet"
        Me.CaixaVBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1191, 610)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gbxInformacoes)
        Me.Controls.Add(Me.lblRealTroco)
        Me.Controls.Add(Me.lblRealValorRecebido)
        Me.Controls.Add(Me.lblRealTotalCompra)
        Me.Controls.Add(Me.lblRealDesconto)
        Me.Controls.Add(Me.lblRealTotal)
        Me.Controls.Add(Me.lblTroco)
        Me.Controls.Add(Me.txtTotalCompra)
        Me.Controls.Add(Me.txtValorRecebido)
        Me.Controls.Add(Me.txtDesconto)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtVenda)
        Me.Controls.Add(Me.txtCodBarras)
        Me.Controls.Add(Me.txtQtddeVendida)
        Me.Controls.Add(Me.cmbFornecedor)
        Me.Controls.Add(Me.cmbFuncionario)
        Me.Controls.Add(Me.pcbProdutos)
        Me.Controls.Add(Me.txtEstoque)
        Me.Controls.Add(Me.cmbProduto)
        Me.Controls.Add(Me.cmbCliente)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.txtQuantidade)
        Me.Controls.Add(Me.lblSubTotal)
        Me.Controls.Add(Me.dgvVendas)
        Me.Controls.Add(Me.lblValor)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Vendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vendas"
        CType(Me.dgvVendas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxInformacoes.ResumeLayout(False)
        Me.gbxInformacoes.PerformLayout()
        CType(Me.CaixaVBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbCliente As ComboBox
    Friend WithEvents txtValor As TextBox
    Friend WithEvents txtQuantidade As TextBox
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents dgvVendas As DataGridView
    Friend WithEvents lblValor As Label
    Friend WithEvents cmbProduto As ComboBox
    Friend WithEvents txtEstoque As TextBox
    Friend WithEvents pcbProdutos As PictureBox
    Friend WithEvents txtQtddeVendida As TextBox
    Friend WithEvents txtCodBarras As TextBox
    Friend WithEvents txtVenda As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtDesconto As TextBox
    Friend WithEvents txtValorRecebido As TextBox
    Friend WithEvents cmbFuncionario As ComboBox
    Friend WithEvents cmbFornecedor As ComboBox
    Friend WithEvents txtTotalCompra As TextBox
    Friend WithEvents lblTroco As Label
    Friend WithEvents lblRealTotal As Label
    Friend WithEvents lblRealDesconto As Label
    Friend WithEvents lblRealTotalCompra As Label
    Friend WithEvents lblRealValorRecebido As Label
    Friend WithEvents lblRealTroco As Label
    Friend WithEvents gbxInformacoes As GroupBox
    Friend WithEvents lblF6 As Label
    Friend WithEvents lblF5 As Label
    Friend WithEvents lblF4 As Label
    Friend WithEvents lblF3 As Label
    Friend WithEvents lblF2 As Label
    Friend WithEvents lblF1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CaixaVBDataSet1 As CaixaVBDataSet
End Class
