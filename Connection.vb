Imports MySql.Data.MySqlClient
Public Class DBConnection
    ReadOnly Connector As New MySqlConnection("Server=localhost; user=root; password=;database=db_healthguard")
    Public Function Open() As MySqlConnection
        Try
            Connector.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return Connector
    End Function

    Public Function Close() As MySqlConnection
        Try
            Connector.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return Connector
    End Function
End Class
