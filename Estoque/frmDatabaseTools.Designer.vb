<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatabaseTools
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ButtonCriarTabela = New System.Windows.Forms.Button()
        Me.ButtonConectar = New System.Windows.Forms.Button()
        Me.TextBoxDataBaseName = New System.Windows.Forms.TextBox()
        Me.ButtonCreateDataBase = New System.Windows.Forms.Button()
        Me.ButtonCompactarDataBase = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ButtonCreateDatabaseSql = New System.Windows.Forms.Button()
        Me.ButtonConectarSql = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.ButtonCriarTabelaSql = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.StatusStrip1)
        Me.GroupBox1.Controls.Add(Me.ButtonCriarTabela)
        Me.GroupBox1.Controls.Add(Me.ButtonConectar)
        Me.GroupBox1.Controls.Add(Me.TextBoxDataBaseName)
        Me.GroupBox1.Controls.Add(Me.ButtonCreateDataBase)
        Me.GroupBox1.Controls.Add(Me.ButtonCompactarDataBase)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(426, 249)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Access"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 144)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(412, 85)
        Me.DataGridView1.TabIndex = 6
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(3, 224)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(420, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ButtonCriarTabela
        '
        Me.ButtonCriarTabela.Location = New System.Drawing.Point(273, 107)
        Me.ButtonCriarTabela.Name = "ButtonCriarTabela"
        Me.ButtonCriarTabela.Size = New System.Drawing.Size(145, 23)
        Me.ButtonCriarTabela.TabIndex = 4
        Me.ButtonCriarTabela.Text = "Criar Tabela no banco dados"
        Me.ButtonCriarTabela.UseVisualStyleBackColor = True
        '
        'ButtonConectar
        '
        Me.ButtonConectar.Location = New System.Drawing.Point(273, 78)
        Me.ButtonConectar.Name = "ButtonConectar"
        Me.ButtonConectar.Size = New System.Drawing.Size(145, 23)
        Me.ButtonConectar.TabIndex = 3
        Me.ButtonConectar.Text = "Conectar banco de dados"
        Me.ButtonConectar.UseVisualStyleBackColor = True
        '
        'TextBoxDataBaseName
        '
        Me.TextBoxDataBaseName.Location = New System.Drawing.Point(6, 52)
        Me.TextBoxDataBaseName.Name = "TextBoxDataBaseName"
        Me.TextBoxDataBaseName.Size = New System.Drawing.Size(261, 20)
        Me.TextBoxDataBaseName.TabIndex = 0
        '
        'ButtonCreateDataBase
        '
        Me.ButtonCreateDataBase.Location = New System.Drawing.Point(273, 49)
        Me.ButtonCreateDataBase.Name = "ButtonCreateDataBase"
        Me.ButtonCreateDataBase.Size = New System.Drawing.Size(145, 23)
        Me.ButtonCreateDataBase.TabIndex = 1
        Me.ButtonCreateDataBase.Text = "&Create Database"
        Me.ButtonCreateDataBase.UseVisualStyleBackColor = True
        '
        'ButtonCompactarDataBase
        '
        Me.ButtonCompactarDataBase.Location = New System.Drawing.Point(273, 19)
        Me.ButtonCompactarDataBase.Name = "ButtonCompactarDataBase"
        Me.ButtonCompactarDataBase.Size = New System.Drawing.Size(145, 24)
        Me.ButtonCompactarDataBase.TabIndex = 2
        Me.ButtonCompactarDataBase.Text = "Compactar Database"
        Me.ButtonCompactarDataBase.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ButtonCreateDatabaseSql)
        Me.GroupBox2.Controls.Add(Me.ButtonConectarSql)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Me.ButtonCriarTabelaSql)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 267)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(529, 202)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SQL"
        '
        'ButtonCreateDatabaseSql
        '
        Me.ButtonCreateDatabaseSql.Location = New System.Drawing.Point(283, 56)
        Me.ButtonCreateDatabaseSql.Name = "ButtonCreateDatabaseSql"
        Me.ButtonCreateDatabaseSql.Size = New System.Drawing.Size(145, 23)
        Me.ButtonCreateDatabaseSql.TabIndex = 7
        Me.ButtonCreateDatabaseSql.Text = "&Create Database"
        Me.ButtonCreateDatabaseSql.UseVisualStyleBackColor = True
        '
        'ButtonConectarSql
        '
        Me.ButtonConectarSql.Location = New System.Drawing.Point(283, 84)
        Me.ButtonConectarSql.Name = "ButtonConectarSql"
        Me.ButtonConectarSql.Size = New System.Drawing.Size(145, 23)
        Me.ButtonConectarSql.TabIndex = 7
        Me.ButtonConectarSql.Text = "Conectar banco de dados"
        Me.ButtonConectarSql.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Database:"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(70, 28)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(207, 20)
        Me.TextBox5.TabIndex = 14
        '
        'ButtonCriarTabelaSql
        '
        Me.ButtonCriarTabelaSql.Location = New System.Drawing.Point(283, 113)
        Me.ButtonCriarTabelaSql.Name = "ButtonCriarTabelaSql"
        Me.ButtonCriarTabelaSql.Size = New System.Drawing.Size(145, 23)
        Me.ButtonCriarTabelaSql.TabIndex = 13
        Me.ButtonCriarTabelaSql.Text = "Criar Tabela no banco dados"
        Me.ButtonCriarTabelaSql.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(283, 142)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "Listar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(202, 142)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Deletar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(202, 113)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Consultar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(202, 85)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Editar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(202, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Incluir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Ende:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nome:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Codi:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ID:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(70, 132)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(70, 106)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(70, 80)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(70, 54)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'frmDatabaseTools
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 499)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDatabaseTools"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Macrosoft AccessCreateDatabase"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonCompactarDataBase As Button
    Friend WithEvents ButtonCreateDataBase As Button
    Friend WithEvents TextBoxDataBaseName As TextBox
    Friend WithEvents ButtonConectar As Button
    Friend WithEvents ButtonCriarTabela As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents ButtonCriarTabelaSql As Button
    Friend WithEvents ButtonConectarSql As Button
    Friend WithEvents ButtonCreateDatabaseSql As Button
End Class
