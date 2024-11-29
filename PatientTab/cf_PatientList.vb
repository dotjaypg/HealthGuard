Imports MySql.Data.MySqlClient

Namespace PatientTab
    Public Class cf_PatientList
        Inherits Form

        Private dbConnection As New DBConnection()
        Private patientTable As DataTable
        Private selectedPatientID As String

        Private Sub cf_PatientList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

                    ' Fill the DataTable with query results
                    Dim adapter As New MySqlDataAdapter(cmd)
                    patientTable = New DataTable()
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
                Dim patientDataForm As New cf_PatientData()
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
            If Not String.IsNullOrEmpty(selectedPatientID) Then
                ' Confirmation before deletion
                Dim result As DialogResult = MessageBox.Show($"Are you sure you want to delete patient {selectedPatientID}?",
                                                              "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If result = DialogResult.Yes Then
                    Try
                        Using conn As MySqlConnection = dbConnection.Open()
                            Dim query As String = "DELETE FROM patients WHERE PatientId = @PatientId"
                            Dim cmd As New MySqlCommand(query, conn)
                            cmd.Parameters.AddWithValue("@PatientId", selectedPatientID)
                            cmd.ExecuteNonQuery()
                            MessageBox.Show($"Patient {selectedPatientID} has been deleted.", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            LoadPatientData() ' Refresh the data grid
                        End Using
                    Catch ex As Exception
                        MessageBox.Show($"Error deleting patient: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            Else
                MessageBox.Show("No patient selected. Please select a patient to delete.", "Delete Patient", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Sub
    End Class
End Namespace
