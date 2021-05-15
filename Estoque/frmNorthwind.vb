Imports Estoque.TFuncoes

Public Class frmNorthwind
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            cboCategorias.DataSource = AcessoBD.GetDados("SELECT * FROM Categories")
            cboCategorias.ValueMember = "CategoryID"
            cboCategorias.DisplayMember = "CategoryName"
        Catch ex As Exception
            informa(ex.ToString)
        End Try
    End Sub
End Class