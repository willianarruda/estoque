<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNorthwind
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
        Me.cboCategorias = New System.Windows.Forms.ComboBox()
        Me.lbProdutos = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboCategorias
        '
        Me.cboCategorias.FormattingEnabled = True
        Me.cboCategorias.Location = New System.Drawing.Point(56, 61)
        Me.cboCategorias.Name = "cboCategorias"
        Me.cboCategorias.Size = New System.Drawing.Size(268, 21)
        Me.cboCategorias.TabIndex = 0
        '
        'lbProdutos
        '
        Me.lbProdutos.FormattingEnabled = True
        Me.lbProdutos.Location = New System.Drawing.Point(56, 88)
        Me.lbProdutos.Name = "lbProdutos"
        Me.lbProdutos.Size = New System.Drawing.Size(268, 147)
        Me.lbProdutos.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(56, 241)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(268, 36)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Preencher"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmNorthwind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaGreen
        Me.ClientSize = New System.Drawing.Size(412, 372)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbProdutos)
        Me.Controls.Add(Me.cboCategorias)
        Me.Name = "frmNorthwind"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmNorthwin"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cboCategorias As ComboBox
    Friend WithEvents lbProdutos As ListBox
    Friend WithEvents Button1 As Button
End Class
