<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VendasDiaAbreFechaCaixa
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VendasDiaAbreFechaCaixa))
        Me.pcbCaixa = New System.Windows.Forms.PictureBox()
        Me.txtTotalVendido = New System.Windows.Forms.TextBox()
        Me.lblTextoCaixa = New System.Windows.Forms.Label()
        Me.lblAbrirFechar = New System.Windows.Forms.Label()
        Me.pnlGrid = New System.Windows.Forms.Panel()
        Me.lblVendasDia = New System.Windows.Forms.Label()
        Me.dgvVendas = New System.Windows.Forms.DataGridView()
        Me.pcbMoney = New System.Windows.Forms.PictureBox()
        Me.pnlNumbers = New System.Windows.Forms.Panel()
        Me.pnlDataHora = New System.Windows.Forms.Panel()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.lblDataeHora = New System.Windows.Forms.Label()
        Me.pnlProdVend = New System.Windows.Forms.Panel()
        Me.lblLabelProdutosVendidos = New System.Windows.Forms.Label()
        Me.pnlVendas = New System.Windows.Forms.Panel()
        Me.lblItensVendidosDia = New System.Windows.Forms.Label()
        Me.pnlSangria = New System.Windows.Forms.Panel()
        Me.lblLabelUltimaSangria = New System.Windows.Forms.Label()
        Me.pnlOperador = New System.Windows.Forms.Panel()
        Me.lblLabelOperador = New System.Windows.Forms.Label()
        Me.lblProdutosVendidos = New System.Windows.Forms.Label()
        Me.lblUltimaSangria = New System.Windows.Forms.Label()
        Me.lblOperador = New System.Windows.Forms.Label()
        Me.lblVendas = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblLabelValorAbertura = New System.Windows.Forms.Label()
        Me.lblLabelHoraAbertura = New System.Windows.Forms.Label()
        Me.lblNivel = New System.Windows.Forms.Label()
        Me.pcbNivel = New System.Windows.Forms.PictureBox()
        CType(Me.pcbCaixa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGrid.SuspendLayout()
        CType(Me.dgvVendas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbMoney, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlNumbers.SuspendLayout()
        Me.pnlDataHora.SuspendLayout()
        Me.pnlProdVend.SuspendLayout()
        Me.pnlVendas.SuspendLayout()
        Me.pnlSangria.SuspendLayout()
        Me.pnlOperador.SuspendLayout()
        CType(Me.pcbNivel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pcbCaixa
        '
        Me.pcbCaixa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbCaixa.Location = New System.Drawing.Point(999, 27)
        Me.pcbCaixa.Name = "pcbCaixa"
        Me.pcbCaixa.Size = New System.Drawing.Size(35, 23)
        Me.pcbCaixa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbCaixa.TabIndex = 144
        Me.pcbCaixa.TabStop = False
        '
        'txtTotalVendido
        '
        Me.txtTotalVendido.Enabled = False
        Me.txtTotalVendido.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalVendido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTotalVendido.Location = New System.Drawing.Point(222, 431)
        Me.txtTotalVendido.Name = "txtTotalVendido"
        Me.txtTotalVendido.ReadOnly = True
        Me.txtTotalVendido.Size = New System.Drawing.Size(150, 29)
        Me.txtTotalVendido.TabIndex = 143
        Me.txtTotalVendido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTextoCaixa
        '
        Me.lblTextoCaixa.AutoSize = True
        Me.lblTextoCaixa.Font = New System.Drawing.Font("Arial", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextoCaixa.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.lblTextoCaixa.Location = New System.Drawing.Point(356, 20)
        Me.lblTextoCaixa.Name = "lblTextoCaixa"
        Me.lblTextoCaixa.Size = New System.Drawing.Size(0, 53)
        Me.lblTextoCaixa.TabIndex = 149
        '
        'lblAbrirFechar
        '
        Me.lblAbrirFechar.AutoSize = True
        Me.lblAbrirFechar.Location = New System.Drawing.Point(973, 53)
        Me.lblAbrirFechar.Name = "lblAbrirFechar"
        Me.lblAbrirFechar.Size = New System.Drawing.Size(89, 13)
        Me.lblAbrirFechar.TabIndex = 150
        Me.lblAbrirFechar.Text = "ABRIR CAIXA "
        '
        'pnlGrid
        '
        Me.pnlGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlGrid.Controls.Add(Me.lblVendasDia)
        Me.pnlGrid.Controls.Add(Me.dgvVendas)
        Me.pnlGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlGrid.Location = New System.Drawing.Point(499, 113)
        Me.pnlGrid.Name = "pnlGrid"
        Me.pnlGrid.Size = New System.Drawing.Size(614, 357)
        Me.pnlGrid.TabIndex = 153
        '
        'lblVendasDia
        '
        Me.lblVendasDia.AutoSize = True
        Me.lblVendasDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVendasDia.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.lblVendasDia.Location = New System.Drawing.Point(199, 4)
        Me.lblVendasDia.Name = "lblVendasDia"
        Me.lblVendasDia.Size = New System.Drawing.Size(164, 20)
        Me.lblVendasDia.TabIndex = 154
        Me.lblVendasDia.Text = "ÚLTIMAS VENDAS"
        '
        'dgvVendas
        '
        Me.dgvVendas.AllowUserToAddRows = False
        Me.dgvVendas.AllowUserToDeleteRows = False
        Me.dgvVendas.AllowUserToResizeColumns = False
        Me.dgvVendas.AllowUserToResizeRows = False
        DataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle28.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvVendas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle28
        Me.dgvVendas.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVendas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle29
        Me.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVendas.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvVendas.Location = New System.Drawing.Point(23, 27)
        Me.dgvVendas.Name = "dgvVendas"
        Me.dgvVendas.ReadOnly = True
        Me.dgvVendas.RowHeadersVisible = False
        DataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvVendas.RowsDefaultCellStyle = DataGridViewCellStyle30
        Me.dgvVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVendas.Size = New System.Drawing.Size(565, 314)
        Me.dgvVendas.TabIndex = 153
        '
        'pcbMoney
        '
        Me.pcbMoney.Image = CType(resources.GetObject("pcbMoney.Image"), System.Drawing.Image)
        Me.pcbMoney.Location = New System.Drawing.Point(91, 401)
        Me.pcbMoney.Name = "pcbMoney"
        Me.pcbMoney.Size = New System.Drawing.Size(117, 100)
        Me.pcbMoney.TabIndex = 154
        Me.pcbMoney.TabStop = False
        '
        'pnlNumbers
        '
        Me.pnlNumbers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlNumbers.Controls.Add(Me.pnlDataHora)
        Me.pnlNumbers.Controls.Add(Me.lblDataeHora)
        Me.pnlNumbers.Controls.Add(Me.pnlProdVend)
        Me.pnlNumbers.Controls.Add(Me.pnlVendas)
        Me.pnlNumbers.Controls.Add(Me.pnlSangria)
        Me.pnlNumbers.Controls.Add(Me.pnlOperador)
        Me.pnlNumbers.Controls.Add(Me.lblProdutosVendidos)
        Me.pnlNumbers.Controls.Add(Me.lblUltimaSangria)
        Me.pnlNumbers.Controls.Add(Me.lblOperador)
        Me.pnlNumbers.Controls.Add(Me.lblVendas)
        Me.pnlNumbers.Location = New System.Drawing.Point(29, 210)
        Me.pnlNumbers.Name = "pnlNumbers"
        Me.pnlNumbers.Size = New System.Drawing.Size(394, 191)
        Me.pnlNumbers.TabIndex = 155
        '
        'pnlDataHora
        '
        Me.pnlDataHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlDataHora.Controls.Add(Me.lblHora)
        Me.pnlDataHora.Controls.Add(Me.lblData)
        Me.pnlDataHora.Location = New System.Drawing.Point(234, 3)
        Me.pnlDataHora.Name = "pnlDataHora"
        Me.pnlDataHora.Size = New System.Drawing.Size(137, 26)
        Me.pnlDataHora.TabIndex = 162
        '
        'lblHora
        '
        Me.lblHora.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.Location = New System.Drawing.Point(70, 6)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(11, 13)
        Me.lblHora.TabIndex = 152
        Me.lblHora.Text = "-"
        '
        'lblData
        '
        Me.lblData.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblData.AutoSize = True
        Me.lblData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData.Location = New System.Drawing.Point(3, 6)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(11, 13)
        Me.lblData.TabIndex = 151
        Me.lblData.Text = "-"
        '
        'lblDataeHora
        '
        Me.lblDataeHora.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDataeHora.AutoSize = True
        Me.lblDataeHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataeHora.Location = New System.Drawing.Point(23, 5)
        Me.lblDataeHora.Name = "lblDataeHora"
        Me.lblDataeHora.Size = New System.Drawing.Size(142, 24)
        Me.lblDataeHora.TabIndex = 161
        Me.lblDataeHora.Text = "DATA / HORA"
        '
        'pnlProdVend
        '
        Me.pnlProdVend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlProdVend.Controls.Add(Me.lblLabelProdutosVendidos)
        Me.pnlProdVend.Location = New System.Drawing.Point(234, 156)
        Me.pnlProdVend.Name = "pnlProdVend"
        Me.pnlProdVend.Size = New System.Drawing.Size(137, 25)
        Me.pnlProdVend.TabIndex = 160
        '
        'lblLabelProdutosVendidos
        '
        Me.lblLabelProdutosVendidos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblLabelProdutosVendidos.AutoSize = True
        Me.lblLabelProdutosVendidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabelProdutosVendidos.Location = New System.Drawing.Point(3, -1)
        Me.lblLabelProdutosVendidos.Name = "lblLabelProdutosVendidos"
        Me.lblLabelProdutosVendidos.Size = New System.Drawing.Size(17, 24)
        Me.lblLabelProdutosVendidos.TabIndex = 155
        Me.lblLabelProdutosVendidos.Text = "-"
        '
        'pnlVendas
        '
        Me.pnlVendas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlVendas.Controls.Add(Me.lblItensVendidosDia)
        Me.pnlVendas.Location = New System.Drawing.Point(234, 118)
        Me.pnlVendas.Name = "pnlVendas"
        Me.pnlVendas.Size = New System.Drawing.Size(137, 24)
        Me.pnlVendas.TabIndex = 159
        '
        'lblItensVendidosDia
        '
        Me.lblItensVendidosDia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblItensVendidosDia.AutoSize = True
        Me.lblItensVendidosDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItensVendidosDia.Location = New System.Drawing.Point(3, -1)
        Me.lblItensVendidosDia.Name = "lblItensVendidosDia"
        Me.lblItensVendidosDia.Size = New System.Drawing.Size(17, 24)
        Me.lblItensVendidosDia.TabIndex = 149
        Me.lblItensVendidosDia.Text = "-"
        '
        'pnlSangria
        '
        Me.pnlSangria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSangria.Controls.Add(Me.lblLabelUltimaSangria)
        Me.pnlSangria.Location = New System.Drawing.Point(234, 82)
        Me.pnlSangria.Name = "pnlSangria"
        Me.pnlSangria.Size = New System.Drawing.Size(137, 23)
        Me.pnlSangria.TabIndex = 158
        '
        'lblLabelUltimaSangria
        '
        Me.lblLabelUltimaSangria.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblLabelUltimaSangria.AutoSize = True
        Me.lblLabelUltimaSangria.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabelUltimaSangria.Location = New System.Drawing.Point(3, -2)
        Me.lblLabelUltimaSangria.Name = "lblLabelUltimaSangria"
        Me.lblLabelUltimaSangria.Size = New System.Drawing.Size(17, 24)
        Me.lblLabelUltimaSangria.TabIndex = 153
        Me.lblLabelUltimaSangria.Text = "-"
        '
        'pnlOperador
        '
        Me.pnlOperador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlOperador.Controls.Add(Me.lblLabelOperador)
        Me.pnlOperador.Location = New System.Drawing.Point(234, 41)
        Me.pnlOperador.Name = "pnlOperador"
        Me.pnlOperador.Size = New System.Drawing.Size(137, 26)
        Me.pnlOperador.TabIndex = 157
        '
        'lblLabelOperador
        '
        Me.lblLabelOperador.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblLabelOperador.AutoSize = True
        Me.lblLabelOperador.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabelOperador.Location = New System.Drawing.Point(3, 0)
        Me.lblLabelOperador.Name = "lblLabelOperador"
        Me.lblLabelOperador.Size = New System.Drawing.Size(17, 24)
        Me.lblLabelOperador.TabIndex = 157
        Me.lblLabelOperador.Text = "-"
        '
        'lblProdutosVendidos
        '
        Me.lblProdutosVendidos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblProdutosVendidos.AutoSize = True
        Me.lblProdutosVendidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProdutosVendidos.Location = New System.Drawing.Point(20, 156)
        Me.lblProdutosVendidos.Name = "lblProdutosVendidos"
        Me.lblProdutosVendidos.Size = New System.Drawing.Size(178, 24)
        Me.lblProdutosVendidos.TabIndex = 153
        Me.lblProdutosVendidos.Text = "PROD VENDIDOS"
        '
        'lblUltimaSangria
        '
        Me.lblUltimaSangria.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblUltimaSangria.AutoSize = True
        Me.lblUltimaSangria.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUltimaSangria.Location = New System.Drawing.Point(20, 79)
        Me.lblUltimaSangria.Name = "lblUltimaSangria"
        Me.lblUltimaSangria.Size = New System.Drawing.Size(180, 24)
        Me.lblUltimaSangria.TabIndex = 151
        Me.lblUltimaSangria.Text = "ÚLTIMA SANGRIA"
        '
        'lblOperador
        '
        Me.lblOperador.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblOperador.AutoSize = True
        Me.lblOperador.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperador.Location = New System.Drawing.Point(23, 39)
        Me.lblOperador.Name = "lblOperador"
        Me.lblOperador.Size = New System.Drawing.Size(125, 24)
        Me.lblOperador.TabIndex = 149
        Me.lblOperador.Text = "OPERADOR"
        '
        'lblVendas
        '
        Me.lblVendas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblVendas.AutoSize = True
        Me.lblVendas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVendas.Location = New System.Drawing.Point(20, 118)
        Me.lblVendas.Name = "lblVendas"
        Me.lblVendas.Size = New System.Drawing.Size(169, 24)
        Me.lblVendas.TabIndex = 147
        Me.lblVendas.Text = "VENDAS DO DIA"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'lblLabelValorAbertura
        '
        Me.lblLabelValorAbertura.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblLabelValorAbertura.AutoSize = True
        Me.lblLabelValorAbertura.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabelValorAbertura.Location = New System.Drawing.Point(240, 88)
        Me.lblLabelValorAbertura.Name = "lblLabelValorAbertura"
        Me.lblLabelValorAbertura.Size = New System.Drawing.Size(21, 24)
        Me.lblLabelValorAbertura.TabIndex = 156
        Me.lblLabelValorAbertura.Text = "0"
        Me.lblLabelValorAbertura.Visible = False
        '
        'lblLabelHoraAbertura
        '
        Me.lblLabelHoraAbertura.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblLabelHoraAbertura.AutoSize = True
        Me.lblLabelHoraAbertura.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabelHoraAbertura.Location = New System.Drawing.Point(238, 64)
        Me.lblLabelHoraAbertura.Name = "lblLabelHoraAbertura"
        Me.lblLabelHoraAbertura.Size = New System.Drawing.Size(17, 24)
        Me.lblLabelHoraAbertura.TabIndex = 151
        Me.lblLabelHoraAbertura.Text = "-"
        Me.lblLabelHoraAbertura.Visible = False
        '
        'lblNivel
        '
        Me.lblNivel.AutoSize = True
        Me.lblNivel.Location = New System.Drawing.Point(973, 95)
        Me.lblNivel.Name = "lblNivel"
        Me.lblNivel.Size = New System.Drawing.Size(107, 13)
        Me.lblNivel.TabIndex = 158
        Me.lblNivel.Text = "ESTOQUE BAIXO"
        '
        'pcbNivel
        '
        Me.pcbNivel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbNivel.Location = New System.Drawing.Point(999, 69)
        Me.pcbNivel.Name = "pcbNivel"
        Me.pcbNivel.Size = New System.Drawing.Size(35, 23)
        Me.pcbNivel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbNivel.TabIndex = 157
        Me.pcbNivel.TabStop = False
        '
        'VendasDiaAbreFechaCaixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1141, 494)
        Me.Controls.Add(Me.lblNivel)
        Me.Controls.Add(Me.pcbNivel)
        Me.Controls.Add(Me.lblLabelValorAbertura)
        Me.Controls.Add(Me.lblLabelHoraAbertura)
        Me.Controls.Add(Me.pnlNumbers)
        Me.Controls.Add(Me.pcbMoney)
        Me.Controls.Add(Me.pnlGrid)
        Me.Controls.Add(Me.lblAbrirFechar)
        Me.Controls.Add(Me.lblTextoCaixa)
        Me.Controls.Add(Me.pcbCaixa)
        Me.Controls.Add(Me.txtTotalVendido)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VendasDiaAbreFechaCaixa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vendas do Dia - Abrir e Fechar Caixa"
        CType(Me.pcbCaixa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGrid.ResumeLayout(False)
        Me.pnlGrid.PerformLayout()
        CType(Me.dgvVendas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbMoney, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlNumbers.ResumeLayout(False)
        Me.pnlNumbers.PerformLayout()
        Me.pnlDataHora.ResumeLayout(False)
        Me.pnlDataHora.PerformLayout()
        Me.pnlProdVend.ResumeLayout(False)
        Me.pnlProdVend.PerformLayout()
        Me.pnlVendas.ResumeLayout(False)
        Me.pnlVendas.PerformLayout()
        Me.pnlSangria.ResumeLayout(False)
        Me.pnlSangria.PerformLayout()
        Me.pnlOperador.ResumeLayout(False)
        Me.pnlOperador.PerformLayout()
        CType(Me.pcbNivel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pcbCaixa As PictureBox
    Friend WithEvents txtTotalVendido As TextBox
    Friend WithEvents lblTextoCaixa As Label
    Friend WithEvents lblAbrirFechar As Label
    Friend WithEvents pnlGrid As Panel
    Friend WithEvents lblVendasDia As Label
    Friend WithEvents dgvVendas As DataGridView
    Friend WithEvents pcbMoney As PictureBox
    Friend WithEvents pnlNumbers As Panel
    Friend WithEvents pnlProdVend As Panel
    Friend WithEvents lblLabelProdutosVendidos As Label
    Friend WithEvents pnlVendas As Panel
    Friend WithEvents lblItensVendidosDia As Label
    Friend WithEvents pnlSangria As Panel
    Friend WithEvents lblLabelUltimaSangria As Label
    Friend WithEvents pnlOperador As Panel
    Friend WithEvents lblProdutosVendidos As Label
    Friend WithEvents lblUltimaSangria As Label
    Friend WithEvents lblOperador As Label
    Friend WithEvents lblVendas As Label
    Friend WithEvents lblDataeHora As Label
    Friend WithEvents pnlDataHora As Panel
    Friend WithEvents lblData As Label
    Friend WithEvents lblLabelOperador As Label
    Friend WithEvents lblHora As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblLabelValorAbertura As Label
    Friend WithEvents lblLabelHoraAbertura As Label
    Friend WithEvents lblNivel As Label
    Friend WithEvents pcbNivel As PictureBox
End Class
