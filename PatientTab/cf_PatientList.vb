Imports MySql.Data.MySqlClient

Namespace PatientTab
    Public Class cf_PatientList
        Inherits Form

        Private dbConnection As New DBConnection() ' DBConnection instance
        Private patientTable As DataTable
        Private selectedPatientID As String

        ' Form Load Event
        Private Sub cf_PatientList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            LoadPatientData()
        End Sub

        ''' <summary>
        ''' Loads patient data from the database and populates the DataGridView.
        ''' </summary>
        Private Sub LoadPatientData()
            Try
                ' Open the connection (no Using block so the connection stays open)
                Dim conn As MySqlConnection = dbConnection.Open()

                ' Define the query to fetch patient data
                Dim query As String = "SELECT PatientId, FirstName, MiddleName, LastName, Sex, DateOfBirth FROM patients"
                Dim cmd As New MySqlCommand(query, conn)

                ' Fill the DataTable with query results
                Dim adapter As New MySqlDataAdapter(cmd)
                patientTable = New DataTable()
                adapter.Fill(patientTable)

                ' Bind the DataTable to the DataGridView
                dgv_PatientTable.DataSource = patientTable

                ' Set column headers for better readability
                SetColumnHeaders()

                ' Close the connection after use
                dbConnection.Close()

            Catch ex As MySqlException
                MessageBox.Show($"MySQL Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        ''' Displays the cf_PatientData form with the selected PatientID.
        ''' </summary>
        Private Sub btn_View_Click(sender As Object, e As EventArgs) Handles btn_View.Click
            If Not String.IsNullOrEmpty(selectedPatientID) Then
                Dim patientDataForm As New cf_ApmntData
                patientDataForm.PatientID = selectedPatientID ' Pass PatientID to cf_PatientData
                patientDataForm.ShowDialog()
            Else
                MessageBox.Show("No patient selected. Please select a patient to view.", "View Patient", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Sub

        ''' <summary>
        ''' Deletes patient data of the selected row when the Delete button is clicked.
        ''' </summary>
        Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click
            If String.IsNullOrEmpty(selectedPatientID) Then
                MessageBox.Show("No patient selected. Please select a patient to delete.", "Delete Patient", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim result As DialogResult = MessageBox.Show($"Are you sure you want to delete patient {selectedPatientID}?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result <> DialogResult.Yes Then Return

            Try
                ' Perform deletion
                Dim conn As MySqlConnection = dbConnection.Open() ' Open the connection manually

                Dim query As String = "DELETE FROM patients WHERE PatientId = @PatientId"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@PatientId", selectedPatientID)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show($"Patient {selectedPatientID} has been deleted.", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("No rows were deleted. The patient may not exist.", "Delete Patient", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using

                ' Close the connection after the operation is complete
                dbConnection.Close()

                ' Refresh the data grid after deletion
                LoadPatientData()

            Catch ex As Exception
                MessageBox.Show($"Error deleting patient: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        ''' <summary>
        ''' Refreshes the data in the DataGridView by reloading it from the database.
        ''' </summary>
        Private Sub btn_Refresh_Click(sender As Object, e As EventArgs) Handles btn_Refresh.Click
            Try
                LoadPatientData() ' Reload patient data from the database
                MessageBox.Show("Patient data refreshed successfully.", "Refresh", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show($"Error refreshing patient data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        ''' <summary>
        ''' Handles the text change event of the search textbox to filter data in the DataGridView.
        ''' </summary>
        Private Sub txt_Search_TextChanged(sender As Object, e As EventArgs) Handles txt_Search.TextChanged
            Dim filterText As String = txt_Search.Text.Trim().ToLower()

            If String.IsNullOrEmpty(filterText) Then
                ' If the search bar is empty, show all rows
                CType(dgv_PatientTable.DataSource, DataTable).DefaultView.RowFilter = String.Empty
            Else
                ' Prepare the filter string
                Dim filterExpression As String = $"PatientId LIKE '%{filterText}%' OR " &
                                                 $"FirstName LIKE '%{filterText}%' OR " &
                                                 $"MiddleName LIKE '%{filterText}%' OR " &
                                                 $"LastName LIKE '%{filterText}%' OR " &
                                                 $"Sex LIKE '%{filterText}%' OR " &
                                                 $"CONVERT(DateOfBirth, 'System.String') LIKE '%{filterText}%'"

                ' Apply the filter
                CType(dgv_PatientTable.DataSource, DataTable).DefaultView.RowFilter = filterExpression
            End If
        End Sub
    End Class
End Namespace
