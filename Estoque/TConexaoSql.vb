Imports System.Data.SqlClient
Imports Estoque.TFuncoes


Public Class TConexaoSql
    Public Conn As SqlConnection
    Public Cmd As SqlCommand
    Public da As SqlDataAdapter
    Public dr As SqlDataReader
    Public registro As DataRow
    Public dt As DataSet

    Public Property IdCliente As Integer
    Public Property Nome As String
    Public Property Endereco As String
    Public Property Numero As String
    Public Property Server As String = "OFFICE\SQLEXPRESS"
    Public Property Database As String = "Live104"
    Public Property UserId As String = "sa"
    Public Property Password As String = "256"
    Public Property cSQLString As String


    Public Sub New()
        '
    End Sub
    Public Sub Create()
        cSQLString = "Server=" + Me.Server + ";"
        cSQLString += "Database=" + Me.Database + ";"
        cSQLString += "User Id=" + Me.UserId + ";"
        cSQLString += "Password=" + Me.Password + ";"
        Conn = New SqlConnection(cSQLString)
    End Sub

    Public Function OpenConnection() As SqlConnection
        Try
            Conn.Open()
        Catch ex As Exception
            informa(ex.Message)
        End Try
        Return Conn
    End Function

    Public Function Open() As SqlConnection
        Try
            Conn.Open()
        Catch ex As Exception
            informa(ex.Message)
        End Try
        Return Conn
    End Function

    Public Function GetConnection() As SqlConnection
        Try
            Conn.Open()
        Catch ex As Exception
            informa(ex.Message)
        End Try
        Return Conn
    End Function

    Public Function CloseConnection() As Boolean
        Try
            Conn.Close()
            Return True
        Catch ex As Exception
            informa(ex.Message)
        End Try
        Return False
    End Function

    Public Function AcessoLogin(ByVal cUsuario As String, ByVal cSenha As String) As Boolean
        Dim sql As String = "SELECT * FROM Login WHERE Usuario='" + cUsuario + "'"
        Dim cmd As SqlCommand = New SqlCommand(sql, Conn)
        Dim lretval As Boolean = False

        Try
            Conn.Open()
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                lretval = True
            End If
        Catch ex As Exception
            informa(ex.Message)
            lretval = False
        End Try
        Conn.Close()
        Return lretval
    End Function

    Public Function NovoCliente() As Boolean
        Dim retorno As Boolean
        Try
            Cmd = New SqlCommand
            Cmd.Connection = Conn
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.CommandText = "PR_NOVO_CLIENTE"
            Cmd.Parameters.AddWithValue("@NOME", Nome)
            If Endereco.Length > 0 Then Cmd.Parameters.AddWithValue("@ENDERECO", Endereco)
            If Numero.Length > 0 Then Cmd.Parameters.AddWithValue("@NUMERO", Numero)
            Conn.Open()
            retorno = Cmd.ExecuteNonQuery
            Conn.Close()
            Return retorno
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function AtualizaCliente() As Boolean
        Dim retorno As Boolean
        Try
            Cmd = New SqlCommand
            Cmd.Connection = Conn
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.CommandText = "PR_ATUALIZA_CLIENTE"
            Cmd.Parameters.AddWithValue("@ID", IdCliente)
            Cmd.Parameters.AddWithValue("@NOME", Nome)
            If Endereco.Length > 0 Then Cmd.Parameters.AddWithValue("@ENDERECO", Endereco)
            If Numero.Length > 0 Then Cmd.Parameters.AddWithValue("@NUMERO", Numero)
            Conn.Open()
            retorno = Cmd.ExecuteNonQuery
            Conn.Close()
            Return retorno
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function DeleteCliente() As Boolean
        Dim retorno As Boolean = False
        Try
            Cmd = New SqlCommand
            Cmd.Connection = Conn
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.CommandText = "PR_DELETE_CLIENTE"
            Cmd.Parameters.AddWithValue("@ID", IdCliente)
            Conn.Open()
            retorno = Cmd.ExecuteNonQuery
            Conn.Close()
            Return retorno
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function BuscaCliente() As Boolean
        Dim retorno As Boolean = False
        Try
            Cmd = New SqlCommand
            Cmd.Connection = Conn
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.CommandText = "PR_BUSCA_CLIENTE"
            Cmd.Parameters.AddWithValue("@ID", IdCliente)
            Conn.Open()
            dr = Cmd.ExecuteReader
            Do While dr.Read
                Nome = dr("NOME")
                If Not IsDBNull(dr("ENDERECO")) Then Endereco = dr("ENDERECO")
                If Not IsDBNull(dr("NUMERO")) Then Numero = dr("NUMERO")
                retorno = True
            Loop
            Conn.Close()
            Return retorno
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ListaCliente() As DataTable
        Dim tabela As New DataTable
        Try
            Cmd = New SqlCommand
            Cmd.Connection = Conn
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.CommandText = "PR_LISTA_CLIENTE"
            da = New SqlDataAdapter(Cmd)
            da.Fill(tabela)
            Return tabela
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
