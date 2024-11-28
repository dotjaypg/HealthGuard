Namespace PatientTab
    Public Class cf_PatientData
        Inherits Form

        Private Sub cf_PatientData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Me.StartPosition = FormStartPosition.CenterScreen
        End Sub

        ''' <summary>
        ''' Hides the current form when the Back button is clicked.
        ''' </summary>
        Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
            Me.Hide()
        End Sub

        Private Sub lbl_PatientID_Click(sender As Object, e As EventArgs) Handles lbl_PatientID.Click
            ' No additional functionality needed here unless specified
        End Sub

        Private Sub btn_SaveData_Click(sender As Object, e As EventArgs) Handles btn_SaveData.Click
            ' Save data functionality here
        End Sub

        Private Sub btn_ResetData_Click(sender As Object, e As EventArgs) Handles btn_ResetData.Click
            ' Reset data functionality here
        End Sub
    End Class
End Namespace
