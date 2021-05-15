Imports Estoque.TFuncoes

Public Class frmMain
    Dim oAmbiente As New TAmbiente

    Private Sub SairToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub BancoDeDadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BancoDeDadosToolStripMenuItem.Click
        Me.Hide()
        frmDatabaseTools.Show()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = oAmbiente.xcabec
        Me.StatusStrip1.Text = oAmbiente.xnomefir
    End Sub
End Class