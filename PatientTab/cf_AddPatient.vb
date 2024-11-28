Namespace PatientTab
    Public Class cf_AddPatient
        Inherits Form

        ' Go back to Patient List form
        Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
            ' Hide the popup panel by accessing the parent form (cf_PatientList)
            Dim parentForm = CType(Me.Parent, Panel)?.Parent
            If TypeOf parentForm Is cf_PatientList Then
                Dim patientListForm = CType(parentForm, cf_PatientList)
                patientListForm.pnl_Popup.Visible = False
            End If
        End Sub

        Private Sub btn_ClearFields_Click(sender As Object, e As EventArgs) Handles btn_ClearFields.Click
            ' Add patient logic here (e.g., saving data to the database)
            MessageBox.Show("Fields have been cleared", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub
    End Class
End Namespace
