Public Class HomeParent
    '- SECONDS CLOCK -
    Dim WithEvents timer As New Timer()
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timer.Interval = 1000
        timer.Start()

        lbl_homeDateTime.Text = DateTime.Now.ToString("MM/dd/yyyy") & vbCrLf & DateTime.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        lbl_homeDateTime.Text = DateTime.Now.ToString("MM/dd/yyyy") & vbCrLf & DateTime.Now.ToString("HH:mm:ss")
    End Sub
    '- SECONDS CLOCK -
    '- NAV FUNCTIONS -
    Private Sub btn_Patients_Click(sender As Object, e As EventArgs) Handles btn_Patients.Click
        PatientParent.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Accounts_Click(sender As Object, e As EventArgs) Handles btn_Accounts.Click
        AccountParent.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Schedules_Click(sender As Object, e As EventArgs) Handles btn_Schedules.Click
        ScheduleParent.Show()
        Me.Hide()
    End Sub
    '- NAV FUNCTIONS -
End Class
