Imports System.Data.Odbc
Public Class mysqlDBlink
    Public conn As New OdbcConnection
    Dim strSQL As String = ""
    Public da As New OdbcDataAdapter
    Public ds As New DataSet
    Dim cb As OdbcCommandBuilder
    ''' <summary>
    ''' Sets and Returns The string used to connect to the database
    ''' </summary>
    ''' <returns></returns>
    Public Property connectionString As String
        Get
            Return conn.ConnectionString.ToString
        End Get
        Set(value As String)
            conn.ConnectionString = value
        End Set
    End Property

    ''' <summary>
    ''' Sets and returns the current SQL additionally it calls setDataAdaptor
    ''' </summary>
    ''' <returns></returns>
    Public Property SQL As String
        Get
            Return strSQL
        End Get
        Set(value As String)
            strSQL = value
            Call setDataAdaptor()
        End Set
    End Property
    ''' <summary>
    ''' Reconnects to the database and refreshes local data set based on the SQL string Stored in strSQL
    ''' </summary>
    Private Sub setDataAdaptor()
        If strSQL <> "" And conn.ConnectionString <> "" Then
            'set new instance of data adapter passing SQL and connection string
            da = New OdbcDataAdapter(strSQL, conn)
            'set new instance of data set (snapshot)
            ds = New DataSet
            'fill data set
            da.Fill(ds)
            'initiate cb
            cb = New OdbcCommandBuilder(da)

        End If
    End Sub

End Class
