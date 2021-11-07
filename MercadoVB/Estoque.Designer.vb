<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Estoque
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Estoque))
        Me.dgvEstoque = New System.Windows.Forms.DataGridView()
        Me.btnGravar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.cmbMotivo = New System.Windows.Forms.ComboBox()
        Me.lblMotivo = New System.Windows.Forms.Label()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.lblFornecedor = New System.Windows.Forms.Label()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.lblProduto = New System.Windows.Forms.Label()
        Me.cmbProduto = New System.Windows.Forms.ComboBox()
        Me.cmbFornecedores = New System.Windows.Forms.ComboBox()
        Me.cmbDescricao = New System.Windows.Forms.ComboBox()
        Me.lblEstoque = New System.Windows.Forms.Label()
        Me.txtEstoque = New System.Windows.Forms.TextBox()
        Me.pcbProdutos = New System.Windows.Forms.PictureBox()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.txtQtddeVendida = New System.Windows.Forms.TextBox()
        CType(Me.dgvEstoque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvEstoque
        '
        Me.dgvEstoque.AllowUserToAddRows = False
        Me.dgvEstoque.AllowUserToDeleteRows = False
        Me.dgvEstoque.AllowUserToResizeColumns = False
        Me.dgvEstoque.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvEstoque.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvEstoque.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEstoque.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEstoque.Location = New System.Drawing.Point(33, 159)
        Me.dgvEstoque.Name = "dgvEstoque"
        Me.dgvEstoque.ReadOnly = True
        Me.dgvEstoque.RowHeadersVisible = False
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvEstoque.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEstoque.Size = New System.Drawing.Size(863, 208)
        Me.dgvEstoque.TabIndex = 127
        '
        'btnGravar
        '
        Me.btnGravar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGravar.Enabled = False
        Me.btnGravar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGravar.Image = CType(resources.GetObject("btnGravar.Image"), System.Drawing.Image)
        Me.btnGravar.Location = New System.Drawing.Point(425, 373)
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(121, 100)
        Me.btnGravar.TabIndex = 129
        Me.btnGravar.Text = "Gravar"
        Me.btnGravar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGravar.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovo.Image = CType(resources.GetObject("btnNovo.Image"), System.Drawing.Image)
        Me.btnNovo.Location = New System.Drawing.Point(33, 373)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(121, 100)
        Me.btnNovo.TabIndex = 121
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
        Me.btnExcluir.Location = New System.Drawing.Point(771, 373)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(125, 100)
        Me.btnExcluir.TabIndex = 128
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'cmbMotivo
        '
        Me.cmbMotivo.FormattingEnabled = True
        Me.cmbMotivo.Items.AddRange(New Object() {"Troca", "Desperdício", "Data Validade", "Compra", "Erros de Entrega", "Devolução/Cancelamento"})
        Me.cmbMotivo.Location = New System.Drawing.Point(151, 132)
        Me.cmbMotivo.Name = "cmbMotivo"
        Me.cmbMotivo.Size = New System.Drawing.Size(211, 21)
        Me.cmbMotivo.TabIndex = 148
        '
        'lblMotivo
        '
        Me.lblMotivo.AutoSize = True
        Me.lblMotivo.Location = New System.Drawing.Point(86, 136)
        Me.lblMotivo.Name = "lblMotivo"
        Me.lblMotivo.Size = New System.Drawing.Size(42, 13)
        Me.lblMotivo.TabIndex = 147
        Me.lblMotivo.Text = "Motivo:"
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(629, 5)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(43, 13)
        Me.lblBuscar.TabIndex = 122
        Me.lblBuscar.Text = "Buscar:"
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(86, 71)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(58, 13)
        Me.lblDescricao.TabIndex = 124
        Me.lblDescricao.Text = "Descrição:"
        '
        'lblFornecedor
        '
        Me.lblFornecedor.AutoSize = True
        Me.lblFornecedor.Location = New System.Drawing.Point(83, 102)
        Me.lblFornecedor.Name = "lblFornecedor"
        Me.lblFornecedor.Size = New System.Drawing.Size(64, 13)
        Me.lblFornecedor.TabIndex = 133
        Me.lblFornecedor.Text = "Fornecedor:"
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.Location = New System.Drawing.Point(377, 70)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(65, 13)
        Me.lblQuantidade.TabIndex = 134
        Me.lblQuantidade.Text = "Quantidade:"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Location = New System.Drawing.Point(453, 68)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(93, 20)
        Me.txtQuantidade.TabIndex = 118
        '
        'lblProduto
        '
        Me.lblProduto.AutoSize = True
        Me.lblProduto.Location = New System.Drawing.Point(95, 37)
        Me.lblProduto.Name = "lblProduto"
        Me.lblProduto.Size = New System.Drawing.Size(47, 13)
        Me.lblProduto.TabIndex = 136
        Me.lblProduto.Text = "Produto:"
        '
        'cmbProduto
        '
        Me.cmbProduto.FormattingEnabled = True
        Me.cmbProduto.Location = New System.Drawing.Point(151, 34)
        Me.cmbProduto.Name = "cmbProduto"
        Me.cmbProduto.Size = New System.Drawing.Size(211, 21)
        Me.cmbProduto.TabIndex = 137
        '
        'cmbFornecedores
        '
        Me.cmbFornecedores.FormattingEnabled = True
        Me.cmbFornecedores.Location = New System.Drawing.Point(151, 100)
        Me.cmbFornecedores.Name = "cmbFornecedores"
        Me.cmbFornecedores.Size = New System.Drawing.Size(396, 21)
        Me.cmbFornecedores.TabIndex = 140
        '
        'cmbDescricao
        '
        Me.cmbDescricao.FormattingEnabled = True
        Me.cmbDescricao.Items.AddRange(New Object() {"Entrada", "Saída"})
        Me.cmbDescricao.Location = New System.Drawing.Point(151, 67)
        Me.cmbDescricao.Name = "cmbDescricao"
        Me.cmbDescricao.Size = New System.Drawing.Size(211, 21)
        Me.cmbDescricao.TabIndex = 141
        '
        'lblEstoque
        '
        Me.lblEstoque.AutoSize = True
        Me.lblEstoque.Location = New System.Drawing.Point(377, 37)
        Me.lblEstoque.Name = "lblEstoque"
        Me.lblEstoque.Size = New System.Drawing.Size(49, 13)
        Me.lblEstoque.TabIndex = 143
        Me.lblEstoque.Text = "Estoque:"
        '
        'txtEstoque
        '
        Me.txtEstoque.Enabled = False
        Me.txtEstoque.Location = New System.Drawing.Point(453, 35)
        Me.txtEstoque.Name = "txtEstoque"
        Me.txtEstoque.ReadOnly = True
        Me.txtEstoque.Size = New System.Drawing.Size(93, 20)
        Me.txtEstoque.TabIndex = 142
        '
        'pcbProdutos
        '
        Me.pcbProdutos.Location = New System.Drawing.Point(711, 30)
        Me.pcbProdutos.Name = "pcbProdutos"
        Me.pcbProdutos.Size = New System.Drawing.Size(120, 120)
        Me.pcbProdutos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbProdutos.TabIndex = 144
        Me.pcbProdutos.TabStop = False
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(290, 8)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtcodigo.TabIndex = 145
        Me.txtcodigo.Visible = False
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(679, 5)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(152, 20)
        Me.txtBuscar.TabIndex = 146
        '
        'txtQtddeVendida
        '
        Me.txtQtddeVendida.Enabled = False
        Me.txtQtddeVendida.Location = New System.Drawing.Point(192, 8)
        Me.txtQtddeVendida.Name = "txtQtddeVendida"
        Me.txtQtddeVendida.ReadOnly = True
        Me.txtQtddeVendida.Size = New System.Drawing.Size(72, 20)
        Me.txtQtddeVendida.TabIndex = 149
        Me.txtQtddeVendida.Visible = False
        '
        'Estoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(920, 483)
        Me.Controls.Add(Me.txtQtddeVendida)
        Me.Controls.Add(Me.cmbMotivo)
        Me.Controls.Add(Me.lblMotivo)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(Me.pcbProdutos)
        Me.Controls.Add(Me.txtEstoque)
        Me.Controls.Add(Me.lblEstoque)
        Me.Controls.Add(Me.cmbDescricao)
        Me.Controls.Add(Me.cmbFornecedores)
        Me.Controls.Add(Me.cmbProduto)
        Me.Controls.Add(Me.lblProduto)
        Me.Controls.Add(Me.txtQuantidade)
        Me.Controls.Add(Me.lblQuantidade)
        Me.Controls.Add(Me.lblFornecedor)
        Me.Controls.Add(Me.btnGravar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.dgvEstoque)
        Me.Controls.Add(Me.lblDescricao)
        Me.Controls.Add(Me.lblBuscar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Estoque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerenciamento de Estoque"
        CType(Me.dgvEstoque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGravar As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents dgvEstoque As DataGridView
    Friend WithEvents cmbMotivo As ComboBox
    Friend WithEvents lblMotivo As Label
    Friend WithEvents lblBuscar As Label
    Friend WithEvents lblDescricao As Label
    Friend WithEvents lblFornecedor As Label
    Friend WithEvents lblQuantidade As Label
    Friend WithEvents txtQuantidade As TextBox
    Friend WithEvents lblProduto As Label
    Friend WithEvents cmbProduto As ComboBox
    Friend WithEvents cmbFornecedores As ComboBox
    Friend WithEvents cmbDescricao As ComboBox
    Friend WithEvents lblEstoque As Label
    Friend WithEvents txtEstoque As TextBox
    Friend WithEvents pcbProdutos As PictureBox
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents txtQtddeVendida As TextBox
End Class
