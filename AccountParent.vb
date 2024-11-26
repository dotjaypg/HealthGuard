Public Class AccountParent
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    '- NAV FUNCTIONS -
    Private Sub btn_Home_Click(sender As Object, e As EventArgs) Handles btn_Home.Click
        HomeParent.Show()
        Me.Hide()
    End Sub
    Private Sub btn_Patients_Click(sender As Object, e As EventArgs) Handles btn_Patients.Click
        PatientParent.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Schedules_Click(sender As Object, e As EventArgs) Handles btn_Schedules.Click
        ScheduleParent.Show()
        Me.Hide()
    End Sub
    '- NAV FUNCTIONS -
End Class
