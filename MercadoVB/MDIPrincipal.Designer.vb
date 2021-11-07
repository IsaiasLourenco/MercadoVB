<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MDIPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIPrincipal))
        Me.StatusPincipal = New System.Windows.Forms.StatusStrip()
        Me.sslBemvindo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.sslUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.sslData = New System.Windows.Forms.ToolStripStatusLabel()
        Me.sslHora = New System.Windows.Forms.ToolStripStatusLabel()
        Me.sslNivelEstoque = New System.Windows.Forms.ToolStripStatusLabel()
        Me.sslNivel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.menuCadastros = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuCadastroProdutos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuCadastroFuncionarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuCadastroClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuCadastroFornecedores = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstoqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntradaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NíveisDeProdutosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuVendas = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuVendasRegistroDeVendas = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuVendasDoDiaAbreFechaCaixa = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuVendasDetalhesDasVendas = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuVendasSangria = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuRelatorios = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuRelatorioDeProdutos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuRelatorioDeVendas = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuRelatorioDoCaixa = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatórioDeEntradaSaídaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdutosComNívelCríticoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdutosMaisVendidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendasPorFuncionáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuSair = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuSairLogOff = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuSairSair = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusPincipal.SuspendLayout()
        Me.MenuPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusPincipal
        '
        Me.StatusPincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sslBemvindo, Me.sslUsuario, Me.sslData, Me.sslHora, Me.sslNivelEstoque, Me.sslNivel})
        Me.StatusPincipal.Location = New System.Drawing.Point(0, 431)
        Me.StatusPincipal.Name = "StatusPincipal"
        Me.StatusPincipal.Size = New System.Drawing.Size(632, 22)
        Me.StatusPincipal.TabIndex = 7
        Me.StatusPincipal.Text = "StatusStrip"
        '
        'sslBemvindo
        '
        Me.sslBemvindo.Name = "sslBemvindo"
        Me.sslBemvindo.Size = New System.Drawing.Size(65, 17)
        Me.sslBemvindo.Text = "Bem Vindo"
        '
        'sslUsuario
        '
        Me.sslUsuario.Name = "sslUsuario"
        Me.sslUsuario.Size = New System.Drawing.Size(12, 17)
        Me.sslUsuario.Text = "-"
        '
        'sslData
        '
        Me.sslData.Name = "sslData"
        Me.sslData.Size = New System.Drawing.Size(12, 17)
        Me.sslData.Text = "-"
        '
        'sslHora
        '
        Me.sslHora.Name = "sslHora"
        Me.sslHora.Size = New System.Drawing.Size(12, 17)
        Me.sslHora.Text = "-"
        '
        'sslNivelEstoque
        '
        Me.sslNivelEstoque.Name = "sslNivelEstoque"
        Me.sslNivelEstoque.Size = New System.Drawing.Size(101, 17)
        Me.sslNivelEstoque.Text = "Níveis do Estoque"
        '
        'sslNivel
        '
        Me.sslNivel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.sslNivel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.sslNivel.Name = "sslNivel"
        Me.sslNivel.Size = New System.Drawing.Size(41, 17)
        Me.sslNivel.Text = "BAIXO"
        '
        'MenuPrincipal
        '
        Me.MenuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuCadastros, Me.EstoqueToolStripMenuItem, Me.menuVendas, Me.menuRelatorios, Me.menuSair})
        Me.MenuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.MenuPrincipal.Name = "MenuPrincipal"
        Me.MenuPrincipal.Size = New System.Drawing.Size(632, 24)
        Me.MenuPrincipal.TabIndex = 10
        '
        'menuCadastros
        '
        Me.menuCadastros.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuCadastroProdutos, Me.menuCadastroFuncionarios, Me.menuCadastroClientes, Me.menuCadastroFornecedores})
        Me.menuCadastros.Image = Global.MercadoVB.My.Resources.Resources.bt_novo
        Me.menuCadastros.Name = "menuCadastros"
        Me.menuCadastros.Size = New System.Drawing.Size(87, 20)
        Me.menuCadastros.Text = "Cadastros"
        '
        'menuCadastroProdutos
        '
        Me.menuCadastroProdutos.Image = Global.MercadoVB.My.Resources.Resources.Shopping_Full
        Me.menuCadastroProdutos.Name = "menuCadastroProdutos"
        Me.menuCadastroProdutos.Size = New System.Drawing.Size(145, 22)
        Me.menuCadastroProdutos.Text = "Produtos"
        '
        'menuCadastroFuncionarios
        '
        Me.menuCadastroFuncionarios.Enabled = False
        Me.menuCadastroFuncionarios.Image = Global.MercadoVB.My.Resources.Resources.users
        Me.menuCadastroFuncionarios.Name = "menuCadastroFuncionarios"
        Me.menuCadastroFuncionarios.Size = New System.Drawing.Size(145, 22)
        Me.menuCadastroFuncionarios.Text = "Funcionários"
        '
        'menuCadastroClientes
        '
        Me.menuCadastroClientes.Image = Global.MercadoVB.My.Resources.Resources.iconfinder_clients_43573
        Me.menuCadastroClientes.Name = "menuCadastroClientes"
        Me.menuCadastroClientes.Size = New System.Drawing.Size(145, 22)
        Me.menuCadastroClientes.Text = "Clientes"
        '
        'menuCadastroFornecedores
        '
        Me.menuCadastroFornecedores.Image = Global.MercadoVB.My.Resources.Resources.fornecedores
        Me.menuCadastroFornecedores.Name = "menuCadastroFornecedores"
        Me.menuCadastroFornecedores.Size = New System.Drawing.Size(145, 22)
        Me.menuCadastroFornecedores.Text = "Fornecedores"
        '
        'EstoqueToolStripMenuItem
        '
        Me.EstoqueToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntradaToolStripMenuItem, Me.ConsultasToolStripMenuItem, Me.NíveisDeProdutosToolStripMenuItem})
        Me.EstoqueToolStripMenuItem.Image = CType(resources.GetObject("EstoqueToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EstoqueToolStripMenuItem.Name = "EstoqueToolStripMenuItem"
        Me.EstoqueToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.EstoqueToolStripMenuItem.Text = "Estoque"
        '
        'EntradaToolStripMenuItem
        '
        Me.EntradaToolStripMenuItem.Image = CType(resources.GetObject("EntradaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EntradaToolStripMenuItem.Name = "EntradaToolStripMenuItem"
        Me.EntradaToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.EntradaToolStripMenuItem.Text = "Entrada/Saída"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.Image = CType(resources.GetObject("ConsultasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'NíveisDeProdutosToolStripMenuItem
        '
        Me.NíveisDeProdutosToolStripMenuItem.Image = CType(resources.GetObject("NíveisDeProdutosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NíveisDeProdutosToolStripMenuItem.Name = "NíveisDeProdutosToolStripMenuItem"
        Me.NíveisDeProdutosToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.NíveisDeProdutosToolStripMenuItem.Text = "Níveis Baixos"
        '
        'menuVendas
        '
        Me.menuVendas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuVendasRegistroDeVendas, Me.menuVendasDoDiaAbreFechaCaixa, Me.menuVendasDetalhesDasVendas, Me.menuVendasSangria})
        Me.menuVendas.Image = Global.MercadoVB.My.Resources.Resources.ico_caixa
        Me.menuVendas.Name = "menuVendas"
        Me.menuVendas.Size = New System.Drawing.Size(72, 20)
        Me.menuVendas.Text = "Vendas"
        '
        'menuVendasRegistroDeVendas
        '
        Me.menuVendasRegistroDeVendas.Image = Global.MercadoVB.My.Resources.Resources.ico_reg_venda
        Me.menuVendasRegistroDeVendas.Name = "menuVendasRegistroDeVendas"
        Me.menuVendasRegistroDeVendas.Size = New System.Drawing.Size(244, 22)
        Me.menuVendasRegistroDeVendas.Text = "Registro de Vendas"
        '
        'menuVendasDoDiaAbreFechaCaixa
        '
        Me.menuVendasDoDiaAbreFechaCaixa.Image = Global.MercadoVB.My.Resources.Resources.caixa2
        Me.menuVendasDoDiaAbreFechaCaixa.Name = "menuVendasDoDiaAbreFechaCaixa"
        Me.menuVendasDoDiaAbreFechaCaixa.Size = New System.Drawing.Size(244, 22)
        Me.menuVendasDoDiaAbreFechaCaixa.Text = "Vendas do Dia/Abre Fecha Caixa"
        '
        'menuVendasDetalhesDasVendas
        '
        Me.menuVendasDetalhesDasVendas.Image = Global.MercadoVB.My.Resources.Resources.venda_rapida
        Me.menuVendasDetalhesDasVendas.Name = "menuVendasDetalhesDasVendas"
        Me.menuVendasDetalhesDasVendas.Size = New System.Drawing.Size(244, 22)
        Me.menuVendasDetalhesDasVendas.Text = "Detalhes das Vendas"
        '
        'menuVendasSangria
        '
        Me.menuVendasSangria.Image = Global.MercadoVB.My.Resources.Resources.sangria
        Me.menuVendasSangria.Name = "menuVendasSangria"
        Me.menuVendasSangria.Size = New System.Drawing.Size(244, 22)
        Me.menuVendasSangria.Text = "Sangria"
        '
        'menuRelatorios
        '
        Me.menuRelatorios.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuRelatorioDeProdutos, Me.menuRelatorioDeVendas, Me.menuRelatorioDoCaixa, Me.RelatórioDeEntradaSaídaToolStripMenuItem, Me.ProdutosComNívelCríticoToolStripMenuItem, Me.ProdutosMaisVendidosToolStripMenuItem, Me.VendasPorFuncionáriosToolStripMenuItem})
        Me.menuRelatorios.Image = Global.MercadoVB.My.Resources.Resources.rel21
        Me.menuRelatorios.Name = "menuRelatorios"
        Me.menuRelatorios.Size = New System.Drawing.Size(87, 20)
        Me.menuRelatorios.Text = "Relatórios"
        '
        'menuRelatorioDeProdutos
        '
        Me.menuRelatorioDeProdutos.Image = Global.MercadoVB.My.Resources.Resources.relatorio_produtos
        Me.menuRelatorioDeProdutos.Name = "menuRelatorioDeProdutos"
        Me.menuRelatorioDeProdutos.Size = New System.Drawing.Size(219, 22)
        Me.menuRelatorioDeProdutos.Text = "Relatório de Produtos"
        '
        'menuRelatorioDeVendas
        '
        Me.menuRelatorioDeVendas.Image = Global.MercadoVB.My.Resources.Resources.relatorio
        Me.menuRelatorioDeVendas.Name = "menuRelatorioDeVendas"
        Me.menuRelatorioDeVendas.Size = New System.Drawing.Size(219, 22)
        Me.menuRelatorioDeVendas.Text = "Relatório de Vendas"
        '
        'menuRelatorioDoCaixa
        '
        Me.menuRelatorioDoCaixa.Image = CType(resources.GetObject("menuRelatorioDoCaixa.Image"), System.Drawing.Image)
        Me.menuRelatorioDoCaixa.Name = "menuRelatorioDoCaixa"
        Me.menuRelatorioDoCaixa.Size = New System.Drawing.Size(219, 22)
        Me.menuRelatorioDoCaixa.Text = "Relatório do Caixa"
        '
        'RelatórioDeEntradaSaídaToolStripMenuItem
        '
        Me.RelatórioDeEntradaSaídaToolStripMenuItem.Image = CType(resources.GetObject("RelatórioDeEntradaSaídaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RelatórioDeEntradaSaídaToolStripMenuItem.Name = "RelatórioDeEntradaSaídaToolStripMenuItem"
        Me.RelatórioDeEntradaSaídaToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.RelatórioDeEntradaSaídaToolStripMenuItem.Text = "Relatório de Entrada / Saída"
        '
        'ProdutosComNívelCríticoToolStripMenuItem
        '
        Me.ProdutosComNívelCríticoToolStripMenuItem.Image = CType(resources.GetObject("ProdutosComNívelCríticoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProdutosComNívelCríticoToolStripMenuItem.Name = "ProdutosComNívelCríticoToolStripMenuItem"
        Me.ProdutosComNívelCríticoToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.ProdutosComNívelCríticoToolStripMenuItem.Text = "Produtos com Nível Crítico"
        '
        'ProdutosMaisVendidosToolStripMenuItem
        '
        Me.ProdutosMaisVendidosToolStripMenuItem.Image = CType(resources.GetObject("ProdutosMaisVendidosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProdutosMaisVendidosToolStripMenuItem.Name = "ProdutosMaisVendidosToolStripMenuItem"
        Me.ProdutosMaisVendidosToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.ProdutosMaisVendidosToolStripMenuItem.Text = "Produtos Mais Vendidos"
        '
        'VendasPorFuncionáriosToolStripMenuItem
        '
        Me.VendasPorFuncionáriosToolStripMenuItem.Name = "VendasPorFuncionáriosToolStripMenuItem"
        Me.VendasPorFuncionáriosToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.VendasPorFuncionáriosToolStripMenuItem.Text = "Vendas por Funcionários"
        Me.VendasPorFuncionáriosToolStripMenuItem.Visible = False
        '
        'menuSair
        '
        Me.menuSair.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuSairLogOff, Me.menuSairSair})
        Me.menuSair.Image = Global.MercadoVB.My.Resources.Resources.btn_sair
        Me.menuSair.Name = "menuSair"
        Me.menuSair.Size = New System.Drawing.Size(54, 20)
        Me.menuSair.Text = "Sair"
        '
        'menuSairLogOff
        '
        Me.menuSairLogOff.Image = Global.MercadoVB.My.Resources.Resources.Trocar
        Me.menuSairLogOff.Name = "menuSairLogOff"
        Me.menuSairLogOff.Size = New System.Drawing.Size(114, 22)
        Me.menuSairLogOff.Text = "Log Off"
        '
        'menuSairSair
        '
        Me.menuSairSair.Image = Global.MercadoVB.My.Resources.Resources.logoff
        Me.menuSairSair.Name = "menuSairSair"
        Me.menuSairSair.Size = New System.Drawing.Size(114, 22)
        Me.menuSairSair.Text = "Sair"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'MDIPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.StatusPincipal)
        Me.Controls.Add(Me.MenuPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuPrincipal
        Me.Name = "MDIPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Vendas, Controle de Estoque e Fluxo de Caixa"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusPincipal.ResumeLayout(False)
        Me.StatusPincipal.PerformLayout()
        Me.MenuPrincipal.ResumeLayout(False)
        Me.MenuPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusPincipal As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents sslBemvindo As ToolStripStatusLabel
    Friend WithEvents sslUsuario As ToolStripStatusLabel
    Friend WithEvents sslData As ToolStripStatusLabel
    Friend WithEvents sslHora As ToolStripStatusLabel
    Friend WithEvents MenuPrincipal As MenuStrip
    Friend WithEvents menuCadastros As ToolStripMenuItem
    Friend WithEvents menuCadastroProdutos As ToolStripMenuItem
    Friend WithEvents menuCadastroFuncionarios As ToolStripMenuItem
    Friend WithEvents menuCadastroClientes As ToolStripMenuItem
    Friend WithEvents menuCadastroFornecedores As ToolStripMenuItem
    Friend WithEvents menuVendas As ToolStripMenuItem
    Friend WithEvents menuVendasRegistroDeVendas As ToolStripMenuItem
    Friend WithEvents menuVendasDoDiaAbreFechaCaixa As ToolStripMenuItem
    Friend WithEvents menuVendasDetalhesDasVendas As ToolStripMenuItem
    Friend WithEvents menuVendasSangria As ToolStripMenuItem
    Friend WithEvents menuRelatorios As ToolStripMenuItem
    Friend WithEvents menuRelatorioDeProdutos As ToolStripMenuItem
    Friend WithEvents menuRelatorioDeVendas As ToolStripMenuItem
    Friend WithEvents menuSair As ToolStripMenuItem
    Friend WithEvents menuSairLogOff As ToolStripMenuItem
    Friend WithEvents menuSairSair As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents menuRelatorioDoCaixa As ToolStripMenuItem
    Friend WithEvents EstoqueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntradaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelatórioDeEntradaSaídaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NíveisDeProdutosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProdutosComNívelCríticoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents sslNivelEstoque As ToolStripStatusLabel
    Friend WithEvents sslNivel As ToolStripStatusLabel
    Friend WithEvents ProdutosMaisVendidosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VendasPorFuncionáriosToolStripMenuItem As ToolStripMenuItem
End Class
