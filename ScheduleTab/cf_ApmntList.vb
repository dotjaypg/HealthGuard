Imports MySql.Data.MySqlClient

Namespace ScheduleTab
    Public Class cf_ApmntList
        Inherits Form

        ' Database connection utility
        Private dbConnection As New DBConnection()

        ' DataTable to store all appointment data
        Private appointmentTable As DataTable
        Private selectedScheduleID As String

        ''' <summary>
        ''' Form Load Event
        ''' </summary>
        Private Sub cf_ApmntList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            LoadAppointmentData()
        End Sub

        ''' <summary>
        ''' Loads appointment data from the database and populates the DataGridView.
        ''' </summary>
        Private Sub LoadAppointmentData()
            Try
                Using conn As MySqlConnection = dbConnection.Open()
                    Dim query As String = "
                        SELECT 
                            s.ScheduleID,
                            CASE 
                                WHEN EndDate IS NULL THEN StartDate
                                ELSE CONCAT(StartDate, ' - ', EndDate)
                            END AS 'Date',
                            CASE 
                                WHEN AllDay = '1' THEN 'All Day'
                                WHEN EndTime IS NULL THEN StartTime
                                ELSE CONCAT(StartTime, ' - ', EndTime)
                            END AS 'Time',
                            CONCAT(p.FirstName, ' ', p.MiddleName, ' ', p.LastName) AS 'Name',
                            s.Status AS 'Status',
                            CONCAT('Dr. ', a.FirstName, ' ', a.MiddleName, ' ', a.LastName) AS 'Doctor'
                        FROM 
                            schedules s
                        INNER JOIN 
                            patients p ON s.PatientID = p.PatientId
                        INNER JOIN 
                            accounts a ON s.DoctorID = a.UserID"
                    Dim cmd As New MySqlCommand(query, conn)

                    Dim adapter As New MySqlDataAdapter(cmd)
                    appointmentTable = New DataTable()
                    adapter.Fill(appointmentTable)

                    dgv_ApmntTable.DataSource = appointmentTable

                    ' Set custom headers
                    SetColumnHeaders()
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error loading appointment data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        ''' <summary>
        ''' Sets custom headers for the DataGridView columns.
        ''' </summary>
        Private Sub SetColumnHeaders()
            dgv_ApmntTable.Columns("ScheduleID").HeaderText = "Schedule ID"
            dgv_ApmntTable.Columns("Date").HeaderText = "Date"
            dgv_ApmntTable.Columns("Time").HeaderText = "Time"
            dgv_ApmntTable.Columns("Name").HeaderText = "Patient Name"
            dgv_ApmntTable.Columns("Status").HeaderText = "Status"
            dgv_ApmntTable.Columns("Doctor").HeaderText = "Doctor"
        End Sub

        ''' <summary>
        ''' Handles row selection in the DataGridView.
        ''' Updates the selectedScheduleID variable with the ID of the selected row.
        ''' </summary>
        Private Sub dgv_ApmntTable_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_ApmntTable.SelectionChanged
            If dgv_ApmntTable.CurrentRow IsNot Nothing AndAlso dgv_ApmntTable.CurrentRow.Index >= 0 Then
                Dim row As DataGridViewRow = dgv_ApmntTable.CurrentRow
                selectedScheduleID = row.Cells("ScheduleID").Value.ToString()
            Else
                selectedScheduleID = Nothing ' No row selected
            End If
        End Sub

        ''' <summary>
        ''' Displays the cf_ApmntData form with the selected ScheduleID.
        ''' </summary>
        Private Sub btn_View_Click(sender As Object, e As EventArgs) Handles btn_View.Click
            If Not String.IsNullOrEmpty(selectedScheduleID) Then
                Dim apmntDataForm As New cf_ApmntData()
                apmntDataForm.ScheduleID = selectedScheduleID ' Pass ScheduleID to cf_ApmntData
                apmntDataForm.ShowDialog()
            Else
                MessageBox.Show("No appointment selected. Please select an appointment to view.", "View Appointment", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Sub

        ''' <summary>
        ''' Deletes appointment data of the selected row when the Delete button is clicked.
        ''' </summary>
        Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click
            If String.IsNullOrEmpty(selectedScheduleID) Then
                MessageBox.Show("No appointment selected. Please select an appointment to delete.", "Delete Appointment", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim result As DialogResult = MessageBox.Show($"Are you sure you want to delete appointment {selectedScheduleID}?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result <> DialogResult.Yes Then Return

            Try
                Using conn As MySqlConnection = dbConnection.Open()
                    Dim query As String = "DELETE FROM schedules WHERE ScheduleID = @ScheduleID"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@ScheduleID", selectedScheduleID)
                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show($"Appointment {selectedScheduleID} has been deleted.", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("No rows were deleted. The appointment may not exist.", "Delete Appointment", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End Using
                End Using

                ' Refresh the data grid after deletion
                LoadAppointmentData()

            Catch ex As Exception
                MessageBox.Show($"Error deleting appointment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        ''' <summary>
        ''' Refreshes the data in the DataGridView by reloading it from the database.
        ''' </summary>
        Private Sub btn_Refresh_Click(sender As Object, e As EventArgs) Handles btn_Refresh.Click
            Try
                LoadAppointmentData() ' Reload appointment data from the database
                MessageBox.Show("Appointment data refreshed successfully.", "Refresh", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show($"Error refreshing appointment data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub
    End Class
End Namespace
