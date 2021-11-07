<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelProdutos
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRelProdutos))
        Me.rpvProdutos = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.produtosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProdutosDataSet = New MercadoVB.ProdutosDataSet()
        Me.produtosTableAdapter = New MercadoVB.ProdutosDataSetTableAdapters.produtosTableAdapter()
        CType(Me.produtosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdutosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rpvProdutos
        '
        Me.rpvProdutos.BackColor = System.Drawing.SystemColors.Window
        Me.rpvProdutos.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.produtosBindingSource
        Me.rpvProdutos.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rpvProdutos.LocalReport.ReportEmbeddedResource = "MercadoVB.RelProdutos.rdlc"
        Me.rpvProdutos.Location = New System.Drawing.Point(0, 0)
        Me.rpvProdutos.Name = "rpvProdutos"
        Me.rpvProdutos.ServerReport.BearerToken = Nothing
        Me.rpvProdutos.Size = New System.Drawing.Size(947, 450)
        Me.rpvProdutos.TabIndex = 0
        '
        'produtosBindingSource
        '
        Me.produtosBindingSource.DataMember = "produtos"
        Me.produtosBindingSource.DataSource = Me.ProdutosDataSet
        '
        'ProdutosDataSet
        '
        Me.ProdutosDataSet.DataSetName = "ProdutosDataSet"
        Me.ProdutosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'produtosTableAdapter
        '
        Me.produtosTableAdapter.ClearBeforeFill = True
        '
        'frmRelProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(947, 450)
        Me.Controls.Add(Me.rpvProdutos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRelProdutos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Produtos"
        CType(Me.produtosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdutosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents produtosBindingSource As BindingSource
    Friend WithEvents ProdutosDataSet As ProdutosDataSet
    Friend WithEvents produtosTableAdapter As ProdutosDataSetTableAdapters.produtosTableAdapter
    Friend WithEvents rpvProdutos As Microsoft.Reporting.WinForms.ReportViewer
End Class
