Imports MySql.Data.MySqlClient

Namespace ScheduleTab
    Public Class cf_ApmntReq
        Inherits Form

        ' Database connection utility
        Private dbConnection As New DBConnection()

        ' DataTable to store appointment requests
        Private appointmentRequestTable As DataTable

        Private selectedScheduleID As String

        Private Sub cf_ApmntReq_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ' Load the appointment requests into the DataGridView
            LoadAppointmentRequests()
        End Sub

        ''' <summary>
        ''' Loads the appointment requests with 'RequestStatus' = 'pending' from the database.
        ''' </summary>
        Private Sub LoadAppointmentRequests()
            Try
                Dim conn As MySqlConnection = dbConnection.Open()
                Dim query As String = "
                    SELECT 
                        s.ScheduleID,
                        CONCAT(p.FirstName, ' ', p.MiddleName, ' ', p.LastName) AS 'PatientName',
                        CONCAT('Dr. ', a.FirstName, ' ', a.MiddleName, ' ', a.LastName) AS 'DoctorName',
                        s.StartDate AS 'StartDate',
                        s.StartTime AS 'StartTime',
                        s.EndTime AS 'EndTime',
                        s.RequestStatus
                    FROM 
                        schedules s
                    INNER JOIN 
                        patients p ON s.PatientID = p.PatientId
                    INNER JOIN 
                        accounts a ON s.DoctorID = a.UserID
                    WHERE 
                        s.RequestStatus = 'pending'"

                Dim cmd As New MySqlCommand(query, conn)
                ' Fill a DataTable with query results
                Dim adapter As New MySqlDataAdapter(cmd)
                appointmentRequestTable = New DataTable()
                adapter.Fill(appointmentRequestTable)

                ' Bind the DataTable to the DataGridView
                dgv_ApmntTable.DataSource = appointmentRequestTable
            Catch ex As Exception
                Debug.WriteLine($"Error loading appointment requests: {ex.ToString()}")
                MessageBox.Show($"Error loading appointment requests: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        ''' <summary>
        ''' Handles the text change event of the search textbox to filter data in the DataGridView.
        ''' </summary>
        Private Sub txt_Search_TextChanged(sender As Object, e As EventArgs) Handles txt_Search.TextChanged
            Try
                Dim filterText As String = txt_Search.Text.Trim()

                If appointmentRequestTable IsNot Nothing Then
                    ' Construct the filter string for the original columns
                    Dim filter As String = $"PatientName LIKE '%{filterText}%' OR DoctorName LIKE '%{filterText}%'"

                    ' Add filter for StartDate (considering DateTime format as string)
                    filter &= $" OR CONVERT(StartDate, System.String) LIKE '%{filterText}%'"

                    ' Add filter for StartTime and EndTime (handling nulls by checking the values before concatenation)
                    filter &= $" OR (CONVERT(StartTime, System.String) + ' - ' + CONVERT(EndTime, System.String)) LIKE '%{filterText}%'"

                    appointmentRequestTable.DefaultView.RowFilter = filter
                End If
            Catch ex As Exception
                Debug.WriteLine($"Error filtering appointments: {ex.ToString()}")
                MessageBox.Show($"Error filtering appointments: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        ''' <summary>
        ''' Handles row selection in the DataGridView.
        ''' Updates the selectedScheduleID variable with the ID of the selected row.
        ''' </summary>
        Private Sub dgv_ApmntTable_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_ApmntTable.SelectionChanged
            If dgv_ApmntTable.CurrentRow IsNot Nothing AndAlso dgv_ApmntTable.CurrentRow.Index >= 0 Then
                Dim row As DataGridViewRow = dgv_ApmntTable.CurrentRow
                If row.Cells("ScheduleID").Value IsNot Nothing Then
                    selectedScheduleID = row.Cells("ScheduleID").Value.ToString()
                Else
                    selectedScheduleID = Nothing ' No value in ScheduleID column
                End If
            Else
                selectedScheduleID = Nothing ' No row selected
            End If
        End Sub

        ''' <summary>
        ''' Approves the selected appointment request.
        ''' </summary>
        Private Sub btn_Approve_Click(sender As Object, e As EventArgs) Handles btn_Approve.Click
            If String.IsNullOrEmpty(selectedScheduleID) Then
                MessageBox.Show("No appointment request selected. Please select a request to approve.", "Approve Appointment", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim result As DialogResult = MessageBox.Show($"Are you sure you want to approve the appointment request {selectedScheduleID}?", "Approve Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If result <> DialogResult.Yes Then Return

            Try
                ' Establish database connection
                Dim conn As MySqlConnection = dbConnection.Open()
                ' Update the status and requeststatus when approving the request
                Dim query As String = "UPDATE schedules SET RequestStatus = 'accepted', Status = 'scheduled' WHERE ScheduleID = @ScheduleID"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ScheduleID", selectedScheduleID)
                cmd.ExecuteNonQuery()

                LoadAppointmentRequests() ' Refresh the data after approval
                MessageBox.Show($"Appointment request {selectedScheduleID} has been approved and scheduled.", "Approve Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                Debug.WriteLine($"Error approving appointment request: {ex.ToString()}")
                MessageBox.Show($"Error approving appointment request: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        ''' <summary>
        ''' Rejects the selected appointment request.
        ''' </summary>
        Private Sub btn_Reject_Click(sender As Object, e As EventArgs) Handles btn_Reject.Click
            If String.IsNullOrEmpty(selectedScheduleID) Then
                MessageBox.Show("No appointment request selected. Please select a request to reject.", "Reject Appointment", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim result As DialogResult = MessageBox.Show($"Are you sure you want to reject the appointment request {selectedScheduleID}?", "Reject Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result <> DialogResult.Yes Then Return

            Try
                ' Establish database connection
                Dim conn As MySqlConnection = dbConnection.Open()
                ' Update the status and requeststatus when rejecting the request
                Dim query As String = "UPDATE schedules SET RequestStatus = 'declined', Status = 'declined' WHERE ScheduleID = @ScheduleID"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ScheduleID", selectedScheduleID)
                cmd.ExecuteNonQuery()

                LoadAppointmentRequests() ' Refresh the data after rejection
                MessageBox.Show($"Appointment request {selectedScheduleID} has been rejected and declined.", "Reject Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                Debug.WriteLine($"Error rejecting appointment request: {ex.ToString()}")
                MessageBox.Show($"Error rejecting appointment request: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub


        ''' <summary>
        ''' Refreshes the data in the DataGridView by reloading it from the database.
        ''' </summary>
        Private Sub btn_Refresh_Click(sender As Object, e As EventArgs) Handles btn_Refresh.Click
            Try
                LoadAppointmentRequests()
                MessageBox.Show("Appointment request data refreshed successfully.", "Refresh", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                Debug.WriteLine($"Error refreshing appointment request data: {ex.ToString()}")
                MessageBox.Show($"Error refreshing appointment request data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub
    End Class
End Namespace
