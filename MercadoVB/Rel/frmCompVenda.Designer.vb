<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCompVenda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompVenda))
        Me.ComprovanteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VendasDataSet = New MercadoVB.VendasDataSet()
        Me.rpvComprovante = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ComprovanteTableAdapter = New MercadoVB.VendasDataSetTableAdapters.ComprovanteTableAdapter()
        CType(Me.ComprovanteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComprovanteBindingSource
        '
        Me.ComprovanteBindingSource.DataMember = "Comprovante"
        Me.ComprovanteBindingSource.DataSource = Me.VendasDataSet
        '
        'VendasDataSet
        '
        Me.VendasDataSet.DataSetName = "VendasDataSet"
        Me.VendasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rpvComprovante
        '
        Me.rpvComprovante.BackColor = System.Drawing.SystemColors.Window
        Me.rpvComprovante.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ComprovanteBindingSource
        Me.rpvComprovante.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rpvComprovante.LocalReport.ReportEmbeddedResource = "MercadoVB.CompVenda.rdlc"
        Me.rpvComprovante.Location = New System.Drawing.Point(0, 0)
        Me.rpvComprovante.Name = "rpvComprovante"
        Me.rpvComprovante.ServerReport.BearerToken = Nothing
        Me.rpvComprovante.Size = New System.Drawing.Size(630, 450)
        Me.rpvComprovante.TabIndex = 0
        '
        'ComprovanteTableAdapter
        '
        Me.ComprovanteTableAdapter.ClearBeforeFill = True
        '
        'frmCompVenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 450)
        Me.Controls.Add(Me.rpvComprovante)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCompVenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comprovante de Venda"
        CType(Me.ComprovanteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rpvComprovante As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ComprovanteBindingSource As BindingSource
    Friend WithEvents VendasDataSet As VendasDataSet
    Friend WithEvents ComprovanteTableAdapter As VendasDataSetTableAdapters.ComprovanteTableAdapter
End Class
