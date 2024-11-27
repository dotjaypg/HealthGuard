Imports System.Windows.Forms
Imports System.Drawing

Public Class AdminParent

    ' Timer for updating date and time
    Private WithEvents timer As New Timer()

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

    ' Timer tick event to update date and time
    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        If pnl_MainPage.Controls.Count > 0 Then
            Dim activeForm = pnl_MainPage.Controls(0)
            If TypeOf activeForm Is HomeTab.cf_Home Then
                Dim homeForm As HomeTab.cf_Home = CType(activeForm, HomeTab.cf_Home)
                homeForm.UpdateDateTime()
            End If
        End If
    End Sub

    ' Method to handle button clicks and dynamically load forms
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles btn_Home.Click, btn_PatientList.Click, btn_AccList.Click, btn_AccReq.Click, btn_ApmntList.Click, btn_ApmntWeek.Click, btn_ApmntDay.Click, btn_ApmntReq.Click

        ' If there is a previously pressed button, reset its background color
        If lastPressedButton IsNot Nothing Then
            lastPressedButton.BackColor = ColorTranslator.FromHtml("#13c18e") ' Default color
        End If

        ' Change the background color of the clicked button
        Dim clickedButton = CType(sender, Button)
        clickedButton.BackColor = ColorTranslator.FromHtml("#2d9364") ' Color when pressed

        ' Update the last pressed button to the current one
        lastPressedButton = clickedButton

        ' Determine the form to load using the button's Tag property
        Dim formType = CType(clickedButton.Tag, Type)
        If formType IsNot Nothing Then
            Dim childForm = CType(Activator.CreateInstance(formType), Form)
            ShowChildForm(childForm)
        End If
    End Sub

    ' Load event to set the initial button state
    Private Sub AdminParent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Assign child forms to button Tags
        btn_Home.Tag = GetType(HomeTab.cf_Home)
        btn_PatientList.Tag = GetType(PatientTab.cf_PatientList)
        btn_AccList.Tag = GetType(AccountTab.cf_AccList)
        btn_AccReq.Tag = GetType(AccountTab.cf_AccReq)
        btn_ApmntList.Tag = GetType(ScheduleTab.cf_ApmntList)
        btn_ApmntWeek.Tag = GetType(ScheduleTab.cf_Template)
        btn_ApmntDay.Tag = GetType(ScheduleTab.cf_ApmntDay)
        btn_ApmntReq.Tag = GetType(ScheduleTab.cf_ApmntReq)

        ' Start the timer for date and time updates
        timer.Interval = 1000 ' 1 second
        timer.Start()

        ' Initially set the first button (btn_Home) as "pressed"
        btn_Home.BackColor = ColorTranslator.FromHtml("#2d9364") ' Set the pressed color
        lastPressedButton = btn_Home ' Mark btn_Home as the last pressed button
        ShowChildForm(New HomeTab.cf_Home()) ' Show the Home child form by default
    End Sub

End Class
