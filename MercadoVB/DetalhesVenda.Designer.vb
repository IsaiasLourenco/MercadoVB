<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetalhesVenda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DetalhesVenda))
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.rbtFuncionário = New System.Windows.Forms.RadioButton()
        Me.rbtCliente = New System.Windows.Forms.RadioButton()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.rbtData = New System.Windows.Forms.RadioButton()
        Me.cmbFuncionario = New System.Windows.Forms.ComboBox()
        Me.dtpData = New System.Windows.Forms.DateTimePicker()
        Me.dgvDetalhesVendas = New System.Windows.Forms.DataGridView()
        Me.lblQtdeTotalDetalhes = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        CType(Me.dgvDetalhesVendas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbCliente
        '
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(568, 8)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(121, 21)
        Me.cmbCliente.TabIndex = 129
        '
        'rbtFuncionário
        '
        Me.rbtFuncionário.AutoSize = True
        Me.rbtFuncionário.Location = New System.Drawing.Point(437, 9)
        Me.rbtFuncionário.Name = "rbtFuncionário"
        Me.rbtFuncionário.Size = New System.Drawing.Size(80, 17)
        Me.rbtFuncionário.TabIndex = 132
        Me.rbtFuncionário.Text = "Funcionário"
        Me.rbtFuncionário.UseVisualStyleBackColor = True
        '
        'rbtCliente
        '
        Me.rbtCliente.AutoSize = True
        Me.rbtCliente.Location = New System.Drawing.Point(382, 9)
        Me.rbtCliente.Name = "rbtCliente"
        Me.rbtCliente.Size = New System.Drawing.Size(57, 17)
        Me.rbtCliente.TabIndex = 131
        Me.rbtCliente.Text = "Cliente"
        Me.rbtCliente.UseVisualStyleBackColor = True
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(336, 10)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(43, 13)
        Me.lblBuscar.TabIndex = 130
        Me.lblBuscar.Text = "Buscar:"
        '
        'rbtData
        '
        Me.rbtData.AutoSize = True
        Me.rbtData.Checked = True
        Me.rbtData.Location = New System.Drawing.Point(517, 9)
        Me.rbtData.Name = "rbtData"
        Me.rbtData.Size = New System.Drawing.Size(48, 17)
        Me.rbtData.TabIndex = 133
        Me.rbtData.TabStop = True
        Me.rbtData.Text = "Data"
        Me.rbtData.UseVisualStyleBackColor = True
        '
        'cmbFuncionario
        '
        Me.cmbFuncionario.FormattingEnabled = True
        Me.cmbFuncionario.Location = New System.Drawing.Point(568, 8)
        Me.cmbFuncionario.Name = "cmbFuncionario"
        Me.cmbFuncionario.Size = New System.Drawing.Size(121, 21)
        Me.cmbFuncionario.TabIndex = 134
        Me.cmbFuncionario.Visible = False
        '
        'dtpData
        '
        Me.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpData.Location = New System.Drawing.Point(568, 8)
        Me.dtpData.Name = "dtpData"
        Me.dtpData.Size = New System.Drawing.Size(121, 20)
        Me.dtpData.TabIndex = 135
        Me.dtpData.Visible = False
        '
        'dgvDetalhesVendas
        '
        Me.dgvDetalhesVendas.AllowUserToAddRows = False
        Me.dgvDetalhesVendas.AllowUserToDeleteRows = False
        Me.dgvDetalhesVendas.AllowUserToResizeColumns = False
        Me.dgvDetalhesVendas.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvDetalhesVendas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDetalhesVendas.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetalhesVendas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDetalhesVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalhesVendas.Location = New System.Drawing.Point(25, 34)
        Me.dgvDetalhesVendas.Name = "dgvDetalhesVendas"
        Me.dgvDetalhesVendas.ReadOnly = True
        Me.dgvDetalhesVendas.RowHeadersVisible = False
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvDetalhesVendas.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvDetalhesVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalhesVendas.Size = New System.Drawing.Size(676, 404)
        Me.dgvDetalhesVendas.TabIndex = 136
        '
        'lblQtdeTotalDetalhes
        '
        Me.lblQtdeTotalDetalhes.AutoSize = True
        Me.lblQtdeTotalDetalhes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQtdeTotalDetalhes.Location = New System.Drawing.Point(613, 452)
        Me.lblQtdeTotalDetalhes.Name = "lblQtdeTotalDetalhes"
        Me.lblQtdeTotalDetalhes.Size = New System.Drawing.Size(11, 13)
        Me.lblQtdeTotalDetalhes.TabIndex = 138
        Me.lblQtdeTotalDetalhes.Text = "-"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(574, 452)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(40, 13)
        Me.lblTotal.TabIndex = 137
        Me.lblTotal.Text = "Total:"
        '
        'DetalhesVenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(713, 474)
        Me.Controls.Add(Me.lblQtdeTotalDetalhes)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.dgvDetalhesVendas)
        Me.Controls.Add(Me.dtpData)
        Me.Controls.Add(Me.cmbFuncionario)
        Me.Controls.Add(Me.rbtData)
        Me.Controls.Add(Me.rbtFuncionário)
        Me.Controls.Add(Me.rbtCliente)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.cmbCliente)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DetalhesVenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalhes de Vendas"
        CType(Me.dgvDetalhesVendas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbCliente As ComboBox
    Friend WithEvents rbtFuncionário As RadioButton
    Friend WithEvents rbtCliente As RadioButton
    Friend WithEvents lblBuscar As Label
    Friend WithEvents rbtData As RadioButton
    Friend WithEvents cmbFuncionario As ComboBox
    Friend WithEvents dtpData As DateTimePicker
    Friend WithEvents dgvDetalhesVendas As DataGridView
    Friend WithEvents lblQtdeTotalDetalhes As Label
    Friend WithEvents lblTotal As Label
End Class
