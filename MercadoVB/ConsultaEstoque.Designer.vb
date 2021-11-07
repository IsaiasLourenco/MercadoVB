<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConsultaEstoque
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaEstoque))
        Me.dgvConsultaEstoque = New System.Windows.Forms.DataGridView()
        Me.cmbEntradaSaída = New System.Windows.Forms.ComboBox()
        Me.rbtData = New System.Windows.Forms.RadioButton()
        Me.rbtEntradaSaída = New System.Windows.Forms.RadioButton()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.dtpDataInicial = New System.Windows.Forms.DateTimePicker()
        Me.dtpDataFinal = New System.Windows.Forms.DateTimePicker()
        Me.lblInicio = New System.Windows.Forms.Label()
        Me.lblFinal = New System.Windows.Forms.Label()
        Me.rbtEntreDatas = New System.Windows.Forms.RadioButton()
        CType(Me.dgvConsultaEstoque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvConsultaEstoque
        '
        Me.dgvConsultaEstoque.AllowUserToAddRows = False
        Me.dgvConsultaEstoque.AllowUserToDeleteRows = False
        Me.dgvConsultaEstoque.AllowUserToResizeColumns = False
        Me.dgvConsultaEstoque.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvConsultaEstoque.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvConsultaEstoque.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvConsultaEstoque.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvConsultaEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsultaEstoque.Location = New System.Drawing.Point(8, 63)
        Me.dgvConsultaEstoque.Name = "dgvConsultaEstoque"
        Me.dgvConsultaEstoque.ReadOnly = True
        Me.dgvConsultaEstoque.RowHeadersVisible = False
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvConsultaEstoque.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvConsultaEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvConsultaEstoque.Size = New System.Drawing.Size(886, 375)
        Me.dgvConsultaEstoque.TabIndex = 146
        '
        'cmbEntradaSaída
        '
        Me.cmbEntradaSaída.FormattingEnabled = True
        Me.cmbEntradaSaída.Items.AddRange(New Object() {"Entrada", "Saída"})
        Me.cmbEntradaSaída.Location = New System.Drawing.Point(771, 8)
        Me.cmbEntradaSaída.Name = "cmbEntradaSaída"
        Me.cmbEntradaSaída.Size = New System.Drawing.Size(121, 21)
        Me.cmbEntradaSaída.TabIndex = 144
        Me.cmbEntradaSaída.Visible = False
        '
        'rbtData
        '
        Me.rbtData.AutoSize = True
        Me.rbtData.Checked = True
        Me.rbtData.Location = New System.Drawing.Point(657, 10)
        Me.rbtData.Name = "rbtData"
        Me.rbtData.Size = New System.Drawing.Size(48, 17)
        Me.rbtData.TabIndex = 143
        Me.rbtData.TabStop = True
        Me.rbtData.Text = "Data"
        Me.rbtData.UseVisualStyleBackColor = True
        '
        'rbtEntradaSaída
        '
        Me.rbtEntradaSaída.AutoSize = True
        Me.rbtEntradaSaída.Location = New System.Drawing.Point(543, 10)
        Me.rbtEntradaSaída.Name = "rbtEntradaSaída"
        Me.rbtEntradaSaída.Size = New System.Drawing.Size(102, 17)
        Me.rbtEntradaSaída.TabIndex = 141
        Me.rbtEntradaSaída.Text = "Entrada / Saída"
        Me.rbtEntradaSaída.UseVisualStyleBackColor = True
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(497, 11)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(43, 13)
        Me.lblBuscar.TabIndex = 140
        Me.lblBuscar.Text = "Buscar:"
        '
        'dtpDataInicial
        '
        Me.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataInicial.Location = New System.Drawing.Point(771, 8)
        Me.dtpDataInicial.Name = "dtpDataInicial"
        Me.dtpDataInicial.Size = New System.Drawing.Size(121, 20)
        Me.dtpDataInicial.TabIndex = 145
        '
        'dtpDataFinal
        '
        Me.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataFinal.Location = New System.Drawing.Point(771, 37)
        Me.dtpDataFinal.Name = "dtpDataFinal"
        Me.dtpDataFinal.Size = New System.Drawing.Size(121, 20)
        Me.dtpDataFinal.TabIndex = 147
        Me.dtpDataFinal.Visible = False
        '
        'lblInicio
        '
        Me.lblInicio.AutoSize = True
        Me.lblInicio.Location = New System.Drawing.Point(734, 12)
        Me.lblInicio.Name = "lblInicio"
        Me.lblInicio.Size = New System.Drawing.Size(37, 13)
        Me.lblInicio.TabIndex = 148
        Me.lblInicio.Text = "Início:"
        '
        'lblFinal
        '
        Me.lblFinal.AutoSize = True
        Me.lblFinal.Location = New System.Drawing.Point(734, 43)
        Me.lblFinal.Name = "lblFinal"
        Me.lblFinal.Size = New System.Drawing.Size(32, 13)
        Me.lblFinal.TabIndex = 149
        Me.lblFinal.Text = "Final:"
        Me.lblFinal.Visible = False
        '
        'rbtEntreDatas
        '
        Me.rbtEntreDatas.AutoSize = True
        Me.rbtEntreDatas.Location = New System.Drawing.Point(655, 41)
        Me.rbtEntreDatas.Name = "rbtEntreDatas"
        Me.rbtEntreDatas.Size = New System.Drawing.Size(81, 17)
        Me.rbtEntreDatas.TabIndex = 150
        Me.rbtEntreDatas.Text = "Entre Datas"
        Me.rbtEntreDatas.UseVisualStyleBackColor = True
        Me.rbtEntreDatas.Visible = False
        '
        'ConsultaEstoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(906, 468)
        Me.Controls.Add(Me.rbtEntreDatas)
        Me.Controls.Add(Me.lblFinal)
        Me.Controls.Add(Me.lblInicio)
        Me.Controls.Add(Me.dtpDataFinal)
        Me.Controls.Add(Me.dgvConsultaEstoque)
        Me.Controls.Add(Me.dtpDataInicial)
        Me.Controls.Add(Me.cmbEntradaSaída)
        Me.Controls.Add(Me.rbtData)
        Me.Controls.Add(Me.rbtEntradaSaída)
        Me.Controls.Add(Me.lblBuscar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ConsultaEstoque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultas ao Estoque"
        CType(Me.dgvConsultaEstoque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvConsultaEstoque As DataGridView
    Friend WithEvents cmbEntradaSaída As ComboBox
    Friend WithEvents rbtData As RadioButton
    Friend WithEvents rbtEntradaSaída As RadioButton
    Friend WithEvents lblBuscar As Label
    Friend WithEvents dtpDataInicial As DateTimePicker
    Friend WithEvents dtpDataFinal As DateTimePicker
    Friend WithEvents lblInicio As Label
    Friend WithEvents lblFinal As Label
    Friend WithEvents rbtEntreDatas As RadioButton
End Class
