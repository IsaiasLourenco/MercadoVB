<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fornecedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fornecedores))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.lblCidade = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.lblBairro = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.btnBuscaCEP = New System.Windows.Forms.Button()
        Me.mktCEP = New System.Windows.Forms.MaskedTextBox()
        Me.lblCEP = New System.Windows.Forms.Label()
        Me.txtContato = New System.Windows.Forms.TextBox()
        Me.lblContato = New System.Windows.Forms.Label()
        Me.lblQtdeTotal = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.mktCNPJBusca = New System.Windows.Forms.MaskedTextBox()
        Me.rbtCNPJ = New System.Windows.Forms.RadioButton()
        Me.rbtNome = New System.Windows.Forms.RadioButton()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGravar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.dgvFornecedores = New System.Windows.Forms.DataGridView()
        Me.mktCNPJ = New System.Windows.Forms.MaskedTextBox()
        Me.mktTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblTelefone = New System.Windows.Forms.Label()
        Me.txtRua = New System.Windows.Forms.TextBox()
        Me.lblRua = New System.Windows.Forms.Label()
        Me.lblCNPJ = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        CType(Me.dgvFornecedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtEstado
        '
        Me.txtEstado.Enabled = False
        Me.txtEstado.Location = New System.Drawing.Point(472, 132)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(87, 20)
        Me.txtEstado.TabIndex = 106
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(424, 134)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(43, 13)
        Me.lblEstado.TabIndex = 107
        Me.lblEstado.Text = "Estado:"
        '
        'txtCidade
        '
        Me.txtCidade.Enabled = False
        Me.txtCidade.Location = New System.Drawing.Point(53, 132)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(339, 20)
        Me.txtCidade.TabIndex = 104
        '
        'lblCidade
        '
        Me.lblCidade.AutoSize = True
        Me.lblCidade.Location = New System.Drawing.Point(10, 135)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(43, 13)
        Me.lblCidade.TabIndex = 105
        Me.lblCidade.Text = "Cidade:"
        '
        'txtBairro
        '
        Me.txtBairro.Enabled = False
        Me.txtBairro.Location = New System.Drawing.Point(622, 83)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(164, 20)
        Me.txtBairro.TabIndex = 102
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.Location = New System.Drawing.Point(579, 86)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(37, 13)
        Me.lblBairro.TabIndex = 103
        Me.lblBairro.Text = "Bairro:"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(472, 83)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(87, 20)
        Me.txtNumero.TabIndex = 100
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(424, 86)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(47, 13)
        Me.lblNumero.TabIndex = 101
        Me.lblNumero.Text = "Número:"
        '
        'btnBuscaCEP
        '
        Me.btnBuscaCEP.Image = CType(resources.GetObject("btnBuscaCEP.Image"), System.Drawing.Image)
        Me.btnBuscaCEP.Location = New System.Drawing.Point(143, 75)
        Me.btnBuscaCEP.Name = "btnBuscaCEP"
        Me.btnBuscaCEP.Size = New System.Drawing.Size(45, 41)
        Me.btnBuscaCEP.TabIndex = 99
        Me.btnBuscaCEP.UseVisualStyleBackColor = True
        '
        'mktCEP
        '
        Me.mktCEP.Location = New System.Drawing.Point(49, 86)
        Me.mktCEP.Mask = "99,999-999"
        Me.mktCEP.Name = "mktCEP"
        Me.mktCEP.Size = New System.Drawing.Size(87, 20)
        Me.mktCEP.TabIndex = 97
        '
        'lblCEP
        '
        Me.lblCEP.AutoSize = True
        Me.lblCEP.Location = New System.Drawing.Point(13, 90)
        Me.lblCEP.Name = "lblCEP"
        Me.lblCEP.Size = New System.Drawing.Size(31, 13)
        Me.lblCEP.TabIndex = 98
        Me.lblCEP.Text = "CEP:"
        '
        'txtContato
        '
        Me.txtContato.Enabled = False
        Me.txtContato.Location = New System.Drawing.Point(622, 174)
        Me.txtContato.Name = "txtContato"
        Me.txtContato.Size = New System.Drawing.Size(164, 20)
        Me.txtContato.TabIndex = 76
        '
        'lblContato
        '
        Me.lblContato.AutoSize = True
        Me.lblContato.Location = New System.Drawing.Point(565, 177)
        Me.lblContato.Name = "lblContato"
        Me.lblContato.Size = New System.Drawing.Size(47, 13)
        Me.lblContato.TabIndex = 96
        Me.lblContato.Text = "Contato:"
        '
        'lblQtdeTotal
        '
        Me.lblQtdeTotal.AutoSize = True
        Me.lblQtdeTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQtdeTotal.Location = New System.Drawing.Point(749, 442)
        Me.lblQtdeTotal.Name = "lblQtdeTotal"
        Me.lblQtdeTotal.Size = New System.Drawing.Size(11, 13)
        Me.lblQtdeTotal.TabIndex = 95
        Me.lblQtdeTotal.Text = "-"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(696, 442)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(40, 13)
        Me.lblTotal.TabIndex = 94
        Me.lblTotal.Text = "Total:"
        '
        'mktCNPJBusca
        '
        Me.mktCNPJBusca.Location = New System.Drawing.Point(621, 6)
        Me.mktCNPJBusca.Mask = "99,999,999/9999-99"
        Me.mktCNPJBusca.Name = "mktCNPJBusca"
        Me.mktCNPJBusca.Size = New System.Drawing.Size(164, 20)
        Me.mktCNPJBusca.TabIndex = 93
        Me.mktCNPJBusca.Visible = False
        '
        'rbtCNPJ
        '
        Me.rbtCNPJ.AutoSize = True
        Me.rbtCNPJ.Location = New System.Drawing.Point(568, 8)
        Me.rbtCNPJ.Name = "rbtCNPJ"
        Me.rbtCNPJ.Size = New System.Drawing.Size(52, 17)
        Me.rbtCNPJ.TabIndex = 92
        Me.rbtCNPJ.TabStop = True
        Me.rbtCNPJ.Text = "CNPJ"
        Me.rbtCNPJ.UseVisualStyleBackColor = True
        '
        'rbtNome
        '
        Me.rbtNome.AutoSize = True
        Me.rbtNome.Checked = True
        Me.rbtNome.Location = New System.Drawing.Point(518, 8)
        Me.rbtNome.Name = "rbtNome"
        Me.rbtNome.Size = New System.Drawing.Size(53, 17)
        Me.rbtNome.TabIndex = 91
        Me.rbtNome.TabStop = True
        Me.rbtNome.Text = "Nome"
        Me.rbtNome.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.Enabled = False
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.Location = New System.Drawing.Point(434, 469)
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
        Me.btnGravar.Location = New System.Drawing.Point(225, 469)
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(121, 100)
        Me.btnGravar.TabIndex = 89
        Me.btnGravar.Text = "Gravar"
        Me.btnGravar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGravar.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovo.Image = CType(resources.GetObject("btnNovo.Image"), System.Drawing.Image)
        Me.btnNovo.Location = New System.Drawing.Point(11, 469)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(121, 100)
        Me.btnNovo.TabIndex = 84
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
        Me.btnExcluir.Location = New System.Drawing.Point(659, 469)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(125, 100)
        Me.btnExcluir.TabIndex = 88
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'dgvFornecedores
        '
        Me.dgvFornecedores.AllowUserToAddRows = False
        Me.dgvFornecedores.AllowUserToDeleteRows = False
        Me.dgvFornecedores.AllowUserToResizeColumns = False
        Me.dgvFornecedores.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvFornecedores.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvFornecedores.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFornecedores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFornecedores.Location = New System.Drawing.Point(11, 216)
        Me.dgvFornecedores.Name = "dgvFornecedores"
        Me.dgvFornecedores.ReadOnly = True
        Me.dgvFornecedores.RowHeadersVisible = False
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvFornecedores.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvFornecedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFornecedores.Size = New System.Drawing.Size(775, 208)
        Me.dgvFornecedores.TabIndex = 87
        '
        'mktCNPJ
        '
        Me.mktCNPJ.Location = New System.Drawing.Point(622, 40)
        Me.mktCNPJ.Mask = "99,999,999/9999-99"
        Me.mktCNPJ.Name = "mktCNPJ"
        Me.mktCNPJ.Size = New System.Drawing.Size(164, 20)
        Me.mktCNPJ.TabIndex = 78
        '
        'mktTelefone
        '
        Me.mktTelefone.Location = New System.Drawing.Point(622, 132)
        Me.mktTelefone.Mask = "(99)99999-9999"
        Me.mktTelefone.Name = "mktTelefone"
        Me.mktTelefone.Size = New System.Drawing.Size(164, 20)
        Me.mktTelefone.TabIndex = 81
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(70, 177)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(485, 20)
        Me.txtEmail.TabIndex = 82
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(8, 180)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(39, 13)
        Me.lblEmail.TabIndex = 86
        Me.lblEmail.Text = "E-Mail:"
        '
        'lblTelefone
        '
        Me.lblTelefone.AutoSize = True
        Me.lblTelefone.Location = New System.Drawing.Point(563, 136)
        Me.lblTelefone.Name = "lblTelefone"
        Me.lblTelefone.Size = New System.Drawing.Size(52, 13)
        Me.lblTelefone.TabIndex = 85
        Me.lblTelefone.Text = "Telefone:"
        '
        'txtRua
        '
        Me.txtRua.Enabled = False
        Me.txtRua.Location = New System.Drawing.Point(222, 83)
        Me.txtRua.Name = "txtRua"
        Me.txtRua.Size = New System.Drawing.Size(170, 20)
        Me.txtRua.TabIndex = 79
        '
        'lblRua
        '
        Me.lblRua.AutoSize = True
        Me.lblRua.Location = New System.Drawing.Point(194, 86)
        Me.lblRua.Name = "lblRua"
        Me.lblRua.Size = New System.Drawing.Size(30, 13)
        Me.lblRua.TabIndex = 83
        Me.lblRua.Text = "Rua:"
        '
        'lblCNPJ
        '
        Me.lblCNPJ.AutoSize = True
        Me.lblCNPJ.Location = New System.Drawing.Point(581, 44)
        Me.lblCNPJ.Name = "lblCNPJ"
        Me.lblCNPJ.Size = New System.Drawing.Size(37, 13)
        Me.lblCNPJ.TabIndex = 80
        Me.lblCNPJ.Text = "CNPJ:"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(49, 40)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(510, 20)
        Me.txtNome.TabIndex = 73
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(12, 45)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(38, 13)
        Me.lblNome.TabIndex = 74
        Me.lblNome.Text = "Nome:"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(622, 6)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(164, 20)
        Me.txtBuscar.TabIndex = 72
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(472, 9)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(43, 13)
        Me.lblBuscar.TabIndex = 71
        Me.lblBuscar.Text = "Buscar:"
        '
        'Fornecedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(811, 578)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.txtCidade)
        Me.Controls.Add(Me.lblCidade)
        Me.Controls.Add(Me.txtBairro)
        Me.Controls.Add(Me.lblBairro)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.lblNumero)
        Me.Controls.Add(Me.btnBuscaCEP)
        Me.Controls.Add(Me.mktCEP)
        Me.Controls.Add(Me.lblCEP)
        Me.Controls.Add(Me.txtContato)
        Me.Controls.Add(Me.lblContato)
        Me.Controls.Add(Me.lblQtdeTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.mktCNPJBusca)
        Me.Controls.Add(Me.rbtCNPJ)
        Me.Controls.Add(Me.rbtNome)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnGravar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.dgvFornecedores)
        Me.Controls.Add(Me.mktCNPJ)
        Me.Controls.Add(Me.mktTelefone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblTelefone)
        Me.Controls.Add(Me.txtRua)
        Me.Controls.Add(Me.lblRua)
        Me.Controls.Add(Me.lblCNPJ)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.lblBuscar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Fornecedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fornecedores"
        CType(Me.dgvFornecedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEstado As TextBox
    Friend WithEvents lblEstado As Label
    Friend WithEvents txtCidade As TextBox
    Friend WithEvents lblCidade As Label
    Friend WithEvents txtBairro As TextBox
    Friend WithEvents lblBairro As Label
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents lblNumero As Label
    Friend WithEvents btnBuscaCEP As Button
    Friend WithEvents mktCEP As MaskedTextBox
    Friend WithEvents lblCEP As Label
    Friend WithEvents txtContato As TextBox
    Friend WithEvents lblContato As Label
    Friend WithEvents lblQtdeTotal As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents mktCNPJBusca As MaskedTextBox
    Friend WithEvents rbtCNPJ As RadioButton
    Friend WithEvents rbtNome As RadioButton
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnGravar As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents dgvFornecedores As DataGridView
    Friend WithEvents mktCNPJ As MaskedTextBox
    Friend WithEvents mktTelefone As MaskedTextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblTelefone As Label
    Friend WithEvents txtRua As TextBox
    Friend WithEvents lblRua As Label
    Friend WithEvents lblCNPJ As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents lblNome As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents lblBuscar As Label
End Class
