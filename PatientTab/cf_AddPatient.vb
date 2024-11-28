Namespace PatientTab
    Public Class cf_AddPatient
        Inherits Form

        ' Go back to Patient List form
        Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
            ' Access the parent form (cf_PatientList) and hide the pnl_PopUp
            Dim parentForm = CType(Me.MdiParent, cf_PatientList)
            If parentForm IsNot Nothing Then
                parentForm.pnl_Popup.Visible = False
            End If
            Me.Close() ' Optionally, close the AddPatient form after going back
        End Sub

        Private Sub btn_ClearFields_Click(sender As Object, e As EventArgs) Handles btn_ClearFields.Click
            ' Add patient logic here (e.g., saving data to the database)
            MessageBox.Show("Fields have been cleared", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub

        Private Sub Panel29_Paint(sender As Object, e As PaintEventArgs) Handles Panel29.Paint

        End Sub
    End Class
End Namespace
