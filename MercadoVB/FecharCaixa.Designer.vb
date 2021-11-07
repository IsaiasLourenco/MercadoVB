<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FecharCaixa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FecharCaixa))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnGravar = New System.Windows.Forms.Button()
        Me.dgvFechaCaixa = New System.Windows.Forms.DataGridView()
        Me.txtValorAbertura = New System.Windows.Forms.TextBox()
        Me.lblValorAbertura = New System.Windows.Forms.Label()
        Me.txtTotalCaixa = New System.Windows.Forms.TextBox()
        Me.lblTotalCaixa = New System.Windows.Forms.Label()
        CType(Me.dgvFechaCaixa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGravar
        '
        Me.btnGravar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGravar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGravar.Image = CType(resources.GetObject("btnGravar.Image"), System.Drawing.Image)
        Me.btnGravar.Location = New System.Drawing.Point(582, 11)
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(121, 94)
        Me.btnGravar.TabIndex = 142
        Me.btnGravar.Text = "Gravar"
        Me.btnGravar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGravar.UseVisualStyleBackColor = True
        '
        'dgvFechaCaixa
        '
        Me.dgvFechaCaixa.AllowUserToAddRows = False
        Me.dgvFechaCaixa.AllowUserToDeleteRows = False
        Me.dgvFechaCaixa.AllowUserToResizeColumns = False
        Me.dgvFechaCaixa.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvFechaCaixa.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvFechaCaixa.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFechaCaixa.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvFechaCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFechaCaixa.Location = New System.Drawing.Point(12, 111)
        Me.dgvFechaCaixa.Name = "dgvFechaCaixa"
        Me.dgvFechaCaixa.ReadOnly = True
        Me.dgvFechaCaixa.RowHeadersVisible = False
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvFechaCaixa.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvFechaCaixa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFechaCaixa.Size = New System.Drawing.Size(689, 202)
        Me.dgvFechaCaixa.TabIndex = 140
        '
        'txtValorAbertura
        '
        Me.txtValorAbertura.Location = New System.Drawing.Point(118, 49)
        Me.txtValorAbertura.Name = "txtValorAbertura"
        Me.txtValorAbertura.Size = New System.Drawing.Size(132, 20)
        Me.txtValorAbertura.TabIndex = 150
        '
        'lblValorAbertura
        '
        Me.lblValorAbertura.AutoSize = True
        Me.lblValorAbertura.Location = New System.Drawing.Point(21, 52)
        Me.lblValorAbertura.Name = "lblValorAbertura"
        Me.lblValorAbertura.Size = New System.Drawing.Size(92, 13)
        Me.lblValorAbertura.TabIndex = 151
        Me.lblValorAbertura.Text = "Valor da Abertura:"
        '
        'txtTotalCaixa
        '
        Me.txtTotalCaixa.Location = New System.Drawing.Point(402, 50)
        Me.txtTotalCaixa.Name = "txtTotalCaixa"
        Me.txtTotalCaixa.Size = New System.Drawing.Size(132, 20)
        Me.txtTotalCaixa.TabIndex = 148
        '
        'lblTotalCaixa
        '
        Me.lblTotalCaixa.AutoSize = True
        Me.lblTotalCaixa.Location = New System.Drawing.Point(318, 53)
        Me.lblTotalCaixa.Name = "lblTotalCaixa"
        Me.lblTotalCaixa.Size = New System.Drawing.Size(78, 13)
        Me.lblTotalCaixa.TabIndex = 149
        Me.lblTotalCaixa.Text = "Total do Caixa:"
        '
        'FecharCaixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(718, 349)
        Me.Controls.Add(Me.txtValorAbertura)
        Me.Controls.Add(Me.lblValorAbertura)
        Me.Controls.Add(Me.txtTotalCaixa)
        Me.Controls.Add(Me.lblTotalCaixa)
        Me.Controls.Add(Me.btnGravar)
        Me.Controls.Add(Me.dgvFechaCaixa)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FecharCaixa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fechar o Caixa"
        CType(Me.dgvFechaCaixa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGravar As Button
    Friend WithEvents dgvFechaCaixa As DataGridView
    Friend WithEvents txtValorAbertura As TextBox
    Friend WithEvents lblValorAbertura As Label
    Friend WithEvents txtTotalCaixa As TextBox
    Friend WithEvents lblTotalCaixa As Label
End Class
