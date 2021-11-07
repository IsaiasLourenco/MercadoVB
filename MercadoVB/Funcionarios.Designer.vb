<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Funcionarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Funcionarios))
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.lblCPF = New System.Windows.Forms.Label()
        Me.lblTelefone = New System.Windows.Forms.Label()
        Me.txtRua = New System.Windows.Forms.TextBox()
        Me.lblRua = New System.Windows.Forms.Label()
        Me.lblDataContrato = New System.Windows.Forms.Label()
        Me.lblTurno = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.mktTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.mktCPF = New System.Windows.Forms.MaskedTextBox()
        Me.cmbSexo = New System.Windows.Forms.ComboBox()
        Me.cmbTurno = New System.Windows.Forms.ComboBox()
        Me.dtpDataAdm = New System.Windows.Forms.DateTimePicker()
        Me.dgvFuncionarios = New System.Windows.Forms.DataGridView()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnGravar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.rbtNome = New System.Windows.Forms.RadioButton()
        Me.rbtCPF = New System.Windows.Forms.RadioButton()
        Me.mktCPFBusca = New System.Windows.Forms.MaskedTextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblQtdeTotal = New System.Windows.Forms.Label()
        Me.lblSenha = New System.Windows.Forms.Label()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.mktCEP = New System.Windows.Forms.MaskedTextBox()
        Me.lblCEP = New System.Windows.Forms.Label()
        Me.btnBuscarCEP = New System.Windows.Forms.Button()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.lblBairro = New System.Windows.Forms.Label()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.lblCidade = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblCargo = New System.Windows.Forms.Label()
        Me.cmbCargo = New System.Windows.Forms.ComboBox()
        CType(Me.dgvFuncionarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(468, 8)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(43, 13)
        Me.lblBuscar.TabIndex = 0
        Me.lblBuscar.Text = "Buscar:"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(618, 5)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(170, 20)
        Me.txtBuscar.TabIndex = 0
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(70, 39)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(170, 20)
        Me.txtNome.TabIndex = 0
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(8, 40)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(38, 13)
        Me.lblNome.TabIndex = 2
        Me.lblNome.Text = "Nome:"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Location = New System.Drawing.Point(240, 42)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(34, 13)
        Me.lblSexo.TabIndex = 4
        Me.lblSexo.Text = "Sexo:"
        '
        'lblCPF
        '
        Me.lblCPF.AutoSize = True
        Me.lblCPF.Location = New System.Drawing.Point(582, 43)
        Me.lblCPF.Name = "lblCPF"
        Me.lblCPF.Size = New System.Drawing.Size(30, 13)
        Me.lblCPF.TabIndex = 6
        Me.lblCPF.Text = "CPF:"
        '
        'lblTelefone
        '
        Me.lblTelefone.AutoSize = True
        Me.lblTelefone.Location = New System.Drawing.Point(563, 138)
        Me.lblTelefone.Name = "lblTelefone"
        Me.lblTelefone.Size = New System.Drawing.Size(52, 13)
        Me.lblTelefone.TabIndex = 12
        Me.lblTelefone.Text = "Telefone:"
        '
        'txtRua
        '
        Me.txtRua.Enabled = False
        Me.txtRua.Location = New System.Drawing.Point(242, 87)
        Me.txtRua.Name = "txtRua"
        Me.txtRua.Size = New System.Drawing.Size(170, 20)
        Me.txtRua.TabIndex = 5
        '
        'lblRua
        '
        Me.lblRua.AutoSize = True
        Me.lblRua.Location = New System.Drawing.Point(207, 90)
        Me.lblRua.Name = "lblRua"
        Me.lblRua.Size = New System.Drawing.Size(30, 13)
        Me.lblRua.TabIndex = 8
        Me.lblRua.Text = "Rua:"
        '
        'lblDataContrato
        '
        Me.lblDataContrato.AutoSize = True
        Me.lblDataContrato.Location = New System.Drawing.Point(557, 179)
        Me.lblDataContrato.Name = "lblDataContrato"
        Me.lblDataContrato.Size = New System.Drawing.Size(60, 13)
        Me.lblDataContrato.TabIndex = 18
        Me.lblDataContrato.Text = "Data Adm :"
        '
        'lblTurno
        '
        Me.lblTurno.AutoSize = True
        Me.lblTurno.Location = New System.Drawing.Point(275, 181)
        Me.lblTurno.Name = "lblTurno"
        Me.lblTurno.Size = New System.Drawing.Size(38, 13)
        Me.lblTurno.TabIndex = 16
        Me.lblTurno.Text = "Turno:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(70, 177)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(170, 20)
        Me.txtEmail.TabIndex = 8
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(8, 180)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(39, 13)
        Me.lblEmail.TabIndex = 14
        Me.lblEmail.Text = "E-Mail:"
        '
        'mktTelefone
        '
        Me.mktTelefone.Location = New System.Drawing.Point(618, 132)
        Me.mktTelefone.Mask = "(99)99999-9999"
        Me.mktTelefone.Name = "mktTelefone"
        Me.mktTelefone.Size = New System.Drawing.Size(170, 20)
        Me.mktTelefone.TabIndex = 7
        '
        'mktCPF
        '
        Me.mktCPF.Location = New System.Drawing.Point(618, 39)
        Me.mktCPF.Mask = "999,999,999-99"
        Me.mktCPF.Name = "mktCPF"
        Me.mktCPF.Size = New System.Drawing.Size(170, 20)
        Me.mktCPF.TabIndex = 3
        '
        'cmbSexo
        '
        Me.cmbSexo.FormattingEnabled = True
        Me.cmbSexo.Items.AddRange(New Object() {"Masculino", "Feminino", "Não Especificado"})
        Me.cmbSexo.Location = New System.Drawing.Point(281, 38)
        Me.cmbSexo.Name = "cmbSexo"
        Me.cmbSexo.Size = New System.Drawing.Size(107, 21)
        Me.cmbSexo.TabIndex = 1
        '
        'cmbTurno
        '
        Me.cmbTurno.FormattingEnabled = True
        Me.cmbTurno.Items.AddRange(New Object() {"Manhã", "Tarde", "Noite", "Madrugada"})
        Me.cmbTurno.Location = New System.Drawing.Point(321, 175)
        Me.cmbTurno.Name = "cmbTurno"
        Me.cmbTurno.Size = New System.Drawing.Size(170, 21)
        Me.cmbTurno.TabIndex = 9
        '
        'dtpDataAdm
        '
        Me.dtpDataAdm.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataAdm.Location = New System.Drawing.Point(618, 174)
        Me.dtpDataAdm.Name = "dtpDataAdm"
        Me.dtpDataAdm.Size = New System.Drawing.Size(170, 20)
        Me.dtpDataAdm.TabIndex = 10
        Me.dtpDataAdm.Value = New Date(2021, 5, 28, 0, 0, 0, 0)
        '
        'dgvFuncionarios
        '
        Me.dgvFuncionarios.AllowUserToAddRows = False
        Me.dgvFuncionarios.AllowUserToDeleteRows = False
        Me.dgvFuncionarios.AllowUserToResizeColumns = False
        Me.dgvFuncionarios.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvFuncionarios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvFuncionarios.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFuncionarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFuncionarios.Location = New System.Drawing.Point(11, 216)
        Me.dgvFuncionarios.Name = "dgvFuncionarios"
        Me.dgvFuncionarios.ReadOnly = True
        Me.dgvFuncionarios.RowHeadersVisible = False
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvFuncionarios.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFuncionarios.Size = New System.Drawing.Size(775, 208)
        Me.dgvFuncionarios.TabIndex = 19
        '
        'btnExcluir
        '
        Me.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluir.Enabled = False
        Me.btnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.Location = New System.Drawing.Point(661, 469)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(125, 100)
        Me.btnExcluir.TabIndex = 20
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovo.Image = CType(resources.GetObject("btnNovo.Image"), System.Drawing.Image)
        Me.btnNovo.Location = New System.Drawing.Point(11, 469)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(121, 100)
        Me.btnNovo.TabIndex = 10
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNovo.UseVisualStyleBackColor = True
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
        Me.btnGravar.TabIndex = 22
        Me.btnGravar.Text = "Gravar"
        Me.btnGravar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGravar.UseVisualStyleBackColor = True
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
        Me.btnEditar.TabIndex = 23
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'rbtNome
        '
        Me.rbtNome.AutoSize = True
        Me.rbtNome.Checked = True
        Me.rbtNome.Location = New System.Drawing.Point(514, 7)
        Me.rbtNome.Name = "rbtNome"
        Me.rbtNome.Size = New System.Drawing.Size(53, 17)
        Me.rbtNome.TabIndex = 24
        Me.rbtNome.TabStop = True
        Me.rbtNome.Text = "Nome"
        Me.rbtNome.UseVisualStyleBackColor = True
        '
        'rbtCPF
        '
        Me.rbtCPF.AutoSize = True
        Me.rbtCPF.Location = New System.Drawing.Point(570, 7)
        Me.rbtCPF.Name = "rbtCPF"
        Me.rbtCPF.Size = New System.Drawing.Size(45, 17)
        Me.rbtCPF.TabIndex = 25
        Me.rbtCPF.TabStop = True
        Me.rbtCPF.Text = "CPF"
        Me.rbtCPF.UseVisualStyleBackColor = True
        '
        'mktCPFBusca
        '
        Me.mktCPFBusca.Location = New System.Drawing.Point(618, 5)
        Me.mktCPFBusca.Mask = "999,999,999-99"
        Me.mktCPFBusca.Name = "mktCPFBusca"
        Me.mktCPFBusca.Size = New System.Drawing.Size(170, 20)
        Me.mktCPFBusca.TabIndex = 26
        Me.mktCPFBusca.Visible = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(696, 442)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(40, 13)
        Me.lblTotal.TabIndex = 27
        Me.lblTotal.Text = "Total:"
        '
        'lblQtdeTotal
        '
        Me.lblQtdeTotal.AutoSize = True
        Me.lblQtdeTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQtdeTotal.Location = New System.Drawing.Point(744, 442)
        Me.lblQtdeTotal.Name = "lblQtdeTotal"
        Me.lblQtdeTotal.Size = New System.Drawing.Size(11, 13)
        Me.lblQtdeTotal.TabIndex = 28
        Me.lblQtdeTotal.Text = "-"
        '
        'lblSenha
        '
        Me.lblSenha.AutoSize = True
        Me.lblSenha.Location = New System.Drawing.Point(398, 42)
        Me.lblSenha.Name = "lblSenha"
        Me.lblSenha.Size = New System.Drawing.Size(41, 13)
        Me.lblSenha.TabIndex = 29
        Me.lblSenha.Text = "Senha:"
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(445, 39)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.Size = New System.Drawing.Size(110, 20)
        Me.txtSenha.TabIndex = 2
        '
        'mktCEP
        '
        Me.mktCEP.Location = New System.Drawing.Point(70, 86)
        Me.mktCEP.Mask = "99,999-999"
        Me.mktCEP.Name = "mktCEP"
        Me.mktCEP.Size = New System.Drawing.Size(81, 20)
        Me.mktCEP.TabIndex = 4
        '
        'lblCEP
        '
        Me.lblCEP.AutoSize = True
        Me.lblCEP.Location = New System.Drawing.Point(12, 89)
        Me.lblCEP.Name = "lblCEP"
        Me.lblCEP.Size = New System.Drawing.Size(31, 13)
        Me.lblCEP.TabIndex = 31
        Me.lblCEP.Text = "CEP:"
        '
        'btnBuscarCEP
        '
        Me.btnBuscarCEP.Image = CType(resources.GetObject("btnBuscarCEP.Image"), System.Drawing.Image)
        Me.btnBuscarCEP.Location = New System.Drawing.Point(157, 81)
        Me.btnBuscarCEP.Name = "btnBuscarCEP"
        Me.btnBuscarCEP.Size = New System.Drawing.Size(35, 30)
        Me.btnBuscarCEP.TabIndex = 5
        Me.btnBuscarCEP.UseVisualStyleBackColor = True
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(482, 87)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(52, 20)
        Me.txtNumero.TabIndex = 6
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(437, 90)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(47, 13)
        Me.lblNumero.TabIndex = 34
        Me.lblNumero.Text = "Número:"
        '
        'txtBairro
        '
        Me.txtBairro.Enabled = False
        Me.txtBairro.Location = New System.Drawing.Point(618, 87)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(170, 20)
        Me.txtBairro.TabIndex = 35
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.Location = New System.Drawing.Point(583, 90)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(37, 13)
        Me.lblBairro.TabIndex = 36
        Me.lblBairro.Text = "Bairro:"
        '
        'txtCidade
        '
        Me.txtCidade.Enabled = False
        Me.txtCidade.Location = New System.Drawing.Point(67, 133)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(170, 20)
        Me.txtCidade.TabIndex = 37
        '
        'lblCidade
        '
        Me.lblCidade.AutoSize = True
        Me.lblCidade.Location = New System.Drawing.Point(14, 136)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(43, 13)
        Me.lblCidade.TabIndex = 38
        Me.lblCidade.Text = "Cidade:"
        '
        'txtEstado
        '
        Me.txtEstado.Enabled = False
        Me.txtEstado.Location = New System.Drawing.Point(291, 133)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(52, 20)
        Me.txtEstado.TabIndex = 39
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(246, 136)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(43, 13)
        Me.lblEstado.TabIndex = 40
        Me.lblEstado.Text = "Estado:"
        '
        'lblCargo
        '
        Me.lblCargo.AutoSize = True
        Me.lblCargo.Location = New System.Drawing.Point(350, 135)
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Size = New System.Drawing.Size(38, 13)
        Me.lblCargo.TabIndex = 42
        Me.lblCargo.Text = "Cargo:"
        '
        'cmbCargo
        '
        Me.cmbCargo.FormattingEnabled = True
        Me.cmbCargo.Items.AddRange(New Object() {"Administrador", "Caixa", "Repositor", "Padeiro", "Açougueiro"})
        Me.cmbCargo.Location = New System.Drawing.Point(388, 132)
        Me.cmbCargo.Name = "cmbCargo"
        Me.cmbCargo.Size = New System.Drawing.Size(146, 21)
        Me.cmbCargo.TabIndex = 43
        '
        'Funcionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 583)
        Me.Controls.Add(Me.cmbCargo)
        Me.Controls.Add(Me.lblCargo)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.txtCidade)
        Me.Controls.Add(Me.lblCidade)
        Me.Controls.Add(Me.txtBairro)
        Me.Controls.Add(Me.lblBairro)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.lblNumero)
        Me.Controls.Add(Me.btnBuscarCEP)
        Me.Controls.Add(Me.mktCEP)
        Me.Controls.Add(Me.lblCEP)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.lblSenha)
        Me.Controls.Add(Me.lblQtdeTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.mktCPFBusca)
        Me.Controls.Add(Me.rbtCPF)
        Me.Controls.Add(Me.rbtNome)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnGravar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.dgvFuncionarios)
        Me.Controls.Add(Me.dtpDataAdm)
        Me.Controls.Add(Me.cmbTurno)
        Me.Controls.Add(Me.cmbSexo)
        Me.Controls.Add(Me.mktCPF)
        Me.Controls.Add(Me.mktTelefone)
        Me.Controls.Add(Me.lblDataContrato)
        Me.Controls.Add(Me.lblTurno)
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
        Me.Name = "Funcionarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Funcionarios"
        CType(Me.dgvFuncionarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBuscar As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents lblNome As Label
    Friend WithEvents lblSexo As Label
    Friend WithEvents lblCPF As Label
    Friend WithEvents lblTelefone As Label
    Friend WithEvents txtRua As TextBox
    Friend WithEvents lblRua As Label
    Friend WithEvents lblDataContrato As Label
    Friend WithEvents lblTurno As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents mktTelefone As MaskedTextBox
    Friend WithEvents mktCPF As MaskedTextBox
    Friend WithEvents cmbSexo As ComboBox
    Friend WithEvents cmbTurno As ComboBox
    Friend WithEvents dtpDataAdm As DateTimePicker
    Friend WithEvents dgvFuncionarios As DataGridView
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents btnGravar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents rbtNome As RadioButton
    Friend WithEvents rbtCPF As RadioButton
    Friend WithEvents mktCPFBusca As MaskedTextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblQtdeTotal As Label
    Friend WithEvents lblSenha As Label
    Friend WithEvents txtSenha As TextBox
    Friend WithEvents mktCEP As MaskedTextBox
    Friend WithEvents lblCEP As Label
    Friend WithEvents btnBuscarCEP As Button
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents lblNumero As Label
    Friend WithEvents txtBairro As TextBox
    Friend WithEvents lblBairro As Label
    Friend WithEvents txtCidade As TextBox
    Friend WithEvents lblCidade As Label
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents lblEstado As Label
    Friend WithEvents lblCargo As Label
    Friend WithEvents cmbCargo As ComboBox
End Class
