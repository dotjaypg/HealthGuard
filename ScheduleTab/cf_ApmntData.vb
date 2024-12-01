Imports System.Text
Imports MySql.Data.MySqlClient

Namespace ScheduleTab
    Public Class cf_ApmntData
        Inherits Form

        ' Property to receive ScheduleID from cf_ApmntList
        Public Property ScheduleID As String

        ' Declare the shared connection
        Private conn As MySqlConnection
        Private dbConnection As New DBConnection()

        Private Sub cf_ApmntData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Me.StartPosition = FormStartPosition.CenterScreen
            Try
                ' Initialize and open the shared connection
                conn = dbConnection.Open()
                If Not String.IsNullOrEmpty(ScheduleID) Then
                    LoadScheduleData(ScheduleID)
                End If
            Catch ex As Exception
                MessageBox.Show($"Error initializing connection: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub cf_ApmntData_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            ' Close the shared connection when the form closes
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Sub

        ''' <summary>
        ''' Fetches schedule data from the database based on ScheduleID and populates the controls.
        ''' </summary>
        Private Sub LoadScheduleData(scheduleId As String)
            Try
                Dim query As String = "SELECT s.ScheduleID, s.PatientID, s.DoctorID, s.StartDate, s.EndDate, s.AllDay, 
                               s.StartTime, s.EndTime, s.RequestStatus, s.Status, 
                               CONCAT(p.FirstName, ' ', p.MiddleName, ' ', p.LastName) AS PatientName, 
                               CONCAT('Dr. ', a.FirstName, ' ', a.MiddleName, ' ', a.LastName) AS DoctorName
                               FROM schedules s
                               LEFT JOIN patients p ON s.PatientID = p.PatientID
                               LEFT JOIN accounts a ON s.DoctorID = a.UserID
                               WHERE s.ScheduleID = @ScheduleID"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ScheduleID", scheduleId)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            lbl_ScheduleID.Text = reader("ScheduleID").ToString()
                            txt_PatientName.Text = reader("PatientName").ToString()
                            txt_DoctorName.Text = reader("DoctorName").ToString()
                            dtp_StartDate.Value = Convert.ToDateTime(reader("StartDate"))
                            cbx_AllDay.Checked = Convert.ToBoolean(reader("AllDay"))

                            ' Handle StartTime and EndTime
                            If Not IsDBNull(reader("StartTime")) Then
                                Dim startTime As TimeSpan = CType(reader("StartTime"), TimeSpan)
                                dtp_StartTime.Value = DateTime.Today.Add(startTime) ' Add TimeSpan to today's date
                            End If
                            If Not IsDBNull(reader("EndTime")) Then
                                Dim endTime As TimeSpan = CType(reader("EndTime"), TimeSpan)
                                dtp_EndTime.Value = DateTime.Today.Add(endTime)
                            End If

                            cmb_RequestStatus.SelectedItem = reader("RequestStatus").ToString()
                            txt_Status.Text = reader("Status").ToString()
                        Else
                            MessageBox.Show("No data found for the selected schedule.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error fetching schedule data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub


        ''' <summary>
        ''' Saves changes made to the schedule data back to the database.
        ''' </summary>
        Private Sub btn_SaveData_Click(sender As Object, e As EventArgs) Handles btn_SaveData.Click
            Try
                Dim query As New StringBuilder("UPDATE schedules SET ")
                Dim parameters As New List(Of MySqlParameter)

                query.Append("StartDate = @StartDate, ")
                parameters.Add(New MySqlParameter("@StartDate", dtp_StartDate.Value))

                If Not cbx_AllDay.Checked AndAlso dtp_StartTime.Checked Then
                    query.Append("StartTime = @StartTime, ")
                    parameters.Add(New MySqlParameter("@StartTime", dtp_StartTime.Value))
                End If

                If Not cbx_AllDay.Checked AndAlso dtp_EndTime.Checked Then
                    query.Append("EndTime = @EndTime, ")
                    parameters.Add(New MySqlParameter("@EndTime", dtp_EndTime.Value))
                End If

                query.Append("AllDay = @AllDay, ")
                parameters.Add(New MySqlParameter("@AllDay", cbx_AllDay.Checked))
                query.Append("RequestStatus = @RequestStatus, ")
                parameters.Add(New MySqlParameter("@RequestStatus", cmb_RequestStatus.SelectedItem))
                query.Append("Status = @Status ")
                parameters.Add(New MySqlParameter("@Status", txt_Status.Text))

                query.Append("WHERE ScheduleID = @ScheduleID")
                parameters.Add(New MySqlParameter("@ScheduleID", ScheduleID))

                ' Execute the dynamically built query
                Using cmd As New MySqlCommand(query.ToString(), conn)
                    cmd.Parameters.AddRange(parameters.ToArray())
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Schedule data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("No changes were made to the schedule data.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error updating schedule data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        ''' <summary>
        ''' Resets the data in the form to the original values from the database.
        ''' </summary>
        Private Sub btn_ResetData_Click(sender As Object, e As EventArgs) Handles btn_ResetData.Click
            If Not String.IsNullOrEmpty(ScheduleID) Then
                LoadScheduleData(ScheduleID)
            Else
                MessageBox.Show("No schedule data to reset.", "Reset Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Sub

        Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
            Me.Close()
        End Sub
    End Class
End Namespace
