Imports System.Data.SqlClient
Module mdSQL
    Private Const SQL_SERVER As String = "192.168.190.131,1433"
    Private Const SQL_DB As String = "mVote"
    Private Const SQL_USER As String = "zn"
    Private Const SQL_PASW As String = "zn8915383"
    Private cn As SqlConnection
    Private da As SqlDataAdapter
    Private ds As DataSet
    Private sc As SqlCommand
    ''' <summary>
    ''' SQL初始化
    ''' </summary>
    ''' <returns></returns>
    Private Function SQLInit() As Integer
        On Error GoTo Errline
        Dim cnStr As String = "Data Source=" & SQL_SERVER &
            ";Initial Catalog=master" &
            ";Integrated Security=False;User ID=" & SQL_USER &
            ";Password=" & SQL_PASW & ";"
        cn = New SqlConnection(cnStr)
        SQLInit = 0
        Exit Function
Errline:
        SQLInit = Err.Number
    End Function
    ''' <summary>
    ''' SQL连接
    ''' </summary>
    ''' <returns></returns>
    Public Function SQLConnect() As Integer
        On Error GoTo Errline
        Dim cnStr As String = "Data Source=" & SQL_SERVER &
            ";Initial Catalog=" & SQL_DB &
            ";Integrated Security=False;User ID=" & SQL_USER &
            ";Password=" & SQL_PASW & ";"
        cn = New SqlConnection(cnStr)

        'da = New SqlDataAdapter("select * from mydatabase1.dbo.db_book", cn)
        'ds = New DataSet()
        'da.Fill(ds, "mydatabase1.dbo.db_book")
        'DataGridView1.DataSource = ds.Tables("mydatabase1.dbo.db_book")
        SQLConnect = 0
        Exit Function
Errline:
        SQLConnect = Err.Number
    End Function
End Module
