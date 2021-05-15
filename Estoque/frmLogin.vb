Imports Estoque.TFuncoes

Public Class frmLogin
    Public oAmbiente As New TAmbiente
    Dim oLogin As TConexaoMysql

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mostraIP()

        oLogin = New TConexaoMysql()
        oLogin.Server = "31.170.167.15"
        oLogin.Server = "sql486.main-hosting.eu"
        oLogin.Database = "u356719782_sci"
        oLogin.UserId = "u356719782_vcatafesta"
        oLogin.Password = "Dfiz451960"
        oLogin.Create()
        ToolStripStatusLabel1.Text = "SQLSERVER : " + oLogin.Server + "|"
        ToolStripStatusLabel2.Text = Now
        Try
            cboUsuario.DataSource = oLogin.GetDados("SELECT * FROM Login")
            cboUsuario.ValueMember = "Id"
            cboUsuario.DisplayMember = "Usuario"
        Catch ex As Exception
            informa(ex.ToString)
        End Try
    End Sub

    Private Sub BTN_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_login.Click
        If ValidarSenha() Then
            Me.Hide()
            'frmMain.Show()
            frmNorthwind.Show()
        End If
    End Sub

    Public Function ValidarSenha() As Boolean
        If cboUsuario.Text = String.Empty Or TB_senha.Text = String.Empty Then
            ToolStripStatusLabel1.Text = "Erro: Usuário ou senha inválido."
            cboUsuario.Focus()
            Return False
        End If

        If oLogin.AcessoLogin(cboUsuario.Text, TB_senha.Text) Then
            ToolStripStatusLabel1.Text = "Info: Acesso garantido."
            Return True
        Else
            informa("Erro: login falhou." + vbCrLf + "Server :" + oLogin.Server)
            Return False
        End If
    End Function

    Private Sub BTN_login_MouseLeave(sender As System.Object, e As System.EventArgs) Handles BTN_login.MouseLeave
        ToolStripStatusLabel1.Text = Nothing
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel2.Text = Now
    End Sub

    Private Sub cboUsuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUsuario.SelectedIndexChanged

    End Sub

    Private Sub mostraIP()
        Dim listaIpLocal As System.Net.IPAddress() = System.Net.Dns.GetHostAddresses(System.Net.Dns.GetHostName())
        ListBox1.Items.Clear()
        For Each ip As System.Net.IPAddress In listaIpLocal
            ListBox1.Items.Add(ip.ToString())
        Next
    End Sub
End Class
