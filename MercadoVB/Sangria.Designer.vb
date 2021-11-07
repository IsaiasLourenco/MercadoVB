<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sangria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sangria))
        Me.txtValorSangria = New System.Windows.Forms.TextBox()
        Me.lblValorSangria = New System.Windows.Forms.Label()
        Me.btnGravar = New System.Windows.Forms.Button()
        Me.lblTotalSangria = New System.Windows.Forms.Label()
        Me.lblValorTotalSangria = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtValorSangria
        '
        Me.txtValorSangria.Location = New System.Drawing.Point(104, 17)
        Me.txtValorSangria.Name = "txtValorSangria"
        Me.txtValorSangria.Size = New System.Drawing.Size(132, 20)
        Me.txtValorSangria.TabIndex = 0
        '
        'lblValorSangria
        '
        Me.lblValorSangria.AutoSize = True
        Me.lblValorSangria.ForeColor = System.Drawing.Color.Black
        Me.lblValorSangria.Location = New System.Drawing.Point(13, 22)
        Me.lblValorSangria.Name = "lblValorSangria"
        Me.lblValorSangria.Size = New System.Drawing.Size(88, 13)
        Me.lblValorSangria.TabIndex = 2
        Me.lblValorSangria.Text = "Valor da Sangria:"
        '
        'btnGravar
        '
        Me.btnGravar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGravar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGravar.ForeColor = System.Drawing.Color.Black
        Me.btnGravar.Image = CType(resources.GetObject("btnGravar.Image"), System.Drawing.Image)
        Me.btnGravar.Location = New System.Drawing.Point(251, 6)
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(121, 94)
        Me.btnGravar.TabIndex = 3
        Me.btnGravar.Text = "Gravar"
        Me.btnGravar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGravar.UseVisualStyleBackColor = True
        '
        'lblTotalSangria
        '
        Me.lblTotalSangria.AutoSize = True
        Me.lblTotalSangria.ForeColor = System.Drawing.Color.Black
        Me.lblTotalSangria.Location = New System.Drawing.Point(12, 58)
        Me.lblTotalSangria.Name = "lblTotalSangria"
        Me.lblTotalSangria.Size = New System.Drawing.Size(88, 13)
        Me.lblTotalSangria.TabIndex = 4
        Me.lblTotalSangria.Text = "Total da Sangria:"
        '
        'lblValorTotalSangria
        '
        Me.lblValorTotalSangria.AutoSize = True
        Me.lblValorTotalSangria.ForeColor = System.Drawing.Color.Black
        Me.lblValorTotalSangria.Location = New System.Drawing.Point(101, 58)
        Me.lblValorTotalSangria.Name = "lblValorTotalSangria"
        Me.lblValorTotalSangria.Size = New System.Drawing.Size(10, 13)
        Me.lblValorTotalSangria.TabIndex = 5
        Me.lblValorTotalSangria.Text = "-"
        '
        'Sangria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(384, 107)
        Me.Controls.Add(Me.lblValorTotalSangria)
        Me.Controls.Add(Me.lblTotalSangria)
        Me.Controls.Add(Me.btnGravar)
        Me.Controls.Add(Me.lblValorSangria)
        Me.Controls.Add(Me.txtValorSangria)
        Me.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Sangria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sangria"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtValorSangria As TextBox
    Friend WithEvents lblValorSangria As Label
    Friend WithEvents btnGravar As Button
    Friend WithEvents lblTotalSangria As Label
    Friend WithEvents lblValorTotalSangria As Label
End Class
