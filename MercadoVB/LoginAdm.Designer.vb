<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginAdm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginAdm))
        Me.txtSenhaAdm = New System.Windows.Forms.TextBox()
        Me.btnAcessoAdm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtSenhaAdm
        '
        Me.txtSenhaAdm.Location = New System.Drawing.Point(13, 13)
        Me.txtSenhaAdm.Name = "txtSenhaAdm"
        Me.txtSenhaAdm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenhaAdm.Size = New System.Drawing.Size(100, 20)
        Me.txtSenhaAdm.TabIndex = 0
        '
        'btnAcessoAdm
        '
        Me.btnAcessoAdm.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnAcessoAdm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAcessoAdm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAcessoAdm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAcessoAdm.Location = New System.Drawing.Point(130, 13)
        Me.btnAcessoAdm.Name = "btnAcessoAdm"
        Me.btnAcessoAdm.Size = New System.Drawing.Size(85, 20)
        Me.btnAcessoAdm.TabIndex = 1
        Me.btnAcessoAdm.Text = "Acessar"
        Me.btnAcessoAdm.UseVisualStyleBackColor = False
        '
        'LoginAdm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(225, 41)
        Me.Controls.Add(Me.btnAcessoAdm)
        Me.Controls.Add(Me.txtSenhaAdm)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginAdm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login de Admnistrador"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSenhaAdm As TextBox
    Friend WithEvents btnAcessoAdm As Button
End Class
