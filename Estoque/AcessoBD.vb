Imports System.Data.SqlClient
Imports System.Configuration

Public Class AcessoBD

    Private Shared Function GetDbConnection() As SqlConnection
        Try
            Dim conString As String = ConfigurationManager.ConnectionStrings("conexaoNorthwind").ConnectionString
            Dim connection As SqlConnection = New SqlConnection(conString)
            connection.Open()
            Return connection
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function GetDados(sql As String) As DataTable
        Using connection As SqlConnection = GetDbConnection()
            Try
                Dim dt As New DataTable
                Using command As New SqlCommand(sql, connection)
                    dt.Load(command.ExecuteReader)
                    Return dt
                End Using
            Catch ex As Exception
                Throw ex
            End Try
        End Using
    End Function
End Class
