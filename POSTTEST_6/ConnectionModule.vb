Imports MySqlConnector

Public Module ConnectionModule
    Private Const ConnString As String = "Server=localhost;Database=db_videotron;User ID=root;Password=;"

    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(ConnString)
    End Function
End Module