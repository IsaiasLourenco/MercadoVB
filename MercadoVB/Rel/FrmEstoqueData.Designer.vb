<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEstoqueData
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEstoqueData))
        Me.EstoqueEntreDatasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstoqueDataSet = New MercadoVB.EstoqueDataSet()
        Me.EstoqueEntradaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstoqueSaídaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EntradasSaidasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rbtEntreDatas = New System.Windows.Forms.RadioButton()
        Me.lblFinal = New System.Windows.Forms.Label()
        Me.lblInicio = New System.Windows.Forms.Label()
        Me.dtpDataFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtpDataInicial = New System.Windows.Forms.DateTimePicker()
        Me.cmbEntradaSaída = New System.Windows.Forms.ComboBox()
        Me.rbtEntradaSaída = New System.Windows.Forms.RadioButton()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.EstoqueEntreDatasTableAdapter = New MercadoVB.EstoqueDataSetTableAdapters.EstoqueEntreDatasTableAdapter()
        Me.EstoqueEntradaTableAdapter1 = New MercadoVB.EstoqueDataSetTableAdapters.EstoqueEntradaTableAdapter()
        Me.EstoqueSaídaTableAdapter1 = New MercadoVB.EstoqueDataSetTableAdapters.EstoqueSaídaTableAdapter()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.EntradasSaidasTableAdapter = New MercadoVB.EstoqueDataSetTableAdapters.EntradasSaidasTableAdapter()
        CType(Me.EstoqueEntreDatasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstoqueDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstoqueEntradaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstoqueSaídaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EntradasSaidasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EstoqueEntreDatasBindingSource
        '
        Me.EstoqueEntreDatasBindingSource.DataMember = "EstoqueEntreDatas"
        Me.EstoqueEntreDatasBindingSource.DataSource = Me.EstoqueDataSet
        '
        'EstoqueDataSet
        '
        Me.EstoqueDataSet.DataSetName = "EstoqueDataSet"
        Me.EstoqueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EstoqueEntradaBindingSource
        '
        Me.EstoqueEntradaBindingSource.DataMember = "EstoqueEntrada"
        Me.EstoqueEntradaBindingSource.DataSource = Me.EstoqueDataSet
        '
        'EstoqueSaídaBindingSource
        '
        Me.EstoqueSaídaBindingSource.DataMember = "EstoqueSaída"
        Me.EstoqueSaídaBindingSource.DataSource = Me.EstoqueDataSet
        '
        'EntradasSaidasBindingSource
        '
        Me.EntradasSaidasBindingSource.DataMember = "EntradasSaidas"
        Me.EntradasSaidasBindingSource.DataSource = Me.EstoqueDataSet
        '
        'rbtEntreDatas
        '
        Me.rbtEntreDatas.AutoSize = True
        Me.rbtEntreDatas.Location = New System.Drawing.Point(1003, 3)
        Me.rbtEntreDatas.Name = "rbtEntreDatas"
        Me.rbtEntreDatas.Size = New System.Drawing.Size(81, 17)
        Me.rbtEntreDatas.TabIndex = 159
        Me.rbtEntreDatas.Text = "Entre Datas"
        Me.rbtEntreDatas.UseVisualStyleBackColor = True
        '
        'lblFinal
        '
        Me.lblFinal.AutoSize = True
        Me.lblFinal.Location = New System.Drawing.Point(1082, 32)
        Me.lblFinal.Name = "lblFinal"
        Me.lblFinal.Size = New System.Drawing.Size(32, 13)
        Me.lblFinal.TabIndex = 158
        Me.lblFinal.Text = "Final:"
        '
        'lblInicio
        '
        Me.lblInicio.AutoSize = True
        Me.lblInicio.Location = New System.Drawing.Point(1082, 5)
        Me.lblInicio.Name = "lblInicio"
        Me.lblInicio.Size = New System.Drawing.Size(37, 13)
        Me.lblInicio.TabIndex = 157
        Me.lblInicio.Text = "Início:"
        '
        'dtpDataFinal
        '
        Me.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataFinal.Location = New System.Drawing.Point(1119, 30)
        Me.dtpDataFinal.Name = "dtpDataFinal"
        Me.dtpDataFinal.Size = New System.Drawing.Size(121, 20)
        Me.dtpDataFinal.TabIndex = 156
        '
        'dtpDataInicial
        '
        Me.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataInicial.Location = New System.Drawing.Point(1119, 3)
        Me.dtpDataInicial.Name = "dtpDataInicial"
        Me.dtpDataInicial.Size = New System.Drawing.Size(121, 20)
        Me.dtpDataInicial.TabIndex = 155
        '
        'cmbEntradaSaída
        '
        Me.cmbEntradaSaída.FormattingEnabled = True
        Me.cmbEntradaSaída.Items.AddRange(New Object() {"Entrada", "Saída"})
        Me.cmbEntradaSaída.Location = New System.Drawing.Point(874, 26)
        Me.cmbEntradaSaída.Name = "cmbEntradaSaída"
        Me.cmbEntradaSaída.Size = New System.Drawing.Size(121, 21)
        Me.cmbEntradaSaída.TabIndex = 154
        '
        'rbtEntradaSaída
        '
        Me.rbtEntradaSaída.AutoSize = True
        Me.rbtEntradaSaída.Checked = True
        Me.rbtEntradaSaída.Location = New System.Drawing.Point(891, 3)
        Me.rbtEntradaSaída.Name = "rbtEntradaSaída"
        Me.rbtEntradaSaída.Size = New System.Drawing.Size(102, 17)
        Me.rbtEntradaSaída.TabIndex = 152
        Me.rbtEntradaSaída.TabStop = True
        Me.rbtEntradaSaída.Text = "Entrada / Saída"
        Me.rbtEntradaSaída.UseVisualStyleBackColor = True
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(845, 4)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(43, 13)
        Me.lblBuscar.TabIndex = 151
        Me.lblBuscar.Text = "Buscar:"
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.EstoqueEntreDatasBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.EstoqueEntradaBindingSource
        ReportDataSource3.Name = "DataSet3"
        ReportDataSource3.Value = Me.EstoqueSaídaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MercadoVB.RelEsoques.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 56)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1228, 382)
        Me.ReportViewer1.TabIndex = 160
        '
        'EstoqueEntreDatasTableAdapter
        '
        Me.EstoqueEntreDatasTableAdapter.ClearBeforeFill = True
        '
        'EstoqueEntradaTableAdapter1
        '
        Me.EstoqueEntradaTableAdapter1.ClearBeforeFill = True
        '
        'EstoqueSaídaTableAdapter1
        '
        Me.EstoqueSaídaTableAdapter1.ClearBeforeFill = True
        '
        'ReportViewer2
        '
        ReportDataSource4.Name = "DataSet1"
        ReportDataSource4.Value = Me.EntradasSaidasBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "MercadoVB.RelEntradaSaída.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(12, 56)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.ServerReport.BearerToken = Nothing
        Me.ReportViewer2.Size = New System.Drawing.Size(1228, 382)
        Me.ReportViewer2.TabIndex = 161
        '
        'EntradasSaidasTableAdapter
        '
        Me.EntradasSaidasTableAdapter.ClearBeforeFill = True
        '
        'frmEstoqueData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1252, 450)
        Me.Controls.Add(Me.ReportViewer2)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.rbtEntreDatas)
        Me.Controls.Add(Me.lblFinal)
        Me.Controls.Add(Me.lblInicio)
        Me.Controls.Add(Me.dtpDataFinal)
        Me.Controls.Add(Me.dtpDataInicial)
        Me.Controls.Add(Me.cmbEntradaSaída)
        Me.Controls.Add(Me.rbtEntradaSaída)
        Me.Controls.Add(Me.lblBuscar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEstoqueData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta ao Estoque por Datas"
        CType(Me.EstoqueEntreDatasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstoqueDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstoqueEntradaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstoqueSaídaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EntradasSaidasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rbtEntreDatas As RadioButton
    Friend WithEvents lblFinal As Label
    Friend WithEvents lblInicio As Label
    Friend WithEvents dtpDataFinal As DateTimePicker
    Friend WithEvents dtpDataInicial As DateTimePicker
    Friend WithEvents cmbEntradaSaída As ComboBox
    Friend WithEvents rbtEntradaSaída As RadioButton
    Friend WithEvents lblBuscar As Label
    Friend WithEvents EstoqueEntradaTableAdapter As EstoqueDataSetTableAdapters.EstoqueEntradaTableAdapter
    Friend WithEvents EstoqueSaídaTableAdapter As EstoqueDataSetTableAdapters.EstoqueSaídaTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents EstoqueEntreDatasBindingSource As BindingSource
    Friend WithEvents EstoqueDataSet As EstoqueDataSet
    Friend WithEvents EstoqueEntradaBindingSource As BindingSource
    Friend WithEvents EstoqueSaídaBindingSource As BindingSource
    Friend WithEvents EstoqueEntreDatasTableAdapter As EstoqueDataSetTableAdapters.EstoqueEntreDatasTableAdapter
    Friend WithEvents EstoqueEntradaTableAdapter1 As EstoqueDataSetTableAdapters.EstoqueEntradaTableAdapter
    Friend WithEvents EstoqueSaídaTableAdapter1 As EstoqueDataSetTableAdapters.EstoqueSaídaTableAdapter
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents EntradasSaidasBindingSource As BindingSource
    Friend WithEvents EntradasSaidasTableAdapter As EstoqueDataSetTableAdapters.EntradasSaidasTableAdapter
End Class
