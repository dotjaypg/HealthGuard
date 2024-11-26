Public Class Home
    ' Declare the timer with WithEvents
    Dim WithEvents timer As New Timer()

    ' Custom button drawing code
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configure the timer
        timer.Interval = 1000
        timer.Start()

        ' Set the date and time on the label
        lbl_homeDateTime.Text = DateTime.Now.ToString("MM/dd/yyyy") & vbCrLf & DateTime.Now.ToString("HH:mm:ss")
    End Sub

    ' Timer event to update the date and time
    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        lbl_homeDateTime.Text = DateTime.Now.ToString("MM/dd/yyyy") & vbCrLf & DateTime.Now.ToString("HH:mm:ss")
    End Sub

    ' Handle the button click event (add logic to change background color to #2d9363)
    Private Sub btn_Home_Click(sender As Object, e As EventArgs) Handles btn_Home.Click, btn_Patients.Click, btn_Accounts.Click, btn_Schedules.Click
        ' Change the background color of the clicked button to #2d9363
        Dim clickedButton As Button = CType(sender, Button)
        clickedButton.BackColor = ColorTranslator.FromHtml("#2d9363")

        ' Optionally, you can reset the background color of other buttons to #13c18e
        ResetButtonColors(clickedButton)
    End Sub

    ' Reset the background color of all buttons except the clicked one
    Private Sub ResetButtonColors(excludeButton As Button)
        ' List of buttons to check
        Dim buttons As New List(Of Button) From {btn_Home, btn_Patients, btn_Accounts, btn_Schedules}

        ' Loop through each button and reset the background color if it is not the clicked button
        For Each btn In buttons
            If btn IsNot excludeButton Then
                btn.BackColor = ColorTranslator.FromHtml("#13c18e") ' Reset to #13c18e color
            End If
        Next
    End Sub

End Class
