Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports Estoque.TFuncoes
Imports JRO
Imports ADODB
Imports ADOX
Imports MSAdodcLib
Imports System.Data.Odbc
Imports System.Data.Common

Public Class frmDatabaseTools
    Dim AccessConn As OleDbConnection
    Dim AccessCmd As OleDbCommand
    Dim SqlConn As SqlConnection
    Dim SqlCmd As SqlCommand
    Dim cSQLString As String
    Dim cCadeiaACE As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
    Dim cCadeiaJET As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        AccessConn = New OleDbConnection(cCadeiaACE + "C:\lixo.accdb;")
        AccessConn.Open()
        cSQLString = "CREATE TABLE TableName (nome TEXT, sobrenome TEXT)"
        AccessCmd = New OleDbCommand(cSQLString, AccessConn)
        AccessCmd.ExecuteNonQuery()
        MsgBox("Tabela criada.")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonCreateDataBase.Click
        'CreateAccessDatabase("C:\lixo\testDB.mdb")
        If TextBoxDataBaseName.Text IsNot "" Then
            If CreateAccessDatabase(TextBoxDataBaseName.Text) Then
                MsgBox("Database " & TextBoxDataBaseName.Text & " created")
            End If
        End If
    End Sub

    Public Function CreateAccessDatabase(ByVal DatabaseFullPath As String) As Boolean
        Dim bAns As Boolean
        Dim cat As New ADOX.Catalog()
        Try
            Dim sCreateString As String
            sCreateString = cCadeiaJET + DatabaseFullPath
            cat.Create(sCreateString)
            bAns = True
        Catch Excep As System.Runtime.InteropServices.COMException
            MessageBox.Show("Erro ao tentar criar o Banco de dados.")
            bAns = False
        Finally
            cat = Nothing
        End Try
        Return bAns
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtonCreateDataBase.Enabled = False
    End Sub

    Private Sub TextBoxDataBaseName_TextChanged(sender As Object, e As EventArgs) Handles TextBoxDataBaseName.TextChanged
        ButtonCreateDataBase.Enabled = True
    End Sub

    Private Sub ButtonCompactarDataBase_Click(sender As Object, e As EventArgs) Handles ButtonCompactarDataBase.Click
        If TextBoxDataBaseName.Text IsNot "" Then
            If CompactAccessDatabase(TextBoxDataBaseName.Text) Then
                info("Database " & TextBoxDataBaseName.Text & " compactado")
            End If
        End If
    End Sub

    Public Function CompactAccessDatabase(ByVal DatabaseFullPath As String) As Boolean
        Dim result As Boolean
        Dim jro As New JRO.JetEngine()
        Try
            Dim sCompactStringSrc As String
            Dim sCompactStringDes As String
            sCompactStringSrc = cCadeiaJET + DatabaseFullPath
            sCompactStringDes = cCadeiaJET + "c:\lixo\terca.mdb"
            jro.CompactDatabase(sCompactStringSrc, sCompactStringDes)
            info("Banco de dados foi compactado com sucesso.")
            result = True
        Catch Excep As System.Runtime.InteropServices.COMException
            info("Erro ao compactar o Banco de dados.")
            result = False
        Finally
            jro = Nothing
        End Try
        Return result
    End Function

    Private Sub ButtonConectar_Click(sender As Object, e As EventArgs) Handles ButtonConectar.Click
        ConectAccessDatabase()
    End Sub

    Public Function ConectAccessDatabase() As Boolean
        AccessConn = New OleDbConnection(cCadeiaACE + TextBoxDataBaseName.Text)
        Try
            AccessConn.Open()
            MsgBox("Conectado: " + TextBoxDataBaseName.Text)
            Return True
        Catch ex As Exception
            MsgBox("Falha ao conectar " & vbNewLine & ex.Message)
            Return False
        End Try
    End Function

    Private Sub ButtonCriarTabela_Click(sender As Object, e As EventArgs) Handles ButtonCriarTabela.Click
        AccessConn = New OleDbConnection(cCadeiaACE + TextBoxDataBaseName.Text)
        cSQLString = "CREATE TABLE clientes (" &
            "Id integer IDENTITY(1,1) PRIMARY KEY NOT NULL," &
            "Codi varchar(5) NOT NULL," &
            "Nome varchar(100) NOT NULL," &
            "Cep varchar(9) NOT NULL)"
        Try
            AccessConn.Open()
            AccessCmd = New OleDbCommand(cSQLString, AccessConn)
            AccessCmd.ExecuteNonQuery()
            MsgBox("Tabela criada ")
        Catch ex As Exception
            MsgBox("Falha ao criar tabela " & vbNewLine & ex.Message)
        End Try
    End Sub

    Private Sub ButtonConectarSql_Click(sender As Object, e As EventArgs) Handles ButtonConectarSql.Click
    End Sub
End Class
