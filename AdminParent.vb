﻿Imports System.Windows.Forms
Imports System.Drawing

Public Class AdminParent

    ' Timer for updating date and time
    Private WithEvents timer As New Timer()

    ' Class-level variable to store the last pressed button
    Private lastPressedButton As Button = Nothing

    ' Method to show a child form in the pnl_MainPage panel
    Public Sub ShowChildForm(childForm As Form)
        ' Clear any existing controls from the panel
        pnl_MainPage.Controls.Clear()

        ' Set the child form's properties to display within the panel
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill  ' Make sure the form fills the panel

        ' Set the MDI parent relationship
        childForm.MdiParent = Me

        ' Add the child form to the panel and display it
        pnl_MainPage.Controls.Add(childForm)
        childForm.Show()
    End Sub


    ' Method to handle button clicks and dynamically load forms
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles btn_PatientList.Click, btn_AccList.Click, btn_AccReq.Click, btn_ApmntList.Click, btn_ApmntDay.Click, btn_ApmntReq.Click

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
        Me.IsMdiContainer = True

        ' Assign child forms to button Tags
        btn_PatientList.Tag = GetType(PatientTab.cf_PatientList)
        btn_AccList.Tag = GetType(AccountTab.cf_AccList)
        btn_AccReq.Tag = GetType(AccountTab.cf_AccReq)
        btn_ApmntList.Tag = GetType(ScheduleTab.cf_ApmntList)
        btn_ApmntDay.Tag = GetType(ScheduleTab.cf_ApmntDay)
        btn_ApmntReq.Tag = GetType(ScheduleTab.cf_ApmntReq)

        ' Start the timer for date and time updates
        timer.Interval = 1000 ' 1 second
        timer.Start()

        ' Set the Patient List button as "pressed" initially
        btn_PatientList.BackColor = ColorTranslator.FromHtml("#2d9364") ' Set the pressed color
        lastPressedButton = btn_PatientList ' Mark btn_PatientList as the last pressed button
        ShowChildForm(New PatientTab.cf_PatientList()) ' Show the Patient List child form by default
    End Sub

    ' Public method to switch forms programmatically
    Public Sub SwitchToForm(childForm As Form)
        ShowChildForm(childForm)
    End Sub

    Private Sub btn_Logout_Click(sender As Object, e As EventArgs) Handles btn_Logout.Click
        ' Hide the AdminParent form
        Me.Hide()

        ' Show the Login form
        Dim loginForm As New Login() ' Replace with your actual Login form name
        loginForm.Show()

        ' Optionally, close the AdminParent form if you don't want it running in the background
        ' Me.Close() ' Uncomment this line if you want to close the AdminParent form completely
    End Sub

End Class
