Imports MySql.Data.MySqlClient

Namespace PatientTab
    Public Class cf_PatientList
        Inherits Form

        ' Database connection utility
        Private dbConnection As New DBConnection()

        ' The full DataTable to store all the patient data
        Private patientTable As DataTable

        ' Stores the PatientID of the currently selected tuple
        Private selectedPatientID As String

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

        ''' <summary>
        ''' Handles row selection in the DataGridView.
        ''' Updates the selectedPatientID variable with the ID of the selected row.
        ''' </summary>
        Private Sub dgv_PatientTable_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_PatientTable.SelectionChanged
            If dgv_PatientTable.CurrentRow IsNot Nothing AndAlso dgv_PatientTable.CurrentRow.Index >= 0 Then
                Dim row As DataGridViewRow = dgv_PatientTable.CurrentRow
                selectedPatientID = row.Cells("PatientId").Value.ToString()
            Else
                selectedPatientID = Nothing ' No row selected
            End If
        End Sub

        ''' <summary>
        ''' Displays patient data of the selected row when the View button is clicked.
        ''' </summary>
        Private Sub btn_View_Click(sender As Object, e As EventArgs) Handles btn_View.Click
            If Not String.IsNullOrEmpty(selectedPatientID) Then
                MessageBox.Show($"PATIENT DATA: {selectedPatientID}", "View Patient", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No patient selected. Please select a patient to view.", "View Patient", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Sub

        ''' <summary>
        ''' Deletes patient data of the selected row when the Delete button is clicked.
        ''' </summary>
        Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click
            If Not String.IsNullOrEmpty(selectedPatientID) Then
                MessageBox.Show($"DELETED DATA: {selectedPatientID}", "Delete Patient", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("No patient selected. Please select a patient to delete.", "Delete Patient", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Sub
    End Class
End Namespace
