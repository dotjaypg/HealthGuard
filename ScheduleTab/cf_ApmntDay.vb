Imports MySql.Data.MySqlClient

Namespace ScheduleTab
    Public Class cf_ApmntDay
        Inherits Form

        ' Database connection utility
        Private dbConnection As New DBConnection()

        ' Full DataTable to store all today's appointment data
        Private appointmentTable As DataTable

        Private Sub cf_ApmntDay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ' Load today's appointment data into the DataGridView
            LoadAppointmentData()
        End Sub

        ''' <summary>
        ''' Loads today's appointment data from the database and formats it for display.
        ''' </summary>
        Private Sub LoadAppointmentData()
            Try
                ' Get today's date in the format 'YYYY-MM-DD'
                Dim today As String = DateTime.Now.ToString("yyyy-MM-dd")

                Using conn As MySqlConnection = dbConnection.Open()
                    Dim query As String = "
                        SELECT 
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
                            accounts a ON s.DoctorID = a.UserID
                        WHERE 
                            s.StartDate = @Today"

                    Dim cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Today", today)

                    ' Fill a DataTable with query results
                    Dim adapter As New MySqlDataAdapter(cmd)
                    appointmentTable = New DataTable()
                    adapter.Fill(appointmentTable)

                    ' Bind the DataTable to the DataGridView
                    dgv_ApmntTable.DataSource = appointmentTable
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error loading today's appointment data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        ''' <summary>
        ''' Filters the appointments displayed in the DataGridView based on the search text.
        ''' </summary>
        Private Sub txt_Search_TextChanged(sender As Object, e As EventArgs) Handles txt_Search.TextChanged
            Dim searchTerm As String = txt_Search.Text.ToLower()

            ' If the search term is empty, show all rows
            If String.IsNullOrWhiteSpace(searchTerm) Then
                dgv_ApmntTable.DataSource = appointmentTable
                Return
            End If

            ' Filter rows based on the search term
            Dim filteredRows As DataRow() = appointmentTable.Select(
                $"Date LIKE '%{searchTerm}%' OR " &
                $"Time LIKE '%{searchTerm}%' OR " &
                $"Name LIKE '%{searchTerm}%' OR " &
                $"Status LIKE '%{searchTerm}%' OR " &
                $"Doctor LIKE '%{searchTerm}%'")

            ' If matches are found, display them
            If filteredRows.Length > 0 Then
                Dim filteredTable As DataTable = filteredRows.CopyToDataTable()
                dgv_ApmntTable.DataSource = filteredTable
            Else
                ' If no matches, clear the DataGridView
                dgv_ApmntTable.DataSource = Nothing
            End If
        End Sub

        ''' <summary>
        ''' Handles the event when a cell in the DataGridView is clicked (optional for additional functionality).
        ''' </summary>
        Private Sub dgv_ApmntTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_ApmntTable.CellContentClick
            ' Optional: Add functionality if needed, such as opening an appointment details view
        End Sub
    End Class
End Namespace
