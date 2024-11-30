Imports MySql.Data.MySqlClient

Namespace AccountTab
    Public Class cf_AccData
        Inherits Form

        ' Property to receive UserID from cf_AccList
        Public Property UserID As String

        ' Declare the shared connection
        Private conn As MySqlConnection
        Private dbConnection As New DBConnection()

        Private Sub cf_AccData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Me.StartPosition = FormStartPosition.CenterScreen
            Try
                ' Initialize and open the shared connection
                conn = dbConnection.Open()
                If Not String.IsNullOrEmpty(UserID) Then
                    LoadAccountData(UserID)
                End If
            Catch ex As Exception
                MessageBox.Show($"Error initializing connection: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub cf_AccData_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            ' Close the shared connection when the form closes
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Sub

        ''' <summary>
        ''' Fetches account data from the database based on UserID and populates the controls.
        ''' </summary>
        Private Sub LoadAccountData(userId As String)
            Try
                Dim query As String = "SELECT UserID, Role, FirstName, MiddleName, LastName, EmailUsername, 
                                       Password, ContactNumber, Status, CreationDate, PatientID, 
                                       AssignedDepartment, Specialization 
                                       FROM accounts WHERE UserID = @UserID"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@UserID", userId)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            lbl_UserID.Text = reader("UserID").ToString()
                            lbl_Role.Text = reader("Role").ToString()
                            txt_FirstName.Text = reader("FirstName").ToString()
                            txt_MiddleName.Text = reader("MiddleName").ToString()
                            txt_LastName.Text = reader("LastName").ToString()
                            txt_EmailUsername.Text = reader("EmailUsername").ToString()
                            txt_Password.Text = reader("Password").ToString()
                            txt_ContactNumber.Text = reader("ContactNumber").ToString()
                            cmb_Status.SelectedItem = reader("Status").ToString()
                            txt_CreationDate.Text = reader("CreationDate").ToString()
                            txt_PatientID.Text = reader("PatientID").ToString()
                            txt_AssignedDepartment.Text = reader("AssignedDepartment").ToString()
                            txt_Specialization.Text = reader("Specialization").ToString()
                        Else
                            MessageBox.Show("No data found for the selected user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error fetching account data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        ''' <summary>
        ''' Saves changes made to the account data back to the database.
        ''' </summary>
        Private Sub btn_SaveData_Click(sender As Object, e As EventArgs) Handles btn_SaveData.Click
            If String.IsNullOrWhiteSpace(txt_FirstName.Text) OrElse
               String.IsNullOrWhiteSpace(txt_LastName.Text) OrElse
               String.IsNullOrWhiteSpace(txt_EmailUsername.Text) Then
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Try
                Dim query As String = "UPDATE accounts SET 
                                        Role = @Role,
                                        FirstName = @FirstName,
                                        MiddleName = @MiddleName,
                                        LastName = @LastName,
                                        EmailUsername = @EmailUsername,
                                        Password = @Password,
                                        ContactNumber = @ContactNumber,
                                        Status = @Status,
                                        PatientID = @PatientID,
                                        AssignedDepartment = @AssignedDepartment,
                                        Specialization = @Specialization
                                       WHERE UserID = @UserID"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Role", lbl_Role.Text)
                    cmd.Parameters.AddWithValue("@FirstName", txt_FirstName.Text)
                    cmd.Parameters.AddWithValue("@MiddleName", txt_MiddleName.Text)
                    cmd.Parameters.AddWithValue("@LastName", txt_LastName.Text)
                    cmd.Parameters.AddWithValue("@EmailUsername", txt_EmailUsername.Text)
                    cmd.Parameters.AddWithValue("@Password", txt_Password.Text)
                    cmd.Parameters.AddWithValue("@ContactNumber", txt_ContactNumber.Text)
                    cmd.Parameters.AddWithValue("@Status", cmb_Status.SelectedItem)
                    cmd.Parameters.AddWithValue("@PatientID", txt_PatientID.Text)
                    cmd.Parameters.AddWithValue("@AssignedDepartment", txt_AssignedDepartment.Text)
                    cmd.Parameters.AddWithValue("@Specialization", txt_Specialization.Text)
                    cmd.Parameters.AddWithValue("@UserID", UserID)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Account data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("No changes were made to the account data.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error updating account data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        ''' <summary>
        ''' Resets the data in the form to the original values from the database.
        ''' </summary>
        Private Sub btn_ResetData_Click(sender As Object, e As EventArgs) Handles btn_ResetData.Click
            If Not String.IsNullOrEmpty(UserID) Then
                LoadAccountData(UserID)
            Else
                MessageBox.Show("No account data to reset.", "Reset Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Sub

        Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
            Me.Close()
        End Sub
    End Class
End Namespace
