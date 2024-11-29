Imports MySql.Data.MySqlClient

Namespace AccountTab
    Public Class cf_AccList
        Inherits Form

        ' Database connection utility
        Private dbConnection As New DBConnection()

        ' The full DataTable to store all the account data
        Private accountTable As DataTable

        ' Form Load Event
        Private Sub cf_AccList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ' Load data into the existing DataGridView
            LoadAccountData()
        End Sub

        ''' <summary>
        ''' Loads account data from the database and populates the DataGridView.
        ''' </summary>
        Private Sub LoadAccountData()
            Try
                ' Open connection using the DBConnection class
                Using conn As MySqlConnection = dbConnection.Open()
                    ' Define the query to fetch account data
                    Dim query As String = "SELECT UserID, Role, FirstName, MiddleName, LastName, EmailUsername, Status, CreationDate FROM accounts"
                    Dim cmd As New MySqlCommand(query, conn)

                    ' Fill a DataTable with query results
                    Dim adapter As New MySqlDataAdapter(cmd)
                    accountTable = New DataTable() ' Store the full data
                    adapter.Fill(accountTable)

                    ' Bind the DataTable to the DataGridView
                    dgv_AccTable.DataSource = accountTable

                    ' Rename column headers
                    SetColumnHeaders()
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error loading account data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        ''' <summary>
        ''' Sets custom headers for the DataGridView columns.
        ''' </summary>
        Private Sub SetColumnHeaders()
            dgv_AccTable.Columns("UserID").HeaderText = "User ID"
            dgv_AccTable.Columns("Role").HeaderText = "Role"
            dgv_AccTable.Columns("FirstName").HeaderText = "First Name"
            dgv_AccTable.Columns("MiddleName").HeaderText = "Middle Name"
            dgv_AccTable.Columns("LastName").HeaderText = "Last Name"
            dgv_AccTable.Columns("EmailUsername").HeaderText = "Email/Username"
            dgv_AccTable.Columns("Status").HeaderText = "Status"
            dgv_AccTable.Columns("CreationDate").HeaderText = "Date of Creation"
        End Sub

        ''' <summary>
        ''' Handles text change in the search textbox.
        ''' Filters the account data based on the search term.
        ''' </summary>
        Private Sub txt_Search_TextChanged(sender As Object, e As EventArgs) Handles txt_Search.TextChanged
            ' Get the search term from the text box
            Dim searchTerm As String = txt_Search.Text.ToLower()

            ' If the search term is empty, show all rows
            If String.IsNullOrWhiteSpace(searchTerm) Then
                dgv_AccTable.DataSource = accountTable
                Return
            End If

            ' Create a DataView to filter the rows based on the search term
            Dim filteredRows As DataRow() = accountTable.Select(
                $"UserID LIKE '%{searchTerm}%' OR " &
                $"Role LIKE '%{searchTerm}%' OR " &
                $"FirstName LIKE '%{searchTerm}%' OR " &
                $"MiddleName LIKE '%{searchTerm}%' OR " &
                $"LastName LIKE '%{searchTerm}%' OR " &
                $"EmailUsername LIKE '%{searchTerm}%' OR " &
                $"Status LIKE '%{searchTerm}%' OR " &
                $"CreationDate LIKE '%{searchTerm}%'")

            ' If there are any matching rows, bind them to the DataGridView
            If filteredRows.Length > 0 Then
                Dim filteredTable As DataTable = filteredRows.CopyToDataTable()
                dgv_AccTable.DataSource = filteredTable
            Else
                ' If no matching rows, clear the DataGridView
                dgv_AccTable.DataSource = Nothing
            End If
        End Sub

        ''' <summary>
        ''' Refreshes the data in the DataGridView by reloading it from the database.
        ''' </summary>
        Private Sub btn_Refresh_Click(sender As Object, e As EventArgs) Handles btn_Refresh.Click
            Try
                ' Reload account data from the database
                LoadAccountData()
                MessageBox.Show("Account data refreshed successfully.", "Refresh", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show($"Error refreshing account data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        ''' <summary>
        ''' Deletes the selected account when the Delete button is clicked.
        ''' </summary>
        Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click
            If dgv_AccTable.SelectedRows.Count = 0 Then
                MessageBox.Show("No account selected. Please select an account to delete.", "Delete Account", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Get the selected UserID from the DataGridView
            Dim selectedUserID As String = dgv_AccTable.SelectedRows(0).Cells("UserID").Value.ToString()

            ' Confirmation before deletion
            Dim result As DialogResult = MessageBox.Show($"Are you sure you want to delete account {selectedUserID}?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result <> DialogResult.Yes Then Return

            Try
                ' Open connection for the delete operation
                Using conn As MySqlConnection = dbConnection.Open()
                    Dim query As String = "DELETE FROM accounts WHERE UserID = @UserID"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@UserID", selectedUserID)
                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show($"Account {selectedUserID} has been deleted.", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("No rows were deleted. The account may not exist.", "Delete Account", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End Using
                End Using

                ' Refresh the data grid after deletion
                LoadAccountData()
            Catch ex As Exception
                MessageBox.Show($"Error deleting account: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

    End Class
End Namespace
