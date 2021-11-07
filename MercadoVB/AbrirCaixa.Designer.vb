<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AbrirCaixa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AbrirCaixa))
        Me.txtValorAbertura = New System.Windows.Forms.TextBox()
        Me.lblValorAbertura = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.btnGravar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtValorAbertura
        '
        Me.txtValorAbertura.Location = New System.Drawing.Point(106, 13)
        Me.txtValorAbertura.Name = "txtValorAbertura"
        Me.txtValorAbertura.Size = New System.Drawing.Size(132, 20)
        Me.txtValorAbertura.TabIndex = 0
        '
        'lblValorAbertura
        '
        Me.lblValorAbertura.AutoSize = True
        Me.lblValorAbertura.Location = New System.Drawing.Point(9, 16)
        Me.lblValorAbertura.Name = "lblValorAbertura"
        Me.lblValorAbertura.Size = New System.Drawing.Size(92, 13)
        Me.lblValorAbertura.TabIndex = 134
        Me.lblValorAbertura.Text = "Valor da Abertura:"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(725, -21)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(164, 20)
        Me.txtBuscar.TabIndex = 122
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(675, -20)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(43, 13)
        Me.lblBuscar.TabIndex = 121
        Me.lblBuscar.Text = "Buscar:"
        '
        'btnGravar
        '
        Me.btnGravar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGravar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGravar.Image = CType(resources.GetObject("btnGravar.Image"), System.Drawing.Image)
        Me.btnGravar.Location = New System.Drawing.Point(260, 13)
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(121, 94)
        Me.btnGravar.TabIndex = 1
        Me.btnGravar.Text = "Gravar"
        Me.btnGravar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGravar.UseVisualStyleBackColor = True
        '
        'AbrirCaixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(395, 112)
        Me.Controls.Add(Me.txtValorAbertura)
        Me.Controls.Add(Me.lblValorAbertura)
        Me.Controls.Add(Me.btnGravar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.lblBuscar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AbrirCaixa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Abrir o Caixa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtValorAbertura As TextBox
    Friend WithEvents lblValorAbertura As Label
    Friend WithEvents btnGravar As Button
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents lblBuscar As Label
End Class
