<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menuCadastros = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuCadastroProdutos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuCadastroFuncionarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuVendas = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuRegistroVendas = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuListaVendas = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuSair = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuSairSai = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuCadastros, Me.menuVendas, Me.menuSair})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menuCadastros
        '
        Me.menuCadastros.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuCadastroProdutos, Me.menuCadastroFuncionarios})
        Me.menuCadastros.Image = CType(resources.GetObject("menuCadastros.Image"), System.Drawing.Image)
        Me.menuCadastros.Name = "menuCadastros"
        Me.menuCadastros.Size = New System.Drawing.Size(87, 20)
        Me.menuCadastros.Text = "Cadastros"
        '
        'menuCadastroProdutos
        '
        Me.menuCadastroProdutos.Image = CType(resources.GetObject("menuCadastroProdutos.Image"), System.Drawing.Image)
        Me.menuCadastroProdutos.Name = "menuCadastroProdutos"
        Me.menuCadastroProdutos.Size = New System.Drawing.Size(180, 22)
        Me.menuCadastroProdutos.Text = "Produtos"
        '
        'menuCadastroFuncionarios
        '
        Me.menuCadastroFuncionarios.Image = CType(resources.GetObject("menuCadastroFuncionarios.Image"), System.Drawing.Image)
        Me.menuCadastroFuncionarios.Name = "menuCadastroFuncionarios"
        Me.menuCadastroFuncionarios.Size = New System.Drawing.Size(180, 22)
        Me.menuCadastroFuncionarios.Text = "Funcionários"
        '
        'menuVendas
        '
        Me.menuVendas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuRegistroVendas, Me.menuListaVendas})
        Me.menuVendas.Image = CType(resources.GetObject("menuVendas.Image"), System.Drawing.Image)
        Me.menuVendas.Name = "menuVendas"
        Me.menuVendas.Size = New System.Drawing.Size(72, 20)
        Me.menuVendas.Text = "Vendas"
        '
        'menuRegistroVendas
        '
        Me.menuRegistroVendas.Image = CType(resources.GetObject("menuRegistroVendas.Image"), System.Drawing.Image)
        Me.menuRegistroVendas.Name = "menuRegistroVendas"
        Me.menuRegistroVendas.Size = New System.Drawing.Size(180, 22)
        Me.menuRegistroVendas.Text = "Registro de Venda"
        '
        'menuListaVendas
        '
        Me.menuListaVendas.Image = CType(resources.GetObject("menuListaVendas.Image"), System.Drawing.Image)
        Me.menuListaVendas.Name = "menuListaVendas"
        Me.menuListaVendas.Size = New System.Drawing.Size(180, 22)
        Me.menuListaVendas.Text = "Lista de Vendas"
        '
        'menuSair
        '
        Me.menuSair.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuSairSai})
        Me.menuSair.Image = CType(resources.GetObject("menuSair.Image"), System.Drawing.Image)
        Me.menuSair.Name = "menuSair"
        Me.menuSair.Size = New System.Drawing.Size(54, 20)
        Me.menuSair.Text = "Sair"
        '
        'menuSairSai
        '
        Me.menuSairSai.Image = CType(resources.GetObject("menuSairSai.Image"), System.Drawing.Image)
        Me.menuSairSai.Name = "menuSairSai"
        Me.menuSairSai.Size = New System.Drawing.Size(180, 22)
        Me.menuSairSai.Text = "Sair"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents menuCadastros As ToolStripMenuItem
    Friend WithEvents menuCadastroProdutos As ToolStripMenuItem
    Friend WithEvents menuCadastroFuncionarios As ToolStripMenuItem
    Friend WithEvents menuVendas As ToolStripMenuItem
    Friend WithEvents menuRegistroVendas As ToolStripMenuItem
    Friend WithEvents menuListaVendas As ToolStripMenuItem
    Friend WithEvents menuSair As ToolStripMenuItem
    Friend WithEvents menuSairSai As ToolStripMenuItem
End Class
