<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRelProdVend
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRelProdVend))
        Me.QtddeVendidaDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProdutosDataSet = New MercadoVB.ProdutosDataSet()
        Me.lblFinal = New System.Windows.Forms.Label()
        Me.lblInicio = New System.Windows.Forms.Label()
        Me.dtpDataFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtpDataInicial = New System.Windows.Forms.DateTimePicker()
        Me.QtddeVendidaDataBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.produtosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QtddeVendidaDataTableAdapter = New MercadoVB.ProdutosDataSetTableAdapters.QtddeVendidaDataTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.QtddeVendidaDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdutosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QtddeVendidaDataBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.produtosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QtddeVendidaDataBindingSource
        '
        Me.QtddeVendidaDataBindingSource.DataMember = "QtddeVendidaData"
        Me.QtddeVendidaDataBindingSource.DataSource = Me.ProdutosDataSet
        '
        'ProdutosDataSet
        '
        Me.ProdutosDataSet.DataSetName = "ProdutosDataSet"
        Me.ProdutosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblFinal
        '
        Me.lblFinal.AutoSize = True
        Me.lblFinal.Location = New System.Drawing.Point(630, 2)
        Me.lblFinal.Name = "lblFinal"
        Me.lblFinal.Size = New System.Drawing.Size(32, 13)
        Me.lblFinal.TabIndex = 162
        Me.lblFinal.Text = "Final:"
        '
        'lblInicio
        '
        Me.lblInicio.AutoSize = True
        Me.lblInicio.Location = New System.Drawing.Point(469, 2)
        Me.lblInicio.Name = "lblInicio"
        Me.lblInicio.Size = New System.Drawing.Size(37, 13)
        Me.lblInicio.TabIndex = 161
        Me.lblInicio.Text = "Início:"
        '
        'dtpDataFinal
        '
        Me.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataFinal.Location = New System.Drawing.Point(667, 0)
        Me.dtpDataFinal.Name = "dtpDataFinal"
        Me.dtpDataFinal.Size = New System.Drawing.Size(121, 20)
        Me.dtpDataFinal.TabIndex = 160
        '
        'dtpDataInicial
        '
        Me.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataInicial.Location = New System.Drawing.Point(506, 0)
        Me.dtpDataInicial.Name = "dtpDataInicial"
        Me.dtpDataInicial.Size = New System.Drawing.Size(121, 20)
        Me.dtpDataInicial.TabIndex = 159
        '
        'QtddeVendidaDataBindingSource1
        '
        Me.QtddeVendidaDataBindingSource1.DataMember = "QtddeVendidaData"
        Me.QtddeVendidaDataBindingSource1.DataSource = Me.ProdutosDataSet
        '
        'produtosBindingSource
        '
        Me.produtosBindingSource.DataMember = "produtos"
        Me.produtosBindingSource.DataSource = Me.ProdutosDataSet
        '
        'QtddeVendidaDataTableAdapter
        '
        Me.QtddeVendidaDataTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.QtddeVendidaDataBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MercadoVB.RelProduVend.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 26)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(776, 397)
        Me.ReportViewer1.TabIndex = 163
        '
        'FrmRelProdVend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 434)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.lblFinal)
        Me.Controls.Add(Me.lblInicio)
        Me.Controls.Add(Me.dtpDataFinal)
        Me.Controls.Add(Me.dtpDataInicial)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRelProdVend"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Produtos mais Vendidos"
        CType(Me.QtddeVendidaDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdutosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QtddeVendidaDataBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.produtosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFinal As Label
    Friend WithEvents lblInicio As Label
    Friend WithEvents dtpDataFinal As DateTimePicker
    Friend WithEvents dtpDataInicial As DateTimePicker
    Friend WithEvents produtosBindingSource As BindingSource
    Friend WithEvents ProdutosDataSet As ProdutosDataSet
    Friend WithEvents QtddeVendidaDataBindingSource As BindingSource
    Friend WithEvents QtddeVendidaDataTableAdapter As ProdutosDataSetTableAdapters.QtddeVendidaDataTableAdapter
    Friend WithEvents QtddeVendidaDataBindingSource1 As BindingSource
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
