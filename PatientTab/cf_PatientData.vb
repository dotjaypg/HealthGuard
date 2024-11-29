Imports MySql.Data.MySqlClient

Namespace PatientTab
    Public Class cf_PatientData
        Inherits Form

        ' Property to receive PatientID from cf_PatientList
        Public Property PatientID As String
        Private dbConnection As New DBConnection()

        Private Sub cf_PatientData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Me.StartPosition = FormStartPosition.CenterScreen
            If Not String.IsNullOrEmpty(PatientID) Then
                LoadPatientData(PatientID)
            End If
        End Sub

        ''' <summary>
        ''' Fetches patient data from the database based on PatientID and populates the textboxes.
        ''' </summary>
        Private Sub LoadPatientData(patientId As String)
            Try
                Using conn As MySqlConnection = dbConnection.Open()
                    Dim query As String = "SELECT PatientID, PrimaryDiagnoses, FirstName, MiddleName, LastName, Sex, 
                                           DateOfBirth, TIMESTAMPDIFF(YEAR, DateOfBirth, CURDATE()) AS Age, 
                                           BloodType, Phone, ParentGuardian, Email, Address 
                                           FROM patients WHERE PatientId = @PatientId"
                    Dim cmd As New MySqlCommand(query, conn)
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

        Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
            Me.Close()
        End Sub

        Private Sub btn_SaveData_Click(sender As Object, e As EventArgs) Handles btn_SaveData.Click

        End Sub

        Private Sub btn_ResetData_Click(sender As Object, e As EventArgs) Handles btn_ResetData.Click

        End Sub
    End Class
End Namespace
