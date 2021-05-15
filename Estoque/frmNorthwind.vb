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
    Private Sub cboCategorias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategorias.SelectedIndexChanged
        Try
            lbProdutos.DataSource = AcessoBD.GetDados("SELECT * FROM Products WHERE CategoryID = " & cboCategorias.SelectedValue.ToString)
            lbProdutos.ValueMember = "ProductID"
            lbProdutos.DisplayMember = "ProductName"
        Catch ex As Exception
            informa(ex.ToString)
        End Try
    End Sub

    Private Sub frmNorthwind_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Lista contendo os times semi-finalistas da Copa do Brasil
        Dim copaDoBrasil() As String = {"CEARÁ", "CORITIBA", "VASCO", "AVAÍ"}

        'Criar uma coluna no Grid
        DataGridView1.Columns.Add("Time", "Semi-Finalistas da Copa do Brasil")
        DataGridView1.Columns(0).Width = 469

        'Popular a grade usando os itens da lista
        For Each time As String In copaDoBrasil
            DataGridView1.Rows.Add(time)
        Next
    End Sub
End Class