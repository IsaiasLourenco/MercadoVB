<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRelEstoque
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRelEstoque))
        Me.cmbEntradaSaída = New System.Windows.Forms.ComboBox()
        Me.dtpDataInicial = New System.Windows.Forms.DateTimePicker()
        Me.dtpDataFinal = New System.Windows.Forms.DateTimePicker()
        Me.lblInicio = New System.Windows.Forms.Label()
        Me.lblFinal = New System.Windows.Forms.Label()
        Me.rbtEntreDatas = New System.Windows.Forms.RadioButton()
        Me.rbtEntradaSaída = New System.Windows.Forms.RadioButton()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'cmbEntradaSaída
        '
        Me.cmbEntradaSaída.FormattingEnabled = True
        Me.cmbEntradaSaída.Items.AddRange(New Object() {"Entrada", "Saída"})
        Me.cmbEntradaSaída.Location = New System.Drawing.Point(859, 13)
        Me.cmbEntradaSaída.Name = "cmbEntradaSaída"
        Me.cmbEntradaSaída.Size = New System.Drawing.Size(121, 21)
        Me.cmbEntradaSaída.TabIndex = 154
        Me.cmbEntradaSaída.Visible = False
        '
        'dtpDataInicial
        '
        Me.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataInicial.Location = New System.Drawing.Point(859, 13)
        Me.dtpDataInicial.Name = "dtpDataInicial"
        Me.dtpDataInicial.Size = New System.Drawing.Size(121, 20)
        Me.dtpDataInicial.TabIndex = 155
        '
        'dtpDataFinal
        '
        Me.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataFinal.Location = New System.Drawing.Point(859, 42)
        Me.dtpDataFinal.Name = "dtpDataFinal"
        Me.dtpDataFinal.Size = New System.Drawing.Size(121, 20)
        Me.dtpDataFinal.TabIndex = 156
        Me.dtpDataFinal.Visible = False
        '
        'lblInicio
        '
        Me.lblInicio.AutoSize = True
        Me.lblInicio.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lblInicio.Location = New System.Drawing.Point(822, 17)
        Me.lblInicio.Name = "lblInicio"
        Me.lblInicio.Size = New System.Drawing.Size(37, 13)
        Me.lblInicio.TabIndex = 157
        Me.lblInicio.Text = "Início:"
        '
        'lblFinal
        '
        Me.lblFinal.AutoSize = True
        Me.lblFinal.Location = New System.Drawing.Point(822, 48)
        Me.lblFinal.Name = "lblFinal"
        Me.lblFinal.Size = New System.Drawing.Size(32, 13)
        Me.lblFinal.TabIndex = 158
        Me.lblFinal.Text = "Final:"
        Me.lblFinal.Visible = False
        '
        'rbtEntreDatas
        '
        Me.rbtEntreDatas.AutoSize = True
        Me.rbtEntreDatas.Checked = True
        Me.rbtEntreDatas.Location = New System.Drawing.Point(743, 15)
        Me.rbtEntreDatas.Name = "rbtEntreDatas"
        Me.rbtEntreDatas.Size = New System.Drawing.Size(81, 17)
        Me.rbtEntreDatas.TabIndex = 164
        Me.rbtEntreDatas.TabStop = True
        Me.rbtEntreDatas.Text = "Entre Datas"
        Me.rbtEntreDatas.UseVisualStyleBackColor = True
        '
        'rbtEntradaSaída
        '
        Me.rbtEntradaSaída.AutoSize = True
        Me.rbtEntradaSaída.Location = New System.Drawing.Point(631, 14)
        Me.rbtEntradaSaída.Name = "rbtEntradaSaída"
        Me.rbtEntradaSaída.Size = New System.Drawing.Size(102, 17)
        Me.rbtEntradaSaída.TabIndex = 162
        Me.rbtEntradaSaída.Text = "Entrada / Saída"
        Me.rbtEntradaSaída.UseVisualStyleBackColor = True
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(585, 15)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(43, 13)
        Me.lblBuscar.TabIndex = 161
        Me.lblBuscar.Text = "Buscar:"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MercadoVB.RelEstoque.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 68)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(992, 356)
        Me.ReportViewer1.TabIndex = 165
        '
        'frmRelEstoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(992, 424)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.rbtEntreDatas)
        Me.Controls.Add(Me.rbtEntradaSaída)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.lblFinal)
        Me.Controls.Add(Me.lblInicio)
        Me.Controls.Add(Me.dtpDataFinal)
        Me.Controls.Add(Me.dtpDataInicial)
        Me.Controls.Add(Me.cmbEntradaSaída)
        Me.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRelEstoque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Estoque Entradas e Saídas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbEntradaSaída As ComboBox
    Friend WithEvents dtpDataInicial As DateTimePicker
    Friend WithEvents dtpDataFinal As DateTimePicker
    Friend WithEvents lblInicio As Label
    Friend WithEvents lblFinal As Label
    Friend WithEvents rbtEntreDatas As RadioButton
    Friend WithEvents rbtEntradaSaída As RadioButton
    Friend WithEvents lblBuscar As Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
