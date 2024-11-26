Imports System.Windows.Forms
Imports System.Drawing
Imports HomeTab
Imports PatientTab
Imports AccountTab
Imports ScheduleTab

Public Class AdminParent
    ' Class-level variable to store the last pressed button
    Private lastPressedButton As Button = Nothing

    ' Method to show a child form in the pnl_MainPage panel
    Private Sub ShowChildForm(childForm As Form)
        ' Clear any existing controls from the panel
        pnl_MainPage.Controls.Clear()

        ' Set the child form's properties to display within the panel
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill

        ' Add the child form to the panel and display it
        pnl_MainPage.Controls.Add(childForm)
        childForm.Show()
    End Sub

    ' Method to handle button clicks and change the background color
    Private Sub Button_Click(sender As Object, e As EventArgs)
        ' If there is a previously pressed button, reset its background color
        If lastPressedButton IsNot Nothing Then
            lastPressedButton.BackColor = ColorTranslator.FromHtml("#13c18e") ' Default color
        End If

        ' Change the background color of the clicked button
        Dim clickedButton As Button = CType(sender, Button)
        clickedButton.BackColor = ColorTranslator.FromHtml("#2d9364") ' Color when pressed

        ' Update the last pressed button to the current one
        lastPressedButton = clickedButton
    End Sub

    ' Event handlers for the buttons
    Private Sub btn_Home_Click(sender As Object, e As EventArgs) Handles btn_Home.Click
        Button_Click(sender, e)
        ShowChildForm(New HomeTab.cf_Home()) ' Show the Home child form
    End Sub

    Private Sub btn_Patient_Click(sender As Object, e As EventArgs) Handles btn_Patient.Click
        Button_Click(sender, e)
        ShowChildForm(New PatientTab.cf_PatientList()) ' Show the Patient List child form
    End Sub

    Private Sub btn_Account_Click(sender As Object, e As EventArgs) Handles btn_Account.Click
        Button_Click(sender, e)
        ShowChildForm(New AccountTab.cf_AccList()) ' Show the Account List child form
    End Sub

    Private Sub btn_Schedule_Click(sender As Object, e As EventArgs) Handles btn_Schedule.Click
        Button_Click(sender, e)
        ShowChildForm(New ScheduleTab.cf_ApmntWeek()) ' Show the Schedule Week View child form
    End Sub

    ' Load event to set the initial button state
    Private Sub AdminParent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initially set the first button (btn_Home) as "pressed"
        btn_Home.BackColor = ColorTranslator.FromHtml("#2d9364") ' Set the pressed color
        lastPressedButton = btn_Home ' Mark btn_Home as the last pressed button
        ShowChildForm(New HomeTab.cf_Home()) ' Show the Home child form by default
    End Sub

End Class
