Imports MySql.Data.MySqlClient

Namespace PatientTab
    Public Class cf_PatientData
        Inherits Form

        ' Property to receive PatientID from cf_PatientList
        Public Property PatientID As String

        ' Declare the shared connection
        Private conn As MySqlConnection
        Private dbConnection As New DBConnection()

        Private Sub cf_PatientData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Me.StartPosition = FormStartPosition.CenterScreen
            Try
                ' Initialize and open the shared connection
                conn = dbConnection.Open()
                If Not String.IsNullOrEmpty(PatientID) Then
                    LoadPatientData(PatientID)
                End If
            Catch ex As Exception
                MessageBox.Show($"Error initializing connection: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub cf_PatientData_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            ' Close the shared connection when the form closes
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Sub

        ''' <summary>
        ''' Fetches patient data from the database based on PatientID and populates the textboxes.
        ''' </summary>
        Private Sub LoadPatientData(patientId As String)
            Try
                Dim query As String = "SELECT PatientID, PrimaryDiagnoses, FirstName, MiddleName, LastName, Sex, 
                                       DateOfBirth, TIMESTAMPDIFF(YEAR, DateOfBirth, CURDATE()) AS Age, 
                                       BloodType, Phone, ParentGuardian, Email, Address 
                                       FROM patients WHERE PatientId = @PatientId"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@PatientId", patientId)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            lbl_PatientID.Text = reader("PatientID").ToString()
                            txt_PrimaryDiagnoses.Text = reader("PrimaryDiagnoses").ToString()
                            txt_FirstName.Text = reader("FirstName").ToString()
                            txt_MiddleName.Text = reader("MiddleName").ToString()
                            txt_LastName.Text = reader("LastName").ToString()
                            txt_Sex.Text = reader("Sex").ToString()
                            dtp_DateOfBirth.Value = DateTime.Parse(reader("DateOfBirth").ToString())
                            txt_Age.Text = reader("Age").ToString()
                            cmb_BloodType.Text = reader("BloodType").ToString()
                            txt_Phone.Text = reader("Phone").ToString()
                            txt_ParentGuardian.Text = reader("ParentGuardian").ToString()
                            txt_Email.Text = reader("Email").ToString()
                            txt_Address.Text = reader("Address").ToString()
                        Else
                            MessageBox.Show("No data found for the selected patient.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error fetching patient data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        ''' <summary>
        ''' Saves changes made to the patient data back to the database.
        ''' </summary>
        Private Sub btn_SaveData_Click(sender As Object, e As EventArgs) Handles btn_SaveData.Click
            If String.IsNullOrWhiteSpace(txt_FirstName.Text) OrElse
               String.IsNullOrWhiteSpace(txt_LastName.Text) OrElse
               String.IsNullOrWhiteSpace(txt_Sex.Text) Then
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Try
                Dim query As String = "UPDATE patients SET 
                                        PrimaryDiagnoses = @PrimaryDiagnoses,
                                        FirstName = @FirstName,
                                        MiddleName = @MiddleName,
                                        LastName = @LastName,
                                        Sex = @Sex,
                                        DateOfBirth = @DateOfBirth,
                                        BloodType = @BloodType,
                                        Phone = @Phone,
                                        ParentGuardian = @ParentGuardian,
                                        Email = @Email,
                                        Address = @Address
                                       WHERE PatientID = @PatientID"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@PrimaryDiagnoses", txt_PrimaryDiagnoses.Text)
                    cmd.Parameters.AddWithValue("@FirstName", txt_FirstName.Text)
                    cmd.Parameters.AddWithValue("@MiddleName", txt_MiddleName.Text)
                    cmd.Parameters.AddWithValue("@LastName", txt_LastName.Text)
                    cmd.Parameters.AddWithValue("@Sex", txt_Sex.Text)
                    cmd.Parameters.AddWithValue("@DateOfBirth", dtp_DateOfBirth.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@BloodType", cmb_BloodType.SelectedItem)
                    cmd.Parameters.AddWithValue("@Phone", txt_Phone.Text)
                    cmd.Parameters.AddWithValue("@ParentGuardian", txt_ParentGuardian.Text)
                    cmd.Parameters.AddWithValue("@Email", txt_Email.Text)
                    cmd.Parameters.AddWithValue("@Address", txt_Address.Text)
                    cmd.Parameters.AddWithValue("@PatientID", PatientID)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Patient data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("No changes were made to the patient data.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error updating patient data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        ''' <summary>
        ''' Resets the data in the form to the original values from the database.
        ''' </summary>
        Private Sub btn_ResetData_Click(sender As Object, e As EventArgs) Handles btn_ResetData.Click
            If Not String.IsNullOrEmpty(PatientID) Then
                LoadPatientData(PatientID)
            Else
                MessageBox.Show("No patient data to reset.", "Reset Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Sub
        Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
            Me.Close()
        End Sub
    End Class
End Namespace
