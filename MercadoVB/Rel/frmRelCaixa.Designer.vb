<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelCaixa
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRelCaixa))
        Me.CaixaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CaixaVBDataSet = New MercadoVB.CaixaVBDataSet()
        Me.lblFuncionario = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.cmbFuncionario = New System.Windows.Forms.ComboBox()
        Me.dtpRelatorioCaixa = New System.Windows.Forms.DateTimePicker()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.CaixaTableAdapter = New MercadoVB.CaixaVBDataSetTableAdapters.caixaTableAdapter()
        Me.VendasDataSet = New MercadoVB.VendasDataSet()
        Me.ListaDeVendasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Lista_de_VendasTableAdapter = New MercadoVB.VendasDataSetTableAdapters.Lista_de_VendasTableAdapter()
        CType(Me.CaixaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CaixaVBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaDeVendasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CaixaBindingSource
        '
        Me.CaixaBindingSource.DataMember = "caixa"
        Me.CaixaBindingSource.DataSource = Me.CaixaVBDataSet
        '
        'CaixaVBDataSet
        '
        Me.CaixaVBDataSet.DataSetName = "CaixaVBDataSet"
        Me.CaixaVBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblFuncionario
        '
        Me.lblFuncionario.AutoSize = True
        Me.lblFuncionario.Location = New System.Drawing.Point(529, 6)
        Me.lblFuncionario.Name = "lblFuncionario"
        Me.lblFuncionario.Size = New System.Drawing.Size(65, 13)
        Me.lblFuncionario.TabIndex = 0
        Me.lblFuncionario.Text = "Funcionário:"
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(719, 6)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(33, 13)
        Me.lblData.TabIndex = 1
        Me.lblData.Text = "Data:"
        '
        'cmbFuncionario
        '
        Me.cmbFuncionario.FormattingEnabled = True
        Me.cmbFuncionario.Location = New System.Drawing.Point(592, 4)
        Me.cmbFuncionario.Name = "cmbFuncionario"
        Me.cmbFuncionario.Size = New System.Drawing.Size(121, 21)
        Me.cmbFuncionario.TabIndex = 2
        '
        'dtpRelatorioCaixa
        '
        Me.dtpRelatorioCaixa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRelatorioCaixa.Location = New System.Drawing.Point(759, 4)
        Me.dtpRelatorioCaixa.Name = "dtpRelatorioCaixa"
        Me.dtpRelatorioCaixa.Size = New System.Drawing.Size(132, 20)
        Me.dtpRelatorioCaixa.TabIndex = 3
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.CaixaBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.ListaDeVendasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MercadoVB.RelCaixa.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 31)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(882, 536)
        Me.ReportViewer1.TabIndex = 4
        '
        'CaixaTableAdapter
        '
        Me.CaixaTableAdapter.ClearBeforeFill = True
        '
        'VendasDataSet
        '
        Me.VendasDataSet.DataSetName = "VendasDataSet"
        Me.VendasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListaDeVendasBindingSource
        '
        Me.ListaDeVendasBindingSource.DataMember = "Lista de Vendas"
        Me.ListaDeVendasBindingSource.DataSource = Me.VendasDataSet
        '
        'Lista_de_VendasTableAdapter
        '
        Me.Lista_de_VendasTableAdapter.ClearBeforeFill = True
        '
        'frmRelCaixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(906, 579)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.dtpRelatorioCaixa)
        Me.Controls.Add(Me.cmbFuncionario)
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.lblFuncionario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRelCaixa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reatório do Caixa"
        CType(Me.CaixaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CaixaVBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaDeVendasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFuncionario As Label
    Friend WithEvents lblData As Label
    Friend WithEvents cmbFuncionario As ComboBox
    Friend WithEvents dtpRelatorioCaixa As DateTimePicker
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CaixaBindingSource As BindingSource
    Friend WithEvents CaixaVBDataSet As CaixaVBDataSet
    Friend WithEvents CaixaTableAdapter As CaixaVBDataSetTableAdapters.caixaTableAdapter
    Friend WithEvents ListaDeVendasBindingSource As BindingSource
    Friend WithEvents VendasDataSet As VendasDataSet
    Friend WithEvents Lista_de_VendasTableAdapter As VendasDataSetTableAdapters.Lista_de_VendasTableAdapter
End Class
