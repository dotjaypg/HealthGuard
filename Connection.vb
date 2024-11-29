Imports MySql.Data.MySqlClient

Public Class DBConnection
    ' lifecycle storing
    Private ReadOnly Connector As New MySqlConnection("Server=localhost; user=root; password=;database=db_healthguard")

    Public Function Open() As MySqlConnection
        ' check if closed
        If Connector.State = ConnectionState.Closed Then
            Try
                Connector.Open()
            Catch ex As Exception
                MessageBox.Show($"Error opening connection: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        Return Connector ' open return
    End Function


    Public Function Close() As MySqlConnection
        ' closer
        If Connector.State = ConnectionState.Open Then
            Try
                Connector.Close()
            Catch ex As Exception
                MessageBox.Show($"Error closing connection: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        Return Connector ' close return
    End Function
End Class
