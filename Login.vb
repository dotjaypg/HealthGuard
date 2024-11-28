Imports MySql.Data.MySqlClient

Public Class Login
    ' Declare the database connection object
    Private dbConnection As New DBConnection()

    Private Sub btn_LoginButton_Click(sender As Object, e As EventArgs) Handles btn_LoginButton.Click
        ' Retrieve the entered credentials
        Dim enteredUsername As String = txt_UserCred.Text.Trim()
        Dim enteredPassword As String = txt_Password.Text.Trim()

        ' Check if the input fields are filled
        If String.IsNullOrEmpty(enteredUsername) OrElse String.IsNullOrEmpty(enteredPassword) Then
            MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            ' Open the database connection
            Dim con As MySqlConnection = dbConnection.Open()

            ' SQL query to validate credentials and check role
            Dim query As String = "SELECT Role FROM accounts WHERE EmailUsername = @username AND Password = @password"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@username", enteredUsername)
            cmd.Parameters.AddWithValue("@password", enteredPassword)

            ' Execute the query and read the results
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                reader.Read()

                ' Check the user's role
                Dim userRole As String = reader("Role").ToString().ToLower()

                If userRole = "admin" Then
                    ' Access granted for admin
                    MessageBox.Show("ACCESS GRANTED", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Hide()
                    Dim adminForm As New AdminParent()
                    adminForm.Show()
                Else
                    ' Access denied for non-admin roles
                    MessageBox.Show("ACCESS DENIED", "Unauthorized", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                ' Invalid credentials
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_Password.Clear()
                txt_UserCred.Clear()
            End If

        Catch ex As Exception
            ' Handle any exceptions that occur during database interaction
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure the database connection is closed
            dbConnection.Close()
        End Try
    End Sub

    ' Prevent Enter key in txt_UserCred
    Private Sub txt_UserCred_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_UserCred.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Prevent the Enter key from doing anything
        End If
    End Sub

    ' Trigger Login button when Enter is pressed in txt_Password
    Private Sub txt_Password_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Password.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Prevent default behavior
            btn_LoginButton.PerformClick() ' Simulate button click
        End If
    End Sub
End Class


