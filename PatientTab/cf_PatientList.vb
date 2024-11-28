Imports MySql.Data.MySqlClient

Namespace PatientTab
    Public Class cf_PatientList
        Inherits Form

        ' Database connection utility
        Private dbConnection As New DBConnection()

        Private Sub cf_PatientList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ' Load data into the existing DataGridView
            LoadPatientData()
            pnl_Popup.Visible = False ' Ensure the popup panel is hidden on load
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

        ' Switch to Add Patient form
        Private Sub btn_AddPatient_Click(sender As Object, e As EventArgs) Handles btn_AddPatient.Click
            ' Make the popup panel visible
            pnl_Popup.Visible = True

            ' Create and display Add Patient form inside the popup panel
            Dim addPatientForm As New cf_AddPatient()
            ShowChildForm(addPatientForm, pnl_Popup)
        End Sub

        ' Utility method to display child forms within the popup panel
        Private Sub ShowChildForm(childForm As Form, targetPanel As Panel)
            targetPanel.Controls.Clear() ' Clear existing controls in the popup
            childForm.TopLevel = False
            childForm.Dock = DockStyle.Fill
            targetPanel.Controls.Add(childForm)
            childForm.Show()
        End Sub
    End Class
End Namespace
