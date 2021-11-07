<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frnRelVenda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frnRelVenda))
        Me.ListaDeVendasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VendasDataSet = New MercadoVB.VendasDataSet()
        Me.rpvRelVendas = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dtpData = New System.Windows.Forms.DateTimePicker()
        Me.lblData = New System.Windows.Forms.Label()
        Me.vendasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.vendasTableAdapter = New MercadoVB.VendasDataSetTableAdapters.vendasTableAdapter()
        Me.Lista_de_VendasTableAdapter = New MercadoVB.VendasDataSetTableAdapters.Lista_de_VendasTableAdapter()
        Me.lblFuncionario = New System.Windows.Forms.Label()
        Me.cmbFuncionario = New System.Windows.Forms.ComboBox()
        CType(Me.ListaDeVendasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vendasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaDeVendasBindingSource
        '
        Me.ListaDeVendasBindingSource.DataMember = "Lista de Vendas"
        Me.ListaDeVendasBindingSource.DataSource = Me.VendasDataSet
        '
        'VendasDataSet
        '
        Me.VendasDataSet.DataSetName = "VendasDataSet"
        Me.VendasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rpvRelVendas
        '
        Me.rpvRelVendas.BackColor = System.Drawing.SystemColors.Window
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ListaDeVendasBindingSource
        Me.rpvRelVendas.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rpvRelVendas.LocalReport.ReportEmbeddedResource = "MercadoVB.RelVenda.rdlc"
        Me.rpvRelVendas.Location = New System.Drawing.Point(0, 37)
        Me.rpvRelVendas.Name = "rpvRelVendas"
        Me.rpvRelVendas.ServerReport.BearerToken = Nothing
        Me.rpvRelVendas.Size = New System.Drawing.Size(836, 413)
        Me.rpvRelVendas.TabIndex = 0
        '
        'dtpData
        '
        Me.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpData.Location = New System.Drawing.Point(736, 11)
        Me.dtpData.Name = "dtpData"
        Me.dtpData.Size = New System.Drawing.Size(100, 20)
        Me.dtpData.TabIndex = 1
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(654, 15)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(81, 13)
        Me.lblData.TabIndex = 2
        Me.lblData.Text = "Escolha a data:"
        '
        'vendasBindingSource
        '
        Me.vendasBindingSource.DataMember = "vendas"
        Me.vendasBindingSource.DataSource = Me.VendasDataSet
        '
        'vendasTableAdapter
        '
        Me.vendasTableAdapter.ClearBeforeFill = True
        '
        'Lista_de_VendasTableAdapter
        '
        Me.Lista_de_VendasTableAdapter.ClearBeforeFill = True
        '
        'lblFuncionario
        '
        Me.lblFuncionario.AutoSize = True
        Me.lblFuncionario.Location = New System.Drawing.Point(420, 15)
        Me.lblFuncionario.Name = "lblFuncionario"
        Me.lblFuncionario.Size = New System.Drawing.Size(112, 13)
        Me.lblFuncionario.TabIndex = 3
        Me.lblFuncionario.Text = "Escolha o funcionário:"
        '
        'cmbFuncionario
        '
        Me.cmbFuncionario.FormattingEnabled = True
        Me.cmbFuncionario.Location = New System.Drawing.Point(533, 10)
        Me.cmbFuncionario.Name = "cmbFuncionario"
        Me.cmbFuncionario.Size = New System.Drawing.Size(112, 21)
        Me.cmbFuncionario.TabIndex = 4
        '
        'frnRelVenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(840, 450)
        Me.Controls.Add(Me.cmbFuncionario)
        Me.Controls.Add(Me.lblFuncionario)
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.dtpData)
        Me.Controls.Add(Me.rpvRelVendas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frnRelVenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Vendas por Data"
        CType(Me.ListaDeVendasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vendasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rpvRelVendas As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents vendasBindingSource As BindingSource
    Friend WithEvents VendasDataSet As VendasDataSet
    Friend WithEvents vendasTableAdapter As VendasDataSetTableAdapters.vendasTableAdapter
    Friend WithEvents ListaDeVendasBindingSource As BindingSource
    Friend WithEvents Lista_de_VendasTableAdapter As VendasDataSetTableAdapters.Lista_de_VendasTableAdapter
    Friend WithEvents dtpData As DateTimePicker
    Friend WithEvents lblData As Label
    Friend WithEvents lblFuncionario As Label
    Friend WithEvents cmbFuncionario As ComboBox
End Class
