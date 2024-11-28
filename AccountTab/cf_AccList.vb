Imports MySql.Data.MySqlClient

Namespace AccountTab
    Public Class cf_AccList
        Inherits Form

        ' Database connection utility
        Private dbConnection As New DBConnection()

        ' The full DataTable to store all the account data
        Private accountTable As DataTable

        Private Sub cf_AccList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ' Load data into the existing DataGridView
            LoadAccountData()
        End Sub

        Private Sub LoadAccountData()
            Try
                Using conn As MySqlConnection = dbConnection.Open()
                    Dim query As String = "SELECT UserID, Role, FirstName, MiddleName, LastName, EmailUsername, Status, CreationDate FROM accounts"
                    Dim cmd As New MySqlCommand(query, conn)

                    ' Fill a DataTable with query results
                    Dim adapter As New MySqlDataAdapter(cmd)
                    accountTable = New DataTable() ' Store the full data
                    adapter.Fill(accountTable)

                    ' Bind the DataTable to the DataGridView
                    dgv_AccTable.DataSource = accountTable

                    ' Rename column headers
                    dgv_AccTable.Columns("UserID").HeaderText = "User ID"
                    dgv_AccTable.Columns("Role").HeaderText = "Role"
                    dgv_AccTable.Columns("FirstName").HeaderText = "First Name"
                    dgv_AccTable.Columns("MiddleName").HeaderText = "Middle Name"
                    dgv_AccTable.Columns("LastName").HeaderText = "Last Name"
                    dgv_AccTable.Columns("EmailUsername").HeaderText = "Email/Username"
                    dgv_AccTable.Columns("Status").HeaderText = "Status"
                    dgv_AccTable.Columns("CreationDate").HeaderText = "Date of Creation"
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error loading account data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

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
    End Class
End Namespace
