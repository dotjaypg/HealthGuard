Imports System.Text
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
                Dim query As New StringBuilder("UPDATE accounts SET ")
                Dim parameters As New List(Of MySqlParameter)

                query.Append("Role = @Role, ")
                parameters.Add(New MySqlParameter("@Role", lbl_Role.Text))
                query.Append("FirstName = @FirstName, ")
                parameters.Add(New MySqlParameter("@FirstName", txt_FirstName.Text))
                query.Append("MiddleName = @MiddleName, ")
                parameters.Add(New MySqlParameter("@MiddleName", txt_MiddleName.Text))
                query.Append("LastName = @LastName, ")
                parameters.Add(New MySqlParameter("@LastName", txt_LastName.Text))
                query.Append("EmailUsername = @EmailUsername, ")
                parameters.Add(New MySqlParameter("@EmailUsername", txt_EmailUsername.Text))
                query.Append("Password = @Password, ")
                parameters.Add(New MySqlParameter("@Password", txt_Password.Text))
                query.Append("ContactNumber = @ContactNumber, ")
                parameters.Add(New MySqlParameter("@ContactNumber", txt_ContactNumber.Text))
                query.Append("Status = @Status ")
                parameters.Add(New MySqlParameter("@Status", cmb_Status.SelectedItem))

                ' Append fields conditionally based on Role
                If lbl_Role.Text <> "Patient" AndAlso lbl_Role.Text <> "Nurse" AndAlso lbl_Role.Text <> "Doctor" Then
                    query.Append(", PatientID = @PatientID ")
                    parameters.Add(New MySqlParameter("@PatientID", txt_PatientID.Text))
                End If

                If lbl_Role.Text <> "Patient" Then
                    query.Append(", AssignedDepartment = @AssignedDepartment ")
                    parameters.Add(New MySqlParameter("@AssignedDepartment", txt_AssignedDepartment.Text))
                    query.Append(", Specialization = @Specialization ")
                    parameters.Add(New MySqlParameter("@Specialization", txt_Specialization.Text))
                End If

                query.Append("WHERE UserID = @UserID")
                parameters.Add(New MySqlParameter("@UserID", UserID))

                ' Execute the dynamically built query
                Using cmd As New MySqlCommand(query.ToString(), conn)
                    cmd.Parameters.AddRange(parameters.ToArray())
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
