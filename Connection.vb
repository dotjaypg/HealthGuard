Imports MySql.Data.MySqlClient

Public Class DBConnection
    ' Store the connection instance to manage its lifecycle manually
    Private ReadOnly Connector As New MySqlConnection("Server=localhost; user=root; password=;database=db_healthguard")

    ''' <summary>
    ''' Opens the MySQL connection if it is not already open.
    ''' </summary>
    ''' <returns>Returns the opened MySqlConnection.</returns>
    Public Function Open() As MySqlConnection
        ' Check if the connection is closed before opening it
        If Connector.State = ConnectionState.Closed Then
            Try
                Connector.Open()
            Catch ex As Exception
                MessageBox.Show($"Error opening connection: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        Return Connector ' Return the connection object
    End Function

    ''' <summary>
    ''' Closes the MySQL connection if it is open.
    ''' </summary>
    ''' <returns>Returns the closed MySqlConnection.</returns>
    Public Function Close() As MySqlConnection
        If Connector.State = ConnectionState.Open Then
            Try
                Connector.Close()
            Catch ex As Exception
                MessageBox.Show($"Error closing connection: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        Return Connector ' Return the connection object
    End Function
End Class
