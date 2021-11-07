<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblQtdeTotal = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.mktCPFBusca = New System.Windows.Forms.MaskedTextBox()
        Me.rbtCPF = New System.Windows.Forms.RadioButton()
        Me.rbtNome = New System.Windows.Forms.RadioButton()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGravar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.cmbSexo = New System.Windows.Forms.ComboBox()
        Me.mktCPF = New System.Windows.Forms.MaskedTextBox()
        Me.mktTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblTelefone = New System.Windows.Forms.Label()
        Me.txtRua = New System.Windows.Forms.TextBox()
        Me.lblRua = New System.Windows.Forms.Label()
        Me.lblCPF = New System.Windows.Forms.Label()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.lblIdade = New System.Windows.Forms.Label()
        Me.txtIdade = New System.Windows.Forms.TextBox()
        Me.mktCEP = New System.Windows.Forms.MaskedTextBox()
        Me.lblCEP = New System.Windows.Forms.Label()
        Me.btnBuscaCEP = New System.Windows.Forms.Button()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.lblBairro = New System.Windows.Forms.Label()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.lblCidade = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblQtdeTotal
        '
        Me.lblQtdeTotal.AutoSize = True
        Me.lblQtdeTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQtdeTotal.Location = New System.Drawing.Point(783, 448)
        Me.lblQtdeTotal.Name = "lblQtdeTotal"
        Me.lblQtdeTotal.Size = New System.Drawing.Size(11, 13)
        Me.lblQtdeTotal.TabIndex = 58
        Me.lblQtdeTotal.Text = "-"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(733, 448)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(40, 13)
        Me.lblTotal.TabIndex = 57
        Me.lblTotal.Text = "Total:"
        '
        'mktCPFBusca
        '
        Me.mktCPFBusca.Location = New System.Drawing.Point(659, 12)
        Me.mktCPFBusca.Mask = "999,999,999-99"
        Me.mktCPFBusca.Name = "mktCPFBusca"
        Me.mktCPFBusca.Size = New System.Drawing.Size(170, 20)
        Me.mktCPFBusca.TabIndex = 56
        Me.mktCPFBusca.Visible = False
        '
        'rbtCPF
        '
        Me.rbtCPF.AutoSize = True
        Me.rbtCPF.Location = New System.Drawing.Point(611, 14)
        Me.rbtCPF.Name = "rbtCPF"
        Me.rbtCPF.Size = New System.Drawing.Size(45, 17)
        Me.rbtCPF.TabIndex = 55
        Me.rbtCPF.TabStop = True
        Me.rbtCPF.Text = "CPF"
        Me.rbtCPF.UseVisualStyleBackColor = True
        '
        'rbtNome
        '
        Me.rbtNome.AutoSize = True
        Me.rbtNome.Checked = True
        Me.rbtNome.Location = New System.Drawing.Point(555, 14)
        Me.rbtNome.Name = "rbtNome"
        Me.rbtNome.Size = New System.Drawing.Size(53, 17)
        Me.rbtNome.TabIndex = 54
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
        Me.btnEditar.Location = New System.Drawing.Point(471, 475)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(121, 100)
        Me.btnEditar.TabIndex = 53
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
        Me.btnGravar.Location = New System.Drawing.Point(262, 475)
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(121, 100)
        Me.btnGravar.TabIndex = 52
        Me.btnGravar.Text = "Gravar"
        Me.btnGravar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGravar.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovo.Image = CType(resources.GetObject("btnNovo.Image"), System.Drawing.Image)
        Me.btnNovo.Location = New System.Drawing.Point(48, 475)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(121, 100)
        Me.btnNovo.TabIndex = 45
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
        Me.btnExcluir.Location = New System.Drawing.Point(698, 475)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(125, 100)
        Me.btnExcluir.TabIndex = 51
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.AllowUserToDeleteRows = False
        Me.dgvClientes.AllowUserToResizeColumns = False
        Me.dgvClientes.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvClientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvClientes.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Location = New System.Drawing.Point(48, 222)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.ReadOnly = True
        Me.dgvClientes.RowHeadersVisible = False
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvClientes.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClientes.Size = New System.Drawing.Size(775, 208)
        Me.dgvClientes.TabIndex = 50
        '
        'cmbSexo
        '
        Me.cmbSexo.FormattingEnabled = True
        Me.cmbSexo.Items.AddRange(New Object() {"Masculino", "Feminino", "Não Especificado"})
        Me.cmbSexo.Location = New System.Drawing.Point(322, 45)
        Me.cmbSexo.Name = "cmbSexo"
        Me.cmbSexo.Size = New System.Drawing.Size(107, 21)
        Me.cmbSexo.TabIndex = 34
        '
        'mktCPF
        '
        Me.mktCPF.Location = New System.Drawing.Point(659, 46)
        Me.mktCPF.Mask = "999,999,999-99"
        Me.mktCPF.Name = "mktCPF"
        Me.mktCPF.Size = New System.Drawing.Size(170, 20)
        Me.mktCPF.TabIndex = 37
        '
        'mktTelefone
        '
        Me.mktTelefone.Location = New System.Drawing.Point(655, 138)
        Me.mktTelefone.Mask = "(99)99999-9999"
        Me.mktTelefone.Name = "mktTelefone"
        Me.mktTelefone.Size = New System.Drawing.Size(170, 20)
        Me.mktTelefone.TabIndex = 40
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(107, 183)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(485, 20)
        Me.txtEmail.TabIndex = 41
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(45, 186)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(39, 13)
        Me.lblEmail.TabIndex = 47
        Me.lblEmail.Text = "E-Mail:"
        '
        'lblTelefone
        '
        Me.lblTelefone.AutoSize = True
        Me.lblTelefone.Location = New System.Drawing.Point(600, 142)
        Me.lblTelefone.Name = "lblTelefone"
        Me.lblTelefone.Size = New System.Drawing.Size(52, 13)
        Me.lblTelefone.TabIndex = 46
        Me.lblTelefone.Text = "Telefone:"
        '
        'txtRua
        '
        Me.txtRua.Location = New System.Drawing.Point(259, 89)
        Me.txtRua.Name = "txtRua"
        Me.txtRua.Size = New System.Drawing.Size(170, 20)
        Me.txtRua.TabIndex = 38
        '
        'lblRua
        '
        Me.lblRua.AutoSize = True
        Me.lblRua.Location = New System.Drawing.Point(231, 92)
        Me.lblRua.Name = "lblRua"
        Me.lblRua.Size = New System.Drawing.Size(30, 13)
        Me.lblRua.TabIndex = 42
        Me.lblRua.Text = "Rua:"
        '
        'lblCPF
        '
        Me.lblCPF.AutoSize = True
        Me.lblCPF.Location = New System.Drawing.Point(623, 50)
        Me.lblCPF.Name = "lblCPF"
        Me.lblCPF.Size = New System.Drawing.Size(30, 13)
        Me.lblCPF.TabIndex = 39
        Me.lblCPF.Text = "CPF:"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Location = New System.Drawing.Point(281, 49)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(34, 13)
        Me.lblSexo.TabIndex = 36
        Me.lblSexo.Text = "Sexo:"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(86, 46)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(195, 20)
        Me.txtNome.TabIndex = 32
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(49, 51)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(38, 13)
        Me.lblNome.TabIndex = 33
        Me.lblNome.Text = "Nome:"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(659, 12)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(170, 20)
        Me.txtBuscar.TabIndex = 31
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(509, 15)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(43, 13)
        Me.lblBuscar.TabIndex = 30
        Me.lblBuscar.Text = "Buscar:"
        '
        'lblIdade
        '
        Me.lblIdade.AutoSize = True
        Me.lblIdade.Location = New System.Drawing.Point(461, 49)
        Me.lblIdade.Name = "lblIdade"
        Me.lblIdade.Size = New System.Drawing.Size(37, 13)
        Me.lblIdade.TabIndex = 59
        Me.lblIdade.Text = "Idade:"
        '
        'txtIdade
        '
        Me.txtIdade.Location = New System.Drawing.Point(509, 46)
        Me.txtIdade.Name = "txtIdade"
        Me.txtIdade.Size = New System.Drawing.Size(87, 20)
        Me.txtIdade.TabIndex = 35
        '
        'mktCEP
        '
        Me.mktCEP.Location = New System.Drawing.Point(86, 92)
        Me.mktCEP.Mask = "99,999-999"
        Me.mktCEP.Name = "mktCEP"
        Me.mktCEP.Size = New System.Drawing.Size(87, 20)
        Me.mktCEP.TabIndex = 60
        '
        'lblCEP
        '
        Me.lblCEP.AutoSize = True
        Me.lblCEP.Location = New System.Drawing.Point(50, 96)
        Me.lblCEP.Name = "lblCEP"
        Me.lblCEP.Size = New System.Drawing.Size(31, 13)
        Me.lblCEP.TabIndex = 61
        Me.lblCEP.Text = "CEP:"
        '
        'btnBuscaCEP
        '
        Me.btnBuscaCEP.Image = CType(resources.GetObject("btnBuscaCEP.Image"), System.Drawing.Image)
        Me.btnBuscaCEP.Location = New System.Drawing.Point(180, 81)
        Me.btnBuscaCEP.Name = "btnBuscaCEP"
        Me.btnBuscaCEP.Size = New System.Drawing.Size(45, 41)
        Me.btnBuscaCEP.TabIndex = 62
        Me.btnBuscaCEP.UseVisualStyleBackColor = True
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(509, 89)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(87, 20)
        Me.txtNumero.TabIndex = 63
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(461, 92)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(47, 13)
        Me.lblNumero.TabIndex = 64
        Me.lblNumero.Text = "Número:"
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(659, 89)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(170, 20)
        Me.txtBairro.TabIndex = 65
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.Location = New System.Drawing.Point(616, 92)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(37, 13)
        Me.lblBairro.TabIndex = 66
        Me.lblBairro.Text = "Bairro:"
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(90, 138)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(339, 20)
        Me.txtCidade.TabIndex = 67
        '
        'lblCidade
        '
        Me.lblCidade.AutoSize = True
        Me.lblCidade.Location = New System.Drawing.Point(47, 141)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(43, 13)
        Me.lblCidade.TabIndex = 68
        Me.lblCidade.Text = "Cidade:"
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(509, 138)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(87, 20)
        Me.txtEstado.TabIndex = 69
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(461, 140)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(43, 13)
        Me.lblEstado.TabIndex = 70
        Me.lblEstado.Text = "Estado:"
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(890, 581)
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
        Me.Controls.Add(Me.txtIdade)
        Me.Controls.Add(Me.lblIdade)
        Me.Controls.Add(Me.lblQtdeTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.mktCPFBusca)
        Me.Controls.Add(Me.rbtCPF)
        Me.Controls.Add(Me.rbtNome)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnGravar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.dgvClientes)
        Me.Controls.Add(Me.cmbSexo)
        Me.Controls.Add(Me.mktCPF)
        Me.Controls.Add(Me.mktTelefone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblTelefone)
        Me.Controls.Add(Me.txtRua)
        Me.Controls.Add(Me.lblRua)
        Me.Controls.Add(Me.lblCPF)
        Me.Controls.Add(Me.lblSexo)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.lblBuscar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblQtdeTotal As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents mktCPFBusca As MaskedTextBox
    Friend WithEvents rbtCPF As RadioButton
    Friend WithEvents rbtNome As RadioButton
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnGravar As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents cmbSexo As ComboBox
    Friend WithEvents mktCPF As MaskedTextBox
    Friend WithEvents mktTelefone As MaskedTextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblTelefone As Label
    Friend WithEvents txtRua As TextBox
    Friend WithEvents lblRua As Label
    Friend WithEvents lblCPF As Label
    Friend WithEvents lblSexo As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents lblNome As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents lblBuscar As Label
    Friend WithEvents lblIdade As Label
    Friend WithEvents txtIdade As TextBox
    Friend WithEvents mktCEP As MaskedTextBox
    Friend WithEvents lblCEP As Label
    Friend WithEvents btnBuscaCEP As Button
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents lblNumero As Label
    Friend WithEvents txtBairro As TextBox
    Friend WithEvents lblBairro As Label
    Friend WithEvents txtCidade As TextBox
    Friend WithEvents lblCidade As Label
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents lblEstado As Label
End Class
