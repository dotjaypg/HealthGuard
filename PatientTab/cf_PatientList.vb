Imports MySql.Data.MySqlClient

Namespace PatientTab
    Public Class cf_PatientList
        Inherits Form

        ' Database connection utility
        Private dbConnection As New DBConnection()

        ' The full DataTable to store all the patient data
        Private patientTable As DataTable

        Private Sub cf_PatientList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ' Load data into the DataGridView on form load
            LoadPatientData()
        End Sub

        ''' <summary>
        ''' Loads patient data from the database and populates the DataGridView.
        ''' </summary>
        Private Sub LoadPatientData()
            Try
                Using conn As MySqlConnection = dbConnection.Open()
                    Dim query As String = "SELECT PatientId, FirstName, MiddleName, LastName, Sex, DateOfBirth FROM patients"
                    Dim cmd As New MySqlCommand(query, conn)

                    ' Fill a DataTable with query results
                    Dim adapter As New MySqlDataAdapter(cmd)
                    patientTable = New DataTable() ' Initialize the DataTable
                    adapter.Fill(patientTable)

                    ' Bind the DataTable to the DataGridView
                    dgv_PatientTable.DataSource = patientTable

                    ' Set column headers for better readability
                    SetColumnHeaders()
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error loading patient data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        ''' <summary>
        ''' Sets custom headers for the DataGridView columns.
        ''' </summary>
        Private Sub SetColumnHeaders()
            dgv_PatientTable.Columns("PatientId").HeaderText = "Patient ID"
            dgv_PatientTable.Columns("FirstName").HeaderText = "First Name"
            dgv_PatientTable.Columns("MiddleName").HeaderText = "Middle Name"
            dgv_PatientTable.Columns("LastName").HeaderText = "Last Name"
            dgv_PatientTable.Columns("Sex").HeaderText = "Sex"
            dgv_PatientTable.Columns("DateOfBirth").HeaderText = "Date of Birth"
        End Sub

        ''' <summary>
        ''' Filters the DataGridView based on the search input.
        ''' </summary>
        Private Sub txt_Search_TextChanged(sender As Object, e As EventArgs) Handles txt_Search.TextChanged
            Dim searchTerm As String = txt_Search.Text.Trim().ToLower()

            ' Show all rows if the search term is empty
            If String.IsNullOrWhiteSpace(searchTerm) Then
                dgv_PatientTable.DataSource = patientTable
                Return
            End If

            ' Filter rows based on the search term
            Dim filteredRows As DataRow() = patientTable.Select(
                $"FirstName LIKE '%{searchTerm}%' OR " &
                $"MiddleName LIKE '%{searchTerm}%' OR " &
                $"LastName LIKE '%{searchTerm}%' OR " &
                $"PatientId LIKE '%{searchTerm}%'")

            ' Display the filtered results in the DataGridView
            If filteredRows.Any() Then
                dgv_PatientTable.DataSource = filteredRows.CopyToDataTable()
            Else
                dgv_PatientTable.DataSource = Nothing ' No matches found
            End If
        End Sub

        Private Sub btn_View_Click(sender As Object, e As EventArgs) Handles btn_View.Click

        End Sub

        Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click

        End Sub
    End Class
End Namespace
