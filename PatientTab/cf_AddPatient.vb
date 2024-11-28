Namespace PatientTab
    Public Class cf_AddPatient
        Inherits Form

        ' Go back to Patient List form
        Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
            ' Access the parent form and return to the Patient List form
            Dim parentForm = CType(Me.MdiParent, AdminParent)
            If parentForm IsNot Nothing Then
                parentForm.ShowChildForm(New cf_PatientList())
            End If
        End Sub

        Private Sub btn_AddPatient_Click(sender As Object, e As EventArgs) Handles btn_AddPatient.Click
            ' Add patient logic here (e.g., saving data to the database)
            MessageBox.Show("Patient added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub
    End Class
End Namespace
