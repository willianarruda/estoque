Imports System.Data.OleDb
Imports Estoque.TFuncoes

Public Class TConexaoAccess
    Public Conn As OleDbConnection
    Public Cmd As OleDbCommand
    Public da As OleDbDataAdapter
    Public dr As OleDbDataReader
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
        cSQLString = "Server=" + Me.Server + ";"
        cSQLString += "Database=" + Me.Database + ";"
        cSQLString += "User Id=" + Me.UserId + ";"
        cSQLString += "Password=" + Me.Password + ";"
        Conn = New OleDbConnection(cSQLString)
    End Sub

    Public Function GetConnection() As OleDbConnection
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
        Dim cmd As OleDbCommand = New OleDbCommand(sql, Conn)
        Dim valida As Boolean = False

        Try
            Conn.Open()
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                valida = True
            End If
        Catch ex As Exception
            informa(ex.Message)
            valida = False
        End Try
        Conn.Close()
        Return valida
    End Function

    Public Function NovoCliente() As Boolean
        Dim retorno As Boolean
        Try
            Cmd = New OleDbCommand
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
            Cmd = New OleDbCommand
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
            Cmd = New OleDbCommand
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
            Cmd = New OleDbCommand
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
            Cmd = New OleDbCommand
            Cmd.Connection = Conn
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.CommandText = "PR_LISTA_CLIENTE"
            da = New OleDbDataAdapter(Cmd)
            da.Fill(tabela)
            Return tabela
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
