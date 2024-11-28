Imports MySql.Data.MySqlClient

Namespace PatientTab
    Public Class cf_PatientList
        Inherits Form

        ' Database connection utility
        Private dbConnection As New DBConnection()

        Private Sub cf_PatientList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ' Load data into the existing DataGridView
            LoadPatientData()
        End Sub

        Private Sub LoadPatientData()
            Try
                Using conn As MySqlConnection = dbConnection.Open()
                    Dim query As String = "SELECT PatientId, FirstName, MiddleName, LastName, Sex, DateOfBirth FROM patients"
                    Dim cmd As New MySqlCommand(query, conn)

                    ' Fill a DataTable with query results
                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    ' Bind the DataTable to the DataGridView
                    dgv_PatientTable.DataSource = table
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error loading patient data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub txt_Search_TextChanged(sender As Object, e As EventArgs) Handles txt_Search.TextChanged

        End Sub
    End Class
End Namespace
